using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebas
{
    public partial class Form1 : Form
    {
        
        private List<Image> imagenesDelFichero = new List<Image>();
        int num;
        public Form1()
        {
            InitializeComponent();
            PictureBox.BorderStyle = BorderStyle.None;
        }

        private void reproductor1_ClickEnPuse(object sender, EventArgs e)
        {
            reproductor1.PausePlay = !reproductor1.PausePlay;
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            string path;
            FileInfo[] imagenes;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                path = folderBrowserDialog.SelectedPath;
                DirectoryInfo directoryInfo = new DirectoryInfo(path);
                imagenes = directoryInfo.GetFiles();
                if (!reproductor1.PausePlay)
                {
                    for (int i = 0; i < imagenes.Length; i++)
                    {
                        try
                        {
                            Image image = Image.FromFile(imagenes[i].FullName);
                            imagenesDelFichero.Add(image);
                        }
                        catch (OutOfMemoryException)
                        {

                        }

                    }
                    MessageBox.Show("Num imagenes: " + imagenesDelFichero.Count);
                }

            }
        }

        private void reproductor1_ClickEnPuse_1(object sender, EventArgs e)
        {
            if (reproductor1.PausePlay)
            {
                //si estaba en pause 
                timer1.Enabled = false;
                reproductor1.PausePlay = false;

            }
            else
            {
                //si estaba en play
                timer1.Enabled = true;
                reproductor1.PausePlay = true;
            }

        }


        private void GestionImagenes()
        {
            if(num == imagenesDelFichero.Count)
            {
                num = 0;
            }
            if (imagenesDelFichero.Count > 0 )
            {
                PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                PictureBox.Image = imagenesDelFichero[num];
            }
            
            num++;
            
          
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            reproductor1.Yy++; 
            GestionImagenes();
        
        }

        private void reproductor1_DesbordaTiempo(object sender, EventArgs e)
        {
            reproductor1.Xx++;
        }


    }
}
