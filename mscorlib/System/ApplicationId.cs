using System;
using System.Text;

namespace System
{
	/// <summary>Содержит сведения, используемые для уникальной идентификации приложения на основе манифеста. Этот класс не наследуется.</summary>
	// Token: 0x020001C8 RID: 456
	[Serializable]
	public sealed class ApplicationId
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ApplicationId" />.</summary>
		/// <param name="publicKeyToken">Массив данных в байтах, представляющий необработанные данные открытого ключа.</param>
		/// <param name="name">Имя приложения.</param>
		/// <param name="version">Объект <see cref="T:System.Version" />, задающий версию приложения.</param>
		/// <param name="processorArchitecture">Архитектура процессора приложения.</param>
		/// <param name="culture">Язык и региональные параметры приложения.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="version" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="publicKeyToken" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> равен пустой строке.</exception>
		// Token: 0x060013A9 RID: 5033 RVA: 0x0004E4E8 File Offset: 0x0004C6E8
		public ApplicationId(byte[] publicKeyToken, string name, Version version, string processorArchitecture, string culture)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (name.Length == 0)
			{
				throw new ArgumentException("ApplicationId cannot have an empty string for the name.");
			}
			if (version == null)
			{
				throw new ArgumentNullException("version");
			}
			if (publicKeyToken == null)
			{
				throw new ArgumentNullException("publicKeyToken");
			}
			this._publicKeyToken = (byte[])publicKeyToken.Clone();
			this.Name = name;
			this.Version = version;
			this.ProcessorArchitecture = processorArchitecture;
			this.Culture = culture;
		}

		/// <summary>Возвращает строку, представляющую сведения о языке и региональных параметрах приложения.</summary>
		/// <returns>Сведения о языке и региональных параметрах приложения.</returns>
		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060013AA RID: 5034 RVA: 0x0004E56D File Offset: 0x0004C76D
		public string Culture { get; }

		/// <summary>Возвращает имя приложения.</summary>
		/// <returns>Имя приложения.</returns>
		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060013AB RID: 5035 RVA: 0x0004E575 File Offset: 0x0004C775
		public string Name { get; }

		/// <summary>Возвращает архитектуру целевого процессора приложения.</summary>
		/// <returns>Архитектура процессора приложения.</returns>
		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060013AC RID: 5036 RVA: 0x0004E57D File Offset: 0x0004C77D
		public string ProcessorArchitecture { get; }

		/// <summary>Возвращает версию приложения.</summary>
		/// <returns>Объект <see cref="T:System.Version" />, задающий версию приложения.</returns>
		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060013AD RID: 5037 RVA: 0x0004E585 File Offset: 0x0004C785
		public Version Version { get; }

		/// <summary>Возвращает для приложения токен открытого ключа.</summary>
		/// <returns>Массив байтов, содержащий токен открытого ключа приложения.</returns>
		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060013AE RID: 5038 RVA: 0x0004E58D File Offset: 0x0004C78D
		public byte[] PublicKeyToken
		{
			get
			{
				return (byte[])this._publicKeyToken.Clone();
			}
		}

		/// <summary>Создает и возвращает идентичную копию текущего удостоверения приложения.</summary>
		/// <returns>Объект <see cref="T:System.ApplicationId" /> представляющий точную копию оригинала.</returns>
		// Token: 0x060013AF RID: 5039 RVA: 0x0004E59F File Offset: 0x0004C79F
		public ApplicationId Copy()
		{
			return new ApplicationId(this._publicKeyToken, this.Name, this.Version, this.ProcessorArchitecture, this.Culture);
		}

		/// <summary>Создает и возвращает строковое представление удостоверения приложения.</summary>
		/// <returns>Строковое представление удостоверения приложения.</returns>
		// Token: 0x060013B0 RID: 5040 RVA: 0x0004E5C4 File Offset: 0x0004C7C4
		public override string ToString()
		{
			StringBuilder stringBuilder = StringBuilderCache.Acquire(16);
			stringBuilder.Append(this.Name);
			if (this.Culture != null)
			{
				stringBuilder.Append(", culture=\"");
				stringBuilder.Append(this.Culture);
				stringBuilder.Append('"');
			}
			stringBuilder.Append(", version=\"");
			stringBuilder.Append(this.Version.ToString());
			stringBuilder.Append('"');
			if (this._publicKeyToken != null)
			{
				stringBuilder.Append(", publicKeyToken=\"");
				stringBuilder.Append(ApplicationId.EncodeHexString(this._publicKeyToken));
				stringBuilder.Append('"');
			}
			if (this.ProcessorArchitecture != null)
			{
				stringBuilder.Append(", processorArchitecture =\"");
				stringBuilder.Append(this.ProcessorArchitecture);
				stringBuilder.Append('"');
			}
			return StringBuilderCache.GetStringAndRelease(stringBuilder);
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x0004E696 File Offset: 0x0004C896
		private static char HexDigit(int num)
		{
			return (char)((num < 10) ? (num + 48) : (num + 55));
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x0004E6A8 File Offset: 0x0004C8A8
		private static string EncodeHexString(byte[] sArray)
		{
			string result = null;
			if (sArray != null)
			{
				char[] array = new char[sArray.Length * 2];
				int i = 0;
				int num = 0;
				while (i < sArray.Length)
				{
					int num2 = (sArray[i] & 240) >> 4;
					array[num++] = ApplicationId.HexDigit(num2);
					num2 = (int)(sArray[i] & 15);
					array[num++] = ApplicationId.HexDigit(num2);
					i++;
				}
				result = new string(array);
			}
			return result;
		}

		/// <summary>Определяет, эквивалентен ли заданный объект <see cref="T:System.ApplicationId" /> текущему объекту <see cref="T:System.ApplicationId" />.</summary>
		/// <param name="o">Объект <see cref="T:System.ApplicationId" />, который требуется сравнить с текущим объектом <see cref="T:System.ApplicationId" />.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.ApplicationId" /> эквивалентен текущему объекту <see cref="T:System.ApplicationId" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060013B3 RID: 5043 RVA: 0x0004E710 File Offset: 0x0004C910
		public override bool Equals(object o)
		{
			ApplicationId applicationId = o as ApplicationId;
			if (applicationId == null)
			{
				return false;
			}
			if (!object.Equals(this.Name, applicationId.Name) || !object.Equals(this.Version, applicationId.Version) || !object.Equals(this.ProcessorArchitecture, applicationId.ProcessorArchitecture) || !object.Equals(this.Culture, applicationId.Culture))
			{
				return false;
			}
			if (this._publicKeyToken.Length != applicationId._publicKeyToken.Length)
			{
				return false;
			}
			for (int i = 0; i < this._publicKeyToken.Length; i++)
			{
				if (this._publicKeyToken[i] != applicationId._publicKeyToken[i])
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>Возвращает хэш-код текущего удостоверения приложения.</summary>
		/// <returns>Хэш-код текущего удостоверения приложения.</returns>
		// Token: 0x060013B4 RID: 5044 RVA: 0x0004E7B3 File Offset: 0x0004C9B3
		public override int GetHashCode()
		{
			return this.Name.GetHashCode() ^ this.Version.GetHashCode();
		}

		// Token: 0x04001447 RID: 5191
		private readonly byte[] _publicKeyToken;
	}
}
