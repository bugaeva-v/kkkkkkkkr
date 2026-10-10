using System;

namespace System.ComponentModel
{
	/// <summary>Задает тип сохранения, используемый при сериализации свойства компонента во время разработки.</summary>
	// Token: 0x0200036A RID: 874
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event)]
	public sealed class DesignerSerializationVisibilityAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DesignerSerializationVisibilityAttribute" />, используя указанное значение <see cref="T:System.ComponentModel.DesignerSerializationVisibility" />.</summary>
		/// <param name="visibility">Одно из значений <see cref="T:System.ComponentModel.DesignerSerializationVisibility" />.</param>
		// Token: 0x06001CF8 RID: 7416 RVA: 0x00068215 File Offset: 0x00066415
		public DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility visibility)
		{
			this.Visibility = visibility;
		}

		/// <summary>Возвращает значение, показывающее базовый режим сериализации, который должен использоваться средством сериализации при определении необходимости и способа сохранения значения свойства.</summary>
		/// <returns>Одно из значений <see cref="T:System.ComponentModel.DesignerSerializationVisibility" />. Значение по умолчанию — <see cref="F:System.ComponentModel.DesignerSerializationVisibility.Visible" />.</returns>
		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06001CF9 RID: 7417 RVA: 0x00068224 File Offset: 0x00066424
		public DesignerSerializationVisibility Visibility { get; }

		/// <summary>Указывает, равен ли этот экземпляр заданному объекту.</summary>
		/// <param name="obj">Другой объект, подлежащий сравнению.</param>
		/// <returns>Значение <see langword="true" />, если значение параметра <paramref name="obj" /> равно данному экземпляру; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001CFA RID: 7418 RVA: 0x0006822C File Offset: 0x0006642C
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			DesignerSerializationVisibilityAttribute designerSerializationVisibilityAttribute = obj as DesignerSerializationVisibilityAttribute;
			DesignerSerializationVisibility? designerSerializationVisibility = (designerSerializationVisibilityAttribute != null) ? new DesignerSerializationVisibility?(designerSerializationVisibilityAttribute.Visibility) : null;
			DesignerSerializationVisibility visibility = this.Visibility;
			return designerSerializationVisibility.GetValueOrDefault() == visibility & designerSerializationVisibility != null;
		}

		/// <summary>Возвращает хэш-код для этого объекта.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06001CFB RID: 7419 RVA: 0x000678FA File Offset: 0x00065AFA
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Возвращает значение, показывающее, является ли текущее значение атрибута его значением по умолчанию.</summary>
		/// <returns>Значение <see langword="true" />, если атрибут установлен равным значению по умолчанию; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001CFC RID: 7420 RVA: 0x00068278 File Offset: 0x00066478
		public override bool IsDefaultAttribute()
		{
			return this.Equals(DesignerSerializationVisibilityAttribute.Default);
		}

		/// <summary>Определяет, что средство сериализации должно сериализовать содержимое данного свойства, а не само свойство. Это поле доступно только для чтения.</summary>
		// Token: 0x04000EB1 RID: 3761
		public static readonly DesignerSerializationVisibilityAttribute Content = new DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content);

		/// <summary>Определяет, что средство сериализации не должно сериализировать значение свойства. Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000EB2 RID: 3762
		public static readonly DesignerSerializationVisibilityAttribute Hidden = new DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden);

		/// <summary>Определяет, что средству сериализации должно быть разрешено сериализировать значение свойства. Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000EB3 RID: 3763
		public static readonly DesignerSerializationVisibilityAttribute Visible = new DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible);

		/// <summary>Задает значение по умолчанию, равное <see cref="F:System.ComponentModel.DesignerSerializationVisibilityAttribute.Visible" />, то есть в режиме визуального конструктора для создания значения свойства используются правила по умолчанию. Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000EB4 RID: 3764
		public static readonly DesignerSerializationVisibilityAttribute Default = DesignerSerializationVisibilityAttribute.Visible;
	}
}
