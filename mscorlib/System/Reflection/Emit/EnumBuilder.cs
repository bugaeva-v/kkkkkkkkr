using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity;

namespace System.Reflection.Emit
{
	/// <summary>Описывает и представляет тип перечисления.</summary>
	// Token: 0x02000920 RID: 2336
	[ComVisible(true)]
	[ComDefaultInterface(typeof(_EnumBuilder))]
	[ClassInterface(ClassInterfaceType.None)]
	public sealed class EnumBuilder : TypeInfo, _EnumBuilder
	{
		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Переданный массив имен, которые необходимо сопоставить.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, зарезервированный вызывающим объектом, куда помещаются идентификаторы, соответствующие именам.</param>
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x06004FA5 RID: 20389 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _EnumBuilder.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает сведения о типе объекта, которые затем могут использоваться для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Получает указатель на объект с запрошенными сведениями о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x06004FA6 RID: 20390 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _EnumBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Указатель, по которому записывается число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x06004FA7 RID: 20391 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _EnumBuilder.GetTypeInfoCount(out uint pcTInfo)
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
		// Token: 0x06004FA8 RID: 20392 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _EnumBuilder.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06004FA9 RID: 20393 RVA: 0x000FA310 File Offset: 0x000F8510
		internal EnumBuilder(ModuleBuilder mb, string name, TypeAttributes visibility, Type underlyingType)
		{
			this._tb = new TypeBuilder(mb, name, visibility | TypeAttributes.Sealed, typeof(Enum), null, PackingSize.Unspecified, 0, null);
			this._underlyingType = underlyingType;
			this._underlyingField = this._tb.DefineField("value__", underlyingType, FieldAttributes.Private | FieldAttributes.SpecialName | FieldAttributes.RTSpecialName);
			this.setup_enum_type(this._tb);
		}

		// Token: 0x06004FAA RID: 20394 RVA: 0x000FA376 File Offset: 0x000F8576
		internal TypeBuilder GetTypeBuilder()
		{
			return this._tb;
		}

		// Token: 0x06004FAB RID: 20395 RVA: 0x000FA37E File Offset: 0x000F857E
		internal override Type InternalResolve()
		{
			return this._tb.InternalResolve();
		}

		// Token: 0x06004FAC RID: 20396 RVA: 0x000FA38B File Offset: 0x000F858B
		internal override Type RuntimeResolve()
		{
			return this._tb.RuntimeResolve();
		}

		/// <summary>Извлекает динамическую сборку, которая содержит определение данного перечисления.</summary>
		/// <returns>Только для чтения. Динамическая сборка, которая содержит определение данного перечисления.</returns>
		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x06004FAD RID: 20397 RVA: 0x000FA398 File Offset: 0x000F8598
		public override Assembly Assembly
		{
			get
			{
				return this._tb.Assembly;
			}
		}

		/// <summary>Возвращает полный путь к этому перечислению, определенный отображаемым именем родительской сборки.</summary>
		/// <returns>Только для чтения. Полный путь к этому перечислению, определенный отображаемым именем родительской сборки.</returns>
		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x06004FAE RID: 20398 RVA: 0x000FA3A5 File Offset: 0x000F85A5
		public override string AssemblyQualifiedName
		{
			get
			{
				return this._tb.AssemblyQualifiedName;
			}
		}

		/// <summary>Возвращает родительский тип <see cref="T:System.Type" /> этого типа, который всегда является <see cref="T:System.Enum" />.</summary>
		/// <returns>Только для чтения. Родительский <see cref="T:System.Type" /> данного типа.</returns>
		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x06004FAF RID: 20399 RVA: 0x000FA3B2 File Offset: 0x000F85B2
		public override Type BaseType
		{
			get
			{
				return this._tb.BaseType;
			}
		}

		/// <summary>Возвращает тип, объявивший этот <see cref="T:System.Reflection.Emit.EnumBuilder" />.</summary>
		/// <returns>Только для чтения. Тип, объявивший этот <see cref="T:System.Reflection.Emit.EnumBuilder" />.</returns>
		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x06004FB0 RID: 20400 RVA: 0x000FA3BF File Offset: 0x000F85BF
		public override Type DeclaringType
		{
			get
			{
				return this._tb.DeclaringType;
			}
		}

		/// <summary>Возвращает полный путь этого перечисления.</summary>
		/// <returns>Только для чтения. Полный путь этого перечисления.</returns>
		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x06004FB1 RID: 20401 RVA: 0x000FA3CC File Offset: 0x000F85CC
		public override string FullName
		{
			get
			{
				return this._tb.FullName;
			}
		}

