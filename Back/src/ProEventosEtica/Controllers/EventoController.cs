using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventosEtica.Models;

namespace ProEventosEtica.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {       
        public IEnumerable<Evento> _evento = new Evento[]{
            new Evento(){
                EventoId = 1,
                Tema = "Angular 11 e .Net 5",
                Local = "Belo Horizonte",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/aaaa"),
                ImagemUrl = "Foto-MG-BH.png",
            },
            new Evento(){
                EventoId = 2,
                Tema = "Angular E Suas Novidades",
                Local = "São Paulo",
                Lote = "2º Lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/aaaa"),
                ImagemUrl = "Foto-SP-SP.png",
            }
        };
        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {         
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {         
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {         
            return "Retornando do POST";
        }
        
        [HttpPut("id")]
        public string Put(int id)
        {         
            return $"Retornando do Put relacionado ao id = {id}";
        }

        [HttpDelete("id")]
        public string Delete(int id)
        {         
            return $"Retornando do Delete relacionado ao id = {id}";
        }
    }
}
