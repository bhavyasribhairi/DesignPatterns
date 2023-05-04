// See https://aka.ms/new-console-template for more information
using Decorator;

Console.WriteLine("Hello, World!");
Console.WriteLine("******Basic passenger car********");
BasicCar basicCar = new BasicCar();   //basic car with basic car functionalities
ICar paswithbasic = new PassengerCar(basicCar); // passenger car with basic car functionalities
paswithbasic.Design();



Console.WriteLine("***********Basic luxury car***********");
BasicCar basiccar= new BasicCar();
ICar car= new LuxuryCar(basiccar);
car.Design();

Console.WriteLine("*************Basic luxury passenger car****************");

ICar car1 = new LuxuryCar(paswithbasic);
car1.Design();




