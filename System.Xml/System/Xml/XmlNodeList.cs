using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace System.Xml
{
	/// <summary>
	///         Представляет упорядоченную коллекцию узлов.
	///       </summary>
	// Token: 0x020001D4 RID: 468
	public abstract class XmlNodeList : IEnumerable, IDisposable
	{
		/// <summary>
		///         Извлекает узел по заданному индексу.
		///       </summary>
		/// <param name="index">
		///           Отсчитываемый от нуля индекс в списке узлов.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Xml.XmlNode" /> С указанным индексом в коллекции.
		///          Если <paramref name="index" /> имеет больше или равно числу узлов в списке, возвращается <see langword="null" />.
		///       </returns>
		// Token: 0x06001243 RID: 4675
		public abstract XmlNode Item(int index);

		/// <summary>
		///         Возвращает количество узлов в <see langword="XmlNodeList" />.
		///       </summary>
		/// <returns>
		///         Количество узлов в <see langword="XmlNodeList" />.
		///       </returns>
		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06001244 RID: 4676
		public abstract int Count { get; }

		/// <summary>
		///         Возвращает перечислитель, выполняющий итерацию по коллекции узлов.
		///       </summary>
		/// <returns>
		///         Перечислитель для прохода по коллекции узлов.
		///       </returns>
		// Token: 0x06001245 RID: 4677
		public abstract IEnumerator GetEnumerator();

		/// <summary>
		///         Возвращает узел по указанному индексу.
		///       </summary>
		/// <param name="i">
		///           Отсчитываемый от нуля индекс в списке узлов.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Xml.XmlNode" /> С указанным индексом в коллекции.
		///          Если индекс больше или равно числу узлов в списке, возвращается <see langword="null" />.
		///       </returns>
		// Token: 0x17000350 RID: 848
		[IndexerName("ItemOf")]
		public virtual XmlNode this[int i]
		{
			get
			{
				return this.Item(i);
			}
		}

		/// <summary>
		///         Освобождает все ресурсы, используемые классом <see cref="T:System.Xml.XmlNodeList" />.
		///       </summary>
		// Token: 0x06001247 RID: 4679 RVA: 0x0006E518 File Offset: 0x0006C718
		void IDisposable.Dispose()
		{
			this.PrivateDisposeNodeList();
		}

		/// <summary>
		///         Освобождает ресурсы, в списке узлов в частном порядке.
		///       </summary>
		// Token: 0x06001248 RID: 4680 RVA: 0x0000B528 File Offset: 0x00009728
		protected virtual void PrivateDisposeNodeList()
		{
		}
	}
}
