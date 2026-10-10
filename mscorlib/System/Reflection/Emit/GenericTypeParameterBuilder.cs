using System;
using System.Globalization;
using System.Runtime.InteropServices;
using Unity;

namespace System.Reflection.Emit
{
	/// <summary>Определяет и создает параметры универсального типа для динамически определяемых универсальных типов и методов. Этот класс не наследуется.</summary>
	// Token: 0x02000928 RID: 2344
	[ComVisible(true)]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class GenericTypeParameterBuilder : TypeInfo
	{
		/// <summary>Задает базовый тип, который должен наследоваться типом, для подстановки вместо параметра типа.</summary>
		/// <param name="baseTypeConstraint">Тип <see cref="T:System.Type" />, который должен наследоваться любым типом, подставляемым вместо параметра типа.</param>
		// Token: 0x06005045 RID: 20549 RVA: 0x000FAF32 File Offset: 0x000F9132
		public void SetBaseTypeConstraint(Type baseTypeConstraint)
		{
			this.base_type = (baseTypeConstraint ?? typeof(object));
		}

		/// <summary>Задает интерфейсы, которые должны быть реализованы типом для использования вместо параметра типа.</summary>
		/// <param name="interfaceConstraints">Массив объектов <see cref="T:System.Type" />, представляющих интерфейсы, которые должны быть реализованы типом для использования вместо параметра типа.</param>
		// Token: 0x06005046 RID: 20550 RVA: 0x000FAF49 File Offset: 0x000F9149
		[ComVisible(true)]
		public void SetInterfaceConstraints(params Type[] interfaceConstraints)
		{
			this.iface_constraints = interfaceConstraints;
		}

		/// <summary>Задает характеристики расхождения и особые ограничения универсального параметра, например ограничение конструктора без параметров.</summary>
		/// <param name="genericParameterAttributes">Побитовое сочетание значений <see cref="T:System.Reflection.GenericParameterAttributes" />, представляющих характеристики расхождения и особые ограничения параметра универсального типа.</param>
		// Token: 0x06005047 RID: 20551 RVA: 0x000FAF52 File Offset: 0x000F9152
		public void SetGenericParameterAttributes(GenericParameterAttributes genericParameterAttributes)
		{
			this.attrs = genericParameterAttributes;
		}

		// Token: 0x06005048 RID: 20552 RVA: 0x000FAF5B File Offset: 0x000F915B
		internal GenericTypeParameterBuilder(TypeBuilder tbuilder, MethodBuilder mbuilder, string name, int index)
		{
			this.tbuilder = tbuilder;
			this.mbuilder = mbuilder;
			this.name = name;
			this.index = index;
		}

		// Token: 0x06005049 RID: 20553 RVA: 0x000FAF80 File Offset: 0x000F9180
		internal override Type InternalResolve()
		{
			if (this.mbuilder != null)
			{
				return MethodBase.GetMethodFromHandle(this.mbuilder.MethodHandleInternal, this.mbuilder.TypeBuilder.InternalResolve().TypeHandle).GetGenericArguments()[this.index];
			}
			return this.tbuilder.InternalResolve().GetGenericArguments()[this.index];
		}

		// Token: 0x0600504A RID: 20554 RVA: 0x000FAFE4 File Offset: 0x000F91E4
		internal override Type RuntimeResolve()
		{
			if (this.mbuilder != null)
			{
				return MethodBase.GetMethodFromHandle(this.mbuilder.MethodHandleInternal, this.mbuilder.TypeBuilder.RuntimeResolve().TypeHandle).GetGenericArguments()[this.index];
			}
			return this.tbuilder.RuntimeResolve().GetGenericArguments()[this.index];
		}

		/// <summary>Не поддерживается для неполных параметров универсального типа.</summary>
		/// <param name="c">Не поддерживается.</param>
		/// <returns>Не поддерживается для неполных параметров универсального типа.</returns>
		/// <exception cref="T:System.NotSupportedException">Во всех случаях.</exception>
		// Token: 0x0600504B RID: 20555 RVA: 0x000FB048 File Offset: 0x000F9248
		[ComVisible(true)]
		public override bool IsSubclassOf(Type c)
		{
			throw this.not_supported();
		}

		// Token: 0x0600504C RID: 20556 RVA: 0x000040F7 File Offset: 0x000022F7
		protected override TypeAttributes GetAttributeFlagsImpl()
		{
			return TypeAttributes.Public;
		}

		// Token: 0x0600504D RID: 20557 RVA: 0x000FB048 File Offset: 0x000F9248
		protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			throw this.not_supported();
		}

