using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orai231005
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            btnClickMe.Click += BtnClickMe_Click;
        }

        static Random rnd = new Random();

        private void BtnClickMe_Click(object sender, EventArgs e)
        {
            if (lblTextfield.Text.Contains("Placeholder"))
            {
                lblTextfield.Text = $"Hello, WinForms";
            }
            else
            {
                lblTextfield.BackColor = Color.FromArgb(
                    red: rnd.Next(256),
                    green: rnd.Next(256),
                    blue: rnd.Next(256)
                    );
            }
        }
    }
}
