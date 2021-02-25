
namespace ejercicio
{
    partial class frmportada
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
            this.gboportada = new System.Windows.Forms.GroupBox();
            this.btncliente = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnempleado = new System.Windows.Forms.Button();
            this.gboportada.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboportada
            // 
            this.gboportada.Controls.Add(this.btncliente);
            this.gboportada.Controls.Add(this.btnsalir);
            this.gboportada.Controls.Add(this.btnempleado);
            this.gboportada.Location = new System.Drawing.Point(12, 119);
            this.gboportada.Name = "gboportada";
            this.gboportada.Size = new System.Drawing.Size(776, 274);
            this.gboportada.TabIndex = 6;
            this.gboportada.TabStop = false;
            this.gboportada.Text = "portada";
            // 
            // btncliente
            // 
            this.btncliente.Location = new System.Drawing.Point(583, 155);
            this.btncliente.Name = "btncliente";
            this.btncliente.Size = new System.Drawing.Size(77, 34);
            this.btncliente.TabIndex = 2;
            this.btncliente.Text = "cliente";
            this.btncliente.UseVisualStyleBackColor = true;
            this.btncliente.Click += new System.EventHandler(this.btncliente_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(334, 148);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(106, 49);
            this.btnsalir.TabIndex = 1;
            this.btnsalir.Text = "salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnempleado
            // 
            this.btnempleado.Location = new System.Drawing.Point(206, 148);
            this.btnempleado.Name = "btnempleado";
            this.btnempleado.Size = new System.Drawing.Size(63, 34);
            this.btnempleado.TabIndex = 0;
            this.btnempleado.Text = "empledo";
            this.btnempleado.UseVisualStyleBackColor = true;
            this.btnempleado.Click += new System.EventHandler(this.btnempleado_Click);
            // 
            // frmportada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::ejercicio.Properties.Resources.descarga__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gboportada);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmportada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmportada";
            this.Load += new System.EventHandler(this.frmportada_Load);
            this.gboportada.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboportada;
        private System.Windows.Forms.Button btncliente;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnempleado;
    }
}