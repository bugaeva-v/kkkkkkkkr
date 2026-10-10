using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using Unity;

namespace System.Reflection
{
	/// <summary>Выявляет атрибуты свойства и обеспечивает доступ к его метаданным.</summary>
	// Token: 0x020008BC RID: 2236
	[Serializable]
	public abstract class PropertyInfo : MemberInfo, _PropertyInfo
	{
		/// <summary>Возвращает значение <see cref="T:System.Reflection.MemberTypes" /> указывающее, что этот член является свойством.</summary>
		/// <returns>Значение <see cref="T:System.Reflection.MemberTypes" />, указывающее, что этот член является свойством.</returns>
		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x060049E6 RID: 18918 RVA: 0x00026EE1 File Offset: 0x000250E1
		public override MemberTypes MemberType
		{
			get
			{
				return MemberTypes.Property;
			}
		}

		/// <summary>Возвращает тип свойства.</summary>
		/// <returns>Тип свойства.</returns>
		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x060049E7 RID: 18919
		public abstract Type PropertyType { get; }

		/// <summary>При переопределении в производном классе возвращает для этого свойства массив всех параметров индекса.</summary>
		/// <returns>Массив элементов типа <see langword="ParameterInfo" />, содержащий параметры для индексов. Если свойство не индексировано, массив содержит 0 (ноль) элементов.</returns>
		// Token: 0x060049E8 RID: 18920
		public abstract ParameterInfo[] GetIndexParameters();

		/// <summary>Получает атрибуты данного свойства.</summary>
		/// <returns>Атрибуты для этого свойства.</returns>
		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x060049E9 RID: 18921
		public abstract PropertyAttributes Attributes { get; }

		/// <summary>Возвращает значение, указывающее, является ли свойство специальным именем.</summary>
		/// <returns>Значение <see langword="true" />, если свойство является особым именем; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x060049EA RID: 18922 RVA: 0x000EF4C2 File Offset: 0x000ED6C2
		public bool IsSpecialName
		{
			get
			{
				return (this.Attributes & PropertyAttributes.SpecialName) > PropertyAttributes.None;
			}
		}

		/// <summary>Получает значение, указывающее, можно ли выполнить считывание данного свойства.</summary>
		/// <returns>Значение <see langword="true" />, если свойство доступно для чтения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x060049EB RID: 18923
		public abstract bool CanRead { get; }

		/// <summary>Получает значение, указывающее, можно ли производить запись в данное свойство.</summary>
		/// <returns>Значение <see langword="true" />, если свойство доступно для записи; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x060049EC RID: 18924
		public abstract bool CanWrite { get; }

		/// <summary>Возвращает массив, элементы которого отражают открытые методы <see langword="get" /> и <see langword="set" /> доступа к свойству, отражаемому текущим экземпляром.</summary>
		/// <returns>Массив объектов <see cref="T:System.Reflection.MethodInfo" />, которые отражают открытые методы <see langword="get" /> и <see langword="set" /> доступа к свойству, отображаемому текущим экземпляром, если эти методы существуют. В противном случае этот метод возвращает массив с нулевым (0) числом элементов.</returns>
		// Token: 0x060049ED RID: 18925 RVA: 0x000EF4D3 File Offset: 0x000ED6D3
		public MethodInfo[] GetAccessors()
		{
			return this.GetAccessors(false);
		}

		/// <summary>Возвращает массив, элементы которого отражают открытые и, если задано, неоткрытые методы доступа <see langword="get" /> и <see langword="set" /> к свойству, отражаемому текущим экземпляром.</summary>
		/// <param name="nonPublic">Указывает, должны ли возвращаться неоткрытые методы в возвращаемый массив. Значение <see langword="true" />, если методы, не являющиеся открытыми, должны включаться, в противном случае — значение <see langword="false" />.</param>
		/// <returns>Массив, элементы которого отражают методы доступа <see langword="get" /> и <see langword="set" /> к свойству, отражаемому текущим экземпляром. Если свойство <paramref name="nonPublic" /> имеет значение <see langword="true" />, этот массив содержит открытые и неоткрытые методы доступа <see langword="get" /> и <see langword="set" />. Если свойство <paramref name="nonPublic" /> имеет значение <see langword="false" />, этот массив содержит только открытые методы доступа <see langword="get" /> и <see langword="set" />. Если методы доступа с указанным статусом видимости не найдены, этот метод возвращает массив с нулевым (0) числом элементов.</returns>
		// Token: 0x060049EE RID: 18926
		public abstract MethodInfo[] GetAccessors(bool nonPublic);

