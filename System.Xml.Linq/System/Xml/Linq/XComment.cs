using System;
using System.Threading;
using System.Threading.Tasks;

namespace System.Xml.Linq
{
	/// <summary>Представляет XML-комментарий.</summary>
	// Token: 0x0200001C RID: 28
	public class XComment : XNode
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Xml.Linq.XComment" /> с указанным содержимым строки.</summary>
		/// <param name="value">Строка, содержащая содержимое нового объекта <see cref="T:System.Xml.Linq.XComment" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060000FD RID: 253 RVA: 0x000058DD File Offset: 0x00003ADD
		public XComment(string value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			this.value = value;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Xml.Linq.XComment" /> с существующим узлом комментария.</summary>
		/// <param name="other">Узел <see cref="T:System.Xml.Linq.XComment" />, из которого следует выполнить копирование.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="other" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060000FE RID: 254 RVA: 0x000058FA File Offset: 0x00003AFA
		public XComment(XComment other)
		{
			if (other == null)
			{
				throw new ArgumentNullException("other");
			}
			this.value = other.value;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000591C File Offset: 0x00003B1C
		internal XComment(XmlReader r)
		{
			this.value = r.Value;
			r.Read();
		}

		/// <summary>Возвращает тип узла для этого узла.</summary>
		/// <returns>Тип узла. Для объектов <see cref="T:System.Xml.Linq.XComment" /> это значение равно <see cref="F:System.Xml.XmlNodeType.Comment" />.</returns>
		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00005937 File Offset: 0x00003B37
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.Comment;
			}
		}

		/// <summary>Возвращает или задает строковое значение этого комментария.</summary>
		/// <returns>
		///   <see cref="T:System.String" /> содержит значение строки этого комментария.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="value" /> — <see langword="null" />.</exception>
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000101 RID: 257 RVA: 0x0000593A File Offset: 0x00003B3A
		// (set) Token: 0x06000102 RID: 258 RVA: 0x00005942 File Offset: 0x00003B42
		public string Value
		{
			get
			{
				return this.value;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				bool flag = base.NotifyChanging(this, XObjectChangeEventArgs.Value);
				this.value = value;
				if (flag)
				{
					base.NotifyChanged(this, XObjectChangeEventArgs.Value);
				}
			}
		}

		/// <summary>Запись этого комментария в <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="writer">Объект <see cref="T:System.Xml.XmlWriter" />, в который данный метод будет выполнять запись.</param>
		// Token: 0x06000103 RID: 259 RVA: 0x00005974 File Offset: 0x00003B74
		public override void WriteTo(XmlWriter writer)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			writer.WriteComment(this.value);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00005990 File Offset: 0x00003B90
		public override Task WriteToAsync(XmlWriter writer, CancellationToken cancellationToken)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			return writer.WriteCommentAsync(this.value);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000059BC File Offset: 0x00003BBC
		internal override XNode CloneNode()
		{
			return new XComment(this);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000059C4 File Offset: 0x00003BC4
		internal override bool DeepEquals(XNode node)
		{
			XComment xcomment = node as XComment;
			return xcomment != null && this.value == xcomment.value;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000059EE File Offset: 0x00003BEE
		internal override int GetDeepHashCode()
		{
			return this.value.GetHashCode();
		}

		// Token: 0x0400008A RID: 138
		internal string value;
	}
}
