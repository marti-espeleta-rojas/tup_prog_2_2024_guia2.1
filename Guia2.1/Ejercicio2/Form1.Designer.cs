namespace Ejercicio2
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
            this.btnRegistrarEmpleado = new System.Windows.Forms.Button();
            this.btnRegistrarLiquidaciones = new System.Windows.Forms.Button();
            this.btnMostrarLiquidaciones = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnRegistrarEmpleado
            // 
            this.btnRegistrarEmpleado.Location = new System.Drawing.Point(32, 36);
            this.btnRegistrarEmpleado.Name = "btnRegistrarEmpleado";
            this.btnRegistrarEmpleado.Size = new System.Drawing.Size(136, 41);
            this.btnRegistrarEmpleado.TabIndex = 0;
            this.btnRegistrarEmpleado.Text = "Registrar Empleado";
            this.btnRegistrarEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarLiquidaciones
            // 
            this.btnRegistrarLiquidaciones.Location = new System.Drawing.Point(310, 36);
            this.btnRegistrarLiquidaciones.Name = "btnRegistrarLiquidaciones";
            this.btnRegistrarLiquidaciones.Size = new System.Drawing.Size(136, 41);
            this.btnRegistrarLiquidaciones.TabIndex = 1;
            this.btnRegistrarLiquidaciones.Text = "Generar Liquidaciones";
            this.btnRegistrarLiquidaciones.UseVisualStyleBackColor = true;
            // 
            // btnMostrarLiquidaciones
            // 
            this.btnMostrarLiquidaciones.Location = new System.Drawing.Point(560, 36);
            this.btnMostrarLiquidaciones.Name = "btnMostrarLiquidaciones";
            this.btnMostrarLiquidaciones.Size = new System.Drawing.Size(136, 41);
            this.btnMostrarLiquidaciones.TabIndex = 2;
            this.btnMostrarLiquidaciones.Text = "Mostrar Liquidaciones";
            this.btnMostrarLiquidaciones.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(32, 97);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(664, 316);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnMostrarLiquidaciones);
            this.Controls.Add(this.btnRegistrarLiquidaciones);
            this.Controls.Add(this.btnRegistrarEmpleado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarEmpleado;
        private System.Windows.Forms.Button btnRegistrarLiquidaciones;
        private System.Windows.Forms.Button btnMostrarLiquidaciones;
        private System.Windows.Forms.ListBox listBox1;
    }
}

