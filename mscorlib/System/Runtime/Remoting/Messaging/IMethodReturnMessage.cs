using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Messaging
{
	/// <summary>Определяет интерфейс возвращаемого сообщения о вызове метода.</summary>
	// Token: 0x02000620 RID: 1568
	[ComVisible(true)]
	public interface IMethodReturnMessage : IMethodMessage, IMessage
	{
		/// <summary>Возвращает исключение, инициированное при вызове метода.</summary>
		/// <returns>Объект исключения для вызова метода или значение <see langword="null" />, если метод не инициировал исключение.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06003B0C RID: 15116
		Exception Exception { get; }

		/// <summary>Возвращает число аргументов в вызове метода, помеченных как параметры <see langword="ref" /> или <see langword="out" />.</summary>
		/// <returns>Число аргументов в вызове метода, помеченных как параметры <see langword="ref" /> или <see langword="out" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06003B0D RID: 15117
		int OutArgCount { get; }

		/// <summary>Возвращает указанный аргумент, помеченный как параметр <see langword="ref" /> или <see langword="out" />.</summary>
		/// <returns>Указанный аргумент, помеченный как параметр <see langword="ref" /> или <see langword="out" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06003B0E RID: 15118
		object[] OutArgs { get; }

		/// <summary>Возвращает возвращаемое значение вызова метода.</summary>
		/// <returns>Возвращаемое значение вызова метода.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06003B0F RID: 15119
		object ReturnValue { get; }

		/// <summary>Возвращает указанный аргумент, помеченный как параметр <see langword="ref" /> или <see langword="out" />.</summary>
		/// <param name="argNum">Номер запрашиваемого аргумента.</param>
		/// <returns>Указанный аргумент, помеченный как параметр <see langword="ref" /> или <see langword="out" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x06003B10 RID: 15120
		object GetOutArg(int argNum);

		/// <summary>Возвращает имя указанного аргумента, помеченного как параметр <see langword="ref" /> или <see langword="out" />.</summary>
		/// <param name="index">Номер запрашиваемого имени аргумента.</param>
		/// <returns>Имя аргумента или <see langword="null" />, если текущий метод не реализован.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x06003B11 RID: 15121
		string GetOutArgName(int index);
	}
}
