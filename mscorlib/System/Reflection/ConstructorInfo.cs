using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using Unity;

namespace System.Reflection
{
	/// <summary>Извлекает атрибуты конструктора класса и предоставляет доступ к метаданным конструктора.</summary>
	// Token: 0x02000895 RID: 2197
	[Serializable]
	public abstract class ConstructorInfo : MethodBase, _ConstructorInfo
	{
		/// <summary>Возвращает значение <see cref="T:System.Reflection.MemberTypes" /> указывающее, что этот член является конструктором.</summary>
		/// <returns>Значение <see cref="T:System.Reflection.MemberTypes" /> указывающее, что этот член является конструктором.</returns>
		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x06004883 RID: 18563 RVA: 0x000040F7 File Offset: 0x000022F7
		public override MemberTypes MemberType
		{
			get
			{
				return MemberTypes.Constructor;
			}
		}

		/// <summary>Вызывает конструктор, отраженный этим экземпляром с указанными параметрами, при условии, что значения по умолчанию для параметров не используются.</summary>
		/// <param name="parameters">Массив значений, соответствующий по количеству, порядку и типу (с учетом ограничений связывателя по умолчанию) параметрам данного конструктора. Если этот конструктор не принимает параметры, следует использовать массив с нулевым числом элементов или <see langword="null" />, например: Object[] parameters = new Object[0]. Любой объект этого массива, которому не присвоено значение явным образом, будет содержать значение по умолчанию для своего типа объекта. Для элементов ссылочного типа это значение равно <see langword="null" />. Для элементов, тип которых передается по значению, это значение равно 0, 0,0 или <see langword="false" /> в зависимости от конкретного типа элемента.</param>
		/// <returns>Экземпляр класса, связанного с конструктором.</returns>
		/// <exception cref="T:System.MemberAccessException">Это абстрактный класс.  
		/// -или- 
		/// Конструктор является инициализатором класса.</exception>
		/// <exception cref="T:System.MethodAccessException">Вместо этого в .NET для приложений Магазина Windows или в переносимой библиотеке классов перехватите исключение базового класса <see cref="T:System.MemberAccessException" />.  
		///
		///
		///
		///
		///  Конструктор является закрытым или защищенным, в вызывающем объекте отсутствует флаг <see cref="F:System.Security.Permissions.ReflectionPermissionFlag.MemberAccess" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="parameters" /> не содержит значения, которые соответствуют типам, принимаемым этим конструктором.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Вызванный конструктор создает исключение.</exception>
		/// <exception cref="T:System.Reflection.TargetParameterCountException">Передано неверное число параметров.</exception>
		/// <exception cref="T:System.NotSupportedException">Не поддерживается создание типов <see cref="T:System.TypedReference" />, <see cref="T:System.ArgIterator" /> и <see cref="T:System.RuntimeArgumentHandle" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий объект не имеет разрешения на доступ к необходимому коду.</exception>
		// Token: 0x06004884 RID: 18564 RVA: 0x000EE1D6 File Offset: 0x000EC3D6
		[DebuggerStepThrough]
		[DebuggerHidden]
		public object Invoke(object[] parameters)
		{
			return this.Invoke(BindingFlags.CreateInstance, null, parameters, null);
		}

