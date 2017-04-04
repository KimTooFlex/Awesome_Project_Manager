using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace awesome_project_manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); //exit the application
        }

        private void tab1_Click(object sender, EventArgs e)
        {
            bunifuSeparator1.Width = ((Bunifu.Framework.UI.BunifuCustomLabel)sender).Width;
            bunifuSeparator1.Left = ((Bunifu.Framework.UI.BunifuCustomLabel)sender).Left;
        }
    }
}
