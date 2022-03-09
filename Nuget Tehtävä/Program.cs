using System;

namespace Nuget_Tehtävä
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many people?");
            
            int personCount = Convert.ToInt32(Console.ReadLine());

            var name = Faker.Name.FullName();
            var address = Faker.Address.StreetAddress();
            var usPassport = Faker.Identification.UsPassportNumber();
            var ssn = Faker.Identification.SocialSecurityNumber();

            for (int i = 0; i < personCount; i++)
            {
                Console.WriteLine("Name: " + name + "\n" + "Address: " + address + "\n" + "Passport number: " + usPassport + "\n" + "Social security number: " + ssn + "\n");
            }
        }

    }
}
