using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_API
{
    public partial class FormInformes : Form
    {
        private ApiClient _api;

        public FormInformes(ApiClient api)
        {
            InitializeComponent();
            _api = api;
            btnRefrescar.Click += async (s, e) => await CargarInformeAsync();
        }

        private async void FormInformes_Load(object sender, EventArgs e)
        {
            await CargarInformeAsync();
        }

        private async Task CargarInformeAsync()
        {
            try
            {
                var informe = await _api.GetInformeVentasHoyAsync();
                if (informe != null)
                {
                    lblTotalValor.Text = $"{informe.total_vendido:0.00} €";
                    lblNumVentasValor.Text = informe.numero_ventas.ToString();
                    lblTopValor.Text = informe.producto_mas_vendido;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el informe desde la API:\n" + ex.Message, "Error de conexión");
            }
        }
    }
}