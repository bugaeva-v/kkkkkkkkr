using System;
using System.Runtime.Serialization;
using System.Security;

namespace System
{
	/// <summary>Предоставляет информацию об операционной системе, например версию и идентификатор платформы. Этот класс не наследуется.</summary>
	// Token: 0x020001CC RID: 460
	[Serializable]
	public sealed class OperatingSystem : ISerializable, ICloneable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.OperatingSystem" />, используя указанное значение идентификатора платформы и объект версии.</summary>
		/// <param name="platform">Одно из значений <see cref="T:System.PlatformID" />, указывающих платформу операционной системы.</param>
		/// <param name="version">Объект <see cref="T:System.Version" />, указывающий версию операционной системы.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="version" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="platform" /> не является значением перечисления <see cref="T:System.PlatformID" />.</exception>
		// Token: 0x060013BC RID: 5052 RVA: 0x0004E834 File Offset: 0x0004CA34
		public OperatingSystem(PlatformID platform, Version version) : this(platform, version, null)
		{
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x0004E840 File Offset: 0x0004CA40
		internal OperatingSystem(PlatformID platform, Version version, string servicePack)
		{
			if (platform < PlatformID.Win32S || platform > PlatformID.MacOSX)
			{
				throw new ArgumentOutOfRangeException("platform", platform, SR.Format("Illegal enum value: {0}.", platform));
			}
			if (version == null)
			{
				throw new ArgumentNullException("version");
			}
			this._platform = platform;
			this._version = version;
			this._servicePack = servicePack;
		}

		/// <summary>Заполняет объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, необходимыми для десериализации данного экземпляра.</summary>
		/// <param name="info">Объект, который требуется заполнить информацией о сериализации.</param>
		/// <param name="context">Место для хранения и извлечения сериализованных данных. Зарезервировано для будущего использования.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060013BE RID: 5054 RVA: 0x0001B98B File Offset: 0x00019B8B
		[SecurityCritical]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new PlatformNotSupportedException();
		}

		/// <summary>Возвращает значение перечисления <see cref="T:System.PlatformID" />, идентифицирующее данную платформу операционной системы.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.PlatformID" />.</returns>
		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060013BF RID: 5055 RVA: 0x0004E8A5 File Offset: 0x0004CAA5
		public PlatformID Platform
		{
			get
			{
				return this._platform;
			}
		}

		/// <summary>Возвращает версию пакета обновления, представленную этим объектом <see cref="T:System.OperatingSystem" />.</summary>
		/// <returns>Версия пакета обновления, если пакеты обновления поддерживаются и хотя бы один из них установлен; в противном случае — пустая строка ("").</returns>
		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060013C0 RID: 5056 RVA: 0x0004E8AD File Offset: 0x0004CAAD
		public string ServicePack
		{
			get
			{
				return this._servicePack ?? string.Empty;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Version" />, идентифицирующий данную операционную систему.</summary>
		/// <returns>Объект <see cref="T:System.Version" />, в котором указан основной и дополнительный номера версии, номер сборки и номер редакции операционной системы.</returns>
		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060013C1 RID: 5057 RVA: 0x0004E8BE File Offset: 0x0004CABE
		public Version Version
		{
			get
			{
				return this._version;
			}
		}

		/// <summary>Создает объект <see cref="T:System.OperatingSystem" />, идентичный данному экземпляру.</summary>
		/// <returns>Объект <see cref="T:System.OperatingSystem" />, который является копией данного экземпляра.</returns>
		// Token: 0x060013C2 RID: 5058 RVA: 0x0004E8C6 File Offset: 0x0004CAC6
		public object Clone()
		{
			return new OperatingSystem(this._platform, this._version, this._servicePack);
		}

		/// <summary>Преобразует значение этого объекта <see cref="T:System.OperatingSystem" /> в эквивалентное ему строковое представление.</summary>
		/// <returns>Строковое представление значений, возвращаемых свойствами <see cref="P:System.OperatingSystem.Platform" />, <see cref="P:System.OperatingSystem.Version" /> и <see cref="P:System.OperatingSystem.ServicePack" />.</returns>
		// Token: 0x060013C3 RID: 5059 RVA: 0x0004E8DF File Offset: 0x0004CADF
		public override string ToString()
		{
			return this.VersionString;
		}

		/// <summary>Возвращает объединенную строку, в которой представлен идентификатор платформы, версия и пакет обновления, установленный в данный момент в операционной системе.</summary>
		/// <returns>Строковое представление значений, возвращаемых свойствами <see cref="P:System.OperatingSystem.Platform" />, <see cref="P:System.OperatingSystem.Version" /> и <see cref="P:System.OperatingSystem.ServicePack" />.</returns>
		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060013C4 RID: 5060 RVA: 0x0004E8E8 File Offset: 0x0004CAE8
		public string VersionString
		{
			get
			{
				if (this._versionString == null)
				{
					string str;
					switch (this._platform)
					{
					case PlatformID.Win32S:
						str = "Microsoft Win32S ";
						break;
					case PlatformID.Win32Windows:
						str = ((this._version.Major > 4 || (this._version.Major == 4 && this._version.Minor > 0)) ? "Microsoft Windows 98 " : "Microsoft Windows 95 ");
						break;
					case PlatformID.Win32NT:
						str = "Microsoft Windows NT ";
						break;
					case PlatformID.WinCE:
						str = "Microsoft Windows CE ";
						break;
					case PlatformID.Unix:
						str = "Unix ";
						break;
					case PlatformID.Xbox:
						str = "Xbox ";
						break;
					case PlatformID.MacOSX:
						str = "Mac OS X ";
						break;
					default:
						str = "<unknown> ";
						break;
					}
					this._versionString = (string.IsNullOrEmpty(this._servicePack) ? (str + this._version.ToString()) : (str + this._version.ToString(3) + " " + this._servicePack));
				}
				return this._versionString;
			}
		}

		// Token: 0x04001455 RID: 5205
		private readonly Version _version;

		// Token: 0x04001456 RID: 5206
		private readonly PlatformID _platform;

		// Token: 0x04001457 RID: 5207
		private readonly string _servicePack;

		// Token: 0x04001458 RID: 5208
		private string _versionString;
	}
}
