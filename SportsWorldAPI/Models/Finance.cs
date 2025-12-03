//Implementasjon av Interface
using SportsWorldAPI.Interfaces;

namespace SportsWorldAPI.Models;


// Klassen som implementerer IFinance
public class Finance : IFinance
{
    public int Id {get; set;}
    public decimal MoneyLeft {get; set;}
    public int NumberOfPurchases {get; set;}
    public decimal MoneySpent {get; set;}
}