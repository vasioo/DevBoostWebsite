﻿using System.ComponentModel.DataAnnotations;

namespace DevBoost.Models.HelpModels
{
	public interface IHelpMessage
	{
		public string Name { get; set; }

		public string Email { get; set; }

		public string Message { get; set; }
	}
}
