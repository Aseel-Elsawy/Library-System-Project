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
    public partial class Store : Inherit
    {
        public Store()
        {
            InitializeComponent();
        }
        bool _addnew = false;
        validation _validate = new validation();
        void bindcombo()
        {
            comboBox1.DataSource = RetriveData.executequery("sp_store_selectall", CommandType.StoredProcedure);
            comboBox1.DisplayMember = "store_name";
            comboBox1.ValueMember = "store_id";
            comboBox1.Text = "";
        }
        void bindempcombo()
        {
          comboBox2.DataSource = RetriveData.executequery("sp_employees_selectall", CommandType.StoredProcedure);
           comboBox2.DisplayMember = "emp_name";
            comboBox2.ValueMember = "emp_id";
            comboBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Are You Sure To Update This Store", "Store", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                #region suredata
                if (nametxt.Text == "")
                {
                    MessageBox.Show("Please Enter Store Name", "Store");
                    return;
                }
                #endregion
                #region save
                RetriveData.executeNonquery("sp_store_update", CommandType.StoredProcedure,
                       new parameter("@store_name", SqlDbType.NVarChar, nametxt.Text),
                        new parameter("@store_id", SqlDbType.Int, int.Parse(comboBox1.SelectedValue.ToString())),
                       new parameter("@store_address", SqlDbType.NVarChar, addtxt.Text),
                       new parameter("@emp_id", SqlDbType.Int, int.Parse(comboBox2.SelectedValue.ToString())),
                       new parameter("@store_notes", SqlDbType.NVarChar, notestxt.Text),
                       new parameter("@user_id", SqlDbType.Int, login.userid));

                #endregion
                MessageBox.Show("Updated", "Store");
                _addnew = false;
                bindcombo();

            }
        }
        private void Store_Load(object sender, EventArgs e)
        {
            bindcombo();
            bindempcombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region add
            _validate.txtclear(this, groupBox4);
            _addnew = true;

            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_addnew == false)
            {
                MessageBox.Show("Please Enter Button New First", "Store ");
                return;

            }
            if (MessageBox.Show("Are You Sure To Save This Store", "Store", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                #region suredata
                if (nametxt.Text == "")
                {
                    MessageBox.Show("Please Enter Store Name", "Store");
                    return;
                }
                #endregion
                #region save
                RetriveData.executeNonquery("sp_store_insert", CommandType.StoredProcedure,
                       new parameter("@store_name", SqlDbType.NVarChar, nametxt.Text),
                       new parameter("@store_address", SqlDbType.NVarChar, addtxt.Text),
                       new parameter("@emp_id", SqlDbType.Int, int.Parse(comboBox2.SelectedValue.ToString())),
                       new parameter("@store_notes", SqlDbType.NVarChar, notestxt.Text),
                       new parameter("@user_id", SqlDbType.Int, login.userid));

                #endregion
                MessageBox.Show("Saved", "Store");
                _addnew = false;
                _validate.txtclear(this, groupBox4);
                bindcombo();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                if (MessageBox.Show("Are You Sure To Delete This Store", "Store", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RetriveData.executeNonquery("sp_store_delete",
                        CommandType.StoredProcedure,
                        new parameter("@store_id", SqlDbType.Int, int.Parse(comboBox1.SelectedValue.ToString())));
                    //labelid.Text = "0";
                    MessageBox.Show("Deleted", "Store");
                    _validate.txtclear(this, groupBox4);
                     bindcombo();



                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                DataTable dt = new DataTable();
                dt = RetriveData.executequery("sp_select_emp_store", CommandType.StoredProcedure, new parameter("@store_id", SqlDbType.Int,
                 int.Parse(comboBox1.SelectedValue.ToString())));
                labelid.Text = dt.Rows[0][0].ToString();
                nametxt.Text = dt.Rows[0]["store_name"].ToString();
                addtxt.Text = dt.Rows[0]["store_address"].ToString();
               comboBox2.Text = dt.Rows[0]["emp_name"].ToString();
                notestxt.Text = dt.Rows[0]["store_notes"].ToString();


            }
        }
    }
}
