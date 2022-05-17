using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Betamart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'betamartDataSet.Betamart' table. You can move, or remove it, as needed.
            this.BetamartTableAdapter.Fill(this.betamartDataSet.Betamart);
            betamartBindingSource.DataSource = this.betamartDataSet.Betamart;
            panel.Enabled = false;
        }

        private void klmCari_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(klmCari.Text))
                {
                    this.BetamartTableAdapter.Fill(this.betamartDataSet.Betamart);
                    betamartBindingSource.DataSource = this.betamartDataSet.Betamart;
                }
                else
                {
                    var query = from o in this.betamartDataSet.Betamart
                                where o.Nama_Produk.IndexOf(klmCari.Text, StringComparison.OrdinalIgnoreCase) >= 0
                                || o.Harga_Produk == klmCari.Text
                                || o.Jumlah_Produk == klmCari.Text
                                || o.Tanggal_Masuk.Contains(klmCari.Text)
                                || o.Tanggal_Expired.Contains(klmCari.Text)
                                || o.Brand_Produk.IndexOf(klmCari.Text, StringComparison.OrdinalIgnoreCase) >= 0
                                select o;
                    betamartBindingSource.DataSource = query.ToList();
                }
            }
        }

        private void tblGambar_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                        boxGambar.Image = Image.FromFile(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                betamartBindingSource.ResetBindings(false);
            }
        }

        private void tblBaru_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Enabled = true;
                klmNama.Focus();
                this.betamartDataSet.Betamart.AddBetamartRow(this.betamartDataSet.Betamart.NewBetamartRow());
                betamartBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                betamartBindingSource.ResetBindings(false);
            }
        }

        private void tblEdit_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            klmNama.Focus();
        }

        private void tblCancel_Click(object sender, EventArgs e)
        {
            panel.Enabled = false;
            betamartBindingSource.ResetBindings(false);
        }

        private void tblSave_Click(object sender, EventArgs e)
        {
            try
            {
                betamartBindingSource.EndEdit();
                BetamartTableAdapter.Update(this.betamartDataSet.Betamart);
                this.BetamartTableAdapter.Fill(this.betamartDataSet.Betamart);
                betamartDataSet.AcceptChanges();
                panel.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                betamartBindingSource.ResetBindings(false);
            }
        }

        private void tblHapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Ingin Menghapus Produk Ini?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                betamartBindingSource.RemoveCurrent();
                BetamartTableAdapter.Update(this.betamartDataSet.Betamart);
                betamartBindingSource.EndEdit();
                betamartBindingSource.ResetBindings(false);
            }
        }
    }
}
