using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjAPIrelatorio.Dto;
using ProjAPIrelatorio.Services;

namespace ProjAPIrelatorio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RelatorioClienteController : ControllerBase
    {
        private DbService _dbService;

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