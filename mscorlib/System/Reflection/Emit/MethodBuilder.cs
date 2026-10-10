using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using Unity;

namespace System.Reflection.Emit
{
	/// <summary>Определяет и представляет метод (или конструктор) для динамического класса.</summary>
	// Token: 0x02000934 RID: 2356
	[ComVisible(true)]
	[ComDefaultInterface(typeof(_MethodBuilder))]
	[ClassInterface(ClassInterfaceType.None)]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class MethodBuilder : MethodInfo, _MethodBuilder
	{
		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Переданный массив имен, которые необходимо сопоставить.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, зарезервированный вызывающим объектом, куда помещаются идентификаторы, соответствующие именам.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06005100 RID: 20736 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _MethodBuilder.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает сведения о типе объекта, которые затем могут использоваться для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Получает указатель на объект с запрошенными сведениями о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06005101 RID: 20737 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _MethodBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Указатель, по которому записывается число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06005102 RID: 20738 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _MethodBuilder.GetTypeInfoCount(out uint pcTInfo)
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
		// Token: 0x06005103 RID: 20739 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _MethodBuilder.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06005104 RID: 20740 RVA: 0x000FD830 File Offset: 0x000FBA30
		internal MethodBuilder(TypeBuilder tb, string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnModReq, Type[] returnModOpt, Type[] parameterTypes, Type[][] paramModReq, Type[][] paramModOpt)
		{
			this.init_locals = true;
			base..ctor();
			this.name = name;
			this.attrs = attributes;
			this.call_conv = callingConvention;
			this.rtype = returnType;
			this.returnModReq = returnModReq;
			this.returnModOpt = returnModOpt;
			this.paramModReq = paramModReq;
			this.paramModOpt = paramModOpt;
			if ((attributes & MethodAttributes.Static) == MethodAttributes.PrivateScope)
			{
				this.call_conv |= CallingConventions.HasThis;
			}
			if (parameterTypes != null)
			{
				for (int i = 0; i < parameterTypes.Length; i++)
				{
					if (parameterTypes[i] == null)
					{
						throw new ArgumentException("Elements of the parameterTypes array cannot be null", "parameterTypes");
					}
				}
				this.parameters = new Type[parameterTypes.Length];
				Array.Copy(parameterTypes, this.parameters, parameterTypes.Length);
			}
			this.type = tb;
			this.table_idx = this.get_next_table_index(this, 6, 1);
			((ModuleBuilder)tb.Module).RegisterToken(this, this.GetToken().Token);
		}

		// Token: 0x06005105 RID: 20741 RVA: 0x000FD924 File Offset: 0x000FBB24
		internal MethodBuilder(TypeBuilder tb, string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnModReq, Type[] returnModOpt, Type[] parameterTypes, Type[][] paramModReq, Type[][] paramModOpt, string dllName, string entryName, CallingConvention nativeCConv, CharSet nativeCharset) : this(tb, name, attributes, callingConvention, returnType, returnModReq, returnModOpt, parameterTypes, paramModReq, paramModOpt)
		{
			this.pi_dll = dllName;
			this.pi_entry = entryName;
			this.native_cc = nativeCConv;
			this.charset = nativeCharset;
		}

		/// <summary>Не поддерживается для этого типа.</summary>
		/// <returns>Не поддерживается.</returns>
		/// <exception cref="T:System.NotSupportedException">Вызванный метод не поддерживается в базовом классе.</exception>
		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x06005106 RID: 20742 RVA: 0x000472C8 File Offset: 0x000454C8
		public override bool ContainsGenericParameters
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		/// <summary>Возвращает или задает логическое значение, указывающее, инициализируются ли локальные переменные в этом методе нулевым значением. По умолчанию этому свойству присваивается значение <see langword="true" />.</summary>
		/// <returns>Значение <see langword="true" />, если локальные переменные в этом методе должны быть инициализированы нулевым значением. В противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Для текущего метода свойство <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethod" /> имеет значение <see langword="true" />, но свойство <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethodDefinition" /> имеет значение <see langword="false" />. (Получить или установить.)</exception>
		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x06005107 RID: 20743 RVA: 0x000FD968 File Offset: 0x000FBB68
		// (set) Token: 0x06005108 RID: 20744 RVA: 0x000FD970 File Offset: 0x000FBB70
		public bool InitLocals
		{
			get
			{
				return this.init_locals;
			}
			set
			{
				this.init_locals = value;
			}
		}

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x06005109 RID: 20745 RVA: 0x000FD979 File Offset: 0x000FBB79
		internal TypeBuilder TypeBuilder
		{
			get
			{
				return this.type;
			}
		}

		/// <summary>Извлекает внутренний маркер метода. Используйте этот маркер для доступа к основному дескриптору метаданных.</summary>
		/// <returns>Только для чтения. Внутренний маркер метода. Используйте этот дескриптор для доступа к дескриптору базовых метаданных.</returns>
		/// <exception cref="T:System.NotSupportedException">В настоящее время этот метод не поддерживается. Извлеките метод с помощью <see cref="M:System.Type.GetMethod(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> и вызовите <see cref="P:System.Reflection.MethodBase.MethodHandle" /> в возвращенном методе <see cref="T:System.Reflection.MethodInfo" />.</exception>
		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x0600510A RID: 20746 RVA: 0x000FD981 File Offset: 0x000FBB81
		public override RuntimeMethodHandle MethodHandle
		{
			get
			{
				throw this.NotSupported();
			}
		}

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x0600510B RID: 20747 RVA: 0x000FD989 File Offset: 0x000FBB89
		internal RuntimeMethodHandle MethodHandleInternal
		{
			get
			{
				return this.mhandle;
			}
		}

		/// <summary>Возвращает метод, представленный этим <see cref="T:System.Reflection.Emit.MethodBuilder" />.</summary>
		/// <returns>Возвращаемый тип метода.</returns>
		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x0600510C RID: 20748 RVA: 0x000FD991 File Offset: 0x000FBB91
		public override Type ReturnType
		{
			get
			{
				return this.rtype;
			}
		}

		/// <summary>Возвращает класс, который использовался в отражении для получения этого объекта.</summary>
		/// <returns>Только для чтения. Тип, используемый для получения этого метода.</returns>
		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x0600510D RID: 20749 RVA: 0x000FD979 File Offset: 0x000FBB79
		public override Type ReflectedType
		{
			get
			{
				return this.type;
			}
		}

		/// <summary>Возвращает тип, объявляющий этот метод.</summary>
		/// <returns>Только для чтения. Тип, объявляющий этот метод.</returns>
		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x0600510E RID: 20750 RVA: 0x000FD979 File Offset: 0x000FBB79
		public override Type DeclaringType
		{
			get
			{
				return this.type;
			}
		}

		/// <summary>Извлекает имя данного метода.</summary>
		/// <returns>Только для чтения. Извлекает строку, содержащую простое имя этого метода.</returns>
		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x0600510F RID: 20751 RVA: 0x000FD999 File Offset: 0x000FBB99
		public override string Name
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Извлекает атрибуты для данного метода.</summary>
		/// <returns>Только для чтения. Извлекает <see langword="MethodAttributes" /> для данного метода.</returns>
		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x06005110 RID: 20752 RVA: 0x000FD9A1 File Offset: 0x000FBBA1
		public override MethodAttributes Attributes
		{
			get
			{
				return this.attrs;
			}
		}

		/// <summary>Возвращает настраиваемые атрибуты типа возвращаемого значения метода.</summary>
		/// <returns>Только для чтения. Настраиваемые атрибуты типа возвращаемого значения метода.</returns>
		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x06005111 RID: 20753 RVA: 0x0000AF5E File Offset: 0x0000915E
		public override ICustomAttributeProvider ReturnTypeCustomAttributes
		{
			get
			{
				return null;
			}
		}

		/// <summary>Возвращает соглашение о вызовах метода.</summary>
		/// <returns>Только для чтения. Соглашение о вызовах метода.</returns>
		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x06005112 RID: 20754 RVA: 0x000FD9A9 File Offset: 0x000FBBA9
		public override CallingConventions CallingConvention
		{
			get
			{
				return this.call_conv;
			}
		}

		/// <summary>Извлекает сигнатуру метода.</summary>
		/// <returns>Только для чтения. Строка, содержащая сигнатуру метода, отражаемую этим экземпляром <see langword="MethodBase" />.</returns>
		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x06005113 RID: 20755 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO("Not implemented")]
		public string Signature
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x17000D65 RID: 3429
		// (set) Token: 0x06005114 RID: 20756 RVA: 0x000FD9B1 File Offset: 0x000FBBB1
		internal bool BestFitMapping
		{
			set
			{
				this.extra_flags = (uint)(((ulong)this.extra_flags & 18446744073709551567UL) | (value ? 16UL : 32UL));
			}
		}

