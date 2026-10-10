using System;
using System.Collections.Generic;

namespace System.Reflection
{
	/// <summary>Содержит статические методы для извлечения настраиваемых атрибутов.</summary>
	// Token: 0x020008E0 RID: 2272
	public static class CustomAttributeExtensions
	{
		/// <summary>Извлекает пользовательский атрибут заданного типа, примененный к указанной сборке.</summary>
		/// <param name="element">Сборка для проверки.</param>
		/// <param name="attributeType">Тип атрибута для поиска.</param>
		/// <returns>Настраиваемый атрибут, соответствующий <paramref name="attributeType" />, или значение <see langword="null" />, если такой атрибут не найден.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Найдено несколько запрошенных атрибутов.</exception>
		// Token: 0x06004BA8 RID: 19368 RVA: 0x000F10E9 File Offset: 0x000EF2E9
		public static Attribute GetCustomAttribute(this Assembly element, Type attributeType)
		{
			return Attribute.GetCustomAttribute(element, attributeType);
		}

		/// <summary>Извлекает пользовательский атрибут заданного типа, примененный к указанному модулю.</summary>
		/// <param name="element">Проверяемый модуль.</param>
		/// <param name="attributeType">Тип атрибута для поиска.</param>
		/// <returns>Настраиваемый атрибут, соответствующий <paramref name="attributeType" />, или значение <see langword="null" />, если такой атрибут не найден.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Найдено несколько запрошенных атрибутов.</exception>
		// Token: 0x06004BA9 RID: 19369 RVA: 0x000F10F2 File Offset: 0x000EF2F2
		public static Attribute GetCustomAttribute(this Module element, Type attributeType)
		{
			return Attribute.GetCustomAttribute(element, attributeType);
		}

		/// <summary>Извлекает пользовательский атрибут заданного типа, примененный к указанному элементу.</summary>
		/// <param name="element">Проверяемый член.</param>
		/// <param name="attributeType">Тип атрибута для поиска.</param>
		/// <returns>Настраиваемый атрибут, соответствующий <paramref name="attributeType" />, или значение <see langword="null" />, если такой атрибут не найден.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="element" /> не представляет конструктор, метод, свойство, событие, тип или поле.</exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Найдено несколько запрошенных атрибутов.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x06004BAA RID: 19370 RVA: 0x000F10FB File Offset: 0x000EF2FB
		public static Attribute GetCustomAttribute(this MemberInfo element, Type attributeType)
		{
			return Attribute.GetCustomAttribute(element, attributeType);
		}

		/// <summary>Извлекает пользовательский атрибут заданного типа, примененный к указанной параметру.</summary>
		/// <param name="element">Проверяемый параметр.</param>
		/// <param name="attributeType">Тип атрибута для поиска.</param>
		/// <returns>Настраиваемый атрибут, соответствующий <paramref name="attributeType" />, или значение <see langword="null" />, если такой атрибут не найден.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Найдено несколько запрошенных атрибутов.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x06004BAB RID: 19371 RVA: 0x000F1104 File Offset: 0x000EF304
		public static Attribute GetCustomAttribute(this ParameterInfo element, Type attributeType)
		{
			return Attribute.GetCustomAttribute(element, attributeType);
		}

		/// <summary>Извлекает пользовательский атрибут заданного типа, примененный к указанной сборке.</summary>
		/// <param name="element">Сборка для проверки.</param>
		/// <typeparam name="T">Тип атрибута для поиска.</typeparam>
		/// <returns>Настраиваемый атрибут, соответствующий <paramref name="T" />, или значение <see langword="null" />, если такой атрибут не найден.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="element" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Найдено несколько запрошенных атрибутов.</exception>
		// Token: 0x06004BAC RID: 19372 RVA: 0x000F110D File Offset: 0x000EF30D
		public static T GetCustomAttribute<T>(this Assembly element) where T : Attribute
		{
			return (T)((object)element.GetCustomAttribute(typeof(T)));
		}