		/// <summary>Получает метод доступа <see langword="get" /> для этого свойства.</summary>
		/// <returns>Метод доступа <see langword="get" /> для этого свойства.</returns>
		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x060049EF RID: 18927 RVA: 0x000EF4DC File Offset: 0x000ED6DC
		public virtual MethodInfo GetMethod
		{
			get
			{
				return this.GetGetMethod(true);
			}
		}

		/// <summary>Возвращает открытый метод доступа <see langword="get" /> для данного свойства.</summary>
		/// <returns>Объект <see langword="MethodInfo" />, предоставляющий открытый метод доступа <see langword="get" /> для этого свойства, или значение <see langword="null" />, если метод доступа <see langword="get" /> не является открытым либо не существует.</returns>
		// Token: 0x060049F0 RID: 18928 RVA: 0x000EF4E5 File Offset: 0x000ED6E5
		public MethodInfo GetGetMethod()
		{
			return this.GetGetMethod(false);
		}

		/// <summary>При переопределении в производном классе возвращает для этого свойства открытый или неоткрытый метод доступа <see langword="get" />.</summary>
		/// <param name="nonPublic">Указывает, должен ли возвращаться метод доступа <see langword="get" />, не являющийся открытым. Значение <see langword="true" />, если не являющийся открытым метод доступа должен возвращаться; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Объект <see langword="MethodInfo" />, предоставляющий метод доступа <see langword="get" /> для этого свойства, если значение <paramref name="nonPublic" /> равно <see langword="true" />. Возвращает значение <see langword="null" />, если <paramref name="nonPublic" /> равен <see langword="false" /> и метод <see langword="get" /> не является открытым, либо если свойство <paramref name="nonPublic" /> равно <see langword="true" /> и методы <see langword="get" /> отсутствуют.</returns>
		/// <exception cref="T:System.Security.SecurityException">Запрашиваемый метод не является открытым, а вызывающий объект не имеет разрешения <see cref="T:System.Security.Permissions.ReflectionPermission" /> на отражение такого метода.</exception>
		// Token: 0x060049F1 RID: 18929
		public abstract MethodInfo GetGetMethod(bool nonPublic);

		/// <summary>Получает метод доступа <see langword="set" /> для этого свойства.</summary>
		/// <returns>Метод доступа <see langword="set" /> для этого свойства или значение <see langword="null" />, если свойство доступно только для чтения.</returns>
		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x060049F2 RID: 18930 RVA: 0x000EF4EE File Offset: 0x000ED6EE
		public virtual MethodInfo SetMethod
		{
			get
			{
				return this.GetSetMethod(true);
			}
		}

		/// <summary>Возвращает открытый метод доступа <see langword="set" /> для данного свойства.</summary>
		/// <returns>Объект <see langword="MethodInfo" />, представляющий метод <see langword="Set" /> для этого свойства, если метод доступа <see langword="set" /> является открытым, или значение <see langword="null" />, если метод <see langword="set" /> не является открытым.</returns>
		// Token: 0x060049F3 RID: 18931 RVA: 0x000EF4F7 File Offset: 0x000ED6F7
		public MethodInfo GetSetMethod()
		{
			return this.GetSetMethod(false);
		}

		/// <summary>При переопределении в производном классе возвращает для этого свойства метод доступа <see langword="set" />.</summary>
		/// <param name="nonPublic">Указывает, должен ли возвращаться метод доступа, не являющийся открытым. Значение <see langword="true" />, если не являющийся открытым метод доступа должен возвращаться; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Метод свойства <see langword="Set" /> или <see langword="null" />, как показано в следующей таблице.  
		///   Значение 
		///   Условие 
		///   Метод <see langword="Set" /> для этого свойства.  
		///
		///   Метод доступа <see langword="set" /> является открытым.  
		///
		/// -или- 
		///  Параметр <paramref name="nonPublic" /> имеет значение <see langword="true" /> и метод доступа <see langword="set" /> не является открытым.  
		///
		///  <see langword="null" />Параметр <paramref name="nonPublic" /> имеет значение <see langword="true" />, но свойство доступно только для чтения.  
		///
		/// -или- 
		///  Параметр <paramref name="nonPublic" /> имеет значение <see langword="false" />, и метод доступа <see langword="set" /> не является открытым.  
		///
		/// -или- 
		/// Метод доступа <see langword="set" /> не существует.</returns>
		/// <exception cref="T:System.Security.SecurityException">Запрашиваемый метод не является открытым, а вызывающий объект не имеет разрешения <see cref="T:System.Security.Permissions.ReflectionPermission" /> на отражение такого метода.</exception>
		// Token: 0x060049F4 RID: 18932
		public abstract MethodInfo GetSetMethod(bool nonPublic);

