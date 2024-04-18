namespace _20240223_Practica_3_Parte_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonSum = new System.Windows.Forms.Button();
            this.botonRes = new System.Windows.Forms.Button();
            this.botonMul = new System.Windows.Forms.Button();
            this.botonDiv = new System.Windows.Forms.Button();
            this.operando1 = new System.Windows.Forms.TextBox();
            this.operando2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonSum
            // 
            this.botonSum.Location = new System.Drawing.Point(165, 240);
            this.botonSum.Name = "botonSum";
            this.botonSum.Size = new System.Drawing.Size(75, 23);
            this.botonSum.TabIndex = 0;
            this.botonSum.Text = "Sumar";
            this.botonSum.UseVisualStyleBackColor = true;
            this.botonSum.Click += new System.EventHandler(this.botonSum_Click);
            // 
            // botonRes
            // 
            this.botonRes.Location = new System.Drawing.Point(292, 240);
            this.botonRes.Name = "botonRes";
            this.botonRes.Size = new System.Drawing.Size(75, 23);
            this.botonRes.TabIndex = 1;
            this.botonRes.Text = "Restar";
            this.botonRes.UseVisualStyleBackColor = true;
            this.botonRes.Click += new System.EventHandler(this.botonRes_Click);
            // 
            // botonMul
            // 
            this.botonMul.Location = new System.Drawing.Point(416, 240);
            this.botonMul.Name = "botonMul";
            this.botonMul.Size = new System.Drawing.Size(75, 23);
            this.botonMul.TabIndex = 2;
            this.botonMul.Text = "Multiplicar";
            this.botonMul.UseVisualStyleBackColor = true;
            this.botonMul.Click += new System.EventHandler(this.botonMul_Click);
            // 
            // botonDiv
            // 
            this.botonDiv.Location = new System.Drawing.Point(532, 240);
            this.botonDiv.Name = "botonDiv";
            this.botonDiv.Size = new System.Drawing.Size(75, 23);
            this.botonDiv.TabIndex = 3;
            this.botonDiv.Text = "Dividir";
            this.botonDiv.UseVisualStyleBackColor = true;
            this.botonDiv.Click += new System.EventHandler(this.botonDiv_Click);
            // 
            // operando1
            // 
            this.operando1.Location = new System.Drawing.Point(355, 62);
            this.operando1.Name = "operando1";
            this.operando1.Size = new System.Drawing.Size(100, 20);
            this.operando1.TabIndex = 4;
            this.operando1.TextChanged += new System.EventHandler(this.operando1_TextChanged);
            // 
            // operando2
            // 
            this.operando2.Location = new System.Drawing.Point(355, 138);
            this.operando2.Name = "operando2";
            this.operando2.Size = new System.Drawing.Size(100, 20);
            this.operando2.TabIndex = 5;
            this.operando2.TextChanged += new System.EventHandler(this.operando2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Operando 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Operando 2:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 292);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.operando2);
            this.Controls.Add(this.operando1);
            this.Controls.Add(this.botonDiv);
            this.Controls.Add(this.botonMul);
            this.Controls.Add(this.botonRes);
            this.Controls.Add(this.botonSum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonSum;
        private System.Windows.Forms.Button botonRes;
        private System.Windows.Forms.Button botonMul;
        private System.Windows.Forms.Button botonDiv;
        private System.Windows.Forms.TextBox operando1;
        private System.Windows.Forms.TextBox operando2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

