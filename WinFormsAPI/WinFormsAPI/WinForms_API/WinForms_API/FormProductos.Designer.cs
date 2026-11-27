namespace WinForms_API
{
    partial class FormProductos
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
            dgvProductos = new DataGridView();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            lblId = new Label();
            txtId = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblCategoria = new Label();
            txtCategoria = new TextBox();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            lblStock = new Label();
            txtStock = new TextBox();
            btnCrear = new Button();
            btnEditar = new Button();
            btnBorrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();

            // lblBuscar
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(20, 18);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(45, 15);
            lblBuscar.Text = "Buscar:";

            // txtBuscar
            txtBuscar.Location = new Point(75, 15);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(250, 23);

            // dgvProductos
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(20, 50);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(520, 380);

            // lblId & txtId
            lblId.AutoSize = true;
            lblId.Location = new Point(565, 53);
            lblId.Name = "lblId";
            lblId.Text = "ID:";

            txtId.Location = new Point(655, 50);
            txtId.Name = "txtId";
            txtId.Size = new Size(175, 23);

            // lblNombre & txtNombre
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(565, 98);
            lblNombre.Name = "lblNombre";
            lblNombre.Text = "Nombre:";

            txtNombre.Location = new Point(655, 95);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(175, 23);

            // lblCategoria & txtCategoria
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(565, 143);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Text = "Categoría:";

            txtCategoria.Location = new Point(655, 140);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(175, 23);

            // lblPrecio & txtPrecio
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(565, 188);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Text = "Precio/Kg:";

            txtPrecio.Location = new Point(655, 185);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(175, 23);

            // lblStock & txtStock
            lblStock.AutoSize = true;
            lblStock.Location = new Point(565, 233);
            lblStock.Name = "lblStock";
            lblStock.Text = "Stock (Kg):";

            txtStock.Location = new Point(655, 230);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(175, 23);

            // btnCrear
            btnCrear.Location = new Point(565, 285);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(265, 38);
            btnCrear.Text = "Añadir Producto";
            btnCrear.UseVisualStyleBackColor = true;

            // btnEditar
            btnEditar.Location = new Point(565, 335);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(265, 38);
            btnEditar.Text = "Actualizar";
            btnEditar.UseVisualStyleBackColor = true;

            // btnBorrar
            btnBorrar.Location = new Point(565, 385);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(265, 38);
            btnBorrar.Text = "Eliminar";
            btnBorrar.UseVisualStyleBackColor = true;

            // FormProductos
            ClientSize = new Size(855, 455);
            Controls.Add(btnBorrar);
            Controls.Add(btnEditar);
            Controls.Add(btnCrear);
            Controls.Add(txtStock);
            Controls.Add(lblStock);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(txtCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(dgvProductos);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Name = "FormProductos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Catálogo de Productos";
            Load += FormProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private Label lblId;
        private TextBox txtId;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblCategoria;
        private TextBox txtCategoria;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private Label lblStock;
        private TextBox txtStock;
        private Button btnCrear;
        private Button btnEditar;
        private Button btnBorrar;
    }
}