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
            this.btnLanzarExcepcion.BackColor = System.Drawing.Color.Red;
            this.btnLanzarExcepcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanzarExcepcion.ForeColor = System.Drawing.Color.White;
            this.btnLanzarExcepcion.Location = new System.Drawing.Point(196, 123);
            this.btnLanzarExcepcion.Name = "btnLanzarExcepcion";
            this.btnLanzarExcepcion.Size = new System.Drawing.Size(164, 92);
            this.btnLanzarExcepcion.TabIndex = 0;
            this.btnLanzarExcepcion.Text = "Lanzar Excepcion";
            this.btnLanzarExcepcion.UseVisualStyleBackColor = false;
            this.btnLanzarExcepcion.Click += new System.EventHandler(this.btnLanzarExcepcion_Click);
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(585, 345);
            this.Controls.Add(this.btnLanzarExcepcion);
            this.MaximizeBox = false;
            this.Name = "Ejercicio3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLanzarExcepcion;
    }
}