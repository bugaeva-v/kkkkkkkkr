using System;
using System.Collections;
using Unity;

namespace System.Security.Cryptography
{
	/// <summary>Предоставляет возможность перемещаться по объекту <see cref="T:System.Security.Cryptography.OidCollection" />. Этот класс не наследуется.</summary>
	// Token: 0x020002B7 RID: 695
	public sealed class OidEnumerator : IEnumerator
	{
		// Token: 0x060015DA RID: 5594 RVA: 0x000578EE File Offset: 0x00055AEE
		internal OidEnumerator(OidCollection oids)
		{
			this._oids = oids;
			this._current = -1;
		}

		/// <summary>Получает текущий объект <see cref="T:System.Security.Cryptography.Oid" /> в объекте <see cref="T:System.Security.Cryptography.OidCollection" />.</summary>
		/// <returns>Текущий объект <see cref="T:System.Security.Cryptography.Oid" /> в коллекции.</returns>
		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x060015DB RID: 5595 RVA: 0x00057904 File Offset: 0x00055B04
		public Oid Current
		{
			get
			{
				return this._oids[this._current];
			}
		}

		/// <summary>Получает текущий объект <see cref="T:System.Security.Cryptography.Oid" /> в объекте <see cref="T:System.Security.Cryptography.OidCollection" />.</summary>
		/// <returns>Текущий объект <see cref="T:System.Security.Cryptography.Oid" />.</returns>
		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x060015DC RID: 5596 RVA: 0x00057917 File Offset: 0x00055B17
		object IEnumerator.Current
		{
			get
			{
				return this.Current;
			}
		}

		/// <summary>Осуществляет переход к следующему объекту <see cref="T:System.Security.Cryptography.Oid" /> в объекте <see cref="T:System.Security.Cryptography.OidCollection" />.</summary>
		/// <returns>Значение <see langword="true" />, если перечислитель был успешно перемещен к следующему элементу; значение <see langword="false" />, если перечислитель достиг конца коллекции.</returns>
		/// <exception cref="T:System.InvalidOperationException">После создания перечислителя семейство было изменено.</exception>
		// Token: 0x060015DD RID: 5597 RVA: 0x0005791F File Offset: 0x00055B1F
		public bool MoveNext()
		{
			if (this._current >= this._oids.Count - 1)
			{
				return false;
			}
			this._current++;
			return true;
		}

		/// <summary>Устанавливает перечислитель в исходное положение.</summary>
		/// <exception cref="T:System.InvalidOperationException">После создания перечислителя семейство было изменено.</exception>
		// Token: 0x060015DE RID: 5598 RVA: 0x00057947 File Offset: 0x00055B47
		public void Reset()
		{
			this._current = -1;
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x00013BCA File Offset: 0x00011DCA
		internal OidEnumerator()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04000C36 RID: 3126
		private readonly OidCollection _oids;

		// Token: 0x04000C37 RID: 3127
		private int _current;
	}
}
