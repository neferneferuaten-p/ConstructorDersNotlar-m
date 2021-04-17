using System;

namespace constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id = 1, FirstName = "oğuzhan", LastName = "Gül", City = "Sakarya" }; // *1*
            Customer customer2 = new Customer(2, "Ali", "asaadasad", "Newyork");

            Console.WriteLine(customer1.FirstName);
        }

        
    }

    class Customer
    {   
        public Customer ()
        {
            // Bu satırı *1* ile işaretlenmiş satırı çalıştırmak için yazmak zorundayız
        }
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName; // newledikmi  yazsakta yazmasakta çalışır       // özellik barındıran class türünü gördük
            LastName = lastName;
            City = city;

        }



        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