		/// <summary>Извлекает пользовательский атрибут заданного типа, примененный к указанному модулю.</summary>
		/// <param name="element">Проверяемый модуль.</param>
		/// <typeparam name="T">Тип атрибута для поиска.</typeparam>
		/// <returns>Настраиваемый атрибут, соответствующий <paramref name="T" />, или значение <see langword="null" />, если такой атрибут не найден.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="element" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Найдено несколько запрошенных атрибутов.</exception>
		// Token: 0x06004BAD RID: 19373 RVA: 0x000F1124 File Offset: 0x000EF324
		public static T GetCustomAttribute<T>(this Module element) where T : Attribute
		{
			return (T)((object)element.GetCustomAttribute(typeof(T)));
		}

		/// <summary>Извлекает пользовательский атрибут заданного типа, примененный к указанному элементу.</summary>
		/// <param name="element">Проверяемый член.</param>
		/// <typeparam name="T">Тип атрибута для поиска.</typeparam>
		/// <returns>Настраиваемый атрибут, соответствующий <paramref name="T" />, или значение <see langword="null" />, если такой атрибут не найден.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="element" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="element" /> не представляет конструктор, метод, свойство, событие, тип или поле.</exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Найдено несколько запрошенных атрибутов.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x06004BAE RID: 19374 RVA: 0x000F113B File Offset: 0x000EF33B
		public static T GetCustomAttribute<T>(this MemberInfo element) where T : Attribute
		{
			return (T)((object)element.GetCustomAttribute(typeof(T)));
		}

		/// <summary>Извлекает пользовательский атрибут заданного типа, примененный к указанной параметру.</summary>
		/// <param name="element">Проверяемый параметр.</param>
		/// <typeparam name="T">Тип атрибута для поиска.</typeparam>
		/// <returns>Настраиваемый атрибут, соответствующий <paramref name="T" />, или значение <see langword="null" />, если такой атрибут не найден.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="element" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="element" /> не представляет конструктор, метод, свойство, событие, тип или поле.</exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Найдено несколько запрошенных атрибутов.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x06004BAF RID: 19375 RVA: 0x000F1152 File Offset: 0x000EF352
		public static T GetCustomAttribute<T>(this ParameterInfo element) where T : Attribute
		{
			return (T)((object)element.GetCustomAttribute(typeof(T)));
		}

		/// <summary>Извлекает настраиваемый атрибут указанного типа, который применяется к указанному элементу и, при необходимости, проверяет предков этого элемента.</summary>
		/// <param name="element">Проверяемый член.</param>
		/// <param name="attributeType">Тип атрибута для поиска.</param>
		/// <param name="inherit">Значение <see langword="true" /> для проверки предков <paramref name="element" />; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Настраиваемый атрибут, соответствующий <paramref name="attributeType" />, или значение <see langword="null" />, если такой атрибут не найден.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="element" /> не представляет конструктор, метод, свойство, событие, тип или поле.</exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Найдено несколько запрошенных атрибутов.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x06004BB0 RID: 19376 RVA: 0x000F1169 File Offset: 0x000EF369
		public static Attribute GetCustomAttribute(this MemberInfo element, Type attributeType, bool inherit)
		{
			return Attribute.GetCustomAttribute(element, attributeType, inherit);
		}

		/// <summary>Извлекает настраиваемый атрибут указанного типа, который применяется к указанному параметру и, при необходимости, проверяет предков этого параметра.</summary>
		/// <param name="element">Проверяемый параметр.</param>
		/// <param name="attributeType">Тип атрибута для поиска.</param>
		/// <param name="inherit">Значение <see langword="true" /> для проверки предков <paramref name="element" />; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Настраиваемый атрибут, соответствующий <paramref name="attributeType" />, или значение <see langword="null" />, если такой атрибут не найден.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Найдено несколько запрошенных атрибутов.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x06004BB1 RID: 19377 RVA: 0x000F1173 File Offset: 0x000EF373
		public static Attribute GetCustomAttribute(this ParameterInfo element, Type attributeType, bool inherit)
		{
			return Attribute.GetCustomAttribute(element, attributeType, inherit);
		}

