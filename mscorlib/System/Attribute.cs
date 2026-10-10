using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;

namespace System
{
	/// <summary>Представляет базовый класс для настраиваемых атрибутов.</summary>
	// Token: 0x020001EB RID: 491
	[AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComDefaultInterface(typeof(_Attribute))]
	[ComVisible(true)]
	[Serializable]
	public abstract class Attribute : _Attribute
	{
		// Token: 0x06001509 RID: 5385 RVA: 0x0005295D File Offset: 0x00050B5D
		private static Attribute[] InternalGetCustomAttributes(PropertyInfo element, Type type, bool inherit)
		{
			return (Attribute[])MonoCustomAttrs.GetCustomAttributes(element, type, inherit);
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x0005295D File Offset: 0x00050B5D
		private static Attribute[] InternalGetCustomAttributes(EventInfo element, Type type, bool inherit)
		{
			return (Attribute[])MonoCustomAttrs.GetCustomAttributes(element, type, inherit);
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x0005296C File Offset: 0x00050B6C
		private static Attribute[] InternalParamGetCustomAttributes(ParameterInfo parameter, Type attributeType, bool inherit)
		{
			if (parameter.Member.MemberType != MemberTypes.Method)
			{
				return null;
			}
			MethodInfo methodInfo = (MethodInfo)parameter.Member;
			MethodInfo baseDefinition = methodInfo.GetBaseDefinition();
			if (attributeType == null)
			{
				attributeType = typeof(Attribute);
			}
			if (methodInfo == baseDefinition)
			{
				return (Attribute[])parameter.GetCustomAttributes(attributeType, inherit);
			}
			List<Type> list = new List<Type>();
			List<Attribute> list2 = new List<Attribute>();
			for (;;)
			{
				foreach (Attribute attribute in (Attribute[])methodInfo.GetParametersInternal()[parameter.Position].GetCustomAttributes(attributeType, false))
				{
					Type type = attribute.GetType();
					if (!list.Contains(type))
					{
						list.Add(type);
						list2.Add(attribute);
					}
				}
				MethodInfo baseMethod = ((RuntimeMethodInfo)methodInfo).GetBaseMethod();
				if (baseMethod == methodInfo)
				{
					break;
				}
				methodInfo = baseMethod;
			}
			Attribute[] array2 = (Attribute[])Array.CreateInstance(attributeType, list2.Count);
			list2.CopyTo(array2, 0);
			return array2;
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x00052A66 File Offset: 0x00050C66
		private static bool InternalIsDefined(PropertyInfo element, Type attributeType, bool inherit)
		{
			return MonoCustomAttrs.IsDefined(element, attributeType, inherit);
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x00052A66 File Offset: 0x00050C66
		private static bool InternalIsDefined(EventInfo element, Type attributeType, bool inherit)
		{
			return MonoCustomAttrs.IsDefined(element, attributeType, inherit);
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x00052A70 File Offset: 0x00050C70
		private static bool InternalParamIsDefined(ParameterInfo parameter, Type attributeType, bool inherit)
		{
			if (parameter.IsDefined(attributeType, inherit))
			{
				return true;
			}
			if (!inherit)
			{
				return false;
			}
			MemberInfo member = parameter.Member;
			if (member.MemberType != MemberTypes.Method)
			{
				return false;
			}
			MethodInfo methodInfo = ((RuntimeMethodInfo)((MethodInfo)member)).GetBaseMethod();
			for (;;)
			{
				ParameterInfo[] parametersInternal = methodInfo.GetParametersInternal();
				if ((parametersInternal != null && parametersInternal.Length == 0) || parameter.Position < 0)
				{
					break;
				}
				if (parametersInternal[parameter.Position].IsDefined(attributeType, false))
				{
					return true;
				}
				MethodInfo baseMethod = ((RuntimeMethodInfo)methodInfo).GetBaseMethod();
				if (baseMethod == methodInfo)
				{
					return false;
				}
				methodInfo = baseMethod;
			}
			return false;
		}

		/// <summary>Извлекает массив настраиваемых атрибутов, примененных к члену типа. Параметры определяют член и тип настраиваемого атрибута для поиска.</summary>
		/// <param name="element">Объект, производный от класса <see cref="T:System.Reflection.MemberInfo" />, который описывает член класса (конструктор, событие, поле, метод или свойство).</param>
		/// <param name="type">Тип или базовый тип искомого настраиваемого атрибута.</param>
		/// <returns>Массив <see cref="T:System.Attribute" />, содержащий настраиваемые атрибуты типа <paramref name="type" />, примененные к <paramref name="element" />, или пустой массив, если таких настраиваемых атрибутов нет.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="type" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="element" /> не представляет конструктор, метод, свойство, событие, тип или поле.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x0600150F RID: 5391 RVA: 0x00052AF7 File Offset: 0x00050CF7
		public static Attribute[] GetCustomAttributes(MemberInfo element, Type type)
		{
			return Attribute.GetCustomAttributes(element, type, true);
		}

		/// <summary>Извлекает массив настраиваемых атрибутов, примененных к члену типа. Параметры определяют член и тип настраиваемого атрибута для поиска и признак поиска родительского элемента члена.</summary>
		/// <param name="element">Объект, производный от класса <see cref="T:System.Reflection.MemberInfo" />, который описывает член класса (конструктор, событие, поле, метод или свойство).</param>
		/// <param name="type">Тип или базовый тип искомого настраиваемого атрибута.</param>
		/// <param name="inherit">Если <see langword="true" />, задает для настраиваемых атрибутов поиск родительских элементов для <paramref name="element" />.</param>
		/// <returns>Массив <see cref="T:System.Attribute" />, содержащий настраиваемые атрибуты типа <paramref name="type" />, примененные к <paramref name="element" />, или пустой массив, если таких настраиваемых атрибутов нет.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="type" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="element" /> не представляет конструктор, метод, свойство, событие, тип или поле.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x06001510 RID: 5392 RVA: 0x00052B04 File Offset: 0x00050D04
		public static Attribute[] GetCustomAttributes(MemberInfo element, Type type, bool inherit)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (!type.IsSubclassOf(typeof(Attribute)) && type != typeof(Attribute))
			{
				throw new ArgumentException(Environment.GetResourceString("Type passed in must be derived from System.Attribute or System.Attribute itself."));
			}
			MemberTypes memberType = element.MemberType;
			if (memberType == MemberTypes.Event)
			{
				return Attribute.InternalGetCustomAttributes((EventInfo)element, type, inherit);
			}
			if (memberType == MemberTypes.Property)
			{
				return Attribute.InternalGetCustomAttributes((PropertyInfo)element, type, inherit);
			}
			return element.GetCustomAttributes(type, inherit) as Attribute[];
		}

		/// <summary>Извлекает массив настраиваемых атрибутов, примененных к члену типа. Параметр задает имя этого члена.</summary>
		/// <param name="element">Объект, производный от класса <see cref="T:System.Reflection.MemberInfo" />, который описывает член класса (конструктор, событие, поле, метод или свойство).</param>
		/// <returns>Массив <see cref="T:System.Attribute" />, содержащий настраиваемые атрибуты, примененные к <paramref name="element" />, или пустой массив, если такие настраиваемые атрибуты не существуют.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="element" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="element" /> не представляет конструктор, метод, свойство, событие, тип или поле.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x06001511 RID: 5393 RVA: 0x00052BA6 File Offset: 0x00050DA6
		public static Attribute[] GetCustomAttributes(MemberInfo element)
		{
			return Attribute.GetCustomAttributes(element, true);
		}

		/// <summary>Извлекает массив настраиваемых атрибутов, примененных к члену типа. Параметры определяют член и тип настраиваемого атрибута для поиска и признак поиска родительского элемента члена.</summary>
		/// <param name="element">Объект, производный от класса <see cref="T:System.Reflection.MemberInfo" />, который описывает член класса (конструктор, событие, поле, метод или свойство).</param>
		/// <param name="inherit">Если <see langword="true" />, задает для настраиваемых атрибутов поиск родительских элементов для <paramref name="element" />.</param>
		/// <returns>Массив <see cref="T:System.Attribute" />, содержащий настраиваемые атрибуты, примененные к <paramref name="element" />, или пустой массив, если такие настраиваемые атрибуты не существуют.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="element" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="element" /> не представляет конструктор, метод, свойство, событие, тип или поле.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x06001512 RID: 5394 RVA: 0x00052BB0 File Offset: 0x00050DB0
		public static Attribute[] GetCustomAttributes(MemberInfo element, bool inherit)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			MemberTypes memberType = element.MemberType;
			if (memberType == MemberTypes.Event)
			{
				return Attribute.InternalGetCustomAttributes((EventInfo)element, typeof(Attribute), inherit);
			}
			if (memberType == MemberTypes.Property)
			{
				return Attribute.InternalGetCustomAttributes((PropertyInfo)element, typeof(Attribute), inherit);
			}
			return element.GetCustomAttributes(typeof(Attribute), inherit) as Attribute[];
		}

		/// <summary>Определяет, применены ли какие-либо настраиваемые атрибуты к члену типа. Параметры определяют член и тип настраиваемого атрибута для поиска.</summary>
		/// <param name="element">Объект, производный от класса <see cref="T:System.Reflection.MemberInfo" />, описывающий член класса — конструктор, событие, поле, тип, метод или свойство.</param>
		/// <param name="attributeType">Тип или базовый тип искомого настраиваемого атрибута.</param>
		/// <returns>
		///   <see langword="true" />, если настраиваемый атрибут типа <paramref name="attributeType" /> применен к элементу, указанному в параметре <paramref name="element" />; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="element" /> не представляет конструктор, метод, свойство, событие, тип или поле.</exception>
		// Token: 0x06001513 RID: 5395 RVA: 0x00052C25 File Offset: 0x00050E25
		public static bool IsDefined(MemberInfo element, Type attributeType)
		{
			return Attribute.IsDefined(element, attributeType, true);
		}

		/// <summary>Определяет, применены ли какие-либо настраиваемые атрибуты к члену типа. Параметры определяют член и тип настраиваемого атрибута для поиска и признак поиска родительского элемента члена.</summary>
		/// <param name="element">Объект, производный от класса <see cref="T:System.Reflection.MemberInfo" />, описывающий член класса — конструктор, событие, поле, тип, метод или свойство.</param>
		/// <param name="attributeType">Тип или базовый тип искомого настраиваемого атрибута.</param>
		/// <param name="inherit">Если <see langword="true" />, задает для настраиваемых атрибутов поиск родительских элементов для <paramref name="element" />.</param>
		/// <returns>
		///   <see langword="true" />, если настраиваемый атрибут типа <paramref name="attributeType" /> применен к элементу, указанному в параметре <paramref name="element" />; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="element" /> не представляет конструктор, метод, свойство, событие, тип или поле.</exception>
		// Token: 0x06001514 RID: 5396 RVA: 0x00052C30 File Offset: 0x00050E30
		public static bool IsDefined(MemberInfo element, Type attributeType, bool inherit)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			if (attributeType == null)
			{
				throw new ArgumentNullException("attributeType");
			}
			if (!attributeType.IsSubclassOf(typeof(Attribute)) && attributeType != typeof(Attribute))
			{
				throw new ArgumentException(Environment.GetResourceString("Type passed in must be derived from System.Attribute or System.Attribute itself."));
			}
			MemberTypes memberType = element.MemberType;
			if (memberType == MemberTypes.Event)
			{
				return Attribute.InternalIsDefined((EventInfo)element, attributeType, inherit);
			}
			if (memberType == MemberTypes.Property)
			{
				return Attribute.InternalIsDefined((PropertyInfo)element, attributeType, inherit);
			}
			return element.IsDefined(attributeType, inherit);
		}

		/// <summary>Извлекает настраиваемый атрибут, примененный к члену типа. Параметры определяют член и тип настраиваемого атрибута для поиска.</summary>
		/// <param name="element">Объект, производный от класса <see cref="T:System.Reflection.MemberInfo" />, который описывает член класса (конструктор, событие, поле, метод или свойство).</param>
		/// <param name="attributeType">Тип или базовый тип искомого настраиваемого атрибута.</param>
		/// <returns>Ссылка на один настраиваемый атрибут типа <paramref name="attributeType" />, примененный к <paramref name="element" />, или <see langword="null" />, если такого атрибута нет.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="element" /> не представляет конструктор, метод, свойство, событие, тип или поле.</exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Найдено несколько запрошенных атрибутов.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x06001515 RID: 5397 RVA: 0x00052CCD File Offset: 0x00050ECD
		public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType)
		{
			return Attribute.GetCustomAttribute(element, attributeType, true);
		}

		/// <summary>Извлекает настраиваемый атрибут, примененный к члену типа. Параметры определяют член и тип настраиваемого атрибута для поиска и признак поиска родительского элемента члена.</summary>
		/// <param name="element">Объект, производный от класса <see cref="T:System.Reflection.MemberInfo" />, который описывает член класса (конструктор, событие, поле, метод или свойство).</param>
		/// <param name="attributeType">Тип или базовый тип искомого настраиваемого атрибута.</param>
		/// <param name="inherit">Если <see langword="true" />, задает для настраиваемых атрибутов поиск родительских элементов для <paramref name="element" />.</param>
		/// <returns>Ссылка на один настраиваемый атрибут типа <paramref name="attributeType" />, примененный к <paramref name="element" />, или <see langword="null" />, если такого атрибута нет.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="element" /> не представляет конструктор, метод, свойство, событие, тип или поле.</exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Найдено несколько запрошенных атрибутов.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x06001516 RID: 5398 RVA: 0x00052CD8 File Offset: 0x00050ED8
		public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType, bool inherit)
		{
			Attribute[] customAttributes = Attribute.GetCustomAttributes(element, attributeType, inherit);
			if (customAttributes == null || customAttributes.Length == 0)
			{
				return null;
			}
			if (customAttributes.Length == 1)
			{
				return customAttributes[0];
			}
			throw new AmbiguousMatchException(Environment.GetResourceString("Multiple custom attributes of the same type found."));
		}

