using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void reproductor1_ClickEnPuse(object sender, EventArgs e)
        {
            reproductor1.PausePlay = !reproductor1.PausePlay;
        }
    }
}
