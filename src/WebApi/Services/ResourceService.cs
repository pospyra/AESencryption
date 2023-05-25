using AppService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Models;
using WebApi.Services;

namespace AppService.Service
{
    public class ResourceService
    {
        private static readonly List<Resource> Resources = new();
        private EncryptionService _encryptionService;

        public ResourceService()
        {
            _encryptionService = new EncryptionService();
        }

        public string Add(string name)
        {
            var resource = new Resource
            {
                Id = Guid.NewGuid(),
                Name = name
            };

            Resources.Add(resource);
            return _encryptionService.Encrypt(resource.Id.ToString());
        }

        public ResourseDto Get(string id)
        {
            var guid = Guid.Parse(_encryptionService.Decrypt(id));
            var resource = Resources.FirstOrDefault(x => x.Id == guid);
            return new ResourseDto
            {
                Id = id,
                Name = resource.Name
            };
        }
    }
}