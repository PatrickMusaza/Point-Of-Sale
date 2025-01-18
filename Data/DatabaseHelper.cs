using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Of_Sale.Data;

public class DatabaseHelper : IAsyncDisposable
{

    private readonly SQLiteAsyncConnection _connection;
    public DatabaseHelper()
    {

        var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "POS_DB.db");

        _connection = new SQLiteAsyncConnection(dbPath,
            SQLiteOpenFlags.Create | SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.SharedCache);

    }

    public async Task InitializaDatabaseAsync()
    {
        await _connection.CreateTableAsync<MenuCategory>();
        await _connection.CreateTableAsync<MenuItem>();
        await _connection.CreateTableAsync<MenuItemCategoryMapping>();
        //others

        await SeedDataAsync();

        var menuItems = await GetMenuItemsByCategoryAsync(1);
    }

    public async Task SeedDataAsync()
    {

        var firstCategory = await _connection.Table<MenuCategory>().FirstOrDefaultAsync();

        if (firstCategory != null)
            return;

        var categories = SeedData.GetMenuCategories();
        var items = SeedData.GetMenuItems();
        var mappings = SeedData.GetMenuItemCategoryMappings();

        await _connection.InsertAllAsync(categories);
        await _connection.InsertAllAsync(items);
        await _connection.InsertAllAsync(mappings);
    }

    public async Task<MenuCategory[]>GetMenuCategoriesAsync()=>
        await _connection.Table<MenuCategory>().ToArrayAsync();

    public async Task<MenuItem[]> GetMenuItemsByCategoryAsync(int categoryId)
    {
        var query = @"
                    select menu.*
                    from MenuItem as menu
                    Inner Join MenuItemCategoryMapping As mappping 
                        On menu.Id = MenuItemCategoryMapping.menuItemId
                    Where mapping.MenuCategoryId = ?
                    ";

        var menuItems = await _connection.QueryAsync<MenuItem>(query, categoryId);

        return [..menuItems];
    }

    public async ValueTask DisposeAsync()
    {
        if (_connection != null)
        {
            await _connection.CloseAsync();
        }

    }
}