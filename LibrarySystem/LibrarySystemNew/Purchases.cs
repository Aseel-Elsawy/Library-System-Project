using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LibrarySystemNew.RetriveData;

namespace LibrarySystemNew
{
    public partial class Purchases : Form
    {
        public Purchases()
        {
            InitializeComponent();
        }
        bool _addnew = false;
        validation _validate = new validation();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        #region calc value
      void calculatevalue()
        {
            if (itmprice.Text == ""){
                itmprice.Text = "0";

            }
            if (quantity.Text == "")
            {
                quantity.Text = "0";

            }
            total.Text = (double.Parse(itmprice.Text) * double.Parse(quantity.Text)).ToString();

        }
        #endregion
        #region calcremainvalue
        void calcremain()
        {
            if ((double.Parse(payed.Text)) > (double.Parse(reciept.Text)))
            {
                MessageBox.Show("Please Enter Correct Data", "Purchase");
                return;

            }
            if (reciept.Text == "")
            {
                reciept.Text = "0";

            }
            if (payed.Text == "")
            {
                payed.Text = "0";

            }
            
           remain.Text = (double.Parse(reciept.Text) - double.Parse(payed.Text)).ToString();
        }
        #endregion
        #region calc total value
        void calctotalvalue()
        {
            double _total = 0;
            for (int i = 0; i <dataGridView1.Rows.Count; i++)
            {
                _total =( double.Parse(reciept.Text) + double.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString()));
                
            }
            reciept.Text = _total.ToString();
        }
        #endregion
        #region bindcombo
        void bindcombo()
        {
            vendorname.DataSource = RetriveData.executequery("sp_vendors_selectall", CommandType.StoredProcedure);
           vendorname.DisplayMember = "ven_name";
            vendorname.ValueMember = "ven_id";
           vendorname.Text = "";
            itmcategory.DataSource = RetriveData.executequery("sp_category_selectall", CommandType.StoredProcedure);
            itmcategory.DisplayMember = "category_name";
            itmcategory.ValueMember = "category_id";
            labelid.Text = itmcategory.Items.Count.ToString();
            itmcategory.Text = "";
           
            store.DataSource = RetriveData.executequery("sp_store_selectall", CommandType.StoredProcedure);
            store.DisplayMember = "store_name";
            store.ValueMember = "store_id";
            store.Text = "";
        }
        #endregion
        #region prepare data
            DataTable PrepareData()
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    DataTable dt = new DataTable();
                    DataRow dr;
                    dt.Columns.Add("category_id", typeof(int));
                    dt.Columns.Add("item_id", typeof(int));
                dt.Columns.Add("purchases_price", typeof(decimal));
                dt.Columns.Add("item_quantity", typeof(int));
                dt.Columns.Add("item_value", typeof(decimal));
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        dr = dt.NewRow();

                        dr[0] = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        dr[1] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    dr[2] = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    dr[3] = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    dr[4] = dataGridView1.Rows[i].Cells[6].Value.ToString();
                   
