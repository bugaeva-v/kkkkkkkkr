using System;
using System.Globalization;
using System.Runtime.InteropServices;
using Unity;

namespace System.Reflection.Emit
{
	/// <summary>Определяет и предоставляет поле. Этот класс не наследуется.</summary>
	// Token: 0x02000924 RID: 2340
	[ComVisible(true)]
	[ComDefaultInterface(typeof(_FieldBuilder))]
	[ClassInterface(ClassInterfaceType.None)]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class FieldBuilder : FieldInfo, _FieldBuilder
	{
		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Переданный массив имен, которые необходимо сопоставить.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, зарезервированный вызывающим объектом, куда помещаются идентификаторы, соответствующие именам.</param>
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x0600500F RID: 20495 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _FieldBuilder.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает сведения о типе объекта, которые затем могут использоваться для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Получает указатель на объект с запрошенными сведениями о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x06005010 RID: 20496 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _FieldBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Указатель, по которому записывается число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x06005011 RID: 20497 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _FieldBuilder.GetTypeInfoCount(out uint pcTInfo)
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
		// Token: 0x06005012 RID: 20498 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _FieldBuilder.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06005013 RID: 20499 RVA: 0x000FAAE0 File Offset: 0x000F8CE0
		internal FieldBuilder(TypeBuilder tb, string fieldName, Type type, FieldAttributes attributes, Type[] modReq, Type[] modOpt)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			this.attrs = attributes;
			this.name = fieldName;
			this.type = type;
			this.modReq = modReq;
			this.modOpt = modOpt;
			this.offset = -1;
			this.typeb = tb;
			((ModuleBuilder)tb.Module).RegisterToken(this, this.GetToken().Token);
		}

		/// <summary>Указывает атрибуты данного поля. Это свойство доступно только для чтения.</summary>
		/// <returns>Атрибуты данного поля.</returns>
		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x06005014 RID: 20500 RVA: 0x000FAB5A File Offset: 0x000F8D5A
		public override FieldAttributes Attributes
		{
			get
			{
				return this.attrs;
			}
		}

		/// <summary>Указывает ссылку на объект <see cref="T:System.Type" /> типа, которым объявлено данное поле. Это свойство доступно только для чтения.</summary>
		/// <returns>Ссылка на объект <see cref="T:System.Type" /> типа, которым объявлено данное поле.</returns>
		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x06005015 RID: 20501 RVA: 0x000FAB62 File Offset: 0x000F8D62
		public override Type DeclaringType
		{
			get
			{
				return this.typeb;
			}
		}

		/// <summary>Указывает внутренний дескриптор метаданных для данного поля. Это свойство доступно только для чтения.</summary>
		/// <returns>Внутренний дескриптор метаданных для данного поля.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод не поддерживается.</exception>
		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x06005016 RID: 20502 RVA: 0x000FAB6A File Offset: 0x000F8D6A
		public override RuntimeFieldHandle FieldHandle
		{
			get
			{
				throw this.CreateNotSupportedException();
			}
		}

		/// <summary>Указывает объект <see cref="T:System.Type" />, предоставляющий тип данного поля. Это свойство доступно только для чтения.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий тип данного поля.</returns>
		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x06005017 RID: 20503 RVA: 0x000FAB72 File Offset: 0x000F8D72
		public override Type FieldType
		{
			get
			{
				return this.type;
			}
		}

		/// <summary>Указывает имя данного поля. Это свойство доступно только для чтения.</summary>
		/// <returns>Объект <see cref="T:System.String" />, содержащий имя данного поля.</returns>
		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x06005018 RID: 20504 RVA: 0x000FAB7A File Offset: 0x000F8D7A
		public override string Name
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Дает ссылку на объект <see cref="T:System.Type" />, откуда был получен данный объект. Это свойство доступно только для чтения.</summary>
		/// <returns>Ссылка на объект <see cref="T:System.Type" />, из которого был получен данный экземпляр.</returns>
		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x06005019 RID: 20505 RVA: 0x000FAB62 File Offset: 0x000F8D62
		public override Type ReflectedType
		{
			get
			{
				return this.typeb;
			}
		}

