using System;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using Unity;

namespace System.Security.Cryptography
{
	/// <summary>Предоставляет простые методы защиты данных.</summary>
	// Token: 0x0200011C RID: 284
	public sealed class DpapiDataProtector : DataProtector
	{
		/// <summary>Создает новый экземпляр класса <see cref="T:System.Security.Cryptography.DpapiDataProtector" />, используя указанное имя приложения, первичную цель и определенные цели.</summary>
		/// <param name="appName">Имя приложения.</param>
		/// <param name="primaryPurpose">Основное назначение для предохранителя данных.</param>
		/// <param name="specificPurpose">Определенное назначение (назначения) для предохранителя данных.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="appName" /> является пустой строкой или <see langword="null" />.  
		///
		/// или - 
		/// <paramref name="primaryPurpose" /> является пустой строкой или <see langword="null" />.  
		///
		/// или - 
		/// Параметр <paramref name="specificPurposes" /> содержит пустую строку или имеет значение <see langword="null" />.</exception>
		// Token: 0x06000730 RID: 1840 RVA: 0x000029A4 File Offset: 0x00000BA4
		[SecuritySafeCritical]
		[DataProtectionPermission(SecurityAction.Demand, Unrestricted = true)]
		public DpapiDataProtector(string appName, string primaryPurpose, string[] specificPurpose)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Получает или задает область защиты данных.</summary>
		/// <returns>Одно из значений перечисления, определяющее область действия защиты данных (текущий пользователь или локальный компьютер). Значение по умолчанию — <see cref="F:System.Security.Cryptography.DataProtectionScope.CurrentUser" />.</returns>
		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000731 RID: 1841 RVA: 0x0001DFA4 File Offset: 0x0001C1A4
		// (set) Token: 0x06000732 RID: 1842 RVA: 0x000029A4 File Offset: 0x00000BA4
		public DataProtectionScope Scope
		{
			[CompilerGenerated]
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return DataProtectionScope.CurrentUser;
			}
			[CompilerGenerated]
			set
			{
				ThrowStub.ThrowNotSupportedException();
			}
		}

		/// <summary>Определяет, необходимо ли снова зашифровать данные.</summary>
		/// <param name="encryptedData">Зашифрованные данные для проверки.</param>
		/// <returns>Значение <see langword="true" />, если данные должны быть заново зашифрованы; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000733 RID: 1843 RVA: 0x0001DFC0 File Offset: 0x0001C1C0
		public override bool IsReprotectRequired(byte[] encryptedData)
		{
			ThrowStub.ThrowNotSupportedException();
			return default(bool);
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x0001DFDB File Offset: 0x0001C1DB
		[SecuritySafeCritical]
		[DataProtectionPermission(SecurityAction.Assert, ProtectData = true)]
		protected override byte[] ProviderProtect(byte[] userData)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x0001DFDB File Offset: 0x0001C1DB
		[SecuritySafeCritical]
		[DataProtectionPermission(SecurityAction.Assert, UnprotectData = true)]
		protected override byte[] ProviderUnprotect(byte[] encryptedData)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}
	}
}
