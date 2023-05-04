// See https://aka.ms/new-console-template for more information
using FactoryDesignPattern;

Console.WriteLine("Hello, World!");

CreditCardFactory card = new CreditCardFactory
card.GetCreditCard("Platinum");
Console.WriteLine(card.GetCardType());
Console.WriteLine(card.GetCreditLimit());
Console.WriteLine(card.GetAnnualCharge());  
Console.WriteLine("*************");


CreditCard card1 = new CreditCardFactory.GetCreditCard("MoneyBack");
Console.WriteLine(card1.GetCardType());
Console.WriteLine(card1.GetCreditLimit());
Console.WriteLine(card1.GetAnnualCharge());
Console.WriteLine("*************");


CreditCard card2 = new CreditCardFactory.GetCreditCard("Titanium");
Console.WriteLine(card2.GetCardType());
Console.WriteLine(card2.GetCreditLimit());
Console.WriteLine(card2.GetAnnualCharge());
Console.WriteLine("*************");
