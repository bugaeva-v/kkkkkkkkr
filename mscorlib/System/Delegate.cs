using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Serialization;
using System.Security;

namespace System
{
	/// <summary>Представляет делегат — структуру данных, указывающую на статический метод или на экземпляр класса и метод экземпляра этого класса.</summary>
	// Token: 0x02000232 RID: 562
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public abstract class Delegate : ICloneable, ISerializable
	{
		/// <summary>Инициализирует делегат, вызывающий заданный метод экземпляра указанного класса.</summary>
		/// <param name="target">Экземпляр класса, метод <paramref name="method" /> которого вызывает делегат.</param>
		/// <param name="method">Имя представленного делегатом метода экземпляра.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="target" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="method" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Произошла ошибка связывания с целевым методом.</exception>
		// Token: 0x0600199A RID: 6554 RVA: 0x0005EE94 File Offset: 0x0005D094
		protected Delegate(object target, string method)
		{
			if (target == null)
			{
				throw new ArgumentNullException("target");
			}
			if (method == null)
			{
				throw new ArgumentNullException("method");
			}
			this.m_target = target;
			this.data = new DelegateData();
			this.data.method_name = method;
		}

		/// <summary>Инициализирует делегат, вызывающий заданный статистический метод указанного класса.</summary>
		/// <param name="target">Тип <see cref="T:System.Type" />, представляющий класс, в котором определен метод <paramref name="method" />.</param>
		/// <param name="method">Имя представленного делегатом статического метода.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="target" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="method" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="target" /> не является объектом типа <see langword="RuntimeType" />. См. статью Типы среды выполнения в отражении.  
		/// -или- 
		///  <paramref name="target" /> представляет открытый универсальный тип.</exception>
		// Token: 0x0600199B RID: 6555 RVA: 0x0005EEE4 File Offset: 0x0005D0E4
		protected Delegate(Type target, string method)
		{
			if (target == null)
			{
				throw new ArgumentNullException("target");
			}
			if (method == null)
			{
				throw new ArgumentNullException("method");
			}
			this.data = new DelegateData();
			this.data.method_name = method;
			this.data.target_type = target;
		}

		/// <summary>Возвращает метод, представленный делегатом.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.MethodInfo" />, описывающий метод, представленный делегатом.</returns>
		/// <exception cref="T:System.MemberAccessException">Вызывающий код не имеет доступа к методу, представленному делегатом (например, если это закрытый метод).</exception>
		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x0600199C RID: 6556 RVA: 0x0005EF3C File Offset: 0x0005D13C
		public MethodInfo Method
		{
			get
			{
				return this.GetMethodImpl();
			}
		}

		// Token: 0x0600199D RID: 6557
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern MethodInfo GetVirtualMethod_internal();

		/// <summary>Возвращает экземпляр класса, метод которого вызывает текущий делегат.</summary>
		/// <returns>Объект, для которого текущий делегат вызывает метод экземпляра, если делегат представляет метод экземпляра, либо <see langword="null" /> если делегат представляет статический метод.</returns>
		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x0600199E RID: 6558 RVA: 0x0005EF44 File Offset: 0x0005D144
		public object Target
		{
			get
			{
				return this.m_target;
			}
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x0005EF4C File Offset: 0x0005D14C
		internal IntPtr GetNativeFunctionPointer()
		{
			return this.method_ptr;
		}

		// Token: 0x060019A0 RID: 6560
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Delegate CreateDelegate_internal(Type type, object target, MethodInfo info, bool throwOnBindFailure);

		// Token: 0x060019A1 RID: 6561 RVA: 0x0005EF54 File Offset: 0x0005D154
		private static bool arg_type_match(Type delArgType, Type argType)
		{
			bool flag = delArgType == argType;
			if (!flag && !argType.IsValueType && argType.IsAssignableFrom(delArgType))
			{
				flag = true;
			}
			if (!flag)
			{
				if (delArgType.IsEnum && Enum.GetUnderlyingType(delArgType) == argType)
				{
					flag = true;
				}
				else if (argType.IsEnum && Enum.GetUnderlyingType(argType) == delArgType)
				{
					flag = true;
				}
			}
			return flag;
		}

		// Token: 0x060019A2 RID: 6562 RVA: 0x0005EFB8 File Offset: 0x0005D1B8
		private static bool arg_type_match_this(Type delArgType, Type argType, bool boxedThis)
		{
			bool result;
			if (argType.IsValueType)
			{
				result = ((delArgType.IsByRef && delArgType.GetElementType() == argType) || (boxedThis && delArgType == argType));
			}
			else
			{
				result = (delArgType == argType || argType.IsAssignableFrom(delArgType));
			}
			return result;
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x0005F00C File Offset: 0x0005D20C
		private static bool return_type_match(Type delReturnType, Type returnType)
		{
			bool flag = returnType == delReturnType;
			if (!flag)
			{
				if (!returnType.IsValueType && delReturnType.IsAssignableFrom(returnType))
				{
					flag = true;
				}
				else
				{
					bool isEnum = delReturnType.IsEnum;
					bool isEnum2 = returnType.IsEnum;
					if (isEnum2 && isEnum)
					{
						flag = (Enum.GetUnderlyingType(delReturnType) == Enum.GetUnderlyingType(returnType));
					}
					else if (isEnum && Enum.GetUnderlyingType(delReturnType) == returnType)
					{
						flag = true;
					}
					else if (isEnum2 && Enum.GetUnderlyingType(returnType) == delReturnType)
					{
						flag = true;
					}
				}
			}
			return flag;
		}

		/// <summary>Создает делегат указанного типа, представляющий заданный статический метод или метод экземпляра, с заданным первым аргументом и поведением на случай, если операция связывания завершится неудачей.</summary>
		/// <param name="type">Объект <see cref="T:System.Type" />, представляющий тип создаваемого делегата.</param>
		/// <param name="firstArgument">Объект <see cref="T:System.Object" />, являющийся первым аргументом метода, представленного делегатом. Для методов экземпляра он должен быть совместим с типом экземпляра.</param>
		/// <param name="method">
		///   <see cref="T:System.Reflection.MethodInfo" />, описывающий статический метод или метод экземпляра, который будет представлен делегатом.</param>
		/// <param name="throwOnBindFailure">Значение <see langword="true" /> для создания исключения, если метод <paramref name="method" /> привязать невозможно; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Делегат заданного типа, представляющий указанный статический метод или метод экземпляра, либо значение <see langword="null" />, если значение параметра <paramref name="throwOnBindFailure" /> равно <see langword="false" /> и делегат не удалось связать с методом <paramref name="method" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="type" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="method" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="type" /> не является производным от <see cref="T:System.MulticastDelegate" />.  
		/// -или- 
		///  <paramref name="type" /> не является объектом типа <see langword="RuntimeType" />. См. статью Типы среды выполнения в отражении.  
		/// -или- 
		///  <paramref name="method" /> невозможно привязать, и <paramref name="throwOnBindFailure" /> имеет значение <see langword="true" />.  
		/// -или- 
		///  <paramref name="method" /> не является объектом типа <see langword="RuntimeMethodInfo" />. См. статью Типы среды выполнения в отражении.</exception>
		/// <exception cref="T:System.MissingMethodException">Метод <see langword="Invoke" /> типа <paramref name="type" /> не найден.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий код не имеет необходимых разрешений для доступа к <paramref name="method" />.</exception>
		// Token: 0x060019A4 RID: 6564 RVA: 0x0005F089 File Offset: 0x0005D289
		public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure)
		{
			return Delegate.CreateDelegate(type, firstArgument, method, throwOnBindFailure, true);
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x0005F098 File Offset: 0x0005D298
		private static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure, bool allowClosed)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (method == null)
			{
				throw new ArgumentNullException("method");
			}
			if (!type.IsSubclassOf(typeof(MulticastDelegate)))
			{
				throw new ArgumentException("type is not a subclass of Multicastdelegate");
			}
			MethodInfo methodInfo = type.GetMethod("Invoke");
			if (!Delegate.return_type_match(methodInfo.ReturnType, method.ReturnType))
			{
				if (throwOnBindFailure)
				{
					throw new ArgumentException("method return type is incompatible");
				}
				return null;
			}
			else
			{
				ParameterInfo[] parametersInternal = methodInfo.GetParametersInternal();
				ParameterInfo[] parametersInternal2 = method.GetParametersInternal();
				bool flag;
				if (firstArgument != null)
				{
					if (!method.IsStatic)
					{
						flag = (parametersInternal2.Length == parametersInternal.Length);
					}
					else
					{
						flag = (parametersInternal2.Length == parametersInternal.Length + 1);
					}
				}
				else if (!method.IsStatic)
				{
					flag = (parametersInternal2.Length + 1 == parametersInternal.Length);
					if (!flag)
					{
						flag = (parametersInternal2.Length == parametersInternal.Length);
					}
				}
				else
				{
					flag = (parametersInternal2.Length == parametersInternal.Length);
					if (!flag)
					{
						flag = (parametersInternal2.Length == parametersInternal.Length + 1);
					}
				}
				if (!flag)
				{
					if (throwOnBindFailure)
					{
						throw new TargetParameterCountException("Parameter count mismatch.");
					}
					return null;
				}
				else
				{
					DelegateData delegateData = new DelegateData();
					bool flag2;
					if (firstArgument != null)
					{
						if (!method.IsStatic)
						{
							flag2 = Delegate.arg_type_match_this(firstArgument.GetType(), method.DeclaringType, true);
							for (int i = 0; i < parametersInternal2.Length; i++)
							{
								flag2 &= Delegate.arg_type_match(parametersInternal[i].ParameterType, parametersInternal2[i].ParameterType);
							}
						}
						else
						{
							flag2 = Delegate.arg_type_match(firstArgument.GetType(), parametersInternal2[0].ParameterType);
							for (int j = 1; j < parametersInternal2.Length; j++)
							{
								flag2 &= Delegate.arg_type_match(parametersInternal[j - 1].ParameterType, parametersInternal2[j].ParameterType);
							}
							delegateData.curried_first_arg = true;
						}
					}
					else if (!method.IsStatic)
					{
						if (parametersInternal2.Length + 1 == parametersInternal.Length)
						{
							flag2 = Delegate.arg_type_match_this(parametersInternal[0].ParameterType, method.DeclaringType, false);
							for (int k = 0; k < parametersInternal2.Length; k++)
							{
								flag2 &= Delegate.arg_type_match(parametersInternal[k + 1].ParameterType, parametersInternal2[k].ParameterType);
							}
						}
						else
						{
							flag2 = allowClosed;
							for (int l = 0; l < parametersInternal2.Length; l++)
							{
								flag2 &= Delegate.arg_type_match(parametersInternal[l].ParameterType, parametersInternal2[l].ParameterType);
							}
						}
					}
					else if (parametersInternal.Length + 1 == parametersInternal2.Length)
					{
						flag2 = (!parametersInternal2[0].ParameterType.IsValueType && !parametersInternal2[0].ParameterType.IsByRef && allowClosed);
						for (int m = 0; m < parametersInternal.Length; m++)
						{
							flag2 &= Delegate.arg_type_match(parametersInternal[m].ParameterType, parametersInternal2[m + 1].ParameterType);
						}
						delegateData.curried_first_arg = true;
					}
					else
					{
						flag2 = true;
						for (int n = 0; n < parametersInternal2.Length; n++)
						{
							flag2 &= Delegate.arg_type_match(parametersInternal[n].ParameterType, parametersInternal2[n].ParameterType);
						}
					}
					if (flag2)
					{
						Delegate @delegate = Delegate.CreateDelegate_internal(type, firstArgument, method, throwOnBindFailure);
						if (@delegate != null)
						{
							@delegate.original_method_info = method;
						}
						if (delegateData != null)
						{
							@delegate.data = delegateData;
						}
						return @delegate;
					}
					if (throwOnBindFailure)
					{
						throw new ArgumentException("method arguments are incompatible");
					}
					return null;
				}
			}
		}

		/// <summary>Создает делегат указанного типа, представляющий заданный статический метод или метод экземпляра, с заданным первым аргументом.</summary>
		/// <param name="type">
		///   <see cref="T:System.Type" /> создаваемого делегата.</param>
		/// <param name="firstArgument">Объект, с которым связан делегат, или значение <see langword="null" />, чтобы обработать <paramref name="method" /> как <see langword="static" /> (<see langword="Shared" /> в Visual Basic).</param>
		/// <param name="method">
		///   <see cref="T:System.Reflection.MethodInfo" />, описывающий статический метод или метод экземпляра, который будет представлен делегатом.</param>
		/// <returns>Делегат указанного типа, представляющий заданный статический метод или метод экземпляра.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="type" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="method" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="type" /> не является производным от <see cref="T:System.MulticastDelegate" />.  
		/// -или- 
		///  <paramref name="type" /> не является объектом типа <see langword="RuntimeType" />. См. статью Типы среды выполнения в отражении.  
		/// -или- 
		///  Метод <paramref name="method" /> невозможно привязать.  
		/// -или- 
		///  <paramref name="method" /> не является объектом типа <see langword="RuntimeMethodInfo" />. См. статью Типы среды выполнения в отражении.</exception>
		/// <exception cref="T:System.MissingMethodException">Метод <see langword="Invoke" /> типа <paramref name="type" /> не найден.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий код не имеет необходимых разрешений для доступа к <paramref name="method" />.</exception>
		// Token: 0x060019A6 RID: 6566 RVA: 0x0005F3BB File Offset: 0x0005D5BB
		public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method)
		{
			return Delegate.CreateDelegate(type, firstArgument, method, true, true);
		}

