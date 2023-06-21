using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventosEtica.Data;
using ProEventosEtica.Models;

namespace ProEventosEtica.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {   
        private readonly DataContext _context;
        public EventosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {         
            return _context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {         
            return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
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
