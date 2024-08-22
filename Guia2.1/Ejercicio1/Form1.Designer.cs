namespace Ejercicio1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnListarRegistros = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbxListarRegistros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(415, 28);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(114, 45);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnListarRegistros
            // 
            this.btnListarRegistros.Location = new System.Drawing.Point(415, 129);
            this.btnListarRegistros.Name = "btnListarRegistros";
            this.btnListarRegistros.Size = new System.Drawing.Size(114, 50);
            this.btnListarRegistros.TabIndex = 1;
            this.btnListarRegistros.Text = "Listar Registros";
            this.btnListarRegistros.UseVisualStyleBackColor = true;
            this.btnListarRegistros.Click += new System.EventHandler(this.btnListarRegistros_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(376, 95);
            this.textBox1.TabIndex = 2;
            // 
            // lbxListarRegistros
            // 
            this.lbxListarRegistros.FormattingEnabled = true;
            this.lbxListarRegistros.Location = new System.Drawing.Point(33, 130);
            this.lbxListarRegistros.Name = "lbxListarRegistros";
            this.lbxListarRegistros.Size = new System.Drawing.Size(376, 121);
            this.lbxListarRegistros.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 261);
            this.Controls.Add(this.lbxListarRegistros);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnListarRegistros);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnListarRegistros;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lbxListarRegistros;
    }
}

