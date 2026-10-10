using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace System.Security.Principal
{
	/// <summary>Представляет универсального пользователя.</summary>
	// Token: 0x020004DC RID: 1244
	[Serializable]
	public class GenericIdentity : ClaimsIdentity
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Principal.GenericIdentity" />, представляющий пользователя с указанным именем.</summary>
		/// <param name="name">Имя пользователя, от лица которого выполняется код программы.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060031DA RID: 12762 RVA: 0x000B79D4 File Offset: 0x000B5BD4
		public GenericIdentity(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			this.m_name = name;
			this.m_type = "";
			this.AddNameClaim();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Principal.GenericIdentity" />, представляющий пользователя с указанными именем и типом проверки подлинности.</summary>
		/// <param name="name">Имя пользователя, от лица которого выполняется код программы.</param>
		/// <param name="type">Тип проверки подлинности, применяемой для идентификации пользователя.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Параметр <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060031DB RID: 12763 RVA: 0x000B7A02 File Offset: 0x000B5C02
		public GenericIdentity(string name, string type)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			this.m_name = name;
			this.m_type = type;
			this.AddNameClaim();
		}

		// Token: 0x060031DC RID: 12764 RVA: 0x000B7A3A File Offset: 0x000B5C3A
		private GenericIdentity()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Principal.GenericIdentity" />, используя указанный объект <see cref="T:System.Security.Principal.GenericIdentity" />.</summary>
		/// <param name="identity">Объект, из которого создается новый экземпляр <see cref="T:System.Security.Principal.GenericIdentity" />.</param>
		// Token: 0x060031DD RID: 12765 RVA: 0x000B7A42 File Offset: 0x000B5C42
		protected GenericIdentity(GenericIdentity identity) : base(identity)
		{
			this.m_name = identity.m_name;
			this.m_type = identity.m_type;
		}

		/// <summary>Создает новый объект, являющийся копией текущего экземпляра.</summary>
		/// <returns>Копия текущего экземпляра.</returns>
		// Token: 0x060031DE RID: 12766 RVA: 0x000B7A63 File Offset: 0x000B5C63
		public override ClaimsIdentity Clone()
		{
			return new GenericIdentity(this);
		}

		/// <summary>Получает все утверждения для пользователя, представленного этим общим идентификатором.</summary>
		/// <returns>Коллекция утверждений для этого объекта <see cref="T:System.Security.Principal.GenericIdentity" />.</returns>
		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x060031DF RID: 12767 RVA: 0x000B7A6B File Offset: 0x000B5C6B
		public override IEnumerable<Claim> Claims
		{
			get
			{
				return base.Claims;
			}
		}

		/// <summary>Получает имя пользователя.</summary>
		/// <returns>Имя пользователя, от лица которого выполняется код программы.</returns>
		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x060031E0 RID: 12768 RVA: 0x000B7A73 File Offset: 0x000B5C73
		public override string Name
		{
			get
			{
				return this.m_name;
			}
		}

		/// <summary>Получает тип аутентификации, используемой для идентификации пользователя.</summary>
		/// <returns>Тип проверки подлинности, применяемой для идентификации пользователя.</returns>
		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x060031E1 RID: 12769 RVA: 0x000B7A7B File Offset: 0x000B5C7B
		public override string AuthenticationType
		{
			get
			{
				return this.m_type;
			}
		}

		/// <summary>Возвращает значение, позволяющее определить, прошел ли пользователь проверку подлинности.</summary>
		/// <returns>
		///   <see langword="true" />, если пользователь прошел проверку подлинности; в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x060031E2 RID: 12770 RVA: 0x000B7A83 File Offset: 0x000B5C83
		public override bool IsAuthenticated
		{
			get
			{
				return !this.m_name.Equals("");
			}
		}

		// Token: 0x060031E3 RID: 12771 RVA: 0x000B7A98 File Offset: 0x000B5C98
		private void AddNameClaim()
		{
			if (this.m_name != null)
			{
				base.AddClaim(new Claim(base.NameClaimType, this.m_name, "http://www.w3.org/2001/XMLSchema#string", "LOCAL AUTHORITY", "LOCAL AUTHORITY", this));
			}
		}

		// Token: 0x040022A3 RID: 8867
		private readonly string m_name;

		// Token: 0x040022A4 RID: 8868
		private readonly string m_type;
	}
}
