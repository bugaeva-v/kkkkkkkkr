using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
	/// <summary>Заключает в оболочку тип XSD <see langword="anyURI" />.</summary>
	// Token: 0x020005E0 RID: 1504
	[ComVisible(true)]
	[Serializable]
	public sealed class SoapAnyUri : ISoapXsd
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapAnyUri" />.</summary>
		// Token: 0x06003925 RID: 14629 RVA: 0x0000259F File Offset: 0x0000079F
		public SoapAnyUri()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapAnyUri" /> с заданным универсальным кодом ресурса.</summary>
		/// <param name="value">Объект <see cref="T:System.String" />, содержащий URI.</param>
		// Token: 0x06003926 RID: 14630 RVA: 0x000CB277 File Offset: 0x000C9477
		public SoapAnyUri(string value)
		{
			this._value = value;
		}

		/// <summary>Получает или задает URI.</summary>
		/// <returns>Объект <see cref="T:System.String" />, содержащий URI.</returns>
		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06003927 RID: 14631 RVA: 0x000CB286 File Offset: 0x000C9486
		// (set) Token: 0x06003928 RID: 14632 RVA: 0x000CB28E File Offset: 0x000C948E
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
		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06003929 RID: 14633 RVA: 0x000CB297 File Offset: 0x000C9497
		public static string XsdType
		{
			get
			{
				return "anyUri";
			}
		}

		/// <summary>Возвращает язык определения XML-схемы (XSD) текущего типа SOAP.</summary>
		/// <returns>Объект <see cref="T:System.String" />, указывающий XSD текущего типа SOAP.</returns>
		// Token: 0x0600392A RID: 14634 RVA: 0x000CB29E File Offset: 0x000C949E
		public string GetXsdType()
		{
			return SoapAnyUri.XsdType;
		}

		/// <summary>Преобразует заданный <see cref="T:System.String" /> в объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapAnyUri" />.</summary>
		/// <param name="value">Преобразуемый объект <see cref="T:System.String" />.</param>
		/// <returns>Объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapAnyUri" />, полученный из <paramref name="value" />.</returns>
		// Token: 0x0600392B RID: 14635 RVA: 0x000CB2A5 File Offset: 0x000C94A5
		public static SoapAnyUri Parse(string value)
		{
			return new SoapAnyUri(value);
		}

		/// <summary>Возвращает <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapAnyUri.Value" /> как <see cref="T:System.String" />.</summary>
		/// <returns>Строка <see cref="T:System.String" />, полученная из <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapAnyUri.Value" />.</returns>
		// Token: 0x0600392C RID: 14636 RVA: 0x000CB286 File Offset: 0x000C9486
		public override string ToString()
		{
			return this._value;
		}

		// Token: 0x0400261F RID: 9759
		private string _value;
	}
}