		/// <summary>Извлекает массив настраиваемых атрибутов, примененных к параметру метода. В параметре задается параметр метода.</summary>
		/// <param name="element">Объект, являющийся производным от класса <see cref="T:System.Reflection.ParameterInfo" />, который описывает параметр члена класса.</param>
		/// <returns>Массив <see cref="T:System.Attribute" />, содержащий настраиваемые атрибуты, примененные к <paramref name="element" />, или пустой массив, если такие настраиваемые атрибуты не существуют.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="element" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x06001517 RID: 5399 RVA: 0x00052D10 File Offset: 0x00050F10
		public static Attribute[] GetCustomAttributes(ParameterInfo element)
		{
			return Attribute.GetCustomAttributes(element, true);
		}

		/// <summary>Извлекает массив настраиваемых атрибутов, примененных к параметру метода. Параметры определяют параметр метода и тип настраиваемого атрибута для поиска.</summary>
		/// <param name="element">Объект, являющийся производным от класса <see cref="T:System.Reflection.ParameterInfo" />, который описывает параметр члена класса.</param>
		/// <param name="attributeType">Тип или базовый тип искомого настраиваемого атрибута.</param>
		/// <returns>Массив <see cref="T:System.Attribute" />, содержащий настраиваемые атрибуты типа <paramref name="attributeType" />, примененные к <paramref name="element" />, или пустой массив, если таких настраиваемых атрибутов нет.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x06001518 RID: 5400 RVA: 0x00052D19 File Offset: 0x00050F19
		public static Attribute[] GetCustomAttributes(ParameterInfo element, Type attributeType)
		{
			return Attribute.GetCustomAttributes(element, attributeType, true);
		}

