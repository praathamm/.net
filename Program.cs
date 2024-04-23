﻿// Create abstract class account having member id. name, balance
// Id is generated by application It is readonly property for ID.
// It has abstract method public abstract void withdraw(double amt);
// It has static method public static double payint(); which will return interest and increase balance if account holder has positive balance
// It has deposit method which will increase the balance.
// Write getter setter for name 
// Balance can be set only by child class.
// It has static double int_rate=0.07
// Create two child class Saving, Current
// Initialise data by calling parentclass constructor
// In saving account maintain minimum balance 1000 for this declare
// Const double minbal=1000
// In current account negative balance allowed.
// Let both child class override withdraw method.
// Create array of account class and store 2 object of saving account and current account.
// Do the transaction. When you load it should print name of bank

abstract class Account
{
    readonly int id;
    string name;
    string accountype;
    double balance;
    static getid;
        private static int count = 0;
    internal const double minbal = 1000f;



    static Account()
    {
        Console.WriteLine("Bank name");
    }

    public Account(string name, double balance, string accountype)
    {
        if (balance < minbal) { throw new Exception("Balance too low"); }
        if (count > 0) { throw new Exception("acount limit max"); }
        else
        {
            Name = name;
            Balance = balance;
            AccountType = accountype;
            id = ++count;


        }
        public void Depoist(float amt)
        {
            if (amt < 1)
            {
                throw new Exception("Cannot depoist 0 or less than Zero amount");
            }

            if (balance == 0 && amt < 1000)
            {
                Console.WriteLine("Depoist amount must be greater than 1000");
            }
            Balance += amt;
        }

         public override string ToString()
    {
        return string.Format("id:{0} name:{1} balance:{2:0.00} Type:{3}", id, name, balance, AccType);
    }



}



public string Name
{
    get { return name; }
    set
    {
        if (name.Length > 3 || name.Length < 15)
        {
            name = value;
        }
        else
        {
            throw new Exception("Invalid name");
        }
    }



    public abstract void withdraw(double amt);

}