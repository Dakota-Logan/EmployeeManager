using System;
using System.Collections;
using System.Collections.Generic;
using DotNet.Models;
using DotNet.Services;
using DotNet.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotNet.Controllers
{
	[ApiController]
	[Route("/api")]
	public class EmployeeController : ControllerBase
	{
		private readonly EmployeeService _es;

		public EmployeeController(EmployeeService es)
		{
			_es = es;
		}

		[HttpGet]
		public ActionResult<IEnumerable<Employee>> Get()
		{
			try
			{
				return Ok(_es.Get());
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}
	}
}