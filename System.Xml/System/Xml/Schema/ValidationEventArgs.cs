using System;
using Unity;

namespace System.Xml.Schema
{
	/// <summary>
	///         Возвращает подробные сведения, относящиеся к <see langword="ValidationEventHandler" />.
	///       </summary>
	// Token: 0x0200057E RID: 1406
	public class ValidationEventArgs : EventArgs
	{
		// Token: 0x060038A6 RID: 14502 RVA: 0x001472A7 File Offset: 0x001454A7
		internal ValidationEventArgs(XmlSchemaException ex)
		{
			this.ex = ex;
			this.severity = XmlSeverityType.Error;
		}

		// Token: 0x060038A7 RID: 14503 RVA: 0x001472BD File Offset: 0x001454BD
		internal ValidationEventArgs(XmlSchemaException ex, XmlSeverityType severity)
		{
			this.ex = ex;
			this.severity = severity;
		}

		/// <summary>
		///         Возвращает степень серьезности события проверки.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Schema.XmlSeverityType" /> Значение, представляющее уровень важности события проверки.
		///       </returns>
		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x060038A8 RID: 14504 RVA: 0x001472D3 File Offset: 0x001454D3
		public XmlSeverityType Severity
		{
			get
			{
				return this.severity;
			}
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Xml.Schema.XmlSchemaException" /> связанный с событием проверки.
		///       </summary>
		/// <returns>
		///         <see langword="XmlSchemaException" /> Связанный с событием проверки.
		///       </returns>
		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x060038A9 RID: 14505 RVA: 0x001472DB File Offset: 0x001454DB
		public XmlSchemaException Exception
		{
			get
			{
				return this.ex;
			}
		}

		/// <summary>
		///         Возвращает текстовое описание, соответствующее событию проверки.
		///       </summary>
		/// <returns>
		///         Текстовое описание.
		///       </returns>
		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x060038AA RID: 14506 RVA: 0x001472E3 File Offset: 0x001454E3
		public string Message
		{
			get
			{
				return this.ex.Message;
			}
		}

		// Token: 0x060038AB RID: 14507 RVA: 0x00067344 File Offset: 0x00065544
		internal ValidationEventArgs()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04002A07 RID: 10759
		private XmlSchemaException ex;

		// Token: 0x04002A08 RID: 10760
		private XmlSeverityType severity;
	}
}
