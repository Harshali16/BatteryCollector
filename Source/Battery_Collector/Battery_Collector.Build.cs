// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Battery_Collector : ModuleRules
{
	public Battery_Collector(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay","UMG" });
	}
}
