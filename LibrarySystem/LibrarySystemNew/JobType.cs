//using DevExpress.XtraEditors;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibrarySystemNew
{
    public partial class JobType : Form
    {
        public JobType()
        {
            InitializeComponent();
        }
        bool _addnew = false;
        validation _validate = new validation();
        #region bindgrid
        void bindgrid()
        {
            dataGridView1.DataSource = RetriveData.executequery("sp_jobs_selectall", CommandType.StoredProcedure);
        }
        #endregion
        #region bindcombo
        void bindcombo()
        {
            jobcombo.DataSource = RetriveData.executequery("sp_jobs_selectall", CommandType.StoredProcedure);
           jobcombo.DisplayMember = "job_name";
            jobcombo.ValueMember = "job_id";
            labelid.Text = jobcombo.Items.Count.ToString();
            jobcombo.Text = "";
        }
        #endregion
        private void button4_Click(object sender, EventArgs e)
        {
            #region add
            _validate.txtclear(this, groupBox1);
            _addnew = true;

            
        }
        #endregion
        private void JobType_Load(object sender, EventArgs e)
        {
            bindcombo();
          bindgrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_addnew == false)
            {
                MessageBox.Show("Please Enter Button New First", "Jobs ");
                return;

            }
            if (MessageBox.Show("Are You Sure To Save This Job", "Jobs", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                #region suredata
                if (jobtxt.Text == "")
                {
                    MessageBox.Show("Please Enter Job Name", "Jobs");
                    return;
                }
                #endregion
                #region save
                RetriveData.executeNonquery("sp_jobs_insert", CommandType.StoredProcedure,
                       new parameter("@job_name", SqlDbType.NVarChar, jobtxt.Text),

                       new parameter("@user_id", SqlDbType.Int, login.userid));

                #endregion
                MessageBox.Show("Saved", "Jobs");
                _addnew = false;
                _validate.txtclear(this, groupBox1);
                bindgrid();
                bindcombo();
                labelid.Text = jobcombo.Items.Count.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

           
            if (MessageBox.Show("Are You Sure To Update This Job", "Jobs", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                #region suredata
                if (jobcombo.Text == "")
                {
                    MessageBox.Show("Please Enter Job Name", "Jobs");
                    return;
                }
                #endregion
                #region save
                RetriveData.executeNonquery("sp_jobs_update", CommandType.StoredProcedure,
                     new parameter("@job_id", SqlDbType.Int, int.Parse(jobcombo.SelectedValue.ToString())),
                       new parameter("@job_name", SqlDbType.NVarChar, jobtxt.Text),
                       new parameter("@user_id", SqlDbType.Int, login.userid));

                #endregion
                MessageBox.Show("Updated", "Jobs");
                _addnew = false;
                bindgrid();
                bindcombo();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (jobcombo.Text != "")
            {
                if (MessageBox.Show("Are You Sure To Delete This job", "Categroies", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    #region suredata
                    if (jobcombo.Text == "")
                    {
                        MessageBox.Show("Please Enter Category Name", "Categories");
                        return;
                    }
                    #endregion
                    RetriveData.executeNonquery("sp_jobs_delete", CommandType.StoredProcedure,
                       new parameter("@job_id", SqlDbType.Int,int.Parse(jobcombo.SelectedValue.ToString())));

                    labelid.Text = "0";
                   jobcombo.Text = "";
                    MessageBox.Show("Deleted", "Categories");
                    _validate.txtclear(this, groupBox1);
                    bindgrid();
                    bindcombo();
                    labelid.Text = jobcombo.Items.Count.ToString();
                }
            }
        }

        private void jobcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void jobcombo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (int.Parse(labelid.Text)!=0)
            {
                DataTable dt = new DataTable();
                dt = RetriveData.executequery("sp_job_selectbyid", CommandType.StoredProcedure, new parameter("@job_id", SqlDbType.Int,
                 int.Parse(jobcombo.SelectedValue.ToString())));
                jobtxt.Text = dt.Rows[0]["job_name"].ToString();
            }
           
        }
        }
    }



