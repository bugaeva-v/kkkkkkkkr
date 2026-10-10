using System;

namespace System.ComponentModel
{
	/// <summary>Указывает, следует ли отображать свойство или событие в окне "Свойства".</summary>
	// Token: 0x02000364 RID: 868
	[AttributeUsage(AttributeTargets.All)]
	public sealed class BrowsableAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.BrowsableAttribute" />.</summary>
		/// <param name="browsable">Значение <see langword="true" />, если свойство или событие можно изменять во время разработки; в противном случае — значение <see langword="false" />. Значение по умолчанию: <see langword="true" />.</param>
		// Token: 0x06001CD7 RID: 7383 RVA: 0x00067EB9 File Offset: 0x000660B9
		public BrowsableAttribute(bool browsable)
		{
			this.Browsable = browsable;
		}

		/// <summary>Возвращает значение, показывающее, будет ли объект отображаться в окне свойств.</summary>
		/// <returns>Значение <see langword="true" />, если объект отображается в окне свойств; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001CD8 RID: 7384 RVA: 0x00067EC8 File Offset: 0x000660C8
		public bool Browsable { get; }

		/// <summary>Указывает, равен ли этот экземпляр заданному объекту.</summary>
		/// <param name="obj">Другой объект, подлежащий сравнению.</param>
		/// <returns>Значение <see langword="true" />, если значение параметра <paramref name="obj" /> равно данному экземпляру; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001CD9 RID: 7385 RVA: 0x00067ED0 File Offset: 0x000660D0
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			BrowsableAttribute browsableAttribute = obj as BrowsableAttribute;
			bool? flag = (browsableAttribute != null) ? new bool?(browsableAttribute.Browsable) : null;
			bool browsable = this.Browsable;
			return flag.GetValueOrDefault() == browsable & flag != null;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06001CDA RID: 7386 RVA: 0x00067F1C File Offset: 0x0006611C
		public override int GetHashCode()
		{
			return this.Browsable.GetHashCode();
		}

		/// <summary>Определяет, является ли этот атрибут используемым по умолчанию.</summary>
		/// <returns>Значение <see langword="true" />, если атрибут является значением по умолчанию для данного класса атрибутов; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001CDB RID: 7387 RVA: 0x00067F37 File Offset: 0x00066137
		public override bool IsDefaultAttribute()
		{
			return this.Equals(BrowsableAttribute.Default);
		}

		/// <summary>Указывает, что свойство или событие можно изменять во время разработки. Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000E9E RID: 3742
		public static readonly BrowsableAttribute Yes = new BrowsableAttribute(true);

		/// <summary>Указывает, что свойство или событие нельзя изменять во время разработки. Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000E9F RID: 3743
		public static readonly BrowsableAttribute No = new BrowsableAttribute(false);

		/// <summary>Задает значение по умолчанию для атрибута <see cref="T:System.ComponentModel.BrowsableAttribute" />, равное <see cref="F:System.ComponentModel.BrowsableAttribute.Yes" />. Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000EA0 RID: 3744
		public static readonly BrowsableAttribute Default = BrowsableAttribute.Yes;
	}
}
