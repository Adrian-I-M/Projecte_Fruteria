using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_API.Models;

namespace WinForms_API
{
    public partial class FormVentas : Form
    {
        private ApiClient _api;
        private List<Producto> _productos = new List<Producto>();

        public FormVentas(ApiClient api)
        {
            InitializeComponent();
            _api = api;

            cmbProductos.SelectedIndexChanged += (s, e) => ActualizarTotal();
            txtCantidad.TextChanged += (s, e) => ActualizarTotal();
            btnVender.Click += btnVender_Click;
        }

        private async void FormVentas_Load(object sender, EventArgs e)
        {
            await CargarDatosAsync();
        }

        private async Task CargarDatosAsync()
        {
            try
            {
                _productos = await _api.GetProductosAsync() ?? new List<Producto>();

                cmbProductos.DataSource = null;
                cmbProductos.DataSource = _productos;
                cmbProductos.DisplayMember = "nombre";
                cmbProductos.ValueMember = "id";

                var ventas = await _api.GetVentasAsync() ?? new List<Venta>();
                dgvVentas.DataSource = null;
                dgvVentas.DataSource = ventas;

                ActualizarTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos desde la API:\n" + ex.Message, "Error de conexión");
            }
        }

        private void ActualizarTotal()
        {
            if (cmbProductos.SelectedItem is Producto prod &&
                float.TryParse(txtCantidad.Text, out float kg) && kg > 0)
            {
                float total = prod.precioKg * kg;
                lblTotalEstimado.Text = $"Total a cobrar: {total:0.00} € (Stock disp: {prod.stockKg} Kg)";
            }
            else if (cmbProductos.SelectedItem is Producto p)
            {
                lblTotalEstimado.Text = $"Total a cobrar: 0,00 € (Stock disp: {p.stockKg} Kg)";
            }
        }

        private async void btnVender_Click(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedItem is not Producto prod)
            {
                MessageBox.Show("Selecciona un producto de la lista.");
                return;
            }

            if (!float.TryParse(txtCantidad.Text, out float cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Introduce una cantidad en Kg válida mayor que 0.");
                return;
            }

            if (cantidad > prod.stockKg)
            {
                MessageBox.Show($"Stock insuficiente. Solo quedan {prod.stockKg} Kg de {prod.nombre}.");
                return;
            }

            var nuevaVenta = new Venta
            {
                id_producto = prod.id,
                cantidad = cantidad
            };

            if (await _api.RegistrarVentaAsync(nuevaVenta))
            {
                txtCantidad.Clear();
                await CargarDatosAsync();
                MessageBox.Show("Venta registrada y stock descontado correctamente.");
            }
            else
            {
                MessageBox.Show("No se pudo registrar la venta en el servidor.");
            }
        }
    }
}