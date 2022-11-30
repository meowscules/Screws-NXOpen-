using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screws
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Program.CreateScrewGost149180(GOST149180.Cylinder_M8, GOST149180.Cut_M8, "Screw GOST 1491-80");
            }
            if (radioButton2.Checked)
            {
                Program.CreateScrewGost147758(GOST147758.Cylinder_M8, GOST147758.Cut_M8, GOST147758.Chamfer_M8, "Screw GOST 1477-58");
            }
            Close();
        }
    }
}
