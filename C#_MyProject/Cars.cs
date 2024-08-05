using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__MyProject
{
    [Serializable]
    public class Cars : IEnumerable
    {
        List<Car> cars = new List<Car>();

        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return cars.GetEnumerator();
        }

    }
}
