using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity;

namespace System.Reflection.Emit
{
	/// <summary>Определяет и представляет модуль в динамической сборке.</summary>
	// Token: 0x02000938 RID: 2360
	[ComVisible(true)]
	[ComDefaultInterface(typeof(_ModuleBuilder))]
	[ClassInterface(ClassInterfaceType.None)]
	[StructLayout(LayoutKind.Sequential)]
	public class ModuleBuilder : Module, _ModuleBuilder
	{
		/// <summary>Описание этого члена см. в разделе <see cref="M:System.Runtime.InteropServices._ModuleBuilder.GetIDsOfNames(System.Guid@,System.IntPtr,System.UInt32,System.UInt32,System.IntPtr)" />.</summary>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Переданный массив имен, которые необходимо сопоставить.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, зарезервированный вызывающим объектом, куда помещаются идентификаторы, соответствующие именам.</param>
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x06005178 RID: 20856 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _ModuleBuilder.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
		{
			throw new NotImplementedException();
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.Runtime.InteropServices._ModuleBuilder.GetTypeInfo(System.UInt32,System.UInt32,System.IntPtr)" />.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Указатель на объект с запрошенными сведениями о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x06005179 RID: 20857 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _ModuleBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.Runtime.InteropServices._ModuleBuilder.GetTypeInfoCount(System.UInt32@)" />.</summary>
		/// <param name="pcTInfo">Расположение, по которому записывается число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x0600517A RID: 20858 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _ModuleBuilder.GetTypeInfoCount(out uint pcTInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.Runtime.InteropServices._ModuleBuilder.Invoke(System.UInt32,System.Guid@,System.UInt32,System.Int16,System.IntPtr,System.IntPtr,System.IntPtr,System.IntPtr)" />.</summary>
		/// <param name="dispIdMember">Идентификатор элемента.</param>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="lcid">Контекст языкового стандарта, в котором следует интерпретировать аргументы.</param>
		/// <param name="wFlags">Флаги, описывающие контекст вызова.</param>
		/// <param name="pDispParams">Указатель на структуру, содержащую массив аргументов, массив DISPID для именованных аргументов, а также счетчики количества элементов в массивах.</param>
		/// <param name="pVarResult">Указатель, по которому будет сохранен результат.</param>
		/// <param name="pExcepInfo">Указатель на структуру, содержащую сведения об исключении.</param>
		/// <param name="puArgErr">Индекс первого аргумента, вызвавшего ошибку.</param>
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x0600517B RID: 20859 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _ModuleBuilder.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600517C RID: 20860
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void basic_init(ModuleBuilder ab);

		// Token: 0x0600517D RID: 20861
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void set_wrappers_type(ModuleBuilder mb, Type ab);

		// Token: 0x0600517E RID: 20862 RVA: 0x000FEA04 File Offset: 0x000FCC04
		internal ModuleBuilder(AssemblyBuilder assb, string name, string fullyqname, bool emitSymbolInfo, bool transient)
		{
			this.scopename = name;
			this.name = name;
			this.fqname = fullyqname;
			this.assemblyb = assb;
			this.assembly = assb;
			this.transient = transient;
			this.guid = Guid.FastNewGuidArray();
			this.table_idx = this.get_next_table_index(this, 0, 1);
			this.name_cache = new Dictionary<TypeName, TypeBuilder>();
			this.us_string_cache = new Dictionary<string, int>(512);
			ModuleBuilder.basic_init(this);
			this.CreateGlobalType();
			if (assb.IsRun)
			{
				Type ab = new TypeBuilder(this, TypeAttributes.Abstract, 16777215).CreateType();
				ModuleBuilder.set_wrappers_type(this, ab);
			}
			if (emitSymbolInfo)
			{
				Assembly assembly = Assembly.LoadWithPartialName("Mono.CompilerServices.SymbolWriter");
				Type type = null;
				if (assembly != null)
				{
					type = assembly.GetType("Mono.CompilerServices.SymbolWriter.SymbolWriterImpl");
				}
				if (type == null)
				{
					ModuleBuilder.WarnAboutSymbolWriter("Failed to load the default Mono.CompilerServices.SymbolWriter assembly");
				}
				else
				{
					try
					{
						this.symbolWriter = (ISymbolWriter)Activator.CreateInstance(type, new object[]
						{
							this
						});
					}
					catch (MissingMethodException)
					{
						ModuleBuilder.WarnAboutSymbolWriter("The default Mono.CompilerServices.SymbolWriter is not available on this platform");
						return;
					}
				}
				string text = this.fqname;
				if (this.assemblyb.AssemblyDir != null)
				{
					text = Path.Combine(this.assemblyb.AssemblyDir, text);
				}
				this.symbolWriter.Initialize(IntPtr.Zero, text, true);
			}
		}

		// Token: 0x0600517F RID: 20863 RVA: 0x000FEB68 File Offset: 0x000FCD68
		private static void WarnAboutSymbolWriter(string message)
		{
			if (ModuleBuilder.has_warned_about_symbolWriter)
			{
				return;
			}
			ModuleBuilder.has_warned_about_symbolWriter = true;
			Console.Error.WriteLine("WARNING: {0}", message);
		}

		/// <summary>Получает значение типа <see langword="String" />, предоставляющее полное имя и путь для данного модуля.</summary>
		/// <returns>Полное имя модуля.</returns>
		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x06005180 RID: 20864 RVA: 0x000FEB88 File Offset: 0x000FCD88
		public override string FullyQualifiedName
		{
			get
			{
				string text = this.fqname;
				if (text == null)
				{
					return null;
				}
				if (this.assemblyb.AssemblyDir != null)
				{
					text = Path.Combine(this.assemblyb.AssemblyDir, text);
					text = Path.GetFullPath(text);
				}
				return text;
			}
		}

		/// <summary>Возвращает значение, указывающее на то, что этот динамический модуль является несохраняемым.</summary>
		/// <returns>Значение <see langword="true" />, если данный динамический модуль является несохраняемым; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06005181 RID: 20865 RVA: 0x000FEBC8 File Offset: 0x000FCDC8
		public bool IsTransient()
		{
			return this.transient;
		}

		/// <summary>Завершает определения глобальной функции и глобальных данных для этого динамического модуля.</summary>
		/// <exception cref="T:System.InvalidOperationException">Данный метод был вызван ранее.</exception>
		// Token: 0x06005182 RID: 20866 RVA: 0x000FEBD0 File Offset: 0x000FCDD0
		public void CreateGlobalFunctions()
		{
			if (this.global_type_created != null)
			{
				throw new InvalidOperationException("global methods already created");
			}
			if (this.global_type != null)
			{
				this.global_type_created = this.global_type.CreateType();
			}
		}

		/// <summary>Определяет инициализированное поле данных в разделе .sdata переносимого исполняемого PE-файла.</summary>
		/// <param name="name">Имя, используемое для ссылки на данные. Параметр <paramref name="name" /> не может содержать внедренные значения NULL.</param>
		/// <param name="data">Большой двоичный объект (BLOB) данных.</param>
		/// <param name="attributes">Атрибуты поля. Значение по умолчанию — <see langword="Static" />.</param>
		/// <returns>Поле для ссылки на данные.</returns>
		/// <exception cref="T:System.ArgumentException">Длина параметра <paramref name="name" /> равна нулю.  
		///
		/// или - 
		/// Размер параметра <paramref name="data" /> меньше или равен нулю, либо больше или равен 0x3f0000.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> или <paramref name="data" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <see cref="M:System.Reflection.Emit.ModuleBuilder.CreateGlobalFunctions" /> был вызван ранее.</exception>
		// Token: 0x06005183 RID: 20867 RVA: 0x000FEC0C File Offset: 0x000FCE0C
		public FieldBuilder DefineInitializedData(string name, byte[] data, FieldAttributes attributes)
		{
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			FieldAttributes fieldAttributes = attributes & ~(FieldAttributes.RTSpecialName | FieldAttributes.HasFieldMarshal | FieldAttributes.HasDefault | FieldAttributes.HasFieldRVA);
			FieldBuilder fieldBuilder = this.DefineDataImpl(name, data.Length, fieldAttributes | FieldAttributes.HasFieldRVA);
			fieldBuilder.SetRVAData(data);
			return fieldBuilder;
		}

		/// <summary>Определяет неинициализированное поле данных в разделе .sdata переносимого исполняемого PE-файла.</summary>
		/// <param name="name">Имя, используемое для ссылки на данные. Параметр <paramref name="name" /> не может содержать внедренные значения NULL.</param>
		/// <param name="size">Размер поля данных.</param>
		/// <param name="attributes">Атрибуты поля.</param>
		/// <returns>Поле для ссылки на данные.</returns>
		/// <exception cref="T:System.ArgumentException">Длина параметра <paramref name="name" /> равна нулю.  
		///
		/// или - 
		/// Значение <paramref name="size" /> меньше или равно нулю либо больше или равно 0x003f0000.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <see cref="M:System.Reflection.Emit.ModuleBuilder.CreateGlobalFunctions" /> был вызван ранее.</exception>
		// Token: 0x06005184 RID: 20868 RVA: 0x000FEC47 File Offset: 0x000FCE47
		public FieldBuilder DefineUninitializedData(string name, int size, FieldAttributes attributes)
		{
			return this.DefineDataImpl(name, size, attributes & ~(FieldAttributes.RTSpecialName | FieldAttributes.HasFieldMarshal | FieldAttributes.HasDefault | FieldAttributes.HasFieldRVA));
		}

		// Token: 0x06005185 RID: 20869 RVA: 0x000FEC58 File Offset: 0x000FCE58
		private FieldBuilder DefineDataImpl(string name, int size, FieldAttributes attributes)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (name == string.Empty)
			{
				throw new ArgumentException("name cannot be empty", "name");
			}
			if (this.global_type_created != null)
			{
				throw new InvalidOperationException("global fields already created");
			}
			if (size <= 0 || size >= 4128768)
			{
				throw new ArgumentException("Data size must be > 0 and < 0x3f0000", null);
			}
			this.CreateGlobalType();
			string className = "$ArrayType$" + size.ToString();
			Type type = this.GetType(className, false, false);
			if (type == null)
			{
				TypeBuilder typeBuilder = this.DefineType(className, TypeAttributes.Public | TypeAttributes.ExplicitLayout | TypeAttributes.Sealed, this.assemblyb.corlib_value_type, null, PackingSize.Size1, size);
				typeBuilder.CreateType();
				type = typeBuilder;
			}
			FieldBuilder fieldBuilder = this.global_type.DefineField(name, type, attributes | FieldAttributes.Static);
			if (this.global_fields != null)
			{
				FieldBuilder[] array = new FieldBuilder[this.global_fields.Length + 1];
				Array.Copy(this.global_fields, array, this.global_fields.Length);
				array[this.global_fields.Length] = fieldBuilder;
				this.global_fields = array;
			}
			else
			{
				this.global_fields = new FieldBuilder[1];
				this.global_fields[0] = fieldBuilder;
			}
			return fieldBuilder;
		}

		// Token: 0x06005186 RID: 20870 RVA: 0x000FED78 File Offset: 0x000FCF78
		private void addGlobalMethod(MethodBuilder mb)
		{
			if (this.global_methods != null)
			{
				MethodBuilder[] array = new MethodBuilder[this.global_methods.Length + 1];
				Array.Copy(this.global_methods, array, this.global_methods.Length);
				array[this.global_methods.Length] = mb;
				this.global_methods = array;
				return;
			}
			this.global_methods = new MethodBuilder[1];
			this.global_methods[0] = mb;
		}

