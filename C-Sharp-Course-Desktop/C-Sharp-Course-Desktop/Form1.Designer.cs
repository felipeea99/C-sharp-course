namespace C_Sharp_Course_Desktop
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
            this.txtoPeso = new System.Windows.Forms.Label();
            this.txtoAltura = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.botonCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtoPeso
            // 
            this.txtoPeso.AutoSize = true;
            this.txtoPeso.Location = new System.Drawing.Point(204, 106);
            this.txtoPeso.Name = "txtoPeso";
            this.txtoPeso.Size = new System.Drawing.Size(32, 15);
            this.txtoPeso.TabIndex = 0;
            this.txtoPeso.Text = "Peso";
            // 
            // txtoAltura
            // 
            this.txtoAltura.AutoSize = true;
            this.txtoAltura.Location = new System.Drawing.Point(204, 132);
            this.txtoAltura.Name = "txtoAltura";
            this.txtoAltura.Size = new System.Drawing.Size(39, 15);
            this.txtoAltura.TabIndex = 1;
            this.txtoAltura.Text = "Altura";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(252, 103);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 23);
            this.txtPeso.TabIndex = 2;
            this.txtPeso.TextChanged += new System.EventHandler(this.txtPeso_TextChanged);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(252, 132);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 23);
            this.txtAltura.TabIndex = 3;
            this.txtAltura.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // botonCalcular
            // 
            this.botonCalcular.Location = new System.Drawing.Point(262, 175);
            this.botonCalcular.Name = "botonCalcular";
            this.botonCalcular.Size = new System.Drawing.Size(75, 23);
            this.botonCalcular.TabIndex = 4;
            this.botonCalcular.Text = "Calcular";
            this.botonCalcular.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.botonCalcular.UseVisualStyleBackColor = true;
            this.botonCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonCalcular);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtoAltura);
            this.Controls.Add(this.txtoPeso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label txtoPeso;
        private Label txtoAltura;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private Button botonCalcular;
    }
}