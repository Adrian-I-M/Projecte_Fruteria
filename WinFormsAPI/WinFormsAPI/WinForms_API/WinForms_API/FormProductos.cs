using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_API.Models;

namespace WinForms_API
{
    public partial class FormProductos : Form
    {
        private ApiClient _api;
        private List<Producto> _listaProductos = new List<Producto>();

        public FormProductos(ApiClient api)
        {
            InitializeComponent();
            _api = api;

            // Conectar eventos directamente por código
            btnCrear.Click += btnCrear_Click;
            btnEditar.Click += btnEditar_Click;
            btnBorrar.Click += btnBorrar_Click;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            dgvProductos.CellClick += dgvProductos_CellClick;
        }

        private async void FormProductos_Load(object sender, EventArgs e)
        {
            await CargarProductosAsync();
        }

        private async Task CargarProductosAsync()
        {
            try
            {
                _listaProductos = await _api.GetProductosAsync() ?? new List<Producto>();
                dgvProductos.DataSource = null;
                dgvProductos.DataSource = _listaProductos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar con la API. Asegúrate de tener uvicorn encendido.\n" + ex.Message, "Error de conexión");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim().ToLower();
            var filtrados = _listaProductos
                .Where(p => p.nombre.ToLower().Contains(filtro) || p.categoria.ToLower().Contains(filtro))
                .ToList();

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = filtrados;
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvProductos.Rows[e.RowIndex].DataBoundItem is Producto seleccionado)
            {
                txtId.Text = seleccionado.id.ToString();
                txtNombre.Text = seleccionado.nombre;
                txtCategoria.Text = seleccionado.categoria;
                txtPrecio.Text = seleccionado.precioKg.ToString();
                txtStock.Text = seleccionado.stockKg.ToString();
            }
        }

        private async void btnCrear_Click(object sender, EventArgs e)
        {
            if (!LeerFormulario(out Producto nuevo)) return;

            if (await _api.CrearProductoAsync(nuevo))
            {
                LimpiarCampos();
                await CargarProductosAsync();
            }
            else
            {
                MessageBox.Show("Error al crear el producto.");
            }
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (!LeerFormulario(out Producto actualizado)) return;

            if (await _api.ActualizarProductoAsync(actualizado.id, actualizado))
            {
                LimpiarCampos();
                await CargarProductosAsync();
            }
            else
            {
                MessageBox.Show("No se encontró un producto con ese ID para actualizar.");
            }
        }

        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Selecciona un producto o escribe un ID válido para eliminar.");
                return;
            }

            if (await _api.BorrarProductoAsync(id))
            {
                LimpiarCampos();
                await CargarProductosAsync();
            }
            else
            {
                MessageBox.Show("Error al eliminar el producto.");
            }
        }

        private bool LeerFormulario(out Producto prod)
        {
            prod = null;
            if (!int.TryParse(txtId.Text, out int id) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                !float.TryParse(txtPrecio.Text, out float precio) ||
                !float.TryParse(txtStock.Text, out float stock))
            {
                MessageBox.Show("Revisa que todos los campos estén rellenos y que ID, Precio y Stock sean números válidos.");
                return false;
            }

            prod = new Producto
            {
                id = id,
                nombre = txtNombre.Text.Trim(),
                categoria = txtCategoria.Text.Trim(),
                precioKg = precio,
                stockKg = stock
            };
            return true;
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtCategoria.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }
    }
}