using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystemNew
{
     class validation
    {
        public void txtclear(Form frm, GroupBox grp)
        {
            foreach (Control item in frm.Controls)
            {
                if (item is GroupBox)
                {
                    foreach (Control txt in grp.Controls)
                    {
                        if (txt is TextBox)
                        {
                            txt.Text = "";
                        }
                        if (txt is ComboBox)
                        {
                            txt.Text = "";
                        }
                        if (txt is MaskedTextBox)
                        {
                            txt.Text = "";
                        }
                    }
                }
            }
        }
    }
}
