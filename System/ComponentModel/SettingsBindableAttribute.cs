using System;

namespace System.ComponentModel
{
	/// <summary>Определяет, когда свойство компонента может быть связано с параметром приложения.</summary>
	// Token: 0x020003EB RID: 1003
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class SettingsBindableAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.SettingsBindableAttribute" />.</summary>
		/// <param name="bindable">Значение <see langword="true" />, определяющее, что свойство подходит для привязки к нему параметров; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x060020DC RID: 8412 RVA: 0x0007182D File Offset: 0x0006FA2D
		public SettingsBindableAttribute(bool bindable)
		{
			this.Bindable = bindable;
		}

		/// <summary>Возвращает значение, показывающее, можно ли привязать к свойству параметры.</summary>
		/// <returns>Значение <see langword="true" />, если свойство подходит для привязки к нему параметров; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x060020DD RID: 8413 RVA: 0x0007183C File Offset: 0x0006FA3C
		public bool Bindable { get; }

		/// <summary>Возвращает значение, показывающее, равен ли экземпляр указанному объекту.</summary>
		/// <param name="obj">Объект <see cref="T:System.Object" /> для сравнения с этим экземпляром или пустая ссылка (<see langword="Nothing" /> в Visual Basic).</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="obj" /> равно типу и значению данного экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060020DE RID: 8414 RVA: 0x00071844 File Offset: 0x0006FA44
		public override bool Equals(object obj)
		{
			return obj == this || (obj != null && obj is SettingsBindableAttribute && ((SettingsBindableAttribute)obj).Bindable == this.Bindable);
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x060020DF RID: 8415 RVA: 0x0007186C File Offset: 0x0006FA6C
		public override int GetHashCode()
		{
			return this.Bindable.GetHashCode();
		}

		/// <summary>Определяет, что это свойство можно использовать для привязки данных.</summary>
		// Token: 0x04000FE6 RID: 4070
		public static readonly SettingsBindableAttribute Yes = new SettingsBindableAttribute(true);

		/// <summary>Определяет, что это свойство не следует использовать для привязки данных.</summary>
		// Token: 0x04000FE7 RID: 4071
		public static readonly SettingsBindableAttribute No = new SettingsBindableAttribute(false);
	}
}
