using System;
using System.Runtime.CompilerServices;
using Unity;

namespace System.Data.SqlClient
{
	/// <summary>Инкапсулирует состояние безопасного сеанса между SqlClient и анклавом в SQL Server, который может использоваться для вычислений в зашифрованных столбцах, защищенных с помощью Always Encrypted.</summary>
	// Token: 0x020003F5 RID: 1013
	public class SqlEnclaveSession
	{
		/// <summary>Создает новый экземпляр класса <see cref="T:System.Data.SqlClient.SqlEnclaveSession" />.</summary>
		/// <param name="sessionKey">Симметричный ключ, используемый для шифрования всех сведений, отправляемых с помощью этого сеанса.</param>
		/// <param name="sessionId">Идентификатор сеанса.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="sessionKey" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="sessionKey" /> имеет нулевую длину.</exception>
		// Token: 0x06002FAD RID: 12205 RVA: 0x000108A6 File Offset: 0x0000EAA6
		public SqlEnclaveSession(byte[] sessionKey, long sessionId)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Получает идентификатор сеанса.</summary>
		/// <returns>Идентификатор сеанса.</returns>
		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06002FAE RID: 12206 RVA: 0x000CBB74 File Offset: 0x000C9D74
		public long SessionId
		{
			[CompilerGenerated]
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0L;
			}
		}

		/// <summary>Получает симметричный ключ, который используется SqlClient для шифрования всех данных, передаваемых в анклав с использованием сеанса.</summary>
		/// <returns>Симметричный ключ.</returns>
		// Token: 0x06002FAF RID: 12207 RVA: 0x00060C51 File Offset: 0x0005EE51
		public byte[] GetSessionKey()
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}
	}
}
