using SQLite;


namespace Point_Of_Sale.Data;

public class MenuCategory{

    [PrimaryKey,AutoIncrement]

    public int Id {get;set;}
    public string Name {get;set;}
    public string Icon {get;set;}
    public string Color {get;set;}
    public string PrintStation {get;set;}
    public string Group {get;set;}
    public string User {get;set;}
    public DateTime DateCreated {get;set;}
    public DateTime DateUpdated {get;set;}

}

//item->category

//orders

//void

//user

//customers

//suppliers

//promotion and discounts

//sales

//sales return or refund

//purchases

//purchases return

//proforma

//inventory count

//loss and damage

/*

______ REMEMBER STATUS FOR EACH ________________

_______ DATE SEPARATED WITH TIME ________________

________ MAPPING FOR RELATED TABLES _____________

*/

// management

// cash register

//payment

//pos details (server)

//taxes

//company

//cash in/out

// transaction payment
