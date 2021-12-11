using System;
using System.Collections.Generic;

namespace NPL.Practice.T01.Problem02
{
    class Program
    {
        static private List<string> GeneraterEmailAddress(List<string> listEmployees)
        {
            List<string> listEmailFirst = new List<string>();
            List<string> listEmailAddress = new List<string>();
            foreach (var item in listEmployees)
            {
                string[] names = item.Split();
                string emailAddress = names[names.Length - 1];
                for (int i = 0; i < names.Length - 1; i++)
                {
                    emailAddress += names[i].Substring(0, 1);
                }
                listEmailAddress.Add(emailAddress);
            }
            for (int i = 0; i < listEmailFirst.Count; i++)
            {
                int index = 0;
                for (int j = 0; j < i; j++)
                {
                    if (listEmailFirst[i] == listEmailFirst[j])
                        index++;
                }
                if (index != 0)
                    listEmailAddress.Add(listEmailFirst[i] + index + "@gmail.com");
                else
                    listEmailAddress.Add(listEmailFirst[i] + "@gmail.com");

            }
            return listEmailAddress;

        }

        static void Main(string[] args)
        {
            foreach (var item in GeneraterEmailAddress(new List<string>()
            {
                "Do Tuan Anh",
                "Vu Van Hop",
                "Do Van Nghia",
                "Tuong The Hai Anh",
                "Luyen Ngoc Nam"
            }))
            {
                Console.WriteLine(item);               
            }
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