		/// <summary>Возвращает идентификатор GUID данного перечисления.</summary>
		/// <returns>Только для чтения. Идентификатор GUID данного перечисления.</returns>
		/// <exception cref="T:System.NotSupportedException">Сейчас этот метод не поддерживается в типах, которые не являются полными.</exception>
		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x06004FB2 RID: 20402 RVA: 0x000FA3D9 File Offset: 0x000F85D9
		public override Guid GUID
		{
			get
			{
				return this._tb.GUID;
			}
		}

		/// <summary>Извлекает динамический модуль, который содержит определение данного <see cref="T:System.Reflection.Emit.EnumBuilder" />.</summary>
		/// <returns>Только для чтения. Динамический модуль, который содержит определение данного <see cref="T:System.Reflection.Emit.EnumBuilder" />.</returns>
		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x06004FB3 RID: 20403 RVA: 0x000FA3E6 File Offset: 0x000F85E6
		public override Module Module
		{
			get
			{
				return this._tb.Module;
			}
		}

		/// <summary>Возвращает имя этого перечисления.</summary>
		/// <returns>Только для чтения. Имя этого перечисления.</returns>
		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x06004FB4 RID: 20404 RVA: 0x000FA3F3 File Offset: 0x000F85F3
		public override string Name
		{
			get
			{
				return this._tb.Name;
			}
		}

		/// <summary>Возвращает пространство имен этого перечисления.</summary>
		/// <returns>Только для чтения. Пространство имен этого перечисления.</returns>
		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x06004FB5 RID: 20405 RVA: 0x000FA400 File Offset: 0x000F8600
		public override string Namespace
		{
			get
			{
				return this._tb.Namespace;
			}
		}

		/// <summary>Возвращает тип, который был использован для получения этого <see cref="T:System.Reflection.Emit.EnumBuilder" />.</summary>
		/// <returns>Только для чтения. Тип, который был использован для получения этого <see cref="T:System.Reflection.Emit.EnumBuilder" />.</returns>
		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x06004FB6 RID: 20406 RVA: 0x000FA40D File Offset: 0x000F860D
		public override Type ReflectedType
		{
			get
			{
				return this._tb.ReflectedType;
			}
		}

		/// <summary>Извлекает внутренний маркер этого перечисления.</summary>
		/// <returns>Только для чтения. Внутренний маркер этого перечисления.</returns>
		/// <exception cref="T:System.NotSupportedException">Данное свойство в настоящий момент не поддерживается.</exception>
		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x06004FB7 RID: 20407 RVA: 0x000FA41A File Offset: 0x000F861A
		public override RuntimeTypeHandle TypeHandle
		{
			get
			{
				return this._tb.TypeHandle;
			}
		}

		/// <summary>Возвращает маркер типа внутренних метаданных этого перечисления.</summary>
		/// <returns>Только для чтения. Маркер типа этого перечисления.</returns>
		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x06004FB8 RID: 20408 RVA: 0x000FA427 File Offset: 0x000F8627
		public TypeToken TypeToken
		{
			get
			{
				return this._tb.TypeToken;
			}
		}

		/// <summary>Возвращает базовое поле для этого перечисления.</summary>
		/// <returns>Только для чтения. Базовое поле для этого перечисления.</returns>
		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x06004FB9 RID: 20409 RVA: 0x000FA434 File Offset: 0x000F8634
		public FieldBuilder UnderlyingField
		{
			get
			{
				return this._underlyingField;
			}
		}

		/// <summary>Возвращает базовый системный тип данного перечисления.</summary>
		/// <returns>Только для чтения. Возвращает базовый системный тип.</returns>
		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x06004FBA RID: 20410 RVA: 0x000FA43C File Offset: 0x000F863C
		public override Type UnderlyingSystemType
		{
			get
			{
				return this._underlyingType;
			}
		}

		/// <summary>Создает объект <see cref="T:System.Type" /> для этого перечисления.</summary>
		/// <returns>Объект <see cref="T:System.Type" /> для этого перечисления.</returns>
		/// <exception cref="T:System.InvalidOperationException">Этот тип был создан ранее.  
		///
		/// или - 
		/// Включающий тип не создан.</exception>
		// Token: 0x06004FBB RID: 20411 RVA: 0x000FA444 File Offset: 0x000F8644
		public Type CreateType()
		{
			return this._tb.CreateType();
		}