		/// <summary>Возвращает массив типов, представляющих необязательные настраиваемые модификаторы для свойства.</summary>
		/// <returns>Массив объектов <see cref="T:System.Type" />, которые указывают дополнительные настраиваемые модификаторы для текущего свойства, такие как <see cref="T:System.Runtime.CompilerServices.IsConst" /> или <see cref="T:System.Runtime.CompilerServices.IsImplicitlyDereferenced" />.</returns>
		// Token: 0x060049F5 RID: 18933 RVA: 0x000EF2CA File Offset: 0x000ED4CA
		public virtual Type[] GetOptionalCustomModifiers()
		{
			return Array.Empty<Type>();
		}

		/// <summary>Возвращает массив типов, представляющих обязательные настраиваемые модификаторы для свойства.</summary>
		/// <returns>Массив объектов <see cref="T:System.Type" />, которые указывают обязательные настраиваемые модификаторы для текущего свойства, например <see cref="T:System.Runtime.CompilerServices.IsConst" /> или <see cref="T:System.Runtime.CompilerServices.IsImplicitlyDereferenced" />.</returns>
		// Token: 0x060049F6 RID: 18934 RVA: 0x000EF2CA File Offset: 0x000ED4CA
		public virtual Type[] GetRequiredCustomModifiers()
		{
			return Array.Empty<Type>();
		}

		/// <summary>Возвращает значение свойства указанного объекта.</summary>
		/// <param name="obj">Объект, свойство которого будет возвращено.</param>
		/// <returns>Значение свойства указанного объекта.</returns>
		// Token: 0x060049F7 RID: 18935 RVA: 0x000EF500 File Offset: 0x000ED700
		[DebuggerStepThrough]
		[DebuggerHidden]
		public object GetValue(object obj)
		{
			return this.GetValue(obj, null);
		}

		/// <summary>Возвращает значение свойства заданного объекта с дополнительными значениями индекса для индексированных свойств.</summary>
		/// <param name="obj">Объект, свойство которого будет возвращено.</param>
		/// <param name="index">Необязательные значения индекса для индексированных свойств. Индексы индексированных свойств отсчитываются от нуля. Для неиндексированных свойств это значение должно быть равно <see langword="null" />.</param>
		/// <returns>Значение свойства указанного объекта.</returns>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="index" /> не содержит тип необходимых аргументов.  
		/// -или- 
		/// Метод доступа <see langword="get" /> для свойства не найден.</exception>
		/// <exception cref="T:System.Reflection.TargetException">Вместо этого в .NET для приложений Магазина Windows или в переносимой библиотеке классов перехватите исключение <see cref="T:System.Exception" />.  
		///
		///
		///
		///
		///  Объект не соответствует целевому типу или свойство является свойством экземпляра, однако параметр <paramref name="obj" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Reflection.TargetParameterCountException">Число параметров в индексе <paramref name="index" /> не совпадает с числом параметров, которые принимает индексированное свойство.</exception>
		/// <exception cref="T:System.MethodAccessException">Вместо этого в .NET для приложений Магазина Windows или в переносимой библиотеке классов перехватите исключение базового класса <see cref="T:System.MemberAccessException" />.  
		///
		///
		///
		///
		///  Недопустимая попытка обращения к закрытому или защищенному методу внутри класса.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Ошибка при получении значения свойства. Например, значение индекса, указанное для индексированного свойства, находится вне диапазона. Свойство <see cref="P:System.Exception.InnerException" /> указывает причину возникновения ошибки.</exception>
		// Token: 0x060049F8 RID: 18936 RVA: 0x000EF50A File Offset: 0x000ED70A
		[DebuggerHidden]
		[DebuggerStepThrough]
		public virtual object GetValue(object obj, object[] index)
		{
			return this.GetValue(obj, BindingFlags.Default, null, index, null);
		}

