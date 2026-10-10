using System;
using System.Text;

namespace System.Runtime.Versioning
{
	/// <summary>Представляет имя версии платформы .NET Framework.</summary>
	// Token: 0x02000182 RID: 386
	[Serializable]
	public sealed class FrameworkName : IEquatable<FrameworkName>
	{
		/// <summary>Получает идентификатор данного объекта <see cref="T:System.Runtime.Versioning.FrameworkName" />.</summary>
		/// <returns>Идентификатор данного объекта <see cref="T:System.Runtime.Versioning.FrameworkName" />.</returns>
		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000A58 RID: 2648 RVA: 0x0002D11C File Offset: 0x0002B31C
		public string Identifier
		{
			get
			{
				return this.m_identifier;
			}
		}

		/// <summary>Получает версию данного объекта <see cref="T:System.Runtime.Versioning.FrameworkName" />.</summary>
		/// <returns>Объект, содержащий информацию о версии данного объекта <see cref="T:System.Runtime.Versioning.FrameworkName" />.</returns>
		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x0002D124 File Offset: 0x0002B324
		public Version Version
		{
			get
			{
				return this.m_version;
			}
		}

		/// <summary>Получает имя профиля данного объекта <see cref="T:System.Runtime.Versioning.FrameworkName" />.</summary>
		/// <returns>Имя профиля данного объекта <see cref="T:System.Runtime.Versioning.FrameworkName" />.</returns>
		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000A5A RID: 2650 RVA: 0x0002D12C File Offset: 0x0002B32C
		public string Profile
		{
			get
			{
				return this.m_profile;
			}
		}

		/// <summary>Получает полное имя данного объекта <see cref="T:System.Runtime.Versioning.FrameworkName" />.</summary>
		/// <returns>Полное имя данного объекта <see cref="T:System.Runtime.Versioning.FrameworkName" />.</returns>
		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x0002D134 File Offset: 0x0002B334
		public string FullName
		{
			get
			{
				if (this.m_fullName == null)
				{
					StringBuilder stringBuilder = new StringBuilder();
					stringBuilder.Append(this.Identifier);
					stringBuilder.Append(',');
					stringBuilder.Append("Version").Append('=');
					stringBuilder.Append('v');
					stringBuilder.Append(this.Version);
					if (!string.IsNullOrEmpty(this.Profile))
					{
						stringBuilder.Append(',');
						stringBuilder.Append("Profile").Append('=');
						stringBuilder.Append(this.Profile);
					}
					this.m_fullName = stringBuilder.ToString();
				}
				return this.m_fullName;
			}
		}

		/// <summary>Возвращает значение, указывающее, представляет ли данный экземпляр класса <see cref="T:System.Runtime.Versioning.FrameworkName" /> ту же версию платформы .NET Framework, что и указанный объект.</summary>
		/// <param name="obj">Объект, сравниваемый с текущим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если все компоненты текущего объекта <see cref="T:System.Runtime.Versioning.FrameworkName" /> совпадают с соответствующими компонентами объекта <paramref name="obj" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000A5C RID: 2652 RVA: 0x0002D1D9 File Offset: 0x0002B3D9
		public override bool Equals(object obj)
		{
			return this.Equals(obj as FrameworkName);
		}

		/// <summary>Возвращает значение, указывающее, представляет ли данный экземпляр класса <see cref="T:System.Runtime.Versioning.FrameworkName" /> ту же версию платформы .NET Framework, что и указанный экземпляр класса <see cref="T:System.Runtime.Versioning.FrameworkName" />.</summary>
		/// <param name="other">Объект, сравниваемый с текущим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если все компоненты текущего объекта <see cref="T:System.Runtime.Versioning.FrameworkName" /> совпадают с соответствующими компонентами объекта <paramref name="other" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000A5D RID: 2653 RVA: 0x0002D1E7 File Offset: 0x0002B3E7
		public bool Equals(FrameworkName other)
		{
			return other != null && (this.Identifier == other.Identifier && this.Version == other.Version) && this.Profile == other.Profile;
		}

