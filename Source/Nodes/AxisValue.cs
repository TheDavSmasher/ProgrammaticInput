using Monocle;
using Microsoft.Xna.Framework;

namespace Celeste.Mod.ProgrammaticInput.Nodes
{
	public abstract class AxisValue : VirtualAxis.Node
	{
		public float CurrentValue;

		public abstract Vector2 VectorValue { set; }

		public override float Value => CurrentValue;

		public static implicit operator float(AxisValue a) => a.Value;
	}

	/// <summary>
	/// Used for <see cref="Input.MoveX"/>, which correlates to regular movement.
	/// </summary>
	public class AxisXValue : AxisValue
	{
		public override Vector2 VectorValue { set => CurrentValue = value.X; }
	}

	/// <summary>
	/// Used for <see cref="Input.MoveY"/> and <see cref="Input.GliderMoveY"/>,
	/// which correlate to regular movement and Jellyfish float.
	/// </summary>
	public class AxisYValue : AxisValue
	{
		public override Vector2 VectorValue { set => CurrentValue = value.Y; }
	}
}
