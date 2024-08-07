using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__MyProject
{
    public class NippartsFactory : IGoodsAbstractFactory
    {
        public Bearings GetBearings () 
        { 
            return new NippartsBearings ("Подшипники", "Задний мост", "14,61 мм", "14,73 мм", "39,88 мм", 
                "50,29 мм", "17,46 мм", "29 мм"); 
        }

        public ShockAbsorbers GetShockAbsorbers()
        {
            return new NippartsShockAbsorbers("Амортизатор", "Задний", "Двухсторонний", "Газооливковый", 1, "1 год или 25000 км", "2 года или 70000км");
        }
    }
}
