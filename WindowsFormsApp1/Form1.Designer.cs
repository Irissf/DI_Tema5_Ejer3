
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.reproductor1 = new DI_Tema5_Ejer3.Reproductor();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.reproductor1);
            this.panel1.Location = new System.Drawing.Point(143, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 431);
            this.panel1.TabIndex = 1;
            // 
            // reproductor1
            // 
            this.reproductor1.ColorComponente = System.Drawing.Color.Black;
            this.reproductor1.LargoLinea = 250;
            this.reproductor1.Location = new System.Drawing.Point(183, 202);
            this.reproductor1.Name = "reproductor1";
            this.reproductor1.PausePlay = true;
            this.reproductor1.Size = new System.Drawing.Size(75, 23);
            this.reproductor1.TabIndex = 0;
            this.reproductor1.Text = "reproductor1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private DI_Tema5_Ejer3.Reproductor reproductor1;
    }
}

