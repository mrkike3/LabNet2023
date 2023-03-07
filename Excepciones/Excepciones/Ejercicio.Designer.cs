namespace Excepciones
{
    partial class Ejercicio
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
            this.nudNumero1 = new System.Windows.Forms.NumericUpDown();
            this.lblError = new System.Windows.Forms.Label();
            this.btnDividir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero1)).BeginInit();
            this.SuspendLayout();
            // 
            // nudNumero1
            // 
            this.nudNumero1.Location = new System.Drawing.Point(248, 94);
            this.nudNumero1.Name = "nudNumero1";
            this.nudNumero1.Size = new System.Drawing.Size(97, 20);
            this.nudNumero1.TabIndex = 0;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(245, 226);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(16, 13);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "...";
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(248, 165);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(97, 27);
            this.btnDividir.TabIndex = 3;
            this.btnDividir.Text = "Dividir";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // Ejercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 388);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.nudNumero1);
            this.Name = "Ejercicio";
            this.Text = "Ejercicio";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudNumero1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnDividir;
    }
}