using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__MyProject
{
    public interface IGoodsAbstractFactory
    {
        Bearings GetBearings();
        ShockAbsorbers GetShockAbsorbers();

    }
}
