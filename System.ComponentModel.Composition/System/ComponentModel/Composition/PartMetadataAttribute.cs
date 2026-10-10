using System;

namespace System.ComponentModel.Composition
{
	/// <summary>Задает метаданные для части.</summary>
	// Token: 0x02000051 RID: 81
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
	public sealed class PartMetadataAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.PartMetadataAttribute" /> с помощью указанного имени и значения метаданных.</summary>
		/// <param name="name">Строка, содержащая имя и значение метаданных, или <see langword="null" />, чтобы использовать пустую строку ("").</param>
		/// <param name="value">Объект, содержащий значение метаданных. Это может быть <see langword="null" />.</param>
		// Token: 0x06000224 RID: 548 RVA: 0x000069E3 File Offset: 0x00004BE3
		public PartMetadataAttribute(string name, object value)
		{
			this.Name = (name ?? string.Empty);
			this.Value = value;
		}

		/// <summary>Получает имя значения метаданных.</summary>
		/// <returns>Строка, содержащая имя значения метаданных.</returns>
		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000225 RID: 549 RVA: 0x00006A02 File Offset: 0x00004C02
		// (set) Token: 0x06000226 RID: 550 RVA: 0x00006A0A File Offset: 0x00004C0A
		public string Name { get; private set; }

		/// <summary>Получает значение метаданных.</summary>
		/// <returns>Объект, содержащий значение метаданных.</returns>
		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000227 RID: 551 RVA: 0x00006A13 File Offset: 0x00004C13
		// (set) Token: 0x06000228 RID: 552 RVA: 0x00006A1B File Offset: 0x00004C1B
		public object Value { get; private set; }
	}
}
