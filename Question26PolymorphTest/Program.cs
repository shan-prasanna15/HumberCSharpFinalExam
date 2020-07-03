using System;

namespace Question26PolymorphTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Adult adult1 = new Adult("Will", "Smith");
            Child child1 = new Child("Jaden", "Smith");

            Adult[] listOfHumanTypes = new Adult[2];

            listOfHumanTypes[0] = adult1;
            listOfHumanTypes[1] = child1;

            foreach(Adult typeOfHuman in listOfHumanTypes)
            {
                Console.WriteLine(typeOfHuman.ToString());
            }            
        }
    }
}
