using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000217 RID: 535
	internal class ScriptingUtility
	{
		// Token: 0x06001768 RID: 5992 RVA: 0x000259D8 File Offset: 0x00023BD8
		[RequiredByNativeCode]
		private static bool IsManagedCodeWorking()
		{
			ScriptingUtility.TestClass testClass = new ScriptingUtility.TestClass
			{
				value = 42
			};
			return testClass.value == 42;
		}

		// Token: 0x02000218 RID: 536
		private struct TestClass
		{
			// Token: 0x04000806 RID: 2054
			public int value;
		}
	}
}
