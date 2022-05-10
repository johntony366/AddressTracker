using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DemoLibrary
{
    public static class Save
    { 
        public static void ToTextFile(PersonModel person)
        {
            string addressText = "";
            for (int i = 0; i < person.Addresses.Count; i++)
            {
                addressText += person.Addresses[i].AddressValue + "\n";
            }

            File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\peopleInfo.txt", $"{person.FirstName} {person.LastName}\nIs Active: {person.IsActive}\nAddresses:\n{addressText}\n");
        }
    }
}
