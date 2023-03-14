namespace Lab.Net.UI.Presentacion
{
    partial class ModificarEmpleado
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
            this.nudEmpleadoModificar = new System.Windows.Forms.NumericUpDown();
            this.txtApellidoModificar = new System.Windows.Forms.TextBox();
            this.txtNombreModificar = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpleadoModificar)).BeginInit();
            this.SuspendLayout();
            // 
            // nudEmpleadoModificar
            // 
            this.nudEmpleadoModificar.Location = new System.Drawing.Point(301, 166);
            this.nudEmpleadoModificar.Name = "nudEmpleadoModificar";
            this.nudEmpleadoModificar.Size = new System.Drawing.Size(71, 20);
            this.nudEmpleadoModificar.TabIndex = 0;
            // 
            // txtApellidoModificar
            // 
            this.txtApellidoModificar.Location = new System.Drawing.Point(301, 253);
            this.txtApellidoModificar.Name = "txtApellidoModificar";
            this.txtApellidoModificar.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoModificar.TabIndex = 1;
            // 
            // txtNombreModificar
            // 
            this.txtNombreModificar.Location = new System.Drawing.Point(301, 215);
            this.txtNombreModificar.Name = "txtNombreModificar";
            this.txtNombreModificar.Size = new System.Drawing.Size(100, 20);
            this.txtNombreModificar.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(242, 306);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(354, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ModificarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNombreModificar);
            this.Controls.Add(this.txtApellidoModificar);
            this.Controls.Add(this.nudEmpleadoModificar);
            this.Name = "ModificarEmpleado";
            this.Text = "ModificarEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpleadoModificar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudEmpleadoModificar;
        private System.Windows.Forms.TextBox txtApellidoModificar;
        private System.Windows.Forms.TextBox txtNombreModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button2;
    }
}