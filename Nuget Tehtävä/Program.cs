using System;

namespace Nuget_Tehtävä
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Faker.Name.FullName();
            var name2 = Faker.Name.FullName();
            var name3 = Faker.Name.FullName();

            var address = Faker.Address.StreetAddress();
            var address2 = Faker.Address.StreetAddress();
            var address3 = Faker.Address.StreetAddress();

            var usPassport = Faker.Identification.UsPassportNumber();
            var usPassport2 = Faker.Identification.UsPassportNumber();
            var usPassport3 = Faker.Identification.UsPassportNumber();

            var ssn = Faker.Identification.SocialSecurityNumber();
            var ssn2 = Faker.Identification.SocialSecurityNumber();
            var ssn3 = Faker.Identification.SocialSecurityNumber();

            Console.WriteLine("Name: " + name + "\n" + "Address: " + address + "\n" + "Passport number: " + usPassport + "\n" + "Social security number: " + ssn + "\n");
            Console.WriteLine("Name: " + name2 + "\n" + "Address: " + address2 + "\n" + "Passport number: " + usPassport2 + "\n" + "Social security number: " + ssn2 + "\n");
            Console.WriteLine("Name: " + name3 + "\n" + "Address: " + address3 + "\n" + "Passport number: " + usPassport3 + "\n" + "Social security number: " + ssn3 + "\n");
        }
    }
}
