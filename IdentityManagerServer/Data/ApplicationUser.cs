﻿using Microsoft.AspNetCore.Identity;

namespace IdentityManagerServer.Data
{
	public class ApplicationUser : IdentityUser
	{
		public string Name { get; set; } = default!;
	}
}
