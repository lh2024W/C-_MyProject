using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__MyProject
{
    public abstract class Transport
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string LicensePlate { get; set; }

        public override string ToString()
        {
            return "Бренд: " + Brand + ' ' + "Модель: " + Model + ' ' + "Год выпуска: " + Year + ' '
                + "Номерной знак: " + LicensePlate + ' ';
        }
    }
}
