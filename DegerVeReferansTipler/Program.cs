using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int,decimal,float,enum,boolean value types
            int sayı1 = 10;
            int sayı2 = 30;
            sayı1 = sayı2;
            sayı2 = 65;
            //sayı1=30


            //arrays, class, interface.. reference types
            int[] sayılar1 = new int[] {1,2,3 };
            int[] sayılar2 = new int[] { 10, 20, 30 };

            sayılar1 = sayılar2;
            sayılar2[0] = 1000;
            //sayilar1[0]=1000

            //-------------------------------------------//


            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Beyza";
            person2 = person1;
            person1.FirstName = "Derin";

            Console.WriteLine(person2.FirstName);


            Customer customer = new Customer();
            customer.FirstName = "Merve";
            customer.CreditCardNumber = "3448992919";

            Employee employee = new Employee();
            employee.FirstName = "Gizem";

            Person person3 = customer;
            Console.WriteLine(person3.FirstName);

            Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);


        }
    }



    class Person 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    // base class: Person
    class Customer: Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person)

        {
            Console.WriteLine(person.FirstName);
        }
    }

}
