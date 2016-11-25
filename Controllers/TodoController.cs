using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Http;

namespace ExampleApi.Controllers
{
	public class TodoData
	{
		public string Item { get; set; }
	}

    public class TodoController : ApiController
    {
		// depency injection
		static List<string> items = new List<string>();

		public IHttpActionResult Get()
        {
			return Json(items);
        }

		public IHttpActionResult Post([FromBody] TodoData item)
		{
			items.Add(item.Item);
			return Ok();
		}
    }
}
