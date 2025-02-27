using System;

namespace Rubicon.SourceGenerators;

public static class GenerationConstants
{
    public const string NodeClass = "Godot.Node";
    public const string SignalAttr = "Godot.SignalAttribute";
    public const string StaticAutoloadAttr = "Rubicon.Core.StaticAutoloadSingletonAttribute";
    public const string ProjectSettingAttr = "Rubicon.Core.Settings.ProjectSettingAttribute";
    public const string UserSettingsData = "Rubicon.Core.Settings.UserSettingsData";
    public const string UserSettingsInstance = "Rubicon.Core.Settings.UserSettingsInstance";
    
    // TODO: I'm sure there are other C# keywords, put them here.
    public static string[] Keywords = ["event"];
}