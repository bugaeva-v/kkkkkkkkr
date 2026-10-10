using System;
using System.Globalization;
using System.Runtime.InteropServices;
using Unity;

namespace System.Reflection.Emit
{
	/// <summary>Определяет свойства для типа.</summary>
	// Token: 0x02000940 RID: 2368
	[ComDefaultInterface(typeof(_PropertyBuilder))]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class PropertyBuilder : PropertyInfo, _PropertyBuilder
	{
		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Переданный массив имен, которые необходимо сопоставить.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, зарезервированный вызывающим объектом, куда помещаются идентификаторы, соответствующие именам.</param>
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x06005217 RID: 21015 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _PropertyBuilder.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает сведения о типе объекта, которые затем могут использоваться для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Получает указатель на объект с запрошенными сведениями о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x06005218 RID: 21016 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _PropertyBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Указатель, по которому записывается число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x06005219 RID: 21017 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _PropertyBuilder.GetTypeInfoCount(out uint pcTInfo)
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
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x0600521A RID: 21018 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _PropertyBuilder.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600521B RID: 21019 RVA: 0x00102478 File Offset: 0x00100678
		internal PropertyBuilder(TypeBuilder tb, string name, PropertyAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnModReq, Type[] returnModOpt, Type[] parameterTypes, Type[][] paramModReq, Type[][] paramModOpt)
		{
			this.name = name;
			this.attrs = attributes;
			this.callingConvention = callingConvention;
			this.type = returnType;
			this.returnModReq = returnModReq;
			this.returnModOpt = returnModOpt;
			this.paramModReq = paramModReq;
			this.paramModOpt = paramModOpt;
			if (parameterTypes != null)
			{
				this.parameters = new Type[parameterTypes.Length];
				Array.Copy(parameterTypes, this.parameters, this.parameters.Length);
			}
			this.typeb = tb;
			this.table_idx = tb.get_next_table_index(this, 23, 1);
		}

		/// <summary>Получает атрибуты данного свойства.</summary>
		/// <returns>Атрибуты данного свойства.</returns>
		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x0600521C RID: 21020 RVA: 0x00102508 File Offset: 0x00100708
		public override PropertyAttributes Attributes
		{
			get
			{
				return this.attrs;
			}
		}

		/// <summary>Получает значение, указывающее, можно ли выполнить считывание данного свойства.</summary>
		/// <returns>Значение <see langword="true" />, если свойство доступно для чтения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x0600521D RID: 21021 RVA: 0x00102510 File Offset: 0x00100710
		public override bool CanRead
		{
			get
			{
				return this.get_method != null;
			}
		}

		/// <summary>Получает значение, указывающее, можно ли производить запись в данное свойство.</summary>
		/// <returns>Значение <see langword="true" />, если свойство доступно для записи; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x0600521E RID: 21022 RVA: 0x0010251E File Offset: 0x0010071E
		public override bool CanWrite
		{
			get
			{
				return this.set_method != null;
			}
		}

		/// <summary>Получает класс, объявляющий этот член.</summary>
		/// <returns>Объект <see langword="Type" /> для класса, объявляющего данный член.</returns>
		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x0600521F RID: 21023 RVA: 0x0010252C File Offset: 0x0010072C
		public override Type DeclaringType
		{
			get
			{
				return this.typeb;
			}
		}

		/// <summary>Возвращает имя данного элемента.</summary>
		/// <returns>Объект <see cref="T:System.String" />, содержащий имя данного элемента.</returns>
		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x06005220 RID: 21024 RVA: 0x00102534 File Offset: 0x00100734
		public override string Name
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Извлекает маркер данного свойства.</summary>
		/// <returns>Только для чтения. Извлекает маркер данного свойства.</returns>
		// Token: 0x17000D98 RID: 3480
		// (get) Token: 0x06005221 RID: 21025 RVA: 0x0010253C File Offset: 0x0010073C
		public PropertyToken PropertyToken
		{
			get
			{
				return default(PropertyToken);
			}
		}

		/// <summary>Возвращает тип поля данного свойства.</summary>
		/// <returns>Тип этого свойства.</returns>
		// Token: 0x17000D99 RID: 3481
		// (get) Token: 0x06005222 RID: 21026 RVA: 0x00102552 File Offset: 0x00100752
		public override Type PropertyType
		{
			get
			{
				return this.type;
			}
		}

		/// <summary>Получает объект класса, который использовался для извлечения данного экземпляра объекта <see langword="MemberInfo" />.</summary>
		/// <returns>Объект <see langword="Type" />, с помощью которого был получен данный объект <see langword="MemberInfo" />.</returns>
		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x06005223 RID: 21027 RVA: 0x0010252C File Offset: 0x0010072C
		public override Type ReflectedType
		{
			get
			{
				return this.typeb;
			}
		}

		/// <summary>Добавляет один из дополнительных методов, связанных с данным свойством.</summary>
		/// <param name="mdBuilder">Объект <see langword="MethodBuilder" />, представляющий "дополнительный" метод.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="mdBuilder" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> был вызван для включающего типа.</exception>
		// Token: 0x06005224 RID: 21028 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public void AddOtherMethod(MethodBuilder mdBuilder)
		{
		}

		/// <summary>Возвращает массив открытых и неоткрытых методов доступа <see langword="get" /> и <see langword="set" /> данного свойства.</summary>
		/// <param name="nonPublic">Указывает, должны ли в массиве элементов <see langword="MethodInfo" /> возвращаться методы, не являющиеся открытыми. <see langword="true" />, если неоткрытые методы должны быть включены; в противном случае — <see langword="false" />.</param>
		/// <returns>Массив элементов типа <see langword="MethodInfo" />, содержащий соответствующие открытые и неоткрытые методы доступа или пустой массив, если у данного свойства методы доступа отсутствуют.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод не поддерживается.</exception>
		// Token: 0x06005225 RID: 21029 RVA: 0x0000AF5E File Offset: 0x0000915E
		public override MethodInfo[] GetAccessors(bool nonPublic)
		{
			return null;
		}

		/// <summary>Возвращает массив, содержащий все пользовательские атрибуты данного свойства.</summary>
		/// <param name="inherit">Если этот параметр равен <see langword="true" />, для поиска пользовательских атрибутов просматривается цепочка наследования данного свойства.</param>
		/// <returns>Массив, содержащий все пользовательские атрибуты.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод не поддерживается.</exception>
		// Token: 0x06005226 RID: 21030 RVA: 0x0010255A File Offset: 0x0010075A
		public override object[] GetCustomAttributes(bool inherit)
		{
			throw this.not_supported();
		}

		/// <summary>Возвращает массив пользовательских атрибутов, идентифицируемых типом <see cref="T:System.Type" />.</summary>
		/// <param name="attributeType">Массив пользовательских атрибутов, идентифицируемых типом.</param>
		/// <param name="inherit">Если этот параметр равен <see langword="true" />, для поиска пользовательских атрибутов просматривается цепочка наследования данного свойства.</param>
		/// <returns>Массив пользовательских атрибутов, определенных для данного отраженного элемента или <see langword="null" />, если ни одного атрибута для данного элемента не определено.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод не поддерживается.</exception>
		// Token: 0x06005227 RID: 21031 RVA: 0x0010255A File Offset: 0x0010075A
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			throw this.not_supported();
		}

