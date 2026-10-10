using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace System.Xml
{
	/// <summary>Обеспечивает динамическое управление оптимизированными строками</summary>
	// Token: 0x0200004C RID: 76
	public class XmlBinaryReaderSession : IXmlDictionary
	{
		/// <summary>Создает объект <see cref="T:System.Xml.XmlDictionaryString" /> из входного параметра и добавляет его во внутреннюю коллекцию.</summary>
		/// <param name="id">Значение ключа.</param>
		/// <param name="value">Значение.</param>
		/// <returns>Новый созданный объект <see cref="T:System.Xml.XmlDictionaryString" />, который добавляется во внутреннюю коллекцию.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="id" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Запись с ключом <paramref name="id" /> уже существует.</exception>
		// Token: 0x06000316 RID: 790 RVA: 0x0000FA78 File Offset: 0x0000DC78
		public XmlDictionaryString Add(int id, string value)
		{
			if (id < 0)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentOutOfRangeException(System.Runtime.Serialization.SR.GetString("ID must be >= 0.")));
			}
			if (value == null)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("value");
			}
			XmlDictionaryString xmlDictionaryString;
			if (this.TryLookup(id, out xmlDictionaryString))
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new InvalidOperationException(System.Runtime.Serialization.SR.GetString("ID already defined.")));
			}
			xmlDictionaryString = new XmlDictionaryString(this, value, id);
			if (id >= 2048)
			{
				if (this.stringDict == null)
				{
					this.stringDict = new Dictionary<int, XmlDictionaryString>();
				}
				this.stringDict.Add(id, xmlDictionaryString);
			}
			else
			{
				if (this.strings == null)
				{
					this.strings = new XmlDictionaryString[Math.Max(id + 1, 16)];
				}
				else if (id >= this.strings.Length)
				{
					XmlDictionaryString[] destinationArray = new XmlDictionaryString[Math.Min(Math.Max(id + 1, this.strings.Length * 2), 2048)];
					Array.Copy(this.strings, destinationArray, this.strings.Length);
					this.strings = destinationArray;
				}
				this.strings[id] = xmlDictionaryString;
			}
			return xmlDictionaryString;
		}

		/// <summary>Проверяет, содержит ли внутренняя коллекция запись, соответствующую ключу.</summary>
		/// <param name="key">Искомый ключ.</param>
		/// <param name="result">Когда выполнение этого метода завершается, содержит строку, если запись была найдена; в противном случае — значение <see langword="null" />. Этот параметр передается неинициализированным.</param>
		/// <returns>Значение <see langword="true" />, если запись, соответствующая <paramref name="key" />, найдена; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000317 RID: 791 RVA: 0x0000FB70 File Offset: 0x0000DD70
		public bool TryLookup(int key, out XmlDictionaryString result)
		{
			if (this.strings != null && key >= 0 && key < this.strings.Length)
			{
				result = this.strings[key];
				return result != null;
			}
			if (key >= 2048 && this.stringDict != null)
			{
				return this.stringDict.TryGetValue(key, out result);
			}
			result = null;
			return false;
		}

		/// <summary>Проверяет, содержит ли внутренняя коллекция запись, соответствующую значению.</summary>
		/// <param name="value">Значение, которое нужно найти.</param>
		/// <param name="result">Когда выполнение этого метода завершается, содержит строку, если запись была найдена; в противном случае — значение <see langword="null" />. Этот параметр передается неинициализированным.</param>
		/// <returns>Значение <see langword="true" />, если запись, соответствующая <paramref name="value" />, найдена; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000318 RID: 792 RVA: 0x0000FBC8 File Offset: 0x0000DDC8
		public bool TryLookup(string value, out XmlDictionaryString result)
		{
			if (value == null)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("value");
			}
			if (this.strings != null)
			{
				for (int i = 0; i < this.strings.Length; i++)
				{
					XmlDictionaryString xmlDictionaryString = this.strings[i];
					if (xmlDictionaryString != null && xmlDictionaryString.Value == value)
					{
						result = xmlDictionaryString;
						return true;
					}
				}
			}
			if (this.stringDict != null)
			{
				foreach (XmlDictionaryString xmlDictionaryString2 in this.stringDict.Values)
				{
					if (xmlDictionaryString2.Value == value)
					{
						result = xmlDictionaryString2;
						return true;
					}
				}
			}
			result = null;
			return false;
		}

		/// <summary>Проверяет, содержит ли внутренняя коллекция запись, соответствующую значению.</summary>
		/// <param name="value">Значение, которое нужно найти.</param>
		/// <param name="result">Когда выполнение этого метода завершается, содержит строку, если запись была найдена; в противном случае — значение <see langword="null" />. Этот параметр передается неинициализированным.</param>
		/// <returns>Значение <see langword="true" />, если запись, соответствующая <paramref name="value" />, найдена; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000319 RID: 793 RVA: 0x0000FC88 File Offset: 0x0000DE88
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

		/// <summary>Очищает внутреннюю коллекцию от всего содержимого.</summary>
		// Token: 0x0600031A RID: 794 RVA: 0x0000FCAF File Offset: 0x0000DEAF
		public void Clear()
		{
			if (this.strings != null)
			{
				Array.Clear(this.strings, 0, this.strings.Length);
			}
			if (this.stringDict != null)
			{
				this.stringDict.Clear();
			}
		}

		// Token: 0x04000212 RID: 530
		private const int MaxArrayEntries = 2048;

		// Token: 0x04000213 RID: 531
		private XmlDictionaryString[] strings;

		// Token: 0x04000214 RID: 532
		private Dictionary<int, XmlDictionaryString> stringDict;
	}
}
