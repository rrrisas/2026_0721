using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _2026_0721
{
    public class Person
    {
        public string Name { get; set; }
        public string Phone {  get; set; }
        public string Email { get; set; }

        public Person(string name, string phone,string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
        }
        public override string ToString()
        {
            return $"{Name}, {Phone}, {Email}";
        }
    }
}
