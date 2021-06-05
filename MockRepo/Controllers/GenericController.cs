using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MockRepo.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockRepo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T> : Controller where T : class
    {
        private IGenericService<T> _genericService;

        public GenericController(IGenericService<T> genericService)
        {
            _genericService = genericService;
        }

        // GET: api/Generic
        [HttpGet]
        public List<T> Get()
        {
            return _genericService.GetAll();
        }
        

        // GET: appi/Generic/5
        [HttpGet("{id}")]
        public T Get(int id)
        {
            return _genericService.GetById(id);
        }
        
        // POST: api/Generic
        [HttpPost]
        public List<T> Post([FromBody] T value)
        {
            return _genericService.Insert(value);
        }
        
        // DELETE api/ApiWithActions/5
        public List<T> Delete(int id)
        {
            return _genericService.Delete(id);
        }
       

    }
}
