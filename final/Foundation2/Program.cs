using System;
// The program has two parts, the forst time through it you will have an address that is in the united states, the second time you will not.
// This program will greet the customer, ask what the customer wants to add to their basket, when they are done shopping the recipt will be
// displayed in the console, then the totals will be calculated.

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation2 World!");
        Products testing = new Products();
        Customer customer1 = new Customer("xX_ELITE_SHOPPER_Xx", "1234 N Street AVE", "RI", "USA");
        Address address = new Address("1234 N Street AVE", "RI", "USA");
        
        customer1.CheckCountry();
        customer1.GreetCustomer();
        if (Customer._inUSA == true)
        {
            Order order1 = new Order(5.00);
            Console.WriteLine("============Order One============");
            order1.CalculateTotal();
            
        }
        else if (Customer._inUSA == false)
        {
            Order order1 = new Order(35.00);
            Console.WriteLine("============Order One============");
            order1.CalculateTotal();
            
        }
        customer1.ThankCustomer();


        
        Customer customer2 = new Customer("John Smith", "1234 N Street AVE", "RI", "UAE");
        customer2.CheckCountry();
        customer2.GreetCustomer();
        if (Customer._inUSA == true)
        {
            Order order2 = new Order(5.00);
            Console.WriteLine("============Order Two============");
            order2.CalculateTotal();
            
        }
        else if (Customer._inUSA == false)
        {
            Order order2 = new Order(35.00);
            Console.WriteLine("============Order Two============");
            order2.CalculateTotal();
            
        }
        customer2.ThankCustomer();
    }
}