

{
     class Account
    {
        String name;
        int id;
        int amt;
        float balance = 100.00f;



        public Account(string n, int i, int am)
        {
            name = n; id = i; amt = am;

        }

        public void deposit(int amt)
        {
            balance = balance + amt;

        }

        public void withdraw(int amt)
        {
            if (amt < balance)
            {
                balance = balance - amt;
            }
            else
            { Console.WriteLine("gareeb bkl"); }
        }


        public string Disp()
        {

            return string.Format("Hello {0}, your current balance is Rs.{1}", name, balance);
        }

    }

    class User
    {
        public static void Main(string[] args)
        {
            Account a1 = new Account("pratham", 69, 6900);
            a1.withdraw(1000);


            Account a2 = new Account("pratham", 69, 6900);
            a2.deposit(1000);

            Console.WriteLine(a1.Disp());
            Console.WriteLine(a2.Disp());


        }

    }

}