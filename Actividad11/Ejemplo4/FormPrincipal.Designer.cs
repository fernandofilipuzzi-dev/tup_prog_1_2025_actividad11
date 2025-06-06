namespace Ejemplo4
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
            tbBuscar = new TextBox();
            btnBuscar = new Button();
            btnListarOrdenado = new Button();
            SuspendLayout();
            // 
            // btnCalcularPromedio
            // 
            btnCalcularPromedio.Location = new Point(306, 71);
            btnCalcularPromedio.Name = "btnCalcularPromedio";
            btnCalcularPromedio.Size = new Size(112, 55);
            btnCalcularPromedio.TabIndex = 20;
            btnCalcularPromedio.Text = "Calcular promedio";
            btnCalcularPromedio.UseVisualStyleBackColor = true;
            btnCalcularPromedio.Click += btnCalcularPromedio_Click;
            // 
            // tbResultado
            // 
            tbResultado.Location = new Point(22, 198);
            tbResultado.Multiline = true;
            tbResultado.Name = "tbResultado";
            tbResultado.Size = new Size(306, 89);
            tbResultado.TabIndex = 19;
            tbResultado.Text = "tbResultado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 71);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 18;
            label3.Text = "Promedio:";
            // 
            // Valor
            // 
            Valor.AutoSize = true;
            Valor.Location = new Point(57, 24);
            Valor.Name = "Valor";
            Valor.Size = new Size(49, 21);
            Valor.TabIndex = 17;
            Valor.Text = "Valor:";
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.BackColor = SystemColors.ActiveCaption;
            lbResultado.Location = new Point(119, 71);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(92, 21);
            lbResultado.TabIndex = 16;
            lbResultado.Text = "lbResultado";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(306, 12);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 52);
            btnRegistrar.TabIndex = 15;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // tbValor
            // 
            tbValor.Location = new Point(119, 21);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(159, 29);
            tbValor.TabIndex = 14;
            tbValor.Text = "tbValor";
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(22, 149);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.Size = new Size(159, 29);
            tbBuscar.TabIndex = 21;
            tbBuscar.Text = "tbBuscar";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(199, 143);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 39);
            btnBuscar.TabIndex = 22;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnListarOrdenado
            // 
            btnListarOrdenado.Location = new Point(334, 209);
            btnListarOrdenado.Name = "btnListarOrdenado";
            btnListarOrdenado.Size = new Size(93, 54);
            btnListarOrdenado.TabIndex = 23;
            btnListarOrdenado.Text = "Listado Ordenado";
            btnListarOrdenado.UseVisualStyleBackColor = true;
            btnListarOrdenado.Click += btnListarOrdenado_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 296);
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
            Text = "Ejemplo 4. Busqueda y Ordenamiento";
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
        private TextBox tbBuscar;
        private Button btnBuscar;
        private Button btnListarOrdenado;
    }
}
