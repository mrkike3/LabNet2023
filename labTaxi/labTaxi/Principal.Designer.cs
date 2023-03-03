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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDetenerOmnibuses = new System.Windows.Forms.Button();
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.btnDetenerTaxis = new System.Windows.Forms.Button();
            this.btnHabilitarTaxis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOmnibus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaxi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOmnibus
            // 
            this.dgvOmnibus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOmnibus.Enabled = false;
            this.dgvOmnibus.Location = new System.Drawing.Point(108, 109);
            this.dgvOmnibus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvOmnibus.Name = "dgvOmnibus";
            this.dgvOmnibus.Size = new System.Drawing.Size(240, 263);
            this.dgvOmnibus.TabIndex = 0;
            // 
            // dgvTaxi
            // 
            this.dgvTaxi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaxi.Enabled = false;
            this.dgvTaxi.Location = new System.Drawing.Point(552, 109);
            this.dgvTaxi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvTaxi.Name = "dgvTaxi";
            this.dgvTaxi.Size = new System.Drawing.Size(237, 263);
            this.dgvTaxi.TabIndex = 1;
            // 
            // btnCargarTaxi
            // 
            this.btnCargarTaxi.BackColor = System.Drawing.Color.Gold;
            this.btnCargarTaxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarTaxi.Location = new System.Drawing.Point(594, 393);
            this.btnCargarTaxi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCargarTaxi.Name = "btnCargarTaxi";
            this.btnCargarTaxi.Size = new System.Drawing.Size(144, 32);
            this.btnCargarTaxi.TabIndex = 2;
            this.btnCargarTaxi.Text = "Agregar Taxis";
            this.btnCargarTaxi.UseVisualStyleBackColor = false;
            this.btnCargarTaxi.Click += new System.EventHandler(this.btnCargarTaxi_Click);
            // 
            // btnCargarOmnibus
            // 
            this.btnCargarOmnibus.BackColor = System.Drawing.Color.Gold;
            this.btnCargarOmnibus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarOmnibus.Location = new System.Drawing.Point(140, 393);
            this.btnCargarOmnibus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCargarOmnibus.Name = "btnCargarOmnibus";
            this.btnCargarOmnibus.Size = new System.Drawing.Size(167, 32);
            this.btnCargarOmnibus.TabIndex = 3;
            this.btnCargarOmnibus.Text = "Agregar Omibus";
            this.btnCargarOmnibus.UseVisualStyleBackColor = false;
            this.btnCargarOmnibus.Click += new System.EventHandler(this.btnCargarOmnibus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Omnibus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(633, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Taxis";
            // 
            // btnDetenerOmnibuses
            // 
            this.btnDetenerOmnibuses.BackColor = System.Drawing.Color.Red;
            this.btnDetenerOmnibuses.ForeColor = System.Drawing.Color.White;
            this.btnDetenerOmnibuses.Location = new System.Drawing.Point(12, 109);
            this.btnDetenerOmnibuses.Name = "btnDetenerOmnibuses";
            this.btnDetenerOmnibuses.Size = new System.Drawing.Size(82, 48);
            this.btnDetenerOmnibuses.TabIndex = 8;
            this.btnDetenerOmnibuses.Text = "Detener Omnibuses";
            this.btnDetenerOmnibuses.UseVisualStyleBackColor = false;
            this.btnDetenerOmnibuses.Click += new System.EventHandler(this.btnDetenerOmnibuses_Click);
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHabilitar.ForeColor = System.Drawing.Color.White;
            this.btnHabilitar.Location = new System.Drawing.Point(38, 393);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(82, 53);
            this.btnHabilitar.TabIndex = 9;
            this.btnHabilitar.Text = "Reanudar Circulacion";
            this.btnHabilitar.UseVisualStyleBackColor = false;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // btnDetenerTaxis
            // 
            this.btnDetenerTaxis.BackColor = System.Drawing.Color.Red;
            this.btnDetenerTaxis.ForeColor = System.Drawing.Color.White;
            this.btnDetenerTaxis.Location = new System.Drawing.Point(795, 109);
            this.btnDetenerTaxis.Name = "btnDetenerTaxis";
            this.btnDetenerTaxis.Size = new System.Drawing.Size(82, 48);
            this.btnDetenerTaxis.TabIndex = 10;
            this.btnDetenerTaxis.Text = "Detener Taxis";
            this.btnDetenerTaxis.UseVisualStyleBackColor = false;
            this.btnDetenerTaxis.Click += new System.EventHandler(this.btnDetenerTaxis_Click);
            // 
            // btnHabilitarTaxis
            // 
            this.btnHabilitarTaxis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHabilitarTaxis.ForeColor = System.Drawing.Color.White;
            this.btnHabilitarTaxis.Location = new System.Drawing.Point(768, 393);
            this.btnHabilitarTaxis.Name = "btnHabilitarTaxis";
            this.btnHabilitarTaxis.Size = new System.Drawing.Size(82, 53);
            this.btnHabilitarTaxis.TabIndex = 11;
            this.btnHabilitarTaxis.Text = "Reanudar Circulacion";
            this.btnHabilitarTaxis.UseVisualStyleBackColor = false;
            this.btnHabilitarTaxis.Click += new System.EventHandler(this.btnHabilitarTaxis_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::labTaxi.Properties.Resources.fondoTransporte;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.btnHabilitarTaxis);
            this.Controls.Add(this.btnDetenerTaxis);
            this.Controls.Add(this.btnHabilitar);
            this.Controls.Add(this.btnDetenerOmnibuses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCargarOmnibus);
            this.Controls.Add(this.btnCargarTaxi);
            this.Controls.Add(this.dgvTaxi);
            this.Controls.Add(this.dgvOmnibus);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transporte Publico";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOmnibus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaxi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOmnibus;
        private System.Windows.Forms.DataGridView dgvTaxi;
        private System.Windows.Forms.Button btnCargarTaxi;
        private System.Windows.Forms.Button btnCargarOmnibus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDetenerOmnibuses;
        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.Button btnDetenerTaxis;
        private System.Windows.Forms.Button btnHabilitarTaxis;
    }
}

