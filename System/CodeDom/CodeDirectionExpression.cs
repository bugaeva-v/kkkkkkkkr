using System;

namespace System.CodeDom
{
	/// <summary>Представляет выражение, используемое как параметр вызова метода вместе с индикатором направления ссылки.</summary>
	// Token: 0x02000308 RID: 776
	[Serializable]
	public class CodeDirectionExpression : CodeExpression
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeDirectionExpression" />.</summary>
		// Token: 0x060018C3 RID: 6339 RVA: 0x0005EE88 File Offset: 0x0005D088
		public CodeDirectionExpression()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeDirectionExpression" />, используя указанное направление поля и выражение.</summary>
		/// <param name="direction">
		///   <see cref="T:System.CodeDom.FieldDirection" /> указывает направление поля выражения.</param>
		/// <param name="expression">
		///   <see cref="T:System.CodeDom.CodeExpression" /> указывает кодовое выражение для представления.</param>
		// Token: 0x060018C4 RID: 6340 RVA: 0x0005FA92 File Offset: 0x0005DC92
		public CodeDirectionExpression(FieldDirection direction, CodeExpression expression)
		{
			this.Expression = expression;
			this.Direction = direction;
		}

		/// <summary>Получает или задает кодовое выражение для представления.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeExpression" />, указывающий выражение для представления.</returns>
		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x060018C5 RID: 6341 RVA: 0x0005FAA8 File Offset: 0x0005DCA8
		// (set) Token: 0x060018C6 RID: 6342 RVA: 0x0005FAB0 File Offset: 0x0005DCB0
		public CodeExpression Expression { get; set; }

		/// <summary>Получает или задает направление поля для выражения направления.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.FieldDirection" /> указывает направление поля для данного выражения направления.</returns>
		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x060018C7 RID: 6343 RVA: 0x0005FAB9 File Offset: 0x0005DCB9
		// (set) Token: 0x060018C8 RID: 6344 RVA: 0x0005FAC1 File Offset: 0x0005DCC1
		public FieldDirection Direction { get; set; }
	}
}
