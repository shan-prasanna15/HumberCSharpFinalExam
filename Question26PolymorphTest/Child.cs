using System;
using System.Collections.Generic;
using System.Text;

namespace Question26PolymorphTest
{
    class Child : Adult
    {
        public Child(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override string ToString()
        {
            return String.Format("The Child first Name : {0} and the Last Name : {1}", this.FirstName, this.LastName);
        }
    }
}
