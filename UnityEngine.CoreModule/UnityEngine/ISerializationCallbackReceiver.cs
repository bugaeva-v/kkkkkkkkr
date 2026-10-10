using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000238 RID: 568
	[RequiredByNativeCode]
	public interface ISerializationCallbackReceiver
	{
		// Token: 0x0600180D RID: 6157
		[RequiredByNativeCode]
		void OnBeforeSerialize();

		// Token: 0x0600180E RID: 6158
		[RequiredByNativeCode]
		void OnAfterDeserialize();
	}
}
