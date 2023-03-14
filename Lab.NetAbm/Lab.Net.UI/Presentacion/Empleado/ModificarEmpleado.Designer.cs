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
            this.txtApellidoModificar = new System.Windows.Forms.TextBox();
            this.txtNombreModificar = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.nudEmpleadoModificar = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpleadoModificar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtApellidoModificar
            // 
            this.txtApellidoModificar.Location = new System.Drawing.Point(154, 182);
            this.txtApellidoModificar.Name = "txtApellidoModificar";
            this.txtApellidoModificar.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoModificar.TabIndex = 1;
            this.txtApellidoModificar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoModificar_KeyPress);
            // 
            // txtNombreModificar
            // 
            this.txtNombreModificar.Location = new System.Drawing.Point(154, 144);
            this.txtNombreModificar.Name = "txtNombreModificar";
            this.txtNombreModificar.Size = new System.Drawing.Size(100, 20);
            this.txtNombreModificar.TabIndex = 2;
            this.txtNombreModificar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreModificar_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGuardar.Location = new System.Drawing.Point(109, 242);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(221, 242);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // nudEmpleadoModificar
            // 
            this.nudEmpleadoModificar.Location = new System.Drawing.Point(154, 95);
            this.nudEmpleadoModificar.Name = "nudEmpleadoModificar";
            this.nudEmpleadoModificar.Size = new System.Drawing.Size(71, 20);
            this.nudEmpleadoModificar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apellido";
            // 
            // ModificarEmpleado
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(444, 348);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNombreModificar);
            this.Controls.Add(this.txtApellidoModificar);
            this.Controls.Add(this.nudEmpleadoModificar);
            this.Name = "ModificarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpleadoModificar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtApellidoModificar;
        private System.Windows.Forms.TextBox txtNombreModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown nudEmpleadoModificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}