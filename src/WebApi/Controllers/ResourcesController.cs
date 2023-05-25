using AppService.Model;
using AppService.Service;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourcesController : ControllerBase
    {
        private ResourceService _resourceService;

        public ResourcesController()
        {
            _resourceService = new ResourceService();
        }

        [HttpGet("{id}")]
        public ResourseDto Get(string id)
        {
            return _resourceService.Get(id);
        }

        [HttpPost]
        public string Post([FromBody] string name)
        {
            return _resourceService.Add(name);
        }
    }
}
