using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LectureTest
{
    public partial class passByRefTest : Form
    {
        public passByRefTest()
        {
            InitializeComponent();
        }

        public void areacalculate(int w, int h, ref int area)
        {
            area = w * h;
            MessageBox.Show("from method is "+area.ToString());
        }
        private void btncalculate_Click(object sender, EventArgs e)
        {
            int width = Convert.ToInt32(txtwidth.Text);
            int height = Convert.ToInt32(txtheight.Text);
            int tarea = 0;
            areacalculate(width, height,ref tarea);
            MessageBox.Show("tarea is " +tarea.ToString());
        }
    }
}
