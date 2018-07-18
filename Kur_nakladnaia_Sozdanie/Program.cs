using Kur_nakladnaia_Sozdanie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kur_nakladnaia_Sozdanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите тип накладной? 1.Эксперсс 2.Бизнес 3.Блиц");
            int t= Int32.Parse(Console.ReadLine());
            switch (t)
            {
                case 1:
                    {

                        break;
                    }
                case 2:
                    {
                        Kur_nakl_Bissness k = new Kur_nakl_Bissness();

                        break;
                    }
                case 3:
                    {

                        break;
                    }

            
            }
           

            
        }
    }
}
