using System;

namespace UnityEngine.Playables
{
	// Token: 0x0200044D RID: 1101
	public static class ScriptPlayableBinding
	{
		// Token: 0x060026ED RID: 9965 RVA: 0x00041034 File Offset: 0x0003F234
		public static PlayableBinding Create(string name, Object key, Type type)
		{
			return PlayableBinding.CreateInternal(name, key, type, new PlayableBinding.CreateOutputMethod(ScriptPlayableBinding.CreateScriptOutput));
		}

		// Token: 0x060026EE RID: 9966 RVA: 0x0004105C File Offset: 0x0003F25C
		private static PlayableOutput CreateScriptOutput(PlayableGraph graph, string name)
		{
			return ScriptPlayableOutput.Create(graph, name);
		}
	}
}
