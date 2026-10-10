using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Security.Principal
{
	/// <summary>Представляет идентификатор безопасности (SID) и предоставляет операции маршалинга и сравнения для SID.</summary>
	// Token: 0x020004E7 RID: 1255
	[ComVisible(false)]
	public sealed class SecurityIdentifier : IdentityReference, IComparable<SecurityIdentifier>
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Principal.SecurityIdentifier" />, используя указанный идентификатор безопасности (ИД безопасности) в формате SDDL (Security Descriptor Definition Language).</summary>
		/// <param name="sddlForm">Строка SDDL для идентификатора безопасности, используемого для создания объекта <see cref="T:System.Security.Principal.SecurityIdentifier" />.</param>
		// Token: 0x06003214 RID: 12820 RVA: 0x000B7ECF File Offset: 0x000B60CF
		public SecurityIdentifier(string sddlForm)
		{
			if (sddlForm == null)
			{
				throw new ArgumentNullException("sddlForm");
			}
			this.buffer = SecurityIdentifier.ParseSddlForm(sddlForm);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Principal.SecurityIdentifier" />, используя указанное двоичное представление идентификатора безопасности (ИД безопасности).</summary>
		/// <param name="binaryForm">Массив байтов, представляющий ИД безопасности.</param>
		/// <param name="offset">Смещение в байтах, которое должно использоваться в качестве начального индекса в параметре <paramref name="binaryForm" />.</param>
		// Token: 0x06003215 RID: 12821 RVA: 0x000B7EF4 File Offset: 0x000B60F4
		public unsafe SecurityIdentifier(byte[] binaryForm, int offset)
		{
			if (binaryForm == null)
			{
				throw new ArgumentNullException("binaryForm");
			}
			if (offset < 0 || offset > binaryForm.Length - 2)
			{
				throw new ArgumentException("offset");
			}
			fixed (byte[] array = binaryForm)
			{
				byte* ptr;
				if (binaryForm == null || array.Length == 0)
				{
					ptr = null;
				}
				else
				{
					ptr = &array[0];
				}
				this.CreateFromBinaryForm((IntPtr)((void*)(ptr + offset)), binaryForm.Length - offset);
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Principal.SecurityIdentifier" />, используя целое число, представляющее двоичную форму идентификатора безопасности (ИД безопасности).</summary>
		/// <param name="binaryForm">Целое число, представляющее двоичную форму ИД безопасности.</param>
		// Token: 0x06003216 RID: 12822 RVA: 0x000B7F59 File Offset: 0x000B6159
		public SecurityIdentifier(IntPtr binaryForm)
		{
			this.CreateFromBinaryForm(binaryForm, int.MaxValue);
		}

		// Token: 0x06003217 RID: 12823 RVA: 0x000B7F70 File Offset: 0x000B6170
		private void CreateFromBinaryForm(IntPtr binaryForm, int length)
		{
			int num = (int)Marshal.ReadByte(binaryForm, 0);
			int num2 = (int)Marshal.ReadByte(binaryForm, 1);
			if (num != 1 || num2 > 15)
			{
				throw new ArgumentException("Value was invalid.");
			}
			if (length < 8 + num2 * 4)
			{
				throw new ArgumentException("offset");
			}
			this.buffer = new byte[8 + num2 * 4];
			Marshal.Copy(binaryForm, this.buffer, 0, this.buffer.Length);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Principal.SecurityIdentifier" />, используя указанные хорошо известный тип идентификатора безопасности (ИД безопасности) и ИД безопасности домена.</summary>
		/// <param name="sidType">Одно из значений перечисления. Это значение не должно быть равно <see cref="F:System.Security.Principal.WellKnownSidType.LogonIdsSid" />.</param>
		/// <param name="domainSid">ИД безопасности домена. Это значение требуется для указанных ниже значений <see cref="T:System.Security.Principal.WellKnownSidType" />. Для любых других значений <see cref="T:System.Security.Principal.WellKnownSidType" /> данный параметр игнорируется.  
		/// - <see cref="F:System.Security.Principal.WellKnownSidType.AccountAdministratorSid" />  
		/// - <see cref="F:System.Security.Principal.WellKnownSidType.AccountGuestSid" />  
		/// - <see cref="F:System.Security.Principal.WellKnownSidType.AccountKrbtgtSid" />  
		/// - <see cref="F:System.Security.Principal.WellKnownSidType.AccountDomainAdminsSid" />  
		/// - <see cref="F:System.Security.Principal.WellKnownSidType.AccountDomainUsersSid" />  
		/// - <see cref="F:System.Security.Principal.WellKnownSidType.AccountDomainGuestsSid" />  
		/// - <see cref="F:System.Security.Principal.WellKnownSidType.AccountComputersSid" />  
		/// - <see cref="F:System.Security.Principal.WellKnownSidType.AccountControllersSid" />  
		/// - <see cref="F:System.Security.Principal.WellKnownSidType.AccountCertAdminsSid" />  
		/// - <see cref="F:System.Security.Principal.WellKnownSidType.AccountSchemaAdminsSid" />  
		/// - <see cref="F:System.Security.Principal.WellKnownSidType.AccountEnterpriseAdminsSid" />  
		/// - <see cref="F:System.Security.Principal.WellKnownSidType.AccountPolicyAdminsSid" />  
		/// - <see cref="F:System.Security.Principal.WellKnownSidType.AccountRasAndIasServersSid" /></param>
		// Token: 0x06003218 RID: 12824 RVA: 0x000B7FD8 File Offset: 0x000B61D8
		public SecurityIdentifier(WellKnownSidType sidType, SecurityIdentifier domainSid)
		{
			WellKnownAccount wellKnownAccount = WellKnownAccount.LookupByType(sidType);
			if (wellKnownAccount == null)
			{
				throw new ArgumentException("Unable to convert SID type: " + sidType.ToString());
			}
			if (wellKnownAccount.IsAbsolute)
			{
				this.buffer = SecurityIdentifier.ParseSddlForm(wellKnownAccount.Sid);
				return;
			}
			if (domainSid == null)
			{
				throw new ArgumentNullException("domainSid");
			}
			this.buffer = SecurityIdentifier.ParseSddlForm(domainSid.Value + "-" + wellKnownAccount.Rid);
		}

		/// <summary>Возвращает часть идентификатора безопасности (ИД безопасности) домена учетных записей из ИД безопасности, представленного объектом <see cref="T:System.Security.Principal.SecurityIdentifier" />, если этот ИД безопасности представляет ИД безопасности учетной записи Windows. Если данный ИД безопасности не представляет ИД безопасности учетной записи Windows, это свойство возвращает <see cref="T:System.ArgumentNullException" />.</summary>
		/// <returns>Часть ИД безопасности домена учетных записей из ИД безопасности, представленного объектом <see cref="T:System.Security.Principal.SecurityIdentifier" />, если этот ИД безопасности представляет ИД безопасности учетной записи Windows; в противном случае возвращается <see cref="T:System.ArgumentNullException" />.</returns>
		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06003219 RID: 12825 RVA: 0x000B8064 File Offset: 0x000B6264
		public SecurityIdentifier AccountDomainSid
		{
			get
			{
				if (!this.Value.StartsWith("S-1-5-21") || this.buffer[1] < 4)
				{
					return null;
				}
				byte[] array = new byte[24];
				Array.Copy(this.buffer, 0, array, 0, array.Length);
				array[1] = 4;
				return new SecurityIdentifier(array, 0);
			}
		}

		/// <summary>Возвращает длину (в байтах) идентификатора безопасности (ИД безопасности), представленного объектом <see cref="T:System.Security.Principal.SecurityIdentifier" />.</summary>
		/// <returns>Длина (в байтах) ИД безопасности, представленного объектом <see cref="T:System.Security.Principal.SecurityIdentifier" />.</returns>
		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x0600321A RID: 12826 RVA: 0x000B80B4 File Offset: 0x000B62B4
		public int BinaryLength
		{
			get
			{
				return this.buffer.Length;
			}
		}

		/// <summary>Возвращает строку символов в верхнем регистре в формате SDDL (Security Descriptor Definition Language) для идентификатора безопасности (ИД безопасности), представленного данным объектом <see cref="T:System.Security.Principal.SecurityIdentifier" />.</summary>
		/// <returns>Строка символов в верхнем регистре в формате SDDL для ИД безопасности, представленного объектом <see cref="T:System.Security.Principal.SecurityIdentifier" />.</returns>
		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x0600321B RID: 12827 RVA: 0x000B80C0 File Offset: 0x000B62C0
		public override string Value
		{
			get
			{
				StringBuilder stringBuilder = new StringBuilder();
				ulong sidAuthority = this.GetSidAuthority();
				stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "S-1-{0}", sidAuthority);
				for (byte b = 0; b < this.GetSidSubAuthorityCount(); b += 1)
				{
					stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "-{0}", this.GetSidSubAuthority(b));
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x0600321C RID: 12828 RVA: 0x000B8128 File Offset: 0x000B6328
		private ulong GetSidAuthority()
		{
			return (ulong)this.buffer[2] << 40 | (ulong)this.buffer[3] << 32 | (ulong)this.buffer[4] << 24 | (ulong)this.buffer[5] << 16 | (ulong)this.buffer[6] << 8 | (ulong)this.buffer[7];
		}

		// Token: 0x0600321D RID: 12829 RVA: 0x000B817E File Offset: 0x000B637E
		private byte GetSidSubAuthorityCount()
		{
			return this.buffer[1];
		}

		// Token: 0x0600321E RID: 12830 RVA: 0x000B8188 File Offset: 0x000B6388
		private uint GetSidSubAuthority(byte index)
		{
			int num = (int)(8 + index * 4);
			return (uint)((int)this.buffer[num] | (int)this.buffer[num + 1] << 8 | (int)this.buffer[num + 2] << 16 | (int)this.buffer[num + 3] << 24);
		}

		/// <summary>Сравнивает текущий объект <see cref="T:System.Security.Principal.SecurityIdentifier" /> с заданным объектом <see cref="T:System.Security.Principal.SecurityIdentifier" />.</summary>
		/// <param name="sid">Объект, который требуется сравнить с текущим объектом.</param>
		/// <returns>Знаковое число, представляющее относительные значения этого экземпляра и параметра <paramref name="sid" />.  
		///   Возвращаемое значение 
		///   Описание: 
		///   Меньше нуля 
		///   Этот экземпляр меньше параметра <paramref name="sid" />.  
		///
		///   Нуль 
		///   Этот экземпляр и параметр <paramref name="sid" /> равны.  
		///
		///   Больше нуля 
		///   Этот экземпляр больше параметра <paramref name="sid" />.</returns>
		// Token: 0x0600321F RID: 12831 RVA: 0x000B81CC File Offset: 0x000B63CC
		public int CompareTo(SecurityIdentifier sid)
		{
			if (sid == null)
			{
				throw new ArgumentNullException("sid");
			}
			int result;
			if ((result = this.GetSidAuthority().CompareTo(sid.GetSidAuthority())) != 0)
			{
				return result;
			}
			if ((result = this.GetSidSubAuthorityCount().CompareTo(sid.GetSidSubAuthorityCount())) != 0)
			{
				return result;
			}
			for (byte b = 0; b < this.GetSidSubAuthorityCount(); b += 1)
			{
				if ((result = this.GetSidSubAuthority(b).CompareTo(sid.GetSidSubAuthority(b))) != 0)
				{
					return result;
				}
			}
			return 0;
		}

		/// <summary>Возвращает значение, показывающее, равен ли данный объект <see cref="T:System.Security.Principal.SecurityIdentifier" /> указанному объекту.</summary>
		/// <param name="o">Объект, сравниваемый с данным объектом <see cref="T:System.Security.Principal.SecurityIdentifier" />, или значение <see langword="null" />.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="o" /> является объектом того же базового типа и значения, что и данный объект <see cref="T:System.Security.Principal.SecurityIdentifier" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06003220 RID: 12832 RVA: 0x000B8251 File Offset: 0x000B6451
		public override bool Equals(object o)
		{
			return this.Equals(o as SecurityIdentifier);
		}

		/// <summary>Показывает, равен ли заданный объект <see cref="T:System.Security.Principal.SecurityIdentifier" /> текущему объекту <see cref="T:System.Security.Principal.SecurityIdentifier" />.</summary>
		/// <param name="sid">Объект, который требуется сравнить с текущим объектом.</param>
		/// <returns>
		///   <see langword="true" />, если значение <paramref name="sid" /> равно значению текущего объекта <see cref="T:System.Security.Principal.SecurityIdentifier" />.</returns>
		// Token: 0x06003221 RID: 12833 RVA: 0x000B825F File Offset: 0x000B645F
		public bool Equals(SecurityIdentifier sid)
		{
			return !(sid == null) && sid.Value == this.Value;
		}

		/// <summary>Копирует двоичное представление указанного идентификатора безопасности (ИД безопасности), представленного классом <see cref="T:System.Security.Principal.SecurityIdentifier" />, в массив байтов.</summary>
		/// <param name="binaryForm">Массив байтов для копируемого ИД безопасности.</param>
		/// <param name="offset">Смещение в байтах, которое должно использоваться в качестве начального индекса в параметре <paramref name="binaryForm" />.</param>
		// Token: 0x06003222 RID: 12834 RVA: 0x000B8280 File Offset: 0x000B6480
		public void GetBinaryForm(byte[] binaryForm, int offset)
		{
			if (binaryForm == null)
			{
				throw new ArgumentNullException("binaryForm");
			}
			if (offset < 0 || offset > binaryForm.Length - this.buffer.Length)
			{
				throw new ArgumentException("offset");
			}
			Array.Copy(this.buffer, 0, binaryForm, offset, this.buffer.Length);
		}

		/// <summary>Служит в качестве хэш-функции для текущего объекта <see cref="T:System.Security.Principal.SecurityIdentifier" />. Метод <see cref="M:System.Security.Principal.SecurityIdentifier.GetHashCode" /> подходит для алгоритмов хэширования и структур данных, таких как хэш-таблицы.</summary>
		/// <returns>Хэш-значение для текущего объекта <see cref="T:System.Security.Principal.SecurityIdentifier" />.</returns>
		// Token: 0x06003223 RID: 12835 RVA: 0x000B7E14 File Offset: 0x000B6014
		public override int GetHashCode()
		{
			return this.Value.GetHashCode();
		}

		/// <summary>Возвращает значение, показывающее, является ли идентификатор безопасности (ИД безопасности), представленный данным объектом <see cref="T:System.Security.Principal.SecurityIdentifier" />, допустимым ИД безопасности учетной записи Windows.</summary>
		/// <returns>
		///   <see langword="true" />, если ИД безопасности, представленный данным объектом <see cref="T:System.Security.Principal.SecurityIdentifier" />, является допустимым ИД безопасности учетной записи Windows; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06003224 RID: 12836 RVA: 0x000B82CF File Offset: 0x000B64CF
		public bool IsAccountSid()
		{
			return this.AccountDomainSid != null;
		}

		/// <summary>Возвращает значение, показывающее, относится ли идентификатор безопасности (ИД безопасности), представленный данным объектом <see cref="T:System.Security.Principal.SecurityIdentifier" />, к тому же домену, что и заданный ИД безопасности.</summary>
		/// <param name="sid">ИД безопасности, который требуется сравнить с данным объектом <see cref="T:System.Security.Principal.SecurityIdentifier" />.</param>
		/// <returns>
		///   <see langword="true" />, если ИД безопасности, представленный данным объектом <see cref="T:System.Security.Principal.SecurityIdentifier" />, относится к тому же домену, что и ИД безопасности <paramref name="sid" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06003225 RID: 12837 RVA: 0x000B82E0 File Offset: 0x000B64E0
		public bool IsEqualDomainSid(SecurityIdentifier sid)
		{
			SecurityIdentifier accountDomainSid = this.AccountDomainSid;
			return !(accountDomainSid == null) && accountDomainSid.Equals(sid.AccountDomainSid);
		}

		/// <summary>Возвращает значение, показывающее, является ли указанный тип допустимым типом преобразования для класса <see cref="T:System.Security.Principal.SecurityIdentifier" />.</summary>
		/// <param name="targetType">Тип, допустимость использования которого в качестве типа преобразования из класса <see cref="T:System.Security.Principal.SecurityIdentifier" /> требуется проверить. Допустимы следующие типы целевого объекта: 
		/// - <see cref="T:System.Security.Principal.NTAccount" />  
		/// - <see cref="T:System.Security.Principal.SecurityIdentifier" /></param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="targetType" /> является допустимым типом преобразования для класса <see cref="T:System.Security.Principal.SecurityIdentifier" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06003226 RID: 12838 RVA: 0x000B830B File Offset: 0x000B650B
		public override bool IsValidTargetType(Type targetType)
		{
			return targetType == typeof(SecurityIdentifier) || targetType == typeof(NTAccount);
		}

		/// <summary>Возвращает значение, показывающее, соответствует ли объект <see cref="T:System.Security.Principal.SecurityIdentifier" /> заданному хорошо известному типу идентификатора безопасности (ИД безопасности).</summary>
		/// <param name="type">Значение, которое требуется сравнить с объектом <see cref="T:System.Security.Principal.SecurityIdentifier" />.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="type" /> — тип ИД безопасности для объекта <see cref="T:System.Security.Principal.SecurityIdentifier" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06003227 RID: 12839 RVA: 0x000B8338 File Offset: 0x000B6538
		public bool IsWellKnown(WellKnownSidType type)
		{
			WellKnownAccount wellKnownAccount = WellKnownAccount.LookupByType(type);
			if (wellKnownAccount == null)
			{
				return false;
			}
			string value = this.Value;
			if (wellKnownAccount.IsAbsolute)
			{
				return value == wellKnownAccount.Sid;
			}
			return value.StartsWith("S-1-5-21", StringComparison.OrdinalIgnoreCase) && value.EndsWith("-" + wellKnownAccount.Rid, StringComparison.OrdinalIgnoreCase);
		}

		/// <summary>Возвращает идентификатор безопасности (ИД безопасности) в формате SDDL (Security Descriptor Definition Language) для учетной записи, представленной объектом <see cref="T:System.Security.Principal.SecurityIdentifier" />. Пример формата SDDL — S-1-5-9.</summary>
		/// <returns>ИД безопасности в формате SDDL для учетной записи, представленной объектом <see cref="T:System.Security.Principal.SecurityIdentifier" />.</returns>
		// Token: 0x06003228 RID: 12840 RVA: 0x000B7E4C File Offset: 0x000B604C
		public override string ToString()
		{
			return this.Value;
		}

		/// <summary>Преобразует имя учетной записи, представленное объектом <see cref="T:System.Security.Principal.SecurityIdentifier" />, в другой тип, производный от <see cref="T:System.Security.Principal.IdentityReference" />.</summary>
		/// <param name="targetType">Тип целевого объекта для преобразования из объекта <see cref="T:System.Security.Principal.SecurityIdentifier" />. Типом целевого объекта должен быть тип, допустимый для использования в качестве аргумента метода <see cref="M:System.Security.Principal.SecurityIdentifier.IsValidTargetType(System.Type)" />.</param>
		/// <returns>Преобразованное удостоверение.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="targetType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="targetType" /> не является типом <see cref="T:System.Security.Principal.IdentityReference" />.</exception>
		/// <exception cref="T:System.Security.Principal.IdentityNotMappedException">Некоторые или ссылки на свойства нельзя преобразовать.</exception>
		/// <exception cref="T:System.SystemException">Возвращен код ошибки Win32.</exception>
		// Token: 0x06003229 RID: 12841 RVA: 0x000B8394 File Offset: 0x000B6594
		public override IdentityReference Translate(Type targetType)
		{
			if (targetType == typeof(SecurityIdentifier))
			{
				return this;
			}
			if (!(targetType == typeof(NTAccount)))
			{
				throw new ArgumentException("Unknown type.", "targetType");
			}
			WellKnownAccount wellKnownAccount = WellKnownAccount.LookupBySid(this.Value);
			if (wellKnownAccount == null || wellKnownAccount.Name == null)
			{
				throw new IdentityNotMappedException("Unable to map SID: " + this.Value);
			}
			return new NTAccount(wellKnownAccount.Name);
		}

		/// <summary>Сравнивает два объекта <see cref="T:System.Security.Principal.SecurityIdentifier" /> на равенство. Объекты считаются равными, если их каноническое представление совпадает с представлением, возвращаемым свойством <see cref="P:System.Security.Principal.SecurityIdentifier.Value" />, или оба объекта имеют значение <see langword="null" />.</summary>
		/// <param name="left">Левый операнд, используемый для сравнения в отношении равенства. Этот параметр может иметь значение <see langword="null" />.</param>
		/// <param name="right">Правый операнд, используемый для сравнения в отношении равенства. Этот параметр может иметь значение <see langword="null" />.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="left" /> и <paramref name="right" /> равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600322A RID: 12842 RVA: 0x000B7BB0 File Offset: 0x000B5DB0
		public static bool operator ==(SecurityIdentifier left, SecurityIdentifier right)
		{
			if (left == null)
			{
				return right == null;
			}
			return right != null && left.Value == right.Value;
		}

		/// <summary>Сравнивает два объекта <see cref="T:System.Security.Principal.SecurityIdentifier" /> на неравенство. Объекты считаются неравными, если их канонические представления имени отличаются от представления, возвращаемого свойством <see cref="P:System.Security.Principal.SecurityIdentifier.Value" />, или один из объектов имеет значение <see langword="null" />, а другой объект имеет другое значение.</summary>
		/// <param name="left">Левый операнд, используемый для сравнения в отношении неравенства. Этот параметр может иметь значение <see langword="null" />.</param>
		/// <param name="right">Правый операнд, используемый для сравнения в отношении неравенства. Этот параметр может иметь значение <see langword="null" />.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="left" /> и <paramref name="right" /> не равны друг другу; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600322B RID: 12843 RVA: 0x000B7BD0 File Offset: 0x000B5DD0
		public static bool operator !=(SecurityIdentifier left, SecurityIdentifier right)
		{
			if (left == null)
			{
				return right != null;
			}
			return right == null || left.Value != right.Value;
		}

		// Token: 0x0600322C RID: 12844 RVA: 0x000B8410 File Offset: 0x000B6610
		internal string GetSddlForm()
		{
			string value = this.Value;
			WellKnownAccount wellKnownAccount = WellKnownAccount.LookupBySid(value);
			if (wellKnownAccount == null || wellKnownAccount.SddlForm == null)
			{
				return value;
			}
			return wellKnownAccount.SddlForm;
		}

		// Token: 0x0600322D RID: 12845 RVA: 0x000B8440 File Offset: 0x000B6640
		internal static SecurityIdentifier ParseSddlForm(string sddlForm, ref int pos)
		{
			if (sddlForm.Length - pos < 2)
			{
				throw new ArgumentException("Invalid SDDL string.", "sddlForm");
			}
			string text = sddlForm.Substring(pos, 2).ToUpperInvariant();
			string sddlForm2;
			int num2;
			if (text == "S-")
			{
				int num = pos;
				char c = char.ToUpperInvariant(sddlForm[num]);
				while (c == 'S' || c == '-' || c == 'X' || (c >= '0' && c <= '9') || (c >= 'A' && c <= 'F'))
				{
					num++;
					c = char.ToUpperInvariant(sddlForm[num]);
				}
				if (c == ':' && sddlForm[num - 1] == 'D')
				{
					num--;
				}
				sddlForm2 = sddlForm.Substring(pos, num - pos);
				num2 = num - pos;
			}
			else
			{
				sddlForm2 = text;
				num2 = 2;
			}
			SecurityIdentifier result = new SecurityIdentifier(sddlForm2);
			pos += num2;
			return result;
		}

		// Token: 0x0600322E RID: 12846 RVA: 0x000B8510 File Offset: 0x000B6710
		private static byte[] ParseSddlForm(string sddlForm)
		{
			string text = sddlForm;
			if (sddlForm.Length == 2)
			{
				WellKnownAccount wellKnownAccount = WellKnownAccount.LookupBySddlForm(sddlForm);
				if (wellKnownAccount == null)
				{
					throw new ArgumentException("Invalid SDDL string - unrecognized account: " + sddlForm, "sddlForm");
				}
				if (!wellKnownAccount.IsAbsolute)
				{
					throw new NotImplementedException("Mono unable to convert account to SID: " + ((wellKnownAccount.Name != null) ? wellKnownAccount.Name : sddlForm));
				}
				text = wellKnownAccount.Sid;
			}
			string[] array = text.ToUpperInvariant().Split('-', StringSplitOptions.None);
			int num = array.Length - 3;
			if (array.Length < 3 || array[0] != "S" || num > 15)
			{
				throw new ArgumentException("Value was invalid.");
			}
			if (array[1] != "1")
			{
				throw new ArgumentException("Only SIDs with revision 1 are supported");
			}
			byte[] array2 = new byte[8 + num * 4];
			array2[0] = 1;
			array2[1] = (byte)num;
			ulong num2;
			if (!SecurityIdentifier.TryParseAuthority(array[2], out num2))
			{
				throw new ArgumentException("Value was invalid.");
			}
			array2[2] = (byte)(num2 >> 40 & 255UL);
			array2[3] = (byte)(num2 >> 32 & 255UL);
			array2[4] = (byte)(num2 >> 24 & 255UL);
			array2[5] = (byte)(num2 >> 16 & 255UL);
			array2[6] = (byte)(num2 >> 8 & 255UL);
			array2[7] = (byte)(num2 & 255UL);
			for (int i = 0; i < num; i++)
			{
				uint num3;
				if (!SecurityIdentifier.TryParseSubAuthority(array[i + 3], out num3))
				{
					throw new ArgumentException("Value was invalid.");
				}
				int num4 = 8 + i * 4;
				array2[num4] = (byte)num3;
				array2[num4 + 1] = (byte)(num3 >> 8);
				array2[num4 + 2] = (byte)(num3 >> 16);
				array2[num4 + 3] = (byte)(num3 >> 24);
			}
			return array2;
		}

		// Token: 0x0600322F RID: 12847 RVA: 0x000B86B6 File Offset: 0x000B68B6
		private static bool TryParseAuthority(string s, out ulong result)
		{
			if (s.StartsWith("0X"))
			{
				return ulong.TryParse(s.Substring(2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out result);
			}
			return ulong.TryParse(s, NumberStyles.Integer, CultureInfo.InvariantCulture, out result);
		}

		// Token: 0x06003230 RID: 12848 RVA: 0x000B86EA File Offset: 0x000B68EA
		private static bool TryParseSubAuthority(string s, out uint result)
		{
			if (s.StartsWith("0X"))
			{
				return uint.TryParse(s.Substring(2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out result);
			}
			return uint.TryParse(s, NumberStyles.Integer, CultureInfo.InvariantCulture, out result);
		}

		// Token: 0x040022C2 RID: 8898
		private byte[] buffer;

		/// <summary>Возвращает максимальный размер (в байтах) двоичного представления идентификатора безопасности.</summary>
		// Token: 0x040022C3 RID: 8899
		public static readonly int MaxBinaryLength = 68;

		/// <summary>Возвращает минимальный размер (в байтах) двоичного представления идентификатора безопасности.</summary>
		// Token: 0x040022C4 RID: 8900
		public static readonly int MinBinaryLength = 8;
	}
}
