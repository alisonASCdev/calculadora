namespace calculadora
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
            somar = new Button();
            primeiroNumero = new TextBox();
            segundoNumero = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Resultado = new Label();
            SuspendLayout();
            // 
            // somar
            // 
            somar.Location = new Point(225, 174);
            somar.Name = "somar";
            somar.Size = new Size(112, 34);
            somar.TabIndex = 0;
            somar.Text = "somar";
            somar.UseVisualStyleBackColor = true;
            // 
            // primeiroNumero
            // 
            primeiroNumero.BackColor = Color.White;
            primeiroNumero.Location = new Point(211, 20);
            primeiroNumero.Name = "primeiroNumero";
            primeiroNumero.Size = new Size(150, 31);
            primeiroNumero.TabIndex = 1;
            // 
            // segundoNumero
            // 
            segundoNumero.Location = new Point(211, 109);
            segundoNumero.Name = "segundoNumero";
            segundoNumero.Size = new Size(150, 31);
            segundoNumero.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 20);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 3;
            label1.Text = "Primeiro Número";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 112);
            label2.Name = "label2";
            label2.Size = new Size(154, 25);
            label2.TabIndex = 4;
            label2.Text = "Segundo Número";
            // 
            // Resultado
            // 
            Resultado.AutoSize = true;
            Resultado.Location = new Point(426, 72);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(22, 25);
            Resultado.TabIndex = 5;
            Resultado.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Resultado);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(segundoNumero);
            Controls.Add(primeiroNumero);
            Controls.Add(somar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button somar;
        private TextBox primeiroNumero;
        private TextBox segundoNumero;
        private Label label1;
        private Label label2;
        private Label Resultado;
    }
}