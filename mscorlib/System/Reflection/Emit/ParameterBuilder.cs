using System;
using System.Runtime.InteropServices;
using Unity;

namespace System.Reflection.Emit
{
	/// <summary>Создает или связывает сведения о параметрах.</summary>
	// Token: 0x0200093E RID: 2366
	[ComDefaultInterface(typeof(_ParameterBuilder))]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[StructLayout(LayoutKind.Sequential)]
	public class ParameterBuilder : _ParameterBuilder
	{
		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Переданный массив имен, которые необходимо сопоставить.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, зарезервированный вызывающим объектом, куда помещаются идентификаторы, соответствующие именам.</param>
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x060051FE RID: 20990 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _ParameterBuilder.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает сведения о типе объекта, которые затем могут использоваться для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Получает указатель на объект с запрошенными сведениями о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x060051FF RID: 20991 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _ParameterBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Указатель, по которому записывается число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x06005200 RID: 20992 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _ParameterBuilder.GetTypeInfoCount(out uint pcTInfo)
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
		// Token: 0x06005201 RID: 20993 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _ParameterBuilder.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06005202 RID: 20994 RVA: 0x001021E0 File Offset: 0x001003E0
		internal ParameterBuilder(MethodBase mb, int pos, ParameterAttributes attributes, string strParamName)
		{
			this.name = strParamName;
			this.position = pos;
			this.attrs = attributes;
			this.methodb = mb;
			if (mb is DynamicMethod)
			{
				this.table_idx = 0;
				return;
			}
			this.table_idx = mb.get_next_table_index(this, 8, 1);
		}

		/// <summary>Извлекает атрибуты данного параметра.</summary>
		/// <returns>Только для чтения. Извлекает атрибуты данного параметра.</returns>
		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x06005203 RID: 20995 RVA: 0x0010222F File Offset: 0x0010042F
		public virtual int Attributes
		{
			get
			{
				return (int)this.attrs;
			}
		}

		/// <summary>Сообщает, является ли данный параметр входным.</summary>
		/// <returns>Только для чтения. Сообщает, является ли данный параметр входным.</returns>
		// Token: 0x17000D8D RID: 3469
		// (get) Token: 0x06005204 RID: 20996 RVA: 0x00102237 File Offset: 0x00100437
		public bool IsIn
		{
			get
			{
				return (this.attrs & ParameterAttributes.In) > ParameterAttributes.None;
			}
		}

		/// <summary>Сообщает, является ли данный параметр выходным.</summary>
		/// <returns>Только для чтения. Сообщает, является ли данный параметр выходным.</returns>
		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x06005205 RID: 20997 RVA: 0x00102244 File Offset: 0x00100444
		public bool IsOut
		{
			get
			{
				return (this.attrs & ParameterAttributes.Out) > ParameterAttributes.None;
			}
		}

		/// <summary>Сообщает, является ли данный параметр необязательным.</summary>
		/// <returns>Только для чтения. Указывает, является ли данный параметр необязательным.</returns>
		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x06005206 RID: 20998 RVA: 0x00102251 File Offset: 0x00100451
		public bool IsOptional
		{
			get
			{
				return (this.attrs & ParameterAttributes.Optional) > ParameterAttributes.None;
			}
		}

		/// <summary>Извлекает имя данного параметра.</summary>
		/// <returns>Только для чтения. Извлекает имя данного параметра.</returns>
		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x06005207 RID: 20999 RVA: 0x0010225F File Offset: 0x0010045F
		public virtual string Name
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Извлекает позицию подписи для данного параметра.</summary>
		/// <returns>Только для чтения. Извлекает позицию подписи для данного параметра.</returns>
		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x06005208 RID: 21000 RVA: 0x00102267 File Offset: 0x00100467
		public virtual int Position
		{
			get
			{
				return this.position;
			}
		}

		/// <summary>Извлекает токен данного параметра.</summary>
		/// <returns>Токен для этого параметра.</returns>
		// Token: 0x06005209 RID: 21001 RVA: 0x0010226F File Offset: 0x0010046F
		public virtual ParameterToken GetToken()
		{
			return new ParameterToken(8 | this.table_idx);
		}

