namespace WinForms_API
{
    partial class FormStock
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
            dgvStock = new DataGridView();
            chkSoloBajoStock = new CheckBox();
            lblSeleccionado = new Label();
            txtProductoSel = new TextBox();
            lblStockActual = new Label();
            txtStockActual = new TextBox();
            lblCantidadSumar = new Label();
            txtCantidadSumar = new TextBox();
            btnReponerStock = new Button();
            lblAviso = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            SuspendLayout();

            // chkSoloBajoStock
            chkSoloBajoStock.AutoSize = true;
            chkSoloBajoStock.Location = new Point(20, 18);
            chkSoloBajoStock.Name = "chkSoloBajoStock";
            chkSoloBajoStock.Size = new Size(230, 19);
            chkSoloBajoStock.Text = "Mostrar solo productos con stock bajo (< 5 Kg)";
            chkSoloBajoStock.UseVisualStyleBackColor = true;

            // lblAviso
            lblAviso.AutoSize = true;
            lblAviso.ForeColor = Color.DarkRed;
            lblAviso.Location = new Point(310, 19);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(230, 15);
            lblAviso.Text = "* En rojo: mercancía por debajo de 5 Kg";

            // dgvStock
            dgvStock.AllowUserToAddRows = false;
            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Location = new Point(20, 50);
            dgvStock.MultiSelect = false;
            dgvStock.Name = "dgvStock";
            dgvStock.ReadOnly = true;
            dgvStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStock.Size = new Size(520, 360);

            // lblSeleccionado & txtProductoSel
            lblSeleccionado.AutoSize = true;
            lblSeleccionado.Location = new Point(565, 53);
            lblSeleccionado.Name = "lblSeleccionado";
            lblSeleccionado.Text = "Producto seleccionado:";

            txtProductoSel.Location = new Point(565, 75);
            txtProductoSel.Name = "txtProductoSel";
            txtProductoSel.ReadOnly = true;
            txtProductoSel.Size = new Size(255, 23);

            // lblStockActual & txtStockActual
            lblStockActual.AutoSize = true;
            lblStockActual.Location = new Point(565, 118);
            lblStockActual.Name = "lblStockActual";
            lblStockActual.Text = "Stock actual (Kg):";

            txtStockActual.Location = new Point(565, 140);
            txtStockActual.Name = "txtStockActual";
            txtStockActual.ReadOnly = true;
            txtStockActual.Size = new Size(255, 23);

            // lblCantidadSumar & txtCantidadSumar
            lblCantidadSumar.AutoSize = true;
            lblCantidadSumar.Location = new Point(565, 183);
            lblCantidadSumar.Name = "lblCantidadSumar";
            lblCantidadSumar.Text = "Kilos a reponer (+ Kg):";

            txtCantidadSumar.Location = new Point(565, 205);
            txtCantidadSumar.Name = "txtCantidadSumar";
            txtCantidadSumar.Size = new Size(255, 23);

            // btnReponerStock
            btnReponerStock.Location = new Point(565, 250);
            btnReponerStock.Name = "btnReponerStock";
            btnReponerStock.Size = new Size(255, 42);
            btnReponerStock.Text = "Añadir Stock al Inventario";
            btnReponerStock.UseVisualStyleBackColor = true;

            // FormStock
            ClientSize = new Size(845, 435);
            Controls.Add(lblAviso);
            Controls.Add(btnReponerStock);
            Controls.Add(txtCantidadSumar);
            Controls.Add(lblCantidadSumar);
            Controls.Add(txtStockActual);
            Controls.Add(lblStockActual);
            Controls.Add(txtProductoSel);
            Controls.Add(lblSeleccionado);
            Controls.Add(dgvStock);
            Controls.Add(chkSoloBajoStock);
            Name = "FormStock";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Control de Stock - Frutería";
            Load += FormStock_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStock;
        private CheckBox chkSoloBajoStock;
        private Label lblSeleccionado;
        private TextBox txtProductoSel;
        private Label lblStockActual;
        private TextBox txtStockActual;
        private Label lblCantidadSumar;
        private TextBox txtCantidadSumar;
        private Button btnReponerStock;
        private Label lblAviso;
    }
}