		/// <summary>При переопределении в производном классе возвращает значение свойства заданного объекта, имеющего указанные сведения о привязке, индексе и языке и региональных параметрах.</summary>
		/// <param name="obj">Объект, свойство которого будет возвращено.</param>
		/// <param name="invokeAttr">Битовая комбинация следующих членов перечисления, определяющих атрибут вызова: <see langword="InvokeMethod" />, <see langword="CreateInstance" />, <see langword="Static" />, <see langword="GetField" />, <see langword="SetField" />, <see langword="GetProperty" /> и <see langword="SetProperty" />. Необходимо указать подходящий атрибут вызова. Например, чтобы вызвать статический член, установите флаг <see langword="Static" />.</param>
		/// <param name="binder">Объект, который допускает привязку, приведение типов аргументов, вызов элементов и извлечение объектов <see cref="T:System.Reflection.MemberInfo" /> путем отражения. Если значение параметра <paramref name="binder" /> равно <see langword="null" />, используется связыватель по умолчанию.</param>
		/// <param name="index">Необязательные значения индекса для индексированных свойств. Для неиндексированных свойств это значение должно быть равно <see langword="null" />.</param>
		/// <param name="culture">Язык и региональные параметры, для которых должен быть локализован данный ресурс. Если ресурс не локализован для данного языка и региональных параметров, при поиске соответствия будет последовательно вызываться свойство <see cref="P:System.Globalization.CultureInfo.Parent" />. Если это значение равно <see langword="null" />, из свойства <see cref="P:System.Globalization.CultureInfo.CurrentUICulture" /> получаются сведения, относящиеся к конкретному языку и региональным параметрам.</param>
		/// <returns>Значение свойства указанного объекта.</returns>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="index" /> не содержит тип необходимых аргументов.  
		/// -или- 
		/// Не найден метод доступа <see langword="get" /> свойства.</exception>
		/// <exception cref="T:System.Reflection.TargetException">Объект не соответствует целевому типу, или свойство является свойством экземпляра, но <paramref name="obj" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Reflection.TargetParameterCountException">Число параметров в <paramref name="index" /> не соответствует числу параметров, принимаемых индексированным свойством.</exception>
		/// <exception cref="T:System.MethodAccessException">Недопустимая попытка обращения к закрытому или защищенному методу внутри класса.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Ошибка при получении значения свойства. Например, значение индекса, указанное для индексированного свойства, находится вне диапазона. Свойство <see cref="P:System.Exception.InnerException" /> указывает причину возникновения ошибки.</exception>
		// Token: 0x060049F9 RID: 18937
		public abstract object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

		/// <summary>Метод возвращает значение-литерал, связанное с этим свойством компилятором.</summary>
		/// <returns>Объект <see cref="T:System.Object" />, содержащий значение-литерал, сопоставленное данному свойству. Если значение литерала является типом класса и при этом значение элемента равно нулю, возвращается значение <see langword="null" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Таблица констант в неуправляемых метаданных не содержит константы для текущего свойства.</exception>
		/// <exception cref="T:System.FormatException">Тип значения не является одним из типов, разрешенных спецификацией CLS. Более подробные сведения о форматировании см. в спецификации метаданных ECMA, часть II.</exception>
		// Token: 0x060049FA RID: 18938 RVA: 0x00047226 File Offset: 0x00045426
		public virtual object GetConstantValue()
		{
			throw NotImplemented.ByDesign;
		}

		/// <summary>Метод возвращает значение-литерал, связанное с этим свойством компилятором.</summary>
		/// <returns>Объект <see cref="T:System.Object" />, содержащий значение-литерал, сопоставленное данному свойству. Если значение литерала является типом класса и при этом значение элемента равно нулю, возвращается значение <see langword="null" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Таблица констант в неуправляемых метаданных не содержит константы для текущего свойства.</exception>
		/// <exception cref="T:System.FormatException">Тип этого значения не относится к типам, разрешенным в соответствии со спецификацией CLS. См. спецификацию раздела II документации по ECMA "Логический формат метаданных: другие структуры, типы элементов, используемые в подписях".</exception>
		// Token: 0x060049FB RID: 18939 RVA: 0x00047226 File Offset: 0x00045426
		public virtual object GetRawConstantValue()
		{
			throw NotImplemented.ByDesign;
		}

