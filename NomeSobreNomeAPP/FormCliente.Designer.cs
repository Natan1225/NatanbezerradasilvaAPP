namespace NatanbezerradasilvaClass
{
    partial class FormCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNomecli = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            txtEndereço = new TextBox();
            label4 = new Label();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 64);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome do Cliente";
            // 
            // txtNomecli
            // 
            txtNomecli.Location = new Point(36, 82);
            txtNomecli.Name = "txtNomecli";
            txtNomecli.Size = new Size(311, 23);
            txtNomecli.TabIndex = 1;
            txtNomecli.TextChanged += txtNomecli_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(379, 64);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 0;
            label2.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(379, 82);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(268, 23);
            txtEmail.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 127);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 0;
            label3.Text = "Telefone";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(36, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 23);
            textBox1.TabIndex = 3;
            // 
            // txtEndereço
            // 
            txtEndereço.Location = new Point(36, 200);
            txtEndereço.Name = "txtEndereço";
            txtEndereço.Size = new Size(311, 23);
            txtEndereço.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 182);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 0;
            label4.Text = "Endereço";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(340, 262);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrar);
            Controls.Add(txtEndereço);
            Controls.Add(textBox1);
            Controls.Add(txtEmail);
            Controls.Add(txtNomecli);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "FormCliente";
            Text = "FormCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public TextBox txtNomecli;
        private Label label2;
        public TextBox txtEmail;
        private Label label3;
        private TextBox textBox1;
        public TextBox txtEndereço;
        private Label label4;
        private Button btnCadastrar;
    }
}