		/// <summary>Не поддерживается для неполных параметров универсального типа.</summary>
		/// <param name="bindingAttr">Не поддерживается.</param>
		/// <returns>Не поддерживается для неполных параметров универсального типа.</returns>
		/// <exception cref="T:System.NotSupportedException">Во всех случаях.</exception>
		// Token: 0x0600504E RID: 20558 RVA: 0x000FB048 File Offset: 0x000F9248
		[ComVisible(true)]
		public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
		{
			throw this.not_supported();
		}

		/// <summary>Не поддерживается для неполных параметров универсального типа.</summary>
		/// <param name="name">Не поддерживается.</param>
		/// <param name="bindingAttr">Не поддерживается.</param>
		/// <returns>Не поддерживается для неполных параметров универсального типа.</returns>
		/// <exception cref="T:System.NotSupportedException">Во всех случаях.</exception>
		// Token: 0x0600504F RID: 20559 RVA: 0x000FB048 File Offset: 0x000F9248
		public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
		{
			throw this.not_supported();
		}

		/// <summary>Не поддерживается для неполных параметров универсального типа.</summary>
		/// <returns>Не поддерживается для неполных параметров универсального типа.</returns>
		/// <exception cref="T:System.NotSupportedException">Во всех случаях.</exception>
		// Token: 0x06005050 RID: 20560 RVA: 0x000FB048 File Offset: 0x000F9248
		public override EventInfo[] GetEvents()
		{
			throw this.not_supported();
		}

		/// <summary>Не поддерживается для неполных параметров универсального типа.</summary>
		/// <param name="bindingAttr">Не поддерживается.</param>
		/// <returns>Не поддерживается для неполных параметров универсального типа.</returns>
		/// <exception cref="T:System.NotSupportedException">Во всех случаях.</exception>
		// Token: 0x06005051 RID: 20561 RVA: 0x000FB048 File Offset: 0x000F9248
		public override EventInfo[] GetEvents(BindingFlags bindingAttr)
		{
			throw this.not_supported();
		}

