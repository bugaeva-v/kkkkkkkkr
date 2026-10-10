using System;
using System.Globalization;

namespace System.Reflection
{
	/// <summary>Выбирает член из списка кандидатов и выполняет преобразование типов из действительного типа аргумента к формальному типу аргумента.</summary>
	// Token: 0x02000892 RID: 2194
	public abstract class Binder
	{
		/// <summary>Выбирает поле из заданного набора полей с учетом заданных критериев.</summary>
		/// <param name="bindingAttr">Побитовое сочетание значений <see cref="T:System.Reflection.BindingFlags" />.</param>
		/// <param name="match">Набор полей, которые являются кандидатами для сопоставления. Например, если объект <see cref="T:System.Reflection.Binder" /> используется методом <see cref="Overload:System.Type.InvokeMember" />, этот параметр указывает набор полей, определенных в отражении как возможные соответствия, как правило в связи с тем, что они имеют правильное имя члена. Реализация по умолчанию, предоставленная свойством <see cref="P:System.Type.DefaultBinder" />, изменяет порядок этого массива.</param>
		/// <param name="value">Значение поля, используемое для нахождения соответствующего поля.</param>
		/// <param name="culture">Экземпляр класса <see cref="T:System.Globalization.CultureInfo" />, который используется для управления приведения типов данных в реализациях связывателя, выполняющих приведение типов. Если параметр <paramref name="culture" /> имеет значение <see langword="null" />, для текущего потока используется объект <see cref="T:System.Globalization.CultureInfo" />.  
		/// Примечание.   Например, если в реализации связывателя допускается приведение строкового типа к числовому, этот параметр необходим для преобразования значения типа <see langword="String" />, представляющего число 1000, в значение типа <see langword="Double" />, поскольку в разных языках и региональных параметрах значение 1000 представляется по-разному. Связыватель по умолчанию не выполняет подобного преобразования строковых типов.</param>
		/// <returns>Соответствующее поле.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">В связывателе по умолчанию параметр <paramref name="bindingAttr" /> содержит флаг <see cref="F:System.Reflection.BindingFlags.SetField" />, а параметр <paramref name="match" /> — несколько полей, в равной мере соответствующих параметру <paramref name="value" />. Например, параметр <paramref name="value" /> содержит объект MyClass, который реализует интерфейс IMyClass, а объект <paramref name="match" /> содержит поле типа MyClass и поле типа IMyClass.</exception>
		/// <exception cref="T:System.MissingFieldException">В связывателе по умолчанию параметр <paramref name="bindingAttr" /> содержит флаг <see cref="F:System.Reflection.BindingFlags.SetField" />, а параметр <paramref name="match" /> не содержит полей, которые могут принимать значение <paramref name="value" />.</exception>
		/// <exception cref="T:System.NullReferenceException">В связывателе по умолчанию параметр <paramref name="bindingAttr" /> содержит флаг <see cref="F:System.Reflection.BindingFlags.SetField" />, а параметр <paramref name="match" /> имеет значение <see langword="null" /> или является пустым массивом.  
		///
		/// или - 
		/// Параметр <paramref name="bindingAttr" /> содержит флаг <see cref="F:System.Reflection.BindingFlags.SetField" />, а параметр <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600487B RID: 18555
		public abstract FieldInfo BindToField(BindingFlags bindingAttr, FieldInfo[] match, object value, CultureInfo culture);

