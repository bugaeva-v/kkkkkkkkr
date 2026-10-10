using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
	/// <summary>Заключает в оболочку атрибут XML <see langword="NMTOKEN" />.</summary>
	// Token: 0x020005F4 RID: 1524
	[ComVisible(true)]
	[Serializable]
	public sealed class SoapNmtoken : ISoapXsd
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNmtoken" />.</summary>
		// Token: 0x060039C3 RID: 14787 RVA: 0x0000259F File Offset: 0x0000079F
		public SoapNmtoken()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNmtoken" /> с атрибутом XML <see langword="NMTOKEN" />.</summary>
		/// <param name="value">Строка <see cref="T:System.String" />, содержащая атрибут XML <see langword="NMTOKEN" />.</param>
		// Token: 0x060039C4 RID: 14788 RVA: 0x000CBE3C File Offset: 0x000CA03C
		public SoapNmtoken(string value)
		{
			this._value = SoapHelper.Normalize(value);
		}

		/// <summary>Получает или устанавливает атрибут XML <see langword="NMTOKEN" />.</summary>
		/// <returns>Параметр с типом <see cref="T:System.String" />, содержащий атрибут XML <see langword="NMTOKEN" />.</returns>
		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x060039C5 RID: 14789 RVA: 0x000CBE50 File Offset: 0x000CA050
		// (set) Token: 0x060039C6 RID: 14790 RVA: 0x000CBE58 File Offset: 0x000CA058
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
		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x060039C7 RID: 14791 RVA: 0x000CBE61 File Offset: 0x000CA061
		public static string XsdType
		{
			get
			{
				return "NMTOKEN";
			}
		}

		/// <summary>Возвращает язык определения XML-схемы (XSD) текущего типа SOAP.</summary>
		/// <returns>Объект <see cref="T:System.String" />, указывающий XSD текущего типа SOAP.</returns>
		// Token: 0x060039C8 RID: 14792 RVA: 0x000CBE68 File Offset: 0x000CA068
		public string GetXsdType()
		{
			return SoapNmtoken.XsdType;
		}

		/// <summary>Преобразует заданный <see cref="T:System.String" /> в объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNmtoken" />.</summary>
		/// <param name="value">Преобразуемый объект <see langword="String" />.</param>
		/// <returns>Объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNmtoken" />, полученный из <paramref name="value" />.</returns>
		// Token: 0x060039C9 RID: 14793 RVA: 0x000CBE6F File Offset: 0x000CA06F
		public static SoapNmtoken Parse(string value)
		{
			return new SoapNmtoken(value);
		}

		/// <summary>Возвращает <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNmtoken.Value" /> как <see cref="T:System.String" />.</summary>
		/// <returns>Строка <see cref="T:System.String" />, полученная из <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNmtoken.Value" />.</returns>
		// Token: 0x060039CA RID: 14794 RVA: 0x000CBE50 File Offset: 0x000CA050
		public override string ToString()
		{
			return this._value;
		}

		// Token: 0x04002637 RID: 9783
		private string _value;
	}
}
