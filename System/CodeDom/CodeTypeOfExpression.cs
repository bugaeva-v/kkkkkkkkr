using System;

namespace System.CodeDom
{
	/// <summary>Представляет выражение <see langword="typeof" />, возвращающее <see cref="T:System.Type" /> для указанного имени типа.</summary>
	// Token: 0x02000338 RID: 824
	[Serializable]
	public class CodeTypeOfExpression : CodeExpression
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeTypeOfExpression" />.</summary>
		// Token: 0x06001A2C RID: 6700 RVA: 0x0005EE88 File Offset: 0x0005D088
		public CodeTypeOfExpression()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeTypeOfExpression" />.</summary>
		/// <param name="type">
		///   <see cref="T:System.CodeDom.CodeTypeReference" />, указывающий тип данных для выражения <see langword="typeof" />.</param>
		// Token: 0x06001A2D RID: 6701 RVA: 0x00061544 File Offset: 0x0005F744
		public CodeTypeOfExpression(CodeTypeReference type)
		{
			this.Type = type;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeTypeOfExpression" />, используя указанный тип.</summary>
		/// <param name="type">Имя типа данных для выражения <see langword="typeof" />.</param>
		// Token: 0x06001A2E RID: 6702 RVA: 0x00061553 File Offset: 0x0005F753
		public CodeTypeOfExpression(string type)
		{
			this.Type = new CodeTypeReference(type);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeTypeOfExpression" />, используя указанный тип.</summary>
		/// <param name="type">Тип данных типа данных для выражения <see langword="typeof" />.</param>
		// Token: 0x06001A2F RID: 6703 RVA: 0x00061567 File Offset: 0x0005F767
		public CodeTypeOfExpression(Type type)
		{
			this.Type = new CodeTypeReference(type);
		}

		/// <summary>Получает или задает тип данных, на который ссылается выражение <see langword="typeof" />.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeTypeReference" />, указывающий тип данных, на который ссылается выражение <see langword="typeof" />. Данное свойство никогда не возвращает <see langword="null" /> и по умолчанию относится к типу <see cref="T:System.Void" />.</returns>
		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06001A30 RID: 6704 RVA: 0x0006157C File Offset: 0x0005F77C
		// (set) Token: 0x06001A31 RID: 6705 RVA: 0x000615A6 File Offset: 0x0005F7A6
		public CodeTypeReference Type
		{
			get
			{
				CodeTypeReference result;
				if ((result = this._type) == null)
				{
					result = (this._type = new CodeTypeReference(""));
				}
				return result;
			}
			set
			{
				this._type = value;
			}
		}

		// Token: 0x04000DF7 RID: 3575
		private CodeTypeReference _type;
	}
}
