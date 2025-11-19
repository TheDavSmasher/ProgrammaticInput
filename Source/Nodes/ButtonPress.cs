using Monocle;

namespace Celeste.Mod.ProgrammaticInput.Nodes
{
	/// <summary>
	/// Used for <see cref="Input.Jump"/>, <see cref="Input.Grab"/>, <see cref="Input.Dash"/>,
	/// <see cref="Input.CrouchDash"/>, and <see cref="Input.Talk"/>.
	/// </summary>
	public class ButtonPress : VirtualButton.Node
	{
		private bool PreviousState;

		public bool CurrentState;

		public override bool Check => CurrentState;

		public override bool Pressed => CurrentState && !PreviousState;

		public override bool Released => !CurrentState && PreviousState;

		public override void Update()
		{
			PreviousState = CurrentState;
		}
	}
}
