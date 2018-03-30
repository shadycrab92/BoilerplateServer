using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Boilerplate.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Boilerplate.Controllers
{
    [Produces("application/json")]
    [Route("api/Publication")]
    public class PublicationController : Controller
    {
        // GET: api/Publication
        [HttpGet]
        public IEnumerable<PublicationModel> Get()
        {
            var publications = new List<PublicationModel>();

            for(var i = 0; i < 10; i++)
            {
                publications.Add(new PublicationModel()
                {
                    Create = DateTime.Now,
                    Update = null,
                    Title = "В Android 6.0 ввели функцию, позволяющую отформатировать карту памяти",
                    PreviewText = "В Android 6.0 ввели функцию, позволяющую отформатировать карту памяти так, чтобы она являлась не отдельным хранилищем, а придатком ко внутренней памяти. Это позволяет избежать путаницы с двумя хранилищами данных, особенно при ручной установке некоторых не всегда честно купленных крупных приложений, поставляемых по частям. Однако есть один нюанс: при этом всём нам наглухо блокируют доступ к карте напрямую. Хочешь что-то передать на устройство — используй MTP со всеми вытекающими, вроде скорости передачи файлов, сравнимой с прогулочным шагом контуженной черепахи. Карту теперь не только к ПК через кабель напрямую нельзя подключить: её и из выключенного телефона через кардридер просто так не смонтируешь, ведь она отформатирована в нечто неизвестное ни науке, ни нашим компьютерам.",
                    Blocks = ""
                });
            }


            return publications;
        }

        // GET: api/Publication/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Publication
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Publication/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