		/// <summary>Извлекает настраиваемый атрибут указанного типа, который применяется к указанному элементу и, при необходимости, проверяет предков этого элемента.</summary>
		/// <param name="element">Проверяемый член.</param>
		/// <param name="inherit">Значение <see langword="true" /> для проверки предков <paramref name="element" />; в противном случае — значение <see langword="false" />.</param>
		/// <typeparam name="T">Тип атрибута для поиска.</typeparam>
		/// <returns>Настраиваемый атрибут, соответствующий <paramref name="T" />, или значение <see langword="null" />, если такой атрибут не найден.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="element" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="element" /> не представляет конструктор, метод, свойство, событие, тип или поле.</exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Найдено несколько запрошенных атрибутов.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x06004BB2 RID: 19378 RVA: 0x000F117D File Offset: 0x000EF37D
		public static T GetCustomAttribute<T>(this MemberInfo element, bool inherit) where T : Attribute
		{
			return (T)((object)element.GetCustomAttribute(typeof(T), inherit));
		}

		/// <summary>Извлекает настраиваемый атрибут указанного типа, который применяется к указанному параметру и, при необходимости, проверяет предков этого параметра.</summary>
		/// <param name="element">Проверяемый параметр.</param>
		/// <param name="inherit">Значение <see langword="true" /> для проверки предков <paramref name="element" />; в противном случае — значение <see langword="false" />.</param>
		/// <typeparam name="T">Тип атрибута для поиска.</typeparam>
		/// <returns>Настраиваемый атрибут, соответствующий <paramref name="T" />, или значение <see langword="null" />, если такой атрибут не найден.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="element" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="element" /> не представляет конструктор, метод, свойство, событие, тип или поле.</exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Найдено несколько запрошенных атрибутов.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x06004BB3 RID: 19379 RVA: 0x000F1195 File Offset: 0x000EF395
		public static T GetCustomAttribute<T>(this ParameterInfo element, bool inherit) where T : Attribute
		{
			return (T)((object)element.GetCustomAttribute(typeof(T), inherit));
		}

		/// <summary>Извлекает коллекцию настраиваемых атрибутов, примененных к указанной сборке.</summary>
		/// <param name="element">Сборка для проверки.</param>
		/// <returns>Коллекция настраиваемых атрибутов, которые применяются к <paramref name="element" />, либо пустая коллекция, если таких атрибутов не существует.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="element" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004BB4 RID: 19380 RVA: 0x000F11AD File Offset: 0x000EF3AD
		public static IEnumerable<Attribute> GetCustomAttributes(this Assembly element)
		{
			return Attribute.GetCustomAttributes(element);
		}

		/// <summary>Извлекает коллекцию настраиваемых атрибутов, примененных к указанному модулю.</summary>
		/// <param name="element">Проверяемый модуль.</param>
		/// <returns>Коллекция настраиваемых атрибутов, которые применяются к <paramref name="element" />, либо пустая коллекция, если таких атрибутов не существует.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="element" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004BB5 RID: 19381 RVA: 0x000F11B5 File Offset: 0x000EF3B5
		public static IEnumerable<Attribute> GetCustomAttributes(this Module element)
		{
			return Attribute.GetCustomAttributes(element);
		}

		/// <summary>Извлекает коллекцию настраиваемых атрибутов, примененных к указанному члену.</summary>
		/// <param name="element">Проверяемый член.</param>
		/// <returns>Коллекция настраиваемых атрибутов, которые применяются к <paramref name="element" />, либо пустая коллекция, если таких атрибутов не существует.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="element" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="element" /> не представляет конструктор, метод, свойство, событие, тип или поле.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x06004BB6 RID: 19382 RVA: 0x000F11BD File Offset: 0x000EF3BD
		public static IEnumerable<Attribute> GetCustomAttributes(this MemberInfo element)
		{
			return Attribute.GetCustomAttributes(element);
		}

		/// <summary>Извлекает коллекцию настраиваемых атрибутов, примененных к указанному параметру.</summary>
		/// <param name="element">Проверяемый параметр.</param>
		/// <returns>Коллекция настраиваемых атрибутов, которые применяются к <paramref name="element" />, либо пустая коллекция, если таких атрибутов не существует.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="element" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="element" /> не представляет конструктор, метод, свойство, событие, тип или поле.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x06004BB7 RID: 19383 RVA: 0x000F11C5 File Offset: 0x000EF3C5
		public static IEnumerable<Attribute> GetCustomAttributes(this ParameterInfo element)
		{
			return Attribute.GetCustomAttributes(element);
		}