                    dt.Rows.Add(dr);
                    }
                    return dt;

                }
                else
                {
                    return null;
                }
            }

        #endregion

        private void Purchases_Load(object sender, EventArgs e)
        {
            bindcombo();
        }

        private void itmcategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void itmcategory_SelectedValueChanged(object sender, EventArgs e)
        {

            if (int.Parse(labelid.Text) != 0)
            {
                if (itmcategory.Text != "")
                {

                    itmname.DataSource = RetriveData.executequery("sp_itemselect_bycategoryid", CommandType.StoredProcedure,
                        new parameter("@category_id", SqlDbType.Int, int.Parse(itmcategory.SelectedValue.ToString())));
                    itmname.DisplayMember = "item_name";
                    itmname.ValueMember = "item_id";
                    itmname.Text = "";

                }
            }
        }

        private void vendorname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            if (itmcategory.Text == "")
            {
                MessageBox.Show("Please Enter Item Category", "Purchases");

            }
            if (itmname.Text=="")
            {
                MessageBox.Show("Please Enter Item Name", "Purchases");

            }
            if (quantity.Text == "")
            {
                MessageBox.Show("Please Enter Item price", "Purchases");
            }
            if (itmprice.Text=="")
            {
                MessageBox.Show("Please Enter Item price", "Purchases");
            }

            DataGridViewRow row = new DataGridViewRow();
            DataGridViewCell cell1 = new DataGridViewTextBoxCell();
            DataGridViewCell cell2 = new DataGridViewTextBoxCell();
            DataGridViewCell cell3 = new DataGridViewTextBoxCell();
            DataGridViewCell cell4 = new DataGridViewTextBoxCell();
            DataGridViewCell cell5 = new DataGridViewTextBoxCell();
            DataGridViewCell cell6 = new DataGridViewTextBoxCell();
            DataGridViewCell cell7 = new DataGridViewTextBoxCell();
            row.Cells.Add(cell1);
            row.Cells.Add(cell2);
            row.Cells.Add(cell3);
            row.Cells.Add(cell4);
            row.Cells.Add(cell5);
            row.Cells.Add(cell6);
            row.Cells.Add(cell7);
            row.Cells[0].Value = itmname.SelectedValue.ToString();
            row.Cells[1].Value =itmcategory.SelectedValue.ToString();
            row.Cells[2].Value =itmcategory.Text;
            row.Cells[3].Value = itmname.Text;
            row.Cells[4].Value = itmprice.Text;
            row.Cells[5].Value = quantity.Text;
            row.Cells[6].Value = total.Text;
            
            dataGridView1.Rows.Add(row);
            calctotalvalue();

        }

        private void itmprice_TextChanged(object sender, EventArgs e)
        {
            calculatevalue();
        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {
            calculatevalue();
        }

        private void reciept_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        DBConnect _con = new DBConnect();
        private void button3_Click(object sender, EventArgs e)
        {
            if (_addnew == false)
            {
                MessageBox.Show("Please Enter Button New First", "Converts ");
                return;

            }
            if (MessageBox.Show("Are You Sure To Save This Convert", "Converts", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataTable dt = PrepareData();
                if (dt.Rows.Count == null)
                {
                    MessageBox.Show("Please Enter Correct Data", "Purchases");
                }
                if (vendorname.Text == "")
                {
                    MessageBox.Show("Please enter Vendor Name", "Purchases");
                }
                if (datetxt.Text == "")
                {
                    MessageBox.Show("Please enter Vendor Name", "Purchases");
                }
                _con.cmd.Connection = DBConnect.con;
                _con.cmd.CommandType = CommandType.StoredProcedure;
                _con.cmd.CommandText = "sp_purchases_insert";
                _con.cmd.Parameters.AddWithValue("@ven_id", int.Parse(vendorname.SelectedValue.ToString()));
                _con.cmd.Parameters.AddWithValue("@purchases_date", DateTime.Parse(datetxt.Text));
                _con.cmd.Parameters.AddWithValue("@total_value", reciept.Text);
                _con.cmd.Parameters.AddWithValue("@payed_value", payed.Text);
                _con.cmd.Parameters.AddWithValue("@remain_value", remain.Text);
                _con.cmd.Parameters.AddWithValue("@purchases_notes", notestxt.Text);
                _con.cmd.Parameters.AddWithValue("@user_id", login.userid);
                _con.cmd.Parameters.AddWithValue("@PurchasesDataType", dt);
                _con.cmd.Parameters.AddWithValue("@store_id", int.Parse(store.SelectedValue.ToString()));
                _con.cmd.ExecuteNonQuery();
                MessageBox.Show("Saved", "Purchases");
                _addnew = false;
                _validate.txtclear(this, groupBox1);
                _validate.txtclear(this, groupBox3);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            #region add
            _validate.txtclear(this, groupBox1);
            _validate.txtclear(this, groupBox3);
            _addnew = true;

            #endregion
        }

        private void payed_TextChanged(object sender, EventArgs e)
        {
            calcremain();
        }

        private void itmprice_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void quantity_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void itmname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
