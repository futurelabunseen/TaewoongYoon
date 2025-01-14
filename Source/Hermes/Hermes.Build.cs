// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Hermes : ModuleRules
{
	public Hermes(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(
			new string[] { 
				"Core", 
				"CoreUObject", 
				"Engine", 
				"InputCore", 
				"EnhancedInput" ,
				"NavigationSystem", 
				"AIModule",
                "GameplayAbilities",
				"GameplayTags",
                "GameplayTasks",
				"UMG",
				"CPathfinding"
			}
		);

        //PublicIncludePaths.AddRange(new string[] { "CPathfinding/Public"});

        PrivateIncludePaths.Add("Hermes");
    }
}
