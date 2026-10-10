using System;
using System.Collections;
using System.Collections.Generic;
using Unity;

namespace System.Net
{
	/// <summary>Представляет коллекцию, используемую для хранения префиксов URI для объектов <see cref="T:System.Net.HttpListener" />.</summary>
	// Token: 0x0200068C RID: 1676
	public class HttpListenerPrefixCollection : ICollection<string>, IEnumerable<string>, IEnumerable
	{
		// Token: 0x060034EF RID: 13551 RVA: 0x000B90E0 File Offset: 0x000B72E0
		internal HttpListenerPrefixCollection(HttpListener listener)
		{
			this.prefixes = new List<string>();
			base..ctor();
			this.listener = listener;
		}

		/// <summary>Возвращает количество префиксов в коллекции.</summary>
		/// <returns>Значение <see cref="T:System.Int32" />, которое содержит количество префиксов в этой коллекции.</returns>
		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x060034F0 RID: 13552 RVA: 0x000B90FA File Offset: 0x000B72FA
		public int Count
		{
			get
			{
				return this.prefixes.Count;
			}
		}

		/// <summary>Возвращает значение, показывающее доступна ли коллекция только для чтения.</summary>
		/// <returns>Всегда возвращает значение <see langword="false" />.</returns>
		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x060034F1 RID: 13553 RVA: 0x00003062 File Offset: 0x00001262
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает значение, указывающее, является ли доступ к коллекции синхронизированным (потокобезопасным).</summary>
		/// <returns>Данное свойство всегда возвращает значение <see langword="false" />.</returns>
		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x060034F2 RID: 13554 RVA: 0x00003062 File Offset: 0x00001262
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Добавляет префикс универсального кода ресурса (URI) в коллекцию.</summary>
		/// <param name="uriPrefix">Строка <see cref="T:System.String" />, указывающая сведения об URI, которые сравниваются во входящих запросах. Префикс должен завершаться косой чертой ("/").</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="uriPrefix" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="uriPrefix" /> не использует схему http:// или https://. Это единственные схемы, поддерживаемые объектами <see cref="T:System.Net.HttpListener" />.  
		///
		/// или - 
		/// Параметр <paramref name="uriPrefix" /> задан неправильно. Строка должна завершаться косой чертой ("/").</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.HttpListener" />, связанный с этой коллекцией, закрыт.</exception>
		/// <exception cref="T:System.Net.HttpListenerException">Вызов функции Windows завершился сбоем. Проверьте свойство исключения <see cref="P:System.Net.HttpListenerException.ErrorCode" />, чтобы определить причину исключения. Это исключение будет вызвано, если другой объект <see cref="T:System.Net.HttpListener" /> уже добавил этот префикс <paramref name="uriPrefix" />.</exception>
		// Token: 0x060034F3 RID: 13555 RVA: 0x000B9108 File Offset: 0x000B7308
		public void Add(string uriPrefix)
		{
			this.listener.CheckDisposed();
			ListenerPrefix.CheckUri(uriPrefix);
			if (this.prefixes.Contains(uriPrefix))
			{
				return;
			}
			this.prefixes.Add(uriPrefix);
			if (this.listener.IsListening)
			{
				EndPointManager.AddPrefix(uriPrefix, this.listener);
			}
		}

		/// <summary>Удаляет префиксы URI из коллекции.</summary>
		/// <exception cref="T:System.Net.HttpListenerException">Вызов функции Windows завершился сбоем. Проверьте свойство исключения <see cref="P:System.Net.HttpListenerException.ErrorCode" />, чтобы определить причину исключения.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.HttpListener" />, связанный с этой коллекцией, закрыт.</exception>
		// Token: 0x060034F4 RID: 13556 RVA: 0x000B915A File Offset: 0x000B735A
		public void Clear()
		{
			this.listener.CheckDisposed();
			this.prefixes.Clear();
			if (this.listener.IsListening)
			{
				EndPointManager.RemoveListener(this.listener);
			}
		}

		/// <summary>Возвращает значение <see cref="T:System.Boolean" />, которое указывает, содержится ли в коллекции указанный префикс.</summary>
		/// <param name="uriPrefix">Строка <see cref="T:System.String" />, которая содержит проверяемый префикс URI.</param>
		/// <returns>Значение <see langword="true" />, если коллекция содержит указанный префикс, определенный параметром <paramref name="uriPrefix" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="uriPrefix" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060034F5 RID: 13557 RVA: 0x000B918A File Offset: 0x000B738A
		public bool Contains(string uriPrefix)
		{
			this.listener.CheckDisposed();
			return this.prefixes.Contains(uriPrefix);
		}

