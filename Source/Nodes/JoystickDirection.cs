using Monocle;
using Microsoft.Xna.Framework;

namespace Celeste.Mod.ProgrammaticInput.Nodes
{
	/// <summary>
	/// Used for <see cref="Input.Aim"/> and <see cref="Input.Feather"/>,
	/// which correlate to Dash direction and Feather/Swimming movement.
	/// </summary>
	public class JoystickDirection : VirtualJoystick.Node
	{
		public Vector2 CurrentDirection;

		public override Vector2 Value => CurrentDirection;

		public void SetDirection(Vector2 value)
		{
			CurrentDirection = value;
		}

		public void SetNeutral()
		{
			CurrentDirection = default;
		}

		public static implicit operator Vector2(JoystickDirection j) => j.Value;
	}
}
