using System;
using System.Security.Cryptography;
using Unity;

namespace System.Data.SqlClient
{
	/// <summary>Базовый класс, определяющий интерфейс поставщиков анклавов для технологии Always Encrypted.</summary>
	// Token: 0x020003F4 RID: 1012
	public abstract class SqlColumnEncryptionEnclaveProvider
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlClient.SqlColumnEncryptionEnclaveProvider" />.</summary>
		// Token: 0x06002FA8 RID: 12200 RVA: 0x000108A6 File Offset: 0x0000EAA6
		protected SqlColumnEncryptionEnclaveProvider()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>При переопределении в производном классе выполняет аттестацию анклава, создает симметричный ключ для сеанса, создает сеанс анклава и сохраняет сведения о сеансе в кэше.</summary>
		/// <param name="enclaveAttestationInfo">Сведения, которые поставщик использует для аттестации анклава и создания симметричного ключа для сеанса. Формат этих сведений зависит от используемого протокола аттестации анклава.</param>
		/// <param name="clientDiffieHellmanKey">Объект алгоритма Диффи — Хеллмана, инкапсулирующий пару ключей на стороне клиента.</param>
		/// <param name="attestationUrl">Конечная точка службы, осуществляющей аттестацию анклава.</param>
		/// <param name="servername">Имя экземпляра SQL Server, содержащего анклав.</param>
		/// <param name="sqlEnclaveSession">Запрошенный сеанс анклава или <see langword="null" />, если поставщик не реализует кэширование сеансов.</param>
		/// <param name="counter">Счетчик, который поставщик анклава должен увеличивать каждый раз, когда SqlClient извлекает сеанс из кэша. Цель этого поля — предотвращать атаки с повторением файлов.</param>
		// Token: 0x06002FA9 RID: 12201
		public abstract void CreateEnclaveSession(byte[] enclaveAttestationInfo, ECDiffieHellmanCng clientDiffieHellmanKey, string attestationUrl, string servername, out SqlEnclaveSession sqlEnclaveSession, out long counter);

		/// <summary>Получает сведения, которые SqlClient впоследствии использует для запуска процесса аттестации анклава и установления безопасного сеанса с анклавом.</summary>
		/// <returns>Сведения, которые SqlClient впоследствии использует для запуска процесса аттестации анклава и установления безопасного сеанса с анклавом.</returns>
		// Token: 0x06002FAA RID: 12202
		public abstract SqlEnclaveAttestationParameters GetAttestationParameters();

		/// <summary>При переопределении в производном классе находит сведения о существующем сеансе анклава в кэше сеансов. Если поставщик анклава не реализует кэширование сеансов анклава, этот метод должен возвращать в параметре <paramref name="sqlEnclaveSession" /> значение <see langword="null" />.</summary>
		/// <param name="serverName">Имя экземпляра SQL Server, содержащего анклав.</param>
		/// <param name="attestationUrl">Конечная точка службы аттестации, с которой SqlClient связывается для аттестации анклава.</param>
		/// <param name="sqlEnclaveSession">При возвращении методом значений — запрошенный сеанс анклава или <see langword="null" />, если поставщик не реализует кэширование сеансов. Этот параметр обрабатывается как неинициализированный.</param>
		/// <param name="counter">Счетчик, который поставщик анклава должен увеличивать каждый раз, когда SqlClient извлекает сеанс из кэша. Цель этого поля — предотвращать атаки с повторением файлов.</param>
		// Token: 0x06002FAB RID: 12203
		public abstract void GetEnclaveSession(string serverName, string attestationUrl, out SqlEnclaveSession sqlEnclaveSession, out long counter);

		/// <summary>При переопределении в производном классе находит и исключает сеанс анклава в кэше, если поставщик реализует кэширование сеансов.</summary>
		/// <param name="serverName">Имя экземпляра SQL Server, содержащего анклав.</param>
		/// <param name="enclaveAttestationUrl">Конечная точка службы аттестации, с которой SqlClient связывается для аттестации анклава.</param>
		/// <param name="enclaveSession">Сеанс, который нужно аннулировать.</param>
		// Token: 0x06002FAC RID: 12204
		public abstract void InvalidateEnclaveSession(string serverName, string enclaveAttestationUrl, SqlEnclaveSession enclaveSession);
	}
}
