using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
	/// <summary>Заключает в оболочку тип XSD <see langword="QName" />.</summary>
	// Token: 0x020005FB RID: 1531
	[ComVisible(true)]
	[Serializable]
	public sealed class SoapQName : ISoapXsd
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapQName" />.</summary>
		// Token: 0x060039FB RID: 14843 RVA: 0x0000259F File Offset: 0x0000079F
		public SoapQName()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapQName" /> с локальной частью полного имени.</summary>
		/// <param name="value">Объект <see cref="T:System.String" />, содержащий локальную часть имени.</param>
		// Token: 0x060039FC RID: 14844 RVA: 0x000CC06A File Offset: 0x000CA26A
		public SoapQName(string value)
		{
			this._name = value;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapQName" /> с псевдонимом пространства имен и локальной частью полного имени.</summary>
		/// <param name="key">Объект <see cref="T:System.String" />, содержащий псевдоним пространства имен полного имени.</param>
		/// <param name="name">Объект <see cref="T:System.String" />, содержащий локальную часть имени.</param>
		// Token: 0x060039FD RID: 14845 RVA: 0x000CC079 File Offset: 0x000CA279
		public SoapQName(string key, string name)
		{
			this._key = key;
			this._name = name;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapQName" /> с псевдонимом пространства имен, локальной частью полного имени и пространством имен, на которое ссылается псевдоним.</summary>
		/// <param name="key">Объект <see cref="T:System.String" />, содержащий псевдоним пространства имен полного имени.</param>
		/// <param name="name">Объект <see cref="T:System.String" />, содержащий локальную часть имени.</param>
		/// <param name="namespaceValue">Строка <see cref="T:System.String" />, содержащая пространство имен, на которое ссылается <paramref name="key" />.</param>
		// Token: 0x060039FE RID: 14846 RVA: 0x000CC08F File Offset: 0x000CA28F
		public SoapQName(string key, string name, string namespaceValue)
		{
			this._key = key;
			this._name = name;
			this._namespace = namespaceValue;
		}

		/// <summary>Получает или задает псевдоним пространства имен в полном имени.</summary>
		/// <returns>Объект <see cref="T:System.String" />, содержащий псевдоним пространства имен полного имени.</returns>
		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x060039FF RID: 14847 RVA: 0x000CC0AC File Offset: 0x000CA2AC
		// (set) Token: 0x06003A00 RID: 14848 RVA: 0x000CC0B4 File Offset: 0x000CA2B4
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}

		/// <summary>Получает или задает именную часть имени.</summary>
		/// <returns>Объект <see cref="T:System.String" />, содержащий часть, составляющую имя в полном имени.</returns>
		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06003A01 RID: 14849 RVA: 0x000CC0BD File Offset: 0x000CA2BD
		// (set) Token: 0x06003A02 RID: 14850 RVA: 0x000CC0C5 File Offset: 0x000CA2C5
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}

		/// <summary>Получает или задает пространство имен, на которое ссылается <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapQName.Key" />.</summary>
		/// <returns>Строка <see cref="T:System.String" />, содержащая пространство имен, на которое ссылается <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapQName.Key" />.</returns>
		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06003A03 RID: 14851 RVA: 0x000CC0CE File Offset: 0x000CA2CE
		// (set) Token: 0x06003A04 RID: 14852 RVA: 0x000CC0D6 File Offset: 0x000CA2D6
		public string Namespace
		{
			get
			{
				return this._namespace;
			}
			set
			{
				this._namespace = value;
			}
		}

		/// <summary>Получает язык определения XML-схемы (XSD) текущего типа SOAP.</summary>
		/// <returns>Объект <see cref="T:System.String" />, указывающий XSD текущего типа SOAP.</returns>
		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06003A05 RID: 14853 RVA: 0x000CC0DF File Offset: 0x000CA2DF
		public static string XsdType
		{
			get
			{
				return "QName";
			}
		}

		/// <summary>Возвращает язык определения XML-схемы (XSD) текущего типа SOAP.</summary>
		/// <returns>Строка <see cref="T:System.String" />, указывающая XSD текущего типа SOAP.</returns>
		// Token: 0x06003A06 RID: 14854 RVA: 0x000CC0E6 File Offset: 0x000CA2E6
		public string GetXsdType()
		{
			return SoapQName.XsdType;
		}

		/// <summary>Преобразует заданный <see cref="T:System.String" /> в объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapQName" />.</summary>
		/// <param name="value">Преобразуемый объект <see cref="T:System.String" />.</param>
		/// <returns>Объект <see cref="T:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapQName" />, полученный из <paramref name="value" />.</returns>
		// Token: 0x06003A07 RID: 14855 RVA: 0x000CC0F0 File Offset: 0x000CA2F0
		public static SoapQName Parse(string value)
		{
			SoapQName soapQName = new SoapQName();
			int num = value.IndexOf(':');
			if (num != -1)
			{
				soapQName.Key = value.Substring(0, num);
				soapQName.Name = value.Substring(num + 1);
			}
			else
			{
				soapQName.Name = value;
			}
			return soapQName;
		}

		/// <summary>Возвращает имя в виде строки <see cref="T:System.String" />.</summary>
		/// <returns>
		///   <see cref="T:System.String" /> в формате "<see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapQName.Key" /> : <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapQName.Name" />". Если <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapQName.Key" /> не задан, этот метод возвращает <see cref="P:System.Runtime.Remoting.Metadata.W3cXsd2001.SoapQName.Name" />.</returns>
		// Token: 0x06003A08 RID: 14856 RVA: 0x000CC137 File Offset: 0x000CA337
		public override string ToString()
		{
			if (this._key == null || this._key == "")
			{
				return this._name;
			}
			return this._key + ":" + this._name;
		}

		// Token: 0x0400263E RID: 9790
		private string _name;

		// Token: 0x0400263F RID: 9791
		private string _key;

		// Token: 0x04002640 RID: 9792
		private string _namespace;
	}
}
