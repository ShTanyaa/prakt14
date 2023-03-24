using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary1
{
    public abstract class DecorativeDogs
    {
        private string show;
        private string haircut;
        private string kol_medalei;

        public string Show { get { return show; } set { show = value; } }
        public string Haircut { get { return haircut; } set { haircut = value; } }
        public string Kol_medalei { get { return kol_medalei; } set { kol_medalei = value; } }

        public void Inform()
        {
            try
            {
                Console.Write("участие в выставках(да или нет): ");
                show = Console.ReadLine();
                Console.Write("нуждается ли собака в стрижке: ");
                haircut = Console.ReadLine();
                Console.Write("кол-во медалей у собаки: ");
                kol_medalei = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка");
            }
        }
    }
}
