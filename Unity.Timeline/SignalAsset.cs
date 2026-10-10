using System;

namespace UnityEngine.Timeline
{
	// Token: 0x0200002A RID: 42
	[AssetFileNameExtension("signal", new string[]
	{

	})]
	public class SignalAsset : ScriptableObject
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000242 RID: 578 RVA: 0x000085F8 File Offset: 0x000067F8
		// (remove) Token: 0x06000243 RID: 579 RVA: 0x0000862C File Offset: 0x0000682C
		internal static event Action<SignalAsset> OnEnableCallback;

		// Token: 0x06000244 RID: 580 RVA: 0x0000865F File Offset: 0x0000685F
		private void OnEnable()
		{
			if (SignalAsset.OnEnableCallback != null)
			{
				SignalAsset.OnEnableCallback(this);
			}
		}
	}
}