		/// <summary>Определяет глобальный метод с данными именем, атрибутами, возвращаемыми типами и типами параметров.</summary>
		/// <param name="name">Имя метода. Параметр <paramref name="name" /> не может содержать внедренные значения NULL.</param>
		/// <param name="attributes">Атрибуты метода. Параметр <paramref name="attributes" /> должен включать атрибут <see cref="F:System.Reflection.MethodAttributes.Static" />.</param>
		/// <param name="returnType">Возвращаемый тип метода.</param>
		/// <param name="parameterTypes">Типы параметров метода.</param>
		/// <returns>Определенный глобальный метод.</returns>
		/// <exception cref="T:System.ArgumentException">Метод не является статическим. То есть параметр <paramref name="attributes" /> не включает <see cref="F:System.Reflection.MethodAttributes.Static" />.  
		///
		/// или - 
		/// Длина параметра <paramref name="name" /> равна нулю. 
		/// или - 
		/// Элементом массива <see cref="T:System.Type" /> является <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <see cref="M:System.Reflection.Emit.ModuleBuilder.CreateGlobalFunctions" /> был вызван ранее.</exception>
		// Token: 0x06005187 RID: 20871 RVA: 0x000FEDD9 File Offset: 0x000FCFD9
		public MethodBuilder DefineGlobalMethod(string name, MethodAttributes attributes, Type returnType, Type[] parameterTypes)
		{
			return this.DefineGlobalMethod(name, attributes, CallingConventions.Standard, returnType, parameterTypes);
		}

		/// <summary>Определяет глобальный метод с данными именем, атрибутами, соглашениями о вызовах, возвращаемыми типами и типами параметров.</summary>
		/// <param name="name">Имя метода. Параметр <paramref name="name" /> не может содержать внедренные значения NULL.</param>
		/// <param name="attributes">Атрибуты метода. Параметр <paramref name="attributes" /> должен включать атрибут <see cref="F:System.Reflection.MethodAttributes.Static" />.</param>
		/// <param name="callingConvention">Соглашение о вызовах для метода.</param>
		/// <param name="returnType">Возвращаемый тип метода.</param>
		/// <param name="parameterTypes">Типы параметров метода.</param>
		/// <returns>Определенный глобальный метод.</returns>
		/// <exception cref="T:System.ArgumentException">Метод не является статическим. То есть параметр <paramref name="attributes" /> не включает <see cref="F:System.Reflection.MethodAttributes.Static" />.  
		///
		/// или - 
		/// Элементом массива <see cref="T:System.Type" /> является <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <see cref="M:System.Reflection.Emit.ModuleBuilder.CreateGlobalFunctions" /> был вызван ранее.</exception>
		// Token: 0x06005188 RID: 20872 RVA: 0x000FEDE8 File Offset: 0x000FCFE8
		public MethodBuilder DefineGlobalMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes)
		{
			return this.DefineGlobalMethod(name, attributes, callingConvention, returnType, null, null, parameterTypes, null, null);
		}

