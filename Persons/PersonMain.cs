using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class PersonsMain
{
    static void Main()
    {
        Console.Write("Eter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Enter email (optional): ");
        
        string email =Console.ReadLine();
        if (email=="")
        {
            email = null;
        }
        
        Person person = new Persons(name,age,email);
       
        
        Console.WriteLine(person);
    }
}

