using Monocle;
using System.Collections;

namespace Celeste.Mod.ProgrammaticInput.Nodes
{
	/// <summary>
	/// Used for <see cref="Input.MoveX"/>, <see cref="Input.MoveY"/>, and <see cref="Input.GliderMoveY"/>,
	/// which correlate to regular movement and Jellyfish float.
	/// </summary>
	public class AxisValue : VirtualAxis.Node
	{
		public float CurrentValue;

		public override float Value => CurrentValue;

		public void SetValue(float value)
		{
			CurrentValue = value;
		}

		public void SetNeutral()
		{
			CurrentValue = default;
		}

		public IEnumerator HoldValue(float value, float? time = null)
		{
			SetValue(value);
			yield return time;
			SetNeutral();
		}

		public void AutoHoldValue(float value, float? time = null)
		{
			ProgrammaticNodes.HoldInput(HoldValue(value, time));
		}

		public static implicit operator float(AxisValue a) => a.Value;
	}
}
