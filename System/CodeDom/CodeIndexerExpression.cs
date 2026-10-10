using System;

namespace System.CodeDom
{
	/// <summary>Представляет ссылку на свойство индексатора объекта.</summary>
	// Token: 0x02000312 RID: 786
	[Serializable]
	public class CodeIndexerExpression : CodeExpression
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeIndexerExpression" />.</summary>
		// Token: 0x060018FA RID: 6394 RVA: 0x0005EE88 File Offset: 0x0005D088
		public CodeIndexerExpression()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeIndexerExpression" />, используя указанные целевой объект и индекс.</summary>
		/// <param name="targetObject">Целевой объект.</param>
		/// <param name="indices">Индекс или индексы выражения индексатора.</param>
		// Token: 0x060018FB RID: 6395 RVA: 0x0005FCEC File Offset: 0x0005DEEC
		public CodeIndexerExpression(CodeExpression targetObject, params CodeExpression[] indices)
		{
			this.TargetObject = targetObject;
			this.Indices.AddRange(indices);
		}

		/// <summary>Получает или задает целевой объект, который может быть проиндексирован.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeExpression" />, указывающий объект индексатора.</returns>
		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x060018FC RID: 6396 RVA: 0x0005FD07 File Offset: 0x0005DF07
		// (set) Token: 0x060018FD RID: 6397 RVA: 0x0005FD0F File Offset: 0x0005DF0F
		public CodeExpression TargetObject { get; set; }

		/// <summary>Получает коллекцию индексов выражения индексатора.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeExpressionCollection" />, указывающий индекс или индексы выражения индексатора.</returns>
		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x060018FE RID: 6398 RVA: 0x0005FD18 File Offset: 0x0005DF18
		public CodeExpressionCollection Indices
		{
			get
			{
				CodeExpressionCollection result;
				if ((result = this._indices) == null)
				{
					result = (this._indices = new CodeExpressionCollection());
				}
				return result;
			}
		}

		// Token: 0x04000D8E RID: 3470
		private CodeExpressionCollection _indices;
	}
}
