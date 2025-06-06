namespace Ejemplo2
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
            tbValor = new TextBox();
            btnRegistrar = new Button();
            lbResultado = new Label();
            Valor = new Label();
            label3 = new Label();
            tbResultado = new TextBox();
            btnCalcularPromedio = new Button();
            SuspendLayout();
            // 
            // tbValor
            // 
            tbValor.Location = new Point(117, 32);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(159, 29);
            tbValor.TabIndex = 0;
            tbValor.Text = "tbValor";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(304, 23);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 52);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.BackColor = SystemColors.ActiveCaption;
            lbResultado.Location = new Point(117, 82);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(92, 21);
            lbResultado.TabIndex = 2;
            lbResultado.Text = "lbResultado";
            // 
            // Valor
            // 
            Valor.AutoSize = true;
            Valor.Location = new Point(55, 35);
            Valor.Name = "Valor";
            Valor.Size = new Size(49, 21);
            Valor.TabIndex = 3;
            Valor.Text = "Valor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 82);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 4;
            label3.Text = "Promedio:";
            // 
            // tbResultado
            // 
            tbResultado.Location = new Point(12, 143);
            tbResultado.Multiline = true;
            tbResultado.Name = "tbResultado";
            tbResultado.Size = new Size(339, 89);
            tbResultado.TabIndex = 5;
            tbResultado.Text = "tbResultado";
            // 
            // btnCalcularPromedio
            // 
            btnCalcularPromedio.Location = new Point(304, 82);
            btnCalcularPromedio.Name = "btnCalcularPromedio";
            btnCalcularPromedio.Size = new Size(112, 55);
            btnCalcularPromedio.TabIndex = 6;
            btnCalcularPromedio.Text = "Calcular promedio";
            btnCalcularPromedio.UseVisualStyleBackColor = true;
            btnCalcularPromedio.Click += btnCalcularPromedio_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 240);
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
            Text = "Ejemplo2. Sin vector";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbValor;
        private Button btnRegistrar;
        private Label lbResultado;
        private Label Valor;
        private Label label3;
        private TextBox tbResultado;
        private Button btnCalcularPromedio;
    }
}
