﻿using Microsoft.AspNetCore.Mvc;

namespace AccountingServer.Presentation.Abstraction
{
	[ApiController]
	[Route("api/[controller]")]
	public abstract class ApiController : ControllerBase
	{
	}
}
