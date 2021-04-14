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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblAreaEmpresa = new System.Windows.Forms.Label();
            this.dtgCargaDatos = new System.Windows.Forms.DataGridView();
            this.btnCSV = new System.Windows.Forms.Button();
            this.btnXML = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCargaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(111, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // lblAreaEmpresa
            // 
            this.lblAreaEmpresa.AutoSize = true;
            this.lblAreaEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaEmpresa.Location = new System.Drawing.Point(428, 105);
            this.lblAreaEmpresa.Name = "lblAreaEmpresa";
            this.lblAreaEmpresa.Size = new System.Drawing.Size(200, 16);
            this.lblAreaEmpresa.TabIndex = 1;
            this.lblAreaEmpresa.Text = "Area:  Produccion de la tela";
            // 
            // dtgCargaDatos
            // 
            this.dtgCargaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCargaDatos.Location = new System.Drawing.Point(83, 175);
            this.dtgCargaDatos.Name = "dtgCargaDatos";
            this.dtgCargaDatos.Size = new System.Drawing.Size(526, 169);
            this.dtgCargaDatos.TabIndex = 2;
            // 
            // btnCSV
            // 
            this.btnCSV.Location = new System.Drawing.Point(180, 371);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Size = new System.Drawing.Size(75, 23);
            this.btnCSV.TabIndex = 3;
            this.btnCSV.Text = "CSV";
            this.btnCSV.UseVisualStyleBackColor = true;
            this.btnCSV.Click += new System.EventHandler(this.btnCSV_Click);
            // 
            // btnXML
            // 
            this.btnXML.Location = new System.Drawing.Point(374, 371);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(75, 23);
            this.btnXML.TabIndex = 4;
            this.btnXML.Text = "XML";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(646, 236);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // frmMenuCargaDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnXML);
            this.Controls.Add(this.btnCSV);
            this.Controls.Add(this.dtgCargaDatos);
            this.Controls.Add(this.lblAreaEmpresa);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "frmMenuCargaDatos";
            this.Text = "MenuCargaDatos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCargaDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblAreaEmpresa;
        private System.Windows.Forms.DataGridView dtgCargaDatos;
        private System.Windows.Forms.Button btnCSV;
        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.Button btnLimpiar;
    }
}