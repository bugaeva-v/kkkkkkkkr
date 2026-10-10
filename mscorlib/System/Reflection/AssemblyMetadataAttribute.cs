using System;

namespace System.Reflection
{
	/// <summary>Определяет пару метаданных «ключ-значение» для помеченной сборки.</summary>
	// Token: 0x0200088B RID: 2187
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true, Inherited = false)]
	public sealed class AssemblyMetadataAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.AssemblyMetadataAttribute" /> с помощью указанного ключа метаданных и значения.</summary>
		/// <param name="key">Ключ метаданных.</param>
		/// <param name="value">Значение метаданных.</param>
		// Token: 0x0600486C RID: 18540 RVA: 0x000EE126 File Offset: 0x000EC326
		public AssemblyMetadataAttribute(string key, string value)
		{
			this.Key = key;
			this.Value = value;
		}

		/// <summary>Получает ключ метаданных.</summary>
		/// <returns>Ключ метаданных.</returns>
		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x0600486D RID: 18541 RVA: 0x000EE13C File Offset: 0x000EC33C
		public string Key { get; }

		/// <summary>Получает значение метаданных.</summary>
		/// <returns>Значение метаданных.</returns>
		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x0600486E RID: 18542 RVA: 0x000EE144 File Offset: 0x000EC344
		public string Value { get; }
	}
}
