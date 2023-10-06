namespace Integrador
{
    partial class FrmCalculadora
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
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            Resultado = new Label();
            cmbOperacion = new ComboBox();
            txtPrimerOperando = new TextBox();
            txtSegundoOperando = new TextBox();
            labelPrimerOperador = new Label();
            labelResultado = new Label();
            labelOperando2 = new Label();
            groupBox1 = new GroupBox();
            rdbDecimalChecked = new RadioButton();
            rdbDecimal = new RadioButton();
            lblResult = new Label();
            lstHistorial = new ListBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnOperar
            // 
            btnOperar.Cursor = Cursors.Hand;
            btnOperar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOperar.Location = new Point(33, 381);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(212, 44);
            btnOperar.TabIndex = 0;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            btnOperar.Click += buttonOperar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(284, 381);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(236, 44);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += buttonLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.Location = new Point(564, 381);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(212, 44);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += buttonCerrar_Click;
            // 
            // Resultado
            // 
            Resultado.AutoSize = true;
            Resultado.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            Resultado.Location = new Point(25, 71);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(220, 59);
            Resultado.TabIndex = 3;
            Resultado.Text = "Resultado:";
            // 
            // cmbOperacion
            // 
            cmbOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacion.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.ImeMode = ImeMode.On;
            cmbOperacion.Location = new Point(326, 317);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(157, 40);
            cmbOperacion.TabIndex = 4;
            // 
            // txtPrimerOperando
            // 
            txtPrimerOperando.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrimerOperando.Location = new Point(33, 317);
            txtPrimerOperando.Name = "txtPrimerOperando";
            txtPrimerOperando.Size = new Size(212, 39);
            txtPrimerOperando.TabIndex = 5;
            // 
            // txtSegundoOperando
            // 
            txtSegundoOperando.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtSegundoOperando.Location = new Point(564, 317);
            txtSegundoOperando.Name = "txtSegundoOperando";
            txtSegundoOperando.Size = new Size(212, 39);
            txtSegundoOperando.TabIndex = 6;
            // 
            // labelPrimerOperador
            // 
            labelPrimerOperador.AutoSize = true;
            labelPrimerOperador.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrimerOperador.Location = new Point(33, 284);
            labelPrimerOperador.Name = "labelPrimerOperador";
            labelPrimerOperador.Size = new Size(155, 25);
            labelPrimerOperador.TabIndex = 7;
            labelPrimerOperador.Text = "Primer operador:";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelResultado.Location = new Point(326, 284);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(93, 25);
            labelResultado.TabIndex = 8;
            labelResultado.Text = "Operador";
            // 
            // labelOperando2
            // 
            labelOperando2.AutoSize = true;
            labelOperando2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelOperando2.Location = new Point(564, 284);
            labelOperando2.Name = "labelOperando2";
            labelOperando2.Size = new Size(174, 25);
            labelOperando2.TabIndex = 9;
            labelOperando2.Text = "Segundo operador:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbDecimalChecked);
            groupBox1.Controls.Add(rdbDecimal);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(318, 174);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(202, 80);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Representar resultado en :";
            // 
            // rdbDecimalChecked
            // 
            rdbDecimalChecked.AutoSize = true;
            rdbDecimalChecked.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rdbDecimalChecked.Location = new Point(6, 37);
            rdbDecimalChecked.Name = "rdbDecimalChecked";
            rdbDecimalChecked.Size = new Size(75, 23);
            rdbDecimalChecked.TabIndex = 12;
            rdbDecimalChecked.TabStop = true;
            rdbDecimalChecked.Text = "Decimal";
            rdbDecimalChecked.UseVisualStyleBackColor = true;
            rdbDecimalChecked.CheckedChanged += rdbDecimalChecked_CheckedChanged;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rdbDecimal.Location = new Point(117, 37);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(69, 23);
            rdbDecimal.TabIndex = 13;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Binario";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += radioBinarioChecked_CheckedChanged;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.Location = new Point(251, 87);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 38);
            lblResult.TabIndex = 15;
            // 
            // lstHistorial
            // 
            lstHistorial.BorderStyle = BorderStyle.None;
            lstHistorial.FormattingEnabled = true;
            lstHistorial.ItemHeight = 15;
            lstHistorial.Location = new Point(817, 87);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(241, 270);
            lstHistorial.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(817, 46);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 17;
            label1.Text = "Historial:";
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 450);
            Controls.Add(label1);
            Controls.Add(lstHistorial);
            Controls.Add(lblResult);
            Controls.Add(groupBox1);
            Controls.Add(labelOperando2);
            Controls.Add(labelResultado);
            Controls.Add(labelPrimerOperador);
            Controls.Add(txtSegundoOperando);
            Controls.Add(txtPrimerOperando);
            Controls.Add(cmbOperacion);
            Controls.Add(Resultado);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Alumnos Juan Manuel Mosquella";
            FormClosing += FrmCalculadora_FormClosing;
            Load += FmrCalculadora_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private Label Resultado;
        private ComboBox cmbOperacion;
        private TextBox txtPrimerOperando;
        private TextBox txtSegundoOperando;
        private Label labelPrimerOperador;
        private Label labelResultado;
        private Label labelOperando2;
        private GroupBox groupBox1;
        private RadioButton rdbDecimalChecked;
        private RadioButton rdbDecimal;
        private Label lblResult;
        private ListBox lstHistorial;
        private Label label1;
    }
}