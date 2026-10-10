using System;
using System.IO;

namespace System.Xml
{
	/// <summary>Содержит свойства и методы, которые, при реализации с помощью <see cref="T:System.Xml.XmlDictionaryWriter" />, позволяют обрабатывать фрагменты XML.</summary>
	// Token: 0x0200001C RID: 28
	public interface IFragmentCapableXmlDictionaryWriter
	{
		/// <summary>Возвращает значение, указывающее, может ли этот объект <see cref="T:System.Xml.XmlDictionaryWriter" /> обработать фрагменты XML.</summary>
		/// <returns>
		///   <see langword="true" />, если этот <see cref="T:System.Xml.XmlDictionaryWriter" /> может обрабатывать фрагменты XML; в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600008B RID: 139
		bool CanFragment { get; }

		/// <summary>Начинает обработку фрагмента XML.</summary>
		/// <param name="stream">Поток, в который требуется выполнить запись.</param>
		/// <param name="generateSelfContainedTextFragment">Если <see langword="true" />, любое пространство имен, объявленное за пределами фрагмента, объявляется снова, если используется внутри него; если <see langword="false" />, то пространства имен не объявляются вновь.</param>
		// Token: 0x0600008C RID: 140
		void StartFragment(Stream stream, bool generateSelfContainedTextFragment);

		/// <summary>Завершает обработку фрагмента XML.</summary>
		// Token: 0x0600008D RID: 141
		void EndFragment();

		/// <summary>Записывает фрагмент XML в основной поток модуля записи.</summary>
		/// <param name="buffer">Буфер для записи.</param>
		/// <param name="offset">Начальное положение для записи в параметре <paramref name="buffer" />.</param>
		/// <param name="count">Число байтов для записи в объект <paramref name="buffer" />.</param>
		// Token: 0x0600008E RID: 142
		void WriteFragment(byte[] buffer, int offset, int count);
	}
}
