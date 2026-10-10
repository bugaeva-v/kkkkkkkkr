using System;

namespace System.CodeDom
{
	/// <summary>Указывает способ разрешения ссылки на тип кода.</summary>
	// Token: 0x020002EC RID: 748
	[Flags]
	public enum CodeTypeReferenceOptions
	{
		/// <summary>Распознайте тип из корневого пространства имен.</summary>
		// Token: 0x04000D3D RID: 3389
		GlobalReference = 1,
		/// <summary>Распознайте тип из параметра типа.</summary>
		// Token: 0x04000D3E RID: 3390
		GenericTypeParameter = 2
	}
}
