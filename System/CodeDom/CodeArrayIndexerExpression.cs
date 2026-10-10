using System;

namespace System.CodeDom
{
	/// <summary>Представляет ссылку на индекс массива.</summary>
	// Token: 0x020002F1 RID: 753
	[Serializable]
	public class CodeArrayIndexerExpression : CodeExpression
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeArrayIndexerExpression" />.</summary>
		// Token: 0x0600181C RID: 6172 RVA: 0x0005EE88 File Offset: 0x0005D088
		public CodeArrayIndexerExpression()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeArrayIndexerExpression" />, используя указанный конечный объект и индексы.</summary>
		/// <param name="targetObject">
		///   <see cref="T:System.CodeDom.CodeExpression" />, указывающий массив, являющийся конечным для индексатора.</param>
		/// <param name="indices">Индекс или индексы для ссылки.</param>
		// Token: 0x0600181D RID: 6173 RVA: 0x0005F081 File Offset: 0x0005D281
		public CodeArrayIndexerExpression(CodeExpression targetObject, params CodeExpression[] indices)
		{
			this.TargetObject = targetObject;
			this.Indices.AddRange(indices);
		}

		/// <summary>Получает или задает конечный объект индексатора массива.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeExpression" />, представляющий индексируемый массив.</returns>
		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x0600181E RID: 6174 RVA: 0x0005F09C File Offset: 0x0005D29C
		// (set) Token: 0x0600181F RID: 6175 RVA: 0x0005F0A4 File Offset: 0x0005D2A4
		public CodeExpression TargetObject { get; set; }

		/// <summary>Получает или задает индекс или индексы выражения индексатора.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeExpressionCollection" />, указывающий индекс или индексы выражения индексатора.</returns>
		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06001820 RID: 6176 RVA: 0x0005F0B0 File Offset: 0x0005D2B0
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

		// Token: 0x04000D4B RID: 3403
		private CodeExpressionCollection _indices;
	}
}