		/// <summary>Выбирает вызываемый метод из данного набора методов в зависимости от переданных аргументов.</summary>
		/// <param name="bindingAttr">Побитовое сочетание значений <see cref="T:System.Reflection.BindingFlags" />.</param>
		/// <param name="match">Набор методов, являющихся кандидатами для сопоставления. Например, если объект <see cref="T:System.Reflection.Binder" /> используется методом <see cref="Overload:System.Type.InvokeMember" />, этот параметр указывает набор методов, определенных в отражении как возможные соответствия, как правило в связи с тем, что они имеют правильное имя члена. Реализация по умолчанию, предоставленная свойством <see cref="P:System.Type.DefaultBinder" />, изменяет порядок этого массива.</param>
		/// <param name="args">Переданные аргументы. Связыватель может изменить порядок аргументов в этом массиве, например связыватель по умолчанию изменяет порядок аргументов в том случае, если этот порядок отличается от порядка по позиции аргументов и определяется параметром <paramref name="names" />. Если в реализации связывателя выполняется приведение типов аргументов, могут также изменяться типы и значения аргументов.</param>
		/// <param name="modifiers">Массив модификаторов параметров, позволяющий привязке работать с сигнатурами параметров, в которых были изменены типы. В реализации по умолчанию для связывателя этот параметр не используется.</param>
		/// <param name="culture">Экземпляр класса <see cref="T:System.Globalization.CultureInfo" />, который используется для управления приведения типов данных в реализациях связывателя, выполняющих приведение типов. Если параметр <paramref name="culture" /> имеет значение <see langword="null" />, для текущего потока используется объект <see cref="T:System.Globalization.CultureInfo" />.  
		/// Примечание.   Например, если в реализации связывателя допускается приведение строкового типа к числовому, этот параметр необходим для преобразования значения типа <see langword="String" />, представляющего число 1000, в значение типа <see langword="Double" />, поскольку в разных языках и региональных параметрах значение 1000 представляется по-разному. Связыватель по умолчанию не выполняет подобного преобразования строковых типов.</param>
		/// <param name="names">Имена параметров, если они должны учитываться при сопоставлении, либо значение <see langword="null" />, если аргументы должны считаться чисто позиционными. Например, необходимо использовать имена параметров в том случае, если аргументы не передаются в порядке по их позиции.</param>
		/// <param name="state">После возврата из этого метода параметр <paramref name="state" /> содержит предоставленный связывателем объект, который отслеживает изменение порядка аргументов. Связыватель создает этот объект и является его единственным объектом-получателем. Если параметр <paramref name="state" /> не равен <see langword="null" /> в результате возврата из метода <see langword="BindToMethod" />, необходимо передать параметр <paramref name="state" /> в метод <see cref="M:System.Reflection.Binder.ReorderArgumentArray(System.Object[]@,System.Object)" />, чтобы восстановить исходный порядок параметра <paramref name="args" />, например, с целью получить возможность извлекать значения параметров <see langword="ref" /> (в Visual Basic — параметров <see langword="ByRef" />).</param>
		/// <returns>Соответствующий метод.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">В связывателе по умолчанию параметр <paramref name="match" /> содержит несколько методов, которые являются соответствующими значениям параметра <paramref name="args" /> с одинаковой степенью соответствия. Например, параметр <paramref name="args" /> содержит объект MyClass, который реализует интерфейс IMyClass, а объект <paramref name="match" /> содержит метод, который принимает объект MyClass и метод, который принимает объект IMyClass.</exception>
		/// <exception cref="T:System.MissingMethodException">В связывателе по умолчанию параметр <paramref name="match" /> не содержит методов, которые могут принимать аргументы, переданные в параметре <paramref name="args" />.</exception>
		/// <exception cref="T:System.ArgumentException">В связывателе по умолчанию параметр <paramref name="match" /> имеет значение <see langword="null" /> или является пустым массивом.</exception>
		// Token: 0x0600487C RID: 18556
		public abstract MethodBase BindToMethod(BindingFlags bindingAttr, MethodBase[] match, ref object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] names, out object state);

		/// <summary>Меняет тип заданного <see langword="Object" /> на заданный <see langword="Type" />.</summary>
		/// <param name="value">Объект, для которого должен быть изменен параметр <see langword="Type" />.</param>
		/// <param name="type">Новый параметр <see langword="Type" />, к которому будет приведен параметр <paramref name="value" />.</param>
		/// <param name="culture">Экземпляр объекта <see cref="T:System.Globalization.CultureInfo" />, используемый для управления приведением типов данных. Если параметр <paramref name="culture" /> имеет значение <see langword="null" />, для текущего потока используется объект <see cref="T:System.Globalization.CultureInfo" />.  
		/// Примечание.  Например, этот параметр необходим для преобразования значения типа <see langword="String" />, представляющего число 1000, в значение типа <see langword="Double" />, поскольку в разных языках и региональных параметрах значение 1000 представляется по-разному.</param>
		/// <returns>Объект, содержащий заданное значение в качестве нового типа.</returns>
		// Token: 0x0600487D RID: 18557
		public abstract object ChangeType(object value, Type type, CultureInfo culture);

