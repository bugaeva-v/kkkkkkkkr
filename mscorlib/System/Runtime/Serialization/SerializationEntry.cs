using System;

namespace System.Runtime.Serialization
{
	/// <summary>Содержит значение <see cref="T:System.Type" /> и имя сериализованного объекта.</summary>
	// Token: 0x0200064C RID: 1612
	public readonly struct SerializationEntry
	{
		// Token: 0x06003C54 RID: 15444 RVA: 0x000D14C8 File Offset: 0x000CF6C8
		internal SerializationEntry(string entryName, object entryValue, Type entryType)
		{
			this._name = entryName;
			this._value = entryValue;
			this._type = entryType;
		}

		/// <summary>Возвращает значение, содержащееся в объекте.</summary>
		/// <returns>Значение, содержащееся в объекте.</returns>
		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06003C55 RID: 15445 RVA: 0x000D14DF File Offset: 0x000CF6DF
		public object Value
		{
			get
			{
				return this._value;
			}
		}

		/// <summary>Возвращает имя объекта.</summary>
		/// <returns>Имя объекта.</returns>
		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06003C56 RID: 15446 RVA: 0x000D14E7 File Offset: 0x000CF6E7
		public string Name
		{
			get
			{
				return this._name;
			}
		}

		/// <summary>Возвращает <see cref="T:System.Type" /> объекта.</summary>
		/// <returns>Ключ сущности <see cref="T:System.Type" /> объекта.</returns>
		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06003C57 RID: 15447 RVA: 0x000D14EF File Offset: 0x000CF6EF
		public Type ObjectType
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x04002716 RID: 10006
		private readonly string _name;

		// Token: 0x04002717 RID: 10007
		private readonly object _value;

		// Token: 0x04002718 RID: 10008
		private readonly Type _type;
	}
}
