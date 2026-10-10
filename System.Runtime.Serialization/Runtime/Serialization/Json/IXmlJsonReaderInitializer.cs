using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;

namespace System.Runtime.Serialization.Json
{
	/// <summary>Задает интерфейс для инициализации средства чтения нотации объектов JavaScript (JSON) при его повторном использовании для чтения из конкретного потока или буфера.</summary>
	// Token: 0x02000167 RID: 359
	[TypeForwardedFrom("System.ServiceModel.Web, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
	public interface IXmlJsonReaderInitializer
	{
		/// <summary>Повторно инициализирует средство чтения нотации объектов JavaScript (JSON) для заданного буфера, содержащего данные с кодированием JSON.</summary>
		/// <param name="buffer">Массив буфера входных байтов <see cref="T:System.Byte" />, из которого выполняется чтение.</param>
		/// <param name="offset">Начальное положение для чтения из параметра <paramref name="buffer" />.</param>
		/// <param name="count">Количество байтов, которое может быть считано из параметра <paramref name="buffer" />.</param>
		/// <param name="encoding">Кодировка <see cref="T:System.Text.Encoding" />, используемая средством чтения.</param>
		/// <param name="quotas">Применяемый режим <see cref="T:System.Xml.XmlDictionaryReaderQuotas" />.</param>
		/// <param name="onClose">Делегат <see cref="T:System.Xml.OnXmlDictionaryReaderClose" />, вызываемый при закрытии средства чтения.</param>
		// Token: 0x060012FF RID: 4863
		void SetInput(byte[] buffer, int offset, int count, Encoding encoding, XmlDictionaryReaderQuotas quotas, OnXmlDictionaryReaderClose onClose);

		/// <summary>Повторно инициализирует средство чтения нотации объектов JavaScript (JSON) для заданного потока, содержащего данные с кодированием JSON.</summary>
		/// <param name="stream">Входной поток <see cref="T:System.IO.Stream" />, из которого выполняется чтение.</param>
		/// <param name="encoding">Кодировка <see cref="T:System.Text.Encoding" />, используемая средством чтения.</param>
		/// <param name="quotas">Применяемый объект <see cref="T:System.Xml.XmlDictionaryReaderQuotas" />.</param>
		/// <param name="onClose">Делегат, вызываемый при закрытии модуля чтения.</param>
		// Token: 0x06001300 RID: 4864
		void SetInput(Stream stream, Encoding encoding, XmlDictionaryReaderQuotas quotas, OnXmlDictionaryReaderClose onClose);
	}
}
