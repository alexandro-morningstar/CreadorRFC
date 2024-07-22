using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class E_RFC
    {
        //--------- Read & Write Properties ---------
        public int IdRFC { get; set; }
        public string Name { get; set; }
        public string PaternalSurname { get; set; }
        public string MaternalSurname { get; set; }
        public DateTime BirthDate { get; set; }

        //--------- Read-only Properties ---------

    }
}
