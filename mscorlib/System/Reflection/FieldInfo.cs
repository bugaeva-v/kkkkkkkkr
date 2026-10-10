using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity;

namespace System.Reflection
{
	/// <summary>Извлекает атрибуты поля и обеспечивает доступ к метаданным поля.</summary>
	// Token: 0x0200089F RID: 2207
	[Serializable]
	public abstract class FieldInfo : MemberInfo, _FieldInfo
	{
		/// <summary>Возвращает значение <see cref="T:System.Reflection.MemberTypes" /> указывающее, что этот член является полем.</summary>
		/// <returns>Значение, <see cref="T:System.Reflection.MemberTypes" /> показывающее, что этот элемент является полем.</returns>
		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x060048C8 RID: 18632 RVA: 0x00022807 File Offset: 0x00020A07
		public override MemberTypes MemberType
		{
			get
			{
				return MemberTypes.Field;
			}
		}

		/// <summary>Возвращает атрибуты, связанные с этим полем.</summary>
		/// <returns>Атрибуты <see langword="FieldAttributes" /> для данного поля.</returns>
		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x060048C9 RID: 18633
		public abstract FieldAttributes Attributes { get; }

		/// <summary>Возвращает тип этого объекта поля.</summary>
		/// <returns>Тип этого объекта поля.</returns>
		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x060048CA RID: 18634
		public abstract Type FieldType { get; }

		/// <summary>Возвращает значение, которое определяет, устанавливается ли поле только в тексте сообщения конструктора.</summary>
		/// <returns>Значение <see langword="true" />, если для поля задан атрибут <see langword="InitOnly" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x060048CB RID: 18635 RVA: 0x000EE5A2 File Offset: 0x000EC7A2
		public bool IsInitOnly
		{
			get
			{
				return (this.Attributes & FieldAttributes.InitOnly) > FieldAttributes.PrivateScope;
			}
		}

		/// <summary>Возвращает значение, показывающее, что значение записывается во время компиляции и не может быть изменено.</summary>
		/// <returns>Значение <see langword="true" />, если для поля задан атрибут <see langword="Literal" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x060048CC RID: 18636 RVA: 0x000EE5B0 File Offset: 0x000EC7B0
		public bool IsLiteral
		{
			get
			{
				return (this.Attributes & FieldAttributes.Literal) > FieldAttributes.PrivateScope;
			}
		}

		/// <summary>Возвращает значение, указывающее, установлен ли для этого поля атрибут <see langword="NotSerialized" />.</summary>
		/// <returns>Значение <see langword="true" />, если для поля задан атрибут <see langword="NotSerialized" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x060048CD RID: 18637 RVA: 0x000EE5BE File Offset: 0x000EC7BE
		public bool IsNotSerialized
		{
			get
			{
				return (this.Attributes & FieldAttributes.NotSerialized) > FieldAttributes.PrivateScope;
			}
		}

		/// <summary>Возвращает значение, указывающее, установлен ли в <see cref="T:System.Reflection.FieldAttributes" /> соответствующий атрибут <see langword="PinvokeImpl" />.</summary>
		/// <returns>Значение <see langword="true" />, если атрибут <see langword="PinvokeImpl" /> установлен в классе <see cref="T:System.Reflection.FieldAttributes" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x060048CE RID: 18638 RVA: 0x000EE5CF File Offset: 0x000EC7CF
		public bool IsPinvokeImpl
		{
			get
			{
				return (this.Attributes & FieldAttributes.PinvokeImpl) > FieldAttributes.PrivateScope;
			}
		}

