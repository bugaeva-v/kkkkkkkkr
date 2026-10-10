using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
	/// <summary>Заключает в оболочку тип XML <see langword="Name" />.</summary>
	// Token: 0x020005F1 RID: 1521
	[ComVisible(true)]
	[Serializable]
	public sealed class SoapName : ISoapXsd
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapName" />.</summary>
		// Token: 0x060039AB RID: 14763 RVA: 0x0000259F File Offset: 0x0000079F
		public SoapName()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapName" /> с типом XML <see langword="Name" />.</summary>
		/// <param name="value">Строка <see cref="T:System.String" />, содержащая тип XML <see langword="Name" />.</param>
		// Token: 0x060039AC RID: 14764 RVA: 0x000CBD59 File Offset: 0x000C9F59
		public SoapName(string value)
		{
			this._value = SoapHelper.Normalize(value);
		}

		/// <summary>Получает или устанавливает тип XML <see langword="Name" />.</summary>
		/// <returns>Строка <see cref="T:System.String" />, содержащая тип XML <see langword="Name" />.</returns>
		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x060039AD RID: 14765 RVA: 0x000CBD6D File Offset: 0x000C9F6D
		// (set) Token: 0x060039AE RID: 14766 RVA: 0x000CBD75 File Offset: 0x000C9F75
		public string Value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
			}
		}

		/// <summary>Получает язык определения XML-схемы (XSD) текущего типа SOAP.</summary>
		/// <returns>Объект <see cref="T:System.String" />, указывающий XSD текущего типа SOAP.</returns>
		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x060039AF RID: 14767 RVA: 0x000CBD7E File Offset: 0x000C9F7E
		public static string XsdType
		{
			get
			{
				return "Name";
			}
		}

		/// <summary>Возвращает язык определения XML-схемы (XSD) текущего типа SOAP.</summary>
		/// <returns>Объект <see cref="T:System.String" />, указывающий XSD текущего типа SOAP.</returns>
		// Token: 0x060039B0 RID: 14768 RVA: 0x000CBD85 File Offset: 0x000C9F85
		public string GetXsdType()
		{
			return SoapName.XsdType;
		}

		/// <summary>Преобразует заданный <see cref="T:System.String" /> в объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapName" />.</summary>
		/// <param name="value">Преобразуемый объект <see langword="String" />.</param>
		/// <returns>Объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapName" />, полученный из <paramref name="value" />.</returns>
		// Token: 0x060039B1 RID: 14769 RVA: 0x000CBD8C File Offset: 0x000C9F8C
		public static SoapName Parse(string value)
		{
			return new SoapName(value);
		}

		/// <summary>Возвращает <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapName.Value" /> как <see cref="T:System.String" />.</summary>
		/// <returns>Строка <see cref="T:System.String" />, полученная из <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapName.Value" />.</returns>
		// Token: 0x060039B2 RID: 14770 RVA: 0x000CBD6D File Offset: 0x000C9F6D
		public override string ToString()
		{
			return this._value;
		}

		// Token: 0x04002634 RID: 9780
		private string _value;
	}
}