		/// <summary>Извлекает массив настраиваемых атрибутов, примененных к параметру метода. Параметры определяют параметр метода и тип настраиваемого атрибута для поиска и признак поиска родительского элемента параметра метода.</summary>
		/// <param name="element">Объект, являющийся производным от класса <see cref="T:System.Reflection.ParameterInfo" />, который описывает параметр члена класса.</param>
		/// <param name="attributeType">Тип или базовый тип искомого настраиваемого атрибута.</param>
		/// <param name="inherit">Если <see langword="true" />, задает для настраиваемых атрибутов поиск родительских элементов для <paramref name="element" />.</param>
		/// <returns>Массив <see cref="T:System.Attribute" />, содержащий настраиваемые атрибуты типа <paramref name="attributeType" />, примененные к <paramref name="element" />, или пустой массив, если таких настраиваемых атрибутов нет.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x06001519 RID: 5401 RVA: 0x00052D24 File Offset: 0x00050F24
		public static Attribute[] GetCustomAttributes(ParameterInfo element, Type attributeType, bool inherit)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			if (attributeType == null)
			{
				throw new ArgumentNullException("attributeType");
			}
			if (!attributeType.IsSubclassOf(typeof(Attribute)) && attributeType != typeof(Attribute))
			{
				throw new ArgumentException(Environment.GetResourceString("Type passed in must be derived from System.Attribute or System.Attribute itself."));
			}
			if (element.Member == null)
			{
				throw new ArgumentException(Environment.GetResourceString("The ParameterInfo object is not valid."), "element");
			}
			if (element.Member.MemberType == MemberTypes.Method && inherit)
			{
				return Attribute.InternalParamGetCustomAttributes(element, attributeType, inherit);
			}
			return element.GetCustomAttributes(attributeType, inherit) as Attribute[];
		}

