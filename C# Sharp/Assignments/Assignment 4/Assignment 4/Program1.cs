using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Person
    {
    private string firstName;
    private string lastName;

    public Person(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public static void Display(Person person)
    {
        string upperFirstName = person.firstName.ToUpper();
        string upperLastName = person.lastName.ToUpper();

        Console.WriteLine(upperFirstName);
        Console.WriteLine(upperLastName);
    }
}

class Program1
{
    static void Main(string[] args)
    {
       
        Person person = new Person("Santhosh", "Kenchanagoudar");

        Person.Display(person);

        Console.ReadLine();
    }
}

}
