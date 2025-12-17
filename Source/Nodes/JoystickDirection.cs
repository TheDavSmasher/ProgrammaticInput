using Monocle;
using Microsoft.Xna.Framework;
using System.Collections;

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

		public IEnumerator HoldDirection(Vector2 value, float? time = null)
		{
			SetDirection(value);
			yield return time;
			SetNeutral();
		}

		public void AutoHoldDirection(Vector2 value, float? time = null)
		{
			Engine.Scene.Tracker.GetEntity<Player>().Add(new Coroutine(HoldDirection(value, time)));
		}

		public static implicit operator Vector2(JoystickDirection j) => j.Value;
	}
}
