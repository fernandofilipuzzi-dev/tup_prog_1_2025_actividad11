namespace Ejemplo3
{
    partial class FormPrincipal
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
            btnCalcularPromedio = new Button();
            tbResultado = new TextBox();
            label3 = new Label();
            Valor = new Label();
            lbResultado = new Label();
            btnRegistrar = new Button();
            tbValor = new TextBox();
            SuspendLayout();
            // 
            // btnCalcularPromedio
            // 
            btnCalcularPromedio.Location = new Point(302, 71);
            btnCalcularPromedio.Name = "btnCalcularPromedio";
            btnCalcularPromedio.Size = new Size(112, 55);
            btnCalcularPromedio.TabIndex = 13;
            btnCalcularPromedio.Text = "Calcular promedio";
            btnCalcularPromedio.UseVisualStyleBackColor = true;
            btnCalcularPromedio.Click += btnCalcularPromedio_Click;
            // 
            // tbResultado
            // 
            tbResultado.Location = new Point(10, 132);
            tbResultado.Multiline = true;
            tbResultado.Name = "tbResultado";
            tbResultado.Size = new Size(339, 89);
            tbResultado.TabIndex = 12;
            tbResultado.Text = "tbResultado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 71);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 11;
            label3.Text = "Promedio:";
            // 
            // Valor
            // 
            Valor.AutoSize = true;
            Valor.Location = new Point(53, 24);
            Valor.Name = "Valor";
            Valor.Size = new Size(49, 21);
            Valor.TabIndex = 10;
            Valor.Text = "Valor:";
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.BackColor = SystemColors.ActiveCaption;
            lbResultado.Location = new Point(115, 71);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(92, 21);
            lbResultado.TabIndex = 9;
            lbResultado.Text = "lbResultado";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(302, 12);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 52);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // tbValor
            // 
            tbValor.Location = new Point(115, 21);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(159, 29);
            tbValor.TabIndex = 7;
            tbValor.Text = "tbValor";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 230);
            Controls.Add(btnCalcularPromedio);
            Controls.Add(tbResultado);
            Controls.Add(label3);
            Controls.Add(Valor);
            Controls.Add(lbResultado);
            Controls.Add(btnRegistrar);
            Controls.Add(tbValor);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejemplo 3. Con vectores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcularPromedio;
        private TextBox tbResultado;
        private Label label3;
        private Label Valor;
        private Label lbResultado;
        private Button btnRegistrar;
        private TextBox tbValor;
    }
}
