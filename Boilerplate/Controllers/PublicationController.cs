using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Boilerplate.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Boilerplate.Controllers
{
    [Route("api/[controller]/[action]")]
    public class PublicationController : Controller
    {
        [HttpGet]
        public IEnumerable<PublicationModel> Get(Int32 page = 0)
        {
            var publications = new List<PublicationModel>();

            for(var i = 0; i < (page + 1) * 2; i++)
            {
                publications.Add(new PublicationModel()
                {
                    Id= i,
                    Created = DateTime.Now,
                    Updated = null,
                    IsLocked = i%2 == 0,
                    Title = "В Android 6.0 ввели функцию, позволяющую отформатировать карту памяти",
                    PreviewText = "В Android 6.0 ввели функцию, позволяющую отформатировать карту памяти так, чтобы она являлась не отдельным хранилищем, а придатком ко внутренней памяти. Это позволяет избежать путаницы с двумя хранилищами данных, особенно при ручной установке некоторых не всегда честно купленных крупных приложений, поставляемых по частям. Однако есть один нюанс: при этом всём нам наглухо блокируют доступ к карте напрямую. Хочешь что-то передать на устройство — используй MTP со всеми вытекающими, вроде скорости передачи файлов, сравнимой с прогулочным шагом контуженной черепахи. Карту теперь не только к ПК через кабель напрямую нельзя подключить: её и из выключенного телефона через кардридер просто так не смонтируешь, ведь она отформатирована в нечто неизвестное ни науке, ни нашим компьютерам.",
                    PreviewImage = "https://picsum.photos/1920/1080/?random",
                    PreviewImageText = "В Android 6.0 ввели функцию, позволяющую отформатировать карту памяти",
                    Blocks = ""
                });
            }


            return publications;
        }

        [HttpGet]
        public PublicationModel GetById(Int32 id)
        {
            return new PublicationModel()
            {
                Created = DateTime.Now,
                Updated = null,
                Title = "В Android 6.0 ввели функцию, позволяющую отформатировать карту памяти",
                PreviewText = "В Android 6.0 ввели функцию, позволяющую отформатировать карту памяти так, чтобы она являлась не отдельным хранилищем, а придатком ко внутренней памяти. Это позволяет избежать путаницы с двумя хранилищами данных, особенно при ручной установке некоторых не всегда честно купленных крупных приложений, поставляемых по частям. Однако есть один нюанс: при этом всём нам наглухо блокируют доступ к карте напрямую. Хочешь что-то передать на устройство — используй MTP со всеми вытекающими, вроде скорости передачи файлов, сравнимой с прогулочным шагом контуженной черепахи. Карту теперь не только к ПК через кабель напрямую нельзя подключить: её и из выключенного телефона через кардридер просто так не смонтируешь, ведь она отформатирована в нечто неизвестное ни науке, ни нашим компьютерам.",
                PreviewImage = "https://picsum.photos/1920/1080/?random",
                PreviewImageText = "В Android 6.0 ввели функцию, позволяющую отформатировать карту памяти",
                Blocks = ""
            };
        }
        
        [HttpPost]
        public PublicationModel Post([FromBody]PublicationModel model)
        {
            return model;
        }
    }
}
