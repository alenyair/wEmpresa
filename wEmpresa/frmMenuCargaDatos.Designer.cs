namespace wEmpresa
{
    partial class frmMenuCargaDatos
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
            this.dtgCargaDatos = new System.Windows.Forms.DataGridView();
            this.btnCSV = new System.Windows.Forms.Button();
            this.btnXML = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCargaDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgCargaDatos
            // 
            this.dtgCargaDatos.BackgroundColor = System.Drawing.Color.Silver;
            this.dtgCargaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCargaDatos.GridColor = System.Drawing.SystemColors.Desktop;
            this.dtgCargaDatos.Location = new System.Drawing.Point(24, 46);
            this.dtgCargaDatos.Name = "dtgCargaDatos";
            this.dtgCargaDatos.Size = new System.Drawing.Size(902, 312);
            this.dtgCargaDatos.TabIndex = 2;
            // 
            // btnCSV
            // 
            this.btnCSV.Font = new System.Drawing.Font("Burbank Big Cd Bd", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSV.ForeColor = System.Drawing.Color.Black;
            this.btnCSV.Location = new System.Drawing.Point(179, 408);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Size = new System.Drawing.Size(176, 86);
            this.btnCSV.TabIndex = 3;
            this.btnCSV.Text = ".CSV";
            this.btnCSV.UseVisualStyleBackColor = true;
            this.btnCSV.Click += new System.EventHandler(this.btnCSV_Click);
            // 
            // btnXML
            // 
            this.btnXML.Font = new System.Drawing.Font("Burbank Big Cd Bd", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXML.ForeColor = System.Drawing.Color.Black;
            this.btnXML.Location = new System.Drawing.Point(426, 408);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(176, 86);
            this.btnXML.TabIndex = 4;
            this.btnXML.Text = ".XML";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Burbank Big Cd Bd", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(667, 408);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(159, 86);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar Datos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnXML);
            this.groupBox1.Controls.Add(this.dtgCargaDatos);
            this.groupBox1.Controls.Add(this.btnCSV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(32, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(951, 565);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Area: Producción de la tela";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(34, 523);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(78, 25);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha ";
            // 
            // frmMenuCargaDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 601);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmMenuCargaDatos";
            this.Text = "MenuCargaDatos";
            this.Load += new System.EventHandler(this.FechaHora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCargaDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgCargaDatos;
        private System.Windows.Forms.Button btnCSV;
        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFecha;
    }
}