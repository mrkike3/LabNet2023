namespace Lab.Net.UI.Presentacion
{
    partial class EliminarEmpleado
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
            this.nudEmpleadoEliminado = new System.Windows.Forms.NumericUpDown();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCamcelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpleadoEliminado)).BeginInit();
            this.SuspendLayout();
            // 
            // nudEmpleadoEliminado
            // 
            this.nudEmpleadoEliminado.Location = new System.Drawing.Point(131, 104);
            this.nudEmpleadoEliminado.Name = "nudEmpleadoEliminado";
            this.nudEmpleadoEliminado.Size = new System.Drawing.Size(120, 20);
            this.nudEmpleadoEliminado.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(97, 170);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCamcelar
            // 
            this.btnCamcelar.Location = new System.Drawing.Point(209, 170);
            this.btnCamcelar.Name = "btnCamcelar";
            this.btnCamcelar.Size = new System.Drawing.Size(75, 23);
            this.btnCamcelar.TabIndex = 2;
            this.btnCamcelar.Text = "Cancelar";
            this.btnCamcelar.UseVisualStyleBackColor = true;
            // 
            // EliminarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 282);
            this.Controls.Add(this.btnCamcelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.nudEmpleadoEliminado);
            this.Name = "EliminarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EliminarEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpleadoEliminado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudEmpleadoEliminado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCamcelar;
    }
}