		/// <summary>Извлекает коллекцию пользовательских атрибутов, которые применяются к указанному элементу и, при необходимости, проверяет предков этого элемента.</summary>
		/// <param name="element">Проверяемый член.</param>
		/// <param name="inherit">Значение <see langword="true" /> для проверки предков <paramref name="element" />; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Коллекция настраиваемых атрибутов, которые применяются к параметру <paramref name="element" />, соответствующему заданным критериям, либо пустая коллекция, если таких атрибутов не существует.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="element" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="element" /> не представляет конструктор, метод, свойство, событие, тип или поле.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x06004BB8 RID: 19384 RVA: 0x000F11CD File Offset: 0x000EF3CD
		public static IEnumerable<Attribute> GetCustomAttributes(this MemberInfo element, bool inherit)
		{
			return Attribute.GetCustomAttributes(element, inherit);
		}

		/// <summary>Извлекает коллекцию пользовательских атрибутов, которые применяются к указанному параметру и, при необходимости, проверяет предков этого параметра.</summary>
		/// <param name="element">Проверяемый параметр.</param>
		/// <param name="inherit">Значение <see langword="true" /> для проверки предков <paramref name="element" />; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Коллекция настраиваемых атрибутов, которые применяются к <paramref name="element" />, либо пустая коллекция, если таких атрибутов не существует.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="element" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="element" /> не представляет конструктор, метод, свойство, событие, тип или поле.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x06004BB9 RID: 19385 RVA: 0x000F11D6 File Offset: 0x000EF3D6
		public static IEnumerable<Attribute> GetCustomAttributes(this ParameterInfo element, bool inherit)
		{
			return Attribute.GetCustomAttributes(element, inherit);
		}

		/// <summary>Извлекает коллекцию пользовательских атрибутов заданного типа, примененных к указанной сборке.</summary>
		/// <param name="element">Сборка для проверки.</param>
		/// <param name="attributeType">Тип атрибута для поиска.</param>
		/// <returns>Коллекция настраиваемых атрибутов, которые применяются к <paramref name="element" /> и соответствуют <paramref name="attributeType" />, либо пустая коллекция, если таких атрибутов не существует.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		// Token: 0x06004BBA RID: 19386 RVA: 0x000F11DF File Offset: 0x000EF3DF
		public static IEnumerable<Attribute> GetCustomAttributes(this Assembly element, Type attributeType)
		{
			return Attribute.GetCustomAttributes(element, attributeType);
		}

		/// <summary>Извлекает коллекцию пользовательских атрибутов заданного типа, примененных к указанному модулю.</summary>
		/// <param name="element">Проверяемый модуль.</param>
		/// <param name="attributeType">Тип атрибута для поиска.</param>
		/// <returns>Коллекция настраиваемых атрибутов, которые применяются к <paramref name="element" /> и соответствуют <paramref name="attributeType" />, либо пустая коллекция, если таких атрибутов не существует.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		// Token: 0x06004BBB RID: 19387 RVA: 0x000F11E8 File Offset: 0x000EF3E8
		public static IEnumerable<Attribute> GetCustomAttributes(this Module element, Type attributeType)
		{
			return Attribute.GetCustomAttributes(element, attributeType);
		}

		/// <summary>Извлекает коллекцию пользовательских атрибутов заданного типа, примененных к указанному элементу.</summary>
		/// <param name="element">Проверяемый член.</param>
		/// <param name="attributeType">Тип атрибута для поиска.</param>
		/// <returns>Коллекция настраиваемых атрибутов, которые применяются к <paramref name="element" /> и соответствуют <paramref name="attributeType" />, либо пустая коллекция, если таких атрибутов не существует.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="element" /> не представляет конструктор, метод, свойство, событие, тип или поле.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x06004BBC RID: 19388 RVA: 0x000F11F1 File Offset: 0x000EF3F1
		public static IEnumerable<Attribute> GetCustomAttributes(this MemberInfo element, Type attributeType)
		{
			return Attribute.GetCustomAttributes(element, attributeType);
		}

