using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Xml.Schema
{
	/// <summary>
	///         Возвращает сведения об ошибках, возникших во время определения классом <see cref="T:System.Xml.Schema.XmlSchemaInference" /> схемы для документа XML.
	///       </summary>
	// Token: 0x02000561 RID: 1377
	[Serializable]
	public class XmlSchemaInferenceException : XmlSchemaException
	{
		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Schema.XmlSchemaInferenceException" /> класса <see cref="T:System.Runtime.Serialization.SerializationInfo" /> и <see cref="T:System.Runtime.Serialization.StreamingContext" /> указанные объекты, содержащие все свойства <see cref="T:System.Xml.Schema.XmlSchemaInferenceException" />.
		///       </summary>
		/// <param name="info">
		///           Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />.
		///         </param>
		/// <param name="context">
		///           Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />.
		///         </param>
		// Token: 0x060036C2 RID: 14018 RVA: 0x001337DF File Offset: 0x001319DF
		protected XmlSchemaInferenceException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>
		///         Объединяет все <see cref="T:System.Xml.Schema.XmlSchemaInferenceException" /> Свойства в объекта <see cref="T:System.Runtime.Serialization.SerializationInfo" /> объекта, указанного для <see cref="T:System.Runtime.Serialization.StreamingContext" /> указанного объекта.
		///       </summary>
		/// <param name="info">
		///           Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />.
		///         </param>
		/// <param name="context">
		///           Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />.
		///         </param>
		// Token: 0x060036C3 RID: 14019 RVA: 0x001337E9 File Offset: 0x001319E9
		[SecurityPermission(SecurityAction.LinkDemand, SerializationFormatter = true)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Schema.XmlSchemaInferenceException" />.
		///       </summary>
		// Token: 0x060036C4 RID: 14020 RVA: 0x001337F3 File Offset: 0x001319F3
		public XmlSchemaInferenceException() : base(null)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Schema.XmlSchemaInferenceException" /> класс указанное сообщение об ошибке.
		///       </summary>
		/// <param name="message">
		///           Описание ошибки.
		///         </param>
		// Token: 0x060036C5 RID: 14021 RVA: 0x001337FC File Offset: 0x001319FC
		public XmlSchemaInferenceException(string message) : base(message, null, 0, 0)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Schema.XmlSchemaInferenceException" /> указанное сообщение об ошибке и исходного класса <see cref="T:System.Exception" /> вызвавшего <see cref="T:System.Xml.Schema.XmlSchemaInferenceException" /> указанного.
		///       </summary>
		/// <param name="message">
		///           Описание ошибки.
		///         </param>
		/// <param name="innerException">
		///           <see cref="T:System.Exception" /> Объект, содержащий исходное исключение, вызвавшее <see cref="T:System.Xml.Schema.XmlSchemaInferenceException" />.
		///         </param>
		// Token: 0x060036C6 RID: 14022 RVA: 0x00133808 File Offset: 0x00131A08
		public XmlSchemaInferenceException(string message, Exception innerException) : base(message, innerException, 0, 0)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Schema.XmlSchemaInferenceException" /> указан класс появляется сообщение об ошибке, исходное <see cref="T:System.Exception" /> вызвало <see cref="T:System.Xml.Schema.XmlSchemaInferenceException" /> указан и числа и строки номер строки ошибки в XML-документа.
		///       </summary>
		/// <param name="message">
		///           Описание ошибки.
		///         </param>
		/// <param name="innerException">
		///           <see cref="T:System.Exception" /> Объект, содержащий исходное исключение, вызвавшее <see cref="T:System.Xml.Schema.XmlSchemaInferenceException" />.
		///         </param>
		/// <param name="lineNumber">
		///           Номер строки в XML-документ, который вызвал <see cref="T:System.Xml.Schema.XmlSchemaInferenceException" />.
		///         </param>
		/// <param name="linePosition">
		///           Номер строки в XML-документ, который вызвал <see cref="T:System.Xml.Schema.XmlSchemaInferenceException" />.
		///         </param>
		// Token: 0x060036C7 RID: 14023 RVA: 0x00133814 File Offset: 0x00131A14
		public XmlSchemaInferenceException(string message, Exception innerException, int lineNumber, int linePosition) : base(message, innerException, lineNumber, linePosition)
		{
		}

		// Token: 0x060036C8 RID: 14024 RVA: 0x00133821 File Offset: 0x00131A21
		internal XmlSchemaInferenceException(string res, string[] args) : base(res, args, null, null, 0, 0, null)
		{
		}

		// Token: 0x060036C9 RID: 14025 RVA: 0x00133830 File Offset: 0x00131A30
		internal XmlSchemaInferenceException(string res, string arg) : base(res, new string[]
		{
			arg
		}, null, null, 0, 0, null)
		{
		}

		// Token: 0x060036CA RID: 14026 RVA: 0x00133848 File Offset: 0x00131A48
		internal XmlSchemaInferenceException(string res, string arg, string sourceUri, int lineNumber, int linePosition) : base(res, new string[]
		{
			arg
		}, null, sourceUri, lineNumber, linePosition, null)
		{
		}

		// Token: 0x060036CB RID: 14027 RVA: 0x00133862 File Offset: 0x00131A62
		internal XmlSchemaInferenceException(string res, string sourceUri, int lineNumber, int linePosition) : base(res, null, null, sourceUri, lineNumber, linePosition, null)
		{
		}

		// Token: 0x060036CC RID: 14028 RVA: 0x00133872 File Offset: 0x00131A72
		internal XmlSchemaInferenceException(string res, string[] args, string sourceUri, int lineNumber, int linePosition) : base(res, args, null, sourceUri, lineNumber, linePosition, null)
		{
		}

		// Token: 0x060036CD RID: 14029 RVA: 0x00133883 File Offset: 0x00131A83
		internal XmlSchemaInferenceException(string res, int lineNumber, int linePosition) : base(res, null, null, null, lineNumber, linePosition, null)
		{
		}
	}
}
