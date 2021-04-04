namespace ProjRelatorio.Services
{
    public class DbServices
    {
        HttpClient httpClient = new HttpClient();
        IEnumerable<ProdutoDto> lstProduto;
        IEnumerable<ClienteDto> lstCliente;
        public async Task<IEnumerable<ProdutoDto>> GetProdutoAsync()
        {
            httpClient.BaseAddress = new Uri("http://localhost:5002/");

            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await httpClient.GetAsync("Produto");

            if (response.IsSuccessStatusCode)
            {
                var produtoString = await response.Content.ReadAsStringAsync();
                lstProduto = JsonConvert.DeserializeObject<IEnumerable<ProdutoDto>>(produtoString);
            }
            else{
                response.EnsureSuccessStatusCode();
            }
            
            return lstProduto;
        }
        public async Task<IEnumerable<ClienteDto>> GetClienteAsync()
        {
            httpClient.BaseAddress = new Uri("http://localhost:5001/");

            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await httpClient.GetAsync("Cliente");

            if (response.IsSuccessStatusCode)
            {
                var clienteString = await response.Content.ReadAsStringAsync();
                lstCliente = JsonConvert.DeserializeObject<IEnumerable<ClienteDto>>(clienteString);
            }
            else{
                response.EnsureSuccessStatusCode();
            }
            
            return lstCliente;
        }
    }
}