		/// <summary>Задает значение свойства для указанного объекта.</summary>
		/// <param name="obj">Объект, значение свойства которого будет установлено.</param>
		/// <param name="value">Новое значение свойства.</param>
		/// <exception cref="T:System.ArgumentException">Метод доступа <see langword="set" /> для свойства не найден.  
		/// -или- 
		///  <paramref name="value" /> невозможно преобразовать в тип <see cref="P:System.Reflection.PropertyInfo.PropertyType" />.</exception>
		/// <exception cref="T:System.Reflection.TargetException">Вместо этого в .NET для приложений Магазина Windows или в переносимой библиотеке классов перехватите исключение <see cref="T:System.Exception" />.  
		///
		///
		///
		///
		///  Тип <paramref name="obj" /> не соответствует целевому типу, или свойство является свойством экземпляра, но <paramref name="obj" /> равен <see langword="null" />.</exception>
		/// <exception cref="T:System.MethodAccessException">Вместо этого в .NET для приложений Магазина Windows или в переносимой библиотеке классов перехватите исключение базового класса <see cref="T:System.MemberAccessException" />.  
		///
		///
		///
		///
		///  Недопустимая попытка обращения к закрытому или защищенному методу внутри класса.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Ошибка при установке значения свойства. Свойство <see cref="P:System.Exception.InnerException" /> указывает причину возникновения ошибки.</exception>
		// Token: 0x060049FC RID: 18940 RVA: 0x000EF517 File Offset: 0x000ED717
		[DebuggerHidden]
		[DebuggerStepThrough]
		public void SetValue(object obj, object value)
		{
			this.SetValue(obj, value, null);
		}

		/// <summary>Задает значение свойства заданного объекта с дополнительными значениями индекса для индексированных свойств.</summary>
		/// <param name="obj">Объект, значение свойства которого будет установлено.</param>
		/// <param name="value">Новое значение свойства.</param>
		/// <param name="index">Необязательные значения индекса для индексированных свойств. Для неиндексированных свойств это значение должно быть равно <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="index" /> не содержит тип необходимых аргументов.  
		/// -или- 
		/// Не найден метод доступа <see langword="set" /> свойства.  
		/// -или- 
		///  <paramref name="value" /> невозможно преобразовать в тип <see cref="P:System.Reflection.PropertyInfo.PropertyType" />.</exception>
		/// <exception cref="T:System.Reflection.TargetException">Вместо этого в .NET для приложений Магазина Windows или в переносимой библиотеке классов перехватите исключение <see cref="T:System.Exception" />.  
		///
		///
		///
		///
		///  Объект не соответствует целевому типу или свойство является свойством экземпляра, однако параметр <paramref name="obj" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Reflection.TargetParameterCountException">Число параметров в индексе <paramref name="index" /> не совпадает с числом параметров, которые принимает индексированное свойство.</exception>
		/// <exception cref="T:System.MethodAccessException">Вместо этого в .NET для приложений Магазина Windows или в переносимой библиотеке классов перехватите исключение базового класса <see cref="T:System.MemberAccessException" />.  
		///
		///
		///
		///
		///  Недопустимая попытка обращения к закрытому или защищенному методу внутри класса.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Произошла ошибка при установке значения свойства. Например, значение индекса, указанное для индексированного свойства, выходит за границы диапазона. Свойство <see cref="P:System.Exception.InnerException" /> указывает причину возникновения ошибки.</exception>
		// Token: 0x060049FD RID: 18941 RVA: 0x000EF522 File Offset: 0x000ED722
		[DebuggerHidden]
		[DebuggerStepThrough]
		public virtual void SetValue(object obj, object value, object[] index)
		{
			this.SetValue(obj, value, BindingFlags.Default, null, index, null);
		}

