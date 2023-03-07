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
            this.btnThrowCustomException.Location = new System.Drawing.Point(323, 232);
            this.btnThrowCustomException.Name = "btnThrowCustomException";
            this.btnThrowCustomException.Size = new System.Drawing.Size(95, 39);
            this.btnThrowCustomException.TabIndex = 0;
            this.btnThrowCustomException.Text = "button1";
            this.btnThrowCustomException.UseVisualStyleBackColor = true;
            this.btnThrowCustomException.Click += new System.EventHandler(this.btnThrowCustomException_Click);
            // 
            // Ejercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThrowCustomException);
            this.Name = "Ejercicio4";
            this.Text = "Ejercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThrowCustomException;
    }
}