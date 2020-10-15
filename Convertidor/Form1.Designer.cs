namespace Convertidor
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
            this.btnConvertir = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.rbDolares = new System.Windows.Forms.RadioButton();
            this.rbPesos = new System.Windows.Forms.RadioButton();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbCantidadP = new System.Windows.Forms.RadioButton();
            this.rbCantidadD = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(621, 87);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 0;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(51, 90);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 1;
            // 
            // rbDolares
            // 
            this.rbDolares.AutoSize = true;
            this.rbDolares.Location = new System.Drawing.Point(25, 41);
            this.rbDolares.Name = "rbDolares";
            this.rbDolares.Size = new System.Drawing.Size(61, 17);
            this.rbDolares.TabIndex = 2;
            this.rbDolares.TabStop = true;
            this.rbDolares.Text = "Dolares";
            this.rbDolares.UseVisualStyleBackColor = true;
            // 
            // rbPesos
            // 
            this.rbPesos.AutoSize = true;
            this.rbPesos.Location = new System.Drawing.Point(25, 111);
            this.rbPesos.Name = "rbPesos";
            this.rbPesos.Size = new System.Drawing.Size(54, 17);
            this.rbPesos.TabIndex = 3;
            this.rbPesos.TabStop = true;
            this.rbPesos.Text = "Pesos";
            this.rbPesos.UseVisualStyleBackColor = true;
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta.Location = new System.Drawing.Point(48, 320);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(0, 24);
            this.lblRespuesta.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cantidad";
            // 
            // rbCantidadP
            // 
            this.rbCantidadP.AutoSize = true;
            this.rbCantidadP.Location = new System.Drawing.Point(20, 111);
            this.rbCantidadP.Name = "rbCantidadP";
            this.rbCantidadP.Size = new System.Drawing.Size(54, 17);
            this.rbCantidadP.TabIndex = 8;
            this.rbCantidadP.TabStop = true;
            this.rbCantidadP.Text = "Pesos";
            this.rbCantidadP.UseVisualStyleBackColor = true;
            // 
            // rbCantidadD
            // 
            this.rbCantidadD.AutoSize = true;
            this.rbCantidadD.Location = new System.Drawing.Point(20, 41);
            this.rbCantidadD.Name = "rbCantidadD";
            this.rbCantidadD.Size = new System.Drawing.Size(61, 17);
            this.rbCantidadD.TabIndex = 7;
            this.rbCantidadD.TabStop = true;
            this.rbCantidadD.Text = "Dolares";
            this.rbCantidadD.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCantidadD);
            this.groupBox1.Controls.Add(this.rbCantidadP);
            this.groupBox1.Location = new System.Drawing.Point(196, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 227);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cantidad en";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbDolares);
            this.groupBox2.Controls.Add(this.rbPesos);
            this.groupBox2.Location = new System.Drawing.Point(343, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(125, 227);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Convertir a";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnConvertir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.RadioButton rbDolares;
        private System.Windows.Forms.RadioButton rbPesos;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbCantidadP;
        private System.Windows.Forms.RadioButton rbCantidadD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

