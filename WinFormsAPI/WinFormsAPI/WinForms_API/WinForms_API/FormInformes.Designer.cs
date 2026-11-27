namespace WinForms_API
{
    partial class FormInformes
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
            lblTotalTexto = new Label();
            lblTotalValor = new Label();
            lblNumVentasTexto = new Label();
            lblNumVentasValor = new Label();
            lblTopTexto = new Label();
            lblTopValor = new Label();
            btnRefrescar = new Button();
            SuspendLayout();

            // lblTitulo
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(33, 37, 41);
            lblTitulo.Location = new Point(35, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(215, 25);
            lblTitulo.Text = "Resumen de Ventas Hoy";

            // lblTotalTexto & lblTotalValor
            lblTotalTexto.AutoSize = true;
            lblTotalTexto.Font = new Font("Segoe UI", 10F);
            lblTotalTexto.ForeColor = Color.Gray;
            lblTotalTexto.Location = new Point(35, 75);
            lblTotalTexto.Name = "lblTotalTexto";
            lblTotalTexto.Text = "Total recaudado hoy:";

            lblTotalValor.AutoSize = true;
            lblTotalValor.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTotalValor.ForeColor = Color.FromArgb(46, 125, 50);
            lblTotalValor.Location = new Point(35, 98);
            lblTotalValor.Name = "lblTotalValor";
            lblTotalValor.Text = "0,00 €";

            // lblNumVentasTexto & lblNumVentasValor
            lblNumVentasTexto.AutoSize = true;
            lblNumVentasTexto.Font = new Font("Segoe UI", 10F);
            lblNumVentasTexto.ForeColor = Color.Gray;
            lblNumVentasTexto.Location = new Point(35, 150);
            lblNumVentasTexto.Name = "lblNumVentasTexto";
            lblNumVentasTexto.Text = "Número de operaciones realizadas:";

            lblNumVentasValor.AutoSize = true;
            lblNumVentasValor.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblNumVentasValor.ForeColor = Color.FromArgb(33, 37, 41);
            lblNumVentasValor.Location = new Point(35, 173);
            lblNumVentasValor.Name = "lblNumVentasValor";
            lblNumVentasValor.Text = "0";

            // lblTopTexto & lblTopValor
            lblTopTexto.AutoSize = true;
            lblTopTexto.Font = new Font("Segoe UI", 10F);
            lblTopTexto.ForeColor = Color.Gray;
            lblTopTexto.Location = new Point(35, 220);
            lblTopTexto.Name = "lblTopTexto";
            lblTopTexto.Text = "Producto estrella más vendido:";

            lblTopValor.AutoSize = true;
            lblTopValor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTopValor.ForeColor = Color.FromArgb(33, 37, 41);
            lblTopValor.Location = new Point(35, 243);
            lblTopValor.Name = "lblTopValor";
            lblTopValor.Text = "-";

            // btnRefrescar
            btnRefrescar.BackColor = Color.FromArgb(46, 125, 50);
            btnRefrescar.Cursor = Cursors.Hand;
            btnRefrescar.FlatAppearance.BorderSize = 0;
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefrescar.ForeColor = Color.White;
            btnRefrescar.Location = new Point(35, 295);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(330, 40);
            btnRefrescar.TabIndex = 0;
            btnRefrescar.Text = "Actualizar Datos";
            btnRefrescar.UseVisualStyleBackColor = false;

            // FormInformes
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(400, 365);
            Controls.Add(btnRefrescar);
            Controls.Add(lblTopValor);
            Controls.Add(lblTopTexto);
            Controls.Add(lblNumVentasValor);
            Controls.Add(lblNumVentasTexto);
            Controls.Add(lblTotalValor);
            Controls.Add(lblTotalTexto);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormInformes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Informes - Frutería";
            Load += FormInformes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblTotalTexto;
        private Label lblTotalValor;
        private Label lblNumVentasTexto;
        private Label lblNumVentasValor;
        private Label lblTopTexto;
        private Label lblTopValor;
        private Button btnRefrescar;
    }
}