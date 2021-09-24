
namespace WinFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnConvertDolar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConversorDolar = new System.Windows.Forms.Button();
            this.btn_conversorPesos = new System.Windows.Forms.Button();
            this.btnLockCotizacion = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textCotizacionEuro = new System.Windows.Forms.TextBox();
            this.textCotizacionDolar = new System.Windows.Forms.TextBox();
            this.textCotizacionPesos = new System.Windows.Forms.TextBox();
            this.textEuroIngresado = new System.Windows.Forms.TextBox();
            this.textDolar = new System.Windows.Forms.TextBox();
            this.textPeso = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConvertDolar
            // 
            this.btnConvertDolar.Location = new System.Drawing.Point(227, 145);
            this.btnConvertDolar.Name = "btnConvertDolar";
            this.btnConvertDolar.Size = new System.Drawing.Size(94, 28);
            this.btnConvertDolar.TabIndex = 0;
            this.btnConvertDolar.Text = "->";
            this.btnConvertDolar.UseVisualStyleBackColor = true;
            this.btnConvertDolar.Click += new System.EventHandler(this.btnConvertDolar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(85, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cotización";
            // 
            // btnConversorDolar
            // 
            this.btnConversorDolar.Location = new System.Drawing.Point(226, 196);
            this.btnConversorDolar.Name = "btnConversorDolar";
            this.btnConversorDolar.Size = new System.Drawing.Size(95, 28);
            this.btnConversorDolar.TabIndex = 2;
            this.btnConversorDolar.Text = "->";
            this.btnConversorDolar.UseVisualStyleBackColor = true;
            // 
            // btn_conversorPesos
            // 
            this.btn_conversorPesos.Location = new System.Drawing.Point(227, 251);
            this.btn_conversorPesos.Name = "btn_conversorPesos";
            this.btn_conversorPesos.Size = new System.Drawing.Size(95, 28);
            this.btn_conversorPesos.TabIndex = 3;
            this.btn_conversorPesos.Text = "->";
            this.btn_conversorPesos.UseVisualStyleBackColor = true;
            // 
            // btnLockCotizacion
            // 
            this.btnLockCotizacion.BackColor = System.Drawing.SystemColors.Window;
            this.btnLockCotizacion.ImageIndex = 0;
            this.btnLockCotizacion.ImageList = this.imageList1;
            this.btnLockCotizacion.Location = new System.Drawing.Point(241, 50);
            this.btnLockCotizacion.Name = "btnLockCotizacion";
            this.btnLockCotizacion.Size = new System.Drawing.Size(62, 51);
            this.btnLockCotizacion.TabIndex = 4;
            this.btnLockCotizacion.UseVisualStyleBackColor = false;
            this.btnLockCotizacion.Click += new System.EventHandler(this.btnLockCotizacion_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "candado1.png");
            this.imageList1.Images.SetKeyName(1, "candado2.png");
            // 
            // textCotizacionEuro
            // 
            this.textCotizacionEuro.Location = new System.Drawing.Point(349, 62);
            this.textCotizacionEuro.Name = "textCotizacionEuro";
            this.textCotizacionEuro.Size = new System.Drawing.Size(92, 27);
            this.textCotizacionEuro.TabIndex = 5;
            // 
            // textCotizacionDolar
            // 
            this.textCotizacionDolar.Enabled = false;
            this.textCotizacionDolar.Location = new System.Drawing.Point(474, 62);
            this.textCotizacionDolar.Name = "textCotizacionDolar";
            this.textCotizacionDolar.Size = new System.Drawing.Size(92, 27);
            this.textCotizacionDolar.TabIndex = 6;
            // 
            // textCotizacionPesos
            // 
            this.textCotizacionPesos.Location = new System.Drawing.Point(600, 62);
            this.textCotizacionPesos.Name = "textCotizacionPesos";
            this.textCotizacionPesos.Size = new System.Drawing.Size(92, 27);
            this.textCotizacionPesos.TabIndex = 7;
            // 
            // textEuroIngresado
            // 
            this.textEuroIngresado.Location = new System.Drawing.Point(86, 146);
            this.textEuroIngresado.Name = "textEuroIngresado";
            this.textEuroIngresado.Size = new System.Drawing.Size(89, 27);
            this.textEuroIngresado.TabIndex = 8;
            // 
            // textDolar
            // 
            this.textDolar.Location = new System.Drawing.Point(86, 196);
            this.textDolar.Name = "textDolar";
            this.textDolar.Size = new System.Drawing.Size(89, 27);
            this.textDolar.TabIndex = 9;
            // 
            // textPeso
            // 
            this.textPeso.Location = new System.Drawing.Point(86, 252);
            this.textPeso.Name = "textPeso";
            this.textPeso.Size = new System.Drawing.Size(89, 27);
            this.textPeso.TabIndex = 10;
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(351, 141);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(92, 27);
            this.textBox7.TabIndex = 11;
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(349, 196);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(92, 27);
            this.textBox8.TabIndex = 12;
            // 
            // textBox9
            // 
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(349, 251);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(92, 27);
            this.textBox9.TabIndex = 13;
            // 
            // textBox10
            // 
            this.textBox10.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox10.Enabled = false;
            this.textBox10.Location = new System.Drawing.Point(474, 141);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(92, 27);
            this.textBox10.TabIndex = 14;
            // 
            // textBox11
            // 
            this.textBox11.Enabled = false;
            this.textBox11.Location = new System.Drawing.Point(474, 197);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(92, 27);
            this.textBox11.TabIndex = 15;
            // 
            // textBox12
            // 
            this.textBox12.Enabled = false;
            this.textBox12.Location = new System.Drawing.Point(474, 251);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(92, 27);
            this.textBox12.TabIndex = 16;
            // 
            // textBox13
            // 
            this.textBox13.Enabled = false;
            this.textBox13.Location = new System.Drawing.Point(600, 141);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(92, 27);
            this.textBox13.TabIndex = 17;
            // 
            // textBox14
            // 
            this.textBox14.Enabled = false;
            this.textBox14.Location = new System.Drawing.Point(600, 196);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(92, 27);
            this.textBox14.TabIndex = 18;
            // 
            // textBox15
            // 
            this.textBox15.Enabled = false;
            this.textBox15.Location = new System.Drawing.Point(600, 251);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(92, 27);
            this.textBox15.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(376, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Euro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(497, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Dolar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(622, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Peso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(21, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Euro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(21, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "Dólar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(21, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 23);
            this.label7.TabIndex = 25;
            this.label7.Text = "Peso";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(725, 345);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textPeso);
            this.Controls.Add(this.textDolar);
            this.Controls.Add(this.textEuroIngresado);
            this.Controls.Add(this.textCotizacionPesos);
            this.Controls.Add(this.textCotizacionDolar);
            this.Controls.Add(this.textCotizacionEuro);
            this.Controls.Add(this.btnLockCotizacion);
            this.Controls.Add(this.btn_conversorPesos);
            this.Controls.Add(this.btnConversorDolar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvertDolar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertDolar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConversorDolar;
        private System.Windows.Forms.Button btn_conversorPesos;
        private System.Windows.Forms.Button btnLockCotizacion;
        private System.Windows.Forms.TextBox textCotizacionEuro;
        private System.Windows.Forms.TextBox textCotizacionDolar;
        private System.Windows.Forms.TextBox textCotizacionPesos;
        private System.Windows.Forms.TextBox textEuroIngresado;
        private System.Windows.Forms.TextBox textDolar;
        private System.Windows.Forms.TextBox textPeso;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

