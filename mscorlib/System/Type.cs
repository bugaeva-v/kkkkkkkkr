using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;

namespace System
{
	/// <summary>Представляет объявления типов для классов, интерфейсов, массивов, значений, перечислений параметров, определений универсальных типов и открытых или закрытых сконструированных универсальных типов.</summary>
	// Token: 0x020001A1 RID: 417
	[ComVisible(true)]
	[ComDefaultInterface(typeof(_Type))]
	[ClassInterface(ClassInterfaceType.None)]
	[Serializable]
	public abstract class Type : MemberInfo, IReflect, _Type
	{
		/// <summary>Возвращает значение, показывающее, имеется ли в текущем типе перечисления указанное значение.</summary>
		/// <param name="value">Проверяемое значение.</param>
		/// <returns>Значение <see langword="true" />, если указанное значение является членом текущего типа перечисления; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Текущий тип не является перечислением.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="value" /> имеет тип, который не может быть базовым типом перечисления.</exception>
		// Token: 0x06001109 RID: 4361 RVA: 0x000465BC File Offset: 0x000447BC
		public virtual bool IsEnumDefined(object value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (!this.IsEnum)
			{
				throw new ArgumentException("Type provided must be an Enum.", "enumType");
			}
			Type type = value.GetType();
			if (type.IsEnum)
			{
				if (!type.IsEquivalentTo(this))
				{
					throw new ArgumentException(SR.Format("Object must be the same type as the enum. The type passed in was '{0}'; the enum type was '{1}'.", type.ToString(), this.ToString()));
				}
				type = type.GetEnumUnderlyingType();
			}
			if (type == typeof(string))
			{
				object[] enumNames = this.GetEnumNames();
				return Array.IndexOf<object>(enumNames, value) >= 0;
			}
			if (!Type.IsIntegerType(type))
			{
				throw new InvalidOperationException("Unknown enum type.");
			}
			Type enumUnderlyingType = this.GetEnumUnderlyingType();
			if (enumUnderlyingType.GetTypeCodeImpl() != type.GetTypeCodeImpl())
			{
				throw new ArgumentException(SR.Format("Enum underlying type and the object must be same type or object must be a String. Type passed in was '{0}'; the enum underlying type was '{1}'.", type.ToString(), enumUnderlyingType.ToString()));
			}
			return Type.BinarySearch(this.GetEnumRawConstantValues(), value) >= 0;
		}

		/// <summary>Возвращает имя константы с заданным значением для текущего типа перечисления.</summary>
		/// <param name="value">Значение, имя которой требуется извлечь.</param>
		/// <returns>Имя члена текущего типа перечисления, имеющего указанное значение, или <see langword="null" />, если такая константа не найдена.</returns>
		/// <exception cref="T:System.ArgumentException">Текущий тип не является перечислением.  
		/// -или- 
		///  <paramref name="value" /> не является ни текущим типом, ни имеющим базовый тип, совпадающий с текущим типом.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> — <see langword="null" />.</exception>
		// Token: 0x0600110A RID: 4362 RVA: 0x000466A8 File Offset: 0x000448A8
		public virtual string GetEnumName(object value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (!this.IsEnum)
			{
				throw new ArgumentException("Type provided must be an Enum.", "enumType");
			}
			Type type = value.GetType();
			if (!type.IsEnum && !Type.IsIntegerType(type))
			{
				throw new ArgumentException("The value passed in must be an enum base or an underlying type for an enum, such as an Int32.", "value");
			}
			int num = Type.BinarySearch(this.GetEnumRawConstantValues(), value);
			if (num >= 0)
			{
				return this.GetEnumNames()[num];
			}
			return null;
		}

		/// <summary>Возвращает имена членов текущего типа перечисления.</summary>
		/// <returns>Массив, который содержит имена членов перечисления.</returns>
		/// <exception cref="T:System.ArgumentException">Текущий тип не является перечислением.</exception>
		// Token: 0x0600110B RID: 4363 RVA: 0x00046720 File Offset: 0x00044920
		public virtual string[] GetEnumNames()
		{
			if (!this.IsEnum)
			{
				throw new ArgumentException("Type provided must be an Enum.", "enumType");
			}
			string[] result;
			Array array;
			this.GetEnumData(out result, out array);
			return result;
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x00046750 File Offset: 0x00044950
		private Array GetEnumRawConstantValues()
		{
			string[] array;
			Array result;
			this.GetEnumData(out array, out result);
			return result;
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x00046768 File Offset: 0x00044968
		private void GetEnumData(out string[] enumNames, out Array enumValues)
		{
			FieldInfo[] fields = this.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			object[] array = new object[fields.Length];
			string[] array2 = new string[fields.Length];
			for (int i = 0; i < fields.Length; i++)
			{
				array2[i] = fields[i].Name;
				array[i] = fields[i].GetRawConstantValue();
			}
			IComparer @default = Comparer<object>.Default;
			for (int j = 1; j < array.Length; j++)
			{
				int num = j;
				string text = array2[j];
				object obj = array[j];
				bool flag = false;
				while (@default.Compare(array[num - 1], obj) > 0)
				{
					array2[num] = array2[num - 1];
					array[num] = array[num - 1];
					num--;
					flag = true;
					if (num == 0)
					{
						break;
					}
				}
				if (flag)
				{
					array2[num] = text;
					array[num] = obj;
				}
			}
			enumNames = array2;
			enumValues = array;
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x00046834 File Offset: 0x00044A34
		private static int BinarySearch(Array array, object value)
		{
			ulong[] array2 = new ulong[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array2[i] = Enum.ToUInt64(array.GetValue(i));
			}
			ulong value2 = Enum.ToUInt64(value);
			return Array.BinarySearch<ulong>(array2, value2);
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x0004687C File Offset: 0x00044A7C
		internal static bool IsIntegerType(Type t)
		{
			return t == typeof(int) || t == typeof(short) || t == typeof(ushort) || t == typeof(byte) || t == typeof(sbyte) || t == typeof(uint) || t == typeof(long) || t == typeof(ulong) || t == typeof(char) || t == typeof(bool);
		}

		/// <summary>Возвращает значение, позволяющее определить, сериализуем ли объект <see cref="T:System.Type" />.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> является сериализуемым; в противным случае — значение <see langword="false" />.</returns>
		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06001110 RID: 4368 RVA: 0x00046944 File Offset: 0x00044B44
		public virtual bool IsSerializable
		{
			get
			{
				if ((this.GetAttributeFlagsImpl() & TypeAttributes.Serializable) != TypeAttributes.NotPublic)
				{
					return true;
				}
				Type type = this.UnderlyingSystemType;
				if (type.IsRuntimeImplemented())
				{
					while (!(type == typeof(Delegate)) && !(type == typeof(Enum)))
					{
						type = type.BaseType;
						if (!(type != null))
						{
							return false;
						}
					}
					return true;
				}
				return false;
			}
		}

		/// <summary>Возвращает значение, позволяющее определить, имеются ли у текущего объекта <see cref="T:System.Type" /> параметры типа, которые не были замещены указанными типами.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> сам является параметром универсального типа или если для его параметров типа не предоставлены определенные типы; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06001111 RID: 4369 RVA: 0x000469A8 File Offset: 0x00044BA8
		public virtual bool ContainsGenericParameters
		{
			get
			{
				if (this.HasElementType)
				{
					return this.GetRootElementType().ContainsGenericParameters;
				}
				if (this.IsGenericParameter)
				{
					return true;
				}
				if (!this.IsGenericType)
				{
					return false;
				}
				Type[] genericArguments = this.GetGenericArguments();
				for (int i = 0; i < genericArguments.Length; i++)
				{
					if (genericArguments[i].ContainsGenericParameters)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x00046A00 File Offset: 0x00044C00
		internal Type GetRootElementType()
		{
			Type type = this;
			while (type.HasElementType)
			{
				type = type.GetElementType();
			}
			return type;
		}

		/// <summary>Возвращает значение, позволяющее определить, можно ли получить доступ к объекту <see cref="T:System.Type" /> из кода за пределами сборки.</summary>
		/// <returns>Значение <see langword="true" />, если текущий объект <see cref="T:System.Type" /> является открытым типом или открытым вложенным типом, все включающие типы которого также являются открытыми; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06001113 RID: 4371 RVA: 0x00046A24 File Offset: 0x00044C24
		public bool IsVisible
		{
			get
			{
				if (this.IsGenericParameter)
				{
					return true;
				}
				if (this.HasElementType)
				{
					return this.GetElementType().IsVisible;
				}
				Type type = this;
				while (type.IsNested)
				{
					if (!type.IsNestedPublic)
					{
						return false;
					}
					type = type.DeclaringType;
				}
				if (!type.IsPublic)
				{
					return false;
				}
				if (this.IsGenericType && !this.IsGenericTypeDefinition)
				{
					Type[] genericArguments = this.GetGenericArguments();
					for (int i = 0; i < genericArguments.Length; i++)
					{
						if (!genericArguments[i].IsVisible)
						{
							return false;
						}
					}
				}
				return true;
			}
		}

		/// <summary>Возвращает массив объектов <see cref="T:System.Type" />, представляющий отфильтрованный список интерфейсов, реализованных или наследуемых текущим объектом <see cref="T:System.Type" />.</summary>
		/// <param name="filter">Делегат, сравнивающий интерфейсы с параметром <paramref name="filterCriteria" />.</param>
		/// <param name="filterCriteria">Критерий поиска, определяющий, должен ли тот или иной интерфейс включаться в возвращаемый массив.</param>
		/// <returns>Массив объектов <see cref="T:System.Type" />, представляющий отфильтрованный список интерфейсов, которые реализует или наследует текущий объект <see cref="T:System.Type" />, или пустой массив типа <see cref="T:System.Type" />, если после применения фильтра для текущего объекта <see cref="T:System.Type" /> не удалось найти соответствующие интерфейсы.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="filter" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Статический инициализатор вызывается и создает исключение.</exception>
		// Token: 0x06001114 RID: 4372 RVA: 0x00046AA8 File Offset: 0x00044CA8
		public virtual Type[] FindInterfaces(TypeFilter filter, object filterCriteria)
		{
			if (filter == null)
			{
				throw new ArgumentNullException("filter");
			}
			Type[] interfaces = this.GetInterfaces();
			int num = 0;
			for (int i = 0; i < interfaces.Length; i++)
			{
				if (!filter(interfaces[i], filterCriteria))
				{
					interfaces[i] = null;
				}
				else
				{
					num++;
				}
			}
			if (num == interfaces.Length)
			{
				return interfaces;
			}
			Type[] array = new Type[num];
			num = 0;
			for (int j = 0; j < interfaces.Length; j++)
			{
				if (interfaces[j] != null)
				{
					array[num++] = interfaces[j];
				}
			}
			return array;
		}

		/// <summary>Возвращает отфильтрованный массив объектов <see cref="T:System.Reflection.MemberInfo" />, тип которого совпадает с указанным типом члена.</summary>
		/// <param name="memberType">Объект, указывающий тип члена, который нужно найти.</param>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <param name="filter">Делегат, выполняющий сравнение и возвращающий <see langword="true" />, если проверяемый член соответствует условиям, заданным в параметре <paramref name="filterCriteria" />, и <see langword="false" /> в противном случае. Можно использовать делегаты <see langword="FilterAttribute" />, <see langword="FilterName" /> и <see langword="FilterNameIgnoreCase" />, предоставляемые этим классом. Первый делегат в качестве условий поиска использует поля классов <see langword="FieldAttributes" />, <see langword="MethodAttributes" /> и <see langword="MethodImplAttributes" />, а два других делегата — объекты <see langword="String" />.</param>
		/// <param name="filterCriteria">Условие поиска, определяющее, будет ли член включен в возвращаемый массив объектов <see langword="MemberInfo" />.  
		/// Поля классов <see langword="FieldAttributes" />, <see langword="MethodAttributes" /> и <see langword="MethodImplAttributes" /> могут использоваться вместе с делегатом <see langword="FilterAttribute" />, предоставляемым этим классом.</param>
		/// <returns>Отфильтрованный массив объектов <see cref="T:System.Reflection.MemberInfo" />, имеющих тип указанного члена.  
		/// -или- 
		/// Пустой массив объектов типа <see cref="T:System.Reflection.MemberInfo" />, если у текущего типа <see cref="T:System.Type" /> нет членов типа <paramref name="memberType" />, удовлетворяющих условиям фильтра.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="filter" /> — <see langword="null" />.</exception>
		// Token: 0x06001115 RID: 4373 RVA: 0x00046B2C File Offset: 0x00044D2C
		public virtual MemberInfo[] FindMembers(MemberTypes memberType, BindingFlags bindingAttr, MemberFilter filter, object filterCriteria)
		{
			MethodInfo[] array = null;
			ConstructorInfo[] array2 = null;
			FieldInfo[] array3 = null;
			PropertyInfo[] array4 = null;
			EventInfo[] array5 = null;
			Type[] array6 = null;
			int num = 0;
			if ((memberType & MemberTypes.Method) != (MemberTypes)0)
			{
				array = this.GetMethods(bindingAttr);
				if (filter != null)
				{
					for (int i = 0; i < array.Length; i++)
					{
						if (!filter(array[i], filterCriteria))
						{
							array[i] = null;
						}
						else
						{
							num++;
						}
					}
				}
				else
				{
					num += array.Length;
				}
			}
			if ((memberType & MemberTypes.Constructor) != (MemberTypes)0)
			{
				array2 = this.GetConstructors(bindingAttr);
				if (filter != null)
				{
					for (int i = 0; i < array2.Length; i++)
					{
						if (!filter(array2[i], filterCriteria))
						{
							array2[i] = null;
						}
						else
						{
							num++;
						}
					}
				}
				else
				{
					num += array2.Length;
				}
			}
			if ((memberType & MemberTypes.Field) != (MemberTypes)0)
			{
				array3 = this.GetFields(bindingAttr);
				if (filter != null)
				{
					for (int i = 0; i < array3.Length; i++)
					{
						if (!filter(array3[i], filterCriteria))
						{
							array3[i] = null;
						}
						else
						{
							num++;
						}
					}
				}
				else
				{
					num += array3.Length;
				}
			}
			if ((memberType & MemberTypes.Property) != (MemberTypes)0)
			{
				array4 = this.GetProperties(bindingAttr);
				if (filter != null)
				{
					for (int i = 0; i < array4.Length; i++)
					{
						if (!filter(array4[i], filterCriteria))
						{
							array4[i] = null;
						}
						else
						{
							num++;
						}
					}
				}
				else
				{
					num += array4.Length;
				}
			}
			if ((memberType & MemberTypes.Event) != (MemberTypes)0)
			{
				array5 = this.GetEvents(bindingAttr);
				if (filter != null)
				{
					for (int i = 0; i < array5.Length; i++)
					{
						if (!filter(array5[i], filterCriteria))
						{
							array5[i] = null;
						}
						else
						{
							num++;
						}
					}
				}
				else
				{
					num += array5.Length;
				}
			}
			if ((memberType & MemberTypes.NestedType) != (MemberTypes)0)
			{
				array6 = this.GetNestedTypes(bindingAttr);
				if (filter != null)
				{
					for (int i = 0; i < array6.Length; i++)
					{
						if (!filter(array6[i], filterCriteria))
						{
							array6[i] = null;
						}
						else
						{
							num++;
						}
					}
				}
				else
				{
					num += array6.Length;
				}
			}
			MemberInfo[] array7 = new MemberInfo[num];
			num = 0;
			if (array != null)
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] != null)
					{
						array7[num++] = array[i];
					}
				}
			}
			if (array2 != null)
			{
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i] != null)
					{
						array7[num++] = array2[i];
					}
				}
			}
			if (array3 != null)
			{
				for (int i = 0; i < array3.Length; i++)
				{
					if (array3[i] != null)
					{
						array7[num++] = array3[i];
					}
				}
			}
			if (array4 != null)
			{
				for (int i = 0; i < array4.Length; i++)
				{
					if (array4[i] != null)
					{
						array7[num++] = array4[i];
					}
				}
			}
			if (array5 != null)
			{
				for (int i = 0; i < array5.Length; i++)
				{
					if (array5[i] != null)
					{
						array7[num++] = array5[i];
					}
				}
			}
			if (array6 != null)
			{
				for (int i = 0; i < array6.Length; i++)
				{
					if (array6[i] != null)
					{
						array7[num++] = array6[i];
					}
				}
			}
			return array7;
		}

		/// <summary>Определяет, является ли текущий <see cref="T:System.Type" /> производным от указанного <see cref="T:System.Type" />.</summary>
		/// <param name="c">Тип для сравнения с текущим типом.</param>
		/// <returns>Значение <see langword="true" />, если текущий объект <see langword="Type" /> является производным от <paramref name="c" />; в противном случае — <see langword="false" />. Этот метод также возвращает значение <see langword="false" />, если параметр <paramref name="c" /> и текущий объект <see langword="Type" /> равны.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="c" /> — <see langword="null" />.</exception>
		// Token: 0x06001116 RID: 4374 RVA: 0x00046E38 File Offset: 0x00045038
		[ComVisible(true)]
		public virtual bool IsSubclassOf(Type c)
		{
			Type type = this;
			if (type == c)
			{
				return false;
			}
			while (type != null)
			{
				if (type == c)
				{
					return true;
				}
				type = type.BaseType;
			}
			return false;
		}

