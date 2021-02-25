
namespace ejercicio
{
    partial class frmempleado
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
            this.txtpaterno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmaterno = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsegurosocial = new System.Windows.Forms.TextBox();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcontrato = new System.Windows.Forms.Label();
            this.cmdsexo = new System.Windows.Forms.ComboBox();
            this.cmdempleado = new System.Windows.Forms.ComboBox();
            this.cmdcontrato = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvempleado = new System.Windows.Forms.DataGridView();
            this.appaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apmaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipocontrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomseguro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnguardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpaterno
            // 
            this.txtpaterno.Location = new System.Drawing.Point(21, 63);
            this.txtpaterno.Name = "txtpaterno";
            this.txtpaterno.Size = new System.Drawing.Size(111, 20);
            this.txtpaterno.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "APELLIDO PATERNO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "APELLIDO MATERNO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtmaterno
            // 
            this.txtmaterno.Location = new System.Drawing.Point(209, 63);
            this.txtmaterno.Name = "txtmaterno";
            this.txtmaterno.Size = new System.Drawing.Size(113, 20);
            this.txtmaterno.TabIndex = 3;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(376, 63);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "NOMBRE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(613, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "GENERO";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtsegurosocial
            // 
            this.txtsegurosocial.Location = new System.Drawing.Point(30, 163);
            this.txtsegurosocial.Name = "txtsegurosocial";
            this.txtsegurosocial.Size = new System.Drawing.Size(142, 20);
            this.txtsegurosocial.TabIndex = 8;
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(209, 164);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(100, 20);
            this.txtcedula.TabIndex = 9;
            this.txtcedula.TextChanged += new System.EventHandler(this.txtcedula_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "NUMERO SEGURO SOCIAL";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "CEDULA";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(395, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "TIPO DE EMPLEADO";
            // 
            // txtcontrato
            // 
            this.txtcontrato.AutoSize = true;
            this.txtcontrato.Location = new System.Drawing.Point(583, 133);
            this.txtcontrato.Name = "txtcontrato";
            this.txtcontrato.Size = new System.Drawing.Size(114, 13);
            this.txtcontrato.TabIndex = 15;
            this.txtcontrato.Text = "TIPO DE CONTRADO";
            this.txtcontrato.Click += new System.EventHandler(this.txtcontrato_Click);
            // 
            // cmdsexo
            // 
            this.cmdsexo.FormattingEnabled = true;
            this.cmdsexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.cmdsexo.Location = new System.Drawing.Point(576, 63);
            this.cmdsexo.Name = "cmdsexo";
            this.cmdsexo.Size = new System.Drawing.Size(121, 21);
            this.cmdsexo.TabIndex = 16;
            // 
            // cmdempleado
            // 
            this.cmdempleado.FormattingEnabled = true;
            this.cmdempleado.Items.AddRange(new object[] {
            "GERENTE",
            "VENDEDOR"});
            this.cmdempleado.Location = new System.Drawing.Point(376, 163);
            this.cmdempleado.Name = "cmdempleado";
            this.cmdempleado.Size = new System.Drawing.Size(121, 21);
            this.cmdempleado.TabIndex = 17;
            // 
            // cmdcontrato
            // 
            this.cmdcontrato.FormattingEnabled = true;
            this.cmdcontrato.Items.AddRange(new object[] {
            "NUEVO ",
            "LONGEVO"});
            this.cmdcontrato.Location = new System.Drawing.Point(576, 163);
            this.cmdcontrato.Name = "cmdcontrato";
            this.cmdcontrato.Size = new System.Drawing.Size(121, 21);
            this.cmdcontrato.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmdcontrato);
            this.groupBox1.Controls.Add(this.txtpaterno);
            this.groupBox1.Controls.Add(this.cmdempleado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmdsexo);
            this.groupBox1.Controls.Add(this.txtsegurosocial);
            this.groupBox1.Controls.Add(this.txtcontrato);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtmaterno);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtcedula);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 212);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CLIENTE";
            // 
            // dgvempleado
            // 
            this.dgvempleado.AllowUserToAddRows = false;
            this.dgvempleado.AllowUserToOrderColumns = true;
            this.dgvempleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvempleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appaterno,
            this.apmaterno,
            this.nombre,
            this.sexo,
            this.tipo,
            this.tipocontrato,
            this.nomseguro});
            this.dgvempleado.Location = new System.Drawing.Point(12, 230);
            this.dgvempleado.Name = "dgvempleado";
            this.dgvempleado.Size = new System.Drawing.Size(1006, 207);
            this.dgvempleado.TabIndex = 20;
            // 
            // appaterno
            // 
            this.appaterno.HeaderText = "APELLIDO PATERNO";
            this.appaterno.Name = "appaterno";
            this.appaterno.Width = 150;
            // 
            // apmaterno
            // 
            this.apmaterno.HeaderText = "APELLIDO MARTERNO";
            this.apmaterno.Name = "apmaterno";
            this.apmaterno.Width = 150;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            // 
            // sexo
            // 
            this.sexo.HeaderText = "SEXO";
            this.sexo.Name = "sexo";
            // 
            // tipo
            // 
            this.tipo.HeaderText = "TIPO DE EMPLEADO";
            this.tipo.Name = "tipo";
            this.tipo.Width = 150;
            // 
            // tipocontrato
            // 
            this.tipocontrato.HeaderText = "TIPO DE CONTRATO";
            this.tipocontrato.Name = "tipocontrato";
            this.tipocontrato.Width = 150;
            // 
            // nomseguro
            // 
            this.nomseguro.HeaderText = "NOMBRE DE SEGURO SOCIAL";
            this.nomseguro.Name = "nomseguro";
            this.nomseguro.Width = 200;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(875, 94);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(129, 88);
            this.btnguardar.TabIndex = 21;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(846, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmempleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 467);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.dgvempleado);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmempleado";
            this.Text = "ingreso de empleados";
            this.Load += new System.EventHandler(this.frmempleado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtpaterno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmaterno;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsegurosocial;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtcontrato;
        private System.Windows.Forms.ComboBox cmdsexo;
        private System.Windows.Forms.ComboBox cmdempleado;
        private System.Windows.Forms.ComboBox cmdcontrato;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvempleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn appaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn apmaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipocontrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomseguro;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button button1;
    }
}