		/// <summary>При реализации в производном классе вызывает конструктор, отраженный этим объектом <see langword="ConstructorInfo" /> с заданными аргументами с учетом ограничений, установленных объектом <see langword="Binder" />.</summary>
		/// <param name="invokeAttr">Одно из значений <see langword="BindingFlags" />, определяющих тип связывания.</param>
		/// <param name="binder">
		///   <see langword="Binder" />, определяющий набор свойств и разрешающий связывание, приведение типов аргументов и вызов элементов с помощью отражения. Если параметр <paramref name="binder" /> принимает значение <see langword="null" />, используется свойство <see langword="Binder.DefaultBinding" />.</param>
		/// <param name="parameters">Массив типа <see langword="Object" />, используемый для проверки соответствия количества, порядка и типа параметрам данного конструктора, с учетом ограничений, установленных объектом <paramref name="binder" />. Если этот конструктор не требует параметров, передается массив нулей, как в Object[] parameters = new Object[0]. Любой объект этого массива, который не был явно инициализирован с помощью значения, будет содержать значение по умолчанию для данного типа объекта. Для элементов ссылочного типа это значение равно <see langword="null" />. Для элементов, тип которых передается по значению, это значение равно 0, 0,0 или <see langword="false" /> в зависимости от конкретного типа элемента.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, используемый для управления приведением типов. Если значение этого объекта — <see langword="null" />, для текущего потока используется <see cref="T:System.Globalization.CultureInfo" />.</param>
		/// <returns>Экземпляр класса, связанного с конструктором.</returns>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="parameters" /> не содержит значений, соответствующих типам, принимаемым этим конструктором, с учетом ограничений, установленных объектом <paramref name="binder" />.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Вызванный конструктор выдал исключение.</exception>
		/// <exception cref="T:System.Reflection.TargetParameterCountException">Передано неверное число параметров.</exception>
		/// <exception cref="T:System.NotSupportedException">создание типов <see cref="T:System.TypedReference" />, <see cref="T:System.ArgIterator" /> и <see cref="T:System.RuntimeArgumentHandle" /> не поддерживается.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий объект не имеет разрешений на доступ к необходимому коду.</exception>
		/// <exception cref="T:System.MemberAccessException">Это абстрактный класс.  
		/// -или- 
		/// Конструктор является инициализатором класса.</exception>
		/// <exception cref="T:System.MethodAccessException">Конструктор является закрытым или защищенным, в вызывающем объекте отсутствует флаг <see cref="F:System.Security.Permissions.ReflectionPermissionFlag.MemberAccess" />.</exception>
		// Token: 0x06004885 RID: 18565
		public abstract object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

		/// <summary>Возвращает значение, указывающее, равен ли этот экземпляр указанному объекту.</summary>
		/// <param name="obj">Объект, сравниваемый с этим экземпляром, или значение <see langword="null" />.</param>
		/// <returns>
		///   <see langword="true" />, если объект <paramref name="obj" /> типу и значению данного экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06004886 RID: 18566 RVA: 0x000EE1E6 File Offset: 0x000EC3E6
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		/// <summary>Возвращает хэш-код для данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-битовым целым числом со знаком.</returns>
		// Token: 0x06004887 RID: 18567 RVA: 0x000EE1EF File Offset: 0x000EC3EF
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Определение равенства двух объектов <see cref="T:System.Reflection.ConstructorInfo" />.</summary>
		/// <param name="left">Первый объект <see cref="T:System.Reflection.ConstructorInfo" /> для сравнения.</param>
		/// <param name="right">Второй объект <see cref="T:System.Reflection.ConstructorInfo" /> для сравнения.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="left" /> равен <paramref name="right" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004888 RID: 18568 RVA: 0x00064560 File Offset: 0x00062760
		public static bool operator ==(ConstructorInfo left, ConstructorInfo right)
		{
			return left == right || (left != null && right != null && left.Equals(right));
		}

