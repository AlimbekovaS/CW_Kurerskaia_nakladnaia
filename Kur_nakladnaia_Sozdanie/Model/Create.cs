using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kur_nakladnaia_Sozdanie.Model
{
    public class Create
    {
        public static bool Sent(Kur_nakladnaia kur_nakl)
        {
            try
            {
                using (var db = new LiteDatabase(@"Kur_nakladnaia_Sozdanie.db"))
                {
                    LiteCollection<Kur_nakladnaia> nakl = db.GetCollection<Kur_nakladnaia>("Kur_nakladnaia");
                    nakl.Insert(kur_nakl);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.Gray;
                return false;

            }
        }
    }
}
