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

        public Person(string firstName, string secondName)
        {
            this.firstName = firstName;
            this.secondName = secondName;
        }

        public override string ToString() => $"{firstName} {secondName}";
    }
}
