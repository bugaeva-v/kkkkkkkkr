using System;
using System.Collections.Generic;

namespace System.Reflection
{
	/// <summary>Предоставляет методы, получающие сведения о типах во время выполнения.</summary>
	// Token: 0x020008DC RID: 2268
	public static class RuntimeReflectionExtensions
	{
		/// <summary>Извлекает коллекцию, представляющую все поля, определенные в указанном типе.</summary>
		/// <param name="type">Тип, содержащий поля.</param>
		/// <returns>Коллекция полей заданного типа.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004B84 RID: 19332 RVA: 0x000F0901 File Offset: 0x000EEB01
		public static IEnumerable<FieldInfo> GetRuntimeFields(this Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			return type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}

		/// <summary>Извлекает коллекцию, представляющую все методы, определенные в указанном типе.</summary>
		/// <param name="type">Тип, содержащий методы.</param>
		/// <returns>Коллекция методов заданного типа.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004B85 RID: 19333 RVA: 0x000F091F File Offset: 0x000EEB1F
		public static IEnumerable<MethodInfo> GetRuntimeMethods(this Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			return type.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}

		/// <summary>Извлекает коллекцию, представляющую все свойства, определенные в указанном типе.</summary>
		/// <param name="type">Тип, содержащий свойства.</param>
		/// <returns>Коллекция свойств для заданного типа.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004B86 RID: 19334 RVA: 0x000F093D File Offset: 0x000EEB3D
		public static IEnumerable<PropertyInfo> GetRuntimeProperties(this Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			return type.GetProperties(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}

		/// <summary>Извлекает коллекцию, представляющую все события, определенные в указанном типе.</summary>
		/// <param name="type">Тип, содержащий события.</param>
		/// <returns>Коллекция событий заданного типа.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004B87 RID: 19335 RVA: 0x000F095B File Offset: 0x000EEB5B
		public static IEnumerable<EventInfo> GetRuntimeEvents(this Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			return type.GetEvents(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}

		/// <summary>Извлекает объект , который представляет указанное поле.</summary>
		/// <param name="type">Тип, содержащий поле.</param>
		/// <param name="name">Имя поля.</param>
		/// <returns>Объект, представляющий указанное поле, или значение <see langword="null" />, если поле не найдено.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="type" /> имеет значение <see langword="null" />.
		/// -или-
		/// Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004B88 RID: 19336 RVA: 0x000F0979 File Offset: 0x000EEB79
		public static FieldInfo GetRuntimeField(this Type type, string name)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			return type.GetField(name);
		}

		/// <summary>Извлекает объект, который представляет указанный метод.</summary>
		/// <param name="type">Тип, содержащий метод.</param>
		/// <param name="name">Имя метода.</param>
		/// <param name="parameters">Массив, содержащий параметры метода.</param>
		/// <returns>Объект, представляющий указанный метод, или значение <see langword="null" />, если метод не найден.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="type" /> имеет значение <see langword="null" />.
		/// -или-
		/// Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="">Найдено несколько методов с указанным именем.</exception>
		// Token: 0x06004B89 RID: 19337 RVA: 0x000F0996 File Offset: 0x000EEB96
		public static MethodInfo GetRuntimeMethod(this Type type, string name, Type[] parameters)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			return type.GetMethod(name, parameters);
		}

		/// <summary>Извлекает объект, который представляет указанное свойство.</summary>
		/// <param name="type">Тип, содержащий свойство.</param>
		/// <param name="name">Имя свойства.</param>
		/// <returns>Объект, представляющий указанное свойство, или значение <see langword="null" />, если свойство не найдено.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="type" /> имеет значение <see langword="null" />.
		/// -или-
		/// Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="type" /> не является объектом <see langword="RuntimeType" />.</exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Обнаружено несколько свойств с запрашиваемым именем.</exception>
		// Token: 0x06004B8A RID: 19338 RVA: 0x000F09B4 File Offset: 0x000EEBB4
		public static PropertyInfo GetRuntimeProperty(this Type type, string name)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			return type.GetProperty(name);
		}

		/// <summary>Получает объект, представляющий указанное событие.</summary>
		/// <param name="type">Тип, содержащий событие.</param>
		/// <param name="name">Имя события.</param>
		/// <returns>Объект, представляющий указанное событие, или значение <see langword="null" />, если событие не найдено.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="type" /> имеет значение <see langword="null" />.
		/// -или-
		/// Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004B8B RID: 19339 RVA: 0x000F09D1 File Offset: 0x000EEBD1
		public static EventInfo GetRuntimeEvent(this Type type, string name)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			return type.GetEvent(name);
		}

		/// <summary>Извлекает объект, представляющий указанный метода в прямом или косвенном базовом классе, где он был первоначально объявлен.</summary>
		/// <param name="method">Метод для извлечения сведений.</param>
		/// <returns>Объект, представляющий первичное объявление указанного метода в базовом классе.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="method" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004B8C RID: 19340 RVA: 0x000F09EE File Offset: 0x000EEBEE
		public static MethodInfo GetRuntimeBaseDefinition(this MethodInfo method)
		{
			if (method == null)
			{
				throw new ArgumentNullException("method");
			}
			return method.GetBaseDefinition();
		}

		/// <summary>Возвращает сопоставление интерфейса для заданного типа и указанного интерфейса.</summary>
		/// <param name="typeInfo">Тип, для которого требуется извлечь сопоставление.</param>
		/// <param name="interfaceType">Интерфейс, для которого требуется извлечь сопоставление.</param>
		/// <returns>Объект, представляющий сопоставление интерфейса для указанного интерфейса и типа.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="typeInfo" /> имеет значение <see langword="null" />.
		/// -или-
		/// Свойство <paramref name="interfaceType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="interfaceType" /> не реализуется в <paramref name="typeInfo" />.
		/// -или-
		/// <paramref name="interfaceType" /> не ссылается на интерфейс.
		/// -или-
		/// <paramref name="typeInfo" /> либо <paramref name="interfaceType" /> представляет собой открытый универсальный тип.
		/// -или-
		/// <paramref name="interfaceType" /> является универсальным интерфейсом, а <paramref name="typeInfo" /> является типом массива.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="typeInfo" /> представляет параметр универсального типа.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="typeInfo" /> является экземпляром <see cref="T:System.Reflection.Emit.TypeBuilder" />, метод <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> которого еще не был вызван.
		/// -или-
		/// Вызванный метод не поддерживается в базовом классе. Реализацию должны обеспечивать производные классы.</exception>
		// Token: 0x06004B8D RID: 19341 RVA: 0x000F0A0A File Offset: 0x000EEC0A
		public static InterfaceMapping GetRuntimeInterfaceMap(this TypeInfo typeInfo, Type interfaceType)
		{
			if (typeInfo == null)
			{
				throw new ArgumentNullException("typeInfo");
			}
			return typeInfo.GetInterfaceMap(interfaceType);
		}

		/// <summary>Получает объект, представляющий метод, представленный указанным делегатом.</summary>
		/// <param name="del">Проверяемый делегат.</param>
		/// <returns>Объект, представляющий метод.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="del" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.MemberAccessException">Вызывающий объект не имеет доступа к методу, представленному делегатом (например, если метод является закрытым).</exception>
		// Token: 0x06004B8E RID: 19342 RVA: 0x000F0A27 File Offset: 0x000EEC27
		public static MethodInfo GetMethodInfo(this Delegate del)
		{
			if (del == null)
			{
				throw new ArgumentNullException("del");
			}
			return del.Method;
		}

		// Token: 0x04002F66 RID: 12134
		private const BindingFlags Everything = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
	}
}
