

using StatePattern.Console.Context;

var bankAccount = new BankAccount();

Console.WriteLine(bankAccount.Balance);

bankAccount.Deposit(10000);

Console.WriteLine(bankAccount.Balance);

bankAccount.Withdraw(20000);

Console.WriteLine(bankAccount.Balance);

bankAccount.Deposit(20000);

Console.WriteLine(bankAccount.Balance);