// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class LineRenderer_UE4EditorTarget : TargetRules
{
	public LineRenderer_UE4EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "LineRenderer_UE4" } );
	}
}
