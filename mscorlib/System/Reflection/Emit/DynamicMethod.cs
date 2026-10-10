using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Reflection.Emit
{
	/// <summary>Определяет и представляет динамический метод, который можно скомпилировать, выполнить и удалить. Удаленные методы доступны для сборки мусора.</summary>
	// Token: 0x0200091D RID: 2333
	[ComVisible(true)]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class DynamicMethod : MethodInfo
	{
		/// <summary>Создает динамический метод, который является глобальным по отношению к модулю, используя имя метода, возвращаемый тип, типы параметров и модуль.</summary>
		/// <param name="name">Имя динамического метода. Это может быть строка нулевой длины, но не <see langword="null" />.</param>
		/// <param name="returnType">Объект <see cref="T:System.Type" />, который указывает возвращаемый тип динамического метода, или значение <see langword="null" />, если метод не имеет возвращаемого типа.</param>
		/// <param name="parameterTypes">Массив объектов <see cref="T:System.Type" />, указывающих типы параметров динамического метода, или значение <see langword="null" />, если метод не имеет параметров.</param>
		/// <param name="m">Объект <see cref="T:System.Reflection.Module" />, представляющий модуль, с которым должен быть логически связан динамический метод.</param>
		/// <exception cref="T:System.ArgumentException">Элемент <paramref name="parameterTypes" /> имеет значение <see langword="null" /> или <see cref="T:System.Void" />.  
		///
		/// или - 
		/// <paramref name="m" /> — это модуль, предоставляющий анонимное размещение для динамических методов.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="m" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="returnType" /> — это тип, для которого <see cref="P:System.Type.IsByRef" /> возвращает <see langword="true" />.</exception>
		// Token: 0x06004F74 RID: 20340 RVA: 0x000F9B9F File Offset: 0x000F7D9F
		public DynamicMethod(string name, Type returnType, Type[] parameterTypes, Module m) : this(name, returnType, parameterTypes, m, false)
		{
		}

		/// <summary>Создает динамический метод, указывая имя метода, возвращаемый тип, типы параметров и тип, с которым логически связан динамический метод.</summary>
		/// <param name="name">Имя динамического метода. Это может быть строка нулевой длины, но не <see langword="null" />.</param>
		/// <param name="returnType">Объект <see cref="T:System.Type" />, который указывает возвращаемый тип динамического метода, или значение <see langword="null" />, если метод не имеет возвращаемого типа.</param>
		/// <param name="parameterTypes">Массив объектов <see cref="T:System.Type" />, указывающих типы параметров динамического метода, или значение <see langword="null" />, если метод не имеет параметров.</param>
		/// <param name="owner">Тип <see cref="T:System.Type" />, с которым логически связан динамический метод. Динамический метод имеет доступ ко всем членам типа.</param>
		/// <exception cref="T:System.ArgumentException">Элемент <paramref name="parameterTypes" /> имеет значение <see langword="null" /> или <see cref="T:System.Void" />.  
		///
		/// или - 
		/// <paramref name="owner" /> является интерфейсом, массивом, открытым универсальным типом или параметром универсального типа или метода.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="owner" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="returnType" /> имеет значение <see langword="null" /> или является типом, для которого <see cref="P:System.Type.IsByRef" /> возвращает <see langword="true" />.</exception>
		// Token: 0x06004F75 RID: 20341 RVA: 0x000F9BAD File Offset: 0x000F7DAD
		public DynamicMethod(string name, Type returnType, Type[] parameterTypes, Type owner) : this(name, returnType, parameterTypes, owner, false)
		{
		}

		/// <summary>Создает динамический метод, который является глобальным для модуля, указывая имя метода, возвращаемый тип, типы параметров, модуль и необходимость пропуска проверки видимости JIT для типов и членов, к которым получает доступ MSIL динамического метода.</summary>
		/// <param name="name">Имя динамического метода. Это может быть строка нулевой длины, но не <see langword="null" />.</param>
		/// <param name="returnType">Объект <see cref="T:System.Type" />, который указывает возвращаемый тип динамического метода, или значение <see langword="null" />, если метод не имеет возвращаемого типа.</param>
		/// <param name="parameterTypes">Массив объектов <see cref="T:System.Type" />, указывающих типы параметров динамического метода, или значение <see langword="null" />, если метод не имеет параметров.</param>
		/// <param name="m">Объект <see cref="T:System.Reflection.Module" />, представляющий модуль, с которым должен быть логически связан динамический метод.</param>
		/// <param name="skipVisibility">Значение <see langword="true" /> для пропуска проверки видимости JIT для типов и членов, к которым получает доступ MSIL динамического метода.</param>
		/// <exception cref="T:System.ArgumentException">Элемент <paramref name="parameterTypes" /> имеет значение <see langword="null" /> или <see cref="T:System.Void" />.  
		///
		/// или - 
		/// <paramref name="m" /> — это модуль, предоставляющий анонимное размещение для динамических методов.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="m" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="returnType" /> — это тип, для которого <see cref="P:System.Type.IsByRef" /> возвращает <see langword="true" />.</exception>
		// Token: 0x06004F76 RID: 20342 RVA: 0x000F9BBB File Offset: 0x000F7DBB
		public DynamicMethod(string name, Type returnType, Type[] parameterTypes, Module m, bool skipVisibility) : this(name, MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Static, CallingConventions.Standard, returnType, parameterTypes, m, skipVisibility)
		{
		}

		/// <summary>Создает динамический метод, указывая имя метода, возвращаемый тип, типы параметров, тип, с которым логически связан динамический метод, и необходимость пропуска проверки видимости JIT для типов и членов, к которым получает доступ MSIL динамического метода.</summary>
		/// <param name="name">Имя динамического метода. Это может быть строка нулевой длины, но не <see langword="null" />.</param>
		/// <param name="returnType">Объект <see cref="T:System.Type" />, который указывает возвращаемый тип динамического метода, или значение <see langword="null" />, если метод не имеет возвращаемого типа.</param>
		/// <param name="parameterTypes">Массив объектов <see cref="T:System.Type" />, указывающих типы параметров динамического метода, или значение <see langword="null" />, если метод не имеет параметров.</param>
		/// <param name="owner">Тип <see cref="T:System.Type" />, с которым логически связан динамический метод. Динамический метод имеет доступ ко всем членам типа.</param>
		/// <param name="skipVisibility">Значение <see langword="true" /> для пропуска проверки видимости JIT для типов и членов, к которым получает доступ MSIL динамического метода; в противном случае — значение <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentException">Элемент <paramref name="parameterTypes" /> имеет значение <see langword="null" /> или <see cref="T:System.Void" />.  
		///
		/// или - 
		/// <paramref name="owner" /> является интерфейсом, массивом, открытым универсальным типом или параметром универсального типа или метода.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="owner" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="returnType" /> имеет значение <see langword="null" /> или является типом, для которого <see cref="P:System.Type.IsByRef" /> возвращает <see langword="true" />.</exception>
		// Token: 0x06004F77 RID: 20343 RVA: 0x000F9BCD File Offset: 0x000F7DCD
		public DynamicMethod(string name, Type returnType, Type[] parameterTypes, Type owner, bool skipVisibility) : this(name, MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Static, CallingConventions.Standard, returnType, parameterTypes, owner, skipVisibility)
		{
		}

		/// <summary>Создает динамический метод, указывая имя метода, атрибуты, соглашение о вызовах, возвращаемый тип, типы параметров, тип, с которым логически связан динамический метод, и необходимость пропуска проверки видимости JIT для типов и членов, к которым получает доступ промежуточный язык Майкрософт (MSIL) динамического метода.</summary>
		/// <param name="name">Имя динамического метода. Это может быть строка нулевой длины, но не <see langword="null" />.</param>
		/// <param name="attributes">Битовая комбинация значений <see cref="T:System.Reflection.MethodAttributes" />, определяющая атрибуты динамического метода. Разрешена только комбинация <see cref="F:System.Reflection.MethodAttributes.Public" /> и <see cref="F:System.Reflection.MethodAttributes.Static" />.</param>
		/// <param name="callingConvention">Соглашение о вызовах для динамического метода. Должно иметь значение <see cref="F:System.Reflection.CallingConventions.Standard" />.</param>
		/// <param name="returnType">Объект <see cref="T:System.Type" />, который указывает возвращаемый тип динамического метода, или значение <see langword="null" />, если метод не имеет возвращаемого типа.</param>
		/// <param name="parameterTypes">Массив объектов <see cref="T:System.Type" />, указывающих типы параметров динамического метода, или значение <see langword="null" />, если метод не имеет параметров.</param>
		/// <param name="owner">Тип <see cref="T:System.Type" />, с которым логически связан динамический метод. Динамический метод имеет доступ ко всем членам типа.</param>
		/// <param name="skipVisibility">Значение <see langword="true" /> для пропуска проверки видимости JIT для типов и членов, к которым получает доступ MSIL динамического метода; в противном случае — значение <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentException">Элемент <paramref name="parameterTypes" /> имеет значение <see langword="null" /> или <see cref="T:System.Void" />.  
		///
		/// или - 
		/// <paramref name="owner" /> является интерфейсом, массивом, открытым универсальным типом или параметром универсального типа или метода.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="owner" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="attributes" /> представляет собой сочетание флагов, отличных от <see cref="F:System.Reflection.MethodAttributes.Public" /> и <see cref="F:System.Reflection.MethodAttributes.Static" />.  
		///
		/// или - 
		/// <paramref name="callingConvention" /> не является <see cref="F:System.Reflection.CallingConventions.Standard" />.  
		///
		/// или - 
		/// <paramref name="returnType" /> — это тип, для которого <see cref="P:System.Type.IsByRef" /> возвращает <see langword="true" />.</exception>
		// Token: 0x06004F78 RID: 20344 RVA: 0x000F9BE0 File Offset: 0x000F7DE0
		public DynamicMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, Type owner, bool skipVisibility) : this(name, attributes, callingConvention, returnType, parameterTypes, owner, owner.Module, skipVisibility, false)
		{
		}

		/// <summary>Создает динамический метод, который является глобальным для модуля, указывая имя метода, атрибуты, соглашение о вызовах, возвращаемый тип, типы параметров, модуль и необходимость пропуска проверки видимости JIT для типов и членов, к которым получает доступ промежуточный язык Майкрософт (MSIL) динамического метода.</summary>
		/// <param name="name">Имя динамического метода. Это может быть строка нулевой длины, но не <see langword="null" />.</param>
		/// <param name="attributes">Битовая комбинация значений <see cref="T:System.Reflection.MethodAttributes" />, определяющая атрибуты динамического метода. Разрешена только комбинация <see cref="F:System.Reflection.MethodAttributes.Public" /> и <see cref="F:System.Reflection.MethodAttributes.Static" />.</param>
		/// <param name="callingConvention">Соглашение о вызовах для динамического метода. Должно иметь значение <see cref="F:System.Reflection.CallingConventions.Standard" />.</param>
		/// <param name="returnType">Объект <see cref="T:System.Type" />, который указывает возвращаемый тип динамического метода, или значение <see langword="null" />, если метод не имеет возвращаемого типа.</param>
		/// <param name="parameterTypes">Массив объектов <see cref="T:System.Type" />, указывающих типы параметров динамического метода, или значение <see langword="null" />, если метод не имеет параметров.</param>
		/// <param name="m">Объект <see cref="T:System.Reflection.Module" />, представляющий модуль, с которым должен быть логически связан динамический метод.</param>
		/// <param name="skipVisibility">Значение <see langword="true" /> для пропуска проверки видимости JIT для типов и членов, к которым получает доступ MSIL динамического метода; в противном случае — значение <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentException">Элемент <paramref name="parameterTypes" /> имеет значение <see langword="null" /> или <see cref="T:System.Void" />.  
		///
		/// или - 
		/// <paramref name="m" /> — это модуль, предоставляющий анонимное размещение для динамических методов.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="m" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="attributes" /> представляет собой сочетание флагов, отличных от <see cref="F:System.Reflection.MethodAttributes.Public" /> и <see cref="F:System.Reflection.MethodAttributes.Static" />.  
		///
		/// или - 
		/// <paramref name="callingConvention" /> не является <see cref="F:System.Reflection.CallingConventions.Standard" />.  
		///
		/// или - 
		/// <paramref name="returnType" /> — это тип, для которого <see cref="P:System.Type.IsByRef" /> возвращает <see langword="true" />.</exception>
		// Token: 0x06004F79 RID: 20345 RVA: 0x000F9C08 File Offset: 0x000F7E08
		public DynamicMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, Module m, bool skipVisibility) : this(name, attributes, callingConvention, returnType, parameterTypes, null, m, skipVisibility, false)
		{
		}

		/// <summary>Инициализирует анонимно размещенный динамический метод, указывая имя метода, возвращаемый тип и типы параметров.</summary>
		/// <param name="name">Имя динамического метода. Это может быть строка нулевой длины, но не <see langword="null" />.</param>
		/// <param name="returnType">Объект <see cref="T:System.Type" />, который указывает возвращаемый тип динамического метода, или значение <see langword="null" />, если метод не имеет возвращаемого типа.</param>
		/// <param name="parameterTypes">Массив объектов <see cref="T:System.Type" />, указывающих типы параметров динамического метода, или значение <see langword="null" />, если метод не имеет параметров.</param>
		/// <exception cref="T:System.ArgumentException">Элемент <paramref name="parameterTypes" /> имеет значение <see langword="null" /> или <see cref="T:System.Void" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="returnType" /> — это тип, для которого <see cref="P:System.Type.IsByRef" /> возвращает <see langword="true" />.</exception>
		// Token: 0x06004F7A RID: 20346 RVA: 0x000F9C28 File Offset: 0x000F7E28
		public DynamicMethod(string name, Type returnType, Type[] parameterTypes) : this(name, returnType, parameterTypes, false)
		{
		}

		/// <summary>Инициализирует анонимно размещенный динамический метод, указывая имя метода, возвращаемый тип, типы параметров и необходимость пропуска проверки видимости JIT для типов и членов, к которым получает доступ MSIL динамического метода.</summary>
		/// <param name="name">Имя динамического метода. Это может быть строка нулевой длины, но не <see langword="null" />.</param>
		/// <param name="returnType">Объект <see cref="T:System.Type" />, который указывает возвращаемый тип динамического метода, или значение <see langword="null" />, если метод не имеет возвращаемого типа.</param>
		/// <param name="parameterTypes">Массив объектов <see cref="T:System.Type" />, указывающих типы параметров динамического метода, или значение <see langword="null" />, если метод не имеет параметров.</param>
		/// <param name="restrictedSkipVisibility">
		///   <see langword="true" /> — пропускает проверки видимости JIT для типов и членов, к которым получает доступ MSIL динамического метода, с таким ограничением: уровень доверия сборок, содержащих эти типы и члены, должен быть равен уровню доверия стека вызовов, создающего динамический метод, или меньше его. В противном случае — <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentException">Элемент <paramref name="parameterTypes" /> имеет значение <see langword="null" /> или <see cref="T:System.Void" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="returnType" /> — это тип, для которого <see cref="P:System.Type.IsByRef" /> возвращает <see langword="true" />.</exception>
		// Token: 0x06004F7B RID: 20347 RVA: 0x000F9C34 File Offset: 0x000F7E34
		[MonoTODO("Visibility is not restricted")]
		public DynamicMethod(string name, Type returnType, Type[] parameterTypes, bool restrictedSkipVisibility) : this(name, MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Static, CallingConventions.Standard, returnType, parameterTypes, null, null, restrictedSkipVisibility, true)
		{
		}

		// Token: 0x06004F7C RID: 20348 RVA: 0x000F9C54 File Offset: 0x000F7E54
		private DynamicMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, Type owner, Module m, bool skipVisibility, bool anonHosted)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (returnType == null)
			{
				returnType = typeof(void);
			}
			if (m == null && !anonHosted)
			{
				throw new ArgumentNullException("m");
			}
			if (returnType.IsByRef)
			{
				throw new ArgumentException("Return type can't be a byref type", "returnType");
			}
			if (parameterTypes != null)
			{
				for (int i = 0; i < parameterTypes.Length; i++)
				{
					if (parameterTypes[i] == null)
					{
						throw new ArgumentException("Parameter " + i.ToString() + " is null", "parameterTypes");
					}
				}
			}
			if (owner != null && (owner.IsArray || owner.IsInterface))
			{
				throw new ArgumentException("Owner can't be an array or an interface.");
			}
			if (m == null)
			{
				m = DynamicMethod.AnonHostModuleHolder.AnonHostModule;
			}
			this.name = name;
			this.attributes = (attributes | MethodAttributes.Static);
			this.callingConvention = callingConvention;
			this.returnType = returnType;
			this.parameters = parameterTypes;
			this.owner = owner;
			this.module = m;
			this.skipVisibility = skipVisibility;
		}

		// Token: 0x06004F7D RID: 20349
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void create_dynamic_method(DynamicMethod m);

		// Token: 0x06004F7E RID: 20350 RVA: 0x000F9D7C File Offset: 0x000F7F7C
		private void CreateDynMethod()
		{
			lock (this)
			{
				if (this.mhandle.Value == IntPtr.Zero)
				{
					if (this.ilgen == null || this.ilgen.ILOffset == 0)
					{
						throw new InvalidOperationException("Method '" + this.name + "' does not have a method body.");
					}
					this.ilgen.label_fixup(this);
					try
					{
						this.creating = true;
						if (this.refs != null)
						{
							for (int i = 0; i < this.refs.Length; i++)
							{
								if (this.refs[i] is DynamicMethod)
								{
									DynamicMethod dynamicMethod = (DynamicMethod)this.refs[i];
									if (!dynamicMethod.creating)
									{
										dynamicMethod.CreateDynMethod();
									}
								}
							}
						}
					}
					finally
					{
						this.creating = false;
					}
					DynamicMethod.create_dynamic_method(this);
					this.ilgen = null;
				}
			}
		}

		/// <summary>Завершает динамический метод и создает делегата, который может использоваться для его выполнения.</summary>
		/// <param name="delegateType">Тип делегата, подпись которого совпадает с подписью динамического метода.</param>
		/// <returns>Делегат указанного типа, который может использоваться для выполнения динамического метода.</returns>
		/// <exception cref="T:System.InvalidOperationException">У динамического метода отсутствует тело метода.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="delegateType" /> имеет неверное число параметров или неправильные типы параметров.</exception>
		// Token: 0x06004F7F RID: 20351 RVA: 0x000F9E78 File Offset: 0x000F8078
		[ComVisible(true)]
		public sealed override Delegate CreateDelegate(Type delegateType)
		{
			if (delegateType == null)
			{
				throw new ArgumentNullException("delegateType");
			}
			if (this.deleg != null)
			{
				return this.deleg;
			}
			this.CreateDynMethod();
			this.deleg = Delegate.CreateDelegate(delegateType, null, this);
			return this.deleg;
		}

		/// <summary>Завершает динамический метод и создает делегат, который может использоваться для его выполнения, указывая тип делегата и объект, к которому привязан делегат.</summary>
		/// <param name="delegateType">Тип делегата, подпись которого совпадает с подписью динамического метода минус первый параметр.</param>
		/// <param name="target">Объект, к которому привязан делегат. Должен быть того же типа, что и первый параметр динамического метода.</param>
		/// <returns>Делегат указанного типа, который может использоваться для выполнения динамического метода с указанным целевым объектом.</returns>
		/// <exception cref="T:System.InvalidOperationException">У динамического метода отсутствует тело метода.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="target" /> не относится к тому же типу, что и первый параметр динамического метода, и не может быть назначен этому типу.  
		///
		/// или - 
		/// <paramref name="delegateType" /> имеет неверное число параметров или неправильные типы параметров.</exception>
		// Token: 0x06004F80 RID: 20352 RVA: 0x000F9EB7 File Offset: 0x000F80B7
		[ComVisible(true)]
		public sealed override Delegate CreateDelegate(Type delegateType, object target)
		{
			if (delegateType == null)
			{
				throw new ArgumentNullException("delegateType");
			}
			this.CreateDynMethod();
			return Delegate.CreateDelegate(delegateType, target, this);
		}

		/// <summary>Определяет параметр динамического метода.</summary>
		/// <param name="position">Позиция параметра в списке параметров. Параметры индексируются, начиная с номера 1 для первого параметра.</param>
		/// <param name="attributes">Битовая комбинация значений <see cref="T:System.Reflection.ParameterAttributes" />, определяющая атрибуты параметра.</param>
		/// <param name="parameterName">Имя параметра. Имя может быть строкой нулевой длины.</param>
		/// <returns>Всегда возвращает значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Метод не имеет параметров.  
		///
		/// или - 
		/// Значение параметра <paramref name="position" /> меньше 0.  
		///
		/// или - 
		/// <paramref name="position" /> превышает число параметров метода.</exception>
		// Token: 0x06004F81 RID: 20353 RVA: 0x000F9EDC File Offset: 0x000F80DC
		public ParameterBuilder DefineParameter(int position, ParameterAttributes attributes, string parameterName)
		{
			if (position < 0 || position > this.parameters.Length)
			{
				throw new ArgumentOutOfRangeException("position");
			}
			this.RejectIfCreated();
			ParameterBuilder parameterBuilder = new ParameterBuilder(this, position, attributes, parameterName);
			if (this.pinfo == null)
			{
				this.pinfo = new ParameterBuilder[this.parameters.Length + 1];
			}
			this.pinfo[position] = parameterBuilder;
			return parameterBuilder;
		}

		/// <summary>Возвращает базовую реализацию метода.</summary>
		/// <returns>Базовая реализация метода.</returns>
		// Token: 0x06004F82 RID: 20354 RVA: 0x0000270D File Offset: 0x0000090D
		public override MethodInfo GetBaseDefinition()
		{
			return this;
		}

		/// <summary>Возвращает все настраиваемые атрибуты, определенные для метода.</summary>
		/// <param name="inherit">Значение <see langword="true" /> для поиска цепочки наследования метода для обнаружения настраиваемых атрибутов; значение <see langword="false" /> для проверки только текущего метода.</param>
		/// <returns>Массив объектов, представляющих все настраиваемые атрибуты метода.</returns>
		// Token: 0x06004F83 RID: 20355 RVA: 0x000F9F3A File Offset: 0x000F813A
		public override object[] GetCustomAttributes(bool inherit)
		{
			return new object[]
			{
				new MethodImplAttribute(this.GetMethodImplementationFlags())
			};
		}

		/// <summary>Возвращает настраиваемые атрибуты заданного типа, которые были применены к методу.</summary>
		/// <param name="attributeType">
		///   <see cref="T:System.Type" />, представляющий тип возвращаемого настраиваемого атрибута.</param>
		/// <param name="inherit">Значение <see langword="true" /> для поиска цепочки наследования метода для обнаружения настраиваемых атрибутов; значение <see langword="false" /> для проверки только текущего метода.</param>
		/// <returns>Массив объектов, представляющих атрибуты метода, которые относятся к типу <paramref name="attributeType" /> или являются производными от типа <paramref name="attributeType" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004F84 RID: 20356 RVA: 0x000F9F50 File Offset: 0x000F8150
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			if (attributeType == null)
			{
				throw new ArgumentNullException("attributeType");
			}
			if (attributeType.IsAssignableFrom(typeof(MethodImplAttribute)))
			{
				return new object[]
				{
					new MethodImplAttribute(this.GetMethodImplementationFlags())
				};
			}
			return EmptyArray<object>.Value;
		}

		/// <summary>Возвращает объект <see cref="T:System.Reflection.Emit.DynamicILInfo" />, который может использоваться для создания тела метода из маркеров метаданных, областей и потоков промежуточного языка Майкрософт (MSIL).</summary>
		/// <returns>Объект <see cref="T:System.Reflection.Emit.DynamicILInfo" />, который может использоваться для создания тела метода из маркеров метаданных, областей и потоков MSIL.</returns>
		// Token: 0x06004F85 RID: 20357 RVA: 0x000F9F9D File Offset: 0x000F819D
		public DynamicILInfo GetDynamicILInfo()
		{
			if (this.il_info == null)
			{
				this.il_info = new DynamicILInfo(this);
			}
			return this.il_info;
		}

		/// <summary>Возвращает генератор MSIL для этого метода с размером потока MSIL, по умолчанию равным 64 байтам.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.Emit.ILGenerator" /> для метода.</returns>
		// Token: 0x06004F86 RID: 20358 RVA: 0x000F9FB9 File Offset: 0x000F81B9
		public ILGenerator GetILGenerator()
		{
			return this.GetILGenerator(64);
		}

		/// <summary>Возвращает генератор промежуточного языка Майкрософт (MSIL) для этого метода с указанным размером потока MSIL.</summary>
		/// <param name="streamSize">Размер потока MSIL (в байтах).</param>
		/// <returns>Объект <see cref="T:System.Reflection.Emit.ILGenerator" /> для метода с указанным размером потока MSIL.</returns>
		// Token: 0x06004F87 RID: 20359 RVA: 0x000F9FC4 File Offset: 0x000F81C4
		public ILGenerator GetILGenerator(int streamSize)
		{
			if ((this.GetMethodImplementationFlags() & MethodImplAttributes.CodeTypeMask) != MethodImplAttributes.IL || (this.GetMethodImplementationFlags() & MethodImplAttributes.ManagedMask) != MethodImplAttributes.IL)
			{
				throw new InvalidOperationException("Method body should not exist.");
			}
			if (this.ilgen != null)
			{
				return this.ilgen;
			}
			this.ilgen = new ILGenerator(this.Module, new DynamicMethodTokenGenerator(this), streamSize);
			return this.ilgen;
		}

		/// <summary>Возвращает флаги реализации для метода.</summary>
		/// <returns>Битовая комбинация значений <see cref="T:System.Reflection.MethodImplAttributes" />, представляющая флаги реализации для метода.</returns>
		// Token: 0x06004F88 RID: 20360 RVA: 0x00047F71 File Offset: 0x00046171
		public override MethodImplAttributes GetMethodImplementationFlags()
		{
			return MethodImplAttributes.NoInlining;
		}

		/// <summary>Возвращает параметры динамического метода.</summary>
		/// <returns>Массив объектов <see cref="T:System.Reflection.ParameterInfo" />, которые представляют параметры динамического метода.</returns>
		// Token: 0x06004F89 RID: 20361 RVA: 0x000F18F6 File Offset: 0x000EFAF6
		public override ParameterInfo[] GetParameters()
		{
			return this.GetParametersInternal();
		}

		// Token: 0x06004F8A RID: 20362 RVA: 0x000FA020 File Offset: 0x000F8220
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

		// Token: 0x06004F8B RID: 20363 RVA: 0x000FA082 File Offset: 0x000F8282
		internal override int GetParametersCount()
		{
			if (this.parameters != null)
			{
				return this.parameters.Length;
			}
			return 0;
		}

		// Token: 0x06004F8C RID: 20364 RVA: 0x000FA096 File Offset: 0x000F8296
		internal override Type GetParameterType(int pos)
		{
			return this.parameters[pos];
		}

		/// <summary>Вызывает динамический метод, используя указанные параметры и учитывая ограничения заданного модуля привязки и указанные сведения о языке и региональных параметрах.</summary>
		/// <param name="obj">Эти параметры игнорируются для динамических методов, поскольку они являются статическими. Задайте имя <see langword="null" />.</param>
		/// <param name="invokeAttr">Битовая комбинация значений <see cref="T:System.Reflection.BindingFlags" />.</param>
		/// <param name="binder">Объект <see cref="T:System.Reflection.Binder" />, который допускает привязку, приведение типов аргументов, вызов элементов и извлечение объектов <see cref="T:System.Reflection.MemberInfo" /> путем отражения. Если значение параметра <paramref name="binder" /> равно <see langword="null" />, используется связыватель по умолчанию. Дополнительные сведения см. в разделе <see cref="T:System.Reflection.Binder" />.</param>
		/// <param name="parameters">Список аргументов. Это массив аргументов с тем же числом, порядком и типом, что и параметры вызываемого метода. Если параметров нет, этот параметр должен иметь значение <see langword="null" />.</param>
		/// <param name="culture">Экземпляр объекта <see cref="T:System.Globalization.CultureInfo" />, используемого для управления приведением типов. Если значение этого объекта — <see langword="null" />, для текущего потока используется <see cref="T:System.Globalization.CultureInfo" />. Например, эти сведения необходимы для правильного преобразовывая объекта <see cref="T:System.String" />, представляющего 1000, в значение <see cref="T:System.Double" />, поскольку в разных языках и региональных параметрах 1000 представляется по-разному.</param>
		/// <returns>Объект <see cref="T:System.Object" />, содержащий возвращаемое значение вызванного метода.</returns>
		/// <exception cref="T:System.NotSupportedException">Соглашение о вызовах <see cref="F:System.Reflection.CallingConventions.VarArgs" /> не поддерживается.</exception>
		/// <exception cref="T:System.Reflection.TargetParameterCountException">Число элементов в <paramref name="parameters" /> не соответствует числу параметров в динамическом методе.</exception>
		/// <exception cref="T:System.ArgumentException">Тип одного или нескольких элементов <paramref name="parameters" /> не соответствует типу соответствующего параметра динамического метода.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Динамический метод связан с модулем, не размещен анонимно и был создан с параметром <paramref name="skipVisibility" />, для которого задано значение <see langword="false" />, однако он получает доступ к членам, которые не имеют тип <see langword="public" /> или <see langword="internal" /> (<see langword="Friend" /> в Visual Basic).  
		///
		/// или - 
		/// Динамический метод размещен анонимно и был создан с параметром <paramref name="skipVisibility" />, для которого задано значение <see langword="false" />, однако он получает доступ к членам, которые не имеют тип <see langword="public" />.  
		///
		/// или - 
		/// Динамический метод содержит непроверяемый код. См. подраздел "Проверка" в разделе примечаний для <see cref="T:System.Reflection.Emit.DynamicMethod" />.</exception>
		// Token: 0x06004F8D RID: 20365 RVA: 0x000FA0A0 File Offset: 0x000F82A0
		[SecuritySafeCritical]
		public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			object result;
			try
			{
				this.CreateDynMethod();
				if (this.method == null)
				{
					this.method = new RuntimeMethodInfo(this.mhandle);
				}
				result = this.method.Invoke(obj, invokeAttr, binder, parameters, culture);
			}
			catch (MethodAccessException inner)
			{
				throw new TargetInvocationException("Method cannot be invoked.", inner);
			}
			return result;
		}

		/// <summary>Указывает, определен ли заданный тип настраиваемых атрибутов.</summary>
		/// <param name="attributeType">
		///   <see cref="T:System.Type" />, представляющий тип искомого настраиваемого атрибута.</param>
		/// <param name="inherit">Значение <see langword="true" /> для поиска цепочки наследования метода для обнаружения настраиваемых атрибутов; значение <see langword="false" /> для проверки только текущего метода.</param>
		/// <returns>Значение <see langword="true" />, если заданный тип настраиваемых атрибутов определен; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004F8E RID: 20366 RVA: 0x000FA108 File Offset: 0x000F8308
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			if (attributeType == null)
			{
				throw new ArgumentNullException("attributeType");
			}
			return attributeType.IsAssignableFrom(typeof(MethodImplAttribute));
		}

		/// <summary>Возвращает сигнатуру метода, представленную в виде строки.</summary>
		/// <returns>Строка, представляющая сигнатуру метода.</returns>
		// Token: 0x06004F8F RID: 20367 RVA: 0x000FA134 File Offset: 0x000F8334
		public override string ToString()
		{
			string text = string.Empty;
			ParameterInfo[] parametersInternal = this.GetParametersInternal();
			for (int i = 0; i < parametersInternal.Length; i++)
			{
				if (i > 0)
				{
					text += ", ";
				}
				text += parametersInternal[i].ParameterType.Name;
			}
			return string.Concat(new string[]
			{
				this.ReturnType.Name,
				" ",
				this.Name,
				"(",
				text,
				")"
			});
		}

		/// <summary>Возвращает атрибуты, указанные при создании динамического метода.</summary>
		/// <returns>Побитовое сочетание значений <see cref="T:System.Reflection.MethodAttributes" />, представляющее атрибуты для метода.</returns>
		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x06004F90 RID: 20368 RVA: 0x000FA1BE File Offset: 0x000F83BE
		public override MethodAttributes Attributes
		{
			get
			{
				return this.attributes;
			}
		}

		/// <summary>Получает соглашение о вызовах, указанное при создании динамического метода.</summary>
		/// <returns>Одно из значений <see cref="T:System.Reflection.CallingConventions" />, указывающее соглашение о вызовах метода.</returns>
		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x06004F91 RID: 20369 RVA: 0x000FA1C6 File Offset: 0x000F83C6
		public override CallingConventions CallingConvention
		{
			get
			{
				return this.callingConvention;
			}
		}

		/// <summary>Возвращает тип, который объявляет метод, всегда являющийся <see langword="null" /> для динамических методов.</summary>
		/// <returns>Всегда <see langword="null" />.</returns>
		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x06004F92 RID: 20370 RVA: 0x0000AF5E File Offset: 0x0000915E
		public override Type DeclaringType
		{
			get
			{
				return null;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, инициализированы ли локальные переменные в методе нулевым значением.</summary>
		/// <returns>Значение <see langword="true" />, если локальные переменные в методе инициализированы нулевым значением; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x06004F93 RID: 20371 RVA: 0x000FA1CE File Offset: 0x000F83CE
		// (set) Token: 0x06004F94 RID: 20372 RVA: 0x000FA1D6 File Offset: 0x000F83D6
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

		/// <summary>Не поддерживается для динамических методов.</summary>
		/// <returns>Не поддерживается для динамических методов.</returns>
		/// <exception cref="T:System.InvalidOperationException">Не разрешено для динамических методов.</exception>
		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x06004F95 RID: 20373 RVA: 0x000FA1DF File Offset: 0x000F83DF
		public override RuntimeMethodHandle MethodHandle
		{
			get
			{
				return this.mhandle;
			}
		}

		/// <summary>Возвращает модуль, с которым логически связан динамический метод.</summary>
		/// <returns>Модуль <see cref="T:System.Reflection.Module" />, с которым связан текущий динамический метод.</returns>
		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x06004F96 RID: 20374 RVA: 0x000FA1E7 File Offset: 0x000F83E7
		public override Module Module
		{
			get
			{
				return this.module;
			}
		}

		/// <summary>Получает имя динамического метода.</summary>
		/// <returns>Простое имя метода.</returns>
		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x06004F97 RID: 20375 RVA: 0x000FA1EF File Offset: 0x000F83EF
		public override string Name
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Возвращает класс, который использовался в отражении для получения метода.</summary>
		/// <returns>Всегда <see langword="null" />.</returns>
		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x06004F98 RID: 20376 RVA: 0x0000AF5E File Offset: 0x0000915E
		public override Type ReflectedType
		{
			get
			{
				return null;
			}
		}

		/// <summary>Возвращает выходной параметр динамического метода.</summary>
		/// <returns>Всегда <see langword="null" />.</returns>
		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x06004F99 RID: 20377 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO("Not implemented")]
		public override ParameterInfo ReturnParameter
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает тип возвращаемого значения для динамического метода.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий тип возвращаемого значения текущего метода; значение <see cref="T:System.Void" />, если метод не имеет возвращаемого типа.</returns>
		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x06004F9A RID: 20378 RVA: 0x000FA1F7 File Offset: 0x000F83F7
		public override Type ReturnType
		{
			get
			{
				return this.returnType;
			}
		}

		/// <summary>Получает настраиваемые атрибуты типа возвращаемого значения для динамического метода.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.ICustomAttributeProvider" />, представляющий настраиваемые атрибуты типа возвращаемого значения для динамического метода.</returns>
		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x06004F9B RID: 20379 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO("Not implemented")]
		public override ICustomAttributeProvider ReturnTypeCustomAttributes
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x06004F9C RID: 20380 RVA: 0x000FA1FF File Offset: 0x000F83FF
		private void RejectIfCreated()
		{
			if (this.mhandle.Value != IntPtr.Zero)
			{
				throw new InvalidOperationException("Type definition of the method is complete.");
			}
		}

		// Token: 0x06004F9D RID: 20381 RVA: 0x000FA224 File Offset: 0x000F8424
		internal int AddRef(object reference)
		{
			if (this.refs == null)
			{
				this.refs = new object[4];
			}
			if (this.nrefs >= this.refs.Length - 1)
			{
				object[] destinationArray = new object[this.refs.Length * 2];
				Array.Copy(this.refs, destinationArray, this.refs.Length);
				this.refs = destinationArray;
			}
			this.refs[this.nrefs] = reference;
			this.refs[this.nrefs + 1] = null;
			this.nrefs += 2;
			return this.nrefs - 1;
		}

		// Token: 0x04003136 RID: 12598
		private RuntimeMethodHandle mhandle;

		// Token: 0x04003137 RID: 12599
		private string name;

		// Token: 0x04003138 RID: 12600
		private Type returnType;

		// Token: 0x04003139 RID: 12601
		private Type[] parameters;

		// Token: 0x0400313A RID: 12602
		private MethodAttributes attributes;

		// Token: 0x0400313B RID: 12603
		private CallingConventions callingConvention;

		// Token: 0x0400313C RID: 12604
		private Module module;

		// Token: 0x0400313D RID: 12605
		private bool skipVisibility;

		// Token: 0x0400313E RID: 12606
		private bool init_locals = true;

		// Token: 0x0400313F RID: 12607
		private ILGenerator ilgen;

		// Token: 0x04003140 RID: 12608
		private int nrefs;

		// Token: 0x04003141 RID: 12609
		private object[] refs;

		// Token: 0x04003142 RID: 12610
		private IntPtr referenced_by;

		// Token: 0x04003143 RID: 12611
		private Type owner;

		// Token: 0x04003144 RID: 12612
		private Delegate deleg;

		// Token: 0x04003145 RID: 12613
		private RuntimeMethodInfo method;

		// Token: 0x04003146 RID: 12614
		private ParameterBuilder[] pinfo;

		// Token: 0x04003147 RID: 12615
		internal bool creating;

		// Token: 0x04003148 RID: 12616
		private DynamicILInfo il_info;

		// Token: 0x0200091E RID: 2334
		private static class AnonHostModuleHolder
		{
			// Token: 0x06004F9E RID: 20382 RVA: 0x000FA2B8 File Offset: 0x000F84B8
			static AnonHostModuleHolder()
			{
				AssemblyName assemblyName = new AssemblyName();
				assemblyName.Name = "Anonymously Hosted DynamicMethods Assembly";
				DynamicMethod.AnonHostModuleHolder.anon_host_module = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run).GetManifestModule();
			}

			// Token: 0x17000D0F RID: 3343
			// (get) Token: 0x06004F9F RID: 20383 RVA: 0x000FA2EC File Offset: 0x000F84EC
			public static Module AnonHostModule
			{
				get
				{
					return DynamicMethod.AnonHostModuleHolder.anon_host_module;
				}
			}

			// Token: 0x04003149 RID: 12617
			public static readonly Module anon_host_module;
		}
	}
}
