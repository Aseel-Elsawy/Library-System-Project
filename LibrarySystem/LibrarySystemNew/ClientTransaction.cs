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
    public partial class ClientTransaction : Form
    {
        public ClientTransaction()
        {
            InitializeComponent();
        }
        void bindgrid()
        {
            dataGridView1.DataSource = RetriveData.executequery("sp_cust_acc_selectall", CommandType.StoredProcedure);
        }
        private void ClientTransaction_Load(object sender, EventArgs e)
        {
            bindgrid();
        }
    }
}
