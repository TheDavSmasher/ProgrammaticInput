using Monocle;
using System.Collections;

namespace Celeste.Mod.ProgrammaticInput.Nodes
{
	internal class NodeExts
	{
		public static void HoldInput(IEnumerator input)
		{
			Engine.Scene.Tracker.GetEntity<Player>().Add(new Coroutine(input));
		}
	}
}
