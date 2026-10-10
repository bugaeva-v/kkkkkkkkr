using System;
using System.Threading.Tasks;
using Unity;

namespace System.Data.SqlClient
{
	/// <summary>Определяет основное поведение поставщиков проверки подлинности и предоставляет базовый класс для производных классов.</summary>
	// Token: 0x020003EE RID: 1006
	public abstract class SqlAuthenticationProvider
	{
		/// <summary>Вызывается из конструкторов в производных классах для инициализации класса <see cref="T:System.Data.SqlClient.SqlAuthenticationProvider" />.</summary>
		// Token: 0x06002F8A RID: 12170 RVA: 0x000108A6 File Offset: 0x0000EAA6
		protected SqlAuthenticationProvider()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Получает токен безопасности из центра.</summary>
		/// <param name="parameters">Параметры проверки подлинности Active Directory, которые драйвер передает поставщикам проверки подлинности.</param>
		/// <returns>Представляет асинхронную операцию, которая возвращает маркер проверки подлинности AD.</returns>
		// Token: 0x06002F8B RID: 12171
		public abstract Task<SqlAuthenticationToken> AcquireTokenAsync(SqlAuthenticationParameters parameters);

		/// <summary>Этот метод вызывается непосредственно перед добавлением поставщика в реестр драйверов SQL.</summary>
		/// <param name="authenticationMethod">Метод проверки подлинности.</param>
		// Token: 0x06002F8C RID: 12172 RVA: 0x000108A6 File Offset: 0x0000EAA6
		public virtual void BeforeLoad(SqlAuthenticationMethod authenticationMethod)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Этот метод вызывается непосредственно перед удалением поставщика из реестра драйверов SQL.</summary>
		/// <param name="authenticationMethod">Метод проверки подлинности.</param>
		// Token: 0x06002F8D RID: 12173 RVA: 0x000108A6 File Offset: 0x0000EAA6
		public virtual void BeforeUnload(SqlAuthenticationMethod authenticationMethod)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Получает поставщик проверки подлинности по методу.</summary>
		/// <param name="authenticationMethod">Метод проверки подлинности.</param>
		/// <returns>Поставщик проверки подлинности или <see langword="null" />, если не найдено.</returns>
		// Token: 0x06002F8E RID: 12174 RVA: 0x00060C51 File Offset: 0x0005EE51
		public static SqlAuthenticationProvider GetProvider(SqlAuthenticationMethod authenticationMethod)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>Указывает, поддерживается ли заданный метод проверки подлинности.</summary>
		/// <param name="authenticationMethod">Метод проверки подлинности.</param>
		/// <returns>
		///   <see langword="true" />, если заданный метод проверки подлинности поддерживается, в противном случае — <see langword="false" />.</returns>
		// Token: 0x06002F8F RID: 12175
		public abstract bool IsSupported(SqlAuthenticationMethod authenticationMethod);

		/// <summary>Задает поставщик проверки подлинности по методу.</summary>
		/// <param name="authenticationMethod">Метод проверки подлинности.</param>
		/// <param name="provider">Поставщик проверки подлинности.</param>
		/// <returns>
		///   <see langword="true" />, если операция выполнена успешно, в противном случае — <see langword="false" /> (например, если существующий поставщик запрещает переопределение).</returns>
		// Token: 0x06002F90 RID: 12176 RVA: 0x000CBAB0 File Offset: 0x000C9CB0
		public static bool SetProvider(SqlAuthenticationMethod authenticationMethod, SqlAuthenticationProvider provider)
		{
			ThrowStub.ThrowNotSupportedException();
			return default(bool);
		}
	}
}
