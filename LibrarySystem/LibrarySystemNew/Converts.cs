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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LibrarySystemNew
{
    public partial class Converts : Form
    {
        public Converts()
        {
            InitializeComponent();
        }
        bool _addnew = false;
        validation _validate = new validation();
        void bindcombo()
        {
            //items
            itmcategory.DataSource = RetriveData.executequery("sp_category_selectall", CommandType.StoredProcedure);
            itmcategory.DisplayMember = "category_name";
           itmcategory.ValueMember = "category_id";
            labelid.Text = itmcategory.Items.Count.ToString();
           itmcategory.Text = "";
            //store from
           storefrom.DataSource = RetriveData.executequery("sp_store_selectall", CommandType.StoredProcedure);
            storefrom.DisplayMember = "store_name";
            storefrom.ValueMember = "store_id";
            storefrom.Text = "";
           //store to
           storeto.DataSource = RetriveData.executequery("sp_store_selectall", CommandType.StoredProcedure);
            storeto.DisplayMember = "store_name";
            storeto.ValueMember = "store_id";
            storeto.Text = "";

        }
        void bindgrid()
        {
            dataGridView1.DataSource = RetriveData.executequery("sp_converts_selectall", CommandType.StoredProcedure);
        }
        private void Converts_Load(object sender, EventArgs e)
        {
            bindcombo();
            bindcombo();
            bindgrid();
        }

        private void itmcategory_SelectedValueChanged(object sender, EventArgs e)
        {
           

            if (int.Parse(labelid.Text)!=0)
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
        private void itmcategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void storefrom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void storefrom_SelectedValueChanged(object sender, EventArgs e)
        {
            if (itmname.Text != "" && storefrom.Text!="")
            {
                DataTable dt=RetriveData.executequery("sp_store_quantityselectquantity", CommandType.StoredProcedure,
                    new parameter("@item_id", SqlDbType.Int, int.Parse(itmname.SelectedValue.ToString())),
                     new parameter("@store_id", SqlDbType.Int, int.Parse(storefrom.SelectedValue.ToString())));
                currquantityfrom.Text = dt.Rows[0][0].ToString();

            }
        }

        private void storeto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void storeto_SelectedValueChanged(object sender, EventArgs e)
        {
            if (itmname.Text != "" && storeto.Text != "")
            {
                DataTable dt = RetriveData.executequery("sp_store_quantityselectquantity", CommandType.StoredProcedure,
                    new parameter("@item_id", SqlDbType.Int, int.Parse(itmname.SelectedValue.ToString())),
                     new parameter("@store_id", SqlDbType.Int, int.Parse(storeto.SelectedValue.ToString())));
               currentquantityto.Text = dt.Rows[0][0].ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(converted.Text)!= 0)
            {
                if (double.Parse(converted.Text) < double.Parse(currquantityfrom.Text))
                {


                    afterconverting.Text = (double.Parse(converted.Text) + double.Parse(currentquantityto.Text)).ToString();
                }
                else
                {
                    MessageBox.Show("Sorry No Enogh Quantity", "Store");
                }
            }
        }
        private void itmname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            #region add
            _validate.txtclear(this, groupBox1);
            _addnew = true;

            #endregion
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_addnew == false)
            {
                MessageBox.Show("Please Enter Button New First", "Converts ");
                return;

            }
            if (MessageBox.Show("Are You Sure To Save This Convert", "Converts", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                #region suredata
                if (afterconverting.Text == "")
                {
                    MessageBox.Show("Please Enter Correctdata", "Converts");
                    return;
                }
                #endregion
                #region save
                RetriveData.executeNonquery("sp_storeconvert_insert", CommandType.StoredProcedure,
                    new parameter("@storefrom_id", SqlDbType.NVarChar, storefrom.SelectedValue.ToString()),
                       new parameter("@storeto_id", SqlDbType.NVarChar, storeto.SelectedValue.ToString()),
                       new parameter("@item_id", SqlDbType.Int, int.Parse(itmname.SelectedValue.ToString())),
                       new parameter("@item_quantity", SqlDbType.Int, int.Parse(converted.Text)),
                       new parameter("@con_date", SqlDbType.Date,DateTime.Parse(datetxt.Text)),
                        new parameter("@user_id", SqlDbType.Int, login.userid));
#endregion
                MessageBox.Show("Saved", "Converts");
                _addnew = false;
                _validate.txtclear(this, groupBox1);
                bindcombo();
                bindgrid();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
