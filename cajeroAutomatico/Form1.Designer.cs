namespace cajeroAutomatico
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
            if(disposing && (components != null))
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
            this.components = new System.ComponentModel.Container();
            this.btnprocesar = new System.Windows.Forms.Button();
            this.lsbresultado = new System.Windows.Forms.ListBox();
            this.txtcancelar = new System.Windows.Forms.TextBox();
            this.lblcancelar = new System.Windows.Forms.Label();
            this.lblingresada = new System.Windows.Forms.Label();
            this.txtcantidaingresada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.erpCajeroAutomatico = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnfibo = new System.Windows.Forms.Button();
            this.lblresp = new System.Windows.Forms.Label();
            this.btnprimo = new System.Windows.Forms.Button();
            this.num = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.erpCajeroAutomatico)).BeginInit();
            this.SuspendLayout();
            // 
            // btnprocesar
            // 
            this.btnprocesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprocesar.Location = new System.Drawing.Point(65, 115);
            this.btnprocesar.Name = "btnprocesar";
            this.btnprocesar.Size = new System.Drawing.Size(137, 34);
            this.btnprocesar.TabIndex = 0;
            this.btnprocesar.Text = "PROCESAR";
            this.btnprocesar.UseVisualStyleBackColor = true;
            this.btnprocesar.Click += new System.EventHandler(this.btnprocesar_Click);
            // 
            // lsbresultado
            // 
            this.lsbresultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lsbresultado.FormattingEnabled = true;
            this.lsbresultado.Location = new System.Drawing.Point(15, 155);
            this.lsbresultado.Name = "lsbresultado";
            this.lsbresultado.Size = new System.Drawing.Size(227, 160);
            this.lsbresultado.TabIndex = 1;
            // 
            // txtcancelar
            // 
            this.txtcancelar.Location = new System.Drawing.Point(113, 67);
            this.txtcancelar.Name = "txtcancelar";
            this.txtcancelar.Size = new System.Drawing.Size(100, 20);
            this.txtcancelar.TabIndex = 2;
            this.txtcancelar.TextChanged += new System.EventHandler(this.txtcancelar_TextChanged);
            // 
            // lblcancelar
            // 
            this.lblcancelar.AutoSize = true;
            this.lblcancelar.Location = new System.Drawing.Point(12, 67);
            this.lblcancelar.Name = "lblcancelar";
            this.lblcancelar.Size = new System.Drawing.Size(91, 13);
            this.lblcancelar.TabIndex = 3;
            this.lblcancelar.Text = "Cantidad a pagar:";
            // 
            // lblingresada
            // 
            this.lblingresada.AutoSize = true;
            this.lblingresada.Location = new System.Drawing.Point(12, 28);
            this.lblingresada.Name = "lblingresada";
            this.lblingresada.Size = new System.Drawing.Size(101, 13);
            this.lblingresada.TabIndex = 5;
            this.lblingresada.Text = "Cantidad ingresada:";
            // 
            // txtcantidaingresada
            // 
            this.txtcantidaingresada.Location = new System.Drawing.Point(113, 28);
            this.txtcantidaingresada.Name = "txtcantidaingresada";
            this.txtcantidaingresada.Size = new System.Drawing.Size(100, 20);
            this.txtcantidaingresada.TabIndex = 4;
            this.txtcantidaingresada.TextChanged += new System.EventHandler(this.txtcantidaingresada_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // erpCajeroAutomatico
            // 
            this.erpCajeroAutomatico.ContainerControl = this;
            // 
            // btnfibo
            // 
            this.btnfibo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnfibo.Location = new System.Drawing.Point(251, 28);
            this.btnfibo.Name = "btnfibo";
            this.btnfibo.Size = new System.Drawing.Size(75, 23);
            this.btnfibo.TabIndex = 10;
            this.btnfibo.Text = "Fibonacci";
            this.btnfibo.UseVisualStyleBackColor = false;
            this.btnfibo.UseWaitCursor = true;
            this.btnfibo.Click += new System.EventHandler(this.btnfibo_Click);
            // 
            // lblresp
            // 
            this.lblresp.AutoSize = true;
            this.lblresp.BackColor = System.Drawing.Color.Red;
            this.lblresp.Location = new System.Drawing.Point(463, 28);
            this.lblresp.Name = "lblresp";
            this.lblresp.Size = new System.Drawing.Size(67, 13);
            this.lblresp.TabIndex = 13;
            this.lblresp.Text = "Respuesta ?";
            this.lblresp.UseWaitCursor = true;
            // 
            // btnprimo
            // 
            this.btnprimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnprimo.Location = new System.Drawing.Point(251, 83);
            this.btnprimo.Name = "btnprimo";
            this.btnprimo.Size = new System.Drawing.Size(75, 23);
            this.btnprimo.TabIndex = 14;
            this.btnprimo.Text = "Primo";
            this.btnprimo.UseVisualStyleBackColor = false;
            this.btnprimo.UseWaitCursor = true;
            this.btnprimo.Click += new System.EventHandler(this.btnprimo_Click);
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(343, 25);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(100, 20);
            this.num.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(640, 292);
            this.Controls.Add(this.num);
            this.Controls.Add(this.btnprimo);
            this.Controls.Add(this.lblresp);
            this.Controls.Add(this.btnfibo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblingresada);
            this.Controls.Add(this.txtcantidaingresada);
            this.Controls.Add(this.lblcancelar);
            this.Controls.Add(this.txtcancelar);
            this.Controls.Add(this.lsbresultado);
            this.Controls.Add(this.btnprocesar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cajero Automatico";
            ((System.ComponentModel.ISupportInitialize)(this.erpCajeroAutomatico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnprocesar;
        private System.Windows.Forms.ListBox lsbresultado;
        private System.Windows.Forms.TextBox txtcancelar;
        private System.Windows.Forms.Label lblcancelar;
        private System.Windows.Forms.Label lblingresada;
        private System.Windows.Forms.TextBox txtcantidaingresada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider erpCajeroAutomatico;
        private System.Windows.Forms.Button btnfibo;
        private System.Windows.Forms.Button btnprimo;
        private System.Windows.Forms.Label lblresp;
        private System.Windows.Forms.TextBox num;
    }
}

