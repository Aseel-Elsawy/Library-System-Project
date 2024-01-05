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
    public partial class Employees : Inherit
    {
        public Employees()
        {
            InitializeComponent();
        }
        bool _addnew = false;
        validation _validate = new validation();
        void bindcombo()
        {
            comboBox1.DataSource = RetriveData.executequery("sp_employees_selectall", CommandType.StoredProcedure);
            comboBox1.DisplayMember = "emp_name";
            comboBox1.ValueMember = "emp_id";
            comboBox1.Text = "";
        }
        void bindjobcombo()
        {
            jobcombo.DataSource = RetriveData.executequery("sp_jobs_selectall", CommandType.StoredProcedure);
            jobcombo.DisplayMember = "job_name";
            jobcombo.ValueMember = "job_id";
            jobcombo.Text = "";
        }
        private void Employees_Load(object sender, EventArgs e)
        {
            bindcombo();
            bindjobcombo();
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
                MessageBox.Show("Please Enter Button New First", "Employees ");
                return;

            }
            if (MessageBox.Show("Are You Sure To Save This Employee", "Employees", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                #region suredata
                if (nametxt.Text == "")
                {
                    MessageBox.Show("Please Enter Employee Name", "Employees");
                    return;
                }
                #endregion
                #region save
                RetriveData.executeNonquery("sp_employee_insert", CommandType.StoredProcedure,
                       new parameter("@emp_name", SqlDbType.NVarChar, nametxt.Text),
                       new parameter("@emp_address", SqlDbType.NVarChar, addtxt.Text),
                       new parameter("@emp_phone", SqlDbType.NVarChar, phtxt.Text),
                       new parameter("@emp_mobile", SqlDbType.NVarChar, mobtxt.Text),
                       new parameter("@personal_id", SqlDbType.NVarChar, personalid.Text),
                       new parameter("@basic_salary", SqlDbType.NVarChar, basicsalary.Text),
                       new parameter("@job_id", SqlDbType.Int, int.Parse(jobcombo.SelectedValue.ToString())),
                       new parameter("@user_id", SqlDbType.Int, login.userid));

                #endregion
                MessageBox.Show("Saved", "Employees");
                _addnew = false;
                _validate.txtclear(this, groupBox4);
                bindcombo();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Save This Employee", "Employees", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                #region suredata
                if (nametxt.Text == "")
                {
                    MessageBox.Show("Please Enter Employee Name", "Employees");
                    return;
                }
                #endregion
                #region save
                RetriveData.executeNonquery("sp_employees_update", CommandType.StoredProcedure,
                       new parameter("@emp_name", SqlDbType.NVarChar, nametxt.Text),
                       new parameter("@emp_address", SqlDbType.NVarChar, addtxt.Text),
                       new parameter("@emp_phone", SqlDbType.NVarChar, phtxt.Text),
                       new parameter("@emp_mobile", SqlDbType.NVarChar, mobtxt.Text),
                       new parameter("@personal_id", SqlDbType.NVarChar, personalid.Text),
                       new parameter("@basic_salary", SqlDbType.NVarChar, basicsalary.Text),
                      new parameter("@job_id", SqlDbType.Int, int.Parse(jobcombo.SelectedValue.ToString())),
                        new parameter("@emp_id", SqlDbType.Int, int.Parse(comboBox1.SelectedValue.ToString())),
                       new parameter("@user_id", SqlDbType.Int, login.userid));

                #endregion
                MessageBox.Show("Saved", "Employees");
                _addnew = false;
                _validate.txtclear(this, groupBox4);
                bindcombo();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                if (MessageBox.Show("Are You Sure To Delete This Employee", "Employees", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RetriveData.executeNonquery("sp_employees_delete",
                        CommandType.StoredProcedure,
                        new parameter("@emp_id", SqlDbType.Int, int.Parse(comboBox1.SelectedValue.ToString())));
                   // labelid.Text = "0";
                    MessageBox.Show("Deleted", "Employees");
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
                dt = RetriveData.executequery("sp_jobemployee_select_all", CommandType.StoredProcedure, new parameter("@emp_id", SqlDbType.Int,
                 int.Parse(comboBox1.SelectedValue.ToString())));
            //    labelid.Text = dt.Rows[0][0].ToString();
                nametxt.Text = dt.Rows[0]["emp_name"].ToString();
                addtxt.Text = dt.Rows[0]["emp_addres"].ToString();
                mobtxt.Text = dt.Rows[0]["emp_mobile"].ToString();
                phtxt.Text = dt.Rows[0]["emp_phone"].ToString();
                personalid.Text = dt.Rows[0]["personal_id"].ToString();
                basicsalary.Text = dt.Rows[0]["basic_salary"].ToString();
               jobcombo.Text = dt.Rows[0]["job_name"].ToString();

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
