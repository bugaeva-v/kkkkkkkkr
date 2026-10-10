using System;
using System.Collections;
using Unity;

namespace System.Security.Cryptography.Pkcs
{
	/// <summary>Класс <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfoEnumerator" /> предоставляет функциональные возможности перечисления для коллекции <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfoCollection" />. Класс <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfoEnumerator" /> реализует интерфейс списка <see cref="T:System.Collections.IEnumerator" />.</summary>
	// Token: 0x02000082 RID: 130
	public sealed class RecipientInfoEnumerator : IEnumerator
	{
		// Token: 0x06000436 RID: 1078 RVA: 0x00012E66 File Offset: 0x00011066
		internal RecipientInfoEnumerator(RecipientInfoCollection RecipientInfos)
		{
			this._recipientInfos = RecipientInfos;
			this._current = -1;
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.RecipientInfoEnumerator.Current" /> возвращает текущий объект <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfo" /> коллекции <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfoCollection" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfo" />, который представляет информацию о текущем получателе в коллекции <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfoCollection" />.</returns>
		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x00012E7C File Offset: 0x0001107C
		public RecipientInfo Current
		{
			get
			{
				return this._recipientInfos[this._current];
			}
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.RecipientInfoEnumerator.System#Collections#IEnumerator#Current" /> возвращает текущий объект <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfo" /> коллекции <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfoCollection" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfo" />, который представляет информацию о текущем получателе в коллекции <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfoCollection" />.</returns>
		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x00012E7C File Offset: 0x0001107C
		object IEnumerator.Current
		{
			get
			{
				return this._recipientInfos[this._current];
			}
		}

		/// <summary>Метод <see cref="M:System.Security.Cryptography.Pkcs.RecipientInfoEnumerator.MoveNext" /> выполняет переход к следующему объекту <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfo" /> коллекции <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfoCollection" />.</summary>
		/// <returns>Этот метод возвращает логическое значение, определяющее, был ли переход выполнен успешно. В случае успешного перехода к следующему объекту <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfo" /> метод возвращает значение <see langword="true" />. Если в результате перехода был пройден последний элемент перечисления, метод возвращает значение <see langword="false" />.</returns>
		// Token: 0x06000439 RID: 1081 RVA: 0x00012E8F File Offset: 0x0001108F
		public bool MoveNext()
		{
			if (this._current >= this._recipientInfos.Count - 1)
			{
				return false;
			}
			this._current++;
			return true;
		}

		/// <summary>Метод <see cref="M:System.Security.Cryptography.Pkcs.RecipientInfoEnumerator.Reset" /> выполняет сброс перечисления к первому объекту <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfo" /> коллекции <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfoCollection" />.</summary>
		// Token: 0x0600043A RID: 1082 RVA: 0x00012EB7 File Offset: 0x000110B7
		public void Reset()
		{
			this._current = -1;
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x000029A4 File Offset: 0x00000BA4
		internal RecipientInfoEnumerator()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x0400029C RID: 668
		private readonly RecipientInfoCollection _recipientInfos;

		// Token: 0x0400029D RID: 669
		private int _current;
	}
}
