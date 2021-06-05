using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MockRepo.IService;
using MockRepo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockRepo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : GenericController<Teacher>
    {
        public TeachersController(IGenericService<Teacher> genericService) : base(genericService)
        {

        }
    }
}
