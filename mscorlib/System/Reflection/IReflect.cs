using System;
using System.Globalization;

namespace System.Reflection
{
	/// <summary>Взаимодействует с интерфейсом IDispatch.</summary>
	// Token: 0x020008A2 RID: 2210
	public interface IReflect
	{
		/// <summary>Извлекает объект <see cref="T:System.Reflection.MethodInfo" />, соответствующий заданному методу из числа перегруженных методов, при помощи массива типа <see cref="T:System.Type" />.</summary>
		/// <param name="name">Имя искомого элемента.</param>
		/// <param name="bindingAttr">Атрибуты привязки, используемые для управления поиском.</param>
		/// <param name="binder">Объект, реализующий <see cref="T:System.Reflection.Binder" />, содержащий свойства, связанные с этим методом.</param>
		/// <param name="types">Массив, используемый для выбора среди перегруженных версий метода.</param>
		/// <param name="modifiers">Массив модификаторов параметров, используемый для работы привязки с подписями параметров, в которых были изменены типы.</param>
		/// <returns>Запрошенный метод, который соответствует всем заданным параметрам.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">В объекте реализовано несколько методов с одним именем.</exception>
		// Token: 0x060048F6 RID: 18678
		MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers);

		/// <summary>Извлекает объект <see cref="T:System.Reflection.MethodInfo" />, соответствующий заданному методу при заданных ограничениях поиска.</summary>
		/// <param name="name">Имя искомого элемента.</param>
		/// <param name="bindingAttr">Атрибуты привязки, используемые для управления поиском.</param>
		/// <returns>Объект <see cref="T:System.Reflection.MethodInfo" />, содержащий данные метода, отвечающие имени метода и ограничениям поиска, задаваемым параметром <paramref name="bindingAttr" />.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">В объекте реализовано несколько методов с одним именем.</exception>
		// Token: 0x060048F7 RID: 18679
		MethodInfo GetMethod(string name, BindingFlags bindingAttr);

		/// <summary>Извлекает массив объектов <see cref="T:System.Reflection.MethodInfo" /> со всеми открытыми методами или всеми методами текущего класса.</summary>
		/// <param name="bindingAttr">Атрибуты привязки, используемые для управления поиском.</param>
		/// <returns>Массив объектов <see cref="T:System.Reflection.MethodInfo" />, содержащих все методы, определенные для этого объекта отражения, который удовлетворяет ограничениям поиска, задаваемым параметром <paramref name="bindingAttr" />.</returns>
		// Token: 0x060048F8 RID: 18680
		MethodInfo[] GetMethods(BindingFlags bindingAttr);

		/// <summary>Возвращает объект <see cref="T:System.Reflection.FieldInfo" />, соответствующий заданному полю и флагу привязки.</summary>
		/// <param name="name">Имя искомого поля.</param>
		/// <param name="bindingAttr">Атрибуты привязки, используемые для управления поиском.</param>
		/// <returns>Объект <see cref="T:System.Reflection.FieldInfo" />, содержащий данные поля для именованного объекта, который удовлетворяет ограничениям поиска, задаваемым параметром <paramref name="bindingAttr" />.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">В объекте реализовано несколько полей с одним именем.</exception>
		// Token: 0x060048F9 RID: 18681
		FieldInfo GetField(string name, BindingFlags bindingAttr);

		/// <summary>Возвращает массив объектов <see cref="T:System.Reflection.FieldInfo" />, соответствующих всем полям текущего класса.</summary>
		/// <param name="bindingAttr">Атрибуты привязки, используемые для управления поиском.</param>
		/// <returns>Массив объектов <see cref="T:System.Reflection.FieldInfo" />, содержащих все данные полей этого объекта отражения, который удовлетворяет ограничениям поиска, задаваемым параметром <paramref name="bindingAttr" />.</returns>
		// Token: 0x060048FA RID: 18682
		FieldInfo[] GetFields(BindingFlags bindingAttr);

		/// <summary>Извлекает объект <see cref="T:System.Reflection.PropertyInfo" />, соответствующий заданному свойству при заданных ограничениях поиска.</summary>
		/// <param name="name">Имя искомого свойства.</param>
		/// <param name="bindingAttr">Атрибуты привязки, используемые для управления поиском.</param>
		/// <returns>Объект <see cref="T:System.Reflection.PropertyInfo" /> для найденного свойства, которое удовлетворяет ограничениям поиска, заданным в параметре <paramref name="bindingAttr" />, или значение <see langword="null" />, если свойство не было найдено.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">В объекте реализовано несколько полей с одним именем.</exception>
		// Token: 0x060048FB RID: 18683
		PropertyInfo GetProperty(string name, BindingFlags bindingAttr);

		/// <summary>Извлекает объект <see cref="T:System.Reflection.PropertyInfo" />, соответствующий заданному свойству при заданных ограничениях поиска.</summary>
		/// <param name="name">Имя искомого элемента.</param>
		/// <param name="bindingAttr">Атрибут привязки, используемый для управления поиском.</param>
		/// <param name="binder">Объект, реализующий <see cref="T:System.Reflection.Binder" />, содержащий свойства, связанные с этим методом.</param>
		/// <param name="returnType">Тип свойства.</param>
		/// <param name="types">Массив, используемый для выбора среди перегружаемых одноименных методов.</param>
		/// <param name="modifiers">Массив, используемый для выбора модификаторов параметров.</param>
		/// <returns>Объект <see cref="T:System.Reflection.PropertyInfo" /> для найденного свойства, если свойство с заданным именем было найдено в данном объекте отражения, или значение <see langword="null" />, если свойство не было найдено.</returns>
		// Token: 0x060048FC RID: 18684
		PropertyInfo GetProperty(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers);

