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
    public class ItemController
    {
        public int Create(Item item)
        {
            int result = 0;

            if (item.Id_item == 0)
            {
                MessageBox.Show("Id Pelanggan harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(item.Nama))
            {
                MessageBox.Show("Nama harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (item.Harga == 0)
            {
                MessageBox.Show("Alamat harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (item.Id_supplier == 0)
            {
                MessageBox.Show("Id Supplier harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (item.Stok == 0)
            {
                MessageBox.Show("Nomor telpon harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            var itemrepo = new ItemRestAPIRepo();
            result = itemrepo.Create(item);

            if (result > 0)
            {
                MessageBox.Show("Data Item berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Item gagal disimpan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return result;
        }

        public int Update(Item item)
        {
            int result = 0;

            if (item.Id_item == 0 || string.IsNullOrEmpty(item.Nama) ||
                item.Harga == 0 || item.Id_supplier == 0 || item.Stok == 0)
            {
                MessageBox.Show("Semua kolom harus diisi", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            var itemrepo = new ItemRestAPIRepo();
            result = itemrepo.Create(item);

            if (result > 0)
            {
                MessageBox.Show("Data Item berhasil diperbarui", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Item gagal diperbarui", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Item item)
        {
            int result = 0;
                
            if (string.IsNullOrEmpty(item.Id_item))
            {
                MessageBox.Show("Id item harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            var itemrepo = new ItemRestAPIRepo();
            result = itemrepo.Create(item);

            if (result > 0)
            {
                MessageBox.Show("Data Item berhasil dihapus", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Item gagal dihapuss", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public List<Item> ReadByNama(string nama)
        {
            List<Item> list = new List<Item>();
            var itemrepo = new ItemRestAPIRepo();
            list = itemrepo.ReadByNama(nama);
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
