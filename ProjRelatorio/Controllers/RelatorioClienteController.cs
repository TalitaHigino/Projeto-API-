namespace ProjRelatorio.Controllers
{
    public class RelatorioClienteController
    { 
         [ApiController]
       [Route("[controller]")]
        public class RelatorioClienteController : ControllerBase
        {
            private DbServices _dbService;

            public RelatorioClienteController()
            {
                _dbService = new DbService();
            }

            [HttpGet]
            public async Task<IEnumerable<ClienteDto>> GetClienteAsync()
            {
                return await _dbService.GetClienteAsync();
            }
        }    
        
    }
}