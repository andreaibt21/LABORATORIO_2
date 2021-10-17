
namespace Formulario
{
    partial class FormPpal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPpal));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.listEjercito = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbBlaster = new System.Windows.Forms.ComboBox();
            this.lblBlaster = new System.Windows.Forms.Label();
            this.checkBoxEsClone = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(65, 342);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(65, 386);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 1;
            this.btnQuitar.Text = "QUITAR";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(41, 9);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(30, 15);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(41, 35);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(122, 23);
            this.cmbTipo.TabIndex = 5;
            // 
            // listEjercito
            // 
            this.listEjercito.FormattingEnabled = true;
            this.listEjercito.ItemHeight = 15;
            this.listEjercito.Location = new System.Drawing.Point(207, 30);
            this.listEjercito.Name = "listEjercito";
            this.listEjercito.Size = new System.Drawing.Size(568, 439);
            this.listEjercito.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 125);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // cmbBlaster
            // 
            this.cmbBlaster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBlaster.FormattingEnabled = true;
            this.cmbBlaster.Location = new System.Drawing.Point(41, 85);
            this.cmbBlaster.Name = "cmbBlaster";
            this.cmbBlaster.Size = new System.Drawing.Size(122, 23);
            this.cmbBlaster.TabIndex = 8;
            // 
            // lblBlaster
            // 
            this.lblBlaster.AutoSize = true;
            this.lblBlaster.Location = new System.Drawing.Point(41, 67);
            this.lblBlaster.Name = "lblBlaster";
            this.lblBlaster.Size = new System.Drawing.Size(42, 15);
            this.lblBlaster.TabIndex = 9;
            this.lblBlaster.Text = "Blaster";
            // 
            // checkBoxEsClone
            // 
            this.checkBoxEsClone.AutoSize = true;
            this.checkBoxEsClone.Location = new System.Drawing.Point(46, 126);
            this.checkBoxEsClone.Name = "checkBoxEsClone";
            this.checkBoxEsClone.Size = new System.Drawing.Size(71, 19);
            this.checkBoxEsClone.TabIndex = 10;
            this.checkBoxEsClone.Text = "Es Clone";
            this.checkBoxEsClone.UseVisualStyleBackColor = true;
            // 
            // FormPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 484);
            this.Controls.Add(this.checkBoxEsClone);
            this.Controls.Add(this.lblBlaster);
            this.Controls.Add(this.cmbBlaster);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listEjercito);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPpal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenidos a la fábrica de troopers del Lado Oscuro";
            this.Load += new System.EventHandler(this.FormPpal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ListBox listEjercito;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbBlaster;
        private System.Windows.Forms.Label lblBlaster;
        private System.Windows.Forms.CheckBox checkBoxEsClone;
    }
}

