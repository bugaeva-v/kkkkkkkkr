using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Messaging
{
	/// <summary>Определяет интерфейс сообщения метода.</summary>
	// Token: 0x0200061F RID: 1567
	[ComVisible(true)]
	public interface IMethodMessage : IMessage
	{
		/// <summary>Возвращает число аргументов, переданных методу.</summary>
		/// <returns>Число аргументов, переданных методу.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06003B01 RID: 15105
		int ArgCount { get; }

		/// <summary>Возвращает массив аргументов, переданных методу.</summary>
		/// <returns>Массив <see cref="T:System.Object" />, содержащий аргументы, переданные методу.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06003B02 RID: 15106
		object[] Args { get; }

		/// <summary>Возвращает значение, указывающее, имеет ли сообщение переменные аргументы.</summary>
		/// <returns>
		///   <see langword="true" />, если метод принимает переменное число аргументов; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06003B03 RID: 15107
		bool HasVarArgs { get; }

		/// <summary>Возвращает <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> для текущего вызова метода.</summary>
		/// <returns>Возвращает <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> для текущего вызова метода.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06003B04 RID: 15108
		LogicalCallContext LogicalCallContext { get; }

		/// <summary>Получает объект <see cref="T:System.Reflection.MethodBase" /> вызванного метода.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.MethodBase" /> вызванного метода.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06003B05 RID: 15109
		MethodBase MethodBase { get; }

		/// <summary>Возвращает имя вызванного метода.</summary>
		/// <returns>Имя вызванного метода.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06003B06 RID: 15110
		string MethodName { get; }

		/// <summary>Возвращает объект, содержащий подпись метода.</summary>
		/// <returns>Объект, содержащий подпись метода.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06003B07 RID: 15111
		object MethodSignature { get; }

		/// <summary>Получает полное имя <see cref="T:System.Type" /> определенного объекта, для которого предназначен вызов.</summary>
		/// <returns>Полное имя <see cref="T:System.Type" /> определенного объекта, для которого предназначен вызов.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06003B08 RID: 15112
		string TypeName { get; }

		/// <summary>Возвращает URI определенного объекта, для которого предназначен вызов.</summary>
		/// <returns>URI удаленного объекта, содержащего вызванный метод.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06003B09 RID: 15113
		string Uri { get; }

		/// <summary>Возвращает определенный аргумент как <see cref="T:System.Object" />.</summary>
		/// <param name="argNum">Номер запрашиваемого аргумента.</param>
		/// <returns>Аргумент, переданный методу.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x06003B0A RID: 15114
		object GetArg(int argNum);

		/// <summary>Возвращает имя аргумента, переданного методу.</summary>
		/// <param name="index">Номер запрашиваемого аргумента.</param>
		/// <returns>Имя заданного аргумента, переданное методу, или <see langword="null" />, если текущий метод не реализован.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x06003B0B RID: 15115
		string GetArgName(int index);
	}
}
