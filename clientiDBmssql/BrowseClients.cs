using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clientiDBmssql
{
    public partial class BrowseClients : Form
    {
        public BrowseClients()
        {
            InitializeComponent();
        }
        public theNavigationClass nc;
        private void BrowseClients_Load(object sender, EventArgs e)
        {

        }

        private void BrowseClients_Shown(object sender, EventArgs e)
        {
            nc = new theNavigationClass(this, "C:\\___\\srcmai2020B\\clientiDBmssql\\clientiDBmssql\\dbfClientiDB.mdf", "Clienti", "RUNALL");
        }
    }
}
