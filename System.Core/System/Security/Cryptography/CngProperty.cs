using System;
using System.Security.Permissions;

namespace System.Security.Cryptography
{
	/// <summary>
	///         Инкапсулирует свойство ключа или поставщика криптографии следующего поколения (CNG).
	///       </summary>
	// Token: 0x02000044 RID: 68
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public struct CngProperty : IEquatable<CngProperty>
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.CngProperty" />.
		///       </summary>
		/// <param name="name">
		///           Имя свойства для инициализации.
		///         </param>
		/// <param name="value">
		///           Значение свойства для инициализации.
		///         </param>
		/// <param name="options">
		///           Побитовое сочетание значений перечисления, которые указывают, как это свойство хранится.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="name" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000140 RID: 320 RVA: 0x000035B0 File Offset: 0x000017B0
		public CngProperty(string name, byte[] value, CngPropertyOptions options)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			this.m_name = name;
			this.m_propertyOptions = options;
			this.m_hashCode = null;
			if (value != null)
			{
				this.m_value = (value.Clone() as byte[]);
				return;
			}
			this.m_value = null;
		}

		/// <summary>
		///         Возвращает свойство name, текущий <see cref="T:System.Security.Cryptography.CngProperty" /> указывает объект.
		///       </summary>
		/// <returns>
		///         Имя свойства, которое задано в текущем <see cref="T:System.Security.Cryptography.CngProperty" /> объекта.
		///       </returns>
		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00003601 File Offset: 0x00001801
		public string Name
		{
			get
			{
				return this.m_name;
			}
		}

		/// <summary>
		///         Получает параметры свойств, текущего <see cref="T:System.Security.Cryptography.CngProperty" /> указывает объект.
		///       </summary>
		/// <returns>
		///         Объект, который указывает параметры, заданные в текущем <see cref="T:System.Security.Cryptography.CngProperty" /> объекта.
		///       </returns>
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00003609 File Offset: 0x00001809
		public CngPropertyOptions Options
		{
			get
			{
				return this.m_propertyOptions;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00003611 File Offset: 0x00001811
		internal byte[] Value
		{
			get
			{
				return this.m_value;
			}
		}

		/// <summary>
		///         Возвращает значение свойства, текущий <see cref="T:System.Security.Cryptography.CngProperty" /> указывает объект.
		///       </summary>
		/// <returns>
		///         Массив, представляющий значение, хранящееся в свойстве.
		///       </returns>
		// Token: 0x06000144 RID: 324 RVA: 0x0000361C File Offset: 0x0000181C
		public byte[] GetValue()
		{
			byte[] result = null;
			if (this.m_value != null)
			{
				result = (this.m_value.Clone() as byte[]);
			}
			return result;
		}

		/// <summary>
		///         Определяет неравенство двух <see cref="T:System.Security.Cryptography.CngProperty" /> объекта задают же имя свойства, значение и параметры.
		///       </summary>
		/// <param name="left">
		///           Объект, задающий свойство ключа криптографии следующего поколения (CNG) или поставщика.
		///         </param>
		/// <param name="right">
		///           Второй объект, который требуется сравнить с объектом, идентифицируемым параметром <paramref name="left" />.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если два объекта задают разные свойства; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x06000145 RID: 325 RVA: 0x00003645 File Offset: 0x00001845
		public static bool operator ==(CngProperty left, CngProperty right)
		{
			return left.Equals(right);
		}

		/// <summary>
		///         Определяет неравенство двух <see cref="T:System.Security.Cryptography.CngProperty" /> объекта задают же имя свойства, значение и параметры.
		///       </summary>
		/// <param name="left">
		///           Объект, задающий свойство ключа криптографии следующего поколения (CNG) или поставщика.
		///         </param>
		/// <param name="right">
		///           Второй объект, который требуется сравнить с объектом, идентифицируемым параметром <paramref name="left" />.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если два объекта задают разные свойства; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x06000146 RID: 326 RVA: 0x0000364F File Offset: 0x0000184F
		public static bool operator !=(CngProperty left, CngProperty right)
		{
			return !left.Equals(right);
		}

		/// <summary>
		///         Сравнивает заданный объект с текущим объектом <see cref="T:System.Security.Cryptography.CngProperty" />.
		///       </summary>
		/// <param name="obj">
		///           Объект, который требуется сравнить с текущим объектом <see cref="T:System.Security.Cryptography.CngProperty" />.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если <paramref name="obj" /> параметр <see cref="T:System.Security.Cryptography.CngProperty" /> объект, который указывает то же свойство, что и текущий объект; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x06000147 RID: 327 RVA: 0x0000365C File Offset: 0x0000185C
		public override bool Equals(object obj)
		{
			return obj != null && obj is CngProperty && this.Equals((CngProperty)obj);
		}

		/// <summary>
		///         Сравнивает заданный объект <see cref="T:System.Security.Cryptography.CngProperty" /> с текущим объектом <see cref="T:System.Security.Cryptography.CngProperty" />.
		///       </summary>
		/// <param name="other">
		///           Объект, который требуется сравнить с текущим объектом <see cref="T:System.Security.Cryptography.CngProperty" />.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если <paramref name="other" /> параметр представляет то же свойство, что и текущий объект; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x06000148 RID: 328 RVA: 0x00003678 File Offset: 0x00001878
		public bool Equals(CngProperty other)
		{
			if (!string.Equals(this.Name, other.Name, StringComparison.Ordinal))
			{
				return false;
			}
			if (this.Options != other.Options)
			{
				return false;
			}
			if (this.m_value == null)
			{
				return other.m_value == null;
			}
			if (other.m_value == null)
			{
				return false;
			}
			if (this.m_value.Length != other.m_value.Length)
			{
				return false;
			}
			for (int i = 0; i < this.m_value.Length; i++)
			{
				if (this.m_value[i] != other.m_value[i])
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>
		///         Создает хэш-значение для текущего <see cref="T:System.Security.Cryptography.CngProperty" /> объекта.
		///       </summary>
		/// <returns>
		///         Значение хэша текущего <see cref="T:System.Security.Cryptography.CngProperty" /> объекта.
		///       </returns>
		// Token: 0x06000149 RID: 329 RVA: 0x00003708 File Offset: 0x00001908
		public override int GetHashCode()
		{
			if (this.m_hashCode == null)
			{
				int num = this.Name.GetHashCode() ^ this.Options.GetHashCode();
				if (this.m_value != null)
				{
					for (int i = 0; i < this.m_value.Length; i++)
					{
						int num2 = (int)this.m_value[i] << i % 4 * 8;
						num ^= num2;
					}
				}
				this.m_hashCode = new int?(num);
			}
			return this.m_hashCode.Value;
		}

		// Token: 0x0400031D RID: 797
		private string m_name;

		// Token: 0x0400031E RID: 798
		private CngPropertyOptions m_propertyOptions;

		// Token: 0x0400031F RID: 799
		private byte[] m_value;

		// Token: 0x04000320 RID: 800
		private int? m_hashCode;
	}
}
