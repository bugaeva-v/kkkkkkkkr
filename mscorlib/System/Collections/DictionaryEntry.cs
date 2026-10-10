using System;

namespace System.Collections
{
	/// <summary>Определяет пару «ключ-значение», которую можно задать или извлечь.</summary>
	// Token: 0x02000A10 RID: 2576
	[Serializable]
	public struct DictionaryEntry
	{
		/// <summary>Инициализирует экземпляр типа <see cref="T:System.Collections.DictionaryEntry" /> с указанным ключом и значением.</summary>
		/// <param name="key">Объект, определенный в каждой паре "ключ-значение".</param>
		/// <param name="value">Описание, связанное с параметром <paramref name="key" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Значением параметра <paramref name="key" /> является <see langword="null" />, и версией платформы .NET Framework является 1.0 или 1.1.</exception>
		// Token: 0x06005B73 RID: 23411 RVA: 0x00134B86 File Offset: 0x00132D86
		public DictionaryEntry(object key, object value)
		{
			this._key = key;
			this._value = value;
		}

		/// <summary>Получает или задает ключ в паре ключ/значение.</summary>
		/// <returns>Ключ из пары ключ/значение.</returns>
		// Token: 0x17000FBC RID: 4028
		// (get) Token: 0x06005B74 RID: 23412 RVA: 0x00134B96 File Offset: 0x00132D96
		// (set) Token: 0x06005B75 RID: 23413 RVA: 0x00134B9E File Offset: 0x00132D9E
		public object Key
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

		/// <summary>Получает или задает значение в паре ключ/значение.</summary>
		/// <returns>Значение из пары ключ/значение.</returns>
		// Token: 0x17000FBD RID: 4029
		// (get) Token: 0x06005B76 RID: 23414 RVA: 0x00134BA7 File Offset: 0x00132DA7
		// (set) Token: 0x06005B77 RID: 23415 RVA: 0x00134BAF File Offset: 0x00132DAF
		public object Value
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

		// Token: 0x06005B78 RID: 23416 RVA: 0x00134BB8 File Offset: 0x00132DB8
		public void Deconstruct(out object key, out object value)
		{
			key = this.Key;
			value = this.Value;
		}

		// Token: 0x04003867 RID: 14439
		private object _key;

		// Token: 0x04003868 RID: 14440
		private object _value;
	}
}
