using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	/// <summary>Инкапсулирует объект <see cref="T:System.Type" /> и делегирует методы этому типу <see langword="Type" />.</summary>
	// Token: 0x020008CE RID: 2254
	public class TypeDelegator : TypeInfo
	{
		/// <summary>Возвращает значение, указывающее, можно ли назначить указанный тип данному типу.</summary>
		/// <param name="typeInfo">Проверяемый тип.</param>
		/// <returns>Значение <see langword="true" />, если указанный тип может быть присвоен этому типу; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004AF0 RID: 19184 RVA: 0x00057EED File Offset: 0x000560ED
		public override bool IsAssignableFrom(TypeInfo typeInfo)
		{
			return !(typeInfo == null) && this.IsAssignableFrom(typeInfo.AsType());
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.TypeDelegator" /> стандартными свойствами.</summary>
		// Token: 0x06004AF1 RID: 19185 RVA: 0x000EFE0F File Offset: 0x000EE00F
		protected TypeDelegator()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.TypeDelegator" />, задавая инкапсулирующий экземпляр.</summary>
		/// <param name="delegatingType">Экземпляр класса <see cref="T:System.Type" />, который инкапсулирует вызов метода объекта.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="delegatingType" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004AF2 RID: 19186 RVA: 0x000EFE17 File Offset: 0x000EE017
		public TypeDelegator(Type delegatingType)
		{
			if (delegatingType == null)
			{
				throw new ArgumentNullException("delegatingType");
			}
			this.typeImpl = delegatingType;
		}

		/// <summary>Возвращает GUID (глобальный идентификатор) реализуемого типа.</summary>
		/// <returns>Идентификатор GUID.</returns>
		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x06004AF3 RID: 19187 RVA: 0x000EFE3A File Offset: 0x000EE03A
		public override Guid GUID
		{
			get
			{
				return this.typeImpl.GUID;
			}
		}

		/// <summary>Возвращает значение, определяющее этот объект в метаданных.</summary>
		/// <returns>Свойство, которое в сочетании с модулем уникальным образом идентифицирует этот объект в метаданных.</returns>
		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x06004AF4 RID: 19188 RVA: 0x000EFE47 File Offset: 0x000EE047
		public override int MetadataToken
		{
			get
			{
				return this.typeImpl.MetadataToken;
			}
		}

		/// <summary>Вызывает указанный член. Вызываемый метод должен быть доступен и обеспечивать наиболее точное соответствие заданному списку аргументов с учетом ограничений заданного модуля привязки и атрибутов вызова.</summary>
		/// <param name="name">Имя вызываемого члена. Это может быть конструктор, метод, свойство или поле. Если передается пустая строка (""), вызывается стандартный член.</param>
		/// <param name="invokeAttr">Атрибут вызова. Атрибут должен быть одним из следующих флагов <see cref="T:System.Reflection.BindingFlags" />: <see langword="InvokeMethod" />, <see langword="CreateInstance" />, <see langword="Static" />, <see langword="GetField" />, <see langword="SetField" />, <see langword="GetProperty" /> или <see langword="SetProperty" />. Необходимо указать подходящий атрибут вызова. Для вызова статического члена должен быть установлен флаг <see langword="Static" />.</param>
		/// <param name="binder">Объект, позволяющий осуществлять привязку, приведение типов аргументов, вызов элементов, а также поиск объектов <see langword="MemberInfo" /> с помощью отражения. Если значение параметра <paramref name="binder" /> равно <see langword="null" />, используется связыватель по умолчанию. См. раздел <see cref="T:System.Reflection.Binder" />.</param>
		/// <param name="target">Объект, для которого следует вызвать указанный член.</param>
		/// <param name="args">Массив объектов типа <see langword="Object" />, содержащий число, последовательность и тип параметров, получаемых вызываемым методом. Если параметр <paramref name="args" /> содержит не инициализированный объект <see langword="Object" />, он обрабатывается как пустой и может быть преобразован стандартным связывателем в 0, 0,0 или строку.</param>
		/// <param name="modifiers">Массив типа <see langword="ParameterModifer" /> такой же длины, как и массив <paramref name="args" />, элементы которого представляют атрибуты, соответствующие параметрам вызываемого метода. С параметром связаны атрибуты в сигнатуре члена. Для параметра ByRef следует использовать параметр <see langword="ParameterModifer.ByRef" />, а при отсутствии параметра — параметр <see langword="ParameterModifer.None" />. Связыватель по умолчанию выбирает точное совпадение. Такие атрибуты, как <see langword="In" /> и <see langword="InOut" />, не используются в привязке и могут быть просмотрены с помощью свойства <see langword="ParameterInfo" />.</param>
		/// <param name="culture">Экземпляр объекта <see langword="CultureInfo" />, используемого для управления приведением типов. Он необходим, например, для преобразования строки, которая представляет число 1000, в значение типа <see langword="Double" />, поскольку в разных культурах 1000 может быть представлено по-разному. Если параметр <paramref name="culture" /> имеет значение <see langword="null" />, используется <see langword="CultureInfo" /> для <see langword="CultureInfo" /> текущего потока.</param>
		/// <param name="namedParameters">Массив объектов типа <see langword="String" />, содержащий имена параметров, совпадающие, начиная с нулевого элемента, с массивом <paramref name="args" />. В массиве не должно быть пустых элементов. Если <paramref name="args" />. Значение <see langword="Length" /> больше значения <paramref name="namedParameters" />. <see langword="Length" />, остальные параметры заполняются по порядку.</param>
		/// <returns>Объект <see langword="Object" />, представляющий значение, возвращаемое указанным членом.</returns>
		// Token: 0x06004AF5 RID: 19189 RVA: 0x000EFE54 File Offset: 0x000EE054
		public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
		{
			return this.typeImpl.InvokeMember(name, invokeAttr, binder, target, args, modifiers, culture, namedParameters);
		}

		/// <summary>Возвращает модуль, содержащий реализованный тип.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.Module" />, представляющий модуль реализованного типа.</returns>
		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x06004AF6 RID: 19190 RVA: 0x000EFE79 File Offset: 0x000EE079
		public override Module Module
		{
			get
			{
				return this.typeImpl.Module;
			}
		}

		/// <summary>Возвращает сборку реализуемого типа.</summary>
		/// <returns>Объект типа <see cref="T:System.Reflection.Assembly" />, представляющий сборку реализуемого типа.</returns>
		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x06004AF7 RID: 19191 RVA: 0x000EFE86 File Offset: 0x000EE086
		public override Assembly Assembly
		{
			get
			{
				return this.typeImpl.Assembly;
			}
		}

		/// <summary>Возвращает дескриптор представления внутренних метаданных реализуемого типа.</summary>
		/// <returns>Объект <see langword="RuntimeTypeHandle" />.</returns>
		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x06004AF8 RID: 19192 RVA: 0x000EFE93 File Offset: 0x000EE093
		public override RuntimeTypeHandle TypeHandle
		{
			get
			{
				return this.typeImpl.TypeHandle;
			}
		}

		/// <summary>Возвращает имя реализуемого типа с удалением пути.</summary>
		/// <returns>Строка <see langword="String" />, содержащая неполное имя типа.</returns>
		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x06004AF9 RID: 19193 RVA: 0x000EFEA0 File Offset: 0x000EE0A0
		public override string Name
		{
			get
			{
				return this.typeImpl.Name;
			}
		}

		/// <summary>Возвращает полное имя реализуемого типа.</summary>
		/// <returns>Строка <see langword="String" />, содержащая полное имя типа.</returns>
		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x06004AFA RID: 19194 RVA: 0x000EFEAD File Offset: 0x000EE0AD
		public override string FullName
		{
			get
			{
				return this.typeImpl.FullName;
			}
		}

		/// <summary>Возвращает пространство имен реализуемого типа.</summary>
		/// <returns>Строка <see langword="String" />, содержащая пространство имен типа.</returns>
		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x06004AFB RID: 19195 RVA: 0x000EFEBA File Offset: 0x000EE0BA
		public override string Namespace
		{
			get
			{
				return this.typeImpl.Namespace;
			}
		}

		/// <summary>Возвращает полное имя сборки.</summary>
		/// <returns>Строка <see langword="String" />, содержащая полное имя сборки.</returns>
		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x06004AFC RID: 19196 RVA: 0x000EFEC7 File Offset: 0x000EE0C7
		public override string AssemblyQualifiedName
		{
			get
			{
				return this.typeImpl.AssemblyQualifiedName;
			}
		}

		/// <summary>Возвращает базовый тип текущего типа.</summary>
		/// <returns>Базовый тип данного типа.</returns>
		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x06004AFD RID: 19197 RVA: 0x000EFED4 File Offset: 0x000EE0D4
		public override Type BaseType
		{
			get
			{
				return this.typeImpl.BaseType;
			}
		}

		/// <summary>Возвращает конструктор, при помощи которого был реализован объект <see langword="TypeDelegator" />.</summary>
		/// <param name="bindingAttr">Битовая маска, влияющая на способ выполнения поиска. Значение является сочетанием битовых флагов из перечисления <see cref="T:System.Reflection.BindingFlags" />.</param>
		/// <param name="binder">Объект, позволяющий осуществлять привязку, приведение типов аргументов, вызов элементов, а также поиск объектов <see langword="MemberInfo" /> с помощью отражения. Если значение параметра <paramref name="binder" /> равно <see langword="null" />, используется связыватель по умолчанию.</param>
		/// <param name="callConvention">Соглашения о вызовах.</param>
		/// <param name="types">Массив объектов типа <see langword="Type" />, содержащий число, порядок и типы параметров. Типы не могут иметь значение <see langword="null" />; для поиска метода без параметров следует использовать соответствующий метод <see langword="GetMethod" /> или пустой массив.</param>
		/// <param name="modifiers">Массив типа <see langword="ParameterModifier" />, имеющий такую же длину, как и массив <paramref name="types" />, элементы которого представляют атрибуты, соответствующие параметрам получаемого метода.</param>
		/// <returns>Объект <see langword="ConstructorInfo" /> для метода, который соответствует заданным критериям, или значение <see langword="null" />, если совпадение не найдено.</returns>
		// Token: 0x06004AFE RID: 19198 RVA: 0x000EFEE1 File Offset: 0x000EE0E1
		protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			return this.typeImpl.GetConstructor(bindingAttr, binder, callConvention, types, modifiers);
		}

		/// <summary>Возвращает массив объектов <see cref="T:System.Reflection.ConstructorInfo" />, представляющих конструкторы, определенные для типа, который инкапсулируется в текущем типе <see cref="T:System.Reflection.TypeDelegator" />.</summary>
		/// <param name="bindingAttr">Битовая маска, влияющая на способ выполнения поиска. Значение является сочетанием битовых флагов из перечисления <see cref="T:System.Reflection.BindingFlags" />.</param>
		/// <returns>Массив объектов типа <see langword="ConstructorInfo" />, содержащий заданные конструкторы, определенные для этого класса. Если конструкторы не определены, возвращается пустой массив. В зависимости от значения заданного параметра возвращаются только открытые конструкторы либо как открытые, так и закрытые конструкторы.</returns>
		// Token: 0x06004AFF RID: 19199 RVA: 0x000EFEF5 File Offset: 0x000EE0F5
		[ComVisible(true)]
		public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
		{
			return this.typeImpl.GetConstructors(bindingAttr);
		}

		/// <summary>Ищет метод с параметрами, соответствующими указанным модификаторам и типам аргументов, с учетом заданных ограничений привязки и соглашений о вызовах.</summary>
		/// <param name="name">Имя метода.</param>
		/// <param name="bindingAttr">Битовая маска, влияющая на способ выполнения поиска. Значение является сочетанием битовых флагов из перечисления <see cref="T:System.Reflection.BindingFlags" />.</param>
		/// <param name="binder">Объект, позволяющий осуществлять привязку, приведение типов аргументов, вызов элементов, а также поиск объектов <see langword="MemberInfo" /> с помощью отражения. Если значение параметра <paramref name="binder" /> равно <see langword="null" />, используется связыватель по умолчанию.</param>
		/// <param name="callConvention">Соглашения о вызовах.</param>
		/// <param name="types">Массив объектов типа <see langword="Type" />, содержащий число, порядок и типы параметров. Типы не могут иметь значение <see langword="null" />; для поиска метода без параметров следует использовать соответствующий метод <see langword="GetMethod" /> или пустой массив.</param>
		/// <param name="modifiers">Массив типа <see langword="ParameterModifier" />, имеющий такую же длину, как и массив <paramref name="types" />, элементы которого представляют атрибуты, соответствующие параметрам получаемого метода.</param>
		/// <returns>Объект <see langword="MethodInfoInfo" /> для реализации метода, который соответствует заданным критериям, или значение <see langword="null" />, если совпадение не найдено.</returns>
		// Token: 0x06004B00 RID: 19200 RVA: 0x000EFF03 File Offset: 0x000EE103
		protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			if (types == null)
			{
				return this.typeImpl.GetMethod(name, bindingAttr);
			}
			return this.typeImpl.GetMethod(name, bindingAttr, binder, callConvention, types, modifiers);
		}

		/// <summary>Возвращает массив объектов <see cref="T:System.Reflection.MethodInfo" />, представляющих заданные методы типа, который инкапсулируется в текущем типе <see cref="T:System.Reflection.TypeDelegator" />.</summary>
		/// <param name="bindingAttr">Битовая маска, влияющая на способ выполнения поиска. Значение является сочетанием битовых флагов из перечисления <see cref="T:System.Reflection.BindingFlags" />.</param>
		/// <returns>Массив объектов <see langword="MethodInfo" />, представляющих методы, определенные для данного объекта <see langword="TypeDelegator" />.</returns>
		// Token: 0x06004B01 RID: 19201 RVA: 0x000EFF2B File Offset: 0x000EE12B
		public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
		{
			return this.typeImpl.GetMethods(bindingAttr);
		}

		/// <summary>Возвращает объект <see cref="T:System.Reflection.FieldInfo" />, представляющий поле с заданным именем.</summary>
		/// <param name="name">Имя искомого поля.</param>
		/// <param name="bindingAttr">Битовая маска, влияющая на способ выполнения поиска. Значение является сочетанием битовых флагов из перечисления <see cref="T:System.Reflection.BindingFlags" />.</param>
		/// <returns>Объект <see langword="FieldInfo" />, представляющий поле, объявленное или унаследованное этим объектом <see langword="TypeDelegator" /> с заданным именем. Если такое поле не найдено, возвращается значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004B02 RID: 19202 RVA: 0x000EFF39 File Offset: 0x000EE139
		public override FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			return this.typeImpl.GetField(name, bindingAttr);
		}

		/// <summary>Возвращает массив объектов <see cref="T:System.Reflection.FieldInfo" />, представляющих поля данных, определенные для типа, который инкапсулируется в текущем типе <see cref="T:System.Reflection.TypeDelegator" />.</summary>
		/// <param name="bindingAttr">Битовая маска, влияющая на способ выполнения поиска. Значение является сочетанием битовых флагов из перечисления <see cref="T:System.Reflection.BindingFlags" />.</param>
		/// <returns>Массив объектов типа <see langword="FieldInfo" />, представляющих поля, объявленные или унаследованные текущим объектом <see langword="TypeDelegator" />. Если совпадающие поля отсутствуют, возвращается пустой массив.</returns>
		// Token: 0x06004B03 RID: 19203 RVA: 0x000EFF48 File Offset: 0x000EE148
		public override FieldInfo[] GetFields(BindingFlags bindingAttr)
		{
			return this.typeImpl.GetFields(bindingAttr);
		}

		/// <summary>Возвращает заданный интерфейс, реализованный типом, инкапсулированным в текущем классе <see cref="T:System.Reflection.TypeDelegator" />.</summary>
		/// <param name="name">Полное имя интерфейса, реализованного в текущем классе.</param>
		/// <param name="ignoreCase">Значение <see langword="true" />, если регистр не должен учитываться; в обратном случае — значение <see langword="false" />.</param>
		/// <returns>Объект <see langword="Type" />, представляющий интерфейс, явно или косвенно реализованный в текущем классе, с полным именем, соответствующим заданному имени. Если интерфейс с совпадающим именем не найден, возвращается пустое значение.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004B04 RID: 19204 RVA: 0x000EFF56 File Offset: 0x000EE156
		public override Type GetInterface(string name, bool ignoreCase)
		{
			return this.typeImpl.GetInterface(name, ignoreCase);
		}

		/// <summary>Возвращает все интерфейсы, реализованные в текущем классе и его базовых классах.</summary>
		/// <returns>Массив объектов типа <see langword="Type" />, содержащий все интерфейсы, реализованные в текущем классе и его базовых классах. Если они не определены, возвращается пустой массив.</returns>
		// Token: 0x06004B05 RID: 19205 RVA: 0x000EFF65 File Offset: 0x000EE165
		public override Type[] GetInterfaces()
		{
			return this.typeImpl.GetInterfaces();
		}

		/// <summary>Возвращает заданное событие.</summary>
		/// <param name="name">Имя возвращаемого события.</param>
		/// <param name="bindingAttr">Битовая маска, влияющая на способ выполнения поиска. Значение является сочетанием битовых флагов из перечисления <see cref="T:System.Reflection.BindingFlags" />.</param>
		/// <returns>Объект <see cref="T:System.Reflection.EventInfo" />, представляющий событие, объявленное или унаследованное этим типом с заданным именем. Если такое событие не найдено, метод возвращает значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004B06 RID: 19206 RVA: 0x000EFF72 File Offset: 0x000EE172
		public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
		{
			return this.typeImpl.GetEvent(name, bindingAttr);
		}

		/// <summary>Возвращает массив объектов типа <see cref="T:System.Reflection.EventInfo" />, представляющих все открытые события, объявленные или унаследованные текущим объектом <see langword="TypeDelegator" />.</summary>
		/// <returns>Массив, который содержит все события, объявленные или унаследованные текущим типом. Если события отсутствуют, возвращается пустой массив.</returns>
		// Token: 0x06004B07 RID: 19207 RVA: 0x000EFF81 File Offset: 0x000EE181
		public override EventInfo[] GetEvents()
		{
			return this.typeImpl.GetEvents();
		}

		/// <summary>При переопределении в производном классе выполняет поиск заданного свойства, параметры которого соответствуют типам и модификаторам заданных аргументов, с использованием заданных ограничений привязки.</summary>
		/// <param name="name">Возвращаемое свойство.</param>
		/// <param name="bindingAttr">Битовая маска, влияющая на способ выполнения поиска. Значение является сочетанием битовых флагов из перечисления <see cref="T:System.Reflection.BindingFlags" />.</param>
		/// <param name="binder">Объект, позволяющий осуществлять привязку, приведение типов аргументов, вызов элементов, а также поиск объектов <see langword="MemberInfo" /> с помощью отражения. Если значение параметра <paramref name="binder" /> равно <see langword="null" />, используется связыватель по умолчанию. См. раздел <see cref="T:System.Reflection.Binder" />.</param>
		/// <param name="returnType">Тип возвращаемого значения свойства.</param>
		/// <param name="types">Список типов параметров. В списке представлено количество, порядок и типы параметров. Типы не могут иметь значение "null"; для поиска метода без параметров следует использовать соответствующий метод <see langword="GetMethod" /> или пустой массив.</param>
		/// <param name="modifiers">Массив такой же длины, что и типы, элементы которых представляют атрибуты, сопоставленные параметрам получаемого метода.</param>
		/// <returns>Объект <see cref="T:System.Reflection.PropertyInfo" /> для свойства, которое соответствует заданным критериям, или пустое значение, если совпадение не найдено.</returns>
		// Token: 0x06004B08 RID: 19208 RVA: 0x000EFF8E File Offset: 0x000EE18E
		protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
		{
			if (returnType == null && types == null)
			{
				return this.typeImpl.GetProperty(name, bindingAttr);
			}
			return this.typeImpl.GetProperty(name, bindingAttr, binder, returnType, types, modifiers);
		}

		/// <summary>Возвращает массив объектов <see cref="T:System.Reflection.PropertyInfo" />, представляющих заданные свойства типа, который инкапсулируется в текущем типе <see cref="T:System.Reflection.TypeDelegator" />.</summary>
		/// <param name="bindingAttr">Битовая маска, влияющая на способ выполнения поиска. Значение является сочетанием битовых флагов из перечисления <see cref="T:System.Reflection.BindingFlags" />.</param>
		/// <returns>Массив объектов <see langword="PropertyInfo" />, представляющих свойства, определенные для данного объекта <see langword="TypeDelegator" />.</returns>
		// Token: 0x06004B09 RID: 19209 RVA: 0x000EFFC0 File Offset: 0x000EE1C0
		public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
		{
			return this.typeImpl.GetProperties(bindingAttr);
		}

		/// <summary>Возвращает события, заданные параметром <paramref name="bindingAttr" /> и объявленные или унаследованные текущим объектом <see langword="TypeDelegator" />.</summary>
		/// <param name="bindingAttr">Битовая маска, влияющая на способ выполнения поиска. Значение является сочетанием битовых флагов из перечисления <see cref="T:System.Reflection.BindingFlags" />.</param>
		/// <returns>Массив объектов типа <see langword="EventInfo" />, содержащий события, заданные параметром <paramref name="bindingAttr" />. Если события отсутствуют, возвращается пустой массив.</returns>
		// Token: 0x06004B0A RID: 19210 RVA: 0x000EFFCE File Offset: 0x000EE1CE
		public override EventInfo[] GetEvents(BindingFlags bindingAttr)
		{
			return this.typeImpl.GetEvents(bindingAttr);
		}

		/// <summary>Возвращает вложенные типы, заданные параметром <paramref name="bindingAttr" />, которые объявлены или унаследованы типом, инкапсулированным в текущем объекте <see cref="T:System.Reflection.TypeDelegator" />.</summary>
		/// <param name="bindingAttr">Битовая маска, влияющая на способ выполнения поиска. Значение является сочетанием битовых флагов из перечисления <see cref="T:System.Reflection.BindingFlags" />.</param>
		/// <returns>Массив объектов типа <see langword="Type" />, содержащих вложенные типы.</returns>
		// Token: 0x06004B0B RID: 19211 RVA: 0x000EFFDC File Offset: 0x000EE1DC
		public override Type[] GetNestedTypes(BindingFlags bindingAttr)
		{
			return this.typeImpl.GetNestedTypes(bindingAttr);
		}

		/// <summary>Возвращает вложенный тип, заданный параметрами <paramref name="name" /> и <paramref name="bindingAttr" />, которые объявлены или унаследованы типом, представленным текущим объектом <see cref="T:System.Reflection.TypeDelegator" />.</summary>
		/// <param name="name">Имя вложенного типа.</param>
		/// <param name="bindingAttr">Битовая маска, влияющая на способ выполнения поиска. Значение является сочетанием битовых флагов из перечисления <see cref="T:System.Reflection.BindingFlags" />.</param>
		/// <returns>Объект типа <see langword="Type" />, представляющий вложенный тип.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004B0C RID: 19212 RVA: 0x000EFFEA File Offset: 0x000EE1EA
		public override Type GetNestedType(string name, BindingFlags bindingAttr)
		{
			return this.typeImpl.GetNestedType(name, bindingAttr);
		}

		/// <summary>Возвращает члены (свойства, методы, конструкторы, поля, события и вложенные типы), задаваемые параметрами <paramref name="name" />, <paramref name="type" /> и <paramref name="bindingAttr" />.</summary>
		/// <param name="name">Имя возвращаемого члена.</param>
		/// <param name="type">Битовая маска, влияющая на способ выполнения поиска. Значение является сочетанием битовых флагов из перечисления <see cref="T:System.Reflection.BindingFlags" />.</param>
		/// <param name="bindingAttr">Тип возвращаемого члена.</param>
		/// <returns>Массив объектов типа <see langword="MemberInfo" />, содержащий все члены текущего и его базовых классов, удовлетворяющие заданным критериям.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004B0D RID: 19213 RVA: 0x000EFFF9 File Offset: 0x000EE1F9
		public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
		{
			return this.typeImpl.GetMember(name, type, bindingAttr);
		}

		/// <summary>Возвращает члены, заданные параметром <paramref name="bindingAttr" />.</summary>
		/// <param name="bindingAttr">Битовая маска, влияющая на способ выполнения поиска. Значение является сочетанием битовых флагов из перечисления <see cref="T:System.Reflection.BindingFlags" />.</param>
		/// <returns>Массив объектов типа <see langword="MemberInfo" />, содержащий все члены текущего класса и его базовых классов, удовлетворяющие условиям фильтра <paramref name="bindingAttr" />.</returns>
		// Token: 0x06004B0E RID: 19214 RVA: 0x000F0009 File Offset: 0x000EE209
		public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
		{
			return this.typeImpl.GetMembers(bindingAttr);
		}

		/// <summary>Получает атрибуты, присвоенные объекту <see langword="TypeDelegator" />.</summary>
		/// <returns>Объект <see langword="TypeAttributes" />, представляющий флаги атрибутов реализации.</returns>
		// Token: 0x06004B0F RID: 19215 RVA: 0x000F0017 File Offset: 0x000EE217
		protected override TypeAttributes GetAttributeFlagsImpl()
		{
			return this.typeImpl.Attributes;
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x06004B10 RID: 19216 RVA: 0x000F0024 File Offset: 0x000EE224
		public override bool IsTypeDefinition
		{
			get
			{
				return this.typeImpl.IsTypeDefinition;
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x06004B11 RID: 19217 RVA: 0x000F0031 File Offset: 0x000EE231
		public override bool IsSZArray
		{
			get
			{
				return this.typeImpl.IsSZArray;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли <see cref="T:System.Type" /> массивом.</summary>
		/// <returns>Значение <see langword="true" />, если <see cref="T:System.Type" /> является массивом; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004B12 RID: 19218 RVA: 0x000F003E File Offset: 0x000EE23E
		protected override bool IsArrayImpl()
		{
			return this.typeImpl.IsArray;
		}

		/// <summary>Возвращает значение, указывающее, является ли <see cref="T:System.Type" /> одним из типов-примитивов.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> является одним из типов-примитивов; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004B13 RID: 19219 RVA: 0x000F004B File Offset: 0x000EE24B
		protected override bool IsPrimitiveImpl()
		{
			return this.typeImpl.IsPrimitive;
		}

		/// <summary>Возвращает значение, показывающее, передан ли <see cref="T:System.Type" /> по ссылке.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> передан по ссылке; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004B14 RID: 19220 RVA: 0x000F0058 File Offset: 0x000EE258
		protected override bool IsByRefImpl()
		{
			return this.typeImpl.IsByRef;
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x06004B15 RID: 19221 RVA: 0x000F0065 File Offset: 0x000EE265
		public override bool IsGenericTypeParameter
		{
			get
			{
				return this.typeImpl.IsGenericTypeParameter;
			}
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x06004B16 RID: 19222 RVA: 0x000F0072 File Offset: 0x000EE272
		public override bool IsGenericMethodParameter
		{
			get
			{
				return this.typeImpl.IsGenericMethodParameter;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли <see cref="T:System.Type" /> указателем.</summary>
		/// <returns>Значение <see langword="true" />, если <see cref="T:System.Type" /> является указателем; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004B17 RID: 19223 RVA: 0x000F007F File Offset: 0x000EE27F
		protected override bool IsPointerImpl()
		{
			return this.typeImpl.IsPointer;
		}

		/// <summary>Возвращает значение, указывающее, является ли данный тип типом значения, то есть, не классом и не интерфейсом.</summary>
		/// <returns>Значение <see langword="true" />, если тип является типом значения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004B18 RID: 19224 RVA: 0x000F008C File Offset: 0x000EE28C
		protected override bool IsValueTypeImpl()
		{
			return this.typeImpl.IsValueType;
		}

		/// <summary>Возвращает значение, указывающее, является ли <see cref="T:System.Type" /> объектом COM.</summary>
		/// <returns>Значение <see langword="true" />, если <see cref="T:System.Type" /> является COM-объектом, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004B19 RID: 19225 RVA: 0x000F0099 File Offset: 0x000EE299
		protected override bool IsCOMObjectImpl()
		{
			return this.typeImpl.IsCOMObject;
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x06004B1A RID: 19226 RVA: 0x000F00A6 File Offset: 0x000EE2A6
		public override bool IsByRefLike
		{
			get
			{
				return this.typeImpl.IsByRefLike;
			}
		}

		/// <summary>Возвращает значение, указывающее, представляет ли этот данный объект сконструированный универсальный тип.</summary>
		/// <returns>Значение <see langword="true" />, если этот объект представляет сконструированный универсальный тип; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x06004B1B RID: 19227 RVA: 0x000F00B3 File Offset: 0x000EE2B3
		public override bool IsConstructedGenericType
		{
			get
			{
				return this.typeImpl.IsConstructedGenericType;
			}
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x06004B1C RID: 19228 RVA: 0x000F00C0 File Offset: 0x000EE2C0
		public override bool IsCollectible
		{
			get
			{
				return this.typeImpl.IsCollectible;
			}
		}

		/// <summary>Возвращает тип <see cref="T:System.Type" /> объекта, используемого или упоминаемого в текущем массиве, указателе или параметре ByRef.</summary>
		/// <returns>Тип <see cref="T:System.Type" /> объекта, используемого или упоминаемого в текущем массиве, указателе или параметре <see langword="ByRef" /> или значение <see langword="null" />, если текущий тип <see cref="T:System.Type" /> не является массивом, указателем или параметром <see langword="ByRef" />.</returns>
		// Token: 0x06004B1D RID: 19229 RVA: 0x000F00CD File Offset: 0x000EE2CD
		public override Type GetElementType()
		{
			return this.typeImpl.GetElementType();
		}

		/// <summary>Возвращает значение, указывающее, использует или обращается ли текущий тип <see cref="T:System.Type" /> к другому типу; другими словами, является ли текущий тип <see cref="T:System.Type" /> массивом, указателем или параметром ByRef.</summary>
		/// <returns>Значение <see langword="true" />, если тип <see cref="T:System.Type" /> является массивом, указателем или параметром ByRef; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004B1E RID: 19230 RVA: 0x000F00DA File Offset: 0x000EE2DA
		protected override bool HasElementTypeImpl()
		{
			return this.typeImpl.HasElementType;
		}

		/// <summary>Возвращает базовый класс <see cref="T:System.Type" />, который представляет реализуемый тип.</summary>
		/// <returns>Базовый тип.</returns>
		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x06004B1F RID: 19231 RVA: 0x000F00E7 File Offset: 0x000EE2E7
		public override Type UnderlyingSystemType
		{
			get
			{
				return this.typeImpl.UnderlyingSystemType;
			}
		}

		/// <summary>Возвращает все пользовательские атрибуты, определенные для этого типа, а также определяет, должна ли быть просмотрена цепочка наследования данного типа.</summary>
		/// <param name="inherit">Указывает, что необходимо просмотреть цепочку наследования этого типа для поиска данных атрибутов.</param>
		/// <returns>Массив объектов, содержащих все пользовательские атрибуты, определенные для этого типа.</returns>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x06004B20 RID: 19232 RVA: 0x000F00F4 File Offset: 0x000EE2F4
		public override object[] GetCustomAttributes(bool inherit)
		{
			return this.typeImpl.GetCustomAttributes(inherit);
		}

		/// <summary>Возвращает массив пользовательских атрибутов, отбираемых по типу.</summary>
		/// <param name="attributeType">Массив пользовательских атрибутов, идентифицируемых типом.</param>
		/// <param name="inherit">Указывает, что необходимо просмотреть цепочку наследования этого типа для поиска данных атрибутов.</param>
		/// <returns>Массив объектов, содержащих пользовательские атрибуты, определенные в этом типе, которые соответствуют параметру <paramref name="attributeType" />, задающему необходимость просмотра иерархии наследования типа, либо значение <see langword="null" />, если пользовательские атрибуты для этого типа не определены.</returns>
		/// <exception cref="T:System.ArgumentException">Свойство <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x06004B21 RID: 19233 RVA: 0x000F0102 File Offset: 0x000EE302
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return this.typeImpl.GetCustomAttributes(attributeType, inherit);
		}

		/// <summary>Указывает, определен ли пользовательский атрибут, заданный параметром <paramref name="attributeType" />.</summary>
		/// <param name="attributeType">Указывает, что необходимо просмотреть цепочку наследования этого типа для поиска данных атрибутов.</param>
		/// <param name="inherit">Массив пользовательских атрибутов, идентифицируемых типом.</param>
		/// <returns>Значение <see langword="true" />, если пользовательский атрибут, заданный параметром <paramref name="attributeType" />, определен; в обратном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Свойство <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Reflection.ReflectionTypeLoadException">Невозможно загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x06004B22 RID: 19234 RVA: 0x000F0111 File Offset: 0x000EE311
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return this.typeImpl.IsDefined(attributeType, inherit);
		}

		/// <summary>Возвращает сопоставление для интерфейса заданного типа.</summary>
		/// <param name="interfaceType">Тип <see cref="T:System.Type" /> интерфейса предназначен для извлечения сопоставления.</param>
		/// <returns>Объект <see cref="T:System.Reflection.InterfaceMapping" />, который представляет сопоставление интерфейса для параметра <paramref name="interfaceType" />.</returns>
		// Token: 0x06004B23 RID: 19235 RVA: 0x000F0120 File Offset: 0x000EE320
		[ComVisible(true)]
		public override InterfaceMapping GetInterfaceMap(Type interfaceType)
		{
			return this.typeImpl.GetInterfaceMap(interfaceType);
		}

		/// <summary>Значение, содержащее сведения о типе.</summary>
		// Token: 0x04002F56 RID: 12118
		protected Type typeImpl;
	}
}
