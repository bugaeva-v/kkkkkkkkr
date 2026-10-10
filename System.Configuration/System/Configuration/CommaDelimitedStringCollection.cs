using System;
using System.Collections.Specialized;

namespace System.Configuration
{
	/// <summary>Представляет коллекцию строковых элементов, разделенных запятыми. Этот класс не наследуется.</summary>
	// Token: 0x0200000F RID: 15
	public sealed class CommaDelimitedStringCollection : StringCollection
	{
		/// <summary>Возвращает значение, указывающее, была ли коллекция изменена.</summary>
		/// <returns>
		///   <see langword="true" />, если коллекция <see cref="T:System.Configuration.CommaDelimitedStringCollection" /> была изменена; в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000028 RID: 40 RVA: 0x000023C0 File Offset: 0x000005C0
		public bool IsModified
		{
			get
			{
				if (this.modified)
				{
					return true;
				}
				string text = this.ToString();
				return text != null && text.GetHashCode() != this.originalStringHash;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли объект коллекции доступным только для чтения.</summary>
		/// <returns>
		///   <see langword="true" />, если указанный строковый элемент в <see cref="T:System.Configuration.CommaDelimitedStringCollection" /> доступен только для чтения; в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000029 RID: 41 RVA: 0x000023F4 File Offset: 0x000005F4
		public new bool IsReadOnly
		{
			get
			{
				return this.readOnly;
			}
		}

		/// <summary>Возвращает или задает строковый элемент в коллекции по указанному индексу.</summary>
		/// <param name="index">Индекс строкового элемента в коллекции.</param>
		/// <returns>Строковый элемент в коллекции.</returns>
		// Token: 0x1700000D RID: 13
		public new string this[int index]
		{
			get
			{
				return base[index];
			}
			set
			{
				if (this.readOnly)
				{
					throw new ConfigurationErrorsException("The configuration is read only");
				}
				base[index] = value;
				this.modified = true;
			}
		}

		/// <summary>Добавляет строку в коллекцию, разделенную запятыми.</summary>
		/// <param name="value">Строковое значение.</param>
		// Token: 0x0600002C RID: 44 RVA: 0x00002429 File Offset: 0x00000629
		public new void Add(string value)
		{
			if (this.readOnly)
			{
				throw new ConfigurationErrorsException("The configuration is read only");
			}
			base.Add(value);
			this.modified = true;
		}

		/// <summary>Добавляет все строки из строкового массива в коллекцию.</summary>
		/// <param name="range">Массив объектов, добавляемых в коллекцию.</param>
		// Token: 0x0600002D RID: 45 RVA: 0x0000244D File Offset: 0x0000064D
		public new void AddRange(string[] range)
		{
			if (this.readOnly)
			{
				throw new ConfigurationErrorsException("The configuration is read only");
			}
			base.AddRange(range);
			this.modified = true;
		}

		/// <summary>Очищает коллекцию.</summary>
		// Token: 0x0600002E RID: 46 RVA: 0x00002470 File Offset: 0x00000670
		public new void Clear()
		{
			if (this.readOnly)
			{
				throw new ConfigurationErrorsException("The configuration is read only");
			}
			base.Clear();
			this.modified = true;
		}

		/// <summary>Создает копию коллекции.</summary>
		/// <returns>Копия объекта <see cref="T:System.Configuration.CommaDelimitedStringCollection" />.</returns>
		// Token: 0x0600002F RID: 47 RVA: 0x00002494 File Offset: 0x00000694
		public CommaDelimitedStringCollection Clone()
		{
			CommaDelimitedStringCollection commaDelimitedStringCollection = new CommaDelimitedStringCollection();
			string[] array = new string[base.Count];
			base.CopyTo(array, 0);
			commaDelimitedStringCollection.AddRange(array);
			commaDelimitedStringCollection.originalStringHash = this.originalStringHash;
			return commaDelimitedStringCollection;
		}

		/// <summary>Добавляет строковый элемент в коллекцию по указанному индексу.</summary>
		/// <param name="index">Индекс коллекции, по которому добавляется новый элемент.</param>
		/// <param name="value">Значение нового элемента, добавляемого в коллекцию.</param>
		// Token: 0x06000030 RID: 48 RVA: 0x000024CD File Offset: 0x000006CD
		public new void Insert(int index, string value)
		{
			if (this.readOnly)
			{
				throw new ConfigurationErrorsException("The configuration is read only");
			}
			base.Insert(index, value);
			this.modified = true;
		}

		/// <summary>Удаляет строковый элемент из коллекции.</summary>
		/// <param name="value">Удаляемая строка.</param>
		// Token: 0x06000031 RID: 49 RVA: 0x000024F1 File Offset: 0x000006F1
		public new void Remove(string value)
		{
			if (this.readOnly)
			{
				throw new ConfigurationErrorsException("The configuration is read only");
			}
			base.Remove(value);
			this.modified = true;
		}

		/// <summary>Устанавливает коллекцию в режим только для чтения.</summary>
		// Token: 0x06000032 RID: 50 RVA: 0x00002514 File Offset: 0x00000714
		public void SetReadOnly()
		{
			this.readOnly = true;
		}

		/// <summary>Возвращает строковое представление объекта.</summary>
		/// <returns>Строковое представление объекта.</returns>
		// Token: 0x06000033 RID: 51 RVA: 0x00002520 File Offset: 0x00000720
		public override string ToString()
		{
			if (base.Count == 0)
			{
				return null;
			}
			string[] array = new string[base.Count];
			base.CopyTo(array, 0);
			return string.Join(",", array);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002558 File Offset: 0x00000758
		internal void UpdateStringHash()
		{
			string text = this.ToString();
			if (text == null)
			{
				this.originalStringHash = 0;
				return;
			}
			this.originalStringHash = text.GetHashCode();
		}

		// Token: 0x04000035 RID: 53
		private bool modified;

		// Token: 0x04000036 RID: 54
		private bool readOnly;

		// Token: 0x04000037 RID: 55
		private int originalStringHash;
	}
}
