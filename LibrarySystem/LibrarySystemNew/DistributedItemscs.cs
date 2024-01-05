using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LibrarySystemNew.RetriveData;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibrarySystemNew
{
    public partial class DistributedItemscs : Form
    {
        public DistributedItemscs()
        {
            InitializeComponent();
        }
        bool _addnew = false;
        #region bindcombo
        void bindcombo()
        {
           storecombobox.DataSource = RetriveData.executequery("sp_store_selectall", CommandType.StoredProcedure);
            storecombobox.DisplayMember = "store_name";
                storecombobox.ValueMember = "store_id";
            storecombobox.Text = "";
            itemcombobox.DataSource = RetriveData.executequery("sp_items_selectall", CommandType.StoredProcedure);
           itemcombobox.DisplayMember = "item_name";
            itemcombobox.ValueMember = "item_id";
           itemcombobox.Text = "";
        }
        #endregion
        private void DistributedItemscs_Load(object sender, EventArgs e)
        {
            bindcombo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            #region suredata
            if (storecombobox.Text == "")
            {
                MessageBox.Show("Please Enter Store Name","Store");
            }
            if (itemcombobox.Text == "")
            {
                MessageBox.Show("Please Enter Item Name","Store");
            }
            #endregion
            DataGridViewRow row = new DataGridViewRow();
            DataGridViewCell cell1 = new DataGridViewTextBoxCell();
            DataGridViewCell cell2 = new DataGridViewTextBoxCell();
            DataGridViewCell cell3 = new DataGridViewTextBoxCell();
            DataGridViewCell cell4 = new DataGridViewTextBoxCell();
            DataGridViewCell cell5 = new DataGridViewTextBoxCell();
            row.Cells.Add(cell1);
            row.Cells.Add(cell2);
            row.Cells.Add(cell3);
            row.Cells.Add(cell4);
            row.Cells.Add(cell5);
            row.Cells[0].Value = storecombobox.SelectedValue.ToString(); ;
            row.Cells[1].Value = itemcombobox.SelectedValue.ToString(); ;
            row.Cells[2].Value = storecombobox.Text;
            row.Cells[3].Value = itemcombobox.Text ;
            row.Cells[4].Value = quantitytxt.Text;
            dataGridView1.Rows.Add(row);
            _addnew = true;

        }
        DataTable PrepareData()
        {
            if(dataGridView1.Rows.Count>0)
            {
                DataTable dt = new DataTable();
                DataRow dr;
                dt.Columns.Add("store_id", typeof(int));
                dt.Columns.Add("item_id", typeof(int));
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dr = dt.NewRow();
                   
                    dr[0] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    dr[1] = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    dt.Rows.Add(dr);
                }
                return dt;
               
            }
            else
            {
                return null;
            }
                

                
        }
        DBConnect _con = new DBConnect();
        private void button3_Click(object sender, EventArgs e)
        {
            // distribute item byu choosing it 
            if (_addnew == false)
            {
                MessageBox.Show("Please Enter Button New First", "Store");
            }
                DataTable dt = PrepareData();
                if (dt.Rows.Count == null)
                {
                    MessageBox.Show("Please Enter Data", "Store");
                }
                _con.cmd.Connection = DBConnect.con;
                _con.cmd.CommandType = CommandType.StoredProcedure;
                _con.cmd.CommandText = "sp_storequantity_insert";
                _con.cmd.Parameters.AddWithValue("@user_id", login.userid);
                _con.cmd.Parameters.AddWithValue("@distributed_items", dt);
                _con.cmd.Parameters.AddWithValue("@quantity", int.Parse(quantitytxt.Text));
                _con.cmd.ExecuteNonQuery();
                MessageBox.Show("Saved", "Store");
                _addnew = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // distribute all items into all stores
            RetriveData.executeNonquery("sp_storequantity_auto",CommandType.StoredProcedure,
                new parameter("@user_id",SqlDbType.Int,login.userid));
            MessageBox.Show("Distribute Done", "Store");

        }

        private void storecombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
