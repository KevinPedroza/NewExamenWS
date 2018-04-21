namespace ExamenWS
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCCM = new System.Windows.Forms.TextBox();
            this.lblCTM = new System.Windows.Forms.Label();
            this.pbxCM = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCCT = new System.Windows.Forms.TextBox();
            this.lblCTT = new System.Windows.Forms.Label();
            this.pbxCT = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.proregionciudad = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCCN = new System.Windows.Forms.TextBox();
            this.lblCTN = new System.Windows.Forms.Label();
            this.pbxCN = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbxRegiones = new System.Windows.Forms.ComboBox();
            this.proregionaregion = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblFaseLunar = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLunaPone = new System.Windows.Forms.Label();
            this.lblLunaSale = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSolPone = new System.Windows.Forms.Label();
            this.lblSolSale = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCM)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proregionciudad)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCN)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proregionaregion)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::ExamenWS.Properties.Resources.Close_Window_64px;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(971, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 40);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(0, 0);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(352, 342);
            this.gMapControl1.TabIndex = 1;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.panel1);
            this.groupBox5.Controls.Add(this.panel2);
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Controls.Add(this.panel3);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(678, 12);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(291, 322);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ciudad";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCCM);
            this.panel1.Controls.Add(this.lblCTM);
            this.panel1.Controls.Add(this.pbxCM);
            this.panel1.Location = new System.Drawing.Point(15, 235);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 77);
            this.panel1.TabIndex = 0;
            // 
            // lblCCM
            // 
            this.lblCCM.BackColor = System.Drawing.SystemColors.Control;
            this.lblCCM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCCM.Enabled = false;
            this.lblCCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCM.Location = new System.Drawing.Point(76, 32);
            this.lblCCM.Margin = new System.Windows.Forms.Padding(2);
            this.lblCCM.Multiline = true;
            this.lblCCM.Name = "lblCCM";
            this.lblCCM.ReadOnly = true;
            this.lblCCM.Size = new System.Drawing.Size(178, 38);
            this.lblCCM.TabIndex = 2;
            this.lblCCM.Text = "Comentario";
            // 
            // lblCTM
            // 
            this.lblCTM.AutoSize = true;
            this.lblCTM.Location = new System.Drawing.Point(71, 11);
            this.lblCTM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCTM.Name = "lblCTM";
            this.lblCTM.Size = new System.Drawing.Size(47, 20);
            this.lblCTM.TabIndex = 1;
            this.lblCTM.Text = "Título";
            // 
            // pbxCM
            // 
            this.pbxCM.Location = new System.Drawing.Point(2, 3);
            this.pbxCM.Margin = new System.Windows.Forms.Padding(2);
            this.pbxCM.Name = "pbxCM";
            this.pbxCM.Size = new System.Drawing.Size(66, 69);
            this.pbxCM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCM.TabIndex = 0;
            this.pbxCM.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCCT);
            this.panel2.Controls.Add(this.lblCTT);
            this.panel2.Controls.Add(this.pbxCT);
            this.panel2.Location = new System.Drawing.Point(17, 72);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 77);
            this.panel2.TabIndex = 1;
            // 
            // lblCCT
            // 
            this.lblCCT.BackColor = System.Drawing.SystemColors.Control;
            this.lblCCT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCCT.Enabled = false;
            this.lblCCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCT.Location = new System.Drawing.Point(76, 34);
            this.lblCCT.Margin = new System.Windows.Forms.Padding(2);
            this.lblCCT.Multiline = true;
            this.lblCCT.Name = "lblCCT";
            this.lblCCT.ReadOnly = true;
            this.lblCCT.Size = new System.Drawing.Size(178, 38);
            this.lblCCT.TabIndex = 2;
            this.lblCCT.Text = "Comentario";
            // 
            // lblCTT
            // 
            this.lblCTT.AutoSize = true;
            this.lblCTT.Location = new System.Drawing.Point(74, 8);
            this.lblCTT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCTT.Name = "lblCTT";
            this.lblCTT.Size = new System.Drawing.Size(47, 20);
            this.lblCTT.TabIndex = 1;
            this.lblCTT.Text = "Título";
            // 
            // pbxCT
            // 
            this.pbxCT.Location = new System.Drawing.Point(2, 4);
            this.pbxCT.Margin = new System.Windows.Forms.Padding(2);
            this.pbxCT.Name = "pbxCT";
            this.pbxCT.Size = new System.Drawing.Size(66, 69);
            this.pbxCT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCT.TabIndex = 0;
            this.pbxCT.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.proregionciudad;
            this.comboBox1.DisplayMember = "nombre";
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 30);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(264, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "nombre";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // proregionciudad
            // 
            this.proregionciudad.DataSource = typeof(ExamenWS.XMLCode.PRONOSTICO_REGIONALREGIONCIUDAD);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblCCN);
            this.panel3.Controls.Add(this.lblCTN);
            this.panel3.Controls.Add(this.pbxCN);
            this.panel3.Location = new System.Drawing.Point(15, 154);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(261, 80);
            this.panel3.TabIndex = 2;
            // 
            // lblCCN
            // 
            this.lblCCN.BackColor = System.Drawing.SystemColors.Control;
            this.lblCCN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCCN.Enabled = false;
            this.lblCCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCN.Location = new System.Drawing.Point(78, 32);
            this.lblCCN.Margin = new System.Windows.Forms.Padding(2);
            this.lblCCN.Multiline = true;
            this.lblCCN.Name = "lblCCN";
            this.lblCCN.ReadOnly = true;
            this.lblCCN.Size = new System.Drawing.Size(174, 38);
            this.lblCCN.TabIndex = 2;
            this.lblCCN.Text = "Comentario";
            // 
            // lblCTN
            // 
            this.lblCTN.AutoSize = true;
            this.lblCTN.Location = new System.Drawing.Point(74, 8);
            this.lblCTN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCTN.Name = "lblCTN";
            this.lblCTN.Size = new System.Drawing.Size(47, 20);
            this.lblCTN.TabIndex = 1;
            this.lblCTN.Text = "Título";
            // 
            // pbxCN
            // 
            this.pbxCN.Location = new System.Drawing.Point(2, 2);
            this.pbxCN.Margin = new System.Windows.Forms.Padding(2);
            this.pbxCN.Name = "pbxCN";
            this.pbxCN.Size = new System.Drawing.Size(66, 69);
            this.pbxCN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCN.TabIndex = 0;
            this.pbxCN.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbxRegiones);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(377, 12);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(291, 84);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Seleccione una Región";
            // 
            // cbxRegiones
            // 
            this.cbxRegiones.DataSource = this.proregionaregion;
            this.cbxRegiones.DisplayMember = "nombre";
            this.cbxRegiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxRegiones.FormattingEnabled = true;
            this.cbxRegiones.Location = new System.Drawing.Point(16, 30);
            this.cbxRegiones.Margin = new System.Windows.Forms.Padding(2);
            this.cbxRegiones.Name = "cbxRegiones";
            this.cbxRegiones.Size = new System.Drawing.Size(264, 28);
            this.cbxRegiones.TabIndex = 0;
            this.cbxRegiones.ValueMember = "nombre";
            this.cbxRegiones.SelectedIndexChanged += new System.EventHandler(this.cbxRegiones_SelectedIndexChanged);
            // 
            // proregionaregion
            // 
            this.proregionaregion.DataSource = typeof(ExamenWS.XMLCode.PRONOSTICO_REGIONALREGION);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblFaseLunar);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(357, 233);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(317, 91);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fase Lunar";
            // 
            // lblFaseLunar
            // 
            this.lblFaseLunar.AutoSize = true;
            this.lblFaseLunar.Location = new System.Drawing.Point(9, 31);
            this.lblFaseLunar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFaseLunar.Name = "lblFaseLunar";
            this.lblFaseLunar.Size = new System.Drawing.Size(49, 20);
            this.lblFaseLunar.TabIndex = 1;
            this.lblFaseLunar.Text = "Sale: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblLunaPone);
            this.groupBox2.Controls.Add(this.lblLunaSale);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(518, 110);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(156, 91);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Luna:";
            // 
            // lblLunaPone
            // 
            this.lblLunaPone.AutoSize = true;
            this.lblLunaPone.Location = new System.Drawing.Point(6, 64);
            this.lblLunaPone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLunaPone.Name = "lblLunaPone";
            this.lblLunaPone.Size = new System.Drawing.Size(50, 20);
            this.lblLunaPone.TabIndex = 1;
            this.lblLunaPone.Text = "Pone:";
            // 
            // lblLunaSale
            // 
            this.lblLunaSale.AutoSize = true;
            this.lblLunaSale.Location = new System.Drawing.Point(8, 31);
            this.lblLunaSale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLunaSale.Name = "lblLunaSale";
            this.lblLunaSale.Size = new System.Drawing.Size(49, 20);
            this.lblLunaSale.TabIndex = 0;
            this.lblLunaSale.Text = "Sale: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSolPone);
            this.groupBox1.Controls.Add(this.lblSolSale);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(357, 110);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(157, 91);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sol:";
            // 
            // lblSolPone
            // 
            this.lblSolPone.AutoSize = true;
            this.lblSolPone.Location = new System.Drawing.Point(6, 64);
            this.lblSolPone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSolPone.Name = "lblSolPone";
            this.lblSolPone.Size = new System.Drawing.Size(50, 20);
            this.lblSolPone.TabIndex = 1;
            this.lblSolPone.Text = "Pone:";
            // 
            // lblSolSale
            // 
            this.lblSolSale.AutoSize = true;
            this.lblSolSale.Location = new System.Drawing.Point(4, 31);
            this.lblSolSale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSolSale.Name = "lblSolSale";
            this.lblSolSale.Size = new System.Drawing.Size(45, 20);
            this.lblSolSale.TabIndex = 0;
            this.lblSolSale.Text = "Sale:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1032, 341);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCM)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proregionciudad)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCN)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.proregionaregion)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox lblCCM;
        private System.Windows.Forms.Label lblCTM;
        private System.Windows.Forms.PictureBox pbxCM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox lblCCT;
        private System.Windows.Forms.Label lblCTT;
        private System.Windows.Forms.PictureBox pbxCT;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox lblCCN;
        private System.Windows.Forms.Label lblCTN;
        private System.Windows.Forms.PictureBox pbxCN;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbxRegiones;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblFaseLunar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblLunaPone;
        private System.Windows.Forms.Label lblLunaSale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSolPone;
        private System.Windows.Forms.Label lblSolSale;
        private System.Windows.Forms.BindingSource proregionaregion;
        private System.Windows.Forms.BindingSource proregionciudad;
    }
}

