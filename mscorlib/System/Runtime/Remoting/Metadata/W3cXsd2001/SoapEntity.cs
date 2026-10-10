using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
	/// <summary>Заключает в оболочку атрибут XML <see langword="ENTITY" />.</summary>
	// Token: 0x020005E7 RID: 1511
	[ComVisible(true)]
	[Serializable]
	public sealed class SoapEntity : ISoapXsd
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapEntity" />.</summary>
		// Token: 0x0600395B RID: 14683 RVA: 0x0000259F File Offset: 0x0000079F
		public SoapEntity()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapEntity" /> с атрибутом XML <see langword="ENTITY" />.</summary>
		/// <param name="value">Параметр с типом <see cref="T:System.String" />, содержащий атрибут XML <see langword="ENTITY" />.</param>
		// Token: 0x0600395C RID: 14684 RVA: 0x000CB954 File Offset: 0x000C9B54
		public SoapEntity(string value)
		{
			this._value = SoapHelper.Normalize(value);
		}

		/// <summary>Получает или устанавливает атрибут XML <see langword="ENTITY" />.</summary>
		/// <returns>Параметр с типом <see cref="T:System.String" />, содержащий атрибут XML <see langword="ENTITY" />.</returns>
		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x0600395D RID: 14685 RVA: 0x000CB968 File Offset: 0x000C9B68
		// (set) Token: 0x0600395E RID: 14686 RVA: 0x000CB970 File Offset: 0x000C9B70
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
		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x0600395F RID: 14687 RVA: 0x000CB979 File Offset: 0x000C9B79
		public static string XsdType
		{
			get
			{
				return "ENTITY";
			}
		}

		/// <summary>Возвращает язык определения XML-схемы (XSD) текущего типа SOAP.</summary>
		/// <returns>Объект <see cref="T:System.String" />, указывающий XSD текущего типа SOAP.</returns>
		// Token: 0x06003960 RID: 14688 RVA: 0x000CB980 File Offset: 0x000C9B80
		public string GetXsdType()
		{
			return SoapEntity.XsdType;
		}

		/// <summary>Преобразует заданный <see cref="T:System.String" /> в объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapEntity" />.</summary>
		/// <param name="value">Преобразуемый объект <see langword="String" />.</param>
		/// <returns>Объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapEntities" />, полученный из <paramref name="value" />.</returns>
		// Token: 0x06003961 RID: 14689 RVA: 0x000CB987 File Offset: 0x000C9B87
		public static SoapEntity Parse(string value)
		{
			return new SoapEntity(value);
		}

		/// <summary>Возвращает <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapEntity.Value" /> как <see cref="T:System.String" />.</summary>
		/// <returns>Строка <see cref="T:System.String" />, полученная из <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapEntity.Value" />.</returns>
		// Token: 0x06003962 RID: 14690 RVA: 0x000CB968 File Offset: 0x000C9B68
		public override string ToString()
		{
			return this._value;
		}

		// Token: 0x04002628 RID: 9768
		private string _value;
	}
}
