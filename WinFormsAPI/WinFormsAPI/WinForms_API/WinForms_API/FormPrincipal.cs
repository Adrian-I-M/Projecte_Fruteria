using System;
using System.Windows.Forms;

namespace WinForms_API
{
    public partial class FormPrincipal : Form
    {
        private ApiClient _apiClient;

        public FormPrincipal()
        {
            InitializeComponent();
            _apiClient = new ApiClient();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProductos ventana = new FormProductos(_apiClient);
            ventana.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormStock ventana = new FormStock(_apiClient);
            ventana.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormVentas ventana = new FormVentas(_apiClient);
            ventana.ShowDialog();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            FormInformes ventana = new FormInformes(_apiClient);
            ventana.ShowDialog();
        }
    }
}