using System;

namespace System.Security.Cryptography
{
	/// <summary>Задает имя криптографического хэш-алгоритма.</summary>
	// Token: 0x02000472 RID: 1138
	public readonly struct HashAlgorithmName : IEquatable<HashAlgorithmName>
	{
		/// <summary>Получает имя хэш-алгоритма, которое представляет "MD5".</summary>
		/// <returns>Имя хэш-алгоритма, которое представляет "MD5".</returns>
		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06002E1A RID: 11802 RVA: 0x000A5DD2 File Offset: 0x000A3FD2
		public static HashAlgorithmName MD5
		{
			get
			{
				return new HashAlgorithmName("MD5");
			}
		}

		/// <summary>Получает имя хэш-алгоритма, которое представляет "SHA1".</summary>
		/// <returns>Имя хэш-алгоритма, которое представляет "SHA1".</returns>
		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06002E1B RID: 11803 RVA: 0x000A5DDE File Offset: 0x000A3FDE
		public static HashAlgorithmName SHA1
		{
			get
			{
				return new HashAlgorithmName("SHA1");
			}
		}

		/// <summary>Получает имя хэш-алгоритма, которое представляет "SHA256".</summary>
		/// <returns>Имя хэш-алгоритма, которое представляет "SHA256".</returns>
		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06002E1C RID: 11804 RVA: 0x000A5DEA File Offset: 0x000A3FEA
		public static HashAlgorithmName SHA256
		{
			get
			{
				return new HashAlgorithmName("SHA256");
			}
		}

		/// <summary>Получает имя хэш-алгоритма, которое представляет "SHA384".</summary>
		/// <returns>Имя хэш-алгоритма, которое представляет "SHA384".</returns>
		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06002E1D RID: 11805 RVA: 0x000A5DF6 File Offset: 0x000A3FF6
		public static HashAlgorithmName SHA384
		{
			get
			{
				return new HashAlgorithmName("SHA384");
			}
		}

		/// <summary>Получает имя хэш-алгоритма, которое представляет "SHA512".</summary>
		/// <returns>Имя хэш-алгоритма, которое представляет "SHA512".</returns>
		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06002E1E RID: 11806 RVA: 0x000A5E02 File Offset: 0x000A4002
		public static HashAlgorithmName SHA512
		{
			get
			{
				return new HashAlgorithmName("SHA512");
			}
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Security.Cryptography.HashAlgorithmName" /> с пользовательским именем.</summary>
		/// <param name="name">Имя пользовательского хэш-алгоритма.</param>
		// Token: 0x06002E1F RID: 11807 RVA: 0x000A5E0E File Offset: 0x000A400E
		public HashAlgorithmName(string name)
		{
			this._name = name;
		}

		/// <summary>Получает базовое представление строки для имени алгоритма.</summary>
		/// <returns>Представление строки для имени алгоритма, <see langword="null" /> или <see cref="F:System.String.Empty" />, если хэш-алгоритм недоступен.</returns>
		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06002E20 RID: 11808 RVA: 0x000A5E17 File Offset: 0x000A4017
		public string Name
		{
			get
			{
				return this._name;
			}
		}

		/// <summary>Возвращает строковое представление текущего экземпляра <see cref="T:System.Security.Cryptography.HashAlgorithmName" />.</summary>
		/// <returns>Представление строки текущего экземпляра <see cref="T:System.Security.Cryptography.HashAlgorithmName" />.</returns>
		// Token: 0x06002E21 RID: 11809 RVA: 0x000A5E1F File Offset: 0x000A401F
		public override string ToString()
		{
			return this._name ?? string.Empty;
		}

		/// <summary>Возвращает значение, указывающее, равен ли данный экземпляр указанному объекту.</summary>
		/// <param name="obj">Объект для сравнения с текущим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="obj" /> является объектом <see cref="T:System.Security.Cryptography.HashAlgorithmName" />, а его свойство <see cref="P:System.Security.Cryptography.HashAlgorithmName.Name" /> равно свойству текущего экземпляра. Сравнение выполняется по порядку, без учета регистра.</returns>
		// Token: 0x06002E22 RID: 11810 RVA: 0x000A5E30 File Offset: 0x000A4030
		public override bool Equals(object obj)
		{
			return obj is HashAlgorithmName && this.Equals((HashAlgorithmName)obj);
		}

		/// <summary>Возвращает значение, указывающее, равны ли два экземпляра <see cref="T:System.Security.Cryptography.HashAlgorithmName" />.</summary>
		/// <param name="other">Объект для сравнения с текущим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если свойство <see cref="P:System.Security.Cryptography.HashAlgorithmName.Name" /> для <paramref name="other" /> равно свойству текущего экземпляра. Сравнение выполняется по порядку, без учета регистра.</returns>
		// Token: 0x06002E23 RID: 11811 RVA: 0x000A5E48 File Offset: 0x000A4048
		public bool Equals(HashAlgorithmName other)
		{
			return this._name == other._name;
		}

		/// <summary>Возвращает хэш-код текущего экземпляра.</summary>
		/// <returns>Хэш-код для текущего экземпляра или 0, если значение <paramref name="name" /> не было предоставлено конструктору <see cref="T:System.Security.Cryptography.HashAlgorithmName" />.</returns>
		// Token: 0x06002E24 RID: 11812 RVA: 0x000A5E5B File Offset: 0x000A405B
		public override int GetHashCode()
		{
			if (this._name != null)
			{
				return this._name.GetHashCode();
			}
			return 0;
		}

		/// <summary>Определение равенства двух заданных объектов <see cref="T:System.Security.Cryptography.HashAlgorithmName" />.</summary>
		/// <param name="left">Первый из сравниваемых объектов.</param>
		/// <param name="right">Второй из сравниваемых объектов.</param>
		/// <returns>Значение <see langword="true" />, если и <paramref name="left" />, и <paramref name="right" /> имеют одно значение <see cref="P:System.Security.Cryptography.HashAlgorithmName.Name" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002E25 RID: 11813 RVA: 0x000A5E72 File Offset: 0x000A4072
		public static bool operator ==(HashAlgorithmName left, HashAlgorithmName right)
		{
			return left.Equals(right);
		}

		/// <summary>Определение неравенства двух заданных объектов <see cref="T:System.Security.Cryptography.HashAlgorithmName" />.</summary>
		/// <param name="left">Первый из сравниваемых объектов.</param>
		/// <param name="right">Второй из сравниваемых объектов.</param>
		/// <returns>Значение <see langword="true" />, если и <paramref name="left" />, и <paramref name="right" /> имеют разные значения <see cref="P:System.Security.Cryptography.HashAlgorithmName.Name" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06002E26 RID: 11814 RVA: 0x000A5E7C File Offset: 0x000A407C
		public static bool operator !=(HashAlgorithmName left, HashAlgorithmName right)
		{
			return !(left == right);
		}

		// Token: 0x04002118 RID: 8472
		private readonly string _name;
	}
}
