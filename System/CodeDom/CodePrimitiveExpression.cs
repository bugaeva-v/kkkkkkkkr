using System;

namespace System.CodeDom
{
	/// <summary>Представляет значение простого типа данных.</summary>
	// Token: 0x02000323 RID: 803
	[Serializable]
	public class CodePrimitiveExpression : CodeExpression
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodePrimitiveExpression" />.</summary>
		// Token: 0x060019A3 RID: 6563 RVA: 0x0005EE88 File Offset: 0x0005D088
		public CodePrimitiveExpression()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodePrimitiveExpression" />, используя заданный объект.</summary>
		/// <param name="value">Объект для представления.</param>
		// Token: 0x060019A4 RID: 6564 RVA: 0x00060B98 File Offset: 0x0005ED98
		public CodePrimitiveExpression(object value)
		{
			this.Value = value;
		}

		/// <summary>Получает или задает простой тип данных для представления.</summary>
		/// <returns>Экземпляр простого типа данных для представления значения.</returns>
		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x060019A5 RID: 6565 RVA: 0x00060BA7 File Offset: 0x0005EDA7
		// (set) Token: 0x060019A6 RID: 6566 RVA: 0x00060BAF File Offset: 0x0005EDAF
		public object Value { get; set; }
	}
}
