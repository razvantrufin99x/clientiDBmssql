namespace clientiDBmssql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowseClients bc1 = new BrowseClients();
            bc1.MdiParent = this;
            bc1.Show();

        }
    }
}