		/// <summary>Устанавливает значение, присваиваемое параметру по умолчанию.</summary>
		/// <param name="defaultValue">Значение, принимаемое данным параметром по умолчанию.</param>
		/// <exception cref="T:System.ArgumentException">Тип параметра не является поддерживаемым.  
		/// -или- 
		/// Тип параметра <paramref name="defaultValue" /> не совпадает с типом параметра.  
		/// -или- 
		/// Параметр имеет тип <see cref="T:System.Object" /> или другой ссылочный тип, значение параметра <paramref name="defaultValue" /> не равно <see langword="null" />, и значение не может быть присвоено ссылочному типу.</exception>
		// Token: 0x0600520A RID: 21002 RVA: 0x0010227E File Offset: 0x0010047E
		public virtual void SetConstant(object defaultValue)
		{
			if (this.position > 0)
			{
				TypeBuilder.SetConstantValue(this.methodb.GetParameterType(this.position - 1), defaultValue, ref defaultValue);
			}
			this.def_value = defaultValue;
			this.attrs |= ParameterAttributes.HasDefault;
		}

		/// <summary>Задает настраиваемый атрибут с помощью построителя настраиваемых атрибутов.</summary>
		/// <param name="customBuilder">Экземпляр вспомогательного класса для определения настраиваемого атрибута.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="con" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600520B RID: 21003 RVA: 0x001022C0 File Offset: 0x001004C0
		public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
		{
			string fullName = customBuilder.Ctor.ReflectedType.FullName;
			if (fullName == "System.Runtime.InteropServices.InAttribute")
			{
				this.attrs |= ParameterAttributes.In;
				return;
			}
			if (fullName == "System.Runtime.InteropServices.OutAttribute")
			{
				this.attrs |= ParameterAttributes.Out;
				return;
			}
			if (fullName == "System.Runtime.InteropServices.OptionalAttribute")
			{
				this.attrs |= ParameterAttributes.Optional;
				return;
			}
			if (fullName == "System.Runtime.InteropServices.MarshalAsAttribute")
			{
				this.attrs |= ParameterAttributes.HasFieldMarshal;
				this.marshal_info = CustomAttributeBuilder.get_umarshal(customBuilder, false);
				return;
			}
			if (fullName == "System.Runtime.InteropServices.DefaultParameterValueAttribute")
			{
				CustomAttributeBuilder.CustomAttributeInfo customAttributeInfo = CustomAttributeBuilder.decode_cattr(customBuilder);
				this.SetConstant(customAttributeInfo.ctorArgs[0]);
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
		// Token: 0x0600520C RID: 21004 RVA: 0x001023D0 File Offset: 0x001005D0
		[ComVisible(true)]
		public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
		{
			this.SetCustomAttribute(new CustomAttributeBuilder(con, binaryAttribute));
		}

		/// <summary>Задает маршалинг для данного параметра.</summary>
		/// <param name="unmanagedMarshal">Сведения о маршалинге для данного параметра.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="unmanagedMarshal" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600520D RID: 21005 RVA: 0x001023DF File Offset: 0x001005DF
		[Obsolete("An alternate API is available: Emit the MarshalAs custom attribute instead.")]
		public virtual void SetMarshal(UnmanagedMarshal unmanagedMarshal)
		{
			this.marshal_info = unmanagedMarshal;
			this.attrs |= ParameterAttributes.HasFieldMarshal;
		}

		// Token: 0x0600520E RID: 21006 RVA: 0x000173AD File Offset: 0x000155AD
		internal ParameterBuilder()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x040032EE RID: 13038
		private MethodBase methodb;

		// Token: 0x040032EF RID: 13039
		private string name;

		// Token: 0x040032F0 RID: 13040
		private CustomAttributeBuilder[] cattrs;

		// Token: 0x040032F1 RID: 13041
		private UnmanagedMarshal marshal_info;

		// Token: 0x040032F2 RID: 13042
		private ParameterAttributes attrs;

		// Token: 0x040032F3 RID: 13043
		private int position;

		// Token: 0x040032F4 RID: 13044
		private int table_idx;

		// Token: 0x040032F5 RID: 13045
		private object def_value;
	}
}
