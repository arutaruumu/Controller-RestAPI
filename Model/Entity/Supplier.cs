using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierDist.Model.Entity
{
    public class Supplier
    {
        public int Id_supplier { get; set; }
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public string Email { get; set; }
        public string No_telp { get; set; }
    }
}
