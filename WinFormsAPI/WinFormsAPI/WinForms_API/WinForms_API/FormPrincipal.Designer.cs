namespace WinForms_API
{
    partial class FormPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();

            // lblTitulo
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(33, 37, 41);
            lblTitulo.Location = new Point(45, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(195, 25);
            lblTitulo.Text = "Gestión de Frutería";

            // button1
            button1.BackColor = Color.FromArgb(46, 125, 50);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(45, 80);
            button1.Name = "button1";
            button1.Size = new Size(310, 45);
            button1.TabIndex = 0;
            button1.Text = "Catálogo de Productos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;

            // button2
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.FromArgb(206, 212, 218);
            button2.FlatAppearance.BorderSize = 1;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            button2.ForeColor = Color.FromArgb(33, 37, 41);
            button2.Location = new Point(45, 140);
            button2.Name = "button2";
            button2.Size = new Size(310, 45);
            button2.TabIndex = 1;
            button2.Text = "Control de Stock";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;

            // button3
            button3.BackColor = Color.White;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.FromArgb(206, 212, 218);
            button3.FlatAppearance.BorderSize = 1;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            button3.ForeColor = Color.FromArgb(33, 37, 41);
            button3.Location = new Point(45, 200);
            button3.Name = "button3";
            button3.Size = new Size(310, 45);
            button3.TabIndex = 2;
            button3.Text = "Registro de Ventas";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;

            // button4
            button4.BackColor = Color.White;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = Color.FromArgb(206, 212, 218);
            button4.FlatAppearance.BorderSize = 1;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            button4.ForeColor = Color.FromArgb(33, 37, 41);
            button4.Location = new Point(45, 260);
            button4.Name = "button4";
            button4.Size = new Size(310, 45);
            button4.TabIndex = 3;
            button4.Text = "Informes de Ventas";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;

            // FormPrincipal
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(400, 340);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Frutería";
            Load += FormPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}