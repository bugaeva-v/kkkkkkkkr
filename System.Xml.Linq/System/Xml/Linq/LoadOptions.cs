using System;

namespace System.Xml.Linq
{
	/// <summary>Указывает параметры загрузки для синтаксического анализа XML.</summary>
	// Token: 0x0200004A RID: 74
	[Flags]
	public enum LoadOptions
	{
		/// <summary>Не сохраняет незначительные пробелы или загружает базовый URI и информацию строки.</summary>
		// Token: 0x04000177 RID: 375
		None = 0,
		/// <summary>Сохраняет незначительные пробелы при анализе.</summary>
		// Token: 0x04000178 RID: 376
		PreserveWhitespace = 1,
		/// <summary>Запрашивает информацию о базовом URI из <see cref="T:System.Xml.XmlReader" /> и делает ее доступной через свойство <see cref="P:System.Xml.Linq.XObject.BaseUri" />.</summary>
		// Token: 0x04000179 RID: 377
		SetBaseUri = 2,
		/// <summary>Запрашивает информацию о строке из <see cref="T:System.Xml.XmlReader" /> и делает ее доступной через свойства на <see cref="T:System.Xml.Linq.XObject" />.</summary>
		// Token: 0x0400017A RID: 378
		SetLineInfo = 4
	}
}