		/// <summary>Извлекает коллекцию пользовательских атрибутов заданного типа, примененных к указанному параметру.</summary>
		/// <param name="element">Проверяемый параметр.</param>
		/// <param name="attributeType">Тип атрибута для поиска.</param>
		/// <returns>Коллекция настраиваемых атрибутов, которые применяются к <paramref name="element" /> и соответствуют <paramref name="attributeType" />, либо пустая коллекция, если таких атрибутов не существует.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="element" /> не представляет конструктор, метод, свойство, событие, тип или поле.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x06004BBD RID: 19389 RVA: 0x000F11FA File Offset: 0x000EF3FA
		public static IEnumerable<Attribute> GetCustomAttributes(this ParameterInfo element, Type attributeType)
		{
			return Attribute.GetCustomAttributes(element, attributeType);
		}

		/// <summary>Извлекает коллекцию пользовательских атрибутов заданного типа, примененных к указанной сборке.</summary>
		/// <param name="element">Сборка для проверки.</param>
		/// <typeparam name="T">Тип атрибута для поиска.</typeparam>
		/// <returns>Коллекция настраиваемых атрибутов, которые применяются к <paramref name="element" /> и соответствуют <paramref name="T" />, либо пустая коллекция, если таких атрибутов не существует.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="element" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004BBE RID: 19390 RVA: 0x000F1203 File Offset: 0x000EF403
		public static IEnumerable<T> GetCustomAttributes<T>(this Assembly element) where T : Attribute
		{
			return (IEnumerable<T>)element.GetCustomAttributes(typeof(T));
		}

		/// <summary>Извлекает коллекцию пользовательских атрибутов заданного типа, примененных к указанному модулю.</summary>
		/// <param name="element">Проверяемый модуль.</param>
		/// <typeparam name="T">Тип атрибута для поиска.</typeparam>
		/// <returns>Коллекция настраиваемых атрибутов, которые применяются к <paramref name="element" /> и соответствуют <paramref name="T" />, либо пустая коллекция, если таких атрибутов не существует.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="element" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004BBF RID: 19391 RVA: 0x000F121A File Offset: 0x000EF41A
		public static IEnumerable<T> GetCustomAttributes<T>(this Module element) where T : Attribute
		{
			return (IEnumerable<T>)element.GetCustomAttributes(typeof(T));
		}

		/// <summary>Извлекает коллекцию пользовательских атрибутов заданного типа, примененных к указанному элементу.</summary>
		/// <param name="element">Проверяемый член.</param>
		/// <typeparam name="T">Тип атрибута для поиска.</typeparam>
		/// <returns>Коллекция настраиваемых атрибутов, которые применяются к <paramref name="element" /> и соответствуют <paramref name="T" />, либо пустая коллекция, если таких атрибутов не существует.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="element" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="element" /> не представляет конструктор, метод, свойство, событие, тип или поле.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x06004BC0 RID: 19392 RVA: 0x000F1231 File Offset: 0x000EF431
		public static IEnumerable<T> GetCustomAttributes<T>(this MemberInfo element) where T : Attribute
		{
			return (IEnumerable<T>)element.GetCustomAttributes(typeof(T));
		}

		/// <summary>Извлекает коллекцию пользовательских атрибутов заданного типа, примененных к указанному параметру.</summary>
		/// <param name="element">Проверяемый параметр.</param>
		/// <typeparam name="T">Тип атрибута для поиска.</typeparam>
		/// <returns>Коллекция настраиваемых атрибутов, которые применяются к <paramref name="element" /> и соответствуют <paramref name="T" />, либо пустая коллекция, если таких атрибутов не существует.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="element" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="element" /> не представляет конструктор, метод, свойство, событие, тип или поле.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x06004BC1 RID: 19393 RVA: 0x000F1248 File Offset: 0x000EF448
		public static IEnumerable<T> GetCustomAttributes<T>(this ParameterInfo element) where T : Attribute
		{
			return (IEnumerable<T>)element.GetCustomAttributes(typeof(T));
		}

