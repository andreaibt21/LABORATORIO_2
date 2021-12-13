
namespace SimuladorForm
{
    partial class SimuladorForm
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
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.cmbMicroorganismo = new System.Windows.Forms.ComboBox();
            this.lblPoblacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textPoblacion = new System.Windows.Forms.TextBox();
            this.txtEvolucion = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(570, 116);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 0;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // cmbMicroorganismo
            // 
            this.cmbMicroorganismo.FormattingEnabled = true;
            this.cmbMicroorganismo.Items.AddRange(new object[] {
            "Covid19",
            "Gripe"});
            this.cmbMicroorganismo.Location = new System.Drawing.Point(158, 55);
            this.cmbMicroorganismo.Name = "cmbMicroorganismo";
            this.cmbMicroorganismo.Size = new System.Drawing.Size(121, 23);
            this.cmbMicroorganismo.TabIndex = 1;
            // 
            // lblPoblacion
            // 
            this.lblPoblacion.AutoSize = true;
            this.lblPoblacion.Location = new System.Drawing.Point(31, 20);
            this.lblPoblacion.Name = "lblPoblacion";
            this.lblPoblacion.Size = new System.Drawing.Size(110, 15);
            this.lblPoblacion.TabIndex = 2;
            this.lblPoblacion.Text = "Poblacion a evaluar";
            this.lblPoblacion.Click += new System.EventHandler(this.lblPoblacion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Microorganismo";
            // 
            // textPoblacion
            // 
            this.textPoblacion.Location = new System.Drawing.Point(158, 21);
            this.textPoblacion.Name = "textPoblacion";
            this.textPoblacion.Size = new System.Drawing.Size(120, 23);
            this.textPoblacion.TabIndex = 4;
            // 
            // txtEvolucion
            // 
            this.txtEvolucion.Location = new System.Drawing.Point(17, 155);
            this.txtEvolucion.Name = "txtEvolucion";
            this.txtEvolucion.Size = new System.Drawing.Size(656, 272);
            this.txtEvolucion.TabIndex = 5;
            this.txtEvolucion.Text = "";
            // 
            // SimuladorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.txtEvolucion);
            this.Controls.Add(this.textPoblacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPoblacion);
            this.Controls.Add(this.cmbMicroorganismo);
            this.Controls.Add(this.btnEjecutar);
            this.Name = "SimuladorForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SimuladorForm_FormClosing);
            this.Load += new System.EventHandler(this.SimuladorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.ComboBox cmbMicroorganismo;
        private System.Windows.Forms.Label lblPoblacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPoblacion;
        private System.Windows.Forms.RichTextBox txtEvolucion;
    }
}

