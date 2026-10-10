using System;

namespace System.ComponentModel
{
	/// <summary>Определяет, используется ли обычно член для привязки данных. Этот класс не наследуется.</summary>
	// Token: 0x02000382 RID: 898
	[AttributeUsage(AttributeTargets.All)]
	public sealed class BindableAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.BindableAttribute" />, используя значение типа Boolean.</summary>
		/// <param name="bindable">Значение <see langword="true" />, чтобы использовать свойство для связывания; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x06001D81 RID: 7553 RVA: 0x00069135 File Offset: 0x00067335
		public BindableAttribute(bool bindable) : this(bindable, BindingDirection.OneWay)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.BindableAttribute" />.</summary>
		/// <param name="bindable">Значение <see langword="true" />, чтобы использовать свойство для связывания; в противном случае — значение <see langword="false" />.</param>
		/// <param name="direction">Одно из значений перечисления <see cref="T:System.ComponentModel.BindingDirection" />.</param>
		// Token: 0x06001D82 RID: 7554 RVA: 0x0006913F File Offset: 0x0006733F
		public BindableAttribute(bool bindable, BindingDirection direction)
		{
			this.Bindable = bindable;
			this.Direction = direction;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.BindableAttribute" /> с использованием одного из стандартных значений <see cref="T:System.ComponentModel.BindableSupport" />.</summary>
		/// <param name="flags">Одно из значений перечисления <see cref="T:System.ComponentModel.BindableSupport" />.</param>
		// Token: 0x06001D83 RID: 7555 RVA: 0x00069155 File Offset: 0x00067355
		public BindableAttribute(BindableSupport flags) : this(flags, BindingDirection.OneWay)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.BindableAttribute" />.</summary>
		/// <param name="flags">Одно из значений перечисления <see cref="T:System.ComponentModel.BindableSupport" />.</param>
		/// <param name="direction">Одно из значений перечисления <see cref="T:System.ComponentModel.BindingDirection" />.</param>
		// Token: 0x06001D84 RID: 7556 RVA: 0x0006915F File Offset: 0x0006735F
		public BindableAttribute(BindableSupport flags, BindingDirection direction)
		{
			this.Bindable = (flags > BindableSupport.No);
			this._isDefault = (flags == BindableSupport.Default);
			this.Direction = direction;
		}

		/// <summary>Возвращает значение, указывающее, что свойство обычно используется для привязки данных.</summary>
		/// <returns>Значение <see langword="true" />, если свойство обычно используется для привязки данных, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06001D85 RID: 7557 RVA: 0x00069182 File Offset: 0x00067382
		public bool Bindable { get; }

		/// <summary>Возвращает значение, показывающее направление или направления этого связывания данных со свойством.</summary>
		/// <returns>Направление привязки данных это свойство.</returns>
		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06001D86 RID: 7558 RVA: 0x0006918A File Offset: 0x0006738A
		public BindingDirection Direction { get; }

		/// <summary>Определяет равенство двух объектов <see cref="T:System.ComponentModel.BindableAttribute" />.</summary>
		/// <param name="obj">Объект для сравнения.</param>
		/// <returns>Значение <see langword="true" />, если заданный <see cref="T:System.ComponentModel.BindableAttribute" /> равен текущему атрибуту <see cref="T:System.ComponentModel.BindableAttribute" />; значение <see langword="false" />, если эти атрибуты не равны.</returns>
		// Token: 0x06001D87 RID: 7559 RVA: 0x00069192 File Offset: 0x00067392
		public override bool Equals(object obj)
		{
			return obj == this || (obj != null && obj is BindableAttribute && ((BindableAttribute)obj).Bindable == this.Bindable);
		}

		/// <summary>Служит хэш-функцией для класса <see cref="T:System.ComponentModel.BindableAttribute" />.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.ComponentModel.BindableAttribute" />.</returns>
		// Token: 0x06001D88 RID: 7560 RVA: 0x000691BC File Offset: 0x000673BC
		public override int GetHashCode()
		{
			return this.Bindable.GetHashCode();
		}

		/// <summary>Определяет, является ли этот атрибут используемым по умолчанию.</summary>
		/// <returns>Значение <see langword="true" />, если атрибут является значением по умолчанию для данного класса атрибутов; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001D89 RID: 7561 RVA: 0x000691D7 File Offset: 0x000673D7
		public override bool IsDefaultAttribute()
		{
			return this.Equals(BindableAttribute.Default) || this._isDefault;
		}

		/// <summary>Указывает, что это свойство обычно используется для привязки данных. Это поле доступно только для чтения.</summary>
		// Token: 0x04000EDC RID: 3804
		public static readonly BindableAttribute Yes = new BindableAttribute(true);

		/// <summary>Указывает, что свойство не предназначено для привязки данных. Это поле доступно только для чтения.</summary>
		// Token: 0x04000EDD RID: 3805
		public static readonly BindableAttribute No = new BindableAttribute(false);

		/// <summary>Задает значение по умолчанию для атрибута <see cref="T:System.ComponentModel.BindableAttribute" />, равное <see cref="F:System.ComponentModel.BindableAttribute.No" />. Это поле доступно только для чтения.</summary>
		// Token: 0x04000EDE RID: 3806
		public static readonly BindableAttribute Default = BindableAttribute.No;

		// Token: 0x04000EDF RID: 3807
		private bool _isDefault;
	}
}
