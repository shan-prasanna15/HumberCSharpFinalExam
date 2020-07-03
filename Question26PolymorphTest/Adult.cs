using System;
using System.Collections.Generic;
using System.Text;

namespace Question26PolymorphTest
{
    class Adult
    {
        public Adult(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        virtual public string FirstName { get; set; }
        virtual public string LastName { get; set; }

        public override string ToString()
        {
            return String.Format("The Adult first Name : {0} and the Last Name : {1}", this.FirstName, this.LastName);
        }
    }
}
