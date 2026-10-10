using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Permissions;
using System.Security.Principal;

namespace System.Security.Claims
{
	/// <summary>Предоставляет удостоверение на основе утверждений.</summary>
	// Token: 0x020004F3 RID: 1267
	[ComVisible(true)]
	[Serializable]
	public class ClaimsIdentity : IIdentity
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Claims.ClaimsIdentity" /> с пустой коллекцией требований.</summary>
		// Token: 0x0600329D RID: 12957 RVA: 0x000BA201 File Offset: 0x000B8401
		public ClaimsIdentity() : this(null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Claims.ClaimsIdentity" />, используя имя и тип аутентификации из заданного объекта <see cref="T:System.Security.Principal.IIdentity" />.</summary>
		/// <param name="identity">Удостоверение, из которого следует создать новое удостоверение утверждений.</param>
		// Token: 0x0600329E RID: 12958 RVA: 0x000BA20A File Offset: 0x000B840A
		public ClaimsIdentity(IIdentity identity) : this(identity, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Claims.ClaimsIdentity" />, используя перечисляемую коллекцию объектов <see cref="T:System.Security.Claims.Claim" />.</summary>
		/// <param name="claims">Утверждения, которыми будет заполняться удостоверение утверждений.</param>
		// Token: 0x0600329F RID: 12959 RVA: 0x000BA214 File Offset: 0x000B8414
		public ClaimsIdentity(IEnumerable<Claim> claims) : this(null, claims, null, null, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Claims.ClaimsIdentity" /> пустой коллекцией требований и указанным типом аутентификации.</summary>
		/// <param name="authenticationType">Тип используемой аутентификации.</param>
		// Token: 0x060032A0 RID: 12960 RVA: 0x000BA221 File Offset: 0x000B8421
		public ClaimsIdentity(string authenticationType) : this(null, null, authenticationType, null, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Claims.ClaimsIdentity" /> с указанными требованиями и типом аутентификации.</summary>
		/// <param name="claims">Утверждения, которыми будет заполняться удостоверение утверждений.</param>
		/// <param name="authenticationType">Тип используемой аутентификации.</param>
		// Token: 0x060032A1 RID: 12961 RVA: 0x000BA22E File Offset: 0x000B842E
		public ClaimsIdentity(IEnumerable<Claim> claims, string authenticationType) : this(null, claims, authenticationType, null, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Claims.ClaimsIdentity" />, используя указанные требования и заданный объект <see cref="T:System.Security.Principal.IIdentity" />.</summary>
		/// <param name="identity">Удостоверение, из которого следует создать новое удостоверение утверждений.</param>
		/// <param name="claims">Утверждения, которыми будет заполняться удостоверение утверждений.</param>
		// Token: 0x060032A2 RID: 12962 RVA: 0x000BA23B File Offset: 0x000B843B
		public ClaimsIdentity(IIdentity identity, IEnumerable<Claim> claims) : this(identity, claims, null, null, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Claims.ClaimsIdentity" /> с указанным типом аутентификации, типом требования имени и типом требования роли.</summary>
		/// <param name="authenticationType">Тип используемой аутентификации.</param>
		/// <param name="nameType">Тип утверждения, используемый для утверждений имен.</param>
		/// <param name="roleType">Тип утверждения, используемый для утверждений ролей.</param>
		// Token: 0x060032A3 RID: 12963 RVA: 0x000BA248 File Offset: 0x000B8448
		public ClaimsIdentity(string authenticationType, string nameType, string roleType) : this(null, null, authenticationType, nameType, roleType)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Claims.ClaimsIdentity" /> указанными требованиями, типом аутентификации, типом требования имени и типом требования роли.</summary>
		/// <param name="claims">Утверждения, которыми будет заполняться удостоверение утверждений.</param>
		/// <param name="authenticationType">Тип используемой аутентификации.</param>
		/// <param name="nameType">Тип утверждения, используемый для утверждений имен.</param>
		/// <param name="roleType">Тип утверждения, используемый для утверждений ролей.</param>
		// Token: 0x060032A4 RID: 12964 RVA: 0x000BA255 File Offset: 0x000B8455
		public ClaimsIdentity(IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType) : this(null, claims, authenticationType, nameType, roleType)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Claims.ClaimsIdentity" /> из указанного <see cref="T:System.Security.Principal.IIdentity" />, используя указанные требования, тип аутентификации, тип требования имени и тип требования роли.</summary>
		/// <param name="identity">Удостоверение, из которого следует создать новое удостоверение утверждений.</param>
		/// <param name="claims">Утверждения, которыми будет заполняться новое удостоверение утверждений.</param>
		/// <param name="authenticationType">Тип используемой аутентификации.</param>
		/// <param name="nameType">Тип утверждения, используемый для утверждений имен.</param>
		/// <param name="roleType">Тип утверждения, используемый для утверждений ролей.</param>
		// Token: 0x060032A5 RID: 12965 RVA: 0x000BA263 File Offset: 0x000B8463
		public ClaimsIdentity(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType) : this(identity, claims, authenticationType, nameType, roleType, true)
		{
		}

		// Token: 0x060032A6 RID: 12966 RVA: 0x000BA274 File Offset: 0x000B8474
		internal ClaimsIdentity(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType, bool checkAuthType)
		{
			this.m_instanceClaims = new List<Claim>();
			this.m_externalClaims = new Collection<IEnumerable<Claim>>();
			this.m_nameType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name";
			this.m_roleType = "http://schemas.microsoft.com/ws/2008/06/identity/claims/role";
			this.m_version = "1.0";
			base..ctor();
			bool flag = false;
			bool flag2 = false;
			if (checkAuthType && identity != null && string.IsNullOrEmpty(authenticationType))
			{
				if (identity is WindowsIdentity)
				{
					try
					{
						this.m_authenticationType = identity.AuthenticationType;
						goto IL_85;
					}
					catch (UnauthorizedAccessException)
					{
						this.m_authenticationType = null;
						goto IL_85;
					}
				}
				this.m_authenticationType = identity.AuthenticationType;
			}
			else
			{
				this.m_authenticationType = authenticationType;
			}
			IL_85:
			if (!string.IsNullOrEmpty(nameType))
			{
				this.m_nameType = nameType;
				flag = true;
			}
			if (!string.IsNullOrEmpty(roleType))
			{
				this.m_roleType = roleType;
				flag2 = true;
			}
			ClaimsIdentity claimsIdentity = identity as ClaimsIdentity;
			if (claimsIdentity != null)
			{
				this.m_label = claimsIdentity.m_label;
				if (!flag)
				{
					this.m_nameType = claimsIdentity.m_nameType;
				}
				if (!flag2)
				{
					this.m_roleType = claimsIdentity.m_roleType;
				}
				this.m_bootstrapContext = claimsIdentity.m_bootstrapContext;
				if (claimsIdentity.Actor != null)
				{
					if (this.IsCircular(claimsIdentity.Actor))
					{
						throw new InvalidOperationException(Environment.GetResourceString("Actor cannot be set so that circular directed graph will exist chaining the subjects together."));
					}
					if (!AppContextSwitches.SetActorAsReferenceWhenCopyingClaimsIdentity)
					{
						this.m_actor = claimsIdentity.Actor.Clone();
					}
					else
					{
						this.m_actor = claimsIdentity.Actor;
					}
				}
				if (claimsIdentity is WindowsIdentity && !(this is WindowsIdentity))
				{
					this.SafeAddClaims(claimsIdentity.Claims);
				}
				else
				{
					this.SafeAddClaims(claimsIdentity.m_instanceClaims);
				}
				if (claimsIdentity.m_userSerializationData != null)
				{
					this.m_userSerializationData = (claimsIdentity.m_userSerializationData.Clone() as byte[]);
				}
			}
			else if (identity != null && !string.IsNullOrEmpty(identity.Name))
			{
				this.SafeAddClaim(new Claim(this.m_nameType, identity.Name, "http://www.w3.org/2001/XMLSchema#string", "LOCAL AUTHORITY", "LOCAL AUTHORITY", this));
			}
			if (claims != null)
			{
				this.SafeAddClaims(claims);
			}
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Security.Claims.ClaimsIdentity" /> с указанным <see cref="T:System.IO.BinaryReader" />.</summary>
		/// <param name="reader">Объект <see cref="T:System.IO.BinaryReader" />, указывающий на <see cref="T:System.Security.Claims.ClaimsIdentity" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="reader" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060032A7 RID: 12967 RVA: 0x000BA458 File Offset: 0x000B8658
		public ClaimsIdentity(BinaryReader reader)
		{
			this.m_instanceClaims = new List<Claim>();
			this.m_externalClaims = new Collection<IEnumerable<Claim>>();
			this.m_nameType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name";
			this.m_roleType = "http://schemas.microsoft.com/ws/2008/06/identity/claims/role";
			this.m_version = "1.0";
			base..ctor();
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			this.Initialize(reader);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Claims.ClaimsIdentity" /> из существующего экземпляра <see cref="T:System.Security.Claims.ClaimsIdentity" />.</summary>
		/// <param name="other">Копируемый <see cref="T:System.Security.Claims.ClaimsIdentity" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="other" /> имеет значение NULL.</exception>
		// Token: 0x060032A8 RID: 12968 RVA: 0x000BA4B8 File Offset: 0x000B86B8
		protected ClaimsIdentity(ClaimsIdentity other)
		{
			this.m_instanceClaims = new List<Claim>();
			this.m_externalClaims = new Collection<IEnumerable<Claim>>();
			this.m_nameType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name";
			this.m_roleType = "http://schemas.microsoft.com/ws/2008/06/identity/claims/role";
			this.m_version = "1.0";
			base..ctor();
			if (other == null)
			{
				throw new ArgumentNullException("other");
			}
			if (other.m_actor != null)
			{
				this.m_actor = other.m_actor.Clone();
			}
			this.m_authenticationType = other.m_authenticationType;
			this.m_bootstrapContext = other.m_bootstrapContext;
			this.m_label = other.m_label;
			this.m_nameType = other.m_nameType;
			this.m_roleType = other.m_roleType;
			if (other.m_userSerializationData != null)
			{
				this.m_userSerializationData = (other.m_userSerializationData.Clone() as byte[]);
			}
			this.SafeAddClaims(other.m_instanceClaims);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Claims.ClaimsIdentity" /> из сериализованного потока, созданного с помощью <see cref="T:System.Runtime.Serialization.ISerializable" />.</summary>
		/// <param name="info">Сериализованные данные.</param>
		/// <param name="context">Контекст сериализации.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="info" /> имеет значение NULL.</exception>
		// Token: 0x060032A9 RID: 12969 RVA: 0x000BA590 File Offset: 0x000B8790
		[SecurityCritical]
		protected ClaimsIdentity(SerializationInfo info, StreamingContext context)
		{
			this.m_instanceClaims = new List<Claim>();
			this.m_externalClaims = new Collection<IEnumerable<Claim>>();
			this.m_nameType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name";
			this.m_roleType = "http://schemas.microsoft.com/ws/2008/06/identity/claims/role";
			this.m_version = "1.0";
			base..ctor();
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			this.Deserialize(info, context, true);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Claims.ClaimsIdentity" /> из сериализованного потока, созданного с помощью <see cref="T:System.Runtime.Serialization.ISerializable" />.</summary>
		/// <param name="info">Сериализованные данные.</param>
		// Token: 0x060032AA RID: 12970 RVA: 0x000BA5F4 File Offset: 0x000B87F4
		[SecurityCritical]
		protected ClaimsIdentity(SerializationInfo info)
		{
			this.m_instanceClaims = new List<Claim>();
			this.m_externalClaims = new Collection<IEnumerable<Claim>>();
			this.m_nameType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name";
			this.m_roleType = "http://schemas.microsoft.com/ws/2008/06/identity/claims/role";
			this.m_version = "1.0";
			base..ctor();
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			this.Deserialize(info, default(StreamingContext), false);
		}

		/// <summary>Возвращает тип проверки подлинности.</summary>
		/// <returns>Тип проверки подлинности.</returns>
		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x060032AB RID: 12971 RVA: 0x000BA65D File Offset: 0x000B885D
		public virtual string AuthenticationType
		{
			get
			{
				return this.m_authenticationType;
			}
		}

		/// <summary>Получает значение, определяющее, прошло ли удостоверение аутентификацию.</summary>
		/// <returns>
		///   <see langword="true" /> Если удостоверение прошел проверку подлинности; в противном случае <see langword="false" />.</returns>
		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x060032AC RID: 12972 RVA: 0x000BA665 File Offset: 0x000B8865
		public virtual bool IsAuthenticated
		{
			get
			{
				return !string.IsNullOrEmpty(this.m_authenticationType);
			}
		}

		/// <summary>Получает или задает удостоверение вызывающей стороны, которой были предоставлены права делегирования.</summary>
		/// <returns>Вызывающая сторона, которой предоставлены права делегирования.</returns>
		/// <exception cref="T:System.InvalidOperationException">Предпринята попытка установить свойство на текущий экземпляр.</exception>
		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x060032AD RID: 12973 RVA: 0x000BA675 File Offset: 0x000B8875
		// (set) Token: 0x060032AE RID: 12974 RVA: 0x000BA67D File Offset: 0x000B887D
		public ClaimsIdentity Actor
		{
			get
			{
				return this.m_actor;
			}
			set
			{
				if (value != null && this.IsCircular(value))
				{
					throw new InvalidOperationException(Environment.GetResourceString("Actor cannot be set so that circular directed graph will exist chaining the subjects together."));
				}
				this.m_actor = value;
			}
		}

		/// <summary>Получает или задает токен, который использовался для создания данного удостоверения на основе требований.</summary>
		/// <returns>Контекст начальной загрузки.</returns>
		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x060032AF RID: 12975 RVA: 0x000BA6A2 File Offset: 0x000B88A2
		// (set) Token: 0x060032B0 RID: 12976 RVA: 0x000BA6AA File Offset: 0x000B88AA
		public object BootstrapContext
		{
			get
			{
				return this.m_bootstrapContext;
			}
			[SecurityCritical]
			set
			{
				this.m_bootstrapContext = value;
			}
		}

		/// <summary>Получает требования, связанные с данным удостоверением на основе требований.</summary>
		/// <returns>Коллекция утверждений, связанных с данным удостоверением утверждений.</returns>
		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x060032B1 RID: 12977 RVA: 0x000BA6B3 File Offset: 0x000B88B3
		public virtual IEnumerable<Claim> Claims
		{
			get
			{
				int num;
				for (int i = 0; i < this.m_instanceClaims.Count; i = num + 1)
				{
					yield return this.m_instanceClaims[i];
					num = i;
				}
				if (this.m_externalClaims != null)
				{
					for (int i = 0; i < this.m_externalClaims.Count; i = num + 1)
					{
						if (this.m_externalClaims[i] != null)
						{
							foreach (Claim claim in this.m_externalClaims[i])
							{
								yield return claim;
							}
							IEnumerator<Claim> enumerator = null;
						}
						num = i;
					}
				}
				yield break;
				yield break;
			}
		}

		/// <summary>Содержит дополнительные данные, предоставленные производным типом. Обычно устанавливается при вызове <see cref="M:System.Security.Claims.ClaimsIdentity.WriteTo(System.IO.BinaryWriter,System.Byte[])" />.</summary>
		/// <returns>Объект <see cref="T:System.Byte" /> массив, представляющий дополнительный сериализованных данных.</returns>
		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x060032B2 RID: 12978 RVA: 0x000BA6C3 File Offset: 0x000B88C3
		protected virtual byte[] CustomSerializationData
		{
			get
			{
				return this.m_userSerializationData;
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x060032B3 RID: 12979 RVA: 0x000BA6CB File Offset: 0x000B88CB
		internal Collection<IEnumerable<Claim>> ExternalClaims
		{
			[FriendAccessAllowed]
			get
			{
				return this.m_externalClaims;
			}
		}

		/// <summary>Получает или задает метку для данного удостоверения на основе требований.</summary>
		/// <returns>Метка.</returns>
		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x060032B4 RID: 12980 RVA: 0x000BA6D3 File Offset: 0x000B88D3
		// (set) Token: 0x060032B5 RID: 12981 RVA: 0x000BA6DB File Offset: 0x000B88DB
		public string Label
		{
			get
			{
				return this.m_label;
			}
			set
			{
				this.m_label = value;
			}
		}

		/// <summary>Получает имя данного удостоверения на основе требований.</summary>
		/// <returns>Имя или <see langword="null" />.</returns>
		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x060032B6 RID: 12982 RVA: 0x000BA6E4 File Offset: 0x000B88E4
		public virtual string Name
		{
			get
			{
				Claim claim = this.FindFirst(this.m_nameType);
				if (claim != null)
				{
					return claim.Value;
				}
				return null;
			}
		}

		/// <summary>Получает тип требования, используемый для определения того, какие требования предоставляют значение для свойства <see cref="P:System.Security.Claims.ClaimsIdentity.Name" /> данного удостоверения на основе требований.</summary>
		/// <returns>Тип требования имени.</returns>
		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x060032B7 RID: 12983 RVA: 0x000BA709 File Offset: 0x000B8909
		public string NameClaimType
		{
			get
			{
				return this.m_nameType;
			}
		}

		/// <summary>Получает тип требования, который будет интерпретироваться как роль .NET Framework среди требований в данном удостоверении на основе требований.</summary>
		/// <returns>Тип требования роли.</returns>
		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x060032B8 RID: 12984 RVA: 0x000BA711 File Offset: 0x000B8911
		public string RoleClaimType
		{
			get
			{
				return this.m_roleType;
			}
		}

		/// <summary>Возвращает новый объект <see cref="T:System.Security.Claims.ClaimsIdentity" />, скопированный из данного удостоверение утверждений.</summary>
		/// <returns>Копия текущего экземпляра.</returns>
		// Token: 0x060032B9 RID: 12985 RVA: 0x000BA71C File Offset: 0x000B891C
		public virtual ClaimsIdentity Clone()
		{
			ClaimsIdentity claimsIdentity = new ClaimsIdentity(this.m_instanceClaims);
			claimsIdentity.m_authenticationType = this.m_authenticationType;
			claimsIdentity.m_bootstrapContext = this.m_bootstrapContext;
			claimsIdentity.m_label = this.m_label;
			claimsIdentity.m_nameType = this.m_nameType;
			claimsIdentity.m_roleType = this.m_roleType;
			if (this.Actor != null)
			{
				if (this.IsCircular(this.Actor))
				{
					throw new InvalidOperationException(Environment.GetResourceString("Actor cannot be set so that circular directed graph will exist chaining the subjects together."));
				}
				if (!AppContextSwitches.SetActorAsReferenceWhenCopyingClaimsIdentity)
				{
					claimsIdentity.Actor = this.Actor.Clone();
				}
				else
				{
					claimsIdentity.Actor = this.Actor;
				}
			}
			return claimsIdentity;
		}

		/// <summary>Добавляет одно требование к этому идентификатору требований.</summary>
		/// <param name="claim">Добавляемое требование.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="claim" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060032BA RID: 12986 RVA: 0x000BA7C0 File Offset: 0x000B89C0
		[SecurityCritical]
		public virtual void AddClaim(Claim claim)
		{
			if (claim == null)
			{
				throw new ArgumentNullException("claim");
			}
			if (claim.Subject == this)
			{
				this.m_instanceClaims.Add(claim);
				return;
			}
			this.m_instanceClaims.Add(claim.Clone(this));
		}

		/// <summary>Добавляет список требований к этому идентификатору требований.</summary>
		/// <param name="claims">Добавляемые требования.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="claims" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060032BB RID: 12987 RVA: 0x000BA7F8 File Offset: 0x000B89F8
		[SecurityCritical]
		public virtual void AddClaims(IEnumerable<Claim> claims)
		{
			if (claims == null)
			{
				throw new ArgumentNullException("claims");
			}
			foreach (Claim claim in claims)
			{
				if (claim != null)
				{
					this.AddClaim(claim);
				}
			}
		}

		/// <summary>Пытается удалить утверждение на основе идентификатора утверждений.</summary>
		/// <param name="claim">Удаляемое требование.</param>
		/// <returns>Значение <see langword="true" />, если требование успешно удалено; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060032BC RID: 12988 RVA: 0x000BA854 File Offset: 0x000B8A54
		[SecurityCritical]
		public virtual bool TryRemoveClaim(Claim claim)
		{
			bool result = false;
			for (int i = 0; i < this.m_instanceClaims.Count; i++)
			{
				if (this.m_instanceClaims[i] == claim)
				{
					this.m_instanceClaims.RemoveAt(i);
					result = true;
					break;
				}
			}
			return result;
		}

		/// <summary>Пытается удалить утверждение на основе идентификатора утверждений.</summary>
		/// <param name="claim">Удаляемое требование.</param>
		/// <exception cref="T:System.InvalidOperationException">Невозможно удалить требования.</exception>
		// Token: 0x060032BD RID: 12989 RVA: 0x000BA899 File Offset: 0x000B8A99
		[SecurityCritical]
		public virtual void RemoveClaim(Claim claim)
		{
			if (!this.TryRemoveClaim(claim))
			{
				throw new InvalidOperationException(Environment.GetResourceString("The Claim '{0}' was not able to be removed.  It is either not part of this Identity or it is a claim that is owned by the Principal that contains this Identity. For example, the Principal will own the claim when creating a GenericPrincipal with roles. The roles will be exposed through the Identity that is passed in the constructor, but not actually owned by the Identity.  Similar logic exists for a RolePrincipal.", new object[]
				{
					claim
				}));
			}
		}

		// Token: 0x060032BE RID: 12990 RVA: 0x000BA8C0 File Offset: 0x000B8AC0
		[SecuritySafeCritical]
		private void SafeAddClaims(IEnumerable<Claim> claims)
		{
			foreach (Claim claim in claims)
			{
				if (claim.Subject == this)
				{
					this.m_instanceClaims.Add(claim);
				}
				else
				{
					this.m_instanceClaims.Add(claim.Clone(this));
				}
			}
		}

		// Token: 0x060032BF RID: 12991 RVA: 0x000BA92C File Offset: 0x000B8B2C
		[SecuritySafeCritical]
		private void SafeAddClaim(Claim claim)
		{
			if (claim.Subject == this)
			{
				this.m_instanceClaims.Add(claim);
				return;
			}
			this.m_instanceClaims.Add(claim.Clone(this));
		}

		/// <summary>Извлекает все утверждения, сопоставленные указанным предикатом.</summary>
		/// <param name="match">Функция, выполняющая логику сопоставления.</param>
		/// <returns>Утверждения сопоставления. Список доступен только для чтения.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="match" /> имеет значение NULL.</exception>
		// Token: 0x060032C0 RID: 12992 RVA: 0x000BA958 File Offset: 0x000B8B58
		public virtual IEnumerable<Claim> FindAll(Predicate<Claim> match)
		{
			if (match == null)
			{
				throw new ArgumentNullException("match");
			}
			List<Claim> list = new List<Claim>();
			foreach (Claim claim in this.Claims)
			{
				if (match(claim))
				{
					list.Add(claim);
				}
			}
			return list.AsReadOnly();
		}

		/// <summary>Извлекает все утверждения, которые имеют указанный тип утверждения.</summary>
		/// <param name="type">Тип утверждения, с которым будут сопоставляться утверждения.</param>
		/// <returns>Утверждения сопоставления. Список доступен только для чтения.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="type" /> имеет значение NULL.</exception>
		// Token: 0x060032C1 RID: 12993 RVA: 0x000BA9C8 File Offset: 0x000B8BC8
		public virtual IEnumerable<Claim> FindAll(string type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			List<Claim> list = new List<Claim>();
			foreach (Claim claim in this.Claims)
			{
				if (claim != null && string.Equals(claim.Type, type, StringComparison.OrdinalIgnoreCase))
				{
					list.Add(claim);
				}
			}
			return list.AsReadOnly();
		}

		/// <summary>Определяет, имеет ли этот идентификатор утверждения утверждение, что соответствует заданному предикату.</summary>
		/// <param name="match">Функция, выполняющая логику сопоставления.</param>
		/// <returns>Значение <see langword="true" />, если совпадающее утверждение существует; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="match" /> имеет значение NULL.</exception>
		// Token: 0x060032C2 RID: 12994 RVA: 0x000BAA44 File Offset: 0x000B8C44
		public virtual bool HasClaim(Predicate<Claim> match)
		{
			if (match == null)
			{
				throw new ArgumentNullException("match");
			}
			foreach (Claim obj in this.Claims)
			{
				if (match(obj))
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>Определяет, имеет ли этот идентификатор утверждения утверждение с заданным типом и значением утверждения.</summary>
		/// <param name="type">Тип утверждения для сопоставления.</param>
		/// <param name="value">Значение утверждения для сопоставления.</param>
		/// <returns>Значение <see langword="true" />, если соответствие найдено; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="type" /> имеет значение NULL.  
		///
		/// или - 
		/// Параметр <paramref name="value" /> имеет значение NULL.</exception>
		// Token: 0x060032C3 RID: 12995 RVA: 0x000BAAA8 File Offset: 0x000B8CA8
		public virtual bool HasClaim(string type, string value)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			foreach (Claim claim in this.Claims)
			{
				if (claim != null && claim != null && string.Equals(claim.Type, type, StringComparison.OrdinalIgnoreCase) && string.Equals(claim.Value, value, StringComparison.Ordinal))
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>Извлекает первое утверждение, которое соответствует указанному предикату.</summary>
		/// <param name="match">Функция, выполняющая логику сопоставления.</param>
		/// <returns>Первое соответствующее утверждение или <see langword="null" />, если соответствие не найдено.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="match" /> имеет значение NULL.</exception>
		// Token: 0x060032C4 RID: 12996 RVA: 0x000BAB38 File Offset: 0x000B8D38
		public virtual Claim FindFirst(Predicate<Claim> match)
		{
			if (match == null)
			{
				throw new ArgumentNullException("match");
			}
			foreach (Claim claim in this.Claims)
			{
				if (match(claim))
				{
					return claim;
				}
			}
			return null;
		}

		/// <summary>Извлекает первое утверждение с заданным типом утверждения.</summary>
		/// <param name="type">Тип утверждения для сопоставления.</param>
		/// <returns>Первое соответствующее утверждение или <see langword="null" />, если соответствие не найдено.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="type" /> имеет значение NULL.</exception>
		// Token: 0x060032C5 RID: 12997 RVA: 0x000BAB9C File Offset: 0x000B8D9C
		public virtual Claim FindFirst(string type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			foreach (Claim claim in this.Claims)
			{
				if (claim != null && string.Equals(claim.Type, type, StringComparison.OrdinalIgnoreCase))
				{
					return claim;
				}
			}
			return null;
		}

		// Token: 0x060032C6 RID: 12998 RVA: 0x000BAC0C File Offset: 0x000B8E0C
		[OnSerializing]
		[SecurityCritical]
		private void OnSerializingMethod(StreamingContext context)
		{
			if (this is ISerializable)
			{
				return;
			}
			this.m_serializedClaims = this.SerializeClaims();
			this.m_serializedNameType = this.m_nameType;
			this.m_serializedRoleType = this.m_roleType;
		}

		// Token: 0x060032C7 RID: 12999 RVA: 0x000BAC3C File Offset: 0x000B8E3C
		[OnDeserialized]
		[SecurityCritical]
		private void OnDeserializedMethod(StreamingContext context)
		{
			if (this is ISerializable)
			{
				return;
			}
			if (!string.IsNullOrEmpty(this.m_serializedClaims))
			{
				this.DeserializeClaims(this.m_serializedClaims);
				this.m_serializedClaims = null;
			}
			this.m_nameType = (string.IsNullOrEmpty(this.m_serializedNameType) ? "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name" : this.m_serializedNameType);
			this.m_roleType = (string.IsNullOrEmpty(this.m_serializedRoleType) ? "http://schemas.microsoft.com/ws/2008/06/identity/claims/role" : this.m_serializedRoleType);
		}

		// Token: 0x060032C8 RID: 13000 RVA: 0x000BACB2 File Offset: 0x000B8EB2
		[OnDeserializing]
		private void OnDeserializingMethod(StreamingContext context)
		{
			if (this is ISerializable)
			{
				return;
			}
			this.m_instanceClaims = new List<Claim>();
			this.m_externalClaims = new Collection<IEnumerable<Claim>>();
		}

		/// <summary>Заполняет <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, необходимыми для сериализации текущего объекта <see cref="T:System.Security.Claims.ClaimsIdentity" />.</summary>
		/// <param name="info">Объект, который требуется заполнить данными.</param>
		/// <param name="context">Целевой объект этой сериализации. Может иметь значение <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060032C9 RID: 13001 RVA: 0x000BACD4 File Offset: 0x000B8ED4
		[SecurityCritical]
		[SecurityPermission(SecurityAction.Assert, SerializationFormatter = true)]
		protected virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			info.AddValue("System.Security.ClaimsIdentity.version", this.m_version);
			if (!string.IsNullOrEmpty(this.m_authenticationType))
			{
				info.AddValue("System.Security.ClaimsIdentity.authenticationType", this.m_authenticationType);
			}
			info.AddValue("System.Security.ClaimsIdentity.nameClaimType", this.m_nameType);
			info.AddValue("System.Security.ClaimsIdentity.roleClaimType", this.m_roleType);
			if (!string.IsNullOrEmpty(this.m_label))
			{
				info.AddValue("System.Security.ClaimsIdentity.label", this.m_label);
			}
			if (this.m_actor != null)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					binaryFormatter.Serialize(memoryStream, this.m_actor, null, false);
					info.AddValue("System.Security.ClaimsIdentity.actor", Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length));
				}
			}
			info.AddValue("System.Security.ClaimsIdentity.claims", this.SerializeClaims());
			if (this.m_bootstrapContext != null)
			{
				using (MemoryStream memoryStream2 = new MemoryStream())
				{
					binaryFormatter.Serialize(memoryStream2, this.m_bootstrapContext, null, false);
					info.AddValue("System.Security.ClaimsIdentity.bootstrapContext", Convert.ToBase64String(memoryStream2.GetBuffer(), 0, (int)memoryStream2.Length));
				}
			}
		}

		// Token: 0x060032CA RID: 13002 RVA: 0x000BAE20 File Offset: 0x000B9020
		[SecurityCritical]
		private void DeserializeClaims(string serializedClaims)
		{
			if (!string.IsNullOrEmpty(serializedClaims))
			{
				using (MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(serializedClaims)))
				{
					this.m_instanceClaims = (List<Claim>)new BinaryFormatter().Deserialize(memoryStream, null, false);
					for (int i = 0; i < this.m_instanceClaims.Count; i++)
					{
						this.m_instanceClaims[i].Subject = this;
					}
				}
			}
			if (this.m_instanceClaims == null)
			{
				this.m_instanceClaims = new List<Claim>();
			}
		}

		// Token: 0x060032CB RID: 13003 RVA: 0x000BAEB0 File Offset: 0x000B90B0
		[SecurityCritical]
		private string SerializeClaims()
		{
			string result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				new BinaryFormatter().Serialize(memoryStream, this.m_instanceClaims, null, false);
				result = Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
			}
			return result;
		}

		// Token: 0x060032CC RID: 13004 RVA: 0x000BAF08 File Offset: 0x000B9108
		private bool IsCircular(ClaimsIdentity subject)
		{
			if (this == subject)
			{
				return true;
			}
			ClaimsIdentity claimsIdentity = subject;
			while (claimsIdentity.Actor != null)
			{
				if (this == claimsIdentity.Actor)
				{
					return true;
				}
				claimsIdentity = claimsIdentity.Actor;
			}
			return false;
		}

		// Token: 0x060032CD RID: 13005 RVA: 0x000BAF3C File Offset: 0x000B913C
		private void Initialize(BinaryReader reader)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			int num = reader.ReadInt32();
			if ((num & 1) == 1)
			{
				this.m_authenticationType = reader.ReadString();
			}
			if ((num & 2) == 2)
			{
				this.m_bootstrapContext = reader.ReadString();
			}
			if ((num & 4) == 4)
			{
				this.m_nameType = reader.ReadString();
			}
			else
			{
				this.m_nameType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name";
			}
			if ((num & 8) == 8)
			{
				this.m_roleType = reader.ReadString();
			}
			else
			{
				this.m_roleType = "http://schemas.microsoft.com/ws/2008/06/identity/claims/role";
			}
			if ((num & 16) == 16)
			{
				int num2 = reader.ReadInt32();
				for (int i = 0; i < num2; i++)
				{
					Claim item = new Claim(reader, this);
					this.m_instanceClaims.Add(item);
				}
			}
		}

		/// <summary>Предоставляет точку расширяемости для производных типов с целью создания пользовательского <see cref="T:System.Security.Claims.Claim" />.</summary>
		/// <param name="reader">Экземпляр <see cref="T:System.IO.BinaryReader" />, указывающий на утверждение.</param>
		/// <returns>Новый объект <see cref="T:System.Security.Claims.Claim" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="reader" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060032CE RID: 13006 RVA: 0x000BAFED File Offset: 0x000B91ED
		protected virtual Claim CreateClaim(BinaryReader reader)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			return new Claim(reader, this);
		}

		/// <summary>Выполняет сериализацию с помощью <see cref="T:System.IO.BinaryWriter" />.</summary>
		/// <param name="writer">Модуль записи, используемый для хранения данных.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="writer" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060032CF RID: 13007 RVA: 0x000BB004 File Offset: 0x000B9204
		public virtual void WriteTo(BinaryWriter writer)
		{
			this.WriteTo(writer, null);
		}

		/// <summary>Выполняет сериализацию с помощью <see cref="T:System.IO.BinaryWriter" />.</summary>
		/// <param name="writer">Модуль записи, используемый для хранения данных.</param>
		/// <param name="userData">Дополнительные данные, предоставленные производным типом.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="writer" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060032D0 RID: 13008 RVA: 0x000BB010 File Offset: 0x000B9210
		protected virtual void WriteTo(BinaryWriter writer, byte[] userData)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			int num = 0;
			ClaimsIdentity.SerializationMask serializationMask = ClaimsIdentity.SerializationMask.None;
			if (this.m_authenticationType != null)
			{
				serializationMask |= ClaimsIdentity.SerializationMask.AuthenticationType;
				num++;
			}
			if (this.m_bootstrapContext != null && this.m_bootstrapContext is string)
			{
				serializationMask |= ClaimsIdentity.SerializationMask.BootstrapConext;
				num++;
			}
			if (!string.Equals(this.m_nameType, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name", StringComparison.Ordinal))
			{
				serializationMask |= ClaimsIdentity.SerializationMask.NameClaimType;
				num++;
			}
			if (!string.Equals(this.m_roleType, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", StringComparison.Ordinal))
			{
				serializationMask |= ClaimsIdentity.SerializationMask.RoleClaimType;
				num++;
			}
			if (!string.IsNullOrWhiteSpace(this.m_label))
			{
				serializationMask |= ClaimsIdentity.SerializationMask.HasLabel;
				num++;
			}
			if (this.m_instanceClaims.Count > 0)
			{
				serializationMask |= ClaimsIdentity.SerializationMask.HasClaims;
				num++;
			}
			if (this.m_actor != null)
			{
				serializationMask |= ClaimsIdentity.SerializationMask.Actor;
				num++;
			}
			if (userData != null && userData.Length != 0)
			{
				num++;
				serializationMask |= ClaimsIdentity.SerializationMask.UserData;
			}
			writer.Write((int)serializationMask);
			writer.Write(num);
			if ((serializationMask & ClaimsIdentity.SerializationMask.AuthenticationType) == ClaimsIdentity.SerializationMask.AuthenticationType)
			{
				writer.Write(this.m_authenticationType);
			}
			if ((serializationMask & ClaimsIdentity.SerializationMask.BootstrapConext) == ClaimsIdentity.SerializationMask.BootstrapConext)
			{
				writer.Write(this.m_bootstrapContext as string);
			}
			if ((serializationMask & ClaimsIdentity.SerializationMask.NameClaimType) == ClaimsIdentity.SerializationMask.NameClaimType)
			{
				writer.Write(this.m_nameType);
			}
			if ((serializationMask & ClaimsIdentity.SerializationMask.RoleClaimType) == ClaimsIdentity.SerializationMask.RoleClaimType)
			{
				writer.Write(this.m_roleType);
			}
			if ((serializationMask & ClaimsIdentity.SerializationMask.HasLabel) == ClaimsIdentity.SerializationMask.HasLabel)
			{
				writer.Write(this.m_label);
			}
			if ((serializationMask & ClaimsIdentity.SerializationMask.HasClaims) == ClaimsIdentity.SerializationMask.HasClaims)
			{
				writer.Write(this.m_instanceClaims.Count);
				foreach (Claim claim in this.m_instanceClaims)
				{
					claim.WriteTo(writer);
				}
			}
			if ((serializationMask & ClaimsIdentity.SerializationMask.Actor) == ClaimsIdentity.SerializationMask.Actor)
			{
				this.m_actor.WriteTo(writer);
			}
			if ((serializationMask & ClaimsIdentity.SerializationMask.UserData) == ClaimsIdentity.SerializationMask.UserData)
			{
				writer.Write(userData.Length);
				writer.Write(userData);
			}
			writer.Flush();
		}

		// Token: 0x060032D1 RID: 13009 RVA: 0x000BB1E8 File Offset: 0x000B93E8
		[SecurityCritical]
		[SecurityPermission(SecurityAction.Assert, SerializationFormatter = true)]
		private void Deserialize(SerializationInfo info, StreamingContext context, bool useContext)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			BinaryFormatter binaryFormatter;
			if (useContext)
			{
				binaryFormatter = new BinaryFormatter(null, context);
			}
			else
			{
				binaryFormatter = new BinaryFormatter();
			}
			SerializationInfoEnumerator enumerator = info.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string name = enumerator.Name;
				uint num = <PrivateImplementationDetails>.ComputeStringHash(name);
				if (num <= 959168042U)
				{
					if (num <= 623923795U)
					{
						if (num != 373632733U)
						{
							if (num == 623923795U)
							{
								if (name == "System.Security.ClaimsIdentity.roleClaimType")
								{
									this.m_roleType = info.GetString("System.Security.ClaimsIdentity.roleClaimType");
								}
							}
						}
						else if (name == "System.Security.ClaimsIdentity.label")
						{
							this.m_label = info.GetString("System.Security.ClaimsIdentity.label");
						}
					}
					else if (num != 656336169U)
					{
						if (num == 959168042U)
						{
							if (name == "System.Security.ClaimsIdentity.nameClaimType")
							{
								this.m_nameType = info.GetString("System.Security.ClaimsIdentity.nameClaimType");
							}
						}
					}
					else if (name == "System.Security.ClaimsIdentity.authenticationType")
					{
						this.m_authenticationType = info.GetString("System.Security.ClaimsIdentity.authenticationType");
					}
				}
				else if (num <= 1476368026U)
				{
					if (num != 1453716852U)
					{
						if (num != 1476368026U)
						{
							continue;
						}
						if (!(name == "System.Security.ClaimsIdentity.actor"))
						{
							continue;
						}
						using (MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(info.GetString("System.Security.ClaimsIdentity.actor"))))
						{
							this.m_actor = (ClaimsIdentity)binaryFormatter.Deserialize(memoryStream, null, false);
							continue;
						}
					}
					else if (!(name == "System.Security.ClaimsIdentity.claims"))
					{
						continue;
					}
					this.DeserializeClaims(info.GetString("System.Security.ClaimsIdentity.claims"));
				}
				else if (num != 2480284791U)
				{
					if (num == 3659022112U)
					{
						if (name == "System.Security.ClaimsIdentity.bootstrapContext")
						{
							using (MemoryStream memoryStream2 = new MemoryStream(Convert.FromBase64String(info.GetString("System.Security.ClaimsIdentity.bootstrapContext"))))
							{
								this.m_bootstrapContext = binaryFormatter.Deserialize(memoryStream2, null, false);
							}
						}
					}
				}
				else if (name == "System.Security.ClaimsIdentity.version")
				{
					info.GetString("System.Security.ClaimsIdentity.version");
				}
			}
		}

		// Token: 0x040023B4 RID: 9140
		[NonSerialized]
		private byte[] m_userSerializationData;

		// Token: 0x040023B5 RID: 9141
		[NonSerialized]
		private const string PreFix = "System.Security.ClaimsIdentity.";

		// Token: 0x040023B6 RID: 9142
		[NonSerialized]
		private const string ActorKey = "System.Security.ClaimsIdentity.actor";

		// Token: 0x040023B7 RID: 9143
		[NonSerialized]
		private const string AuthenticationTypeKey = "System.Security.ClaimsIdentity.authenticationType";

		// Token: 0x040023B8 RID: 9144
		[NonSerialized]
		private const string BootstrapContextKey = "System.Security.ClaimsIdentity.bootstrapContext";

		// Token: 0x040023B9 RID: 9145
		[NonSerialized]
		private const string ClaimsKey = "System.Security.ClaimsIdentity.claims";

		// Token: 0x040023BA RID: 9146
		[NonSerialized]
		private const string LabelKey = "System.Security.ClaimsIdentity.label";

		// Token: 0x040023BB RID: 9147
		[NonSerialized]
		private const string NameClaimTypeKey = "System.Security.ClaimsIdentity.nameClaimType";

		// Token: 0x040023BC RID: 9148
		[NonSerialized]
		private const string RoleClaimTypeKey = "System.Security.ClaimsIdentity.roleClaimType";

		// Token: 0x040023BD RID: 9149
		[NonSerialized]
		private const string VersionKey = "System.Security.ClaimsIdentity.version";

		/// <summary>Издатель по умолчанию; "ЛОКАЛЬНАЯ СИСТЕМА".</summary>
		// Token: 0x040023BE RID: 9150
		[NonSerialized]
		public const string DefaultIssuer = "LOCAL AUTHORITY";

		/// <summary>Тип утверждения имени по умолчанию; <see cref="F:System.Security.Claims.ClaimTypes.Name" />.</summary>
		// Token: 0x040023BF RID: 9151
		[NonSerialized]
		public const string DefaultNameClaimType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name";

		/// <summary>Тип утверждения роли по умолчанию; <see cref="F:System.Security.Claims.ClaimTypes.Role" />.</summary>
		// Token: 0x040023C0 RID: 9152
		[NonSerialized]
		public const string DefaultRoleClaimType = "http://schemas.microsoft.com/ws/2008/06/identity/claims/role";

		// Token: 0x040023C1 RID: 9153
		[NonSerialized]
		private List<Claim> m_instanceClaims;

		// Token: 0x040023C2 RID: 9154
		[NonSerialized]
		private Collection<IEnumerable<Claim>> m_externalClaims;

		// Token: 0x040023C3 RID: 9155
		[NonSerialized]
		private string m_nameType;

		// Token: 0x040023C4 RID: 9156
		[NonSerialized]
		private string m_roleType;

		// Token: 0x040023C5 RID: 9157
		[OptionalField(VersionAdded = 2)]
		private string m_version;

		// Token: 0x040023C6 RID: 9158
		[OptionalField(VersionAdded = 2)]
		private ClaimsIdentity m_actor;

		// Token: 0x040023C7 RID: 9159
		[OptionalField(VersionAdded = 2)]
		private string m_authenticationType;

		// Token: 0x040023C8 RID: 9160
		[OptionalField(VersionAdded = 2)]
		private object m_bootstrapContext;

		// Token: 0x040023C9 RID: 9161
		[OptionalField(VersionAdded = 2)]
		private string m_label;

		// Token: 0x040023CA RID: 9162
		[OptionalField(VersionAdded = 2)]
		private string m_serializedNameType;

		// Token: 0x040023CB RID: 9163
		[OptionalField(VersionAdded = 2)]
		private string m_serializedRoleType;

		// Token: 0x040023CC RID: 9164
		[OptionalField(VersionAdded = 2)]
		private string m_serializedClaims;

		// Token: 0x020004F4 RID: 1268
		private enum SerializationMask
		{
			// Token: 0x040023CE RID: 9166
			None,
			// Token: 0x040023CF RID: 9167
			AuthenticationType,
			// Token: 0x040023D0 RID: 9168
			BootstrapConext,
			// Token: 0x040023D1 RID: 9169
			NameClaimType = 4,
			// Token: 0x040023D2 RID: 9170
			RoleClaimType = 8,
			// Token: 0x040023D3 RID: 9171
			HasClaims = 16,
			// Token: 0x040023D4 RID: 9172
			HasLabel = 32,
			// Token: 0x040023D5 RID: 9173
			Actor = 64,
			// Token: 0x040023D6 RID: 9174
			UserData = 128
		}
	}
}
