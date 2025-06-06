namespace Ejemplo5
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
            SuspendLayout();
            // 
            // btnListarOrdenado
            // 
            btnListarOrdenado.Location = new Point(327, 209);
            btnListarOrdenado.Name = "btnListarOrdenado";
            btnListarOrdenado.Size = new Size(93, 54);
            btnListarOrdenado.TabIndex = 33;
            btnListarOrdenado.Text = "Listado Ordenado";
            btnListarOrdenado.UseVisualStyleBackColor = true;
            btnListarOrdenado.Click += btnListarOrdenado_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(192, 143);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 39);
            btnBuscar.TabIndex = 32;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(15, 149);
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
            tbResultado.Location = new Point(15, 198);
            tbResultado.Multiline = true;
            tbResultado.Name = "tbResultado";
            tbResultado.Size = new Size(306, 89);
            tbResultado.TabIndex = 29;
            tbResultado.Text = "tbResultado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 71);
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
            lbResultado.Location = new Point(112, 71);
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
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 295);
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
            Margin = new Padding(4);
            Name = "FormPrincipal";
            Text = "Form1";
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
    }
}
