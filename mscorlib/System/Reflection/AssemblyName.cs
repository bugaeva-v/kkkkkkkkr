using System;
using System.Configuration.Assemblies;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using Mono;
using Mono.Security;
using Mono.Security.Cryptography;

namespace System.Reflection
{
	/// <summary>Подробно описывает уникальный идентификатор сборки.</summary>
	// Token: 0x020008EB RID: 2283
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComDefaultInterface(typeof(_AssemblyName))]
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class AssemblyName : ICloneable, ISerializable, IDeserializationCallback, _AssemblyName
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.AssemblyName" />.</summary>
		// Token: 0x06004C5D RID: 19549 RVA: 0x000F2137 File Offset: 0x000F0337
		public AssemblyName()
		{
			this.versioncompat = AssemblyVersionCompatibility.SameMachine;
		}

		// Token: 0x06004C5E RID: 19550
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool ParseAssemblyName(IntPtr name, out MonoAssemblyName aname, out bool is_version_definited, out bool is_token_defined);

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.AssemblyName" /> с заданным отображаемым именем.</summary>
		/// <param name="assemblyName">Отображаемое имя сборки, возвращаемое свойством <see cref="P:System.Reflection.AssemblyName.FullName" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assemblyName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="assemblyName" /> — пустая строка.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Вместо этого в .NET для приложений Магазина Windows или в переносимой библиотеке классов перехватите исключение базового класса <see cref="T:System.IO.IOException" />.  
		///
		///
		///
		///
		///  Не удалось найти или загрузить сборку, на которую указывает ссылка.</exception>
		// Token: 0x06004C5F RID: 19551 RVA: 0x000F2148 File Offset: 0x000F0348
		public unsafe AssemblyName(string assemblyName)
		{
			if (assemblyName == null)
			{
				throw new ArgumentNullException("assemblyName");
			}
			if (assemblyName.Length < 1)
			{
				throw new ArgumentException("assemblyName cannot have zero length.");
			}
			using (SafeStringMarshal safeStringMarshal = RuntimeMarshal.MarshalString(assemblyName))
			{
				MonoAssemblyName monoAssemblyName;
				bool addVersion;
				bool defaultToken;
				if (!AssemblyName.ParseAssemblyName(safeStringMarshal.Value, out monoAssemblyName, out addVersion, out defaultToken))
				{
					throw new FileLoadException("The assembly name is invalid.");
				}
				try
				{
					this.FillName(&monoAssemblyName, null, addVersion, false, defaultToken, false);
				}
				finally
				{
					RuntimeMarshal.FreeAssemblyName(ref monoAssemblyName, false);
				}
			}
		}

		/// <summary>Возвращает или задает значение, указывающее процессор и разрядность слова для платформы, являющейся целевой для исполняемого файла.</summary>
		/// <returns>Одно из значений перечисления, которое определяет процессор и разрядность слова для платформы, являющейся целевой для исполняемого файла.</returns>
		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x06004C60 RID: 19552 RVA: 0x000F21E8 File Offset: 0x000F03E8
		// (set) Token: 0x06004C61 RID: 19553 RVA: 0x000F21F0 File Offset: 0x000F03F0
		public ProcessorArchitecture ProcessorArchitecture
		{
			get
			{
				return this.processor_architecture;
			}
			set
			{
				this.processor_architecture = value;
			}
		}

		// Token: 0x06004C62 RID: 19554 RVA: 0x000F21FC File Offset: 0x000F03FC
		internal AssemblyName(SerializationInfo si, StreamingContext sc)
		{
			this.name = si.GetString("_Name");
			this.codebase = si.GetString("_CodeBase");
			this.version = (Version)si.GetValue("_Version", typeof(Version));
			this.publicKey = (byte[])si.GetValue("_PublicKey", typeof(byte[]));
			this.keyToken = (byte[])si.GetValue("_PublicKeyToken", typeof(byte[]));
			this.hashalg = (AssemblyHashAlgorithm)si.GetValue("_HashAlgorithm", typeof(AssemblyHashAlgorithm));
			this.keypair = (StrongNameKeyPair)si.GetValue("_StrongNameKeyPair", typeof(StrongNameKeyPair));
			this.versioncompat = (AssemblyVersionCompatibility)si.GetValue("_VersionCompatibility", typeof(AssemblyVersionCompatibility));
			this.flags = (AssemblyNameFlags)si.GetValue("_Flags", typeof(AssemblyNameFlags));
			int @int = si.GetInt32("_CultureInfo");
			if (@int != -1)
			{
				this.cultureinfo = new CultureInfo(@int);
			}
		}

		/// <summary>Получает или задает простое имя сборки. Это, как правило (но не обязательно), имя файла манифеста сборки без указания его расширения.</summary>
		/// <returns>Простое имя сборки.</returns>
		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x06004C63 RID: 19555 RVA: 0x000F232D File Offset: 0x000F052D
		// (set) Token: 0x06004C64 RID: 19556 RVA: 0x000F2335 File Offset: 0x000F0535
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		/// <summary>Возвращает или задает местонахождение сборки в виде URL-адреса.</summary>
		/// <returns>Строка, представляющая URL-адрес расположения сборки.</returns>
		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x06004C65 RID: 19557 RVA: 0x000F233E File Offset: 0x000F053E
		// (set) Token: 0x06004C66 RID: 19558 RVA: 0x000F2346 File Offset: 0x000F0546
		public string CodeBase
		{
			get
			{
				return this.codebase;
			}
			set
			{
				this.codebase = value;
			}
		}

		/// <summary>Получает универсальный код доступа (URI), предоставляющий базовый код, включая escape-символы.</summary>
		/// <returns>Универсальный код доступа (URI) с escape-символами.</returns>
		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x06004C67 RID: 19559 RVA: 0x000F234F File Offset: 0x000F054F
		public string EscapedCodeBase
		{
			get
			{
				if (this.codebase == null)
				{
					return null;
				}
				return Uri.EscapeString(this.codebase, false, true, true);
			}
		}

		/// <summary>Возвращает или задает язык и региональные параметры, поддерживаемые сборкой.</summary>
		/// <returns>Объект, представляющий язык и региональные параметры, поддерживаемые сборкой.</returns>
		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x06004C68 RID: 19560 RVA: 0x000F2369 File Offset: 0x000F0569
		// (set) Token: 0x06004C69 RID: 19561 RVA: 0x000F2371 File Offset: 0x000F0571
		public CultureInfo CultureInfo
		{
			get
			{
				return this.cultureinfo;
			}
			set
			{
				this.cultureinfo = value;
			}
		}

		/// <summary>Возвращает или задает атрибуты сборки.</summary>
		/// <returns>Ззначение, представляющее атрибуты сборки.</returns>
		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x06004C6A RID: 19562 RVA: 0x000F237A File Offset: 0x000F057A
		// (set) Token: 0x06004C6B RID: 19563 RVA: 0x000F2382 File Offset: 0x000F0582
		public AssemblyNameFlags Flags
		{
			get
			{
				return this.flags;
			}
			set
			{
				this.flags = value;
			}
		}

		/// <summary>Возвращает полное имя сборки, также называемое отображаемым именем.</summary>
		/// <returns>Строка, являющаяся полным именем сборки, также называемая отображаемым именем.</returns>
		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x06004C6C RID: 19564 RVA: 0x000F238C File Offset: 0x000F058C
		public string FullName
		{
			get
			{
				if (this.name == null)
				{
					return string.Empty;
				}
				StringBuilder stringBuilder = new StringBuilder();
				if (char.IsWhiteSpace(this.name[0]))
				{
					stringBuilder.Append("\"" + this.name + "\"");
				}
				else
				{
					stringBuilder.Append(this.name);
				}
				if (this.Version != null)
				{
					stringBuilder.Append(", Version=");
					stringBuilder.Append(this.Version.ToString());
				}
				if (this.cultureinfo != null)
				{
					stringBuilder.Append(", Culture=");
					if (this.cultureinfo.LCID == CultureInfo.InvariantCulture.LCID)
					{
						stringBuilder.Append("neutral");
					}
					else
					{
						stringBuilder.Append(this.cultureinfo.Name);
					}
				}
				byte[] array = this.InternalGetPublicKeyToken();
				if (array != null)
				{
					if (array.Length == 0)
					{
						stringBuilder.Append(", PublicKeyToken=null");
					}
					else
					{
						stringBuilder.Append(", PublicKeyToken=");
						for (int i = 0; i < array.Length; i++)
						{
							stringBuilder.Append(array[i].ToString("x2"));
						}
					}
				}
				if ((this.Flags & AssemblyNameFlags.Retargetable) != AssemblyNameFlags.None)
				{
					stringBuilder.Append(", Retargetable=Yes");
				}
				return stringBuilder.ToString();
			}
		}

		/// <summary>Возвращает или задает алгоритм хэширования, используемый манифестом сборки.</summary>
		/// <returns>Алгоритм хэширования, используемый манифестом сборки.</returns>
		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x06004C6D RID: 19565 RVA: 0x000F24D0 File Offset: 0x000F06D0
		// (set) Token: 0x06004C6E RID: 19566 RVA: 0x000F24D8 File Offset: 0x000F06D8
		public AssemblyHashAlgorithm HashAlgorithm
		{
			get
			{
				return this.hashalg;
			}
			set
			{
				this.hashalg = value;
			}
		}

		/// <summary>Возвращает или задает пару открытого и закрытого ключей шифрования, которая используется для создания подписи со строгим именем для сборки.</summary>
		/// <returns>Пара открытого и закрытого ключей шифрования, которая должна использоваться для создания подписи со строгим именем для сборки.</returns>
		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x06004C6F RID: 19567 RVA: 0x000F24E1 File Offset: 0x000F06E1
		// (set) Token: 0x06004C70 RID: 19568 RVA: 0x000F24E9 File Offset: 0x000F06E9
		public StrongNameKeyPair KeyPair
		{
			get
			{
				return this.keypair;
			}
			set
			{
				this.keypair = value;
			}
		}

		/// <summary>Возвращает или задает для сборки основной номер версии, промежуточный номер версии, номер построения и номер редакции.</summary>
		/// <returns>Объект, предоставляющий для сборки основной номер версии, промежуточный номер версии, номер построения и номер редакции.</returns>
		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x06004C71 RID: 19569 RVA: 0x000F24F2 File Offset: 0x000F06F2
		// (set) Token: 0x06004C72 RID: 19570 RVA: 0x000F24FC File Offset: 0x000F06FC
		public Version Version
		{
			get
			{
				return this.version;
			}
			set
			{
				this.version = value;
				if (value == null)
				{
					this.major = (this.minor = (this.build = (this.revision = 0)));
					return;
				}
				this.major = value.Major;
				this.minor = value.Minor;
				this.build = value.Build;
				this.revision = value.Revision;
			}
		}

		/// <summary>Возвращает или задает сведения, связанные с совместимостью сборки с другими сборками.</summary>
		/// <returns>Значение, представляющее сведения о совместимости сборки с другими сборками.</returns>
		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x06004C73 RID: 19571 RVA: 0x000F256C File Offset: 0x000F076C
		// (set) Token: 0x06004C74 RID: 19572 RVA: 0x000F2574 File Offset: 0x000F0774
		public AssemblyVersionCompatibility VersionCompatibility
		{
			get
			{
				return this.versioncompat;
			}
			set
			{
				this.versioncompat = value;
			}
		}

		/// <summary>Возвращает полное имя сборки, также называемое отображаемым именем.</summary>
		/// <returns>Полное имя сборки или имя класса, если полное имя не может быть определено.</returns>
		// Token: 0x06004C75 RID: 19573 RVA: 0x000F2580 File Offset: 0x000F0780
		public override string ToString()
		{
			string fullName = this.FullName;
			if (fullName == null)
			{
				return base.ToString();
			}
			return fullName;
		}

		/// <summary>Возвращает открытый ключ сборки.</summary>
		/// <returns>Массив байтов, содержащий открытый ключ сборки.</returns>
		/// <exception cref="T:System.Security.SecurityException">Был предоставлен открытый ключ (например, с помощью метода <see cref="M:System.Reflection.AssemblyName.SetPublicKey(System.Byte[])" />), но не был предоставлен маркер открытого ключа.</exception>
		// Token: 0x06004C76 RID: 19574 RVA: 0x000F259F File Offset: 0x000F079F
		public byte[] GetPublicKey()
		{
			return this.publicKey;
		}

		/// <summary>Возвращает токен открытого ключа, представляющий собой последние 8 байт хэш-значения SHA-1 открытого ключа, которым подписаны приложение или сборка.</summary>
		/// <returns>Массив байтов, содержащий токен открытого ключа.</returns>
		// Token: 0x06004C77 RID: 19575 RVA: 0x000F25A8 File Offset: 0x000F07A8
		public byte[] GetPublicKeyToken()
		{
			if (this.keyToken != null)
			{
				return this.keyToken;
			}
			if (this.publicKey == null)
			{
				return null;
			}
			if (this.publicKey.Length == 0)
			{
				return EmptyArray<byte>.Value;
			}
			if (!this.IsPublicKeyValid)
			{
				throw new SecurityException("The public key is not valid.");
			}
			this.keyToken = this.ComputePublicKeyToken();
			return this.keyToken;
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x06004C78 RID: 19576 RVA: 0x000F2604 File Offset: 0x000F0804
		private bool IsPublicKeyValid
		{
			get
			{
				if (this.publicKey.Length == 16)
				{
					int i = 0;
					int num = 0;
					while (i < this.publicKey.Length)
					{
						num += (int)this.publicKey[i++];
					}
					if (num == 4)
					{
						return true;
					}
				}
				byte b = this.publicKey[0];
				if (b != 0)
				{
					if (b == 6)
					{
						return CryptoConvert.TryImportCapiPublicKeyBlob(this.publicKey, 0);
					}
					if (b != 7)
					{
					}
				}
				else if (this.publicKey.Length > 12 && this.publicKey[12] == 6)
				{
					return CryptoConvert.TryImportCapiPublicKeyBlob(this.publicKey, 12);
				}
				return false;
			}
		}

		// Token: 0x06004C79 RID: 19577 RVA: 0x000F2690 File Offset: 0x000F0890
		private byte[] InternalGetPublicKeyToken()
		{
			if (this.keyToken != null)
			{
				return this.keyToken;
			}
			if (this.publicKey == null)
			{
				return null;
			}
			if (this.publicKey.Length == 0)
			{
				return EmptyArray<byte>.Value;
			}
			if (!this.IsPublicKeyValid)
			{
				throw new SecurityException("The public key is not valid.");
			}
			return this.ComputePublicKeyToken();
		}

		// Token: 0x06004C7A RID: 19578
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void get_public_token(byte* token, byte* pubkey, int len);

		// Token: 0x06004C7B RID: 19579 RVA: 0x000F26E0 File Offset: 0x000F08E0
		private unsafe byte[] ComputePublicKeyToken()
		{
			byte[] array2;
			byte[] array = array2 = new byte[8];
			byte* token;
			if (array == null || array2.Length == 0)
			{
				token = null;
			}
			else
			{
				token = &array2[0];
			}
			byte[] array3;
			byte* pubkey;
			if ((array3 = this.publicKey) == null || array3.Length == 0)
			{
				pubkey = null;
			}
			else
			{
				pubkey = &array3[0];
			}
			AssemblyName.get_public_token(token, pubkey, this.publicKey.Length);
			array3 = null;
			array2 = null;
			return array;
		}

		/// <summary>Возвращает значение, указывающее, идентичны ли имена двух сборок. Сравнение — на основе простых имен сборки.</summary>
		/// <param name="reference">Имя базовой сборки.</param>
		/// <param name="definition">Имя сборки, которое сравнивается с базовой сборкой.</param>
		/// <returns>Значение <see langword="true" />, если простые имена сборок совпадают; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004C7C RID: 19580 RVA: 0x000F273B File Offset: 0x000F093B
		public static bool ReferenceMatchesDefinition(AssemblyName reference, AssemblyName definition)
		{
			if (reference == null)
			{
				throw new ArgumentNullException("reference");
			}
			if (definition == null)
			{
				throw new ArgumentNullException("definition");
			}
			return string.Equals(reference.Name, definition.Name, StringComparison.OrdinalIgnoreCase);
		}

		/// <summary>Задает открытый ключ, идентифицирующий сборку.</summary>
		/// <param name="publicKey">Массив байтов, содержащий открытый ключ сборки.</param>
		// Token: 0x06004C7D RID: 19581 RVA: 0x000F276B File Offset: 0x000F096B
		public void SetPublicKey(byte[] publicKey)
		{
			if (publicKey == null)
			{
				this.flags ^= AssemblyNameFlags.PublicKey;
			}
			else
			{
				this.flags |= AssemblyNameFlags.PublicKey;
			}
			this.publicKey = publicKey;
		}

		/// <summary>Задает токен открытого ключа, представляющий собой последние 8 байт хэш-значения SHA-1 открытого ключа, которым подписаны приложение или сборка.</summary>
		/// <param name="publicKeyToken">Массив байтов, содержащий токена открытого ключа сборки.</param>
		// Token: 0x06004C7E RID: 19582 RVA: 0x000F2795 File Offset: 0x000F0995
		public void SetPublicKeyToken(byte[] publicKeyToken)
		{
			this.keyToken = publicKeyToken;
		}

		/// <summary>Получает сведения сериализации со всеми данными, необходимыми для повторного создания экземпляра этого <see langword="AssemblyName" />.</summary>
		/// <param name="info">Объект, для которого будут заполнены сведения о сериализации.</param>
		/// <param name="context">Контекст назначения сериализации.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004C7F RID: 19583 RVA: 0x000F27A0 File Offset: 0x000F09A0
		[SecurityCritical]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			info.AddValue("_Name", this.name);
			info.AddValue("_PublicKey", this.publicKey);
			info.AddValue("_PublicKeyToken", this.keyToken);
			info.AddValue("_CultureInfo", (this.cultureinfo != null) ? this.cultureinfo.LCID : -1);
			info.AddValue("_CodeBase", this.codebase);
			info.AddValue("_Version", this.Version);
			info.AddValue("_HashAlgorithm", this.hashalg);
			info.AddValue("_HashAlgorithmForControl", AssemblyHashAlgorithm.None);
			info.AddValue("_StrongNameKeyPair", this.keypair);
			info.AddValue("_VersionCompatibility", this.versioncompat);
			info.AddValue("_Flags", this.flags);
			info.AddValue("_HashForControl", null);
		}

		/// <summary>Создает копию этого объекта <see cref="T:System.Reflection.AssemblyName" />.</summary>
		/// <returns>Объект, который является копией этого объекта <see cref="T:System.Reflection.AssemblyName" />.</returns>
		// Token: 0x06004C80 RID: 19584 RVA: 0x000F28A4 File Offset: 0x000F0AA4
		public object Clone()
		{
			return new AssemblyName
			{
				name = this.name,
				codebase = this.codebase,
				major = this.major,
				minor = this.minor,
				build = this.build,
				revision = this.revision,
				version = this.version,
				cultureinfo = this.cultureinfo,
				flags = this.flags,
				hashalg = this.hashalg,
				keypair = this.keypair,
				publicKey = this.publicKey,
				keyToken = this.keyToken,
				versioncompat = this.versioncompat,
				processor_architecture = this.processor_architecture
			};
		}

		/// <summary>Реализует интерфейс <see cref="T:System.Runtime.Serialization.ISerializable" /> и вызывается событием десериализации после завершения десериализации в ходе обратного вызова.</summary>
		/// <param name="sender">Источник события десериализации.</param>
		// Token: 0x06004C81 RID: 19585 RVA: 0x000F296A File Offset: 0x000F0B6A
		public void OnDeserialization(object sender)
		{
			this.Version = this.version;
		}

		/// <summary>Возвращает <see cref="T:System.Reflection.AssemblyName" /> для заданного файла.</summary>
		/// <param name="assemblyFile">Путь к сборки, свойство <see cref="T:System.Reflection.AssemblyName" /> которой нужно возвратить.</param>
		/// <returns>Объект , представляющий данный файл сборки.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assemblyFile" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="assemblyFile" /> является недопустимым, как сборка с недопустимыми языком и региональными параметрами.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="assemblyFile" /> не найден.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение на обнаружение пути.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyFile" /> не является допустимой сборкой.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными наборами свидетельств.</exception>
		// Token: 0x06004C82 RID: 19586 RVA: 0x000F2978 File Offset: 0x000F0B78
		public unsafe static AssemblyName GetAssemblyName(string assemblyFile)
		{
			if (assemblyFile == null)
			{
				throw new ArgumentNullException("assemblyFile");
			}
			AssemblyName assemblyName = new AssemblyName();
			MonoAssemblyName monoAssemblyName;
			string codeBase;
			Assembly.InternalGetAssemblyName(Path.GetFullPath(assemblyFile), out monoAssemblyName, out codeBase);
			try
			{
				assemblyName.FillName(&monoAssemblyName, codeBase, true, false, true, false);
			}
			finally
			{
				RuntimeMarshal.FreeAssemblyName(ref monoAssemblyName, false);
			}
			return assemblyName;
		}

		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Переданный массив имен, которые необходимо сопоставить.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, зарезервированный вызывающим объектом, куда помещаются идентификаторы, соответствующие именам.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06004C83 RID: 19587 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _AssemblyName.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает сведения о типе объекта, которые затем могут использоваться для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Получает указатель на объект с запрошенными сведениями о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06004C84 RID: 19588 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _AssemblyName.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Указатель, по которому записывается число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06004C85 RID: 19589 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _AssemblyName.GetTypeInfoCount(out uint pcTInfo)
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
		// Token: 0x06004C86 RID: 19590 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _AssemblyName.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
		{
			throw new NotImplementedException();
		}

		/// <summary>Получает или задает имя языка и региональных параметров, связанных со сборкой.</summary>
		/// <returns>Имя языка и региональных параметров.</returns>
		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x06004C87 RID: 19591 RVA: 0x000F29D4 File Offset: 0x000F0BD4
		// (set) Token: 0x06004C88 RID: 19592 RVA: 0x000F29EB File Offset: 0x000F0BEB
		public string CultureName
		{
			get
			{
				if (this.cultureinfo != null)
				{
					return this.cultureinfo.Name;
				}
				return null;
			}
			set
			{
				if (value == null)
				{
					this.cultureinfo = null;
					return;
				}
				this.cultureinfo = new CultureInfo(value);
			}
		}

		/// <summary>Получает или задает значение, указывающее, какой тип содержимого содержит сборка.</summary>
		/// <returns>Значение, указывающее, какой тип содержимого сборка содержит.</returns>
		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x06004C89 RID: 19593 RVA: 0x000F2A04 File Offset: 0x000F0C04
		// (set) Token: 0x06004C8A RID: 19594 RVA: 0x000F2A0C File Offset: 0x000F0C0C
		[ComVisible(false)]
		public AssemblyContentType ContentType
		{
			get
			{
				return this.contentType;
			}
			set
			{
				this.contentType = value;
			}
		}

		// Token: 0x06004C8B RID: 19595
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern MonoAssemblyName* GetNativeName(IntPtr assembly_ptr);

		// Token: 0x06004C8C RID: 19596 RVA: 0x000F2A18 File Offset: 0x000F0C18
		internal unsafe void FillName(MonoAssemblyName* native, string codeBase, bool addVersion, bool addPublickey, bool defaultToken, bool assemblyRef)
		{
			this.name = RuntimeMarshal.PtrToUtf8String(native->name);
			this.major = (int)native->major;
			this.minor = (int)native->minor;
			this.build = (int)native->build;
			this.revision = (int)native->revision;
			this.flags = (AssemblyNameFlags)native->flags;
			this.hashalg = (AssemblyHashAlgorithm)native->hash_alg;
			this.versioncompat = AssemblyVersionCompatibility.SameMachine;
			this.processor_architecture = (ProcessorArchitecture)native->arch;
			if (addVersion)
			{
				this.version = new Version(this.major, this.minor, this.build, this.revision);
			}
			this.codebase = codeBase;
			if (native->culture != IntPtr.Zero)
			{
				this.cultureinfo = CultureInfo.CreateCulture(RuntimeMarshal.PtrToUtf8String(native->culture), assemblyRef);
			}
			if (native->public_key != IntPtr.Zero)
			{
				this.publicKey = RuntimeMarshal.DecodeBlobArray(native->public_key);
				this.flags |= AssemblyNameFlags.PublicKey;
			}
			else if (addPublickey)
			{
				this.publicKey = EmptyArray<byte>.Value;
				this.flags |= AssemblyNameFlags.PublicKey;
			}
			if (native->public_key_token.FixedElementField != 0)
			{
				byte[] array = new byte[8];
				int i = 0;
				int num = 0;
				while (i < 8)
				{
					array[i] = (byte)(RuntimeMarshal.AsciHexDigitValue((int)(*(ref native->public_key_token.FixedElementField + num++))) << 4);
					byte[] array2 = array;
					int num2 = i;
					array2[num2] |= (byte)RuntimeMarshal.AsciHexDigitValue((int)(*(ref native->public_key_token.FixedElementField + num++)));
					i++;
				}
				this.keyToken = array;
				return;
			}
			if (defaultToken)
			{
				this.keyToken = EmptyArray<byte>.Value;
			}
		}

		// Token: 0x06004C8D RID: 19597 RVA: 0x000F2BB4 File Offset: 0x000F0DB4
		internal unsafe static AssemblyName Create(Assembly assembly, bool fillCodebase)
		{
			AssemblyName assemblyName = new AssemblyName();
			MonoAssemblyName* nativeName = AssemblyName.GetNativeName(assembly.MonoAssembly);
			assemblyName.FillName(nativeName, fillCodebase ? assembly.CodeBase : null, true, true, true, false);
			return assemblyName;
		}

		// Token: 0x04003014 RID: 12308
		private string name;

		// Token: 0x04003015 RID: 12309
		private string codebase;

		// Token: 0x04003016 RID: 12310
		private int major;

		// Token: 0x04003017 RID: 12311
		private int minor;

		// Token: 0x04003018 RID: 12312
		private int build;

		// Token: 0x04003019 RID: 12313
		private int revision;

		// Token: 0x0400301A RID: 12314
		private CultureInfo cultureinfo;

		// Token: 0x0400301B RID: 12315
		private AssemblyNameFlags flags;

		// Token: 0x0400301C RID: 12316
		private AssemblyHashAlgorithm hashalg;

		// Token: 0x0400301D RID: 12317
		private StrongNameKeyPair keypair;

		// Token: 0x0400301E RID: 12318
		private byte[] publicKey;

		// Token: 0x0400301F RID: 12319
		private byte[] keyToken;

		// Token: 0x04003020 RID: 12320
		private AssemblyVersionCompatibility versioncompat;

		// Token: 0x04003021 RID: 12321
		private Version version;

		// Token: 0x04003022 RID: 12322
		private ProcessorArchitecture processor_architecture;

		// Token: 0x04003023 RID: 12323
		private AssemblyContentType contentType;
	}
}
