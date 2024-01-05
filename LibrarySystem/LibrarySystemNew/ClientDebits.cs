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
    public partial class ClientDebits : Form
    {
        public ClientDebits()
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
        private void ClientDebits_Load(object sender, EventArgs e)
        {
            bindcombo();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text != "")
            {
                DataTable dt = new DataTable();
                dt = RetriveData.executequery("sp_customers_selectbyid", CommandType.StoredProcedure, new parameter("@cust_id", SqlDbType.Int,
                 int.Parse(comboBox1.SelectedValue.ToString())));
                remain.Text = dt.Rows[0]["cust_debit"].ToString();

            }
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
                MessageBox.Show("Please Enter Button New First", "Clients ");
                return;

            }
            if (MessageBox.Show("Are You Sure To Save This Process", "Clients", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                #region sure data
                if (payed.Text != "")
                {
                    if (double.Parse(payed.Text) > double.Parse(remain.Text))
                    {
                        MessageBox.Show("Please Enter Correct Data", "Clinets");
                        return;

                    }
                    
                }
                else
                {
                    MessageBox.Show("Please Enter Payed Value", "Clients");
                    return;
                }
                if (payed.Text == "")
                    {
                        MessageBox.Show("Please Enter Payed Value", "CLients");

                    }
                    if (remain.Text == "")
                    {
                        MessageBox.Show("Please Enter Remain Value", "Clients");

                    }
                    if (dateTxt.Text == "")
                    {
                        MessageBox.Show("Please Enter Date", "CLients");

                    }
                }
                #endregion

                #region save
                RetriveData.executeNonquery("sp_customers_account_insert", CommandType.StoredProcedure,
                       new parameter("@cust_id", SqlDbType.Int, int.Parse(comboBox1.SelectedValue.ToString())),
                       new parameter("@payed_value", SqlDbType.Decimal, decimal.Parse(payed.Text)),
                       new parameter("@datepayed", SqlDbType.DateTime, DateTime.Parse(dateTxt.Text)),
                       new parameter("@account_notes", SqlDbType.NVarChar, notes.Text),
                       new parameter("@user_id", SqlDbType.Int, login.userid));

                #endregion
                MessageBox.Show("Saved", "Clients");
                _addnew = false;
                _validate.txtclear(this, groupBox2);
                bindcombo();
            }

        private void button4_Click(object sender, EventArgs e)
        {

            RetriveData.executeNonquery("sp_cust_acc_rollback", CommandType.StoredProcedure,
                new parameter("@cust_id", SqlDbType.Int, int.Parse(comboBox1.SelectedValue.ToString())));
            MessageBox.Show("Last Process Has Been Removed", "Clients");
            _validate.txtclear(this, groupBox2);
        }

    }
    }