		/// <summary>Создает делегат указанного типа, представляющий заданный статический метод, с заданным поведением на случай, если операция связывания завершится неудачей.</summary>
		/// <param name="type">
		///   <see cref="T:System.Type" /> создаваемого делегата.</param>
		/// <param name="method">Объект <see cref="T:System.Reflection.MethodInfo" />, описывающий статический метод или метод экземпляра, который будет представлен делегатом.</param>
		/// <param name="throwOnBindFailure">Значение <see langword="true" /> для создания исключения, если метод <paramref name="method" /> привязать невозможно; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Делегат указанного типа, представляющий заданный статический метод.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="type" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="method" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="type" /> не является производным от <see cref="T:System.MulticastDelegate" />.  
		/// -или- 
		///  <paramref name="type" /> не является объектом типа <see langword="RuntimeType" />. См. статью Типы среды выполнения в отражении.  
		/// -или- 
		///  <paramref name="method" /> невозможно привязать, и <paramref name="throwOnBindFailure" /> имеет значение <see langword="true" />.  
		/// -или- 
		///  <paramref name="method" /> не является объектом типа <see langword="RuntimeMethodInfo" />. См. статью Типы среды выполнения в отражении.</exception>
		/// <exception cref="T:System.MissingMethodException">Метод <see langword="Invoke" /> типа <paramref name="type" /> не найден.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий код не имеет необходимых разрешений для доступа к <paramref name="method" />.</exception>
		// Token: 0x060019A7 RID: 6567 RVA: 0x0005F3C7 File Offset: 0x0005D5C7
		public static Delegate CreateDelegate(Type type, MethodInfo method, bool throwOnBindFailure)
		{
			return Delegate.CreateDelegate(type, null, method, throwOnBindFailure, false);
		}

