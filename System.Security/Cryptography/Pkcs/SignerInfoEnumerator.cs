using System;
using System.Collections;

namespace System.Security.Cryptography.Pkcs
{
	/// <summary>Класс <see cref="T:System.Security.Cryptography.Pkcs.SignerInfoEnumerator" /> предоставляет функциональные возможности перечисления для коллекции <see cref="T:System.Security.Cryptography.Pkcs.SignerInfoCollection" />. Класс <see cref="T:System.Security.Cryptography.Pkcs.SignerInfoEnumerator" /> реализует интерфейс списка <see cref="T:System.Collections.IEnumerator" />.</summary>
	// Token: 0x02000088 RID: 136
	public sealed class SignerInfoEnumerator : IEnumerator
	{
		// Token: 0x0600048C RID: 1164 RVA: 0x00002145 File Offset: 0x00000345
		private SignerInfoEnumerator()
		{
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x000147E3 File Offset: 0x000129E3
		internal SignerInfoEnumerator(SignerInfoCollection signerInfos)
		{
			this._signerInfos = signerInfos;
			this._position = -1;
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.SignerInfoEnumerator.Current" /> возвращает текущий объект <see cref="T:System.Security.Cryptography.Pkcs.SignerInfo" /> коллекции <see cref="T:System.Security.Cryptography.Pkcs.SignerInfoCollection" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Pkcs.SignerInfo" />, который представляет информацию о текущем подписавшем в коллекции <see cref="T:System.Security.Cryptography.Pkcs.SignerInfoCollection" />.</returns>
		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x000147F9 File Offset: 0x000129F9
		public SignerInfo Current
		{
			get
			{
				return this._signerInfos[this._position];
			}
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.SignerInfoEnumerator.System#Collections#IEnumerator#Current" /> возвращает текущий объект <see cref="T:System.Security.Cryptography.Pkcs.SignerInfo" /> коллекции <see cref="T:System.Security.Cryptography.Pkcs.SignerInfoCollection" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Pkcs.SignerInfo" />, который представляет информацию о текущем подписавшем в коллекции <see cref="T:System.Security.Cryptography.Pkcs.SignerInfoCollection" />.</returns>
		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x000147F9 File Offset: 0x000129F9
		object IEnumerator.Current
		{
			get
			{
				return this._signerInfos[this._position];
			}
		}

		/// <summary>Метод <see cref="M:System.Security.Cryptography.Pkcs.SignerInfoEnumerator.MoveNext" /> выполняет переход к следующему объекту <see cref="T:System.Security.Cryptography.Pkcs.SignerInfo" /> в коллекции <see cref="T:System.Security.Cryptography.Pkcs.SignerInfoCollection" />.</summary>
		/// <returns>Этот метод возвращает логическое значение, определяющее, был ли переход выполнен успешно. В случае успешного перехода к следующему объекту <see cref="T:System.Security.Cryptography.Pkcs.SignerInfo" /> метод возвращает значение <see langword="true" />. Если в результате перехода был пройден последний элемент перечисления, метод возвращает значение <see langword="false" />.</returns>
		// Token: 0x06000490 RID: 1168 RVA: 0x0001480C File Offset: 0x00012A0C
		public bool MoveNext()
		{
			int num = this._position + 1;
			if (num >= this._signerInfos.Count)
			{
				return false;
			}
			this._position = num;
			return true;
		}

		/// <summary>Метод <see cref="M:System.Security.Cryptography.Pkcs.SignerInfoEnumerator.Reset" /> выполняет сброс перечисления к первому объекту <see cref="T:System.Security.Cryptography.Pkcs.SignerInfo" /> коллекции <see cref="T:System.Security.Cryptography.Pkcs.SignerInfoCollection" />.</summary>
		// Token: 0x06000491 RID: 1169 RVA: 0x0001483A File Offset: 0x00012A3A
		public void Reset()
		{
			this._position = -1;
		}

		// Token: 0x040002BD RID: 701
		private readonly SignerInfoCollection _signerInfos;

		// Token: 0x040002BE RID: 702
		private int _position;
	}
}
