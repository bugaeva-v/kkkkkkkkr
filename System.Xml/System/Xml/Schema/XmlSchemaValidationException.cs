using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Xml.Schema
{
	/// <summary>
	///         Представляет исключение, возникающее при возникновении предупреждения и ошибки проверки схемы языка определения схем XML (XSD) в проверяемом XML-документе.
	///       </summary>
	// Token: 0x020005E6 RID: 1510
	[Serializable]
	public class XmlSchemaValidationException : XmlSchemaException
	{
		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Schema.XmlSchemaValidationException" /> класса <see cref="T:System.Runtime.Serialization.SerializationInfo" /> и <see cref="T:System.Runtime.Serialization.StreamingContext" /> указанные объекты.
		///       </summary>
		/// <param name="info">
		///           Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />.
		///         </param>
		/// <param name="context">
		///           Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />.
		///         </param>
		// Token: 0x06003C78 RID: 15480 RVA: 0x001337DF File Offset: 0x001319DF
		protected XmlSchemaValidationException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>
		///         Создает новый <see cref="T:System.Xml.Schema.XmlSchemaValidationException" /> объекта с помощью заданного <see cref="T:System.Runtime.Serialization.SerializationInfo" /> и <see cref="T:System.Runtime.Serialization.StreamingContext" /> сведения, который содержит все свойства <see cref="T:System.Xml.Schema.XmlSchemaValidationException" />.
		///       </summary>
		/// <param name="info">
		///           <see cref="T:System.Runtime.Serialization.SerializationInfo" />
		///         </param>
		/// <param name="context">
		///           <see cref="T:System.Runtime.Serialization.StreamingContext" />
		///         </param>
		// Token: 0x06003C79 RID: 15481 RVA: 0x001337E9 File Offset: 0x001319E9
		[SecurityPermission(SecurityAction.LinkDemand, SerializationFormatter = true)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Schema.XmlSchemaValidationException" />.
		///       </summary>
		// Token: 0x06003C7A RID: 15482 RVA: 0x001337F3 File Offset: 0x001319F3
		public XmlSchemaValidationException() : base(null)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Schema.XmlSchemaValidationException" /> класса указанное сообщение об исключении.
		///       </summary>
		/// <param name="message">
		///           A <see langword="string" /> Описание условия ошибки.
		///         </param>
		// Token: 0x06003C7B RID: 15483 RVA: 0x001337FC File Offset: 0x001319FC
		public XmlSchemaValidationException(string message) : base(message, null, 0, 0)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Schema.XmlSchemaValidationException" /> сообщение об исключении и исходного класса <see cref="T:System.Exception" /> вызвавшее данное исключение указанного объекта.
		///       </summary>
		/// <param name="message">
		///           A <see langword="string" /> Описание условия ошибки.
		///         </param>
		/// <param name="innerException">
		///           Исходный <see cref="T:System.Exception" /> объекта, вызвавшего данное исключение.
		///         </param>
		// Token: 0x06003C7C RID: 15484 RVA: 0x00133808 File Offset: 0x00131A08
		public XmlSchemaValidationException(string message, Exception innerException) : base(message, innerException, 0, 0)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Schema.XmlSchemaValidationException" /> указанное сообщение об исключении и исходного класса <see cref="T:System.Exception" /> объект, номер строки и номер строки XML, который вызывает это исключение, заданное.
		///       </summary>
		/// <param name="message">
		///           A <see langword="string" /> Описание условия ошибки.
		///         </param>
		/// <param name="innerException">
		///           Исходный <see cref="T:System.Exception" /> объекта, вызвавшего данное исключение.
		///         </param>
		/// <param name="lineNumber">
		///           Номер строки XML, вызвавшей это исключение.
		///         </param>
		/// <param name="linePosition">
		///           Номер строки XML, вызвавшей это исключение.
		///         </param>
		// Token: 0x06003C7D RID: 15485 RVA: 0x00133814 File Offset: 0x00131A14
		public XmlSchemaValidationException(string message, Exception innerException, int lineNumber, int linePosition) : base(message, innerException, lineNumber, linePosition)
		{
		}

		// Token: 0x06003C7E RID: 15486 RVA: 0x00133821 File Offset: 0x00131A21
		internal XmlSchemaValidationException(string res, string[] args) : base(res, args, null, null, 0, 0, null)
		{
		}

		// Token: 0x06003C7F RID: 15487 RVA: 0x00133830 File Offset: 0x00131A30
		internal XmlSchemaValidationException(string res, string arg) : base(res, new string[]
		{
			arg
		}, null, null, 0, 0, null)
		{
		}

		// Token: 0x06003C80 RID: 15488 RVA: 0x00133848 File Offset: 0x00131A48
		internal XmlSchemaValidationException(string res, string arg, string sourceUri, int lineNumber, int linePosition) : base(res, new string[]
		{
			arg
		}, null, sourceUri, lineNumber, linePosition, null)
		{
		}

		// Token: 0x06003C81 RID: 15489 RVA: 0x00133862 File Offset: 0x00131A62
		internal XmlSchemaValidationException(string res, string sourceUri, int lineNumber, int linePosition) : base(res, null, null, sourceUri, lineNumber, linePosition, null)
		{
		}

		// Token: 0x06003C82 RID: 15490 RVA: 0x00133872 File Offset: 0x00131A72
		internal XmlSchemaValidationException(string res, string[] args, string sourceUri, int lineNumber, int linePosition) : base(res, args, null, sourceUri, lineNumber, linePosition, null)
		{
		}

		// Token: 0x06003C83 RID: 15491 RVA: 0x001514EB File Offset: 0x0014F6EB
		internal XmlSchemaValidationException(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition) : base(res, args, innerException, sourceUri, lineNumber, linePosition, null)
		{
		}

		// Token: 0x06003C84 RID: 15492 RVA: 0x001514FD File Offset: 0x0014F6FD
		internal XmlSchemaValidationException(string res, string[] args, object sourceNode) : base(res, args, null, null, 0, 0, null)
		{
			this.sourceNodeObject = sourceNode;
		}

		// Token: 0x06003C85 RID: 15493 RVA: 0x00151513 File Offset: 0x0014F713
		internal XmlSchemaValidationException(string res, string[] args, string sourceUri, object sourceNode) : base(res, args, null, sourceUri, 0, 0, null)
		{
			this.sourceNodeObject = sourceNode;
		}

		// Token: 0x06003C86 RID: 15494 RVA: 0x0015152A File Offset: 0x0014F72A
		internal XmlSchemaValidationException(string res, string[] args, string sourceUri, int lineNumber, int linePosition, XmlSchemaObject source, object sourceNode) : base(res, args, null, sourceUri, lineNumber, linePosition, source)
		{
			this.sourceNodeObject = sourceNode;
		}

		/// <summary>
		///         Возвращает узел XML, это вызвано <see cref="T:System.Xml.Schema.XmlSchemaValidationException" />.
		///       </summary>
		/// <returns>
		///         Узел XML, это вызвано <see cref="T:System.Xml.Schema.XmlSchemaValidationException" />.
		///       </returns>
		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x06003C87 RID: 15495 RVA: 0x00151544 File Offset: 0x0014F744
		public object SourceObject
		{
			get
			{
				return this.sourceNodeObject;
			}
		}

		/// <summary>
		///         Задает узел XML, который вызывает ошибку.
		///       </summary>
		/// <param name="sourceObject">
		///           Исходный объект.
		///         </param>
		// Token: 0x06003C88 RID: 15496 RVA: 0x0015154C File Offset: 0x0014F74C
		protected internal void SetSourceObject(object sourceObject)
		{
			this.sourceNodeObject = sourceObject;
		}

		// Token: 0x04002BE1 RID: 11233
		private object sourceNodeObject;
	}
}
