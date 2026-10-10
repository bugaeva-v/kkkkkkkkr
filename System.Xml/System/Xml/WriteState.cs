using System;

namespace System.Xml
{
	/// <summary>
	///         Задает состояние <see cref="T:System.Xml.XmlWriter" />.
	///       </summary>
	// Token: 0x02000178 RID: 376
	public enum WriteState
	{
		/// <summary>
		///         Указывает, что метод Write еще не был вызван.
		///       </summary>
		// Token: 0x04000EA5 RID: 3749
		Start,
		/// <summary>
		///         Указывает, что записывается пролог.
		///       </summary>
		// Token: 0x04000EA6 RID: 3750
		Prolog,
		/// <summary>
		///         Указывает, что записывается начальный тег элемента.
		///       </summary>
		// Token: 0x04000EA7 RID: 3751
		Element,
		/// <summary>
		///         Указывает, что записывается значение атрибута.
		///       </summary>
		// Token: 0x04000EA8 RID: 3752
		Attribute,
		/// <summary>
		///         Указывает, что содержимое элемента записывается.
		///       </summary>
		// Token: 0x04000EA9 RID: 3753
		Content,
		/// <summary>
		///         Указывает, что <see cref="M:System.Xml.XmlWriter.Close" /> был вызван метод.
		///       </summary>
		// Token: 0x04000EAA RID: 3754
		Closed,
		/// <summary>
		///         Исключения, который вышел <see cref="T:System.Xml.XmlWriter" /> в недопустимом состоянии.
		///          Можно вызвать <see cref="M:System.Xml.XmlWriter.Close" /> метод для размещения <see cref="T:System.Xml.XmlWriter" /> в <see cref="F:System.Xml.WriteState.Closed" /> состояние.
		///          Любой другой <see cref="T:System.Xml.XmlWriter" /> Результаты вызовы методов в <see cref="T:System.InvalidOperationException" />.
		///       </summary>
		// Token: 0x04000EAB RID: 3755
		Error
	}
}
