namespace PromedioNotas
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnota1 = new System.Windows.Forms.TextBox();
            this.txtnota2 = new System.Windows.Forms.TextBox();
            this.txtnota3 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblpromedio = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(69, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota 1 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(69, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nota 2 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(69, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nota 3 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(196, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(450, 37);
            this.label5.TabIndex = 5;
            this.label5.Text = "Promedio de Calificaciones ";
            // 
            // txtnota1
            // 
            this.txtnota1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnota1.Location = new System.Drawing.Point(189, 179);
            this.txtnota1.Name = "txtnota1";
            this.txtnota1.Size = new System.Drawing.Size(100, 35);
            this.txtnota1.TabIndex = 6;
            // 
            // txtnota2
            // 
            this.txtnota2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnota2.Location = new System.Drawing.Point(189, 235);
            this.txtnota2.Name = "txtnota2";
            this.txtnota2.Size = new System.Drawing.Size(100, 35);
            this.txtnota2.TabIndex = 7;
            this.txtnota2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtnota3
            // 
            this.txtnota3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnota3.Location = new System.Drawing.Point(189, 294);
            this.txtnota3.Name = "txtnota3";
            this.txtnota3.Size = new System.Drawing.Size(100, 35);
            this.txtnota3.TabIndex = 8;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcular.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(338, 220);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(115, 66);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(493, 220);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(115, 66);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblpromedio
            // 
            this.lblpromedio.AutoSize = true;
            this.lblpromedio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpromedio.Location = new System.Drawing.Point(140, 374);
            this.lblpromedio.Name = "lblpromedio";
            this.lblpromedio.Size = new System.Drawing.Size(149, 32);
            this.lblpromedio.TabIndex = 11;
            this.lblpromedio.Text = "Promedio:";
            this.lblpromedio.Visible = false;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(304, 374);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(0, 32);
            this.lblresultado.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblpromedio);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtnota3);
            this.Controls.Add(this.txtnota2);
            this.Controls.Add(this.txtnota1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnota1;
        private System.Windows.Forms.TextBox txtnota2;
        private System.Windows.Forms.TextBox txtnota3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblpromedio;
        private System.Windows.Forms.Label lblresultado;
    }
}

