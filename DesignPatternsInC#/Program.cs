// See https://aka.ms/new-console-template for more information
using DesignPatternsInC_.src.OppPrinciples.Abstraction;
using DesignPatternsInC_.src.OppPrinciples.Coupling;
using DesignPatternsInC_.src.OppPrinciples.Encapsulation;
using DesignPatternsInC_.src.OppPrinciples.Inheritance;
using DesignPatternsInC_.src.OppPrinciples.Polymorphism;

Console.WriteLine("Hello, World!");

//Encapsulation 


/*BadBankAccount bankAccount = new BadBankAccount();
bankAccount.balance = 100;

System.Console.WriteLine(bankAccount.balance);

BankAccount bankAccount = new BankAccount(100);

System.Console.WriteLine(bankAccount.GetBalance());

bankAccount.Deposit(130);

System.Console.WriteLine(bankAccount.GetBalance());

bankAccount.Withdraw(90);

System.Console.WriteLine(bankAccount.GetBalance());


//BankAccount bankAccount2 = new BankAccount(-100);

//bankAccount.Withdraw(-90);

System.Console.WriteLine(bankAccount.GetBalance()); */

/*

//Abstraction - Reduce the Complexity by hiding un-nececeary details

//if any changes to the flow we have make changes in in between the existing code it's a bad practice
BadEmailService emailService = new BadEmailService();
emailService.Connect();
emailService.Authenticate();
emailService.SendEmail();
emailService.Disconnect();


//Good Practice - no need to call all the methods/actions
EmailService goodEmailService = new EmailService();
goodEmailService.SendEmail();


//Inheritance

DesignPatternsInC_.src.OppPrinciples.Inheritance.Car car = new DesignPatternsInC_.src.OppPrinciples.Inheritance.Car();

//Shared
car.Brand = "BMW";
car.Start();
car.Stop();

//Unique
car.NumberOfDoors = 4; 
*/

//Polymorphism

/*
List<object> vehicles = new List<object>();
vehicles.Add(new DesignPatternsInC_.src.OppPrinciples.Polymorphism.Car { Brand = "Suzuki", Model = "AW", NumberOfDoors = 4 });
vehicles.Add(new MotorCycle {Brand = "Royal", Model = "TR", Year =2024});

Console.WriteLine(vehicles.Count());

foreach(var vehicle in vehicles)
{
    if(vehicle is DesignPatternsInC_.src.OppPrinciples.Polymorphism.Car)
    {   
        var car = (DesignPatternsInC_.src.OppPrinciples.Polymorphism.Car)vehicle;
        car.Start();
    }

    else if(vehicle is MotorCycle)
    {
        var motorCycle = (MotorCycle)vehicle;
        motorCycle.Stop();
    }
}

List<DesignPatternsInC_.src.OppPrinciples.Polymorphism.Vehicle> vehicles1 = new List<DesignPatternsInC_.src.OppPrinciples.Polymorphism.Vehicle>();
vehicles.Add(new DesignPatternsInC_.src.OppPrinciples.Polymorphism.Car { Brand = "Suzuki", Model = "AW", NumberOfDoors = 4 });
vehicles.Add(new MotorCycle {Brand = "Royal", Model = "TR", Year =2024});

foreach (var vehicle in vehicles1)
{
    vehicle.Start();
}

*/

//Coupling

/*dOrder order = new BadOrder();
order.PlaceOrder();

Order order1 = new Order(new EmailSender());
order1.PlaceOrder();

Order order2 = new Order(new SmsSender());
order1.PlaceOrder();
*/

//Compostion

/*DesignPatternsInC_.src.OppPrinciples.Composition.Car car = new DesignPatternsInC_.src.OppPrinciples.Composition.Car();
car.StartCar();
*/

//Liskov Substitution Principle

