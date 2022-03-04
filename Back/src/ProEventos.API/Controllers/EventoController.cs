using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> evento = new Evento[]{
             new Evento(){
            EventoId = 1,
            Tema = "Angular 11 e .Net 5",
            Local = "São Paulo",
            Lote = "1",
            QtdePessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
            ImagemURL = "foto.png"
           },
            new Evento(){
            EventoId = 2,
            Tema = "Angular e sua novidades",
            Local = "São Paulo",
            Lote = "2",
            QtdePessoas = 300,
            DataEvento = DateTime.Now.AddDays(6).ToString("dd/MM/yyyy"),
            ImagemURL = "foto2.png"
        }
    };

        public DataContext _Context { get; }

        public EventoController(DataContext context)
        {
            _Context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _Context.Eventos ;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _Context.Eventos.FirstOrDefault(e => e.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de put com id =  {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
            ;
        }
    }
}
