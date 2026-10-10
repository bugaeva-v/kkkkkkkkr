using System;
using System.Text;

namespace System.Xml.Linq
{
	/// <summary>Представляет XML-декларацию.</summary>
	// Token: 0x02000026 RID: 38
	public class XDeclaration
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Xml.Linq.XDeclaration" /> с указанной версией, кодировкой и автономным статусом.</summary>
		/// <param name="version">Версия XML, обычно "1.0".</param>
		/// <param name="encoding">Кодировка документа XML.</param>
		/// <param name="standalone">Строка, содержащая "да" или "нет", которая указывает, является ли XML автономным или требует разрешения внешних сущностей.</param>
		// Token: 0x06000164 RID: 356 RVA: 0x00007912 File Offset: 0x00005B12
		public XDeclaration(string version, string encoding, string standalone)
		{
			this._version = version;
			this._encoding = encoding;
			this._standalone = standalone;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Xml.Linq.XDeclaration" /> из другого объекта <see cref="T:System.Xml.Linq.XDeclaration" />.</summary>
		/// <param name="other">
		///   <see cref="T:System.Xml.Linq.XDeclaration" /> используется для инициализации этого объекта <see cref="T:System.Xml.Linq.XDeclaration" />.</param>
		// Token: 0x06000165 RID: 357 RVA: 0x0000792F File Offset: 0x00005B2F
		public XDeclaration(XDeclaration other)
		{
			if (other == null)
			{
				throw new ArgumentNullException("other");
			}
			this._version = other._version;
			this._encoding = other._encoding;
			this._standalone = other._standalone;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0000796C File Offset: 0x00005B6C
		internal XDeclaration(XmlReader r)
		{
			this._version = r.GetAttribute("version");
			this._encoding = r.GetAttribute("encoding");
			this._standalone = r.GetAttribute("standalone");
			r.Read();
		}

		/// <summary>Возвращает или задает кодировку для этого документа.</summary>
		/// <returns>
		///   <see cref="T:System.String" />, содержащий имя страницы кода для этого документа.</returns>
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000167 RID: 359 RVA: 0x000079B9 File Offset: 0x00005BB9
		// (set) Token: 0x06000168 RID: 360 RVA: 0x000079C1 File Offset: 0x00005BC1
		public string Encoding
		{
			get
			{
				return this._encoding;
			}
			set
			{
				this._encoding = value;
			}
		}

		/// <summary>Возвращает или задает отдельное свойство для этого документа.</summary>
		/// <returns>
		///   <see cref="T:System.String" /> содержит отдельное свойство для этого документа.</returns>
		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000169 RID: 361 RVA: 0x000079CA File Offset: 0x00005BCA
		// (set) Token: 0x0600016A RID: 362 RVA: 0x000079D2 File Offset: 0x00005BD2
		public string Standalone
		{
			get
			{
				return this._standalone;
			}
			set
			{
				this._standalone = value;
			}
		}

		/// <summary>Возвращает или задает версию свойства для этого документа.</summary>
		/// <returns>
		///   <see cref="T:System.String" /> содержит версию свойства для этого документа.</returns>
		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600016B RID: 363 RVA: 0x000079DB File Offset: 0x00005BDB
		// (set) Token: 0x0600016C RID: 364 RVA: 0x000079E3 File Offset: 0x00005BE3
		public string Version
		{
			get
			{
				return this._version;
			}
			set
			{
				this._version = value;
			}
		}

		/// <summary>Представляет объявление как отформатированную строку.</summary>
		/// <returns>Объект <see cref="T:System.String" />, содержащий отформатированную строку XML.</returns>
		// Token: 0x0600016D RID: 365 RVA: 0x000079EC File Offset: 0x00005BEC
		public override string ToString()
		{
			StringBuilder stringBuilder = StringBuilderCache.Acquire(16);
			stringBuilder.Append("<?xml");
			if (this._version != null)
			{
				stringBuilder.Append(" version=\"");
				stringBuilder.Append(this._version);
				stringBuilder.Append('"');
			}
			if (this._encoding != null)
			{
				stringBuilder.Append(" encoding=\"");
				stringBuilder.Append(this._encoding);
				stringBuilder.Append('"');
			}
			if (this._standalone != null)
			{
				stringBuilder.Append(" standalone=\"");
				stringBuilder.Append(this._standalone);
				stringBuilder.Append('"');
			}
			stringBuilder.Append("?>");
			return StringBuilderCache.GetStringAndRelease(stringBuilder);
		}

		// Token: 0x040000C5 RID: 197
		private string _version;

		// Token: 0x040000C6 RID: 198
		private string _encoding;

		// Token: 0x040000C7 RID: 199
		private string _standalone;
	}
}
