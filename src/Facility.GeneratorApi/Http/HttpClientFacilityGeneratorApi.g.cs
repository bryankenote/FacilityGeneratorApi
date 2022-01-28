// <auto-generated>
// DO NOT EDIT: generated by fsdgencsharp
// </auto-generated>
#nullable enable
using System;
using System.Threading;
using System.Threading.Tasks;
using Facility.Core;
using Facility.Core.Http;

namespace Facility.GeneratorApi.Http
{
	/// <summary>
	/// Generates code from Facility Service Definitions.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	public sealed partial class HttpClientFacilityGeneratorApi : HttpClientService, IFacilityGeneratorApi
	{
		/// <summary>
		/// Creates the service.
		/// </summary>
		public HttpClientFacilityGeneratorApi(HttpClientServiceSettings? settings = null)
			: base(settings, s_defaults)
		{
		}

		/// <summary>
		/// Gets information about the API.
		/// </summary>
		public Task<ServiceResult<GetApiInfoResponseDto>> GetApiInfoAsync(GetApiInfoRequestDto request, CancellationToken cancellationToken = default) =>
			TrySendRequestAsync(FacilityGeneratorApiHttpMapping.GetApiInfoMapping, request, cancellationToken);

		/// <summary>
		/// Generates code from a service definition.
		/// </summary>
		public Task<ServiceResult<GenerateResponseDto>> GenerateAsync(GenerateRequestDto request, CancellationToken cancellationToken = default) =>
			TrySendRequestAsync(FacilityGeneratorApiHttpMapping.GenerateMapping, request, cancellationToken);

		private static readonly HttpClientServiceDefaults s_defaults = new HttpClientServiceDefaults
		{
			ContentSerializer = HttpContentSerializer.Create(SystemTextJsonServiceSerializer.Instance),
		};
	}
}