		/// <summary>Создает делегат указанного типа, представляющий заданный статический метод.</summary>
		/// <param name="type">
		///   <see cref="T:System.Type" /> создаваемого делегата.</param>
		/// <param name="method">
		///   <see cref="T:System.Reflection.MethodInfo" />, описывающий статический метод или метод экземпляра, который будет представлен делегатом. На платформе .NET Framework версий 1.0 и 1.1 поддерживаются только статические методы.</param>
		/// <returns>Делегат указанного типа, представляющий заданный статический метод.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="type" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="method" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="type" /> не является производным от <see cref="T:System.MulticastDelegate" />.  
		/// -или- 
		///  <paramref name="type" /> не является объектом типа <see langword="RuntimeType" />. См. статью Типы среды выполнения в отражении.  
		/// -или- 
		///  <paramref name="method" /> не является статическим методом, а версия платформы .NET Framework имеет значение 1.0 или 1.1.  
		/// -или- 
		///  Метод <paramref name="method" /> невозможно привязать.  
		/// -или- 
		///  <paramref name="method" /> не является объектом типа <see langword="RuntimeMethodInfo" />. См. статью Типы среды выполнения в отражении.</exception>
		/// <exception cref="T:System.MissingMethodException">Метод <see langword="Invoke" /> типа <paramref name="type" /> не найден.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий код не имеет необходимых разрешений для доступа к <paramref name="method" />.</exception>
		// Token: 0x060019A8 RID: 6568 RVA: 0x0005F3D3 File Offset: 0x0005D5D3
		public static Delegate CreateDelegate(Type type, MethodInfo method)
		{
			return Delegate.CreateDelegate(type, method, true);
		}

