using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Dogs:WorkingDogs
    {
        private string breed;
        private string data;
        private string name;
        private string owner;

        public string Breed { get { return breed; } set { breed = value; } }
        public string Data { get { return data; } set { data = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Owner { get { return owner; } set { owner = value; } }

        public void Info()
        {
            try
            {
                Console.Write("порода собаки: ");
                breed = Console.ReadLine();
                Console.Write("дата рождения собаки: ");
                data = Console.ReadLine();
                Console.Write("кличка собаки: ");
                name = Console.ReadLine();
                Console.Write("владелец собаки: ");
                owner = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка");
            }
        }

    }
}
