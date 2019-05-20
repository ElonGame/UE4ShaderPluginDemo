namespace UnrealBuildTool.Rules
{
	public class PixelShader : ModuleRules
	{
		public PixelShader(ReadOnlyTargetRules Target) : base(Target)
        {
            PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

            PrivateIncludePaths.AddRange(
                new string[] {
					"PixelShader/Private"
				}
                );

			PublicDependencyModuleNames.AddRange(
				new string[]
				{
					"Core",
					"CoreUObject",
                    "Engine",
                    "RenderCore",
                    "RHI"
				}
				);

            PrivateDependencyModuleNames.AddRange(
                new string[]
                {
                    "Projects",
					// ... add private dependencies that you statically link with here ...
				}
                );
        }
	}
}