		/// <summary>Возвращает хэш-код для объекта <see cref="T:System.Runtime.Versioning.FrameworkName" />.</summary>
		/// <returns>32-разрядное целое число со знаком, представляющее хэш-код данного экземпляра.</returns>
		// Token: 0x06000A5E RID: 2654 RVA: 0x0002D227 File Offset: 0x0002B427
		public override int GetHashCode()
		{
			return this.Identifier.GetHashCode() ^ this.Version.GetHashCode() ^ this.Profile.GetHashCode();
		}

		/// <summary>Возвращает строковое представление конкретного объекта <see cref="T:System.Runtime.Versioning.FrameworkName" />.</summary>
		/// <returns>Строка, представляющая данный объект <see cref="T:System.Runtime.Versioning.FrameworkName" />.</returns>
		// Token: 0x06000A5F RID: 2655 RVA: 0x0002D24C File Offset: 0x0002B44C
		public override string ToString()
		{
			return this.FullName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Versioning.FrameworkName" /> с помощью строки и объекта <see cref="T:System.Version" />, указывающих версию платформы .NET Framework.</summary>
		/// <param name="identifier">Строка, указывающая версию платформы .NET Framework.</param>
		/// <param name="version">Объект, содержащий информацию о версии платформы .NET Framework.</param>
		/// <exception cref="T:System.ArgumentException">Свойство <paramref name="identifier" /> имеет значение <see cref="F:System.String.Empty" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="identifier" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="version" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000A60 RID: 2656 RVA: 0x0002D254 File Offset: 0x0002B454
		public FrameworkName(string identifier, Version version) : this(identifier, version, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Versioning.FrameworkName" /> с помощью строки, объекта <see cref="T:System.Version" />, указывающего версию платформы .NET Framework, и имени профиля.</summary>
		/// <param name="identifier">Строка, указывающая версию платформы .NET Framework.</param>
		/// <param name="version">Объект, содержащий информацию о версии платформы .NET Framework.</param>
		/// <param name="profile">Имя профиля.</param>
		/// <exception cref="T:System.ArgumentException">Свойство <paramref name="identifier" /> имеет значение <see cref="F:System.String.Empty" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="identifier" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="version" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000A61 RID: 2657 RVA: 0x0002D260 File Offset: 0x0002B460
		public FrameworkName(string identifier, Version version, string profile)
		{
			if (identifier == null)
			{
				throw new ArgumentNullException("identifier");
			}
			if (identifier.Trim().Length == 0)
			{
				throw new ArgumentException(SR.GetString("The parameter '{0}' cannot be an empty string.", new object[]
				{
					"identifier"
				}), "identifier");
			}
			if (version == null)
			{
				throw new ArgumentNullException("version");
			}
			this.m_identifier = identifier.Trim();
			this.m_version = (Version)version.Clone();
			this.m_profile = ((profile == null) ? string.Empty : profile.Trim());
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Versioning.FrameworkName" /> с помощью строки, содержащей информацию о версии платформы .NET Framework.</summary>
		/// <param name="frameworkName">Строка, содержащая информацию о версии платформы .NET Framework.</param>
		/// <exception cref="T:System.ArgumentException">Свойство <paramref name="frameworkName" /> имеет значение <see cref="F:System.String.Empty" />.  
		///
		/// или - 
		/// В параметре <paramref name="frameworkName" /> содержится менее двух или более трех компонентов.  
		///
		/// или - 
		/// <paramref name="frameworkName" /> не включает основной и дополнительный номера версии.  
		///
		/// или - 
		/// <paramref name="frameworkName" /> не включает допустимый номер версии.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="frameworkName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000A62 RID: 2658 RVA: 0x0002D2F8 File Offset: 0x0002B4F8
		public FrameworkName(string frameworkName)
		{
			if (frameworkName == null)
			{
				throw new ArgumentNullException("frameworkName");
			}
			if (frameworkName.Length == 0)
			{
				throw new ArgumentException(SR.GetString("The parameter '{0}' cannot be an empty string.", new object[]
				{
					"frameworkName"
				}), "frameworkName");
			}
			string[] array = frameworkName.Split(',', StringSplitOptions.None);
			if (array.Length < 2 || array.Length > 3)
			{
				throw new ArgumentException(SR.GetString("FrameworkName cannot have less than two components or more than three components."), "frameworkName");
			}
			this.m_identifier = array[0].Trim();
			if (this.m_identifier.Length == 0)
			{
				throw new ArgumentException(SR.GetString("FrameworkName is invalid."), "frameworkName");
			}
			bool flag = false;
			this.m_profile = string.Empty;
			int i = 1;
			while (i < array.Length)
			{
				string[] array2 = array[i].Split('=', StringSplitOptions.None);
				if (array2.Length != 2)
				{
					throw new ArgumentException(SR.GetString("FrameworkName is invalid."), "frameworkName");
				}
				string text = array2[0].Trim();
				string text2 = array2[1].Trim();
				if (text.Equals("Version", StringComparison.OrdinalIgnoreCase))
				{
					flag = true;
					if (text2.Length > 0 && (text2[0] == 'v' || text2[0] == 'V'))
					{
						text2 = text2.Substring(1);
					}
					try
					{
						this.m_version = new Version(text2);
						goto IL_181;
					}
					catch (Exception innerException)
					{
						throw new ArgumentException(SR.GetString("FrameworkName version component is invalid."), "frameworkName", innerException);
					}
					goto IL_14B;
				}
				goto IL_14B;
				IL_181:
				i++;
				continue;
				IL_14B:
				if (!text.Equals("Profile", StringComparison.OrdinalIgnoreCase))
				{
					throw new ArgumentException(SR.GetString("FrameworkName is invalid."), "frameworkName");
				}
				if (!string.IsNullOrEmpty(text2))
				{
					this.m_profile = text2;
					goto IL_181;
				}
				goto IL_181;
			}
			if (!flag)
			{
				throw new ArgumentException(SR.GetString("FrameworkName version component is missing."), "frameworkName");
			}
		}

		/// <summary>Возвращает значение, указывающее, представляют ли два экземпляра объекта <see cref="T:System.Runtime.Versioning.FrameworkName" /> одну и ту же версию .NET Framework.</summary>
		/// <param name="left">Первый из сравниваемых объектов.</param>
		/// <param name="right">Второй из сравниваемых объектов.</param>
		/// <returns>Значение <see langword="true" />, если параметры <paramref name="left" /> и <paramref name="right" /> представляют собой одну и ту же версию .NET Framework; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000A63 RID: 2659 RVA: 0x0002D4BC File Offset: 0x0002B6BC
		public static bool operator ==(FrameworkName left, FrameworkName right)
		{
			if (left == null)
			{
				return right == null;
			}
			return left.Equals(right);
		}

		/// <summary>Возвращает значение, указывающее, представляют ли два объекта <see cref="T:System.Runtime.Versioning.FrameworkName" /> разные версии .NET Framework.</summary>
		/// <param name="left">Первый из сравниваемых объектов.</param>
		/// <param name="right">Второй из сравниваемых объектов.</param>
		/// <returns>Значение <see langword="true" />, если параметры <paramref name="left" /> и <paramref name="right" /> представляют разные версии .NET Framework; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000A64 RID: 2660 RVA: 0x0002D4CD File Offset: 0x0002B6CD
		public static bool operator !=(FrameworkName left, FrameworkName right)
		{
			return !(left == right);
		}

		// Token: 0x040006DD RID: 1757
		private readonly string m_identifier;

		// Token: 0x040006DE RID: 1758
		private readonly Version m_version;

		// Token: 0x040006DF RID: 1759
		private readonly string m_profile;

		// Token: 0x040006E0 RID: 1760
		private string m_fullName;

		// Token: 0x040006E1 RID: 1761
		private const char c_componentSeparator = ',';

		// Token: 0x040006E2 RID: 1762
		private const char c_keyValueSeparator = '=';

		// Token: 0x040006E3 RID: 1763
		private const char c_versionValuePrefix = 'v';

		// Token: 0x040006E4 RID: 1764
		private const string c_versionKey = "Version";

		// Token: 0x040006E5 RID: 1765
		private const string c_profileKey = "Profile";
	}
}
