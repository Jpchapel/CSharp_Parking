namespace Parking
{
    partial class fParking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fParking));
            this.cbxVehiculosParking = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMatricula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxModelo = new System.Windows.Forms.ComboBox();
            this.gbxMatriculas = new System.Windows.Forms.GroupBox();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btEntrada = new System.Windows.Forms.Button();
            this.btSaida = new System.Windows.Forms.Button();
            this.btGardar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btImprimir = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.vistaPrevia = new System.Windows.Forms.PrintPreviewDialog();
            this.documentoImprimir = new System.Drawing.Printing.PrintDocument();
            this.gbxMatriculas.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxVehiculosParking
            // 
            this.cbxVehiculosParking.FormattingEnabled = true;
            this.cbxVehiculosParking.Location = new System.Drawing.Point(6, 57);
            this.cbxVehiculosParking.Name = "cbxVehiculosParking";
            this.cbxVehiculosParking.Size = new System.Drawing.Size(188, 21);
            this.cbxVehiculosParking.TabIndex = 0;
            this.cbxVehiculosParking.SelectedIndexChanged += new System.EventHandler(this.cbxVehiculosParking_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = " matrícula";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = " matrícula";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbMatricula
            // 
            this.txbMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMatricula.Location = new System.Drawing.Point(11, 57);
            this.txbMatricula.Name = "txbMatricula";
            this.txbMatricula.Size = new System.Drawing.Size(188, 22);
            this.txbMatricula.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = " marca";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxMarca
            // 
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(11, 105);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(188, 21);
            this.cbxMarca.TabIndex = 4;
            this.cbxMarca.SelectedIndexChanged += new System.EventHandler(this.cbxMarca_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = " modelo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxModelo
            // 
            this.cbxModelo.FormattingEnabled = true;
            this.cbxModelo.Location = new System.Drawing.Point(11, 155);
            this.cbxModelo.Name = "cbxModelo";
            this.cbxModelo.Size = new System.Drawing.Size(188, 21);
            this.cbxModelo.TabIndex = 6;
            // 
            // gbxMatriculas
            // 
            this.gbxMatriculas.Controls.Add(this.label1);
            this.gbxMatriculas.Controls.Add(this.cbxVehiculosParking);
            this.gbxMatriculas.Location = new System.Drawing.Point(12, 165);
            this.gbxMatriculas.Name = "gbxMatriculas";
            this.gbxMatriculas.Size = new System.Drawing.Size(203, 236);
            this.gbxMatriculas.TabIndex = 10;
            this.gbxMatriculas.TabStop = false;
            this.gbxMatriculas.Text = "parking matrículas";
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.label3);
            this.gbxDatos.Controls.Add(this.label2);
            this.gbxDatos.Controls.Add(this.txbMatricula);
            this.gbxDatos.Controls.Add(this.cbxMarca);
            this.gbxDatos.Controls.Add(this.label4);
            this.gbxDatos.Controls.Add(this.cbxModelo);
            this.gbxDatos.Location = new System.Drawing.Point(241, 165);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(205, 236);
            this.gbxDatos.TabIndex = 11;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "datos do vehículo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(453, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btEntrada
            // 
            this.btEntrada.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEntrada.Location = new System.Drawing.Point(241, 118);
            this.btEntrada.Name = "btEntrada";
            this.btEntrada.Size = new System.Drawing.Size(203, 42);
            this.btEntrada.TabIndex = 14;
            this.btEntrada.Text = "ENTRADA";
            this.btEntrada.UseVisualStyleBackColor = true;
            this.btEntrada.Click += new System.EventHandler(this.btEntrada_Click);
            // 
            // btSaida
            // 
            this.btSaida.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSaida.ForeColor = System.Drawing.Color.Red;
            this.btSaida.Location = new System.Drawing.Point(12, 118);
            this.btSaida.Name = "btSaida";
            this.btSaida.Size = new System.Drawing.Size(203, 41);
            this.btSaida.TabIndex = 15;
            this.btSaida.Text = "SAIDA";
            this.btSaida.UseVisualStyleBackColor = true;
            this.btSaida.Click += new System.EventHandler(this.btSaida_Click);
            // 
            // btGardar
            // 
            this.btGardar.Image = ((System.Drawing.Image)(resources.GetObject("btGardar.Image")));
            this.btGardar.Location = new System.Drawing.Point(468, 212);
            this.btGardar.Name = "btGardar";
            this.btGardar.Size = new System.Drawing.Size(47, 42);
            this.btGardar.TabIndex = 15;
            this.btGardar.UseVisualStyleBackColor = true;
            this.btGardar.Click += new System.EventHandler(this.btGardar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btCancelar.Image")));
            this.btCancelar.Location = new System.Drawing.Point(468, 359);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(47, 42);
            this.btCancelar.TabIndex = 16;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btImprimir
            // 
            this.btImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btImprimir.Image")));
            this.btImprimir.Location = new System.Drawing.Point(468, 165);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(47, 40);
            this.btImprimir.TabIndex = 16;
            this.btImprimir.UseVisualStyleBackColor = true;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(432, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // vistaPrevia
            // 
            this.vistaPrevia.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.vistaPrevia.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.vistaPrevia.ClientSize = new System.Drawing.Size(400, 300);
            this.vistaPrevia.Enabled = true;
            this.vistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("vistaPrevia.Icon")));
            this.vistaPrevia.Name = "vistaPrevia";
            this.vistaPrevia.Visible = false;
            // 
            // documentoImprimir
            // 
            this.documentoImprimir.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.contidoPaxina);
            // 
            // fParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 431);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btImprimir);
            this.Controls.Add(this.btGardar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSaida);
            this.Controls.Add(this.btEntrada);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.gbxMatriculas);
            this.Name = "fParking";
            this.Text = "parking";
            this.Load += new System.EventHandler(this.fParking_Load);
            this.gbxMatriculas.ResumeLayout(false);
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxVehiculosParking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMatricula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxModelo;
        private System.Windows.Forms.GroupBox gbxMatriculas;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btGardar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btEntrada;
        private System.Windows.Forms.Button btSaida;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PrintPreviewDialog vistaPrevia;
        private System.Drawing.Printing.PrintDocument documentoImprimir;
    }
}

