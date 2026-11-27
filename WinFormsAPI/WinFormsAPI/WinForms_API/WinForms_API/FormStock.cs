using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_API.Models;

namespace WinForms_API
{
    public partial class FormStock : Form
    {
        private ApiClient _api;
        private List<Producto> _listaProductos = new List<Producto>();
        private Producto _productoSeleccionado = null;

        public FormStock(ApiClient api)
        {
            InitializeComponent();
            _api = api;

            dgvStock.CellClick += dgvStock_CellClick;
            dgvStock.DataBindingComplete += dgvStock_DataBindingComplete;
            chkSoloBajoStock.CheckedChanged += chkSoloBajoStock_CheckedChanged;
            btnReponerStock.Click += btnReponerStock_Click;
        }

        private async void FormStock_Load(object sender, EventArgs e)
        {
            await CargarStockAsync();
        }

        private async Task CargarStockAsync()
        {
            try
            {
                _listaProductos = await _api.GetProductosAsync() ?? new List<Producto>();
                AplicarFiltro();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el stock desde la API:\n" + ex.Message, "Error de conexión");
            }
        }

        private void AplicarFiltro()
        {
            var datos = chkSoloBajoStock.Checked
                ? _listaProductos.Where(p => p.stockKg < 5).ToList()
                : _listaProductos;

            dgvStock.DataSource = null;
            dgvStock.DataSource = datos;
        }

        private void dgvStock_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow fila in dgvStock.Rows)
            {
                if (fila.DataBoundItem is Producto prod && prod.stockKg < 5)
                {
                    fila.DefaultCellStyle.BackColor = Color.MistyRose;
                    fila.DefaultCellStyle.ForeColor = Color.DarkRed;
                }
            }
        }

        private void chkSoloBajoStock_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvStock.Rows[e.RowIndex].DataBoundItem is Producto seleccionado)
            {
                _productoSeleccionado = seleccionado;
                txtProductoSel.Text = $"{seleccionado.id} - {seleccionado.nombre}";
                txtStockActual.Text = seleccionado.stockKg.ToString();
                txtCantidadSumar.Focus();
            }
        }

        private async void btnReponerStock_Click(object sender, EventArgs e)
        {
            if (_productoSeleccionado == null)
            {
                MessageBox.Show("Selecciona primero un producto de la tabla.");
                return;
            }

            if (!float.TryParse(txtCantidadSumar.Text, out float kilosExtra) || kilosExtra <= 0)
            {
                MessageBox.Show("Introduce una cantidad válida de kilos mayor que 0.");
                return;
            }

            _productoSeleccionado.stockKg += kilosExtra;

            if (await _api.ActualizarProductoAsync(_productoSeleccionado.id, _productoSeleccionado))
            {
                txtCantidadSumar.Clear();
                txtStockActual.Text = _productoSeleccionado.stockKg.ToString();
                await CargarStockAsync();
                MessageBox.Show("Stock actualizado correctamente.");
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el stock en el servidor.");
            }
        }
    }
}