		/// <summary>Получает объект <see cref="T:System.Reflection.TypeInfo" />, представляющий это перечисление.</summary>
		/// <returns>Объект, представляющий это перечисление.</returns>
		// Token: 0x06004FBC RID: 20412 RVA: 0x000FA451 File Offset: 0x000F8651
		public TypeInfo CreateTypeInfo()
		{
			return this._tb.CreateTypeInfo();
		}

		/// <summary>Возвращает базовый тип integer текущего перечисления, который устанавливается при определении построителя перечисления.</summary>
		/// <returns>Базовый тип.</returns>
		// Token: 0x06004FBD RID: 20413 RVA: 0x000FA43C File Offset: 0x000F863C
		public override Type GetEnumUnderlyingType()
		{
			return this._underlyingType;
		}

		// Token: 0x06004FBE RID: 20414
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void setup_enum_type(Type t);

		/// <summary>Определяет именованное статическое поле типа перечисления с указанным константным значением.</summary>
		/// <param name="literalName">Имя статического поля.</param>
		/// <param name="literalValue">Константное значение литерала.</param>
		/// <returns>Определенное поле.</returns>
		// Token: 0x06004FBF RID: 20415 RVA: 0x000FA460 File Offset: 0x000F8660
		public FieldBuilder DefineLiteral(string literalName, object literalValue)
		{
			FieldBuilder fieldBuilder = this._tb.DefineField(literalName, this, FieldAttributes.FamANDAssem | FieldAttributes.Family | FieldAttributes.Static | FieldAttributes.Literal);
			fieldBuilder.SetConstant(literalValue);
			return fieldBuilder;
		}

		// Token: 0x06004FC0 RID: 20416 RVA: 0x000FA485 File Offset: 0x000F8685
		protected override TypeAttributes GetAttributeFlagsImpl()
		{
			return this._tb.attrs;
		}

		// Token: 0x06004FC1 RID: 20417 RVA: 0x000FA492 File Offset: 0x000F8692
		protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			return this._tb.GetConstructor(bindingAttr, binder, callConvention, types, modifiers);
		}

		/// <summary>Возвращает массив объектов <see cref="T:System.Reflection.ConstructorInfo" />, представляющих открытые и закрытые конструкторы, определенные для этого класса, как указано.</summary>
		/// <param name="bindingAttr">Это должен быть одноразрядный флаг из <see cref="T:System.Reflection.BindingFlags" /> : <see langword="InvokeMethod" />, <see langword="NonPublic" /> и так далее.</param>
		/// <returns>Возвращает массив объектов <see cref="T:System.Reflection.ConstructorInfo" />, представляющих указанные конструкторы, определенные для этого класса. Если конструкторы не определены, возвращается пустой массив.</returns>
		/// <exception cref="T:System.NotSupportedException">Сейчас этот метод не поддерживается в типах, которые не являются полными.</exception>
		// Token: 0x06004FC2 RID: 20418 RVA: 0x000FA4A6 File Offset: 0x000F86A6
		[ComVisible(true)]
		public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
		{
			return this._tb.GetConstructors(bindingAttr);
		}

		/// <summary>Возвращает все настраиваемые атрибуты, определенные для этого конструктора.</summary>
		/// <param name="inherit">Указывает, следует ли выполнять поиск атрибутов в цепочке наследования этого члена.</param>
		/// <returns>Возвращает массив объектов, представляющих все настраиваемые атрибуты конструктора, который представлен этим экземпляром <see cref="T:System.Reflection.Emit.ConstructorBuilder" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Сейчас этот метод не поддерживается в типах, которые не являются полными.</exception>
		// Token: 0x06004FC3 RID: 20419 RVA: 0x000FA4B4 File Offset: 0x000F86B4
		public override object[] GetCustomAttributes(bool inherit)
		{
			return this._tb.GetCustomAttributes(inherit);
		}

		/// <summary>Возвращает настраиваемые атрибуты, определяемые заданным типом.</summary>
		/// <param name="attributeType">Объект <see langword="Type" />, к которому применяются настраиваемые атрибуты.</param>
		/// <param name="inherit">Указывает, следует ли выполнять поиск атрибутов в цепочке наследования этого члена.</param>
		/// <returns>Возвращает массив объектов, предоставляющих атрибуты типа <see cref="T:System.Type" /><paramref name="attributeType" /> данного конструктора.</returns>
		/// <exception cref="T:System.NotSupportedException">Сейчас этот метод не поддерживается в типах, которые не являются полными.</exception>
		// Token: 0x06004FC4 RID: 20420 RVA: 0x000FA4C2 File Offset: 0x000F86C2
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return this._tb.GetCustomAttributes(attributeType, inherit);
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.NotSupportedException" />.</summary>
		/// <returns>Этот метод не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.NotSupportedException">В настоящее время этот метод не поддерживается.</exception>
		// Token: 0x06004FC5 RID: 20421 RVA: 0x000FA4D1 File Offset: 0x000F86D1
		public override Type GetElementType()
		{
			return this._tb.GetElementType();
		}

