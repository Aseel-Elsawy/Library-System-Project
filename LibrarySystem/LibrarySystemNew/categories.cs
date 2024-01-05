using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LibrarySystemNew.RetriveData;

namespace LibrarySystemNew
{
    public partial class categories : Form
    {
        public categories()
        {
            InitializeComponent();
        }
        bool _addnew = false;
        validation _validate = new validation();
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
                MessageBox.Show("Please Enter Button New First", "Categories ");
                return;

            }
            if (MessageBox.Show("Are You Sure To Save This Category", "Categories", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                #region suredata
                if (categorytxt.Text == "")
                {
                    MessageBox.Show("Please Enter Category Name", "Categories");
                    return;
                }
                #endregion
                #region save
                RetriveData.executeNonquery("sp_category_insert", CommandType.StoredProcedure,
                       new parameter("@category_name", SqlDbType.NVarChar, categorytxt.Text),

                       new parameter("@user_id", SqlDbType.Int, login.userid));

                #endregion
                MessageBox.Show("Saved", "Categories");
                _addnew = false;
                _validate.txtclear(this, groupBox1);
                bindgrid();
                bindcombo();
                labelid.Text = comboBox1.Items.Count.ToString();

            }
        }
        #region bindgrid
        void bindgrid()
        {
            dataGridView1.DataSource = RetriveData.executequery("sp_category_selectall", CommandType.StoredProcedure);
        }
        #endregion
        #region bindcombo
        void bindcombo()
        {
            comboBox1.DataSource = RetriveData.executequery("sp_category_selectall", CommandType.StoredProcedure);
            comboBox1.DisplayMember = "category_name";
            comboBox1.ValueMember = "category_id";
            labelid.Text = comboBox1.Items.Count.ToString();
            comboBox1.Text = "";
        }
        #endregion

        private void categories_Load(object sender, EventArgs e)
        {
            bindgrid();
            bindcombo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (categorytxt.Text != "")
            {
                if (MessageBox.Show("Are You Sure To Update This Category", "Categroies", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    #region suredata
                    if (comboBox1.Text == "")
                    {
                        MessageBox.Show("Please Enter Category Name", "Categories");
                        return;
                    }
                    #endregion
                    RetriveData.executeNonquery("sp_category_update", CommandType.StoredProcedure,
                       new parameter("@category_name", SqlDbType.NVarChar, categorytxt.Text),
                        new parameter("@category_id", SqlDbType.Int, int.Parse(comboBox1.SelectedValue.ToString())),
                       new parameter("@user_id", SqlDbType.Int, login.userid));
                    labelid.Text = "0";
                    categorytxt.Text = "";
                    MessageBox.Show("Updated", "Categories");

                    bindgrid();
                    bindcombo();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                if (MessageBox.Show("Are You Sure To Delete This Category", "Categroies", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    #region suredata
                    if (comboBox1.Text == "")
                    {
                        MessageBox.Show("Please Enter Category Name", "Categories");
                        return;
                    }
                    #endregion
                    RetriveData.executeNonquery("sp_category_delete", CommandType.StoredProcedure,
                       new parameter("@category_id", SqlDbType.Int, int.Parse(comboBox1.SelectedValue.ToString())));

                    labelid.Text = "0";
                    categorytxt.Text = "";
                    MessageBox.Show("Deleted", "Categories");
                    _validate.txtclear(this, groupBox1);
                    _validate.txtclear(this, groupBox3);
                    bindgrid();
                    bindcombo();
                    labelid.Text = comboBox1.Items.Count.ToString();
                }
            }
        }



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {


            }

            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
            {
                if (int.Parse(labelid.Text) != 0)
                {
                    DataTable dt = new DataTable();
                    dt = RetriveData.executequery("sp_category_selectbyid_combo", CommandType.StoredProcedure, new parameter("@category_id", SqlDbType.Int, int.Parse(comboBox1.SelectedValue.ToString())));

                    categorytxt.Text = dt.Rows[0][0].ToString();
                }

            }
        }
    }