		/// <summary>При возвращении из <see cref="M:System.Reflection.Binder.BindToMethod(System.Reflection.BindingFlags,System.Reflection.MethodBase[],System.Object[]@,System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[],System.Object@)" /> приводит аргумент <paramref name="args" /> к виду, в котором он был передан из <see langword="BindToMethod" />.</summary>
		/// <param name="args">Фактически переданные аргументы. Допускается изменение как типов, так и значений этих аргументов.</param>
		/// <param name="state">Объект, предоставленный связывателем и отслеживающий изменение порядка аргументов.</param>
		// Token: 0x0600487E RID: 18558
		public abstract void ReorderArgumentArray(ref object[] args, object state);

		/// <summary>В зависимости от типа аргумента выбирает вызываемый метод из данного набора методов.</summary>
		/// <param name="bindingAttr">Побитовое сочетание значений <see cref="T:System.Reflection.BindingFlags" />.</param>
		/// <param name="match">Набор методов, являющихся кандидатами для сопоставления. Например, если объект <see cref="T:System.Reflection.Binder" /> используется методом <see cref="Overload:System.Type.InvokeMember" />, этот параметр указывает набор методов, определенных в отражении как возможные соответствия, как правило в связи с тем, что они имеют правильное имя члена. Реализация по умолчанию, предоставленная свойством <see cref="P:System.Type.DefaultBinder" />, изменяет порядок этого массива.</param>
		/// <param name="types">Типы параметров, используемые для нахождения соответствующего метода.</param>
		/// <param name="modifiers">Массив модификаторов параметров, позволяющий привязке работать с сигнатурами параметров, в которых были изменены типы.</param>
		/// <returns>Соответствующий метод, если таковой обнаружен; в обратном случае — значение <see langword="null" />.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">В связывателе по умолчанию параметр <paramref name="match" /> содержит несколько методов, которые являются соответствующими значениям типов параметров, определенных параметром <paramref name="types" />, с одинаковой степенью соответствия. Например, массив в параметре <paramref name="types" /> содержит объект <see cref="T:System.Type" /> для MyClass, а массив в параметре <paramref name="match" /> содержит метод, который принимает базовый класс объектов MyClass, а также метод, который принимает интерфейс, реализуемый классом MyClass.</exception>
		/// <exception cref="T:System.ArgumentException">В связывателе по умолчанию параметр <paramref name="match" /> имеет значение <see langword="null" /> или является пустым массивом.  
		///
		/// или - 
		/// Тип элемента параметра <paramref name="types" /> является производным от типа <see cref="T:System.Type" />, но не типом <see langword="RuntimeType" />.</exception>
		// Token: 0x0600487F RID: 18559
		public abstract MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, Type[] types, ParameterModifier[] modifiers);

		/// <summary>Выбирает свойство из заданного набора свойств в зависимости от заданных критериев.</summary>
		/// <param name="bindingAttr">Побитовое сочетание значений <see cref="T:System.Reflection.BindingFlags" />.</param>
		/// <param name="match">Набор свойств, являющихся кандидатами для сопоставления. Например, если объект <see cref="T:System.Reflection.Binder" /> используется методом <see cref="Overload:System.Type.InvokeMember" />, этот параметр указывает набор свойств, определенных в отражении как возможные соответствия, как правило в связи с тем, что они имеют правильное имя члена. Реализация по умолчанию, предоставленная свойством <see cref="P:System.Type.DefaultBinder" />, изменяет порядок этого массива.</param>
		/// <param name="returnType">Возвращаемое значение, которым должно обладать соответствующее свойство.</param>
		/// <param name="indexes">Типы индексов свойства, поиск которого выполняется. Используется для свойств индекса, например указателя для класса.</param>
		/// <param name="modifiers">Массив модификаторов параметров, позволяющий привязке работать с сигнатурами параметров, в которых были изменены типы.</param>
		/// <returns>Соответствующее свойство.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">В связывателе по умолчанию параметр <paramref name="match" /> содержит несколько свойств, которые одинаково хорошо соответствуют значениям параметров <paramref name="returnType" /> и <paramref name="indexes" />.</exception>
		/// <exception cref="T:System.ArgumentException">В связывателе по умолчанию параметр <paramref name="match" /> имеет значение <see langword="null" /> или является пустым массивом.</exception>
		// Token: 0x06004880 RID: 18560
		public abstract PropertyInfo SelectProperty(BindingFlags bindingAttr, PropertyInfo[] match, Type returnType, Type[] indexes, ParameterModifier[] modifiers);

		// Token: 0x06004881 RID: 18561 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public virtual bool CanChangeType(object value, Type type, CultureInfo culture)
		{
			return false;
		}
	}
}
