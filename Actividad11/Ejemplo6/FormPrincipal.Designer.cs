namespace Ejemplo6
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
            btnListarOrdenado = new Button();
            btnBuscar = new Button();
            tbBuscar = new TextBox();
            btnCalcularPromedio = new Button();
            tbResultado = new TextBox();
            label3 = new Label();
            Valor = new Label();
            lbResultado = new Label();
            btnRegistrar = new Button();
            tbValor = new TextBox();
            label4 = new Label();
            lbMinimo = new Label();
            label1 = new Label();
            lbMaximo = new Label();
            btnMinimo = new Button();
            btnMaximo = new Button();
            btnMayoresAlPromedio = new Button();
            SuspendLayout();
            // 
            // btnListarOrdenado
            // 
            btnListarOrdenado.Location = new Point(286, 340);
            btnListarOrdenado.Name = "btnListarOrdenado";
            btnListarOrdenado.Size = new Size(136, 54);
            btnListarOrdenado.TabIndex = 33;
            btnListarOrdenado.Text = "Listado Ordenado";
            btnListarOrdenado.UseVisualStyleBackColor = true;
            btnListarOrdenado.Click += btnListarOrdenado_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(194, 285);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 39);
            btnBuscar.TabIndex = 32;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(17, 291);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.Size = new Size(159, 29);
            tbBuscar.TabIndex = 31;
            tbBuscar.Text = "tbBuscar";
            // 
            // btnCalcularPromedio
            // 
            btnCalcularPromedio.Location = new Point(299, 71);
            btnCalcularPromedio.Name = "btnCalcularPromedio";
            btnCalcularPromedio.Size = new Size(112, 55);
            btnCalcularPromedio.TabIndex = 30;
            btnCalcularPromedio.Text = "Calcular promedio";
            btnCalcularPromedio.UseVisualStyleBackColor = true;
            btnCalcularPromedio.Click += btnCalcularPromedio_Click;
            // 
            // tbResultado
            // 
            tbResultado.Location = new Point(17, 340);
            tbResultado.Multiline = true;
            tbResultado.Name = "tbResultado";
            tbResultado.Size = new Size(263, 142);
            tbResultado.TabIndex = 29;
            tbResultado.Text = "tbResultado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 88);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 28;
            label3.Text = "Promedio:";
            // 
            // Valor
            // 
            Valor.AutoSize = true;
            Valor.Location = new Point(50, 24);
            Valor.Name = "Valor";
            Valor.Size = new Size(49, 21);
            Valor.TabIndex = 27;
            Valor.Text = "Valor:";
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.BackColor = SystemColors.ActiveCaption;
            lbResultado.Location = new Point(117, 88);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(92, 21);
            lbResultado.TabIndex = 26;
            lbResultado.Text = "lbResultado";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(299, 12);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 52);
            btnRegistrar.TabIndex = 25;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // tbValor
            // 
            tbValor.Location = new Point(112, 21);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(159, 29);
            tbValor.TabIndex = 24;
            tbValor.Text = "tbValor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 239);
            label4.Name = "label4";
            label4.Size = new Size(67, 21);
            label4.TabIndex = 45;
            label4.Text = "Mínimo:";
            // 
            // lbMinimo
            // 
            lbMinimo.AutoSize = true;
            lbMinimo.BackColor = SystemColors.ActiveCaption;
            lbMinimo.Location = new Point(130, 239);
            lbMinimo.Name = "lbMinimo";
            lbMinimo.Size = new Size(77, 21);
            lbMinimo.TabIndex = 44;
            lbMinimo.Text = "lbMinimo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 173);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 43;
            label1.Text = "Máximo:";
            // 
            // lbMaximo
            // 
            lbMaximo.AutoSize = true;
            lbMaximo.BackColor = SystemColors.ActiveCaption;
            lbMaximo.Location = new Point(130, 173);
            lbMaximo.Name = "lbMaximo";
            lbMaximo.Size = new Size(79, 21);
            lbMaximo.TabIndex = 42;
            lbMaximo.Text = "lbMaximo";
            // 
            // btnMinimo
            // 
            btnMinimo.Location = new Point(246, 202);
            btnMinimo.Name = "btnMinimo";
            btnMinimo.Size = new Size(165, 38);
            btnMinimo.TabIndex = 41;
            btnMinimo.Text = "Calcular Mínimo";
            btnMinimo.UseVisualStyleBackColor = true;
            btnMinimo.Click += btnMinimo_Click;
            // 
            // btnMaximo
            // 
            btnMaximo.Location = new Point(246, 132);
            btnMaximo.Name = "btnMaximo";
            btnMaximo.Size = new Size(165, 40);
            btnMaximo.TabIndex = 40;
            btnMaximo.Text = "Calcular Máximo";
            btnMaximo.UseVisualStyleBackColor = true;
            btnMaximo.Click += btnMaximo_Click;
            // 
            // btnMayoresAlPromedio
            // 
            btnMayoresAlPromedio.Location = new Point(286, 398);
            btnMayoresAlPromedio.Name = "btnMayoresAlPromedio";
            btnMayoresAlPromedio.Size = new Size(136, 84);
            btnMayoresAlPromedio.TabIndex = 46;
            btnMayoresAlPromedio.Text = "Listado Superiores al promedio";
            btnMayoresAlPromedio.UseVisualStyleBackColor = true;
            btnMayoresAlPromedio.Click += btnMayoresAlPromedio_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 494);
            Controls.Add(btnMayoresAlPromedio);
            Controls.Add(label4);
            Controls.Add(lbMinimo);
            Controls.Add(label1);
            Controls.Add(lbMaximo);
            Controls.Add(btnMinimo);
            Controls.Add(btnMaximo);
            Controls.Add(btnListarOrdenado);
            Controls.Add(btnBuscar);
            Controls.Add(tbBuscar);
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
            Text = "Ejemplo 6. Todo en la clase Servicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListarOrdenado;
        private Button btnBuscar;
        private TextBox tbBuscar;
        private Button btnCalcularPromedio;
        private TextBox tbResultado;
        private Label label3;
        private Label Valor;
        private Label lbResultado;
        private Button btnRegistrar;
        private TextBox tbValor;
        private Label label4;
        private Label lbMinimo;
        private Label label1;
        private Label lbMaximo;
        private Button btnMinimo;
        private Button btnMaximo;
        private Button btnMayoresAlPromedio;
    }
}