		/// <summary>Определяет неравенство двух объектов <see cref="T:System.Reflection.ConstructorInfo" />.</summary>
		/// <param name="left">Первый объект <see cref="T:System.Reflection.ConstructorInfo" /> для сравнения.</param>
		/// <param name="right">Второй объект <see cref="T:System.Reflection.ConstructorInfo" /> для сравнения.</param>
		/// <returns>Значение <see langword="true" />, если параметры <paramref name="left" /> и <paramref name="right" /> не равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004889 RID: 18569 RVA: 0x000EE1F7 File Offset: 0x000EC3F7
		public static bool operator !=(ConstructorInfo left, ConstructorInfo right)
		{
			return !(left == right);
		}

		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для использования в будущем. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Переданный массив имен, которые необходимо сопоставить.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, зарезервированный вызывающим объектом, куда помещаются идентификаторы, соответствующие именам.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x0600488B RID: 18571 RVA: 0x000173AD File Offset: 0x000155AD
		void _ConstructorInfo.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Возвращает объект <see cref="T:System.Type" />, представляющий тип <see cref="T:System.Reflection.ConstructorInfo" />.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий тип <see cref="T:System.Reflection.ConstructorInfo" />.</returns>
		// Token: 0x0600488C RID: 18572 RVA: 0x00052955 File Offset: 0x00050B55
		Type _ConstructorInfo.GetType()
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>Возвращает сведения о типе объекта, которые затем могут использоваться для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Получает указатель на объект с запрошенными сведениями о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x0600488D RID: 18573 RVA: 0x000173AD File Offset: 0x000155AD
		void _ConstructorInfo.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Указатель, по которому записывается число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x0600488E RID: 18574 RVA: 0x000173AD File Offset: 0x000155AD
		void _ConstructorInfo.GetTypeInfoCount(out uint pcTInfo)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Предоставляет доступ к открытым свойствам и методам объекта.</summary>
		/// <param name="dispIdMember">Идентифицирует член.</param>
		/// <param name="riid">Зарезервировано для использования в будущем. Должно быть равным IID_NULL.</param>
		/// <param name="lcid">Контекст языкового стандарта, в котором следует интерпретировать аргументы.</param>
		/// <param name="wFlags">Флаги, описывающие контекст вызова.</param>
		/// <param name="pDispParams">Указатель на структуру, содержащую массив аргументов, массив DISPID для именованных аргументов, а также счетчики количества элементов в массивах.</param>
		/// <param name="pVarResult">Указатель, по которому будет сохранен результат.</param>
		/// <param name="pExcepInfo">Указатель на структуру, содержащую сведения об исключении.</param>
		/// <param name="puArgErr">Индекс первого аргумента, вызвавшего ошибку.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x0600488F RID: 18575 RVA: 0x000173AD File Offset: 0x000155AD
		void _ConstructorInfo.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.MethodBase.Invoke(System.Object,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object[],System.Globalization.CultureInfo)" />.</summary>
		/// <param name="obj">Экземпляр, создавший этот метод.</param>
		/// <param name="invokeAttr">Одно из значений <see cref="T:System.Reflection.BindingFlags" />, определяющих тип связывания.</param>
		/// <param name="binder">
		///   <see cref="T:System.Reflection.Binder" />, определяющий набор свойств и разрешающий связывание, приведение типов аргументов и вызов элементов с помощью отражения. Если параметр <paramref name="binder" /> принимает значение <see langword="null" />, используется свойство <see cref="P:System.Type.DefaultBinder" />.</param>
		/// <param name="parameters">Массив объектов, используемый для проверки соответствия количества, порядка и типа параметрам данного конструктора, с учетом ограничений, установленных объектом <paramref name="binder" />. Если этот конструктор не требует параметров, передается массив с нулевыми элементами. Любой объект этого массива, который не был явно инициализирован с помощью значения, будет содержать значение по умолчанию для данного типа объекта. Для элементов ссылочного типа это значение равно <see langword="null" />. Для элементов, тип которых передается по значению, это значение равно 0, 0,0 или <see langword="false" /> в зависимости от конкретного типа элемента.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, используемый для управления приведением типов. Если значение этого объекта — <see langword="null" />, для текущего потока используется <see cref="T:System.Globalization.CultureInfo" />.</param>
		/// <returns>Экземпляр типа.</returns>
		// Token: 0x06004890 RID: 18576 RVA: 0x00052955 File Offset: 0x00050B55
		object _ConstructorInfo.Invoke_2(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.MethodBase.Invoke(System.Object,System.Object[])" />.</summary>
		/// <param name="obj">Экземпляр, создавший этот метод.</param>
		/// <param name="parameters">Массив объектов, используемый для проверки соответствия количества, порядка и типа параметрам данного конструктора, с учетом ограничений, установленных объектом <paramref name="binder" />. Если этот конструктор не требует параметров, передается массив с нулевыми элементами. Любой объект этого массива, который не был явно инициализирован с помощью значения, будет содержать значение по умолчанию для данного типа объекта. Для элементов ссылочного типа это значение равно <see langword="null" />. Для элементов, тип которых передается по значению, это значение равно 0, 0,0 или <see langword="false" /> в зависимости от конкретного типа элемента.</param>
		/// <returns>Экземпляр типа.</returns>
		// Token: 0x06004891 RID: 18577 RVA: 0x00052955 File Offset: 0x00050B55
		object _ConstructorInfo.Invoke_3(object obj, object[] parameters)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.ConstructorInfo.Invoke(System.Reflection.BindingFlags,System.Reflection.Binder,System.Object[],System.Globalization.CultureInfo)" />.</summary>
		/// <param name="invokeAttr">Одно из значений <see cref="T:System.Reflection.BindingFlags" />, определяющих тип связывания.</param>
		/// <param name="binder">
		///   <see cref="T:System.Reflection.Binder" />, определяющий набор свойств и разрешающий связывание, приведение типов аргументов и вызов элементов с помощью отражения. Если параметр <paramref name="binder" /> принимает значение <see langword="null" />, используется свойство <see cref="P:System.Type.DefaultBinder" />.</param>
		/// <param name="parameters">Массив объектов, используемый для проверки соответствия количества, порядка и типа параметрам данного конструктора, с учетом ограничений, установленных объектом <paramref name="binder" />. Если этот конструктор не требует параметров, передается массив с нулевыми элементами. Любой объект этого массива, который не был явно инициализирован с помощью значения, будет содержать значение по умолчанию для данного типа объекта. Для элементов ссылочного типа это значение равно <see langword="null" />. Для элементов, тип которых передается по значению, это значение равно 0, 0,0 или <see langword="false" /> в зависимости от конкретного типа элемента.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, используемый для управления приведением типов. Если значение этого объекта — <see langword="null" />, для текущего потока используется <see cref="T:System.Globalization.CultureInfo" />.</param>
		/// <returns>Экземпляр типа.</returns>
		// Token: 0x06004892 RID: 18578 RVA: 0x00052955 File Offset: 0x00050B55
		object _ConstructorInfo.Invoke_4(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.ConstructorInfo.Invoke(System.Object[])" />.</summary>
		/// <param name="parameters">Массив объектов, используемый для проверки соответствия количества, порядка и типа параметрам данного конструктора, с учетом ограничений, установленных объектом <paramref name="binder" />. Если этот конструктор не требует параметров, передается массив с нулевыми элементами. Любой объект этого массива, который не был явно инициализирован с помощью значения, будет содержать значение по умолчанию для данного типа объекта. Для элементов ссылочного типа это значение равно <see langword="null" />. Для элементов, тип которых передается по значению, это значение равно 0, 0,0 или <see langword="false" /> в зависимости от конкретного типа элемента.</param>
		/// <returns>Экземпляр типа.</returns>
		// Token: 0x06004893 RID: 18579 RVA: 0x00052955 File Offset: 0x00050B55
		object _ConstructorInfo.Invoke_5(object[] parameters)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>Представляет хранящееся в метаданных имя метода конструктора класса. Это имя всегда имеет расширение CTOR. Это поле доступно только для чтения.</summary>
		// Token: 0x04002E83 RID: 11907
		public static readonly string ConstructorName = ".ctor";

		/// <summary>Представляет хранящееся в метаданных имя метода конструктора типа. Это имя всегда имеет расширение CCTOR. Это свойство доступно только для чтения.</summary>
		// Token: 0x04002E84 RID: 11908
		public static readonly string TypeConstructorName = ".cctor";
	}
}
