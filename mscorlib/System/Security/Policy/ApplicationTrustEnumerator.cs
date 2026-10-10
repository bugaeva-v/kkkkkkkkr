using System;
using System.Collections;
using System.Runtime.InteropServices;
using Unity;

namespace System.Security.Policy
{
	/// <summary>Представляет перечислитель для объектов <see cref="T:System.Security.Policy.ApplicationTrust" /> в коллекции <see cref="T:System.Security.Policy.ApplicationTrustCollection" />.</summary>
	// Token: 0x02000405 RID: 1029
	[ComVisible(true)]
	public sealed class ApplicationTrustEnumerator : IEnumerator
	{
		// Token: 0x06002A15 RID: 10773 RVA: 0x00098939 File Offset: 0x00096B39
		internal ApplicationTrustEnumerator(ApplicationTrustCollection atc)
		{
			this.trusts = atc;
			this.current = -1;
		}

		/// <summary>Получает текущий объект <see cref="T:System.Security.Policy.ApplicationTrust" /> в коллекции <see cref="T:System.Security.Policy.ApplicationTrustCollection" />.</summary>
		/// <returns>Текущий объект <see cref="T:System.Security.Policy.ApplicationTrust" /> в объекте <see cref="T:System.Security.Policy.ApplicationTrustCollection" />.</returns>
		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06002A16 RID: 10774 RVA: 0x0009894F File Offset: 0x00096B4F
		public ApplicationTrust Current
		{
			get
			{
				return this.trusts[this.current];
			}
		}

		/// <summary>Получает текущий объект <see cref="T:System.Object" /> в коллекции<see cref="T:System.Security.Policy.ApplicationTrustCollection" />.</summary>
		/// <returns>Текущий объект <see cref="T:System.Object" /> в объекте <see cref="T:System.Security.Policy.ApplicationTrustCollection" />.</returns>
		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06002A17 RID: 10775 RVA: 0x0009894F File Offset: 0x00096B4F
		object IEnumerator.Current
		{
			get
			{
				return this.trusts[this.current];
			}
		}

		/// <summary>Вновь устанавливает перечислитель на начало коллекции <see cref="T:System.Security.Policy.ApplicationTrustCollection" />.</summary>
		// Token: 0x06002A18 RID: 10776 RVA: 0x00098962 File Offset: 0x00096B62
		public void Reset()
		{
			this.current = -1;
		}

		/// <summary>Переходит к следующему элементу в коллекции <see cref="T:System.Security.Policy.ApplicationTrustCollection" />.</summary>
		/// <returns>Значение <see langword="true" />, если перечислитель был успешно перемещен к следующему элементу; значение <see langword="false" />, если перечислитель достиг конца коллекции.</returns>
		// Token: 0x06002A19 RID: 10777 RVA: 0x0009896B File Offset: 0x00096B6B
		[SecuritySafeCritical]
		public bool MoveNext()
		{
			if (this.current == this.trusts.Count - 1)
			{
				return false;
			}
			this.current++;
			return true;
		}

		// Token: 0x06002A1A RID: 10778 RVA: 0x000173AD File Offset: 0x000155AD
		internal ApplicationTrustEnumerator()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04001F62 RID: 8034
		private ApplicationTrustCollection trusts;

		// Token: 0x04001F63 RID: 8035
		private int current;
	}
}
