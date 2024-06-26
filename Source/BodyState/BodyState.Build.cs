// Copyright 1998-2020 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class BodyState : ModuleRules
{
	public BodyState(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		PublicIncludePaths.AddRange(
			new string[] {
			}
			);
				
		
		PrivateIncludePaths.AddRange(
			new string[] {
				"BodyState/Private",
			}
			);
			
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core"
			}
			);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"AnimGraphRuntime",
				"InputCore",
				"InputDevice",
				"HeadMountedDisplay",
				"Slate",
				"SlateCore",
				"XRBase"
			}
			);
			if (Target.bBuildEditor)
			{
				PrivateDependencyModuleNames.Add("Persona");
			}



			DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
			}
			);
	}
}
