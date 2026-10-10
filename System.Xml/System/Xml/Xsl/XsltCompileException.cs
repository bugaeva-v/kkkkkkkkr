using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Xml.Xsl
{
	/// <summary>
	///         Исключение, вызванное нагрузки метод, если обнаружена ошибка в таблице стилей XSLT.
	///       </summary>
	// Token: 0x0200034D RID: 845
	[Serializable]
	public class XsltCompileException : XsltException
	{
		/// <summary>
		///         Инициализирует новый экземпляр <see langword="XsltCompileException" /> класса, используя сведения в <see cref="T:System.Runtime.Serialization.SerializationInfo" /> и <see cref="T:System.Runtime.Serialization.StreamingContext" /> объектов.
		///       </summary>
		/// <param name="info">
		///           <see langword="SerializationInfo" /> Объект, содержащий все свойства <see langword="XsltCompileException" />.
		///         </param>
		/// <param name="context">
		///           <see langword="StreamingContext" /> Объект, содержащий сведения о контексте.
		///         </param>
		// Token: 0x060022E8 RID: 8936 RVA: 0x000D91A7 File Offset: 0x000D73A7
		protected XsltCompileException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>
		///         Объединяет все <see langword="XsltCompileException" /> Свойства в <see cref="T:System.Runtime.Serialization.SerializationInfo" /> класса для данного <see cref="T:System.Runtime.Serialization.StreamingContext" />.
		///       </summary>
		/// <param name="info">
		///           Объект <see langword="SerializationInfo" />.
		///         </param>
		/// <param name="context">
		///           Объект <see langword="StreamingContext" />.
		///         </param>
		// Token: 0x060022E9 RID: 8937 RVA: 0x000DAA62 File Offset: 0x000D8C62
		[SecurityPermission(SecurityAction.LinkDemand, SerializationFormatter = true)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Xsl.XsltCompileException" />.
		///       </summary>
		// Token: 0x060022EA RID: 8938 RVA: 0x000DAA6C File Offset: 0x000D8C6C
		public XsltCompileException()
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Xsl.XsltCompileException" /> с указанным сообщением об ошибке.
		///       </summary>
		/// <param name="message">
		///           Сообщение, описывающее ошибку.
		///         </param>
		// Token: 0x060022EB RID: 8939 RVA: 0x000DAA74 File Offset: 0x000D8C74
		public XsltCompileException(string message) : base(message)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Xsl.XsltCompileException" /> класс указанное сообщение об ошибке и ссылкой на внутреннее исключение, которое стало причиной данного исключения.
		///       </summary>
		/// <param name="message">
		///           Сообщение, описывающее ошибку.
		///         </param>
		/// <param name="innerException">
		///           Исключение, вызвавшее текущее исключение, или <see langword="null" /> Если указано внутреннее исключение.
		///         </param>
		// Token: 0x060022EC RID: 8940 RVA: 0x000DAA7D File Offset: 0x000D8C7D
		public XsltCompileException(string message, Exception innerException) : base(message, innerException)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see langword="XsltCompileException" />.
		///       </summary>
		/// <param name="inner">
		///           <see cref="T:System.Exception" /> Вызвавший <see langword="XsltCompileException" />.
		///         </param>
		/// <param name="sourceUri">
		///           Путь к таблице стилей.
		///         </param>
		/// <param name="lineNumber">
		///           Номер строки, указывающий место возникновения ошибки в таблице стилей.
		///         </param>
		/// <param name="linePosition">
		///           Позиция в строке, указывающую место возникновения ошибки в таблице стилей.
		///         </param>
		// Token: 0x060022ED RID: 8941 RVA: 0x000DAA88 File Offset: 0x000D8C88
		public XsltCompileException(Exception inner, string sourceUri, int lineNumber, int linePosition) : base((lineNumber != 0) ? "XSLT compile error at {0}({1},{2}). See InnerException for details." : "XSLT compile error.", new string[]
		{
			sourceUri,
			lineNumber.ToString(CultureInfo.InvariantCulture),
			linePosition.ToString(CultureInfo.InvariantCulture)
		}, sourceUri, lineNumber, linePosition, inner)
		{
		}
	}
}
