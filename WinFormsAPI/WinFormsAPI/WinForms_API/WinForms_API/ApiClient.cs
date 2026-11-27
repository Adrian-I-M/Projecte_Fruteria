using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WinForms_API.Models;

namespace WinForms_API
{
    public class ApiClient
    {
        private readonly HttpClient _httpClient;

        public ApiClient()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://127.0.0.1:8000/");
        }

        // --- ENDPOINTS DE PRODUCTOS ---

        public async Task<List<Producto>> GetProductosAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Producto>>("productos");
        }

        public async Task<bool> CrearProductoAsync(Producto producto)
        {
            var response = await _httpClient.PostAsJsonAsync("productos", producto);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> ActualizarProductoAsync(int id, Producto producto)
        {
            var response = await _httpClient.PutAsJsonAsync($"productos/{id}", producto);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> BorrarProductoAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"productos/{id}");
            return response.IsSuccessStatusCode;
        }

        // --- ENDPOINTS DE VENTAS ---

        public async Task<bool> RegistrarVentaAsync(Venta venta)
        {
            var response = await _httpClient.PostAsJsonAsync("ventas", venta);
            return response.IsSuccessStatusCode;
        }

        public async Task<List<Venta>> GetVentasAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Venta>>("ventas");
        }

        // --- ENDPOINT DE INFORMES (OPCIONAL) ---

        public async Task<InformeVentas> GetInformeVentasHoyAsync()
        {
            return await _httpClient.GetFromJsonAsync<InformeVentas>("informes/ventas-hoy");
        }
    }
}