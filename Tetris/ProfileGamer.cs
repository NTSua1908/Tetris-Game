using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account
{
    public partial class ProfileGamer : Form
    {
        public ProfileGamer()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to log out?", "Nofitication", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
