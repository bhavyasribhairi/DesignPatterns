// See https://aka.ms/new-console-template for more information
using BuilderDesignPattern;

Console.WriteLine("Hello, World!");


Beverage bever= new Beverage();
BeverageDirector beverageDirector   = new BeverageDirector();

//Making tea
TeaBuilder teaBuilder= new TeaBuilder();
beverageDirector.MakeBevarage(teaBuilder);

//Making Coffee
CoffeeBuilder coffeeBuilder= new CoffeeBuilder();
beverageDirector.MakeBevarage(coffeeBuilder);

