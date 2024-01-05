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
    public partial class VendorDebit : Form
    {
        public VendorDebit()
        {
            InitializeComponent();
        }
        bool _addnew = false;
        validation _validate = new validation();
        #region binding combo
        void bindcombo()
        {
            comboBox1.DataSource = RetriveData.executequery("sp_vendors_selectall", CommandType.StoredProcedure);
            comboBox1.DisplayMember = "ven_name";
            comboBox1.ValueMember = "ven_id";
            comboBox1.Text = "";
        }
        #endregion
        private void button3_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text != "")
            {
                DataTable dt = new DataTable();
                dt = RetriveData.executequery("sp_vendors_selectbyid", CommandType.StoredProcedure, new parameter("@ven_id", SqlDbType.Int,
                 int.Parse(comboBox1.SelectedValue.ToString())));
                remain.Text = dt.Rows[0]["ven_debit"].ToString();

            }
        }

        private void VendorDebit_Load(object sender, EventArgs e)
        {
            bindcombo();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            #region add
            _validate.txtclear(this, groupBox2);
            _addnew = true;

            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_addnew == false)
            {
                MessageBox.Show("Please Enter Button New First", "Vendors");
                return;

            }
            if (MessageBox.Show("Are You Sure To Save This Process", "Vendors", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                #region sure data
                if (payed.Text != "")
                {
                    if (double.Parse(payed.Text) > double.Parse(remain.Text))
                    {
                        MessageBox.Show("Please Enter Correct Data", "Vendors");
                        return;

                    }

                }
                else
                {
                    MessageBox.Show("Please Enter Payed Value", "Vendors");
                    return;
                }
                if (payed.Text == "")
                {
                    MessageBox.Show("Please Enter Payed Value", "Vendors");

                }
                if (remain.Text == "")
                {
                    MessageBox.Show("Please Enter Remain Value", "Vendors");

                }
                if (dateTxt.Text == "")
                {
                    MessageBox.Show("Please Enter Date", "Vendors");

                }
            }
            #endregion

            #region save
            RetriveData.executeNonquery("sp_ven_accounts_insert", CommandType.StoredProcedure,
                   new parameter("@ven_id", SqlDbType.Int, int.Parse(comboBox1.SelectedValue.ToString())),
                   new parameter("@payed_value", SqlDbType.Decimal, decimal.Parse(payed.Text)),
                   new parameter("@payed_date", SqlDbType.DateTime, DateTime.Parse(dateTxt.Text)),
                   new parameter("@acc_notes", SqlDbType.NVarChar, notes.Text),
                   new parameter("@user_id", SqlDbType.Int, login.userid));

            #endregion
            MessageBox.Show("Saved", "Vendors");
            _addnew = false;
            _validate.txtclear(this, groupBox2);
            bindcombo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RetriveData.executeNonquery("sp_ven_accounts_rollback", CommandType.StoredProcedure,
                new parameter("@ven_id", SqlDbType.Int, int.Parse(comboBox1.SelectedValue.ToString())));
            MessageBox.Show("Last Process Has Been Removed", "Vendors");
            _validate.txtclear(this, groupBox2);


        }
    }
}
    

