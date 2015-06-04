using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;


class PCCatalog
{
    static void Main()
    {
        List<Component> components = new List<Component>();
        components.Add(new Component("HDD",234.43m));
        components.Add(new Component("CPU", 120.45m));
        components.Add(new Component("RAM", 45.50m));
        Computer pc = new Computer("HP",components);
        List<Computer> catalog = new List<Computer>();
        catalog.Add(pc);
        List<Component> components1 = new List<Component>();
        components1.Add(new Component("CPU", 231));
        components1.Add(new Component("Motheboard", 351));
        components1.Add(new Component("Graphics card", 351));
        Computer pc1= new Computer("Lenovo",components1);
        catalog.Add(pc1);
        List<Component> components2 = new List<Component>();
        components2.Add(new Component("CPU", 134));
        components2.Add(new Component("RAM", 123.65m,"4GB"));
        Computer pc2 = new Computer("Sony", components2);
        catalog.Add(pc2);

        var catalogSort=catalog.OrderBy(x => x.Price);

      
        foreach (var item in catalogSort)
        {
            Console.WriteLine(item);
        }
           
       
    }
}

