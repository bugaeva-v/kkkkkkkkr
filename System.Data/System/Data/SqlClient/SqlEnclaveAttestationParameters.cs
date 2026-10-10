using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Unity;

namespace System.Data.SqlClient
{
	/// <summary>Инкапсулирует сведения, которые SqlClient отправляет в SQL Server, чтобы инициировать процесс аттестации и создания безопасного сеанса с анклавом для вычислений в столбцах, защищенных с помощью Always Encrypted.</summary>
	// Token: 0x020003F6 RID: 1014
	public class SqlEnclaveAttestationParameters
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlClient.SqlEnclaveAttestationParameters" />.</summary>
		/// <param name="protocol">Протокол аттестации анклава.</param>
		/// <param name="input">Входные данные протокола аттестации анклава.</param>
		/// <param name="clientDiffieHellmanKey">Алгоритм Диффи — Хеллмана, инкапсулирующий пару ключей на стороне клиента.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="clientDiffieHellmanKey" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002FB0 RID: 12208 RVA: 0x000108A6 File Offset: 0x0000EAA6
		public SqlEnclaveAttestationParameters(int protocol, byte[] input, ECDiffieHellmanCng clientDiffieHellmanKey)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Получает алгоритм Диффи — Хеллмана, который инкапсулирует пару ключей, используемых SqlClient для установления безопасного сеанса с анклавом.</summary>
		/// <returns>Алгоритм Диффи — Хеллмана.</returns>
		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06002FB1 RID: 12209 RVA: 0x00060C51 File Offset: 0x0005EE51
		public ECDiffieHellmanCng ClientDiffieHellmanKey
		{
			[CompilerGenerated]
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>Получает идентификатор протокола аттестации анклава.</summary>
		/// <returns>Идентификатор протокола аттестации анклава.</returns>
		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06002FB2 RID: 12210 RVA: 0x000CBB90 File Offset: 0x000C9D90
		public int Protocol
		{
			[CompilerGenerated]
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0;
			}
		}

		/// <summary>Получает сведения, используемые для запуска процесса аттестации анклава. Формат и содержимое этих сведений зависит от используемого протокола аттестации.</summary>
		/// <returns>Сведения, используемые SQL Server для выполнения протокола аттестации, который задается с помощью EnclaveAttestationProtocols.</returns>
		// Token: 0x06002FB3 RID: 12211 RVA: 0x00060C51 File Offset: 0x0005EE51
		public byte[] GetInput()
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}
	}
}
