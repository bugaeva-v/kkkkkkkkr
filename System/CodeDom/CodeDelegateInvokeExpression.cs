using System;

namespace System.CodeDom
{
	/// <summary>Представляет выражение, вызывающее событие.</summary>
	// Token: 0x02000307 RID: 775
	[Serializable]
	public class CodeDelegateInvokeExpression : CodeExpression
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeDelegateInvokeExpression" />.</summary>
		// Token: 0x060018BD RID: 6333 RVA: 0x0005FA26 File Offset: 0x0005DC26
		public CodeDelegateInvokeExpression()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeDelegateInvokeExpression" />, используя указанный целевой объект.</summary>
		/// <param name="targetObject">
		///   <see cref="T:System.CodeDom.CodeExpression" />, указывающий целевой объект.</param>
		// Token: 0x060018BE RID: 6334 RVA: 0x0005FA39 File Offset: 0x0005DC39
		public CodeDelegateInvokeExpression(CodeExpression targetObject)
		{
			this.TargetObject = targetObject;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeDelegateInvokeExpression" />, используя указанные целевой объект и параметры.</summary>
		/// <param name="targetObject">
		///   <see cref="T:System.CodeDom.CodeExpression" />, указывающий целевой объект.</param>
		/// <param name="parameters">Массив объектов <see cref="T:System.CodeDom.CodeExpression" />, указывающих параметры.</param>
		// Token: 0x060018BF RID: 6335 RVA: 0x0005FA53 File Offset: 0x0005DC53
		public CodeDelegateInvokeExpression(CodeExpression targetObject, params CodeExpression[] parameters)
		{
			this.TargetObject = targetObject;
			this.Parameters.AddRange(parameters);
		}

		/// <summary>Получает или задает событие для вызова.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeExpression" />, указывающий событие для вызова.</returns>
		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x060018C0 RID: 6336 RVA: 0x0005FA79 File Offset: 0x0005DC79
		// (set) Token: 0x060018C1 RID: 6337 RVA: 0x0005FA81 File Offset: 0x0005DC81
		public CodeExpression TargetObject { get; set; }

		/// <summary>Получает или задает параметры для передачи методам обработки событий, вложенным в событие.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeExpression" />, указывающий параметры для передачи методам обработки событий, вложенным в событие.</returns>
		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x060018C2 RID: 6338 RVA: 0x0005FA8A File Offset: 0x0005DC8A
		public CodeExpressionCollection Parameters { get; } = new CodeExpressionCollection();
	}
}
