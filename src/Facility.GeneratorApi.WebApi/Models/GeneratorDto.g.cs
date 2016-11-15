// DO NOT EDIT: generated by fsdgencsharp
using System;
using System.Collections.Generic;
using Facility.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Facility.GeneratorApi.WebApi.Models
{
	/// <summary>
	/// A generator.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	public sealed partial class GeneratorDto : ServiceDto<GeneratorDto>
	{
		/// <summary>
		/// Creates an instance.
		/// </summary>
		public GeneratorDto()
		{
		}

		/// <summary>
		/// The name of the generator.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Determines if two DTOs are equivalent.
		/// </summary>
		public override bool IsEquivalentTo(GeneratorDto other)
		{
			return other != null &&
				Name == other.Name;
		}
	}
}