﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedClassLibrary.Contracts;
using SharedClassLibrary.DTOs;

namespace IdentityManagerServer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AccountController(IUserAccount userAccount) : ControllerBase
	{
		[HttpPost("register")]
		public async Task<IActionResult> Register(UserDTO userDTO)
		{
			var response = await userAccount.CreateAccount(userDTO);
			return Ok(response);
		}
		[HttpPost("login")]
		public async Task<IActionResult> Login(LoginDTO loginDTO)
		{
			var response = await userAccount.LogginAccount(loginDTO);
			return Ok(response);
		}
	}
}
