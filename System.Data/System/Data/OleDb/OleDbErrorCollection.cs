using System;
using System.Collections;
using System.Data.Common;

namespace System.Data.OleDb
{
	/// <summary>Собирает все ошибки, созданные поставщиком данных .NET Framework для OLE DB. Этот класс не наследуется.</summary>
	// Token: 0x02000165 RID: 357
	[MonoTODO("OleDb is not implemented.")]
	public sealed class OleDbErrorCollection : ICollection, IEnumerable
	{
		// Token: 0x0600135B RID: 4955 RVA: 0x00003D93 File Offset: 0x00001F93
		internal OleDbErrorCollection()
		{
		}

		/// <summary>Получает число ошибок в коллекции.</summary>
		/// <returns>Общее число ошибок в коллекции.</returns>
		// Token: 0x17000337 RID: 823
		// (get) Token: 0x0600135C RID: 4956 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public int Count
		{
			get
			{
				throw ADP.OleDb();
			}
		}

		/// <summary>Копирует элементы <see cref="T:System.Data.OleDb.OleDbErrorCollection" /> в массив <see cref="T:System.Array" />, начиная с заданного индекса в массиве <see cref="T:System.Array" />.</summary>
		/// <param name="array">Массив <see cref="T:System.Array" />, в который копируются элементы.</param>
		/// <param name="index">Начальный индекс массива <paramref name="array" />.</param>
		/// <exception cref="T:System.ArgumentException">Сумма индекса <paramref name="index" /> и числа элементов в коллекции <see cref="T:System.Data.OleDb.OleDbErrorCollection" /> больше длины массива <see cref="T:System.Array" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Индекс <paramref name="index" /> является недопустимым для массива <paramref name="array" />.</exception>
		// Token: 0x0600135D RID: 4957 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public void CopyTo(Array array, int index)
		{
			throw ADP.OleDb();
		}

		/// <summary>Копирует все элементы текущей коллекции <see cref="T:System.Data.OleDb.OleDbErrorCollection" /> в указанную коллекцию <see cref="T:System.Data.OleDb.OleDbErrorCollection" />, начиная с указанного индекса в коллекции назначения.</summary>
		/// <param name="array">Коллекция <see cref="T:System.Data.OleDb.OleDbErrorCollection" /> — назначение для элементов, копируемых из текущей коллекции <see cref="T:System.Data.OleDb.OleDbErrorCollection" />.</param>
		/// <param name="index">32-разрядное целое число, представляющее индекс в коллекции <see cref="T:System.Data.OleDb.OleDbErrorCollection" />, с которого начинается копирование.</param>
		// Token: 0x0600135E RID: 4958 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public void CopyTo(OleDbError[] array, int index)
		{
			throw ADP.OleDb();
		}

		/// <summary>Предоставляет метод <see cref="M:System.Collections.IEnumerable.GetEnumerator" />, который поддерживает простую итерацию по коллекции с помощью поставщика данных .NET Framework.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IEnumerator" />, который может использоваться для итерации элементов коллекции.</returns>
		// Token: 0x0600135F RID: 4959 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public IEnumerator GetEnumerator()
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает ошибку с указанным индексом.</summary>
		/// <param name="index">Начинающийся с нуля индекс извлекаемой ошибки.</param>
		/// <returns>Объект <see cref="T:System.Data.OleDb.OleDbError" />, содержащий ошибку с указанным индексом.</returns>
		// Token: 0x17000338 RID: 824
		public OleDbError this[int index]
		{
			get
			{
				throw ADP.OleDb();
			}
		}

		/// <summary>Описание этого члена см. в разделе <see cref="P:System.Collections.ICollection.IsSynchronized" />.</summary>
		/// <returns>Значение <see langword="true" />, если доступ к коллекции является синхронизированным (потокобезопасным); в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06001361 RID: 4961 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		bool ICollection.IsSynchronized
		{
			get
			{
				throw ADP.OleDb();
			}
		}

		/// <summary>Описание этого члена см. в разделе <see cref="P:System.Collections.ICollection.SyncRoot" />.</summary>
		/// <returns>Объект <see cref="T:System.Object" />, который может использоваться для синхронизации доступа к коллекции.</returns>
		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06001362 RID: 4962 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		object ICollection.SyncRoot
		{
			get
			{
				throw ADP.OleDb();
			}
		}
	}
}
