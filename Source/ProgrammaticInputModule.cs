using System;

namespace Celeste.Mod.ProgrammaticInput;

public class ProgrammaticInputModule : EverestModule {
    public static ProgrammaticInputModule Instance { get; private set; }

    public override Type SettingsType => typeof(ProgrammaticInputModuleSettings);
    public static ProgrammaticInputModuleSettings Settings => (ProgrammaticInputModuleSettings) Instance._Settings;

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
        // TODO: apply any hooks that should always be active
    }

    public override void Unload() {
        // TODO: unapply any hooks applied in Load()
    }
}