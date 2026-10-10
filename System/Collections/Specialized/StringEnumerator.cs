using System;
using Unity;

namespace System.Collections.Specialized
{
	/// <summary>Поддерживает простой перебор коллекции <see cref="T:System.Collections.Specialized.StringCollection" />.</summary>
	// Token: 0x020004B1 RID: 1201
	public class StringEnumerator
	{
		// Token: 0x060026D4 RID: 9940 RVA: 0x0008738F File Offset: 0x0008558F
		internal StringEnumerator(StringCollection mappings)
		{
			this._temp = mappings;
			this._baseEnumerator = this._temp.GetEnumerator();
		}

		/// <summary>Получает текущий элемент в коллекции.</summary>
		/// <returns>Текущий элемент в коллекции.</returns>
		/// <exception cref="T:System.InvalidOperationException">Перечислитель размещается перед первым элементом семейства или после его последнего элемента.</exception>
		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x060026D5 RID: 9941 RVA: 0x000873AF File Offset: 0x000855AF
		public string Current
		{
			get
			{
				return (string)this._baseEnumerator.Current;
			}
		}

		/// <summary>Перемещает перечислитель к следующему элементу коллекции.</summary>
		/// <returns>Значение <see langword="true" />, если перечислитель был успешно перемещен к следующему элементу; значение <see langword="false" />, если перечислитель достиг конца коллекции.</returns>
		/// <exception cref="T:System.InvalidOperationException">После создания перечислителя семейство было изменено.</exception>
		// Token: 0x060026D6 RID: 9942 RVA: 0x000873C1 File Offset: 0x000855C1
		public bool MoveNext()
		{
			return this._baseEnumerator.MoveNext();
		}

		/// <summary>Устанавливает перечислитель в его начальное положение, т. е. перед первым элементом коллекции.</summary>
		/// <exception cref="T:System.InvalidOperationException">После создания перечислителя семейство было изменено.</exception>
		// Token: 0x060026D7 RID: 9943 RVA: 0x000873CE File Offset: 0x000855CE
		public void Reset()
		{
			this._baseEnumerator.Reset();
		}

		// Token: 0x060026D8 RID: 9944 RVA: 0x00013BCA File Offset: 0x00011DCA
		internal StringEnumerator()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04001512 RID: 5394
		private IEnumerator _baseEnumerator;

		// Token: 0x04001513 RID: 5395
		private IEnumerable _temp;
	}
}