		/// <summary>Возвращает значение, указывающее, установлен ли в перечислителе <see cref="T:System.Reflection.FieldAttributes" /> соответствующий атрибут <see langword="SpecialName" />.</summary>
		/// <returns>Значение <see langword="true" />, если атрибут <see langword="SpecialName" /> установлен в классе <see cref="T:System.Reflection.FieldAttributes" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x060048CF RID: 18639 RVA: 0x000EE5E0 File Offset: 0x000EC7E0
		public bool IsSpecialName
		{
			get
			{
				return (this.Attributes & FieldAttributes.SpecialName) > FieldAttributes.PrivateScope;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли поле статическим.</summary>
		/// <returns>Значение <see langword="true" />, если поле является статическим; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x060048D0 RID: 18640 RVA: 0x000EE5F1 File Offset: 0x000EC7F1
		public bool IsStatic
		{
			get
			{
				return (this.Attributes & FieldAttributes.Static) > FieldAttributes.PrivateScope;
			}
		}

		/// <summary>Возвращает значение, которое указывает, описана ли доступность данного поля в поле <see cref="F:System.Reflection.FieldAttributes.Assembly" />; другими словами, будет ли это поле полностью доступно для других полей той же сборки и недоступно для производных типов, не включенных в сборку.</summary>
		/// <returns>Значение <see langword="true" />, если видимость этого поля точно описана в поле <see cref="F:System.Reflection.FieldAttributes.Assembly" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x060048D1 RID: 18641 RVA: 0x000EE5FF File Offset: 0x000EC7FF
		public bool IsAssembly
		{
			get
			{
				return (this.Attributes & FieldAttributes.FieldAccessMask) == FieldAttributes.Assembly;
			}
		}

		/// <summary>Возвращает значение, которое указывает, описана ли доступность этого поля в поле <see cref="F:System.Reflection.FieldAttributes.Family" />; другими словами, будет ли это поле доступно только в своем классе и производных классах.</summary>
		/// <returns>Значение <see langword="true" />, если доступ к этому полю точно описан в поле <see cref="F:System.Reflection.FieldAttributes.Family" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x060048D2 RID: 18642 RVA: 0x000EE60C File Offset: 0x000EC80C
		public bool IsFamily
		{
			get
			{
				return (this.Attributes & FieldAttributes.FieldAccessMask) == FieldAttributes.Family;
			}
		}

		/// <summary>Возвращает значение, которое указывает, описана ли доступность этого поля в поле <see cref="F:System.Reflection.FieldAttributes.FamANDAssem" />; другими словами, будет ли это поле доступно только в производных классах, которые включены в ту же сборку.</summary>
		/// <returns>Значение <see langword="true" />, если доступ к этому полю точно описан в поле <see cref="F:System.Reflection.FieldAttributes.FamANDAssem" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x060048D3 RID: 18643 RVA: 0x000EE619 File Offset: 0x000EC819
		public bool IsFamilyAndAssembly
		{
			get
			{
				return (this.Attributes & FieldAttributes.FieldAccessMask) == FieldAttributes.FamANDAssem;
			}
		}

		/// <summary>Возвращает значение, которое указывает, описана ли потенциальная доступность этого поля в поле <see cref="F:System.Reflection.FieldAttributes.FamORAssem" />; другими словами, будет ли это поле доступно в производных классах независимо от их местонахождения, а также в классах, которые включены в ту же сборку.</summary>
		/// <returns>Значение <see langword="true" />, если доступ к этому полю точно описан в поле <see cref="F:System.Reflection.FieldAttributes.FamORAssem" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x060048D4 RID: 18644 RVA: 0x000EE626 File Offset: 0x000EC826
		public bool IsFamilyOrAssembly
		{
			get
			{
				return (this.Attributes & FieldAttributes.FieldAccessMask) == FieldAttributes.FamORAssem;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли поле закрытым.</summary>
		/// <returns>Значение <see langword="true" />, если поле является закрытым; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x060048D5 RID: 18645 RVA: 0x000EE633 File Offset: 0x000EC833
		public bool IsPrivate
		{
			get
			{
				return (this.Attributes & FieldAttributes.FieldAccessMask) == FieldAttributes.Private;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли поле открытым.</summary>
		/// <returns>Значение <see langword="true" />, если поле является открытым; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x060048D6 RID: 18646 RVA: 0x000EE640 File Offset: 0x000EC840
		public bool IsPublic
		{
			get
			{
				return (this.Attributes & FieldAttributes.FieldAccessMask) == FieldAttributes.Public;
			}
		}

		/// <summary>Получает значение, которое указывает, является ли текущее поле критически важным для безопасности или защищенным критически важным для безопасности на данном уровне доверия.</summary>
		/// <returns>Значение <see langword="true" />, если текущее поле является критически важным для безопасности или защищенным критически важным для безопасности на текущем уровне доверия; значение <see langword="false" />, если оно является прозрачным.</returns>
		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x060048D7 RID: 18647 RVA: 0x000040F7 File Offset: 0x000022F7
		public virtual bool IsSecurityCritical
		{
			get
			{
				return true;
			}
		}

		/// <summary>Получает значение, которое указывает, является ли текущее поле защищенным критически важным для безопасности на данном уровне доверия.</summary>
		/// <returns>Значение <see langword="true" />, если текущее поле является защищенным критически важным для безопасности на текущем уровне доверия; значение <see langword="false" />, если оно является критически важным для безопасности прозрачным.</returns>
		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x060048D8 RID: 18648 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public virtual bool IsSecuritySafeCritical
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает значение, которое указывает, является ли текущее поле прозрачным на данном уровне доверия.</summary>
		/// <returns>Значение <see langword="true" />, если текущее поле является прозрачным на текущем уровне доверия; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x060048D9 RID: 18649 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public virtual bool IsSecurityTransparent
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает дескриптор <see langword="RuntimeFieldHandle" />, являющийся дескриптором представления внутренних метаданных поля.</summary>
		/// <returns>Дескриптор представления внутренних метаданных поля.</returns>
		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x060048DA RID: 18650
		public abstract RuntimeFieldHandle FieldHandle { get; }

		/// <summary>Возвращает значение, указывающее, равен ли этот экземпляр указанному объекту.</summary>
		/// <param name="obj">Объект, сравниваемый с этим экземпляром, или значение <see langword="null" />.</param>
		/// <returns>
		///   <see langword="true" />, если объект <paramref name="obj" /> типу и значению данного экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060048DB RID: 18651 RVA: 0x000EE386 File Offset: 0x000EC586
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		/// <summary>Возвращает хэш-код для данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-битовым целым числом со знаком.</returns>
		// Token: 0x060048DC RID: 18652 RVA: 0x000EE38F File Offset: 0x000EC58F
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Определение равенства двух объектов <see cref="T:System.Reflection.FieldInfo" />.</summary>
		/// <param name="left">Первый сравниваемый объект.</param>
		/// <param name="right">Второй сравниваемый объект.</param>
		/// <returns>
		///   <see langword="true" />, если значения параметров <paramref name="left" /> и <paramref name="right" /> равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060048DD RID: 18653 RVA: 0x00064560 File Offset: 0x00062760
		public static bool operator ==(FieldInfo left, FieldInfo right)
		{
			return left == right || (left != null && right != null && left.Equals(right));
		}

		/// <summary>Определяет неравенство двух объектов <see cref="T:System.Reflection.FieldInfo" />.</summary>
		/// <param name="left">Первый сравниваемый объект.</param>
		/// <param name="right">Второй сравниваемый объект.</param>
		/// <returns>
		///   <see langword="true" />, если значения <paramref name="left" /> и <paramref name="right" /> не равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060048DE RID: 18654 RVA: 0x000EE64D File Offset: 0x000EC84D
		public static bool operator !=(FieldInfo left, FieldInfo right)
		{
			return !(left == right);
		}

		/// <summary>При переопределении в производном классе возвращает значение поля, поддерживаемое данным объектом.</summary>
		/// <param name="obj">Объект, значение поля которого будет возвращено.</param>
		/// <returns>Объект, содержащий значение поля, отраженное этим экземпляром.</returns>
		/// <exception cref="T:System.Reflection.TargetException">Вместо этого в .NET для приложений Магазина Windows или в переносимой библиотеке классов перехватите исключение <see cref="T:System.Exception" />.  
		///
		///
		///
		///
		///  Это поле не является статическим, а параметр <paramref name="obj" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Поле является помеченным литералом, однако для этого поля не задан допустимый тип литерала.</exception>
		/// <exception cref="T:System.FieldAccessException">Вместо этого в .NET для приложений Магазина Windows или в переносимой библиотеке классов перехватите исключение базового класса <see cref="T:System.MemberAccessException" />.  
		///
		///
		///
		///
		///  Вызывающий объект не имеет разрешения на доступ к этому полю.</exception>
		/// <exception cref="T:System.ArgumentException">Этот метод не объявлен в классе с параметром <paramref name="obj" /> и не унаследован в таком классе.</exception>
		// Token: 0x060048DF RID: 18655
		public abstract object GetValue(object obj);

		/// <summary>Устанавливает значение поля указанного объекта.</summary>
		/// <param name="obj">Объект, для которого будет установлено значение поля.</param>
		/// <param name="value">Значение, присваиваемое полю.</param>
		/// <exception cref="T:System.FieldAccessException">Вместо этого в .NET для приложений Магазина Windows или в переносимой библиотеке классов перехватите исключение базового класса <see cref="T:System.MemberAccessException" />.  
		///
		///
		///
		///
		///  Вызывающий объект не имеет разрешения на доступ к этому полю.</exception>
		/// <exception cref="T:System.Reflection.TargetException">Вместо этого в .NET для приложений Магазина Windows или в переносимой библиотеке классов перехватите исключение <see cref="T:System.Exception" />.  
		///
		///
		///
		///
		///  Параметр <paramref name="obj" /> имеет значение <see langword="null" />, поле является полем экземпляра.</exception>
		/// <exception cref="T:System.ArgumentException">Это поле не существует в объекте.  
		/// -или- 
		/// Параметр <paramref name="value" /> не может быть преобразован и сохранен в данном поле.</exception>
		// Token: 0x060048E0 RID: 18656 RVA: 0x000EE659 File Offset: 0x000EC859
		[DebuggerHidden]
		[DebuggerStepThrough]
		public void SetValue(object obj, object value)
		{
			this.SetValue(obj, value, BindingFlags.Default, Type.DefaultBinder, null);
		}

		/// <summary>Если переопределен производным классом, устанавливает значение поля, поддерживаемое данным объектом.</summary>
		/// <param name="obj">Объект, для которого будет установлено значение поля.</param>
		/// <param name="value">Значение, присваиваемое полю.</param>
		/// <param name="invokeAttr">Поле <see langword="Binder" />, определяющее требуемый тип привязки (например, <see langword="Binder.CreateInstance" /> или <see langword="Binder.ExactBinding" />).</param>
		/// <param name="binder">Набор свойств, который позволяет осуществлять связывание, приведение типов аргументов и вызов элементов с помощью отражения. Если параметр <paramref name="binder" /> принимает значение <see langword="null" />, используется свойство <see langword="Binder.DefaultBinding" />.</param>
		/// <param name="culture">Программные настройки конкретного языка и региональных параметров.</param>
		/// <exception cref="T:System.FieldAccessException">Вызывающий объект не имеет разрешения на доступ к этому полю.</exception>
		/// <exception cref="T:System.Reflection.TargetException">Параметр <paramref name="obj" /> имеет значение <see langword="null" />, поле является полем экземпляра.</exception>
		/// <exception cref="T:System.ArgumentException">Это поле не существует в объекте.  
		/// -или- 
		/// Параметр <paramref name="value" /> не может быть преобразован и сохранен в данном поле.</exception>
		// Token: 0x060048E1 RID: 18657
		public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture);

		/// <summary>Устанавливает значение поля указанного объекта.</summary>
		/// <param name="obj">Структура <see cref="T:System.TypedReference" />, инкапсулирующая управляемый указатель на место и представление типа во время выполнения, которое может храниться в этом расположение.</param>
		/// <param name="value">Значение, присваиваемое полю.</param>
		/// <exception cref="T:System.NotSupportedException">Вызывающий оператор требует альтернативу CLS, однако вызывается этот метод.</exception>
		// Token: 0x060048E2 RID: 18658 RVA: 0x000EE66A File Offset: 0x000EC86A
		[CLSCompliant(false)]
		public virtual void SetValueDirect(TypedReference obj, object value)
		{
			throw new NotSupportedException("This non-CLS method is not implemented.");
		}

		/// <summary>Возвращает значение поля, поддерживаемого заданным объектом.</summary>
		/// <param name="obj">Структура <see cref="T:System.TypedReference" />, инкапсулирующая управляемый указатель на место и представление типа во время выполнения, которое может храниться в этом месте.</param>
		/// <returns>Объект <see langword="Object" />, содержащий значение поля.</returns>
		/// <exception cref="T:System.NotSupportedException">Вызывающий оператор требует альтернативу CLS, однако вызывается этот метод.</exception>
		// Token: 0x060048E3 RID: 18659 RVA: 0x000EE66A File Offset: 0x000EC86A
		[CLSCompliant(false)]
		public virtual object GetValueDirect(TypedReference obj)
		{
			throw new NotSupportedException("This non-CLS method is not implemented.");
		}

		/// <summary>Метод возвращает значение-литерал, связанное с полем компилятором.</summary>
		/// <returns>
		///   <see cref="T:System.Object" /> — содержит литеральное значение, связанное с этим полем. Если значение литерала является типом класса и при этом значение элемента равно нулю, возвращается значение <see langword="null" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Таблица констант в неуправляемых метаданных не содержит константы для текущего поля.</exception>
		/// <exception cref="T:System.FormatException">Тип этого значения не относится к типам, разрешенным в соответствии со спецификацией CLS. См. спецификацию раздела II документации по ECMA "Логический формат метаданных: другие структуры, типы элементов, используемые в подписях".</exception>
		/// <exception cref="T:System.NotSupportedException">Для поля не задано постоянное значение.</exception>
		// Token: 0x060048E4 RID: 18660 RVA: 0x000EE66A File Offset: 0x000EC86A
		public virtual object GetRawConstantValue()
		{
			throw new NotSupportedException("This non-CLS method is not implemented.");
		}

		/// <summary>Возвращает массив типов, которые определяют необязательные настраиваемые модификаторы для поля.</summary>
		/// <returns>Массив объектов <see cref="T:System.Type" />, которые указывают необязательные настраиваемые модификаторы для текущего поля, например <see cref="T:System.Runtime.CompilerServices.IsConst" />.</returns>
		// Token: 0x060048E5 RID: 18661 RVA: 0x00047226 File Offset: 0x00045426
		public virtual Type[] GetOptionalCustomModifiers()
		{
			throw NotImplemented.ByDesign;
		}

		/// <summary>Возвращает массив типов, который указывает обязательные настраиваемые модификаторы для свойства.</summary>
		/// <returns>Массив объектов <see cref="T:System.Type" />, которые указывают обязательные настраиваемые модификаторы для текущего свойства, например <see cref="T:System.Runtime.CompilerServices.IsConst" /> или <see cref="T:System.Runtime.CompilerServices.IsImplicitlyDereferenced" />.</returns>
		// Token: 0x060048E6 RID: 18662 RVA: 0x00047226 File Offset: 0x00045426
		public virtual Type[] GetRequiredCustomModifiers()
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x060048E7 RID: 18663
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FieldInfo internal_from_handle_type(IntPtr field_handle, IntPtr type_handle);

		/// <summary>Возвращает значение <see cref="T:System.Reflection.FieldInfo" /> для поля, представленного указанным дескриптором.</summary>
		/// <param name="handle">Структура дескрипторов <see cref="T:System.RuntimeFieldHandle" />, содержащая дескриптор для обработки внутреннего представления поля в метаданных.</param>
		/// <returns>Объект <see cref="T:System.Reflection.FieldInfo" />, представляющий поле, указанное параметром <paramref name="handle" />.</returns>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="handle" /> недопустимо.</exception>
		// Token: 0x060048E8 RID: 18664 RVA: 0x000EE676 File Offset: 0x000EC876
		public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle)
		{
			if (handle.Value == IntPtr.Zero)
			{
				throw new ArgumentException("The handle is invalid.");
			}
			return FieldInfo.internal_from_handle_type(handle.Value, IntPtr.Zero);
		}

		/// <summary>Получает объект <see cref="T:System.Reflection.FieldInfo" /> для представленного указанным дескриптором поля заданного универсального типа.</summary>
		/// <param name="handle">Структура дескрипторов <see cref="T:System.RuntimeFieldHandle" />, содержащая дескриптор для обработки внутреннего представления поля в метаданных.</param>
		/// <param name="declaringType">Структура дескрипторов <see cref="T:System.RuntimeTypeHandle" />, содержащая дескриптор для обработки универсального типа, который определяет это поле.</param>
		/// <returns>Объект <see cref="T:System.Reflection.FieldInfo" />, который представляет поле, определенное дескриптором <paramref name="handle" />, в универсальном типе, заданном параметром <paramref name="declaringType" />.</returns>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="handle" /> недопустимо.  
		/// -или- 
		///  Параметр <paramref name="declaringType" /> несовместим с параметром <paramref name="handle" />. Например, параметр <paramref name="declaringType" /> представляет дескриптор типа среды выполнения определения универсального типа, а параметр <paramref name="handle" /> поступает из конструируемого типа.</exception>
		// Token: 0x060048E9 RID: 18665 RVA: 0x000EE6A8 File Offset: 0x000EC8A8
		[ComVisible(false)]
		public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle, RuntimeTypeHandle declaringType)
		{
			if (handle.Value == IntPtr.Zero)
			{
				throw new ArgumentException("The handle is invalid.");
			}
			FieldInfo fieldInfo = FieldInfo.internal_from_handle_type(handle.Value, declaringType.Value);
			if (fieldInfo == null)
			{
				throw new ArgumentException("The field handle and the type handle are incompatible.");
			}
			return fieldInfo;
		}

		// Token: 0x060048EA RID: 18666 RVA: 0x000EE6FA File Offset: 0x000EC8FA
		internal virtual int GetFieldOffset()
		{
			throw new SystemException("This method should not be called");
		}

		// Token: 0x060048EB RID: 18667
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern MarshalAsAttribute get_marshal_info();

		// Token: 0x060048EC RID: 18668 RVA: 0x000EE708 File Offset: 0x000EC908
		internal object[] GetPseudoCustomAttributes()
		{
			int num = 0;
			if (this.IsNotSerialized)
			{
				num++;
			}
			if (this.DeclaringType.IsExplicitLayout)
			{
				num++;
			}
			MarshalAsAttribute marshal_info = this.get_marshal_info();
			if (marshal_info != null)
			{
				num++;
			}
			if (num == 0)
			{
				return null;
			}
			object[] array = new object[num];
			num = 0;
			if (this.IsNotSerialized)
			{
				array[num++] = new NonSerializedAttribute();
			}
			if (this.DeclaringType.IsExplicitLayout)
			{
				array[num++] = new FieldOffsetAttribute(this.GetFieldOffset());
			}
			if (marshal_info != null)
			{
				array[num++] = marshal_info;
			}
			return array;
		}

		// Token: 0x060048ED RID: 18669 RVA: 0x000EE790 File Offset: 0x000EC990
		internal CustomAttributeData[] GetPseudoCustomAttributesData()
		{
			int num = 0;
			if (this.IsNotSerialized)
			{
				num++;
			}
			if (this.DeclaringType.IsExplicitLayout)
			{
				num++;
			}
			MarshalAsAttribute marshal_info = this.get_marshal_info();
			if (marshal_info != null)
			{
				num++;
			}
			if (num == 0)
			{
				return null;
			}
			CustomAttributeData[] array = new CustomAttributeData[num];
			num = 0;
			if (this.IsNotSerialized)
			{
				array[num++] = new CustomAttributeData(typeof(NonSerializedAttribute).GetConstructor(Type.EmptyTypes));
			}
			if (this.DeclaringType.IsExplicitLayout)
			{
				CustomAttributeTypedArgument[] ctorArgs = new CustomAttributeTypedArgument[]
				{
					new CustomAttributeTypedArgument(typeof(int), this.GetFieldOffset())
				};
				array[num++] = new CustomAttributeData(typeof(FieldOffsetAttribute).GetConstructor(new Type[]
				{
					typeof(int)
				}), ctorArgs, EmptyArray<CustomAttributeNamedArgument>.Value);
			}
			if (marshal_info != null)
			{
				CustomAttributeTypedArgument[] ctorArgs2 = new CustomAttributeTypedArgument[]
				{
					new CustomAttributeTypedArgument(typeof(UnmanagedType), marshal_info.Value)
				};
				array[num++] = new CustomAttributeData(typeof(MarshalAsAttribute).GetConstructor(new Type[]
				{
					typeof(UnmanagedType)
				}), ctorArgs2, EmptyArray<CustomAttributeNamedArgument>.Value);
			}
			return array;
		}

		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для использования в будущем. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Переданный массив имен, которые необходимо сопоставить.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, зарезервированный вызывающим объектом, куда помещаются идентификаторы, соответствующие именам.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x060048EE RID: 18670 RVA: 0x000173AD File Offset: 0x000155AD
		void _FieldInfo.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Возвращает объект <see cref="T:System.Type" />, представляющий тип <see cref="T:System.Reflection.FieldInfo" />.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий тип <see cref="T:System.Reflection.FieldInfo" />.</returns>
		// Token: 0x060048EF RID: 18671 RVA: 0x00052955 File Offset: 0x00050B55
		Type _FieldInfo.GetType()
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>Возвращает сведения о типе объекта, которые затем могут использоваться для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Получает указатель на объект с запрошенными сведениями о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x060048F0 RID: 18672 RVA: 0x000173AD File Offset: 0x000155AD
		void _FieldInfo.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Указатель, по которому записывается число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x060048F1 RID: 18673 RVA: 0x000173AD File Offset: 0x000155AD
		void _FieldInfo.GetTypeInfoCount(out uint pcTInfo)
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
		// Token: 0x060048F2 RID: 18674 RVA: 0x000173AD File Offset: 0x000155AD
		void _FieldInfo.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
