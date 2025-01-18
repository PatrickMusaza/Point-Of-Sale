using SQLite;

namespace Point_Of_Sale.Data;

public class MenuItem{

    [PrimaryKey,AutoIncrement]

    public int Id {get;set;}
    public string Name {get;set;}
    public string Icon {get;set;}
   // public string Code {get;set;}
    public decimal Price {get;set;}
   // public string  Barcode {get;set;}
    public string Description {get;set;}
   /* public string Measurement {get;set;}
    public int AgeRestriction {get;set;}
    public bool Active{get;set;}
    public string User {get;set;}
    public DateTime DateCreated {get;set;}
    public DateTime DateUpdated {get;set;}
    */
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
