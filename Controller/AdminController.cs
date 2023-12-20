using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using CashierDist.Model.Entity;
using CashierDist.Model.Repository;
us

namespace CashierDist.Controller
{
    public class AdminController
    {
        //private AdminRepo adminRepo;

        public int Create(Admin admin)
        {
            int result = 0;

            //if (admin.Id_admin == 0)
            //{
            //    MessageBox.Show("Id Admin harus diisi!", "Peringatan",
            //        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return 0;
            //}

            if (string.IsNullOrEmpty(admin.Nama))
            {
                MessageBox.Show("Nama harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(admin.Alamat))
            {
                MessageBox.Show("Alamat harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(admin.Email))
            {
                MessageBox.Show("Email harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(admin.No_telp))
            {
                MessageBox.Show("Nomor telpon harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            var adminrepo = new AdminRestAPIRepo();
            result = adminrepo.Create(admin);

            if (result > 0)
            {
                MessageBox.Show("Data Admin berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Admin gagal disimpan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return result;
        }

        public int Update(Admin admin)
        {
            int result = 0;

            if (admin.Id_admin == 0 || string.IsNullOrEmpty(admin.Nama) ||
                string.IsNullOrEmpty (admin.Alamat) || string.IsNullOrEmpty(admin.Email) ||
                string.IsNullOrEmpty(admin.No_telp))
            {
                MessageBox.Show("Semua kolom harus diisi", "Peringatan", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            var adminrepo = new AdminRestAPIRepo();
            result = adminrepo.Create(admin);

            if (result > 0)
            {
                MessageBox.Show("Data Admin berhasil diperbarui", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Admin gagal diperbarui", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Admin admin)
        {
            int result = 0;

            if (admin.Id_admin == 0)
            {
                MessageBox.Show("Id Admin harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            var adminrepo = new AdminRestAPIRepo();
            result = adminrepo.Create(admin);

            if (result > 0)
            {
                MessageBox.Show("Data Admin berhasil dihapus", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Admin gagal dihapuss", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public List<Admin> ReadByNama(string nama)
        {
            List<Admin> list = new List<Admin>();
            var adminrepo = new AdminRestAPIRepo();
            list = adminrepo.ReadByNama(nama);

            return list;
        }

        public List<Admin> ReadById(int id_admin)
        {
            List<Admin> list = new List<Admin>();
            var adminrepo = new AdminRestAPIRepo();
            list = adminrepo.ReadById(id_admin);

            return list;
        }
        public List<Admin> ReadAll()
        {
            List<Admin> list = new List<Admin>();
            var adminrepo = new AdminRestAPIRepo();
            list = adminrepo.ReadAll();

            return list;
        }
    }
}