		/// <summary>Извлекает коллекцию пользовательских атрибутов указанного типа, которые применяется к указанному элементу и, при необходимости, проверяет предков этого элемента.</summary>
		/// <param name="element">Проверяемый член.</param>
		/// <param name="attributeType">Тип атрибута для поиска.</param>
		/// <param name="inherit">Значение <see langword="true" /> для проверки предков <paramref name="element" />; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Коллекция настраиваемых атрибутов, которые применяются к <paramref name="element" /> и соответствуют <paramref name="attributeType" />, либо пустая коллекция, если таких атрибутов не существует.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="element" /> не представляет конструктор, метод, свойство, событие, тип или поле.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x06004BC2 RID: 19394 RVA: 0x000F125F File Offset: 0x000EF45F
		public static IEnumerable<Attribute> GetCustomAttributes(this MemberInfo element, Type attributeType, bool inherit)
		{
			return Attribute.GetCustomAttributes(element, attributeType, inherit);
		}

		/// <summary>Извлекает коллекцию пользовательских атрибутов указанного типа, которые применяется к указанному параметру и, при необходимости, проверяет предков этого параметра.</summary>
		/// <param name="element">Проверяемый параметр.</param>
		/// <param name="attributeType">Тип атрибута для поиска.</param>
		/// <param name="inherit">Значение <see langword="true" /> для проверки предков <paramref name="element" />; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Коллекция настраиваемых атрибутов, которые применяются к <paramref name="element" /> и соответствуют <paramref name="attributeType" />, либо пустая коллекция, если таких атрибутов не существует.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="element" /> не представляет конструктор, метод, свойство, событие, тип или поле.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x06004BC3 RID: 19395 RVA: 0x000F1269 File Offset: 0x000EF469
		public static IEnumerable<Attribute> GetCustomAttributes(this ParameterInfo element, Type attributeType, bool inherit)
		{
			return Attribute.GetCustomAttributes(element, attributeType, inherit);
		}

		/// <summary>Извлекает коллекцию пользовательских атрибутов указанного типа, которые применяется к указанному элементу и, при необходимости, проверяет предков этого элемента.</summary>
		/// <param name="element">Проверяемый член.</param>
		/// <param name="inherit">Значение <see langword="true" /> для проверки предков <paramref name="element" />; в противном случае — значение <see langword="false" />.</param>
		/// <typeparam name="T">Тип атрибута для поиска.</typeparam>
		/// <returns>Коллекция настраиваемых атрибутов, которые применяются к <paramref name="element" /> и соответствуют <paramref name="T" />, либо пустая коллекция, если таких атрибутов не существует.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="element" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="element" /> не представляет конструктор, метод, свойство, событие, тип или поле.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x06004BC4 RID: 19396 RVA: 0x000F1273 File Offset: 0x000EF473
		public static IEnumerable<T> GetCustomAttributes<T>(this MemberInfo element, bool inherit) where T : Attribute
		{
			return (IEnumerable<T>)element.GetCustomAttributes(typeof(T), inherit);
		}

		/// <summary>Извлекает коллекцию пользовательских атрибутов указанного типа, которые применяется к указанному параметру и, при необходимости, проверяет предков этого параметра.</summary>
		/// <param name="element">Проверяемый параметр.</param>
		/// <param name="inherit">Значение <see langword="true" /> для проверки предков <paramref name="element" />; в противном случае — значение <see langword="false" />.</param>
		/// <typeparam name="T">Тип атрибута для поиска.</typeparam>
		/// <returns>Коллекция настраиваемых атрибутов, которые применяются к <paramref name="element" /> и соответствуют <paramref name="T" />, либо пустая коллекция, если таких атрибутов не существует.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="element" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="element" /> не представляет конструктор, метод, свойство, событие, тип или поле.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x06004BC5 RID: 19397 RVA: 0x000F128B File Offset: 0x000EF48B
		public static IEnumerable<T> GetCustomAttributes<T>(this ParameterInfo element, bool inherit) where T : Attribute
		{
			return (IEnumerable<T>)element.GetCustomAttributes(typeof(T), inherit);
		}

