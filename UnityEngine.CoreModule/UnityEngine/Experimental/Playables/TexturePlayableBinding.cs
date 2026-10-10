using System;
using UnityEngine.Playables;

namespace UnityEngine.Experimental.Playables
{
	// Token: 0x0200046D RID: 1133
	public static class TexturePlayableBinding
	{
		// Token: 0x0600281E RID: 10270 RVA: 0x00042D90 File Offset: 0x00040F90
		public static PlayableBinding Create(string name, Object key)
		{
			return PlayableBinding.CreateInternal(name, key, typeof(RenderTexture), new PlayableBinding.CreateOutputMethod(TexturePlayableBinding.CreateTextureOutput));
		}

		// Token: 0x0600281F RID: 10271 RVA: 0x00042DC0 File Offset: 0x00040FC0
		private static PlayableOutput CreateTextureOutput(PlayableGraph graph, string name)
		{
			return TexturePlayableOutput.Create(graph, name, null);
		}
	}
}
