using System;

namespace System.Xml.Schema
{
	/// <summary>
	///         Перечисления для модели содержимого сложного типа.
	///          Представляет содержимое в наборе сведений после проверки схемы (infoset).
	///       </summary>
	// Token: 0x020005A7 RID: 1447
	public enum XmlSchemaContentType
	{
		/// <summary>
		///         Только текстовое содержимое.
		///       </summary>
		// Token: 0x04002B1A RID: 11034
		TextOnly,
		/// <summary>
		///         Пустое содержимое.
		///       </summary>
		// Token: 0x04002B1B RID: 11035
		Empty,
		/// <summary>
		///         Только содержимое элемента.
		///       </summary>
		// Token: 0x04002B1C RID: 11036
		ElementOnly,
		/// <summary>
		///         Смешанное содержимое.
		///       </summary>
		// Token: 0x04002B1D RID: 11037
		Mixed
	}
}
