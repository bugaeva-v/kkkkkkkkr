using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
	/// <summary>Заключает в оболочку атрибут XML <see langword="ENTITIES" />.</summary>
	// Token: 0x020005E6 RID: 1510
	[ComVisible(true)]
	[Serializable]
	public sealed class SoapEntities : ISoapXsd
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapEntities" />.</summary>
		// Token: 0x06003953 RID: 14675 RVA: 0x0000259F File Offset: 0x0000079F
		public SoapEntities()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapEntities" /> с атрибутом XML <see langword="ENTITIES" />.</summary>
		/// <param name="value">Параметр с типом <see cref="T:System.String" />, содержащий атрибут XML <see langword="ENTITIES" />.</param>
		// Token: 0x06003954 RID: 14676 RVA: 0x000CB919 File Offset: 0x000C9B19
		public SoapEntities(string value)
		{
			this._value = SoapHelper.Normalize(value);
		}

		/// <summary>Получает или устанавливает атрибут XML <see langword="ENTITIES" />.</summary>
		/// <returns>Параметр с типом <see cref="T:System.String" />, содержащий атрибут XML <see langword="ENTITIES" />.</returns>
		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06003955 RID: 14677 RVA: 0x000CB92D File Offset: 0x000C9B2D
		// (set) Token: 0x06003956 RID: 14678 RVA: 0x000CB935 File Offset: 0x000C9B35
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
		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06003957 RID: 14679 RVA: 0x000CB93E File Offset: 0x000C9B3E
		public static string XsdType
		{
			get
			{
				return "ENTITIES";
			}
		}

		/// <summary>Возвращает язык определения XML-схемы (XSD) текущего типа SOAP.</summary>
		/// <returns>Объект <see cref="T:System.String" />, указывающий XSD текущего типа SOAP.</returns>
		// Token: 0x06003958 RID: 14680 RVA: 0x000CB945 File Offset: 0x000C9B45
		public string GetXsdType()
		{
			return SoapEntities.XsdType;
		}

		/// <summary>Преобразует заданный <see cref="T:System.String" /> в объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapEntities" />.</summary>
		/// <param name="value">Преобразуемый объект <see langword="String" />.</param>
		/// <returns>Объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapEntities" />, полученный из <paramref name="value" />.</returns>
		// Token: 0x06003959 RID: 14681 RVA: 0x000CB94C File Offset: 0x000C9B4C
		public static SoapEntities Parse(string value)
		{
			return new SoapEntities(value);
		}

		/// <summary>Возвращает <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapEntities.Value" /> как <see cref="T:System.String" />.</summary>
		/// <returns>Строка <see cref="T:System.String" />, полученная из <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapEntities.Value" />.</returns>
		// Token: 0x0600395A RID: 14682 RVA: 0x000CB92D File Offset: 0x000C9B2D
		public override string ToString()
		{
			return this._value;
		}

		// Token: 0x04002627 RID: 9767
		private string _value;
	}
}
