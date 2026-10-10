using System;

namespace System.Security.Cryptography
{
	/// <summary>
	///         Указывает параметры свойства ключа криптографии следующего поколения (CNG).
	///       </summary>
	// Token: 0x02000052 RID: 82
	[Flags]
	public enum CngPropertyOptions
	{
		/// <summary>
		///         Указанное свойство не имеет параметров.
		///       </summary>
		// Token: 0x04000346 RID: 838
		None = 0,
		/// <summary>
		///         Свойство не указано, CNG.
		///          Используйте этот параметр, чтобы избежать конфликтов имен будущих свойств CNG.
		///       </summary>
		// Token: 0x04000347 RID: 839
		CustomProperty = 1073741824,
		/// <summary>
		///         Свойство должно быть сохранено.
		///       </summary>
		// Token: 0x04000348 RID: 840
		Persist = -2147483648
	}
}
