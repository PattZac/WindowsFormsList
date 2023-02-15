using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsList
{
    internal class Vozilo
    {
        string marka, model, vrsta, vozipo;

        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public string Vrsta { get => vrsta; set => vrsta = value; }
        public string Vozipo { get => vozipo; set => vozipo = value; }

        public Vozilo(string ma, string mo, string ve)
        {
            Marka = ma;
            Model = mo;
            Vrsta = ve;
        }
        public Vozilo()
        {
        }
        public override string ToString()
        {
            return "Marka: " + Marka + "\t | Model: " + Model + "\t | Vrsta: " + Vrsta + "\t | Vozi Po: " + Vozipo + "\r\n";
        }
    }
}
