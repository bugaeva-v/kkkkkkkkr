using System;
using System.Reflection;
using System.Security;

namespace System.Runtime.InteropServices
{
	/// <summary>Предоставляет набор служб для регистрации и удаления регистрации управляемых сборок при использовании из COM.</summary>
	// Token: 0x0200074E RID: 1870
	[ClassInterface(ClassInterfaceType.None)]
	[Guid("475e398f-8afa-43a7-a3be-f4ef8d6787c9")]
	[ComVisible(true)]
	public class RegistrationServices : IRegistrationServices
	{
		/// <summary>Возвращает идентификатор GUID категории COM, содержащей управляемые классы.</summary>
		/// <returns>Идентификатор GUID категории COM, содержащей управляемые классы.</returns>
		// Token: 0x06004239 RID: 16953 RVA: 0x000E3AA6 File Offset: 0x000E1CA6
		public virtual Guid GetManagedCategoryGuid()
		{
			return RegistrationServices.guidManagedCategory;
		}

		/// <summary>Извлекает идентификатор ProgID COM для указанного типа.</summary>
		/// <param name="type">Тип, соответствующий запрашиваемому идентификатору ProgID.</param>
		/// <returns>Идентификатор ProgID для заданного типа.</returns>
		// Token: 0x0600423A RID: 16954 RVA: 0x000E3AAD File Offset: 0x000E1CAD
		[SecurityCritical]
		public virtual string GetProgIdForType(Type type)
		{
			return Marshal.GenerateProgIdForType(type);
		}

		/// <summary>Извлекает список классов сборки, регистрация которых будет выполнена вызовом метода <see cref="M:System.Runtime.InteropServices.RegistrationServices.RegisterAssembly(System.Reflection.Assembly,System.Runtime.InteropServices.AssemblyRegistrationFlags)" />.</summary>
		/// <param name="assembly">Сборка для поиска классов.</param>
		/// <returns>Массив <see cref="T:System.Type" />, содержащий список классов в сборке <paramref name="assembly" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="assembly" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600423B RID: 16955 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO("implement")]
		[SecurityCritical]
		public virtual Type[] GetRegistrableTypesInAssembly(Assembly assembly)
		{
			throw new NotImplementedException();
		}

		/// <summary>Регистрирует классы в управляемой сборке для поддержки создания из COM.</summary>
		/// <param name="assembly">Регистрируемая сборка.</param>
		/// <param name="flags">Значение <see cref="T:System.Runtime.InteropServices.AssemblyRegistrationFlags" />, показывающее любые специальные настройки, использованные при регистрации параметра <paramref name="assembly" />.</param>
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
		/// <exception cref="T:System.Reflection.TargetInvocationException">Пользовательская настраиваемая функция регистрации (помеченная атрибутом <see cref="T:System.Runtime.InteropServices.ComRegisterFunctionAttribute" />) вызывает исключение.</exception>
		// Token: 0x0600423C RID: 16956 RVA: 0x000479F8 File Offset: 0x00045BF8
		[SecurityCritical]
		[MonoTODO("implement")]
		public virtual bool RegisterAssembly(Assembly assembly, AssemblyRegistrationFlags flags)
		{
			throw new NotImplementedException();
		}

		/// <summary>Регистрирует указанный тип в COM, используя заданный GUID.</summary>
		/// <param name="type">
		///   <see cref="T:System.Type" />, регистрируемый для использования из COM.</param>
		/// <param name="g">
		///   <see cref="T:System.Guid" />, используемый для регистрации указанного типа.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="type" /> не может быть создан.</exception>
		// Token: 0x0600423D RID: 16957 RVA: 0x000479F8 File Offset: 0x00045BF8
		[SecurityCritical]
		[MonoTODO("implement")]
		public virtual void RegisterTypeForComClients(Type type, ref Guid g)
		{
			throw new NotImplementedException();
		}

