using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting
{
	/// <summary>Обеспечивает сведения о типе объекта.</summary>
	// Token: 0x0200055F RID: 1375
	[ComVisible(true)]
	public interface IRemotingTypeInfo
	{
		/// <summary>Возвращает или задает полное имя типа объекта сервера в <see cref="T:System.Runtime.Remoting.ObjRef" />.</summary>
		/// <returns>Полное имя типа объекта сервера в <see cref="T:System.Runtime.Remoting.ObjRef" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x060035E5 RID: 13797
		// (set) Token: 0x060035E6 RID: 13798
		string TypeName { get; set; }

		/// <summary>Проверяет, можно ли привести прокси, представляющий указанный тип объекта, к типу, представляемому интерфейсом <see cref="T:System.Runtime.Remoting.IRemotingTypeInfo" />.</summary>
		/// <param name="fromType">Тип, к которому осуществляется приведение.</param>
		/// <param name="o">Объект, для которого необходимо проверить приведение.</param>
		/// <returns>
		///   <see langword="true" />, если приведение типов прошло успешно; иначе — <see langword="false" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x060035E7 RID: 13799
		bool CanCastTo(Type fromType, object o);
	}
}
