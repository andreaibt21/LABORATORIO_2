
namespace EjemploFormularios
{
    partial class FormManejadorAlumnos
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.tbx_dni = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(187, 223);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(498, 223);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(187, 94);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PlaceholderText = "Nombre Usuario";
            this.txt_nombre.Size = new System.Drawing.Size(386, 23);
            this.txt_nombre.TabIndex = 2;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(187, 149);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.PlaceholderText = "Direccion";
            this.txt_direccion.Size = new System.Drawing.Size(386, 23);
            this.txt_direccion.TabIndex = 3;
            // 
            // tbx_dni
            // 
            this.tbx_dni.Location = new System.Drawing.Point(187, 43);
            this.tbx_dni.Name = "tbx_dni";
            this.tbx_dni.PlaceholderText = "DNI";
            this.tbx_dni.Size = new System.Drawing.Size(386, 23);
            this.tbx_dni.TabIndex = 4;
            // 
            // FormManejadorAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 333);
            this.Controls.Add(this.tbx_dni);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Name = "FormManejadorAlumnos";
            this.Text = "AltaUsuario";
            this.Load += new System.EventHandler(this.FormManejadorAlumnos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox tbx_dni;
    }
}