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
    public partial class vendors : Inherit
    {
        public vendors()
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
        private void vendors_Load(object sender, EventArgs e)
        {
            bindcombo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_addnew == false)
            {
                MessageBox.Show("Please Enter Button New First", "Vendors ");
                return;

            }
            if (MessageBox.Show("Are You Sure To Save This Vendor", "Vendors", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                #region suredata
                if (nametxt.Text == "")
                {
                    MessageBox.Show("Please Enter Vendor Name", "Vendors");
                    return;
                }
                #endregion
                #region save
                RetriveData.executeNonquery("sp_vendors_insert", CommandType.StoredProcedure, 
                    new parameter("@ven_name", SqlDbType.NVarChar, nametxt.Text),

                       new parameter("@ven_address", SqlDbType.NVarChar, addtxt.Text),
                       new parameter("@ven_phone", SqlDbType.NVarChar, phtxt.Text),
                       new parameter("@ven_mobile", SqlDbType.NVarChar, mobtxt.Text),
                       new parameter("@ven_notes", SqlDbType.NVarChar, notestxt.Text),
                       new parameter("@ven_date", SqlDbType.DateTime, DateTime.Parse(datetxt.Text)),
                        new parameter("@user_id", SqlDbType.Int, login.userid));
                #endregion
                MessageBox.Show("Saved", "Vendors");
                _addnew = false;
                _validate.txtclear(this, groupBox6);
                bindcombo();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (labelid.Text != "")
            {
                if (MessageBox.Show("Are You Sure To Update This Vendor", "Vendors", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    #region suredata
                    if (nametxt.Text == "")
                    {
                        MessageBox.Show("Please Enter Client Name", "Clients");
                        return;
                    }
                    #endregion
                    RetriveData.executeNonquery("sp_vendors_update", CommandType.StoredProcedure,
                        new parameter("@ven_name", SqlDbType.NVarChar, nametxt.Text),
                          new parameter("@ven_id", SqlDbType.Int, int.Parse(comboBox1.SelectedValue.ToString())),
                       new parameter("@ven_address", SqlDbType.NVarChar, addtxt.Text),
                       new parameter("@ven_phone", SqlDbType.NVarChar, phtxt.Text),
                       new parameter("@ven_mobile", SqlDbType.NVarChar, mobtxt.Text),
                       new parameter("@ven_notes", SqlDbType.NVarChar, notestxt.Text),
                       new parameter("@user_id", SqlDbType.Int, login.userid),
                       new parameter("@ven_date", SqlDbType.DateTime, DateTime.Parse(datetxt.Text)));
                 //   labelid.Text = "0";
                    MessageBox.Show("Updated", "Vendors");
                    _validate.txtclear(this, groupBox6);
                    bindcombo();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "0")
            {
                if (MessageBox.Show("Are You Sure To Update This Vendors", "Vendors", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RetriveData.executeNonquery("sp_vendors_delete",
                        CommandType.StoredProcedure,
                        new parameter("@ven_id", SqlDbType.Int, int.Parse(comboBox1.SelectedValue.ToString())));
                  //  labelid.Text = "0";
                    MessageBox.Show("Deleted", "Vendors");
                    _validate.txtclear(this, groupBox6);
                    bindcombo();



                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                DataTable dt = new DataTable();
                dt = RetriveData.executequery("sp_vendors_selectbyid", CommandType.StoredProcedure, new parameter("@ven_id", SqlDbType.Int,
                 int.Parse(comboBox1.SelectedValue.ToString())));
                labelid.Text = dt.Rows[0][0].ToString();
                nametxt.Text = dt.Rows[0]["ven_name"].ToString();
                addtxt.Text = dt.Rows[0]["ven_address"].ToString();
                mobtxt.Text = dt.Rows[0]["ven_mobile"].ToString();
                phtxt.Text = dt.Rows[0]["ven_phone"].ToString();
                notestxt.Text = dt.Rows[0]["ven_notes"].ToString();
                datetxt.Text = dt.Rows[0]["ven_date"].ToString();



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region add
            _validate.txtclear(this, groupBox6);
            _addnew = true;

            #endregion
        }
    }
    }

