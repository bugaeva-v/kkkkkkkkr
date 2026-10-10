using System;
using System.Runtime.InteropServices;

namespace System.Security.Principal
{
	/// <summary>Представляет учетную запись пользователя или группы.</summary>
	// Token: 0x020004E6 RID: 1254
	[ComVisible(false)]
	public sealed class NTAccount : IdentityReference
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Principal.NTAccount" />, используя указанное имя.</summary>
		/// <param name="name">Имя, используемое для создания объекта <see cref="T:System.Security.Principal.NTAccount" />. Этот параметр не может иметь значение <see langword="null" /> или являться пустой строкой.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> равен пустой строке.  
		///
		/// или - 
		/// Параметр <paramref name="name" /> имеет слишком большую длину.</exception>
		// Token: 0x0600320A RID: 12810 RVA: 0x000B7D44 File Offset: 0x000B5F44
		public NTAccount(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (name.Length == 0)
			{
				throw new ArgumentException(Locale.GetText("Empty"), "name");
			}
			this._value = name;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Principal.NTAccount" />, используя указанные имя домена и имя учетной записи.</summary>
		/// <param name="domainName">Имя домена. Этот параметр может иметь значение <see langword="null" /> или являться пустой строкой. Имена доменов, имеющие значения NULL, обрабатываются аналогично пустой строке.</param>
		/// <param name="accountName">Имя учетной записи. Этот параметр не может иметь значение <see langword="null" /> или являться пустой строкой.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="accountName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="accountName" /> равен пустой строке.  
		///
		/// или - 
		/// Параметр <paramref name="accountName" /> имеет слишком большую длину.  
		///
		/// или - 
		/// Параметр <paramref name="domainName" /> имеет слишком большую длину.</exception>
		// Token: 0x0600320B RID: 12811 RVA: 0x000B7D80 File Offset: 0x000B5F80
		public NTAccount(string domainName, string accountName)
		{
			if (accountName == null)
			{
				throw new ArgumentNullException("accountName");
			}
			if (accountName.Length == 0)
			{
				throw new ArgumentException(Locale.GetText("Empty"), "accountName");
			}
			if (domainName == null)
			{
				this._value = accountName;
				return;
			}
			this._value = domainName + "\\" + accountName;
		}

		/// <summary>Возвращает строковое представление (в верхнем регистре) данного объекта <see cref="T:System.Security.Principal.NTAccount" />.</summary>
		/// <returns>Строковое представление (в верхнем регистре) данного объекта <see cref="T:System.Security.Principal.NTAccount" />.</returns>
		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x0600320C RID: 12812 RVA: 0x000B7DDB File Offset: 0x000B5FDB
		public override string Value
		{
			get
			{
				return this._value;
			}
		}

		/// <summary>Возвращает значение, показывающее, равен ли данный объект <see cref="T:System.Security.Principal.NTAccount" /> указанному объекту.</summary>
		/// <param name="o">Объект, сравниваемый с данным объектом <see cref="T:System.Security.Principal.NTAccount" />, или значение <see langword="null" />.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="o" /> является объектом того же базового типа и значения, что и данный объект <see cref="T:System.Security.Principal.NTAccount" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600320D RID: 12813 RVA: 0x000B7DE4 File Offset: 0x000B5FE4
		public override bool Equals(object o)
		{
			NTAccount ntaccount = o as NTAccount;
			return !(ntaccount == null) && ntaccount.Value == this.Value;
		}

		/// <summary>Служит в качестве хэш-функции для текущего объекта <see cref="T:System.Security.Principal.NTAccount" />. Метод <see cref="M:System.Security.Principal.NTAccount.GetHashCode" /> подходит для алгоритмов хэширования и структур данных, таких как хэш-таблицы.</summary>
		/// <returns>Хэш-значение для текущего объекта <see cref="T:System.Security.Principal.NTAccount" />.</returns>
		// Token: 0x0600320E RID: 12814 RVA: 0x000B7E14 File Offset: 0x000B6014
		public override int GetHashCode()
		{
			return this.Value.GetHashCode();
		}

		/// <summary>Возвращает значение, показывающее, является ли указанный тип допустимым типом преобразования для класса <see cref="T:System.Security.Principal.NTAccount" />.</summary>
		/// <param name="targetType">Тип, допустимость использования которого в качестве типа преобразования из класса <see cref="T:System.Security.Principal.NTAccount" /> требуется проверить. Допустимы следующие типы целевого объекта: 
		/// - <see cref="T:System.Security.Principal.NTAccount" />  
		/// - <see cref="T:System.Security.Principal.SecurityIdentifier" /></param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="targetType" /> является допустимым типом преобразования для класса <see cref="T:System.Security.Principal.NTAccount" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600320F RID: 12815 RVA: 0x000B7E21 File Offset: 0x000B6021
		public override bool IsValidTargetType(Type targetType)
		{
			return targetType == typeof(NTAccount) || targetType == typeof(SecurityIdentifier);
		}

		/// <summary>Возвращает имя учетной записи в формате домен \ учетная запись для учетной записи, представленной объектом <see cref="T:System.Security.Principal.NTAccount" />.</summary>
		/// <returns>Имя учетной записи в формате домен \ учетная запись.</returns>
		// Token: 0x06003210 RID: 12816 RVA: 0x000B7E4C File Offset: 0x000B604C
		public override string ToString()
		{
			return this.Value;
		}

		/// <summary>Преобразует имя учетной записи, представленное объектом <see cref="T:System.Security.Principal.NTAccount" />, в другой тип, производный от <see cref="T:System.Security.Principal.IdentityReference" />.</summary>
		/// <param name="targetType">Тип целевого объекта для преобразования из объекта <see cref="T:System.Security.Principal.NTAccount" />. Типом целевого объекта должен быть тип, допустимый для использования в качестве аргумента метода <see cref="M:System.Security.Principal.NTAccount.IsValidTargetType(System.Type)" />.</param>
		/// <returns>Преобразованное удостоверение.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="targetType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="targetType" /> не является типом <see cref="T:System.Security.Principal.IdentityReference" />.</exception>
		/// <exception cref="T:System.Security.Principal.IdentityNotMappedException">Некоторые или ссылки на свойства нельзя преобразовать.</exception>
		/// <exception cref="T:System.SystemException">Исходное имя учетной записи слишком длинное.  
		///
		/// или - 
		/// Возвращен код ошибки Win32.</exception>
		// Token: 0x06003211 RID: 12817 RVA: 0x000B7E54 File Offset: 0x000B6054
		public override IdentityReference Translate(Type targetType)
		{
			if (targetType == typeof(NTAccount))
			{
				return this;
			}
			if (!(targetType == typeof(SecurityIdentifier)))
			{
				throw new ArgumentException("Unknown type", "targetType");
			}
			WellKnownAccount wellKnownAccount = WellKnownAccount.LookupByName(this.Value);
			if (wellKnownAccount == null || wellKnownAccount.Sid == null)
			{
				throw new IdentityNotMappedException("Cannot map account name: " + this.Value);
			}
			return new SecurityIdentifier(wellKnownAccount.Sid);
		}

		/// <summary>Сравнивает два объекта <see cref="T:System.Security.Principal.NTAccount" /> на равенство. Объекты считаются равными, если их каноническое представление имени совпадает с представлением, возвращаемым свойством <see cref="P:System.Security.Principal.NTAccount.Value" />, или значения обоих объектов равны <see langword="null" />.</summary>
		/// <param name="left">Левый операнд, используемый для сравнения в отношении равенства. Этот параметр может иметь значение <see langword="null" />.</param>
		/// <param name="right">Правый операнд, используемый для сравнения в отношении равенства. Этот параметр может иметь значение <see langword="null" />.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="left" /> и <paramref name="right" /> равны; в ином случае — <see langword="false" />.</returns>
		// Token: 0x06003212 RID: 12818 RVA: 0x000B7BB0 File Offset: 0x000B5DB0
		public static bool operator ==(NTAccount left, NTAccount right)
		{
			if (left == null)
			{
				return right == null;
			}
			return right != null && left.Value == right.Value;
		}

		/// <summary>Сравнивает два объекта <see cref="T:System.Security.Principal.NTAccount" /> на неравенство. Объекты считаются неравными, если их канонические представления имени отличаются от представления, возвращаемого свойством <see cref="P:System.Security.Principal.NTAccount.Value" />, или один из объектов имеет значение <see langword="null" />, а другой объект имеет другое значение.</summary>
		/// <param name="left">Левый операнд, используемый для сравнения в отношении неравенства. Этот параметр может иметь значение <see langword="null" />.</param>
		/// <param name="right">Правый операнд, используемый для сравнения в отношении неравенства. Этот параметр может иметь значение <see langword="null" />.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="left" /> и <paramref name="right" /> не равны; в ином случае — <see langword="false" />.</returns>
		// Token: 0x06003213 RID: 12819 RVA: 0x000B7BD0 File Offset: 0x000B5DD0
		public static bool operator !=(NTAccount left, NTAccount right)
		{
			if (left == null)
			{
				return right != null;
			}
			return right == null || left.Value != right.Value;
		}

		// Token: 0x040022C1 RID: 8897
		private string _value;
	}
}
