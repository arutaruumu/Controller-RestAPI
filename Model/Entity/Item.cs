using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierDist.Model.Entity
{
    public class Item
    {
        public int Id_item { get; set; }
        public string Nama { get; set; }
        public int Harga { get; set; }
        public int Id_supplier { get; set; }
        public int Stok { get; set; }
    }
}
