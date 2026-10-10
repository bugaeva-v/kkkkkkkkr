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
	/// <summary>Определяет и представляет конструктор динамического класса.</summary>
	// Token: 0x02000915 RID: 2325
	[ComDefaultInterface(typeof(_ConstructorBuilder))]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class ConstructorBuilder : ConstructorInfo, _ConstructorBuilder
	{
		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Переданный массив имен, которые необходимо сопоставить.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, зарезервированный вызывающим объектом, куда помещаются идентификаторы, соответствующие именам.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06004EEC RID: 20204 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _ConstructorBuilder.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает сведения о типе объекта, которые затем могут использоваться для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Получает указатель на объект с запрошенными сведениями о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06004EED RID: 20205 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _ConstructorBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Указатель, по которому записывается число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06004EEE RID: 20206 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _ConstructorBuilder.GetTypeInfoCount(out uint pcTInfo)
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
		// Token: 0x06004EEF RID: 20207 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _ConstructorBuilder.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06004EF0 RID: 20208 RVA: 0x000F7F5C File Offset: 0x000F615C
		internal ConstructorBuilder(TypeBuilder tb, MethodAttributes attributes, CallingConventions callingConvention, Type[] parameterTypes, Type[][] paramModReq, Type[][] paramModOpt)
		{
			this.init_locals = true;
			base..ctor();
			this.attrs = (attributes | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName);
			this.call_conv = callingConvention;
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
			this.paramModReq = paramModReq;
			this.paramModOpt = paramModOpt;
			this.table_idx = this.get_next_table_index(this, 6, 1);
			((ModuleBuilder)tb.Module).RegisterToken(this, this.GetToken().Token);
		}

		/// <summary>Получает значение <see cref="T:System.Reflection.CallingConventions" />, которое зависит от того, является ли объявляющий тип универсальным.</summary>
		/// <returns>Значение <see cref="F:System.Reflection.CallingConventions.HasThis" />, если объявляющий тип является универсальным; в противном случае — значение <see cref="F:System.Reflection.CallingConventions.Standard" />.</returns>
		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x06004EF1 RID: 20209 RVA: 0x000F8024 File Offset: 0x000F6224
		[MonoTODO]
		public override CallingConventions CallingConvention
		{
			get
			{
				return this.call_conv;
			}
		}

		/// <summary>Получает или задает значение, указывающее необходимость инициализации локальных переменных в этом конструкторе нулями.</summary>
		/// <returns>Чтение и запись. Получает или задает значение, указывающее необходимость инициализации локальных переменных в этом конструкторе нулями.</returns>
		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x06004EF2 RID: 20210 RVA: 0x000F802C File Offset: 0x000F622C
		// (set) Token: 0x06004EF3 RID: 20211 RVA: 0x000F8034 File Offset: 0x000F6234
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

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x06004EF4 RID: 20212 RVA: 0x000F803D File Offset: 0x000F623D
		internal TypeBuilder TypeBuilder
		{
			get
			{
				return this.type;
			}
		}

		/// <summary>Возвращает флаги реализации метода для этого конструктора.</summary>
		/// <returns>Флаги реализации метода для этого конструктора.</returns>
		// Token: 0x06004EF5 RID: 20213 RVA: 0x000F8045 File Offset: 0x000F6245
		public override MethodImplAttributes GetMethodImplementationFlags()
		{
			return this.iattrs;
		}

		/// <summary>Возвращает параметры этого конструктора.</summary>
		/// <returns>Массив, представляющий параметры этого конструктора.</returns>
		/// <exception cref="T:System.InvalidOperationException">
		///   <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> не был вызван для этого типа конструктора в платформе .NET Framework версий 1.0 и 1.1.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> не был вызван для этого типа конструктора в платформе .NET Framework версии 2.0.</exception>
		// Token: 0x06004EF6 RID: 20214 RVA: 0x000F804D File Offset: 0x000F624D
		public override ParameterInfo[] GetParameters()
		{
			if (!this.type.is_created)
			{
				throw this.not_created();
			}
			return this.GetParametersInternal();
		}

		// Token: 0x06004EF7 RID: 20215 RVA: 0x000F806C File Offset: 0x000F626C
		internal override ParameterInfo[] GetParametersInternal()
		{
			if (this.parameters == null)
			{
				return EmptyArray<ParameterInfo>.Value;
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

		// Token: 0x06004EF8 RID: 20216 RVA: 0x000F80CE File Offset: 0x000F62CE
		internal override int GetParametersCount()
		{
			if (this.parameters == null)
			{
				return 0;
			}
			return this.parameters.Length;
		}

		// Token: 0x06004EF9 RID: 20217 RVA: 0x000F80E2 File Offset: 0x000F62E2
		internal override Type GetParameterType(int pos)
		{
			return this.parameters[pos];
		}

		// Token: 0x06004EFA RID: 20218 RVA: 0x000F80EC File Offset: 0x000F62EC
		internal MethodBase RuntimeResolve()
		{
			return this.type.RuntimeResolve().GetConstructor(this);
		}

		/// <summary>Динамически вызывает конструктор, отраженный этим экземпляром с указанными аргументами, с учетом ограничений заданного параметра <see langword="Binder" />.</summary>
		/// <param name="obj">Объект, который необходимо повторно инициализировать.</param>
		/// <param name="invokeAttr">Одно из значений <see langword="BindingFlags" />, указывающее нужный тип привязки.</param>
		/// <param name="binder">Параметр <see langword="Binder" />, который определяет набор свойств и обеспечивает привязку, приведение типов аргументов и вызов членов с помощью отражения. Если <paramref name="binder" /> имеет значение <see langword="null" />, то используется Binder.DefaultBinding.</param>
		/// <param name="parameters">Список аргументов. Это массив аргументов с тем же числом, порядком и типом, что и параметры вызываемого конструктора. Если параметров нет, он должен быть пустой ссылкой (<see langword="Nothing" /> в Visual Basic).</param>
		/// <param name="culture">Параметр <see cref="T:System.Globalization.CultureInfo" />, используемый для управления приведением типов. Если параметр имеет значение NULL, для текущего потока используется <see cref="T:System.Globalization.CultureInfo" />.</param>
		/// <returns>Экземпляр класса, связанный с конструктором.</returns>
		/// <exception cref="T:System.NotSupportedException">В настоящее время этот метод не поддерживается. Конструктор можно получить с помощью <see cref="M:System.Type.GetConstructor(System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> и вызвать <see cref="M:System.Reflection.ConstructorInfo.Invoke(System.Reflection.BindingFlags,System.Reflection.Binder,System.Object[],System.Globalization.CultureInfo)" /> для возвращенного объекта <see cref="T:System.Reflection.ConstructorInfo" />.</exception>
		// Token: 0x06004EFB RID: 20219 RVA: 0x000F80FF File Offset: 0x000F62FF
		public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			throw this.not_supported();
		}

		/// <summary>Динамически вызывает конструктор, представленный этим экземпляром для данного объекта, передавая указанные параметры и учитывая ограничения данного модуля привязки.</summary>
		/// <param name="invokeAttr">Это должен быть одноразрядный флаг из <see cref="T:System.Reflection.BindingFlags" />, например InvokeMethod, NonPublic и т. д.</param>
		/// <param name="binder">Объект, позволяющий осуществлять привязку, приведение типов аргументов, вызов элементов, а также поиск объектов <see langword="MemberInfo" /> с помощью отражения. Если указан модуль привязки <see langword="null" />, используется модуль привязки по умолчанию. См. раздел <see cref="T:System.Reflection.Binder" />.</param>
		/// <param name="parameters">Список аргументов. Это массив аргументов с тем же числом, порядком и типом, что и параметры вызываемого конструктора. Если параметров нет, должно быть указано значение <see langword="null" />.</param>
		/// <param name="culture">Экземпляр объекта <see cref="T:System.Globalization.CultureInfo" />, используемого для управления приведением типов. Если параметр имеет значение NULL, для текущего потока используется <see cref="T:System.Globalization.CultureInfo" />. (Например, необходимо преобразовывать объект <see cref="T:System.String" />, представляющий 1000, в значение <see cref="T:System.Double" />, поскольку в разных языках и региональных параметрах 1000 представляется по-разному.)</param>
		/// <returns>Значение, возвращаемое вызванным конструктором.</returns>
		/// <exception cref="T:System.NotSupportedException">В настоящее время этот метод не поддерживается. Конструктор можно получить с помощью <see cref="M:System.Type.GetConstructor(System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> и вызвать <see cref="M:System.Reflection.ConstructorInfo.Invoke(System.Reflection.BindingFlags,System.Reflection.Binder,System.Object[],System.Globalization.CultureInfo)" /> для возвращенного объекта <see cref="T:System.Reflection.ConstructorInfo" />.</exception>
		// Token: 0x06004EFC RID: 20220 RVA: 0x000F80FF File Offset: 0x000F62FF
		public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			throw this.not_supported();
		}

		/// <summary>Получает внутренний маркер метода. Используйте этот дескриптор для доступа к дескриптору базовых метаданных.</summary>
		/// <returns>Внутренний маркер метода. Используйте этот дескриптор для доступа к дескриптору базовых метаданных.</returns>
		/// <exception cref="T:System.NotSupportedException">Это свойство не поддерживается для этого класса.</exception>
		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x06004EFD RID: 20221 RVA: 0x000F80FF File Offset: 0x000F62FF
		public override RuntimeMethodHandle MethodHandle
		{
			get
			{
				throw this.not_supported();
			}
		}

		/// <summary>Получает атрибуты для этого конструктора.</summary>
		/// <returns>Атрибуты для данного конструктора.</returns>
		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x06004EFE RID: 20222 RVA: 0x000F8107 File Offset: 0x000F6307
		public override MethodAttributes Attributes
		{
			get
			{
				return this.attrs;
			}
		}

		/// <summary>Содержит ссылку на объект <see cref="T:System.Type" />, из которого был получен данный объект.</summary>
		/// <returns>
		///   <see langword="Type" /> Объект, из которого был получен данный объект.</returns>
		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x06004EFF RID: 20223 RVA: 0x000F803D File Offset: 0x000F623D
		public override Type ReflectedType
		{
			get
			{
				return this.type;
			}
		}

		/// <summary>Получает ссылку на объект <see cref="T:System.Type" /> для типа, который объявляет этот элемент.</summary>
		/// <returns>Тип, который объявляет этот член.</returns>
		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x06004F00 RID: 20224 RVA: 0x000F803D File Offset: 0x000F623D
		public override Type DeclaringType
		{
			get
			{
				return this.type;
			}
		}

		/// <summary>Возвращает <see langword="null" />.</summary>
		/// <returns>Возвращает <see langword="null" />.</returns>
		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x06004F01 RID: 20225 RVA: 0x0000AF5E File Offset: 0x0000915E
		[Obsolete]
		public Type ReturnType
		{
			get
			{
				return null;
			}
		}

		/// <summary>Получает имя конструктора.</summary>
		/// <returns>Имя данного конструктора.</returns>
		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x06004F02 RID: 20226 RVA: 0x000F810F File Offset: 0x000F630F
		public override string Name
		{
			get
			{
				if ((this.attrs & MethodAttributes.Static) == MethodAttributes.PrivateScope)
				{
					return ConstructorInfo.ConstructorName;
				}
				return ConstructorInfo.TypeConstructorName;
			}
		}

		/// <summary>Извлекает сигнатуру поля в виде строки.</summary>
		/// <returns>Сигнатура поля.</returns>
		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x06004F03 RID: 20227 RVA: 0x000F8127 File Offset: 0x000F6327
		public string Signature
		{
			get
			{
				return "constructor signature";
			}
		}

		/// <summary>Добавляет декларативную безопасность в этот конструктор.</summary>
		/// <param name="action">Выполняемое действие безопасности, например Demand, Assert и т. д.</param>
		/// <param name="pset">Набор разрешений, к которому применяется действие.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="action" /> является недопустимым (RequestMinimum, RequestOptional и RequestRefuse являются недопустимыми).</exception>
		/// <exception cref="T:System.InvalidOperationException">Содержащий тип был создан ранее с помощью <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.  
		///
		/// или - 
		/// Набор разрешений <paramref name="pset" /> содержит действие, добавленное ранее с помощью <see langword="AddDeclarativeSecurity" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pset" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004F04 RID: 20228 RVA: 0x000F8130 File Offset: 0x000F6330
		public void AddDeclarativeSecurity(SecurityAction action, PermissionSet pset)
		{
			if (pset == null)
			{
				throw new ArgumentNullException("pset");
			}
			if (action == SecurityAction.RequestMinimum || action == SecurityAction.RequestOptional || action == SecurityAction.RequestRefuse)
			{
				throw new ArgumentOutOfRangeException("action", "Request* values are not permitted");
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

		/// <summary>Определяет параметр данного конструктора.</summary>
		/// <param name="iSequence">Позиция параметра в списке параметров. Параметры индексируются, начиная с номера 1 для первого параметра.</param>
		/// <param name="attributes">Атрибуты параметра.</param>
		/// <param name="strParamName">Имя параметра. Имя может быть пустой строкой.</param>
		/// <returns>Объект, представляющий новый параметр этого конструктора.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="iSequence" /> меньше нуля или больше, чем число параметров конструктора.</exception>
		/// <exception cref="T:System.InvalidOperationException">Содержащий тип был создан с помощью <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.</exception>
		// Token: 0x06004F05 RID: 20229 RVA: 0x000F8210 File Offset: 0x000F6410
		public ParameterBuilder DefineParameter(int iSequence, ParameterAttributes attributes, string strParamName)
		{
			if (iSequence < 0 || iSequence > this.GetParametersCount())
			{
				throw new ArgumentOutOfRangeException("iSequence");
			}
			if (this.type.is_created)
			{
				throw this.not_after_created();
			}
			ParameterBuilder parameterBuilder = new ParameterBuilder(this, iSequence, attributes, strParamName);
			if (this.pinfo == null)
			{
				this.pinfo = new ParameterBuilder[this.parameters.Length + 1];
			}
			this.pinfo[iSequence] = parameterBuilder;
			return parameterBuilder;
		}

		/// <summary>Проверяет, определен ли заданный тип настраиваемого атрибута.</summary>
		/// <param name="attributeType">Тип настраиваемого атрибута.</param>
		/// <param name="inherit">Управляет наследованием настраиваемых атрибутов базового класса. Этот параметр не учитывается.</param>
		/// <returns>Значение <see langword="true" />, если заданный тип настраиваемых атрибутов определен; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.NotSupportedException">В настоящее время этот метод не поддерживается. Конструктор можно получить с помощью <see cref="M:System.Type.GetConstructor(System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> и вызвать <see cref="M:System.Reflection.MemberInfo.IsDefined(System.Type,System.Boolean)" /> для возвращенного объекта <see cref="T:System.Reflection.ConstructorInfo" />.</exception>
		// Token: 0x06004F06 RID: 20230 RVA: 0x000F80FF File Offset: 0x000F62FF
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			throw this.not_supported();
		}

		/// <summary>Возвращает все настраиваемые атрибуты, определенные для этого конструктора.</summary>
		/// <param name="inherit">Управляет наследованием настраиваемых атрибутов базового класса. Этот параметр не учитывается.</param>
		/// <returns>Массив объектов, представляющий все пользовательские атрибуты конструктора, который представлен этим экземпляром <see cref="T:System.Reflection.Emit.ConstructorBuilder" />.</returns>
		/// <exception cref="T:System.NotSupportedException">В настоящее время этот метод не поддерживается.</exception>
		// Token: 0x06004F07 RID: 20231 RVA: 0x000F80FF File Offset: 0x000F62FF
		public override object[] GetCustomAttributes(bool inherit)
		{
			throw this.not_supported();
		}

		/// <summary>Возвращает настраиваемые атрибуты, определяемые заданным типом.</summary>
		/// <param name="attributeType">Тип настраиваемого атрибута.</param>
		/// <param name="inherit">Управляет наследованием настраиваемых атрибутов базового класса. Этот параметр не учитывается.</param>
		/// <returns>Массив объектов, представляющий атрибуты этого конструктора.</returns>
		/// <exception cref="T:System.NotSupportedException">В настоящее время этот метод не поддерживается.</exception>
		// Token: 0x06004F08 RID: 20232 RVA: 0x000F80FF File Offset: 0x000F62FF
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			throw this.not_supported();
		}

		/// <summary>Получает <see cref="T:System.Reflection.Emit.ILGenerator" /> для этого конструктора.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.Emit.ILGenerator" /> для этого конструктора.</returns>
		/// <exception cref="T:System.InvalidOperationException">Конструктор является конструктором по умолчанию.  
		/// -или- 
		/// У конструктора есть флаги <see cref="T:System.Reflection.MethodAttributes" /> или <see cref="T:System.Reflection.MethodImplAttributes" />, указывающие, что он не должен иметь тело метода.</exception>
		// Token: 0x06004F09 RID: 20233 RVA: 0x000F827A File Offset: 0x000F647A
		public ILGenerator GetILGenerator()
		{
			return this.GetILGenerator(64);
		}

		/// <summary>Получает объект <see cref="T:System.Reflection.Emit.ILGenerator" /> с указанным размером потока MSIL, который может использоваться для построения тела метода для данного конструктора.</summary>
		/// <param name="streamSize">Размер потока MSIL (в байтах).</param>
		/// <returns>
		///   <see cref="T:System.Reflection.Emit.ILGenerator" /> для этого конструктора.</returns>
		/// <exception cref="T:System.InvalidOperationException">Конструктор является конструктором по умолчанию.  
		/// -или- 
		/// У конструктора есть флаги <see cref="T:System.Reflection.MethodAttributes" /> или <see cref="T:System.Reflection.MethodImplAttributes" />, указывающие, что он не должен иметь тело метода.</exception>
		// Token: 0x06004F0A RID: 20234 RVA: 0x000F8284 File Offset: 0x000F6484
		public ILGenerator GetILGenerator(int streamSize)
		{
			if (this.ilgen != null)
			{
				return this.ilgen;
			}
			this.ilgen = new ILGenerator(this.type.Module, ((ModuleBuilder)this.type.Module).GetTokenGenerator(), streamSize);
			return this.ilgen;
		}

		/// <summary>Создает тело конструктора с использованием указанного массива байтов инструкций промежуточного языка Майкрософт (MSIL).</summary>
		/// <param name="il">Массив, содержащий допустимые инструкции MSIL.</param>
		/// <param name="maxStack">Максимальная глубина оценки стека.</param>
		/// <param name="localSignature">Массив байтов, содержащий сериализованную структуру локальной переменной. Укажите <see langword="null" />, если у конструктора нет локальных переменных.</param>
		/// <param name="exceptionHandlers">Коллекция, содержащая обработчики исключений для конструктора. Укажите <see langword="null" />, если у конструктора нет обработчиков исключений.</param>
		/// <param name="tokenFixups">Коллекция значений, которые представляют смещения в <paramref name="il" />, каждый из которых задает начало токена, который может быть изменен. Укажите <see langword="null" />, если у конструктора нет токенов, которые должны быть изменены.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="il" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="maxStack" /> является отрицательным значением.  
		/// -или- 
		/// Один из <paramref name="exceptionHandlers" /> указывает смещение за пределами <paramref name="il" />.  
		/// -или- 
		/// Один из <paramref name="tokenFixups" /> указывает смещение, которое находится за пределами массива <paramref name="il" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Содержащий тип был создан ранее с помощью метода <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.  
		/// -или- 
		/// Этот метод был вызван ранее для этого объекта <see cref="T:System.Reflection.Emit.ConstructorBuilder" />.</exception>
		// Token: 0x06004F0B RID: 20235 RVA: 0x000F82D2 File Offset: 0x000F64D2
		public void SetMethodBody(byte[] il, int maxStack, byte[] localSignature, IEnumerable<ExceptionHandler> exceptionHandlers, IEnumerable<int> tokenFixups)
		{
			this.GetILGenerator().Init(il, maxStack, localSignature, exceptionHandlers, tokenFixups);
		}

		/// <summary>Задает настраиваемый атрибут с помощью построителя настраиваемых атрибутов.</summary>
		/// <param name="customBuilder">Экземпляр вспомогательного класса для определения настраиваемого атрибута.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="customBuilder" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004F0C RID: 20236 RVA: 0x000F82E8 File Offset: 0x000F64E8
		public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
		{
			if (customBuilder == null)
			{
				throw new ArgumentNullException("customBuilder");
			}
			if (customBuilder.Ctor.ReflectedType.FullName == "System.Runtime.CompilerServices.MethodImplAttribute")
			{
				byte[] data = customBuilder.Data;
				int num = (int)data[2];
				num |= (int)data[3] << 8;
				this.SetImplementationFlags((MethodImplAttributes)num);
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
		// Token: 0x06004F0D RID: 20237 RVA: 0x000F8387 File Offset: 0x000F6587
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

		/// <summary>Задает флаги реализации метода для этого конструктора.</summary>
		/// <param name="attributes">Флаги реализации метода.</param>
		/// <exception cref="T:System.InvalidOperationException">Содержащий тип был создан с помощью <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.</exception>
		// Token: 0x06004F0E RID: 20238 RVA: 0x000F83B8 File Offset: 0x000F65B8
		public void SetImplementationFlags(MethodImplAttributes attributes)
		{
			if (this.type.is_created)
			{
				throw this.not_after_created();
			}
			this.iattrs = attributes;
		}

		/// <summary>Возвращает ссылку на модуль, содержащий этот конструктор.</summary>
		/// <returns>Модуль, содержащий этот конструктор.</returns>
		// Token: 0x06004F0F RID: 20239 RVA: 0x000F83D5 File Offset: 0x000F65D5
		public Module GetModule()
		{
			return this.type.Module;
		}

		/// <summary>Возвращает объект <see cref="T:System.Reflection.Emit.MethodToken" />, представляющий маркер для этого конструктора.</summary>
		/// <returns>
		///   <see cref="T:System.Reflection.Emit.MethodToken" /> этого конструктора.</returns>
		// Token: 0x06004F10 RID: 20240 RVA: 0x000F83E2 File Offset: 0x000F65E2
		public MethodToken GetToken()
		{
			return new MethodToken(100663296 | this.table_idx);
		}

		/// <summary>Задает пользовательский атрибут этого конструктора, связанный с символьными данными.</summary>
		/// <param name="name">Имя пользовательского атрибута.</param>
		/// <param name="data">Значение пользовательского атрибута.</param>
		/// <exception cref="T:System.InvalidOperationException">Содержащий тип был создан с помощью <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.  
		/// -или- 
		/// Для модуля не определен модуль записи символов. Например, модуль не является отладочным.</exception>
		// Token: 0x06004F11 RID: 20241 RVA: 0x000F83F5 File Offset: 0x000F65F5
		[MonoTODO]
		public void SetSymCustomAttribute(string name, byte[] data)
		{
			if (this.type.is_created)
			{
				throw this.not_after_created();
			}
		}

		/// <summary>Возвращает динамический модуль, в котором определен этот конструктор.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.Module" />, представляющий динамический модуль, в котором определен этот конструктор.</returns>
		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x06004F12 RID: 20242 RVA: 0x000F840B File Offset: 0x000F660B
		public override Module Module
		{
			get
			{
				return this.GetModule();
			}
		}

		/// <summary>Возвращает этот экземпляр <see cref="T:System.Reflection.Emit.ConstructorBuilder" /> в виде <see cref="T:System.String" />.</summary>
		/// <returns>Строка, содержащая имя, атрибуты и исключения этого конструктора, за которой следует текущий поток MSIL.</returns>
		// Token: 0x06004F13 RID: 20243 RVA: 0x000F8413 File Offset: 0x000F6613
		public override string ToString()
		{
			return "ConstructorBuilder ['" + this.type.Name + "']";
		}

		// Token: 0x06004F14 RID: 20244 RVA: 0x000F8430 File Offset: 0x000F6630
		internal void fixup()
		{
			if ((this.attrs & (MethodAttributes.Abstract | MethodAttributes.PinvokeImpl)) == MethodAttributes.PrivateScope && (this.iattrs & (MethodImplAttributes)4099) == MethodImplAttributes.IL && (this.ilgen == null || this.ilgen.ILOffset == 0))
			{
				throw new InvalidOperationException("Method '" + this.Name + "' does not have a method body.");
			}
			if (this.ilgen != null)
			{
				this.ilgen.label_fixup(this);
			}
		}

		// Token: 0x06004F15 RID: 20245 RVA: 0x000F84A0 File Offset: 0x000F66A0
		internal void ResolveUserTypes()
		{
			TypeBuilder.ResolveUserTypes(this.parameters);
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

		// Token: 0x06004F16 RID: 20246 RVA: 0x000F8502 File Offset: 0x000F6702
		internal void FixupTokens(Dictionary<int, int> token_map, Dictionary<int, MemberInfo> member_map)
		{
			if (this.ilgen != null)
			{
				this.ilgen.FixupTokens(token_map, member_map);
			}
		}

		// Token: 0x06004F17 RID: 20247 RVA: 0x000F851C File Offset: 0x000F671C
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

		// Token: 0x06004F18 RID: 20248 RVA: 0x000F8588 File Offset: 0x000F6788
		internal override int get_next_table_index(object obj, int table, int count)
		{
			return this.type.get_next_table_index(obj, table, count);
		}

		// Token: 0x06004F19 RID: 20249 RVA: 0x000F8598 File Offset: 0x000F6798
		private void RejectIfCreated()
		{
			if (this.type.is_created)
			{
				throw new InvalidOperationException("Type definition of the method is complete.");
			}
		}

		// Token: 0x06004F1A RID: 20250 RVA: 0x000F79D6 File Offset: 0x000F5BD6
		private Exception not_supported()
		{
			return new NotSupportedException("The invoked member is not supported in a dynamic module.");
		}

		// Token: 0x06004F1B RID: 20251 RVA: 0x000F85B2 File Offset: 0x000F67B2
		private Exception not_after_created()
		{
			return new InvalidOperationException("Unable to change after type has been created.");
		}

		// Token: 0x06004F1C RID: 20252 RVA: 0x000F85BE File Offset: 0x000F67BE
		private Exception not_created()
		{
			return new NotSupportedException("The type is not yet created.");
		}

		// Token: 0x06004F1D RID: 20253 RVA: 0x000173AD File Offset: 0x000155AD
		internal ConstructorBuilder()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04003119 RID: 12569
		private RuntimeMethodHandle mhandle;

		// Token: 0x0400311A RID: 12570
		private ILGenerator ilgen;

		// Token: 0x0400311B RID: 12571
		internal Type[] parameters;

		// Token: 0x0400311C RID: 12572
		private MethodAttributes attrs;

		// Token: 0x0400311D RID: 12573
		private MethodImplAttributes iattrs;

		// Token: 0x0400311E RID: 12574
		private int table_idx;

		// Token: 0x0400311F RID: 12575
		private CallingConventions call_conv;

		// Token: 0x04003120 RID: 12576
		private TypeBuilder type;

		// Token: 0x04003121 RID: 12577
		internal ParameterBuilder[] pinfo;

		// Token: 0x04003122 RID: 12578
		private CustomAttributeBuilder[] cattrs;

		// Token: 0x04003123 RID: 12579
		private bool init_locals;

		// Token: 0x04003124 RID: 12580
		private Type[][] paramModReq;

		// Token: 0x04003125 RID: 12581
		private Type[][] paramModOpt;

		// Token: 0x04003126 RID: 12582
		private RefEmitPermissionSet[] permissions;
	}
}
