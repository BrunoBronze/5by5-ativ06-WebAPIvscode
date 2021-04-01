using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjAPIrelatorio.Dto;
using ProjAPIrelatorio.Services;

namespace ProjAPIrelatorio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RelatorioProdutoController : ControllerBase
    {
        private DbService _dbService;

        public RelatorioProdutoController()
        {
            _dbService = new DbService();
        }

        [HttpGet]
        public async Task<IEnumerable<ProdutoDto>> GetProdutoAsync()
        {
            return await _dbService.GetProdutoAsync();
        }
    }
}