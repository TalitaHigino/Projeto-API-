namespace ProjRelatorio.Controllers
{
    public class RelatorioProdutoController
    {
       [ApiController]
    [Route("[controller]")]
        public class RelatorioProdutoController : ControllerBase
        {
            private DbServices _dbService;

            public RelatorioProdutoController()
            {
                _dbService = new DbServices();
            }

            [HttpGet]
            public async Task<IEnumerable<ProdutoDto>> GetProdutoAsync()
            {
                return await _dbService.GetProdutoAsync();
            }
        }    
    }
    
}