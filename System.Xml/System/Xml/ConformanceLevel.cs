using System;

namespace System.Xml
{
	/// <summary>
	///         Указывает объем ввода или вывода, проверка <see cref="T:System.Xml.XmlReader" /> и <see cref="T:System.Xml.XmlWriter" /> выполняют объекты.
	///       </summary>
	// Token: 0x0200002E RID: 46
	public enum ConformanceLevel
	{
		/// <summary>
		///         <see cref="T:System.Xml.XmlReader" /> Или <see cref="T:System.Xml.XmlWriter" /> автоматически обнаруживает ли уровня документа или уровня фрагмента проверку следует выполнять и выполняет соответствующую проверку.
		///          Если другой обтекания <see cref="T:System.Xml.XmlReader" /> или <see cref="T:System.Xml.XmlWriter" /> объекта внешний объект не выполняет какие-либо дополнительные соответствия проверки.
		///          Проверка на соответствие выполняется базовым объектом.
		///
		///         В разделе <see cref="P:System.Xml.XmlReaderSettings.ConformanceLevel" /> и <see cref="P:System.Xml.XmlWriterSettings.ConformanceLevel" /> Свойства сведения о том, как определяется уровень соответствия.
		///       </summary>
		// Token: 0x040005E0 RID: 1504
		Auto,
		/// <summary>
		///         XML-данные well-formed XML fragment, как определено консорциумом W3C.
		///       </summary>
		// Token: 0x040005E1 RID: 1505
		Fragment,
		/// <summary>
		///         XML-данные соответствуют правилам для правильного формата XML 1.0 document, как определено консорциумом W3C.
		///       </summary>
		// Token: 0x040005E2 RID: 1506
		Document
	}
}
