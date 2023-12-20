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
    public class SupplierController
    {
        public int Create(Supplier supplier)
        {
            int result = 0;

            if (supplier.Id_supplier == 0)
            {
                MessageBox.Show("Id Supplier harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(supplier.Nama))
            {
                MessageBox.Show("Nama harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(supplier.Alamat))
            {
                MessageBox.Show("Alamat harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(supplier.Email))
            {
                MessageBox.Show("Email harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(supplier.No_telp))
            {
                MessageBox.Show("Nomor telpon harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            var supplierrepo = new SupplierRestAPIRepo();
            result = supplierrepo.Create(supplier);

            if (result > 0)
            {
                MessageBox.Show("Data Supplier berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Supplier gagal disimpan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return result;
        }

        public int Update(Supplier supplier)
        {
            int result = 0;

            if (supplier.Id_supplier == 0 || string.IsNullOrEmpty(supplier.Nama) ||
                string.IsNullOrEmpty(supplier.Alamat) || string.IsNullOrEmpty(supplier.Email) ||
                string.IsNullOrEmpty(supplier.No_telp))
            {
                MessageBox.Show("Semua kolom harus diisi", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            var supplierrepo = new SupplierRestAPIRepo();
            result = supplierrepo.Create(supplier);

            if (result > 0)
            {
                MessageBox.Show("Data Supplier berhasil diperbarui", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Supplier gagal diperbarui", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Supplier supplier)
        {
            int result = 0;

            if (string.IsNullOrEmpty(supplier.Nama))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            var supplierrepo = new SupplierRestAPIRepo();
            result = supplierrepo.Create(supplier);

            if (result > 0)
            {
                MessageBox.Show("Data Supplier berhasil dihapus", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Supplier gagal dihapuss", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public List<Supplier> ReadByNama(string nama)
        {
            List<Supplier> list = new List<Supplier>();
            var supplierrepo = new SupplierRestAPIRepo();
            list = supplierrepo.ReadByNama(nama);
            return list;
        }
        public List<Supplier> ReadAll()
        {
            List<Supplier> list = new List<Supplier>();
            var supplierrepo = new SupplierRestAPIRepo();
            list = supplierrepo.ReadAll();

            return list;
        }
    }
}
