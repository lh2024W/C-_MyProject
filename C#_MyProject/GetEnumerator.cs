using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__MyProject
{
    internal class GroupEnumerator(List<Car> cars) : IEnumerator
    {
        public List<Car> cars = new List<Car>();

        int position = -1;

        public void GroupEnum(List<Car> cars)
        {
            this.cars = cars;
        }
        public bool MoveNext()
        {
            position++;
            return (position < cars.Count);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return cars[position];
            }
        }
    }
}