		/// <summary>Возвращает событие с указанным именем.</summary>
		/// <param name="name">Имя возвращаемого события.</param>
		/// <param name="bindingAttr">Это атрибут вызова. Это должен быть одноразрядный флаг из <see cref="T:System.Reflection.BindingFlags" /> : <see langword="InvokeMethod" />, <see langword="NonPublic" /> и так далее.</param>
		/// <returns>Возвращает объект <see cref="T:System.Reflection.EventInfo" />, представляющий событие с указанным именем, объявленное или унаследованное этим типом. Если совпадений нет, возвращается значение <see langword="null" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Сейчас этот метод не поддерживается в типах, которые не являются полными.</exception>
		// Token: 0x06004FC6 RID: 20422 RVA: 0x000FA4DE File Offset: 0x000F86DE
		public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
		{
			return this._tb.GetEvent(name, bindingAttr);
		}

		/// <summary>Возвращает события для открытых событий, объявленных или наследуемых данным типом.</summary>
		/// <returns>Возвращает массив объектов <see cref="T:System.Reflection.EventInfo" />, представляющих открытые события, объявленные или наследуемые этим типом. Если открытые события отсутствуют, возвращается пустой массив.</returns>
		/// <exception cref="T:System.NotSupportedException">Сейчас этот метод не поддерживается в типах, которые не являются полными.</exception>
		// Token: 0x06004FC7 RID: 20423 RVA: 0x000FA4ED File Offset: 0x000F86ED
		public override EventInfo[] GetEvents()
		{
			return this._tb.GetEvents();
		}

		/// <summary>Возвращает открытые и не являющиеся открытыми события, объявленные данным типом.</summary>
		/// <param name="bindingAttr">Это должен быть одноразрядный флаг из <see cref="T:System.Reflection.BindingFlags" />, например <see langword="InvokeMethod" />, <see langword="NonPublic" /> и так далее.</param>
		/// <returns>Возвращает массив объектов <see cref="T:System.Reflection.EventInfo" />, представляющих открытые и не являющиеся открытыми события, объявленные или наследованные этим объектом. Если заданные события отсутствуют, возвращается пустой массив.</returns>
		/// <exception cref="T:System.NotSupportedException">Сейчас этот метод не поддерживается в типах, которые не являются полными.</exception>
		// Token: 0x06004FC8 RID: 20424 RVA: 0x000FA4FA File Offset: 0x000F86FA
		public override EventInfo[] GetEvents(BindingFlags bindingAttr)
		{
			return this._tb.GetEvents(bindingAttr);
		}