		// Token: 0x17000D66 RID: 3430
		// (set) Token: 0x06005115 RID: 20757 RVA: 0x000FD9D0 File Offset: 0x000FBBD0
		internal bool ThrowOnUnmappableChar
		{
			set
			{
				this.extra_flags = (uint)(((ulong)this.extra_flags & 18446744073709539327UL) | (value ? 4096UL : 8192UL));
			}
		}

		// Token: 0x17000D67 RID: 3431
		// (set) Token: 0x06005116 RID: 20758 RVA: 0x000FD9F8 File Offset: 0x000FBBF8
		internal bool ExactSpelling
		{
			set
			{
				this.extra_flags = (uint)(((ulong)this.extra_flags & 18446744073709551614UL) | (value ? 1UL : 0UL));
			}
		}

		// Token: 0x17000D68 RID: 3432
		// (set) Token: 0x06005117 RID: 20759 RVA: 0x000FDA15 File Offset: 0x000FBC15
		internal bool SetLastError
		{
			set
			{
				this.extra_flags = (uint)(((ulong)this.extra_flags & 18446744073709551551UL) | (value ? 64UL : 0UL));
			}
		}

		/// <summary>Возвращает объект <see langword="MethodToken" />, представляющий маркер для этого метода.</summary>
		/// <returns>Возвращает объект <see langword="MethodToken" /> этого метода.</returns>
		// Token: 0x06005118 RID: 20760 RVA: 0x000FDA33 File Offset: 0x000FBC33
		public MethodToken GetToken()
		{
			return new MethodToken(100663296 | this.table_idx);
		}

		/// <summary>Возвращает базовую реализацию метода.</summary>
		/// <returns>Базовая реализация этого метода.</returns>
		// Token: 0x06005119 RID: 20761 RVA: 0x0000270D File Offset: 0x0000090D
		public override MethodInfo GetBaseDefinition()
		{
			return this;
		}

		/// <summary>Возвращает флаги реализации для метода.</summary>
		/// <returns>Возвращает флаги реализации для метода.</returns>
		// Token: 0x0600511A RID: 20762 RVA: 0x000FDA46 File Offset: 0x000FBC46
		public override MethodImplAttributes GetMethodImplementationFlags()
		{
			return this.iattrs;
		}

		/// <summary>Возвращает параметры данного метода.</summary>
		/// <returns>Массив объектов <see langword="ParameterInfo" />, которые представляют параметры метода.</returns>
		/// <exception cref="T:System.NotSupportedException">В настоящее время этот метод не поддерживается. Извлеките метод с помощью <see cref="M:System.Type.GetMethod(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> и вызовите <see langword="GetParameters" /> в возвращенном методе <see cref="T:System.Reflection.MethodInfo" />.</exception>
		// Token: 0x0600511B RID: 20763 RVA: 0x000FDA4E File Offset: 0x000FBC4E
		public override ParameterInfo[] GetParameters()
		{
			if (!this.type.is_created)
			{
				throw this.NotSupported();
			}
			return this.GetParametersInternal();
		}

		// Token: 0x0600511C RID: 20764 RVA: 0x000FDA6C File Offset: 0x000FBC6C
		internal override ParameterInfo[] GetParametersInternal()
		{
			if (this.parameters == null)
			{
				return null;
			}
			ParameterInfo[] array = new ParameterInfo[this.parameters.Length];
			for (int i = 0; i < this.parameters.Length; i++)
			{
				ParameterInfo[] array2 = array;
				int num = i;
				ParameterBuilder[] array3 = this.pinfo;
				array2[num] = RuntimeParameterInfo.New((array3 != null) ? array3[i + 1] : null, this.parameters[i], this, i + 1);
			}
			return array;
		}

		// Token: 0x0600511D RID: 20765 RVA: 0x000FDACA File Offset: 0x000FBCCA
		internal override int GetParametersCount()
		{
			if (this.parameters == null)
			{
				return 0;
			}
			return this.parameters.Length;
		}

		// Token: 0x0600511E RID: 20766 RVA: 0x000FDADE File Offset: 0x000FBCDE
		internal override Type GetParameterType(int pos)
		{
			return this.parameters[pos];
		}

		// Token: 0x0600511F RID: 20767 RVA: 0x000FDAE8 File Offset: 0x000FBCE8
		internal MethodBase RuntimeResolve()
		{
			return this.type.RuntimeResolve().GetMethod(this);
		}

		/// <summary>Возвращает ссылку на модуль, содержащий этот метод.</summary>
		/// <returns>Возвращает ссылку на модуль, содержащий этот метод.</returns>
		// Token: 0x06005120 RID: 20768 RVA: 0x000FDAFB File Offset: 0x000FBCFB
		public Module GetModule()
		{
			return this.type.Module;
		}

