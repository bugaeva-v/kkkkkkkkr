using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Messaging
{
	/// <summary>Определяет экстренные данные для вызова.</summary>
	// Token: 0x02000618 RID: 1560
	[ComVisible(true)]
	[Serializable]
	public class Header
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Messaging.Header" /> с заданными именем и значением.</summary>
		/// <param name="_Name">Имя <see cref="T:System.Runtime.Remoting.Messaging.Header" />.</param>
		/// <param name="_Value">Объект, содержащий значение для <see cref="T:System.Runtime.Remoting.Messaging.Header" />.</param>
		// Token: 0x06003AEC RID: 15084 RVA: 0x000CE325 File Offset: 0x000CC525
		public Header(string _Name, object _Value) : this(_Name, _Value, true)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Messaging.Header" /> с заданными именем, значением и дополнительными сведениями о конфигурации.</summary>
		/// <param name="_Name">Имя <see cref="T:System.Runtime.Remoting.Messaging.Header" />.</param>
		/// <param name="_Value">Объект, содержащий значение для <see cref="T:System.Runtime.Remoting.Messaging.Header" />.</param>
		/// <param name="_MustUnderstand">Указывает, должна ли принимающая сторона распознавать экстренные данные.</param>
		// Token: 0x06003AED RID: 15085 RVA: 0x000CE330 File Offset: 0x000CC530
		public Header(string _Name, object _Value, bool _MustUnderstand) : this(_Name, _Value, _MustUnderstand, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Messaging.Header" />.</summary>
		/// <param name="_Name">Имя <see cref="T:System.Runtime.Remoting.Messaging.Header" />.</param>
		/// <param name="_Value">Объект, содержащий значение <see cref="T:System.Runtime.Remoting.Messaging.Header" />.</param>
		/// <param name="_MustUnderstand">Указывает, должна ли принимающая сторона распознавать экстренные данные.</param>
		/// <param name="_HeaderNamespace">Пространство имен XML <see cref="T:System.Runtime.Remoting.Messaging.Header" />.</param>
		// Token: 0x06003AEE RID: 15086 RVA: 0x000CE33C File Offset: 0x000CC53C
		public Header(string _Name, object _Value, bool _MustUnderstand, string _HeaderNamespace)
		{
			this.Name = _Name;
			this.Value = _Value;
			this.MustUnderstand = _MustUnderstand;
			this.HeaderNamespace = _HeaderNamespace;
		}

		/// <summary>Указывает пространство имен XML, которому принадлежит текущий <see cref="T:System.Runtime.Remoting.Messaging.Header" />.</summary>
		// Token: 0x0400268E RID: 9870
		public string HeaderNamespace;

		/// <summary>Указывает, должна ли принимающая сторона распознавать экстренные данные.</summary>
		// Token: 0x0400268F RID: 9871
		public bool MustUnderstand;

		/// <summary>Содержит имя <see cref="T:System.Runtime.Remoting.Messaging.Header" />.</summary>
		// Token: 0x04002690 RID: 9872
		public string Name;

		/// <summary>Содержит значение для <see cref="T:System.Runtime.Remoting.Messaging.Header" />.</summary>
		// Token: 0x04002691 RID: 9873
		public object Value;
	}
}
