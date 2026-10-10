using System;

namespace System.ComponentModel
{
	/// <summary>Указывает, когда может использоваться объект <see cref="T:System.ComponentModel.License" />.</summary>
	// Token: 0x020003CB RID: 971
	public enum LicenseUsageMode
	{
		/// <summary>Используется во время выполнения.</summary>
		// Token: 0x04000F57 RID: 3927
		Runtime,
		/// <summary>Используется визуальным конструктором или компилятором во время разработки.</summary>
		// Token: 0x04000F58 RID: 3928
		Designtime
	}
}
