namespace EjemploUnoPOO
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtnumero1 = new System.Windows.Forms.TextBox();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.btnsumar = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.btndividir = new System.Windows.Forms.Button();
            this.btnmultiplicar = new System.Windows.Forms.Button();
            this.btnrestar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Súper Calculadora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa el primer número:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresa el segundo número:";
            // 
            // txtnumero1
            // 
            this.txtnumero1.Location = new System.Drawing.Point(410, 166);
            this.txtnumero1.Name = "txtnumero1";
            this.txtnumero1.Size = new System.Drawing.Size(100, 20);
            this.txtnumero1.TabIndex = 3;
            // 
            // txtnumero2
            // 
            this.txtnumero2.Location = new System.Drawing.Point(410, 200);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(100, 20);
            this.txtnumero2.TabIndex = 4;
            // 
            // btnsumar
            // 
            this.btnsumar.Location = new System.Drawing.Point(534, 135);
            this.btnsumar.Name = "btnsumar";
            this.btnsumar.Size = new System.Drawing.Size(75, 23);
            this.btnsumar.TabIndex = 5;
            this.btnsumar.Text = "Sumar";
            this.btnsumar.UseVisualStyleBackColor = true;
            this.btnsumar.Click += new System.EventHandler(this.btncumar_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(392, 264);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(55, 13);
            this.lblresultado.TabIndex = 6;
            this.lblresultado.Text = "Resultado";
            this.lblresultado.Visible = false;
            // 
            // btndividir
            // 
            this.btndividir.Location = new System.Drawing.Point(534, 224);
            this.btndividir.Name = "btndividir";
            this.btndividir.Size = new System.Drawing.Size(75, 23);
            this.btndividir.TabIndex = 7;
            this.btndividir.Text = "dividir";
            this.btndividir.UseVisualStyleBackColor = true;
            this.btndividir.Click += new System.EventHandler(this.btndividir_Click);
            // 
            // btnmultiplicar
            // 
            this.btnmultiplicar.Location = new System.Drawing.Point(534, 195);
            this.btnmultiplicar.Name = "btnmultiplicar";
            this.btnmultiplicar.Size = new System.Drawing.Size(75, 23);
            this.btnmultiplicar.TabIndex = 8;
            this.btnmultiplicar.Text = "Multiplicar";
            this.btnmultiplicar.UseVisualStyleBackColor = true;
            this.btnmultiplicar.Click += new System.EventHandler(this.btnmultiplicar_Click);
            // 
            // btnrestar
            // 
            this.btnrestar.Location = new System.Drawing.Point(534, 166);
            this.btnrestar.Name = "btnrestar";
            this.btnrestar.Size = new System.Drawing.Size(75, 23);
            this.btnrestar.TabIndex = 9;
            this.btnrestar.Text = "Restar";
            this.btnrestar.UseVisualStyleBackColor = true;
            this.btnrestar.Click += new System.EventHandler(this.btnrestar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnrestar);
            this.Controls.Add(this.btnmultiplicar);
            this.Controls.Add(this.btndividir);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btnsumar);
            this.Controls.Add(this.txtnumero2);
            this.Controls.Add(this.txtnumero1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnumero1;
        private System.Windows.Forms.TextBox txtnumero2;
        private System.Windows.Forms.Button btnsumar;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button btndividir;
        private System.Windows.Forms.Button btnmultiplicar;
        private System.Windows.Forms.Button btnrestar;
    }
}

