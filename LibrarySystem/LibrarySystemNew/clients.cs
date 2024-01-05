using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LibrarySystemNew.RetriveData;

namespace LibrarySystemNew
{
    public partial class clients :Inherit
    {
        public clients()
        {
            InitializeComponent();
        }
        bool _addnew = false;
        validation _validate = new validation();
        #region binding combo
        void bindcombo()
        {
            comboBox1.DataSource = RetriveData.executequery("sp_customers_selectall", CommandType.StoredProcedure);
            comboBox1.DisplayMember = "cust_name";
            comboBox1.ValueMember = "cust_id";
            comboBox1.Text = "";
        }
        #endregion
        private void clients_Load(object sender, EventArgs e)
        {
            bindcombo();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                DataTable dt = new DataTable();
                dt = RetriveData.executequery("sp_customers_selectbyid", CommandType.StoredProcedure, new parameter("@cust_id", SqlDbType.Int,
                 int.Parse(comboBox1.SelectedValue.ToString())));
                labelid.Text = dt.Rows[0][0].ToString();
                nametxt.Text = dt.Rows[0]["cust_name"].ToString();
                addtxt.Text = dt.Rows[0]["cust_address"].ToString();
                mobtxt.Text = dt.Rows[0]["cust_mobile"].ToString();
                phtxt.Text = dt.Rows[0]["cust_phone"].ToString();
                notestxt.Text = dt.Rows[0]["cust_notes"].ToString();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_addnew == false)
            {
                MessageBox.Show("Please Enter Button New First", "Clients ");
                return;

            }
            if (MessageBox.Show("Are You Sure To Save This client", "Clients", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                #region suredata
                if (nametxt.Text == "")
                {
                    MessageBox.Show("Please Enter Client Name", "Clients");
                    return;
                }
                #endregion
                #region save
                RetriveData.executeNonquery("sp_customers_insert", CommandType.StoredProcedure, 
                       new parameter("@cust_name", SqlDbType.NVarChar, nametxt.Text),
                       new parameter("@cust_addres", SqlDbType.NVarChar, addtxt.Text),
                       new parameter("@cust_phone", SqlDbType.NVarChar, phtxt.Text),
                       new parameter("@cust_mobile", SqlDbType.NVarChar, mobtxt.Text),
                       new parameter("@cust_notes", SqlDbType.NVarChar, notestxt.Text),
                       new parameter("@user_id", SqlDbType.Int, login.userid));

                #endregion
                MessageBox.Show("Saved", "Clients");
                _addnew = false;
                _validate.txtclear(this, groupBox5);
                bindcombo();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                if (MessageBox.Show("Are You Sure To Update This client", "Clients", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    #region suredata
                    if (nametxt.Text == "")
                    {
                        MessageBox.Show("Please Enter Client Name", "Clients");
                        return;
                    }
                    #endregion
                    RetriveData.executeNonquery("sp_customers_update", CommandType.StoredProcedure, 
                        new parameter("@cust_id", SqlDbType.Int, int.Parse(comboBox1.SelectedValue.ToString())), 
                        new parameter("@cust_name", SqlDbType.NVarChar, nametxt.Text),
                       new parameter("@cust_addres", SqlDbType.NVarChar, addtxt.Text),
                       new parameter("@cust_phone", SqlDbType.NVarChar, phtxt.Text),
                       new parameter("@cust_mobile", SqlDbType.NVarChar, mobtxt.Text),
                       new parameter("@user_id", SqlDbType.Int, login.userid),
                       new parameter("@cust_notes", SqlDbType.NVarChar, notestxt.Text));
                 //   labelid.Text = "0";
                    MessageBox.Show("Updated", "Clients");
                    _validate.txtclear(this, groupBox5);
                    bindcombo();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (labelid.Text != "0")
            {
                if (MessageBox.Show("Are You Sure To Update This client", "Clients", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RetriveData.executeNonquery("sp_customers_delete",
                        CommandType.StoredProcedure,
                        new parameter("@cust_id", SqlDbType.Int, int.Parse(comboBox1.SelectedValue.ToString())));
                   // labelid.Text = "0";
                    MessageBox.Show("Deleted", "Clients");
                    _validate.txtclear(this, groupBox5);
                    bindcombo();



                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region add
            _validate.txtclear(this, groupBox5);
            _addnew = true;

            #endregion
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
