var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");

var solutionFileName = "FacilityGeneratorApi.sln";

void CodeGen(bool verify)
{
}

Task("CodeGen")
	.Does(() => CodeGen(verify: false));

Task("Clean")
	.Does(() =>
	{
		CleanDirectories($"src/**/bin");
		CleanDirectories($"src/**/obj");
	});

Task("VerifyCodeGen")
	.IsDependentOn("Clean")
	.Does(() => CodeGen(verify: true));

Task("Build")
	.IsDependentOn("VerifyCodeGen")
	.Does(() =>
  {
    DotNetCoreRestore("src/Facility.GeneratorApi.WebApi");
    DotNetCoreBuild("src/Facility.GeneratorApi.WebApi", new DotNetCoreBuildSettings { Configuration = configuration });
  });

Task("Default")
	.IsDependentOn("Build");

void ExecuteProcess(string exePath, string arguments)
{
	int exitCode = StartProcess(exePath, arguments);
	if (exitCode != 0)
		throw new InvalidOperationException($"{exePath} failed with exit code {exitCode}.");
}

RunTarget(target);