using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kur_nakladnaia_Sozdanie.Model
{
    public enum TypeOfPackage { Konvert, Letter, Box }
    public enum TypeOfTarif { Door_door, Door_Sklad, Sklad_sklad, Sklad_door }
    public abstract class Kur_nakladnaia
    {
  
        public Receiver receiver { get; set; }
        public Sender sender { get; set; }

       //public void Create()
       // {


       // }


    }
}