		/// <summary>Определяет, можно ли присвоить экземпляр указанного типа экземпляру текущего типа.</summary>
		/// <param name="c">Тип для сравнения с текущим типом.</param>
		/// <returns>
		///   <see langword="true" />, если истинно любое из следующих условий: 
		///
		/// <paramref name="c" /> и текущий экземпляр принадлежат к одному типу.  
		///
		/// <paramref name="c" /> прямо или косвенно унаследован от текущего экземпляра. Параметр <paramref name="c" /> является производным непосредственно от текущего экземпляра, если он наследуется от него. Параметр <paramref name="c" /> является косвенно производным от текущего экземпляра, если он наследуется от последовательности одного или нескольких классов, наследуемых от текущего экземпляра.  
		///
		///
		/// – Текущий экземпляр является интерфейсом, который реализуется параметром <paramref name="c" />.  
		///
		/// <paramref name="c" /> является параметром универсального типа, а текущий экземпляр представляет одно из ограничений, наложенных на параметр <paramref name="c" />.  
		///
		/// В приведенном ниже примере текущий экземпляр является объектом <see cref="T:System.Type" />, который представляет класс <see cref="T:System.IO.Stream" />. GenericWithConstraint — это универсальный тип, параметр универсального типа которого должен иметь тип <see cref="T:System.IO.Stream" />. Передача этого параметра универсального типа в <see cref="M:System.Type.IsAssignableFrom(System.Type)" /> означает, что экземпляр параметра универсального типа можно присвоить объекту <see cref="T:System.IO.Stream" />.  
		/// [!code-csharpSystem.Type.IsAssignableFrom#2] [!code-vbSystem.Type.IsAssignableFrom#2] 
		///
		/// <paramref name="c" /> представляет тип значения, а текущий экземпляр представляет Nullable&lt;c&gt; (Nullable(Of c) в Visual Basic).  
		///
		///  Значение <see langword="false" />, если не выполняется ни одно из этих условий или значение параметра <paramref name="c" /> равно <see langword="null" />.</returns>
		// Token: 0x06001117 RID: 4375 RVA: 0x00046E70 File Offset: 0x00045070
		public virtual bool IsAssignableFrom(Type c)
		{
			if (c == null)
			{
				return false;
			}
			if (this == c)
			{
				return true;
			}
			Type underlyingSystemType = this.UnderlyingSystemType;
			if (underlyingSystemType.IsRuntimeImplemented())
			{
				return underlyingSystemType.IsAssignableFrom(c);
			}
			if (c.IsSubclassOf(this))
			{
				return true;
			}
			if (this.IsInterface)
			{
				return c.ImplementInterface(this);
			}
			if (this.IsGenericParameter)
			{
				Type[] genericParameterConstraints = this.GetGenericParameterConstraints();
				for (int i = 0; i < genericParameterConstraints.Length; i++)
				{
					if (!genericParameterConstraints[i].IsAssignableFrom(c))
					{
						return false;
					}
				}
				return true;
			}
			return false;
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x00046EF4 File Offset: 0x000450F4
		internal bool ImplementInterface(Type ifaceType)
		{
			Type type = this;
			while (type != null)
			{
				Type[] interfaces = type.GetInterfaces();
				if (interfaces != null)
				{
					for (int i = 0; i < interfaces.Length; i++)
					{
						if (interfaces[i] == ifaceType || (interfaces[i] != null && interfaces[i].ImplementInterface(ifaceType)))
						{
							return true;
						}
					}
				}
				type = type.BaseType;
			}
			return false;
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x00046F54 File Offset: 0x00045154
		private static bool FilterAttributeImpl(MemberInfo m, object filterCriteria)
		{
			if (filterCriteria == null)
			{
				throw new InvalidFilterCriteriaException("An Int32 must be provided for the filter criteria.");
			}
			MemberTypes memberType = m.MemberType;
			if (memberType != MemberTypes.Constructor)
			{
				if (memberType == MemberTypes.Field)
				{
					FieldAttributes fieldAttributes = FieldAttributes.PrivateScope;
					try
					{
						fieldAttributes = (FieldAttributes)((int)filterCriteria);
					}
					catch
					{
						throw new InvalidFilterCriteriaException("An Int32 must be provided for the filter criteria.");
					}
					FieldAttributes attributes = ((FieldInfo)m).Attributes;
					return ((fieldAttributes & FieldAttributes.FieldAccessMask) == FieldAttributes.PrivateScope || (attributes & FieldAttributes.FieldAccessMask) == (fieldAttributes & FieldAttributes.FieldAccessMask)) && ((fieldAttributes & FieldAttributes.Static) == FieldAttributes.PrivateScope || (attributes & FieldAttributes.Static) != FieldAttributes.PrivateScope) && ((fieldAttributes & FieldAttributes.InitOnly) == FieldAttributes.PrivateScope || (attributes & FieldAttributes.InitOnly) != FieldAttributes.PrivateScope) && ((fieldAttributes & FieldAttributes.Literal) == FieldAttributes.PrivateScope || (attributes & FieldAttributes.Literal) != FieldAttributes.PrivateScope) && ((fieldAttributes & FieldAttributes.NotSerialized) == FieldAttributes.PrivateScope || (attributes & FieldAttributes.NotSerialized) != FieldAttributes.PrivateScope) && ((fieldAttributes & FieldAttributes.PinvokeImpl) == FieldAttributes.PrivateScope || (attributes & FieldAttributes.PinvokeImpl) != FieldAttributes.PrivateScope);
				}
				if (memberType != MemberTypes.Method)
				{
					return false;
				}
			}
			MethodAttributes methodAttributes = MethodAttributes.PrivateScope;
			try
			{
				methodAttributes = (MethodAttributes)((int)filterCriteria);
			}
			catch
			{
				throw new InvalidFilterCriteriaException("An Int32 must be provided for the filter criteria.");
			}
			MethodAttributes attributes2;
			if (m.MemberType == MemberTypes.Method)
			{
				attributes2 = ((MethodInfo)m).Attributes;
			}
			else
			{
				attributes2 = ((ConstructorInfo)m).Attributes;
			}
			return ((methodAttributes & MethodAttributes.MemberAccessMask) == MethodAttributes.PrivateScope || (attributes2 & MethodAttributes.MemberAccessMask) == (methodAttributes & MethodAttributes.MemberAccessMask)) && ((methodAttributes & MethodAttributes.Static) == MethodAttributes.PrivateScope || (attributes2 & MethodAttributes.Static) != MethodAttributes.PrivateScope) && ((methodAttributes & MethodAttributes.Final) == MethodAttributes.PrivateScope || (attributes2 & MethodAttributes.Final) != MethodAttributes.PrivateScope) && ((methodAttributes & MethodAttributes.Virtual) == MethodAttributes.PrivateScope || (attributes2 & MethodAttributes.Virtual) != MethodAttributes.PrivateScope) && ((methodAttributes & MethodAttributes.Abstract) == MethodAttributes.PrivateScope || (attributes2 & MethodAttributes.Abstract) != MethodAttributes.PrivateScope) && ((methodAttributes & MethodAttributes.SpecialName) == MethodAttributes.PrivateScope || (attributes2 & MethodAttributes.SpecialName) != MethodAttributes.PrivateScope);
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x000470D0 File Offset: 0x000452D0
		private static bool FilterNameImpl(MemberInfo m, object filterCriteria)
		{
			if (filterCriteria == null || !(filterCriteria is string))
			{
				throw new InvalidFilterCriteriaException("A String must be provided for the filter criteria.");
			}
			string text = (string)filterCriteria;
			text = text.Trim();
			string text2 = m.Name;
			if (m.MemberType == MemberTypes.NestedType)
			{
				text2 = text2.Substring(text2.LastIndexOf('+') + 1);
			}
			if (text.Length > 0 && text[text.Length - 1] == '*')
			{
				text = text.Substring(0, text.Length - 1);
				return text2.StartsWith(text, StringComparison.Ordinal);
			}
			return text2.Equals(text);
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x00047164 File Offset: 0x00045364
		private static bool FilterNameIgnoreCaseImpl(MemberInfo m, object filterCriteria)
		{
			if (filterCriteria == null || !(filterCriteria is string))
			{
				throw new InvalidFilterCriteriaException("A String must be provided for the filter criteria.");
			}
			string text = (string)filterCriteria;
			text = text.Trim();
			string text2 = m.Name;
			if (m.MemberType == MemberTypes.NestedType)
			{
				text2 = text2.Substring(text2.LastIndexOf('+') + 1);
			}
			if (text.Length > 0 && text[text.Length - 1] == '*')
			{
				text = text.Substring(0, text.Length - 1);
				return string.Compare(text2, 0, text, 0, text.Length, StringComparison.OrdinalIgnoreCase) == 0;
			}
			return string.Compare(text, text2, StringComparison.OrdinalIgnoreCase) == 0;
		}

		/// <summary>Возвращает значение <see cref="T:System.Reflection.MemberTypes" />, позволяющее определить, каким типом является этот член: обычным или вложенным.</summary>
		/// <returns>Значение <see cref="T:System.Reflection.MemberTypes" />, позволяющее определить, каким типом является этот член: обычным или вложенным.</returns>
		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600111D RID: 4381 RVA: 0x0004720C File Offset: 0x0004540C
		public override MemberTypes MemberType
		{
			get
			{
				return MemberTypes.TypeInfo;
			}
		}

		/// <summary>Возвращает текущий <see cref="T:System.Type" />.</summary>
		/// <returns>Текущий контекст <see cref="T:System.Type" />.</returns>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Инициализатор класса вызывается и создает исключение.</exception>
		// Token: 0x0600111E RID: 4382 RVA: 0x00047210 File Offset: 0x00045410
		public new Type GetType()
		{
			return base.GetType();
		}

		/// <summary>Возвращает пространство имен объекта <see cref="T:System.Type" />.</summary>
		/// <returns>Пространство имен <see cref="T:System.Type" /> или значение <see langword="null" />, если текущий экземпляр не имеет пространства имен или представляет универсальный параметр.</returns>
		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600111F RID: 4383
		public abstract string Namespace { get; }

		/// <summary>Возвращает имя типа с указанием сборки, включающее имя сборки, из которой был загружен объект <see cref="T:System.Type" />.</summary>
		/// <returns>Имя объекта <see cref="T:System.Type" /> с указанием сборки, включающее имя сборки, из которой был загружен объект <see cref="T:System.Type" />, или значение <see langword="null" />, если текущий экземпляр представляет параметр универсального типа.</returns>
		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06001120 RID: 4384
		public abstract string AssemblyQualifiedName { get; }

		/// <summary>Возвращает полное имя типа, включая пространство имен, но не сборку.</summary>
		/// <returns>Полное имя типа, включая пространство имен, но не сборку; или значение <see langword="null" />, если текущий экземпляр представляет параметр универсального типа, тип массива, тип указателя, тип <see langword="byref" /> на основе параметра типа либо универсальный тип, который, хотя и не является определением универсального типа, содержит неразрешенные параметры типа.</returns>
		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06001121 RID: 4385
		public abstract string FullName { get; }

		/// <summary>Возвращает объект <see cref="T:System.Reflection.Assembly" />, в котором объявлен тип. Для универсальных типов возвращает объект сборки <see cref="T:System.Reflection.Assembly" />, в которой определен универсальный тип.</summary>
		/// <returns>Экземпляр <see cref="T:System.Reflection.Assembly" />, описывающий сборку, которая содержит текущий тип. Для универсальных типов экземпляр описывает сборку, содержащую определение универсального типа, а не сборку, которая создала и использует определенный сконструированный тип.</returns>
		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06001122 RID: 4386
		public abstract Assembly Assembly { get; }

		/// <summary>Возвращает модуль (DLL), в котором определен текущий объект <see cref="T:System.Type" />.</summary>
		/// <returns>Модуль, в котором определен текущий объект <see cref="T:System.Type" />.</returns>
		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06001123 RID: 4387
		public new abstract Module Module { get; }

		/// <summary>Возвращает значение, позволяющее определить, представляет ли текущий объект <see cref="T:System.Type" /> тип, определение которого вложено в определение другого типа.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> вложен в другой тип; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06001124 RID: 4388 RVA: 0x00047218 File Offset: 0x00045418
		public bool IsNested
		{
			get
			{
				return this.DeclaringType != null;
			}
		}

		/// <summary>Возвращает тип, объявивший текущий вложенный тип или параметр универсального типа.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий включающий тип, если текущий тип является вложенным, или определение универсального типа, если текущий тип является параметром универсального типа, или тип, объявивший этот универсальный метод, если текущий тип является параметром типа универсального метода; в противном случае — значение <see langword="null" />.</returns>
		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06001125 RID: 4389 RVA: 0x0000AF5E File Offset: 0x0000915E
		public override Type DeclaringType
		{
			get
			{
				return null;
			}
		}

		/// <summary>Возвращает метод <see cref="T:System.Reflection.MethodBase" />, который представляет объявляемый метод, если текущий <see cref="T:System.Type" /> представляет параметр типа универсального метода.</summary>
		/// <returns>Если текущий объект <see cref="T:System.Type" /> представляет параметр типа универсального метода, класс <see cref="T:System.Reflection.MethodBase" />, представляющий объявляемый метод; в противном случае — значение <see langword="null" />.</returns>
		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06001126 RID: 4390 RVA: 0x0000AF5E File Offset: 0x0000915E
		public virtual MethodBase DeclaringMethod
		{
			get
			{
				return null;
			}
		}

		/// <summary>Возвращает объект класса, который использовался для получения этого члена.</summary>
		/// <returns>Объект <see langword="Type" />, с помощью которого был получен данный объект <see cref="T:System.Type" />.</returns>
		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06001127 RID: 4391 RVA: 0x0000AF5E File Offset: 0x0000915E
		public override Type ReflectedType
		{
			get
			{
				return null;
			}
		}

		/// <summary>Указывает на тип, предоставляемый средой CLR, представляющей этот тип.</summary>
		/// <returns>Базовый системный тип текущего типа <see cref="T:System.Type" />.</returns>
		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06001128 RID: 4392
		public abstract Type UnderlyingSystemType { get; }

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06001129 RID: 4393 RVA: 0x00047226 File Offset: 0x00045426
		public virtual bool IsTypeDefinition
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		/// <summary>Возвращает значение, показывающее, является ли тип массивом.</summary>
		/// <returns>Значение <see langword="true" />, если текущий тип является массивом; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000172 RID: 370
		// (get) Token: 0x0600112A RID: 4394 RVA: 0x0004722D File Offset: 0x0004542D
		public bool IsArray
		{
			get
			{
				return this.IsArrayImpl();
			}
		}

		/// <summary>При переопределении в производном классе реализует свойство <see cref="P:System.Type.IsArray" /> и определяет, является ли данный объект <see cref="T:System.Type" /> массивом.</summary>
		/// <returns>Значение <see langword="true" />, если <see cref="T:System.Type" /> является массивом; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600112B RID: 4395
		protected abstract bool IsArrayImpl();

		/// <summary>Возвращает значение, указывающее, передан ли объект <see cref="T:System.Type" /> по ссылке.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> передан по ссылке; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600112C RID: 4396 RVA: 0x00047235 File Offset: 0x00045435
		public bool IsByRef
		{
			get
			{
				return this.IsByRefImpl();
			}
		}

		/// <summary>При переопределении в производном классе реализует свойство <see cref="P:System.Type.IsByRef" /> и определяет, передается ли данный объект <see cref="T:System.Type" /> по ссылке.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> передан по ссылке; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600112D RID: 4397
		protected abstract bool IsByRefImpl();

		/// <summary>Возвращает значение, указывающее, является ли объект <see cref="T:System.Type" /> указателем.</summary>
		/// <returns>Значение <see langword="true" />, если <see cref="T:System.Type" /> является указателем; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600112E RID: 4398 RVA: 0x0004723D File Offset: 0x0004543D
		public bool IsPointer
		{
			get
			{
				return this.IsPointerImpl();
			}
		}

		/// <summary>При переопределении в производном классе реализует свойство <see cref="P:System.Type.IsPointer" /> и определяет, является ли объект <see cref="T:System.Type" /> указателем.</summary>
		/// <returns>Значение <see langword="true" />, если <see cref="T:System.Type" /> является указателем; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600112F RID: 4399
		protected abstract bool IsPointerImpl();

		/// <summary>Возвращает значение, указывающее, представляет ли этот данный объект сконструированный универсальный тип. Можно создать экземпляры сконструированного универсального типа.</summary>
		/// <returns>Значение <see langword="true" />, если этот объект представляет сконструированный универсальный тип; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06001130 RID: 4400 RVA: 0x00047226 File Offset: 0x00045426
		public virtual bool IsConstructedGenericType
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		/// <summary>Возвращает значение, позволяющее определить, представляет ли текущий объект <see cref="T:System.Type" /> параметр типа в определении универсального типа или метода.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> представляет параметр определения универсального типа; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06001131 RID: 4401 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public virtual bool IsGenericParameter
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06001132 RID: 4402 RVA: 0x00047245 File Offset: 0x00045445
		public virtual bool IsGenericTypeParameter
		{
			get
			{
				return this.IsGenericParameter && this.DeclaringMethod == null;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06001133 RID: 4403 RVA: 0x0004725D File Offset: 0x0004545D
		public virtual bool IsGenericMethodParameter
		{
			get
			{
				return this.IsGenericParameter && this.DeclaringMethod != null;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли текущий тип универсальным.</summary>
		/// <returns>
		///   <see langword="true" /> Если текущий тип является универсальным типом; в противном случае <see langword="false" />.</returns>
		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06001134 RID: 4404 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public virtual bool IsGenericType
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает значение, позволяющее определить, представляет ли текущий объект <see cref="T:System.Type" /> определение универсального типа, на основе которого можно сконструировать другие универсальные типы.</summary>
		/// <returns>Значение <see langword="true" />, если этот объект <see cref="T:System.Type" /> представляет определение универсального типа; в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06001135 RID: 4405 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public virtual bool IsGenericTypeDefinition
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06001136 RID: 4406 RVA: 0x00047226 File Offset: 0x00045426
		public virtual bool IsSZArray
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06001137 RID: 4407 RVA: 0x00047275 File Offset: 0x00045475
		public virtual bool IsVariableBoundArray
		{
			get
			{
				return this.IsArray && !this.IsSZArray;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06001138 RID: 4408 RVA: 0x0004728A File Offset: 0x0004548A
		public virtual bool IsByRefLike
		{
			get
			{
				throw new NotSupportedException("Derived classes must provide an implementation.");
			}
		}

		/// <summary>Возвращает значение, позволяющее определить, содержит ли текущий объект <see cref="T:System.Type" /> в себе другой тип или ссылку на другой тип (иными словами, является ли текущий объект <see cref="T:System.Type" /> массивом, указателем либо параметром или же он передается по ссылке).</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> является массивом, указателем или параметром, переданным по ссылке; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06001139 RID: 4409 RVA: 0x00047296 File Offset: 0x00045496
		public bool HasElementType
		{
			get
			{
				return this.HasElementTypeImpl();
			}
		}

		/// <summary>При переопределении в производном классе реализует свойство <see cref="P:System.Type.HasElementType" /> и определяет, что содержится в текущем объекте <see cref="T:System.Type" />: непосредственно другой тип или же указывающая на него ссылка (иными словами, является ли текущий объект <see cref="T:System.Type" /> массивом, указателем или параметром или же он передается по ссылке).</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> является массивом, указателем или параметром, переданным по ссылке; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600113A RID: 4410
		protected abstract bool HasElementTypeImpl();

		/// <summary>При переопределении в производном классе возвращает тип <see cref="T:System.Type" /> объекта, на который ссылается данный массив, указатель или ссылка или который инкапсулирован в этих объектах.</summary>
		/// <returns>Тип объекта <see cref="T:System.Type" />, на который ссылается данный массив, указатель или ссылка или который инкапсулирован в этих объектах, или значение <see langword="null" />, если текущий объект <see cref="T:System.Type" /> не является массивом или указателем, не передается по ссылке либо представляет универсальный тип или параметр типа в определении универсального типа или метода.</returns>
		// Token: 0x0600113B RID: 4411
		public abstract Type GetElementType();

		/// <summary>Возвращает размерность массива.</summary>
		/// <returns>Целое число, указывающее на количество измерений текущего типа.</returns>
		/// <exception cref="T:System.NotSupportedException">Функциональность этого метода не поддерживается в базовом классе и должна быть реализована в производном классе.</exception>
		/// <exception cref="T:System.ArgumentException">Текущий тип не является массивом.</exception>
		// Token: 0x0600113C RID: 4412 RVA: 0x0004728A File Offset: 0x0004548A
		public virtual int GetArrayRank()
		{
			throw new NotSupportedException("Derived classes must provide an implementation.");
		}

		/// <summary>Возвращает объект <see cref="T:System.Type" />, представляющий определение универсального типа, на основе которого можно сконструировать текущий универсальный тип.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий универсальный тип, на основе которого можно сконструировать текущий тип.</returns>
		/// <exception cref="T:System.InvalidOperationException">Текущий тип не является универсальным.  То есть <see cref="P:System.Type.IsGenericType" /> возвращает <see langword="false" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Вызванный метод не поддерживается в базовом классе. Реализацию должны обеспечивать производные классы.</exception>
		// Token: 0x0600113D RID: 4413 RVA: 0x0004728A File Offset: 0x0004548A
		public virtual Type GetGenericTypeDefinition()
		{
			throw new NotSupportedException("Derived classes must provide an implementation.");
		}

		/// <summary>Возвращает массив аргументов универсального типа для этого типа.</summary>
		/// <returns>Массив аргументов универсального типа для этого типа.</returns>
		// Token: 0x1700017F RID: 383
		// (get) Token: 0x0600113E RID: 4414 RVA: 0x0004729E File Offset: 0x0004549E
		public virtual Type[] GenericTypeArguments
		{
			get
			{
				if (!this.IsGenericType || this.IsGenericTypeDefinition)
				{
					return Array.Empty<Type>();
				}
				return this.GetGenericArguments();
			}
		}

		/// <summary>Возвращает массив объектов <see cref="T:System.Type" />, которые представляют аргументы закрытого универсального типа или параметры определения универсального типа.</summary>
		/// <returns>Массив объектов <see cref="T:System.Type" />, которые представляют аргументы универсального типа. Возвращает пустой массив, если текущий тип не является универсальным.</returns>
		/// <exception cref="T:System.NotSupportedException">Вызванный метод не поддерживается в базовом классе. Реализацию должны обеспечивать производные классы.</exception>
		// Token: 0x0600113F RID: 4415 RVA: 0x0004728A File Offset: 0x0004548A
		public virtual Type[] GetGenericArguments()
		{
			throw new NotSupportedException("Derived classes must provide an implementation.");
		}

		/// <summary>Возвращает позицию параметра типа в списке параметров универсального типа или метода, который объявил параметр, если объект <see cref="T:System.Type" /> представляет параметр универсального типа или метода.</summary>
		/// <returns>Позиция параметра типа в списке параметров типа универсального типа или метода, которые задали этот параметр. Нумерация позиций начинается с 0.</returns>
		/// <exception cref="T:System.InvalidOperationException">Текущий тип не представляет параметр типа. То есть <see cref="P:System.Type.IsGenericParameter" /> возвращает <see langword="false" />.</exception>
		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06001140 RID: 4416 RVA: 0x000472BC File Offset: 0x000454BC
		public virtual int GenericParameterPosition
		{
			get
			{
				throw new InvalidOperationException("Method may only be called on a Type for which Type.IsGenericParameter is true.");
			}
		}

		/// <summary>Возвращает сочетание флагов <see cref="T:System.Reflection.GenericParameterAttributes" />, описывающих ковариацию и особые ограничения текущего параметра универсального типа.</summary>
		/// <returns>Побитовое сочетание значений <see cref="T:System.Reflection.GenericParameterAttributes" />, которое описывает ковариацию и особые ограничения текущего параметра универсального типа.</returns>
		/// <exception cref="T:System.InvalidOperationException">Текущий объект <see cref="T:System.Type" /> не является параметром универсального типа. То есть свойство <see cref="P:System.Type.IsGenericParameter" /> возвращает значение <see langword="false" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Вызванный метод не поддерживается в базовом классе.</exception>
		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06001141 RID: 4417 RVA: 0x000472C8 File Offset: 0x000454C8
		public virtual GenericParameterAttributes GenericParameterAttributes
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		/// <summary>Возвращает массив объектов <see cref="T:System.Type" />, которые представляют ограничения, накладываемые на параметр текущего универсального типа.</summary>
		/// <returns>Массив объектов <see cref="T:System.Type" />, которые представляют ограничения, накладываемые на параметр текущего универсального типа.</returns>
		/// <exception cref="T:System.InvalidOperationException">Текущий объект <see cref="T:System.Type" /> не является параметром универсального типа. То есть свойство <see cref="P:System.Type.IsGenericParameter" /> возвращает значение <see langword="false" />.</exception>
		// Token: 0x06001142 RID: 4418 RVA: 0x000472CF File Offset: 0x000454CF
		public virtual Type[] GetGenericParameterConstraints()
		{
			if (!this.IsGenericParameter)
			{
				throw new InvalidOperationException("Method may only be called on a Type for which Type.IsGenericParameter is true.");
			}
			throw new InvalidOperationException();
		}

		/// <summary>Возвращает атрибуты, связанные с объектом <see cref="T:System.Type" />.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.TypeAttributes" />, представляющий набор атрибутов типа <see cref="T:System.Type" />, если <see cref="T:System.Type" /> не представляет параметр универсального типа. В противном случае это значение не определено.</returns>
		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06001143 RID: 4419 RVA: 0x000472E9 File Offset: 0x000454E9
		public TypeAttributes Attributes
		{
			get
			{
				return this.GetAttributeFlagsImpl();
			}
		}

		/// <summary>При переопределении в производном классе реализует свойство <see cref="P:System.Type.Attributes" /> и возвращает битовую маску, позволяющую определить атрибуты, связанные с объектом <see cref="T:System.Type" />.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.TypeAttributes" />, представляющий набор атрибутов объекта <see cref="T:System.Type" />.</returns>
		// Token: 0x06001144 RID: 4420
		protected abstract TypeAttributes GetAttributeFlagsImpl();

		/// <summary>Возвращает значение, показывающее, является ли данный объект <see cref="T:System.Type" /> абстрактным объектом, который должен быть переопределен.</summary>
		/// <returns>Значение <see langword="true" />, если класс <see cref="T:System.Type" /> является абстрактным; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06001145 RID: 4421 RVA: 0x000472F1 File Offset: 0x000454F1
		public bool IsAbstract
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.Abstract) > TypeAttributes.NotPublic;
			}
		}

		/// <summary>Возвращает значение, позволяющее определить, есть ли у объекта <see cref="T:System.Type" /> атрибут <see cref="T:System.Runtime.InteropServices.ComImportAttribute" />, свидетельствующий о том, что объект был импортирован из библиотеки COM-типов.</summary>
		/// <returns>Значение <see langword="true" />, если у <see cref="T:System.Type" /> есть атрибут <see cref="T:System.Runtime.InteropServices.ComImportAttribute" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06001146 RID: 4422 RVA: 0x00047302 File Offset: 0x00045502
		public bool IsImport
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.Import) > TypeAttributes.NotPublic;
			}
		}

		/// <summary>Возвращает значение, позволяющее определить, был ли объект <see cref="T:System.Type" /> объявлен как запечатанный.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> объявлен как запечатанный; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06001147 RID: 4423 RVA: 0x00047313 File Offset: 0x00045513
		public bool IsSealed
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.Sealed) > TypeAttributes.NotPublic;
			}
		}

		/// <summary>Возвращает значение, позволяющее определить, требует ли имя данного объекта специальной обработки.</summary>
		/// <returns>Значение <see langword="true" />, если имя типа требует специальной обработки; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06001148 RID: 4424 RVA: 0x00047324 File Offset: 0x00045524
		public bool IsSpecialName
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.SpecialName) > TypeAttributes.NotPublic;
			}
		}

		/// <summary>Получает значение, позволяющее определить, является объект <see cref="T:System.Type" /> классом или делегатом (иными словами, не является типом значения или интерфейсом).</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> является классом; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06001149 RID: 4425 RVA: 0x00047335 File Offset: 0x00045535
		public bool IsClass
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.ClassSemanticsMask) == TypeAttributes.NotPublic && !this.IsValueType;
			}
		}

		/// <summary>Возвращает значение, позволяющее определить, является ли объект <see cref="T:System.Type" /> вложенным и видимым только в своей сборке.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> является вложенным и видимым только в своей сборке; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600114A RID: 4426 RVA: 0x0004734D File Offset: 0x0004554D
		public bool IsNestedAssembly
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.VisibilityMask) == TypeAttributes.NestedAssembly;
			}
		}

		/// <summary>Возвращает значение, позволяющее определить, является ли объект <see cref="T:System.Type" /> вложенным и видимым только для классов, принадлежащих одновременно к семейству и сборке этого объекта.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> является вложенным и видимым только классам, принадлежащим одновременно к семейству и сборке этого объекта; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600114B RID: 4427 RVA: 0x0004735A File Offset: 0x0004555A
		public bool IsNestedFamANDAssem
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.VisibilityMask) == TypeAttributes.NestedFamANDAssem;
			}
		}

		/// <summary>Возвращает значение, позволяющее определить, является ли объект <see cref="T:System.Type" /> вложенным и видимым только в своем семействе.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> является вложенным и видимым только внутри собственного семейства; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600114C RID: 4428 RVA: 0x00047367 File Offset: 0x00045567
		public bool IsNestedFamily
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.VisibilityMask) == TypeAttributes.NestedFamily;
			}
		}

		/// <summary>Возвращает значение, позволяющее определить, является ли данный объект <see cref="T:System.Type" /> вложенным и видимым только для классов, принадлежащих либо к его семейству, либо к его сборке.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> является вложенным и видимым только классам, принадлежащим его семейству или его сборке; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600114D RID: 4429 RVA: 0x00047374 File Offset: 0x00045574
		public bool IsNestedFamORAssem
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.VisibilityMask) == TypeAttributes.VisibilityMask;
			}
		}

		/// <summary>Возвращает значение, позволяющее определить, является ли объект <see cref="T:System.Type" /> вложенным и объявленным как закрытый.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> является вложенным и объявленным как закрытый; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600114E RID: 4430 RVA: 0x00047381 File Offset: 0x00045581
		public bool IsNestedPrivate
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.VisibilityMask) == TypeAttributes.NestedPrivate;
			}
		}

		/// <summary>Возвращает значение, позволяющее определить, является ли класс вложенным и объявленным как открытый.</summary>
		/// <returns>Значение <see langword="true" />, если данный класс является вложенным и объявленным как открытый; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600114F RID: 4431 RVA: 0x0004738E File Offset: 0x0004558E
		public bool IsNestedPublic
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.VisibilityMask) == TypeAttributes.NestedPublic;
			}
		}

		/// <summary>Возвращает значение, позволяющее определить, не был ли объект <see cref="T:System.Type" /> объявлен как открытый.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> не объявлен как открытый и не является вложенным типом; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06001150 RID: 4432 RVA: 0x0004739B File Offset: 0x0004559B
		public bool IsNotPublic
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.VisibilityMask) == TypeAttributes.NotPublic;
			}
		}

		/// <summary>Возвращает значение, позволяющее определить, был ли объект <see cref="T:System.Type" /> объявлен как открытый.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> объявлен как открытый и не является вложенным типом; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06001151 RID: 4433 RVA: 0x000473A8 File Offset: 0x000455A8
		public bool IsPublic
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.VisibilityMask) == TypeAttributes.Public;
			}
		}

		/// <summary>Возвращает значение, указывающее, выкладываются ли поля текущего типа автоматически средой CLR.</summary>
		/// <returns>Значение <see langword="true" />, если свойство <see cref="P:System.Type.Attributes" /> текущего типа включает <see cref="F:System.Reflection.TypeAttributes.AutoLayout" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06001152 RID: 4434 RVA: 0x000473B5 File Offset: 0x000455B5
		public bool IsAutoLayout
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.LayoutMask) == TypeAttributes.NotPublic;
			}
		}

		/// <summary>Возвращает значение, указывающее, выкладываются ли поля текущего типа с явно заданными смещениями.</summary>
		/// <returns>Значение <see langword="true" />, если свойство <see cref="P:System.Type.Attributes" /> текущего типа включает <see cref="F:System.Reflection.TypeAttributes.ExplicitLayout" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06001153 RID: 4435 RVA: 0x000473C3 File Offset: 0x000455C3
		public bool IsExplicitLayout
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.LayoutMask) == TypeAttributes.ExplicitLayout;
			}
		}

		/// <summary>Возвращает значение, указывающее, выкладываются ли поля текущего типа последовательно, в том порядке, в котором они были определены, или выдаются в метаданные.</summary>
		/// <returns>Значение <see langword="true" />, если свойство <see cref="P:System.Type.Attributes" /> текущего типа включает <see cref="F:System.Reflection.TypeAttributes.SequentialLayout" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06001154 RID: 4436 RVA: 0x000473D2 File Offset: 0x000455D2
		public bool IsLayoutSequential
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.LayoutMask) == TypeAttributes.SequentialLayout;
			}
		}

		/// <summary>Возвращает значение, позволяющее определить, выбран ли для объекта <see langword="AnsiClass" /> атрибут формата строки <see cref="T:System.Type" />.</summary>
		/// <returns>Значение <see langword="true" />, если для данного объекта <see langword="AnsiClass" /> выбран атрибут формата строки <see cref="T:System.Type" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06001155 RID: 4437 RVA: 0x000473E0 File Offset: 0x000455E0
		public bool IsAnsiClass
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.StringFormatMask) == TypeAttributes.NotPublic;
			}
		}

		/// <summary>Возвращает значение, позволяющее определить, выбран ли для объекта <see langword="AutoClass" /> атрибут формата строки <see cref="T:System.Type" />.</summary>
		/// <returns>Значение <see langword="true" />, если для данного объекта <see langword="AutoClass" /> выбран атрибут формата строки <see cref="T:System.Type" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06001156 RID: 4438 RVA: 0x000473F1 File Offset: 0x000455F1
		public bool IsAutoClass
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.StringFormatMask) == TypeAttributes.AutoClass;
			}
		}

		/// <summary>Возвращает значение, позволяющее определить, выбран ли для объекта <see langword="UnicodeClass" /> атрибут формата строки <see cref="T:System.Type" />.</summary>
		/// <returns>Значение <see langword="true" />, если для данного объекта <see langword="UnicodeClass" /> выбран атрибут формата строки <see cref="T:System.Type" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06001157 RID: 4439 RVA: 0x00047406 File Offset: 0x00045606
		public bool IsUnicodeClass
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.StringFormatMask) == TypeAttributes.UnicodeClass;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли объект <see cref="T:System.Type" /> COM-объектом.</summary>
		/// <returns>Значение <see langword="true" />, если <see cref="T:System.Type" /> является COM-объектом, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06001158 RID: 4440 RVA: 0x0004741B File Offset: 0x0004561B
		public bool IsCOMObject
		{
			get
			{
				return this.IsCOMObjectImpl();
			}
		}

		/// <summary>При переопределении в производном классе реализует свойство <see cref="P:System.Type.IsCOMObject" /> и определяет, является ли объект <see cref="T:System.Type" /> COM-объектом.</summary>
		/// <returns>Значение <see langword="true" />, если <see cref="T:System.Type" /> является COM-объектом, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001159 RID: 4441
		protected abstract bool IsCOMObjectImpl();

		/// <summary>Возвращает значение, позволяющее определить, можно ли поместить в контекст объект <see cref="T:System.Type" />.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> может быть помещен в контекст; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600115A RID: 4442 RVA: 0x00047423 File Offset: 0x00045623
		public bool IsContextful
		{
			get
			{
				return this.IsContextfulImpl();
			}
		}

		/// <summary>Реализует свойство <see cref="P:System.Type.IsContextful" /> и определяет, можно ли поместить в контекст данный объект <see cref="T:System.Type" />.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> может быть помещен в контекст; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600115B RID: 4443 RVA: 0x0004742B File Offset: 0x0004562B
		protected virtual bool IsContextfulImpl()
		{
			return typeof(ContextBoundObject).IsAssignableFrom(this);
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x0600115C RID: 4444 RVA: 0x000040F7 File Offset: 0x000022F7
		public virtual bool IsCollectible
		{
			get
			{
				return true;
			}
		}

		/// <summary>Возвращает значение, позволяющее определить, представляет ли текущий объект <see cref="T:System.Type" /> перечисление.</summary>
		/// <returns>Значение <see langword="true" />, если текущий объект <see cref="T:System.Type" /> представляет перечисление; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000199 RID: 409
		// (get) Token: 0x0600115D RID: 4445 RVA: 0x0004743D File Offset: 0x0004563D
		public virtual bool IsEnum
		{
			get
			{
				return this.IsSubclassOf(typeof(Enum));
			}
		}

		/// <summary>Возвращает значение, указывающее, маршалирован ли объект <see cref="T:System.Type" /> по ссылке.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> маршалируется по ссылке; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700019A RID: 410
		// (get) Token: 0x0600115E RID: 4446 RVA: 0x0004744F File Offset: 0x0004564F
		public bool IsMarshalByRef
		{
			get
			{
				return this.IsMarshalByRefImpl();
			}
		}

		/// <summary>Реализует свойство <see cref="P:System.Type.IsMarshalByRef" /> и определяет, маршалируется ли объект <see cref="T:System.Type" /> по ссылке.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> маршалируется по ссылке; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600115F RID: 4447 RVA: 0x00047457 File Offset: 0x00045657
		protected virtual bool IsMarshalByRefImpl()
		{
			return typeof(MarshalByRefObject).IsAssignableFrom(this);
		}

		/// <summary>Возвращает значение, указывающее, является ли <see cref="T:System.Type" /> одним из типов-примитивов.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> является одним из типов-примитивов; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06001160 RID: 4448 RVA: 0x00047469 File Offset: 0x00045669
		public bool IsPrimitive
		{
			get
			{
				return this.IsPrimitiveImpl();
			}
		}

		/// <summary>При переопределении в производном классе реализует свойство <see cref="P:System.Type.IsPrimitive" /> и определяет, является ли объект <see cref="T:System.Type" /> одним из типов-примитивов.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> является одним из типов-примитивов; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001161 RID: 4449
		protected abstract bool IsPrimitiveImpl();

		/// <summary>Возвращает значение, позволяющее определить, является ли объект <see cref="T:System.Type" /> типом значения.</summary>
		/// <returns>Значение <see langword="true" />, если тип <see cref="T:System.Type" /> является типом значения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06001162 RID: 4450 RVA: 0x00047471 File Offset: 0x00045671
		public bool IsValueType
		{
			get
			{
				return this.IsValueTypeImpl();
			}
		}

		/// <summary>Реализует свойство <see cref="P:System.Type.IsValueType" /> и определяет, является ли объект <see cref="T:System.Type" /> типом значения (иными словами, не является классом или интерфейсом).</summary>
		/// <returns>Значение <see langword="true" />, если тип <see cref="T:System.Type" /> является типом значения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001163 RID: 4451 RVA: 0x00047479 File Offset: 0x00045679
		protected virtual bool IsValueTypeImpl()
		{
			return this.IsSubclassOf(typeof(ValueType));
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06001164 RID: 4452 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public virtual bool IsSignatureType
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает значение, которое указывает, является ли текущий тип критически важным для безопасности или защищенным критически важным для безопасности на данном уровне доверия и, следовательно, может ли он выполнять критические операции.</summary>
		/// <returns>Значение <see langword="true" />, если текущий тип является критически важным для безопасности или защищенным критически важным для безопасности на текущем уровне доверия; значение <see langword="false" />, если он является прозрачным.</returns>
		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06001165 RID: 4453 RVA: 0x00047226 File Offset: 0x00045426
		public virtual bool IsSecurityCritical
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		/// <summary>Возвращает значение, которое указывает, является ли текущий тип защищенным критически важным для безопасности на текущем уровне доверия и, следовательно, может ли он выполнять критические операции и предоставлять доступ прозрачному коду.</summary>
		/// <returns>Значение <see langword="true" />, если текущий тип является защищенным критически важным для безопасности на текущем уровне доверия; значение <see langword="false" />, если он является критически важным для безопасности или прозрачным.</returns>
		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06001166 RID: 4454 RVA: 0x00047226 File Offset: 0x00045426
		public virtual bool IsSecuritySafeCritical
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		/// <summary>Возвращает значение, которое указывает, является ли текущий тип прозрачным на текущем уровне доверия и, следовательно, не может выполнять критические операции.</summary>
		/// <returns>Значение <see langword="true" />, если текущий тип является прозрачным на текущем уровне доверия; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06001167 RID: 4455 RVA: 0x00047226 File Offset: 0x00045426
		public virtual bool IsSecurityTransparent
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		/// <summary>Возвращает атрибут <see cref="T:System.Runtime.InteropServices.StructLayoutAttribute" />, описывающий структуру текущего типа.</summary>
		/// <returns>Возвращает атрибут <see cref="T:System.Runtime.InteropServices.StructLayoutAttribute" />, описывающий общие особенности структуры текущего типа.</returns>
		/// <exception cref="T:System.NotSupportedException">Вызванный метод не поддерживается в базовом классе.</exception>
		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06001168 RID: 4456 RVA: 0x000472C8 File Offset: 0x000454C8
		public virtual StructLayoutAttribute StructLayoutAttribute
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		/// <summary>Возвращает инициализатор типа.</summary>
		/// <returns>Объект, содержащий имя конструктора класса <see cref="T:System.Type" />.</returns>
		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06001169 RID: 4457 RVA: 0x0004748B File Offset: 0x0004568B
		public ConstructorInfo TypeInitializer
		{
			get
			{
				return this.GetConstructorImpl(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, CallingConventions.Any, Type.EmptyTypes, null);
			}
		}

		/// <summary>Выполняет поиск открытого конструктора экземпляра, параметры которого соответствуют типам, содержащимся в указанном массиве.</summary>
		/// <param name="types">Массив объектов <see cref="T:System.Type" />, предоставляющих число, порядок и тип параметров нужного конструктора.  
		/// -или- 
		/// Пустой массив объектов <see cref="T:System.Type" /> для получения конструктора, не имеющего параметров. Подобный пустой массив предоставляется полем <see langword="static" /> с описателем <see cref="F:System.Type.EmptyTypes" />.</param>
		/// <returns>Объект, представляющий открытый конструктор экземпляра, параметры которого соответствуют типам, указанным в массиве типов параметров, если такой конструктор найден; в противном случае — <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="types" /> — <see langword="null" />.  
		/// -или- 
		/// Один из элементов в <paramref name="types" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="types" /> является многомерным.</exception>
		// Token: 0x0600116A RID: 4458 RVA: 0x0004749D File Offset: 0x0004569D
		[ComVisible(true)]
		public ConstructorInfo GetConstructor(Type[] types)
		{
			return this.GetConstructor(BindingFlags.Instance | BindingFlags.Public, null, types, null);
		}

		/// <summary>Выполняет поиск конструктора, параметры которого соответствуют указанным типам аргументов и модификаторам, используя заданные ограничения привязки.</summary>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <param name="binder">Объект, определяющий набор свойств и разрешающий привязку, что может включать выбор перегруженных методов, приведение типов аргументов и вызов члена с помощью отражения.  
		/// -или- 
		/// Пустая ссылка (<see langword="Nothing" /> в Visual Basic) для использования свойства <see cref="P:System.Type.DefaultBinder" />.</param>
		/// <param name="types">Массив объектов <see cref="T:System.Type" />, предоставляющий число, порядок и тип параметров, извлекаемых конструктором.  
		/// -или- 
		/// Пустой массив объектов типа <see cref="T:System.Type" /> (то есть Type[] types = new Type[0]), если требуется получить конструктор, который не имеет параметров.  
		/// -или- 
		///  <see cref="F:System.Type.EmptyTypes" />.</param>
		/// <param name="modifiers">Массив объектов <see cref="T:System.Reflection.ParameterModifier" />, представляющих атрибуты, связанные с соответствующим элементом в массиве типов параметра. Связыватель по умолчанию не обрабатывает этот параметр.</param>
		/// <returns>Если поиск выполнен удачно, возвращается объект <see cref="T:System.Reflection.ConstructorInfo" />, представляющий конструктор, который соответствует указанным требованиям; в противном случае возвращается значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="types" /> — <see langword="null" />.  
		/// -или- 
		/// Один из элементов в <paramref name="types" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="types" /> является многомерным.  
		/// -или- 
		///  Массив <paramref name="modifiers" /> является многомерным.  
		/// -или- 
		///  <paramref name="types" /> и <paramref name="modifiers" /> имеют разную длину.</exception>
		// Token: 0x0600116B RID: 4459 RVA: 0x000474AA File Offset: 0x000456AA
		[ComVisible(true)]
		public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers)
		{
			return this.GetConstructor(bindingAttr, binder, CallingConventions.Any, types, modifiers);
		}

		/// <summary>Выполняет поиск конструктора с параметрами, соответствующими указанным модификаторам и типам аргументов, с учетом заданных ограничений по привязке и соглашений о вызовах.</summary>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <param name="binder">Объект, определяющий набор свойств и разрешающий привязку, что может включать выбор перегруженных методов, приведение типов аргументов и вызов члена с помощью отражения.  
		/// -или- 
		/// Пустая ссылка (<see langword="Nothing" /> в Visual Basic) для использования свойства <see cref="P:System.Type.DefaultBinder" />.</param>
		/// <param name="callConvention">Объект, определяющий набор применяемых правил, касающихся порядка и расположения аргументов, способа передачи возвращаемого значения, регистров, используемых для аргументов, и очистки стека.</param>
		/// <param name="types">Массив объектов <see cref="T:System.Type" />, предоставляющий число, порядок и тип параметров, извлекаемых конструктором.  
		/// -или- 
		/// Пустой массив объектов типа <see cref="T:System.Type" /> (то есть Type[] types = new Type[0]), если требуется получить конструктор, который не имеет параметров.</param>
		/// <param name="modifiers">Массив объектов <see cref="T:System.Reflection.ParameterModifier" />, представляющих атрибуты, связанные с соответствующим элементом в массиве <paramref name="types" />. Связыватель по умолчанию не обрабатывает этот параметр.</param>
		/// <returns>Если поиск выполнен удачно, возвращается объект, представляющий конструктор, который соответствует указанным требованиям; в противном случае возвращается значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="types" /> — <see langword="null" />.  
		/// -или- 
		/// Один из элементов в <paramref name="types" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="types" /> является многомерным.  
		/// -или- 
		///  Массив <paramref name="modifiers" /> является многомерным.  
		/// -или- 
		///  <paramref name="types" /> и <paramref name="modifiers" /> имеют разную длину.</exception>
		// Token: 0x0600116C RID: 4460 RVA: 0x000474B8 File Offset: 0x000456B8
		[ComVisible(true)]
		public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			if (types == null)
			{
				throw new ArgumentNullException("types");
			}
			for (int i = 0; i < types.Length; i++)
			{
				if (types[i] == null)
				{
					throw new ArgumentNullException("types");
				}
			}
			return this.GetConstructorImpl(bindingAttr, binder, callConvention, types, modifiers);
		}

		/// <summary>При переопределении в производном классе ищет конструктор, параметры которого соответствуют указанным типам аргументов и модификаторам, используя для этого заданные ограничения привязки и соглашение о вызовах.</summary>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <param name="binder">Объект, определяющий набор свойств и разрешающий привязку, что может включать выбор перегруженных методов, приведение типов аргументов и вызов члена с помощью отражения.  
		/// -или- 
		/// Пустая ссылка (<see langword="Nothing" /> в Visual Basic) для использования свойства <see cref="P:System.Type.DefaultBinder" />.</param>
		/// <param name="callConvention">Объект, определяющий набор применяемых правил, касающихся порядка и расположения аргументов, способа передачи возвращаемого значения, регистров, используемых для аргументов, и очистки стека.</param>
		/// <param name="types">Массив объектов <see cref="T:System.Type" />, предоставляющий число, порядок и тип параметров, извлекаемых конструктором.  
		/// -или- 
		/// Пустой массив объектов типа <see cref="T:System.Type" /> (то есть Type[] types = new Type[0]), если требуется получить конструктор, который не имеет параметров.</param>
		/// <param name="modifiers">Массив объектов <see cref="T:System.Reflection.ParameterModifier" />, представляющих атрибуты, связанные с соответствующим элементом в массиве <paramref name="types" />. Связыватель по умолчанию не обрабатывает этот параметр.</param>
		/// <returns>Если поиск выполнен удачно, возвращается объект <see cref="T:System.Reflection.ConstructorInfo" />, представляющий конструктор, который соответствует указанным требованиям; в противном случае возвращается значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="types" /> — <see langword="null" />.  
		/// -или- 
		/// Один из элементов в <paramref name="types" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="types" /> является многомерным.  
		/// -или- 
		///  Массив <paramref name="modifiers" /> является многомерным.  
		/// -или- 
		///  <paramref name="types" /> и <paramref name="modifiers" /> имеют разную длину.</exception>
		/// <exception cref="T:System.NotSupportedException">Текущий тип — <see cref="T:System.Reflection.Emit.TypeBuilder" /> или <see cref="T:System.Reflection.Emit.GenericTypeParameterBuilder" />.</exception>
		// Token: 0x0600116D RID: 4461
		protected abstract ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);

		/// <summary>Возвращает все открытые конструкторы, определенные для текущего объекта <see cref="T:System.Type" />.</summary>
		/// <returns>Массив объектов <see cref="T:System.Reflection.ConstructorInfo" />, представляющий все открытые конструкторы экземпляров, определенные для текущего типа <see cref="T:System.Type" />, за исключением инициализатора типа (статический конструктор). Если для текущего объекта <see cref="T:System.Type" /> открытые конструкторы экземпляров не определены или если текущий объект <see cref="T:System.Type" /> представляет параметр типа в определении универсального типа или метода, возвращается пустой массив типа <see cref="T:System.Reflection.ConstructorInfo" />.</returns>
		// Token: 0x0600116E RID: 4462 RVA: 0x00047507 File Offset: 0x00045707
		[ComVisible(true)]
		public ConstructorInfo[] GetConstructors()
		{
			return this.GetConstructors(BindingFlags.Instance | BindingFlags.Public);
		}

		/// <summary>При переопределении в производном классе ищет конструкторы, определенные для текущего объекта <see cref="T:System.Type" />, с использованием указанного объекта <see langword="BindingFlags" />.</summary>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <returns>Массив объектов <see cref="T:System.Reflection.ConstructorInfo" />, представляющий все конструкторы, определенные для текущего объекта <see cref="T:System.Type" /> и удовлетворяющие указанным ограничениям привязки, в том числе и инициализатор типа, если он определен. Возвращает пустой массив типа <see cref="T:System.Reflection.ConstructorInfo" />, если для текущего типа <see cref="T:System.Type" /> не определены конструкторы, если ни один из определенных конструкторов не соответствует ограничениям привязки или если текущий тип <see cref="T:System.Type" /> представляет параметр типа в определении универсального типа или метода.</returns>
		// Token: 0x0600116F RID: 4463
		[ComVisible(true)]
		public abstract ConstructorInfo[] GetConstructors(BindingFlags bindingAttr);

		/// <summary>Возвращает объект <see cref="T:System.Reflection.EventInfo" />, представляющий указанное открытое событие.</summary>
		/// <param name="name">Строка, содержащая имя события, которое объявлено или унаследовано текущим типом <see cref="T:System.Type" />.</param>
		/// <returns>Объект, представляющий указанное открытое событие, которое объявлено или унаследовано в текущем объекте <see cref="T:System.Type" />, если такое событие найдено; в противном случае — <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.</exception>
		// Token: 0x06001170 RID: 4464 RVA: 0x00047511 File Offset: 0x00045711
		public EventInfo GetEvent(string name)
		{
			return this.GetEvent(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		/// <summary>При переопределении в производном классе возвращает объект <see cref="T:System.Reflection.EventInfo" />, представляющий указанное событие, используя для этого указанные ограничения привязки.</summary>
		/// <param name="name">Строка, содержащая имя события, которое объявлено или унаследовано текущим типом <see cref="T:System.Type" />.</param>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <returns>Объект, представляющий указанное событие, которое объявлено или унаследовано текущим типом <see cref="T:System.Type" />, если такое событие найдено; <see langword="null" /> в противном случае.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.</exception>
		// Token: 0x06001171 RID: 4465
		public abstract EventInfo GetEvent(string name, BindingFlags bindingAttr);

		/// <summary>Возвращает все открытые события, которые объявлены или унаследованы текущим объектом <see cref="T:System.Type" />.</summary>
		/// <returns>Массив объектов <see cref="T:System.Reflection.EventInfo" />, представляющий все открытые события, которые объявлены или унаследованы текущим объектом <see cref="T:System.Type" />.  
		/// -или- 
		/// Пустой массив типа <see cref="T:System.Reflection.EventInfo" />, если в текущем объекте <see cref="T:System.Type" /> нет открытых событий.</returns>
		// Token: 0x06001172 RID: 4466 RVA: 0x0004751C File Offset: 0x0004571C
		public virtual EventInfo[] GetEvents()
		{
			return this.GetEvents(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		/// <summary>При переопределении в производном классе ищет события, которые объявлены или унаследованы текущим объектом <see cref="T:System.Type" />, используя указанные ограничения привязки.</summary>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <returns>Массив объектов <see cref="T:System.Reflection.EventInfo" />, представляющий все события, которые объявлены или унаследованы данным объектом <see cref="T:System.Type" /> и удовлетворяют указанным ограничениям привязки.  
		/// -или- 
		/// Пустой массив типа <see cref="T:System.Reflection.EventInfo" />, если у текущего типа <see cref="T:System.Type" /> нет событий или ни одно событие не удовлетворяет ограничениям привязки.</returns>
		// Token: 0x06001173 RID: 4467
		public abstract EventInfo[] GetEvents(BindingFlags bindingAttr);

		/// <summary>Выполняет поиск открытого поля с заданным именем.</summary>
		/// <param name="name">Строка, содержащая имя искомого поля данных.</param>
		/// <returns>Объект, представляющий открытое поле с указанным именем, если такое свойство есть, или <see langword="null" />, если такого свойства нет.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Этот объект <see cref="T:System.Type" /> является <see cref="T:System.Reflection.Emit.TypeBuilder" />, метод <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> которого еще не был вызван.</exception>
		// Token: 0x06001174 RID: 4468 RVA: 0x00047526 File Offset: 0x00045726
		public FieldInfo GetField(string name)
		{
			return this.GetField(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		/// <summary>Выполняет поиск указанного поля, используя заданные ограничения привязки.</summary>
		/// <param name="name">Строка, содержащая имя искомого поля данных.</param>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <returns>Объект, предоставляющий поле, которое соответствует указанным требованиям, если такое свойство найдено; в противном случае возвращается <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.</exception>
		// Token: 0x06001175 RID: 4469
		public abstract FieldInfo GetField(string name, BindingFlags bindingAttr);

		/// <summary>Возвращает все открытые поля текущего объекта <see cref="T:System.Type" />.</summary>
		/// <returns>Массив объектов <see cref="T:System.Reflection.FieldInfo" />, представляющий все открытые поля, определенные для текущего объекта <see cref="T:System.Type" />.  
		/// -или- 
		/// Пустой массив типа <see cref="T:System.Reflection.FieldInfo" />, если для текущего типа <see cref="T:System.Type" /> открытые поля не определены.</returns>
		// Token: 0x06001176 RID: 4470 RVA: 0x00047531 File Offset: 0x00045731
		public FieldInfo[] GetFields()
		{
			return this.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		/// <summary>При переопределении в производном классе ищет поля, определенные для текущего объекта <see cref="T:System.Type" />, используя указанные ограничения привязки.</summary>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <returns>Массив объектов <see cref="T:System.Reflection.FieldInfo" />, представляющий все поля, определенные для текущего типа <see cref="T:System.Type" /> и удовлетворяющие указанным ограничениям привязки.  
		/// -или- 
		/// Пустой массив типа <see cref="T:System.Reflection.FieldInfo" />, если для текущего объекта <see cref="T:System.Type" /> не определены поля или ни одно из определенных полей не удовлетворяет ограничениям привязки.</returns>
		// Token: 0x06001177 RID: 4471
		public abstract FieldInfo[] GetFields(BindingFlags bindingAttr);

		/// <summary>Выполняет поиск открытого члена с заданным именем.</summary>
		/// <param name="name">Строка, содержащая имя искомых открытых членов.</param>
		/// <returns>Массив объектов <see cref="T:System.Reflection.MemberInfo" />, представляющий открытые члены с заданным именем, если такие члены есть, и пустой массив, если таких членов нет.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.</exception>
		// Token: 0x06001178 RID: 4472 RVA: 0x0004753B File Offset: 0x0004573B
		public MemberInfo[] GetMember(string name)
		{
			return this.GetMember(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		/// <summary>Выполняет поиск указанных членов, используя заданные ограничения привязки.</summary>
		/// <param name="name">Строка, содержащая имя для поиска элементов.</param>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Ноль для возвращения пустого массива.</param>
		/// <returns>Массив объектов <see cref="T:System.Reflection.MemberInfo" />, представляющий открытые члены с заданным именем, если такие члены есть, и пустой массив, если таких членов нет.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.</exception>
		// Token: 0x06001179 RID: 4473 RVA: 0x00047546 File Offset: 0x00045746
		public virtual MemberInfo[] GetMember(string name, BindingFlags bindingAttr)
		{
			return this.GetMember(name, MemberTypes.All, bindingAttr);
		}

		/// <summary>Ищет указанные члены заданного типа, используя установленные ограничения привязки.</summary>
		/// <param name="name">Строка, содержащая имя для поиска элементов.</param>
		/// <param name="type">Значение, которое нужно найти.</param>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Ноль для возвращения пустого массива.</param>
		/// <returns>Массив объектов <see cref="T:System.Reflection.MemberInfo" />, представляющий открытые члены с заданным именем, если такие члены есть, и пустой массив, если таких членов нет.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Реализацию должен обеспечивать производный класс.</exception>
		// Token: 0x0600117A RID: 4474 RVA: 0x0004728A File Offset: 0x0004548A
		public virtual MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
		{
			throw new NotSupportedException("Derived classes must provide an implementation.");
		}

		/// <summary>Возвращает все открытые члены текущего объекта <see cref="T:System.Type" />.</summary>
		/// <returns>Массив объектов <see cref="T:System.Reflection.MemberInfo" />, представляющий все открытые члены текущего типа <see cref="T:System.Type" />.  
		/// -или- 
		/// Пустой массив типа <see cref="T:System.Reflection.MemberInfo" />, если у текущего типа <see cref="T:System.Type" /> нет открытых членов.</returns>
		// Token: 0x0600117B RID: 4475 RVA: 0x00047555 File Offset: 0x00045755
		public MemberInfo[] GetMembers()
		{
			return this.GetMembers(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		/// <summary>При переопределении в производном классе ищет члены, определенные для текущего объекта <see cref="T:System.Type" />, используя указанные ограничения привязки.</summary>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Ноль (<see cref="F:System.Reflection.BindingFlags.Default" />) для возвращения пустого массива.</param>
		/// <returns>Массив объектов <see cref="T:System.Reflection.MemberInfo" />, представляющий все члены, определенные для текущего типа <see cref="T:System.Type" /> и удовлетворяющие указанным ограничениям привязки.  
		/// -или- 
		/// Пустой массив типа <see cref="T:System.Reflection.MemberInfo" />, если для текущего объекта <see cref="T:System.Type" /> не определены члены или ни один из определенных членов не удовлетворяет ограничениям привязки.</returns>
		// Token: 0x0600117C RID: 4476
		public abstract MemberInfo[] GetMembers(BindingFlags bindingAttr);

		/// <summary>Выполняет поиск открытого метода с заданным именем.</summary>
		/// <param name="name">Строка, содержащая имя искомого открытого метода.</param>
		/// <returns>Объект, представляющий открытый метод с заданным именем, если такой метод есть, и <see langword="null" />, если такого метода нет.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Найдено несколько методов с указанным именем.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.</exception>
		// Token: 0x0600117D RID: 4477 RVA: 0x0004755F File Offset: 0x0004575F
		public MethodInfo GetMethod(string name)
		{
			return this.GetMethod(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		/// <summary>Выполняет поиск указанного метода, используя заданные ограничения привязки.</summary>
		/// <param name="name">Строка, содержащая имя искомого метода.</param>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <returns>Если поиск выполнен удачно, возвращается объект, предоставляющий метод, который соответствует указанным требованиям; в противном случае возвращается <see langword="null" />.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Найдено несколько методов с указанным именем и соответствующих указанным ограничениям привязки.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.</exception>
		// Token: 0x0600117E RID: 4478 RVA: 0x0004756A File Offset: 0x0004576A
		public MethodInfo GetMethod(string name, BindingFlags bindingAttr)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			return this.GetMethodImpl(name, bindingAttr, null, CallingConventions.Any, null, null);
		}

		/// <summary>Ищет указанный открытый метод, параметры которого соответствуют заданным типам аргументов.</summary>
		/// <param name="name">Строка, содержащая имя искомого открытого метода.</param>
		/// <param name="types">Массив объектов <see cref="T:System.Type" />, предоставляющий число, порядок и тип параметров искомого метода.  
		/// -или- 
		/// Пустой массив объектов <see cref="T:System.Type" /> (в соответствии со значением поля <see cref="F:System.Type.EmptyTypes" />) для получения метода, не принимающего параметры.</param>
		/// <returns>Объект, представляющий открытый метод, параметры которого соответствуют указанным типам аргументов, если они существуют, и <see langword="null" />, если их нет.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Найдено несколько методов с указанным именем и заданными параметрами.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="types" /> — <see langword="null" />.  
		/// -или- 
		/// Один из элементов в <paramref name="types" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="types" /> является многомерным.</exception>
		// Token: 0x0600117F RID: 4479 RVA: 0x00047586 File Offset: 0x00045786
		public MethodInfo GetMethod(string name, Type[] types)
		{
			return this.GetMethod(name, types, null);
		}

		/// <summary>Выполняет поиск указанного открытого метода, параметры которого соответствуют указанным типам аргументов и модификаторам.</summary>
		/// <param name="name">Строка, содержащая имя искомого открытого метода.</param>
		/// <param name="types">Массив объектов <see cref="T:System.Type" />, предоставляющий число, порядок и тип параметров искомого метода.  
		/// -или- 
		/// Пустой массив объектов <see cref="T:System.Type" /> (в соответствии со значением поля <see cref="F:System.Type.EmptyTypes" />) для получения метода, не принимающего параметры.</param>
		/// <param name="modifiers">Массив объектов <see cref="T:System.Reflection.ParameterModifier" />, представляющих атрибуты, связанные с соответствующим элементом в массиве <paramref name="types" />. Используется только при вызове посредством COM-взаимодействия. При этом обрабатываются только параметры, переданные по ссылке. Связыватель по умолчанию не обрабатывает этот параметр.</param>
		/// <returns>Если поиск выполнен успешно, возвращается объект, представляющий открытый метод, который соответствует указанным требованиям; в противном случае возвращается <see langword="null" />.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Найдено несколько методов с указанным именем и заданными параметрами.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="types" /> — <see langword="null" />.  
		/// -или- 
		/// Один из элементов в <paramref name="types" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="types" /> является многомерным.  
		/// -или- 
		///  Массив <paramref name="modifiers" /> является многомерным.</exception>
		// Token: 0x06001180 RID: 4480 RVA: 0x00047591 File Offset: 0x00045791
		public MethodInfo GetMethod(string name, Type[] types, ParameterModifier[] modifiers)
		{
			return this.GetMethod(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public, null, types, modifiers);
		}

		/// <summary>Ищет заданный метод, параметры которого соответствуют указанным типам аргументов и модификаторам, используя установленные ограничения привязки.</summary>
		/// <param name="name">Строка, содержащая имя искомого метода.</param>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <param name="binder">Объект, определяющий набор свойств и разрешающий привязку, что может включать выбор перегруженных методов, приведение типов аргументов и вызов члена с помощью отражения.  
		/// -или- 
		/// Пустая ссылка (<see langword="Nothing" /> в Visual Basic) для использования свойства <see cref="P:System.Type.DefaultBinder" />.</param>
		/// <param name="types">Массив объектов <see cref="T:System.Type" />, предоставляющий число, порядок и тип параметров искомого метода.  
		/// -или- 
		/// Пустой массив объектов <see cref="T:System.Type" /> (в соответствии со значением поля <see cref="F:System.Type.EmptyTypes" />) для получения метода, не принимающего параметры.</param>
		/// <param name="modifiers">Массив объектов <see cref="T:System.Reflection.ParameterModifier" />, представляющих атрибуты, связанные с соответствующим элементом в массиве <paramref name="types" />. Используется только при вызове посредством COM-взаимодействия. При этом обрабатываются только параметры, переданные по ссылке. Связыватель по умолчанию не обрабатывает этот параметр.</param>
		/// <returns>Если поиск выполнен удачно, возвращается объект, предоставляющий метод, который соответствует указанным требованиям; в противном случае возвращается <see langword="null" />.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Найдено несколько методов с указанным именем и соответствующих указанным ограничениям привязки.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="types" /> — <see langword="null" />.  
		/// -или- 
		/// Один из элементов в <paramref name="types" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="types" /> является многомерным.  
		/// -или- 
		///  Массив <paramref name="modifiers" /> является многомерным.</exception>
		// Token: 0x06001181 RID: 4481 RVA: 0x0004759F File Offset: 0x0004579F
		public MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers)
		{
			return this.GetMethod(name, bindingAttr, binder, CallingConventions.Any, types, modifiers);
		}

		/// <summary>Ищет метод с параметрами, соответствующими указанным модификаторам и типам аргументов, с учетом заданных ограничений привязки и соглашений о вызовах.</summary>
		/// <param name="name">Строка, содержащая имя искомого метода.</param>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <param name="binder">Объект, определяющий набор свойств и разрешающий привязку, что может включать выбор перегруженных методов, приведение типов аргументов и вызов члена с помощью отражения.  
		/// -или- 
		/// Пустая ссылка (<see langword="Nothing" /> в Visual Basic) для использования свойства <see cref="P:System.Type.DefaultBinder" />.</param>
		/// <param name="callConvention">Объект, определяющий набор применяемых правил, касающихся порядка и расположения аргументов, способа передачи возвращаемого значения, регистров, используемых для аргументов, и способа очистки стека.</param>
		/// <param name="types">Массив объектов <see cref="T:System.Type" />, предоставляющий число, порядок и тип параметров искомого метода.  
		/// -или- 
		/// Пустой массив объектов <see cref="T:System.Type" /> (в соответствии со значением поля <see cref="F:System.Type.EmptyTypes" />) для получения метода, не принимающего параметры.</param>
		/// <param name="modifiers">Массив объектов <see cref="T:System.Reflection.ParameterModifier" />, представляющих атрибуты, связанные с соответствующим элементом в массиве <paramref name="types" />. Используется только при вызове посредством COM-взаимодействия. При этом обрабатываются только параметры, переданные по ссылке. Связыватель по умолчанию не обрабатывает этот параметр.</param>
		/// <returns>Если поиск выполнен удачно, возвращается объект, предоставляющий метод, который соответствует указанным требованиям; в противном случае возвращается <see langword="null" />.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Найдено несколько методов с указанным именем и соответствующих указанным ограничениям привязки.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="types" /> — <see langword="null" />.  
		/// -или- 
		/// Один из элементов в <paramref name="types" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="types" /> является многомерным.  
		/// -или- 
		///  Массив <paramref name="modifiers" /> является многомерным.</exception>
		// Token: 0x06001182 RID: 4482 RVA: 0x000475B0 File Offset: 0x000457B0
		public MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (types == null)
			{
				throw new ArgumentNullException("types");
			}
			for (int i = 0; i < types.Length; i++)
			{
				if (types[i] == null)
				{
					throw new ArgumentNullException("types");
				}
			}
			return this.GetMethodImpl(name, bindingAttr, binder, callConvention, types, modifiers);
		}

		/// <summary>При переопределении в производном классе ищет указанный метод, параметры которого соответствуют указанным типам аргументов и модификаторам, используя для этого заданные ограничения привязки и соглашение о вызовах.</summary>
		/// <param name="name">Строка, содержащая имя искомого метода.</param>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <param name="binder">Объект, определяющий набор свойств и разрешающий привязку, что может включать выбор перегруженных методов, приведение типов аргументов и вызов члена с помощью отражения.  
		/// -или- 
		/// Пустая ссылка (<see langword="Nothing" /> в Visual Basic) для использования свойства <see cref="P:System.Type.DefaultBinder" />.</param>
		/// <param name="callConvention">Объект, который задает набор правил, используемых в зависимости от порядка и расположения аргументов, способа передачи возвращаемого значения, регистров, используемых для аргументов, и процесса очистки стека.</param>
		/// <param name="types">Массив объектов <see cref="T:System.Type" />, предоставляющий число, порядок и тип параметров искомого метода.  
		/// -или- 
		/// Пустой массив объектов типа <see cref="T:System.Type" /> (то есть Type[] types = new Type[0]), если требуется получить метод, который не имеет параметров.  
		/// -или- 
		///  <see langword="null" />. Если значение параметра <paramref name="types" /> равно <see langword="null" />, аргументы метода не проверяются на соответствие условиям.</param>
		/// <param name="modifiers">Массив объектов <see cref="T:System.Reflection.ParameterModifier" />, представляющих атрибуты, связанные с соответствующим элементом в массиве <paramref name="types" />. Связыватель по умолчанию не обрабатывает этот параметр.</param>
		/// <returns>Если поиск выполнен удачно, возвращается объект, предоставляющий метод, который соответствует указанным требованиям; в противном случае возвращается <see langword="null" />.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Найдено несколько методов с указанным именем и соответствующих указанным ограничениям привязки.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="types" /> является многомерным.  
		/// -или- 
		///  Массив <paramref name="modifiers" /> является многомерным.  
		/// -или- 
		///  <paramref name="types" /> и <paramref name="modifiers" /> имеют разную длину.</exception>
		/// <exception cref="T:System.NotSupportedException">Текущий тип — <see cref="T:System.Reflection.Emit.TypeBuilder" /> или <see cref="T:System.Reflection.Emit.GenericTypeParameterBuilder" />.</exception>
		// Token: 0x06001183 RID: 4483
		protected abstract MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);

		// Token: 0x06001184 RID: 4484 RVA: 0x0004760F File Offset: 0x0004580F
		public MethodInfo GetMethod(string name, int genericParameterCount, Type[] types)
		{
			return this.GetMethod(name, genericParameterCount, types, null);
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x0004761B File Offset: 0x0004581B
		public MethodInfo GetMethod(string name, int genericParameterCount, Type[] types, ParameterModifier[] modifiers)
		{
			return this.GetMethod(name, genericParameterCount, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public, null, types, modifiers);
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x0004762B File Offset: 0x0004582B
		public MethodInfo GetMethod(string name, int genericParameterCount, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers)
		{
			return this.GetMethod(name, genericParameterCount, bindingAttr, binder, CallingConventions.Any, types, modifiers);
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x00047640 File Offset: 0x00045840
		public MethodInfo GetMethod(string name, int genericParameterCount, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (genericParameterCount < 0)
			{
				throw new ArgumentException("Non-negative number required.", "genericParameterCount");
			}
			if (types == null)
			{
				throw new ArgumentNullException("types");
			}
			for (int i = 0; i < types.Length; i++)
			{
				if (types[i] == null)
				{
					throw new ArgumentNullException("types");
				}
			}
			return this.GetMethodImpl(name, genericParameterCount, bindingAttr, binder, callConvention, types, modifiers);
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x000472C8 File Offset: 0x000454C8
		protected virtual MethodInfo GetMethodImpl(string name, int genericParameterCount, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			throw new NotSupportedException();
		}

		/// <summary>Возвращает все открытые методы текущего объекта <see cref="T:System.Type" />.</summary>
		/// <returns>Массив объектов <see cref="T:System.Reflection.MethodInfo" />, представляющий все открытые методы, определенные для текущего объекта <see cref="T:System.Type" />.  
		/// -или- 
		/// Пустой массив типа <see cref="T:System.Reflection.MethodInfo" />, если для текущего типа <see cref="T:System.Type" /> открытые методы не определены.</returns>
		// Token: 0x06001189 RID: 4489 RVA: 0x000476B5 File Offset: 0x000458B5
		public MethodInfo[] GetMethods()
		{
			return this.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		/// <summary>При переопределении в производном классе ищет методы, определенные для текущего объекта <see cref="T:System.Type" />, используя указанные ограничения привязки.</summary>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <returns>Массив объектов <see cref="T:System.Reflection.MethodInfo" />, представляющий все методы, определенные для текущего типа <see cref="T:System.Type" /> и удовлетворяющие указанным ограничениям привязки.  
		/// -или- 
		/// Пустой массив типа <see cref="T:System.Reflection.MethodInfo" />, если для текущего объекта <see cref="T:System.Type" /> не определены методы или ни один из определенных методов не удовлетворяет ограничениям привязки.</returns>
		// Token: 0x0600118A RID: 4490
		public abstract MethodInfo[] GetMethods(BindingFlags bindingAttr);

		/// <summary>Выполняет поиск открытого вложенного типа с заданным именем.</summary>
		/// <param name="name">Строка, содержащая имя искомого вложенного типа.</param>
		/// <returns>Объект, представляющий открытый вложенный тип с указанным именем, если тип есть, и <see langword="null" />, если такого типа нет.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.</exception>
		// Token: 0x0600118B RID: 4491 RVA: 0x000476BF File Offset: 0x000458BF
		public Type GetNestedType(string name)
		{
			return this.GetNestedType(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		/// <summary>При переопределении в производном классе ищет указанный вложенный тип, используя заданные ограничения привязки.</summary>
		/// <param name="name">Строка, содержащая имя искомого вложенного типа.</param>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <returns>Если поиск выполнен успешно, возвращается объект, предоставляющий вложенный тип, который соответствует указанным требованиям; в противном случае возвращается <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.</exception>
		// Token: 0x0600118C RID: 4492
		public abstract Type GetNestedType(string name, BindingFlags bindingAttr);

		/// <summary>Возвращает открытые типы, вложенные в текущий объект <see cref="T:System.Type" />.</summary>
		/// <returns>Массив объектов <see cref="T:System.Type" />, представляющий открытые типы, вложенные в текущий объект <see cref="T:System.Type" /> (нерекурсивный поиск), или пустой массив типа <see cref="T:System.Type" />, если в текущий объект <see cref="T:System.Type" /> не вложен ни один открытый тип.</returns>
		// Token: 0x0600118D RID: 4493 RVA: 0x000476CA File Offset: 0x000458CA
		public Type[] GetNestedTypes()
		{
			return this.GetNestedTypes(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		/// <summary>При переопределении в производном классе ищет типы, вложенные в текущий объект <see cref="T:System.Type" />, используя заданные ограничения привязки.</summary>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <returns>Массив объектов <see cref="T:System.Type" />, представляющий все типы, вложенные в текущий объект <see cref="T:System.Type" />, удовлетворяющий заданным ограничениям привязки (нерекурсивный поиск), или пустой массив типа <see cref="T:System.Type" />, если вложенные типы, удовлетворяющие ограничениям привязки, не найдены.</returns>
		// Token: 0x0600118E RID: 4494
		public abstract Type[] GetNestedTypes(BindingFlags bindingAttr);

		/// <summary>Выполняет поиск открытого свойства с заданным именем.</summary>
		/// <param name="name">Строка, содержащая искомое имя открытого свойства.</param>
		/// <returns>Объект, представляющий открытое свойство с заданным именем, если такое свойство есть, и <see langword="null" />, если такого свойства нет.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Найдено несколько свойств с указанным именем.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.</exception>
		// Token: 0x0600118F RID: 4495 RVA: 0x000476D4 File Offset: 0x000458D4
		public PropertyInfo GetProperty(string name)
		{
			return this.GetProperty(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		/// <summary>Ищет указанное свойство, используя заданные ограничения привязки.</summary>
		/// <param name="name">Строка, содержащий имя искомого свойства.</param>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <returns>Объект, предоставляющий свойство, которое соответствует указанным требованиям, если такое свойство найдено; в противном случае возвращается <see langword="null" />.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Найдено несколько свойств с указанным именем, соответствующих указанным ограничениям привязки.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.</exception>
		// Token: 0x06001190 RID: 4496 RVA: 0x000476DF File Offset: 0x000458DF
		public PropertyInfo GetProperty(string name, BindingFlags bindingAttr)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			return this.GetPropertyImpl(name, bindingAttr, null, null, null, null);
		}

		/// <summary>Выполняет поиск открытого свойства с заданным именем и типом возвращаемого значения.</summary>
		/// <param name="name">Строка, содержащая искомое имя открытого свойства.</param>
		/// <param name="returnType">Тип возвращаемого значения свойства.</param>
		/// <returns>Объект, представляющий открытое свойство с заданным именем, если такое свойство есть, и <see langword="null" />, если такого свойства нет.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Найдено несколько свойств с указанным именем.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> имеет значение <see langword="null" />, или <paramref name="returnType" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001191 RID: 4497 RVA: 0x000476FB File Offset: 0x000458FB
		public PropertyInfo GetProperty(string name, Type returnType)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (returnType == null)
			{
				throw new ArgumentNullException("returnType");
			}
			return this.GetPropertyImpl(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public, null, returnType, null, null);
		}

		/// <summary>Ищет указанное открытое свойство, параметры которого соответствуют указанным типам аргументов.</summary>
		/// <param name="name">Строка, содержащая искомое имя открытого свойства.</param>
		/// <param name="types">Массив объектов <see cref="T:System.Type" />, предоставляющий число, порядок и тип параметров искомого индексированного свойства.  
		/// -или- 
		/// Пустой массив объектов типа <see cref="T:System.Type" /> (то есть Type[] types = new Type[0]), если требуется получить неиндексированное свойство.</param>
		/// <returns>Объект, представляющий открытое свойство, аргументы которого соответствуют указанным условиям, если такое свойство существует, и <see langword="null" />, если такого свойства нет.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Найдено несколько свойств с указанным именем и соответствующих указанным типам аргументов.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="types" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="types" /> является многомерным.</exception>
		/// <exception cref="T:System.NullReferenceException">Элемент <paramref name="types" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001192 RID: 4498 RVA: 0x0004772C File Offset: 0x0004592C
		public PropertyInfo GetProperty(string name, Type[] types)
		{
			return this.GetProperty(name, null, types);
		}

		/// <summary>Ищет указанное открытое свойство, параметры которого соответствуют указанным типам аргументов.</summary>
		/// <param name="name">Строка, содержащая искомое имя открытого свойства.</param>
		/// <param name="returnType">Тип возвращаемого значения свойства.</param>
		/// <param name="types">Массив объектов <see cref="T:System.Type" />, предоставляющий число, порядок и тип параметров искомого индексированного свойства.  
		/// -или- 
		/// Пустой массив объектов типа <see cref="T:System.Type" /> (то есть Type[] types = new Type[0]), если требуется получить неиндексированное свойство.</param>
		/// <returns>Объект, представляющий открытое свойство, аргументы которого соответствуют указанным условиям, если такое свойство существует, и <see langword="null" />, если такого свойства нет.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Найдено несколько свойств с указанным именем и соответствующих указанным типам аргументов.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="types" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="types" /> является многомерным.</exception>
		/// <exception cref="T:System.NullReferenceException">Элемент <paramref name="types" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001193 RID: 4499 RVA: 0x00047737 File Offset: 0x00045937
		public PropertyInfo GetProperty(string name, Type returnType, Type[] types)
		{
			return this.GetProperty(name, returnType, types, null);
		}

		/// <summary>Ищет заданное открытое свойство, параметры которого соответствуют указанным типам аргументов и модификаторам.</summary>
		/// <param name="name">Строка, содержащая искомое имя открытого свойства.</param>
		/// <param name="returnType">Тип возвращаемого значения свойства.</param>
		/// <param name="types">Массив объектов <see cref="T:System.Type" />, предоставляющий число, порядок и тип параметров искомого индексированного свойства.  
		/// -или- 
		/// Пустой массив объектов типа <see cref="T:System.Type" /> (то есть Type[] types = new Type[0]), если требуется получить неиндексированное свойство.</param>
		/// <param name="modifiers">Массив объектов <see cref="T:System.Reflection.ParameterModifier" />, представляющих атрибуты, связанные с соответствующим элементом в массиве <paramref name="types" />. Связыватель по умолчанию не обрабатывает этот параметр.</param>
		/// <returns>Объект, представляющий открытое свойство, которое соответствует указанным требованиям, если такое свойство найдено; в противном случае возвращается <see langword="null" />.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Найдено несколько свойств с указанным именем и соответствующих указанным типам аргументов и модификаторам.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="types" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="types" /> является многомерным.  
		/// -или- 
		///  Массив <paramref name="modifiers" /> является многомерным.  
		/// -или- 
		///  <paramref name="types" /> и <paramref name="modifiers" /> имеют разную длину.</exception>
		/// <exception cref="T:System.NullReferenceException">Элемент <paramref name="types" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001194 RID: 4500 RVA: 0x00047743 File Offset: 0x00045943
		public PropertyInfo GetProperty(string name, Type returnType, Type[] types, ParameterModifier[] modifiers)
		{
			return this.GetProperty(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public, null, returnType, types, modifiers);
		}

		/// <summary>Ищет свойство с параметрами, соответствующими указанным модификаторам и типам аргументов, с учетом заданных ограничений привязки.</summary>
		/// <param name="name">Строка, содержащий имя искомого свойства.</param>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <param name="binder">Объект, определяющий набор свойств и разрешающий привязку, что может включать выбор перегруженных методов, приведение типов аргументов и вызов члена с помощью отражения.  
		/// -или- 
		/// Пустая ссылка (<see langword="Nothing" /> в Visual Basic) для использования свойства <see cref="P:System.Type.DefaultBinder" />.</param>
		/// <param name="returnType">Тип возвращаемого значения свойства.</param>
		/// <param name="types">Массив объектов <see cref="T:System.Type" />, предоставляющий число, порядок и тип параметров искомого индексированного свойства.  
		/// -или- 
		/// Пустой массив объектов типа <see cref="T:System.Type" /> (то есть Type[] types = new Type[0]), если требуется получить неиндексированное свойство.</param>
		/// <param name="modifiers">Массив объектов <see cref="T:System.Reflection.ParameterModifier" />, представляющих атрибуты, связанные с соответствующим элементом в массиве <paramref name="types" />. Связыватель по умолчанию не обрабатывает этот параметр.</param>
		/// <returns>Объект, предоставляющий свойство, которое соответствует указанным требованиям, если такое свойство найдено; в противном случае возвращается <see langword="null" />.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Найдено несколько свойств с указанным именем, соответствующих указанным ограничениям привязки.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="types" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="types" /> является многомерным.  
		/// -или- 
		///  Массив <paramref name="modifiers" /> является многомерным.  
		/// -или- 
		///  <paramref name="types" /> и <paramref name="modifiers" /> имеют разную длину.</exception>
		/// <exception cref="T:System.NullReferenceException">Элемент <paramref name="types" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001195 RID: 4501 RVA: 0x00047753 File Offset: 0x00045953
		public PropertyInfo GetProperty(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (types == null)
			{
				throw new ArgumentNullException("types");
			}
			return this.GetPropertyImpl(name, bindingAttr, binder, returnType, types, modifiers);
		}

		/// <summary>При переопределении в производном классе выполняет поиск заданного свойства, параметры которого соответствуют типам и модификаторам заданных аргументов, с использованием заданных ограничений привязки.</summary>
		/// <param name="name">Строка, содержащий имя искомого свойства.</param>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <param name="binder">Объект, определяющий набор свойств и разрешающий привязку, что может включать выбор перегруженного члена, приведение типов аргументов и вызов члена с помощью отражения.  
		/// -или- 
		/// Пустая ссылка (<see langword="Nothing" /> в Visual Basic) для использования свойства <see cref="P:System.Type.DefaultBinder" />.</param>
		/// <param name="returnType">Тип возвращаемого значения свойства.</param>
		/// <param name="types">Массив объектов <see cref="T:System.Type" />, предоставляющий число, порядок и тип параметров искомого индексированного свойства.  
		/// -или- 
		/// Пустой массив объектов типа <see cref="T:System.Type" /> (то есть Type[] types = new Type[0]), если требуется получить неиндексированное свойство.</param>
		/// <param name="modifiers">Массив объектов <see cref="T:System.Reflection.ParameterModifier" />, представляющих атрибуты, связанные с соответствующим элементом в массиве <paramref name="types" />. Связыватель по умолчанию не обрабатывает этот параметр.</param>
		/// <returns>Объект, предоставляющий свойство, которое соответствует указанным требованиям, если такое свойство найдено; в противном случае возвращается <see langword="null" />.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Найдено несколько свойств с указанным именем, соответствующих указанным ограничениям привязки.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="types" /> — <see langword="null" />.  
		/// -или- 
		/// Один из элементов в <paramref name="types" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="types" /> является многомерным.  
		/// -или- 
		///  Массив <paramref name="modifiers" /> является многомерным.  
		/// -или- 
		///  <paramref name="types" /> и <paramref name="modifiers" /> имеют разную длину.</exception>
		/// <exception cref="T:System.NotSupportedException">Текущий тип — <see cref="T:System.Reflection.Emit.TypeBuilder" />, <see cref="T:System.Reflection.Emit.EnumBuilder" /> или <see cref="T:System.Reflection.Emit.GenericTypeParameterBuilder" />.</exception>
		// Token: 0x06001196 RID: 4502
		protected abstract PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers);

		/// <summary>Возвращает все открытые свойства текущего объекта <see cref="T:System.Type" />.</summary>
		/// <returns>Массив объектов <see cref="T:System.Reflection.PropertyInfo" />, представляющий все открытые свойства текущего типа <see cref="T:System.Type" />.  
		/// -или- 
		/// Пустой массив типа <see cref="T:System.Reflection.PropertyInfo" />, если у текущего типа <see cref="T:System.Type" /> нет открытых свойств.</returns>
		// Token: 0x06001197 RID: 4503 RVA: 0x00047781 File Offset: 0x00045981
		public PropertyInfo[] GetProperties()
		{
			return this.GetProperties(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		/// <summary>При переопределении в производном классе ищет свойства текущего объекта <see cref="T:System.Type" />, используя указанные ограничения привязки.</summary>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <returns>Массив объектов <see cref="T:System.Reflection.PropertyInfo" />, представляющий все свойства текущего типа <see cref="T:System.Type" />, которые удовлетворяют указанным ограничениям привязки.  
		/// -или- 
		/// Пустой массив типа <see cref="T:System.Reflection.PropertyInfo" />, если у текущего типа <see cref="T:System.Type" /> нет свойств или ни одно свойство не удовлетворяет ограничениям привязки.</returns>
		// Token: 0x06001198 RID: 4504
		public abstract PropertyInfo[] GetProperties(BindingFlags bindingAttr);

		/// <summary>Выполняет поиск членов, определенных для текущего объекта <see cref="T:System.Type" />, для которого задан атрибут <see cref="T:System.Reflection.DefaultMemberAttribute" />.</summary>
		/// <returns>Массив объектов <see cref="T:System.Reflection.MemberInfo" />, представляющий все члены по умолчанию текущего объекта <see cref="T:System.Type" />.  
		/// -или- 
		/// Пустой массив типа <see cref="T:System.Reflection.MemberInfo" />, если у текущего типа <see cref="T:System.Type" /> нет членов по умолчанию.</returns>
		// Token: 0x06001199 RID: 4505 RVA: 0x00047226 File Offset: 0x00045426
		public virtual MemberInfo[] GetDefaultMembers()
		{
			throw NotImplemented.ByDesign;
		}

		/// <summary>Возвращает дескриптор текущего объекта <see cref="T:System.Type" />.</summary>
		/// <returns>Дескриптор текущего объекта <see cref="T:System.Type" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Платформа .NET Compact Framework в настоящее время не поддерживает это свойство.</exception>
		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x0600119A RID: 4506 RVA: 0x000472C8 File Offset: 0x000454C8
		public virtual RuntimeTypeHandle TypeHandle
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		/// <summary>Возвращает дескриптор <see cref="T:System.Type" /> для указанного объекта.</summary>
		/// <param name="o">Объект, для которого требуется получить дескриптор типа.</param>
		/// <returns>Дескриптор типа <see cref="T:System.Type" /> для указанного объекта <see cref="T:System.Object" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="o" /> — <see langword="null" />.</exception>
		// Token: 0x0600119B RID: 4507 RVA: 0x0004778B File Offset: 0x0004598B
		public static RuntimeTypeHandle GetTypeHandle(object o)
		{
			if (o == null)
			{
				throw new ArgumentNullException(null, "Invalid handle.");
			}
			return o.GetType().TypeHandle;
		}

		/// <summary>Возвращает типы объектов в указанном массиве.</summary>
		/// <param name="args">Массив объектов, типы которых нужно определить.</param>
		/// <returns>Массив объектов <see cref="T:System.Type" />, представляющих типы соответствующих элементов в массиве <paramref name="args" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="args" /> — <see langword="null" />.  
		/// -или- 
		/// Один или несколько элементов в <paramref name="args" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Вызываются инициализаторы класса, и по крайней мере один из них создает исключение.</exception>
		// Token: 0x0600119C RID: 4508 RVA: 0x000477A8 File Offset: 0x000459A8
		public static Type[] GetTypeArray(object[] args)
		{
			if (args == null)
			{
				throw new ArgumentNullException("args");
			}
			Type[] array = new Type[args.Length];
			for (int i = 0; i < array.Length; i++)
			{
				if (args[i] == null)
				{
					throw new ArgumentNullException();
				}
				array[i] = args[i].GetType();
			}
			return array;
		}

		/// <summary>Возвращает код базового типа указанного объекта <see cref="T:System.Type" />.</summary>
		/// <param name="type">Тип, код базового типа которого требуется получить.</param>
		/// <returns>Код базового типа или <see cref="F:System.TypeCode.Empty" />, если <paramref name="type" /> — <see langword="null" />.</returns>
		// Token: 0x0600119D RID: 4509 RVA: 0x000477F1 File Offset: 0x000459F1
		public static TypeCode GetTypeCode(Type type)
		{
			if (type == null)
			{
				return TypeCode.Empty;
			}
			return type.GetTypeCodeImpl();
		}

		/// <summary>Возвращает код базового типа этого экземпляра <see cref="T:System.Type" />.</summary>
		/// <returns>Код типа базового типа.</returns>
		// Token: 0x0600119E RID: 4510 RVA: 0x00047804 File Offset: 0x00045A04
		protected virtual TypeCode GetTypeCodeImpl()
		{
			if (this != this.UnderlyingSystemType && this.UnderlyingSystemType != null)
			{
				return Type.GetTypeCode(this.UnderlyingSystemType);
			}
			return TypeCode.Object;
		}

		/// <summary>Возвращает идентификатор GUID, связанный с объектом <see cref="T:System.Type" />.</summary>
		/// <returns>Идентификатор GUID, связанный с объектом <see cref="T:System.Type" />.</returns>
		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x0600119F RID: 4511
		public abstract Guid GUID { get; }

		/// <summary>Возвращает тип, связанный с заданным кодом CLSID.</summary>
		/// <param name="clsid">Код CLSID извлекаемого типа.</param>
		/// <returns>
		///   <see langword="System.__ComObject" /> вне зависимости от того, допустим ли код CLSID.</returns>
		// Token: 0x060011A0 RID: 4512 RVA: 0x0004782F File Offset: 0x00045A2F
		public static Type GetTypeFromCLSID(Guid clsid)
		{
			return Type.GetTypeFromCLSID(clsid, null, false);
		}

		/// <summary>Возвращает тип, связанный с заданным кодом CLSID, позволяющий определить, будет ли выбрасываться исключение в случае происхождения ошибки при загрузке типа.</summary>
		/// <param name="clsid">Код CLSID извлекаемого типа.</param>
		/// <param name="throwOnError">Значение <see langword="true" /> для вызова любого возникшего исключения.  
		/// -или- 
		///  Значение <see langword="false" /> для игнорирования всех происходящих исключений.</param>
		/// <returns>
		///   <see langword="System.__ComObject" /> вне зависимости от того, допустим ли код CLSID.</returns>
		// Token: 0x060011A1 RID: 4513 RVA: 0x00047839 File Offset: 0x00045A39
		public static Type GetTypeFromCLSID(Guid clsid, bool throwOnError)
		{
			return Type.GetTypeFromCLSID(clsid, null, throwOnError);
		}

		/// <summary>Возвращает с указанного сервера тип, связанный с заданным кодом CLSID.</summary>
		/// <param name="clsid">Код CLSID извлекаемого типа.</param>
		/// <param name="server">Сервер, с которого должен быть загружен тип. Если в качестве имени сервера задано значение <see langword="null" />, этот метод автоматически перейдет к поиску на локальном компьютере.</param>
		/// <returns>
		///   <see langword="System.__ComObject" /> вне зависимости от того, допустим ли код CLSID.</returns>
		// Token: 0x060011A2 RID: 4514 RVA: 0x00047843 File Offset: 0x00045A43
		public static Type GetTypeFromCLSID(Guid clsid, string server)
		{
			return Type.GetTypeFromCLSID(clsid, server, false);
		}

		/// <summary>Возвращает тип, связанный с указанным идентификатором ProgID, и возвращает значение NULL, если при загрузке объекта <see cref="T:System.Type" /> возникла ошибка.</summary>
		/// <param name="progID">Идентификатор ProgID извлекаемого типа.</param>
		/// <returns>Тип, связанный с указанным идентификатором ProgID, если идентификатор <paramref name="progID" /> является допустимой записью в реестре и с ним связан определенный тип; в противном случае — значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="progID" /> — <see langword="null" />.</exception>
		// Token: 0x060011A3 RID: 4515 RVA: 0x0004784D File Offset: 0x00045A4D
		public static Type GetTypeFromProgID(string progID)
		{
			return Type.GetTypeFromProgID(progID, null, false);
		}

		/// <summary>Возвращает тип, связанный с заданным идентификатором ProgID, позволяющим определить, будет ли выбрасываться исключение при происхождении ошибки во время загрузки типа.</summary>
		/// <param name="progID">Идентификатор ProgID извлекаемого типа.</param>
		/// <param name="throwOnError">Значение <see langword="true" /> для вызова любого возникшего исключения.  
		/// -или- 
		///  Значение <see langword="false" /> для игнорирования всех происходящих исключений.</param>
		/// <returns>Тип, связанный с указанным идентификатором ProgID, если идентификатор <paramref name="progID" /> является допустимой записью в реестре и с ним связан определенный тип; в противном случае — значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="progID" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Указанный идентификатор ProgID не зарегистрирован.</exception>
		// Token: 0x060011A4 RID: 4516 RVA: 0x00047857 File Offset: 0x00045A57
		public static Type GetTypeFromProgID(string progID, bool throwOnError)
		{
			return Type.GetTypeFromProgID(progID, null, throwOnError);
		}

		/// <summary>Возвращает с указанного сервера тип, связанный с заданным идентификатором ProgID, и возвращает значение NULL, если при загрузке типа произошла ошибка.</summary>
		/// <param name="progID">Идентификатор ProgID извлекаемого типа.</param>
		/// <param name="server">Сервер, с которого должен быть загружен тип. Если в качестве имени сервера задано значение <see langword="null" />, этот метод автоматически перейдет к поиску на локальном компьютере.</param>
		/// <returns>Тип, связанный с заданным идентификатором ProgID, если идентификатор <paramref name="progID" /> является допустимой записью в реестре и с ним связан определенный тип; в противном случае — значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="prodID" /> — <see langword="null" />.</exception>
		// Token: 0x060011A5 RID: 4517 RVA: 0x00047861 File Offset: 0x00045A61
		public static Type GetTypeFromProgID(string progID, string server)
		{
			return Type.GetTypeFromProgID(progID, server, false);
		}

		/// <summary>Возвращает тип, для которого текущий объект <see cref="T:System.Type" /> является непосредственным наследником.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, прямым наследником которого является текущий объект <see cref="T:System.Type" />, или <see langword="null" />, если текущий объект <see langword="Type" /> представляет класс <see cref="T:System.Object" /> или интерфейс.</returns>
		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060011A6 RID: 4518
		public abstract Type BaseType { get; }

		/// <summary>Вызывает указанный член, соответствующий заданным ограничениям привязки и указанному списку аргументов.</summary>
		/// <param name="name">Строка, содержащая имя вызываемого элемента — конструктора, метода, свойства или поля.  
		/// -или- 
		/// Пустая строка ("") — в этом случае будет вызван член по умолчанию.  
		/// -или- 
		/// Для членов <see langword="IDispatch" /> — строка, представляющая идентификатор DispID, например "[DispID=3]".</param>
		/// <param name="invokeAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск. Тип доступа может быть обозначен одним из флагов <see langword="BindingFlags" />, например <see langword="Public" />, <see langword="NonPublic" />, <see langword="Private" />, <see langword="InvokeMethod" />, <see langword="GetField" /> и т.д. Тип поиска указывать необязательно. Если тип поиска не указан, используются флаги <see langword="BindingFlags.Public" /> | <see langword="BindingFlags.Instance" /> | <see langword="BindingFlags.Static" />.</param>
		/// <param name="binder">Объект, определяющий набор свойств и разрешающий привязку, что может включать выбор перегруженных методов, приведение типов аргументов и вызов члена с помощью отражения.  
		/// -или- 
		/// Пустая ссылка (<see langword="Nothing" /> в Visual Basic) для использования свойства <see cref="P:System.Type.DefaultBinder" />. Обратите внимание, что для успешного вызова перегруженных версий метода с переменными аргументами может потребоваться явное объявление объекта <see cref="T:System.Reflection.Binder" />.</param>
		/// <param name="target">Объект, для которого следует вызвать указанный член.</param>
		/// <param name="args">Массив с аргументами, передаваемыми вызываемому члену.</param>
		/// <returns>Объект, представляющий возвращаемое значение вызываемого элемента.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="invokeAttr" /> не содержит <see langword="CreateInstance" />, а <paramref name="name" /> равно <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="invokeAttr" /> не является допустимым атрибутом <see cref="T:System.Reflection.BindingFlags" />.  
		/// -или- 
		///  <paramref name="invokeAttr" /> не содержит одного из следующих флагов привязки: <see langword="InvokeMethod" />, <see langword="CreateInstance" />, <see langword="GetField" />, <see langword="SetField" />, <see langword="GetProperty" /> или <see langword="SetProperty" />.  
		/// -или- 
		///  <paramref name="invokeAttr" /> содержит <see langword="CreateInstance" /> в сочетании с <see langword="InvokeMethod" />, <see langword="GetField" />, <see langword="SetField" />, <see langword="GetProperty" /> или <see langword="SetProperty" />.  
		/// -или- 
		///  <paramref name="invokeAttr" /> содержит как <see langword="GetField" />, так и <see langword="SetField" />.  
		/// -или- 
		///  <paramref name="invokeAttr" /> содержит как <see langword="GetProperty" />, так и <see langword="SetProperty" />.  
		/// -или- 
		///  <paramref name="invokeAttr" /> содержит <see langword="InvokeMethod" /> в сочетании с <see langword="SetField" /> или <see langword="SetProperty" />.  
		/// -или- 
		///  <paramref name="invokeAttr" /> содержит <see langword="SetField" />, а <paramref name="args" /> содержит более одного элемента.  
		/// -или- 
		/// Этот метод вызывается для объекта COM, и один из следующих флагов привязки не был передан: <see langword="BindingFlags.InvokeMethod" />, <see langword="BindingFlags.GetProperty" />, <see langword="BindingFlags.SetProperty" />, <see langword="BindingFlags.PutDispProperty" /> или <see langword="BindingFlags.PutRefDispProperty" />.  
		/// -или- 
		/// Один из массивов именованных параметров содержит строку, имеющую значение <see langword="null" />.</exception>
		/// <exception cref="T:System.MethodAccessException">Указанный член является инициализатором класса.</exception>
		/// <exception cref="T:System.MissingFieldException">Невозможно найти поле или свойство.</exception>
		/// <exception cref="T:System.MissingMethodException">Невозможно найти метод, который соответствует аргументам в <paramref name="args" />.  
		/// -или- 
		/// Текущий объект <see cref="T:System.Type" /> представляет тип, содержащий параметры открытого типа, то есть <see cref="P:System.Type.ContainsGenericParameters" /> возвращает <see langword="true" />.</exception>
		/// <exception cref="T:System.Reflection.TargetException">Невозможно вызвать указанный член для <paramref name="target" />.</exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Несколько методов соответствуют критериям привязки.</exception>
		/// <exception cref="T:System.NotSupportedException">Платформа .NET Compact Framework сейчас не поддерживает этот метод.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод, представленный <paramref name="name" />, имеет один или несколько незаданных параметров универсального типа. То есть свойство <see cref="P:System.Reflection.MethodInfo.ContainsGenericParameters" /> метода возвращает <see langword="true" />.</exception>
		// Token: 0x060011A7 RID: 4519 RVA: 0x0004786C File Offset: 0x00045A6C
		[DebuggerHidden]
		[DebuggerStepThrough]
		public object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args)
		{
			return this.InvokeMember(name, invokeAttr, binder, target, args, null, null, null);
		}

		/// <summary>Вызывает указанный член, соответствующий заданным ограничениям привязки, списку аргументов, а также языку и региональным параметрам.</summary>
		/// <param name="name">Строка, содержащая имя вызываемого элемента — конструктора, метода, свойства или поля.  
		/// -или- 
		/// Пустая строка ("") — в этом случае будет вызван член по умолчанию.  
		/// -или- 
		/// Для членов <see langword="IDispatch" /> — строка, представляющая идентификатор DispID, например "[DispID=3]".</param>
		/// <param name="invokeAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск. Тип доступа может быть обозначен одним из флагов <see langword="BindingFlags" />, например <see langword="Public" />, <see langword="NonPublic" />, <see langword="Private" />, <see langword="InvokeMethod" />, <see langword="GetField" /> и т.д. Тип поиска указывать необязательно. Если тип поиска не указан, используются флаги <see langword="BindingFlags.Public" /> | <see langword="BindingFlags.Instance" /> | <see langword="BindingFlags.Static" />.</param>
		/// <param name="binder">Объект, определяющий набор свойств и разрешающий привязку, что может включать выбор перегруженных методов, приведение типов аргументов и вызов члена с помощью отражения.  
		/// -или- 
		/// Пустая ссылка (<see langword="Nothing" /> в Visual Basic) для использования свойства <see cref="P:System.Type.DefaultBinder" />. Обратите внимание, что для успешного вызова перегруженных версий метода с переменными аргументами может потребоваться явное объявление объекта <see cref="T:System.Reflection.Binder" />.</param>
		/// <param name="target">Объект, для которого следует вызвать указанный член.</param>
		/// <param name="args">Массив с аргументами, передаваемыми вызываемому члену.</param>
		/// <param name="culture">Объект, представляющий используемые языковые стандарты глобализации. Его задание может понадобиться для выполнения преобразований, зависящих от языкового стандарта, например преобразования числовой строки <see cref="T:System.String" /> к типу <see cref="T:System.Double" />.  
		/// -или- 
		/// Пустая ссылка (<see langword="Nothing" /> в Visual Basic) для использования объекта <see cref="T:System.Globalization.CultureInfo" /> текущего потока.</param>
		/// <returns>Объект, представляющий возвращаемое значение вызываемого элемента.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="invokeAttr" /> не содержит <see langword="CreateInstance" />, а <paramref name="name" /> равно <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="invokeAttr" /> не является допустимым атрибутом <see cref="T:System.Reflection.BindingFlags" />.  
		/// -или- 
		///  <paramref name="invokeAttr" /> не содержит одного из следующих флагов привязки: <see langword="InvokeMethod" />, <see langword="CreateInstance" />, <see langword="GetField" />, <see langword="SetField" />, <see langword="GetProperty" /> или <see langword="SetProperty" />.  
		/// -или- 
		///  <paramref name="invokeAttr" /> содержит <see langword="CreateInstance" /> в сочетании с <see langword="InvokeMethod" />, <see langword="GetField" />, <see langword="SetField" />, <see langword="GetProperty" /> или <see langword="SetProperty" />.  
		/// -или- 
		///  <paramref name="invokeAttr" /> содержит как <see langword="GetField" />, так и <see langword="SetField" />.  
		/// -или- 
		///  <paramref name="invokeAttr" /> содержит как <see langword="GetProperty" />, так и <see langword="SetProperty" />.  
		/// -или- 
		///  <paramref name="invokeAttr" /> содержит <see langword="InvokeMethod" /> в сочетании с <see langword="SetField" /> или <see langword="SetProperty" />.  
		/// -или- 
		///  <paramref name="invokeAttr" /> содержит <see langword="SetField" />, а <paramref name="args" /> содержит более одного элемента.  
		/// -или- 
		/// Этот метод вызывается для объекта COM, и один из следующих флагов привязки не был передан: <see langword="BindingFlags.InvokeMethod" />, <see langword="BindingFlags.GetProperty" />, <see langword="BindingFlags.SetProperty" />, <see langword="BindingFlags.PutDispProperty" /> или <see langword="BindingFlags.PutRefDispProperty" />.  
		/// -или- 
		/// Один из массивов именованных параметров содержит строку, имеющую значение <see langword="null" />.</exception>
		/// <exception cref="T:System.MethodAccessException">Указанный член является инициализатором класса.</exception>
		/// <exception cref="T:System.MissingFieldException">Невозможно найти поле или свойство.</exception>
		/// <exception cref="T:System.MissingMethodException">Невозможно найти метод, который соответствует аргументам в <paramref name="args" />.  
		/// -или- 
		/// Текущий объект <see cref="T:System.Type" /> представляет тип, содержащий параметры открытого типа, то есть <see cref="P:System.Type.ContainsGenericParameters" /> возвращает <see langword="true" />.</exception>
		/// <exception cref="T:System.Reflection.TargetException">Невозможно вызвать указанный член для <paramref name="target" />.</exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Несколько методов соответствуют критериям привязки.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод, представленный <paramref name="name" />, имеет один или несколько незаданных параметров универсального типа. То есть свойство <see cref="P:System.Reflection.MethodInfo.ContainsGenericParameters" /> метода возвращает <see langword="true" />.</exception>
		// Token: 0x060011A8 RID: 4520 RVA: 0x0004788C File Offset: 0x00045A8C
		[DebuggerHidden]
		[DebuggerStepThrough]
		public object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, CultureInfo culture)
		{
			return this.InvokeMember(name, invokeAttr, binder, target, args, null, culture, null);
		}

		/// <summary>При переопределении в производном классе вызывает указанный член, соответствующий заданным ограничениям привязки, списку аргументов, модификаторов, а также языку и региональным параметрам.</summary>
		/// <param name="name">Строка, содержащая имя вызываемого элемента — конструктора, метода, свойства или поля.  
		/// -или- 
		/// Пустая строка ("") — в этом случае будет вызван член по умолчанию.  
		/// -или- 
		/// Для членов <see langword="IDispatch" /> — строка, представляющая идентификатор DispID, например "[DispID=3]".</param>
		/// <param name="invokeAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск. Тип доступа может быть обозначен одним из флагов <see langword="BindingFlags" />, например <see langword="Public" />, <see langword="NonPublic" />, <see langword="Private" />, <see langword="InvokeMethod" />, <see langword="GetField" /> и т.д. Тип поиска указывать необязательно. Если тип поиска не указан, используются флаги <see langword="BindingFlags.Public" /> | <see langword="BindingFlags.Instance" /> | <see langword="BindingFlags.Static" />.</param>
		/// <param name="binder">Объект, определяющий набор свойств и разрешающий привязку, что может включать выбор перегруженных методов, приведение типов аргументов и вызов члена с помощью отражения.  
		/// -или- 
		/// Пустая ссылка (Nothing в Visual Basic) для использования свойства <see cref="P:System.Type.DefaultBinder" />. Обратите внимание, что для успешного вызова перегруженных версий метода с переменными аргументами может потребоваться явное объявление объекта <see cref="T:System.Reflection.Binder" />.</param>
		/// <param name="target">Объект, для которого следует вызвать указанный член.</param>
		/// <param name="args">Массив с аргументами, передаваемыми вызываемому члену.</param>
		/// <param name="modifiers">Массив объектов <see cref="T:System.Reflection.ParameterModifier" />, представляющих атрибуты, связанные с соответствующим элементом в массиве <paramref name="args" />. Атрибуты, связанные с параметром, хранятся в сигнатуре члена.  
		/// Связыватель по умолчанию обрабатывает этот параметр только при вызове COM-компонента.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, представляющий используемый языковой стандарт глобализации. Он может понадобиться для выполнения преобразований, зависящих от языкового стандарта, например приведения числа в строковом формате к типу Double.  
		/// -или- 
		/// Пустая ссылка (<see langword="Nothing" /> в Visual Basic) для использования объекта <see cref="T:System.Globalization.CultureInfo" /> текущего потока.</param>
		/// <param name="namedParameters">Массив, содержащий имена параметров, в которые передаются значения элементов массива <paramref name="args" />.</param>
		/// <returns>Объект, представляющий возвращаемое значение вызываемого элемента.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="invokeAttr" /> не содержит <see langword="CreateInstance" />, а <paramref name="name" /> равно <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="args" /> и <paramref name="modifiers" /> имеют разную длину.  
		/// -или- 
		///  <paramref name="invokeAttr" /> не является допустимым атрибутом <see cref="T:System.Reflection.BindingFlags" />.  
		/// -или- 
		///  <paramref name="invokeAttr" /> не содержит одного из следующих флагов привязки: <see langword="InvokeMethod" />, <see langword="CreateInstance" />, <see langword="GetField" />, <see langword="SetField" />, <see langword="GetProperty" /> или <see langword="SetProperty" />.  
		/// -или- 
		///  <paramref name="invokeAttr" /> содержит <see langword="CreateInstance" /> в сочетании с <see langword="InvokeMethod" />, <see langword="GetField" />, <see langword="SetField" />, <see langword="GetProperty" /> или <see langword="SetProperty" />.  
		/// -или- 
		///  <paramref name="invokeAttr" /> содержит как <see langword="GetField" />, так и <see langword="SetField" />.  
		/// -или- 
		///  <paramref name="invokeAttr" /> содержит как <see langword="GetProperty" />, так и <see langword="SetProperty" />.  
		/// -или- 
		///  <paramref name="invokeAttr" /> содержит <see langword="InvokeMethod" /> в сочетании с <see langword="SetField" /> или <see langword="SetProperty" />.  
		/// -или- 
		///  <paramref name="invokeAttr" /> содержит <see langword="SetField" />, а <paramref name="args" /> содержит более одного элемента.  
		/// -или- 
		/// Массив именованных параметров больше, чем массив аргументов.  
		/// -или- 
		/// Этот метод вызывается для объекта COM, и один из следующих флагов привязки не был передан: <see langword="BindingFlags.InvokeMethod" />, <see langword="BindingFlags.GetProperty" />, <see langword="BindingFlags.SetProperty" />, <see langword="BindingFlags.PutDispProperty" /> или <see langword="BindingFlags.PutRefDispProperty" />.  
		/// -или- 
		/// Один из массивов именованных параметров содержит строку, имеющую значение <see langword="null" />.</exception>
		/// <exception cref="T:System.MethodAccessException">Указанный член является инициализатором класса.</exception>
		/// <exception cref="T:System.MissingFieldException">Невозможно найти поле или свойство.</exception>
		/// <exception cref="T:System.MissingMethodException">Невозможно найти метод, который соответствует аргументам в <paramref name="args" />.  
		/// -или- 
		/// Невозможно найти члены с именами аргументов, указанными в <paramref name="namedParameters" />.  
		/// -или- 
		/// Текущий объект <see cref="T:System.Type" /> представляет тип, содержащий параметры открытого типа, то есть <see cref="P:System.Type.ContainsGenericParameters" /> возвращает <see langword="true" />.</exception>
		/// <exception cref="T:System.Reflection.TargetException">Невозможно вызвать указанный член для <paramref name="target" />.</exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Несколько методов соответствуют критериям привязки.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод, представленный <paramref name="name" />, имеет один или несколько незаданных параметров универсального типа. То есть свойство <see cref="P:System.Reflection.MethodInfo.ContainsGenericParameters" /> метода возвращает <see langword="true" />.</exception>
		// Token: 0x060011A9 RID: 4521
		public abstract object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters);

		/// <summary>Выполняет поиск интерфейса с заданным именем.</summary>
		/// <param name="name">Строка, содержащая имя искомого интерфейса. Для универсальных интерфейсов это искаженное имя.</param>
		/// <returns>Объект, представляющий интерфейс с заданным именем, который реализуется или наследуется текущим объектом <see cref="T:System.Type" />, если такой интерфейс существует; в противном случае — значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Текущий <see cref="T:System.Type" /> представляет тип, реализующий тот же универсальный интерфейс с другими аргументами типа.</exception>
		// Token: 0x060011AA RID: 4522 RVA: 0x000478AA File Offset: 0x00045AAA
		public Type GetInterface(string name)
		{
			return this.GetInterface(name, false);
		}

		/// <summary>При переопределении в производном классе ищет интерфейс с заданным именем, позволяющий определить, нужно ли выполнять поиск без учета регистра.</summary>
		/// <param name="name">Строка, содержащая имя искомого интерфейса. Для универсальных интерфейсов это искаженное имя.</param>
		/// <param name="ignoreCase">Значение <see langword="true" />, чтобы игнорировать регистр той части параметра <paramref name="name" />, в которой задается простое имя интерфейса (регистр части, соответствующей пространству имен, должен быть надлежащим образом соблюден).  
		/// -или- 
		///  Значение <see langword="false" />, для поиска с учетом регистра всех частей параметра <paramref name="name" />.</param>
		/// <returns>Объект, представляющий интерфейс с заданным именем, который реализуется или наследуется текущим объектом <see cref="T:System.Type" />, если такой интерфейс существует; в противном случае — значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Текущий <see cref="T:System.Type" /> представляет тип, реализующий тот же универсальный интерфейс с другими аргументами типа.</exception>
		// Token: 0x060011AB RID: 4523
		public abstract Type GetInterface(string name, bool ignoreCase);

		/// <summary>При переопределении в производном классе возвращает все интерфейсы, реализуемые или наследуемые текущим объектом <see cref="T:System.Type" />.</summary>
		/// <returns>Массив объектов <see cref="T:System.Type" />, представляющий все интерфейсы, реализуемые или наследуемые текущим типом <see cref="T:System.Type" />.  
		/// -или- 
		/// Пустой массив типа <see cref="T:System.Type" /> в случае отсутствия интерфейсов, реализуемых или наследуемых текущим типом <see cref="T:System.Type" />.</returns>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Статический инициализатор вызывается и создает исключение.</exception>
		// Token: 0x060011AC RID: 4524
		public abstract Type[] GetInterfaces();

		/// <summary>Возвращает сопоставление для интерфейса заданного типа.</summary>
		/// <param name="interfaceType">Тип интерфейса, для которого требуется извлечь сопоставление.</param>
		/// <returns>Объект, представляющий сопоставление интерфейса для <paramref name="interfaceType" />.</returns>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="interfaceType" /> не реализован с помощью текущего типа.  
		/// -или- 
		/// Аргумент <paramref name="interfaceType" /> не ссылается на интерфейс.  
		/// -или-
		/// Текущий экземпляр или аргумент <paramref name="interfaceType" /> является открытым универсальным типом (то есть свойство <see cref="P:System.Type.ContainsGenericParameters" /> возвращает <see langword="true" />).
		/// -или-
		///  <paramref name="interfaceType" /> является универсальным интерфейсом, а текущий тип является типом массива.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="interfaceType" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Текущий тип <see cref="T:System.Type" /> представляет параметр универсального типа, то есть <see cref="P:System.Type.IsGenericParameter" /> имеет значение <see langword="true" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Вызванный метод не поддерживается в базовом классе. Реализацию должны обеспечивать производные классы.</exception>
		// Token: 0x060011AD RID: 4525 RVA: 0x0004728A File Offset: 0x0004548A
		[ComVisible(true)]
		public virtual InterfaceMapping GetInterfaceMap(Type interfaceType)
		{
			throw new NotSupportedException("Derived classes must provide an implementation.");
		}

		/// <summary>Определяет, является ли указанный объект экземпляром текущего типа <see cref="T:System.Type" />.</summary>
		/// <param name="o">Объект, который требуется сравнить с текущим типом.</param>
		/// <returns>Значение <see langword="true" />, если текущий объект <see langword="Type" /> входит в иерархию наследования объекта, представленного параметром <paramref name="o" /> или если текущий объект <see langword="Type" /> является интерфейсом, реализуемым параметром <paramref name="o" />. Значение <see langword="false" />, если не выполняется ни одно из перечисленных условий, параметр <paramref name="o" /> имеет значение <see langword="null" /> или текущий объект <see langword="Type" /> является открытым универсальным типом (то есть свойство <see cref="P:System.Type.ContainsGenericParameters" /> возвращает значение <see langword="true" />).</returns>
		// Token: 0x060011AE RID: 4526 RVA: 0x000478B4 File Offset: 0x00045AB4
		public virtual bool IsInstanceOfType(object o)
		{
			return o != null && this.IsAssignableFrom(o.GetType());
		}

		/// <summary>Определяет, имеют ли два типа модели COM одинаковые удостоверения и могут ли они считаться эквивалентными.</summary>
		/// <param name="other">Тип модели COM, который проверяется на эквивалентность текущему типу.</param>
		/// <returns>Значение <see langword="true" />, если типы модели COM эквивалентны; в противном случае — значение <see langword="false" />. Этот метод также возвращает значение <see langword="false" />, если один тип находится в сборке, загружаемой для исполнения, а другой — в сборке, загружаемой в контекст, предназначенный только для отражения.</returns>
		// Token: 0x060011AF RID: 4527 RVA: 0x000478C7 File Offset: 0x00045AC7
		public virtual bool IsEquivalentTo(Type other)
		{
			return this == other;
		}

		/// <summary>Возвращает базовый тип текущего типа перечисления.</summary>
		/// <returns>Базовый тип текущего перечисления.</returns>
		/// <exception cref="T:System.ArgumentException">Текущий тип не является перечислением.  
		/// -или- 
		/// Тип перечисления не является допустимым, так как содержит более одного поля экземпляра.</exception>
		// Token: 0x060011B0 RID: 4528 RVA: 0x000478D0 File Offset: 0x00045AD0
		public virtual Type GetEnumUnderlyingType()
		{
			if (!this.IsEnum)
			{
				throw new ArgumentException("Type provided must be an Enum.", "enumType");
			}
			FieldInfo[] fields = this.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			if (fields == null || fields.Length != 1)
			{
				throw new ArgumentException("The Enum type should contain one and only one instance field.", "enumType");
			}
			return fields[0].FieldType;
		}

		/// <summary>Возвращает массив значений констант в текущем типе перечисления.</summary>
		/// <returns>Массив, содержащий значения. Элементы массива сортируются по двоичным значениям (то есть значениям без знака) констант перечисления.</returns>
		/// <exception cref="T:System.ArgumentException">Текущий тип не является перечислением.</exception>
		// Token: 0x060011B1 RID: 4529 RVA: 0x0004791F File Offset: 0x00045B1F
		public virtual Array GetEnumValues()
		{
			if (!this.IsEnum)
			{
				throw new ArgumentException("Type provided must be an Enum.", "enumType");
			}
			throw NotImplemented.ByDesign;
		}

		/// <summary>Возвращает объект <see cref="T:System.Type" />, представляющий одномерный массив текущего типа с нижней границей, равной нулю.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий одномерный массив текущего типа с нижней границей, равной нулю.</returns>
		/// <exception cref="T:System.NotSupportedException">Вызванный метод не поддерживается в базовом классе. Реализацию должны обеспечивать производные классы.</exception>
		/// <exception cref="T:System.TypeLoadException">Текущий тип — <see cref="T:System.TypedReference" />.  
		/// -или- 
		/// Текущий тип — <see langword="ByRef" />. То есть <see cref="P:System.Type.IsByRef" /> возвращает <see langword="true" />.</exception>
		// Token: 0x060011B2 RID: 4530 RVA: 0x000472C8 File Offset: 0x000454C8
		public virtual Type MakeArrayType()
		{
			throw new NotSupportedException();
		}

		/// <summary>Возвращает объект <see cref="T:System.Type" />, представляющий массив текущего типа указанной размерности.</summary>
		/// <param name="rank">Размерность массива. Это число должно быть меньше либо равно 32.</param>
		/// <returns>Объект, представляющий массив текущего типа указанной размерности.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">
		///   <paramref name="rank" /> недопустим. Например, 0 или отрицательное число.</exception>
		/// <exception cref="T:System.NotSupportedException">Вызванный метод не поддерживается в базовом классе.</exception>
		/// <exception cref="T:System.TypeLoadException">Текущий тип — <see cref="T:System.TypedReference" />.  
		/// -или- 
		/// Текущий тип — <see langword="ByRef" />. То есть <see cref="P:System.Type.IsByRef" /> возвращает <see langword="true" />.  
		/// -или- 
		///  Значение <paramref name="rank" /> больше 32.</exception>
		// Token: 0x060011B3 RID: 4531 RVA: 0x000472C8 File Offset: 0x000454C8
		public virtual Type MakeArrayType(int rank)
		{
			throw new NotSupportedException();
		}

		/// <summary>Возвращает объект <see cref="T:System.Type" />, который представляет текущий тип при передаче в качестве параметра <see langword="ref" /> (параметра <see langword="ByRef" /> в Visual Basic).</summary>
		/// <returns>Объект <see cref="T:System.Type" />, который представляет текущий тип при передаче в качестве параметра <see langword="ref" /> (параметра <see langword="ByRef" /> в Visual Basic).</returns>
		/// <exception cref="T:System.NotSupportedException">Вызванный метод не поддерживается в базовом классе.</exception>
		/// <exception cref="T:System.TypeLoadException">Текущий тип — <see cref="T:System.TypedReference" />.  
		/// -или- 
		/// Текущий тип — <see langword="ByRef" />. То есть <see cref="P:System.Type.IsByRef" /> возвращает <see langword="true" />.</exception>
		// Token: 0x060011B4 RID: 4532 RVA: 0x000472C8 File Offset: 0x000454C8
		public virtual Type MakeByRefType()
		{
			throw new NotSupportedException();
		}

		/// <summary>Замещает элементы массива типов для параметров определения текущего универсального типа и возвращает объект <see cref="T:System.Type" />, представляющий сконструированный результирующий тип.</summary>
		/// <param name="typeArguments">Массив типов, который должен быть замещен параметрами типа текущего универсального типа.</param>
		/// <returns>
		///   <see cref="T:System.Type" /> представляет сконструированный тип, сформированный путем замещения элементов объекта <paramref name="typeArguments" /> параметрами текущего универсального типа.</returns>
		/// <exception cref="T:System.InvalidOperationException">Текущий тип не представляет определение универсального типа. То есть <see cref="P:System.Type.IsGenericTypeDefinition" /> возвращает <see langword="false" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="typeArguments" /> — <see langword="null" />.  
		/// -или- 
		/// Любой элемент <paramref name="typeArguments" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Количество элементов в <paramref name="typeArguments" /> не совпадает с количеством параметров типа в текущем определении универсального типа.  
		/// -или- 
		/// Элементы <paramref name="typeArguments" /> не соответствуют ограничениям, указанным для соответствующего параметра типа текущего определения универсального типа.  
		/// -или- 
		///  <paramref name="typeArguments" /> содержит элемент, который является типом указателя (<see cref="P:System.Type.IsPointer" /> возвращает <see langword="true" />), типом доступа по ссылке (<see cref="P:System.Type.IsByRef" /> возвращает <see langword="true" />) или <see cref="T:System.Void" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Вызванный метод не поддерживается в базовом классе. Реализацию должны обеспечивать производные классы.</exception>
		// Token: 0x060011B5 RID: 4533 RVA: 0x0004728A File Offset: 0x0004548A
		public virtual Type MakeGenericType(params Type[] typeArguments)
		{
			throw new NotSupportedException("Derived classes must provide an implementation.");
		}

		/// <summary>Возвращает объект <see cref="T:System.Type" />, который представляет указатель на текущий тип.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, который представляет указатель на текущий тип.</returns>
		/// <exception cref="T:System.NotSupportedException">Вызванный метод не поддерживается в базовом классе.</exception>
		/// <exception cref="T:System.TypeLoadException">Текущий тип — <see cref="T:System.TypedReference" />.  
		/// -или- 
		/// Текущий тип — <see langword="ByRef" />. То есть <see cref="P:System.Type.IsByRef" /> возвращает <see langword="true" />.</exception>
		// Token: 0x060011B6 RID: 4534 RVA: 0x000472C8 File Offset: 0x000454C8
		public virtual Type MakePointerType()
		{
			throw new NotSupportedException();
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x0004793E File Offset: 0x00045B3E
		public static Type MakeGenericSignatureType(Type genericTypeDefinition, params Type[] typeArguments)
		{
			return new SignatureConstructedGenericType(genericTypeDefinition, typeArguments);
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x00047947 File Offset: 0x00045B47
		public static Type MakeGenericMethodParameter(int position)
		{
			if (position < 0)
			{
				throw new ArgumentException("Non-negative number required.", "position");
			}
			return new SignatureGenericMethodParameterType(position);
		}

		/// <summary>Возвращает объект типа <see langword="String" />, представляющий имя текущего объекта <see langword="Type" />.</summary>
		/// <returns>Объект типа <see cref="T:System.String" />, представляющий имя текущего объекта <see cref="T:System.Type" />.</returns>
		// Token: 0x060011B9 RID: 4537 RVA: 0x00047963 File Offset: 0x00045B63
		public override string ToString()
		{
			return "Type: " + this.Name;
		}

		/// <summary>Определяет, совпадает ли базовый системный тип текущего объекта <see cref="T:System.Type" /> с базовым системным типом указанного объекта <see cref="T:System.Object" />.</summary>
		/// <param name="o">Объект, базовый системный тип которого сравнивается с базовым системным типом текущего типа <see cref="T:System.Type" />. Для успешного сравнения необходимо, чтобы параметр <paramref name="o" /> можно было привести к объекту типа <see cref="T:System.Type" /> или преобразовать в объект такого типа.</param>
		/// <returns>Значение <see langword="true" />, если базовый системный тип параметра <paramref name="o" /> совпадает с базовым системным типом текущего объекта <see cref="T:System.Type" />; в противном случае — значение <see langword="false" />. Этот метод также возвращает <see langword="false" /> в следующих случаях:  
		///
		/// <paramref name="o" /> имеет значение <see langword="null" />.  
		///
		/// <paramref name="o" /> невозможно привести к объекту или преобразовать в объект <see cref="T:System.Type" />.</returns>
		// Token: 0x060011BA RID: 4538 RVA: 0x00047975 File Offset: 0x00045B75
		public override bool Equals(object o)
		{
			return o != null && this.Equals(o as Type);
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код данного экземпляра.</returns>
		// Token: 0x060011BB RID: 4539 RVA: 0x00047988 File Offset: 0x00045B88
		public override int GetHashCode()
		{
			Type underlyingSystemType = this.UnderlyingSystemType;
			if (underlyingSystemType != this)
			{
				return underlyingSystemType.GetHashCode();
			}
			return base.GetHashCode();
		}

		/// <summary>Позволяет определить, совпадает ли базовый системный тип текущего объекта <see cref="T:System.Type" /> с базовым системным типом указанного объекта <see cref="T:System.Type" />.</summary>
		/// <param name="o">Объект, базовый системный тип которого сравнивается с базовым системным типом текущего типа <see cref="T:System.Type" />.</param>
		/// <returns>Значение <see langword="true" />, если базовый системный тип параметра <paramref name="o" /> совпадает с базовым системным типом текущего объекта <see cref="T:System.Type" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060011BC RID: 4540 RVA: 0x000479AD File Offset: 0x00045BAD
		public virtual bool Equals(Type o)
		{
			return !(o == null) && this.UnderlyingSystemType == o.UnderlyingSystemType;
		}

		/// <summary>Возвращает ссылку на связыватель по умолчанию, который реализует внутренние правила выбора соответствующих членов, вызываемых методом <see cref="M:System.Type.InvokeMember(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object,System.Object[],System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[])" />.</summary>
		/// <returns>Ссылка на связыватель, используемый в системе по умолчанию.</returns>
		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060011BD RID: 4541 RVA: 0x000479C8 File Offset: 0x00045BC8
		public static Binder DefaultBinder
		{
			get
			{
				if (Type.s_defaultBinder == null)
				{
					DefaultBinder value = new DefaultBinder();
					Interlocked.CompareExchange<Binder>(ref Type.s_defaultBinder, value, null);
				}
				return Type.s_defaultBinder;
			}
		}

		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Переданный массив имен, которые необходимо сопоставить.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, зарезервированный вызывающим объектом, куда помещаются идентификаторы, соответствующие именам.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x060011BE RID: 4542 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _Type.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает сведения о типе объекта, которые затем могут использоваться для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Указатель на объект с запрошенными сведениями о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x060011BF RID: 4543 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _Type.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Указатель, по которому записывается число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x060011C0 RID: 4544 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _Type.GetTypeInfoCount(out uint pcTInfo)
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
		// Token: 0x060011C1 RID: 4545 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _Type.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x000479FF File Offset: 0x00045BFF
		internal virtual Type InternalResolve()
		{
			return this.UnderlyingSystemType;
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x000479F8 File Offset: 0x00045BF8
		internal virtual Type RuntimeResolve()
		{
			throw new NotImplementedException();
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060011C4 RID: 4548 RVA: 0x000040F7 File Offset: 0x000022F7
		internal virtual bool IsUserType
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x00047A07 File Offset: 0x00045C07
		internal virtual MethodInfo GetMethod(MethodInfo fromNoninstanciated)
		{
			throw new InvalidOperationException("can only be called in generic type");
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x00047A07 File Offset: 0x00045C07
		internal virtual ConstructorInfo GetConstructor(ConstructorInfo fromNoninstanciated)
		{
			throw new InvalidOperationException("can only be called in generic type");
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x00047A07 File Offset: 0x00045C07
		internal virtual FieldInfo GetField(FieldInfo fromNoninstanciated)
		{
			throw new InvalidOperationException("can only be called in generic type");
		}

		/// <summary>Возвращает тип, на который ссылается указанный дескриптор типа.</summary>
		/// <param name="handle">Объект, который ссылается на тип.</param>
		/// <returns>Тип, на который ссылается заданный дескриптор <see cref="T:System.RuntimeTypeHandle" />, или значение <see langword="null" />, если значение свойства <see cref="P:System.RuntimeTypeHandle.Value" /> параметра <paramref name="handle" /> равно <see langword="null" />.</returns>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Инициализатор класса вызывается и создает исключение.</exception>
		// Token: 0x060011C8 RID: 4552 RVA: 0x00047A13 File Offset: 0x00045C13
		public static Type GetTypeFromHandle(RuntimeTypeHandle handle)
		{
			if (handle.Value == IntPtr.Zero)
			{
				return null;
			}
			return Type.internal_from_handle(handle.Value);
		}

		// Token: 0x060011C9 RID: 4553
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Type internal_from_handle(IntPtr handle);

		// Token: 0x060011CA RID: 4554 RVA: 0x00047A36 File Offset: 0x00045C36
		internal virtual RuntimeTypeHandle GetTypeHandleInternal()
		{
			return this.TypeHandle;
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x000479F8 File Offset: 0x00045BF8
		internal virtual bool IsWindowsRuntimeObjectImpl()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x000479F8 File Offset: 0x00045BF8
		internal virtual bool IsExportedToWindowsRuntimeImpl()
		{
			throw new NotImplementedException();
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060011CD RID: 4557 RVA: 0x00047A3E File Offset: 0x00045C3E
		internal bool IsWindowsRuntimeObject
		{
			get
			{
				return this.IsWindowsRuntimeObjectImpl();
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060011CE RID: 4558 RVA: 0x00047A46 File Offset: 0x00045C46
		internal bool IsExportedToWindowsRuntime
		{
			get
			{
				return this.IsExportedToWindowsRuntimeImpl();
			}
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		internal virtual bool HasProxyAttributeImpl()
		{
			return false;
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060011D0 RID: 4560 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		internal virtual bool IsSzArray
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x00047A4E File Offset: 0x00045C4E
		internal string FormatTypeName()
		{
			return this.FormatTypeName(false);
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x000479F8 File Offset: 0x00045BF8
		internal virtual string FormatTypeName(bool serialization)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает значение, позволяющее определить, является ли объект <see cref="T:System.Type" /> интерфейсом (иными словами, не является классом или типом значения).</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> является интерфейсом; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060011D3 RID: 4563 RVA: 0x00047A58 File Offset: 0x00045C58
		public bool IsInterface
		{
			[SecuritySafeCritical]
			get
			{
				RuntimeType runtimeType = this as RuntimeType;
				if (runtimeType != null)
				{
					return RuntimeTypeHandle.IsInterface(runtimeType);
				}
				return (this.GetAttributeFlagsImpl() & TypeAttributes.ClassSemanticsMask) == TypeAttributes.ClassSemanticsMask;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Type" /> с указанным именем, позволяющий определить, будет ли создаваться исключение в случае невозможности найти тип и будет ли учитываться регистр при поиске.</summary>
		/// <param name="typeName">Имя искомого типа с указанием сборки. См. раздел <see cref="P:System.Type.AssemblyQualifiedName" />. Если тип находится в выполняемой в данный момент сборке или библиотеке Mscorlib.dll, достаточно предоставить имя типа с указанием пространства имен.</param>
		/// <param name="throwOnError">Значение <see langword="true" />, чтобы создать исключение, если тип не удается найти; значение <see langword="false" />, чтобы вернуть значение <see langword="null" />. Кроме того, при указании значения <see langword="false" /> подавляются некоторые другие условия возникновения исключений, но не все из них. См. раздел "Исключения".</param>
		/// <param name="ignoreCase">Значение <see langword="true" />, чтобы не учитывать регистр при поиске <paramref name="typeName" />, значение <see langword="false" />, чтобы учитывать регистр при поиске <paramref name="typeName" />.</param>
		/// <returns>Тип с указанным именем. Если тип не найден, параметр <paramref name="throwOnError" /> определяет дальнейшее действие — возврат значения <see langword="null" /> или создание исключения. В некоторых случаях исключение создается независимо от значения параметра <paramref name="throwOnError" />. См. раздел "Исключения".</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="typeName" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Инициализатор класса вызывается и создает исключение.</exception>
		/// <exception cref="T:System.TypeLoadException">
		///   <paramref name="throwOnError" /> имеет значение <see langword="true" />, и тип не найден.  
		/// -или- 
		///  <paramref name="throwOnError" /> имеет значение <see langword="true" />, и <paramref name="typeName" /> содержит недопустимые знаки, например внедренные табуляции. 
		/// -или- 
		///  <paramref name="throwOnError" /> имеет значение <see langword="true" />, и <paramref name="typeName" /> является пустой строкой.  
		/// -или- 
		///  <paramref name="throwOnError" /> имеет значение <see langword="true" />, и <paramref name="typeName" /> представляет тип массива с недопустимым размером.  
		/// -или- 
		///  <paramref name="typeName" /> представляет массив <see cref="T:System.TypedReference" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="throwOnError" /> имеет значение <see langword="true" />, и <paramref name="typeName" /> содержит недопустимый синтаксис. Например, "MyType[,*,]".  
		/// -или- 
		///  <paramref name="typeName" /> представляет универсальный тип, имеющий тип указателя, тип <see langword="ByRef" /> или <see cref="T:System.Void" /> в качестве одного из его аргументов типа.  
		/// -или- 
		///  <paramref name="typeName" /> представляет универсальный тип, который содержит неправильное количество аргументов типа.  
		/// -или- 
		///  <paramref name="typeName" /> представляет универсальный тип, и один из его аргументов типа не удовлетворяет ограничениям для соответствующего параметра типа.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="throwOnError" /> имеет значение <see langword="true" />, и не удалось найти сборку либо одну из ее зависимостей.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или одна из ее зависимостей найдена, но не может быть загружена.</exception>
		/// <exception cref="T:System.BadImageFormatException">Сборка или одна из ее зависимостей является недопустимой.  
		/// -или- 
		/// В текущий момент загружена среда CLR версии 2.0 или более поздней версии. Сборка была скомпилирована в более поздней версии.</exception>
		// Token: 0x060011D4 RID: 4564 RVA: 0x00047A8C File Offset: 0x00045C8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Type GetType(string typeName, bool throwOnError, bool ignoreCase)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return RuntimeType.GetType(typeName, throwOnError, ignoreCase, false, ref stackCrawlMark);
		}

		/// <summary>Возвращает объект <see cref="T:System.Type" /> с заданным именем, выполняя поиск с учетом регистра и указывая, будет ли создаваться исключение в случае невозможности найти тип.</summary>
		/// <param name="typeName">Имя искомого типа с указанием сборки. См. раздел <see cref="P:System.Type.AssemblyQualifiedName" />. Если тип находится в выполняемой в данный момент сборке или библиотеке Mscorlib.dll, достаточно предоставить имя типа с указанием пространства имен.</param>
		/// <param name="throwOnError">Значение <see langword="true" />, чтобы создать исключение, если тип не удается найти; значение <see langword="false" />, чтобы вернуть значение <see langword="null" />. Кроме того, при указании значения <see langword="false" /> подавляются некоторые другие условия возникновения исключений, но не все из них. См. раздел "Исключения".</param>
		/// <returns>Тип с указанным именем. Если тип не найден, параметр <paramref name="throwOnError" /> определяет дальнейшее действие — возврат значения <see langword="null" /> или создание исключения. В некоторых случаях исключение создается независимо от значения параметра <paramref name="throwOnError" />. См. раздел "Исключения".</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="typeName" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Инициализатор класса вызывается и создает исключение.</exception>
		/// <exception cref="T:System.TypeLoadException">
		///   <paramref name="throwOnError" /> имеет значение <see langword="true" />, и тип не найден.  
		/// -или- 
		///  <paramref name="throwOnError" /> имеет значение <see langword="true" />, и <paramref name="typeName" /> содержит недопустимые знаки, например внедренные табуляции. 
		/// -или- 
		///  <paramref name="throwOnError" /> имеет значение <see langword="true" />, и <paramref name="typeName" /> является пустой строкой.  
		/// -или- 
		///  <paramref name="throwOnError" /> имеет значение <see langword="true" />, и <paramref name="typeName" /> представляет тип массива с недопустимым размером.  
		/// -или- 
		///  <paramref name="typeName" /> представляет массив <see cref="T:System.TypedReference" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="throwOnError" /> имеет значение <see langword="true" />, и <paramref name="typeName" /> содержит недопустимый синтаксис. Например, "MyType[,*,]".  
		/// -или- 
		///  <paramref name="typeName" /> представляет универсальный тип, имеющий тип указателя, тип <see langword="ByRef" /> или <see cref="T:System.Void" /> в качестве одного из его аргументов типа.  
		/// -или- 
		///  <paramref name="typeName" /> представляет универсальный тип, который содержит неправильное количество аргументов типа.  
		/// -или- 
		///  <paramref name="typeName" /> представляет универсальный тип, и один из его аргументов типа не удовлетворяет ограничениям для соответствующего параметра типа.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="throwOnError" /> имеет значение <see langword="true" />, и не удалось найти сборку либо одну из ее зависимостей.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Вместо этого в .NET для приложений Магазина Windows или в переносимой библиотеке классов перехватите исключение базового класса <see cref="T:System.IO.IOException" />.  
		///
		///
		///
		///
		///  Сборка или одна из ее зависимостей найдена, но не может быть загружена.</exception>
		/// <exception cref="T:System.BadImageFormatException">Сборка или одна из ее зависимостей является недопустимой.  
		/// -или- 
		/// В текущий момент загружена среда CLR версии 2.0 или более поздней версии. Сборка была скомпилирована в более поздней версии.</exception>
		// Token: 0x060011D5 RID: 4565 RVA: 0x00047AA8 File Offset: 0x00045CA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Type GetType(string typeName, bool throwOnError)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return RuntimeType.GetType(typeName, throwOnError, false, false, ref stackCrawlMark);
		}

		/// <summary>Возвращает объект <see cref="T:System.Type" /> с указанным именем, учитывая при поиске регистр.</summary>
		/// <param name="typeName">Имя искомого типа с указанием сборки. См. раздел <see cref="P:System.Type.AssemblyQualifiedName" />. Если тип находится в выполняемой в данный момент сборке или библиотеке Mscorlib.dll, достаточно предоставить имя типа с указанием пространства имен.</param>
		/// <returns>Тип с указанным именем, если он существует; в противном случае — значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="typeName" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Инициализатор класса вызывается и создает исключение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="typeName" /> представляет универсальный тип, имеющий тип указателя, тип <see langword="ByRef" /> или <see cref="T:System.Void" /> в качестве одного из его аргументов типа.  
		/// -или- 
		///  <paramref name="typeName" /> представляет универсальный тип, который содержит неправильное количество аргументов типа.  
		/// -или- 
		///  <paramref name="typeName" /> представляет универсальный тип, и один из его аргументов типа не удовлетворяет ограничениям для соответствующего параметра типа.</exception>
		/// <exception cref="T:System.TypeLoadException">
		///   <paramref name="typeName" /> представляет массив <see cref="T:System.TypedReference" />.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Вместо этого в .NET для приложений Магазина Windows или в переносимой библиотеке классов перехватите исключение базового класса <see cref="T:System.IO.IOException" />.  
		///
		///
		///
		///
		///  Сборка или одна из ее зависимостей найдена, но не может быть загружена.</exception>
		/// <exception cref="T:System.BadImageFormatException">Сборка или одна из ее зависимостей является недопустимой.  
		/// -или- 
		/// В текущий момент загружена среда CLR версии 2.0 или более поздней версии. Сборка была скомпилирована в более поздней версии.</exception>
		// Token: 0x060011D6 RID: 4566 RVA: 0x00047AC4 File Offset: 0x00045CC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Type GetType(string typeName)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return RuntimeType.GetType(typeName, false, false, false, ref stackCrawlMark);
		}

		/// <summary>Возвращает тип с указанным именем; дополнительно может предоставлять настраиваемые методы для разрешения сборки и типа.</summary>
		/// <param name="typeName">Имя получаемого типа. Если задан параметр <paramref name="typeResolver" />, имя типа может быть любой строкой, которую может разрешить объект <paramref name="typeResolver" />. Если задан параметр <paramref name="assemblyResolver" /> или если используется стандартное разрешение типов, параметр <paramref name="typeName" /> должен быть именем с указанием сборки (см. описание свойства <see cref="P:System.Type.AssemblyQualifiedName" />), кроме случаев, когда этот тип находится в текущей выполняемой сборке или в библиотеке Mscorlib.dll — тогда достаточно задать имя типа с указанием пространства имен.</param>
		/// <param name="assemblyResolver">Метод, находящий и возвращающий сборку, заданную в параметре <paramref name="typeName" />. Имя сборки передается методу <paramref name="assemblyResolver" /> в виде объекта <see cref="T:System.Reflection.AssemblyName" />. Если объект <paramref name="typeName" /> не содержит имя сборки, метод <paramref name="assemblyResolver" /> не вызывается. Если метод <paramref name="assemblyResolver" /> не указан, выполняется стандартное разрешение сборки.  
		/// Внимание. Не передавайте методы от неизвестных или недоверенных вызывающих модулей. В противном случае возможно повышение привилегий для вредоносного кода. Рекомендуется использовать только методы, предоставленные пользователями или знакомые им.</param>
		/// <param name="typeResolver">Метод, находящий и возвращающий тип, заданный в параметре <paramref name="typeName" />, из сборки, возвращенной методом <paramref name="assemblyResolver" /> или стандартным методом разрешения сборки. Если сборка не предоставлена, ее может предоставить метод <paramref name="typeResolver" />. Метод также принимает параметр, указывающий, следует ли выполнять поиск без учета регистра; этому параметру передается значение <see langword="false" />.  
		/// Внимание. Не передавайте методы от неизвестных или недоверенных вызывающих модулей.</param>
		/// <returns>Тип с указанным именем или значение <see langword="null" />, если тип не найден.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="typeName" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Инициализатор класса вызывается и создает исключение.</exception>
		/// <exception cref="T:System.ArgumentException">Произошла ошибка при интерпретации <paramref name="typeName" /> в имя типа и имя сборки (например, если имя простого типа содержит неэкранированный специальный знак).  
		/// -или- 
		///  <paramref name="typeName" /> представляет универсальный тип, имеющий тип указателя, тип <see langword="ByRef" /> или <see cref="T:System.Void" /> в качестве одного из его аргументов типа.  
		/// -или- 
		///  <paramref name="typeName" /> представляет универсальный тип, который содержит неправильное количество аргументов типа.  
		/// -или- 
		///  <paramref name="typeName" /> представляет универсальный тип, и один из его аргументов типа не удовлетворяет ограничениям для соответствующего параметра типа.</exception>
		/// <exception cref="T:System.TypeLoadException">
		///   <paramref name="typeName" /> представляет массив <see cref="T:System.TypedReference" />.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или одна из ее зависимостей найдена, но не может быть загружена.  
		/// -или- 
		///  <paramref name="typeName" /> содержит недопустимое имя сборки.  
		/// -или- 
		///  <paramref name="typeName" /> является допустимым именем сборки без имени типа.</exception>
		/// <exception cref="T:System.BadImageFormatException">Сборка или одна из ее зависимостей является недопустимой.  
		/// -или- 
		/// Сборка была скомпилирована в более поздней версии среды CLR, чем версия, загруженная в текущий момент.</exception>
		// Token: 0x060011D7 RID: 4567 RVA: 0x00047AE0 File Offset: 0x00045CE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return TypeNameParser.GetType(typeName, assemblyResolver, typeResolver, false, false, ref stackCrawlMark);
		}

		/// <summary>Возвращает тип с заданным именем и указывает, следует ли создавать исключение в случае невозможности найти тип, а также может предоставлять настраиваемые методы для разрешения сборки и типа.</summary>
		/// <param name="typeName">Имя получаемого типа. Если задан параметр <paramref name="typeResolver" />, имя типа может быть любой строкой, которую может разрешить объект <paramref name="typeResolver" />. Если задан параметр <paramref name="assemblyResolver" /> или если используется стандартное разрешение типов, параметр <paramref name="typeName" /> должен быть именем с указанием сборки (см. описание свойства <see cref="P:System.Type.AssemblyQualifiedName" />), кроме случаев, когда этот тип находится в текущей выполняемой сборке или в библиотеке Mscorlib.dll — тогда достаточно задать имя типа с указанием пространства имен.</param>
		/// <param name="assemblyResolver">Метод, находящий и возвращающий сборку, заданную в параметре <paramref name="typeName" />. Имя сборки передается методу <paramref name="assemblyResolver" /> в виде объекта <see cref="T:System.Reflection.AssemblyName" />. Если объект <paramref name="typeName" /> не содержит имя сборки, метод <paramref name="assemblyResolver" /> не вызывается. Если метод <paramref name="assemblyResolver" /> не указан, выполняется стандартное разрешение сборки.  
		/// Внимание. Не передавайте методы от неизвестных или недоверенных вызывающих модулей. В противном случае возможно повышение привилегий для вредоносного кода. Рекомендуется использовать только методы, предоставленные пользователями или знакомые им.</param>
		/// <param name="typeResolver">Метод, находящий и возвращающий тип, заданный в параметре <paramref name="typeName" />, из сборки, возвращенной методом <paramref name="assemblyResolver" /> или стандартным методом разрешения сборки. Если сборка не предоставлена, этот метод может предоставить ее. Метод также принимает параметр, указывающий, следует ли выполнять поиск без учета регистра; этому параметру передается значение <see langword="false" />.  
		/// Внимание. Не передавайте методы от неизвестных или недоверенных вызывающих модулей.</param>
		/// <param name="throwOnError">Значение <see langword="true" />, чтобы создать исключение, если тип не удается найти; значение <see langword="false" />, чтобы вернуть значение <see langword="null" />. Кроме того, при указании значения <see langword="false" /> подавляются некоторые другие условия возникновения исключений, но не все из них. См. раздел "Исключения".</param>
		/// <returns>Тип с указанным именем. Если тип не найден, параметр <paramref name="throwOnError" /> определяет дальнейшее действие — возврат значения <see langword="null" /> или создание исключения. В некоторых случаях исключение создается независимо от значения параметра <paramref name="throwOnError" />. См. раздел "Исключения".</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="typeName" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Инициализатор класса вызывается и создает исключение.</exception>
		/// <exception cref="T:System.TypeLoadException">
		///   <paramref name="throwOnError" /> имеет значение <see langword="true" />, и тип не найден.  
		/// -или- 
		///  <paramref name="throwOnError" /> имеет значение <see langword="true" />, и <paramref name="typeName" /> содержит недопустимые знаки, например внедренные табуляции. 
		/// -или- 
		///  <paramref name="throwOnError" /> имеет значение <see langword="true" />, и <paramref name="typeName" /> является пустой строкой.  
		/// -или- 
		///  <paramref name="throwOnError" /> имеет значение <see langword="true" />, и <paramref name="typeName" /> представляет тип массива с недопустимым размером.  
		/// -или- 
		///  <paramref name="typeName" /> представляет массив <see cref="T:System.TypedReference" />.</exception>
		/// <exception cref="T:System.ArgumentException">Произошла ошибка при интерпретации <paramref name="typeName" /> в имя типа и имя сборки (например, если имя простого типа содержит неэкранированный специальный знак).  
		/// -или- 
		///  <paramref name="throwOnError" /> имеет значение <see langword="true" />, и <paramref name="typeName" /> содержит недопустимый синтаксис (например "MyType[,*,]").  
		/// -или- 
		///  <paramref name="typeName" /> представляет универсальный тип, имеющий тип указателя, тип <see langword="ByRef" /> или <see cref="T:System.Void" /> в качестве одного из его аргументов типа.  
		/// -или- 
		///  <paramref name="typeName" /> представляет универсальный тип, который содержит неправильное количество аргументов типа.  
		/// -или- 
		///  <paramref name="typeName" /> представляет универсальный тип, и один из его аргументов типа не удовлетворяет ограничениям для соответствующего параметра типа.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="throwOnError" /> имеет значение <see langword="true" />, и не удалось найти сборку либо одну из ее зависимостей.  
		/// -или- 
		///  <paramref name="typeName" /> содержит недопустимое имя сборки.  
		/// -или- 
		///  <paramref name="typeName" /> является допустимым именем сборки без имени типа.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или одна из ее зависимостей найдена, но не может быть загружена.</exception>
		/// <exception cref="T:System.BadImageFormatException">Сборка или одна из ее зависимостей является недопустимой.  
		/// -или- 
		/// Сборка была скомпилирована в более поздней версии среды CLR, чем версия, загруженная в текущий момент.</exception>
		// Token: 0x060011D8 RID: 4568 RVA: 0x00047AFC File Offset: 0x00045CFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return TypeNameParser.GetType(typeName, assemblyResolver, typeResolver, throwOnError, false, ref stackCrawlMark);
		}

		/// <summary>Возвращает тип с заданным именем и указывает, следует ли выполнять поиск без учета регистра и следует ли создавать исключение в случае невозможности найти тип, а также может предоставлять настраиваемые методы для разрешения сборки и типа.</summary>
		/// <param name="typeName">Имя получаемого типа. Если задан параметр <paramref name="typeResolver" />, имя типа может быть любой строкой, которую может разрешить объект <paramref name="typeResolver" />. Если задан параметр <paramref name="assemblyResolver" /> или если используется стандартное разрешение типов, параметр <paramref name="typeName" /> должен быть именем с указанием сборки (см. описание свойства <see cref="P:System.Type.AssemblyQualifiedName" />), кроме случаев, когда этот тип находится в текущей выполняемой сборке или в библиотеке Mscorlib.dll — тогда достаточно задать имя типа с указанием пространства имен.</param>
		/// <param name="assemblyResolver">Метод, находящий и возвращающий сборку, заданную в параметре <paramref name="typeName" />. Имя сборки передается методу <paramref name="assemblyResolver" /> в виде объекта <see cref="T:System.Reflection.AssemblyName" />. Если объект <paramref name="typeName" /> не содержит имя сборки, метод <paramref name="assemblyResolver" /> не вызывается. Если метод <paramref name="assemblyResolver" /> не указан, выполняется стандартное разрешение сборки.  
		/// Внимание. Не передавайте методы от неизвестных или недоверенных вызывающих модулей. В противном случае возможно повышение привилегий для вредоносного кода. Рекомендуется использовать только методы, предоставленные пользователями или знакомые им.</param>
		/// <param name="typeResolver">Метод, находящий и возвращающий тип, заданный в параметре <paramref name="typeName" />, из сборки, возвращенной методом <paramref name="assemblyResolver" /> или стандартным методом разрешения сборки. Если сборка не предоставлена, этот метод может предоставить ее. Метод также принимает параметр, указывающий, следует ли выполнять поиск без учета регистра; этому параметру передается значение <paramref name="ignoreCase" />.  
		/// Внимание. Не передавайте методы от неизвестных или недоверенных вызывающих модулей.</param>
		/// <param name="throwOnError">Значение <see langword="true" />, чтобы создать исключение, если тип не удается найти; значение <see langword="false" />, чтобы вернуть значение <see langword="null" />. Кроме того, при указании значения <see langword="false" /> подавляются некоторые другие условия возникновения исключений, но не все из них. См. раздел "Исключения".</param>
		/// <param name="ignoreCase">Значение <see langword="true" />, чтобы не учитывать регистр при поиске <paramref name="typeName" />, значение <see langword="false" />, чтобы учитывать регистр при поиске <paramref name="typeName" />.</param>
		/// <returns>Тип с указанным именем. Если тип не найден, параметр <paramref name="throwOnError" /> определяет дальнейшее действие — возврат значения <see langword="null" /> или создание исключения. В некоторых случаях исключение создается независимо от значения параметра <paramref name="throwOnError" />. См. раздел "Исключения".</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="typeName" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Инициализатор класса вызывается и создает исключение.</exception>
		/// <exception cref="T:System.TypeLoadException">
		///   <paramref name="throwOnError" /> имеет значение <see langword="true" />, и тип не найден.  
		/// -или- 
		///  <paramref name="throwOnError" /> имеет значение <see langword="true" />, и <paramref name="typeName" /> содержит недопустимые знаки, например внедренные табуляции. 
		/// -или- 
		///  <paramref name="throwOnError" /> имеет значение <see langword="true" />, и <paramref name="typeName" /> является пустой строкой.  
		/// -или- 
		///  <paramref name="throwOnError" /> имеет значение <see langword="true" />, и <paramref name="typeName" /> представляет тип массива с недопустимым размером.  
		/// -или- 
		///  <paramref name="typeName" /> представляет массив <see cref="T:System.TypedReference" />.</exception>
		/// <exception cref="T:System.ArgumentException">Произошла ошибка при интерпретации <paramref name="typeName" /> в имя типа и имя сборки (например, если имя простого типа содержит неэкранированный специальный знак).  
		/// -или- 
		///  <paramref name="throwOnError" /> имеет значение <see langword="true" />, и <paramref name="typeName" /> содержит недопустимый синтаксис (например "MyType[,*,]").  
		/// -или- 
		///  <paramref name="typeName" /> представляет универсальный тип, имеющий тип указателя, тип <see langword="ByRef" /> или <see cref="T:System.Void" /> в качестве одного из его аргументов типа.  
		/// -или- 
		///  <paramref name="typeName" /> представляет универсальный тип, который содержит неправильное количество аргументов типа.  
		/// -или- 
		///  <paramref name="typeName" /> представляет универсальный тип, и один из его аргументов типа не удовлетворяет ограничениям для соответствующего параметра типа.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="throwOnError" /> имеет значение <see langword="true" />, и не удалось найти сборку либо одну из ее зависимостей.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или одна из ее зависимостей найдена, но не может быть загружена.  
		/// -или- 
		///  <paramref name="typeName" /> содержит недопустимое имя сборки.  
		/// -или- 
		///  <paramref name="typeName" /> является допустимым именем сборки без имени типа.</exception>
		/// <exception cref="T:System.BadImageFormatException">Сборка или одна из ее зависимостей является недопустимой.  
		/// -или- 
		/// Сборка была скомпилирована в более поздней версии среды CLR, чем версия, загруженная в текущий момент.</exception>
		// Token: 0x060011D9 RID: 4569 RVA: 0x00047B18 File Offset: 0x00045D18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError, bool ignoreCase)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return TypeNameParser.GetType(typeName, assemblyResolver, typeResolver, throwOnError, ignoreCase, ref stackCrawlMark);
		}

		/// <summary>Определение равенства двух объектов <see cref="T:System.Type" />.</summary>
		/// <param name="left">Первый из сравниваемых объектов.</param>
		/// <param name="right">Второй из сравниваемых объектов.</param>
		/// <returns>
		///   <see langword="true" />, если значения параметров <paramref name="left" /> и <paramref name="right" /> равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060011DA RID: 4570 RVA: 0x00028426 File Offset: 0x00026626
		public static bool operator ==(Type left, Type right)
		{
			return left == right;
		}

		/// <summary>Определяет неравенство двух объектов <see cref="T:System.Type" />.</summary>
		/// <param name="left">Первый из сравниваемых объектов.</param>
		/// <param name="right">Второй из сравниваемых объектов.</param>
		/// <returns>
		///   <see langword="true" />, если значения <paramref name="left" /> и <paramref name="right" /> не равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060011DB RID: 4571 RVA: 0x0002842C File Offset: 0x0002662C
		public static bool operator !=(Type left, Type right)
		{
			return left != right;
		}

		/// <summary>Возвращает объект <see cref="T:System.Type" /> с заданным именем, позволяющий определить, будет ли учитываться регистр при поиске, и будет ли создаваться исключение в случае невозможности найти тип. Тип загружается не для выполнения, а только для отражения.</summary>
		/// <param name="typeName">Имя искомого типа <see cref="T:System.Type" /> с указанием сборки.</param>
		/// <param name="throwIfNotFound">Значение <see langword="true" />, чтобы в случае невозможности найти тип создавалось исключение <see cref="T:System.TypeLoadException" />; значение <see langword="false" />, чтобы при невозможности найти тип возвращалось значение <see langword="null" />. Кроме того, при указании значения <see langword="false" /> подавляются некоторые другие условия возникновения исключений, но не все из них. См. раздел "Исключения".</param>
		/// <param name="ignoreCase">Значение <see langword="true" />, чтобы не учитывать регистр при поиске <paramref name="typeName" />, значение <see langword="false" />, чтобы учитывать регистр при поиске <paramref name="typeName" />.</param>
		/// <returns>Тип с указанным именем, если он существует; в противном случае — значение <see langword="null" />. Если тип не найден, параметр <paramref name="throwIfNotFound" /> определяет дальнейшее действие — возврат значения <see langword="null" /> или создание исключения. В некоторых случаях исключение создается независимо от значения параметра <paramref name="throwIfNotFound" />. См. раздел "Исключения".</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="typeName" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Инициализатор класса вызывается и создает исключение.</exception>
		/// <exception cref="T:System.TypeLoadException">
		///   <paramref name="throwIfNotFound" /> имеет значение <see langword="true" />, и тип не найден.  
		/// -или- 
		///  <paramref name="throwIfNotFound" /> имеет значение <see langword="true" />, и <paramref name="typeName" /> содержит недопустимые знаки, например внедренные табуляции. 
		/// -или- 
		///  <paramref name="throwIfNotFound" /> имеет значение <see langword="true" />, и <paramref name="typeName" /> является пустой строкой.  
		/// -или- 
		///  <paramref name="throwIfNotFound" /> имеет значение <see langword="true" />, и <paramref name="typeName" /> представляет тип массива с недопустимым размером.  
		/// -или- 
		///  <paramref name="typeName" /> представляет массив объектов <see cref="T:System.TypedReference" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="typeName" /> не включает имя сборки.  
		/// -или- 
		///  <paramref name="throwIfNotFound" /> имеет значение <see langword="true" />, и <paramref name="typeName" /> содержит недопустимый синтаксис (например, "MyType[,*,]").  
		/// -или- 
		///  <paramref name="typeName" /> представляет универсальный тип, имеющий тип указателя, тип <see langword="ByRef" /> или <see cref="T:System.Void" /> в качестве одного из его аргументов типа.  
		/// -или- 
		///  <paramref name="typeName" /> представляет универсальный тип, который содержит неправильное количество аргументов типа.  
		/// -или- 
		///  <paramref name="typeName" /> представляет универсальный тип, и один из его аргументов типа не удовлетворяет ограничениям для соответствующего параметра типа.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="throwIfNotFound" /> имеет значение <see langword="true" />, и не удалось найти сборку либо одну из ее зависимостей.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или одна из ее зависимостей найдена, но не может быть загружена.</exception>
		/// <exception cref="T:System.BadImageFormatException">Сборка или одна из ее зависимостей является недопустимой.  
		/// -или- 
		/// Сборка была скомпилирована в более поздней версии среды CLR, чем версия, загруженная в текущий момент.</exception>
		// Token: 0x060011DC RID: 4572 RVA: 0x00047B34 File Offset: 0x00045D34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Type ReflectionOnlyGetType(string typeName, bool throwIfNotFound, bool ignoreCase)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return RuntimeType.GetType(typeName, throwIfNotFound, ignoreCase, true, ref stackCrawlMark);
		}

		/// <summary>Возвращает с указанного сервера тип, связанный с заданным кодом CLSID, позволяющий определить, будет ли выбрасываться исключение при происхождении ошибки во время загрузки типа.</summary>
		/// <param name="clsid">Код CLSID извлекаемого типа.</param>
		/// <param name="server">Сервер, с которого должен быть загружен тип. Если в качестве имени сервера задано значение <see langword="null" />, этот метод автоматически перейдет к поиску на локальном компьютере.</param>
		/// <param name="throwOnError">Значение <see langword="true" /> для вызова любого возникшего исключения.  
		/// -или- 
		///  Значение <see langword="false" /> для игнорирования всех происходящих исключений.</param>
		/// <returns>
		///   <see langword="System.__ComObject" /> вне зависимости от того, допустим ли код CLSID.</returns>
		// Token: 0x060011DD RID: 4573 RVA: 0x00047B4E File Offset: 0x00045D4E
		public static Type GetTypeFromCLSID(Guid clsid, string server, bool throwOnError)
		{
			return RuntimeType.GetTypeFromCLSIDImpl(clsid, server, throwOnError);
		}

		/// <summary>Возвращает с указанного сервера тип, связанный с заданным идентификатором progID, который позволяет определить, будет ли выбрасываться исключение при происхождении ошибки во время загрузки типа.</summary>
		/// <param name="progID">Идентификатор ProgID извлекаемого типа <see cref="T:System.Type" />.</param>
		/// <param name="server">Сервер, с которого должен быть загружен тип. Если в качестве имени сервера задано значение <see langword="null" />, этот метод автоматически перейдет к поиску на локальном компьютере.</param>
		/// <param name="throwOnError">Значение <see langword="true" /> для вызова любого возникшего исключения.  
		/// -или- 
		///  Значение <see langword="false" /> для игнорирования всех происходящих исключений.</param>
		/// <returns>Тип, связанный с заданным идентификатором ProgID, если идентификатор <paramref name="progID" /> является допустимой записью в реестре и с ним связан определенный тип; в противном случае — значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="progID" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Указанный идентификатор progID не зарегистрирован.</exception>
		// Token: 0x060011DE RID: 4574 RVA: 0x00047B58 File Offset: 0x00045D58
		public static Type GetTypeFromProgID(string progID, string server, bool throwOnError)
		{
			return RuntimeType.GetTypeFromProgIDImpl(progID, server, throwOnError);
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060011DF RID: 4575 RVA: 0x00047B64 File Offset: 0x00045D64
		internal string FullNameOrDefault
		{
			get
			{
				if (this.InternalNameIfAvailable == null)
				{
					return "UnknownType";
				}
				string result;
				try
				{
					result = this.FullName;
				}
				catch (MissingMetadataException)
				{
					result = "UnknownType";
				}
				return result;
			}
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x00047BA4 File Offset: 0x00045DA4
		internal bool IsRuntimeImplemented()
		{
			return this.UnderlyingSystemType is RuntimeType;
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x00047BB4 File Offset: 0x00045DB4
		internal virtual string InternalGetNameIfAvailable(ref Type rootCauseForFailure)
		{
			return this.Name;
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060011E2 RID: 4578 RVA: 0x00047BBC File Offset: 0x00045DBC
		internal string InternalNameIfAvailable
		{
			get
			{
				Type type = null;
				return this.InternalGetNameIfAvailable(ref type);
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060011E3 RID: 4579 RVA: 0x00047BD3 File Offset: 0x00045DD3
		internal string NameOrDefault
		{
			get
			{
				return this.InternalNameIfAvailable ?? "UnknownType";
			}
		}

		// Token: 0x0400133D RID: 4925
		private static volatile Binder s_defaultBinder;

		/// <summary>Разделяет имена в пространстве имен класса <see cref="T:System.Type" />. Это поле доступно только для чтения.</summary>
		// Token: 0x0400133E RID: 4926
		public static readonly char Delimiter = '.';

		/// <summary>Представляет пустой массив типа <see cref="T:System.Type" />. Это поле доступно только для чтения.</summary>
		// Token: 0x0400133F RID: 4927
		public static readonly Type[] EmptyTypes = Array.Empty<Type>();

		/// <summary>Представляет отсутствующее значение в данных объекта <see cref="T:System.Type" />. Это поле доступно только для чтения.</summary>
		// Token: 0x04001340 RID: 4928
		public static readonly object Missing = System.Reflection.Missing.Value;

		/// <summary>Предоставляет фильтр членов, используемый для атрибутов. Это поле доступно только для чтения.</summary>
		// Token: 0x04001341 RID: 4929
		public static readonly MemberFilter FilterAttribute = new MemberFilter(Type.FilterAttributeImpl);

		/// <summary>Представляет фильтр членов с учетом регистра, применяемый к именам. Это поле доступно только для чтения.</summary>
		// Token: 0x04001342 RID: 4930
		public static readonly MemberFilter FilterName = new MemberFilter(Type.FilterNameImpl);

		/// <summary>Представляет фильтр членов без учета регистра, применяемый к именам. Это поле доступно только для чтения.</summary>
		// Token: 0x04001343 RID: 4931
		public static readonly MemberFilter FilterNameIgnoreCase = new MemberFilter(Type.FilterNameIgnoreCaseImpl);

		// Token: 0x04001344 RID: 4932
		private const BindingFlags DefaultLookup = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public;

		// Token: 0x04001345 RID: 4933
		internal RuntimeTypeHandle _impl;

		// Token: 0x04001346 RID: 4934
		internal const string DefaultTypeNameWhenMissingMetadata = "UnknownType";
	}
}