		/// <summary>Определяет глобальный метод с данными именем, атрибутами, соглашениями о вызовах, возвращаемым типом, пользовательскими модификаторами для возвращаемого типа, типами параметров и пользовательскими модификаторами для типов параметров.</summary>
		/// <param name="name">Имя метода. Параметр <paramref name="name" /> не должен содержать внедренные символы NULL.</param>
		/// <param name="attributes">Атрибуты метода. Параметр <paramref name="attributes" /> должен включать атрибут <see cref="F:System.Reflection.MethodAttributes.Static" />.</param>
		/// <param name="callingConvention">Соглашение о вызовах для метода.</param>
		/// <param name="returnType">Возвращаемый тип метода.</param>
		/// <param name="requiredReturnTypeCustomModifiers">Массив типов представляет собой требуемые пользовательские модификаторы для возвращаемого типа, например <see cref="T:System.Runtime.CompilerServices.IsConst" /> или <see cref="T:System.Runtime.CompilerServices.IsBoxed" />. Если возвращаемый тип не содержит требуемых настраиваемых модификаторов, укажите <see langword="null" />.</param>
		/// <param name="optionalReturnTypeCustomModifiers">Массив типов представляет собой необязательные пользовательские модификаторы для возвращаемого типа, например <see cref="T:System.Runtime.CompilerServices.IsConst" /> или <see cref="T:System.Runtime.CompilerServices.IsBoxed" />. Если возвращаемый тип не содержит необязательные настраиваемые модификаторы, укажите <see langword="null" />.</param>
		/// <param name="parameterTypes">Типы параметров метода.</param>
		/// <param name="requiredParameterTypeCustomModifiers">Массив массивов типов. Каждый массив типов представляет собой требуемые пользовательские модификаторы для соответствующего параметра глобального метода. Если определенный аргумент не содержит требуемые пользовательские модификаторы, вместо массива данных укажите <see langword="null" />. Если глобальный метод не содержит аргументов или если аргументы не содержат пользовательские модификаторы, укажите значение <see langword="null" /> вместо массива массивов.</param>
		/// <param name="optionalParameterTypeCustomModifiers">Массив массивов типов. Каждый массив типов представляет собой необязательные пользовательские модификаторы для соответствующего параметра. Если определенный аргумент не содержит необязательные пользовательские модификаторы, вместо массива данных укажите <see langword="null" />. Если глобальный метод не содержит аргументов или если аргументы не содержат необязательные пользовательские модификаторы, укажите значение <see langword="null" /> вместо массива массивов.</param>
		/// <returns>Определенный глобальный метод.</returns>
		/// <exception cref="T:System.ArgumentException">Метод не является статическим. То есть параметр <paramref name="attributes" /> не включает <see cref="F:System.Reflection.MethodAttributes.Static" />.  
		///
		/// или - 
		/// Элементом массива <see cref="T:System.Type" /> является <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="M:System.Reflection.Emit.ModuleBuilder.CreateGlobalFunctions" /> вызывался до этого.</exception>
		// Token: 0x06005189 RID: 20873 RVA: 0x000FEE08 File Offset: 0x000FD008
		public MethodBuilder DefineGlobalMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] requiredReturnTypeCustomModifiers, Type[] optionalReturnTypeCustomModifiers, Type[] parameterTypes, Type[][] requiredParameterTypeCustomModifiers, Type[][] optionalParameterTypeCustomModifiers)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if ((attributes & MethodAttributes.Static) == MethodAttributes.PrivateScope)
			{
				throw new ArgumentException("global methods must be static");
			}
			if (this.global_type_created != null)
			{
				throw new InvalidOperationException("global methods already created");
			}
			this.CreateGlobalType();
			MethodBuilder methodBuilder = this.global_type.DefineMethod(name, attributes, callingConvention, returnType, requiredReturnTypeCustomModifiers, optionalReturnTypeCustomModifiers, parameterTypes, requiredParameterTypeCustomModifiers, optionalParameterTypeCustomModifiers);
			this.addGlobalMethod(methodBuilder);
			return methodBuilder;
		}

		/// <summary>Определяет метод <see langword="PInvoke" /> с заданными именем, именем DLL-библиотеки, в котором этот метод определен, атрибутами метода, соглашением о вызовах, возвращаемым типом, типами параметров метода и флагами <see langword="PInvoke" />.</summary>
		/// <param name="name">Имя метода <see langword="PInvoke" />. Параметр <paramref name="name" /> не может содержать внедренные значения NULL.</param>
		/// <param name="dllName">Имя библиотеки DLL, в которой определен метод <see langword="PInvoke" />.</param>
		/// <param name="attributes">Атрибуты метода.</param>
		/// <param name="callingConvention">Соглашение о вызове метода.</param>
		/// <param name="returnType">Возвращаемый тип метода.</param>
		/// <param name="parameterTypes">Типы параметров метода.</param>
		/// <param name="nativeCallConv">Собственное соглашение о вызове.</param>
		/// <param name="nativeCharSet">Собственная кодировка метода.</param>
		/// <returns>Определенный метод <see langword="PInvoke" />.</returns>
		/// <exception cref="T:System.ArgumentException">Метод не является статическим или вмещающий тип является интерфейсом.  
		///
		/// или - 
		/// Метод является абстрактным.  
		///
		/// или - 
		/// Метод был определен ранее.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> или <paramref name="dllName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Содержащий тип был создан ранее с помощью метода <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.</exception>
		// Token: 0x0600518A RID: 20874 RVA: 0x000FEE78 File Offset: 0x000FD078
		public MethodBuilder DefinePInvokeMethod(string name, string dllName, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, CallingConvention nativeCallConv, CharSet nativeCharSet)
		{
			return this.DefinePInvokeMethod(name, dllName, name, attributes, callingConvention, returnType, parameterTypes, nativeCallConv, nativeCharSet);
		}

		/// <summary>Определяет метод <see langword="PInvoke" /> с заданными именем, именем DLL-библиотеки, в котором этот метод определен, атрибутами метода, соглашением о вызовах, возвращаемым типом, типами параметров метода и флагами <see langword="PInvoke" />.</summary>
		/// <param name="name">Имя метода <see langword="PInvoke" />. Параметр <paramref name="name" /> не может содержать внедренные значения NULL.</param>
		/// <param name="dllName">Имя библиотеки DLL, в которой определен метод <see langword="PInvoke" />.</param>
		/// <param name="entryName">Имя точки входа в библиотеке DLL.</param>
		/// <param name="attributes">Атрибуты метода.</param>
		/// <param name="callingConvention">Соглашение о вызове метода.</param>
		/// <param name="returnType">Возвращаемый тип метода.</param>
		/// <param name="parameterTypes">Типы параметров метода.</param>
		/// <param name="nativeCallConv">Собственное соглашение о вызове.</param>
		/// <param name="nativeCharSet">Собственная кодировка метода.</param>
		/// <returns>Определенный метод <see langword="PInvoke" />.</returns>
		/// <exception cref="T:System.ArgumentException">Метод не является статическим или вмещающий тип является интерфейсом, или метод является абстрактным, или метод был определен ранее.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> или <paramref name="dllName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Содержащий тип был создан ранее с помощью метода <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.</exception>
		// Token: 0x0600518B RID: 20875 RVA: 0x000FEE9C File Offset: 0x000FD09C
		public MethodBuilder DefinePInvokeMethod(string name, string dllName, string entryName, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, CallingConvention nativeCallConv, CharSet nativeCharSet)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if ((attributes & MethodAttributes.Static) == MethodAttributes.PrivateScope)
			{
				throw new ArgumentException("global methods must be static");
			}
			if (this.global_type_created != null)
			{
				throw new InvalidOperationException("global methods already created");
			}
			this.CreateGlobalType();
			MethodBuilder methodBuilder = this.global_type.DefinePInvokeMethod(name, dllName, entryName, attributes, callingConvention, returnType, parameterTypes, nativeCallConv, nativeCharSet);
			this.addGlobalMethod(methodBuilder);
			return methodBuilder;
		}

		/// <summary>Создает объект <see langword="TypeBuilder" /> для закрытого типа с указанным в этом модуле именем.</summary>
		/// <param name="name">Полный путь к типу, включая пространство имен. Параметр <paramref name="name" /> не может содержать внедренные значения NULL.</param>
		/// <returns>Закрытый тип с указанным именем.</returns>
		/// <exception cref="T:System.ArgumentException">Тип с данным именем существует в родительской сборке этого модуля.  
		///
		/// или - 
		/// Атрибуты вложенного типа установлены для типа, который не является вложенным.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600518C RID: 20876 RVA: 0x000FEF0B File Offset: 0x000FD10B
		public TypeBuilder DefineType(string name)
		{
			return this.DefineType(name, TypeAttributes.NotPublic);
		}

		/// <summary>Конструирует <see langword="TypeBuilder" /> с заданными именем и атрибутами типа.</summary>
		/// <param name="name">Полный путь к типу. Параметр <paramref name="name" /> не может содержать внедренные значения NULL.</param>
		/// <param name="attr">Атрибуты определенного в результате типа.</param>
		/// <returns>Объект <see langword="TypeBuilder" />, созданный с учетом всех запрошенных атрибутов.</returns>
		/// <exception cref="T:System.ArgumentException">Тип с данным именем существует в родительской сборке этого модуля.  
		///
		/// или - 
		/// Атрибуты вложенного типа установлены для типа, который не является вложенным.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600518D RID: 20877 RVA: 0x000FEF15 File Offset: 0x000FD115
		public TypeBuilder DefineType(string name, TypeAttributes attr)
		{
			if ((attr & TypeAttributes.ClassSemanticsMask) != TypeAttributes.NotPublic)
			{
				return this.DefineType(name, attr, null, null);
			}
			return this.DefineType(name, attr, typeof(object), null);
		}

		/// <summary>Конструирует <see langword="TypeBuilder" /> с заданным именем, атрибутами и типом, который расширяет определенный тип.</summary>
		/// <param name="name">Полный путь к типу. Параметр <paramref name="name" /> не может содержать внедренные значения NULL.</param>
		/// <param name="attr">Атрибут, который будет связан с типом.</param>
		/// <param name="parent">Тип, расширяющий определенный тип.</param>
		/// <returns>Объект <see langword="TypeBuilder" />, созданный с учетом всех запрошенных атрибутов.</returns>
		/// <exception cref="T:System.ArgumentException">Тип с данным именем существует в родительской сборке этого модуля.  
		///
		/// или - 
		/// Атрибуты вложенного типа установлены для типа, который не является вложенным.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600518E RID: 20878 RVA: 0x000FEF3B File Offset: 0x000FD13B
		public TypeBuilder DefineType(string name, TypeAttributes attr, Type parent)
		{
			return this.DefineType(name, attr, parent, null);
		}

		// Token: 0x0600518F RID: 20879 RVA: 0x000FEF48 File Offset: 0x000FD148
		private void AddType(TypeBuilder tb)
		{
			if (this.types != null)
			{
				if (this.types.Length == this.num_types)
				{
					TypeBuilder[] destinationArray = new TypeBuilder[this.types.Length * 2];
					Array.Copy(this.types, destinationArray, this.num_types);
					this.types = destinationArray;
				}
			}
			else
			{
				this.types = new TypeBuilder[1];
			}
			this.types[this.num_types] = tb;
			this.num_types++;
		}

		// Token: 0x06005190 RID: 20880 RVA: 0x000FEFC0 File Offset: 0x000FD1C0
		private TypeBuilder DefineType(string name, TypeAttributes attr, Type parent, Type[] interfaces, PackingSize packingSize, int typesize)
		{
			if (name == null)
			{
				throw new ArgumentNullException("fullname");
			}
			TypeIdentifier key = TypeIdentifiers.FromInternal(name);
			if (this.name_cache.ContainsKey(key))
			{
				throw new ArgumentException("Duplicate type name within an assembly.");
			}
			TypeBuilder typeBuilder = new TypeBuilder(this, name, attr, parent, interfaces, packingSize, typesize, null);
			this.AddType(typeBuilder);
			this.name_cache.Add(key, typeBuilder);
			return typeBuilder;
		}

		// Token: 0x06005191 RID: 20881 RVA: 0x000FF021 File Offset: 0x000FD221
		internal void RegisterTypeName(TypeBuilder tb, TypeName name)
		{
			this.name_cache.Add(name, tb);
		}

		// Token: 0x06005192 RID: 20882 RVA: 0x000FF030 File Offset: 0x000FD230
		internal TypeBuilder GetRegisteredType(TypeName name)
		{
			TypeBuilder result = null;
			this.name_cache.TryGetValue(name, out result);
			return result;
		}

		/// <summary>Конструирует <see langword="TypeBuilder" /> с заданными именем, атрибутами, типом, который расширяет определенный тип, и интерфейсами, реализующими этот тип.</summary>
		/// <param name="name">Полный путь к типу. Параметр <paramref name="name" /> не может содержать внедренные значения NULL.</param>
		/// <param name="attr">Атрибуты, которые будут связаны с типом.</param>
		/// <param name="parent">Тип, расширяющий определенный тип.</param>
		/// <param name="interfaces">Список интерфейсов, реализуемых типом.</param>
		/// <returns>Объект <see langword="TypeBuilder" />, созданный с учетом всех запрошенных атрибутов.</returns>
		/// <exception cref="T:System.ArgumentException">Тип с данным именем существует в родительской сборке этого модуля.  
		///
		/// или - 
		/// Атрибуты вложенного типа установлены для типа, который не является вложенным.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06005193 RID: 20883 RVA: 0x000FF04F File Offset: 0x000FD24F
		[ComVisible(true)]
		public TypeBuilder DefineType(string name, TypeAttributes attr, Type parent, Type[] interfaces)
		{
			return this.DefineType(name, attr, parent, interfaces, PackingSize.Unspecified, 0);
		}

		/// <summary>Конструирует <see langword="TypeBuilder" /> с заданными именем, атрибутами, типом, который расширяет определенный тип, и общим размером типа.</summary>
		/// <param name="name">Полный путь к типу. Параметр <paramref name="name" /> не может содержать внедренные значения NULL.</param>
		/// <param name="attr">Атрибуты определенного в результате типа.</param>
		/// <param name="parent">Тип, расширяющий определенный тип.</param>
		/// <param name="typesize">Общий размер типа.</param>
		/// <returns>Объект <see langword="TypeBuilder" />.</returns>
		/// <exception cref="T:System.ArgumentException">Тип с данным именем существует в родительской сборке этого модуля.  
		///
		/// или - 
		/// Атрибуты вложенного типа установлены для типа, который не является вложенным.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06005194 RID: 20884 RVA: 0x000FF05E File Offset: 0x000FD25E
		public TypeBuilder DefineType(string name, TypeAttributes attr, Type parent, int typesize)
		{
			return this.DefineType(name, attr, parent, null, PackingSize.Unspecified, typesize);
		}

		/// <summary>Конструирует <see langword="TypeBuilder" /> с заданными именем, атрибутами, типом, который расширяет определенный тип, и размером упаковки типа.</summary>
		/// <param name="name">Полный путь к типу. Параметр <paramref name="name" /> не может содержать внедренные значения NULL.</param>
		/// <param name="attr">Атрибуты определенного в результате типа.</param>
		/// <param name="parent">Тип, расширяющий определенный тип.</param>
		/// <param name="packsize">Размер упаковки типа.</param>
		/// <returns>Объект <see langword="TypeBuilder" />.</returns>
		/// <exception cref="T:System.ArgumentException">Тип с данным именем существует в родительской сборке этого модуля.  
		///
		/// или - 
		/// Атрибуты вложенного типа установлены для типа, который не является вложенным.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06005195 RID: 20885 RVA: 0x000FF06D File Offset: 0x000FD26D
		public TypeBuilder DefineType(string name, TypeAttributes attr, Type parent, PackingSize packsize)
		{
			return this.DefineType(name, attr, parent, null, packsize, 0);
		}

		/// <summary>Конструирует <see langword="TypeBuilder" /> с заданными именем, атрибутами, типом, который расширяет определенный тип, а также размером уплотнения и общим размером определенного типа.</summary>
		/// <param name="name">Полный путь к типу. Параметр <paramref name="name" /> не может содержать внедренные значения NULL.</param>
		/// <param name="attr">Атрибуты определенного в результате типа.</param>
		/// <param name="parent">Тип, расширяющий определенный тип.</param>
		/// <param name="packingSize">Размер упаковки типа.</param>
		/// <param name="typesize">Общий размер типа.</param>
		/// <returns>Объект <see langword="TypeBuilder" />, созданный с учетом всех запрошенных атрибутов.</returns>
		/// <exception cref="T:System.ArgumentException">Тип с данным именем существует в родительской сборке этого модуля.  
		///
		/// или - 
		/// Атрибуты вложенного типа установлены для типа, который не является вложенным.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06005196 RID: 20886 RVA: 0x000FF07C File Offset: 0x000FD27C
		public TypeBuilder DefineType(string name, TypeAttributes attr, Type parent, PackingSize packingSize, int typesize)
		{
			return this.DefineType(name, attr, parent, null, packingSize, typesize);
		}

		/// <summary>Возвращает именованный метод класса массива.</summary>
		/// <param name="arrayClass">Класс массива.</param>
		/// <param name="methodName">Имя метода класса массива.</param>
		/// <param name="callingConvention">Соглашение о вызове метода.</param>
		/// <param name="returnType">Возвращаемый тип метода.</param>
		/// <param name="parameterTypes">Типы параметров метода.</param>
		/// <returns>Именованный метод класса массива.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="arrayClass" /> не является массивом.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="arrayClass" /> или <paramref name="methodName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06005197 RID: 20887 RVA: 0x000FF08C File Offset: 0x000FD28C
		public MethodInfo GetArrayMethod(Type arrayClass, string methodName, CallingConventions callingConvention, Type returnType, Type[] parameterTypes)
		{
			return new MonoArrayMethod(arrayClass, methodName, callingConvention, returnType, parameterTypes);
		}

		/// <summary>Определяет тип перечисления, который является типом значения с одним нестатическим полем, называемым <paramref name="value__" /> указанного типа.</summary>
		/// <param name="name">Полный путь к типу перечисления. Параметр <paramref name="name" /> не может содержать внедренные значения NULL.</param>
		/// <param name="visibility">Атрибуты типа данного перечисления. Атрибутами являются любые биты, определенные с помощью <see cref="F:System.Reflection.TypeAttributes.VisibilityMask" />.</param>
		/// <param name="underlyingType">Базовый тип данного перечисления. Это должен быть встроенный целочисленный тип.</param>
		/// <returns>Определенное перечисление.</returns>
		/// <exception cref="T:System.ArgumentException">Переданы атрибуты, не являющиеся атрибутами видимости.  
		///
		/// или - 
		/// Перечисление с указанным именем существует в родительской сборке этого модуля.  
		///
		/// или - 
		/// Атрибуты видимости не соответствуют области действия перечисления. Например, если в качестве значения параметра <paramref name="visibility" /> указано <see cref="F:System.Reflection.TypeAttributes.NestedPublic" />, но перечисление не относится к вложенному типу.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06005198 RID: 20888 RVA: 0x000FF09C File Offset: 0x000FD29C
		public EnumBuilder DefineEnum(string name, TypeAttributes visibility, Type underlyingType)
		{
			TypeIdentifier key = TypeIdentifiers.FromInternal(name);
			if (this.name_cache.ContainsKey(key))
			{
				throw new ArgumentException("Duplicate type name within an assembly.");
			}
			EnumBuilder enumBuilder = new EnumBuilder(this, name, visibility, underlyingType);
			TypeBuilder typeBuilder = enumBuilder.GetTypeBuilder();
			this.AddType(typeBuilder);
			this.name_cache.Add(key, typeBuilder);
			return enumBuilder;
		}

		/// <summary>Получает именованный тип, определенный в модуле.</summary>
		/// <param name="className">Имя получаемого объекта <see cref="T:System.Type" />.</param>
		/// <returns>Запрошенный тип, если тип определен в данном модуле, в противном случае — значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">Длина параметра <paramref name="className" /> равна нулю или больше 1023.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="className" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">Запрошенный объект <see cref="T:System.Type" /> не является открытым и вызывающая сторона не имеет разрешения (<see cref="T:System.Security.Permissions.ReflectionPermission" />) на отражение неоткрытых объектов за пределами текущей сборки.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Инициализатор класса вызывается и создает исключение.</exception>
		/// <exception cref="T:System.TypeLoadException">При загрузке объекта <see cref="T:System.Type" /> произошла ошибка.</exception>
		// Token: 0x06005199 RID: 20889 RVA: 0x000EEF8A File Offset: 0x000ED18A
		[ComVisible(true)]
		public override Type GetType(string className)
		{
			return this.GetType(className, false, false);
		}

		/// <summary>Получает определенный в модуле именованный тип (с возможностью игнорирования регистра символов в имени типа).</summary>
		/// <param name="className">Имя получаемого объекта <see cref="T:System.Type" />.</param>
		/// <param name="ignoreCase">Если значение <see langword="true" />, при поиске не учитывается регистр. Если значение <see langword="false" />, при поиске учитывается регистр.</param>
		/// <returns>Запрошенный тип, если тип определен в данном модуле, в противном случае — значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">Длина параметра <paramref name="className" /> равна нулю или больше 1023.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="className" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">Запрошенный объект <see cref="T:System.Type" /> не является открытым и вызывающая сторона не имеет разрешения (<see cref="T:System.Security.Permissions.ReflectionPermission" />) на отражение неоткрытых объектов за пределами текущей сборки.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Инициализатор класса вызывается и создает исключение.</exception>
		// Token: 0x0600519A RID: 20890 RVA: 0x000EEF95 File Offset: 0x000ED195
		[ComVisible(true)]
		public override Type GetType(string className, bool ignoreCase)
		{
			return this.GetType(className, false, ignoreCase);
		}

		// Token: 0x0600519B RID: 20891 RVA: 0x000FF0F0 File Offset: 0x000FD2F0
		private TypeBuilder search_in_array(TypeBuilder[] arr, int validElementsInArray, TypeName className)
		{
			for (int i = 0; i < validElementsInArray; i++)
			{
				if (string.Compare(className.DisplayName, arr[i].FullName, true, CultureInfo.InvariantCulture) == 0)
				{
					return arr[i];
				}
			}
			return null;
		}

		// Token: 0x0600519C RID: 20892 RVA: 0x000FF12C File Offset: 0x000FD32C
		private TypeBuilder search_nested_in_array(TypeBuilder[] arr, int validElementsInArray, TypeName className)
		{
			for (int i = 0; i < validElementsInArray; i++)
			{
				if (string.Compare(className.DisplayName, arr[i].Name, true, CultureInfo.InvariantCulture) == 0)
				{
					return arr[i];
				}
			}
			return null;
		}

		// Token: 0x0600519D RID: 20893 RVA: 0x000FF168 File Offset: 0x000FD368
		private TypeBuilder GetMaybeNested(TypeBuilder t, IEnumerable<TypeName> nested)
		{
			TypeBuilder typeBuilder = t;
			foreach (TypeName className in nested)
			{
				if (typeBuilder.subtypes == null)
				{
					return null;
				}
				typeBuilder = this.search_nested_in_array(typeBuilder.subtypes, typeBuilder.subtypes.Length, className);
				if (typeBuilder == null)
				{
					return null;
				}
			}
			return typeBuilder;
		}

		/// <summary>Получает определенный в модуле именованный тип (с возможностью игнорирования регистра символов в имени типа). Позволяет указать, следует ли создавать исключение, если тип не будет найден.</summary>
		/// <param name="className">Имя получаемого объекта <see cref="T:System.Type" />.</param>
		/// <param name="throwOnError">Значение <see langword="true" />, чтобы создать исключение, если тип не удается найти; значение <see langword="false" />, чтобы вернуть значение <see langword="null" />.</param>
		/// <param name="ignoreCase">Если значение <see langword="true" />, при поиске не учитывается регистр. Если значение <see langword="false" />, при поиске учитывается регистр.</param>
		/// <returns>Заданный тип, если тип объявлен в данном модуле, в противном случае — значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">Длина параметра <paramref name="className" /> равна нулю или больше 1023.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="className" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">Запрошенный объект <see cref="T:System.Type" /> не является открытым и вызывающая сторона не имеет разрешения (<see cref="T:System.Security.Permissions.ReflectionPermission" />) на отражение неоткрытых объектов за пределами текущей сборки.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Инициализатор класса вызывается и создает исключение.</exception>
		/// <exception cref="T:System.TypeLoadException">Значение параметра <paramref name="throwOnError" /> равно <see langword="true" />, и указанный тип не был найден.</exception>
		// Token: 0x0600519E RID: 20894 RVA: 0x000FF1E0 File Offset: 0x000FD3E0
		[ComVisible(true)]
		public override Type GetType(string className, bool throwOnError, bool ignoreCase)
		{
			if (className == null)
			{
				throw new ArgumentNullException("className");
			}
			if (className.Length == 0)
			{
				throw new ArgumentException("className");
			}
			TypeBuilder typeBuilder = null;
			if (this.types == null && throwOnError)
			{
				throw new TypeLoadException(className);
			}
			TypeSpec typeSpec = TypeSpec.Parse(className);
			if (!ignoreCase)
			{
				TypeName key = typeSpec.TypeNameWithoutModifiers();
				this.name_cache.TryGetValue(key, out typeBuilder);
			}
			else
			{
				if (this.types != null)
				{
					typeBuilder = this.search_in_array(this.types, this.num_types, typeSpec.Name);
				}
				if (!typeSpec.IsNested && typeBuilder != null)
				{
					typeBuilder = this.GetMaybeNested(typeBuilder, typeSpec.Nested);
				}
			}
			if (typeBuilder == null && throwOnError)
			{
				throw new TypeLoadException(className);
			}
			if (typeBuilder != null && (typeSpec.HasModifiers || typeSpec.IsByRef))
			{
				Type type = typeBuilder;
				if (typeBuilder != null)
				{
					TypeBuilder typeBuilder2 = typeBuilder;
					if (typeBuilder2.is_created)
					{
						type = typeBuilder2.CreateType();
					}
				}
				foreach (ModifierSpec modifierSpec in typeSpec.Modifiers)
				{
					if (modifierSpec is PointerSpec)
					{
						type = type.MakePointerType();
					}
					else if (modifierSpec is ArraySpec)
					{
						ArraySpec arraySpec = modifierSpec as ArraySpec;
						if (arraySpec.IsBound)
						{
							return null;
						}
						if (arraySpec.Rank == 1)
						{
							type = type.MakeArrayType();
						}
						else
						{
							type = type.MakeArrayType(arraySpec.Rank);
						}
					}
				}
				if (typeSpec.IsByRef)
				{
					type = type.MakeByRefType();
				}
				typeBuilder = (type as TypeBuilder);
				if (typeBuilder == null)
				{
					return type;
				}
			}
			if (typeBuilder != null && typeBuilder.is_created)
			{
				return typeBuilder.CreateType();
			}
			return typeBuilder;
		}

		// Token: 0x0600519F RID: 20895 RVA: 0x000FF3A0 File Offset: 0x000FD5A0
		internal int get_next_table_index(object obj, int table, int count)
		{
			if (this.table_indexes == null)
			{
				this.table_indexes = new int[64];
				for (int i = 0; i < 64; i++)
				{
					this.table_indexes[i] = 1;
				}
				this.table_indexes[2] = 2;
			}
			int result = this.table_indexes[table];
			this.table_indexes[table] += count;
			return result;
		}

		/// <summary>Применяет к модулю настраиваемый атрибут с помощью построителя настраиваемых атрибутов.</summary>
		/// <param name="customBuilder">Экземпляр вспомогательного класса для определения применяемого пользовательского атрибута.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="customBuilder" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060051A0 RID: 20896 RVA: 0x000FF3FC File Offset: 0x000FD5FC
		public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
		{
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

		/// <summary>Устанавливает пользовательский атрибут для этого модуля с помощью указанного большого двоичного объекта (BLOB), представляющего атрибут.</summary>
		/// <param name="con">Конструктор настраиваемого атрибута.</param>
		/// <param name="binaryAttribute">Большой двоичный объект байтов, представляющий атрибут.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="con" /> или <paramref name="binaryAttribute" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060051A1 RID: 20897 RVA: 0x000FF456 File Offset: 0x000FD656
		[ComVisible(true)]
		public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
		{
			this.SetCustomAttribute(new CustomAttributeBuilder(con, binaryAttribute));
		}

		/// <summary>Возвращается интерфейс записи символов, связанный с данным динамическим модулем.</summary>
		/// <returns>Интерфейс записи символов, связанный с данным динамическим модулем.</returns>
		// Token: 0x060051A2 RID: 20898 RVA: 0x000FF465 File Offset: 0x000FD665
		public ISymbolWriter GetSymWriter()
		{
			return this.symbolWriter;
		}

		/// <summary>Определяет документ-источник.</summary>
		/// <param name="url">URL-адрес документа.</param>
		/// <param name="language">GUID, предназначенный для идентификации языка документа. Это может быть <see cref="F:System.Guid.Empty" />.</param>
		/// <param name="languageVendor">GUID, предназначенный для идентификации поставщика языка документа. Это может быть <see cref="F:System.Guid.Empty" />.</param>
		/// <param name="documentType">GUID, предназначенный для идентификации типа документа. Это может быть <see cref="F:System.Guid.Empty" />.</param>
		/// <returns>Определенный документ.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="url" /> имеет значение <see langword="null" />. Это изменение из более ранних версий .NET Framework.</exception>
		/// <exception cref="T:System.InvalidOperationException">Этот метод вызывается для динамического модуля, не являющегося отладочным.</exception>
		// Token: 0x060051A3 RID: 20899 RVA: 0x000FF46D File Offset: 0x000FD66D
		public ISymbolDocumentWriter DefineDocument(string url, Guid language, Guid languageVendor, Guid documentType)
		{
			if (this.symbolWriter != null)
			{
				return this.symbolWriter.DefineDocument(url, language, languageVendor, documentType);
			}
			return null;
		}

		/// <summary>Возвращаются все классы, определенные в данном модуле.</summary>
		/// <returns>Массив, содержащий типы, которые определены в модуле, отражаемом данным экземпляром.</returns>
		/// <exception cref="T:System.Reflection.ReflectionTypeLoadException">Невозможно загрузить один или несколько классов в модуле.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x060051A4 RID: 20900 RVA: 0x000FF48C File Offset: 0x000FD68C
		public override Type[] GetTypes()
		{
			if (this.types == null)
			{
				return Type.EmptyTypes;
			}
			int num = this.num_types;
			Type[] array = new Type[num];
			Array.Copy(this.types, array, num);
			for (int i = 0; i < array.Length; i++)
			{
				if (this.types[i].is_created)
				{
					array[i] = this.types[i].CreateType();
				}
			}
			return array;
		}

		/// <summary>Определяет именованный управляемый внедренный ресурс с указанными атрибутами, который будет сохранен в данном модуле.</summary>
		/// <param name="name">Имя ресурса. Параметр <paramref name="name" /> не может содержать внедренные значения NULL.</param>
		/// <param name="description">Описание ресурса.</param>
		/// <param name="attribute">Атрибуты ресурса.</param>
		/// <returns>Интерфейс записи ресурса для определенного ресурса.</returns>
		/// <exception cref="T:System.ArgumentException">Длина параметра <paramref name="name" /> равна нулю.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение null.</exception>
		/// <exception cref="T:System.InvalidOperationException">Модуль является несохраняемым.  
		///
		/// или - 
		/// Включающая сборка не является сохраненной.</exception>
		// Token: 0x060051A5 RID: 20901 RVA: 0x000FF4F0 File Offset: 0x000FD6F0
		public IResourceWriter DefineResource(string name, string description, ResourceAttributes attribute)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (name == string.Empty)
			{
				throw new ArgumentException("name cannot be empty");
			}
			if (this.transient)
			{
				throw new InvalidOperationException("The module is transient");
			}
			if (!this.assemblyb.IsSave)
			{
				throw new InvalidOperationException("The assembly is transient");
			}
			ResourceWriter resourceWriter = new ResourceWriter(new MemoryStream());
			if (this.resource_writers == null)
			{
				this.resource_writers = new Hashtable();
			}
			this.resource_writers[name] = resourceWriter;
			if (this.resources != null)
			{
				MonoResource[] destinationArray = new MonoResource[this.resources.Length + 1];
				Array.Copy(this.resources, destinationArray, this.resources.Length);
				this.resources = destinationArray;
			}
			else
			{
				this.resources = new MonoResource[1];
			}
			int num = this.resources.Length - 1;
			this.resources[num].name = name;
			this.resources[num].attrs = attribute;
			return resourceWriter;
		}

		/// <summary>Определяет именованный управляемый внедренный ресурс, сохраняемый в данном модуле.</summary>
		/// <param name="name">Имя ресурса. Параметр <paramref name="name" /> не может содержать внедренные значения NULL.</param>
		/// <param name="description">Описание ресурса.</param>
		/// <returns>Интерфейс записи ресурса для определенного ресурса.</returns>
		/// <exception cref="T:System.ArgumentException">Длина параметра <paramref name="name" /> равна нулю.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение null.</exception>
		/// <exception cref="T:System.InvalidOperationException">Модуль является несохраняемым.  
		///
		/// или - 
		/// Включающая сборка не является сохраненной.</exception>
		// Token: 0x060051A6 RID: 20902 RVA: 0x000FF5EA File Offset: 0x000FD7EA
		public IResourceWriter DefineResource(string name, string description)
		{
			return this.DefineResource(name, description, ResourceAttributes.Public);
		}

		/// <summary>Определяет неуправляемый внедренный ресурс как закрытый большой двоичный объект (BLOB) байтов.</summary>
		/// <param name="resource">Закрытый большой двоичный объект, который предоставляет неуправляемый ресурс/</param>
		/// <exception cref="T:System.ArgumentException">Неуправляемый ресурс уже был определен в сборке модуля.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="resource" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060051A7 RID: 20903 RVA: 0x000FF5F5 File Offset: 0x000FD7F5
		[MonoTODO]
		public void DefineUnmanagedResource(byte[] resource)
		{
			if (resource == null)
			{
				throw new ArgumentNullException("resource");
			}
			throw new NotImplementedException();
		}

		/// <summary>Определяет неуправляемый ресурс с указанием имени файла ресурсов Win32.</summary>
		/// <param name="resourceFileName">Имя файла неуправляемых ресурсов.</param>
		/// <exception cref="T:System.ArgumentException">Неуправляемый ресурс уже был определен в сборке модуля.  
		///
		/// или - 
		/// <paramref name="resourceFileName" /> является пустой строкой ("").</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="resourceFileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="resourceFileName" /> не найден.  
		///
		/// или - 
		/// <paramref name="resourceFileName" /> является каталогом.</exception>
		// Token: 0x060051A8 RID: 20904 RVA: 0x000FF60C File Offset: 0x000FD80C
		[MonoTODO]
		public void DefineUnmanagedResource(string resourceFileName)
		{
			if (resourceFileName == null)
			{
				throw new ArgumentNullException("resourceFileName");
			}
			if (resourceFileName == string.Empty)
			{
				throw new ArgumentException("resourceFileName");
			}
			if (!File.Exists(resourceFileName) || Directory.Exists(resourceFileName))
			{
				throw new FileNotFoundException("File '" + resourceFileName + "' does not exist or is a directory.");
			}
			throw new NotImplementedException();
		}

		/// <summary>Определяет большой двоичный объект (BLOB), представляющий ресурс манифеста, который должен быть внедрен в динамическую сборку.</summary>
		/// <param name="name">Имя ресурса, зависящее от регистра.</param>
		/// <param name="stream">Поток, содержащий байты, предназначенные для ресурса.</param>
		/// <param name="attribute">Значение перечисления, которое определяет, является ли ресурс закрытым или открытым.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="stream" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="name" /> представляет собой строку нулевой длины.</exception>
		/// <exception cref="T:System.InvalidOperationException">Динамическая сборка, которая содержит текущий модуль, является несохраняемой, то есть при вызове <see cref="M:System.Reflection.Emit.AssemblyBuilder.DefineDynamicModule(System.String,System.String)" /> не было указано имя файла.</exception>
		// Token: 0x060051A9 RID: 20905 RVA: 0x000FF66C File Offset: 0x000FD86C
		public void DefineManifestResource(string name, Stream stream, ResourceAttributes attribute)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (name == string.Empty)
			{
				throw new ArgumentException("name cannot be empty");
			}
			if (stream == null)
			{
				throw new ArgumentNullException("stream");
			}
			if (this.transient)
			{
				throw new InvalidOperationException("The module is transient");
			}
			if (!this.assemblyb.IsSave)
			{
				throw new InvalidOperationException("The assembly is transient");
			}
			if (this.resources != null)
			{
				MonoResource[] destinationArray = new MonoResource[this.resources.Length + 1];
				Array.Copy(this.resources, destinationArray, this.resources.Length);
				this.resources = destinationArray;
			}
			else
			{
				this.resources = new MonoResource[1];
			}
			int num = this.resources.Length - 1;
			this.resources[num].name = name;
			this.resources[num].attrs = attribute;
			this.resources[num].stream = stream;
		}

		/// <summary>Этот метод не выполняет никаких действий.</summary>
		/// <param name="name">Имя пользовательского атрибута</param>
		/// <param name="data">Закрытый большой двоичный объект (BLOB) байтов, представляющий значение настраиваемого атрибута.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="url" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060051AA RID: 20906 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public void SetSymCustomAttribute(string name, byte[] data)
		{
			throw new NotImplementedException();
		}

		/// <summary>Устанавливает пользовательскую точка входа.</summary>
		/// <param name="entryPoint">Пользовательская точка входа.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="entryPoint" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Этот метод вызывается для динамического модуля, не являющегося отладочным.  
		///
		/// или - 
		/// точка входа, заданная параметром <paramref name="entryPoint" />, не содержится в данном динамическом модуле.</exception>
		// Token: 0x060051AB RID: 20907 RVA: 0x000FF75A File Offset: 0x000FD95A
		[MonoTODO]
		public void SetUserEntryPoint(MethodInfo entryPoint)
		{
			if (entryPoint == null)
			{
				throw new ArgumentNullException("entryPoint");
			}
			if (entryPoint.DeclaringType.Module != this)
			{
				throw new InvalidOperationException("entryPoint is not contained in this module");
			}
			throw new NotImplementedException();
		}

		/// <summary>Возвращает токен, используемый для идентификации указанного метода в данном модуле.</summary>
		/// <param name="method">Метод, для которого нужно получить токен.</param>
		/// <returns>Токен, используемый для идентификации указанного метода в данном модуле.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="method" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Объявляемый тип метода не содержится в данном модуле.</exception>
		// Token: 0x060051AC RID: 20908 RVA: 0x000FF793 File Offset: 0x000FD993
		public MethodToken GetMethodToken(MethodInfo method)
		{
			if (method == null)
			{
				throw new ArgumentNullException("method");
			}
			return new MethodToken(this.GetToken(method));
		}

		/// <summary>Возвращает токен, используемый для идентификации метода с заданными атрибутами и типами параметров в данном модуле.</summary>
		/// <param name="method">Метод, для которого нужно получить токен.</param>
		/// <param name="optionalParameterTypes">Коллекция типов необязательных параметров для метода.</param>
		/// <returns>Токен, используемый для идентификации указанного метода в данном модуле.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="method" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Объявляемый тип метода не содержится в данном модуле.</exception>
		// Token: 0x060051AD RID: 20909 RVA: 0x000FF7B5 File Offset: 0x000FD9B5
		public MethodToken GetMethodToken(MethodInfo method, IEnumerable<Type> optionalParameterTypes)
		{
			if (method == null)
			{
				throw new ArgumentNullException("method");
			}
			return new MethodToken(this.GetToken(method, optionalParameterTypes));
		}

		/// <summary>Возвращает маркер для именованного метода класса массива.</summary>
		/// <param name="arrayClass">Объект массива.</param>
		/// <param name="methodName">Строка, содержащая имя метода.</param>
		/// <param name="callingConvention">Соглашение о вызовах для метода.</param>
		/// <param name="returnType">Возвращаемый тип метода.</param>
		/// <param name="parameterTypes">Типы параметров метода.</param>
		/// <returns>маркер именованного метода класса массива.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="arrayClass" /> не является массивом.  
		///
		/// или - 
		/// Длина параметра <paramref name="methodName" /> равна нулю.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="arrayClass" /> или <paramref name="methodName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060051AE RID: 20910 RVA: 0x000FF7D8 File Offset: 0x000FD9D8
		public MethodToken GetArrayMethodToken(Type arrayClass, string methodName, CallingConventions callingConvention, Type returnType, Type[] parameterTypes)
		{
			return this.GetMethodToken(this.GetArrayMethod(arrayClass, methodName, callingConvention, returnType, parameterTypes));
		}

		/// <summary>Возвращает маркер, используемый для идентификации указанного конструктора в данном модуле.</summary>
		/// <param name="con">Конструктор, для которого нужно получить токен.</param>
		/// <returns>Токен, используемый для идентификации указанного конструктора в данном модуле.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="con" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060051AF RID: 20911 RVA: 0x000FF7ED File Offset: 0x000FD9ED
		[ComVisible(true)]
		public MethodToken GetConstructorToken(ConstructorInfo con)
		{
			if (con == null)
			{
				throw new ArgumentNullException("con");
			}
			return new MethodToken(this.GetToken(con));
		}

		/// <summary>Возвращает токен, используемый для идентификации конструктора с заданными атрибутами и типами параметров в данном модуле.</summary>
		/// <param name="constructor">Конструктор, для которого нужно получить токен.</param>
		/// <param name="optionalParameterTypes">Коллекция типов необязательных параметров для конструктора.</param>
		/// <returns>Токен, используемый для идентификации указанного конструктора в данном модуле.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="constructor" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060051B0 RID: 20912 RVA: 0x000FF80F File Offset: 0x000FDA0F
		public MethodToken GetConstructorToken(ConstructorInfo constructor, IEnumerable<Type> optionalParameterTypes)
		{
			if (constructor == null)
			{
				throw new ArgumentNullException("constructor");
			}
			return new MethodToken(this.GetToken(constructor, optionalParameterTypes));
		}

		/// <summary>Возвращает токен, используемый для идентификации указанного поля в данном модуле.</summary>
		/// <param name="field">Поле, для которого нужно получить токен.</param>
		/// <returns>Токен, используемый для идентификации указанного поля в данном модуле.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="field" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060051B1 RID: 20913 RVA: 0x000FF832 File Offset: 0x000FDA32
		public FieldToken GetFieldToken(FieldInfo field)
		{
			if (field == null)
			{
				throw new ArgumentNullException("field");
			}
			return new FieldToken(this.GetToken(field));
		}

		/// <summary>Определяет токен для сигнатуры, заданной массивом символов и длиной сигнатуры.</summary>
		/// <param name="sigBytes">Большой двоичный объект (BLOB) сигнатуры.</param>
		/// <param name="sigLength">Длина большого двоичного объекта сигнатуры.</param>
		/// <returns>Токен для указанной сигнатуры.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="sigBytes" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060051B2 RID: 20914 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public SignatureToken GetSignatureToken(byte[] sigBytes, int sigLength)
		{
			throw new NotImplementedException();
		}

		/// <summary>Определяет маркер для сигнатуры, определенной указанным объектом <see cref="T:System.Reflection.Emit.SignatureHelper" />.</summary>
		/// <param name="sigHelper">Сигнатура.</param>
		/// <returns>Токен для определенной сигнатуры.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="sigHelper" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060051B3 RID: 20915 RVA: 0x000FF854 File Offset: 0x000FDA54
		public SignatureToken GetSignatureToken(SignatureHelper sigHelper)
		{
			if (sigHelper == null)
			{
				throw new ArgumentNullException("sigHelper");
			}
			return new SignatureToken(this.GetToken(sigHelper));
		}

		/// <summary>Возвращается токен заданной строки из пула констант модуля.</summary>
		/// <param name="str">Строка, которую следует добавить в пул констант модуля.</param>
		/// <returns>Токен строки в пуле констант.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="str" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060051B4 RID: 20916 RVA: 0x000FF870 File Offset: 0x000FDA70
		public StringToken GetStringConstant(string str)
		{
			if (str == null)
			{
				throw new ArgumentNullException("str");
			}
			return new StringToken(this.GetToken(str));
		}

		/// <summary>Возвращает маркер, используемый для идентификации указанного типа в данном модуле.</summary>
		/// <param name="type">Объект типа, предоставляющий тип класса.</param>
		/// <returns>Токен, используемый для идентификации указанного типа в данном модуле.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="type" /> относится к типу <see langword="ByRef" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Не являющийся несохраняемым модуль ссылается на несохраняемый модуль.</exception>
		// Token: 0x060051B5 RID: 20917 RVA: 0x000FF88C File Offset: 0x000FDA8C
		public TypeToken GetTypeToken(Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (type.IsByRef)
			{
				throw new ArgumentException("type can't be a byref type", "type");
			}
			if (!this.IsTransient() && type.Module is ModuleBuilder && ((ModuleBuilder)type.Module).IsTransient())
			{
				throw new InvalidOperationException("a non-transient module can't reference a transient module");
			}
			return new TypeToken(this.GetToken(type));
		}

		/// <summary>Возвращает токен, используемый для идентификации типа с указанным именем.</summary>
		/// <param name="name">Полное имя класса, включая пространство имен.</param>
		/// <returns>Токен, используемый для идентификации типа с указанным именем в данном модуле.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="name" /> является пустой строкой ("").  
		///
		/// или - 
		/// <paramref name="name" /> представляет тип <see langword="ByRef" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Не удается найти тип, указанный с помощью <paramref name="name" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Не являющийся несохраняемым модуль ссылается на несохраняемый модуль.</exception>
		// Token: 0x060051B6 RID: 20918 RVA: 0x000FF903 File Offset: 0x000FDB03
		public TypeToken GetTypeToken(string name)
		{
			return this.GetTypeToken(this.GetType(name));
		}

		// Token: 0x060051B7 RID: 20919
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int getUSIndex(ModuleBuilder mb, string str);

		// Token: 0x060051B8 RID: 20920
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int getToken(ModuleBuilder mb, object obj, bool create_open_instance);

		// Token: 0x060051B9 RID: 20921
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int getMethodToken(ModuleBuilder mb, MethodBase method, Type[] opt_param_types);

		// Token: 0x060051BA RID: 20922 RVA: 0x000FF914 File Offset: 0x000FDB14
		internal int GetToken(string str)
		{
			int usindex;
			if (!this.us_string_cache.TryGetValue(str, out usindex))
			{
				usindex = ModuleBuilder.getUSIndex(this, str);
				this.us_string_cache[str] = usindex;
			}
			return usindex;
		}

		// Token: 0x060051BB RID: 20923 RVA: 0x000FF948 File Offset: 0x000FDB48
		private int GetPseudoToken(MemberInfo member, bool create_open_instance)
		{
			Dictionary<MemberInfo, int> dictionary = create_open_instance ? this.inst_tokens_open : this.inst_tokens;
			int num;
			if (dictionary == null)
			{
				dictionary = new Dictionary<MemberInfo, int>(ReferenceEqualityComparer<MemberInfo>.Instance);
				if (create_open_instance)
				{
					this.inst_tokens_open = dictionary;
				}
				else
				{
					this.inst_tokens = dictionary;
				}
			}
			else if (dictionary.TryGetValue(member, out num))
			{
				return num;
			}
			if (member is TypeBuilderInstantiation || member is SymbolType)
			{
				num = ModuleBuilder.typespec_tokengen--;
			}
			else if (member is FieldOnTypeBuilderInst)
			{
				num = ModuleBuilder.memberref_tokengen--;
			}
			else if (member is ConstructorOnTypeBuilderInst)
			{
				num = ModuleBuilder.memberref_tokengen--;
			}
			else if (member is MethodOnTypeBuilderInst)
			{
				num = ModuleBuilder.memberref_tokengen--;
			}
			else if (member is FieldBuilder)
			{
				num = ModuleBuilder.memberref_tokengen--;
			}
			else if (member is TypeBuilder)
			{
				if (create_open_instance && (member as TypeBuilder).ContainsGenericParameters)
				{
					num = ModuleBuilder.typespec_tokengen--;
				}
				else if (member.Module == this)
				{
					num = ModuleBuilder.typedef_tokengen--;
				}
				else
				{
					num = ModuleBuilder.typeref_tokengen--;
				}
			}
			else
			{
				if (member is EnumBuilder)
				{
					num = this.GetPseudoToken((member as EnumBuilder).GetTypeBuilder(), create_open_instance);
					dictionary[member] = num;
					return num;
				}
				if (member is ConstructorBuilder)
				{
					if (member.Module == this && !(member as ConstructorBuilder).TypeBuilder.ContainsGenericParameters)
					{
						num = ModuleBuilder.methoddef_tokengen--;
					}
					else
					{
						num = ModuleBuilder.memberref_tokengen--;
					}
				}
				else if (member is MethodBuilder)
				{
					MethodBuilder methodBuilder = member as MethodBuilder;
					if (member.Module == this && !methodBuilder.TypeBuilder.ContainsGenericParameters && !methodBuilder.IsGenericMethodDefinition)
					{
						num = ModuleBuilder.methoddef_tokengen--;
					}
					else
					{
						num = ModuleBuilder.memberref_tokengen--;
					}
				}
				else
				{
					if (!(member is GenericTypeParameterBuilder))
					{
						throw new NotImplementedException();
					}
					num = ModuleBuilder.typespec_tokengen--;
				}
			}
			dictionary[member] = num;
			this.RegisterToken(member, num);
			return num;
		}

		// Token: 0x060051BC RID: 20924 RVA: 0x000FFB76 File Offset: 0x000FDD76
		internal int GetToken(MemberInfo member)
		{
			if (member is ConstructorBuilder || member is MethodBuilder || member is FieldBuilder)
			{
				return this.GetPseudoToken(member, false);
			}
			return ModuleBuilder.getToken(this, member, true);
		}

		// Token: 0x060051BD RID: 20925 RVA: 0x000FFBA4 File Offset: 0x000FDDA4
		internal int GetToken(MemberInfo member, bool create_open_instance)
		{
			if (member is TypeBuilderInstantiation || member is FieldOnTypeBuilderInst || member is ConstructorOnTypeBuilderInst || member is MethodOnTypeBuilderInst || member is SymbolType || member is FieldBuilder || member is TypeBuilder || member is ConstructorBuilder || member is MethodBuilder || member is GenericTypeParameterBuilder || member is EnumBuilder)
			{
				return this.GetPseudoToken(member, create_open_instance);
			}
			return ModuleBuilder.getToken(this, member, create_open_instance);
		}

		// Token: 0x060051BE RID: 20926 RVA: 0x000FFC1C File Offset: 0x000FDE1C
		internal int GetToken(MethodBase method, IEnumerable<Type> opt_param_types)
		{
			if (method is ConstructorBuilder || method is MethodBuilder)
			{
				return this.GetPseudoToken(method, false);
			}
			if (opt_param_types == null)
			{
				return ModuleBuilder.getToken(this, method, true);
			}
			List<Type> list = new List<Type>(opt_param_types);
			return ModuleBuilder.getMethodToken(this, method, list.ToArray());
		}

		// Token: 0x060051BF RID: 20927 RVA: 0x000FFC62 File Offset: 0x000FDE62
		internal int GetToken(MethodBase method, Type[] opt_param_types)
		{
			if (method is ConstructorBuilder || method is MethodBuilder)
			{
				return this.GetPseudoToken(method, false);
			}
			return ModuleBuilder.getMethodToken(this, method, opt_param_types);
		}

		// Token: 0x060051C0 RID: 20928 RVA: 0x000FFC85 File Offset: 0x000FDE85
		internal int GetToken(SignatureHelper helper)
		{
			return ModuleBuilder.getToken(this, helper, true);
		}

		// Token: 0x060051C1 RID: 20929
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void RegisterToken(object obj, int token);

		// Token: 0x060051C2 RID: 20930
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern object GetRegisteredToken(int token);

		// Token: 0x060051C3 RID: 20931 RVA: 0x000FFC8F File Offset: 0x000FDE8F
		internal TokenGenerator GetTokenGenerator()
		{
			if (this.token_gen == null)
			{
				this.token_gen = new ModuleBuilderTokenGenerator(this);
			}
			return this.token_gen;
		}

		// Token: 0x060051C4 RID: 20932 RVA: 0x000FFCAC File Offset: 0x000FDEAC
		internal static object RuntimeResolve(object obj)
		{
			if (obj is MethodBuilder)
			{
				return (obj as MethodBuilder).RuntimeResolve();
			}
			if (obj is ConstructorBuilder)
			{
				return (obj as ConstructorBuilder).RuntimeResolve();
			}
			if (obj is FieldBuilder)
			{
				return (obj as FieldBuilder).RuntimeResolve();
			}
			if (obj is GenericTypeParameterBuilder)
			{
				return (obj as GenericTypeParameterBuilder).RuntimeResolve();
			}
			if (obj is FieldOnTypeBuilderInst)
			{
				return (obj as FieldOnTypeBuilderInst).RuntimeResolve();
			}
			if (obj is MethodOnTypeBuilderInst)
			{
				return (obj as MethodOnTypeBuilderInst).RuntimeResolve();
			}
			if (obj is ConstructorOnTypeBuilderInst)
			{
				return (obj as ConstructorOnTypeBuilderInst).RuntimeResolve();
			}
			if (obj is Type)
			{
				return (obj as Type).RuntimeResolve();
			}
			throw new NotImplementedException(obj.GetType().FullName);
		}

		// Token: 0x060051C5 RID: 20933
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void build_metadata(ModuleBuilder mb);

		// Token: 0x060051C6 RID: 20934
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void WriteToFile(IntPtr handle);

		// Token: 0x060051C7 RID: 20935 RVA: 0x000FFD6C File Offset: 0x000FDF6C
		private void FixupTokens(Dictionary<int, int> token_map, Dictionary<int, MemberInfo> member_map, Dictionary<MemberInfo, int> inst_tokens, bool open)
		{
			foreach (KeyValuePair<MemberInfo, int> keyValuePair in inst_tokens)
			{
				MemberInfo key = keyValuePair.Key;
				int value = keyValuePair.Value;
				MemberInfo memberInfo;
				if (key is TypeBuilderInstantiation || key is SymbolType)
				{
					memberInfo = (key as Type).RuntimeResolve();
				}
				else if (key is FieldOnTypeBuilderInst)
				{
					memberInfo = (key as FieldOnTypeBuilderInst).RuntimeResolve();
				}
				else if (key is ConstructorOnTypeBuilderInst)
				{
					memberInfo = (key as ConstructorOnTypeBuilderInst).RuntimeResolve();
				}
				else if (key is MethodOnTypeBuilderInst)
				{
					memberInfo = (key as MethodOnTypeBuilderInst).RuntimeResolve();
				}
				else if (key is FieldBuilder)
				{
					memberInfo = (key as FieldBuilder).RuntimeResolve();
				}
				else if (key is TypeBuilder)
				{
					memberInfo = (key as TypeBuilder).RuntimeResolve();
				}
				else if (key is EnumBuilder)
				{
					memberInfo = (key as EnumBuilder).RuntimeResolve();
				}
				else if (key is ConstructorBuilder)
				{
					memberInfo = (key as ConstructorBuilder).RuntimeResolve();
				}
				else if (key is MethodBuilder)
				{
					memberInfo = (key as MethodBuilder).RuntimeResolve();
				}
				else
				{
					if (!(key is GenericTypeParameterBuilder))
					{
						throw new NotImplementedException();
					}
					memberInfo = (key as GenericTypeParameterBuilder).RuntimeResolve();
				}
				int value2 = this.GetToken(memberInfo, open);
				token_map[value] = value2;
				member_map[value] = memberInfo;
				this.RegisterToken(memberInfo, value);
			}
		}

		// Token: 0x060051C8 RID: 20936 RVA: 0x000FFF00 File Offset: 0x000FE100
		private void FixupTokens()
		{
			Dictionary<int, int> token_map = new Dictionary<int, int>();
			Dictionary<int, MemberInfo> member_map = new Dictionary<int, MemberInfo>();
			if (this.inst_tokens != null)
			{
				this.FixupTokens(token_map, member_map, this.inst_tokens, false);
			}
			if (this.inst_tokens_open != null)
			{
				this.FixupTokens(token_map, member_map, this.inst_tokens_open, true);
			}
			if (this.types != null)
			{
				for (int i = 0; i < this.num_types; i++)
				{
					this.types[i].FixupTokens(token_map, member_map);
				}
			}
		}

		// Token: 0x060051C9 RID: 20937 RVA: 0x000FFF70 File Offset: 0x000FE170
		internal void Save()
		{
			if (this.transient && !this.is_main)
			{
				return;
			}
			if (this.types != null)
			{
				for (int i = 0; i < this.num_types; i++)
				{
					if (!this.types[i].is_created)
					{
						throw new NotSupportedException("Type '" + this.types[i].FullName + "' was not completed.");
					}
				}
			}
			this.FixupTokens();
			if (this.global_type != null && this.global_type_created == null)
			{
				this.global_type_created = this.global_type.CreateType();
			}
			if (this.resources != null)
			{
				for (int j = 0; j < this.resources.Length; j++)
				{
					IResourceWriter resourceWriter;
					if (this.resource_writers != null && (resourceWriter = (this.resource_writers[this.resources[j].name] as IResourceWriter)) != null)
					{
						ResourceWriter resourceWriter2 = (ResourceWriter)resourceWriter;
						resourceWriter2.Generate();
						MemoryStream memoryStream = (MemoryStream)resourceWriter2._output;
						this.resources[j].data = new byte[memoryStream.Length];
						memoryStream.Seek(0L, SeekOrigin.Begin);
						memoryStream.Read(this.resources[j].data, 0, (int)memoryStream.Length);
					}
					else
					{
						Stream stream = this.resources[j].stream;
						if (stream != null)
						{
							try
							{
								long length = stream.Length;
								this.resources[j].data = new byte[length];
								stream.Seek(0L, SeekOrigin.Begin);
								stream.Read(this.resources[j].data, 0, (int)length);
							}
							catch
							{
							}
						}
					}
				}
			}
			ModuleBuilder.build_metadata(this);
			string text = this.fqname;
			if (this.assemblyb.AssemblyDir != null)
			{
				text = Path.Combine(this.assemblyb.AssemblyDir, text);
			}
			try
			{
				File.Delete(text);
			}
			catch
			{
			}
			using (FileStream fileStream = new FileStream(text, FileMode.Create, FileAccess.Write))
			{
				this.WriteToFile(fileStream.Handle);
			}
			File.SetAttributes(text, (FileAttributes)(-2147483648));
			if (this.types != null && this.symbolWriter != null)
			{
				for (int k = 0; k < this.num_types; k++)
				{
					this.types[k].GenerateDebugInfo(this.symbolWriter);
				}
				this.symbolWriter.Close();
			}
		}

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x060051CA RID: 20938 RVA: 0x00100200 File Offset: 0x000FE400
		internal string FileName
		{
			get
			{
				return this.fqname;
			}
		}

		// Token: 0x17000D7E RID: 3454
		// (set) Token: 0x060051CB RID: 20939 RVA: 0x00100208 File Offset: 0x000FE408
		internal bool IsMain
		{
			set
			{
				this.is_main = value;
			}
		}

		// Token: 0x060051CC RID: 20940 RVA: 0x00100211 File Offset: 0x000FE411
		internal void CreateGlobalType()
		{
			if (this.global_type == null)
			{
				this.global_type = new TypeBuilder(this, TypeAttributes.NotPublic, 1);
			}
		}

		// Token: 0x060051CD RID: 20941 RVA: 0x0010022F File Offset: 0x000FE42F
		internal override Guid GetModuleVersionId()
		{
			return new Guid(this.guid);
		}

		/// <summary>Получает динамическую сборку, определившую данный экземпляр <see cref="T:System.Reflection.Emit.ModuleBuilder" />.</summary>
		/// <returns>Динамическая сборка, определившая текущий динамический модуль.</returns>
		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x060051CE RID: 20942 RVA: 0x0010023C File Offset: 0x000FE43C
		public override Assembly Assembly
		{
			get
			{
				return this.assemblyb;
			}
		}

		/// <summary>Строка, указывающая, что это модуль, расположенный в памяти.</summary>
		/// <returns>Текст, указывающий, что это модуль, расположенный в памяти.</returns>
		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x060051CF RID: 20943 RVA: 0x00100244 File Offset: 0x000FE444
		public override string Name
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Получает строку, представляющую имя динамического модуля.</summary>
		/// <returns>Имя динамического модуля.</returns>
		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x060051D0 RID: 20944 RVA: 0x00100244 File Offset: 0x000FE444
		public override string ScopeName
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Возвращает универсальный уникальный идентификатор (UUID), по которому можно различить две версии модуля.</summary>
		/// <returns>Значение свойства <see cref="T:System.Guid" />, по которому можно различить две версии модуля.</returns>
		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x060051D1 RID: 20945 RVA: 0x000EF158 File Offset: 0x000ED358
		public override Guid ModuleVersionId
		{
			get
			{
				return this.GetModuleVersionId();
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли объект ресурсом.</summary>
		/// <returns>Значение <see langword="true" />, если объект является ресурсом; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x060051D2 RID: 20946 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public override bool IsResource()
		{
			return false;
		}

		/// <summary>Возвращает метод уровня модуля, соответствующий заданным критериям.</summary>
		/// <param name="name">Имя метода.</param>
		/// <param name="bindingAttr">Комбинация двоичных флагов привязки <see langword="BindingFlags" />, используемых для управления поиском.</param>
		/// <param name="binder">Объект, реализующий <see langword="Binder" />, содержащий свойства, связанные с этим методом.</param>
		/// <param name="callConvention">Соглашение о вызовах для метода.</param>
		/// <param name="types">Типы параметров метода.</param>
		/// <param name="modifiers">Массив модификаторов параметров, используемый для работы привязки с подписями параметров, в которых были изменены типы.</param>
		/// <returns>Метод, определяемый на уровне модуля, соответствующий заданным критериям; значение <see langword="null" />, если такого метода не существует.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="name" /> равно <see langword="null" />, значение параметра <paramref name="types" /> равно <see langword="null" />, или элемент параметра <paramref name="types" /> равен значению <see langword="null" />.</exception>
		// Token: 0x060051D3 RID: 20947 RVA: 0x0010024C File Offset: 0x000FE44C
		protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			if (this.global_type_created == null)
			{
				return null;
			}
			if (types == null)
			{
				return this.global_type_created.GetMethod(name);
			}
			return this.global_type_created.GetMethod(name, bindingAttr, binder, callConvention, types, modifiers);
		}

		/// <summary>Возвращает поле, определенное заданным токеном метаданных, в контексте, определенном заданными параметрами универсального типа.</summary>
		/// <param name="metadataToken">токен метаданных, определяющий поле в модуле.</param>
		/// <param name="genericTypeArguments">Массив объектов <see cref="T:System.Type" />, представляющих аргументы типа для данного типа, если токен находится в области, либо значение <see langword="null" />, если этот тип не является универсальным.</param>
		/// <param name="genericMethodArguments">Массив объектов <see cref="T:System.Type" />, представляющих аргументы типа для метода, если токен находится в области, либо значение <see langword="null" />, если этот метод не является универсальным.</param>
		/// <returns>Объект <see cref="T:System.Reflection.FieldInfo" />, представляющий поле, которое определяется заданным токеном метаданных.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="metadataToken" /> не является маркером для поля в области текущего модуля.  
		///
		/// или - 
		/// Параметр <paramref name="metadataToken" /> определяет поле, родительская спецификация <see langword="TypeSpec" /> которого имеет подпись, содержащую сведения о типе элемента <see langword="var" /> (параметр типа для универсального типа) или <see langword="mvar" /> (параметр типа для универсального метода), а для метода <paramref name="genericTypeArguments" /> или <paramref name="genericMethodArguments" /> не предоставлены необходимые аргументы типа.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="metadataToken" /> не является допустимым маркером для поля в области текущего модуля.</exception>
		// Token: 0x060051D4 RID: 20948 RVA: 0x00100283 File Offset: 0x000FE483
		public override FieldInfo ResolveField(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
		{
			return RuntimeModule.ResolveField(this, this._impl, metadataToken, genericTypeArguments, genericMethodArguments);
		}

		/// <summary>Возвращает тип или член, которые определены заданным токеном метаданных, в контексте, определенном заданными параметрами универсального типа.</summary>
		/// <param name="metadataToken">токен метаданных, определяющий тип или член в модуле.</param>
		/// <param name="genericTypeArguments">Массив объектов <see cref="T:System.Type" />, представляющих аргументы типа для данного типа, если токен находится в области, либо значение <see langword="null" />, если этот тип не является универсальным.</param>
		/// <param name="genericMethodArguments">Массив объектов <see cref="T:System.Type" />, представляющих аргументы типа для метода, если токен находится в области, либо значение <see langword="null" />, если этот метод не является универсальным.</param>
		/// <returns>Объект <see cref="T:System.Reflection.MemberInfo" />, представляющий тип члена, который определяется заданным токеном метаданных.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="metadataToken" /> не является маркером для типа или члена в области текущего модуля.  
		///
		/// или - 
		/// Параметр <paramref name="metadataToken" /> является объектом <see langword="MethodSpec" /> или <see langword="TypeSpec" />, подпись которого содержит сведения о типе элемента <see langword="var" /> (параметр типа для универсального типа) или <see langword="mvar" /> (параметр типа для универсального метода), а для метода <paramref name="genericTypeArguments" /> или <paramref name="genericMethodArguments" /> не предоставлены необходимые аргументы типа.  
		///
		/// или - 
		/// Параметр <paramref name="metadataToken" /> определяет свойство или событие.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="metadataToken" /> не является допустимым маркером для поля в области текущего модуля.</exception>
		// Token: 0x060051D5 RID: 20949 RVA: 0x00100294 File Offset: 0x000FE494
		public override MemberInfo ResolveMember(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
		{
			return RuntimeModule.ResolveMember(this, this._impl, metadataToken, genericTypeArguments, genericMethodArguments);
		}

		// Token: 0x060051D6 RID: 20950 RVA: 0x001002A8 File Offset: 0x000FE4A8
		internal MemberInfo ResolveOrGetRegisteredToken(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
		{
			ResolveTokenError error;
			MemberInfo memberInfo = RuntimeModule.ResolveMemberToken(this._impl, metadataToken, RuntimeModule.ptrs_from_types(genericTypeArguments), RuntimeModule.ptrs_from_types(genericMethodArguments), out error);
			if (memberInfo != null)
			{
				return memberInfo;
			}
			memberInfo = (this.GetRegisteredToken(metadataToken) as MemberInfo);
			if (memberInfo == null)
			{
				throw RuntimeModule.resolve_token_exception(this.Name, metadataToken, error, "MemberInfo");
			}
			return memberInfo;
		}

		/// <summary>Возвращает метод или конструктор, определенный заданным маркером метаданных, в контексте, определенном заданными параметрами универсального типа.</summary>
		/// <param name="metadataToken">маркер метаданных, определяющий метод или конструктор в модуле.</param>
		/// <param name="genericTypeArguments">Массив объектов <see cref="T:System.Type" />, представляющих аргументы типа для данного типа, если токен находится в области, либо значение <see langword="null" />, если этот тип не является универсальным.</param>
		/// <param name="genericMethodArguments">Массив объектов <see cref="T:System.Type" />, представляющих аргументы типа для метода, если токен находится в области, либо значение <see langword="null" />, если этот метод не является универсальным.</param>
		/// <returns>Объект <see cref="T:System.Reflection.MethodBase" />, представляющий метод, определенный заданным токеном метаданных.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="metadataToken" /> не является маркером для метода или конструктора в области текущего модуля.  
		///
		/// или - 
		/// Параметр <paramref name="metadataToken" /> является объектом <see langword="MethodSpec" />, сигнатура которого содержит сведения о типе элемента <see langword="var" /> (параметр типа для универсального типа) или <see langword="mvar" /> (параметр типа для универсального метода), а для <paramref name="genericTypeArguments" />, <paramref name="genericMethodArguments" /> или обоих параметров не предоставлены необходимые аргументы типа.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="metadataToken" /> не является допустимым маркером для поля в области текущего модуля.</exception>
		// Token: 0x060051D7 RID: 20951 RVA: 0x00100305 File Offset: 0x000FE505
		public override MethodBase ResolveMethod(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
		{
			return RuntimeModule.ResolveMethod(this, this._impl, metadataToken, genericTypeArguments, genericMethodArguments);
		}

		/// <summary>Возвращает строку, определенную заданным маркером метаданных.</summary>
		/// <param name="metadataToken">маркер метаданных, определяющий строку в куче строк модуля.</param>
		/// <returns>Объект <see cref="T:System.String" />, содержащий строковое значение из кучи строк метаданных.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="metadataToken" /> не является маркером для строки в области текущего модуля.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="metadataToken" /> не является допустимым маркером для поля в области текущего модуля.</exception>
		// Token: 0x060051D8 RID: 20952 RVA: 0x00100316 File Offset: 0x000FE516
		public override string ResolveString(int metadataToken)
		{
			return RuntimeModule.ResolveString(this, this._impl, metadataToken);
		}

		/// <summary>Возвращает большой двоичный объект подписи, определенный токеном метаданных.</summary>
		/// <param name="metadataToken">токен метаданных, определяющий подпись в модуле.</param>
		/// <returns>Массив байтов, представляющий большой двоичный объект подписи.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="metadataToken" /> не является допустимым объектом <see langword="MemberRef" />, <see langword="MethodDef" />, <see langword="TypeSpec" />, сигнатурой или маркером <see langword="FieldDef" /> в области видимости текущего модуля.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="metadataToken" /> не является допустимым маркером для поля в области текущего модуля.</exception>
		// Token: 0x060051D9 RID: 20953 RVA: 0x00100325 File Offset: 0x000FE525
		public override byte[] ResolveSignature(int metadataToken)
		{
			return RuntimeModule.ResolveSignature(this, this._impl, metadataToken);
		}

		/// <summary>Возвращает тип, определенный заданным токеном метаданных, в контексте, определенном заданными параметрами универсального типа.</summary>
		/// <param name="metadataToken">Маркер метаданных, который определяет тип в модуле.</param>
		/// <param name="genericTypeArguments">Массив объектов <see cref="T:System.Type" />, представляющих аргументы типа для данного типа, если токен находится в области, либо значение <see langword="null" />, если этот тип не является универсальным.</param>
		/// <param name="genericMethodArguments">Массив объектов <see cref="T:System.Type" />, представляющих аргументы типа для метода, если токен находится в области, либо значение <see langword="null" />, если этот метод не является универсальным.</param>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий тип, который определяется заданным токеном метаданных.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="metadataToken" /> не является маркером для типа в области текущего модуля.  
		///
		/// или - 
		/// Параметр <paramref name="metadataToken" /> является объектом <see langword="TypeSpec" />, сигнатура которого содержит сведения о типе элемента <see langword="var" /> (параметр типа для универсального типа) или <see langword="mvar" /> (параметр типа для универсального метода), а для <paramref name="genericTypeArguments" />, <paramref name="genericMethodArguments" /> или обоих параметров не предоставлены необходимые аргументы типа.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="metadataToken" /> не является допустимым маркером для поля в области текущего модуля.</exception>
		// Token: 0x060051DA RID: 20954 RVA: 0x00100334 File Offset: 0x000FE534
		public override Type ResolveType(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
		{
			return RuntimeModule.ResolveType(this, this._impl, metadataToken, genericTypeArguments, genericMethodArguments);
		}

		/// <summary>Возвращает значение, указывающее, равен ли данный экземпляр указанному объекту.</summary>
		/// <param name="obj">Объект, сравниваемый с этим экземпляром, или значение <see langword="null" />.</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="obj" /> равно типу и значению данного экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060051DB RID: 20955 RVA: 0x00100345 File Offset: 0x000FE545
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x060051DC RID: 20956 RVA: 0x0010034E File Offset: 0x000FE54E
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Возвращает значение, обозначающее, применен ли к этому модулю указанный тип атрибутов.</summary>
		/// <param name="attributeType">Тип настраиваемого атрибута для проверки.</param>
		/// <param name="inherit">Данный аргумент не учитывается для объектов этого типа.</param>
		/// <returns>Значение <see langword="true" />, если к этому модулю применен один или несколько экземпляров <paramref name="attributeType" />, в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="attributeType" /> не является объектом <see cref="T:System.Type" />, предоставляемым средой выполнения. Например, <paramref name="attributeType" /> является объектом <see cref="T:System.Reflection.Emit.TypeBuilder" />.</exception>
		// Token: 0x060051DD RID: 20957 RVA: 0x00100356 File Offset: 0x000FE556
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return base.IsDefined(attributeType, inherit);
		}

		/// <summary>Возвращает все настраиваемые атрибуты, которые были применены к текущему <see cref="T:System.Reflection.Emit.ModuleBuilder" />.</summary>
		/// <param name="inherit">Данный аргумент не учитывается для объектов этого типа.</param>
		/// <returns>Массив, содержащий настраиваемые атрибуты; массив является пустым, если атрибуты отсутствуют.</returns>
		// Token: 0x060051DE RID: 20958 RVA: 0x00100360 File Offset: 0x000FE560
		public override object[] GetCustomAttributes(bool inherit)
		{
			return this.GetCustomAttributes(null, inherit);
		}

		/// <summary>Возвращает настраиваемые атрибуты, примененные к текущему <see cref="T:System.Reflection.Emit.ModuleBuilder" />, которые являются производными от указанного типа атрибута.</summary>
		/// <param name="attributeType">Базовый тип, от которого наследуют атрибуты.</param>
		/// <param name="inherit">Данный аргумент не учитывается для объектов этого типа.</param>
		/// <returns>Массив, содержащий настраиваемые атрибуты, происходящие (на любом уровне) от <paramref name="attributeType" />; если массив пуст, таких атрибутов нет.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="attributeType" /> не является объектом <see cref="T:System.Type" />, предоставляемым средой выполнения. Например, <paramref name="attributeType" /> является объектом <see cref="T:System.Reflection.Emit.TypeBuilder" />.</exception>
		// Token: 0x060051DF RID: 20959 RVA: 0x0010036C File Offset: 0x000FE56C
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			if (this.cattrs == null || this.cattrs.Length == 0)
			{
				return Array.Empty<object>();
			}
			if (attributeType is TypeBuilder)
			{
				throw new InvalidOperationException("First argument to GetCustomAttributes can't be a TypeBuilder");
			}
			List<object> list = new List<object>();
			for (int i = 0; i < this.cattrs.Length; i++)
			{
				Type type = this.cattrs[i].Ctor.GetType();
				if (type is TypeBuilder)
				{
					throw new InvalidOperationException("Can't construct custom attribute for TypeBuilder type");
				}
				if (attributeType == null || attributeType.IsAssignableFrom(type))
				{
					list.Add(this.cattrs[i].Invoke());
				}
			}
			return list.ToArray();
		}

		/// <summary>Возвращает поле уровня модуля, определенное в области .sdata переносимого исполняемого файла (PE) с данными именем и атрибутами привязки.</summary>
		/// <param name="name">Имя поля.</param>
		/// <param name="bindingAttr">Комбинация двоичных флагов привязки <see langword="BindingFlags" />, используемых для управления поиском.</param>
		/// <returns>Поле, имеющее заданное имя и атрибуты привязки, либо значение <see langword="null" />, если поле не существует.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060051E0 RID: 20960 RVA: 0x0010040D File Offset: 0x000FE60D
		public override FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			if (this.global_type_created == null)
			{
				throw new InvalidOperationException("Module-level fields cannot be retrieved until after the CreateGlobalFunctions method has been called for the module.");
			}
			return this.global_type_created.GetField(name, bindingAttr);
		}

		/// <summary>Возвращает все поля, определенные в области .sdata переносимого исполняемого файла (PE), соответствующие заданным флагам привязки.</summary>
		/// <param name="bindingFlags">Комбинация двоичных флагов привязки <see langword="BindingFlags" />, используемых для управления поиском.</param>
		/// <returns>Массив полей, соответствующих заданным флагам; если таких полей нет, массив пуст.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060051E1 RID: 20961 RVA: 0x00100435 File Offset: 0x000FE635
		public override FieldInfo[] GetFields(BindingFlags bindingFlags)
		{
			if (this.global_type_created == null)
			{
				throw new InvalidOperationException("Module-level fields cannot be retrieved until after the CreateGlobalFunctions method has been called for the module.");
			}
			return this.global_type_created.GetFields(bindingFlags);
		}

		/// <summary>Возвращает все методы, которые определены на уровне модуля для текущего объекта <see cref="T:System.Reflection.Emit.ModuleBuilder" /> и соответствуют указанным флагам привязки.</summary>
		/// <param name="bindingFlags">Комбинация двоичных флагов привязки <see langword="BindingFlags" />, используемых для управления поиском.</param>
		/// <returns>Массив, который содержит все методы уровня модуля, соответствующие <paramref name="bindingFlags" />.</returns>
		// Token: 0x060051E2 RID: 20962 RVA: 0x0010045C File Offset: 0x000FE65C
		public override MethodInfo[] GetMethods(BindingFlags bindingFlags)
		{
			if (this.global_type_created == null)
			{
				throw new InvalidOperationException("Module-level methods cannot be retrieved until after the CreateGlobalFunctions method has been called for the module.");
			}
			return this.global_type_created.GetMethods(bindingFlags);
		}

		/// <summary>Получает токен, который определяет текущий динамический модуль в метаданных.</summary>
		/// <returns>Целочисленный токен, который идентифицирует текущий модуль в метаданных.</returns>
		// Token: 0x17000D83 RID: 3459
		// (get) Token: 0x060051E3 RID: 20963 RVA: 0x000F4CD7 File Offset: 0x000F2ED7
		public override int MetadataToken
		{
			get
			{
				return RuntimeModule.get_MetadataToken(this);
			}
		}

		// Token: 0x060051E5 RID: 20965 RVA: 0x000173AD File Offset: 0x000155AD
		internal ModuleBuilder()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x040031DA RID: 12762
		internal IntPtr _impl;

		// Token: 0x040031DB RID: 12763
		internal Assembly assembly;

		// Token: 0x040031DC RID: 12764
		internal string fqname;

		// Token: 0x040031DD RID: 12765
		internal string name;

		// Token: 0x040031DE RID: 12766
		internal string scopename;

		// Token: 0x040031DF RID: 12767
		internal bool is_resource;

		// Token: 0x040031E0 RID: 12768
		internal int token;

		// Token: 0x040031E1 RID: 12769
		private UIntPtr dynamic_image;

		// Token: 0x040031E2 RID: 12770
		private int num_types;

		// Token: 0x040031E3 RID: 12771
		private TypeBuilder[] types;

		// Token: 0x040031E4 RID: 12772
		private CustomAttributeBuilder[] cattrs;

		// Token: 0x040031E5 RID: 12773
		private byte[] guid;

		// Token: 0x040031E6 RID: 12774
		private int table_idx;

		// Token: 0x040031E7 RID: 12775
		internal AssemblyBuilder assemblyb;

		// Token: 0x040031E8 RID: 12776
		private MethodBuilder[] global_methods;

		// Token: 0x040031E9 RID: 12777
		private FieldBuilder[] global_fields;

		// Token: 0x040031EA RID: 12778
		private bool is_main;

		// Token: 0x040031EB RID: 12779
		private MonoResource[] resources;

		// Token: 0x040031EC RID: 12780
		private IntPtr unparented_classes;

		// Token: 0x040031ED RID: 12781
		private int[] table_indexes;

		// Token: 0x040031EE RID: 12782
		private TypeBuilder global_type;

		// Token: 0x040031EF RID: 12783
		private Type global_type_created;

		// Token: 0x040031F0 RID: 12784
		private Dictionary<TypeName, TypeBuilder> name_cache;

		// Token: 0x040031F1 RID: 12785
		private Dictionary<string, int> us_string_cache;

		// Token: 0x040031F2 RID: 12786
		private bool transient;

		// Token: 0x040031F3 RID: 12787
		private ModuleBuilderTokenGenerator token_gen;

		// Token: 0x040031F4 RID: 12788
		private Hashtable resource_writers;

		// Token: 0x040031F5 RID: 12789
		private ISymbolWriter symbolWriter;

		// Token: 0x040031F6 RID: 12790
		private static bool has_warned_about_symbolWriter;

		// Token: 0x040031F7 RID: 12791
		private static int typeref_tokengen = 33554431;

		// Token: 0x040031F8 RID: 12792
		private static int typedef_tokengen = 50331647;

		// Token: 0x040031F9 RID: 12793
		private static int typespec_tokengen = 469762047;

		// Token: 0x040031FA RID: 12794
		private static int memberref_tokengen = 184549375;

		// Token: 0x040031FB RID: 12795
		private static int methoddef_tokengen = 117440511;

		// Token: 0x040031FC RID: 12796
		private Dictionary<MemberInfo, int> inst_tokens;

		// Token: 0x040031FD RID: 12797
		private Dictionary<MemberInfo, int> inst_tokens_open;
	}
}