		/// <summary>Возвращает открытый и неоткрытый метод доступа get данного свойства.</summary>
		/// <param name="nonPublic">Указывает, должны ли возвращаться методы доступа get, не являющиеся открытыми. <see langword="true" />, если неоткрытые методы должны быть включены; в противном случае — <see langword="false" />.</param>
		/// <returns>Если параметр <paramref name="nonPublic" /> равен <see langword="MethodInfo" />, возвращается объект <see langword="true" />, предоставляющий метод доступа get данного свойства. Если параметр <paramref name="nonPublic" /> равен <see langword="null" /> и метод доступа get является неоткрытым, или параметр <paramref name="nonPublic" /> равен <see langword="false" />, но метод доступа get отсутствует, возвращается <see langword="true" />.</returns>
		// Token: 0x06005228 RID: 21032 RVA: 0x00102562 File Offset: 0x00100762
		public override MethodInfo GetGetMethod(bool nonPublic)
		{
			return this.get_method;
		}

		/// <summary>Возвращает массив, содержащий все индексные параметры данного свойства.</summary>
		/// <returns>Массив элементов типа <see langword="ParameterInfo" />, содержащий параметры для индексов.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод не поддерживается.</exception>
		// Token: 0x06005229 RID: 21033 RVA: 0x0010255A File Offset: 0x0010075A
		public override ParameterInfo[] GetIndexParameters()
		{
			throw this.not_supported();
		}

