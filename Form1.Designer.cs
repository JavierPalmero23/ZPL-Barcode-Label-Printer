namespace $safeprojectname$
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.imprimir2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ValorBC = new System.Windows.Forms.TextBox();
            this.Generar = new System.Windows.Forms.Button();
            this.Clase = new System.Windows.Forms.TextBox();
            this.Lote = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.TextBox();
            this.Huerta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Imprimir ZPL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // imprimir2
            // 
            this.imprimir2.Location = new System.Drawing.Point(31, 279);
            this.imprimir2.Name = "imprimir2";
            this.imprimir2.Size = new System.Drawing.Size(151, 23);
            this.imprimir2.TabIndex = 2;
            this.imprimir2.Text = "Imprimir BarCode";
            this.imprimir2.UseVisualStyleBackColor = true;
            this.imprimir2.Click += new System.EventHandler(this.imprimir2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ValorBC
            // 
            this.ValorBC.Location = new System.Drawing.Point(12, 250);
            this.ValorBC.Name = "ValorBC";
            this.ValorBC.Size = new System.Drawing.Size(120, 23);
            this.ValorBC.TabIndex = 4;
            // 
            // Generar
            // 
            this.Generar.Location = new System.Drawing.Point(138, 250);
            this.Generar.Name = "Generar";
            this.Generar.Size = new System.Drawing.Size(79, 24);
            this.Generar.TabIndex = 5;
            this.Generar.Text = "Generar";
            this.Generar.UseVisualStyleBackColor = true;
            this.Generar.Click += new System.EventHandler(this.Generar_Click);
            // 
            // Clase
            // 
            this.Clase.Location = new System.Drawing.Point(12, 12);
            this.Clase.Name = "Clase";
            this.Clase.PlaceholderText = "Clase";
            this.Clase.Size = new System.Drawing.Size(195, 23);
            this.Clase.TabIndex = 6;
            // 
            // Lote
            // 
            this.Lote.Location = new System.Drawing.Point(12, 41);
            this.Lote.Name = "Lote";
            this.Lote.PlaceholderText = "Folio";
            this.Lote.Size = new System.Drawing.Size(195, 23);
            this.Lote.TabIndex = 7;
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(12, 70);
            this.Fecha.Name = "Fecha";
            this.Fecha.PlaceholderText = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(195, 23);
            this.Fecha.TabIndex = 8;
            // 
            // Huerta
            // 
            this.Huerta.Location = new System.Drawing.Point(13, 99);
            this.Huerta.Name = "Huerta";
            this.Huerta.PlaceholderText = "Huerto";
            this.Huerta.Size = new System.Drawing.Size(194, 23);
            this.Huerta.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 311);
            this.Controls.Add(this.Huerta);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Lote);
            this.Controls.Add(this.Clase);
            this.Controls.Add(this.Generar);
            this.Controls.Add(this.ValorBC);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imprimir2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private PrintDialog printDialog1;
        private Button imprimir2;
        private PictureBox pictureBox1;
        private TextBox ValorBC;
        private Button Generar;
        private TextBox Clase;
        private TextBox Lote;
        private TextBox Fecha;
        private TextBox Huerta;
    }
}