		/// <summary>Извлекает массив настраиваемых атрибутов, примененных к параметру метода. Параметры определяют параметр метода и признак поиска родительского элемента параметра метода.</summary>
		/// <param name="element">Объект, являющийся производным от класса <see cref="T:System.Reflection.ParameterInfo" />, который описывает параметр члена класса.</param>
		/// <param name="inherit">Если <see langword="true" />, задает для настраиваемых атрибутов поиск родительских элементов для <paramref name="element" />.</param>
		/// <returns>Массив <see cref="T:System.Attribute" />, содержащий настраиваемые атрибуты, примененные к <paramref name="element" />, или пустой массив, если такие настраиваемые атрибуты не существуют.</returns>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Reflection.ParameterInfo.Member" /> параметра <paramref name="element" /> равно <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="element" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x0600151A RID: 5402 RVA: 0x00052DD4 File Offset: 0x00050FD4
		public static Attribute[] GetCustomAttributes(ParameterInfo element, bool inherit)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			if (element.Member == null)
			{
				throw new ArgumentException(Environment.GetResourceString("The ParameterInfo object is not valid."), "element");
			}
			if (element.Member.MemberType == MemberTypes.Method && inherit)
			{
				return Attribute.InternalParamGetCustomAttributes(element, null, inherit);
			}
			return element.GetCustomAttributes(typeof(Attribute), inherit) as Attribute[];
		}

		/// <summary>Определяет, применены ли какие-либо настраиваемые атрибуты к параметру метода. Параметры определяют параметр метода и тип настраиваемого атрибута для поиска.</summary>
		/// <param name="element">Объект, являющийся производным от класса <see cref="T:System.Reflection.ParameterInfo" />, который описывает параметр члена класса.</param>
		/// <param name="attributeType">Тип или базовый тип искомого настраиваемого атрибута.</param>
		/// <returns>
		///   <see langword="true" />, если настраиваемый атрибут типа <paramref name="attributeType" /> применен к элементу, указанному в параметре <paramref name="element" />; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		// Token: 0x0600151B RID: 5403 RVA: 0x00052E43 File Offset: 0x00051043
		public static bool IsDefined(ParameterInfo element, Type attributeType)
		{
			return Attribute.IsDefined(element, attributeType, true);
		}

		/// <summary>Определяет, применены ли какие-либо настраиваемые атрибуты к параметру метода. Параметры определяют параметр метода и тип настраиваемого атрибута для поиска и признак поиска родительского элемента параметра метода.</summary>
		/// <param name="element">Объект, являющийся производным от класса <see cref="T:System.Reflection.ParameterInfo" />, который описывает параметр члена класса.</param>
		/// <param name="attributeType">Тип или базовый тип искомого настраиваемого атрибута.</param>
		/// <param name="inherit">Если <see langword="true" />, задает для настраиваемых атрибутов поиск родительских элементов для <paramref name="element" />.</param>
		/// <returns>
		///   <see langword="true" />, если настраиваемый атрибут типа <paramref name="attributeType" /> применен к элементу, указанному в параметре <paramref name="element" />; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		/// <exception cref="T:System.ExecutionEngineException">
		///   <paramref name="element" /> не является методом, конструктором или типом.</exception>
		// Token: 0x0600151C RID: 5404 RVA: 0x00052E50 File Offset: 0x00051050
		public static bool IsDefined(ParameterInfo element, Type attributeType, bool inherit)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			if (attributeType == null)
			{
				throw new ArgumentNullException("attributeType");
			}
			if (!attributeType.IsSubclassOf(typeof(Attribute)) && attributeType != typeof(Attribute))
			{
				throw new ArgumentException(Environment.GetResourceString("Type passed in must be derived from System.Attribute or System.Attribute itself."));
			}
			MemberTypes memberType = element.Member.MemberType;
			if (memberType == MemberTypes.Constructor)
			{
				return element.IsDefined(attributeType, false);
			}
			if (memberType == MemberTypes.Method)
			{
				return Attribute.InternalParamIsDefined(element, attributeType, inherit);
			}
			if (memberType != MemberTypes.Property)
			{
				throw new ArgumentException(Environment.GetResourceString("Invalid type for ParameterInfo member in Attribute class."));
			}
			return element.IsDefined(attributeType, false);
		}

		/// <summary>Извлекает настраиваемый атрибут, примененный к параметру метода. Параметры определяют параметр метода и тип настраиваемого атрибута для поиска.</summary>
		/// <param name="element">Объект, являющийся производным от класса <see cref="T:System.Reflection.ParameterInfo" />, который описывает параметр члена класса.</param>
		/// <param name="attributeType">Тип или базовый тип искомого настраиваемого атрибута.</param>
		/// <returns>Ссылка на один настраиваемый атрибут типа <paramref name="attributeType" />, примененный к <paramref name="element" />, или <see langword="null" />, если такого атрибута нет.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Найдено несколько запрошенных атрибутов.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x0600151D RID: 5405 RVA: 0x00052EF8 File Offset: 0x000510F8
		public static Attribute GetCustomAttribute(ParameterInfo element, Type attributeType)
		{
			return Attribute.GetCustomAttribute(element, attributeType, true);
		}

		/// <summary>Извлекает настраиваемый атрибут, примененный к параметру метода. Параметры определяют параметр метода и тип настраиваемого атрибута для поиска и признак поиска родительского элемента параметра метода.</summary>
		/// <param name="element">Объект, являющийся производным от класса <see cref="T:System.Reflection.ParameterInfo" />, который описывает параметр члена класса.</param>
		/// <param name="attributeType">Тип или базовый тип искомого настраиваемого атрибута.</param>
		/// <param name="inherit">Если <see langword="true" />, задает для настраиваемых атрибутов поиск родительских элементов для <paramref name="element" />.</param>
		/// <returns>Ссылка на один настраиваемый атрибут типа <paramref name="attributeType" />, примененный к <paramref name="element" />, или <see langword="null" />, если такого атрибута нет.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Найдено несколько запрошенных атрибутов.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x0600151E RID: 5406 RVA: 0x00052F04 File Offset: 0x00051104
		public static Attribute GetCustomAttribute(ParameterInfo element, Type attributeType, bool inherit)
		{
			Attribute[] customAttributes = Attribute.GetCustomAttributes(element, attributeType, inherit);
			if (customAttributes == null || customAttributes.Length == 0)
			{
				return null;
			}
			if (customAttributes.Length == 0)
			{
				return null;
			}
			if (customAttributes.Length == 1)
			{
				return customAttributes[0];
			}
			throw new AmbiguousMatchException(Environment.GetResourceString("Multiple custom attributes of the same type found."));
		}

		/// <summary>Извлекает массив настраиваемых атрибутов, примененных к модулю. Параметры определяют модуль и тип настраиваемого атрибута для поиска.</summary>
		/// <param name="element">Объект, являющийся производным от класса <see cref="T:System.Reflection.Module" />, который описывает переносимый исполняемый файл.</param>
		/// <param name="attributeType">Тип или базовый тип искомого настраиваемого атрибута.</param>
		/// <returns>Массив <see cref="T:System.Attribute" />, содержащий настраиваемые атрибуты типа <paramref name="attributeType" />, примененные к <paramref name="element" />, или пустой массив, если таких настраиваемых атрибутов нет.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		// Token: 0x0600151F RID: 5407 RVA: 0x00052F42 File Offset: 0x00051142
		public static Attribute[] GetCustomAttributes(Module element, Type attributeType)
		{
			return Attribute.GetCustomAttributes(element, attributeType, true);
		}

		/// <summary>Извлекает массив настраиваемых атрибутов, примененных к модулю. Параметр задает имя этого модуля.</summary>
		/// <param name="element">Объект, являющийся производным от класса <see cref="T:System.Reflection.Module" />, который описывает переносимый исполняемый файл.</param>
		/// <returns>Массив <see cref="T:System.Attribute" />, содержащий настраиваемые атрибуты, примененные к <paramref name="element" />, или пустой массив, если такие настраиваемые атрибуты не существуют.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="element" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001520 RID: 5408 RVA: 0x00052F4C File Offset: 0x0005114C
		public static Attribute[] GetCustomAttributes(Module element)
		{
			return Attribute.GetCustomAttributes(element, true);
		}

		/// <summary>Извлекает массив настраиваемых атрибутов, примененных к модулю. Параметры задают модуль и игнорируемый параметр поиска.</summary>
		/// <param name="element">Объект, являющийся производным от класса <see cref="T:System.Reflection.Module" />, который описывает переносимый исполняемый файл.</param>
		/// <param name="inherit">Этот параметр игнорируется и не влияет на работу данного метода.</param>
		/// <returns>Массив <see cref="T:System.Attribute" />, содержащий настраиваемые атрибуты, примененные к <paramref name="element" />, или пустой массив, если такие настраиваемые атрибуты не существуют.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001521 RID: 5409 RVA: 0x00052F55 File Offset: 0x00051155
		public static Attribute[] GetCustomAttributes(Module element, bool inherit)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			return (Attribute[])element.GetCustomAttributes(typeof(Attribute), inherit);
		}

		/// <summary>Извлекает массив настраиваемых атрибутов, примененных к модулю. Параметры определяют модуль, тип настраиваемого атрибута для поиска и игнорированный параметр поиска.</summary>
		/// <param name="element">Объект, являющийся производным от класса <see cref="T:System.Reflection.Module" />, который описывает переносимый исполняемый файл.</param>
		/// <param name="attributeType">Тип или базовый тип искомого настраиваемого атрибута.</param>
		/// <param name="inherit">Этот параметр игнорируется и не влияет на работу данного метода.</param>
		/// <returns>Массив <see cref="T:System.Attribute" />, содержащий настраиваемые атрибуты типа <paramref name="attributeType" />, примененные к <paramref name="element" />, или пустой массив, если таких настраиваемых атрибутов нет.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		// Token: 0x06001522 RID: 5410 RVA: 0x00052F84 File Offset: 0x00051184
		public static Attribute[] GetCustomAttributes(Module element, Type attributeType, bool inherit)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			if (attributeType == null)
			{
				throw new ArgumentNullException("attributeType");
			}
			if (!attributeType.IsSubclassOf(typeof(Attribute)) && attributeType != typeof(Attribute))
			{
				throw new ArgumentException(Environment.GetResourceString("Type passed in must be derived from System.Attribute or System.Attribute itself."));
			}
			return (Attribute[])element.GetCustomAttributes(attributeType, inherit);
		}

		/// <summary>Определяет применены ли какие-либо пользовательские атрибуты заданного типа к модулю. Параметры определяют модуль и тип настраиваемого атрибута для поиска.</summary>
		/// <param name="element">Объект, являющийся производным от класса <see cref="T:System.Reflection.Module" />, который описывает переносимый исполняемый файл.</param>
		/// <param name="attributeType">Тип или базовый тип искомого настраиваемого атрибута.</param>
		/// <returns>
		///   <see langword="true" />, если настраиваемый атрибут типа <paramref name="attributeType" /> применен к элементу, указанному в параметре <paramref name="element" />; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		// Token: 0x06001523 RID: 5411 RVA: 0x00052FFA File Offset: 0x000511FA
		public static bool IsDefined(Module element, Type attributeType)
		{
			return Attribute.IsDefined(element, attributeType, false);
		}

		/// <summary>Определяет, применены ли какие-либо настраиваемые атрибуты к модулю. Параметры определяют модуль, тип настраиваемого атрибута для поиска и игнорированный параметр поиска.</summary>
		/// <param name="element">Объект, являющийся производным от класса <see cref="T:System.Reflection.Module" />, который описывает переносимый исполняемый файл.</param>
		/// <param name="attributeType">Тип или базовый тип искомого настраиваемого атрибута.</param>
		/// <param name="inherit">Этот параметр игнорируется и не влияет на работу данного метода.</param>
		/// <returns>
		///   <see langword="true" />, если настраиваемый атрибут типа <paramref name="attributeType" /> применен к элементу, указанному в параметре <paramref name="element" />; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		// Token: 0x06001524 RID: 5412 RVA: 0x00053004 File Offset: 0x00051204
		public static bool IsDefined(Module element, Type attributeType, bool inherit)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			if (attributeType == null)
			{
				throw new ArgumentNullException("attributeType");
			}
			if (!attributeType.IsSubclassOf(typeof(Attribute)) && attributeType != typeof(Attribute))
			{
				throw new ArgumentException(Environment.GetResourceString("Type passed in must be derived from System.Attribute or System.Attribute itself."));
			}
			return element.IsDefined(attributeType, false);
		}

		/// <summary>Извлекает настраиваемый атрибут, примененный к модулю. Параметры определяют модуль и тип настраиваемого атрибута для поиска.</summary>
		/// <param name="element">Объект, являющийся производным от класса <see cref="T:System.Reflection.Module" />, который описывает переносимый исполняемый файл.</param>
		/// <param name="attributeType">Тип или базовый тип искомого настраиваемого атрибута.</param>
		/// <returns>Ссылка на один настраиваемый атрибут типа <paramref name="attributeType" />, примененный к <paramref name="element" />, или <see langword="null" />, если такого атрибута нет.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Найдено несколько запрошенных атрибутов.</exception>
		// Token: 0x06001525 RID: 5413 RVA: 0x00053075 File Offset: 0x00051275
		public static Attribute GetCustomAttribute(Module element, Type attributeType)
		{
			return Attribute.GetCustomAttribute(element, attributeType, true);
		}

		/// <summary>Извлекает настраиваемый атрибут, примененный к модулю. Параметры определяют модуль, тип настраиваемого атрибута для поиска и игнорированный параметр поиска.</summary>
		/// <param name="element">Объект, являющийся производным от класса <see cref="T:System.Reflection.Module" />, который описывает переносимый исполняемый файл.</param>
		/// <param name="attributeType">Тип или базовый тип искомого настраиваемого атрибута.</param>
		/// <param name="inherit">Этот параметр игнорируется и не влияет на работу данного метода.</param>
		/// <returns>Ссылка на один настраиваемый атрибут типа <paramref name="attributeType" />, примененный к <paramref name="element" />, или <see langword="null" />, если такого атрибута нет.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Найдено несколько запрошенных атрибутов.</exception>
		// Token: 0x06001526 RID: 5414 RVA: 0x00053080 File Offset: 0x00051280
		public static Attribute GetCustomAttribute(Module element, Type attributeType, bool inherit)
		{
			Attribute[] customAttributes = Attribute.GetCustomAttributes(element, attributeType, inherit);
			if (customAttributes == null || customAttributes.Length == 0)
			{
				return null;
			}
			if (customAttributes.Length == 1)
			{
				return customAttributes[0];
			}
			throw new AmbiguousMatchException(Environment.GetResourceString("Multiple custom attributes of the same type found."));
		}

		/// <summary>Извлекает массив настраиваемых атрибутов, примененных к сборке. Параметры определяют сборку и тип настраиваемого атрибута для поиска.</summary>
		/// <param name="element">Объект, производный от класса <see cref="T:System.Reflection.Assembly" />, который описывает многократно используемую коллекцию модулей.</param>
		/// <param name="attributeType">Тип или базовый тип искомого настраиваемого атрибута.</param>
		/// <returns>Массив <see cref="T:System.Attribute" />, содержащий настраиваемые атрибуты типа <paramref name="attributeType" />, примененные к <paramref name="element" />, или пустой массив, если таких настраиваемых атрибутов нет.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		// Token: 0x06001527 RID: 5415 RVA: 0x000530B8 File Offset: 0x000512B8
		public static Attribute[] GetCustomAttributes(Assembly element, Type attributeType)
		{
			return Attribute.GetCustomAttributes(element, attributeType, true);
		}

		/// <summary>Извлекает массив настраиваемых атрибутов, примененных к сборке. Параметры определяют сборку, тип настраиваемого атрибута для поиска и игнорированный параметр поиска.</summary>
		/// <param name="element">Объект, производный от класса <see cref="T:System.Reflection.Assembly" />, который описывает многократно используемую коллекцию модулей.</param>
		/// <param name="attributeType">Тип или базовый тип искомого настраиваемого атрибута.</param>
		/// <param name="inherit">Этот параметр игнорируется и не влияет на работу данного метода.</param>
		/// <returns>Массив <see cref="T:System.Attribute" />, содержащий настраиваемые атрибуты типа <paramref name="attributeType" />, примененные к <paramref name="element" />, или пустой массив, если таких настраиваемых атрибутов нет.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		// Token: 0x06001528 RID: 5416 RVA: 0x000530C4 File Offset: 0x000512C4
		public static Attribute[] GetCustomAttributes(Assembly element, Type attributeType, bool inherit)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			if (attributeType == null)
			{
				throw new ArgumentNullException("attributeType");
			}
			if (!attributeType.IsSubclassOf(typeof(Attribute)) && attributeType != typeof(Attribute))
			{
				throw new ArgumentException(Environment.GetResourceString("Type passed in must be derived from System.Attribute or System.Attribute itself."));
			}
			return (Attribute[])element.GetCustomAttributes(attributeType, inherit);
		}

		/// <summary>Извлекает массив настраиваемых атрибутов, примененных к сборке. Параметр указывает сборку.</summary>
		/// <param name="element">Объект, производный от класса <see cref="T:System.Reflection.Assembly" />, который описывает многократно используемую коллекцию модулей.</param>
		/// <returns>Массив <see cref="T:System.Attribute" />, содержащий настраиваемые атрибуты, примененные к <paramref name="element" />, или пустой массив, если такие настраиваемые атрибуты не существуют.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="element" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001529 RID: 5417 RVA: 0x0005313A File Offset: 0x0005133A
		public static Attribute[] GetCustomAttributes(Assembly element)
		{
			return Attribute.GetCustomAttributes(element, true);
		}

		/// <summary>Извлекает массив настраиваемых атрибутов, примененных к сборке. Параметры задают сборку и игнорируемый параметр поиска.</summary>
		/// <param name="element">Объект, производный от класса <see cref="T:System.Reflection.Assembly" />, который описывает многократно используемую коллекцию модулей.</param>
		/// <param name="inherit">Этот параметр игнорируется и не влияет на работу данного метода.</param>
		/// <returns>Массив <see cref="T:System.Attribute" />, содержащий настраиваемые атрибуты, примененные к <paramref name="element" />, или пустой массив, если такие настраиваемые атрибуты не существуют.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600152A RID: 5418 RVA: 0x00053143 File Offset: 0x00051343
		public static Attribute[] GetCustomAttributes(Assembly element, bool inherit)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			return (Attribute[])element.GetCustomAttributes(typeof(Attribute), inherit);
		}

		/// <summary>Определяет, применены ли какие-либо настраиваемые атрибуты к сборке. Параметры определяют сборку и тип настраиваемого атрибута для поиска.</summary>
		/// <param name="element">Объект, производный от класса <see cref="T:System.Reflection.Assembly" />, который описывает многократно используемую коллекцию модулей.</param>
		/// <param name="attributeType">Тип или базовый тип искомого настраиваемого атрибута.</param>
		/// <returns>
		///   <see langword="true" />, если настраиваемый атрибут типа <paramref name="attributeType" /> применен к элементу, указанному в параметре <paramref name="element" />; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		// Token: 0x0600152B RID: 5419 RVA: 0x0005316F File Offset: 0x0005136F
		public static bool IsDefined(Assembly element, Type attributeType)
		{
			return Attribute.IsDefined(element, attributeType, true);
		}

		/// <summary>Определяет, применены ли какие-либо настраиваемые атрибуты к сборке. Параметры определяют сборку, тип настраиваемого атрибута для поиска и игнорированный параметр поиска.</summary>
		/// <param name="element">Объект, производный от класса <see cref="T:System.Reflection.Assembly" />, который описывает многократно используемую коллекцию модулей.</param>
		/// <param name="attributeType">Тип или базовый тип искомого настраиваемого атрибута.</param>
		/// <param name="inherit">Этот параметр игнорируется и не влияет на работу данного метода.</param>
		/// <returns>
		///   <see langword="true" />, если настраиваемый атрибут типа <paramref name="attributeType" /> применен к элементу, указанному в параметре <paramref name="element" />; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		// Token: 0x0600152C RID: 5420 RVA: 0x0005317C File Offset: 0x0005137C
		public static bool IsDefined(Assembly element, Type attributeType, bool inherit)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			if (attributeType == null)
			{
				throw new ArgumentNullException("attributeType");
			}
			if (!attributeType.IsSubclassOf(typeof(Attribute)) && attributeType != typeof(Attribute))
			{
				throw new ArgumentException(Environment.GetResourceString("Type passed in must be derived from System.Attribute or System.Attribute itself."));
			}
			return element.IsDefined(attributeType, false);
		}

		/// <summary>Извлекает настраиваемый атрибут, примененный к заданной сборке. Параметры определяют сборку и тип настраиваемого атрибута для поиска.</summary>
		/// <param name="element">Объект, производный от класса <see cref="T:System.Reflection.Assembly" />, который описывает многократно используемую коллекцию модулей.</param>
		/// <param name="attributeType">Тип или базовый тип искомого настраиваемого атрибута.</param>
		/// <returns>Ссылка на один настраиваемый атрибут типа <paramref name="attributeType" />, примененный к <paramref name="element" />, или <see langword="null" />, если такого атрибута нет.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Найдено несколько запрошенных атрибутов.</exception>
		// Token: 0x0600152D RID: 5421 RVA: 0x000531ED File Offset: 0x000513ED
		public static Attribute GetCustomAttribute(Assembly element, Type attributeType)
		{
			return Attribute.GetCustomAttribute(element, attributeType, true);
		}

		/// <summary>Извлекает настраиваемый атрибут, примененный к сборке. Параметры определяют сборку, тип настраиваемого атрибута для поиска и игнорированный параметр поиска.</summary>
		/// <param name="element">Объект, производный от класса <see cref="T:System.Reflection.Assembly" />, который описывает многократно используемую коллекцию модулей.</param>
		/// <param name="attributeType">Тип или базовый тип искомого настраиваемого атрибута.</param>
		/// <param name="inherit">Этот параметр игнорируется и не влияет на работу данного метода.</param>
		/// <returns>Ссылка на один настраиваемый атрибут типа <paramref name="attributeType" />, примененный к <paramref name="element" />, или <see langword="null" />, если такого атрибута нет.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> или <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="attributeType" /> не является производным объекта <see cref="T:System.Attribute" />.</exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Найдено несколько запрошенных атрибутов.</exception>
		// Token: 0x0600152E RID: 5422 RVA: 0x000531F8 File Offset: 0x000513F8
		public static Attribute GetCustomAttribute(Assembly element, Type attributeType, bool inherit)
		{
			Attribute[] customAttributes = Attribute.GetCustomAttributes(element, attributeType, inherit);
			if (customAttributes == null || customAttributes.Length == 0)
			{
				return null;
			}
			if (customAttributes.Length == 1)
			{
				return customAttributes[0];
			}
			throw new AmbiguousMatchException(Environment.GetResourceString("Multiple custom attributes of the same type found."));
		}

		/// <summary>Возвращает значение, показывающее, равен ли экземпляр указанному объекту.</summary>
		/// <param name="obj">Объект <see cref="T:System.Object" />, который необходимо сравнить с этим экземпляром, или значение <see langword="null" />.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="obj" /> и тип данного экземпляра и значения полей полностью совпадают, в противном случае <see langword="false" />.</returns>
		// Token: 0x06001530 RID: 5424 RVA: 0x00053230 File Offset: 0x00051430
		[SecuritySafeCritical]
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			RuntimeType runtimeType = (RuntimeType)base.GetType();
			if ((RuntimeType)obj.GetType() != runtimeType)
			{
				return false;
			}
			FieldInfo[] fields = runtimeType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			for (int i = 0; i < fields.Length; i++)
			{
				object thisValue = ((RtFieldInfo)fields[i]).UnsafeGetValue(this);
				object thatValue = ((RtFieldInfo)fields[i]).UnsafeGetValue(obj);
				if (!Attribute.AreFieldValuesEqual(thisValue, thatValue))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x000532AC File Offset: 0x000514AC
		private static bool AreFieldValuesEqual(object thisValue, object thatValue)
		{
			if (thisValue == null && thatValue == null)
			{
				return true;
			}
			if (thisValue == null || thatValue == null)
			{
				return false;
			}
			if (thisValue.GetType().IsArray)
			{
				if (!thisValue.GetType().Equals(thatValue.GetType()))
				{
					return false;
				}
				Array array = thisValue as Array;
				Array array2 = thatValue as Array;
				if (array.Length != array2.Length)
				{
					return false;
				}
				for (int i = 0; i < array.Length; i++)
				{
					if (!Attribute.AreFieldValuesEqual(array.GetValue(i), array2.GetValue(i)))
					{
						return false;
					}
				}
			}
			else if (!thisValue.Equals(thatValue))
			{
				return false;
			}
			return true;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06001532 RID: 5426 RVA: 0x00053340 File Offset: 0x00051540
		[SecuritySafeCritical]
		public override int GetHashCode()
		{
			Type type = base.GetType();
			FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			object obj = null;
			for (int i = 0; i < fields.Length; i++)
			{
				object obj2 = ((RtFieldInfo)fields[i]).UnsafeGetValue(this);
				if (obj2 != null && !obj2.GetType().IsArray)
				{
					obj = obj2;
				}
				if (obj != null)
				{
					break;
				}
			}
			if (obj != null)
			{
				return obj.GetHashCode();
			}
			return type.GetHashCode();
		}

		/// <summary>В случае реализации в производном классе возвращает уникальный идентификатор для этого атрибута <see cref="T:System.Attribute" />.</summary>
		/// <returns>Объект <see cref="T:System.Object" />, являющийся уникальным идентификатором атрибута.</returns>
		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06001533 RID: 5427 RVA: 0x00047210 File Offset: 0x00045410
		public virtual object TypeId
		{
			get
			{
				return base.GetType();
			}
		}

		/// <summary>При переопределении в производном классе возвращает значение, указывающее, является ли этот экземпляр равным заданному объекту.</summary>
		/// <param name="obj">Объект <see cref="T:System.Object" />, который необходимо сравнить с этим экземпляром <see cref="T:System.Attribute" />.</param>
		/// <returns>
		///   <see langword="true" />, если этот экземпляр эквивалентен объекту, заданному в параметре <paramref name="obj" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001534 RID: 5428 RVA: 0x000533A5 File Offset: 0x000515A5
		public virtual bool Match(object obj)
		{
			return this.Equals(obj);
		}

		/// <summary>При переопределении в производном классе указывает, является ли значение этого экземпляра значением по умолчанию для производного класса.</summary>
		/// <returns>Значение <see langword="true" />, если этот экземпляр является атрибутом по умолчанию для класса; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001535 RID: 5429 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public virtual bool IsDefaultAttribute()
		{
			return false;
		}

		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Указатель, по которому записывается число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06001536 RID: 5430 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _Attribute.GetTypeInfoCount(out uint pcTInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает сведения о типе объекта, которые можно использовать для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Получает указатель на объект с запрошенными сведениями о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06001537 RID: 5431 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _Attribute.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Переданный массив имен, которые необходимо сопоставить.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, зарезервированный вызывающим объектом, куда помещаются идентификаторы, соответствующие именам.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06001538 RID: 5432 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _Attribute.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
		{
			throw new NotImplementedException();
		}

		/// <summary>Предоставляет доступ к открытым свойствам и методам объекта.</summary>
		/// <param name="dispIdMember">Идентифицирует член.</param>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="lcid">Контекст языкового стандарта, в котором следует интерпретировать аргументы.</param>
		/// <param name="wFlags">Флаги, описывающие контекст вызова.</param>
		/// <param name="pDispParams">Указатель на структуру, содержащую массив аргументов, массив DISPID для именованных аргументов, а также счетчики количества элементов в массивах.</param>
		/// <param name="pVarResult">Указатель, по которому будет сохранен результат.</param>
		/// <param name="pExcepInfo">Указатель на структуру, содержащую сведения об исключении.</param>
		/// <param name="puArgErr">Индекс первого аргумента, вызвавшего ошибку.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06001539 RID: 5433 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _Attribute.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
		{
			throw new NotImplementedException();
		}
	}
}
