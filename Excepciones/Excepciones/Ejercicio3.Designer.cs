namespace Excepciones
{
    partial class Ejercicio3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLanzarExcepcion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLanzarExcepcion
            // 
            this.btnLanzarExcepcion.Location = new System.Drawing.Point(283, 186);
            this.btnLanzarExcepcion.Name = "btnLanzarExcepcion";
            this.btnLanzarExcepcion.Size = new System.Drawing.Size(75, 23);
            this.btnLanzarExcepcion.TabIndex = 0;
            this.btnLanzarExcepcion.Text = "button1";
            this.btnLanzarExcepcion.UseVisualStyleBackColor = true;
            this.btnLanzarExcepcion.Click += new System.EventHandler(this.btnLanzarExcepcion_Click);
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLanzarExcepcion);
            this.Name = "Ejercicio3";
            this.Text = "Ejercicio3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLanzarExcepcion;
    }
}