namespace SportsWorldAPI.Interfaces;


//Interface for Finance model
interface IFinance
{
    int Id {get; set;}
    decimal MoneyLeft {get; set;}
    int NumberOfPurchases {get; set;}
    decimal MoneySpent {get; set;}
}