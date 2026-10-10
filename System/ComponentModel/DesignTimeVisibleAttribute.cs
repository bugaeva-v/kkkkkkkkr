using System;

namespace System.ComponentModel
{
	/// <summary>Атрибут <see cref="T:System.ComponentModel.DesignTimeVisibleAttribute" /> помечает видимость компонента. Если установлено поле <see cref="F:System.ComponentModel.DesignTimeVisibleAttribute.Yes" />, этот компонент может быть отображен в визуальном конструкторе.</summary>
	// Token: 0x020003A3 RID: 931
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
	public sealed class DesignTimeVisibleAttribute : Attribute
	{
		/// <summary>Создает новый атрибут <see cref="T:System.ComponentModel.DesignTimeVisibleAttribute" /> со свойством <see cref="P:System.ComponentModel.DesignTimeVisibleAttribute.Visible" />, равным заданному значению параметра <paramref name="visible" />.</summary>
		/// <param name="visible">Значение, устанавливаемое для свойства <see cref="P:System.ComponentModel.DesignTimeVisibleAttribute.Visible" />.</param>
		// Token: 0x06001E6D RID: 7789 RVA: 0x0006C0B4 File Offset: 0x0006A2B4
		public DesignTimeVisibleAttribute(bool visible)
		{
			this.Visible = visible;
		}

		/// <summary>Создает новый атрибут <see cref="T:System.ComponentModel.DesignTimeVisibleAttribute" /> со значением по умолчанию <see langword="false" />.</summary>
		// Token: 0x06001E6E RID: 7790 RVA: 0x00003D9F File Offset: 0x00001F9F
		public DesignTimeVisibleAttribute()
		{
		}

		/// <summary>Возвращает или устанавливает значение, определяющее, должен ли компонент отображаться во время разработки.</summary>
		/// <returns>Значение <see langword="true" />, если компонент должен отображаться во время разработки, или значение <see langword="false" />, если не должен.</returns>
		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06001E6F RID: 7791 RVA: 0x0006C0C3 File Offset: 0x0006A2C3
		public bool Visible { get; }

		/// <summary>Возвращает значение, показывающее, равен ли экземпляр указанному объекту.</summary>
		/// <param name="obj">Объект для сравнения с этим экземпляром или пустая ссылка (<see langword="Nothing" /> в Visual Basic).</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="obj" /> равно типу и значению данного экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001E70 RID: 7792 RVA: 0x0006C0CC File Offset: 0x0006A2CC
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			DesignTimeVisibleAttribute designTimeVisibleAttribute = obj as DesignTimeVisibleAttribute;
			return designTimeVisibleAttribute != null && designTimeVisibleAttribute.Visible == this.Visible;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06001E71 RID: 7793 RVA: 0x0006C0F9 File Offset: 0x0006A2F9
		public override int GetHashCode()
		{
			return typeof(DesignTimeVisibleAttribute).GetHashCode() ^ (this.Visible ? -1 : 0);
		}

		/// <summary>Возвращает значение, показывающее, равен ли этот экземпляр значению <see cref="F:System.ComponentModel.DesignTimeVisibleAttribute.Default" />.</summary>
		/// <returns>Значение <see langword="true" />, если этот экземпляр равен значению <see cref="F:System.ComponentModel.DesignTimeVisibleAttribute.Default" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001E72 RID: 7794 RVA: 0x0006C117 File Offset: 0x0006A317
		public override bool IsDefaultAttribute()
		{
			return this.Visible == DesignTimeVisibleAttribute.Default.Visible;
		}

		/// <summary>Помечает компонент как видимый в визуальном конструкторе.</summary>
		// Token: 0x04000F33 RID: 3891
		public static readonly DesignTimeVisibleAttribute Yes = new DesignTimeVisibleAttribute(true);

		/// <summary>Помечает компонент как невидимый в визуальном конструкторе.</summary>
		// Token: 0x04000F34 RID: 3892
		public static readonly DesignTimeVisibleAttribute No = new DesignTimeVisibleAttribute(false);

		/// <summary>По умолчанию значение видимости — <see langword="Yes" />.</summary>
		// Token: 0x04000F35 RID: 3893
		public static readonly DesignTimeVisibleAttribute Default = DesignTimeVisibleAttribute.Yes;
	}
}
