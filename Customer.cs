using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_exam_midterm
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }

        public Customer(int id, string name, int phoneNumber)
        {
            this.Id = id;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Customer ID: {Id}, Name: {Name}, Phone: {PhoneNumber}");
        }
    }
}
