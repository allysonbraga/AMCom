using AMcom.Teste.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AMcom.Teste.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/ubs")]
    public class UbsController : Controller
    {
        private UbsService ubsService = new UbsService();

        // Implemente um método que seja acessível por HTTP GET e retorne a lista das 5 UBSs
        // (Unidades Básicas de Saúde) mas próximas de um ponto (latitude e longitude) e ordenada
        // por avaliação (da melhor para a pior). O retorno deve ser no formato JSON.
        

        // "api/usblatitude=-10.9112370014188&longitude=-37.0620775222768"
        public IEnumerable<UbsDTO> Get(double latitude, double longitude)
        {
            return ubsService.Selecionar(latitude, longitude);
        }
    }
}
