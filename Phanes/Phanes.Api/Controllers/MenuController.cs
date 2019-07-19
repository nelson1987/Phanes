using Microsoft.AspNetCore.Mvc;
using Phanes.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Phanes.Api.Controllers
{
    public class MenuType
    {
        public MenuType(string nome, string link, string icon)
        {
            Nome = nome;
            Link = link;
            Icon = icon;
        }
        public string Link { get; set; }
        public string Icon { get; set; }
        public string Nome { get; set; }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<MenuType>))]
        public IActionResult Get()
        {
            var listaMenu = new List<MenuType>() {
                new MenuType("/","Home","home"),
                new MenuType("/counter","Counter","education"),
                new MenuType("/fetch-data","Fetch data","th-list"),
            };
            var rng = new Random();
            return Ok(listaMenu);
        }
    }
}
