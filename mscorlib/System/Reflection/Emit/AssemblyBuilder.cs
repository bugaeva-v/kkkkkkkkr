using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using System.Threading;
using Mono.Security;
using Unity;

namespace System.Reflection.Emit
{
	/// <summary>Определяет и представляет динамическую сборку.</summary>
	// Token: 0x02000913 RID: 2323
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComDefaultInterface(typeof(_AssemblyBuilder))]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class AssemblyBuilder : Assembly, _AssemblyBuilder
	{
		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Переданный массив имен, которые необходимо сопоставить.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, зарезервированный вызывающим объектом, куда помещаются идентификаторы, соответствующие именам.</param>
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x06004E99 RID: 20121 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _AssemblyBuilder.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает сведения о типе объекта, которые затем могут использоваться для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Получает указатель на объект с запрошенными сведениями о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x06004E9A RID: 20122 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _AssemblyBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Указатель, по которому записывается число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x06004E9B RID: 20123 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _AssemblyBuilder.GetTypeInfoCount(out uint pcTInfo)
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
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x06004E9C RID: 20124 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _AssemblyBuilder.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06004E9D RID: 20125
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void basic_init(AssemblyBuilder ab);

		// Token: 0x06004E9E RID: 20126
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void UpdateNativeCustomAttributes(AssemblyBuilder ab);

		// Token: 0x06004E9F RID: 20127 RVA: 0x000F6850 File Offset: 0x000F4A50
		[PreserveDependency("RuntimeResolve", "System.Reflection.Emit.ModuleBuilder")]
		internal AssemblyBuilder(AssemblyName n, string directory, AssemblyBuilderAccess access, bool corlib_internal)
		{
			this.pekind = PEFileKinds.Dll;
			this.corlib_object_type = typeof(object);
			this.corlib_value_type = typeof(ValueType);
			this.corlib_enum_type = typeof(Enum);
			this.corlib_void_type = typeof(void);
			base..ctor();
			if ((access & (AssemblyBuilderAccess)2048) != (AssemblyBuilderAccess)0)
			{
				throw new NotImplementedException("COMPILER_ACCESS is no longer supperted, use a newer mcs.");
			}
			if (!Enum.IsDefined(typeof(AssemblyBuilderAccess), access))
			{
				throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "Argument value {0} is not valid.", (int)access), "access");
			}
			this.name = n.Name;
			this.access = (uint)access;
			this.flags = (uint)n.Flags;
			if (this.IsSave && (directory == null || directory.Length == 0))
			{
				this.dir = Directory.GetCurrentDirectory();
			}
			else
			{
				this.dir = directory;
			}
			if (n.CultureInfo != null)
			{
				this.culture = n.CultureInfo.Name;
				this.versioninfo_culture = n.CultureInfo.Name;
			}
			Version version = n.Version;
			if (version != null)
			{
				this.version = version.ToString();
			}
			if (n.KeyPair != null)
			{
				this.sn = n.KeyPair.StrongName();
			}
			else
			{
				byte[] publicKey = n.GetPublicKey();
				if (publicKey != null && publicKey.Length != 0)
				{
					this.sn = new Mono.Security.StrongName(publicKey);
				}
			}
			if (this.sn != null)
			{
				this.flags |= 1U;
			}
			this.corlib_internal = corlib_internal;
			if (this.sn != null)
			{
				this.pktoken = new byte[this.sn.PublicKeyToken.Length * 2];
				int num = 0;
				foreach (byte b in this.sn.PublicKeyToken)
				{
					string text = b.ToString("x2");
					this.pktoken[num++] = (byte)text[0];
					this.pktoken[num++] = (byte)text[1];
				}
			}
			AssemblyBuilder.basic_init(this);
		}

		/// <summary>Получает первоначально заданное расположение сборки (например, в объекте <see cref="T:System.Reflection.AssemblyName" />).</summary>
		/// <returns>Первоначально заданное расположение сборки.</returns>
		/// <exception cref="T:System.NotSupportedException">В настоящее время этот метод не поддерживается.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x06004EA0 RID: 20128 RVA: 0x000F6A5A File Offset: 0x000F4C5A
		public override string CodeBase
		{
			get
			{
				throw this.not_supported();
			}
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x06004EA1 RID: 20129 RVA: 0x000F3478 File Offset: 0x000F1678
		public override string EscapedCodeBase
		{
			get
			{
				return RuntimeAssembly.GetCodeBase(this, true);
			}
		}

		/// <summary>Возвращает точку входа для этой сборки.</summary>
		/// <returns>Точка входа для этой сборки.</returns>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x06004EA2 RID: 20130 RVA: 0x000F6A62 File Offset: 0x000F4C62
		public override MethodInfo EntryPoint
		{
			get
			{
				return this.entry_point;
			}
		}

		/// <summary>Возвращает расположение (в формате базы кода) загруженного файла, содержащего манифест, если он не является теневой копией.</summary>
		/// <returns>Местоположение загруженного файла, содержащего манифест. Если для загруженного файла была создана теневая копия, <see langword="Location" /> является расположением файла до теневого копирования.</returns>
		/// <exception cref="T:System.NotSupportedException">В настоящее время этот метод не поддерживается.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x06004EA3 RID: 20131 RVA: 0x000F6A5A File Offset: 0x000F4C5A
		public override string Location
		{
			get
			{
				throw this.not_supported();
			}
		}

		/// <summary>Возвращает версию среды CLR, которая будет сохранена в файле, содержащем манифест.</summary>
		/// <returns>Строка, представляющая версию среды CLR.</returns>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x06004EA4 RID: 20132 RVA: 0x000F3489 File Offset: 0x000F1689
		public override string ImageRuntimeVersion
		{
			get
			{
				return RuntimeAssembly.InternalImageRuntimeVersion(this);
			}
		}

		/// <summary>Получает значение, которое указывает, находится ли эта динамическая сборка в контексте только отражения.</summary>
		/// <returns>Значение <see langword="true" />, если динамическая сборка находится в контексте только отражения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x06004EA5 RID: 20133 RVA: 0x000F6A6A File Offset: 0x000F4C6A
		public override bool ReflectionOnly
		{
			get
			{
				return this.access == 6U;
			}
		}

		/// <summary>Добавляет существующий файл ресурсов в эту сборку.</summary>
		/// <param name="name">Логическое имя ресурса.</param>
		/// <param name="fileName">Имя физического файла (RESOURCES-файл), с которым сопоставляется логическое имя. Оно не должно включать путь; файл должен быть в том же каталоге, что и сборка, в которую он добавляется.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="name" /> было определено ранее.  
		///
		/// или - 
		/// В сборке уже имеется другой файл с именем <paramref name="fileName" />.  
		///
		/// или - 
		/// Длина параметра <paramref name="name" /> равна нулю.  
		///
		/// или - 
		/// Длина параметра <paramref name="fileName" /> равна нулю, или <paramref name="fileName" /> включает в себя путь.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> или <paramref name="fileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл <paramref name="fileName" /> не найден.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06004EA6 RID: 20134 RVA: 0x000F6A75 File Offset: 0x000F4C75
		public void AddResourceFile(string name, string fileName)
		{
			this.AddResourceFile(name, fileName, ResourceAttributes.Public);
		}

		/// <summary>Добавляет существующий файл ресурсов в эту сборку.</summary>
		/// <param name="name">Логическое имя ресурса.</param>
		/// <param name="fileName">Имя физического файла (RESOURCES-файл), с которым сопоставляется логическое имя. Оно не должно включать путь; файл должен быть в том же каталоге, что и сборка, в которую он добавляется.</param>
		/// <param name="attribute">Атрибуты ресурса.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="name" /> было определено ранее.  
		///
		/// или - 
		/// В сборке уже имеется другой файл с именем <paramref name="fileName" />.  
		///
		/// или - 
		/// Длина <paramref name="name" /> равна нулю, или если длина <paramref name="fileName" /> равна нулю.  
		///
		/// или - 
		/// <paramref name="fileName" /> содержит путь.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> или <paramref name="fileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Если файл <paramref name="fileName" /> не найден.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06004EA7 RID: 20135 RVA: 0x000F6A80 File Offset: 0x000F4C80
		public void AddResourceFile(string name, string fileName, ResourceAttributes attribute)
		{
			this.AddResourceFile(name, fileName, attribute, true);
		}

		// Token: 0x06004EA8 RID: 20136 RVA: 0x000F6A8C File Offset: 0x000F4C8C
		private void AddResourceFile(string name, string fileName, ResourceAttributes attribute, bool fileNeedsToExists)
		{
			this.check_name_and_filename(name, fileName, fileNeedsToExists);
			if (this.dir != null)
			{
				fileName = Path.Combine(this.dir, fileName);
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
			this.resources[num].filename = fileName;
			this.resources[num].attrs = attribute;
		}

		// Token: 0x06004EA9 RID: 20137 RVA: 0x000F6B3C File Offset: 0x000F4D3C
		internal void AddPermissionRequests(PermissionSet required, PermissionSet optional, PermissionSet refused)
		{
			if (this.created)
			{
				throw new InvalidOperationException("Assembly was already saved.");
			}
			this._minimum = required;
			this._optional = optional;
			this._refuse = refused;
			if (required != null)
			{
				this.permissions_minimum = new RefEmitPermissionSet[1];
				this.permissions_minimum[0] = new RefEmitPermissionSet(SecurityAction.RequestMinimum, required.ToXml().ToString());
			}
			if (optional != null)
			{
				this.permissions_optional = new RefEmitPermissionSet[1];
				this.permissions_optional[0] = new RefEmitPermissionSet(SecurityAction.RequestOptional, optional.ToXml().ToString());
			}
			if (refused != null)
			{
				this.permissions_refused = new RefEmitPermissionSet[1];
				this.permissions_refused[0] = new RefEmitPermissionSet(SecurityAction.RequestRefuse, refused.ToXml().ToString());
			}
		}

		// Token: 0x06004EAA RID: 20138 RVA: 0x000F6BF7 File Offset: 0x000F4DF7
		internal void EmbedResourceFile(string name, string fileName)
		{
			this.EmbedResourceFile(name, fileName, ResourceAttributes.Public);
		}

		// Token: 0x06004EAB RID: 20139 RVA: 0x000F6C04 File Offset: 0x000F4E04
		private void EmbedResourceFile(string name, string fileName, ResourceAttributes attribute)
		{
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
			try
			{
				FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
				long length = fileStream.Length;
				this.resources[num].data = new byte[length];
				fileStream.Read(this.resources[num].data, 0, (int)length);
				fileStream.Close();
			}
			catch
			{
			}
		}

		/// <summary>Определяет динамическую сборку, которая имеет указанные имя и права доступа.</summary>
		/// <param name="name">Имя сборки.</param>
		/// <param name="access">Права доступа сборки.</param>
		/// <returns>Объект, представляющий новую сборку.</returns>
		// Token: 0x06004EAC RID: 20140 RVA: 0x000F6CE0 File Offset: 0x000F4EE0
		public static AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			return new AssemblyBuilder(name, null, access, false);
		}

		/// <summary>Определяет новую сборку, которая имеет указанные имя, права доступа и атрибуты.</summary>
		/// <param name="name">Имя сборки.</param>
		/// <param name="access">Права доступа сборки.</param>
		/// <param name="assemblyAttributes">Коллекция, содержащая атрибуты сборки.</param>
		/// <returns>Объект, представляющий новую сборку.</returns>
		// Token: 0x06004EAD RID: 20141 RVA: 0x000F6CFC File Offset: 0x000F4EFC
		public static AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, IEnumerable<CustomAttributeBuilder> assemblyAttributes)
		{
			AssemblyBuilder assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(name, access);
			foreach (CustomAttributeBuilder customAttribute in assemblyAttributes)
			{
				assemblyBuilder.SetCustomAttribute(customAttribute);
			}
			return assemblyBuilder;
		}

		/// <summary>Определяет именованный временный динамический модуль в этой сборке.</summary>
		/// <param name="name">Имя динамического модуля.</param>
		/// <returns>Объект <see cref="T:System.Reflection.Emit.ModuleBuilder" />, представляющий определенный динамический модуль.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="name" /> начинается с пробела.  
		///
		/// или - 
		/// Длина параметра <paramref name="name" /> равна нулю.  
		///
		/// или - 
		/// Длина <paramref name="name" /> превышает максимальную длину, определенную в системе.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ExecutionEngineException">Не удается загрузить сборку для модуля записи символов по умолчанию.  
		///
		/// или - 
		/// Не удается найти тип, реализующий интерфейс модуля записи символов по умолчанию.</exception>
		// Token: 0x06004EAE RID: 20142 RVA: 0x000F6D50 File Offset: 0x000F4F50
		public ModuleBuilder DefineDynamicModule(string name)
		{
			return this.DefineDynamicModule(name, name, false, true);
		}

		/// <summary>Определяет именованный несохраняемый динамический модуль в данной сборке и указывает, должна ли выдаваться символьная информация.</summary>
		/// <param name="name">Имя динамического модуля.</param>
		/// <param name="emitSymbolInfo">
		///   <see langword="true" />, если символьная информация должна выдаваться; в противном случае — <see langword="false" />.</param>
		/// <returns>Объект <see cref="T:System.Reflection.Emit.ModuleBuilder" />, представляющий определенный динамический модуль.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="name" /> начинается с пробела.  
		///
		/// или - 
		/// Длина параметра <paramref name="name" /> равна нулю.  
		///
		/// или - 
		/// Длина <paramref name="name" /> превышает максимальную длину, определенную в системе.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ExecutionEngineException">Не удается загрузить сборку для модуля записи символов по умолчанию.  
		///
		/// или - 
		/// Не удается найти тип, реализующий интерфейс модуля записи символов по умолчанию.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06004EAF RID: 20143 RVA: 0x000F6D5C File Offset: 0x000F4F5C
		public ModuleBuilder DefineDynamicModule(string name, bool emitSymbolInfo)
		{
			return this.DefineDynamicModule(name, name, emitSymbolInfo, true);
		}

		/// <summary>Определяет сохраняемый динамический модуль с заданным именем, который будет сохранен в указанном файле. Данные символов не созданы.</summary>
		/// <param name="name">Имя динамического модуля.</param>
		/// <param name="fileName">Имя файла, в котором должен сохраняться динамический модуль.</param>
		/// <returns>Объект <see cref="T:System.Reflection.Emit.ModuleBuilder" />, представляющий определенный динамический модуль.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> или <paramref name="fileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Длина параметра <paramref name="name" /> или <paramref name="fileName" /> равна нулю.  
		///
		/// или - 
		/// Длина <paramref name="name" /> превышает максимальную длину, определенную в системе.  
		///
		/// или - 
		/// <paramref name="fileName" /> содержит спецификацию пути (например, компонент каталога).  
		///
		/// или - 
		/// Имеется конфликт с именем другого файла, который принадлежит этой сборке.</exception>
		/// <exception cref="T:System.InvalidOperationException">Эта сборка была ранее сохранена.</exception>
		/// <exception cref="T:System.NotSupportedException">Сборка была вызвана в динамической сборке с атрибутом <see cref="F:System.Reflection.Emit.AssemblyBuilderAccess.Run" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ExecutionEngineException">Не удается загрузить сборку для модуля записи символов по умолчанию.  
		///
		/// или - 
		/// Не удается найти тип, реализующий интерфейс модуля записи символов по умолчанию.</exception>
		// Token: 0x06004EB0 RID: 20144 RVA: 0x000F6D68 File Offset: 0x000F4F68
		public ModuleBuilder DefineDynamicModule(string name, string fileName)
		{
			return this.DefineDynamicModule(name, fileName, false, false);
		}

		/// <summary>Определяет сохраняемый динамический модуль с указанием имени модуля, имени файла, в котором модуль будет сохранен, и необходимости создания символьной информации с помощью модуля записи символов по умолчанию.</summary>
		/// <param name="name">Имя динамического модуля.</param>
		/// <param name="fileName">Имя файла, в котором должен сохраняться динамический модуль.</param>
		/// <param name="emitSymbolInfo">Если это <see langword="true" />, символьная информация записывается с помощью модуля записи символов по умолчанию.</param>
		/// <returns>Объект <see cref="T:System.Reflection.Emit.ModuleBuilder" />, представляющий определенный динамический модуль.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> или <paramref name="fileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Длина параметра <paramref name="name" /> или <paramref name="fileName" /> равна нулю.  
		///
		/// или - 
		/// Длина <paramref name="name" /> превышает максимальную длину, определенную в системе.  
		///
		/// или - 
		/// <paramref name="fileName" /> содержит спецификацию пути (например, компонент каталога).  
		///
		/// или - 
		/// Имеется конфликт с именем другого файла, который принадлежит этой сборке.</exception>
		/// <exception cref="T:System.InvalidOperationException">Эта сборка была ранее сохранена.</exception>
		/// <exception cref="T:System.NotSupportedException">Сборка была вызвана для динамической сборки с атрибутом <see cref="F:System.Reflection.Emit.AssemblyBuilderAccess.Run" />.</exception>
		/// <exception cref="T:System.ExecutionEngineException">Не удается загрузить сборку для модуля записи символов по умолчанию.  
		///
		/// или - 
		/// Не удается найти тип, реализующий интерфейс модуля записи символов по умолчанию.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06004EB1 RID: 20145 RVA: 0x000F6D74 File Offset: 0x000F4F74
		public ModuleBuilder DefineDynamicModule(string name, string fileName, bool emitSymbolInfo)
		{
			return this.DefineDynamicModule(name, fileName, emitSymbolInfo, false);
		}

		// Token: 0x06004EB2 RID: 20146 RVA: 0x000F6D80 File Offset: 0x000F4F80
		private ModuleBuilder DefineDynamicModule(string name, string fileName, bool emitSymbolInfo, bool transient)
		{
			this.check_name_and_filename(name, fileName, false);
			if (!transient)
			{
				if (Path.GetExtension(fileName) == string.Empty)
				{
					throw new ArgumentException("Module file name '" + fileName + "' must have file extension.");
				}
				if (!this.IsSave)
				{
					throw new NotSupportedException("Persistable modules are not supported in a dynamic assembly created with AssemblyBuilderAccess.Run");
				}
				if (this.created)
				{
					throw new InvalidOperationException("Assembly was already saved.");
				}
			}
			ModuleBuilder moduleBuilder = new ModuleBuilder(this, name, fileName, emitSymbolInfo, transient);
			if (this.modules != null && this.is_module_only)
			{
				throw new InvalidOperationException("A module-only assembly can only contain one module.");
			}
			if (this.modules != null)
			{
				ModuleBuilder[] destinationArray = new ModuleBuilder[this.modules.Length + 1];
				Array.Copy(this.modules, destinationArray, this.modules.Length);
				this.modules = destinationArray;
			}
			else
			{
				this.modules = new ModuleBuilder[1];
			}
			this.modules[this.modules.Length - 1] = moduleBuilder;
			return moduleBuilder;
		}

		/// <summary>Определяет автономный управляемый ресурс для данной сборки с атрибутом открытого ресурса по умолчанию.</summary>
		/// <param name="name">Логическое имя ресурса.</param>
		/// <param name="description">Текстовое описание ресурса.</param>
		/// <param name="fileName">Имя физического файла (RESOURCES-файл), с которым сопоставляется логическое имя. Оно не должно содержать путь.</param>
		/// <returns>Объект <see cref="T:System.Resources.ResourceWriter" /> для указанного ресурса.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="name" /> было определено ранее.  
		///
		/// или - 
		/// В сборке уже имеется другой файл с именем <paramref name="fileName" />.  
		///
		/// или - 
		/// Длина параметра <paramref name="name" /> равна нулю.  
		///
		/// или - 
		/// Длина параметра <paramref name="fileName" /> равна нулю.  
		///
		/// или - 
		/// <paramref name="fileName" /> содержит путь.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> или <paramref name="fileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06004EB3 RID: 20147 RVA: 0x000F6E63 File Offset: 0x000F5063
		public IResourceWriter DefineResource(string name, string description, string fileName)
		{
			return this.DefineResource(name, description, fileName, ResourceAttributes.Public);
		}

		/// <summary>Определяет автономный управляемый ресурс для данной сборки. Для управляемого ресурса можно задать атрибуты.</summary>
		/// <param name="name">Логическое имя ресурса.</param>
		/// <param name="description">Текстовое описание ресурса.</param>
		/// <param name="fileName">Имя физического файла (RESOURCES-файл), с которым сопоставляется логическое имя. Оно не должно содержать путь.</param>
		/// <param name="attribute">Атрибуты ресурса.</param>
		/// <returns>Объект <see cref="T:System.Resources.ResourceWriter" /> для указанного ресурса.</returns>
		/// <exception cref="T:System.ArgumentException">Имя <paramref name="name" /> было определено ранее, или в сборке имеется другой файл с именем <paramref name="fileName" />.  
		///
		/// или - 
		/// Длина параметра <paramref name="name" /> равна нулю.  
		///
		/// или - 
		/// Длина параметра <paramref name="fileName" /> равна нулю.  
		///
		/// или - 
		/// <paramref name="fileName" /> содержит путь.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> или <paramref name="fileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06004EB4 RID: 20148 RVA: 0x000F6E70 File Offset: 0x000F5070
		public IResourceWriter DefineResource(string name, string description, string fileName, ResourceAttributes attribute)
		{
			this.AddResourceFile(name, fileName, attribute, false);
			IResourceWriter resourceWriter = new ResourceWriter(fileName);
			if (this.resource_writers == null)
			{
				this.resource_writers = new ArrayList();
			}
			this.resource_writers.Add(resourceWriter);
			return resourceWriter;
		}

		// Token: 0x06004EB5 RID: 20149 RVA: 0x000F6EB0 File Offset: 0x000F50B0
		private void AddUnmanagedResource(Win32Resource res)
		{
			MemoryStream memoryStream = new MemoryStream();
			res.WriteTo(memoryStream);
			if (this.win32_resources != null)
			{
				MonoWin32Resource[] destinationArray = new MonoWin32Resource[this.win32_resources.Length + 1];
				Array.Copy(this.win32_resources, destinationArray, this.win32_resources.Length);
				this.win32_resources = destinationArray;
			}
			else
			{
				this.win32_resources = new MonoWin32Resource[1];
			}
			this.win32_resources[this.win32_resources.Length - 1] = new MonoWin32Resource(res.Type.Id, res.Name.Id, res.Language, memoryStream.ToArray());
		}

		/// <summary>Определяет неуправляемый ресурс для данной сборки как непрозрачный BLOB-объект байтов.</summary>
		/// <param name="resource">Непрозрачный BLOB-объект байтов, представляющий неуправляемый ресурс.</param>
		/// <exception cref="T:System.ArgumentException">Неуправляемый ресурс был определен ранее.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="resource" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06004EB6 RID: 20150 RVA: 0x000F6F47 File Offset: 0x000F5147
		[MonoTODO("Not currently implemenented")]
		public void DefineUnmanagedResource(byte[] resource)
		{
			if (resource == null)
			{
				throw new ArgumentNullException("resource");
			}
			if (this.native_resource != NativeResourceType.None)
			{
				throw new ArgumentException("Native resource has already been defined.");
			}
			this.native_resource = NativeResourceType.Unmanaged;
			throw new NotImplementedException();
		}

		/// <summary>Определяет файл неуправляемого ресурса для данной сборки по заданному имени файла ресурсов.</summary>
		/// <param name="resourceFileName">Имя файла ресурсов.</param>
		/// <exception cref="T:System.ArgumentException">Неуправляемый ресурс был определен ранее.  
		///
		/// или - 
		/// Файл <paramref name="resourceFileName" /> нечитаем.  
		///
		/// или - 
		/// <paramref name="resourceFileName" /> является пустой строкой ("").</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="resourceFileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="resourceFileName" /> не найден.  
		///
		/// или - 
		/// <paramref name="resourceFileName" /> является каталогом.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06004EB7 RID: 20151 RVA: 0x000F6F78 File Offset: 0x000F5178
		public void DefineUnmanagedResource(string resourceFileName)
		{
			if (resourceFileName == null)
			{
				throw new ArgumentNullException("resourceFileName");
			}
			if (resourceFileName.Length == 0)
			{
				throw new ArgumentException("resourceFileName");
			}
			if (!File.Exists(resourceFileName) || Directory.Exists(resourceFileName))
			{
				throw new FileNotFoundException("File '" + resourceFileName + "' does not exist or is a directory.");
			}
			if (this.native_resource != NativeResourceType.None)
			{
				throw new ArgumentException("Native resource has already been defined.");
			}
			this.native_resource = NativeResourceType.Unmanaged;
			using (FileStream fileStream = new FileStream(resourceFileName, FileMode.Open, FileAccess.Read))
			{
				foreach (object obj in new Win32ResFileReader(fileStream).ReadResources())
				{
					Win32EncodedResource win32EncodedResource = (Win32EncodedResource)obj;
					if (win32EncodedResource.Name.IsName || win32EncodedResource.Type.IsName)
					{
						throw new InvalidOperationException("resource files with named resources or non-default resource types are not supported.");
					}
					this.AddUnmanagedResource(win32EncodedResource);
				}
			}
		}

		/// <summary>Определяет неуправляемый ресурс сведений о версии с помощью сведений, указанных в объекте AssemblyName и настраиваемых атрибутах сборки.</summary>
		/// <exception cref="T:System.ArgumentException">Неуправляемый ресурс сведений о версии был определен ранее.  
		///
		/// или - 
		/// Объем неуправляемых сведений о версии слишком велик для сохранения.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06004EB8 RID: 20152 RVA: 0x000F707C File Offset: 0x000F527C
		public void DefineVersionInfoResource()
		{
			if (this.native_resource != NativeResourceType.None)
			{
				throw new ArgumentException("Native resource has already been defined.");
			}
			this.native_resource = NativeResourceType.Assembly;
			this.version_res = new Win32VersionResource(1, 0, false);
		}

		/// <summary>Определяет неуправляемую версию информационного ресурса для этой сборки с учетом заданных спецификаций.</summary>
		/// <param name="product">Имя продукта, с которым поставляется данная сборка.</param>
		/// <param name="productVersion">Версия продукта, с которым поставляется данная сборка.</param>
		/// <param name="company">Название организации, которая является создателем сборки.</param>
		/// <param name="copyright">Описывает все уведомления об авторских правах, товарные знаки и охраняемые товарные знаки, применимые к этой сборке. Это должен быть полный текст всех уведомлений, допустимых символов, сроки действия прав, номера товарных знаков и так далее. На русском языке эта строка должна быть в формате "© Корпорация Майкрософт (Microsoft Corporation) 1990-2001".</param>
		/// <param name="trademark">Описывает товарные знаки и охраняемые товарные знаки, применимые к этой сборке. Это должен быть полный текст всех уведомлений, допустимых символов, номера товарных знаков и так далее. На русском языке эта строка должна быть в формате "Windows является товарным знаком корпорации Майкрософт".</param>
		/// <exception cref="T:System.ArgumentException">Неуправляемый ресурс сведений о версии был определен ранее.  
		///
		/// или - 
		/// Объем неуправляемых сведений о версии слишком велик для сохранения.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06004EB9 RID: 20153 RVA: 0x000F70A8 File Offset: 0x000F52A8
		public void DefineVersionInfoResource(string product, string productVersion, string company, string copyright, string trademark)
		{
			if (this.native_resource != NativeResourceType.None)
			{
				throw new ArgumentException("Native resource has already been defined.");
			}
			this.native_resource = NativeResourceType.Explicit;
			this.version_res = new Win32VersionResource(1, 0, false);
			this.version_res.ProductName = ((product != null) ? product : " ");
			this.version_res.ProductVersion = ((productVersion != null) ? productVersion : " ");
			this.version_res.CompanyName = ((company != null) ? company : " ");
			this.version_res.LegalCopyright = ((copyright != null) ? copyright : " ");
			this.version_res.LegalTrademarks = ((trademark != null) ? trademark : " ");
		}

		// Token: 0x06004EBA RID: 20154 RVA: 0x000F7150 File Offset: 0x000F5350
		private void DefineVersionInfoResourceImpl(string fileName)
		{
			if (this.versioninfo_culture != null)
			{
				this.version_res.FileLanguage = new CultureInfo(this.versioninfo_culture).LCID;
			}
			this.version_res.Version = ((this.version == null) ? "0.0.0.0" : this.version);
			if (this.cattrs != null)
			{
				NativeResourceType nativeResourceType = this.native_resource;
				if (nativeResourceType != NativeResourceType.Assembly)
				{
					if (nativeResourceType == NativeResourceType.Explicit)
					{
						foreach (CustomAttributeBuilder customAttributeBuilder in this.cattrs)
						{
							string fullName = customAttributeBuilder.Ctor.ReflectedType.FullName;
							if (fullName == "System.Reflection.AssemblyCultureAttribute")
							{
								this.version_res.FileLanguage = new CultureInfo(customAttributeBuilder.string_arg()).LCID;
							}
							else if (fullName == "System.Reflection.AssemblyDescriptionAttribute")
							{
								this.version_res.Comments = customAttributeBuilder.string_arg();
							}
						}
					}
				}
				else
				{
					foreach (CustomAttributeBuilder customAttributeBuilder2 in this.cattrs)
					{
						string fullName2 = customAttributeBuilder2.Ctor.ReflectedType.FullName;
						if (fullName2 == "System.Reflection.AssemblyProductAttribute")
						{
							this.version_res.ProductName = customAttributeBuilder2.string_arg();
						}
						else if (fullName2 == "System.Reflection.AssemblyCompanyAttribute")
						{
							this.version_res.CompanyName = customAttributeBuilder2.string_arg();
						}
						else if (fullName2 == "System.Reflection.AssemblyCopyrightAttribute")
						{
							this.version_res.LegalCopyright = customAttributeBuilder2.string_arg();
						}
						else if (fullName2 == "System.Reflection.AssemblyTrademarkAttribute")
						{
							this.version_res.LegalTrademarks = customAttributeBuilder2.string_arg();
						}
						else if (fullName2 == "System.Reflection.AssemblyCultureAttribute")
						{
							this.version_res.FileLanguage = new CultureInfo(customAttributeBuilder2.string_arg()).LCID;
						}
						else if (fullName2 == "System.Reflection.AssemblyFileVersionAttribute")
						{
							this.version_res.FileVersion = customAttributeBuilder2.string_arg();
						}
						else if (fullName2 == "System.Reflection.AssemblyInformationalVersionAttribute")
						{
							this.version_res.ProductVersion = customAttributeBuilder2.string_arg();
						}
						else if (fullName2 == "System.Reflection.AssemblyTitleAttribute")
						{
							this.version_res.FileDescription = customAttributeBuilder2.string_arg();
						}
						else if (fullName2 == "System.Reflection.AssemblyDescriptionAttribute")
						{
							this.version_res.Comments = customAttributeBuilder2.string_arg();
						}
					}
				}
			}
			this.version_res.OriginalFilename = fileName;
			this.version_res.InternalName = Path.GetFileNameWithoutExtension(fileName);
			this.AddUnmanagedResource(this.version_res);
		}

		/// <summary>Возвращает динамический модуль с указанным именем.</summary>
		/// <param name="name">Имя запрошенного динамического модуля.</param>
		/// <returns>Объект ModuleBuilder, представляющий запрошенный динамический модуль.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Длина параметра <paramref name="name" /> равна нулю.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06004EBB RID: 20155 RVA: 0x000F73D8 File Offset: 0x000F55D8
		public ModuleBuilder GetDynamicModule(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (name.Length == 0)
			{
				throw new ArgumentException("Empty name is not legal.", "name");
			}
			if (this.modules != null)
			{
				for (int i = 0; i < this.modules.Length; i++)
				{
					if (this.modules[i].name == name)
					{
						return this.modules[i];
					}
				}
			}
			return null;
		}

		/// <summary>Возвращает экспортированные типы, определенные в этой сборке.</summary>
		/// <returns>Массив <see cref="T:System.Type" />, содержащий экспортированные типы, определенные в этой сборке.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод не реализован.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06004EBC RID: 20156 RVA: 0x000F6A5A File Offset: 0x000F4C5A
		public override Type[] GetExportedTypes()
		{
			throw this.not_supported();
		}

		/// <summary>Возвращает объект <see cref="T:System.IO.FileStream" /> для указанного файла из таблицы файлов манифеста данной сборки.</summary>
		/// <param name="name">Имя указанного файла.</param>
		/// <returns>
		///   <see cref="T:System.IO.FileStream" /> для указанного файла или <see langword="null" />, если файл не найден.</returns>
		/// <exception cref="T:System.NotSupportedException">В настоящее время этот метод не поддерживается.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06004EBD RID: 20157 RVA: 0x000F6A5A File Offset: 0x000F4C5A
		public override FileStream GetFile(string name)
		{
			throw this.not_supported();
		}

		/// <summary>Получает файлы из таблицы манифеста сборки с указанием включать или не включать модули ресурсов.</summary>
		/// <param name="getResourceModules">Значение <see langword="true" />, если необходимо включать модули ресурсов; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Массив объектов <see cref="T:System.IO.FileStream" />.</returns>
		/// <exception cref="T:System.NotSupportedException">В настоящее время этот метод не поддерживается.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06004EBE RID: 20158 RVA: 0x000F6A5A File Offset: 0x000F4C5A
		public override FileStream[] GetFiles(bool getResourceModules)
		{
			throw this.not_supported();
		}

		// Token: 0x06004EBF RID: 20159 RVA: 0x000F7445 File Offset: 0x000F5645
		internal override Module[] GetModulesInternal()
		{
			if (this.modules == null)
			{
				return new Module[0];
			}
			return (Module[])this.modules.Clone();
		}

		// Token: 0x06004EC0 RID: 20160 RVA: 0x000F7468 File Offset: 0x000F5668
		internal override Type[] GetTypes(bool exportedOnly)
		{
			Type[] array = null;
			if (this.modules != null)
			{
				for (int i = 0; i < this.modules.Length; i++)
				{
					Type[] types = this.modules[i].GetTypes();
					if (array == null)
					{
						array = types;
					}
					else
					{
						Type[] destinationArray = new Type[array.Length + types.Length];
						Array.Copy(array, 0, destinationArray, 0, array.Length);
						Array.Copy(types, 0, destinationArray, array.Length, types.Length);
					}
				}
			}
			if (this.loaded_modules != null)
			{
				for (int j = 0; j < this.loaded_modules.Length; j++)
				{
					Type[] types2 = this.loaded_modules[j].GetTypes();
					if (array == null)
					{
						array = types2;
					}
					else
					{
						Type[] destinationArray2 = new Type[array.Length + types2.Length];
						Array.Copy(array, 0, destinationArray2, 0, array.Length);
						Array.Copy(types2, 0, destinationArray2, array.Length, types2.Length);
					}
				}
			}
			if (array != null)
			{
				List<Exception> list = null;
				foreach (Type type in array)
				{
					if (type is TypeBuilder)
					{
						if (list == null)
						{
							list = new List<Exception>();
						}
						list.Add(new TypeLoadException(string.Format("Type '{0}' is not finished", type.FullName)));
					}
				}
				if (list != null)
				{
					throw new ReflectionTypeLoadException(new Type[list.Count], list.ToArray());
				}
			}
			if (array != null)
			{
				return array;
			}
			return Type.EmptyTypes;
		}

		/// <summary>Возвращает сведения о сохранении заданного ресурса.</summary>
		/// <param name="resourceName">Имя ресурса.</param>
		/// <returns>
		///   <see cref="T:System.Reflection.ManifestResourceInfo" />, заполненный сведениями о топологии ресурса, или <see langword="null" />, если ресурс не найден.</returns>
		/// <exception cref="T:System.NotSupportedException">В настоящее время этот метод не поддерживается.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06004EC1 RID: 20161 RVA: 0x000F6A5A File Offset: 0x000F4C5A
		public override ManifestResourceInfo GetManifestResourceInfo(string resourceName)
		{
			throw this.not_supported();
		}

		/// <summary>Загружает указанный ресурс манифеста из сборки.</summary>
		/// <returns>Массив типа <see langword="String" />, содержащий имена всех ресурсов.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод не поддерживается для динамической сборки. Для получения имен ресурсов манифеста используйте <see cref="M:System.Reflection.Assembly.GetManifestResourceNames" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06004EC2 RID: 20162 RVA: 0x000F6A5A File Offset: 0x000F4C5A
		public override string[] GetManifestResourceNames()
		{
			throw this.not_supported();
		}

		/// <summary>Загружает указанный ресурс манифеста из сборки.</summary>
		/// <param name="name">Имя запрашиваемого ресурса манифеста.</param>
		/// <returns>
		///   <see cref="T:System.IO.Stream" />, представляющий этот ресурс манифеста.</returns>
		/// <exception cref="T:System.NotSupportedException">В настоящее время этот метод не поддерживается.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06004EC3 RID: 20163 RVA: 0x000F6A5A File Offset: 0x000F4C5A
		public override Stream GetManifestResourceStream(string name)
		{
			throw this.not_supported();
		}

		/// <summary>Загружает из сборки указанный ресурс манифеста с учетом ограничения области действия пространства имен по типу.</summary>
		/// <param name="type">Тип, пространством имен которого ограничена область действия имени ресурса манифеста.</param>
		/// <param name="name">Имя запрашиваемого ресурса манифеста.</param>
		/// <returns>
		///   <see cref="T:System.IO.Stream" />, представляющий этот ресурс манифеста.</returns>
		/// <exception cref="T:System.NotSupportedException">В настоящее время этот метод не поддерживается.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06004EC4 RID: 20164 RVA: 0x000F6A5A File Offset: 0x000F4C5A
		public override Stream GetManifestResourceStream(Type type, string name)
		{
			throw this.not_supported();
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x06004EC5 RID: 20165 RVA: 0x000F75AD File Offset: 0x000F57AD
		internal bool IsSave
		{
			get
			{
				return this.access != 1U;
			}
		}

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x06004EC6 RID: 20166 RVA: 0x000F75BB File Offset: 0x000F57BB
		internal bool IsRun
		{
			get
			{
				return this.access == 1U || this.access == 3U || this.access == 9U;
			}
		}

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x06004EC7 RID: 20167 RVA: 0x000F75DB File Offset: 0x000F57DB
		internal string AssemblyDir
		{
			get
			{
				return this.dir;
			}
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x06004EC8 RID: 20168 RVA: 0x000F75E3 File Offset: 0x000F57E3
		// (set) Token: 0x06004EC9 RID: 20169 RVA: 0x000F75EB File Offset: 0x000F57EB
		internal bool IsModuleOnly
		{
			get
			{
				return this.is_module_only;
			}
			set
			{
				this.is_module_only = value;
			}
		}

		// Token: 0x06004ECA RID: 20170 RVA: 0x000F75F4 File Offset: 0x000F57F4
		internal override Module GetManifestModule()
		{
			if (this.manifest_module == null)
			{
				this.manifest_module = this.DefineDynamicModule("Default Dynamic Module");
			}
			return this.manifest_module;
		}

		/// <summary>Сохраняет эту динамическую сборку на диске, указывая природу кода в исполняемых файлах сборки и целевую платформу.</summary>
		/// <param name="assemblyFileName">Имя файла сборки.</param>
		/// <param name="portableExecutableKind">Побитовое сочетание значений <see cref="T:System.Reflection.PortableExecutableKinds" />, определяющее природу кода.</param>
		/// <param name="imageFileMachine">Одно из значений <see cref="T:System.Reflection.ImageFileMachine" />, определяющее целевую платформу.</param>
		/// <exception cref="T:System.ArgumentException">Длина <paramref name="assemblyFileName" /> равна нулю.  
		///
		/// или - 
		/// В сборке есть два или более файлов ресурсов модулей с тем же именем.  
		///
		/// или - 
		/// Целевой каталог сборки недопустим.  
		///
		/// или - 
		/// <paramref name="assemblyFileName" /> не является простым именем файла (например, содержит каталог или букву диска), или в этой сборке определено несколько неуправляемых ресурсов, включая ресурсы сведений о версии.  
		///
		/// или - 
		/// Строка <see langword="CultureInfo" /> в <see cref="T:System.Reflection.AssemblyCultureAttribute" /> не является допустимой строкой, и <see cref="M:System.Reflection.Emit.AssemblyBuilder.DefineVersionInfoResource(System.String,System.String,System.String,System.String,System.String)" /> был вызван до вызова этого метода.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assemblyFileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Эта сборка была сохранена ранее.  
		///
		/// или - 
		/// Эта сборка имеет доступ <see langword="Run" /><see cref="T:System.Reflection.Emit.AssemblyBuilderAccess" />.</exception>
		/// <exception cref="T:System.IO.IOException">Во время сохранения возникает ошибка вывода.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> не был вызван для какого-либо типа в модулях сборки, которые должны быть записаны на диск.</exception>
		// Token: 0x06004ECB RID: 20171 RVA: 0x000F761C File Offset: 0x000F581C
		[MonoLimitation("No support for PE32+ assemblies for AMD64 and IA64")]
		public void Save(string assemblyFileName, PortableExecutableKinds portableExecutableKind, ImageFileMachine imageFileMachine)
		{
			this.peKind = portableExecutableKind;
			this.machine = imageFileMachine;
			if ((this.peKind & PortableExecutableKinds.PE32Plus) != PortableExecutableKinds.NotAPortableExecutableImage || (this.peKind & PortableExecutableKinds.Unmanaged32Bit) != PortableExecutableKinds.NotAPortableExecutableImage)
			{
				throw new NotImplementedException(this.peKind.ToString());
			}
			if (this.machine == ImageFileMachine.IA64 || this.machine == ImageFileMachine.AMD64)
			{
				throw new NotImplementedException(this.machine.ToString());
			}
			if (this.resource_writers != null)
			{
				foreach (object obj in this.resource_writers)
				{
					IResourceWriter resourceWriter = (IResourceWriter)obj;
					resourceWriter.Generate();
					resourceWriter.Close();
				}
			}
			ModuleBuilder moduleBuilder = null;
			if (this.modules != null)
			{
				foreach (ModuleBuilder moduleBuilder2 in this.modules)
				{
					if (moduleBuilder2.FileName == assemblyFileName)
					{
						moduleBuilder = moduleBuilder2;
					}
				}
			}
			if (moduleBuilder == null)
			{
				moduleBuilder = this.DefineDynamicModule("RefEmit_OnDiskManifestModule", assemblyFileName);
			}
			if (!this.is_module_only)
			{
				moduleBuilder.IsMain = true;
			}
			if (this.entry_point != null && this.entry_point.DeclaringType.Module != moduleBuilder)
			{
				Type[] array2;
				if (this.entry_point.GetParametersCount() == 1)
				{
					array2 = new Type[]
					{
						typeof(string)
					};
				}
				else
				{
					array2 = Type.EmptyTypes;
				}
				MethodBuilder methodBuilder = moduleBuilder.DefineGlobalMethod("__EntryPoint$", MethodAttributes.Static, this.entry_point.ReturnType, array2);
				ILGenerator ilgenerator = methodBuilder.GetILGenerator();
				if (array2.Length == 1)
				{
					ilgenerator.Emit(OpCodes.Ldarg_0);
				}
				ilgenerator.Emit(OpCodes.Tailcall);
				ilgenerator.Emit(OpCodes.Call, this.entry_point);
				ilgenerator.Emit(OpCodes.Ret);
				this.entry_point = methodBuilder;
			}
			if (this.version_res != null)
			{
				this.DefineVersionInfoResourceImpl(assemblyFileName);
			}
			if (this.sn != null)
			{
				this.public_key = this.sn.PublicKey;
			}
			foreach (ModuleBuilder moduleBuilder3 in this.modules)
			{
				if (moduleBuilder3 != moduleBuilder)
				{
					moduleBuilder3.Save();
				}
			}
			moduleBuilder.Save();
			if (this.sn != null && this.sn.CanSign)
			{
				this.sn.Sign(Path.Combine(this.AssemblyDir, assemblyFileName));
			}
			this.created = true;
		}

		/// <summary>Сохраняет динамическую сборку на диск.</summary>
		/// <param name="assemblyFileName">Имя файла сборки.</param>
		/// <exception cref="T:System.ArgumentException">Длина <paramref name="assemblyFileName" /> равна нулю.  
		///
		/// или - 
		/// В сборке есть два или более файлов ресурсов модулей с тем же именем.  
		///
		/// или - 
		/// Целевой каталог сборки недопустим.  
		///
		/// или - 
		/// <paramref name="assemblyFileName" /> не является простым именем файла (например, содержит каталог или букву диска), или в этой сборке определено несколько неуправляемых ресурсов, включая ресурс сведений о версии.  
		///
		/// или - 
		/// Строка <see langword="CultureInfo" /> в <see cref="T:System.Reflection.AssemblyCultureAttribute" /> не является допустимой строкой, и <see cref="M:System.Reflection.Emit.AssemblyBuilder.DefineVersionInfoResource(System.String,System.String,System.String,System.String,System.String)" /> был вызван до вызова этого метода.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assemblyFileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Эта сборка была сохранена ранее.  
		///
		/// или - 
		/// Эта сборка имеет доступ <see langword="Run" /><see cref="T:System.Reflection.Emit.AssemblyBuilderAccess" />.</exception>
		/// <exception cref="T:System.IO.IOException">Во время сохранения возникает ошибка вывода.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> не был вызван для какого-либо типа в модулях сборки, которые должны быть записаны на диск.</exception>
		// Token: 0x06004ECC RID: 20172 RVA: 0x000F78A0 File Offset: 0x000F5AA0
		public void Save(string assemblyFileName)
		{
			this.Save(assemblyFileName, PortableExecutableKinds.ILOnly, ImageFileMachine.I386);
		}

		/// <summary>Задает точку входа для этой динамической сборки при условии, что выполняется сборка консольного приложения.</summary>
		/// <param name="entryMethod">Ссылка на метод, представляющий точку входа для этой динамической сборки.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="entryMethod" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод <paramref name="entryMethod" /> не содержится в данной сборке.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06004ECD RID: 20173 RVA: 0x000F78AF File Offset: 0x000F5AAF
		public void SetEntryPoint(MethodInfo entryMethod)
		{
			this.SetEntryPoint(entryMethod, PEFileKinds.ConsoleApplication);
		}

		/// <summary>Задает точку входа для этой сборки и определяет тип переносимого исполняемого файла (PE-файла), построение которого выполняется.</summary>
		/// <param name="entryMethod">Ссылка на метод, представляющий точку входа для этой динамической сборки.</param>
		/// <param name="fileKind">Тип исполняемого файла сборки, построение которого выполняется.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="entryMethod" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод <paramref name="entryMethod" /> не содержится в данной сборке.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06004ECE RID: 20174 RVA: 0x000F78BC File Offset: 0x000F5ABC
		public void SetEntryPoint(MethodInfo entryMethod, PEFileKinds fileKind)
		{
			if (entryMethod == null)
			{
				throw new ArgumentNullException("entryMethod");
			}
			if (entryMethod.DeclaringType.Assembly != this)
			{
				throw new InvalidOperationException("Entry method is not defined in the same assembly.");
			}
			this.entry_point = entryMethod;
			this.pekind = fileKind;
		}

		/// <summary>Задает настраиваемый атрибут для этой сборки с помощью построителя настраиваемого атрибута.</summary>
		/// <param name="customBuilder">Экземпляр вспомогательного класса для определения настраиваемого атрибута.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="con" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06004ECF RID: 20175 RVA: 0x000F790C File Offset: 0x000F5B0C
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
			}
			else
			{
				this.cattrs = new CustomAttributeBuilder[1];
				this.cattrs[0] = customBuilder;
			}
			if (customBuilder.Ctor != null && customBuilder.Ctor.DeclaringType == typeof(RuntimeCompatibilityAttribute))
			{
				AssemblyBuilder.UpdateNativeCustomAttributes(this);
			}
		}

		/// <summary>Задает настраиваемый атрибут для этой сборки с помощью большого двоичного объекта настраиваемого атрибута.</summary>
		/// <param name="con">Конструктор настраиваемого атрибута.</param>
		/// <param name="binaryAttribute">Большой двоичный объект байтов, представляющий атрибуты.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="con" /> или <paramref name="binaryAttribute" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="con" /> не является объектом <see langword="RuntimeConstructorInfo" />.</exception>
		// Token: 0x06004ED0 RID: 20176 RVA: 0x000F79A5 File Offset: 0x000F5BA5
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

		// Token: 0x06004ED1 RID: 20177 RVA: 0x000F79D6 File Offset: 0x000F5BD6
		private Exception not_supported()
		{
			return new NotSupportedException("The invoked member is not supported in a dynamic module.");
		}

		// Token: 0x06004ED2 RID: 20178 RVA: 0x000F79E4 File Offset: 0x000F5BE4
		private void check_name_and_filename(string name, string fileName, bool fileNeedsToExists)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (fileName == null)
			{
				throw new ArgumentNullException("fileName");
			}
			if (name.Length == 0)
			{
				throw new ArgumentException("Empty name is not legal.", "name");
			}
			if (fileName.Length == 0)
			{
				throw new ArgumentException("Empty file name is not legal.", "fileName");
			}
			if (Path.GetFileName(fileName) != fileName)
			{
				throw new ArgumentException("fileName '" + fileName + "' must not include a path.", "fileName");
			}
			string text = fileName;
			if (this.dir != null)
			{
				text = Path.Combine(this.dir, fileName);
			}
			if (fileNeedsToExists && !File.Exists(text))
			{
				throw new FileNotFoundException("Could not find file '" + fileName + "'");
			}
			if (this.resources != null)
			{
				for (int i = 0; i < this.resources.Length; i++)
				{
					if (this.resources[i].filename == text)
					{
						throw new ArgumentException("Duplicate file name '" + fileName + "'");
					}
					if (this.resources[i].name == name)
					{
						throw new ArgumentException("Duplicate name '" + name + "'");
					}
				}
			}
			if (this.modules != null)
			{
				for (int j = 0; j < this.modules.Length; j++)
				{
					if (!this.modules[j].IsTransient() && this.modules[j].FileName == fileName)
					{
						throw new ArgumentException("Duplicate file name '" + fileName + "'");
					}
					if (this.modules[j].Name == name)
					{
						throw new ArgumentException("Duplicate name '" + name + "'");
					}
				}
			}
		}

		// Token: 0x06004ED3 RID: 20179 RVA: 0x000F7B98 File Offset: 0x000F5D98
		private string create_assembly_version(string version)
		{
			string[] array = version.Split('.', StringSplitOptions.None);
			int[] array2 = new int[4];
			if (array.Length < 0 || array.Length > 4)
			{
				throw new ArgumentException("The version specified '" + version + "' is invalid");
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == "*")
				{
					DateTime now = DateTime.Now;
					if (i == 2)
					{
						array2[2] = (now - new DateTime(2000, 1, 1)).Days;
						if (array.Length == 3)
						{
							array2[3] = (now.Second + now.Minute * 60 + now.Hour * 3600) / 2;
						}
					}
					else
					{
						if (i != 3)
						{
							throw new ArgumentException("The version specified '" + version + "' is invalid");
						}
						array2[3] = (now.Second + now.Minute * 60 + now.Hour * 3600) / 2;
					}
				}
				else
				{
					try
					{
						array2[i] = int.Parse(array[i]);
					}
					catch (FormatException)
					{
						throw new ArgumentException("The version specified '" + version + "' is invalid");
					}
				}
			}
			return string.Concat(new string[]
			{
				array2[0].ToString(),
				".",
				array2[1].ToString(),
				".",
				array2[2].ToString(),
				".",
				array2[3].ToString()
			});
		}

		// Token: 0x06004ED4 RID: 20180 RVA: 0x000F7D2C File Offset: 0x000F5F2C
		private string GetCultureString(string str)
		{
			if (!(str == "neutral"))
			{
				return str;
			}
			return string.Empty;
		}

		// Token: 0x06004ED5 RID: 20181 RVA: 0x000F7D42 File Offset: 0x000F5F42
		internal Type MakeGenericType(Type gtd, Type[] typeArguments)
		{
			return new TypeBuilderInstantiation(gtd, typeArguments);
		}

		/// <summary>Возвращает указанный тип из типов, которые определены и созданы в текущем <see cref="T:System.Reflection.Emit.AssemblyBuilder" />.</summary>
		/// <param name="name">Имя искомого типа.</param>
		/// <param name="throwOnError">Значение <see langword="true" /> для вызова исключения, если тип не найден, в противном случае — значение <see langword="false" />.</param>
		/// <param name="ignoreCase">Значение <see langword="true" />, чтобы игнорировать регистр имени типа при поиске; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Указанный тип или значение <see langword="null" />, если тип не найден или еще не создан.</returns>
		// Token: 0x06004ED6 RID: 20182 RVA: 0x000F7D4C File Offset: 0x000F5F4C
		public override Type GetType(string name, bool throwOnError, bool ignoreCase)
		{
			if (name == null)
			{
				throw new ArgumentNullException(name);
			}
			if (name.Length == 0)
			{
				throw new ArgumentException("name", "Name cannot be empty");
			}
			Type type = base.InternalGetType(null, name, throwOnError, ignoreCase);
			if (!(type is TypeBuilder))
			{
				return type;
			}
			if (throwOnError)
			{
				throw new TypeLoadException(string.Format("Could not load type '{0}' from assembly '{1}'", name, this.name));
			}
			return null;
		}

		/// <summary>Получает указанный модуль этой сборки.</summary>
		/// <param name="name">Имя запрошенного модуля.</param>
		/// <returns>Запрашиваемый модуль или значение <see langword="null" />, если модуль не найден.</returns>
		// Token: 0x06004ED7 RID: 20183 RVA: 0x000F7DAC File Offset: 0x000F5FAC
		public override Module GetModule(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (name.Length == 0)
			{
				throw new ArgumentException("Name can't be empty");
			}
			if (this.modules == null)
			{
				return null;
			}
			foreach (ModuleBuilder module in this.modules)
			{
				if (module.ScopeName == name)
				{
					return module;
				}
			}
			return null;
		}

		/// <summary>Получает все модули, входящие в эту сборку, и при необходимости включает модули ресурсов.</summary>
		/// <param name="getResourceModules">Значение <see langword="true" />, если необходимо включать модули ресурсов; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Модули, являющиеся частью этой сборки.</returns>
		// Token: 0x06004ED8 RID: 20184 RVA: 0x000F7E10 File Offset: 0x000F6010
		public override Module[] GetModules(bool getResourceModules)
		{
			Module[] modulesInternal = this.GetModulesInternal();
			if (!getResourceModules)
			{
				List<Module> list = new List<Module>(modulesInternal.Length);
				foreach (Module module in modulesInternal)
				{
					if (!module.IsResource())
					{
						list.Add(module);
					}
				}
				return list.ToArray();
			}
			return modulesInternal;
		}

		/// <summary>Получает имя <see cref="T:System.Reflection.AssemblyName" />, которое было указано при создании текущей динамической сборки, и устанавливает базу кода в соответствии с указанием.</summary>
		/// <param name="copiedName">Значение <see langword="true" />, чтобы база кода устанавливалась в расположении сборки после создания ее теневой копии; значение <see langword="false" />, чтобы база кода устанавливалась в исходном расположении.</param>
		/// <returns>Имя динамической сборки.</returns>
		// Token: 0x06004ED9 RID: 20185 RVA: 0x000F7E60 File Offset: 0x000F6060
		public override AssemblyName GetName(bool copiedName)
		{
			AssemblyName assemblyName = AssemblyName.Create(this, false);
			if (this.sn != null)
			{
				assemblyName.SetPublicKey(this.sn.PublicKey);
				assemblyName.SetPublicKeyToken(this.sn.PublicKeyToken);
			}
			return assemblyName;
		}

		/// <summary>Получает неполный список объектов <see cref="T:System.Reflection.AssemblyName" /> для сборок, на которые ссылается этот <see cref="T:System.Reflection.Emit.AssemblyBuilder" />.</summary>
		/// <returns>Массив имен сборок для связанных сборок. Этот массив не является полным списком.</returns>
		// Token: 0x06004EDA RID: 20186 RVA: 0x000F3355 File Offset: 0x000F1555
		[MonoTODO("This always returns an empty array")]
		public override AssemblyName[] GetReferencedAssemblies()
		{
			return Assembly.GetReferencedAssemblies(this);
		}

		/// <summary>Возвращает все загруженные модули, входящие в эту сборку, и при необходимости включает модули ресурсов.</summary>
		/// <param name="getResourceModules">Значение <see langword="true" />, если необходимо включать модули ресурсов; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Загруженные модули, являющиеся частью этой сборки.</returns>
		// Token: 0x06004EDB RID: 20187 RVA: 0x000F33AE File Offset: 0x000F15AE
		public override Module[] GetLoadedModules(bool getResourceModules)
		{
			return this.GetModules(getResourceModules);
		}

		/// <summary>Получает сопутствующую сборку для указанной культуры.</summary>
		/// <param name="culture">Заданные язык и региональные параметры.</param>
		/// <returns>Указанная вспомогательная сборка.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="culture" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удается найти сборку.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Вспомогательная сборка с соответствующим именем файла была найдена, но параметр <see langword="CultureInfo" /> не соответствует указанному.</exception>
		/// <exception cref="T:System.BadImageFormatException">Вспомогательная сборка не является допустимой сборкой.</exception>
		// Token: 0x06004EDC RID: 20188 RVA: 0x000F7EA0 File Offset: 0x000F60A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Assembly GetSatelliteAssembly(CultureInfo culture)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return base.GetSatelliteAssembly(culture, null, true, ref stackCrawlMark);
		}

		/// <summary>Получает указанную версию вспомогательной сборки для указанной культуры.</summary>
		/// <param name="culture">Заданные язык и региональные параметры.</param>
		/// <param name="version">Версия вспомогательной сборки.</param>
		/// <returns>Указанная вспомогательная сборка.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="culture" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Вспомогательная сборка с соответствующим именем файла была найдена, но <see langword="CultureInfo" /> или версия не соответствуют указанным.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удается найти сборку.</exception>
		/// <exception cref="T:System.BadImageFormatException">Вспомогательная сборка не является допустимой сборкой.</exception>
		// Token: 0x06004EDD RID: 20189 RVA: 0x000F7EBC File Offset: 0x000F60BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Assembly GetSatelliteAssembly(CultureInfo culture, Version version)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return base.GetSatelliteAssembly(culture, version, true, ref stackCrawlMark);
		}

		/// <summary>Получает модуль в текущем <see cref="T:System.Reflection.Emit.AssemblyBuilder" />, содержащий манифест сборки.</summary>
		/// <returns>Модуль манифеста.</returns>
		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x06004EDE RID: 20190 RVA: 0x000F33EE File Offset: 0x000F15EE
		public override Module ManifestModule
		{
			get
			{
				return this.GetManifestModule();
			}
		}

		/// <summary>Получает значение, указывающее, была ли сборка загружена из глобального кэша сборок.</summary>
		/// <returns>Всегда <see langword="false" />.</returns>
		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x06004EDF RID: 20191 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public override bool GlobalAssemblyCache
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает значение, указывающее, что текущая сборка является динамической.</summary>
		/// <returns>Всегда <see langword="true" />.</returns>
		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x06004EE0 RID: 20192 RVA: 0x000040F7 File Offset: 0x000022F7
		public override bool IsDynamic
		{
			get
			{
				return true;
			}
		}

		/// <summary>Возвращает значение, указывающее, равен ли данный экземпляр указанному объекту.</summary>
		/// <param name="obj">Объект, сравниваемый с этим экземпляром, или значение <see langword="null" />.</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="obj" /> равно типу и значению данного экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06004EE1 RID: 20193 RVA: 0x000F7ED6 File Offset: 0x000F60D6
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06004EE2 RID: 20194 RVA: 0x000F374A File Offset: 0x000F194A
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06004EE3 RID: 20195 RVA: 0x000F7EDF File Offset: 0x000F60DF
		public override string ToString()
		{
			if (this.assemblyName != null)
			{
				return this.assemblyName;
			}
			this.assemblyName = this.FullName;
			return this.assemblyName;
		}

		/// <summary>Возвращает значение, указывающее, применяется ли к данному члену один или несколько экземпляров определенного типа атрибута.</summary>
		/// <param name="attributeType">Тип атрибута для тестирования.</param>
		/// <param name="inherit">Данный аргумент не учитывается для объектов этого типа.</param>
		/// <returns>Значение <see langword="true" />, если один или несколько экземпляров <paramref name="attributeType" /> применяются к этой динамической сборке; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004EE4 RID: 20196 RVA: 0x00052A66 File Offset: 0x00050C66
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return MonoCustomAttrs.IsDefined(this, attributeType, inherit);
		}

		/// <summary>Возвращает все настраиваемые атрибуты, которые были применены к текущему <see cref="T:System.Reflection.Emit.AssemblyBuilder" />.</summary>
		/// <param name="inherit">Данный аргумент не учитывается для объектов этого типа.</param>
		/// <returns>Массив, содержащий настраиваемые атрибуты; массив является пустым, если атрибуты отсутствуют.</returns>
		// Token: 0x06004EE5 RID: 20197 RVA: 0x000F191D File Offset: 0x000EFB1D
		public override object[] GetCustomAttributes(bool inherit)
		{
			return MonoCustomAttrs.GetCustomAttributes(this, inherit);
		}

		/// <summary>Возвращает настраиваемые атрибуты, примененные к текущему <see cref="T:System.Reflection.Emit.AssemblyBuilder" />, которые являются производными от указанного типа атрибута.</summary>
		/// <param name="attributeType">Базовый тип, от которого наследуют атрибуты.</param>
		/// <param name="inherit">Данный аргумент не учитывается для объектов этого типа.</param>
		/// <returns>Массив, содержащий настраиваемые атрибуты, которые являются производными на любом уровне от <paramref name="attributeType" />; массив является пустым, если атрибуты отсутствуют.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="attributeType" /> не является объектом <see cref="T:System.Type" />, предоставляемым средой выполнения. Например, <paramref name="attributeType" /> является объектом <see cref="T:System.Reflection.Emit.TypeBuilder" />.</exception>
		// Token: 0x06004EE6 RID: 20198 RVA: 0x000F1926 File Offset: 0x000EFB26
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return MonoCustomAttrs.GetCustomAttributes(this, attributeType, inherit);
		}

		/// <summary>Получает отображаемое имя текущей динамической сборки.</summary>
		/// <returns>Отображаемое имя текущей динамической сборки.</returns>
		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x06004EE7 RID: 20199 RVA: 0x000F3481 File Offset: 0x000F1681
		public override string FullName
		{
			get
			{
				return RuntimeAssembly.get_fullname(this);
			}
		}

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x06004EE8 RID: 20200 RVA: 0x000F7F02 File Offset: 0x000F6102
		internal override IntPtr MonoAssembly
		{
			get
			{
				return this._mono_assembly;
			}
		}

		/// <summary>Получает свидетельство для этой сборки.</summary>
		/// <returns>Свидетельство для этой сборки.</returns>
		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x06004EE9 RID: 20201 RVA: 0x000F37A2 File Offset: 0x000F19A2
		public override Evidence Evidence
		{
			[SecurityPermission(SecurityAction.Demand, ControlEvidence = true)]
			get
			{
				return this.UnprotectedGetEvidence();
			}
		}

		// Token: 0x06004EEA RID: 20202 RVA: 0x000F7F0C File Offset: 0x000F610C
		internal override Evidence UnprotectedGetEvidence()
		{
			if (this._evidence == null)
			{
				lock (this)
				{
					this._evidence = Evidence.GetDefaultHostEvidence(this);
				}
			}
			return this._evidence;
		}

		// Token: 0x06004EEB RID: 20203 RVA: 0x000173AD File Offset: 0x000155AD
		internal AssemblyBuilder()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x040030E5 RID: 12517
		internal IntPtr _mono_assembly;

		// Token: 0x040030E6 RID: 12518
		internal Evidence _evidence;

		// Token: 0x040030E7 RID: 12519
		private UIntPtr dynamic_assembly;

		// Token: 0x040030E8 RID: 12520
		private MethodInfo entry_point;

		// Token: 0x040030E9 RID: 12521
		private ModuleBuilder[] modules;

		// Token: 0x040030EA RID: 12522
		private string name;

		// Token: 0x040030EB RID: 12523
		private string dir;

		// Token: 0x040030EC RID: 12524
		private CustomAttributeBuilder[] cattrs;

		// Token: 0x040030ED RID: 12525
		private MonoResource[] resources;

		// Token: 0x040030EE RID: 12526
		private byte[] public_key;

		// Token: 0x040030EF RID: 12527
		private string version;

		// Token: 0x040030F0 RID: 12528
		private string culture;

		// Token: 0x040030F1 RID: 12529
		private uint algid;

		// Token: 0x040030F2 RID: 12530
		private uint flags;

		// Token: 0x040030F3 RID: 12531
		private PEFileKinds pekind;

		// Token: 0x040030F4 RID: 12532
		private bool delay_sign;

		// Token: 0x040030F5 RID: 12533
		private uint access;

		// Token: 0x040030F6 RID: 12534
		private Module[] loaded_modules;

		// Token: 0x040030F7 RID: 12535
		private MonoWin32Resource[] win32_resources;

		// Token: 0x040030F8 RID: 12536
		private RefEmitPermissionSet[] permissions_minimum;

		// Token: 0x040030F9 RID: 12537
		private RefEmitPermissionSet[] permissions_optional;

		// Token: 0x040030FA RID: 12538
		private RefEmitPermissionSet[] permissions_refused;

		// Token: 0x040030FB RID: 12539
		private PortableExecutableKinds peKind;

		// Token: 0x040030FC RID: 12540
		private ImageFileMachine machine;

		// Token: 0x040030FD RID: 12541
		private bool corlib_internal;

		// Token: 0x040030FE RID: 12542
		private Type[] type_forwarders;

		// Token: 0x040030FF RID: 12543
		private byte[] pktoken;

		// Token: 0x04003100 RID: 12544
		internal PermissionSet _minimum;

		// Token: 0x04003101 RID: 12545
		internal PermissionSet _optional;

		// Token: 0x04003102 RID: 12546
		internal PermissionSet _refuse;

		// Token: 0x04003103 RID: 12547
		internal PermissionSet _granted;

		// Token: 0x04003104 RID: 12548
		internal PermissionSet _denied;

		// Token: 0x04003105 RID: 12549
		private string assemblyName;

		// Token: 0x04003106 RID: 12550
		internal Type corlib_object_type;

		// Token: 0x04003107 RID: 12551
		internal Type corlib_value_type;

		// Token: 0x04003108 RID: 12552
		internal Type corlib_enum_type;

		// Token: 0x04003109 RID: 12553
		internal Type corlib_void_type;

		// Token: 0x0400310A RID: 12554
		private ArrayList resource_writers;

		// Token: 0x0400310B RID: 12555
		private Win32VersionResource version_res;

		// Token: 0x0400310C RID: 12556
		private bool created;

		// Token: 0x0400310D RID: 12557
		private bool is_module_only;

		// Token: 0x0400310E RID: 12558
		private Mono.Security.StrongName sn;

		// Token: 0x0400310F RID: 12559
		private NativeResourceType native_resource;

		// Token: 0x04003110 RID: 12560
		private string versioninfo_culture;

		// Token: 0x04003111 RID: 12561
		private const AssemblyBuilderAccess COMPILER_ACCESS = (AssemblyBuilderAccess)2048;

		// Token: 0x04003112 RID: 12562
		private ModuleBuilder manifest_module;
	}
}
