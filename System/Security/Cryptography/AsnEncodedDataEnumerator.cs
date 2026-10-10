using System;
using System.Collections;
using Unity;

namespace System.Security.Cryptography
{
	/// <summary>Предоставляет возможность перемещаться по объекту <see cref="T:System.Security.Cryptography.AsnEncodedDataCollection" />. Этот класс не наследуется.</summary>
	// Token: 0x020002B4 RID: 692
	public sealed class AsnEncodedDataEnumerator : IEnumerator
	{
		// Token: 0x060015BE RID: 5566 RVA: 0x0005758A File Offset: 0x0005578A
		internal AsnEncodedDataEnumerator(AsnEncodedDataCollection asnEncodedDatas)
		{
			this._asnEncodedDatas = asnEncodedDatas;
			this._current = -1;
		}

		/// <summary>Получает текущий объект <see cref="T:System.Security.Cryptography.AsnEncodedData" /> в объекте <see cref="T:System.Security.Cryptography.AsnEncodedDataCollection" />.</summary>
		/// <returns>Текущий объект <see cref="T:System.Security.Cryptography.AsnEncodedData" /> в коллекции.</returns>
		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x060015BF RID: 5567 RVA: 0x000575A0 File Offset: 0x000557A0
		public AsnEncodedData Current
		{
			get
			{
				return this._asnEncodedDatas[this._current];
			}
		}

		/// <summary>Получает текущий объект <see cref="T:System.Security.Cryptography.AsnEncodedData" /> в объекте <see cref="T:System.Security.Cryptography.AsnEncodedDataCollection" />.</summary>
		/// <returns>Текущий объект <see cref="T:System.Security.Cryptography.AsnEncodedData" />.</returns>
		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x060015C0 RID: 5568 RVA: 0x000575A0 File Offset: 0x000557A0
		object IEnumerator.Current
		{
			get
			{
				return this._asnEncodedDatas[this._current];
			}
		}

		/// <summary>Осуществляет переход к следующему объекту <see cref="T:System.Security.Cryptography.AsnEncodedData" /> в объекте <see cref="T:System.Security.Cryptography.AsnEncodedDataCollection" />.</summary>
		/// <returns>Значение <see langword="true" />, если перечислитель был успешно перемещен к следующему элементу; значение <see langword="false" />, если перечислитель достиг конца коллекции.</returns>
		/// <exception cref="T:System.InvalidOperationException">Коллекция была изменена после создания перечислителя.</exception>
		// Token: 0x060015C1 RID: 5569 RVA: 0x000575B3 File Offset: 0x000557B3
		public bool MoveNext()
		{
			if (this._current >= this._asnEncodedDatas.Count - 1)
			{
				return false;
			}
			this._current++;
			return true;
		}

		/// <summary>Устанавливает перечислитель в исходное положение.</summary>
		/// <exception cref="T:System.InvalidOperationException">Коллекция была изменена после создания перечислителя.</exception>
		// Token: 0x060015C2 RID: 5570 RVA: 0x000575DB File Offset: 0x000557DB
		public void Reset()
		{
			this._current = -1;
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x00013BCA File Offset: 0x00011DCA
		internal AsnEncodedDataEnumerator()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04000C30 RID: 3120
		private readonly AsnEncodedDataCollection _asnEncodedDatas;

		// Token: 0x04000C31 RID: 3121
		private int _current;
	}
}
