using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200010E RID: 270
	[UsedByNativeCode(Name = "ExposedReference")]
	[Serializable]
	public struct ExposedReference<T> where T : Object
	{
		// Token: 0x0600067F RID: 1663 RVA: 0x00008D7C File Offset: 0x00006F7C
		public T Resolve(IExposedPropertyTable resolver)
		{
			bool flag = resolver != null;
			if (flag)
			{
				bool flag2;
				Object referenceValue = resolver.GetReferenceValue(this.exposedName, out flag2);
				bool flag3 = flag2;
				if (flag3)
				{
					return referenceValue as T;
				}
			}
			return this.defaultValue as T;
		}

		// Token: 0x04000386 RID: 902
		[SerializeField]
		public PropertyName exposedName;

		// Token: 0x04000387 RID: 903
		[SerializeField]
		public Object defaultValue;
	}
}
