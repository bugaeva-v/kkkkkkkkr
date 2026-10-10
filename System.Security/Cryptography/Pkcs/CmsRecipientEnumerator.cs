using System;
using System.Collections;
using Unity;

namespace System.Security.Cryptography.Pkcs
{
	/// <summary>Класс <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipientEnumerator" /> предоставляет функциональные возможности перечисления для коллекции <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipientCollection" />. Класс <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipientEnumerator" /> реализует интерфейс списка <see cref="T:System.Collections.IEnumerator" />.</summary>
	// Token: 0x0200006B RID: 107
	public sealed class CmsRecipientEnumerator : IEnumerator
	{
		// Token: 0x0600038F RID: 911 RVA: 0x000110CE File Offset: 0x0000F2CE
		internal CmsRecipientEnumerator(CmsRecipientCollection recipients)
		{
			this._recipients = recipients;
			this._current = -1;
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.CmsRecipientEnumerator.Current" /> возвращает текущий объект <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipient" /> коллекции <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipientCollection" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipient" />, который представляет текущего получателя в коллекции <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipientCollection" />.</returns>
		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000390 RID: 912 RVA: 0x000110E4 File Offset: 0x0000F2E4
		public CmsRecipient Current
		{
			get
			{
				return this._recipients[this._current];
			}
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.CmsRecipientEnumerator.System#Collections#IEnumerator#Current" /> возвращает текущий объект <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipient" /> коллекции <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipientCollection" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipient" />, который представляет текущего получателя в коллекции <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipientCollection" />.</returns>
		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000391 RID: 913 RVA: 0x000110E4 File Offset: 0x0000F2E4
		object IEnumerator.Current
		{
			get
			{
				return this._recipients[this._current];
			}
		}

		/// <summary>Метод <see cref="M:System.Security.Cryptography.Pkcs.CmsRecipientEnumerator.MoveNext" /> выполняет переход к следующему объекту <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipient" /> коллекции <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipientCollection" />.</summary>
		/// <returns>Метод возвращает значение <see langword="true" /> в случае успешного перехода к следующему объекту <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipient" /> и значение <see langword="false" />, если в результате перехода был пройден последний элемент перечисления.</returns>
		// Token: 0x06000392 RID: 914 RVA: 0x000110F7 File Offset: 0x0000F2F7
		public bool MoveNext()
		{
			if (this._current >= this._recipients.Count - 1)
			{
				return false;
			}
			this._current++;
			return true;
		}

		/// <summary>Метод <see cref="M:System.Security.Cryptography.Pkcs.CmsRecipientEnumerator.Reset" /> выполняет сброс перечисления к первому объекту <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipient" /> коллекции <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipientCollection" />.</summary>
		// Token: 0x06000393 RID: 915 RVA: 0x0001111F File Offset: 0x0000F31F
		public void Reset()
		{
			this._current = -1;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x000029A4 File Offset: 0x00000BA4
		internal CmsRecipientEnumerator()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04000267 RID: 615
		private readonly CmsRecipientCollection _recipients;

		// Token: 0x04000268 RID: 616
		private int _current;
	}
}