		/// <summary>Возвращает все пользовательские атрибуты, определенные для данного поля.</summary>
		/// <param name="inherit">Управляет наследованием настраиваемых атрибутов базового класса.</param>
		/// <returns>Массив объектов <see cref="T:System.Object" />, предоставляющий все пользовательские атрибуты конструктора, который в свою очередь представлен экземпляром объекта <see cref="T:System.Reflection.Emit.FieldBuilder" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод не поддерживается.</exception>
		// Token: 0x0600501A RID: 20506 RVA: 0x000FAB82 File Offset: 0x000F8D82
		public override object[] GetCustomAttributes(bool inherit)
		{
			if (this.typeb.is_created)
			{
				return MonoCustomAttrs.GetCustomAttributes(this, inherit);
			}
			throw this.CreateNotSupportedException();
		}

		/// <summary>Возвращает все пользовательские атрибуты, определенные для данного поля, идентифицируемого указанным типом.</summary>
		/// <param name="attributeType">Тип настраиваемого атрибута.</param>
		/// <param name="inherit">Управляет наследованием настраиваемых атрибутов базового класса.</param>
		/// <returns>Массив объектов <see cref="T:System.Object" />, предоставляющий все пользовательские атрибуты конструктора, который в свою очередь представлен экземпляром объекта <see cref="T:System.Reflection.Emit.FieldBuilder" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод не поддерживается.</exception>
		// Token: 0x0600501B RID: 20507 RVA: 0x000FAB9F File Offset: 0x000F8D9F
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			if (this.typeb.is_created)
			{
				return MonoCustomAttrs.GetCustomAttributes(this, attributeType, inherit);
			}
			throw this.CreateNotSupportedException();
		}

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x0600501C RID: 20508 RVA: 0x000FABBD File Offset: 0x000F8DBD
		public override int MetadataToken
		{
			get
			{
				return ((ModuleBuilder)this.typeb.Module).GetToken(this);
			}
		}

		/// <summary>Возвращает токен, представляющий данное поле.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.Emit.FieldToken" />, представляющий токен этого поля.</returns>
		// Token: 0x0600501D RID: 20509 RVA: 0x000FABD5 File Offset: 0x000F8DD5
		public FieldToken GetToken()
		{
			return new FieldToken(this.MetadataToken);
		}

		/// <summary>Извлекает значение поля для указанного объекта.</summary>
		/// <param name="obj">Объект, к полю которого требуется доступ.</param>
		/// <returns>Объект <see cref="T:System.Object" />, содержащий значение поля, отражаемого данным экземпляром.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод не поддерживается.</exception>
		// Token: 0x0600501E RID: 20510 RVA: 0x000FAB6A File Offset: 0x000F8D6A
		public override object GetValue(object obj)
		{
			throw this.CreateNotSupportedException();
		}

		/// <summary>Показывает, определен ли для поля атрибут указанного типа.</summary>
		/// <param name="attributeType">Тип атрибута.</param>
		/// <param name="inherit">Управляет наследованием настраиваемых атрибутов базового класса.</param>
		/// <returns>
		///   <see langword="true" />, если для данного поля определен один или несколько экземпляров <paramref name="attributeType" />; в противном случае возвращается <see langword="false" />.</returns>
		/// <exception cref="T:System.NotSupportedException">В настоящее время этот метод не поддерживается. Можно извлечь поле с помощью метода <see cref="M:System.Type.GetField(System.String,System.Reflection.BindingFlags)" /> и для полученного объекта <see cref="M:System.Reflection.MemberInfo.IsDefined(System.Type,System.Boolean)" /> вызвать метод <see cref="T:System.Reflection.FieldInfo" />.</exception>
		// Token: 0x0600501F RID: 20511 RVA: 0x000FAB6A File Offset: 0x000F8D6A
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			throw this.CreateNotSupportedException();
		}

		// Token: 0x06005020 RID: 20512 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		internal override int GetFieldOffset()
		{
			return 0;
		}

		// Token: 0x06005021 RID: 20513 RVA: 0x000FABE2 File Offset: 0x000F8DE2
		internal void SetRVAData(byte[] data)
		{
			this.rva_data = (byte[])data.Clone();
		}

		/// <summary>Устанавливает значение, присваиваемое полю по умолчанию.</summary>
		/// <param name="defaultValue">Новое значение, присваиваемое полю по умолчанию.</param>
		/// <exception cref="T:System.InvalidOperationException">Содержащий тип был создан с помощью <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип поля не поддерживается.  
		/// -или- 
		/// Тип параметра <paramref name="defaultValue" /> не совпадает с типом поля.  
		///
		/// или - 
		/// Поле имеет тип <see cref="T:System.Object" /> или другой ссылочный тип, значение <paramref name="defaultValue" /> не равно <see langword="null" />, и значение не может быть присвоено ссылочному типу.</exception>
		// Token: 0x06005022 RID: 20514 RVA: 0x000FABF5 File Offset: 0x000F8DF5
		public void SetConstant(object defaultValue)
		{
			this.RejectIfCreated();
			this.def_value = defaultValue;
		}

		/// <summary>Задает настраиваемый атрибут с помощью построителя настраиваемых атрибутов.</summary>
		/// <param name="customBuilder">Экземпляр вспомогательного класса для определения настраиваемого атрибута.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="con" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Родительский тип данного поля закрыт.</exception>
		// Token: 0x06005023 RID: 20515 RVA: 0x000FAC04 File Offset: 0x000F8E04
		public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
		{
			this.RejectIfCreated();
			if (customBuilder == null)
			{
				throw new ArgumentNullException("customBuilder");
			}
			string fullName = customBuilder.Ctor.ReflectedType.FullName;
			if (fullName == "System.Runtime.InteropServices.FieldOffsetAttribute")
			{
				byte[] data = customBuilder.Data;
				this.offset = (int)data[2];
				this.offset |= (int)data[3] << 8;
				this.offset |= (int)data[4] << 16;
				this.offset |= (int)data[5] << 24;
				return;
			}
			if (fullName == "System.NonSerializedAttribute")
			{
				this.attrs |= FieldAttributes.NotSerialized;
				return;
			}
			if (fullName == "System.Runtime.CompilerServices.SpecialNameAttribute")
			{
				this.attrs |= FieldAttributes.SpecialName;
				return;
			}
			if (fullName == "System.Runtime.InteropServices.MarshalAsAttribute")
			{
				this.attrs |= FieldAttributes.HasFieldMarshal;
				this.marshal_info = CustomAttributeBuilder.get_umarshal(customBuilder, true);
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

		/// <summary>Задает настраиваемый атрибут с помощью большого двоичного объекта пользовательских атрибутов.</summary>
		/// <param name="con">Конструктор настраиваемого атрибута.</param>
		/// <param name="binaryAttribute">Большой двоичный объект байтов, представляющий атрибуты.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="con" /> или <paramref name="binaryAttribute" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Родительский тип данного поля закрыт.</exception>
		// Token: 0x06005024 RID: 20516 RVA: 0x000FAD46 File Offset: 0x000F8F46
		[ComVisible(true)]
		public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
		{
			this.RejectIfCreated();
			this.SetCustomAttribute(new CustomAttributeBuilder(con, binaryAttribute));
		}

		/// <summary>Описывает присущий данному объекту маршалинг поля.</summary>
		/// <param name="unmanagedMarshal">Дескриптор, устанавливающий присущий данному объекту маршалинг поля.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="unmanagedMarshal" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Содержащий тип был создан с помощью <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.</exception>
		// Token: 0x06005025 RID: 20517 RVA: 0x000FAD5B File Offset: 0x000F8F5B
		[Obsolete("An alternate API is available: Emit the MarshalAs custom attribute instead.")]
		public void SetMarshal(UnmanagedMarshal unmanagedMarshal)
		{
			this.RejectIfCreated();
			this.marshal_info = unmanagedMarshal;
			this.attrs |= FieldAttributes.HasFieldMarshal;
		}

		/// <summary>Устанавливает расположение поля.</summary>
		/// <param name="iOffset">Смещение поля внутри содержащего это поле типа.</param>
		/// <exception cref="T:System.InvalidOperationException">Содержащий тип был создан с помощью <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.</exception>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="iOffset" /> меньше нуля.</exception>
		// Token: 0x06005026 RID: 20518 RVA: 0x000FAD7C File Offset: 0x000F8F7C
		public void SetOffset(int iOffset)
		{
			this.RejectIfCreated();
			if (iOffset < 0)
			{
				throw new ArgumentException("Negative field offset is not allowed");
			}
			this.offset = iOffset;
		}

		/// <summary>Задает значение поля, которое поддерживается указанным объектом.</summary>
		/// <param name="obj">Объект, к полю которого требуется доступ.</param>
		/// <param name="val">Значение, присваиваемое этому полю.</param>
		/// <param name="invokeAttr">Элемент <see langword="IBinder" />, который указывает желаемый тип связывания (например, IBinder.CreateInstance, IBinder.ExactBinding).</param>
		/// <param name="binder">Набор свойств и разрешение на связывание, приведение типов аргументов и вызов элементов с помощью отражения. Если для связывателя задано значение null, используется Binder.DefaultBinding.</param>
		/// <param name="culture">Программные настройки конкретного языка и региональных параметров.</param>
		/// <exception cref="T:System.NotSupportedException">Этот метод не поддерживается.</exception>
		// Token: 0x06005027 RID: 20519 RVA: 0x000FAB6A File Offset: 0x000F8D6A
		public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
		{
			throw this.CreateNotSupportedException();
		}

		// Token: 0x06005028 RID: 20520 RVA: 0x000F79D6 File Offset: 0x000F5BD6
		private Exception CreateNotSupportedException()
		{
			return new NotSupportedException("The invoked member is not supported in a dynamic module.");
		}

		// Token: 0x06005029 RID: 20521 RVA: 0x000FAD9A File Offset: 0x000F8F9A
		private void RejectIfCreated()
		{
			if (this.typeb.is_created)
			{
				throw new InvalidOperationException("Unable to change after type has been created.");
			}
		}

		// Token: 0x0600502A RID: 20522 RVA: 0x000FADB4 File Offset: 0x000F8FB4
		internal void ResolveUserTypes()
		{
			this.type = TypeBuilder.ResolveUserType(this.type);
			TypeBuilder.ResolveUserTypes(this.modReq);
			TypeBuilder.ResolveUserTypes(this.modOpt);
			if (this.marshal_info != null)
			{
				this.marshal_info.marshaltyperef = TypeBuilder.ResolveUserType(this.marshal_info.marshaltyperef);
			}
		}

		// Token: 0x0600502B RID: 20523 RVA: 0x000FAE0C File Offset: 0x000F900C
		internal FieldInfo RuntimeResolve()
		{
			RuntimeTypeHandle declaringType = new RuntimeTypeHandle(this.typeb.CreateType() as RuntimeType);
			return FieldInfo.GetFieldFromHandle(this.handle, declaringType);
		}

		/// <summary>Возвращает модуль, в котором определяется тип, содержащий это поле.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.Module" />, который представляет динамический модуль, в котором определено это поле.</returns>
		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x0600502C RID: 20524 RVA: 0x000FAE3C File Offset: 0x000F903C
		public override Module Module
		{
			get
			{
				return base.Module;
			}
		}

		// Token: 0x0600502D RID: 20525 RVA: 0x000173AD File Offset: 0x000155AD
		internal FieldBuilder()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x0400315D RID: 12637
		private FieldAttributes attrs;

		// Token: 0x0400315E RID: 12638
		private Type type;

		// Token: 0x0400315F RID: 12639
		private string name;

		// Token: 0x04003160 RID: 12640
		private object def_value;

		// Token: 0x04003161 RID: 12641
		private int offset;

		// Token: 0x04003162 RID: 12642
		internal TypeBuilder typeb;

		// Token: 0x04003163 RID: 12643
		private byte[] rva_data;

		// Token: 0x04003164 RID: 12644
		private CustomAttributeBuilder[] cattrs;

		// Token: 0x04003165 RID: 12645
		private UnmanagedMarshal marshal_info;

		// Token: 0x04003166 RID: 12646
		private RuntimeFieldHandle handle;

		// Token: 0x04003167 RID: 12647
		private Type[] modReq;

		// Token: 0x04003168 RID: 12648
		private Type[] modOpt;
	}
}