		/// <summary>Создает тело метода с использованием предоставленного массива байтов инструкций промежуточного языка Майкрософт (MSIL).</summary>
		/// <param name="il">Массив, содержащий допустимые инструкции MSIL. Если этот параметр равен <see langword="null" />, тело метода очищается.</param>
		/// <param name="count">Число допустимых байтов в массиве MSIL. Это значение игнорируется, если MSIL — <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="count" /> выходит за пределы диапазона индексов предоставленного массива инструкций MSIL, и <paramref name="il" /> не равно <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Содержащий тип был создан ранее с помощью <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.  
		///
		/// или - 
		/// Этот метод был вызван ранее применительно к этому <see langword="MethodBuilder" /> с аргументом <paramref name="il" />, не равным <see langword="null" />.  
		///
		/// или - 
		/// Для текущего метода свойство <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethod" /> имеет значение <see langword="true" />, но свойство <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethodDefinition" /> имеет значение <see langword="false" />.</exception>
		// Token: 0x06005121 RID: 20769 RVA: 0x000FDB08 File Offset: 0x000FBD08
		public void CreateMethodBody(byte[] il, int count)
		{
			if (il != null && (count < 0 || count > il.Length))
			{
				throw new ArgumentOutOfRangeException("Index was out of range.  Must be non-negative and less than the size of the collection.");
			}
			if (this.code != null || this.type.is_created)
			{
				throw new InvalidOperationException("Type definition of the method is complete.");
			}
			if (il == null)
			{
				this.code = null;
				return;
			}
			this.code = new byte[count];
			Array.Copy(il, this.code, count);
		}

		/// <summary>Создает тело метода с использованием указанного массива байтов инструкций промежуточного языка Майкрософт (MSIL).</summary>
		/// <param name="il">Массив, содержащий допустимые инструкции MSIL.</param>
		/// <param name="maxStack">Максимальная глубина оценки стека.</param>
		/// <param name="localSignature">Массив байтов, содержащий сериализованную структуру локальной переменной. Укажите <see langword="null" />, если у метода нет локальных переменных.</param>
		/// <param name="exceptionHandlers">Коллекция, содержащая обработчики исключений для метода. Укажите <see langword="null" />, если у метода нет обработчиков исключений.</param>
		/// <param name="tokenFixups">Коллекция значений, представляющих смещения в <paramref name="il" />, каждое из которых задает начало маркера, который может быть изменен. Укажите <see langword="null" />, если у метода нет маркеров, которые должны быть изменены.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="il" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="maxStack" /> является отрицательным значением.  
		///
		/// или - 
		/// Один из <paramref name="exceptionHandlers" /> указывает смещение за пределами <paramref name="il" />.  
		///
		/// или - 
		/// Один из <paramref name="tokenFixups" /> указывает смещение, которое находится за пределами массива <paramref name="il" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Содержащий тип был создан ранее с помощью метода <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.  
		///
		/// или - 
		/// Этот метод был вызван ранее для этого объекта <see cref="T:System.Reflection.Emit.MethodBuilder" />.</exception>
		// Token: 0x06005122 RID: 20770 RVA: 0x000FDB71 File Offset: 0x000FBD71
		public void SetMethodBody(byte[] il, int maxStack, byte[] localSignature, IEnumerable<ExceptionHandler> exceptionHandlers, IEnumerable<int> tokenFixups)
		{
			this.GetILGenerator().Init(il, maxStack, localSignature, exceptionHandlers, tokenFixups);
		}

