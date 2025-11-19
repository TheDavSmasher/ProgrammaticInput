using Celeste.Mod.ProgrammaticInput.Nodes;

namespace Celeste.Mod.ProgrammaticInput.Binds
{
	public static class GameplayBinds
	{
		public static readonly AxisXValue MoveX = new();

		public static readonly AxisYValue MoveY = new();

		public static readonly AxisYValue GliderMoveY = new();



		public static readonly JoystickDirection Aim = new();

		public static readonly JoystickDirection Feather = new();



		public static readonly ButtonPress Jump = new();

		public static readonly ButtonPress Grab = new();

		public static readonly ButtonPress Dash = new();

		public static readonly ButtonPress Talk = new();

		public static readonly ButtonPress CrouchDash = new();
	}
}
