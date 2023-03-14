namespace Lab.Net.UI.Presentacion.Categoria
{
    partial class ModificarCategoria
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombreModificar = new System.Windows.Forms.TextBox();
            this.txtDescripcionModificar = new System.Windows.Forms.TextBox();
            this.nudCategoriaModificar = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCategoriaModificar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(184, 207);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(72, 207);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombreModificar
            // 
            this.txtNombreModificar.Location = new System.Drawing.Point(131, 116);
            this.txtNombreModificar.Name = "txtNombreModificar";
            this.txtNombreModificar.Size = new System.Drawing.Size(100, 20);
            this.txtNombreModificar.TabIndex = 7;
            this.txtNombreModificar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreModificar_KeyPress);
            // 
            // txtDescripcionModificar
            // 
            this.txtDescripcionModificar.Location = new System.Drawing.Point(131, 154);
            this.txtDescripcionModificar.Name = "txtDescripcionModificar";
            this.txtDescripcionModificar.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcionModificar.TabIndex = 6;
            this.txtDescripcionModificar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcionModificar_KeyPress);
            // 
            // nudCategoriaModificar
            // 
            this.nudCategoriaModificar.Location = new System.Drawing.Point(131, 67);
            this.nudCategoriaModificar.Name = "nudCategoriaModificar";
            this.nudCategoriaModificar.Size = new System.Drawing.Size(71, 20);
            this.nudCategoriaModificar.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Descripcion";
            // 
            // ModificarCategoria
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(312, 276);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNombreModificar);
            this.Controls.Add(this.txtDescripcionModificar);
            this.Controls.Add(this.nudCategoriaModificar);
            this.Name = "ModificarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarCategoria";
            ((System.ComponentModel.ISupportInitialize)(this.nudCategoriaModificar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombreModificar;
        private System.Windows.Forms.TextBox txtDescripcionModificar;
        private System.Windows.Forms.NumericUpDown nudCategoriaModificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}