		/// <summary>Копирует содержимое объекта <see cref="T:System.Net.HttpListenerPrefixCollection" /> в указанный строковый массив.</summary>
		/// <param name="array">Одномерный строковый массив, получающий строки префиксов URI в этой коллекции.</param>
		/// <param name="offset">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="array" /> имеет более одного измерения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Эта коллекция содержит больше элементов, чем может быть сохранено в массиве <paramref name="array" />, начиная с <paramref name="offset" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.HttpListener" />, связанный с этой коллекцией, закрыт.</exception>
		// Token: 0x060034F6 RID: 13558 RVA: 0x000B91A3 File Offset: 0x000B73A3
		public void CopyTo(string[] array, int offset)
		{
			this.listener.CheckDisposed();
			this.prefixes.CopyTo(array, offset);
		}

		/// <summary>Копирует содержимое коллекции <see cref="T:System.Net.HttpListenerPrefixCollection" /> в указанный массив.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, получающий строки префиксов URI в этой коллекции.</param>
		/// <param name="offset">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="array" /> имеет более одного измерения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Эта коллекция содержит больше элементов, чем может быть сохранено в массиве <paramref name="array" />, начиная с <paramref name="offset" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.HttpListener" />, связанный с этой коллекцией, закрыт.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="array" /> не может содержать строковые значения.</exception>
		// Token: 0x060034F7 RID: 13559 RVA: 0x000B91BD File Offset: 0x000B73BD
		public void CopyTo(Array array, int offset)
		{
			this.listener.CheckDisposed();
			((ICollection)this.prefixes).CopyTo(array, offset);
		}

		/// <summary>Возвращает объект, который может использоваться для перебора элементов коллекции.</summary>
		/// <returns>Объект, реализующий интерфейс <see cref="T:System.Collections.IEnumerator" /> и предоставляющий доступ к строкам в этой коллекции.</returns>
		// Token: 0x060034F8 RID: 13560 RVA: 0x000B91D7 File Offset: 0x000B73D7
		public IEnumerator<string> GetEnumerator()
		{
			return this.prefixes.GetEnumerator();
		}

		/// <summary>Возвращает объект, который может использоваться для перебора элементов коллекции.</summary>
		/// <returns>Объект, реализующий интерфейс <see cref="T:System.Collections.IEnumerator" /> и предоставляющий доступ к строкам в этой коллекции.</returns>
		// Token: 0x060034F9 RID: 13561 RVA: 0x000B91D7 File Offset: 0x000B73D7
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.prefixes.GetEnumerator();
		}

		/// <summary>Удаляет указанный URI из списка префиксов, обрабатываемых объектом <see cref="T:System.Net.HttpListener" />.</summary>
		/// <param name="uriPrefix">Строка <see cref="T:System.String" />, содержащая удаляемый префикс URI.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="uriPrefix" /> обнаружен в <see cref="T:System.Net.HttpListenerPrefixCollection" /> и удален; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="uriPrefix" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.HttpListenerException">Вызов функции Windows завершился сбоем. Чтобы определить причину исключения, просмотрите код ошибки исключения.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.HttpListener" />, связанный с этой коллекцией, закрыт.</exception>
		// Token: 0x060034FA RID: 13562 RVA: 0x000B91EC File Offset: 0x000B73EC
		public bool Remove(string uriPrefix)
		{
			this.listener.CheckDisposed();
			if (uriPrefix == null)
			{
				throw new ArgumentNullException("uriPrefix");
			}
			bool flag = this.prefixes.Remove(uriPrefix);
			if (flag && this.listener.IsListening)
			{
				EndPointManager.RemovePrefix(uriPrefix, this.listener);
			}
			return flag;
		}

		// Token: 0x060034FB RID: 13563 RVA: 0x00013BCA File Offset: 0x00011DCA
		internal HttpListenerPrefixCollection()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04001EE7 RID: 7911
		private List<string> prefixes;

		// Token: 0x04001EE8 RID: 7912
		private HttpListener listener;
	}
}
