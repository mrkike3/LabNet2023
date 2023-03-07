namespace Excepciones
{
    partial class Principal
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
            this.btnEjercicio1 = new System.Windows.Forms.Button();
            this.btnEjercicio2 = new System.Windows.Forms.Button();
            this.btnEjercicio3 = new System.Windows.Forms.Button();
            this.btnEjercicio4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEjercicio1
            // 
            this.btnEjercicio1.BackColor = System.Drawing.Color.Red;
            this.btnEjercicio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjercicio1.ForeColor = System.Drawing.Color.White;
            this.btnEjercicio1.Location = new System.Drawing.Point(374, 137);
            this.btnEjercicio1.Name = "btnEjercicio1";
            this.btnEjercicio1.Size = new System.Drawing.Size(134, 52);
            this.btnEjercicio1.TabIndex = 0;
            this.btnEjercicio1.Text = "Ejercicio 1)";
            this.btnEjercicio1.UseVisualStyleBackColor = false;
            this.btnEjercicio1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEjercicio2
            // 
            this.btnEjercicio2.BackColor = System.Drawing.Color.Green;
            this.btnEjercicio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjercicio2.ForeColor = System.Drawing.Color.White;
            this.btnEjercicio2.Location = new System.Drawing.Point(374, 195);
            this.btnEjercicio2.Name = "btnEjercicio2";
            this.btnEjercicio2.Size = new System.Drawing.Size(134, 47);
            this.btnEjercicio2.TabIndex = 1;
            this.btnEjercicio2.Text = "Ejercicio 2)";
            this.btnEjercicio2.UseVisualStyleBackColor = false;
            this.btnEjercicio2.Click += new System.EventHandler(this.btnEjercicio2_Click);
            // 
            // btnEjercicio3
            // 
            this.btnEjercicio3.BackColor = System.Drawing.Color.Blue;
            this.btnEjercicio3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjercicio3.ForeColor = System.Drawing.Color.White;
            this.btnEjercicio3.Location = new System.Drawing.Point(374, 248);
            this.btnEjercicio3.Name = "btnEjercicio3";
            this.btnEjercicio3.Size = new System.Drawing.Size(134, 52);
            this.btnEjercicio3.TabIndex = 2;
            this.btnEjercicio3.Text = "Ejercicio 3)";
            this.btnEjercicio3.UseVisualStyleBackColor = false;
            this.btnEjercicio3.Click += new System.EventHandler(this.btnEjercicio3_Click);
            // 
            // btnEjercicio4
            // 
            this.btnEjercicio4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEjercicio4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjercicio4.ForeColor = System.Drawing.Color.White;
            this.btnEjercicio4.Location = new System.Drawing.Point(374, 306);
            this.btnEjercicio4.Name = "btnEjercicio4";
            this.btnEjercicio4.Size = new System.Drawing.Size(134, 55);
            this.btnEjercicio4.TabIndex = 3;
            this.btnEjercicio4.Text = "Ejercicio 4)";
            this.btnEjercicio4.UseVisualStyleBackColor = false;
            this.btnEjercicio4.Click += new System.EventHandler(this.btnEjercicio4_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(911, 481);
            this.Controls.Add(this.btnEjercicio4);
            this.Controls.Add(this.btnEjercicio3);
            this.Controls.Add(this.btnEjercicio2);
            this.Controls.Add(this.btnEjercicio1);
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEjercicio1;
        private System.Windows.Forms.Button btnEjercicio2;
        private System.Windows.Forms.Button btnEjercicio3;
        private System.Windows.Forms.Button btnEjercicio4;
    }
}

