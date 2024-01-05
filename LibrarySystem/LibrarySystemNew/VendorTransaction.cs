using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystemNew
{
    public partial class VendorTransaction : Form
    {
        public VendorTransaction()
        {
            InitializeComponent();
        }
        void bindgrid()
        {
            dataGridView1.DataSource = RetriveData.executequery("sp_venAcc_selectall", CommandType.StoredProcedure);
        }
        private void VendorTransaction_Load(object sender, EventArgs e)
        {
            bindgrid();
        }
    }
}
