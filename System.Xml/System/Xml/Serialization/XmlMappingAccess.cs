using System;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Указывает, является ли сопоставление чтения и записи.
	///       </summary>
	// Token: 0x020002D5 RID: 725
	[Flags]
	public enum XmlMappingAccess
	{
		/// <summary>
		///         Чтения и записи методы создаются.
		///       </summary>
		// Token: 0x040019F6 RID: 6646
		None = 0,
		/// <summary>
		///         Генерируются методы чтения.
		///       </summary>
		// Token: 0x040019F7 RID: 6647
		Read = 1,
		/// <summary>
		///         Записи создаются методы.
		///       </summary>
		// Token: 0x040019F8 RID: 6648
		Write = 2
	}
}
