using System;

namespace System.ComponentModel
{
	/// <summary>Указывает, что это свойство может быть объединено в окне "Свойства" со свойствами, принадлежащими другим объектам.</summary>
	// Token: 0x02000376 RID: 886
	[AttributeUsage(AttributeTargets.All)]
	public sealed class MergablePropertyAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.MergablePropertyAttribute" />.</summary>
		/// <param name="allowMerge">Значение <see langword="true" />, если свойство может быть объединено в окне "Свойства" со свойствами, принадлежащими другим объектам; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x06001D33 RID: 7475 RVA: 0x0006863E File Offset: 0x0006683E
		public MergablePropertyAttribute(bool allowMerge)
		{
			this.AllowMerge = allowMerge;
		}

		/// <summary>Получает значение, указывающее, может ли это свойство быть объединено в окне "Свойства" со свойствами, принадлежащими другим объектам.</summary>
		/// <returns>Значение <see langword="true" />, если свойство может быть объединено в окне "Свойства" со свойствами, принадлежащими другим объектам; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06001D34 RID: 7476 RVA: 0x0006864D File Offset: 0x0006684D
		public bool AllowMerge { get; }

		/// <summary>Указывает, равен ли этот экземпляр заданному объекту.</summary>
		/// <param name="obj">Другой объект, подлежащий сравнению.</param>
		/// <returns>Значение <see langword="true" />, если значение параметра <paramref name="obj" /> равно данному экземпляру; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001D35 RID: 7477 RVA: 0x00068658 File Offset: 0x00066858
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			MergablePropertyAttribute mergablePropertyAttribute = obj as MergablePropertyAttribute;
			bool? flag = (mergablePropertyAttribute != null) ? new bool?(mergablePropertyAttribute.AllowMerge) : null;
			bool allowMerge = this.AllowMerge;
			return flag.GetValueOrDefault() == allowMerge & flag != null;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.ComponentModel.MergablePropertyAttribute" />.</returns>
		// Token: 0x06001D36 RID: 7478 RVA: 0x000678FA File Offset: 0x00065AFA
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Определяет, является ли этот атрибут используемым по умолчанию.</summary>
		/// <returns>Значение <see langword="true" />, если атрибут является значением по умолчанию для данного класса атрибутов; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001D37 RID: 7479 RVA: 0x000686A4 File Offset: 0x000668A4
		public override bool IsDefaultAttribute()
		{
			return this.Equals(MergablePropertyAttribute.Default);
		}

		/// <summary>Указывает, что свойство может быть объединено в окне "Свойства" со свойствами, принадлежащими другим объектам. Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000EC6 RID: 3782
		public static readonly MergablePropertyAttribute Yes = new MergablePropertyAttribute(true);

		/// <summary>Указывает, что это свойство не может быть объединено в окне "Свойства" со свойствами, принадлежащими другим объектам. Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000EC7 RID: 3783
		public static readonly MergablePropertyAttribute No = new MergablePropertyAttribute(false);

		/// <summary>Задает значение по умолчанию, равное <see cref="F:System.ComponentModel.MergablePropertyAttribute.Yes" />, то есть свойство может объединяться со свойствами других объектов в окне "Свойства". Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000EC8 RID: 3784
		public static readonly MergablePropertyAttribute Default = MergablePropertyAttribute.Yes;
	}
}