		/// <summary>Создает делегат указанного типа, представляющий заданный метод экземпляра, который вызывается для заданного экземпляра класса.</summary>
		/// <param name="type">
		///   <see cref="T:System.Type" /> создаваемого делегата.</param>
		/// <param name="target">Экземпляр класса, для которого вызывается метод <paramref name="method" />.</param>
		/// <param name="method">Имя метода экземпляра, который должен быть представлен делегатом.</param>
		/// <returns>Создает делегат указанного типа, представляющий заданный метод экземпляра, который вызывается для заданного экземпляра класса.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="type" /> — <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="target" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  <paramref name="method" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="type" /> не является производным от <see cref="T:System.MulticastDelegate" />.  
		/// -или- 
		///  <paramref name="type" /> не является объектом типа <see langword="RuntimeType" />. См. статью Типы среды выполнения в отражении.  
		/// -или- 
		///  <paramref name="method" /> не является методом экземпляра.  
		/// -или- 
		///  Параметр <paramref name="method" /> невозможно привязать, например, потому, что его не удалось найти.</exception>
		/// <exception cref="T:System.MissingMethodException">Метод <see langword="Invoke" /> для <paramref name="type" /> не найден.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий код не имеет необходимых разрешений для доступа к <paramref name="method" />.</exception>
		// Token: 0x060019A9 RID: 6569 RVA: 0x0005F3DD File Offset: 0x0005D5DD
		public static Delegate CreateDelegate(Type type, object target, string method)
		{
			return Delegate.CreateDelegate(type, target, method, false);
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x0005F3E8 File Offset: 0x0005D5E8
		private static MethodInfo GetCandidateMethod(Type type, Type target, string method, BindingFlags bflags, bool ignoreCase, bool throwOnBindFailure)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (method == null)
			{
				throw new ArgumentNullException("method");
			}
			if (!type.IsSubclassOf(typeof(MulticastDelegate)))
			{
				throw new ArgumentException("type is not subclass of MulticastDelegate.");
			}
			MethodInfo methodInfo = type.GetMethod("Invoke");
			ParameterInfo[] parametersInternal = methodInfo.GetParametersInternal();
			Type[] array = new Type[parametersInternal.Length];
			for (int i = 0; i < parametersInternal.Length; i++)
			{
				array[i] = parametersInternal[i].ParameterType;
			}
			BindingFlags bindingFlags = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.ExactBinding | bflags;
			if (ignoreCase)
			{
				bindingFlags |= BindingFlags.IgnoreCase;
			}
			MethodInfo methodInfo2 = null;
			Type type2 = target;
			while (type2 != null)
			{
				MethodInfo methodInfo3 = type2.GetMethod(method, bindingFlags, null, array, Array.Empty<ParameterModifier>());
				if (methodInfo3 != null && Delegate.return_type_match(methodInfo.ReturnType, methodInfo3.ReturnType))
				{
					methodInfo2 = methodInfo3;
					break;
				}
				type2 = type2.BaseType;
			}
			if (!(methodInfo2 == null))
			{
				return methodInfo2;
			}
			if (throwOnBindFailure)
			{
				throw new ArgumentException("Couldn't bind to method '" + method + "'.");
			}
			return null;
		}

