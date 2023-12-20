using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierDist.Model.Entity
{
    public class Transaksi
    {
        public int Id_transaksi { get; set; }
        public int Id_admin { get; set; }
        public int Id_item { get; set; }
        public int Id_pelanggan { get; set; }
        public string Tanggal { get; set; }
        public int Total_barang { get; set; }
        public int Pembulatan { get; set; }
        public string Metode_pembayaran { get; set; }
        public int Total { get; set; }

    }
}
