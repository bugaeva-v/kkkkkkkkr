using System;
using System.Collections.Generic;
using System.Configuration.Assemblies;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Threading;
using Mono;

namespace System.Reflection
{
	/// <summary>Представляет сборку, которая является модулем с возможностью многократного использования, поддержкой версий и встроенным механизмом описания общеязыковой исполняющей среды.</summary>
	// Token: 0x020008E8 RID: 2280
	[ComDefaultInterface(typeof(_Assembly))]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public abstract class Assembly : ICustomAttributeProvider, _Assembly, IEvidenceFactory, ISerializable
	{
		/// <summary>Возникает, если загрузчик классов общеязыковой среды выполнения не может обработать ссылку на внутренний модуль сборки, используя обычные средства.</summary>
		// Token: 0x1400001C RID: 28
		// (add) Token: 0x06004BE3 RID: 19427 RVA: 0x000479F8 File Offset: 0x00045BF8
		// (remove) Token: 0x06004BE4 RID: 19428 RVA: 0x000479F8 File Offset: 0x00045BF8
		public virtual event ModuleResolveEventHandler ModuleResolve
		{
			[SecurityPermission(SecurityAction.LinkDemand, ControlAppDomain = true)]
			add
			{
				throw new NotImplementedException();
			}
			[SecurityPermission(SecurityAction.LinkDemand, ControlAppDomain = true)]
			remove
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает первоначально заданное расположение сборки, например в объекте <see cref="T:System.Reflection.AssemblyName" />.</summary>
		/// <returns>Первоначально заданное расположение сборки.</returns>
		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x06004BE5 RID: 19429 RVA: 0x000479F8 File Offset: 0x00045BF8
		public virtual string CodeBase
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает универсальный код доступа (URI), предоставляющий базовый код, включая escape-символы.</summary>
		/// <returns>Универсальный код доступа (URI) с escape-символами.</returns>
		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x06004BE6 RID: 19430 RVA: 0x000479F8 File Offset: 0x00045BF8
		public virtual string EscapedCodeBase
		{
			[SecuritySafeCritical]
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает отображаемое имя сборки.</summary>
		/// <returns>Отображаемое имя сборки.</returns>
		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x06004BE7 RID: 19431 RVA: 0x000479F8 File Offset: 0x00045BF8
		public virtual string FullName
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает точку входа для этой сборки.</summary>
		/// <returns>Объект, представляющий точку входа этой сборки. Если точка входа не найдена (например, сборка является DLL-библиотекой), возвращается значение <see langword="null" />.</returns>
		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x06004BE8 RID: 19432 RVA: 0x000479F8 File Offset: 0x00045BF8
		public virtual MethodInfo EntryPoint
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает свидетельство для этой сборки.</summary>
		/// <returns>Свидетельство для этой сборки.</returns>
		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x06004BE9 RID: 19433 RVA: 0x000479F8 File Offset: 0x00045BF8
		public virtual Evidence Evidence
		{
			[SecurityPermission(SecurityAction.Demand, ControlEvidence = true)]
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x06004BEA RID: 19434 RVA: 0x000479F8 File Offset: 0x00045BF8
		internal virtual Evidence UnprotectedGetEvidence()
		{
			throw new NotImplementedException();
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x06004BEB RID: 19435 RVA: 0x000479F8 File Offset: 0x00045BF8
		internal virtual IntPtr MonoAssembly
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x17000C37 RID: 3127
		// (set) Token: 0x06004BEC RID: 19436 RVA: 0x000479F8 File Offset: 0x00045BF8
		internal virtual bool FromByteArray
		{
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает полный путь либо UNC для расположения загруженного файла, содержащего манифест.</summary>
		/// <returns>Местоположение загруженного файла, содержащего манифест. Если для загруженного файла был создан снимок состояния, местонахождение является местонахождением файла после теневого копирования. Если сборка загружается из массива байтов, например, при использовании метода перегрузки <see cref="M:System.Reflection.Assembly.Load(System.Byte[])" />, возвращаемое значение является пустой строкой ("").</returns>
		/// <exception cref="T:System.NotSupportedException">Текущая сборка является динамической сборкой, представленной объектом <see cref="T:System.Reflection.Emit.AssemblyBuilder" />.</exception>
		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x06004BED RID: 19437 RVA: 0x000479F8 File Offset: 0x00045BF8
		public virtual string Location
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает строку, представляющую версию общеязыковой среды выполнения (CLR), сохраненной в файле, содержащем манифест.</summary>
		/// <returns>Имя папки версии среды CLR. Указанный путь не является полным.</returns>
		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x06004BEE RID: 19438 RVA: 0x000479F8 File Offset: 0x00045BF8
		[ComVisible(false)]
		public virtual string ImageRuntimeVersion
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает сведения сериализации со всеми данными, необходимыми для повторного создания экземпляра этой сборки.</summary>
		/// <param name="info">Объект, для которого будут заполнены сведения о сериализации.</param>
		/// <param name="context">Контекст назначения сериализации.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004BEF RID: 19439 RVA: 0x000479F8 File Offset: 0x00045BF8
		[SecurityCritical]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new NotImplementedException();
		}

		/// <summary>Указывает, применен ли конкретный атрибут к сборке.</summary>
		/// <param name="attributeType">Тип атрибута, который нужно проверить для данной сборки.</param>
		/// <param name="inherit">Данный аргумент не учитывается для объектов этого типа.</param>
		/// <returns>Значение <see langword="true" />, если атрибут был применен к сборке; в обратном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="attributeType" /> использует недопустимый тип.</exception>
		// Token: 0x06004BF0 RID: 19440 RVA: 0x000479F8 File Offset: 0x00045BF8
		public virtual bool IsDefined(Type attributeType, bool inherit)
		{
			throw new NotImplementedException();
		}

		/// <summary>Получает все настраиваемые атрибуты для этой сборки.</summary>
		/// <param name="inherit">Данный аргумент не учитывается для объектов типа <see cref="T:System.Reflection.Assembly" />.</param>
		/// <returns>Массив, содержащий настраиваемые атрибуты для этой сборки.</returns>
		// Token: 0x06004BF1 RID: 19441 RVA: 0x000479F8 File Offset: 0x00045BF8
		public virtual object[] GetCustomAttributes(bool inherit)
		{
			throw new NotImplementedException();
		}

		/// <summary>Получает настраиваемые атрибуты для этой сборки как заданные по типу.</summary>
		/// <param name="attributeType">Тип, для которого должны быть возвращены настраиваемые атрибуты.</param>
		/// <param name="inherit">Данный аргумент не учитывается для объектов типа <see cref="T:System.Reflection.Assembly" />.</param>
		/// <returns>Массив, содержащий настраиваемые атрибуты для этой сборки, заданные параметром <paramref name="attributeType" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="attributeType" /> не является типом среды выполнения.</exception>
		// Token: 0x06004BF2 RID: 19442 RVA: 0x000479F8 File Offset: 0x00045BF8
		public virtual object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			throw new NotImplementedException();
		}

		/// <summary>Получает файлы в таблице файлов манифеста сборки.</summary>
		/// <returns>Массив потоков, содержащий файлы.</returns>
		/// <exception cref="T:System.IO.FileLoadException">Не удалось загрузить файл, который был найден.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл не найден.</exception>
		/// <exception cref="T:System.BadImageFormatException">Файл не является допустимой сборкой.</exception>
		// Token: 0x06004BF3 RID: 19443 RVA: 0x000F19F9 File Offset: 0x000EFBF9
		public virtual FileStream[] GetFiles()
		{
			return this.GetFiles(false);
		}

		/// <summary>Получает файлы из таблицы манифеста сборки с указанием включать или не включать модули ресурсов.</summary>
		/// <param name="getResourceModules">Значение <see langword="true" />, если необходимо включать модули ресурсов; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Массив потоков, содержащий файлы.</returns>
		/// <exception cref="T:System.IO.FileLoadException">Не удалось загрузить файл, который был найден.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл не найден.</exception>
		/// <exception cref="T:System.BadImageFormatException">Файл не является допустимой сборкой.</exception>
		// Token: 0x06004BF4 RID: 19444 RVA: 0x000479F8 File Offset: 0x00045BF8
		public virtual FileStream[] GetFiles(bool getResourceModules)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает объект <see cref="T:System.IO.FileStream" /> для указанного файла из таблицы файлов манифеста данной сборки.</summary>
		/// <param name="name">Имя указанного файла. Не должно содержать путь к файлу.</param>
		/// <returns>Поток, содержащий указанный файл или <see langword="null" />, если файл не найден.</returns>
		/// <exception cref="T:System.IO.FileLoadException">Не удалось загрузить файл, который был найден.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> представляет собой пустую строку ("").</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="name" />.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="name" /> не является допустимой сборкой.</exception>
		// Token: 0x06004BF5 RID: 19445 RVA: 0x000479F8 File Offset: 0x00045BF8
		public virtual FileStream GetFile(string name)
		{
			throw new NotImplementedException();
		}

		/// <summary>Загружает указанный ресурс манифеста из сборки.</summary>
		/// <param name="name">Имя запрашиваемого ресурса манифеста, зависящее от регистра.</param>
		/// <returns>Ресурс манифеста; или значение <see langword="null" />, если при компиляции не были заданы ресурсы или ресурс не является видимым для вызывающего объекта.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> представляет собой пустую строку ("").</exception>
		/// <exception cref="T:System.IO.FileLoadException">Вместо этого в .NET для приложений Магазина Windows или в переносимой библиотеке классов перехватите исключение базового класса <see cref="T:System.IO.IOException" />.  
		///
		///
		///
		///
		///  Не удалось загрузить файл, который был найден.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="name" />.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="name" /> не является допустимой сборкой.</exception>
		/// <exception cref="T:System.NotImplementedException">Длина ресурса больше <see cref="F:System.Int64.MaxValue" />.</exception>
		// Token: 0x06004BF6 RID: 19446 RVA: 0x000479F8 File Offset: 0x00045BF8
		public virtual Stream GetManifestResourceStream(string name)
		{
			throw new NotImplementedException();
		}

		/// <summary>Загружает из сборки указанный ресурс манифеста с учетом ограничения области действия пространства имен по типу.</summary>
		/// <param name="type">Тип, пространством имен которого ограничена область действия имени ресурса манифеста.</param>
		/// <param name="name">Имя запрашиваемого ресурса манифеста, зависящее от регистра.</param>
		/// <returns>Ресурс манифеста; или значение <see langword="null" />, если при компиляции не были заданы ресурсы или ресурс не является видимым для вызывающего объекта.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> представляет собой пустую строку ("").</exception>
		/// <exception cref="T:System.IO.FileLoadException">Не удалось загрузить файл, который был найден.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="name" />.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="name" /> не является допустимой сборкой.</exception>
		/// <exception cref="T:System.NotImplementedException">Длина ресурса больше <see cref="F:System.Int64.MaxValue" />.</exception>
		// Token: 0x06004BF7 RID: 19447 RVA: 0x000479F8 File Offset: 0x00045BF8
		public virtual Stream GetManifestResourceStream(Type type, string name)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06004BF8 RID: 19448 RVA: 0x000F1A04 File Offset: 0x000EFC04
		internal Stream GetManifestResourceStream(Type type, string name, bool skipSecurityCheck, ref StackCrawlMark stackMark)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (type == null)
			{
				if (name == null)
				{
					throw new ArgumentNullException("type");
				}
			}
			else
			{
				string @namespace = type.Namespace;
				if (@namespace != null)
				{
					stringBuilder.Append(@namespace);
					if (name != null)
					{
						stringBuilder.Append(Type.Delimiter);
					}
				}
			}
			if (name != null)
			{
				stringBuilder.Append(name);
			}
			return this.GetManifestResourceStream(stringBuilder.ToString());
		}

		// Token: 0x06004BF9 RID: 19449 RVA: 0x000F1A66 File Offset: 0x000EFC66
		internal Stream GetManifestResourceStream(string name, ref StackCrawlMark stackMark, bool skipSecurityCheck)
		{
			return this.GetManifestResourceStream(null, name, skipSecurityCheck, ref stackMark);
		}

		// Token: 0x06004BFA RID: 19450 RVA: 0x000F1A72 File Offset: 0x000EFC72
		internal string GetSimpleName()
		{
			return this.GetName(true).Name;
		}

		// Token: 0x06004BFB RID: 19451 RVA: 0x000F1A80 File Offset: 0x000EFC80
		internal byte[] GetPublicKey()
		{
			return this.GetName(true).GetPublicKey();
		}

		// Token: 0x06004BFC RID: 19452 RVA: 0x000F1A8E File Offset: 0x000EFC8E
		internal Version GetVersion()
		{
			return this.GetName(true).Version;
		}

		// Token: 0x06004BFD RID: 19453 RVA: 0x000F1A9C File Offset: 0x000EFC9C
		private AssemblyNameFlags GetFlags()
		{
			return this.GetName(true).Flags;
		}

		// Token: 0x06004BFE RID: 19454
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal virtual extern Type[] GetTypes(bool exportedOnly);

		/// <summary>Получает типы, определенные в этой сборке.</summary>
		/// <returns>Массив, содержащий все типы, определенные в этой сборке.</returns>
		/// <exception cref="T:System.Reflection.ReflectionTypeLoadException">Сборка содержит один или несколько типов, которые не удается загрузить. Массив, возвращаемый свойством <see cref="P:System.Reflection.ReflectionTypeLoadException.Types" /> этого исключения, содержит объект <see cref="T:System.Type" /> для каждого типа, который был загружен, и объект <see langword="null" /> для каждого типа, который не удалось загрузить, тогда как свойство <see cref="P:System.Reflection.ReflectionTypeLoadException.LoaderExceptions" /> содержит исключение для каждого типа, который не удалось загрузить.</exception>
		// Token: 0x06004BFF RID: 19455 RVA: 0x000F1AAA File Offset: 0x000EFCAA
		public virtual Type[] GetTypes()
		{
			return this.GetTypes(false);
		}

		/// <summary>Получает открытые типы, определенные в этой сборке и видимые за ее пределами.</summary>
		/// <returns>Массив, представляющий типы, определенные в сборке и видимые за ее пределами.</returns>
		/// <exception cref="T:System.NotSupportedException">Сборка является динамической.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удается загрузить зависимую сборку.</exception>
		// Token: 0x06004C00 RID: 19456 RVA: 0x000479F8 File Offset: 0x00045BF8
		public virtual Type[] GetExportedTypes()
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает объект <see cref="T:System.Type" /> с заданным именем в экземпляре сборки и может вызывать исключение, если тип не найден.</summary>
		/// <param name="name">Полное имя типа.</param>
		/// <param name="throwOnError">Значение <see langword="true" /> для создания исключения, если тип не найден, в обратном случае — значение <see langword="false" />, в результате чего будет возвращено значение <see langword="null" />.</param>
		/// <returns>Объект, представляющий указанный класс.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="name" /> недопустим.  
		///
		/// или - 
		/// Длина <paramref name="name" /> превышает 1024 символа.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.TypeLoadException">
		///   <paramref name="throwOnError" /> является <see langword="true" />, не удается найти тип.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Для <paramref name="name" /> требуется зависимая сборка, которую не удается найти.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Для <paramref name="name" /> требуется зависимая сборка, которая была найдена, но ее не удалось загрузить.  
		///
		/// или - 
		/// Текущая сборка была загружена в контекст только для отражения, а для <paramref name="name" /> требуется зависимая сборка, которая не была предварительно загружена.</exception>
		/// <exception cref="T:System.BadImageFormatException">Для <paramref name="name" /> требуется зависимая сборка, однако файл не является допустимой сборкой.  
		///
		/// или - 
		/// Для <paramref name="name" /> требуется зависимая сборка, которая была скомпилирована для версии среды выполнения более поздней, чем текущая загруженная версия.</exception>
		// Token: 0x06004C01 RID: 19457 RVA: 0x000F1AB3 File Offset: 0x000EFCB3
		public virtual Type GetType(string name, bool throwOnError)
		{
			return this.GetType(name, throwOnError, false);
		}

		/// <summary>Возвращает объект <see cref="T:System.Type" /> с указанным именем в экземпляре сборки.</summary>
		/// <param name="name">Полное имя типа.</param>
		/// <returns>Объект, представляющий указанный класс, или <see langword="null" />, если класс не найден.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="name" /> недопустим.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Для <paramref name="name" /> требуется зависимая сборка, которую не удается найти.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Вместо этого в .NET для приложений Магазина Windows или в переносимой библиотеке классов перехватите исключение базового класса <see cref="T:System.IO.IOException" />.  
		///
		///     Для 
		///     <paramref name="name" /> требуется зависимая сборка, которая была найдена, но ее не удалось загрузить.  
		///
		/// или - 
		/// Текущая сборка была загружена в контекст только для отражения, а для <paramref name="name" /> требуется зависимая сборка, которая не была предварительно загружена.</exception>
		/// <exception cref="T:System.BadImageFormatException">Для <paramref name="name" /> требуется зависимая сборка, однако файл не является допустимой сборкой.  
		///
		/// или - 
		/// Для <paramref name="name" /> требуется зависимая сборка, которая была скомпилирована для версии среды выполнения более поздней, чем текущая загруженная версия.</exception>
		// Token: 0x06004C02 RID: 19458 RVA: 0x000F1ABE File Offset: 0x000EFCBE
		public virtual Type GetType(string name)
		{
			return this.GetType(name, false, false);
		}

		// Token: 0x06004C03 RID: 19459
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern Type InternalGetType(Module module, string name, bool throwOnError, bool ignoreCase);

		// Token: 0x06004C04 RID: 19460
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void InternalGetAssemblyName(string assemblyFile, out MonoAssemblyName aname, out string codebase);

		/// <summary>Возвращает значение <see cref="T:System.Reflection.AssemblyName" /> для этой сборки, база кода устанавливается в соответствии с параметром <paramref name="copiedName" />.</summary>
		/// <param name="copiedName">Значение <see langword="true" />, чтобы значение свойства <see cref="P:System.Reflection.Assembly.CodeBase" /> указывало на расположение сборки после создания ее теневой копии; значение <see langword="false" />, если значение свойства <see cref="P:System.Reflection.Assembly.CodeBase" /> должно указывать на первоначальное расположение.</param>
		/// <returns>Объект, содержащий полностью проанализированное отображаемое имя для этой сборки.</returns>
		// Token: 0x06004C05 RID: 19461 RVA: 0x000479F8 File Offset: 0x00045BF8
		public virtual AssemblyName GetName(bool copiedName)
		{
			throw new NotImplementedException();
		}

		/// <summary>Получает имя <see cref="T:System.Reflection.AssemblyName" /> для этой сборки.</summary>
		/// <returns>Объект, содержащий полностью проанализированное отображаемое имя для этой сборки.</returns>
		// Token: 0x06004C06 RID: 19462 RVA: 0x000F1AC9 File Offset: 0x000EFCC9
		public virtual AssemblyName GetName()
		{
			return this.GetName(false);
		}

		/// <summary>Возвращает полное имя сборки, также называемое отображаемым именем.</summary>
		/// <returns>Полное имя сборки или имя класса, если полное имя сборки не может быть определено.</returns>
		// Token: 0x06004C07 RID: 19463 RVA: 0x00097E33 File Offset: 0x00096033
		public override string ToString()
		{
			return base.ToString();
		}

		/// <summary>Создает имя типа, который определяется отображаемым именем его сборки.</summary>
		/// <param name="assemblyName">Отображаемое имя сборки.</param>
		/// <param name="typeName">Полное имя типа.</param>
		/// <returns>Полное имя типа, дополненное отображаемым именем сборки.</returns>
		// Token: 0x06004C08 RID: 19464 RVA: 0x000F1AD2 File Offset: 0x000EFCD2
		public static string CreateQualifiedName(string assemblyName, string typeName)
		{
			return typeName + ", " + assemblyName;
		}

		/// <summary>Возвращает текущую загруженную сборку, в которой определен указанный тип.</summary>
		/// <param name="type">Объект, представляющий тип в сборке, которая будет возвращена.</param>
		/// <returns>Сборка, в которой определен указанный тип.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004C09 RID: 19465 RVA: 0x000F1AE0 File Offset: 0x000EFCE0
		public static Assembly GetAssembly(Type type)
		{
			if (type != null)
			{
				return type.Assembly;
			}
			throw new ArgumentNullException("type");
		}

		/// <summary>Получает процесс, исполняемый в домене приложения по умолчанию. В других доменах приложений это первый исполняемый процесс, который был выполнен методом <see cref="M:System.AppDomain.ExecuteAssembly(System.String)" />.</summary>
		/// <returns>Сборка, представляющая собой исполняемый файл процесса в домене приложения по умолчанию или первый исполняемый файл, выполненный методом <see cref="M:System.AppDomain.ExecuteAssembly(System.String)" />. Может возвратить значение <see langword="null" /> при вызове из неуправляемого кода.</returns>
		// Token: 0x06004C0A RID: 19466
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Assembly GetEntryAssembly();

		// Token: 0x06004C0B RID: 19467 RVA: 0x000F1AFC File Offset: 0x000EFCFC
		internal Assembly GetSatelliteAssembly(CultureInfo culture, Version version, bool throwOnError, ref StackCrawlMark stackMark)
		{
			if (culture == null)
			{
				throw new ArgumentNullException("culture");
			}
			string name = this.GetSimpleName() + ".resources";
			return this.InternalGetSatelliteAssembly(name, culture, version, true, ref stackMark);
		}

		// Token: 0x06004C0C RID: 19468 RVA: 0x000F1B34 File Offset: 0x000EFD34
		internal RuntimeAssembly InternalGetSatelliteAssembly(string name, CultureInfo culture, Version version, bool throwOnFileNotFound, ref StackCrawlMark stackMark)
		{
			AssemblyName assemblyName = new AssemblyName();
			assemblyName.SetPublicKey(this.GetPublicKey());
			assemblyName.Flags = (this.GetFlags() | AssemblyNameFlags.PublicKey);
			if (version == null)
			{
				assemblyName.Version = this.GetVersion();
			}
			else
			{
				assemblyName.Version = version;
			}
			assemblyName.CultureInfo = culture;
			assemblyName.Name = name;
			try
			{
				Assembly assembly = AppDomain.CurrentDomain.LoadSatellite(assemblyName, false, ref stackMark);
				if (assembly != null)
				{
					return (RuntimeAssembly)assembly;
				}
			}
			catch (FileNotFoundException)
			{
			}
			if (string.IsNullOrEmpty(this.Location))
			{
				return null;
			}
			string text = Path.Combine(Path.GetDirectoryName(this.Location), Path.Combine(culture.Name, assemblyName.Name + ".dll"));
			RuntimeAssembly result;
			try
			{
				result = (RuntimeAssembly)Assembly.LoadFrom(text, false, ref stackMark);
			}
			catch
			{
				if (throwOnFileNotFound || File.Exists(text))
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		/// <summary>Возвращает тип текущего экземпляра.</summary>
		/// <returns>Объект, представляющий тип <see cref="T:System.Reflection.Assembly" />.</returns>
		// Token: 0x06004C0D RID: 19469 RVA: 0x00047210 File Offset: 0x00045410
		Type _Assembly.GetType()
		{
			return base.GetType();
		}

		// Token: 0x06004C0E RID: 19470
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Assembly LoadFrom(string assemblyFile, bool refOnly, ref StackCrawlMark stackMark);

		// Token: 0x06004C0F RID: 19471
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Assembly LoadFile_internal(string assemblyFile, ref StackCrawlMark stackMark);

		/// <summary>Загружает сборку с заданным именем или путем.</summary>
		/// <param name="assemblyFile">Имя файла, содержащего манифест сборки, либо путь к нему.</param>
		/// <returns>Загруженная сборка.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assemblyFile" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл <paramref name="assemblyFile" /> не найден, или модуль, который вы пытаетесь загрузить, не указывает расширение имени файла.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Не удалось загрузить файл, который был найден.
		///
		/// или -
		///
		/// Возможность выполнения кода в удаленных сборках отключена. См. элемент &lt;loadFromRemoteSources&gt;.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyFile" /> не является допустимой сборкой. Например, это 32-разрядная сборка в 64-разрядном процессе. Дополнительные сведения см. в разделе исключений.  
		///
		/// или - 
		/// В настоящий момент загружена среда CLR версии 2.0 или более поздней версии. Сборка <paramref name="assemblyFile" /> была скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.Security.SecurityException">База кода, которая не начинается с "file://", была указана без требуемого <see cref="T:System.Net.WebPermission" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="assemblyFile" /> представляет собой пустую строку ("").</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Длина имени сборки превышает максимальную длину, определенную в системе.</exception>
		// Token: 0x06004C10 RID: 19472 RVA: 0x000F1C34 File Offset: 0x000EFE34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Assembly LoadFrom(string assemblyFile)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return Assembly.LoadFrom(assemblyFile, false, ref stackCrawlMark);
		}

		/// <summary>Загружает сборку, заданную именем файла или путем к этому файлу и предоставленным свидетельством безопасности.</summary>
		/// <param name="assemblyFile">Имя файла, содержащего манифест сборки, либо путь к нему.</param>
		/// <param name="securityEvidence">Свидетельство для загрузки сборки.</param>
		/// <returns>Загруженная сборка.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assemblyFile" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл <paramref name="assemblyFile" /> не найден, или модуль, который вы пытаетесь загрузить, не указывает расширение имени файла.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Не удалось загрузить файл, который был найден.  
		///
		/// или - 
		/// Параметр <paramref name="securityEvidence" /> не является неоднозначным и определяется как недопустимый.
		///
		/// или -
		///
		///
		/// Возможность выполнения кода в удаленных сборках отключена. См. элемент &lt;loadFromRemoteSources&gt;.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyFile" /> не является допустимой сборкой. Например, это 32-разрядная сборка в 64-разрядном процессе. Дополнительные сведения см. в разделе исключений.  
		///
		/// или - 
		/// В настоящий момент загружена среда CLR версии 2.0 или более поздней версии. Сборка <paramref name="assemblyFile" /> была скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.Security.SecurityException">База кода, которая не начинается с "file://", была указана без требуемого <see cref="T:System.Net.WebPermission" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="assemblyFile" /> представляет собой пустую строку ("").</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Длина имени сборки превышает максимальную длину, определенную в системе.</exception>
		// Token: 0x06004C11 RID: 19473 RVA: 0x000F1C4C File Offset: 0x000EFE4C
		[Obsolete]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Assembly LoadFrom(string assemblyFile, Evidence securityEvidence)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			Assembly assembly = Assembly.LoadFrom(assemblyFile, false, ref stackCrawlMark);
			if (assembly != null && securityEvidence != null)
			{
				assembly.Evidence.Merge(securityEvidence);
			}
			return assembly;
		}

		/// <summary>Загружает сборку с заданным именем файла сборки или путем, свидетельством безопасности, хэш-значением и хэш-алгоритмом.</summary>
		/// <param name="assemblyFile">Имя файла, содержащего манифест сборки, либо путь к нему.</param>
		/// <param name="securityEvidence">Свидетельство для загрузки сборки.</param>
		/// <param name="hashValue">Значение вычисленного хэш-кода.</param>
		/// <param name="hashAlgorithm">Алгоритм хэширования, используемый для хэширования файлов и генерации строгого имени.</param>
		/// <returns>Загруженная сборка.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assemblyFile" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл <paramref name="assemblyFile" /> не найден, или модуль, который вы пытаетесь загрузить, не указывает расширение имени файла.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Не удалось загрузить файл, который был найден.  
		///
		/// или - 
		/// Параметр <paramref name="securityEvidence" /> не является неоднозначным и определяется как недопустимый.
		///
		/// или -
		///
		///
		/// Возможность выполнения кода в удаленных сборках отключена. См. элемент &lt;loadFromRemoteSources&gt;.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyFile" /> не является допустимой сборкой. Например, это 32-разрядная сборка в 64-разрядном процессе. Дополнительные сведения см. в разделе исключений.  
		///
		/// или - 
		/// В настоящий момент загружена среда CLR версии 2.0 или более поздней версии. Сборка <paramref name="assemblyFile" /> была скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.Security.SecurityException">База кода, которая не начинается с "file://", была указана без требуемого <see cref="T:System.Net.WebPermission" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="assemblyFile" /> представляет собой пустую строку ("").</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Длина имени сборки превышает максимальную длину, определенную в системе.</exception>
		// Token: 0x06004C12 RID: 19474 RVA: 0x000479F8 File Offset: 0x00045BF8
		[Obsolete]
		[MonoTODO("This overload is not currently implemented")]
		public static Assembly LoadFrom(string assemblyFile, Evidence securityEvidence, byte[] hashValue, AssemblyHashAlgorithm hashAlgorithm)
		{
			throw new NotImplementedException();
		}

		/// <summary>Загружает сборку с заданным именем файла сборки или путем, хэш-значением и хэш-алгоритмом.</summary>
		/// <param name="assemblyFile">Имя файла, содержащего манифест сборки, либо путь к нему.</param>
		/// <param name="hashValue">Значение вычисленного хэш-кода.</param>
		/// <param name="hashAlgorithm">Алгоритм хэширования, используемый для хэширования файлов и генерации строгого имени.</param>
		/// <returns>Загруженная сборка.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assemblyFile" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Параметр <paramref name="assemblyFile" /> не найден, или модуль, который вы пытаетесь загрузить, не указывает расширение имени файла.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Не удалось загрузить файл, который был найден.
		///
		/// или -
		///
		/// Возможность выполнения кода в удаленных сборках отключена. См. элемент &lt;loadFromRemoteSources&gt;.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyFile" /> не является допустимой сборкой. Например, это 32-разрядная сборка в 64-разрядном процессе. Дополнительные сведения см. в разделе исключений.  
		///
		/// или - 
		/// Сборка <paramref name="assemblyFile" /> была скомпилирована в более поздней версии среды CLR, чем версия, загруженная в текущий момент.</exception>
		/// <exception cref="T:System.Security.SecurityException">База кода, которая не начинается с "file://", была указана без требуемого разрешения <see cref="T:System.Net.WebPermission" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="assemblyFile" /> представляет собой пустую строку ("").</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Длина имени сборки превышает максимальную длину, определенную в системе.</exception>
		// Token: 0x06004C13 RID: 19475 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public static Assembly LoadFrom(string assemblyFile, byte[] hashValue, AssemblyHashAlgorithm hashAlgorithm)
		{
			throw new NotImplementedException();
		}

		/// <summary>Загружает сборку в контекст, из которого производится загрузка, обходя некоторые проверки безопасности.</summary>
		/// <param name="assemblyFile">Имя файла, содержащего манифест сборки, либо путь к нему.</param>
		/// <returns>Загруженная сборка.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assemblyFile" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл <paramref name="assemblyFile" /> не найден, или модуль, который вы пытаетесь загрузить, не указывает расширение имени файла.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Не удалось загрузить файл, который был найден.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyFile" /> не является допустимой сборкой.  
		///
		/// или - 
		/// Сборка <paramref name="assemblyFile" /> была скомпилирована в более поздней версии среды CLR, чем версия, загруженная в текущий момент.</exception>
		/// <exception cref="T:System.Security.SecurityException">База кода, которая не начинается с "file://", была указана без требуемого разрешения <see cref="T:System.Net.WebPermission" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="assemblyFile" /> представляет собой пустую строку ("").</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Длина имени сборки превышает максимальную длину, определенную в системе.</exception>
		// Token: 0x06004C14 RID: 19476 RVA: 0x000F1C80 File Offset: 0x000EFE80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Assembly UnsafeLoadFrom(string assemblyFile)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return Assembly.LoadFrom(assemblyFile, false, ref stackCrawlMark);
		}

		/// <summary>Загружает сборку с заданным путем в домен вызывающего объекта с использованием переданного свидетельства.</summary>
		/// <param name="path">Полный путь к файлу сборки.</param>
		/// <param name="securityEvidence">Свидетельство для загрузки сборки.</param>
		/// <returns>Загруженная сборка.</returns>
		/// <exception cref="T:System.ArgumentException">Аргумент <paramref name="path" /> не является абсолютным путем.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Параметр <paramref name="path" /> представляет собой пустую строку ("") или не существует.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Не удалось загрузить файл, который был найден.
		///
		/// или -
		///
		/// Возможность выполнения кода в удаленных сборках отключена. См. элемент &lt;loadFromRemoteSources&gt;.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="path" /> не является допустимой сборкой.  
		///
		/// или - 
		/// В настоящий момент загружена среда CLR версии 2.0 или более поздней версии. Сборка <paramref name="path" /> была скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="securityEvidence" /> не является <see langword="null" />. По умолчанию устаревшая политика CAS не включена в .NET Framework 4; если она не включена, параметр <paramref name="securityEvidence" /> должен иметь значение <see langword="null" />.</exception>
		// Token: 0x06004C15 RID: 19477 RVA: 0x000F1C98 File Offset: 0x000EFE98
		[Obsolete]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Assembly LoadFile(string path, Evidence securityEvidence)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (path == string.Empty)
			{
				throw new ArgumentException("Path can't be empty", "path");
			}
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			Assembly assembly = Assembly.LoadFile_internal(path, ref stackCrawlMark);
			if (assembly != null && securityEvidence != null)
			{
				throw new NotImplementedException();
			}
			return assembly;
		}

		/// <summary>Загружает содержимое файла сборки, находящегося по указанному пути.</summary>
		/// <param name="path">Полный путь к загружаемому файлу.</param>
		/// <returns>Загруженная сборка.</returns>
		/// <exception cref="T:System.ArgumentException">Аргумент <paramref name="path" /> не является абсолютным путем.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Не удалось загрузить файл, который был найден.
		///
		/// или -
		///
		/// Возможность выполнения кода в удаленных сборках отключена. См. элемент &lt;loadFromRemoteSources&gt;.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Параметр <paramref name="path" /> представляет собой пустую строку ("") или не существует.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="path" /> не является допустимой сборкой.  
		///
		/// или - 
		/// В настоящий момент загружена среда CLR версии 2.0 или более поздней версии. Сборка <paramref name="path" /> была скомпилирована в более поздней версии.</exception>
		// Token: 0x06004C16 RID: 19478 RVA: 0x000F1CEC File Offset: 0x000EFEEC
		public static Assembly LoadFile(string path)
		{
			return Assembly.LoadFile(path, null);
		}

		/// <summary>Загружает сборку, заданную длинной формой ее имени.</summary>
		/// <param name="assemblyString">Длинная форма имени сборки.</param>
		/// <returns>Загруженная сборка.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assemblyString" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="assemblyString" /> представляет собой строку нулевой длины.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="assemblyString" /> не найден.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Не удалось загрузить файл, который был найден.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyString" /> не является допустимой сборкой.  
		///
		/// или - 
		/// В настоящий момент загружена среда CLR версии 2.0 или более поздней версии. Сборка <paramref name="assemblyString" /> была скомпилирована в более поздней версии.</exception>
		// Token: 0x06004C17 RID: 19479 RVA: 0x000F1CF5 File Offset: 0x000EFEF5
		public static Assembly Load(string assemblyString)
		{
			return AppDomain.CurrentDomain.Load(assemblyString);
		}

		/// <summary>Загружает сборку с заданным отображаемым именем. Сборка загружается в домен вызывающего объекта с использованием переданного основания.</summary>
		/// <param name="assemblyString">Отображаемое имя сборки.</param>
		/// <param name="assemblySecurity">Свидетельство для загрузки сборки.</param>
		/// <returns>Загруженная сборка.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assemblyString" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="assemblyString" /> не найден.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyString" /> не является допустимым именем сборки.  
		///
		/// или - 
		/// В настоящий момент загружена среда CLR версии 2.0 или более поздней версии. Сборка <paramref name="assemblyString" /> была скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Не удалось загрузить файл, который был найден.  
		///
		/// или - 
		/// Сборка или модуль был загружен дважды с двумя разными свидетельствами.</exception>
		// Token: 0x06004C18 RID: 19480 RVA: 0x000F1D02 File Offset: 0x000EFF02
		[Obsolete]
		public static Assembly Load(string assemblyString, Evidence assemblySecurity)
		{
			return AppDomain.CurrentDomain.Load(assemblyString, assemblySecurity);
		}

		/// <summary>Загружает сборку с заданным именем <see cref="T:System.Reflection.AssemblyName" />.</summary>
		/// <param name="assemblyRef">Объект, описывающий загружаемую сборку.</param>
		/// <returns>Загруженная сборка.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assemblyRef" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="assemblyRef" /> не найден.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Вместо этого в .NET для приложений Магазина Windows или в переносимой библиотеке классов перехватите исключение базового класса <see cref="T:System.IO.IOException" />.  
		///
		///
		///
		///
		///  Не удалось загрузить файл, который был найден.
		///
		/// или -
		///
		/// <paramref name="assemblyRef" /> указывает на удаленную сборку, но возможность выполнения кода в удаленных сборках отключена. См. элемент &lt;loadFromRemoteSources&gt;.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyRef" /> не является допустимой сборкой. - или - 
		/// В настоящий момент загружена среда CLR версии 2.0 или более поздней версии. Сборка <paramref name="assemblyRef" /> была скомпилирована в более поздней версии.</exception>
		// Token: 0x06004C19 RID: 19481 RVA: 0x000F1D10 File Offset: 0x000EFF10
		public static Assembly Load(AssemblyName assemblyRef)
		{
			return AppDomain.CurrentDomain.Load(assemblyRef);
		}

		/// <summary>Загружает сборку с заданным именем <see cref="T:System.Reflection.AssemblyName" />. Сборка загружена в домен вызывающего объекта с использованием переданного свидетельства.</summary>
		/// <param name="assemblyRef">Объект, описывающий загружаемую сборку.</param>
		/// <param name="assemblySecurity">Свидетельство для загрузки сборки.</param>
		/// <returns>Загруженная сборка.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assemblyRef" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="assemblyRef" /> не найден.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyRef" /> не является допустимым именем сборки.  
		///
		/// или - 
		/// В настоящий момент загружена среда CLR версии 2.0 или более поздней версии. Сборка <paramref name="assemblyRef" /> была скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.
		///
		/// или -
		///
		/// <paramref name="assemblyRef" /> указывает на удаленную сборку, но возможность выполнения кода в удаленных сборках отключена. См. элемент &lt;loadFromRemoteSources&gt;.</exception>
		// Token: 0x06004C1A RID: 19482 RVA: 0x000F1D1D File Offset: 0x000EFF1D
		[Obsolete]
		public static Assembly Load(AssemblyName assemblyRef, Evidence assemblySecurity)
		{
			return AppDomain.CurrentDomain.Load(assemblyRef, assemblySecurity);
		}

		/// <summary>Загружает сборку с образом в формате COFF, содержащим порожденную сборку. Сборка загружается в домен приложения вызывающего объекта.</summary>
		/// <param name="rawAssembly">Массив байтов, который является образом в формате COFF, содержащим созданную сборку.</param>
		/// <returns>Загруженная сборка.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rawAssembly" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="rawAssembly" /> не является допустимым именем сборки.  
		///
		/// или - 
		/// В настоящий момент загружена среда CLR версии 2.0 или более поздней версии. Сборка <paramref name="rawAssembly" /> была скомпилирована в более поздней версии.</exception>
		// Token: 0x06004C1B RID: 19483 RVA: 0x000F1D2B File Offset: 0x000EFF2B
		public static Assembly Load(byte[] rawAssembly)
		{
			return AppDomain.CurrentDomain.Load(rawAssembly);
		}

		/// <summary>Загружает сборку с образом в формате COFF, содержащим выпущенную сборку и (дополнительно) символы для сборки. Сборка загружается в домен приложения вызывающего объекта.</summary>
		/// <param name="rawAssembly">Массив байтов, который является образом в формате COFF, содержащим созданную сборку.</param>
		/// <param name="rawSymbolStore">Массив байтов, содержащий необработанные байты, которые представляют символы для сборки.</param>
		/// <returns>Загруженная сборка.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rawAssembly" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="rawAssembly" /> не является допустимым именем сборки.  
		///
		/// или - 
		/// В настоящий момент загружена среда CLR версии 2.0 или более поздней версии. Сборка <paramref name="rawAssembly" /> была скомпилирована в более поздней версии.</exception>
		// Token: 0x06004C1C RID: 19484 RVA: 0x000F1D38 File Offset: 0x000EFF38
		public static Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore)
		{
			return AppDomain.CurrentDomain.Load(rawAssembly, rawSymbolStore);
		}

