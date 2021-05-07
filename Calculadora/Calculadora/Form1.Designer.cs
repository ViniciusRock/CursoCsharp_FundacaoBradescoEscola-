
namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(127, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÁLCULOS BÁSICOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(34, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "DIGITE O 1º NÚMERO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(34, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "DIGITE O 2º NÚMERO";
            // 
            // txtNum1
            // 
            this.txtNum1.AllowDrop = true;
            this.txtNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNum1.ForeColor = System.Drawing.Color.Red;
            this.txtNum1.Location = new System.Drawing.Point(234, 136);
            this.txtNum1.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.PlaceholderText = "Insira um número";
            this.txtNum1.Size = new System.Drawing.Size(213, 26);
            this.txtNum1.TabIndex = 3;
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNum2
            // 
            this.txtNum2.AllowDrop = true;
            this.txtNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNum2.ForeColor = System.Drawing.Color.Red;
            this.txtNum2.Location = new System.Drawing.Point(234, 163);
            this.txtNum2.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.PlaceholderText = "Insira um número";
            this.txtNum2.Size = new System.Drawing.Size(213, 26);
            this.txtNum2.TabIndex = 4;
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(79, 326);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "RESULTADO";
            // 
            // txtResultado
            // 
            this.txtResultado.AllowDrop = true;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtResultado.ForeColor = System.Drawing.Color.Red;
            this.txtResultado.Location = new System.Drawing.Point(204, 323);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(4);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.PlaceholderText = "Resultado da operação";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(213, 26);
            this.txtResultado.TabIndex = 10;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSomar
            // 
            this.btnSomar.BackColor = System.Drawing.Color.Lime;
            this.btnSomar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSomar.FlatAppearance.BorderSize = 0;
            this.btnSomar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnSomar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSomar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSomar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSomar.Location = new System.Drawing.Point(169, 197);
            this.btnSomar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(73, 55);
            this.btnSomar.TabIndex = 5;
            this.btnSomar.Text = "+";
            this.btnSomar.UseVisualStyleBackColor = false;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.BackColor = System.Drawing.Color.Lime;
            this.btnSubtrair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubtrair.FlatAppearance.BorderSize = 0;
            this.btnSubtrair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnSubtrair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSubtrair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtrair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSubtrair.Location = new System.Drawing.Point(250, 197);
            this.btnSubtrair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(73, 55);
            this.btnSubtrair.TabIndex = 6;
            this.btnSubtrair.Text = "-";
            this.btnSubtrair.UseVisualStyleBackColor = false;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.Color.Lime;
            this.btnMultiplicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultiplicar.FlatAppearance.BorderSize = 0;
            this.btnMultiplicar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnMultiplicar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplicar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMultiplicar.Location = new System.Drawing.Point(169, 260);
            this.btnMultiplicar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(73, 55);
            this.btnMultiplicar.TabIndex = 7;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.Color.Lime;
            this.btnDividir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDividir.FlatAppearance.BorderSize = 0;
            this.btnDividir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnDividir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDividir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDividir.Location = new System.Drawing.Point(250, 260);
            this.btnDividir.Margin = new System.Windows.Forms.Padding(4);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(73, 55);
            this.btnDividir.TabIndex = 11;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Lime;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpar.Location = new System.Drawing.Point(91, 356);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(126, 55);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Lime;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(325, 356);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(122, 55);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Calculadora.Properties.Resources.math1;
            this.ClientSize = new System.Drawing.Size(495, 435);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Básica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

