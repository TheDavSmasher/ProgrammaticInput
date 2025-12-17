using System;
using Celeste.Mod.ProgrammaticInput.Binds;

namespace Celeste.Mod.ProgrammaticInput;

public class ProgrammaticInputModule : EverestModule {
    public static ProgrammaticInputModule Instance { get; private set; }

	// Store Settings
	public override Type SettingsType => typeof(ProgrammaticInputSettings);
	public static ProgrammaticInputSettings Settings => (ProgrammaticInputSettings)Instance._Settings;

	public ProgrammaticInputModule() {
        Instance = this;
#if DEBUG
        // debug builds use verbose logging
        Logger.SetLogLevel(nameof(ProgrammaticInputModule), LogLevel.Verbose);
#else
        // release builds use info logging to reduce spam in log files
        Logger.SetLogLevel(nameof(ProgrammaticInputModule), LogLevel.Info);
#endif
    }

    public override void Load() {
		Everest.Events.Level.OnLoadLevel += ResetOnLoad;
    }

	public override void Unload() {
		Everest.Events.Level.OnLoadLevel -= ResetOnLoad;
	}

	private void ResetOnLoad(Level level, Player.IntroTypes playerIntro, bool isFromLoader)
	{
		if (!Settings.ResetOnLevelLoad)
			return;

		MenuBinds.ESC.Release();
		MenuBinds.Pause.Release();
		MenuBinds.MenuLeft.Release();
		MenuBinds.MenuRight.Release();
		MenuBinds.MenuUp.Release();
		MenuBinds.MenuDown.Release();
		MenuBinds.MenuConfirm.Release();
		MenuBinds.MenuCancel.Release();
		MenuBinds.MenuJournal.Release();
		MenuBinds.QuickRestart.Release();

		GameplayBinds.MoveX.SetNeutral();
		GameplayBinds.MoveY.SetNeutral();
		GameplayBinds.GliderMoveY.SetNeutral();

		GameplayBinds.Aim.SetNeutral();
		GameplayBinds.Feather.SetNeutral();
		MenuBinds.MountainAim.SetNeutral();

		GameplayBinds.Jump.Release();
		GameplayBinds.Dash.Release();
		GameplayBinds.Grab.Release();
		GameplayBinds.Talk.Release();
		GameplayBinds.CrouchDash.Release();
	}

	public override void OnInputInitialize()
	{
		base.OnInputInitialize();

		Input.ESC.Nodes.Add(MenuBinds.ESC);
		Input.Pause.Nodes.Add(MenuBinds.Pause);
		Input.MenuLeft.Nodes.Add(MenuBinds.MenuLeft);
		Input.MenuRight.Nodes.Add(MenuBinds.MenuRight);
		Input.MenuUp.Nodes.Add(MenuBinds.MenuUp);
		Input.MenuDown.Nodes.Add(MenuBinds.MenuDown);
		Input.MenuConfirm.Nodes.Add(MenuBinds.MenuConfirm);
		Input.MenuCancel.Nodes.Add(MenuBinds.MenuCancel);
		Input.MenuJournal.Nodes.Add(MenuBinds.MenuJournal);
		Input.QuickRestart.Nodes.Add(MenuBinds.QuickRestart);

		Input.MoveX.Nodes.Add(GameplayBinds.MoveX);
		Input.MoveY.Nodes.Add(GameplayBinds.MoveY);
		Input.GliderMoveY.Nodes.Add(GameplayBinds.GliderMoveY);

		Input.Aim.Nodes.Add(GameplayBinds.Aim);
		Input.Feather.Nodes.Add(GameplayBinds.Feather);
		Input.MountainAim.Nodes.Add(MenuBinds.MountainAim);

		Input.Jump.Nodes.Add(GameplayBinds.Jump);
		Input.Dash.Nodes.Add(GameplayBinds.Dash);
		Input.Grab.Nodes.Add(GameplayBinds.Grab);
		Input.Talk.Nodes.Add(GameplayBinds.Talk);
		Input.CrouchDash.Nodes.Add(GameplayBinds.CrouchDash);
	}

	public override void OnInputDeregister()
	{
		base.OnInputDeregister();

		Input.ESC?.Nodes.Remove(MenuBinds.ESC);
		Input.Pause?.Nodes.Remove(MenuBinds.Pause);
		Input.MenuLeft?.Nodes.Remove(MenuBinds.MenuLeft);
		Input.MenuRight?.Nodes.Remove(MenuBinds.MenuRight);
		Input.MenuUp?.Nodes.Remove(MenuBinds.MenuUp);
		Input.MenuDown?.Nodes.Remove(MenuBinds.MenuDown);
		Input.MenuConfirm?.Nodes.Remove(MenuBinds.MenuConfirm);
		Input.MenuCancel?.Nodes.Remove(MenuBinds.MenuCancel);
		Input.MenuJournal?.Nodes.Remove(MenuBinds.MenuJournal);
		Input.QuickRestart?.Nodes.Remove(MenuBinds.QuickRestart);

		Input.MoveX?.Nodes.Remove(GameplayBinds.MoveX);
		Input.MoveY?.Nodes.Remove(GameplayBinds.MoveY);
		Input.GliderMoveY?.Nodes.Remove(GameplayBinds.GliderMoveY);

		Input.Aim?.Nodes.Remove(GameplayBinds.Aim);
		Input.Feather?.Nodes.Remove(GameplayBinds.Feather);
		Input.MountainAim?.Nodes.Remove(MenuBinds.MountainAim);

		Input.Jump?.Nodes.Remove(GameplayBinds.Jump);
		Input.Dash?.Nodes.Remove(GameplayBinds.Dash);
		Input.Grab?.Nodes.Remove(GameplayBinds.Grab);
		Input.Talk?.Nodes.Remove(GameplayBinds.Talk);
		Input.CrouchDash?.Nodes.Remove(GameplayBinds.CrouchDash);
	}
}