		/// <summary>Загружает сборку с образом в формате COFF, содержащим выпущенную сборку и (необязательно) символы и свидетельство для сборки. Сборка загружается в домен приложения вызывающего объекта.</summary>
		/// <param name="rawAssembly">Массив байтов, который является образом в формате COFF, содержащим созданную сборку.</param>
		/// <param name="rawSymbolStore">Массив байтов, содержащий необработанные байты, которые представляют символы для сборки.</param>
		/// <param name="securityEvidence">Свидетельство для загрузки сборки.</param>
		/// <returns>Загруженная сборка.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rawAssembly" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="rawAssembly" /> не является допустимым именем сборки.  
		///
		/// или - 
		/// В настоящий момент загружена среда CLR версии 2.0 или более поздней версии. Сборка <paramref name="rawAssembly" /> была скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="securityEvidence" /> не является <see langword="null" />.  По умолчанию устаревшая политика CAS не включена в .NET Framework 4; если она не включена, параметр <paramref name="securityEvidence" /> должен иметь значение <see langword="null" />.</exception>
		// Token: 0x06004C1D RID: 19485 RVA: 0x000F1D46 File Offset: 0x000EFF46
		[Obsolete]
		public static Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, Evidence securityEvidence)
		{
			return AppDomain.CurrentDomain.Load(rawAssembly, rawSymbolStore, securityEvidence);
		}

		/// <summary>Загружает сборку с образом в формате COFF, содержащим выпущенную сборку и необязательно содержащим символы и задающим источник для контекста безопасности. Сборка загружается в домен приложения вызывающего объекта.</summary>
		/// <param name="rawAssembly">Массив байтов, который является образом в формате COFF, содержащим созданную сборку.</param>
		/// <param name="rawSymbolStore">Массив байтов, содержащий необработанные байты, которые представляют символы для сборки.</param>
		/// <param name="securityContextSource">Источник контекста безопасности.</param>
		/// <returns>Загруженная сборка.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rawAssembly" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="rawAssembly" /> не является допустимым именем сборки.  
		///
		/// или - 
		/// Сборка <paramref name="rawAssembly" /> была скомпилирована в более поздней версии среды CLR, чем версия, загруженная в текущий момент.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="securityContextSource" /> не является одним из значений перечисления.</exception>
		// Token: 0x06004C1E RID: 19486 RVA: 0x000F1D38 File Offset: 0x000EFF38
		[MonoLimitation("Argument securityContextSource is ignored")]
		public static Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, SecurityContextSource securityContextSource)
		{
			return AppDomain.CurrentDomain.Load(rawAssembly, rawSymbolStore);
		}

		/// <summary>Загружает сборку из образа в формате COFF, содержащего порожденную сборку. Сборка загружается в контекст, предназначенный только для отражения, который относится к домену приложения вызывающего объекта.</summary>
		/// <param name="rawAssembly">Массив байтов, который является образом в формате COFF, содержащим созданную сборку.</param>
		/// <returns>Загруженная сборка.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rawAssembly" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="rawAssembly" /> не является допустимым именем сборки.  
		///
		/// или - 
		/// В настоящий момент загружена среда CLR версии 2.0 или более поздней версии. Сборка <paramref name="rawAssembly" /> была скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Не удается загрузить <paramref name="rawAssembly" />.</exception>
		// Token: 0x06004C1F RID: 19487 RVA: 0x000F1D55 File Offset: 0x000EFF55
		public static Assembly ReflectionOnlyLoad(byte[] rawAssembly)
		{
			return AppDomain.CurrentDomain.Load(rawAssembly, null, null, true);
		}

		/// <summary>Загружает сборку с заданным отображаемым именем в контекст, предназначенный только для отражения.</summary>
		/// <param name="assemblyString">Отображаемое имя сборки, возвращаемое свойством <see cref="P:System.Reflection.AssemblyName.FullName" />.</param>
		/// <returns>Загруженная сборка.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assemblyString" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="assemblyString" /> является пустой строкой ("").</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="assemblyString" /> не найден.</exception>
		/// <exception cref="T:System.IO.FileLoadException">
		///   <paramref name="assemblyString" /> найдена, но не может быть загружена.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyString" /> не является допустимой сборкой.  
		///
		/// или - 
		/// В настоящий момент загружена среда CLR версии 2.0 или более поздней версии. Сборка <paramref name="assemblyString" /> была скомпилирована в более поздней версии.</exception>
		// Token: 0x06004C20 RID: 19488 RVA: 0x000F1D68 File Offset: 0x000EFF68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Assembly ReflectionOnlyLoad(string assemblyString)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return AppDomain.CurrentDomain.Load(assemblyString, null, true, ref stackCrawlMark);
		}

		/// <summary>Загружает сборку с заданным путем в контекст, предназначенный только для отражения.</summary>
		/// <param name="assemblyFile">Путь к файлу, содержащему манифест сборки.</param>
		/// <returns>Загруженная сборка.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assemblyFile" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл <paramref name="assemblyFile" /> не найден, или модуль, который вы пытаетесь загрузить, не указывает расширение имени файла.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Файл <paramref name="assemblyFile" /> найден, но его не удается загрузить.</exception>
		/// <exception cref="T:System.BadImageFormatException">Файл <paramref name="assemblyFile" /> не является допустимой сборкой.  
		///
		/// или - 
		/// В настоящий момент загружена среда CLR версии 2.0 или более поздней версии. Сборка <paramref name="assemblyFile" /> была скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.Security.SecurityException">База кода, которая не начинается с "file://", была указана без требуемого разрешения <see cref="T:System.Net.WebPermission" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Длина имени сборки превышает максимальную длину, определенную в системе.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="assemblyFile" /> является пустой строкой ("").</exception>
		// Token: 0x06004C21 RID: 19489 RVA: 0x000F1D88 File Offset: 0x000EFF88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Assembly ReflectionOnlyLoadFrom(string assemblyFile)
		{
			if (assemblyFile == null)
			{
				throw new ArgumentNullException("assemblyFile");
			}
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return Assembly.LoadFrom(assemblyFile, true, ref stackCrawlMark);
		}

		/// <summary>Загружает сборку из каталога приложения или из глобального кэша сборок с использованием частичного имени.</summary>
		/// <param name="partialName">Отображаемое имя сборки.</param>
		/// <returns>Загруженная сборка. Если значение <paramref name="partialName" /> не найдено, этот метод возвращает значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="partialName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyFile" /> не является допустимой сборкой.  
		///
		/// или - 
		/// В настоящий момент загружена среда CLR версии 2.0 или более поздней версии. Сборка <paramref name="partialName" /> была скомпилирована в более поздней версии.</exception>
		// Token: 0x06004C22 RID: 19490 RVA: 0x000F1DAE File Offset: 0x000EFFAE
		[Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
		public static Assembly LoadWithPartialName(string partialName)
		{
			return Assembly.LoadWithPartialName(partialName, null);
		}

		/// <summary>Загружает модуль, внутренний для этой сборки, с образом в формате COFF, содержащим включенный модуль или файл ресурсов.</summary>
		/// <param name="moduleName">Имя модуля. Эта строка должна соответствовать имени файла в манифесте этой сборки.</param>
		/// <param name="rawModule">Массив байтов, который является COFF-образом, содержащим передаваемый модуль или ресурс.</param>
		/// <returns>Загруженный модуль.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="moduleName" /> или <paramref name="rawModule" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="moduleName" /> не соответствует записи файла в манифесте этой сборки.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="rawModule" /> не является допустимым модулем.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Не удалось загрузить файл, который был найден.</exception>
		// Token: 0x06004C23 RID: 19491 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO("Not implemented")]
		public Module LoadModule(string moduleName, byte[] rawModule)
		{
			throw new NotImplementedException();
		}

		/// <summary>Загружает модуль, внутренний для этой сборки, с образом в формате COFF, содержащим включенный модуль или файл ресурсов. Также загружаются необработанные байты, представляющие собой символы для модуля.</summary>
		/// <param name="moduleName">Имя модуля. Эта строка должна соответствовать имени файла в манифесте этой сборки.</param>
		/// <param name="rawModule">Массив байтов, который является COFF-образом, содержащим передаваемый модуль или ресурс.</param>
		/// <param name="rawSymbolStore">Массив байтов, содержащий необработанные байты, представляющие собой символы для модуля. Для файла ресурсов должно быть задано значение <see langword="null" />.</param>
		/// <returns>Загруженный модуль.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="moduleName" /> или <paramref name="rawModule" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="moduleName" /> не соответствует записи файла в манифесте этой сборки.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="rawModule" /> не является допустимым модулем.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Не удалось загрузить файл, который был найден.</exception>
		// Token: 0x06004C24 RID: 19492 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO("Not implemented")]
		public virtual Module LoadModule(string moduleName, byte[] rawModule, byte[] rawSymbolStore)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06004C25 RID: 19493
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Assembly load_with_partial_name(string name, Evidence e);

		/// <summary>Загружает сборку из каталога приложения или из глобального кэша сборок с использованием частичного имени. Сборка загружена в домен вызывающего объекта с использованием переданного свидетельства.</summary>
		/// <param name="partialName">Отображаемое имя сборки.</param>
		/// <param name="securityEvidence">Свидетельство для загрузки сборки.</param>
		/// <returns>Загруженная сборка. Если значение <paramref name="partialName" /> не найдено, этот метод возвращает значение <see langword="null" />.</returns>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными наборами свидетельств.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="partialName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyFile" /> не является допустимой сборкой.  
		///
		/// или - 
		/// В настоящий момент загружена среда CLR версии 2.0 или более поздней версии. Сборка <paramref name="partialName" /> была скомпилирована в более поздней версии.</exception>
		// Token: 0x06004C26 RID: 19494 RVA: 0x000F1DB7 File Offset: 0x000EFFB7
		[Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
		public static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence)
		{
			return Assembly.LoadWithPartialName(partialName, securityEvidence, true);
		}

		// Token: 0x06004C27 RID: 19495 RVA: 0x000F1DC1 File Offset: 0x000EFFC1
		internal static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence, bool oldBehavior)
		{
			if (!oldBehavior)
			{
				throw new NotImplementedException();
			}
			if (partialName == null)
			{
				throw new NullReferenceException();
			}
			return Assembly.load_with_partial_name(partialName, securityEvidence);
		}

		/// <summary>С помощью поиска с учетом регистра находит заданный тип в этой сборке и создает его экземпляр, используя абстрактный метод.</summary>
		/// <param name="typeName">
		///   <see cref="P:System.Type.FullName" /> искомого типа.</param>
		/// <returns>Экземпляр указанного типа, созданный с использованием конструктора по умолчанию; или <see langword="null" />, если <paramref name="typeName" /> не найден. Тип разрешается с использованием связывателя по умолчанию, не задавая языка и региональных параметров, а также атрибутов активации, при этом для объекта <see cref="T:System.Reflection.BindingFlags" /> задано значение <see langword="Public" /> или <see langword="Instance" />.</returns>
		/// <exception cref="T:System.ArgumentException">Значение <paramref name="typeName" /> является пустой строкой ("") или строкой, начинающейся с нуль-символа.  
		///
		/// или - 
		/// Текущая сборка была загружена в контекст только для отражения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="typeName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Соответствующий конструктор не найден.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Для <paramref name="typeName" /> требуется зависимая сборка, которую не удалось найти.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Для <paramref name="typeName" /> требуется зависимая сборка, которая была найдена, но ее не удалось загрузить.  
		///
		/// или - 
		/// Текущая сборка была загружена в контекст только для отражения, а для <paramref name="typeName" /> требуется зависимая сборка, которая не была предварительно загружена.</exception>
		/// <exception cref="T:System.BadImageFormatException">Для <paramref name="typeName" /> требуется зависимая сборка, однако файл не является допустимой сборкой.  
		///
		/// или - 
		/// Для <paramref name="typeName" /> требуется зависимая сборка, которая была скомпилирована для версии среды выполнения более поздней, чем текущая загруженная версия.</exception>
		// Token: 0x06004C28 RID: 19496 RVA: 0x000F1DDC File Offset: 0x000EFFDC
		public object CreateInstance(string typeName)
		{
			return this.CreateInstance(typeName, false);
		}

		/// <summary>При помощи необязательного поиска с учетом регистра находит заданный тип в этой сборке и создает его экземпляр, используя абстрактный метод.</summary>
		/// <param name="typeName">
		///   <see cref="P:System.Type.FullName" /> искомого типа.</param>
		/// <param name="ignoreCase">Значение <see langword="true" />, чтобы игнорировать регистр имени типа, в обратном случае — значение <see langword="false" />.</param>
		/// <returns>Экземпляр указанного типа, созданный с использованием конструктора по умолчанию; или <see langword="null" />, если <paramref name="typeName" /> не найден. Тип разрешается с использованием связывателя по умолчанию, не задавая языка и региональных параметров, а также атрибутов активации, при этом для объекта <see cref="T:System.Reflection.BindingFlags" /> задано значение <see langword="Public" /> или <see langword="Instance" />.</returns>
		/// <exception cref="T:System.ArgumentException">Значение <paramref name="typeName" /> является пустой строкой ("") или строкой, начинающейся с нуль-символа.  
		///
		/// или - 
		/// Текущая сборка была загружена в контекст только для отражения.</exception>
		/// <exception cref="T:System.MissingMethodException">Соответствующий конструктор не найден.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="typeName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Для <paramref name="typeName" /> требуется зависимая сборка, которую не удается найти.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Для <paramref name="typeName" /> требуется зависимая сборка, которая была найдена, но ее не удалось загрузить.  
		///
		/// или - 
		/// Текущая сборка была загружена в контекст только для отражения, а для <paramref name="typeName" /> требуется зависимая сборка, которая не была предварительно загружена.</exception>
		/// <exception cref="T:System.BadImageFormatException">Для <paramref name="typeName" /> требуется зависимая сборка, однако файл не является допустимой сборкой.  
		///
		/// или - 
		/// Для <paramref name="typeName" /> требуется зависимая сборка, которая была скомпилирована для версии среды выполнения более поздней, чем текущая загруженная версия.</exception>
		// Token: 0x06004C29 RID: 19497 RVA: 0x000F1DE8 File Offset: 0x000EFFE8
		public object CreateInstance(string typeName, bool ignoreCase)
		{
			Type type = this.GetType(typeName, false, ignoreCase);
			if (type == null)
			{
				return null;
			}
			object result;
			try
			{
				result = Activator.CreateInstance(type);
			}
			catch (InvalidOperationException)
			{
				throw new ArgumentException("It is illegal to invoke a method on a Type loaded via ReflectionOnly methods.");
			}
			return result;
		}

		/// <summary>Находит в сборке указанный тип и создает его экземпляр с использованием системного активатора при помощи необязательного поиска с учетом регистра и с заданными аргументами, культурой, а также атрибутами привязки и активации.</summary>
		/// <param name="typeName">
		///   <see cref="P:System.Type.FullName" /> искомого типа.</param>
		/// <param name="ignoreCase">Значение <see langword="true" />, чтобы игнорировать регистр имени типа, в обратном случае — значение <see langword="false" />.</param>
		/// <param name="bindingAttr">Битовая маска, влияющая на способ выполнения поиска. Значение является сочетанием одноразрядных флагов из <see cref="T:System.Reflection.BindingFlags" />.</param>
		/// <param name="binder">Объект, позволяющий осуществлять привязку, приведение типов аргументов, вызов элементов, а также поиск объектов <see langword="MemberInfo" /> с помощью отражения. Если значение параметра <paramref name="binder" /> равно <see langword="null" />, используется связыватель по умолчанию.</param>
		/// <param name="args">Массив, содержащий аргументы, передаваемые конструктору. Этот массив аргументов должен по числу, порядку и типу аргументов соответствовать параметрам вызываемого конструктора. Если нужен конструктор по умолчанию, <paramref name="args" /> должен быть пустым массивом или <see langword="null" />.</param>
		/// <param name="culture">Экземпляр объекта <see langword="CultureInfo" />, используемого для управления приведением типов. Если значение этого объекта — <see langword="null" />, для текущего потока используется <see langword="CultureInfo" />. (Например, необходимо преобразовывать объект <see langword="String" />, представляющий 1000, в значение <see langword="Double" />, поскольку при разных языках и региональных параметрах 1000 представляется по-разному.)</param>
		/// <param name="activationAttributes">Массив, состоящий из одного или нескольких атрибутов, которые могут участвовать в активации. Обычно это массив, содержащий один объект <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />, определяющий URL-адрес, необходимый для активации удаленного объекта.    Этот параметр связан с объектами, активируемыми клиентом. Активация клиентом — это устаревшая технология, которая сохраняется с целью обеспечения обратной совместимости; ее не рекомендуется использовать для разработки новых приложений. Сейчас в распределенных приложениях следует использовать Windows Communication Foundation.</param>
		/// <returns>Экземпляр указанного типа или <see langword="null" />, если <paramref name="typeName" /> не найден. Предоставленные аргументы используются для разрешения типа и привязки конструктора, который используется для создания экземпляра.</returns>
		/// <exception cref="T:System.ArgumentException">Значение <paramref name="typeName" /> является пустой строкой ("") или строкой, начинающейся с нуль-символа.  
		///
		/// или - 
		/// Текущая сборка была загружена в контекст только для отражения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="typeName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Соответствующий конструктор не найден.</exception>
		/// <exception cref="T:System.NotSupportedException">Непустой массив атрибутов активации передан в тип, который не является производным от <see cref="T:System.MarshalByRefObject" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Для <paramref name="typeName" /> требуется зависимая сборка, которую не удалось найти.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Для <paramref name="typeName" /> требуется зависимая сборка, которая была найдена, но ее не удалось загрузить.  
		///
		/// или - 
		/// Текущая сборка была загружена в контекст только для отражения, а для <paramref name="typeName" /> требуется зависимая сборка, которая не была предварительно загружена.</exception>
		/// <exception cref="T:System.BadImageFormatException">Для <paramref name="typeName" /> требуется зависимая сборка, однако файл не является допустимой сборкой.  
		///
		/// или - 
		/// Для <paramref name="typeName" /> требуется зависимая сборка, которая была скомпилирована для версии среды выполнения более поздней, чем текущая загруженная версия.</exception>
		// Token: 0x06004C2A RID: 19498 RVA: 0x000F1E34 File Offset: 0x000F0034
		public virtual object CreateInstance(string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
		{
			Type type = this.GetType(typeName, false, ignoreCase);
			if (type == null)
			{
				return null;
			}
			object result;
			try
			{
				result = Activator.CreateInstance(type, bindingAttr, binder, args, culture, activationAttributes);
			}
			catch (InvalidOperationException)
			{
				throw new ArgumentException("It is illegal to invoke a method on a Type loaded via ReflectionOnly methods.");
			}
			return result;
		}

		/// <summary>Получает все загруженные модули, являющиеся частью этой сборки.</summary>
		/// <returns>Массив модулей.</returns>
		// Token: 0x06004C2B RID: 19499 RVA: 0x000F1E88 File Offset: 0x000F0088
		public Module[] GetLoadedModules()
		{
			return this.GetLoadedModules(false);
		}

		/// <summary>Получает все модули, являющиеся частью этой сборки.</summary>
		/// <returns>Массив модулей.</returns>
		/// <exception cref="T:System.IO.FileNotFoundException">В загружаемом модуле не указано расширение имени файла.</exception>
		// Token: 0x06004C2C RID: 19500 RVA: 0x000F1E91 File Offset: 0x000F0091
		public Module[] GetModules()
		{
			return this.GetModules(false);
		}

		// Token: 0x06004C2D RID: 19501 RVA: 0x000479F8 File Offset: 0x00045BF8
		internal virtual Module[] GetModulesInternal()
		{
			throw new NotImplementedException();
		}

		/// <summary>Получает сборку, которая содержит выполняемый в текущий момент код.</summary>
		/// <returns>Сборка, содержащая выполняемый в текущий момент код.</returns>
		// Token: 0x06004C2E RID: 19502
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Assembly GetExecutingAssembly();

		/// <summary>Возвращает объект <see cref="T:System.Reflection.Assembly" /> метода, вызвавшего текущий выполняемый метод.</summary>
		/// <returns>Объект <see langword="Assembly" /> метода, вызвавшего выполняющийся в текущий момент метод.</returns>
		// Token: 0x06004C2F RID: 19503
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Assembly GetCallingAssembly();

		// Token: 0x06004C30 RID: 19504
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern IntPtr InternalGetReferencedAssemblies(Assembly module);

		/// <summary>Возвращает имена всех ресурсов в этой сборке.</summary>
		/// <returns>Массив, который содержит имена всех ресурсов.</returns>
		// Token: 0x06004C31 RID: 19505 RVA: 0x000479F8 File Offset: 0x00045BF8
		public virtual string[] GetManifestResourceNames()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06004C32 RID: 19506 RVA: 0x000F1E9C File Offset: 0x000F009C
		internal unsafe static AssemblyName[] GetReferencedAssemblies(Assembly module)
		{
			AssemblyName[] result;
			using (SafeGPtrArrayHandle safeGPtrArrayHandle = new SafeGPtrArrayHandle(Assembly.InternalGetReferencedAssemblies(module)))
			{
				int length = safeGPtrArrayHandle.Length;
				try
				{
					AssemblyName[] array = new AssemblyName[length];
					for (int i = 0; i < length; i++)
					{
						AssemblyName assemblyName = new AssemblyName();
						MonoAssemblyName* native = (MonoAssemblyName*)((void*)safeGPtrArrayHandle[i]);
						assemblyName.FillName(native, null, true, false, true, true);
						array[i] = assemblyName;
					}
					result = array;
				}
				finally
				{
					for (int j = 0; j < length; j++)
					{
						MonoAssemblyName* name = (MonoAssemblyName*)((void*)safeGPtrArrayHandle[j]);
						RuntimeMarshal.FreeAssemblyName(ref *name, true);
					}
				}
			}
			return result;
		}

		/// <summary>Возвращает сведения о сохранении заданного ресурса.</summary>
		/// <param name="resourceName">Имя ресурса, зависящее от регистра.</param>
		/// <returns>Объект со сведениями о топологии ресурса или <see langword="null" />, если ресурс не найден.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="resourceName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="resourceName" /> представляет собой пустую строку ("").</exception>
		// Token: 0x06004C33 RID: 19507 RVA: 0x000479F8 File Offset: 0x00045BF8
		public virtual ManifestResourceInfo GetManifestResourceInfo(string resourceName)
		{
			throw new NotImplementedException();
		}

		/// <summary>Получает контекст хост-сайта, с которым была загружена сборка.</summary>
		/// <returns>Значение <see cref="T:System.Int64" />, которое указывает контекст узла, с которым была загружена сборка, при его наличии.</returns>
		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x06004C34 RID: 19508 RVA: 0x0005CD46 File Offset: 0x0005AF46
		[MonoTODO("Currently it always returns zero")]
		[ComVisible(false)]
		public virtual long HostContext
		{
			get
			{
				return 0L;
			}
		}

		// Token: 0x06004C35 RID: 19509 RVA: 0x000479F8 File Offset: 0x00045BF8
		internal virtual Module GetManifestModule()
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает значение <see cref="T:System.Boolean" />, которое указывает, была ли эта сборка загружена в контекст, предназначенный только для отражения.</summary>
		/// <returns>Значение <see langword="true" />, если сборка была загружена в контекст, предназначенный только для отражения вместо контекста выполнения; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x06004C36 RID: 19510 RVA: 0x000479F8 File Offset: 0x00045BF8
		[ComVisible(false)]
		public virtual bool ReflectionOnly
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06004C37 RID: 19511 RVA: 0x000930E8 File Offset: 0x000912E8
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Определяет равенство сборки и заданного объекта.</summary>
		/// <param name="o">Объект, сравниваемый с данным экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если значение параметра <paramref name="o" /> равно данному экземпляру; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004C38 RID: 19512 RVA: 0x00097E2A File Offset: 0x0009602A
		public override bool Equals(object o)
		{
			return base.Equals(o);
		}

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x06004C39 RID: 19513 RVA: 0x000479F8 File Offset: 0x00045BF8
		internal virtual PermissionSet GrantedPermissionSet
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x06004C3A RID: 19514 RVA: 0x000479F8 File Offset: 0x00045BF8
		internal virtual PermissionSet DeniedPermissionSet
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает набор разрешений текущей сборки.</summary>
		/// <returns>Набор разрешений текущей сборки.</returns>
		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x06004C3B RID: 19515 RVA: 0x000479F8 File Offset: 0x00045BF8
		public virtual PermissionSet PermissionSet
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает значение, указывающее набор правил безопасности, которые применяются средой CLR к данной сборке.</summary>
		/// <returns>Набор правил безопасности, которые применяются средой CLR к данной сборке.</returns>
		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x06004C3C RID: 19516 RVA: 0x000F1F54 File Offset: 0x000F0154
		public virtual SecurityRuleSet SecurityRuleSet
		{
			get
			{
				throw Assembly.CreateNIE();
			}
		}

		// Token: 0x06004C3D RID: 19517 RVA: 0x000F1F5B File Offset: 0x000F015B
		private static Exception CreateNIE()
		{
			return new NotImplementedException("Derived classes must implement it");
		}

		/// <summary>Возвращает сведения об атрибутах, примененных к текущему объекту <see cref="T:System.Reflection.Assembly" />; сведения представляют собой объекты <see cref="T:System.Reflection.CustomAttributeData" />.</summary>
		/// <returns>Универсальный список объектов <see cref="T:System.Reflection.CustomAttributeData" />, представляющих данные об атрибутах, которые были применены к текущей сборке.</returns>
		// Token: 0x06004C3E RID: 19518 RVA: 0x000479F8 File Offset: 0x00045BF8
		public virtual IList<CustomAttributeData> GetCustomAttributesData()
		{
			throw new NotImplementedException();
		}

		/// <summary>Получает значение, указывающее, загружена ли текущая сборка с полным доверием.</summary>
		/// <returns>Значение <see langword="true" />, если текущая сборка загружена с полным доверием; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x06004C3F RID: 19519 RVA: 0x000040F7 File Offset: 0x000022F7
		[MonoTODO]
		public bool IsFullyTrusted
		{
			get
			{
				return true;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Type" /> с заданным именем в экземпляре сборки, с возможностями игнорировать регистр и вызвать исключение, если тип не найден.</summary>
		/// <param name="name">Полное имя типа.</param>
		/// <param name="throwOnError">Значение <see langword="true" /> для создания исключения, если тип не найден, в обратном случае — значение <see langword="false" />, в результате чего будет возвращено значение <see langword="null" />.</param>
		/// <param name="ignoreCase">Значение <see langword="true" />, чтобы игнорировать регистр имени типа, в обратном случае — значение <see langword="false" />.</param>
		/// <returns>Объект, представляющий указанный класс.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="name" /> недопустим.  
		///
		/// или - 
		/// Длина <paramref name="name" /> превышает 1024 символа.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.TypeLoadException">
		///   <paramref name="throwOnError" /> является <see langword="true" />, не удается найти тип.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Для <paramref name="name" /> требуется зависимая сборка, которую не удается найти.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Для <paramref name="name" /> требуется зависимая сборка, которая была найдена, но ее не удалось загрузить.  
		///
		/// или - 
		/// Текущая сборка была загружена в контекст только для отражения, а для <paramref name="name" /> требуется зависимая сборка, которая не была предварительно загружена.</exception>
		/// <exception cref="T:System.BadImageFormatException">Для <paramref name="name" /> требуется зависимая сборка, однако файл не является допустимой сборкой.  
		///
		/// или - 
		/// Для <paramref name="name" /> требуется зависимая сборка, которая была скомпилирована для версии среды выполнения более поздней, чем текущая загруженная версия.</exception>
		// Token: 0x06004C40 RID: 19520 RVA: 0x000F1F54 File Offset: 0x000F0154
		public virtual Type GetType(string name, bool throwOnError, bool ignoreCase)
		{
			throw Assembly.CreateNIE();
		}

		/// <summary>Получает указанный модуль этой сборки.</summary>
		/// <param name="name">Имя запрашиваемого модуля.</param>
		/// <returns>Запрашиваемый модуль или значение <see langword="null" />, если модуль не найден.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> представляет собой пустую строку ("").</exception>
		/// <exception cref="T:System.IO.FileLoadException">Не удалось загрузить файл, который был найден.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="name" />.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="name" /> не является допустимой сборкой.</exception>
		// Token: 0x06004C41 RID: 19521 RVA: 0x000F1F54 File Offset: 0x000F0154
		public virtual Module GetModule(string name)
		{
			throw Assembly.CreateNIE();
		}

		/// <summary>Возвращает объекты <see cref="T:System.Reflection.AssemblyName" /> для всех сборок, на которые ссылается данная сборка.</summary>
		/// <returns>Массив, содержащий полностью проанализированные отображаемые имена всех сборок, на которые ссылается данная сборка.</returns>
		// Token: 0x06004C42 RID: 19522 RVA: 0x000F1F54 File Offset: 0x000F0154
		public virtual AssemblyName[] GetReferencedAssemblies()
		{
			throw Assembly.CreateNIE();
		}

		/// <summary>Получает все загруженные модули, входящие в эту сборку, с указанием возможности включения модулей ресурсов.</summary>
		/// <param name="getResourceModules">Значение <see langword="true" />, если необходимо включать модули ресурсов; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Массив модулей.</returns>
		// Token: 0x06004C43 RID: 19523 RVA: 0x000F1F54 File Offset: 0x000F0154
		public virtual Module[] GetModules(bool getResourceModules)
		{
			throw Assembly.CreateNIE();
		}

		/// <summary>Получает все загруженные модули, входящие в эту сборку, с заданием возможности включения модулей ресурсов.</summary>
		/// <param name="getResourceModules">Значение <see langword="true" />, если необходимо включать модули ресурсов; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Массив модулей.</returns>
		// Token: 0x06004C44 RID: 19524 RVA: 0x000F1F54 File Offset: 0x000F0154
		[MonoTODO("Always returns the same as GetModules")]
		public virtual Module[] GetLoadedModules(bool getResourceModules)
		{
			throw Assembly.CreateNIE();
		}

		/// <summary>Получает сопутствующую сборку для указанной культуры.</summary>
		/// <param name="culture">Заданные язык и региональные параметры.</param>
		/// <returns>Указанная вспомогательная сборка.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="culture" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удается найти сборку.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Вспомогательная сборка с соответствующим именем файла была найдена, но параметр <see langword="CultureInfo" /> не соответствует указанному.</exception>
		/// <exception cref="T:System.BadImageFormatException">Вспомогательная сборка не является допустимой сборкой.</exception>
		// Token: 0x06004C45 RID: 19525 RVA: 0x000F1F54 File Offset: 0x000F0154
		public virtual Assembly GetSatelliteAssembly(CultureInfo culture)
		{
			throw Assembly.CreateNIE();
		}

		/// <summary>Получает указанную версию вспомогательной сборки для указанной культуры.</summary>
		/// <param name="culture">Заданные язык и региональные параметры.</param>
		/// <param name="version">Версия вспомогательной сборки.</param>
		/// <returns>Указанная вспомогательная сборка.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="culture" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Вспомогательная сборка с соответствующим именем файла была найдена, но <see langword="CultureInfo" /> или версия не соответствуют указанным.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удается найти сборку.</exception>
		/// <exception cref="T:System.BadImageFormatException">Вспомогательная сборка не является допустимой сборкой.</exception>
		// Token: 0x06004C46 RID: 19526 RVA: 0x000F1F54 File Offset: 0x000F0154
		public virtual Assembly GetSatelliteAssembly(CultureInfo culture, Version version)
		{
			throw Assembly.CreateNIE();
		}

		/// <summary>Возвращает модуль, содержащий манифест текущей сборки.</summary>
		/// <returns>Модуль, содержащий манифест текущей сборки.</returns>
		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x06004C47 RID: 19527 RVA: 0x000F1F54 File Offset: 0x000F0154
		public virtual Module ManifestModule
		{
			get
			{
				throw Assembly.CreateNIE();
			}
		}

		/// <summary>Получает значение, указывающее, была ли сборка загружена из глобального кэша сборок.</summary>
		/// <returns>Значение <see langword="true" />, если сборка была загружена из глобального кэша сборок, в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x06004C48 RID: 19528 RVA: 0x000F1F54 File Offset: 0x000F0154
		public virtual bool GlobalAssemblyCache
		{
			get
			{
				throw Assembly.CreateNIE();
			}
		}

		/// <summary>Получает значение, определяющее, была ли текущая сборка создана динамически в текущем процессе с помощью отражения.</summary>
		/// <returns>Значение <see langword="true" />, если текущая сборка была создана динамически в текущем процессе; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x06004C49 RID: 19529 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public virtual bool IsDynamic
		{
			get
			{
				return false;
			}
		}

		/// <summary>Определение равенства двух объектов <see cref="T:System.Reflection.Assembly" />.</summary>
		/// <param name="left">Сборка, сравниваемая со значением <paramref name="right" />.</param>
		/// <param name="right">Сборка, сравниваемая со значением <paramref name="left" />.</param>
		/// <returns>
		///   <see langword="true" />, если значения параметров <paramref name="left" /> и <paramref name="right" /> равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06004C4A RID: 19530 RVA: 0x000F1F67 File Offset: 0x000F0167
		public static bool operator ==(Assembly left, Assembly right)
		{
			return left == right || (!(left == null ^ right == null) && left.Equals(right));
		}

		/// <summary>Определяет неравенство двух объектов <see cref="T:System.Reflection.Assembly" />.</summary>
		/// <param name="left">Сборка, сравниваемая со значением <paramref name="right" />.</param>
		/// <param name="right">Сборка, сравниваемая со значением <paramref name="left" />.</param>
		/// <returns>
		///   <see langword="true" />, если значения <paramref name="left" /> и <paramref name="right" /> не равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06004C4B RID: 19531 RVA: 0x000F1F83 File Offset: 0x000F0183
		public static bool operator !=(Assembly left, Assembly right)
		{
			return left != right && ((left == null ^ right == null) || !left.Equals(right));
		}

		/// <summary>Получает коллекцию типов, определенных в этой сборке.</summary>
		/// <returns>Коллекция типов, определенных в этой сборке.</returns>
		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x06004C4C RID: 19532 RVA: 0x000F1FA2 File Offset: 0x000F01A2
		public virtual IEnumerable<TypeInfo> DefinedTypes
		{
			get
			{
				foreach (Type type in this.GetTypes())
				{
					yield return type.GetTypeInfo();
				}
				Type[] array = null;
				yield break;
			}
		}

		/// <summary>Получает коллекцию открытых типов, определенных в этой сборке и видимых за ее пределами.</summary>
		/// <returns>Коллекция открытых типов, определенных в этой сборке и видимых за ее пределами.</returns>
		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x06004C4D RID: 19533 RVA: 0x000F1FB2 File Offset: 0x000F01B2
		public virtual IEnumerable<Type> ExportedTypes
		{
			get
			{
				return this.GetExportedTypes();
			}
		}

		/// <summary>Получает коллекцию, содержащую модули в этой сборке.</summary>
		/// <returns>Коллекция, содержащая модули в этой сборке.</returns>
		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x06004C4E RID: 19534 RVA: 0x000F1FBA File Offset: 0x000F01BA
		public virtual IEnumerable<Module> Modules
		{
			get
			{
				return this.GetModules();
			}
		}

		/// <summary>Получает коллекцию, содержащую пользовательские атрибуты этой сборки.</summary>
		/// <returns>Коллекция, содержащая пользовательские атрибуты этой сборки.</returns>
		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x06004C4F RID: 19535 RVA: 0x000F1FC2 File Offset: 0x000F01C2
		public virtual IEnumerable<CustomAttributeData> CustomAttributes
		{
			get
			{
				return this.GetCustomAttributesData();
			}
		}

		// Token: 0x06004C50 RID: 19536 RVA: 0x0001B98B File Offset: 0x00019B8B
		public virtual Type[] GetForwardedTypes()
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x020008E9 RID: 2281
		internal class ResolveEventHolder
		{
			// Token: 0x1400001D RID: 29
			// (add) Token: 0x06004C52 RID: 19538 RVA: 0x000F1FCC File Offset: 0x000F01CC
			// (remove) Token: 0x06004C53 RID: 19539 RVA: 0x000F2004 File Offset: 0x000F0204
			public event ModuleResolveEventHandler ModuleResolve;
		}
	}
}
