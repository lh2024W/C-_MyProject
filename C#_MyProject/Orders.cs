using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__MyProject
{
    public class Orders : IEnumerable
    {
        List<Order> orders = new List<Order>();

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
            return orders.GetEnumerator();
        }

    }
}