		/// <summary>Возвращает поле, указанное данным именем.</summary>
		/// <param name="name">Имя получаемого поля.</param>
		/// <param name="bindingAttr">Это должен быть одноразрядный флаг из <see cref="T:System.Reflection.BindingFlags" /> : <see langword="InvokeMethod" />, <see langword="NonPublic" /> и так далее.</param>
		/// <returns>Возвращает объект <see cref="T:System.Reflection.FieldInfo" />, представляющий поле, объявленное или наследуемое этим типом, с указанным именем и открытым или закрытым модификатором. Если совпадений нет, возвращается нулевое значение.</returns>
		/// <exception cref="T:System.NotSupportedException">Сейчас этот метод не поддерживается в типах, которые не являются полными.</exception>
		// Token: 0x06004FC9 RID: 20425 RVA: 0x000FA508 File Offset: 0x000F8708
		public override FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			return this._tb.GetField(name, bindingAttr);
		}

		/// <summary>Возвращает открытые и не являющиеся открытыми поля, объявленные данным типом.</summary>
		/// <param name="bindingAttr">Это должен быть одноразрядный флаг из <see cref="T:System.Reflection.BindingFlags" />, например InvokeMethod, NonPublic и т. д.</param>
		/// <returns>Возвращает массив объектов <see cref="T:System.Reflection.FieldInfo" />, представляющих открытые и не являющиеся открытыми поля, объявленные или наследованные этим типом. Если заданные поля отсутствуют, возвращается пустой массив.</returns>
		/// <exception cref="T:System.NotSupportedException">Сейчас этот метод не поддерживается в типах, которые не являются полными.</exception>
		// Token: 0x06004FCA RID: 20426 RVA: 0x000FA517 File Offset: 0x000F8717
		public override FieldInfo[] GetFields(BindingFlags bindingAttr)
		{
			return this._tb.GetFields(bindingAttr);
		}

		/// <summary>Возвращает интерфейс, реализованный (прямо или косвенно) данным типом, с указанным полным именем.</summary>
		/// <param name="name">Имя интерфейса.</param>
		/// <param name="ignoreCase">Если значение <see langword="true" />, при поиске не учитывается регистр. Если значение <see langword="false" />, при поиске учитывается регистр.</param>
		/// <returns>Возвращает объект <see cref="T:System.Type" />, предоставляющий реализованный интерфейс. Возвращает значение null, если совпадающее имя интерфейса не найдено.</returns>
		/// <exception cref="T:System.NotSupportedException">Сейчас этот метод не поддерживается в типах, которые не являются полными.</exception>
		// Token: 0x06004FCB RID: 20427 RVA: 0x000FA525 File Offset: 0x000F8725
		public override Type GetInterface(string name, bool ignoreCase)
		{
			return this._tb.GetInterface(name, ignoreCase);
		}

		/// <summary>Возвращает сопоставление для интерфейса заданного типа.</summary>
		/// <param name="interfaceType">Тип интерфейса, для которого должно быть получено сопоставление интерфейса.</param>
		/// <returns>Запрошенное сопоставление интерфейса.</returns>
		/// <exception cref="T:System.ArgumentException">Тип не реализует интерфейс.</exception>
		// Token: 0x06004FCC RID: 20428 RVA: 0x000FA534 File Offset: 0x000F8734
		[ComVisible(true)]
		public override InterfaceMapping GetInterfaceMap(Type interfaceType)
		{
			return this._tb.GetInterfaceMap(interfaceType);
		}

		/// <summary>Возвращает массив всех интерфейсов, реализованных для данного класса и его базовых классов.</summary>
		/// <returns>Возвращает массив объектов <see cref="T:System.Type" />, представляющих реализованные интерфейсы. Если они не определены, возвращается пустой массив.</returns>
		// Token: 0x06004FCD RID: 20429 RVA: 0x000FA542 File Offset: 0x000F8742
		public override Type[] GetInterfaces()
		{
			return this._tb.GetInterfaces();
		}

		/// <summary>Возвращает все члены с указанным именем, типом и привязкой, объявленные или наследованные этим типом.</summary>
		/// <param name="name">Имя элемента.</param>
		/// <param name="type">Тип возвращаемого члена.</param>
		/// <param name="bindingAttr">Это должен быть одноразрядный флаг из <see cref="T:System.Reflection.BindingFlags" /> : <see langword="InvokeMethod" />, <see langword="NonPublic" /> и так далее.</param>
		/// <returns>Возвращает массив объектов <see cref="T:System.Reflection.MemberInfo" />, представляющих открытые и не являющиеся открытыми члены, определенные для данного типа, если используется <paramref name="nonPublic" />; в противном случае возвращаются только открытые члены.</returns>
		/// <exception cref="T:System.NotSupportedException">Сейчас этот метод не поддерживается в типах, которые не являются полными.</exception>
		// Token: 0x06004FCE RID: 20430 RVA: 0x000FA54F File Offset: 0x000F874F
		public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
		{
			return this._tb.GetMember(name, type, bindingAttr);
		}

		/// <summary>Возвращает указанные члены, объявленные или наследованные данным типом.</summary>
		/// <param name="bindingAttr">Это должен быть одноразрядный флаг из <see cref="T:System.Reflection.BindingFlags" /> : <see langword="InvokeMethod" />, <see langword="NonPublic" /> и так далее.</param>
		/// <returns>Возвращает массив объектов <see cref="T:System.Reflection.MemberInfo" />, представляющих открытые и не являющиеся открытыми члены, объявленные или наследованные этим типом. Если соответствующие члены отсутствуют, возвращается пустой массив.</returns>
		/// <exception cref="T:System.NotSupportedException">Сейчас этот метод не поддерживается в типах, которые не являются полными.</exception>
		// Token: 0x06004FCF RID: 20431 RVA: 0x000FA55F File Offset: 0x000F875F
		public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
		{
			return this._tb.GetMembers(bindingAttr);
		}

		// Token: 0x06004FD0 RID: 20432 RVA: 0x000FA56D File Offset: 0x000F876D
		protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			if (types == null)
			{
				return this._tb.GetMethod(name, bindingAttr);
			}
			return this._tb.GetMethod(name, bindingAttr, binder, callConvention, types, modifiers);
		}

		/// <summary>Возвращает все открытые и закрытые методы, объявленные или наследуемые данным типом, как указано.</summary>
		/// <param name="bindingAttr">Это должен быть одноразрядный флаг из <see cref="T:System.Reflection.BindingFlags" />, например <see langword="InvokeMethod" />, <see langword="NonPublic" /> и так далее.</param>
		/// <returns>Возвращает массив объектов <see cref="T:System.Reflection.MethodInfo" />, представляющих открытые и закрытые методы, определенные для данного типа, если используется <paramref name="nonPublic" />; в противном случае возвращаются только открытые методы.</returns>
		/// <exception cref="T:System.NotSupportedException">Сейчас этот метод не поддерживается в типах, которые не являются полными.</exception>
		// Token: 0x06004FD1 RID: 20433 RVA: 0x000FA595 File Offset: 0x000F8795
		public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
		{
			return this._tb.GetMethods(bindingAttr);
		}

		/// <summary>Возвращает указанный вложенный тип, который объявлен этим типом.</summary>
		/// <param name="name">Строка <see cref="T:System.String" />, содержащая имя искомого вложенного типа.</param>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		///
		/// или - 
		/// Нуль для выполнения поиска открытых методов с учетом регистра.</param>
		/// <returns>Если поиск выполнен успешно, возвращается объект <see cref="T:System.Type" />, предоставляющий вложенный тип, который соответствует указанным требованиям; в противном случае возвращается <see langword="null" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Сейчас этот метод не поддерживается в типах, которые не являются полными.</exception>
		// Token: 0x06004FD2 RID: 20434 RVA: 0x000FA5A3 File Offset: 0x000F87A3
		public override Type GetNestedType(string name, BindingFlags bindingAttr)
		{
			return this._tb.GetNestedType(name, bindingAttr);
		}

		/// <summary>Возвращает открытые и не являющиеся открытыми вложенные типы, объявленные или наследованные данным типом.</summary>
		/// <param name="bindingAttr">Это должен быть одноразрядный флаг из <see cref="T:System.Reflection.BindingFlags" />, например <see langword="InvokeMethod" />, <see langword="NonPublic" /> и так далее.</param>
		/// <returns>Массив объектов <see cref="T:System.Type" />, представляющий все типы, вложенные внутри текущего типа <see cref="T:System.Type" /> и удовлетворяющие указанным ограничениям привязки.  
		/// Пустой массив типа <see cref="T:System.Type" />, если внутри текущего объекта <see cref="T:System.Type" /> нет вложенных типов или ни один из вложенных типов не удовлетворяет ограничениям привязки.</returns>
		/// <exception cref="T:System.NotSupportedException">Сейчас этот метод не поддерживается в типах, которые не являются полными.</exception>
		// Token: 0x06004FD3 RID: 20435 RVA: 0x000FA5B2 File Offset: 0x000F87B2
		public override Type[] GetNestedTypes(BindingFlags bindingAttr)
		{
			return this._tb.GetNestedTypes(bindingAttr);
		}

		/// <summary>Возвращает все открытые и закрытые свойства, объявленные или наследуемые данным типом, как указано.</summary>
		/// <param name="bindingAttr">Это атрибут вызова. Это должен быть одноразрядный флаг из <see cref="T:System.Reflection.BindingFlags" /> : <see langword="InvokeMethod" />, <see langword="NonPublic" /> и так далее.</param>
		/// <returns>Возвращает массив объектов <see cref="T:System.Reflection.PropertyInfo" />, представляющих открытые и закрытые свойства, определенные для данного типа, если используется <paramref name="nonPublic" />; в противном случае возвращаются только открытые свойства.</returns>
		/// <exception cref="T:System.NotSupportedException">Сейчас этот метод не поддерживается в типах, которые не являются полными.</exception>
		// Token: 0x06004FD4 RID: 20436 RVA: 0x000FA5C0 File Offset: 0x000F87C0
		public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
		{
			return this._tb.GetProperties(bindingAttr);
		}

		// Token: 0x06004FD5 RID: 20437 RVA: 0x000FA5CE File Offset: 0x000F87CE
		protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
		{
			throw this.CreateNotSupportedException();
		}

		// Token: 0x06004FD6 RID: 20438 RVA: 0x000FA5D6 File Offset: 0x000F87D6
		protected override bool HasElementTypeImpl()
		{
			return this._tb.HasElementType;
		}

		/// <summary>Вызывает указанный член. Вызываемый метод должен быть доступен и должен обеспечивать наиболее точное соответствие заданному списку аргументов с учетом ограничений заданного модуля привязки и атрибутов вызова.</summary>
		/// <param name="name">Имя вызываемого члена. Это может быть конструктор, метод, свойство или поле. Необходимо указать подходящий атрибут вызова. Обратите внимание, что можно вызвать член класса, заданный по умолчанию, передав в качестве имени члена пустую строку.</param>
		/// <param name="invokeAttr">Атрибут вызова. Это должен быть одноразрядный флаг из <see langword="BindingFlags" />.</param>
		/// <param name="binder">Объект, позволяющий осуществлять привязку, приведение типов аргументов, вызов элементов, а также поиск объектов <see langword="MemberInfo" /> с помощью отражения. Если указан модуль привязки <see langword="null" />, используется модуль привязки по умолчанию. См. раздел <see cref="T:System.Reflection.Binder" />.</param>
		/// <param name="target">Объект, для которого следует вызвать указанный член. Если член является статическим, этот параметр игнорируется.</param>
		/// <param name="args">Список аргументов. Это массив объектов, содержащий число, порядок и тип параметров вызываемого члена. Если параметров нет, должно быть указано значение NULL.</param>
		/// <param name="modifiers">Массив с такой же длиной, как у <paramref name="args" /> с элементами, представляющими атрибуты, связанные с аргументами вызываемого члена. Параметр имеет атрибуты, связанные с ним в метаданных. Они используются различными службами взаимодействия. Такие сведения можно найти в спецификации метаданных.</param>
		/// <param name="culture">Экземпляр объекта <see langword="CultureInfo" />, используемого для управления приведением типов. Если параметр имеет значение NULL, для текущего потока используется <see langword="CultureInfo" />. (Обратите внимание, что необходимо, например, преобразовать строку, представляющую 1000, в число с двойной точностью, поскольку для разных языков и региональных параметров 1000 представляется по-разному.)</param>
		/// <param name="namedParameters">Каждый параметр в массиве <paramref name="namedParameters" /> получает значение в соответствующем элементе в массиве <paramref name="args" />. Если длина <paramref name="args" /> превышает длину <paramref name="namedParameters" />, оставшиеся значения аргументов передаются по порядку.</param>
		/// <returns>Возвращает возвращаемое значение вызываемого члена.</returns>
		/// <exception cref="T:System.NotSupportedException">Сейчас этот метод не поддерживается в типах, которые не являются полными.</exception>
		// Token: 0x06004FD7 RID: 20439 RVA: 0x000FA5E4 File Offset: 0x000F87E4
		public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
		{
			return this._tb.InvokeMember(name, invokeAttr, binder, target, args, modifiers, culture, namedParameters);
		}

		// Token: 0x06004FD8 RID: 20440 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		protected override bool IsArrayImpl()
		{
			return false;
		}

		// Token: 0x06004FD9 RID: 20441 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		protected override bool IsByRefImpl()
		{
			return false;
		}

		// Token: 0x06004FDA RID: 20442 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		protected override bool IsCOMObjectImpl()
		{
			return false;
		}

		// Token: 0x06004FDB RID: 20443 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		protected override bool IsPointerImpl()
		{
			return false;
		}

		// Token: 0x06004FDC RID: 20444 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		protected override bool IsPrimitiveImpl()
		{
			return false;
		}

		// Token: 0x06004FDD RID: 20445 RVA: 0x000040F7 File Offset: 0x000022F7
		protected override bool IsValueTypeImpl()
		{
			return true;
		}

		/// <summary>Проверяет, определен ли заданный тип настраиваемого атрибута.</summary>
		/// <param name="attributeType">Объект <see langword="Type" />, к которому применяются настраиваемые атрибуты.</param>
		/// <param name="inherit">Указывает, следует ли выполнять поиск атрибутов в цепочке наследования этого члена.</param>
		/// <returns>Значение <see langword="true" />, если для данного члена определен один или несколько экземпляров <paramref name="attributeType" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Сейчас этот метод не поддерживается в типах, которые не являются полными.</exception>
		// Token: 0x06004FDE RID: 20446 RVA: 0x000FA609 File Offset: 0x000F8809
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return this._tb.IsDefined(attributeType, inherit);
		}

		/// <summary>Возвращает объект <see cref="T:System.Type" />, представляющий одномерный массив текущего типа с нижней границей, равной нулю.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий одномерный массив текущего типа с нижней границей, равной нулю.</returns>
		// Token: 0x06004FDF RID: 20447 RVA: 0x000F653D File Offset: 0x000F473D
		public override Type MakeArrayType()
		{
			return new ArrayType(this, 0);
		}

		/// <summary>Возвращает объект <see cref="T:System.Type" />, представляющий массив текущего типа указанной размерности.</summary>
		/// <param name="rank">Размерность массива. Это число должно быть меньше либо равно 32.</param>
		/// <returns>Объект, представляющий массив текущего типа указанной размерности.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Значение параметра <paramref name="rank" /> меньше 1.</exception>
		// Token: 0x06004FE0 RID: 20448 RVA: 0x000F6546 File Offset: 0x000F4746
		public override Type MakeArrayType(int rank)
		{
			if (rank < 1)
			{
				throw new IndexOutOfRangeException();
			}
			return new ArrayType(this, rank);
		}

		/// <summary>Возвращает объект <see cref="T:System.Type" />, который представляет текущий тип при передаче в качестве параметра ref (параметра ByRef в Visual Basic).</summary>
		/// <returns>Объект <see cref="T:System.Type" />, который представляет текущий тип при передаче в качестве параметра ref (параметра ByRef в Visual Basic).</returns>
		// Token: 0x06004FE1 RID: 20449 RVA: 0x000F6559 File Offset: 0x000F4759
		public override Type MakeByRefType()
		{
			return new ByRefType(this);
		}

		/// <summary>Возвращает объект <see cref="T:System.Type" />, который представляет указатель на текущий тип.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, который представляет указатель на текущий тип.</returns>
		// Token: 0x06004FE2 RID: 20450 RVA: 0x000F6561 File Offset: 0x000F4761
		public override Type MakePointerType()
		{
			return new PointerType(this);
		}

		/// <summary>Задает настраиваемый атрибут с помощью построителя настраиваемых атрибутов.</summary>
		/// <param name="customBuilder">Экземпляр вспомогательного класса для определения настраиваемого атрибута.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="con" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004FE3 RID: 20451 RVA: 0x000FA618 File Offset: 0x000F8818
		public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
		{
			this._tb.SetCustomAttribute(customBuilder);
		}

		/// <summary>Задает настраиваемый атрибут с помощью большого двоичного объекта пользовательских атрибутов.</summary>
		/// <param name="con">Конструктор настраиваемого атрибута.</param>
		/// <param name="binaryAttribute">Большой двоичный объект байтов, представляющий атрибуты.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="con" /> или <paramref name="binaryAttribute" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004FE4 RID: 20452 RVA: 0x000FA626 File Offset: 0x000F8826
		[ComVisible(true)]
		public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
		{
			this.SetCustomAttribute(new CustomAttributeBuilder(con, binaryAttribute));
		}

		// Token: 0x06004FE5 RID: 20453 RVA: 0x000F79D6 File Offset: 0x000F5BD6
		private Exception CreateNotSupportedException()
		{
			return new NotSupportedException("The invoked member is not supported in a dynamic module.");
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x06004FE6 RID: 20454 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		internal override bool IsUserType
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает значение, указывающее, представляет ли этот данный объект сконструированный универсальный тип.</summary>
		/// <returns>Значение <see langword="true" />, если этот объект представляет сконструированный универсальный тип; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x06004FE7 RID: 20455 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public override bool IsConstructedGenericType
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает значение, указывающее, может ли заданный объект <see cref="T:System.Reflection.TypeInfo" /> быть назначен этому объекту.</summary>
		/// <param name="typeInfo">Объект для тестирования.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="typeInfo" /> может быть назначен этому объекту. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004FE8 RID: 20456 RVA: 0x000FA635 File Offset: 0x000F8835
		public override bool IsAssignableFrom(TypeInfo typeInfo)
		{
			return base.IsAssignableFrom(typeInfo);
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x06004FE9 RID: 20457 RVA: 0x000040F7 File Offset: 0x000022F7
		public override bool IsTypeDefinition
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06004FEA RID: 20458 RVA: 0x000173AD File Offset: 0x000155AD
		internal EnumBuilder()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x0400314B RID: 12619
		private TypeBuilder _tb;

		// Token: 0x0400314C RID: 12620
		private FieldBuilder _underlyingField;

		// Token: 0x0400314D RID: 12621
		private Type _underlyingType;
	}
}
