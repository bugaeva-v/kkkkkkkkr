using System;
using System.Runtime.Serialization;

namespace System.Security
{
	/// <summary>Исключение, создаваемое при обнаружении синтаксической ошибки в ходе разбора XML. Этот класс не наследуется.</summary>
	// Token: 0x020003CC RID: 972
	[Serializable]
	public sealed class XmlSyntaxException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.XmlSyntaxException" /> стандартными свойствами.</summary>
		// Token: 0x0600285A RID: 10330 RVA: 0x00092A49 File Offset: 0x00090C49
		public XmlSyntaxException()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.XmlSyntaxException" /> с номером строки, в которой обнаружено исключение.</summary>
		/// <param name="lineNumber">Номер строки в потоке XML, в которой обнаружена синтаксическая ошибка XML.</param>
		// Token: 0x0600285B RID: 10331 RVA: 0x00092A49 File Offset: 0x00090C49
		public XmlSyntaxException(int lineNumber)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.XmlSyntaxException" /> с указанным сообщением об ошибке и номером строки, в которой обнаружено исключение.</summary>
		/// <param name="lineNumber">Номер строки в потоке XML, в которой обнаружена синтаксическая ошибка XML.</param>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		// Token: 0x0600285C RID: 10332 RVA: 0x00092A49 File Offset: 0x00090C49
		public XmlSyntaxException(int lineNumber, string message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.XmlSyntaxException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		// Token: 0x0600285D RID: 10333 RVA: 0x00092A49 File Offset: 0x00090C49
		public XmlSyntaxException(string message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.XmlSyntaxException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="inner" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x0600285E RID: 10334 RVA: 0x00092A49 File Offset: 0x00090C49
		public XmlSyntaxException(string message, Exception inner)
		{
		}

		// Token: 0x0600285F RID: 10335 RVA: 0x00020A65 File Offset: 0x0001EC65
		private XmlSyntaxException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