		/// <summary>Возвращает метод доступа для этого свойства.</summary>
		/// <param name="nonPublic">Указывает, должен ли возвращаться метод доступа, если он не является открытым. <see langword="true" />, если неоткрытые методы должны быть включены; в противном случае — <see langword="false" />.</param>
		/// <returns>Метод свойства <see langword="Set" /> или <see langword="null" />, как показано в следующей таблице.  
		///   Значение 
		///   Условие 
		///   Объект <see cref="T:System.Reflection.MethodInfo" />, который предоставляет метод Set для этого свойства.  
		///
		///   Метод доступа является открытым.  
		///
		///  <paramref name="nonPublic" /> имеет значение True, а закрытые методы могут быть возвращены.  
		///
		///   null 
		///  <paramref name="nonPublic" /> имеет значение True, но свойство доступно только для чтения.  
		///
		///  <paramref name="nonPublic" /> имеет значение False, а метод доступа не является открытым.</returns>
		// Token: 0x0600522A RID: 21034 RVA: 0x0010256A File Offset: 0x0010076A
		public override MethodInfo GetSetMethod(bool nonPublic)
		{
			return this.set_method;
		}

		/// <summary>Получает значение индексированного свойства через вызов метода чтения данного свойства.</summary>
		/// <param name="obj">Объект, свойство которого будет возвращено.</param>
		/// <param name="index">Необязательные значения индекса для индексированных свойств. Для неиндексированных свойств это значение должно быть равно <see langword="null" />.</param>
		/// <returns>Значение указанного индексированного свойства.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод не поддерживается.</exception>
		// Token: 0x0600522B RID: 21035 RVA: 0x0000AF5E File Offset: 0x0000915E
		public override object GetValue(object obj, object[] index)
		{
			return null;
		}

		/// <summary>Получает значение свойства в соответствии с указанными связыванием, индексом и объектом <see langword="CultureInfo" />.</summary>
		/// <param name="obj">Объект, свойство которого будет возвращено.</param>
		/// <param name="invokeAttr">Атрибут вызова. Должен представлять собой двоичный флаг из набора <see langword="BindingFlags" />: <see langword="InvokeMethod" />, <see langword="CreateInstance" />, <see langword="Static" />, <see langword="GetField" />, <see langword="SetField" />, <see langword="GetProperty" /> или <see langword="SetProperty" />. Необходимо указать подходящий атрибут вызова. Если требуется вызвать статический элемент, следует установить флаг <see langword="Static" /> объекта <see langword="BindingFlags" />.</param>
		/// <param name="binder">Объект, позволяющий осуществлять привязку, приведение типов аргументов, вызов элементов, а также поиск объектов <see langword="MemberInfo" /> с помощью отражения. Если значение параметра <paramref name="binder" /> равно <see langword="null" />, используется связыватель по умолчанию.</param>
		/// <param name="index">Необязательные значения индекса для индексированных свойств. Для неиндексированных свойств это значение должно быть равно <see langword="null" />.</param>
		/// <param name="culture">Объект <see langword="CultureInfo" />, представляющий язык и региональные параметры, для которых должен быть локализован ресурс. Обратите внимание, что в случае, если ресурс не локализован на данном языке, при поиске соответствия будет последовательно вызываться метод <see langword="CultureInfo.Parent" />. Если данное значение равно <see langword="null" />, объект <see langword="CultureInfo" /> извлекается из свойства <see langword="CultureInfo.CurrentUICulture" />.</param>
		/// <returns>Значение свойства для <paramref name="obj" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод не поддерживается.</exception>
		// Token: 0x0600522C RID: 21036 RVA: 0x0010255A File Offset: 0x0010075A
		public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
		{
			throw this.not_supported();
		}

