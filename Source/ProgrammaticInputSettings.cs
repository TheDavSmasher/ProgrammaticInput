namespace Celeste.Mod.ProgrammaticInput;

public class ProgrammaticInputSettings : EverestModuleSettings
{
	[SettingName("Reset on Level Load")]
	public bool ResetOnLevelLoad { get; set; }

	[SettingName("Force reset current input")]
	public ButtonBinding InputResetBind { get; set; }
}
