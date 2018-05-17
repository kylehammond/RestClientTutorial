using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClientTutorial.JsonObjects
{
    public class Person
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int age { get; set; }
        public bool isalive { get; set; }
        public Address address { get; set; }
        public List<PhoneNumber> phonenumbers { get; set; }
    }
}
