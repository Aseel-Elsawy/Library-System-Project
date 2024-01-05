using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;

namespace LibrarySystemNew
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void showClientsTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
          ClientTransaction client = new ClientTransaction();
            client.MdiParent = this;
            client.Show();

        }

        private void enrollClientDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
           clients client = new clients();
            client.MdiParent = this;
            client.Show();
        }

        private void enrollVemdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vendors ven = new vendors();
            ven.MdiParent = this;
            ven.Show();
        }

        private void enrollEmployeesDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees emp = new Employees();
            emp.MdiParent = this;
            emp.Show();
        }

        private void jobTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JobType job = new JobType();
            job.MdiParent = this;
            job.Show();
        }

        private void enrollItemDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemDetails itm = new ItemDetails();
            itm.MdiParent = this;
            itm.Show();
        }

        private void enrollItemCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            categories cat = new categories();
            cat.MdiParent = this;
            cat.Show();
        }

        private void storeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Store str = new Store();
            str.MdiParent = this;
            str.Show();
        }

        private void storeConvertsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Converts con = new Converts();
            con.MdiParent = this;
            con.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void itemDistributedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DistributedItemscs ds = new DistributedItemscs();
          ds.MdiParent = this;
           ds.Show();

        }

        private void makeBuyingProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Purchases ps = new Purchases();
            ps.MdiParent = this;
            ps.Show();
        }

        private void makeSellingProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Sales sl = new Sales();
            sl.MdiParent = this;
           sl.Show();
        }

        private void clientsDebitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientDebits cl = new ClientDebits();
            cl.MdiParent = this;
           cl.Show();
        }

        private void vendorsDebitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           VendorDebit vn = new VendorDebit();
          vn.MdiParent = this;
           vn.Show();
        }

        private void showVendorTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VendorTransaction ven = new VendorTransaction();
            ven.MdiParent = this;
            ven.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
