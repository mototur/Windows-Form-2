namespace Ahorro
{
    partial class AhorroDisponible
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
            label1 = new Label();
            label2 = new Label();
            Monto = new TextBox();
            label3 = new Label();
            Interes = new TextBox();
            label4 = new Label();
            Calcular = new Button();
            Años = new TextBox();
            Salir = new Button();
            Resultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(325, 24);
            label1.Name = "label1";
            label1.Size = new Size(145, 22);
            label1.TabIndex = 0;
            label1.Text = "CAPITAL FINAL";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 123);
            label2.Name = "label2";
            label2.Size = new Size(86, 18);
            label2.TabIndex = 1;
            label2.Text = "Monto Inicial";
            label2.Click += label2_Click;
            // 
            // Monto
            // 
            Monto.Location = new Point(51, 157);
            Monto.Name = "Monto";
            Monto.Size = new Size(86, 23);
            Monto.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(246, 124);
            label3.Name = "label3";
            label3.Size = new Size(69, 17);
            label3.TabIndex = 3;
            label3.Text = "Intereses";
            label3.Click += label3_Click;
            // 
            // Interes
            // 
            Interes.Location = new Point(227, 157);
            Interes.Name = "Interes";
            Interes.Size = new Size(118, 23);
            Interes.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(421, 124);
            label4.Name = "label4";
            label4.Size = new Size(119, 17);
            label4.TabIndex = 5;
            label4.Text = "Periodo en años";
            // 
            // Calcular
            // 
            Calcular.BackColor = Color.Orchid;
            Calcular.ForeColor = SystemColors.ActiveCaptionText;
            Calcular.Location = new Point(532, 247);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(113, 27);
            Calcular.TabIndex = 6;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = false;
            Calcular.Click += Calcular_Click;
            // 
            // Años
            // 
            Años.Location = new Point(421, 157);
            Años.Name = "Años";
            Años.Size = new Size(133, 23);
            Años.TabIndex = 7;
            // 
            // Salir
            // 
            Salir.BackColor = Color.IndianRed;
            Salir.Location = new Point(686, 258);
            Salir.Name = "Salir";
            Salir.Size = new Size(49, 24);
            Salir.TabIndex = 8;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = false;
            Salir.Click += Salir_Click;
            // 
            // Resultado
            // 
            Resultado.AutoSize = true;
            Resultado.Location = new Point(340, 253);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(59, 15);
            Resultado.TabIndex = 9;
            Resultado.Text = "Resultado";
            Resultado.Click += label5_Click;
            // 
            // AhorroDisponible
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(800, 450);
            Controls.Add(Resultado);
            Controls.Add(Salir);
            Controls.Add(Años);
            Controls.Add(Calcular);
            Controls.Add(label4);
            Controls.Add(Interes);
            Controls.Add(label3);
            Controls.Add(Monto);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AhorroDisponible";
            Text = "AHORRO";
            TransparencyKey = Color.Fuchsia;
            Load += AhorroDisponible_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Monto;
        private Label label3;
        private TextBox Interes;
        private Label label4;
        private Button Calcular;
        private TextBox Años;
        private Button Salir;
        private Label Resultado;
    }
}
