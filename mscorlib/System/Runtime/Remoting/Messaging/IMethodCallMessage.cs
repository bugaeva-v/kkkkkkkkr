using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Messaging
{
	/// <summary>Определяет интерфейс сообщения о вызове метода.</summary>
	// Token: 0x0200061E RID: 1566
	[ComVisible(true)]
	public interface IMethodCallMessage : IMethodMessage, IMessage
	{
		/// <summary>Возвращает число аргументов в вызове, которые не помечены как параметры <see langword="out" />.</summary>
		/// <returns>Число аргументов в вызове, которые не помечены как параметры <see langword="out" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06003AFD RID: 15101
		int InArgCount { get; }

		/// <summary>Возвращает массив аргументов, которые не помечены как параметры <see langword="out" />.</summary>
		/// <returns>Массив аргументов, которые не помечены как параметры <see langword="out" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06003AFE RID: 15102
		object[] InArgs { get; }

		/// <summary>Возвращает заданный аргумент, который не помечен как параметр <see langword="out" />.</summary>
		/// <param name="argNum">Номер запрашиваемого аргумента <see langword="in" />.</param>
		/// <returns>Запрашиваемый аргумент, который не помечен как параметр <see langword="out" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x06003AFF RID: 15103
		object GetInArg(int argNum);

		/// <summary>Возвращает имя заданного аргумента, который не помечен как параметр <see langword="out" />.</summary>
		/// <param name="index">Номер запрашиваемого аргумента <see langword="in" />.</param>
		/// <returns>Имя заданного аргумента, который не помечен как параметр <see langword="out" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x06003B00 RID: 15104
		string GetInArgName(int index);
	}
}
