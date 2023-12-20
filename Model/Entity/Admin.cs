using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierDist.Model.Entity
{
    public class Admin
    {
        public int Id_admin { get; set; }
        public string Nama { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Alamat { get; set; }
        public string No_telp { get; set; }
    }
}
