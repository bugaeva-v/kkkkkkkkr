using System;

namespace System.CodeDom
{
	/// <summary>Предоставляет базовый класс для элемента типа. Элементы типа включают в себя поля, методы, свойства, конструкторы и вложенные типы.</summary>
	// Token: 0x02000336 RID: 822
	[Serializable]
	public class CodeTypeMember : CodeObject
	{
		/// <summary>Получает или задает имя элемента.</summary>
		/// <returns>Имя элемента.</returns>
		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06001A13 RID: 6675 RVA: 0x000613C3 File Offset: 0x0005F5C3
		// (set) Token: 0x06001A14 RID: 6676 RVA: 0x000613D4 File Offset: 0x0005F5D4
		public string Name
		{
			get
			{
				return this._name ?? string.Empty;
			}
			set
			{
				this._name = value;
			}
		}

		/// <summary>Получает или задает атрибуты элемента.</summary>
		/// <returns>Поразрядная комбинация значений <see cref="T:System.CodeDom.MemberAttributes" />, используемая для указания атрибутов элемента. Значение по умолчанию — <see cref="F:System.CodeDom.MemberAttributes.Private" />  |  <see cref="F:System.CodeDom.MemberAttributes.Final" />.</returns>
		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06001A15 RID: 6677 RVA: 0x000613DD File Offset: 0x0005F5DD
		// (set) Token: 0x06001A16 RID: 6678 RVA: 0x000613E5 File Offset: 0x0005F5E5
		public MemberAttributes Attributes { get; set; } = (MemberAttributes)20482;

		/// <summary>Получает или задает пользовательские атрибуты элемента.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeAttributeDeclarationCollection" />, указывающий пользовательские атрибуты элемента.</returns>
		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06001A17 RID: 6679 RVA: 0x000613F0 File Offset: 0x0005F5F0
		// (set) Token: 0x06001A18 RID: 6680 RVA: 0x00061415 File Offset: 0x0005F615
		public CodeAttributeDeclarationCollection CustomAttributes
		{
			get
			{
				CodeAttributeDeclarationCollection result;
				if ((result = this._customAttributes) == null)
				{
					result = (this._customAttributes = new CodeAttributeDeclarationCollection());
				}
				return result;
			}
			set
			{
				this._customAttributes = value;
			}
		}

		/// <summary>Получает или задает строку, на которой происходит оператор элемента типа.</summary>
		/// <returns>Объект <see cref="T:System.CodeDom.CodeLinePragma" />, указывающий местоположение объявления элемента типа.</returns>
		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001A19 RID: 6681 RVA: 0x0006141E File Offset: 0x0005F61E
		// (set) Token: 0x06001A1A RID: 6682 RVA: 0x00061426 File Offset: 0x0005F626
		public CodeLinePragma LinePragma { get; set; }

		/// <summary>Получает коллекцию комментариев для элемента типа.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeCommentStatementCollection" />, указывающий комментарии для элемента.</returns>
		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001A1B RID: 6683 RVA: 0x0006142F File Offset: 0x0005F62F
		public CodeCommentStatementCollection Comments { get; } = new CodeCommentStatementCollection();

		/// <summary>Получает начальные директивы для элемента.</summary>
		/// <returns>Объект <see cref="T:System.CodeDom.CodeDirectiveCollection" />, содержащий начальные директивы.</returns>
		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06001A1C RID: 6684 RVA: 0x00061438 File Offset: 0x0005F638
		public CodeDirectiveCollection StartDirectives
		{
			get
			{
				CodeDirectiveCollection result;
				if ((result = this._startDirectives) == null)
				{
					result = (this._startDirectives = new CodeDirectiveCollection());
				}
				return result;
			}
		}

		/// <summary>Получает конечные директивы для элемента.</summary>
		/// <returns>Объект <see cref="T:System.CodeDom.CodeDirectiveCollection" />, содержащий конечные директивы.</returns>
		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06001A1D RID: 6685 RVA: 0x00061460 File Offset: 0x0005F660
		public CodeDirectiveCollection EndDirectives
		{
			get
			{
				CodeDirectiveCollection result;
				if ((result = this._endDirectives) == null)
				{
					result = (this._endDirectives = new CodeDirectiveCollection());
				}
				return result;
			}
		}

		// Token: 0x04000DF0 RID: 3568
		private string _name;

		// Token: 0x04000DF1 RID: 3569
		private CodeAttributeDeclarationCollection _customAttributes;

		// Token: 0x04000DF2 RID: 3570
		private CodeDirectiveCollection _startDirectives;

		// Token: 0x04000DF3 RID: 3571
		private CodeDirectiveCollection _endDirectives;
	}
}