		/// <summary>Указывает, применены ли какие-либо пользовательские атрибуты заданного типа к указанной сборке.</summary>
		/// <param name="element">Сборка для проверки.</param>
		/// <param name="attributeType">Искомый тип атрибута.</param>
		/// <returns>Значение <see langword="true" />, если атрибут указанного типа применен к <paramref name="element" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		// Token: 0x06004BC6 RID: 19398 RVA: 0x000F12A3 File Offset: 0x000EF4A3
		public static bool IsDefined(this Assembly element, Type attributeType)
		{
			return Attribute.IsDefined(element, attributeType);
		}

		/// <summary>Указывает, применены ли какие-либо пользовательские атрибуты заданного типа к указанному модулю.</summary>
		/// <param name="element">Проверяемый модуль.</param>
		/// <param name="attributeType">Тип атрибута для поиска.</param>
		/// <returns>Значение <see langword="true" />, если атрибут указанного типа применен к <paramref name="element" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		// Token: 0x06004BC7 RID: 19399 RVA: 0x000F12AC File Offset: 0x000EF4AC
		public static bool IsDefined(this Module element, Type attributeType)
		{
			return Attribute.IsDefined(element, attributeType);
		}

		/// <summary>Указывает, применены ли какие-либо пользовательские атрибуты заданного типа к указанному члену.</summary>
		/// <param name="element">Проверяемый член.</param>
		/// <param name="attributeType">Тип атрибута для поиска.</param>
		/// <returns>Значение <see langword="true" />, если атрибут указанного типа применен к <paramref name="element" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="element" /> не представляет конструктор, метод, свойство, событие, тип или поле.</exception>
		// Token: 0x06004BC8 RID: 19400 RVA: 0x000F12B5 File Offset: 0x000EF4B5
		public static bool IsDefined(this MemberInfo element, Type attributeType)
		{
			return Attribute.IsDefined(element, attributeType);
		}

		/// <summary>Указывает, применены ли какие-либо пользовательские атрибуты заданного типа к указанному параметру.</summary>
		/// <param name="element">Проверяемый параметр.</param>
		/// <param name="attributeType">Тип атрибута для поиска.</param>
		/// <returns>Значение <see langword="true" />, если атрибут указанного типа применен к <paramref name="element" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		// Token: 0x06004BC9 RID: 19401 RVA: 0x000F12BE File Offset: 0x000EF4BE
		public static bool IsDefined(this ParameterInfo element, Type attributeType)
		{
			return Attribute.IsDefined(element, attributeType);
		}

		/// <summary>Указывает применены ли настраиваемые атрибуты указанного типа к указанному элементу и, при необходимости, применены ли они к его предкам.</summary>
		/// <param name="element">Проверяемый член.</param>
		/// <param name="attributeType">Искомый тип атрибута.</param>
		/// <param name="inherit">Значение <see langword="true" /> для проверки предков <paramref name="element" />; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Значение <see langword="true" />, если атрибут указанного типа применен к <paramref name="element" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="element" /> не представляет конструктор, метод, свойство, событие, тип или поле.</exception>
		// Token: 0x06004BCA RID: 19402 RVA: 0x000F12C7 File Offset: 0x000EF4C7
		public static bool IsDefined(this MemberInfo element, Type attributeType, bool inherit)
		{
			return Attribute.IsDefined(element, attributeType, inherit);
		}

		/// <summary>Указывает применены ли настраиваемые атрибуты указанного типа к указанному параметру и, при необходимости, применены ли они к его предкам.</summary>
		/// <param name="element">Проверяемый параметр.</param>
		/// <param name="attributeType">Тип атрибута для поиска.</param>
		/// <param name="inherit">Значение <see langword="true" /> для проверки предков <paramref name="element" />; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Значение <see langword="true" />, если атрибут указанного типа применен к <paramref name="element" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		// Token: 0x06004BCB RID: 19403 RVA: 0x000F12D1 File Offset: 0x000EF4D1
		public static bool IsDefined(this ParameterInfo element, Type attributeType, bool inherit)
		{
			return Attribute.IsDefined(element, attributeType, inherit);
		}
	}
}