		/// <summary>Показывает, помечен ли тип атрибутом <see cref="T:System.Runtime.InteropServices.ComImportAttribute" /> или является производным от типа, помеченного атрибутом <see cref="T:System.Runtime.InteropServices.ComImportAttribute" /> и использующим тот же самый GUID в качестве родителя.</summary>
		/// <param name="type">Тип, для которого проверяется, является ли он COM-типом.</param>
		/// <returns>Значение <see langword="true" />, если тип помечен атрибутом <see cref="T:System.Runtime.InteropServices.ComImportAttribute" /> или является производным от типа, помеченного атрибутом <see cref="T:System.Runtime.InteropServices.ComImportAttribute" /> и использующим тот же самый GUID в качестве родителя. В противном случае возвращается значение <see langword="false" />.</returns>
		// Token: 0x0600423E RID: 16958 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO("implement")]
		[SecuritySafeCritical]
		public virtual bool TypeRepresentsComType(Type type)
		{
			throw new NotImplementedException();
		}

		/// <summary>Определяет, необходима ли регистрация указанного типа.</summary>
		/// <param name="type">Тип, для которого проверяется необходимость регистрации COM.</param>
		/// <returns>Значение <see langword="true" />, если тип необходимо регистрировать для использования из COM; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600423F RID: 16959 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO("implement")]
		[SecurityCritical]
		public virtual bool TypeRequiresRegistration(Type type)
		{
			throw new NotImplementedException();
		}

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
		/// <exception cref="T:System.Reflection.TargetInvocationException">Пользовательская настраиваемая функция удаления регистрации (помеченная атрибутом <see cref="T:System.Runtime.InteropServices.ComUnregisterFunctionAttribute" />) вызывает исключение.</exception>
		// Token: 0x06004240 RID: 16960 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO("implement")]
		[SecurityCritical]
		public virtual bool UnregisterAssembly(Assembly assembly)
		{
			throw new NotImplementedException();
		}

		/// <summary>Регистрирует указанный тип в COM, используя заданный контекст выполнения и тип подключения.</summary>
		/// <param name="type">Объект <see cref="T:System.Type" />, регистрируемый для использования из COM.</param>
		/// <param name="classContext">Одно из значений <see cref="T:System.Runtime.InteropServices.RegistrationClassContext" />, показывающее контекст, в котором будет выполняться исполняемый код.</param>
		/// <param name="flags">Одно из значений типа <see cref="T:System.Runtime.InteropServices.RegistrationConnectionType" />, определяющих, какие подключения к объектам класса выполняются.</param>
		/// <returns>Целое число, представляющее значение файла Cookie.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="type" /> не может быть создан.</exception>
		// Token: 0x06004241 RID: 16961 RVA: 0x000479F8 File Offset: 0x00045BF8
		[ComVisible(false)]
		[MonoTODO("implement")]
		public virtual int RegisterTypeForComClients(Type type, RegistrationClassContext classContext, RegistrationConnectionType flags)
		{
			throw new NotImplementedException();
		}

		/// <summary>Удаляет ссылки на тип, зарегистрированный с помощью метода <see cref="M:System.Runtime.InteropServices.RegistrationServices.RegisterTypeForComClients(System.Type,System.Runtime.InteropServices.RegistrationClassContext,System.Runtime.InteropServices.RegistrationConnectionType)" />.</summary>
		/// <param name="cookie">Значение файла cookie, возвращенное предыдущим вызовом перегрузки метода <see cref="M:System.Runtime.InteropServices.RegistrationServices.RegisterTypeForComClients(System.Type,System.Runtime.InteropServices.RegistrationClassContext,System.Runtime.InteropServices.RegistrationConnectionType)" />.</param>
		// Token: 0x06004242 RID: 16962 RVA: 0x000479F8 File Offset: 0x00045BF8
		[ComVisible(false)]
		[MonoTODO("implement")]
		public virtual void UnregisterTypeForComClients(int cookie)
		{
			throw new NotImplementedException();
		}

		// Token: 0x04002BF1 RID: 11249
		private static Guid guidManagedCategory = new Guid("{62C8FE65-4EBB-45e7-B440-6E39B2CDBF29}");
	}
}
