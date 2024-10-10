using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiLatihanTiga3
{
    public partial class frmLetihanTiga3 : Form
    {
        public frmLetihanTiga3()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var nama = txtNama.Text;
            var pendidikan = cmbPendidikan.Text;
            var pekerjaan = lstPekerjaan.Text;

            txtPesan1.Text = string.Format("Halo {0}", nama);
            txtPesan2.Text = string.Format("Pendidikan Andan {0} ya?", pendidikan);
            txtPesan3.Text = string.Format("Anda seorang {0}. hebat !!!", pekerjaan);
        }

        private void lstPekerjaan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}//23.11.5787
