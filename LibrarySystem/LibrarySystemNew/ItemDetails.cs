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
    public partial class ItemDetails : Form
    {
        public ItemDetails()
        {
            InitializeComponent();
        }
        bool _addnew = false;
        validation _validate = new validation();
        #region bindgrid
        void bindgrid()
        {
            dataGridView1.DataSource = RetriveData.executequery("sp_items_selectall", CommandType.StoredProcedure);
        }
        #endregion
        #region bindcombo
        void bindcombocategory()
        {
            itmcategory.DataSource = RetriveData.executequery("sp_category_selectall", CommandType.StoredProcedure);
            itmcategory.DisplayMember = "category_name";
            itmcategory.ValueMember = "category_id";
           // labelid.Text = itmcategory.SelectedValue.ToString();
            itmcategory.Text = "";
        }
        void bindcombo()
        {
            comboBox1.DataSource = RetriveData.executequery("sp_items_selectall", CommandType.StoredProcedure);
                comboBox1.DisplayMember = "item_name";
           comboBox1.ValueMember = "item_id";
            //labelid.Text = comboBox1.SelectedValue.ToString();
            comboBox1.Text = "";
        }
        #endregion
        private void ItemDetails_Load(object sender, EventArgs e)
        {
            bindcombocategory();
            bindgrid();
            bindcombo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            #region add
            _validate.txtclear(this, groupBox1);
            _addnew = true;

            #endregion
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_addnew == false)
            {
                MessageBox.Show("Please Enter Button New First", "Items");
                return;

            }
            if (MessageBox.Show("Are You Sure To Save This Item", "Items", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                #region suredata
                if (itmname.Text == "")
                {
                    MessageBox.Show("Please Enter Item Name", "Items");
                    return;
                }
                if (itmcategory.Text == "")
                {
                    MessageBox.Show("Please Enter Item Category", "Items");
                    return;
                }
                if (itmminimum.Text == "")
                {
                    MessageBox.Show("Please Enter Minimum", "Items");
                    return;
                }
                #endregion
                #region save
                RetriveData.executeNonquery("sp_items_insert", CommandType.StoredProcedure,
                       new parameter("@item_name", SqlDbType.NVarChar, itmname.Text),
                       new parameter("@category_id", SqlDbType.Int, int.Parse(itmcategory.SelectedValue.ToString())),
                       new parameter("@item_minimum", SqlDbType.Int, int.Parse(itmminimum.Text)),
                       new parameter("@user_id", SqlDbType.Int, login.userid));

                #endregion
                MessageBox.Show("Saved", "Items");
                _addnew = false;
                _validate.txtclear(this, groupBox1);
                bindgrid();
                bindcombo();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Are You Sure To Update This Item", "Items", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                #region suredata
                if (itmname.Text == "")
                {
                    MessageBox.Show("Please Enter Item Name", "Items");
                    return;
                }
                if (itmcategory.Text == "")
                {
                    MessageBox.Show("Please Enter Item Category", "Items");
                    return;
                }
                if (itmminimum.Text == "")
                {
                    MessageBox.Show("Please Enter Minimum", "Items");
                    return;
                }
                #endregion
                #region save
                RetriveData.executeNonquery("sp_items_Update", CommandType.StoredProcedure,
                     new parameter("@Item_id", SqlDbType.Int, int.Parse(comboBox1.SelectedValue.ToString())),
                       new parameter("@item_name", SqlDbType.NVarChar, itmname.Text),
                       new parameter("@category_id", SqlDbType.Int, int.Parse(itmcategory.SelectedValue.ToString())),
                       new parameter("@Item_minimum", SqlDbType.Int, int.Parse(itmminimum.Text)),
                       new parameter("@user_id", SqlDbType.Int, login.userid));

                #endregion
                MessageBox.Show("Saved", "Items");
                _addnew = false;
                bindgrid();
                bindcombo();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelid.Text != "0")
            {
                if (MessageBox.Show("Are You Sure To Delete This Item", "Items", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RetriveData.executeNonquery("sp_items_delete",
                        CommandType.StoredProcedure,
                        new parameter("@item_id", SqlDbType.Int, int.Parse(labelid.Text)));
                    labelid.Text = "0";
                    MessageBox.Show("Deleted", "Items");
                    _validate.txtclear(this, groupBox1);

                    bindcombo();
                    bindgrid();



                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                DataTable dt = new DataTable();
                dt = RetriveData.executequery("sp_items_selectabyid", CommandType.StoredProcedure, new parameter("@item_id", SqlDbType.Int,
                 int.Parse(comboBox1.SelectedValue.ToString())));
                labelid.Text = dt.Rows[0][0].ToString();
               itmname.Text = dt.Rows[0]["item_name"].ToString();
                itmcategory.Text = dt.Rows[0]["category_name"].ToString();
                itmminimum.Text = dt.Rows[0]["item_minimum"].ToString();
                //labelid.Text = comboBox1.SelectedValue.ToString();


            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
    }
}