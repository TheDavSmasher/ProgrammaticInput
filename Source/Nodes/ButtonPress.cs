using Monocle;
using System.Collections;

namespace Celeste.Mod.ProgrammaticInput.Nodes
{
	/// <summary>
	/// Used for <see cref="Input.Jump"/>, <see cref="Input.Grab"/>, <see cref="Input.Dash"/>,
	/// <see cref="Input.CrouchDash"/>, and <see cref="Input.Talk"/>.
	/// </summary>
	public class ButtonPress : VirtualButton.Node
	{
		private bool changeState;

		private bool PreviousState;

		public bool CurrentState;

		public override bool Check => CurrentState;

		public override bool Pressed => CurrentState && !PreviousState;

		public override bool Released => !CurrentState && PreviousState;

		public override void Update()
		{
			PreviousState = changeState;
			changeState = CurrentState;
		}

		public void Press()
		{
			CurrentState = true;
		}

		public void Release()
		{
			CurrentState = default;
		}

		public IEnumerator HoldPress(float? time = null)
		{
			Press();
			yield return time;
			Release();
		}

		public void AutoHoldPress(float? time = null)
		{
			ProgrammaticNodes.HoldInput(HoldPress(time));
		}

		public static implicit operator bool(ButtonPress b) => b.CurrentState;
	}
}
