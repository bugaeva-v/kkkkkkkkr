using System;

namespace System.Xml
{
	/// <summary>
	///         Задает состояние средства чтения.
	///       </summary>
	// Token: 0x02000059 RID: 89
	public enum ReadState
	{
		/// <summary>
		///         <see langword="Read" /> Не был вызван метод.
		///       </summary>
		// Token: 0x04000691 RID: 1681
		Initial,
		/// <summary>
		///         <see langword="Read" /> Был вызван метод.
		///          Дополнительные методы могут быть вызваны для средства чтения.
		///       </summary>
		// Token: 0x04000692 RID: 1682
		Interactive,
		/// <summary>
		///         Произошла ошибка, препятствующая продолжению операции чтения.
		///       </summary>
		// Token: 0x04000693 RID: 1683
		Error,
		/// <summary>
		///         Успешно достигнут конец файла.
		///       </summary>
		// Token: 0x04000694 RID: 1684
		EndOfFile,
		/// <summary>
		///         <see cref="M:System.Xml.XmlReader.Close" /> Был вызван метод.
		///       </summary>
		// Token: 0x04000695 RID: 1685
		Closed
	}
}
