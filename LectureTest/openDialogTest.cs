using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace LectureTest
{
    public partial class openDialogTest : Form
    {
        public openDialogTest()
        {
            InitializeComponent();
        }
        bool checkpicture = true;
        string imagename = "";
        string originalpath = "";
        string originalname = "";

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{

            //    String originalpath = openFileDialog1.FileName;

            //    pictureBox1.Image = Image.FromFile(originalpath);



            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                checkpicture = true;
                originalpath = openFileDialog1.FileName;
               
                originalname = System.IO.Path.GetFileName(originalpath);
                label1.Text = originalname;
                pictureBox1.Image = Image.FromFile(originalpath);
               
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string startupPath = System.IO.Directory.GetCurrentDirectory();

            // MessageBox.Show(startupPath);
            startupPath = Directory.GetParent(startupPath).Parent.FullName;
            //MessageBox.Show(startupPath);
            imagename = "\\upload\\" + originalname;//to save database

            String destinationfilepath = startupPath + "\\upload\\" + originalname;

            //save in folder
            File.Copy(originalpath, destinationfilepath, true);
            pictureBox1.Image = null;
        }

        private void openDialogTest_Load(object sender, EventArgs e)
        {
            
        }
    }
}
