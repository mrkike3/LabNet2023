namespace labTaxi
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
            this.dgvOmnibus = new System.Windows.Forms.DataGridView();
            this.dgvTaxi = new System.Windows.Forms.DataGridView();
            this.btnCargarTaxi = new System.Windows.Forms.Button();
            this.btnCargarOmnibus = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOmnibus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaxi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOmnibus
            // 
            this.dgvOmnibus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOmnibus.Enabled = false;
            this.dgvOmnibus.Location = new System.Drawing.Point(71, 109);
            this.dgvOmnibus.Name = "dgvOmnibus";
            this.dgvOmnibus.Size = new System.Drawing.Size(240, 263);
            this.dgvOmnibus.TabIndex = 0;
            // 
            // dgvTaxi
            // 
            this.dgvTaxi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaxi.Enabled = false;
            this.dgvTaxi.Location = new System.Drawing.Point(453, 109);
            this.dgvTaxi.Name = "dgvTaxi";
            this.dgvTaxi.Size = new System.Drawing.Size(240, 263);
            this.dgvTaxi.TabIndex = 1;
            // 
            // btnCargarTaxi
            // 
            this.btnCargarTaxi.Enabled = false;
            this.btnCargarTaxi.Location = new System.Drawing.Point(537, 80);
            this.btnCargarTaxi.Name = "btnCargarTaxi";
            this.btnCargarTaxi.Size = new System.Drawing.Size(85, 23);
            this.btnCargarTaxi.TabIndex = 2;
            this.btnCargarTaxi.Text = "Agregar Taxi";
            this.btnCargarTaxi.UseVisualStyleBackColor = true;
            this.btnCargarTaxi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCargarOmnibus
            // 
            this.btnCargarOmnibus.Enabled = false;
            this.btnCargarOmnibus.Location = new System.Drawing.Point(127, 80);
            this.btnCargarOmnibus.Name = "btnCargarOmnibus";
            this.btnCargarOmnibus.Size = new System.Drawing.Size(132, 23);
            this.btnCargarOmnibus.TabIndex = 3;
            this.btnCargarOmnibus.Text = "Agregar Omibus";
            this.btnCargarOmnibus.UseVisualStyleBackColor = true;
            this.btnCargarOmnibus.Click += new System.EventHandler(this.btnCargarOmnibus_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(322, 44);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(102, 23);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Cargar Grillas";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnCargarOmnibus);
            this.Controls.Add(this.btnCargarTaxi);
            this.Controls.Add(this.dgvTaxi);
            this.Controls.Add(this.dgvOmnibus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOmnibus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaxi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOmnibus;
        private System.Windows.Forms.DataGridView dgvTaxi;
        private System.Windows.Forms.Button btnCargarTaxi;
        private System.Windows.Forms.Button btnCargarOmnibus;
        private System.Windows.Forms.Button btnMostrar;
    }
}

