// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class IDEOLOGYEditorTarget : TargetRules
{
	public IDEOLOGYEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
        bUsesSteam = true;
		ExtraModuleNames.AddRange( new string[] { "IDEOLOGY" } );
	}
}
