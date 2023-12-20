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
    public class TransaksiController
    {
        public int Create(Transaksi transaksi)
        {
            int result = 0;

            if (transaksi.Id_admin == 0)
            {
                MessageBox.Show("Id transaksi harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (transaksi.Id_admin == 0)
            {
                MessageBox.Show("Id admin diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (transaksi.Id_item == 0)
            {
                MessageBox.Show("Id item harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (transaksi.Id_pelanggan == 0)
            {
                MessageBox.Show("Id pelanggan harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(transaksi.Tanggal))
            {
                MessageBox.Show("Tanggal harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(transaksi.Metode_pembayaran))
            {
                MessageBox.Show("Metode pembayaran harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }


            var transaksirepo = new TransaksiRestAPIRepo();
            result = transaksirepo.Create(transaksi);

            if (result > 0)
            {
                MessageBox.Show("Data Transaksi berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Transaksi gagal disimpan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return result;
        }

        public int Update(Transaksi transaksi)
        {
            int result = 0;

            if (transaksi.Id_transaksi == 0 || transaksi.Id_admin == 0 || transaksi.Id_item == 0 ||
                transaksi.Id_pelanggan == 0 || string.IsNullOrEmpty(transaksi.Tanggal) ||
                transaksi.Total == 0 || transaksi.Total_barang == 0 || transaksi.Pembulatan == 0 ||
                string.IsNullOrEmpty(transaksi.Metode_pembayaran))
            {
                MessageBox.Show("Semua kolom harus diisi", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            var transaksirepo = new TransaksiRestAPIRepo();
            result = transaksirepo.Create(transaksi);

            if (result > 0)
            {
                MessageBox.Show("Data Transaksi berhasil diperbarui", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Transaksi gagal diperbarui", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Transaksi transaksi)
        {
            int result = 0;

            if (transaksi.Id_transaksi == 0)
            {
                MessageBox.Show("Id Transaksi harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            var transaksirepo = new TransaksiRestAPIRepo();
            result = transaksirepo.Create(transaksi);

            if (result > 0)
            {
                MessageBox.Show("Data Transaksi berhasil dihapus", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Transaksi gagal dihapuss", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public List<Transaksi> ReadById(string id_transaksi)
        {
            List<Transaksi> list = new List<Transaksi>();
            var transaksirepo = new TransaksiRestAPIRepo();
            list = transaksirepo.ReadByNama(id_transaksi);

            return list;
        }
        public List<Transaksi> ReadAll()
        {
            List<Transaksi> list = new List<Transaksi>();
            var transaksirepo = new TransaksiRestAPIRepo();
            list = transaksirepo.ReadAll();

            return list;
        }
    }
}
