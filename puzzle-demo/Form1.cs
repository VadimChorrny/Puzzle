using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puzzle_demo
{
    public partial class Form1 : Form
    {
        #region properties
        
        #endregion
        public Form1()
        {
            InitializeComponent();
            pbSecond.AllowDrop = true;
        }

        private void pbSecond_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                pbSecond.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
                pbFirst.Image = null; // for delete image
            }
            else if (e.Data.GetDataPresent(DataFormats.Bitmap) || e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                pbSecond.ImageLocation = (e.Data.GetData(DataFormats.FileDrop) as string[])[0];
            }
        }

        private void pbSecond_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) || e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void pbFirst_MouseDown(object sender, MouseEventArgs e)
        {
            pbFirst.DoDragDrop(pbFirst.Image, DragDropEffects.Copy);
        }
    }
}
