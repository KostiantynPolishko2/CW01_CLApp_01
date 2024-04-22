using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLApp.Models
{
    public class Person
    {
        public string firstName { get; set; }
        public string secondName { get; set; }

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            secondName = lastName;
        }

        public override string ToString() => $"{firstName} {secondName}";
    }
}
