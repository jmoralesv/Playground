using System.Collections;

namespace Playground;

public class CustomerManager
{
    private readonly ArrayList customers = new();

    public void AddCustomer(Customer c)
    {
        customers.Add(c);
    }

    public void ShowCustomerNames()
    {
        foreach (Customer customer in customers)
        {
            Console.WriteLine(customer.name);
        }
    }

    public void RemoveCustomer(int id)
    {
        int index = -1;

        for (int i = 0; i < customers.Count; i++)
        {
            if (customers[i] is Customer customer && customer.id == id)
            {
                index = i;
                break;
            }
        }

        if(index != -1)
        {
            customers.RemoveAt(index);
            Console.WriteLine("Customer with id " + id + " was removed.");
        }
    }
}
