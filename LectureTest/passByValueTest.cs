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
    public partial class passByValueTest : Form
    {
        public passByValueTest()
        {
            InitializeComponent();
        }
        public int areacalculate(int w, int h, int area)
        {
            area = w * h;
            return area;
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            int width = Convert.ToInt32(txtwidth.Text);
            int height = Convert.ToInt32(txtheight.Text);
            int tarea = 0;
            MessageBox.Show(areacalculate(width, height, tarea).ToString());
            MessageBox.Show(tarea.ToString());
        }

    }
}
