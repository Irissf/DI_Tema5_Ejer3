using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_Tema5_Ejer3
{
    public partial class Reproductor : Control
    {
        private int offSetXLine = 10;
        private int offSetYLine = 10;
        private int predeterminado = 250;
        public Reproductor()
        {
            InitializeComponent();
        }

        /**
         * =============================================================================
                    ___  ____ ____ ___  _ ____ ___  ____ ___  ____ ____ 
                    |__] |__/ |  | |__] | |___ |  \ |__| |  \ |___ [__  
                    |    |  \ |__| |    | |___ |__/ |  | |__/ |___ ___]
         * =============================================================================
        */

        //Color del componente****************************
        private Color colorComponente = Color.Black;
        [Category("aparienciaNueva")]
        [Description("Camnia el color")]
        public Color ColorComponente
        {
            set
            {
                colorComponente = value;
                this.Refresh();
            }
            get
            {
                return colorComponente;
            }
        }

        //Tamaño*****************************************
        private int largoLinea = 250;
        [Category("aparienciaNueva")]
        [Description("Escala el tamaño del componente desde el largo de la linea entre 150 y 400")]
        public int LargoLinea
        {
            set
            {
                if (value < 100)
                {
                    largoLinea = 100;
                }
                else if (value > 400)
                {
                    largoLinea = 400;
                }
                else
                {
                    largoLinea = value;
                }

            }
            get
            {
                return largoLinea;
            }
        }


        //PausePlay**************************************
        private bool pausePlay = true; //true = pause
        [Category("aparienciaNueva")]
        [Description("Pone el componente en pause o en play")]
        public bool PausePlay
        {
            set
            {
                pausePlay = value;
                this.Refresh();
            }
            get
            {
                return pausePlay;
            }
        }

        //XX ******************************************
        private int xx;
        [Category("aparienciaNueva")]
        [Description("Valor entre 0 y 99")]
        public int Xx
        {
            set
            {
                if (value > 99 || value < 0)
                {
                    xx = 0;
                }
                else
                {
                    xx = value;
                }
            }
            get
            {
                return xx;
            }
        }

        //YY ******************************************
        private int yy;
        [Category("aparienciaNueva")]
        [Description("Valor entre 0 y 59")]
        public int Yy
        {
            set
            {
                if (value > 59)
                {
                    xx = 0;
                }
                else
                {
                    xx = value;
                }
            }
            get
            {
                return xx;
            }
        }
        /**
      * =============================================================================
                _    ____ _  _ ___  ____ ____    ____ _  _ ____ _  _ ___ ____ ____ 
                |    |__| |\ |   /  |__| |__/    |___ |  | |___ |\ |  |  |  | [__  
                |___ |  | | \|  /__ |  | |  \    |___  \/  |___ | \|  |  |__| ___]
      * =============================================================================
     */
        [Category("click en pausePlay")]
        [Description("cambia entre play y pause")]
        public event System.EventHandler ClickEnPuse;
        protected override void OnMouseClick(MouseEventArgs e)
        {
            if (e.X >= (135 * largoLinea) / predeterminado && e.X <= (150 * largoLinea) / predeterminado
                && e.Y >= (20 * largoLinea) / predeterminado && e.Y <= (40 * largoLinea) / predeterminado)
            {
                ClickEnPuse?.Invoke(this, EventArgs.Empty);
            }
            base.OnMouseClick(e);
        }

        [Category("Desborda tiempo")]
        [Description("Cuando YY es mayor de 59")]
        public event System.EventHandler DesbordaTiempo;
        

        /**
         * =============================================================================
                                ____ _  _    ___  ____ _ _  _ ___ 
                                |  | |\ |    |__] |__| | |\ |  |  
                                |__| | \|    |    |  | | | \|  |
         * =============================================================================
        */


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            int grosor = largoLinea < 200 ? 2 : 3;
            offSetXLine = (10 * largoLinea) / predeterminado;
            offSetYLine = (10 * largoLinea) / predeterminado;


            Pen pen = new Pen(ColorComponente, grosor);
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;

            //mejora en la apariencia o en la eficiencia a la hora de dibujar
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            g.DrawLine(pen, offSetXLine, offSetYLine, largoLinea + offSetXLine, offSetYLine);


            if (PausePlay)
            {
                //pause

                g.DrawLine(pen, (135 * largoLinea) / predeterminado, (20 * largoLinea) / predeterminado, (135 * largoLinea) / predeterminado, (40 * largoLinea) / predeterminado);
                g.DrawLine(pen, (145 * largoLinea) / predeterminado, (20 * largoLinea) / predeterminado, (145 * largoLinea) / predeterminado, (40 * largoLinea) / predeterminado);
            }
            else
            {

                SolidBrush pincelRelleno = new SolidBrush(colorComponente);
                //play 
                Point[] triangle = new Point[] {
                    new Point((130 * largoLinea )/ predeterminado ,(20 * largoLinea )/ predeterminado),
                    new Point( (150 * largoLinea )/ predeterminado,(30 * largoLinea )/ predeterminado),
                    new Point((130 * largoLinea )/ predeterminado,(40* largoLinea )/ predeterminado)
                };
                g.FillPolygon(pincelRelleno, triangle);
            }

        }
    }
}