		/// <summary>Указывает, определен ли для данного свойства один или несколько экземпляров типа, задаваемого параметром <paramref name="attributeType" />.</summary>
		/// <param name="attributeType">Объект <see langword="Type" />, к которому применяются настраиваемые атрибуты.</param>
		/// <param name="inherit">Указывает, следует ли для поиска пользовательских атрибутов просматривать цепочку наследования данного свойства.</param>
		/// <returns>Возвращается значение <see langword="true" />, если для данного свойства определен один или несколько экземпляров типа, задаваемого параметром <paramref name="attributeType" />; в противном случае возвращается <see langword="false" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод не поддерживается.</exception>
		// Token: 0x0600522D RID: 21037 RVA: 0x0010255A File Offset: 0x0010075A
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			throw this.not_supported();
		}

		/// <summary>Устанавливает значение, присваиваемое свойству по умолчанию.</summary>
		/// <param name="defaultValue">Значение этого свойства по умолчанию.</param>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> был вызван для включающего типа.</exception>
		/// <exception cref="T:System.ArgumentException">Тип свойства не является поддерживаемым.  
		///
		/// или - 
		/// Тип параметра <paramref name="defaultValue" /> не совпадает с типом свойства.  
		///
		/// или - 
		/// Свойство имеет тип <see cref="T:System.Object" /> или другой ссылочный тип, значение <paramref name="defaultValue" /> не равно <see langword="null" />, и значение не может быть присвоено ссылочному типу.</exception>
		// Token: 0x0600522E RID: 21038 RVA: 0x00102572 File Offset: 0x00100772
		public void SetConstant(object defaultValue)
		{
			this.def_value = defaultValue;
		}

		/// <summary>Задает настраиваемый атрибут с помощью построителя настраиваемых атрибутов.</summary>
		/// <param name="customBuilder">Экземпляр вспомогательного класса для определения настраиваемого атрибута.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="customBuilder" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> был вызван для включающего типа.</exception>
		// Token: 0x0600522F RID: 21039 RVA: 0x0010257C File Offset: 0x0010077C
		public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
		{
			if (customBuilder.Ctor.ReflectedType.FullName == "System.Runtime.CompilerServices.SpecialNameAttribute")
			{
				this.attrs |= PropertyAttributes.SpecialName;
				return;
			}
			if (this.cattrs != null)
			{
				CustomAttributeBuilder[] array = new CustomAttributeBuilder[this.cattrs.Length + 1];
				this.cattrs.CopyTo(array, 0);
				array[this.cattrs.Length] = customBuilder;
				this.cattrs = array;
				return;
			}
			this.cattrs = new CustomAttributeBuilder[1];
			this.cattrs[0] = customBuilder;
		}

		/// <summary>Задает настраиваемый атрибут с помощью большого двоичного объекта настраиваемых атрибутов.</summary>
		/// <param name="con">Конструктор настраиваемого атрибута.</param>
		/// <param name="binaryAttribute">Большой двоичный объект байтов, представляющий атрибуты.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="con" /> или <paramref name="binaryAttribute" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> был вызван для включающего типа.</exception>
		// Token: 0x06005230 RID: 21040 RVA: 0x00102605 File Offset: 0x00100805
		[ComVisible(true)]
		public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
		{
			this.SetCustomAttribute(new CustomAttributeBuilder(con, binaryAttribute));
		}

		/// <summary>Устанавливает метод, который получает значение свойства.</summary>
		/// <param name="mdBuilder">Объект <see langword="MethodBuilder" />, предоставляющий метод, который получает значение свойства.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="mdBuilder" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> был вызван для включающего типа.</exception>
		// Token: 0x06005231 RID: 21041 RVA: 0x00102614 File Offset: 0x00100814
		public void SetGetMethod(MethodBuilder mdBuilder)
		{
			this.get_method = mdBuilder;
		}

		/// <summary>Устанавливает метод, который задает значение свойства.</summary>
		/// <param name="mdBuilder">Объект <see langword="MethodBuilder" />, предоставляющий метод, который задает значение свойства.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="mdBuilder" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> был вызван для включающего типа.</exception>
		// Token: 0x06005232 RID: 21042 RVA: 0x0010261D File Offset: 0x0010081D
		public void SetSetMethod(MethodBuilder mdBuilder)
		{
			this.set_method = mdBuilder;
		}

		/// <summary>Задает значение свойства с необязательными значениями индекса для свойств индекса.</summary>
		/// <param name="obj">Объект, значение свойства которого будет установлено.</param>
		/// <param name="value">Новое значение для этого свойства.</param>
		/// <param name="index">Необязательные значения индекса для индексированных свойств. Для неиндексированных свойств это значение должно быть равно <see langword="null" />.</param>
		/// <exception cref="T:System.NotSupportedException">Этот метод не поддерживается.</exception>
		// Token: 0x06005233 RID: 21043 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public override void SetValue(object obj, object value, object[] index)
		{
		}

		/// <summary>Устанавливает указанное значение для свойства указанного объекта.</summary>
		/// <param name="obj">Объект, свойство которого будет возвращено.</param>
		/// <param name="value">Новое значение для этого свойства.</param>
		/// <param name="invokeAttr">Атрибут вызова. Должен представлять собой двоичный флаг из набора <see langword="BindingFlags" />: <see langword="InvokeMethod" />, <see langword="CreateInstance" />, <see langword="Static" />, <see langword="GetField" />, <see langword="SetField" />, <see langword="GetProperty" /> или <see langword="SetProperty" />. Необходимо указать подходящий атрибут вызова. Если требуется вызвать статический элемент, следует установить флаг <see langword="Static" /> объекта <see langword="BindingFlags" />.</param>
		/// <param name="binder">Объект, позволяющий осуществлять привязку, приведение типов аргументов, вызов элементов, а также поиск объектов <see langword="MemberInfo" /> с помощью отражения. Если значение параметра <paramref name="binder" /> равно <see langword="null" />, используется связыватель по умолчанию.</param>
		/// <param name="index">Необязательные значения индекса для индексированных свойств. Для неиндексированных свойств это значение должно быть равно <see langword="null" />.</param>
		/// <param name="culture">Объект <see langword="CultureInfo" />, представляющий язык и региональные параметры, для которых должен быть локализован ресурс. Обратите внимание, что в случае, если ресурс не локализован на данном языке, при поиске соответствия будет последовательно вызываться метод <see langword="CultureInfo.Parent" />. Если данное значение равно <see langword="null" />, объект <see langword="CultureInfo" /> извлекается из свойства <see langword="CultureInfo.CurrentUICulture" />.</param>
		/// <exception cref="T:System.NotSupportedException">Этот метод не поддерживается.</exception>
		// Token: 0x06005234 RID: 21044 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
		{
		}

		/// <summary>Возвращает модуль, в котором определяется тип, объявляющий текущее свойство.</summary>
		/// <returns>Модуль <see cref="T:System.Reflection.Module" />, в котором определяется тип, объявляющий текущее свойство.</returns>
		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x06005235 RID: 21045 RVA: 0x000FAE3C File Offset: 0x000F903C
		public override Module Module
		{
			get
			{
				return base.Module;
			}
		}

		// Token: 0x06005236 RID: 21046 RVA: 0x000F79D6 File Offset: 0x000F5BD6
		private Exception not_supported()
		{
			return new NotSupportedException("The invoked member is not supported in a dynamic module.");
		}

		// Token: 0x06005237 RID: 21047 RVA: 0x000173AD File Offset: 0x000155AD
		internal PropertyBuilder()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x040032F8 RID: 13048
		private PropertyAttributes attrs;

		// Token: 0x040032F9 RID: 13049
		private string name;

		// Token: 0x040032FA RID: 13050
		private Type type;

		// Token: 0x040032FB RID: 13051
		private Type[] parameters;

		// Token: 0x040032FC RID: 13052
		private CustomAttributeBuilder[] cattrs;

		// Token: 0x040032FD RID: 13053
		private object def_value;

		// Token: 0x040032FE RID: 13054
		private MethodBuilder set_method;

		// Token: 0x040032FF RID: 13055
		private MethodBuilder get_method;

		// Token: 0x04003300 RID: 13056
		private int table_idx;

		// Token: 0x04003301 RID: 13057
		internal TypeBuilder typeb;

		// Token: 0x04003302 RID: 13058
		private Type[] returnModReq;

		// Token: 0x04003303 RID: 13059
		private Type[] returnModOpt;

		// Token: 0x04003304 RID: 13060
		private Type[][] paramModReq;

		// Token: 0x04003305 RID: 13061
		private Type[][] paramModOpt;

		// Token: 0x04003306 RID: 13062
		private CallingConventions callingConvention;
	}
}
