using WK_Shopping.Web.Models;
using WK_Shopping.Web.Services.IServices;
using WK_Shopping.Web.Utils;

namespace WK_Shopping.Web.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly HttpClient _client;
        public const string BasePath = "api/v1/categoria";

        public CategoriaService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<IEnumerable<CategoriaModel>> FindAllCategorias()
        {
            var response = await _client.GetAsync(BasePath);
            return await response.ReadContentAs<List<CategoriaModel>>();
        }

        public async Task<CategoriaModel> FindAllCategoriaById(long id)
        {
            var response = await _client.GetAsync($"{BasePath}/{id}");
            return await response.ReadContentAs<CategoriaModel>();
        }

        public async Task<CategoriaModel> CreateCategoria(CategoriaModel model)
        {
            var response = await _client.PostAsJson(BasePath, model);
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<CategoriaModel>();
            else throw new Exception("Algo deu errado ao chamar a API");
        }
        public async Task<CategoriaModel> UpdateCategoria(CategoriaModel model)
        {
            var response = await _client.PutAsJson(BasePath, model);
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<CategoriaModel>();
            else throw new Exception("Algo deu errado ao chamar a API");
        }

        public async Task<bool> DeleteCategoriaById(long id)
        {
            var response = await _client.DeleteAsync($"{BasePath}/{id}");
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<bool>();
            else throw new Exception("Algo deu errado ao chamar a API");
        }
    }
}