		/// <summary>Извлекает массив объектов <see cref="T:System.Reflection.PropertyInfo" />, соответствующих всем открытым свойствам или всем свойствам текущего класса.</summary>
		/// <param name="bindingAttr">Атрибут привязки, используемый для управления поиском.</param>
		/// <returns>Массив объектов <see cref="T:System.Reflection.PropertyInfo" /> для всех свойств, определенных в объекте отражения.</returns>
		// Token: 0x060048FD RID: 18685
		PropertyInfo[] GetProperties(BindingFlags bindingAttr);

		/// <summary>Извлекает массив объектов <see cref="T:System.Reflection.MemberInfo" />, соответствующих всем открытым членам или всем членам, которые удовлетворяют заданному имени.</summary>
		/// <param name="name">Имя искомого элемента.</param>
		/// <param name="bindingAttr">Атрибуты привязки, используемые для управления поиском.</param>
		/// <returns>Массив объектов <see cref="T:System.Reflection.MemberInfo" />, отвечающих параметру <paramref name="name" />.</returns>
		// Token: 0x060048FE RID: 18686
		MemberInfo[] GetMember(string name, BindingFlags bindingAttr);

		/// <summary>Извлекает массив объектов <see cref="T:System.Reflection.MemberInfo" />, соответствующих всем открытым членам или всем членам текущего класса.</summary>
		/// <param name="bindingAttr">Атрибуты привязки, используемые для управления поиском.</param>
		/// <returns>Массив объектов <see cref="T:System.Reflection.MemberInfo" />, содержащих все данные элементов для этого объекта отражения.</returns>
		// Token: 0x060048FF RID: 18687
		MemberInfo[] GetMembers(BindingFlags bindingAttr);

		/// <summary>Вызывает заданный элемент.</summary>
		/// <param name="name">Имя искомого элемента.</param>
		/// <param name="invokeAttr">Один из атрибутов вызова <see cref="T:System.Reflection.BindingFlags" />. Параметр <paramref name="invokeAttr" /> может быть конструктором, методом, свойством или полем. Необходимо указать подходящий атрибут вызова. Чтобы вызвать стандартный элемент класса, передайте в качестве имени элемента пустую строку ("").</param>
		/// <param name="binder">Один из битовых флагов <see cref="T:System.Reflection.BindingFlags" />. Реализует класс <see cref="T:System.Reflection.Binder" />, содержащий свойства, связанные с этим методом.</param>
		/// <param name="target">Объект, для которого следует вызвать указанный член. Для статических элементов этот параметр не обрабатывается.</param>
		/// <param name="args">Массив объектов, содержащих число, порядок и тип параметров вызываемого элемента. Если параметров нет, этот массив пуст.</param>
		/// <param name="modifiers">Массив объектов <see cref="T:System.Reflection.ParameterModifier" />. Массив такой же длины, что и параметр <paramref name="args" />, предоставляющий атрибуты аргументов вызываемого члена в виде метаданных. Параметр может иметь следующие атрибуты: <see langword="pdIn" />, <see langword="pdOut" />, <see langword="pdRetval" />, <see langword="pdOptional" /> и <see langword="pdHasDefault" />. Эти значения представляют, соответственно, параметры [In], [Out], [retval], [optional] и стандартный параметр. Эти атрибуты используются различными службами взаимодействия.</param>
		/// <param name="culture">Экземпляр объекта <see cref="T:System.Globalization.CultureInfo" />, используемого для управления приведением типов. Например, параметр <paramref name="culture" /> преобразует строку <see langword="String" />, которая представляет число 1000, в значение типа <see langword="Double" />, поскольку в разных культурах 1000 может быть представлено по-разному. Если этот параметр имеет значение <see langword="null" />, для текущего потока используется объект <see cref="T:System.Globalization.CultureInfo" />.</param>
		/// <param name="namedParameters">Массив параметров типа <see langword="String" />.</param>
		/// <returns>Заданный член.</returns>
		/// <exception cref="T:System.ArgumentException">Для процедуры <see langword="set" /> поля задано более одного аргумента.</exception>
		/// <exception cref="T:System.MissingFieldException">Невозможно найти поле или свойство.</exception>
		/// <exception cref="T:System.MissingMethodException">Не удается найти метод.</exception>
		/// <exception cref="T:System.Security.SecurityException">Закрытый элемент вызван без необходимого разрешения <see cref="T:System.Security.Permissions.ReflectionPermission" />.</exception>
		// Token: 0x06004900 RID: 18688
		object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters);

		/// <summary>Получает базовый тип, представляющий объект <see cref="T:System.Reflection.IReflect" />.</summary>
		/// <returns>Базовый тип, представляющий объект <see cref="T:System.Reflection.IReflect" />.</returns>
		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x06004901 RID: 18689
		Type UnderlyingSystemType { get; }
	}
}
