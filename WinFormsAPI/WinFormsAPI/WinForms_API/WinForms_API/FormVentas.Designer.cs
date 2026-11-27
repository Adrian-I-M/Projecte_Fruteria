namespace WinForms_API
{
    partial class FormVentas
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
            lblProducto = new Label();
            cmbProductos = new ComboBox();
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            lblTotalEstimado = new Label();
            btnVender = new Button();
            lblHistorial = new Label();
            dgvVentas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(25, 25);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(118, 15);
            lblProducto.TabIndex = 7;
            lblProducto.Text = "Selecciona Producto:";
            // 
            // cmbProductos
            // 
            cmbProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(25, 48);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(260, 23);
            cmbProductos.TabIndex = 6;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(25, 95);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(131, 15);
            lblCantidad.TabIndex = 5;
            lblCantidad.Text = "Cantidad a vender (Kg):";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(25, 118);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(260, 23);
            txtCantidad.TabIndex = 4;
            // 
            // lblTotalEstimado
            // 
            lblTotalEstimado.AutoSize = true;
            lblTotalEstimado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalEstimado.Location = new Point(25, 160);
            lblTotalEstimado.Name = "lblTotalEstimado";
            lblTotalEstimado.Size = new Size(152, 19);
            lblTotalEstimado.TabIndex = 3;
            lblTotalEstimado.Text = "Total a cobrar: 0,00 €";
            // 
            // btnVender
            // 
            btnVender.Location = new Point(25, 200);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(260, 45);
            btnVender.TabIndex = 2;
            btnVender.Text = "Registrar Venta";
            btnVender.UseVisualStyleBackColor = true;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Location = new Point(315, 25);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(164, 15);
            lblHistorial.TabIndex = 1;
            lblHistorial.Text = "Historial de Ventas Realizadas:";
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(315, 48);
            dgvVentas.MultiSelect = false;
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(460, 330);
            dgvVentas.TabIndex = 0;
            // 
            // FormVentas
            // 
            ClientSize = new Size(800, 405);
            Controls.Add(dgvVentas);
            Controls.Add(lblHistorial);
            Controls.Add(btnVender);
            Controls.Add(lblTotalEstimado);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(cmbProductos);
            Controls.Add(lblProducto);
            Name = "FormVentas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registro de Ventas - Frutería";
            Load += FormVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProducto;
        private ComboBox cmbProductos;
        private Label lblCantidad;
        private TextBox txtCantidad;
        private Label lblTotalEstimado;
        private Button btnVender;
        private Label lblHistorial;
        private DataGridView dgvVentas;
    }
}