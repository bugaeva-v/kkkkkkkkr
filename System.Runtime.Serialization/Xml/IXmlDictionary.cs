using System;

namespace System.Xml
{
	/// <summary>
	///   <see langword="interface" />, определяющий контракт, который должен реализовать словарь XML, чтобы быть использованным реализациями <see cref="T:System.Xml.XmlDictionaryReader" /> и <see cref="T:System.Xml.XmlDictionaryWriter" />.</summary>
	// Token: 0x0200001E RID: 30
	public interface IXmlDictionary
	{
		/// <summary>Выполняет поиск указанного значения в словаре.</summary>
		/// <param name="value">Искомое строковое значение.</param>
		/// <param name="result">Соответствующая строка <see cref="T:System.Xml.XmlDictionaryString" />, если обнаружена; в противном случае — <see langword="null" />.</param>
		/// <returns>Значение <see langword="true" />, если значение присутствует в словаре; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000091 RID: 145
		bool TryLookup(string value, out XmlDictionaryString result);

		/// <summary>Попытки найти запись в словаре.</summary>
		/// <param name="key">Искомый ключ.</param>
		/// <param name="result">Если параметр <paramref name="key" /> определен, <see cref="T:System.Xml.XmlDictionaryString" />, сопоставляется с ключом; в противном случае — <see langword="null" />.</param>
		/// <returns>
		///   <see langword="true" />, если ключ присутствует в словаре; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000092 RID: 146
		bool TryLookup(int key, out XmlDictionaryString result);

		/// <summary>Проверяет наличие в словаре указанной строки <see cref="T:System.Xml.XmlDictionaryString" />.</summary>
		/// <param name="value">
		///   <see cref="T:System.Xml.XmlDictionaryString" />, наличие которой проверяется.</param>
		/// <param name="result">Соответствующая строка <see cref="T:System.Xml.XmlDictionaryString" />, если обнаружена; в противном случае — <see langword="null" />.</param>
		/// <returns>Значение <see langword="true" />, если <see cref="T:System.Xml.XmlDictionaryString" /> присутствует в словаре; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000093 RID: 147
		bool TryLookup(XmlDictionaryString value, out XmlDictionaryString result);
	}
}
