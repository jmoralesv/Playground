using Playground;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Playground";
        
        Console.WriteLine("Hello, World!");

        DoCustomerManagement();

        Console.ReadKey();
    }

    private static void DoCustomerManagement()
    {
        var customer1 = new Customer(1, "Jorge", 35, "Lima");
        var customer2 = new Customer(2, "Ahmeet", 18, "Turkey");

        var manager = new CustomerManager();
        manager.AddCustomer(customer1);
        manager.AddCustomer(customer2);

        manager.ShowCustomerNames();

        manager.RemoveCustomer(customer1.id);
        manager.RemoveCustomer(customer2.id);

        manager.ShowCustomerNames();
    }

    static void DoSum()
    {
        int sum = 0;

        for (int i = 1; i <= 5; i = i + 1)
        {
            sum = sum + i;
        }

        Console.WriteLine("The sum is: " + sum);
        //Console.WriteLine($"The sum is: {sum}");

        DoSomething(5);
        int x = CalculateSum(1) + 10;
    }

    static void DoSomething(int n)
    {
        Console.WriteLine("xyz");

        int sum = 0;
        for (int i = 1; i <= n; i = i + 1)
        {
            sum = sum + i;
        }

        //Console.WriteLine("The result is: " + sum);
    }

    static int CalculateSum(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i = i + 1)
        {
            sum = sum + i;
        }

        return sum;
    }

    static (int, int) CalculateSum(int n, int x)
    {
        int sum = 0;
        int i;
        for (i = 1; i <= n; i = i + 1)
        {
            sum = sum + i;
        }

        return (sum, i);
    }

    static void DoXYZ(int a, int b, int c)
    {
        for (int i = 0; i < a; i++)
        {

        }

        while (true)
        {

        }
    }
}