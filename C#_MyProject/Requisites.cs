using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__MyProject
{
    public class Requisites
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string CheckingAccount { get; set; }

        public Requisites() : this("ФОП Кравчук Л.Ю.", "г.Одесса, ул. Раскидайловская 36Б", "ЕДРПОУ 55899844 МФО 2565448 р/р 45995887445666554 ГОУ ВАТ Ощадбанк")
        {
        }
        public Requisites(string name, string address, string checkingAccount)
        {
            this.Name = name;
            this.Address = address;
            this.CheckingAccount = checkingAccount;
        }
    }
}
