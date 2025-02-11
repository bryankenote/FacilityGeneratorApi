// <auto-generated>
// DO NOT EDIT: generated by fsdgencsharp
// </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;
using Facility.Core;

namespace Facility.GeneratorApi
{
	/// <summary>
	/// Response for Generate.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	public sealed partial class GenerateResponseDto : ServiceDto<GenerateResponseDto>
	{
		/// <summary>
		/// Creates an instance.
		/// </summary>
		public GenerateResponseDto()
		{
		}

		/// <summary>
		/// The output from the generator.
		/// </summary>
		public IReadOnlyList<NamedTextDto>? Output { get; set; }

		/// <summary>
		/// The failure, if any.
		/// </summary>
		public FailureDto? Failure { get; set; }

		/// <summary>
		/// Returns the DTO as JSON.
		/// </summary>
		public override string ToString() => SystemTextJsonServiceSerializer.Instance.ToJson(this);

		/// <summary>
		/// Determines if two DTOs are equivalent.
		/// </summary>
		public override bool IsEquivalentTo(GenerateResponseDto? other)
		{
			return other != null &&
				ServiceDataUtility.AreEquivalentFieldValues(Output, other.Output) &&
				ServiceDataUtility.AreEquivalentDtos(Failure, other.Failure);
		}
	}
}
