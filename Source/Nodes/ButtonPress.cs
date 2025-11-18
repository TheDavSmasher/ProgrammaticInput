using Monocle;

namespace Celeste.Mod.ProgrammaticInput.Nodes
{
	/// <summary>
	/// Used for <see cref="Input.Jump"/>, <see cref="Input.Grab"/>, <see cref="Input.Dash"/>,
	/// <see cref="Input.CrouchDash"/>, and <see cref="Input.Talk"/>.
	/// </summary>
	public class ButtonPress : VirtualButton.Node
	{
		private bool PreviousDecision;

		public bool CurrentDecision;

		public override bool Check => CurrentDecision;

		public override bool Pressed => CurrentDecision && !PreviousDecision;

		public override bool Released => !CurrentDecision && PreviousDecision;

		public override void Update()
		{
			PreviousDecision = CurrentDecision;
		}
	}
}
