using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class WorkingDogs:DecorativeDogs
    {
        private string trainer;
        private string type_of_service;

        public string Trainer { get { return trainer; } set { trainer = value; } }
        public string Type_of_service { get { return type_of_service; } set { type_of_service = value; } }

        public void Zanatie()
        {
            Console.Write("введите дрессировщика: ");
            trainer = Console.ReadLine();
            Console.Write("введите вид занятие: ");
            type_of_service = Console.ReadLine();
        }
    }
}
