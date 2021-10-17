
namespace formulario
{
    partial class FormCarga
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.checkBoxAsistir = new System.Windows.Forms.CheckBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.textAntiguedad = new System.Windows.Forms.TextBox();
            this.textSueldo = new System.Windows.Forms.TextBox();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.lblAntiguedad = new System.Windows.Forms.Label();
            this.checkBoxEsSoloDocente = new System.Windows.Forms.CheckBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textInscripcion = new System.Windows.Forms.TextBox();
            this.lblInscripcion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(76, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(76, 95);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 15);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            // 
            // checkBoxAsistir
            // 
            this.checkBoxAsistir.AutoSize = true;
            this.checkBoxAsistir.Location = new System.Drawing.Point(238, 134);
            this.checkBoxAsistir.Name = "checkBoxAsistir";
            this.checkBoxAsistir.Size = new System.Drawing.Size(58, 19);
            this.checkBoxAsistir.TabIndex = 3;
            this.checkBoxAsistir.Text = "Asistir";
            this.checkBoxAsistir.UseVisualStyleBackColor = true;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(144, 55);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(152, 23);
            this.textNombre.TabIndex = 4;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(144, 92);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(152, 23);
            this.textID.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(144, 263);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(134, 35);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // textAntiguedad
            // 
            this.textAntiguedad.Location = new System.Drawing.Point(144, 168);
            this.textAntiguedad.Name = "textAntiguedad";
            this.textAntiguedad.Size = new System.Drawing.Size(152, 23);
            this.textAntiguedad.TabIndex = 7;
            // 
            // textSueldo
            // 
            this.textSueldo.Location = new System.Drawing.Point(159, 210);
            this.textSueldo.Name = "textSueldo";
            this.textSueldo.Size = new System.Drawing.Size(137, 23);
            this.textSueldo.TabIndex = 8;
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(76, 214);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(43, 15);
            this.lblSueldo.TabIndex = 9;
            this.lblSueldo.Text = "Sueldo";
            // 
            // lblAntiguedad
            // 
            this.lblAntiguedad.AutoSize = true;
            this.lblAntiguedad.Location = new System.Drawing.Point(58, 168);
            this.lblAntiguedad.Name = "lblAntiguedad";
            this.lblAntiguedad.Size = new System.Drawing.Size(69, 15);
            this.lblAntiguedad.TabIndex = 10;
            this.lblAntiguedad.Text = "Antiguedad";
            // 
            // checkBoxEsSoloDocente
            // 
            this.checkBoxEsSoloDocente.AutoSize = true;
            this.checkBoxEsSoloDocente.Location = new System.Drawing.Point(90, 134);
            this.checkBoxEsSoloDocente.Name = "checkBoxEsSoloDocente";
            this.checkBoxEsSoloDocente.Size = new System.Drawing.Size(127, 19);
            this.checkBoxEsSoloDocente.TabIndex = 11;
            this.checkBoxEsSoloDocente.Text = "Es Solo un Docente";
            this.checkBoxEsSoloDocente.UseVisualStyleBackColor = true;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Docente",
            "Alumno"});
            this.comboBoxTipo.Location = new System.Drawing.Point(168, 20);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(118, 23);
            this.comboBoxTipo.TabIndex = 12;
            this.comboBoxTipo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tipo de persona";
            // 
            // textInscripcion
            // 
            this.textInscripcion.Location = new System.Drawing.Point(144, 168);
            this.textInscripcion.Name = "textInscripcion";
            this.textInscripcion.Size = new System.Drawing.Size(152, 23);
            this.textInscripcion.TabIndex = 14;
            // 
            // lblInscripcion
            // 
            this.lblInscripcion.AutoSize = true;
            this.lblInscripcion.Location = new System.Drawing.Point(31, 171);
            this.lblInscripcion.Name = "lblInscripcion";
            this.lblInscripcion.Size = new System.Drawing.Size(106, 15);
            this.lblInscripcion.TabIndex = 15;
            this.lblInscripcion.Text = "Año de Inscripcion";
            // 
            // FormCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.lblInscripcion);
            this.Controls.Add(this.textInscripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.checkBoxEsSoloDocente);
            this.Controls.Add(this.lblAntiguedad);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.textSueldo);
            this.Controls.Add(this.textAntiguedad);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.checkBoxAsistir);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblNombre);
            this.Name = "FormCarga";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormCarga_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.CheckBox checkBoxAsistir;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox textAntiguedad;
        private System.Windows.Forms.TextBox textSueldo;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label lblAntiguedad;
        private System.Windows.Forms.CheckBox checkBoxEsSoloDocente;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textInscripcion;
        private System.Windows.Forms.Label lblInscripcion;
    }
}