		/// <summary>Динамически вызывает метод, отраженный этим экземпляром для данного объекта, передавая указанные параметры и учитывая ограничения данного модуля привязки.</summary>
		/// <param name="obj">Объект, для которого нужно вызвать указанный метод. Если метод является статическим, этот параметр игнорируется.</param>
		/// <param name="invokeAttr">Это должен быть одноразрядный флаг из <see cref="T:System.Reflection.BindingFlags" /> : <see langword="InvokeMethod" />, <see langword="NonPublic" /> и так далее.</param>
		/// <param name="binder">Объект, позволяющий осуществлять привязку, приведение типов аргументов, вызов членов, а также поиск объектов MemberInfo с помощью отражения. Если модуль привязки имеет значение <see langword="null" />, используется модуль привязки по умолчанию. Дополнительные сведения см. в разделе <see cref="T:System.Reflection.Binder" />.</param>
		/// <param name="parameters">Список аргументов. Это массив аргументов с тем же числом, порядком и типом, что и параметры вызываемого метода. Если параметров нет, должно быть указано значение <see langword="null" />.</param>
		/// <param name="culture">Экземпляр объекта <see cref="T:System.Globalization.CultureInfo" />, используемого для управления приведением типов. Если значение параметра — NULL, для текущего потока используется <see cref="T:System.Globalization.CultureInfo" />. (Это необходимо, например, чтобы преобразовывать объект <see cref="T:System.String" />, представляющий 1000, в значение <see cref="T:System.Double" />, поскольку в разных языках и региональных параметрах 1000 представляется по-разному.)</param>
		/// <returns>Возвращает объект, содержащий возвращаемое значение вызываемого элемента.</returns>
		/// <exception cref="T:System.NotSupportedException">В настоящее время этот метод не поддерживается. Извлеките метод с помощью <see cref="M:System.Type.GetMethod(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> и вызовите <see cref="M:System.Type.InvokeMember(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object,System.Object[],System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[])" /> в возвращенном методе <see cref="T:System.Reflection.MethodInfo" />.</exception>
		// Token: 0x06005123 RID: 20771 RVA: 0x000FD981 File Offset: 0x000FBB81
		public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			throw this.NotSupported();
		}

		/// <summary>Проверяет, определен ли заданный тип настраиваемого атрибута.</summary>
		/// <param name="attributeType">Тип настраиваемого атрибута.</param>
		/// <param name="inherit">Указывает, следует ли выполнять поиск в цепочке наследования этого члена для нахождения настраиваемых атрибутов.</param>
		/// <returns>Значение <see langword="true" />, если заданный тип настраиваемых атрибутов определен; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.NotSupportedException">В настоящее время этот метод не поддерживается. Извлеките метод с помощью <see cref="M:System.Type.GetMethod(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> и вызовите <see cref="M:System.Reflection.MemberInfo.IsDefined(System.Type,System.Boolean)" /> в возвращенном методе <see cref="T:System.Reflection.MethodInfo" />.</exception>
		// Token: 0x06005124 RID: 20772 RVA: 0x000FD981 File Offset: 0x000FBB81
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			throw this.NotSupported();
		}

		/// <summary>Возвращает все настраиваемые атрибуты, определенные для данного метода.</summary>
		/// <param name="inherit">Указывает, следует ли выполнять поиск в цепочке наследования этого члена для нахождения настраиваемых атрибутов.</param>
		/// <returns>Возвращает массив объектов, представляющих все настраиваемые атрибуты этого метода.</returns>
		/// <exception cref="T:System.NotSupportedException">В настоящее время этот метод не поддерживается. Извлеките метод с помощью <see cref="M:System.Type.GetMethod(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> и вызовите <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Boolean)" /> в возвращенном методе <see cref="T:System.Reflection.MethodInfo" />.</exception>
		// Token: 0x06005125 RID: 20773 RVA: 0x000FDB85 File Offset: 0x000FBD85
		public override object[] GetCustomAttributes(bool inherit)
		{
			if (this.type.is_created)
			{
				return MonoCustomAttrs.GetCustomAttributes(this, inherit);
			}
			throw this.NotSupported();
		}

		/// <summary>Возвращает настраиваемые атрибуты, определяемые заданным типом.</summary>
		/// <param name="attributeType">Тип настраиваемого атрибута.</param>
		/// <param name="inherit">Указывает, следует ли выполнять поиск в цепочке наследования этого члена для нахождения настраиваемых атрибутов.</param>
		/// <returns>Возвращает массив объектов, представляющих атрибуты этого метода, которые имеют тип <paramref name="attributeType" />.</returns>
		/// <exception cref="T:System.NotSupportedException">В настоящее время этот метод не поддерживается. Извлеките метод с помощью <see cref="M:System.Type.GetMethod(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> и вызовите <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Boolean)" /> в возвращенном методе <see cref="T:System.Reflection.MethodInfo" />.</exception>
		// Token: 0x06005126 RID: 20774 RVA: 0x000FDBA2 File Offset: 0x000FBDA2
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			if (this.type.is_created)
			{
				return MonoCustomAttrs.GetCustomAttributes(this, attributeType, inherit);
			}
			throw this.NotSupported();
		}

		/// <summary>Возвращает <see langword="ILGenerator" /> для этого метода с потоком промежуточного языка Майкрософт (MSIL), имеющим размер по умолчанию (64 байта).</summary>
		/// <returns>Возвращает объект <see langword="ILGenerator" /> для этого метода.</returns>
		/// <exception cref="T:System.InvalidOperationException">Метод не должен иметь тело из-за своих флагов <see cref="T:System.Reflection.MethodAttributes" /> или <see cref="T:System.Reflection.MethodImplAttributes" />, например, потому что имеет флаг <see cref="F:System.Reflection.MethodAttributes.PinvokeImpl" />.  
		///
		/// или - 
		/// Метод является универсальным методом, но не определением универсального метода. Свойство <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethod" /> имеет значение <see langword="true" />, однако свойство <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethodDefinition" /> имеет значение <see langword="false" />.</exception>
		// Token: 0x06005127 RID: 20775 RVA: 0x000FDBC0 File Offset: 0x000FBDC0
		public ILGenerator GetILGenerator()
		{
			return this.GetILGenerator(64);
		}

		/// <summary>Возвращает <see langword="ILGenerator" /> для этого метода с указанным размером потока MSIL.</summary>
		/// <param name="size">Размер потока MSIL (в байтах).</param>
		/// <returns>Возвращает объект <see langword="ILGenerator" /> для этого метода.</returns>
		/// <exception cref="T:System.InvalidOperationException">Метод не должен иметь тело из-за своих флагов <see cref="T:System.Reflection.MethodAttributes" /> или <see cref="T:System.Reflection.MethodImplAttributes" />, например, потому что имеет флаг <see cref="F:System.Reflection.MethodAttributes.PinvokeImpl" />.  
		///
		/// или - 
		/// Метод является универсальным методом, но не определением универсального метода. Свойство <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethod" /> имеет значение <see langword="true" />, однако свойство <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethodDefinition" /> имеет значение <see langword="false" />.</exception>
		// Token: 0x06005128 RID: 20776 RVA: 0x000FDBCC File Offset: 0x000FBDCC
		public ILGenerator GetILGenerator(int size)
		{
			if ((this.iattrs & MethodImplAttributes.CodeTypeMask) != MethodImplAttributes.IL || (this.iattrs & MethodImplAttributes.ManagedMask) != MethodImplAttributes.IL)
			{
				throw new InvalidOperationException("Method body should not exist.");
			}
			if (this.ilgen != null)
			{
				return this.ilgen;
			}
			this.ilgen = new ILGenerator(this.type.Module, ((ModuleBuilder)this.type.Module).GetTokenGenerator(), size);
			return this.ilgen;
		}

		/// <summary>Задает атрибуты параметров и имя параметра этого метода или возвращаемого значения данного метода. Возвращает ParameterBuilder, который можно использовать для применения настраиваемых атрибутов.</summary>
		/// <param name="position">Позиция параметра в списке параметров. Параметры индексируются, начиная с номера 1 для первого параметра; число 0 представляет возвращаемое значение метода.</param>
		/// <param name="attributes">Атрибуты параметра.</param>
		/// <param name="strParamName">Имя параметра. Имя может быть пустой строкой.</param>
		/// <returns>Возвращает объект <see langword="ParameterBuilder" />, представляющий параметр этого метода или возвращаемое значение этого метода.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Метод не имеет параметров.  
		///
		/// или - 
		/// Значение параметра <paramref name="position" /> меньше нуля.  
		///
		/// или - 
		/// <paramref name="position" /> превышает число параметров метода.</exception>
		/// <exception cref="T:System.InvalidOperationException">Содержащий тип был создан ранее с помощью <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.  
		///
		/// или - 
		/// Для текущего метода свойство <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethod" /> имеет значение <see langword="true" />, но свойство <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethodDefinition" /> имеет значение <see langword="false" />.</exception>
		// Token: 0x06005129 RID: 20777 RVA: 0x000FDC3C File Offset: 0x000FBE3C
		public ParameterBuilder DefineParameter(int position, ParameterAttributes attributes, string strParamName)
		{
			this.RejectIfCreated();
			if (position < 0 || this.parameters == null || position > this.parameters.Length)
			{
				throw new ArgumentOutOfRangeException("position");
			}
			ParameterBuilder parameterBuilder = new ParameterBuilder(this, position, attributes, strParamName);
			if (this.pinfo == null)
			{
				this.pinfo = new ParameterBuilder[this.parameters.Length + 1];
			}
			this.pinfo[position] = parameterBuilder;
			return parameterBuilder;
		}

		// Token: 0x0600512A RID: 20778 RVA: 0x000FDCA4 File Offset: 0x000FBEA4
		internal void check_override()
		{
			if (this.override_methods != null)
			{
				foreach (MethodInfo methodInfo in this.override_methods)
				{
					if (methodInfo.IsVirtual && !base.IsVirtual)
					{
						throw new TypeLoadException(string.Format("Method '{0}' override '{1}' but it is not virtual", this.name, methodInfo));
					}
				}
			}
		}

		// Token: 0x0600512B RID: 20779 RVA: 0x000FDCFC File Offset: 0x000FBEFC
		internal void fixup()
		{
			if ((this.attrs & (MethodAttributes.Abstract | MethodAttributes.PinvokeImpl)) == MethodAttributes.PrivateScope && (this.iattrs & (MethodImplAttributes)4099) == MethodImplAttributes.IL && (this.ilgen == null || this.ilgen.ILOffset == 0) && (this.code == null || this.code.Length == 0))
			{
				throw new InvalidOperationException(string.Format("Method '{0}.{1}' does not have a method body.", this.DeclaringType.FullName, this.Name));
			}
			if (this.ilgen != null)
			{
				this.ilgen.label_fixup(this);
			}
		}

		// Token: 0x0600512C RID: 20780 RVA: 0x000FDD80 File Offset: 0x000FBF80
		internal void ResolveUserTypes()
		{
			this.rtype = TypeBuilder.ResolveUserType(this.rtype);
			TypeBuilder.ResolveUserTypes(this.parameters);
			TypeBuilder.ResolveUserTypes(this.returnModReq);
			TypeBuilder.ResolveUserTypes(this.returnModOpt);
			if (this.paramModReq != null)
			{
				Type[][] array = this.paramModReq;
				for (int i = 0; i < array.Length; i++)
				{
					TypeBuilder.ResolveUserTypes(array[i]);
				}
			}
			if (this.paramModOpt != null)
			{
				Type[][] array = this.paramModOpt;
				for (int i = 0; i < array.Length; i++)
				{
					TypeBuilder.ResolveUserTypes(array[i]);
				}
			}
		}

		// Token: 0x0600512D RID: 20781 RVA: 0x000FDE09 File Offset: 0x000FC009
		internal void FixupTokens(Dictionary<int, int> token_map, Dictionary<int, MemberInfo> member_map)
		{
			if (this.ilgen != null)
			{
				this.ilgen.FixupTokens(token_map, member_map);
			}
		}

		// Token: 0x0600512E RID: 20782 RVA: 0x000FDE20 File Offset: 0x000FC020
		internal void GenerateDebugInfo(ISymbolWriter symbolWriter)
		{
			if (this.ilgen != null && this.ilgen.HasDebugInfo)
			{
				SymbolToken symbolToken = new SymbolToken(this.GetToken().Token);
				symbolWriter.OpenMethod(symbolToken);
				symbolWriter.SetSymAttribute(symbolToken, "__name", Encoding.UTF8.GetBytes(this.Name));
				this.ilgen.GenerateDebugInfo(symbolWriter);
				symbolWriter.CloseMethod();
			}
		}

		/// <summary>Задает настраиваемый атрибут с помощью построителя настраиваемых атрибутов.</summary>
		/// <param name="customBuilder">Экземпляр вспомогательного класса для описания настраиваемого атрибута.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="customBuilder" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для текущего метода свойство <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethod" /> имеет значение <see langword="true" />, но свойство <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethodDefinition" /> имеет значение <see langword="false" />.</exception>
		// Token: 0x0600512F RID: 20783 RVA: 0x000FDE8C File Offset: 0x000FC08C
		public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
		{
			if (customBuilder == null)
			{
				throw new ArgumentNullException("customBuilder");
			}
			string fullName = customBuilder.Ctor.ReflectedType.FullName;
			if (fullName == "System.Runtime.CompilerServices.MethodImplAttribute")
			{
				byte[] data = customBuilder.Data;
				int num = (int)data[2];
				num |= (int)data[3] << 8;
				this.iattrs |= (MethodImplAttributes)num;
				return;
			}
			if (!(fullName == "System.Runtime.InteropServices.DllImportAttribute"))
			{
				if (fullName == "System.Runtime.InteropServices.PreserveSigAttribute")
				{
					this.iattrs |= MethodImplAttributes.PreserveSig;
					return;
				}
				if (fullName == "System.Runtime.CompilerServices.SpecialNameAttribute")
				{
					this.attrs |= MethodAttributes.SpecialName;
					return;
				}
				if (fullName == "System.Security.SuppressUnmanagedCodeSecurityAttribute")
				{
					this.attrs |= MethodAttributes.HasSecurity;
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
				return;
			}
			else
			{
				CustomAttributeBuilder.CustomAttributeInfo customAttributeInfo = CustomAttributeBuilder.decode_cattr(customBuilder);
				bool flag = true;
				this.pi_dll = (string)customAttributeInfo.ctorArgs[0];
				if (this.pi_dll == null || this.pi_dll.Length == 0)
				{
					throw new ArgumentException("DllName cannot be empty");
				}
				this.native_cc = System.Runtime.InteropServices.CallingConvention.Winapi;
				for (int i = 0; i < customAttributeInfo.namedParamNames.Length; i++)
				{
					string a = customAttributeInfo.namedParamNames[i];
					object obj = customAttributeInfo.namedParamValues[i];
					if (a == "CallingConvention")
					{
						this.native_cc = (CallingConvention)obj;
					}
					else if (a == "CharSet")
					{
						this.charset = (CharSet)obj;
					}
					else if (a == "EntryPoint")
					{
						this.pi_entry = (string)obj;
					}
					else if (a == "ExactSpelling")
					{
						this.ExactSpelling = (bool)obj;
					}
					else if (a == "SetLastError")
					{
						this.SetLastError = (bool)obj;
					}
					else if (a == "PreserveSig")
					{
						flag = (bool)obj;
					}
					else if (a == "BestFitMapping")
					{
						this.BestFitMapping = (bool)obj;
					}
					else if (a == "ThrowOnUnmappableChar")
					{
						this.ThrowOnUnmappableChar = (bool)obj;
					}
				}
				this.attrs |= MethodAttributes.PinvokeImpl;
				if (flag)
				{
					this.iattrs |= MethodImplAttributes.PreserveSig;
				}
				return;
			}
		}

		/// <summary>Задает настраиваемый атрибут с помощью большого двоичного объекта пользовательских атрибутов.</summary>
		/// <param name="con">Конструктор настраиваемого атрибута.</param>
		/// <param name="binaryAttribute">Большой двоичный объект байтов, представляющий атрибуты.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="con" /> или <paramref name="binaryAttribute" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для текущего метода свойство <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethod" /> имеет значение <see langword="true" />, но свойство <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethodDefinition" /> имеет значение <see langword="false" />.</exception>
		// Token: 0x06005130 RID: 20784 RVA: 0x000FE140 File Offset: 0x000FC340
		[ComVisible(true)]
		public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
		{
			if (con == null)
			{
				throw new ArgumentNullException("con");
			}
			if (binaryAttribute == null)
			{
				throw new ArgumentNullException("binaryAttribute");
			}
			this.SetCustomAttribute(new CustomAttributeBuilder(con, binaryAttribute));
		}

		/// <summary>Задает флаги реализации для этого метода.</summary>
		/// <param name="attributes">Флаги реализации для установки.</param>
		/// <exception cref="T:System.InvalidOperationException">Содержащий тип был создан ранее с помощью <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.  
		///
		/// или - 
		/// Для текущего метода свойство <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethod" /> имеет значение <see langword="true" />, но свойство <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethodDefinition" /> имеет значение <see langword="false" />.</exception>
		// Token: 0x06005131 RID: 20785 RVA: 0x000FE171 File Offset: 0x000FC371
		public void SetImplementationFlags(MethodImplAttributes attributes)
		{
			this.RejectIfCreated();
			this.iattrs = attributes;
		}

		/// <summary>Добавляет декларативную безопасность в этот метод.</summary>
		/// <param name="action">Выполняемое действие для безопасности (Demand, Assert и т. д.).</param>
		/// <param name="pset">Набор разрешений, к которому применяется действие.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="action" /> является недопустимым (<see langword="RequestMinimum" />, <see langword="RequestOptional" /> и <see langword="RequestRefuse" /> являются недопустимыми).</exception>
		/// <exception cref="T:System.InvalidOperationException">Содержащий тип был создан с помощью <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.  
		///
		/// или - 
		/// Набор разрешений <paramref name="pset" /> содержит действие, добавленное ранее с помощью <see cref="M:System.Reflection.Emit.MethodBuilder.AddDeclarativeSecurity(System.Security.Permissions.SecurityAction,System.Security.PermissionSet)" />.  
		///
		/// или - 
		/// Для текущего метода свойство <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethod" /> имеет значение <see langword="true" />, но свойство <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethodDefinition" /> имеет значение <see langword="false" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pset" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06005132 RID: 20786 RVA: 0x000FE180 File Offset: 0x000FC380
		public void AddDeclarativeSecurity(SecurityAction action, PermissionSet pset)
		{
			if (pset == null)
			{
				throw new ArgumentNullException("pset");
			}
			if (action == SecurityAction.RequestMinimum || action == SecurityAction.RequestOptional || action == SecurityAction.RequestRefuse)
			{
				throw new ArgumentOutOfRangeException("Request* values are not permitted", "action");
			}
			this.RejectIfCreated();
			if (this.permissions != null)
			{
				RefEmitPermissionSet[] array = this.permissions;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].action == action)
					{
						throw new InvalidOperationException("Multiple permission sets specified with the same SecurityAction.");
					}
				}
				RefEmitPermissionSet[] array2 = new RefEmitPermissionSet[this.permissions.Length + 1];
				this.permissions.CopyTo(array2, 0);
				this.permissions = array2;
			}
			else
			{
				this.permissions = new RefEmitPermissionSet[1];
			}
			this.permissions[this.permissions.Length - 1] = new RefEmitPermissionSet(action, pset.ToXml().ToString());
			this.attrs |= MethodAttributes.HasSecurity;
		}

		/// <summary>Задает сведения о маршалинге для типа возвращаемого значения этого метода.</summary>
		/// <param name="unmanagedMarshal">Сведения о маршалинге для типа возвращаемого значения этого метода.</param>
		/// <exception cref="T:System.InvalidOperationException">Содержащий тип был создан ранее с помощью <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.  
		///
		/// или - 
		/// Для текущего метода свойство <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethod" /> имеет значение <see langword="true" />, но свойство <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethodDefinition" /> имеет значение <see langword="false" />.</exception>
		// Token: 0x06005133 RID: 20787 RVA: 0x000FE260 File Offset: 0x000FC460
		[Obsolete("An alternate API is available: Emit the MarshalAs custom attribute instead.")]
		public void SetMarshal(UnmanagedMarshal unmanagedMarshal)
		{
			this.RejectIfCreated();
			throw new NotImplementedException();
		}

		/// <summary>Задает символьный настраиваемый атрибут с помощью большого двоичного объекта.</summary>
		/// <param name="name">Имя символьного настраиваемого атрибута.</param>
		/// <param name="data">Большой двоичный объект байтов, представляющий значение символьного настраиваемого атрибута.</param>
		/// <exception cref="T:System.InvalidOperationException">Содержащий тип был создан ранее с помощью <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.  
		///
		/// или - 
		/// Модуль, содержащий этот метод, не является модулем отладки.  
		///
		/// или - 
		/// Для текущего метода свойство <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethod" /> имеет значение <see langword="true" />, но свойство <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethodDefinition" /> имеет значение <see langword="false" />.</exception>
		// Token: 0x06005134 RID: 20788 RVA: 0x000FE260 File Offset: 0x000FC460
		[MonoTODO]
		public void SetSymCustomAttribute(string name, byte[] data)
		{
			this.RejectIfCreated();
			throw new NotImplementedException();
		}

		/// <summary>Возвращает этот экземпляр <see langword="MethodBuilder" /> в виде строки.</summary>
		/// <returns>Возвращает строку, содержащую имя, атрибуты, сигнатуру метода, исключения и локальную сигнатуру данного метода, за которой следует текущий поток MSIL.</returns>
		// Token: 0x06005135 RID: 20789 RVA: 0x000FE26D File Offset: 0x000FC46D
		[SecuritySafeCritical]
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"MethodBuilder [",
				this.type.Name,
				"::",
				this.name,
				"]"
			});
		}

		/// <summary>Определяет, равен ли данный объект этому экземпляру.</summary>
		/// <param name="obj">Объект, сравниваемый с этим экземпляром <see langword="MethodBuilder" />.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="obj" /> является экземпляром <see langword="MethodBuilder" /> и равен этому объекту; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06005136 RID: 20790 RVA: 0x000FE2A9 File Offset: 0x000FC4A9
		[MonoTODO]
		[SecuritySafeCritical]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		/// <summary>Возвращает хэш-код для этого метода.</summary>
		/// <returns>Хэш-код для этого метода.</returns>
		// Token: 0x06005137 RID: 20791 RVA: 0x000FE2B2 File Offset: 0x000FC4B2
		public override int GetHashCode()
		{
			return this.name.GetHashCode();
		}

		// Token: 0x06005138 RID: 20792 RVA: 0x000FE2BF File Offset: 0x000FC4BF
		internal override int get_next_table_index(object obj, int table, int count)
		{
			return this.type.get_next_table_index(obj, table, count);
		}

		// Token: 0x06005139 RID: 20793 RVA: 0x000FE2D0 File Offset: 0x000FC4D0
		private void ExtendArray<T>(ref T[] array, T elem)
		{
			if (array == null)
			{
				array = new T[1];
			}
			else
			{
				T[] array2 = new T[array.Length + 1];
				Array.Copy(array, array2, array.Length);
				array = array2;
			}
			array[array.Length - 1] = elem;
		}

		// Token: 0x0600513A RID: 20794 RVA: 0x000FE314 File Offset: 0x000FC514
		internal void set_override(MethodInfo mdecl)
		{
			this.ExtendArray<MethodInfo>(ref this.override_methods, mdecl);
		}

		// Token: 0x0600513B RID: 20795 RVA: 0x000FE323 File Offset: 0x000FC523
		private void RejectIfCreated()
		{
			if (this.type.is_created)
			{
				throw new InvalidOperationException("Type definition of the method is complete.");
			}
		}

		// Token: 0x0600513C RID: 20796 RVA: 0x000F79D6 File Offset: 0x000F5BD6
		private Exception NotSupported()
		{
			return new NotSupportedException("The invoked member is not supported in a dynamic module.");
		}

		/// <summary>Возвращает универсальный метод, построенный на основе определения текущего универсального метода с использованием указанных аргументов универсального типа.</summary>
		/// <param name="typeArguments">Массив объектов <see cref="T:System.Type" />, которые представляют аргументы типа для универсального метода.</param>
		/// <returns>Сведения <see cref="T:System.Reflection.MethodInfo" />, представляющие универсальный метод, построенный на основе определения текущего универсального метода с использованием указанных аргументов универсального типа.</returns>
		// Token: 0x0600513D RID: 20797 RVA: 0x000FE340 File Offset: 0x000FC540
		public override MethodInfo MakeGenericMethod(params Type[] typeArguments)
		{
			if (!this.IsGenericMethodDefinition)
			{
				throw new InvalidOperationException("Method is not a generic method definition");
			}
			if (typeArguments == null)
			{
				throw new ArgumentNullException("typeArguments");
			}
			if (this.generic_params.Length != typeArguments.Length)
			{
				throw new ArgumentException("Incorrect length", "typeArguments");
			}
			for (int i = 0; i < typeArguments.Length; i++)
			{
				if (typeArguments[i] == null)
				{
					throw new ArgumentNullException("typeArguments");
				}
			}
			return new MethodOnTypeBuilderInst(this, typeArguments);
		}

		/// <summary>Получает значение, указывающее, представляет ли текущий объект <see cref="T:System.Reflection.Emit.MethodBuilder" /> определение универсального метода.</summary>
		/// <returns>Значение <see langword="true" />, если текущий объект <see cref="T:System.Reflection.Emit.MethodBuilder" /> представляет определение универсального метода; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x0600513E RID: 20798 RVA: 0x000FE3B8 File Offset: 0x000FC5B8
		public override bool IsGenericMethodDefinition
		{
			get
			{
				return this.generic_params != null;
			}
		}

		/// <summary>Получает значение, которое указывает, является ли метод универсальным.</summary>
		/// <returns>Значение <see langword="true" />, если метод является универсальным; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x0600513F RID: 20799 RVA: 0x000FE3B8 File Offset: 0x000FC5B8
		public override bool IsGenericMethod
		{
			get
			{
				return this.generic_params != null;
			}
		}

		/// <summary>Возвращает этот метод.</summary>
		/// <returns>Текущий экземпляр <see cref="T:System.Reflection.Emit.MethodBuilder" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Текущий метод не является универсальным. То есть свойство <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethod" /> возвращает значение <see langword="false" />.</exception>
		// Token: 0x06005140 RID: 20800 RVA: 0x000FE3C3 File Offset: 0x000FC5C3
		public override MethodInfo GetGenericMethodDefinition()
		{
			if (!this.IsGenericMethodDefinition)
			{
				throw new InvalidOperationException();
			}
			return this;
		}

		/// <summary>Возвращает массив объектов <see cref="T:System.Reflection.Emit.GenericTypeParameterBuilder" />, которые представляют параметры типа для метода, если он является универсальным.</summary>
		/// <returns>Массив объектов <see cref="T:System.Reflection.Emit.GenericTypeParameterBuilder" />, представляющих параметры типа, если метод является универсальным, или <see langword="null" />, если метод не является универсальным.</returns>
		// Token: 0x06005141 RID: 20801 RVA: 0x000FE3D4 File Offset: 0x000FC5D4
		public override Type[] GetGenericArguments()
		{
			if (this.generic_params == null)
			{
				return null;
			}
			Type[] array = new Type[this.generic_params.Length];
			for (int i = 0; i < this.generic_params.Length; i++)
			{
				array[i] = this.generic_params[i];
			}
			return array;
		}

		/// <summary>Задает количество параметров универсального типа для текущего метода, указывает их имена и возвращает массив объектов <see cref="T:System.Reflection.Emit.GenericTypeParameterBuilder" />, которые можно использовать для определения их ограничений.</summary>
		/// <param name="names">Массив строк, представляющих имена параметров универсального типа.</param>
		/// <returns>Массив объектов <see cref="T:System.Reflection.Emit.GenericTypeParameterBuilder" />, представляющих параметры типа универсального метода.</returns>
		/// <exception cref="T:System.InvalidOperationException">Для этого метода уже были определены параметры универсального типа.  
		///
		/// или - 
		/// Метод уже завершен.  
		///
		/// или - 
		/// Метод <see cref="M:System.Reflection.Emit.MethodBuilder.SetImplementationFlags(System.Reflection.MethodImplAttributes)" /> был вызван для текущего метода.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="names" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Элемент <paramref name="names" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="names" /> является пустым массивом.</exception>
		// Token: 0x06005142 RID: 20802 RVA: 0x000FE418 File Offset: 0x000FC618
		public GenericTypeParameterBuilder[] DefineGenericParameters(params string[] names)
		{
			if (names == null)
			{
				throw new ArgumentNullException("names");
			}
			if (names.Length == 0)
			{
				throw new ArgumentException("names");
			}
			this.generic_params = new GenericTypeParameterBuilder[names.Length];
			for (int i = 0; i < names.Length; i++)
			{
				string text = names[i];
				if (text == null)
				{
					throw new ArgumentNullException("names");
				}
				this.generic_params[i] = new GenericTypeParameterBuilder(this.type, this, text, i);
			}
			return this.generic_params;
		}

		/// <summary>Задает возвращаемый тип метода.</summary>
		/// <param name="returnType">Объект <see cref="T:System.Type" />, представляющий возвращаемый тип метода.</param>
		/// <exception cref="T:System.InvalidOperationException">Текущий метод является универсальным, но определение метода универсальным не является. Свойство <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethod" /> имеет значение <see langword="true" />, однако свойство <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethodDefinition" /> имеет значение <see langword="false" />.</exception>
		// Token: 0x06005143 RID: 20803 RVA: 0x000FE48C File Offset: 0x000FC68C
		public void SetReturnType(Type returnType)
		{
			this.rtype = returnType;
		}

		/// <summary>Задает количество и типы параметров для метода.</summary>
		/// <param name="parameterTypes">Массив объектов <see cref="T:System.Type" />, представляющих типы параметров.</param>
		/// <exception cref="T:System.InvalidOperationException">Текущий метод является универсальным, но определение метода универсальным не является. Свойство <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethod" /> имеет значение <see langword="true" />, однако свойство <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethodDefinition" /> имеет значение <see langword="false" />.</exception>
		// Token: 0x06005144 RID: 20804 RVA: 0x000FE498 File Offset: 0x000FC698
		public void SetParameters(params Type[] parameterTypes)
		{
			if (parameterTypes != null)
			{
				for (int i = 0; i < parameterTypes.Length; i++)
				{
					if (parameterTypes[i] == null)
					{
						throw new ArgumentException("Elements of the parameterTypes array cannot be null", "parameterTypes");
					}
				}
				this.parameters = new Type[parameterTypes.Length];
				Array.Copy(parameterTypes, this.parameters, parameterTypes.Length);
			}
		}

		/// <summary>Задает сигнатуру метода, включая возвращаемый тип, типы параметров, а также обязательные и необязательные настраиваемые модификаторы для возвращаемого типа и типов параметров.</summary>
		/// <param name="returnType">Возвращаемый тип метода.</param>
		/// <param name="returnTypeRequiredCustomModifiers">Массив типов, представляющих обязательные настраиваемые модификаторы, такие как <see cref="T:System.Runtime.CompilerServices.IsConst" />, для возвращаемого типа метода. Если возвращаемый тип не содержит требуемых настраиваемых модификаторов, укажите <see langword="null" />.</param>
		/// <param name="returnTypeOptionalCustomModifiers">Массив типов, представляющих необязательные настраиваемые модификаторы, такие как <see cref="T:System.Runtime.CompilerServices.IsConst" />, для возвращаемого типа метода. Если возвращаемый тип не содержит необязательных настраиваемых модификаторов, укажите <see langword="null" />.</param>
		/// <param name="parameterTypes">Типы параметров метода.</param>
		/// <param name="parameterTypeRequiredCustomModifiers">Массив массивов типов. Каждый массив типов представляет обязательные настраиваемые модификаторы для соответствующего параметра, такие как <see cref="T:System.Runtime.CompilerServices.IsConst" />. Если определенный параметр не имеет обязательных настраиваемых модификаторов, укажите <see langword="null" /> вместо массива массивов. Если ни один из параметров не имеет обязательных настраиваемых модификаторов, укажите <see langword="null" /> вместо массива массивов.</param>
		/// <param name="parameterTypeOptionalCustomModifiers">Массив массивов типов. Каждый массив типов представляет необязательные настраиваемые модификаторы для соответствующего параметра, такие как <see cref="T:System.Runtime.CompilerServices.IsConst" />. Если определенный параметр не имеет необязательных настраиваемых модификаторов, укажите <see langword="null" /> вместо массива массивов. Если ни один из параметров не имеет необязательных настраиваемых модификаторов, укажите <see langword="null" /> вместо массива типов.</param>
		/// <exception cref="T:System.InvalidOperationException">Текущий метод является универсальным, но определение метода универсальным не является. Свойство <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethod" /> имеет значение <see langword="true" />, однако свойство <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethodDefinition" /> имеет значение <see langword="false" />.</exception>
		// Token: 0x06005145 RID: 20805 RVA: 0x000FE4EE File Offset: 0x000FC6EE
		public void SetSignature(Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers)
		{
			this.SetReturnType(returnType);
			this.SetParameters(parameterTypes);
			this.returnModReq = returnTypeRequiredCustomModifiers;
			this.returnModOpt = returnTypeOptionalCustomModifiers;
			this.paramModReq = parameterTypeRequiredCustomModifiers;
			this.paramModOpt = parameterTypeOptionalCustomModifiers;
		}

		/// <summary>Возвращает модуль, в котором определяется текущий метод.</summary>
		/// <returns>Модуль <see cref="T:System.Reflection.Module" />, в котором определяется член, представленный текущим <see cref="T:System.Reflection.MemberInfo" />.</returns>
		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x06005146 RID: 20806 RVA: 0x000FE51D File Offset: 0x000FC71D
		public override Module Module
		{
			get
			{
				return this.GetModule();
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Reflection.ParameterInfo" />, который содержит сведения о типе возвращаемого значения этого метода, например, имеет ли возвращаемый тип пользовательские модификаторы.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.ParameterInfo" />, содержащий сведения о типе возвращаемого значения.</returns>
		/// <exception cref="T:System.InvalidOperationException">Объявляющий тип не создан.</exception>
		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x06005147 RID: 20807 RVA: 0x000FE525 File Offset: 0x000FC725
		public override ParameterInfo ReturnParameter
		{
			get
			{
				return base.ReturnParameter;
			}
		}

		// Token: 0x06005148 RID: 20808 RVA: 0x000173AD File Offset: 0x000155AD
		internal MethodBuilder()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x040031B7 RID: 12727
		private RuntimeMethodHandle mhandle;

		// Token: 0x040031B8 RID: 12728
		private Type rtype;

		// Token: 0x040031B9 RID: 12729
		internal Type[] parameters;

		// Token: 0x040031BA RID: 12730
		private MethodAttributes attrs;

		// Token: 0x040031BB RID: 12731
		private MethodImplAttributes iattrs;

		// Token: 0x040031BC RID: 12732
		private string name;

		// Token: 0x040031BD RID: 12733
		private int table_idx;

		// Token: 0x040031BE RID: 12734
		private byte[] code;

		// Token: 0x040031BF RID: 12735
		private ILGenerator ilgen;

		// Token: 0x040031C0 RID: 12736
		private TypeBuilder type;

		// Token: 0x040031C1 RID: 12737
		internal ParameterBuilder[] pinfo;

		// Token: 0x040031C2 RID: 12738
		private CustomAttributeBuilder[] cattrs;

		// Token: 0x040031C3 RID: 12739
		private MethodInfo[] override_methods;

		// Token: 0x040031C4 RID: 12740
		private string pi_dll;

		// Token: 0x040031C5 RID: 12741
		private string pi_entry;

		// Token: 0x040031C6 RID: 12742
		private CharSet charset;

		// Token: 0x040031C7 RID: 12743
		private uint extra_flags;

		// Token: 0x040031C8 RID: 12744
		private CallingConvention native_cc;

		// Token: 0x040031C9 RID: 12745
		private CallingConventions call_conv;

		// Token: 0x040031CA RID: 12746
		private bool init_locals;

		// Token: 0x040031CB RID: 12747
		private IntPtr generic_container;

		// Token: 0x040031CC RID: 12748
		internal GenericTypeParameterBuilder[] generic_params;

		// Token: 0x040031CD RID: 12749
		private Type[] returnModReq;

		// Token: 0x040031CE RID: 12750
		private Type[] returnModOpt;

		// Token: 0x040031CF RID: 12751
		private Type[][] paramModReq;

		// Token: 0x040031D0 RID: 12752
		private Type[][] paramModOpt;

		// Token: 0x040031D1 RID: 12753
		private RefEmitPermissionSet[] permissions;
	}
}
