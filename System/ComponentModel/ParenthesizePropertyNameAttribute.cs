using System;

namespace System.ComponentModel
{
	/// <summary>Показывает, отображается ли имя связанного свойства в окне "Свойства" в скобках. Этот класс не наследуется.</summary>
	// Token: 0x02000435 RID: 1077
	[AttributeUsage(AttributeTargets.All)]
	public sealed class ParenthesizePropertyNameAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.ParenthesizePropertyNameAttribute" />, используя значение, указывающее, что имя связанного свойства не должно отображаться в скобках.</summary>
		// Token: 0x06002360 RID: 9056 RVA: 0x00080CBC File Offset: 0x0007EEBC
		public ParenthesizePropertyNameAttribute() : this(false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.ParenthesizePropertyNameAttribute" />, используя заданное значение, чтобы указать, отображать ли атрибут в скобках.</summary>
		/// <param name="needParenthesis">Значение <see langword="true" />, если имя должно быть заключено в скобки; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x06002361 RID: 9057 RVA: 0x00080CC5 File Offset: 0x0007EEC5
		public ParenthesizePropertyNameAttribute(bool needParenthesis)
		{
			this.needParenthesis = needParenthesis;
		}

		/// <summary>Возвращает значение, показывающее, отображается ли имя свойства в окне "Свойства" в скобках.</summary>
		/// <returns>Значение <see langword="true" />, если имя свойства отображается в скобках; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06002362 RID: 9058 RVA: 0x00080CD4 File Offset: 0x0007EED4
		public bool NeedParenthesis
		{
			get
			{
				return this.needParenthesis;
			}
		}

		/// <summary>Сравнивает заданный объект с этим объектом, проверяя их равенство.</summary>
		/// <param name="o">Сравниваемый объект.</param>
		/// <returns>Значение <see langword="true" />, если объекты равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002363 RID: 9059 RVA: 0x00080CDC File Offset: 0x0007EEDC
		public override bool Equals(object o)
		{
			return o is ParenthesizePropertyNameAttribute && ((ParenthesizePropertyNameAttribute)o).NeedParenthesis == this.needParenthesis;
		}

		/// <summary>Получает хэш-код для этого объекта.</summary>
		/// <returns>Хэш-код для объекта, которому принадлежит данный атрибут.</returns>
		// Token: 0x06002364 RID: 9060 RVA: 0x000678FA File Offset: 0x00065AFA
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Возвращает значение, показывающее, является ли текущее значение атрибута его значением по умолчанию.</summary>
		/// <returns>Значение <see langword="true" />, если текущим значением атрибута является значение атрибута по умолчанию; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002365 RID: 9061 RVA: 0x00080CFB File Offset: 0x0007EEFB
		public override bool IsDefaultAttribute()
		{
			return this.Equals(ParenthesizePropertyNameAttribute.Default);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.ParenthesizePropertyNameAttribute" />, используя значение по умолчанию, указывающее, что имя связанного свойства не должно отображаться в скобках. Это поле доступно только для чтения.</summary>
		// Token: 0x0400109C RID: 4252
		public static readonly ParenthesizePropertyNameAttribute Default = new ParenthesizePropertyNameAttribute();

		// Token: 0x0400109D RID: 4253
		private bool needParenthesis;
	}
}
