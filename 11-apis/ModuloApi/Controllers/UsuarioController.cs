using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ModuloApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("ObterDatHoraAtual")]
        public IActionResult ObterDataHora()
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };

            return Ok(obj);
        }

        [HttpGet("Apresentar/{nome}/{sobrenome}")]
        public IActionResult Apresentar(string nome)
        {
            var mensagem = $"Olá, {nome}, seja bem-vindo";
            return Ok(new {mensagem});
        }
    }

}