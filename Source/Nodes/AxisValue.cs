using Monocle;
using Microsoft.Xna.Framework;

namespace Celeste.Mod.ProgrammaticInput.Nodes
{
	public abstract class AxisValue : VirtualAxis.Node
	{
		public float CurrentDecision;

		public abstract Vector2 VectorDecision { set; }

		public override float Value => CurrentDecision;
	}

	/// <summary>
	/// Used for <see cref="Input.MoveX"/>, which correlates to regular movement.
	/// </summary>
	public class AxisXValue : AxisValue
	{
		public override Vector2 VectorDecision { set => CurrentDecision = value.X; }
	}

	/// <summary>
	/// Used for <see cref="Input.MoveY"/> and <see cref="Input.GliderMoveY"/>,
	/// which correlate to regular movement and Jellyfish float.
	/// </summary>
	public class AxisYValue : AxisValue
	{
		public override Vector2 VectorDecision { set => CurrentDecision = value.Y; }
	}
}
