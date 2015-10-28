using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaibLab
{
    public partial class frmPaint : Form
    {
        public frmPaint()
        {
            InitializeComponent();
            
            //panel1.par
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            var img = pictureBox1.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                pictureBox1.Image = null;
            }
        }
        void pictureBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Move;
        }

        void pictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox2.Image = bmp;
        }



        private void frmPaint_Load(object sender, EventArgs e)
        {
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox2.AllowDrop = true;
            //pictureBox2.DragEnter += pictureBox2_DragEnter;
            pictureBox2.DragDrop += pictureBox2_DragDrop;
        }
    }
}
