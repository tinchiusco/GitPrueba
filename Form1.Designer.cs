namespace ReciboSueldo
{
    partial class gbResultado
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
            labelEmpleado = new Label();
            labelAntiguedad = new Label();
            labelHorasTrabajadas = new Label();
            btnCalcular = new Button();
            txtNombre = new TextBox();
            numAntiguedad = new NumericUpDown();
            numHorasTrabajadas = new NumericUpDown();
            gbResultados = new GroupBox();
            lblTotalNeto = new Label();
            lblTotalDescuentos = new Label();
            lblTotalCobrar = new Label();
            btnCerrar = new Button();
            lblValorHora = new Label();
            numValorHora = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numAntiguedad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHorasTrabajadas).BeginInit();
            gbResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numValorHora).BeginInit();
            SuspendLayout();
            // 
            // labelEmpleado
            // 
            labelEmpleado.AutoSize = true;
            labelEmpleado.Location = new Point(66, 71);
            labelEmpleado.Name = "labelEmpleado";
            labelEmpleado.Size = new Size(54, 15);
            labelEmpleado.TabIndex = 0;
            labelEmpleado.Text = "Nombre:";
            // 
            // labelAntiguedad
            // 
            labelAntiguedad.AutoSize = true;
            labelAntiguedad.Location = new Point(66, 135);
            labelAntiguedad.Name = "labelAntiguedad";
            labelAntiguedad.Size = new Size(72, 15);
            labelAntiguedad.TabIndex = 1;
            labelAntiguedad.Text = "Antiguedad:";
            // 
            // labelHorasTrabajadas
            // 
            labelHorasTrabajadas.AutoSize = true;
            labelHorasTrabajadas.Location = new Point(66, 199);
            labelHorasTrabajadas.Name = "labelHorasTrabajadas";
            labelHorasTrabajadas.Size = new Size(99, 15);
            labelHorasTrabajadas.TabIndex = 2;
            labelHorasTrabajadas.Text = "Horas Trabajadas:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(66, 317);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(186, 65);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(197, 63);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(193, 23);
            txtNombre.TabIndex = 4;
            // 
            // numAntiguedad
            // 
            numAntiguedad.Location = new Point(197, 127);
            numAntiguedad.Name = "numAntiguedad";
            numAntiguedad.Size = new Size(120, 23);
            numAntiguedad.TabIndex = 5;
            // 
            // numHorasTrabajadas
            // 
            numHorasTrabajadas.Location = new Point(197, 191);
            numHorasTrabajadas.Name = "numHorasTrabajadas";
            numHorasTrabajadas.Size = new Size(120, 23);
            numHorasTrabajadas.TabIndex = 6;
            // 
            // gbResultados
            // 
            gbResultados.Controls.Add(lblTotalNeto);
            gbResultados.Controls.Add(lblTotalDescuentos);
            gbResultados.Controls.Add(lblTotalCobrar);
            gbResultados.Controls.Add(btnCerrar);
            gbResultados.Location = new Point(477, 52);
            gbResultados.Name = "gbResultados";
            gbResultados.Size = new Size(270, 351);
            gbResultados.TabIndex = 7;
            gbResultados.TabStop = false;
            gbResultados.Text = "Resultados";
            gbResultados.Visible = false;
            // 
            // lblTotalNeto
            // 
            lblTotalNeto.AutoSize = true;
            lblTotalNeto.Location = new Point(44, 147);
            lblTotalNeto.Name = "lblTotalNeto";
            lblTotalNeto.Size = new Size(109, 15);
            lblTotalNeto.TabIndex = 11;
            lblTotalNeto.Text = "Total Neto a Cobrar";
            // 
            // lblTotalDescuentos
            // 
            lblTotalDescuentos.AutoSize = true;
            lblTotalDescuentos.Location = new Point(41, 93);
            lblTotalDescuentos.Name = "lblTotalDescuentos";
            lblTotalDescuentos.Size = new Size(112, 15);
            lblTotalDescuentos.TabIndex = 10;
            lblTotalDescuentos.Text = "Total de Descuentos";
            // 
            // lblTotalCobrar
            // 
            lblTotalCobrar.AutoSize = true;
            lblTotalCobrar.Location = new Point(44, 39);
            lblTotalCobrar.Name = "lblTotalCobrar";
            lblTotalCobrar.Size = new Size(112, 15);
            lblTotalCobrar.TabIndex = 9;
            lblTotalCobrar.Text = "Total a Cobrar Bruto";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(44, 265);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(186, 65);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblValorHora
            // 
            lblValorHora.AutoSize = true;
            lblValorHora.Location = new Point(66, 254);
            lblValorHora.Name = "lblValorHora";
            lblValorHora.Size = new Size(65, 15);
            lblValorHora.TabIndex = 8;
            lblValorHora.Text = "Valor Hora:";
            // 
            // numValorHora
            // 
            numValorHora.Location = new Point(197, 252);
            numValorHora.Name = "numValorHora";
            numValorHora.Size = new Size(120, 23);
            numValorHora.TabIndex = 9;
            numValorHora.ValueChanged += numValorHora_ValueChanged;
            // 
            // gbResultado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 510);
            Controls.Add(numValorHora);
            Controls.Add(lblValorHora);
            Controls.Add(gbResultados);
            Controls.Add(numHorasTrabajadas);
            Controls.Add(numAntiguedad);
            Controls.Add(txtNombre);
            Controls.Add(btnCalcular);
            Controls.Add(labelHorasTrabajadas);
            Controls.Add(labelAntiguedad);
            Controls.Add(labelEmpleado);
            Name = "gbResultado";
            Text = "Resultado";
            ((System.ComponentModel.ISupportInitialize)numAntiguedad).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHorasTrabajadas).EndInit();
            gbResultados.ResumeLayout(false);
            gbResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numValorHora).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEmpleado;
        private Label labelAntiguedad;
        private Label labelHorasTrabajadas;
        private Button btnCalcular;
        private TextBox txtNombre;
        private NumericUpDown numAntiguedad;
        private NumericUpDown numHorasTrabajadas;
        private GroupBox gbResultados;
        private Button btnCerrar;
        private Label lblValorHora;
        private Label lblTotalNeto;
        private Label lblTotalDescuentos;
        private Label lblTotalCobrar;
        private NumericUpDown numValorHora;
    }
}
