using System;
using System.Text;


class Person
{
    private int age;
    private string name;
    private string email;
    public string Name { get
    {
        return this.name;
    }
        set
        {
            if (value==null)
            {
                throw new ArgumentNullException("The name can not by null!");
            }
            this.name = value;
            value.Trim();
            if (value=="")
            {
                throw new ArgumentException("The name can not empty!");
            }
        }

    }
  

    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            
            if (value< 0||value>100)
            {
                throw new ArgumentOutOfRangeException(@"The ages can not ""0"" !");
            }
            this.age = value;
        }
    }
    public string Email { get
    {
        return this.email;
    }
        set
        {
            if (value!=null)
            {
                if (!value.Contains("@"))
                {
                    throw new ArgumentException(@"Email must has ""@"" !");
                }
            }
          
            this.email = value;
            
        }
    }
    public Person(string name, int age, string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }
    
    public Person(string name,int age)
    {
        this.Name = name;
        this.Age = age;
        
    }
    
    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.AppendLine(string.Format("Name: {0}\nAge: {1}", this.Name, this.Age));
        if (email!=null&&email!="")
        {
            result.AppendLine("Email: "+this.Email);
        }
        return result.ToString();
        
    }
   
}

