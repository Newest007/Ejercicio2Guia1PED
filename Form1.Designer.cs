
namespace Ejercicio2Guía1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstboxFiguras = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbColores = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nmcTamaño = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcTamaño)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(325, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 400);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // lstboxFiguras
            // 
            this.lstboxFiguras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstboxFiguras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstboxFiguras.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxFiguras.FormattingEnabled = true;
            this.lstboxFiguras.ItemHeight = 23;
            this.lstboxFiguras.Items.AddRange(new object[] {
            "  Circulo",
            "Rectangulo"});
            this.lstboxFiguras.Location = new System.Drawing.Point(97, 65);
            this.lstboxFiguras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstboxFiguras.Name = "lstboxFiguras";
            this.lstboxFiguras.Size = new System.Drawing.Size(90, 48);
            this.lstboxFiguras.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione la figura que desea dibujar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbColores);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nmcTamaño);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lstboxFiguras);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(25, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 333);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones:";
            // 
            // cmbColores
            // 
            this.cmbColores.FormattingEnabled = true;
            this.cmbColores.Location = new System.Drawing.Point(81, 224);
            this.cmbColores.Name = "cmbColores";
            this.cmbColores.Size = new System.Drawing.Size(121, 31);
            this.cmbColores.TabIndex = 7;
            this.cmbColores.SelectedIndexChanged += new System.EventHandler(this.cmbColores_SelectedIndexChanged);
            this.cmbColores.SelectedValueChanged += new System.EventHandler(this.cmbColores_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Seleccione el color de la figura";
            // 
            // nmcTamaño
            // 
            this.nmcTamaño.Location = new System.Drawing.Point(81, 153);
            this.nmcTamaño.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nmcTamaño.Name = "nmcTamaño";
            this.nmcTamaño.Size = new System.Drawing.Size(120, 30);
            this.nmcTamaño.TabIndex = 4;
            this.nmcTamaño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccione su tamaño";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(382, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Haga click en donde desea que se dibuje la figura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(140)))), ((int)(((byte)(69)))));
            this.label5.Location = new System.Drawing.Point(1, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(317, 33);
            this.label5.TabIndex = 5;
            this.label5.Text = "Programa para dibujar figuras!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(790, 476);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Dibujador de Figuras";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcTamaño)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstboxFiguras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmcTamaño;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbColores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

