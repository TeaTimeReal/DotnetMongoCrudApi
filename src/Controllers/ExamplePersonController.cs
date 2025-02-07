using Microsoft.AspNetCore.Components;
using MongoCrudApi.DataTypes;

namespace MongoCrudApi.Controllers
{
    [Route("/Person")]
    public class ExamplePersonController : GenericMongoCrudController<ExamplePerson>
    {
        public ExamplePersonController(ILogger<GenericMongoCrudController<ExamplePerson>> logger) : base(logger) { }
    }
}
