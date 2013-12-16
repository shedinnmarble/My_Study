using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace linqToxml
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement contacts =
    new XElement("Contacts",
        new XElement("Contact",
            new XElement("Name", "Patrick Hines"),
            new XElement("Phone", "206-555-0144",
                new XAttribute("Type", "Home")),
            new XElement("phone", "425-555-0145",
                new XAttribute("Type", "Work")),
            new XElement("Address",
                new XElement("Street1", "123 Main St"),
                new XElement("City", "Mercer Island"),
                new XElement("State", "WA"),
                new XElement("Postal", "68042")
            )
        )
    );
            contacts.Save("study.xml");
            XElement messages =
                new XElement("Messages",
                    new XElement("Message", "学习",
                        new XAttribute("SSN", "001")),
                    new XElement("Message","学习2", new XAttribute("SSN", "002")));
            Console.WriteLine(  messages.ToString());

           
            Console.ReadKey();
           
        }
    }
}
