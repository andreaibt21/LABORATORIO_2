
namespace EjemploFormularios
{
    partial class FormularioPrincipal
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
            this.btn_mensaje = new System.Windows.Forms.Button();
            this.btn_dialog = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_mensaje
            // 
            this.btn_mensaje.Location = new System.Drawing.Point(97, 97);
            this.btn_mensaje.Name = "btn_mensaje";
            this.btn_mensaje.Size = new System.Drawing.Size(177, 23);
            this.btn_mensaje.TabIndex = 0;
            this.btn_mensaje.Text = "Form Show";
            this.btn_mensaje.UseVisualStyleBackColor = true;
            this.btn_mensaje.Click += new System.EventHandler(this.btn_mensaje_Click);
            // 
            // btn_dialog
            // 
            this.btn_dialog.Location = new System.Drawing.Point(373, 97);
            this.btn_dialog.Name = "btn_dialog";
            this.btn_dialog.Size = new System.Drawing.Size(265, 23);
            this.btn_dialog.TabIndex = 2;
            this.btn_dialog.Text = "Form ShowDialog ALTA";
            this.btn_dialog.UseVisualStyleBackColor = true;
            this.btn_dialog.Click += new System.EventHandler(this.btn_dialog_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(384, 188);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(254, 23);
            this.btn_Modificar.TabIndex = 3;
            this.btn_Modificar.Text = "Form ShowDialog MODIFICACION";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_dialog);
            this.Controls.Add(this.btn_mensaje);
            this.Name = "FormularioPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_mensaje;
        private System.Windows.Forms.Button btn_dialog;
        private System.Windows.Forms.Button btn_Modificar;
    }
}

