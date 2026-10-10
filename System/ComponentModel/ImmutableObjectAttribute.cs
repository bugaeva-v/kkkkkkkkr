using System;

namespace System.ComponentModel
{
	/// <summary>Указывает на то, что у объекта нет редактируемых вложенных свойств. Этот класс не наследуется.</summary>
	// Token: 0x02000372 RID: 882
	[AttributeUsage(AttributeTargets.All)]
	public sealed class ImmutableObjectAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.ImmutableObjectAttribute" />.</summary>
		/// <param name="immutable">Значение <see langword="true" />, если объект является неизменным; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x06001D20 RID: 7456 RVA: 0x000684AB File Offset: 0x000666AB
		public ImmutableObjectAttribute(bool immutable)
		{
			this.Immutable = immutable;
		}

		/// <summary>Возвращает значение, показывающее, является ли объект неизменным.</summary>
		/// <returns>Значение <see langword="true" />, если объект является неизменным; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06001D21 RID: 7457 RVA: 0x000684BA File Offset: 0x000666BA
		public bool Immutable { get; }

		/// <summary>Возвращает значение, показывающее, равен ли экземпляр указанному объекту.</summary>
		/// <param name="obj">Объект <see cref="T:System.Object" /> для сравнения с этим экземпляром или пустая ссылка (<see langword="Nothing" /> в Visual Basic).</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="obj" /> равно типу и значению данного экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001D22 RID: 7458 RVA: 0x000684C4 File Offset: 0x000666C4
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			ImmutableObjectAttribute immutableObjectAttribute = obj as ImmutableObjectAttribute;
			bool? flag = (immutableObjectAttribute != null) ? new bool?(immutableObjectAttribute.Immutable) : null;
			bool immutable = this.Immutable;
			return flag.GetValueOrDefault() == immutable & flag != null;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.ComponentModel.ImmutableObjectAttribute" />.</returns>
		// Token: 0x06001D23 RID: 7459 RVA: 0x000678FA File Offset: 0x00065AFA
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Показывает, является ли значение этого экземпляра значением по умолчанию.</summary>
		/// <returns>Значение <see langword="true" />, если этот экземпляр является атрибутом по умолчанию для класса; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001D24 RID: 7460 RVA: 0x00068510 File Offset: 0x00066710
		public override bool IsDefaultAttribute()
		{
			return this.Equals(ImmutableObjectAttribute.Default);
		}

		/// <summary>Определяет, что у объекта нет редактируемых вложенных свойств. Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000EBD RID: 3773
		public static readonly ImmutableObjectAttribute Yes = new ImmutableObjectAttribute(true);

		/// <summary>Определяет, что у объекта есть, по крайней мере, одно редактируемое вложенное свойство. Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000EBE RID: 3774
		public static readonly ImmutableObjectAttribute No = new ImmutableObjectAttribute(false);

		/// <summary>Представляет значение по умолчанию для объекта <see cref="T:System.ComponentModel.ImmutableObjectAttribute" />.</summary>
		// Token: 0x04000EBF RID: 3775
		public static readonly ImmutableObjectAttribute Default = ImmutableObjectAttribute.No;
	}
}
