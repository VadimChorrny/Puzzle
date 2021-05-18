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
            pbFirst.AllowDrop = true;
            pbSecond.AllowDrop = true;
            pbFour.AllowDrop = true;
            pbThird.AllowDrop = true;

        }

        private void pbSecond_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                pbSecond.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
                pbFirst.Image = null;
                pbThird.Image = null;
                pbFour.Image = null;
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



        private void pbSecond_MouseDown(object sender, MouseEventArgs e)
        {
            pbSecond.DoDragDrop(pbSecond.Image, DragDropEffects.Copy);
        }

        private void pbFour_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                pbFour.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
                pbSecond.Image = null;
                pbFirst.Image = null;
                pbThird.Image = null;
            }
            else if (e.Data.GetDataPresent(DataFormats.Bitmap) || e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                pbFour.ImageLocation = (e.Data.GetData(DataFormats.FileDrop) as string[])[0];
            }
        }

        private void pbFour_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) || e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void pbFour_MouseDown(object sender, MouseEventArgs e)
        {
            pbFour.DoDragDrop(pbFour.Image, DragDropEffects.Copy);

        }

        private void pbThird_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                pbThird.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
                pbFour.Image = null;
                pbFirst.Image = null;
                pbSecond.Image = null;

            }
            else if (e.Data.GetDataPresent(DataFormats.Bitmap) || e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                pbFour.ImageLocation = (e.Data.GetData(DataFormats.FileDrop) as string[])[0];
            }
        }

        private void pbThird_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) || e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void pbThird_MouseDown(object sender, MouseEventArgs e)
        {
            pbThird.DoDragDrop(pbThird.Image, DragDropEffects.Copy);

        }

        private void pbFirst_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                pbFirst.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
                pbFour.Image = null;
                pbSecond.Image = null;
                pbThird.Image = null;
            }
            else if (e.Data.GetDataPresent(DataFormats.Bitmap) || e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                pbFirst.ImageLocation = (e.Data.GetData(DataFormats.FileDrop) as string[])[0];
            }
        }

        private void pbFirst_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) || e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
    }
}