		/// <summary>При переопределении в производном классе задает значение свойства для заданного объекта, имеющего указанные сведения о привязке, индексе и языке и региональных параметрах.</summary>
		/// <param name="obj">Объект, значение свойства которого будет установлено.</param>
		/// <param name="value">Новое значение свойства.</param>
		/// <param name="invokeAttr">Битовая комбинация следующих членов перечисления, определяющих атрибут вызова: <see langword="InvokeMethod" />, <see langword="CreateInstance" />, <see langword="Static" />, <see langword="GetField" />, <see langword="SetField" />, <see langword="GetProperty" /> или <see langword="SetProperty" />. Необходимо указать подходящий атрибут вызова. Например, чтобы вызвать статический член, установите флаг <see langword="Static" />.</param>
		/// <param name="binder">Объект, который допускает привязку, приведение типов аргументов, вызов элементов и извлечение объектов <see cref="T:System.Reflection.MemberInfo" /> путем отражения. Если значение параметра <paramref name="binder" /> равно <see langword="null" />, используется связыватель по умолчанию.</param>
		/// <param name="index">Необязательные значения индекса для индексированных свойств. Для неиндексированных свойств это значение должно быть равно <see langword="null" />.</param>
		/// <param name="culture">Язык и региональные параметры, для которых должен быть локализован данный ресурс. Если ресурс не локализован для данного языка и региональных параметров, при поиске соответствия будет последовательно вызываться свойство <see cref="P:System.Globalization.CultureInfo.Parent" />. Если это значение равно <see langword="null" />, из свойства <see cref="P:System.Globalization.CultureInfo.CurrentUICulture" /> получаются сведения, относящиеся к конкретному языку и региональным параметрам.</param>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="index" /> не содержит тип необходимых аргументов.  
		/// -или- 
		/// Не найден метод доступа <see langword="set" /> свойства.  
		/// -или- 
		///  <paramref name="value" /> невозможно преобразовать в тип <see cref="P:System.Reflection.PropertyInfo.PropertyType" />.</exception>
		/// <exception cref="T:System.Reflection.TargetException">Объект не соответствует целевому типу, или свойство является свойством экземпляра, но <paramref name="obj" /> равен <see langword="null" />.</exception>
		/// <exception cref="T:System.Reflection.TargetParameterCountException">Число параметров в <paramref name="index" /> не соответствует числу параметров, принимаемых индексированным свойством.</exception>
		/// <exception cref="T:System.MethodAccessException">Недопустимая попытка доступа к частному или защищенному методу внутри класса.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Произошла ошибка при установке значения свойства. Например, значение индекса, указанное для индексированного свойства, выходит за границы диапазона. Свойство <see cref="P:System.Exception.InnerException" /> указывает причину возникновения ошибки.</exception>
		// Token: 0x060049FE RID: 18942
		public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

		/// <summary>Возвращает значение, указывающее, равен ли этот экземпляр указанному объекту.</summary>
		/// <param name="obj">Объект, сравниваемый с этим экземпляром, или значение <see langword="null" />.</param>
		/// <returns>
		///   <see langword="true" />, если объект <paramref name="obj" /> типу и значению данного экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060049FF RID: 18943 RVA: 0x000EE386 File Offset: 0x000EC586
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		/// <summary>Возвращает хэш-код для данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-битовым целым числом со знаком.</returns>
		// Token: 0x06004A00 RID: 18944 RVA: 0x000EE38F File Offset: 0x000EC58F
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Определение равенства двух объектов <see cref="T:System.Reflection.PropertyInfo" />.</summary>
		/// <param name="left">Первый сравниваемый объект.</param>
		/// <param name="right">Второй сравниваемый объект.</param>
		/// <returns>
		///   <see langword="true" />, если значения параметров <paramref name="left" /> и <paramref name="right" /> равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06004A01 RID: 18945 RVA: 0x00064560 File Offset: 0x00062760
		public static bool operator ==(PropertyInfo left, PropertyInfo right)
		{
			return left == right || (left != null && right != null && left.Equals(right));
		}

		/// <summary>Определяет неравенство двух объектов <see cref="T:System.Reflection.PropertyInfo" />.</summary>
		/// <param name="left">Первый сравниваемый объект.</param>
		/// <param name="right">Второй сравниваемый объект.</param>
		/// <returns>
		///   <see langword="true" />, если значения <paramref name="left" /> и <paramref name="right" /> не равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06004A02 RID: 18946 RVA: 0x000EF530 File Offset: 0x000ED730
		public static bool operator !=(PropertyInfo left, PropertyInfo right)
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
		// Token: 0x06004A03 RID: 18947 RVA: 0x000173AD File Offset: 0x000155AD
		void _PropertyInfo.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Возвращает объект <see cref="T:System.Type" />, представляющий тип <see cref="T:System.Reflection.PropertyInfo" />.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий тип <see cref="T:System.Reflection.PropertyInfo" />.</returns>
		// Token: 0x06004A04 RID: 18948 RVA: 0x00052955 File Offset: 0x00050B55
		Type _PropertyInfo.GetType()
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>Возвращает сведения о типе объекта, которые затем могут использоваться для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Получает указатель на объект с запрошенными сведениями о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06004A05 RID: 18949 RVA: 0x000173AD File Offset: 0x000155AD
		void _PropertyInfo.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Указатель, по которому записывается число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06004A06 RID: 18950 RVA: 0x000173AD File Offset: 0x000155AD
		void _PropertyInfo.GetTypeInfoCount(out uint pcTInfo)
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
		// Token: 0x06004A07 RID: 18951 RVA: 0x000173AD File Offset: 0x000155AD
		void _PropertyInfo.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
