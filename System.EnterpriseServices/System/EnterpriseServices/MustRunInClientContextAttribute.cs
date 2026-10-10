using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Инициирует, если это возможно, создание объекта с атрибутами в контексте создателя. Этот класс не наследуется.</summary>
	// Token: 0x02000034 RID: 52
	[AttributeUsage(AttributeTargets.Class)]
	[ComVisible(false)]
	public sealed class MustRunInClientContextAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.MustRunInClientContextAttribute" /> и требует создания объекта в контексте создателя.</summary>
		// Token: 0x0600009E RID: 158 RVA: 0x000023DC File Offset: 0x000005DC
		public MustRunInClientContextAttribute() : this(true)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.MustRunInClientContextAttribute" /> и дополнительно не создает объект в контексте создателя.</summary>
		/// <param name="val">Значение <see langword="true" />, чтобы создать объект в контексте создателя; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x0600009F RID: 159 RVA: 0x000023E5 File Offset: 0x000005E5
		public MustRunInClientContextAttribute(bool val)
		{
			this.val = val;
		}

		/// <summary>Возвращает значение, указывающее, будет ли объект с атрибутами создан в контексте создателя.</summary>
		/// <returns>Значение <see langword="true" />, если объект будет создан в контексте создателя; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x000023F4 File Offset: 0x000005F4
		public bool Value
		{
			get
			{
				return this.val;
			}
		}

		// Token: 0x0400006E RID: 110
		private bool val;
	}
}
