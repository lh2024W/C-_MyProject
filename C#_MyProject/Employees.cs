using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__MyProject
{
    internal class Employees : IEnumerable // работники
    {
        List<Worker> employees = new List<Worker>();

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
            return employees.GetEnumerator();
        }

    }
}
