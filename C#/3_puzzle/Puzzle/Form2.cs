using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Puzzle
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string picpath;
        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = CutPicture.Resize(picpath, 600,600);
        }

        
    }
}
