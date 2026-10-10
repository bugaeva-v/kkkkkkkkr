using System;
using Unity;

namespace System.Security.Cryptography.Pkcs
{
	/// <summary>Класс <see cref="T:System.Security.Cryptography.Pkcs.PublicKeyInfo" /> представляет информацию, связанную открытым ключом.</summary>
	// Token: 0x0200007F RID: 127
	public sealed class PublicKeyInfo
	{
		// Token: 0x0600041F RID: 1055 RVA: 0x00012CC2 File Offset: 0x00010EC2
		internal PublicKeyInfo(AlgorithmIdentifier algorithm, byte[] keyValue)
		{
			this.Algorithm = algorithm;
			this.KeyValue = keyValue;
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.PublicKeyInfo.Algorithm" /> возвращает идентификатор алгоритма, связанный с открытым ключом.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Pkcs.AlgorithmIdentifier" />, представляющий алгоритм.</returns>
		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x00012CD8 File Offset: 0x00010ED8
		public AlgorithmIdentifier Algorithm { get; }

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.PublicKeyInfo.KeyValue" /> возвращает значение закодированной открытой части пары ключей.</summary>
		/// <returns>Массив байтовых значений, представляющий закодированную открытую часть пары ключей.</returns>
		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x00012CE0 File Offset: 0x00010EE0
		public byte[] KeyValue { get; }

		// Token: 0x06000422 RID: 1058 RVA: 0x000029A4 File Offset: 0x00000BA4
		internal PublicKeyInfo()
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
