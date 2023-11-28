using System.Diagnostics;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using myfinance_web_netcore.Models;
using myfinance_web_netcore.Services;

namespace myfinance_web_netcore.Controllers;

public class PlanoContaController : Controller
{
    private readonly ILogger<PlanoContaController> _logger;
    private readonly IMapper _mapper;
    private readonly IPlanoContaService _planoContaService;

    public PlanoContaController(
        ILogger<PlanoContaController> logger, 
        IMapper mapper,
        IPlanoContaService planoContaService )
    {
        _logger = logger;
        _mapper = mapper;
        _planoContaService = planoContaService;
    } 

    public IActionResult Index()
    {
/*        List<PlanoContaModel> listaPlanoContaModel = new();


        //ViewBag.ListaPLanoConta = _planoContaService.ListarPlanoContas();
        
        foreach (var item in _planoContaService.ListarPlanoContas())
        {
            var planoConta = new PlanoContaModel()
            {
            Id = item.Id,
            Descricao = item.Descricao,
            Tipo = item.Tipo
            };
            listaPlanoContaModel.Add(planoConta);
        } 
        
        ViewBag.listaPlanoConta = listaPlanoContaModel; */

        var listaPlanoConta = _planoContaService.ListarPlanoContas();
        var lista = _mapper.Map<IEnumerable<PlanoContaModel>>(listaPlanoConta);
        ViewBag.listaPlanoConta = lista;

        return View();
    } 

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