		/// <summary>Не поддерживается для неполных параметров универсального типа.</summary>
		/// <param name="name">Не поддерживается.</param>
		/// <param name="bindingAttr">Не поддерживается.</param>
		/// <returns>Не поддерживается для неполных параметров универсального типа.</returns>
		/// <exception cref="T:System.NotSupportedException">Во всех случаях.</exception>
		// Token: 0x06005052 RID: 20562 RVA: 0x000FB048 File Offset: 0x000F9248
		public override FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			throw this.not_supported();
		}

		/// <summary>Не поддерживается для неполных параметров универсального типа.</summary>
		/// <param name="bindingAttr">Не поддерживается.</param>
		/// <returns>Не поддерживается для неполных параметров универсального типа.</returns>
		/// <exception cref="T:System.NotSupportedException">Во всех случаях.</exception>
		// Token: 0x06005053 RID: 20563 RVA: 0x000FB048 File Offset: 0x000F9248
		public override FieldInfo[] GetFields(BindingFlags bindingAttr)
		{
			throw this.not_supported();
		}

		/// <summary>Не поддерживается для неполных параметров универсального типа.</summary>
		/// <param name="name">Имя интерфейса.</param>
		/// <param name="ignoreCase">Значение <see langword="true" /> для поиска без учета регистра; значение <see langword="false" /> для поиска с учетом регистра.</param>
		/// <returns>Не поддерживается для неполных параметров универсального типа.</returns>
		/// <exception cref="T:System.NotSupportedException">Во всех случаях.</exception>
		// Token: 0x06005054 RID: 20564 RVA: 0x000FB048 File Offset: 0x000F9248
		public override Type GetInterface(string name, bool ignoreCase)
		{
			throw this.not_supported();
		}

		/// <summary>Не поддерживается для неполных параметров универсального типа.</summary>
		/// <returns>Не поддерживается для неполных параметров универсального типа.</returns>
		/// <exception cref="T:System.NotSupportedException">Во всех случаях.</exception>
		// Token: 0x06005055 RID: 20565 RVA: 0x000FB048 File Offset: 0x000F9248
		public override Type[] GetInterfaces()
		{
			throw this.not_supported();
		}

		/// <summary>Не поддерживается для неполных параметров универсального типа.</summary>
		/// <param name="bindingAttr">Не поддерживается.</param>
		/// <returns>Не поддерживается для неполных параметров универсального типа.</returns>
		/// <exception cref="T:System.NotSupportedException">Во всех случаях.</exception>
		// Token: 0x06005056 RID: 20566 RVA: 0x000FB048 File Offset: 0x000F9248
		public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
		{
			throw this.not_supported();
		}

		/// <summary>Не поддерживается для неполных параметров универсального типа.</summary>
		/// <param name="name">Не поддерживается.</param>
		/// <param name="type">Не поддерживается.</param>
		/// <param name="bindingAttr">Не поддерживается.</param>
		/// <returns>Не поддерживается для неполных параметров универсального типа.</returns>
		/// <exception cref="T:System.NotSupportedException">Во всех случаях.</exception>
		// Token: 0x06005057 RID: 20567 RVA: 0x000FB048 File Offset: 0x000F9248
		public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
		{
			throw this.not_supported();
		}

		/// <summary>Не поддерживается для неполных параметров универсального типа.</summary>
		/// <param name="bindingAttr">Не поддерживается.</param>
		/// <returns>Не поддерживается для неполных параметров универсального типа.</returns>
		/// <exception cref="T:System.NotSupportedException">Во всех случаях.</exception>
		// Token: 0x06005058 RID: 20568 RVA: 0x000FB048 File Offset: 0x000F9248
		public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
		{
			throw this.not_supported();
		}

		// Token: 0x06005059 RID: 20569 RVA: 0x000FB048 File Offset: 0x000F9248
		protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			throw this.not_supported();
		}

		/// <summary>Не поддерживается для неполных параметров универсального типа.</summary>
		/// <param name="name">Не поддерживается.</param>
		/// <param name="bindingAttr">Не поддерживается.</param>
		/// <returns>Не поддерживается для неполных параметров универсального типа.</returns>
		/// <exception cref="T:System.NotSupportedException">Во всех случаях.</exception>
		// Token: 0x0600505A RID: 20570 RVA: 0x000FB048 File Offset: 0x000F9248
		public override Type GetNestedType(string name, BindingFlags bindingAttr)
		{
			throw this.not_supported();
		}

		/// <summary>Не поддерживается для неполных параметров универсального типа.</summary>
		/// <param name="bindingAttr">Не поддерживается.</param>
		/// <returns>Не поддерживается для неполных параметров универсального типа.</returns>
		/// <exception cref="T:System.NotSupportedException">Во всех случаях.</exception>
		// Token: 0x0600505B RID: 20571 RVA: 0x000FB048 File Offset: 0x000F9248
		public override Type[] GetNestedTypes(BindingFlags bindingAttr)
		{
			throw this.not_supported();
		}

		/// <summary>Не поддерживается для неполных параметров универсального типа.</summary>
		/// <param name="bindingAttr">Не поддерживается.</param>
		/// <returns>Не поддерживается для неполных параметров универсального типа.</returns>
		/// <exception cref="T:System.NotSupportedException">Во всех случаях.</exception>
		// Token: 0x0600505C RID: 20572 RVA: 0x000FB048 File Offset: 0x000F9248
		public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
		{
			throw this.not_supported();
		}

		// Token: 0x0600505D RID: 20573 RVA: 0x000FB048 File Offset: 0x000F9248
		protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
		{
			throw this.not_supported();
		}

		// Token: 0x0600505E RID: 20574 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		protected override bool HasElementTypeImpl()
		{
			return false;
		}

		/// <summary>Вызывает исключение <see cref="T:System.NotSupportedException" /> во всех случаях.</summary>
		/// <param name="c">Объект для тестирования.</param>
		/// <returns>Вызывает исключение <see cref="T:System.NotSupportedException" /> во всех случаях.</returns>
		/// <exception cref="T:System.NotSupportedException">Во всех случаях.</exception>
		// Token: 0x0600505F RID: 20575 RVA: 0x000FB048 File Offset: 0x000F9248
		public override bool IsAssignableFrom(Type c)
		{
			throw this.not_supported();
		}

		/// <summary>Вызывает исключение <see cref="T:System.NotSupportedException" /> во всех случаях.</summary>
		/// <param name="typeInfo">Объект для тестирования.</param>
		/// <returns>Вызывает исключение <see cref="T:System.NotSupportedException" /> во всех случаях.</returns>
		/// <exception cref="T:System.NotSupportedException">Во всех случаях.</exception>
		// Token: 0x06005060 RID: 20576 RVA: 0x00057EED File Offset: 0x000560ED
		public override bool IsAssignableFrom(TypeInfo typeInfo)
		{
			return !(typeInfo == null) && this.IsAssignableFrom(typeInfo.AsType());
		}

		// Token: 0x06005061 RID: 20577 RVA: 0x000FB048 File Offset: 0x000F9248
		public override bool IsInstanceOfType(object o)
		{
			throw this.not_supported();
		}

		// Token: 0x06005062 RID: 20578 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		protected override bool IsArrayImpl()
		{
			return false;
		}

		// Token: 0x06005063 RID: 20579 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		protected override bool IsByRefImpl()
		{
			return false;
		}

		// Token: 0x06005064 RID: 20580 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		protected override bool IsCOMObjectImpl()
		{
			return false;
		}

		// Token: 0x06005065 RID: 20581 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		protected override bool IsPointerImpl()
		{
			return false;
		}

		// Token: 0x06005066 RID: 20582 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		protected override bool IsPrimitiveImpl()
		{
			return false;
		}

		// Token: 0x06005067 RID: 20583 RVA: 0x000FB050 File Offset: 0x000F9250
		protected override bool IsValueTypeImpl()
		{
			return this.base_type != null && this.base_type.IsValueType;
		}

		/// <summary>Не поддерживается для неполных параметров универсального типа.</summary>
		/// <param name="name">Не поддерживается.</param>
		/// <param name="invokeAttr">Не поддерживается.</param>
		/// <param name="binder">Не поддерживается.</param>
		/// <param name="target">Не поддерживается.</param>
		/// <param name="args">Не поддерживается.</param>
		/// <param name="modifiers">Не поддерживается.</param>
		/// <param name="culture">Не поддерживается.</param>
		/// <param name="namedParameters">Не поддерживается.</param>
		/// <returns>Не поддерживается для неполных параметров универсального типа.</returns>
		/// <exception cref="T:System.NotSupportedException">Во всех случаях.</exception>
		// Token: 0x06005068 RID: 20584 RVA: 0x000FB048 File Offset: 0x000F9248
		public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
		{
			throw this.not_supported();
		}

		/// <summary>Во всех случаях вызывает исключение <see cref="T:System.NotSupportedException" />.</summary>
		/// <returns>Тип, на который ссылается текущий тип массива, тип указателя или тип <see langword="ByRef" />; или значение <see langword="null" />, если текущий тип не является типом массива, типом указателя и не передается по ссылке.</returns>
		/// <exception cref="T:System.NotSupportedException">Во всех случаях.</exception>
		// Token: 0x06005069 RID: 20585 RVA: 0x000FB048 File Offset: 0x000F9248
		public override Type GetElementType()
		{
			throw this.not_supported();
		}

		/// <summary>Возвращает текущий параметр универсального типа.</summary>
		/// <returns>Текущий объект <see cref="T:System.Reflection.Emit.GenericTypeParameterBuilder" />.</returns>
		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x0600506A RID: 20586 RVA: 0x0000270D File Offset: 0x0000090D
		public override Type UnderlyingSystemType
		{
			get
			{
				return this;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Reflection.Assembly" />, представляющий динамическую сборку, содержащую определение универсального типа, которой принадлежит текущий параметр типа.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.Assembly" />, представляющий динамическую сборку, содержащую определение универсального типа, которой принадлежит текущий параметр типа.</returns>
		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x0600506B RID: 20587 RVA: 0x000FB06D File Offset: 0x000F926D
		public override Assembly Assembly
		{
			get
			{
				return this.tbuilder.Assembly;
			}
		}

		/// <summary>Получает значение <see langword="null" /> во всех случаях.</summary>
		/// <returns>Пустая ссылка (<see langword="Nothing" /> в Visual Basic) во всех случаях.</returns>
		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x0600506C RID: 20588 RVA: 0x0000AF5E File Offset: 0x0000915E
		public override string AssemblyQualifiedName
		{
			get
			{
				return null;
			}
		}

		/// <summary>Возвращает ограничение базового типа для текущего параметра универсального типа.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий ограничение базового типа для параметра универсального типа, или <see langword="null" />, если параметр типа не имеет ограничения базового типа.</returns>
		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x0600506D RID: 20589 RVA: 0x000FB07A File Offset: 0x000F927A
		public override Type BaseType
		{
			get
			{
				return this.base_type;
			}
		}

		/// <summary>Получает значение <see langword="null" /> во всех случаях.</summary>
		/// <returns>Пустая ссылка (<see langword="Nothing" /> в Visual Basic) во всех случаях.</returns>
		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x0600506E RID: 20590 RVA: 0x0000AF5E File Offset: 0x0000915E
		public override string FullName
		{
			get
			{
				return null;
			}
		}

		/// <summary>Не поддерживается для неполных параметров универсального типа.</summary>
		/// <returns>Не поддерживается для неполных параметров универсального типа.</returns>
		/// <exception cref="T:System.NotSupportedException">Во всех случаях.</exception>
		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x0600506F RID: 20591 RVA: 0x000FB048 File Offset: 0x000F9248
		public override Guid GUID
		{
			get
			{
				throw this.not_supported();
			}
		}

		/// <summary>Не поддерживается для неполных параметров универсального типа.</summary>
		/// <param name="attributeType">Не поддерживается.</param>
		/// <param name="inherit">Не поддерживается.</param>
		/// <returns>Не поддерживается для неполных параметров универсального типа.</returns>
		/// <exception cref="T:System.NotSupportedException">Во всех случаях.</exception>
		// Token: 0x06005070 RID: 20592 RVA: 0x000FB048 File Offset: 0x000F9248
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			throw this.not_supported();
		}

		/// <summary>Не поддерживается для неполных параметров универсального типа.</summary>
		/// <param name="inherit">Указывает, следует ли выполнять поиск атрибутов в цепочке наследования этого члена.</param>
		/// <returns>Не поддерживается для неполных параметров универсального типа.</returns>
		/// <exception cref="T:System.NotSupportedException">Во всех случаях.</exception>
		// Token: 0x06005071 RID: 20593 RVA: 0x000FB048 File Offset: 0x000F9248
		public override object[] GetCustomAttributes(bool inherit)
		{
			throw this.not_supported();
		}

		/// <summary>Не поддерживается для неполных параметров универсального типа.</summary>
		/// <param name="attributeType">Тип атрибута для поиска. Возвращаются только те атрибуты, которые можно назначить этому типу.</param>
		/// <param name="inherit">Указывает, следует ли выполнять поиск атрибутов в цепочке наследования этого члена.</param>
		/// <returns>Не поддерживается для неполных параметров универсального типа.</returns>
		/// <exception cref="T:System.NotSupportedException">Во всех случаях.</exception>
		// Token: 0x06005072 RID: 20594 RVA: 0x000FB048 File Offset: 0x000F9248
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			throw this.not_supported();
		}

		/// <summary>Не поддерживается для неполных параметров универсального типа.</summary>
		/// <param name="interfaceType">Объект <see cref="T:System.Type" />, представляющий тип интерфейса, для которого будет извлекаться сопоставление.</param>
		/// <returns>Не поддерживается для неполных параметров универсального типа.</returns>
		/// <exception cref="T:System.NotSupportedException">Во всех случаях.</exception>
		// Token: 0x06005073 RID: 20595 RVA: 0x000FB048 File Offset: 0x000F9248
		[ComVisible(true)]
		public override InterfaceMapping GetInterfaceMap(Type interfaceType)
		{
			throw this.not_supported();
		}

		/// <summary>Возвращает имя универсального параметра типа.</summary>
		/// <returns>Имя универсального параметра типа.</returns>
		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x06005074 RID: 20596 RVA: 0x000FB082 File Offset: 0x000F9282
		public override string Name
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Получает значение <see langword="null" /> во всех случаях.</summary>
		/// <returns>Пустая ссылка (<see langword="Nothing" /> в Visual Basic) во всех случаях.</returns>
		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x06005075 RID: 20597 RVA: 0x0000AF5E File Offset: 0x0000915E
		public override string Namespace
		{
			get
			{
				return null;
			}
		}

		/// <summary>Возвращает динамический модуль, содержащий параметр универсального типа.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.Module" />, который представляет динамический модуль, содержащий параметр универсального типа.</returns>
		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x06005076 RID: 20598 RVA: 0x000FB08A File Offset: 0x000F928A
		public override Module Module
		{
			get
			{
				return this.tbuilder.Module;
			}
		}

		/// <summary>Возвращает определение универсального типа или определение универсального метода, которому принадлежит параметр универсального типа.</summary>
		/// <returns>Если параметр типа относится к универсальному типу, объект <see cref="T:System.Type" />, представляющий этот универсальный тип. Если параметр типа относится к универсальному методу, объект <see cref="T:System.Type" />, представляющий тип, который объявил этот универсальный метод.</returns>
		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x06005077 RID: 20599 RVA: 0x000FB097 File Offset: 0x000F9297
		public override Type DeclaringType
		{
			get
			{
				if (!(this.mbuilder != null))
				{
					return this.tbuilder;
				}
				return this.mbuilder.DeclaringType;
			}
		}

		/// <summary>Получает объект <see cref="T:System.Type" />, который использовался для получения <see cref="T:System.Reflection.Emit.GenericTypeParameterBuilder" />.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, который использовался для получения <see cref="T:System.Reflection.Emit.GenericTypeParameterBuilder" />.</returns>
		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x06005078 RID: 20600 RVA: 0x00058E51 File Offset: 0x00057051
		public override Type ReflectedType
		{
			get
			{
				return this.DeclaringType;
			}
		}

		/// <summary>Не поддерживается для неполных параметров универсального типа.</summary>
		/// <returns>Не поддерживается для неполных параметров универсального типа.</returns>
		/// <exception cref="T:System.NotSupportedException">Во всех случаях.</exception>
		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x06005079 RID: 20601 RVA: 0x000FB048 File Offset: 0x000F9248
		public override RuntimeTypeHandle TypeHandle
		{
			get
			{
				throw this.not_supported();
			}
		}

		/// <summary>Не допустимо для параметров универсального типа.</summary>
		/// <returns>Не допустимо для параметров универсального типа.</returns>
		/// <exception cref="T:System.InvalidOperationException">Во всех случаях.</exception>
		// Token: 0x0600507A RID: 20602 RVA: 0x00084B8D File Offset: 0x00082D8D
		public override Type[] GetGenericArguments()
		{
			throw new InvalidOperationException();
		}

		/// <summary>Не допустимо для параметров универсального типа.</summary>
		/// <returns>Не допустимо для параметров универсального типа.</returns>
		/// <exception cref="T:System.InvalidOperationException">Во всех случаях.</exception>
		// Token: 0x0600507B RID: 20603 RVA: 0x00084B8D File Offset: 0x00082D8D
		public override Type GetGenericTypeDefinition()
		{
			throw new InvalidOperationException();
		}

		/// <summary>Получает значение <see langword="true" /> во всех случаях.</summary>
		/// <returns>Значение <see langword="true" /> во всех случаях.</returns>
		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x0600507C RID: 20604 RVA: 0x000040F7 File Offset: 0x000022F7
		public override bool ContainsGenericParameters
		{
			get
			{
				return true;
			}
		}

		/// <summary>Получает значение <see langword="true" /> во всех случаях.</summary>
		/// <returns>Значение <see langword="true" /> во всех случаях.</returns>
		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x0600507D RID: 20605 RVA: 0x000040F7 File Offset: 0x000022F7
		public override bool IsGenericParameter
		{
			get
			{
				return true;
			}
		}

		/// <summary>Возвращает значение <see langword="false" /> во всех случаях.</summary>
		/// <returns>Значение <see langword="false" /> во всех случаях.</returns>
		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x0600507E RID: 20606 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public override bool IsGenericType
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает значение <see langword="false" /> во всех случаях.</summary>
		/// <returns>Значение <see langword="false" /> во всех случаях.</returns>
		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x0600507F RID: 20607 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public override bool IsGenericTypeDefinition
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает сочетание флагов <see cref="T:System.Reflection.GenericParameterAttributes" />, описывающих ковариацию и особые ограничения текущего параметра универсального типа.</summary>
		/// <returns>Побитовое сочетание значений, которое описывает ковариацию и особые ограничения текущего параметра универсального типа.</returns>
		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x06005080 RID: 20608 RVA: 0x000472C8 File Offset: 0x000454C8
		public override GenericParameterAttributes GenericParameterAttributes
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		/// <summary>Возвращает позицию параметра типа в списке параметров типа универсального типа или метода, который объявил этот параметр.</summary>
		/// <returns>Позиция параметра типа в списке параметров типа универсального типа или метода, который объявил этот параметр.</returns>
		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x06005081 RID: 20609 RVA: 0x000FB0B9 File Offset: 0x000F92B9
		public override int GenericParameterPosition
		{
			get
			{
				return this.index;
			}
		}

		// Token: 0x06005082 RID: 20610 RVA: 0x00084B8D File Offset: 0x00082D8D
		public override Type[] GetGenericParameterConstraints()
		{
			throw new InvalidOperationException();
		}

		/// <summary>Возвращает метод <see cref="T:System.Reflection.MethodInfo" />, который представляет объявляемый метод, если текущий <see cref="T:System.Reflection.Emit.GenericTypeParameterBuilder" /> представляет параметр типа универсального метода.</summary>
		/// <returns>Метод <see cref="T:System.Reflection.MethodInfo" />, который представляет объявляющий метод, если текущий <see cref="T:System.Reflection.Emit.GenericTypeParameterBuilder" /> представляет параметр типа универсального метода; в противном случае —значение <see langword="null" />.</returns>
		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x06005083 RID: 20611 RVA: 0x000FB0C1 File Offset: 0x000F92C1
		public override MethodBase DeclaringMethod
		{
			get
			{
				return this.mbuilder;
			}
		}

		/// <summary>Задает настраиваемый атрибут с помощью построителя настраиваемых атрибутов.</summary>
		/// <param name="customBuilder">Экземпляр вспомогательного класса, определяющий настраиваемый атрибут.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="customBuilder" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06005084 RID: 20612 RVA: 0x000FB0CC File Offset: 0x000F92CC
		public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
		{
			if (customBuilder == null)
			{
				throw new ArgumentNullException("customBuilder");
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
		/// <param name="binaryAttribute">Большой двоичный объект байтов, представляющий атрибут.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="con" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  <paramref name="binaryAttribute" /> является пустой ссылкой.</exception>
		// Token: 0x06005085 RID: 20613 RVA: 0x000FB134 File Offset: 0x000F9334
		[MonoTODO("unverified implementation")]
		public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
		{
			this.SetCustomAttribute(new CustomAttributeBuilder(con, binaryAttribute));
		}

		// Token: 0x06005086 RID: 20614 RVA: 0x0004DD2C File Offset: 0x0004BF2C
		private Exception not_supported()
		{
			return new NotSupportedException();
		}

		/// <summary>Возвращает строковое представление текущего параметра универсального типа.</summary>
		/// <returns>Строка, содержащая имя параметра универсального типа.</returns>
		// Token: 0x06005087 RID: 20615 RVA: 0x000FB082 File Offset: 0x000F9282
		public override string ToString()
		{
			return this.name;
		}

		/// <summary>Проверяет, является ли указанный объект экземпляром <see langword="EventToken" /> и равен ли он текущему экземпляру.</summary>
		/// <param name="o">Объект для сравнения с текущим экземпляром.</param>
		/// <returns>Возвращается <see langword="true" />, если <paramref name="o" /> является экземпляром <see langword="EventToken" /> и совпадает с текущим экземпляром; в противном случае возвращается <see langword="false" />.</returns>
		// Token: 0x06005088 RID: 20616 RVA: 0x000FB143 File Offset: 0x000F9343
		[MonoTODO]
		public override bool Equals(object o)
		{
			return base.Equals(o);
		}

		/// <summary>Возвращает хэш-код в виде 32-разрядного целого числа для текущего экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа.</returns>
		// Token: 0x06005089 RID: 20617 RVA: 0x000FB14C File Offset: 0x000F934C
		[MonoTODO]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Возвращает тип одномерного массива, тип элементов которого является параметром универсального типа.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий тип одномерного массива, тип элементов которого является параметром универсального типа.</returns>
		// Token: 0x0600508A RID: 20618 RVA: 0x000F653D File Offset: 0x000F473D
		public override Type MakeArrayType()
		{
			return new ArrayType(this, 0);
		}

		/// <summary>Возвращает тип массива, тип элементов которого является параметром универсального типа с указанным количеством измерений.</summary>
		/// <param name="rank">Размерность массива.</param>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий тип массива, тип элементов которого является параметром универсального типа с указанным количеством измерений.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">
		///   <paramref name="rank" /> не является допустимым количеством измерений. Например, его значение меньше 1.</exception>
		// Token: 0x0600508B RID: 20619 RVA: 0x000F6546 File Offset: 0x000F4746
		public override Type MakeArrayType(int rank)
		{
			if (rank < 1)
			{
				throw new IndexOutOfRangeException();
			}
			return new ArrayType(this, rank);
		}

		/// <summary>Возвращает объект <see cref="T:System.Type" />, который представляет текущий параметр универсального типа, когда выполняется передача в качестве параметра ссылки.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, который представляет текущий параметр универсального типа, когда выполняется передача в качестве параметра ссылки.</returns>
		// Token: 0x0600508C RID: 20620 RVA: 0x000F6559 File Offset: 0x000F4759
		public override Type MakeByRefType()
		{
			return new ByRefType(this);
		}

		/// <summary>Недопустимо для неполных параметров универсального типа.</summary>
		/// <param name="typeArguments">Массив аргументов типа.</param>
		/// <returns>Этот метод недопустим для неполных параметров универсального типа.</returns>
		/// <exception cref="T:System.InvalidOperationException">Во всех случаях.</exception>
		// Token: 0x0600508D RID: 20621 RVA: 0x000FB154 File Offset: 0x000F9354
		public override Type MakeGenericType(params Type[] typeArguments)
		{
			throw new InvalidOperationException(Environment.GetResourceString("{0} is not a GenericTypeDefinition. MakeGenericType may only be called on a type for which Type.IsGenericTypeDefinition is true."));
		}

		/// <summary>Возвращает объект <see cref="T:System.Type" />, который представляет указатель на текущий параметр универсального типа.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, который представляет указатель на текущий параметр универсального типа.</returns>
		// Token: 0x0600508E RID: 20622 RVA: 0x000F6561 File Offset: 0x000F4761
		public override Type MakePointerType()
		{
			return new PointerType(this);
		}

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x0600508F RID: 20623 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		internal override bool IsUserType
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06005090 RID: 20624 RVA: 0x000173AD File Offset: 0x000155AD
		internal GenericTypeParameterBuilder()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04003177 RID: 12663
		private TypeBuilder tbuilder;

		// Token: 0x04003178 RID: 12664
		private MethodBuilder mbuilder;

		// Token: 0x04003179 RID: 12665
		private string name;

		// Token: 0x0400317A RID: 12666
		private int index;

		// Token: 0x0400317B RID: 12667
		private Type base_type;

		// Token: 0x0400317C RID: 12668
		private Type[] iface_constraints;

		// Token: 0x0400317D RID: 12669
		private CustomAttributeBuilder[] cattrs;

		// Token: 0x0400317E RID: 12670
		private GenericParameterAttributes attrs;
	}
}
