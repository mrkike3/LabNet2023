namespace Excepciones
{
    partial class Ejercicio4
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
            this.btnThrowCustomException = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThrowCustomException
            // 
            this.btnThrowCustomException.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThrowCustomException.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThrowCustomException.ForeColor = System.Drawing.Color.White;
            this.btnThrowCustomException.Location = new System.Drawing.Point(187, 120);
            this.btnThrowCustomException.Name = "btnThrowCustomException";
            this.btnThrowCustomException.Size = new System.Drawing.Size(201, 100);
            this.btnThrowCustomException.TabIndex = 0;
            this.btnThrowCustomException.Text = "Lanzar Excepcion Personalizada";
            this.btnThrowCustomException.UseVisualStyleBackColor = false;
            this.btnThrowCustomException.Click += new System.EventHandler(this.btnThrowCustomException_Click);
            // 
            // Ejercicio4
            // 
            this.AcceptButton = this.btnThrowCustomException;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(585, 345);
            this.Controls.Add(this.btnThrowCustomException);
            this.MaximizeBox = false;
            this.Name = "Ejercicio4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThrowCustomException;
    }
}