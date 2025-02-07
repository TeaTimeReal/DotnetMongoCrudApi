using Microsoft.AspNetCore.Components;
using MongoCrudApi.DataTypes;

namespace MongoCrudApi.Controllers
{
    [Route("/Product")]
    public class ExampleProductController : GenericMongoCrudController<ExampleProduct>
    {
        public ExampleProductController(ILogger<GenericMongoCrudController<ExampleProduct>> logger) : base(logger) { }
    }
}
