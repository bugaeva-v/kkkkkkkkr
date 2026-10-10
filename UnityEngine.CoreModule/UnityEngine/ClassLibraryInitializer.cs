using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001FE RID: 510
	internal static class ClassLibraryInitializer
	{
		// Token: 0x0600167C RID: 5756 RVA: 0x00024018 File Offset: 0x00022218
		[RequiredByNativeCode]
		private static void Init()
		{
			UnityLogWriter.Init();
		}
	}
}
