using App.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UI.Desktop
{
    public partial class frmArtist : Form
    {
        public frmArtist()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var da = new ArtistDA();
            // dgvListado.DataSource=da.
            lblCount.Text = da.Count().ToString();
            dgvListado.DataSource = da.Gets(txtFiltro.Text.Trim());
            dgvListado.Refresh();
            
        }
    }
}
