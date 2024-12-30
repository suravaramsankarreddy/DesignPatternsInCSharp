// See https://aka.ms/new-console-template for more information
using DesignPatternsInC_.src.OppPrinciples.Encapsulation;

Console.WriteLine("Hello, World!");

/*BadBankAccount bankAccount = new BadBankAccount();
bankAccount.balance = 100;

System.Console.WriteLine(bankAccount.balance);*/

BankAccount bankAccount = new BankAccount(100);

System.Console.WriteLine(bankAccount.GetBalance());

bankAccount.Deposit(130);

System.Console.WriteLine(bankAccount.GetBalance());

bankAccount.Withdraw(90);

System.Console.WriteLine(bankAccount.GetBalance());


//BankAccount bankAccount2 = new BankAccount(-100);

//bankAccount.Withdraw(-90);

System.Console.WriteLine(bankAccount.GetBalance());

