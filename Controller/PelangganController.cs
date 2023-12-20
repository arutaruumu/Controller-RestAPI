
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CashierDist.Model.Entity;
using CashierDist.Model.Repository;
using CashierDist.Model.Context;

namespace CashierDist.Controller
{
    public class PelangganController
    {
        public int Create(Pelanggan pelanggan)
        {
            int result = 0;

            if (pelanggan.Id_pelanggan == 0)
            {
                MessageBox.Show("Id Pelanggan harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(pelanggan.Nama))
            {
                MessageBox.Show("Nama harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(pelanggan.Alamat))
            {
                MessageBox.Show("Alamat harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(pelanggan.Email))
            {
                MessageBox.Show("Email harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(pelanggan.No_telp))
            {
                MessageBox.Show("Nomor telpon harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            var pelangganrepo = new PelangganRestAPIRepo();
            result = pelangganrepo.Create(pelanggan);

            if (result > 0)
            {
                MessageBox.Show("Data Pelanggan berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Pelanggan gagal disimpan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return result;
        }

        public int Update(Pelanggan pelanggan)
        {
            int result = 0;

            if (pelanggan.Id_pelanggan == 0 || string.IsNullOrEmpty(pelanggan.Nama) ||
                string.IsNullOrEmpty(pelanggan.Alamat) || string.IsNullOrEmpty(pelanggan.Email) ||
                string.IsNullOrEmpty(pelanggan.No_telp))
            {
                MessageBox.Show("Semua kolom harus diisi", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            var pelangganrepo = new PelangganRestAPIRepo();
            result = pelangganrepo.Create(pelanggan);

            if (result > 0)
            {
                MessageBox.Show("Data Pelanggan berhasil diperbarui", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Pelanggan gagal diperbarui", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Pelanggan pelanggan)
        {
            int result = 0;

            if (string.IsNullOrEmpty(pelanggan.Nama))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            var pelangganrepo = new PelangganRestAPIRepo();
            result = pelangganrepo.Create(pelanggan);

            if (result > 0)
            {
                MessageBox.Show("Data Pelanggan berhasil dihapus", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Pelanggan gagal dihapuss", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public List<Pelanggan> ReadByNama(string nama)
        {
            List<Pelanggan> list = new List<Pelanggan>();
            var pelangganrepo = new PelangganRestAPIRepo();
            list = pelangganrepo.ReadByNama(nama);
            return list;
        }
        public List<Pelanggan> ReadAll()
        {
            List<Pelanggan> list = new List<Pelanggan>();
            var pelangganrepo = new PelangganRestAPIRepo();
            list = pelangganrepo.ReadAll();

            return list;
        }
    }
}
