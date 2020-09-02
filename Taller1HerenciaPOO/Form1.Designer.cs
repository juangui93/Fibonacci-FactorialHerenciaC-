namespace Taller1HerenciaPOO
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnCalcularFactorial = new System.Windows.Forms.Button();
            this.btnCalcularFibonacci = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFactorial = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(642, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÁLCULO DE FACTORIAL Y SERIE FIBONACCI DE UN NÚMERO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese un número: ";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(262, 88);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(116, 20);
            this.txtNumero.TabIndex = 2;
            // 
            // btnCalcularFactorial
            // 
            this.btnCalcularFactorial.Location = new System.Drawing.Point(430, 78);
            this.btnCalcularFactorial.Name = "btnCalcularFactorial";
            this.btnCalcularFactorial.Size = new System.Drawing.Size(98, 48);
            this.btnCalcularFactorial.TabIndex = 3;
            this.btnCalcularFactorial.Text = "Calcular Factorial";
            this.btnCalcularFactorial.UseVisualStyleBackColor = true;
            this.btnCalcularFactorial.Click += new System.EventHandler(this.btnCalcularFactorial_Click);
            // 
            // btnCalcularFibonacci
            // 
            this.btnCalcularFibonacci.Location = new System.Drawing.Point(556, 78);
            this.btnCalcularFibonacci.Name = "btnCalcularFibonacci";
            this.btnCalcularFibonacci.Size = new System.Drawing.Size(98, 48);
            this.btnCalcularFibonacci.TabIndex = 4;
            this.btnCalcularFibonacci.Text = "Calcular Serie Fibonacci";
            this.btnCalcularFibonacci.UseVisualStyleBackColor = true;
            this.btnCalcularFibonacci.Click += new System.EventHandler(this.btnCalcularFibonacci_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(798, 78);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(98, 48);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Factorial: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Serie Fibonacci: ";
            // 
            // lblFactorial
            // 
            this.lblFactorial.AutoSize = true;
            this.lblFactorial.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactorial.Location = new System.Drawing.Point(258, 129);
            this.lblFactorial.Name = "lblFactorial";
            this.lblFactorial.Size = new System.Drawing.Size(22, 24);
            this.lblFactorial.TabIndex = 8;
            this.lblFactorial.Text = "0";
            this.lblFactorial.Visible = false;
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.Location = new System.Drawing.Point(262, 165);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(120, 173);
            this.lb1.TabIndex = 9;
            this.lb1.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(678, 78);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(98, 48);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 335);
            this.ControlBox = false;
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.lblFactorial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcularFibonacci);
            this.Controls.Add(this.btnCalcularFactorial);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "FACTORIAL Y SERIE FIBONACCI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnCalcularFactorial;
        private System.Windows.Forms.Button btnCalcularFibonacci;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFactorial;
        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

