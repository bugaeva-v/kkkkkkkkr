using System;

namespace UnityEngine
{
	// Token: 0x0200010F RID: 271
	public interface IExposedPropertyTable
	{
		// Token: 0x06000680 RID: 1664
		void SetReferenceValue(PropertyName id, Object value);

		// Token: 0x06000681 RID: 1665
		Object GetReferenceValue(PropertyName id, out bool idValid);

		// Token: 0x06000682 RID: 1666
		void ClearReferenceValue(PropertyName id);
	}
}
