using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestesAutomatizadosNFC_e
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            indicatorMenu.Left = 0;
        }

        public void SetTap(object sender)
        {
            indicatorMenu.Top = ((Control)sender).Top;
            indicatorMenu.Height = ((Control)sender).Height;            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            SetTap(sender);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            SetTap(sender);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            SetTap(sender);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            SetTap(sender);
        }

        
    }
}