		/// <summary>Создает делегат заданного типа, представляющий заданный статический метод заданного класса с заданными установками учета регистра и поведением на случай, если операция связывания завершится неудачей.</summary>
		/// <param name="type">
		///   <see cref="T:System.Type" /> создаваемого делегата.</param>
		/// <param name="target">Тип <see cref="T:System.Type" />, представляющий класс, в котором реализован метод <paramref name="method" />.</param>
		/// <param name="method">Имя статического метода, который должен быть представлен делегатом.</param>
		/// <param name="ignoreCase">Логическое значение, указывающее, следует ли учитывать регистр при сравнении имени метода.</param>
		/// <param name="throwOnBindFailure">Значение <see langword="true" /> для создания исключения, если метод <paramref name="method" /> привязать невозможно; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Делегат указанного типа, представляющий заданный статический метод заданного класса.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="type" /> — <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="target" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  <paramref name="method" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="type" /> не является производным от <see cref="T:System.MulticastDelegate" />.  
		/// -или- 
		///  <paramref name="type" /> не является объектом типа <see langword="RuntimeType" />. См. статью Типы среды выполнения в отражении.  
		/// -или- 
		///  <paramref name="target" /> не является объектом <see langword="RuntimeType" />.  
		/// -или- 
		///  <paramref name="target" /> представляет собой открытый универсальный тип. То есть свойство <see cref="P:System.Type.ContainsGenericParameters" /> имеет значение <see langword="true" />.  
		/// -или- 
		///  <paramref name="method" /> не является методом <see langword="static" /> (метод <see langword="Shared" /> в Visual Basic).  
		/// -или- 
		///  Параметр <paramref name="method" /> невозможно привязать, например, потому, что его невозможно найти, а <paramref name="throwOnBindFailure" /> имеет значение <see langword="true" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Метод <see langword="Invoke" /> для <paramref name="type" /> не найден.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий код не имеет необходимых разрешений для доступа к <paramref name="method" />.</exception>
		// Token: 0x060019AB RID: 6571 RVA: 0x0005F4F8 File Offset: 0x0005D6F8
		public static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase, bool throwOnBindFailure)
		{
			if (target == null)
			{
				throw new ArgumentNullException("target");
			}
			MethodInfo candidateMethod = Delegate.GetCandidateMethod(type, target, method, BindingFlags.Static, ignoreCase, throwOnBindFailure);
			if (candidateMethod == null)
			{
				return null;
			}
			return Delegate.CreateDelegate_internal(type, null, candidateMethod, throwOnBindFailure);
		}

		/// <summary>Создает делегат указанного типа, представляющий заданный статический метод заданного класса.</summary>
		/// <param name="type">
		///   <see cref="T:System.Type" /> создаваемого делегата.</param>
		/// <param name="target">Тип <see cref="T:System.Type" />, представляющий класс, в котором реализован метод <paramref name="method" />.</param>
		/// <param name="method">Имя статического метода, который должен быть представлен делегатом.</param>
		/// <returns>Делегат указанного типа, представляющий заданный статический метод заданного класса.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="type" /> — <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="target" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  <paramref name="method" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="type" /> не является производным от <see cref="T:System.MulticastDelegate" />.  
		/// -или- 
		///  <paramref name="type" /> не является объектом типа <see langword="RuntimeType" />. См. статью Типы среды выполнения в отражении.  
		/// -или- 
		///  <paramref name="target" /> не является объектом <see langword="RuntimeType" />.  
		/// -или- 
		///  <paramref name="target" /> представляет собой открытый универсальный тип. То есть свойство <see cref="P:System.Type.ContainsGenericParameters" /> имеет значение <see langword="true" />.  
		/// -или- 
		///  <paramref name="method" /> не является методом <see langword="static" /> (метод <see langword="Shared" /> в Visual Basic).  
		/// -или- 
		///  Параметр <paramref name="method" /> невозможно привязать, например, потому, что его невозможно найти, а <paramref name="throwOnBindFailure" /> имеет значение <see langword="true" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Метод <see langword="Invoke" /> для <paramref name="type" /> не найден.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий код не имеет необходимых разрешений для доступа к <paramref name="method" />.</exception>
		// Token: 0x060019AC RID: 6572 RVA: 0x0005F53B File Offset: 0x0005D73B
		public static Delegate CreateDelegate(Type type, Type target, string method)
		{
			return Delegate.CreateDelegate(type, target, method, false, true);
		}

		/// <summary>Создает делегат указанного типа, представляющий заданный статический метод заданного класса с заданной установкой учета регистра.</summary>
		/// <param name="type">
		///   <see cref="T:System.Type" /> создаваемого делегата.</param>
		/// <param name="target">Тип <see cref="T:System.Type" />, представляющий класс, в котором реализован метод <paramref name="method" />.</param>
		/// <param name="method">Имя статического метода, который должен быть представлен делегатом.</param>
		/// <param name="ignoreCase">Логическое значение, указывающее, следует ли учитывать регистр при сравнении имени метода.</param>
		/// <returns>Делегат указанного типа, представляющий заданный статический метод заданного класса.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="type" /> — <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="target" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  <paramref name="method" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="type" /> не является производным от <see cref="T:System.MulticastDelegate" />.  
		/// -или- 
		///  <paramref name="type" /> не является объектом типа <see langword="RuntimeType" />. См. статью Типы среды выполнения в отражении.  
		/// -или- 
		///  <paramref name="target" /> не является объектом <see langword="RuntimeType" />.  
		/// -или- 
		///  <paramref name="target" /> представляет собой открытый универсальный тип. То есть свойство <see cref="P:System.Type.ContainsGenericParameters" /> имеет значение <see langword="true" />.  
		/// -или- 
		///  <paramref name="method" /> не является методом <see langword="static" /> (метод <see langword="Shared" /> в Visual Basic).  
		/// -или- 
		///  Параметр <paramref name="method" /> невозможно привязать, например, потому, что его не удалось найти.</exception>
		/// <exception cref="T:System.MissingMethodException">Метод <see langword="Invoke" /> для <paramref name="type" /> не найден.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий код не имеет необходимых разрешений для доступа к <paramref name="method" />.</exception>
		// Token: 0x060019AD RID: 6573 RVA: 0x0005F547 File Offset: 0x0005D747
		public static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase)
		{
			return Delegate.CreateDelegate(type, target, method, ignoreCase, true);
		}

		/// <summary>Создает делегат указанного типа, представляющий заданный статический метод, вызываемый для заданного экземпляра класса с заданной установкой учета регистра и заданным поведением на случай, если операция связывания завершится неудачей.</summary>
		/// <param name="type">
		///   <see cref="T:System.Type" /> создаваемого делегата.</param>
		/// <param name="target">Экземпляр класса, для которого вызывается метод <paramref name="method" />.</param>
		/// <param name="method">Имя метода экземпляра, который должен быть представлен делегатом.</param>
		/// <param name="ignoreCase">Логическое значение, указывающее, следует ли учитывать регистр при сравнении имени метода.</param>
		/// <param name="throwOnBindFailure">Значение <see langword="true" /> для создания исключения, если метод <paramref name="method" /> привязать невозможно; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Создает делегат указанного типа, представляющий заданный метод экземпляра, который вызывается для заданного экземпляра класса.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="type" /> — <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="target" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  <paramref name="method" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="type" /> не является производным от <see cref="T:System.MulticastDelegate" />.  
		/// -или- 
		///  <paramref name="type" /> не является объектом типа <see langword="RuntimeType" />. См. статью Типы среды выполнения в отражении.  
		/// -или- 
		///  <paramref name="method" /> не является методом экземпляра.  
		/// -или- 
		///  Параметр <paramref name="method" /> невозможно привязать, например, потому, что его невозможно найти, а <paramref name="throwOnBindFailure" /> имеет значение <see langword="true" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Метод <see langword="Invoke" /> для <paramref name="type" /> не найден.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий код не имеет необходимых разрешений для доступа к <paramref name="method" />.</exception>
		// Token: 0x060019AE RID: 6574 RVA: 0x0005F554 File Offset: 0x0005D754
		public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase, bool throwOnBindFailure)
		{
			if (target == null)
			{
				throw new ArgumentNullException("target");
			}
			MethodInfo candidateMethod = Delegate.GetCandidateMethod(type, target.GetType(), method, BindingFlags.Instance, ignoreCase, throwOnBindFailure);
			if (candidateMethod == null)
			{
				return null;
			}
			return Delegate.CreateDelegate_internal(type, target, candidateMethod, throwOnBindFailure);
		}

		/// <summary>Создает делегат указанного типа, представляющий заданный метод экземпляра, который вызывается из заданного экземпляра класса с заданной установкой учета регистра.</summary>
		/// <param name="type">
		///   <see cref="T:System.Type" /> создаваемого делегата.</param>
		/// <param name="target">Экземпляр класса, для которого вызывается метод <paramref name="method" />.</param>
		/// <param name="method">Имя метода экземпляра, который должен быть представлен делегатом.</param>
		/// <param name="ignoreCase">Логическое значение, указывающее, следует ли учитывать регистр при сравнении имени метода.</param>
		/// <returns>Создает делегат указанного типа, представляющий заданный метод экземпляра, который вызывается для заданного экземпляра класса.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="type" /> — <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="target" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  <paramref name="method" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="type" /> не является производным от <see cref="T:System.MulticastDelegate" />.  
		/// -или- 
		///  <paramref name="type" /> не является объектом типа <see langword="RuntimeType" />. См. статью Типы среды выполнения в отражении.  
		/// -или- 
		///  <paramref name="method" /> не является методом экземпляра.  
		/// -или- 
		///  Параметр <paramref name="method" /> невозможно привязать, например, потому, что его не удалось найти.</exception>
		/// <exception cref="T:System.MissingMethodException">Метод <see langword="Invoke" /> для <paramref name="type" /> не найден.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий код не имеет необходимых разрешений для доступа к <paramref name="method" />.</exception>
		// Token: 0x060019AF RID: 6575 RVA: 0x0005F596 File Offset: 0x0005D796
		public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase)
		{
			return Delegate.CreateDelegate(type, target, method, ignoreCase, true);
		}

		/// <summary>Динамически (с поздней привязкой) вызывает метод, представленный текущим делегатом.</summary>
		/// <param name="args">Массив объектов, которые передаются в качестве аргументов методу, представленному текущим делегатом.  
		/// -или- 
		///  Значение <see langword="null" />, если метод, представленный текущим делегатом, не требует аргументов.</param>
		/// <returns>Объект, возвращаемый методом, представленным делегатом.</returns>
		/// <exception cref="T:System.MemberAccessException">Вызывающий код не имеет доступа к методу, представленному делегатом (например, если это закрытый метод).  
		/// -или- 
		/// Количество, порядок или тип параметров в списке <paramref name="args" /> является недопустимым.</exception>
		/// <exception cref="T:System.ArgumentException">Представленный делегатом метод вызывается для объекта или класса, которые его не поддерживают.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Представленный делегатом метод является методом экземпляра, а целевой объект имеет значение <see langword="null" />.  
		/// -или- 
		/// Один из инкапсулированных методов выбрасывает исключение.</exception>
		// Token: 0x060019B0 RID: 6576 RVA: 0x0005F5A2 File Offset: 0x0005D7A2
		public object DynamicInvoke(params object[] args)
		{
			return this.DynamicInvokeImpl(args);
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x0005F5AC File Offset: 0x0005D7AC
		private void InitializeDelegateData()
		{
			DelegateData delegateData = new DelegateData();
			if (this.method_info.IsStatic)
			{
				if (this.m_target != null)
				{
					delegateData.curried_first_arg = true;
				}
				else if (base.GetType().GetMethod("Invoke").GetParametersCount() + 1 == this.method_info.GetParametersCount())
				{
					delegateData.curried_first_arg = true;
				}
			}
			this.data = delegateData;
		}

		/// <summary>Динамически (с поздней привязкой) вызывает метод, представленный текущим делегатом.</summary>
		/// <param name="args">Массив объектов, которые передаются в качестве аргументов методу, представленному текущим делегатом.  
		/// -или- 
		///  Значение <see langword="null" />, если метод, представленный текущим делегатом, не требует аргументов.</param>
		/// <returns>Объект, возвращаемый методом, представленным делегатом.</returns>
		/// <exception cref="T:System.MemberAccessException">Вызывающий код не имеет доступа к методу, представленному делегатом (например, если это закрытый метод).  
		/// -или- 
		/// Количество, порядок или тип параметров в списке <paramref name="args" /> является недопустимым.</exception>
		/// <exception cref="T:System.ArgumentException">Представленный делегатом метод вызывается для объекта или класса, которые его не поддерживают.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Представленный делегатом метод является методом экземпляра, а целевой объект имеет значение <see langword="null" />.  
		/// -или- 
		/// Один из инкапсулированных методов выбрасывает исключение.</exception>
		// Token: 0x060019B2 RID: 6578 RVA: 0x0005F610 File Offset: 0x0005D810
		protected virtual object DynamicInvokeImpl(object[] args)
		{
			if (this.Method == null)
			{
				Type[] array = new Type[args.Length];
				for (int i = 0; i < args.Length; i++)
				{
					array[i] = args[i].GetType();
				}
				this.method_info = this.m_target.GetType().GetMethod(this.data.method_name, array);
			}
			object obj = this.m_target;
			if (this.data == null)
			{
				this.InitializeDelegateData();
			}
			if (this.Method.IsStatic)
			{
				if (this.data.curried_first_arg)
				{
					if (args == null)
					{
						args = new object[]
						{
							obj
						};
					}
					else
					{
						Array.Resize<object>(ref args, args.Length + 1);
						Array.Copy(args, 0, args, 1, args.Length - 1);
						args[0] = obj;
					}
					obj = null;
				}
			}
			else if (this.m_target == null && args != null && args.Length != 0)
			{
				obj = args[0];
				Array.Copy(args, 1, args, 0, args.Length - 1);
				Array.Resize<object>(ref args, args.Length - 1);
			}
			return this.Method.Invoke(obj, args);
		}

		/// <summary>Создает неполную копию делегата.</summary>
		/// <returns>Неполная копия делегата.</returns>
		// Token: 0x060019B3 RID: 6579 RVA: 0x000231CD File Offset: 0x000213CD
		public virtual object Clone()
		{
			return base.MemberwiseClone();
		}

		/// <summary>Определяет, принадлежат ли заданный объект и текущий делегат к одному типу, и одинаковы ли их целевые объекты, методы и списки вызовов.</summary>
		/// <param name="obj">Объект, который требуется сравнить с текущим делегатом.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="obj" /> и текущий делегат имеют одинаковые целевые объекты, методы и списки вызовов, в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.MemberAccessException">Вызывающий код не имеет доступа к методу, представленному делегатом (например, если это закрытый метод).</exception>
		// Token: 0x060019B4 RID: 6580 RVA: 0x0005F70C File Offset: 0x0005D90C
		public override bool Equals(object obj)
		{
			Delegate @delegate = obj as Delegate;
			if (@delegate == null)
			{
				return false;
			}
			if (@delegate.m_target != this.m_target || !(@delegate.Method == this.Method))
			{
				return false;
			}
			if (@delegate.data == null && this.data == null)
			{
				return true;
			}
			if (@delegate.data != null && this.data != null)
			{
				return @delegate.data.target_type == this.data.target_type && @delegate.data.method_name == this.data.method_name;
			}
			if (@delegate.data != null)
			{
				return @delegate.data.target_type == null;
			}
			return this.data != null && this.data.target_type == null;
		}

		/// <summary>Возвращает хэш-код делегата.</summary>
		/// <returns>Хэш-код делегата.</returns>
		// Token: 0x060019B5 RID: 6581 RVA: 0x0005F7E4 File Offset: 0x0005D9E4
		public override int GetHashCode()
		{
			MethodInfo methodInfo = this.Method;
			return ((methodInfo != null) ? methodInfo.GetHashCode() : base.GetType().GetHashCode()) ^ RuntimeHelpers.GetHashCode(this.m_target);
		}

		/// <summary>Возвращает статический метод, представленный текущим делегатом.</summary>
		/// <returns>
		///   <see cref="T:System.Reflection.MethodInfo" />, описывающий статический метод, представленный текущим делегатом.</returns>
		/// <exception cref="T:System.MemberAccessException">Вызывающий код не имеет доступа к методу, представленному делегатом (например, если это закрытый метод).</exception>
		// Token: 0x060019B6 RID: 6582 RVA: 0x0005F820 File Offset: 0x0005DA20
		protected virtual MethodInfo GetMethodImpl()
		{
			if (this.method_info != null)
			{
				return this.method_info;
			}
			if (this.method != IntPtr.Zero)
			{
				if (!this.method_is_virtual)
				{
					this.method_info = (MethodInfo)RuntimeMethodInfo.GetMethodFromHandleNoGenericCheck(new RuntimeMethodHandle(this.method));
				}
				else
				{
					this.method_info = this.GetVirtualMethod_internal();
				}
			}
			return this.method_info;
		}

		/// <summary>Не поддерживается.</summary>
		/// <param name="info">Не поддерживается.</param>
		/// <param name="context">Не поддерживается.</param>
		/// <exception cref="T:System.NotSupportedException">Этот метод не поддерживается.</exception>
		// Token: 0x060019B7 RID: 6583 RVA: 0x0005F88B File Offset: 0x0005DA8B
		[SecurityCritical]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			DelegateSerializationHolder.GetDelegateData(this, info, context);
		}

		/// <summary>Возвращает список вызовов делегата.</summary>
		/// <returns>Массив делегатов, представляющих список вызовов текущего делегата.</returns>
		// Token: 0x060019B8 RID: 6584 RVA: 0x0005F895 File Offset: 0x0005DA95
		public virtual Delegate[] GetInvocationList()
		{
			return new Delegate[]
			{
				this
			};
		}

		/// <summary>Сцепляет списки вызовов двух делегатов.</summary>
		/// <param name="a">Делегат, список вызовов которого передан первым.</param>
		/// <param name="b">Делегат, список вызовов которого передан вторым.</param>
		/// <returns>Новый делегат со списком вызовов, представляющим собой сцепление списков вызовов, заданных в параметрах <paramref name="a" /> и <paramref name="b" /> в указанном порядке. Возвращает <paramref name="a" />, если <paramref name="b" /> имеет значение <see langword="null" />; возвращает <paramref name="b" />, если <paramref name="a" /> является пустой ссылкой; возвращает пустую ссылку, если <paramref name="a" /> и <paramref name="b" /> являются пустыми ссылками.</returns>
		/// <exception cref="T:System.ArgumentException">Значение обоих параметров, <paramref name="a" /> и <paramref name="b" />, не равно <see langword="null" />, и эти параметры <paramref name="a" /> и <paramref name="b" /> не являются экземплярами одного и того же типа делегата.</exception>
		// Token: 0x060019B9 RID: 6585 RVA: 0x0005F8A4 File Offset: 0x0005DAA4
		public static Delegate Combine(Delegate a, Delegate b)
		{
			if (a == null)
			{
				return b;
			}
			if (b == null)
			{
				return a;
			}
			if (a.GetType() != b.GetType())
			{
				throw new ArgumentException(string.Format("Incompatible Delegate Types. First is {0} second is {1}.", a.GetType().FullName, b.GetType().FullName));
			}
			return a.CombineImpl(b);
		}

		/// <summary>Сцепляет списки вызовов массива делегатов.</summary>
		/// <param name="delegates">Массив комбинируемых делегатов.</param>
		/// <returns>Новый делегат со списком вызовов, представляющим собой сцепление списков вызовов делегатов, заданных в массиве <paramref name="delegates" />. Возвращает <see langword="null" />, если <paramref name="delegates" /> имеет значение <see langword="null" />, либо <paramref name="delegates" /> содержит нуль элементов, либо каждый элемент в <paramref name="delegates" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">Не все ненулевые элементы в <paramref name="delegates" /> являются экземплярами одного типа делегата.</exception>
		// Token: 0x060019BA RID: 6586 RVA: 0x0005F8FC File Offset: 0x0005DAFC
		[ComVisible(true)]
		public static Delegate Combine(params Delegate[] delegates)
		{
			if (delegates == null)
			{
				return null;
			}
			Delegate @delegate = null;
			foreach (Delegate b in delegates)
			{
				@delegate = Delegate.Combine(@delegate, b);
			}
			return @delegate;
		}

		/// <summary>Сцепляет списки вызовов заданного группового (комбинируемого) делегата и текущего группового (комбинируемого) делегата.</summary>
		/// <param name="d">Групповой (комбинируемый) делегат, чей список вызовов необходимо добавить в конец списка вызовов текущего группового (комбинируемого) делегата.</param>
		/// <returns>Новый групповой (комбинируемый) делегат со списком вызовов, состоящим из сцепления списков вызовов текущего группового (комбинируемого) делегата и делегата, заданного в параметре <paramref name="d" />, или текущий групповой (комбинируемый) делегат, если <paramref name="d" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.MulticastNotSupportedException">Возникает всегда.</exception>
		// Token: 0x060019BB RID: 6587 RVA: 0x0005F92D File Offset: 0x0005DB2D
		protected virtual Delegate CombineImpl(Delegate d)
		{
			throw new MulticastNotSupportedException(string.Empty);
		}

		/// <summary>Удаляет последнее вхождение списка вызовов делегата из списка вызовов другого делегата.</summary>
		/// <param name="source">Делегат, из списка вызовов которого необходимо удалить список вызовов <paramref name="value" />.</param>
		/// <param name="value">Делегат, представляющий список вызовов, который необходимо удалить из списка вызовов <paramref name="source" />.</param>
		/// <returns>Новый делегат со списком вызовов, сформированным путем удаления из <paramref name="source" /> последнего вхождения списка вызовов <paramref name="value" />, если список вызовов <paramref name="value" /> найден в списке вызовов <paramref name="source" />. Возвращает <paramref name="source" />, если <paramref name="value" /> имеет значение <see langword="null" /> либо список вызовов <paramref name="value" /> не найден в списке вызовов <paramref name="source" />. Возвращает пустую ссылку, если список вызовов <paramref name="value" /> равен списку вызовов <paramref name="source" /> либо <paramref name="source" /> является пустой ссылкой.</returns>
		/// <exception cref="T:System.MemberAccessException">Вызывающий код не имеет доступа к методу, представленному делегатом (например, если это закрытый метод).</exception>
		/// <exception cref="T:System.ArgumentException">Типы делегатов не совпадают.</exception>
		// Token: 0x060019BC RID: 6588 RVA: 0x0005F93C File Offset: 0x0005DB3C
		public static Delegate Remove(Delegate source, Delegate value)
		{
			if (source == null)
			{
				return null;
			}
			if (value == null)
			{
				return source;
			}
			if (source.GetType() != value.GetType())
			{
				throw new ArgumentException(string.Format("Incompatible Delegate Types. First is {0} second is {1}.", source.GetType().FullName, value.GetType().FullName));
			}
			return source.RemoveImpl(value);
		}

		/// <summary>Удаляет список вызовов одного делегата из списка вызовов другого делегата.</summary>
		/// <param name="d">Делегат, представляющий список вызовов, который необходимо удалить из списка вызовов текущего делегата.</param>
		/// <returns>Новый делегат со списком вызовов, сформированным удаления списка вызовов <paramref name="value" /> из списка вызовов текущего делегата, если список вызовов <paramref name="value" /> найден в списке вызовов текущего делегата. Возвращает текущий делегат, если <paramref name="value" /> имеет значение <see langword="null" /> или список вызовов <paramref name="value" /> не найден в списке вызовов текущего делегата. Возвращает <see langword="null" />, если список вызовов <paramref name="value" /> равен списку вызовов текущего делегата.</returns>
		/// <exception cref="T:System.MemberAccessException">Вызывающий код не имеет доступа к методу, представленному делегатом (например, если это закрытый метод).</exception>
		// Token: 0x060019BD RID: 6589 RVA: 0x0005F993 File Offset: 0x0005DB93
		protected virtual Delegate RemoveImpl(Delegate d)
		{
			if (this.Equals(d))
			{
				return null;
			}
			return this;
		}

		/// <summary>Удаляет все вхождения списка вызовов одного делегата из списка вызовов другого делегата.</summary>
		/// <param name="source">Делегат, из списка вызовов которого необходимо удалить список вызовов <paramref name="value" />.</param>
		/// <param name="value">Делегат, представляющий список вызовов, который необходимо удалить из списка вызовов <paramref name="source" />.</param>
		/// <returns>Новый делегат со списком вызовов, сформированным путем удаления из списка вызовов <paramref name="source" /> всех вхождений списка вызовов <paramref name="value" />, если список вызовов <paramref name="value" /> найден в списке вызовов <paramref name="source" />. Возвращает <paramref name="source" />, если <paramref name="value" /> имеет значение <see langword="null" /> либо список вызовов <paramref name="value" /> не найден в списке вызовов <paramref name="source" />. Возвращает пустую ссылку, если список вызовов <paramref name="value" /> равен списку вызовов <paramref name="source" />, либо список вызовов <paramref name="source" /> содержит только списки вызовов <paramref name="value" />, либо <paramref name="source" /> является пустой ссылкой.</returns>
		/// <exception cref="T:System.MemberAccessException">Вызывающий код не имеет доступа к методу, представленному делегатом (например, если это закрытый метод).</exception>
		/// <exception cref="T:System.ArgumentException">Типы делегатов не совпадают.</exception>
		// Token: 0x060019BE RID: 6590 RVA: 0x0005F9A4 File Offset: 0x0005DBA4
		public static Delegate RemoveAll(Delegate source, Delegate value)
		{
			Delegate @delegate = source;
			while ((source = Delegate.Remove(source, value)) != @delegate)
			{
				@delegate = source;
			}
			return @delegate;
		}

		/// <summary>Определяет, равны ли два заданных делегата.</summary>
		/// <param name="d1">Первый делегат для операции сравнения.</param>
		/// <param name="d2">Второй делегат для операции сравнения.</param>
		/// <returns>
		///   <see langword="true" />, если значения параметров <paramref name="d1" /> и <paramref name="d2" /> равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060019BF RID: 6591 RVA: 0x0005F9CA File Offset: 0x0005DBCA
		public static bool operator ==(Delegate d1, Delegate d2)
		{
			if (d1 == null)
			{
				return d2 == null;
			}
			return d2 != null && d1.Equals(d2);
		}

		/// <summary>Определяет, являются ли заданные делегаты неравными.</summary>
		/// <param name="d1">Первый делегат для операции сравнения.</param>
		/// <param name="d2">Второй делегат для операции сравнения.</param>
		/// <returns>
		///   <see langword="true" />, если значения <paramref name="d1" /> и <paramref name="d2" /> не равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060019C0 RID: 6592 RVA: 0x0005F9E2 File Offset: 0x0005DBE2
		public static bool operator !=(Delegate d1, Delegate d2)
		{
			return !(d1 == d2);
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x0005F9EE File Offset: 0x0005DBEE
		internal bool IsTransparentProxy()
		{
			return RemotingServices.IsTransparentProxy(this.m_target);
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x0005F9FB File Offset: 0x0005DBFB
		internal static Delegate CreateDelegateNoSecurityCheck(RuntimeType type, object firstArgument, MethodInfo method)
		{
			return Delegate.CreateDelegate_internal(type, firstArgument, method, true);
		}

		// Token: 0x060019C3 RID: 6595
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern MulticastDelegate AllocDelegateLike_internal(Delegate d);

		// Token: 0x040016FF RID: 5887
		private IntPtr method_ptr;

		// Token: 0x04001700 RID: 5888
		private IntPtr invoke_impl;

		// Token: 0x04001701 RID: 5889
		private object m_target;

		// Token: 0x04001702 RID: 5890
		private IntPtr method;

		// Token: 0x04001703 RID: 5891
		private IntPtr delegate_trampoline;

		// Token: 0x04001704 RID: 5892
		private IntPtr extra_arg;

		// Token: 0x04001705 RID: 5893
		private IntPtr method_code;

		// Token: 0x04001706 RID: 5894
		private IntPtr interp_method;

		// Token: 0x04001707 RID: 5895
		private IntPtr interp_invoke_impl;

		// Token: 0x04001708 RID: 5896
		private MethodInfo method_info;

		// Token: 0x04001709 RID: 5897
		private MethodInfo original_method_info;

		// Token: 0x0400170A RID: 5898
		private DelegateData data;

		// Token: 0x0400170B RID: 5899
		private bool method_is_virtual;
	}
}
