using System;
using System.Reflection;
using System.Security;

namespace System.Runtime.InteropServices
{
	/// <summary>Предоставляет набор служб для регистрации и удаления регистрации управляемых сборок при использовании из COM.</summary>
	// Token: 0x0200071A RID: 1818
	[Guid("CCBD682C-73A5-4568-B8B0-C7007E11ABA2")]
	[ComVisible(true)]
	public interface IRegistrationServices
	{
		/// <summary>Регистрирует классы в управляемой сборке для поддержки создания из COM.</summary>
		/// <param name="assembly">Регистрируемая сборка.</param>
		/// <param name="flags">Значение <see cref="T:System.Runtime.InteropServices.AssemblyRegistrationFlags" />, показывающее специальные параметры, необходимые при регистрации сборки <paramref name="assembly" />.</param>
		/// <returns>Значение <see langword="true" />, если сборка <paramref name="assembly" /> содержит успешно зарегистрированные типы; в противном случае, если сборка не содержит подходящих типов — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assembly" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Полное имя сборки <paramref name="assembly" /> равно <see langword="null" />.  
		///
		/// или - 
		/// Метод, помеченный с помощью атрибута <see cref="T:System.Runtime.InteropServices.ComRegisterFunctionAttribute" />, не является статическим (<see langword="static" />).  
		///
		/// или - 
		/// На заданном уровне иерархии атрибутом <see cref="T:System.Runtime.InteropServices.ComRegisterFunctionAttribute" /> помечено несколько методов.  
		///
		/// или - 
		/// Подпись метода, помеченного атрибутом <see cref="T:System.Runtime.InteropServices.ComRegisterFunctionAttribute" />, недействительна.</exception>
		// Token: 0x060040D8 RID: 16600
		[SecurityCritical]
		bool RegisterAssembly(Assembly assembly, AssemblyRegistrationFlags flags);

		/// <summary>Удаляет регистрацию классов в управляемой сборке.</summary>
		/// <param name="assembly">Сборка, для которой удаляется регистрация.</param>
		/// <returns>Значение <see langword="true" />, если сборка <paramref name="assembly" /> содержит типы, для регистрация была успешно удалена; в противном случае, если сборка не содержит подходящих типов — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assembly" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Полное имя сборки <paramref name="assembly" /> равно <see langword="null" />.  
		///
		/// или - 
		/// Метод, помеченный с помощью атрибута <see cref="T:System.Runtime.InteropServices.ComUnregisterFunctionAttribute" />, не является статическим (<see langword="static" />).  
		///
		/// или - 
		/// На заданном уровне иерархии атрибутом <see cref="T:System.Runtime.InteropServices.ComUnregisterFunctionAttribute" /> помечено несколько методов.  
		///
		/// или - 
		/// Подпись метода, помеченного атрибутом <see cref="T:System.Runtime.InteropServices.ComUnregisterFunctionAttribute" />, недействительна.</exception>
		// Token: 0x060040D9 RID: 16601
		[SecurityCritical]
		bool UnregisterAssembly(Assembly assembly);

		/// <summary>Извлекает список классов сборки, регистрация которых будет выполнена вызовом метода <see cref="M:System.Runtime.InteropServices.IRegistrationServices.RegisterAssembly(System.Reflection.Assembly,System.Runtime.InteropServices.AssemblyRegistrationFlags)" />.</summary>
		/// <param name="assembly">Сборка для поиска классов.</param>
		/// <returns>Массив <see cref="T:System.Type" />, содержащий список классов в сборке <paramref name="assembly" />.</returns>
		// Token: 0x060040DA RID: 16602
		[SecurityCritical]
		Type[] GetRegistrableTypesInAssembly(Assembly assembly);

		/// <summary>Извлекает идентификатор ProgID COM для указанного типа.</summary>
		/// <param name="type">Тип, запрашиваемый идентификатором ProgID.</param>
		/// <returns>Идентификатор ProgID для заданного типа.</returns>
		// Token: 0x060040DB RID: 16603
		[SecurityCritical]
		string GetProgIdForType(Type type);

		/// <summary>Регистрирует указанный тип в COM, используя заданный GUID.</summary>
		/// <param name="type">Тип, регистрируемый для использования из COM.</param>
		/// <param name="g">Идентификатор GUID, используемый для регистрации указанного типа.</param>
		// Token: 0x060040DC RID: 16604
		[SecurityCritical]
		void RegisterTypeForComClients(Type type, ref Guid g);

		/// <summary>Возвращает идентификатор GUID категории COM, содержащей управляемые классы.</summary>
		/// <returns>Идентификатор GUID категории COM, содержащей управляемые классы.</returns>
		// Token: 0x060040DD RID: 16605
		Guid GetManagedCategoryGuid();

		/// <summary>Определяет, необходима ли регистрация указанного типа.</summary>
		/// <param name="type">Тип, для которого проверяется необходимость регистрации COM.</param>
		/// <returns>Значение <see langword="true" />, если тип необходимо регистрировать для использования из COM; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060040DE RID: 16606
		[SecurityCritical]
		bool TypeRequiresRegistration(Type type);

		/// <summary>Определяет, является ли указанный тип COM-типом.</summary>
		/// <param name="type">Тип для определения, является ли он COM-типом.</param>
		/// <returns>Значение <see langword="true" />, если указанный тип является COM-типом; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060040DF RID: 16607
		bool TypeRepresentsComType(Type type);
	}
}
