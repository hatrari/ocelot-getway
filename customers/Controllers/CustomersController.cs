using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Customers.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class CustomersController : ControllerBase
	{
		private readonly string[] customers = new[] {"Customer 1", "Customer 2"};
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return customers;
		}
	}
}
