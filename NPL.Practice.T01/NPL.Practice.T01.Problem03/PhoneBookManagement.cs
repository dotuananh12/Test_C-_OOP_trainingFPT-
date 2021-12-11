using System;
using System.Collections.Generic;
using System.Linq;

namespace NPL.Practice.T01.Problem03
{
    public class PhoneBookManagement
    {
        List<PhoneBook> ListPhoneBook = new List<PhoneBook>();

        public void Add()
        {
            PhoneBook phonebook = new PhoneBook();
            Console.Write("Employee Name: ");
            phonebook.Name = Console.ReadLine();
            Console.Write("Phone Number: ");
            phonebook.PhoneNumber = Console.ReadLine();
            Console.Write("Email: ");
            phonebook.Email = Console.ReadLine();
            Console.Write("Address: ");
            phonebook.Address = Console.ReadLine();
            Console.Write("Group: ");
            phonebook.Group = Console.ReadLine();
            ListPhoneBook.Add(phonebook);
        }
        public void Print(List<PhoneBook> listphone)
        {
            Console.WriteLine("Employee Name \t\t\t\tPhone Number \t\t\tEmail \t\t\tAddress \t\t\tGroup");
            foreach (var item in listphone)
            {
                Console.WriteLine("{0}\t\t\t\t{1}\t\t\t{2}\t\t\t{3}\t\t\t{4}", item.Name, item.PhoneNumber, item.Email, item.Address, item.Group);
            }
        }
        public void Display()
        {
            Print(ListPhoneBook);
        }
        public void Remove()
        {
            Console.Write("Employee Name: ");
            string name = Console.ReadLine();
            ListPhoneBook.Remove(ListPhoneBook.FirstOrDefault(x => x.Name == name));
            Display();
        }
        public void Sort()
        {
            var data = (from l in ListPhoneBook orderby l.Name select l).ToList();
            Print(data);
        }

        public void Find()
        {
            Console.Write("Employee Name: ");
            string name = Console.ReadLine();
            var data = ListPhoneBook.Where(x => x.Name == name).ToList();
            Print(data);

        }
    }
}
