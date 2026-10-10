using System;
using System.Xml.XPath;

namespace System.Xml
{
	/// <summary>
	///         Представляет содержимое комментария XML.
	///       </summary>
	// Token: 0x020001BA RID: 442
	public class XmlComment : XmlCharacterData
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.XmlComment" />.
		///       </summary>
		/// <param name="comment">
		///           Содержимое элемента комментария.
		///         </param>
		/// <param name="doc">
		///           Родительский XML-документ.
		///         </param>
		// Token: 0x06001040 RID: 4160 RVA: 0x0006734B File Offset: 0x0006554B
		protected internal XmlComment(string comment, XmlDocument doc) : base(comment, doc)
		{
		}

		/// <summary>
		///         Возвращает полное имя узла.
		///       </summary>
		/// <returns>
		///         Для узлов комментариев значение — <see langword="#comment" />.
		///       </returns>
		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06001041 RID: 4161 RVA: 0x000678C8 File Offset: 0x00065AC8
		public override string Name
		{
			get
			{
				return this.OwnerDocument.strCommentName;
			}
		}

		/// <summary>
		///         Возвращает локальное имя узла.
		///       </summary>
		/// <returns>
		///         Для узлов комментариев значение — <see langword="#comment" />.
		///       </returns>
		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x000678C8 File Offset: 0x00065AC8
		public override string LocalName
		{
			get
			{
				return this.OwnerDocument.strCommentName;
			}
		}

		/// <summary>
		///         Возвращает тип текущего узла.
		///       </summary>
		/// <returns>
		///         Для узлов комментариев значение — XmlNodeType.Comment.
		///       </returns>
		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06001043 RID: 4163 RVA: 0x000678D5 File Offset: 0x00065AD5
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.Comment;
			}
		}

		/// <summary>
		///         Создает дубликат этого узла.
		///       </summary>
		/// <param name="deep">
		///           Значение <see langword="true" /> для рекурсивного клонирования поддерева указанного узла; значение <see langword="false" /> для клонирования только самого узла.
		///            Поскольку узлы комментариев не имеют дочерних узлов, точная копия узла всегда включает текстовое содержимое независимо от значения параметра.
		///         </param>
		/// <returns>
		///         Точная копия узла.
		///       </returns>
		// Token: 0x06001044 RID: 4164 RVA: 0x000678D8 File Offset: 0x00065AD8
		public override XmlNode CloneNode(bool deep)
		{
			return this.OwnerDocument.CreateComment(this.Data);
		}

		/// <summary>
		///         Сохраняет узел в указанном <see cref="T:System.Xml.XmlWriter" />.
		///       </summary>
		/// <param name="w">
		///           Объект <see langword="XmlWriter" />, в котором необходимо выполнить сохранение.
		///         </param>
		// Token: 0x06001045 RID: 4165 RVA: 0x000678EB File Offset: 0x00065AEB
		public override void WriteTo(XmlWriter w)
		{
			w.WriteComment(this.Data);
		}

		/// <summary>
		///         Сохраняет все дочерние узлы узла в заданном <see cref="T:System.Xml.XmlWriter" />.
		///          Поскольку узлы комментариев не имеют дочерних узлов, этот метод не оказывает влияния.
		///       </summary>
		/// <param name="w">
		///           Объект <see langword="XmlWriter" />, в котором необходимо выполнить сохранение.
		///         </param>
		// Token: 0x06001046 RID: 4166 RVA: 0x0000B528 File Offset: 0x00009728
		public override void WriteContentTo(XmlWriter w)
		{
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06001047 RID: 4167 RVA: 0x000678D5 File Offset: 0x00065AD5
		internal override XPathNodeType XPNodeType
		{
			get
			{
				return XPathNodeType.Comment;
			}
		}
	}
}
