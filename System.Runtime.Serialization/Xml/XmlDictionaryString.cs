using System;
using System.Runtime.Serialization;
using System.Text;

namespace System.Xml
{
	/// <summary>Представляет запись, которая хранится в <see cref="T:System.Xml.XmlDictionary" />.</summary>
	// Token: 0x02000064 RID: 100
	public class XmlDictionaryString
	{
		/// <summary>Создает экземпляр этого класса.</summary>
		/// <param name="dictionary">Класс <see cref="T:System.Xml.IXmlDictionary" />, содержащий этот экземпляр.</param>
		/// <param name="value">Строка, являющаяся значением записи словаря.</param>
		/// <param name="key">Целое число, являющееся ключом записи словаря.</param>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="dictionary" /> или <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="key" /> имеет значение меньше 0 или больше <see cref="F:System.Int32.MaxValue" /> / 4.</exception>
		// Token: 0x06000549 RID: 1353 RVA: 0x000189B0 File Offset: 0x00016BB0
		public XmlDictionaryString(IXmlDictionary dictionary, string value, int key)
		{
			if (dictionary == null)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentNullException("dictionary"));
			}
			if (value == null)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentNullException("value"));
			}
			if (key < 0 || key > 536870911)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentOutOfRangeException("key", System.Runtime.Serialization.SR.GetString("The value of this argument must fall within the range {0} to {1}.", new object[]
				{
					0,
					536870911
				})));
			}
			this.dictionary = dictionary;
			this.value = value;
			this.key = key;
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00018A40 File Offset: 0x00016C40
		internal static string GetString(XmlDictionaryString s)
		{
			if (s == null)
			{
				return null;
			}
			return s.Value;
		}

		/// <summary>Возвращает объект <see cref="T:System.Xml.XmlDictionaryString" />, представляющий пустую строку.</summary>
		/// <returns>Объект <see cref="T:System.Xml.XmlDictionaryString" />, представляющий пустую строку.</returns>
		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x00018A4D File Offset: 0x00016C4D
		public static XmlDictionaryString Empty
		{
			get
			{
				return XmlDictionaryString.emptyStringDictionary.EmptyString;
			}
		}

		/// <summary>Представляет <see cref="T:System.Xml.IXmlDictionary" />, передаваемый конструктору экземпляра <see cref="T:System.Xml.XmlDictionaryString" />.</summary>
		/// <returns>
		///   <see cref="T:System.Xml.IXmlDictionary" /> для этой записи словаря.</returns>
		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x00018A59 File Offset: 0x00016C59
		public IXmlDictionary Dictionary
		{
			get
			{
				return this.dictionary;
			}
		}

		/// <summary>Возвращает целочисленный ключ для экземпляра класса.</summary>
		/// <returns>Целочисленный ключ для этого экземпляра класса.</returns>
		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x00018A61 File Offset: 0x00016C61
		public int Key
		{
			get
			{
				return this.key;
			}
		}

		/// <summary>Возвращает строковое значение для этого экземпляра класса.</summary>
		/// <returns>Строковое значение для этого экземпляра класса.</returns>
		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x00018A69 File Offset: 0x00016C69
		public string Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00018A71 File Offset: 0x00016C71
		internal byte[] ToUTF8()
		{
			if (this.buffer == null)
			{
				this.buffer = Encoding.UTF8.GetBytes(this.value);
			}
			return this.buffer;
		}

		/// <summary>Отображает текстовое представление объекта.</summary>
		/// <returns>Строковое значение для этого экземпляра класса.</returns>
		// Token: 0x06000550 RID: 1360 RVA: 0x00018A69 File Offset: 0x00016C69
		public override string ToString()
		{
			return this.value;
		}

		// Token: 0x04000291 RID: 657
		internal const int MinKey = 0;

		// Token: 0x04000292 RID: 658
		internal const int MaxKey = 536870911;

		// Token: 0x04000293 RID: 659
		private IXmlDictionary dictionary;

		// Token: 0x04000294 RID: 660
		private string value;

		// Token: 0x04000295 RID: 661
		private int key;

		// Token: 0x04000296 RID: 662
		private byte[] buffer;

		// Token: 0x04000297 RID: 663
		private static XmlDictionaryString.EmptyStringDictionary emptyStringDictionary = new XmlDictionaryString.EmptyStringDictionary();

		// Token: 0x02000065 RID: 101
		private class EmptyStringDictionary : IXmlDictionary
		{
			// Token: 0x06000552 RID: 1362 RVA: 0x00018AA3 File Offset: 0x00016CA3
			public EmptyStringDictionary()
			{
				this.empty = new XmlDictionaryString(this, string.Empty, 0);
			}

			// Token: 0x1700009C RID: 156
			// (get) Token: 0x06000553 RID: 1363 RVA: 0x00018ABD File Offset: 0x00016CBD
			public XmlDictionaryString EmptyString
			{
				get
				{
					return this.empty;
				}
			}

			// Token: 0x06000554 RID: 1364 RVA: 0x00018AC5 File Offset: 0x00016CC5
			public bool TryLookup(string value, out XmlDictionaryString result)
			{
				if (value == null)
				{
					throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("value");
				}
				if (value.Length == 0)
				{
					result = this.empty;
					return true;
				}
				result = null;
				return false;
			}

			// Token: 0x06000555 RID: 1365 RVA: 0x00018AEB File Offset: 0x00016CEB
			public bool TryLookup(int key, out XmlDictionaryString result)
			{
				if (key == 0)
				{
					result = this.empty;
					return true;
				}
				result = null;
				return false;
			}

			// Token: 0x06000556 RID: 1366 RVA: 0x0000FC88 File Offset: 0x0000DE88
			public bool TryLookup(XmlDictionaryString value, out XmlDictionaryString result)
			{
				if (value == null)
				{
					throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentNullException("value"));
				}
				if (value.Dictionary != this)
				{
					result = null;
					return false;
				}
				result = value;
				return true;
			}

			// Token: 0x04000298 RID: 664
			private XmlDictionaryString empty;
		}
	}
}
