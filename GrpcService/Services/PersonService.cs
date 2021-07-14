using System;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using testt.Model;
using testt.Service;

namespace GrpcService.Services
{
    public class PersonService : PersonProto.PersonProtoBase
    {
        private readonly ILogger<PersonService> _logger;

        private readonly IDBService _service;

        public PersonService(ILogger<PersonService> logger, IDBService service)
        {
            _logger = logger;
            _service = service;
        }

        public override Task<PersonModel> GetPersonById(PersonLookupModel request, ServerCallContext context)
        {
            Person person = _service.Get().Where(x => x.Id == request.Id).SingleOrDefault();
            return Task.FromResult(new PersonModel() {FirstName =  person.FirstName, LastName = person.LastName});
        }
    }
}
