using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Data.SqlClient
{
	/// <summary>Собирает все ошибки, созданные поставщиком данных .NET Framework для SQL Server. Этот класс не наследуется.</summary>
	// Token: 0x02000201 RID: 513
	[Serializable]
	public sealed class SqlErrorCollection : ICollection, IEnumerable
	{
		// Token: 0x060018E2 RID: 6370 RVA: 0x00073F5F File Offset: 0x0007215F
		internal SqlErrorCollection()
		{
		}

		/// <summary>Копирует элементы коллекции <see cref="T:System.Data.SqlClient.SqlErrorCollection" /> в массив <see cref="T:System.Array" /> начиная с заданного индекса.</summary>
		/// <param name="array">
		///   <see cref="T:System.Array" />, в который будут копироваться элементы.</param>
		/// <param name="index">Индекс, начиная с которого происходит копирование в параметр <paramref name="array" />.</param>
		/// <exception cref="T:System.ArgumentException">Сумма <paramref name="index" /> и количества элементов в коллекции <see cref="T:System.Data.SqlClient.SqlErrorCollection" /> превышает <see cref="P:System.Array.Length" /> массива <see cref="T:System.Array" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Индекс <paramref name="index" /> является недопустимым для массива <paramref name="array" />.</exception>
		// Token: 0x060018E3 RID: 6371 RVA: 0x00073F72 File Offset: 0x00072172
		public void CopyTo(Array array, int index)
		{
			((ICollection)this._errors).CopyTo(array, index);
		}

		/// <summary>Копирует элементы коллекции <see cref="T:System.Data.SqlClient.SqlErrorCollection" /> в коллекцию <see cref="T:System.Data.SqlClient.SqlErrorCollection" /> начиная с заданного индекса.</summary>
		/// <param name="array">
		///   <see cref="T:System.Data.SqlClient.SqlErrorCollection" />, куда будут копироваться элементы.</param>
		/// <param name="index">Индекс, начиная с которого происходит копирование в параметр <paramref name="array" />.</param>
		/// <exception cref="T:System.ArgumentException">Сумма индекса <paramref name="index" /> и числа элементов в коллекции <see cref="T:System.Data.SqlClient.SqlErrorCollection" /> больше длины коллекции <see cref="T:System.Data.SqlClient.SqlErrorCollection" /> .</exception>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Индекс <paramref name="index" /> является недопустимым для массива <paramref name="array" />.</exception>
		// Token: 0x060018E4 RID: 6372 RVA: 0x00073F84 File Offset: 0x00072184
		public void CopyTo(SqlError[] array, int index)
		{
			this._errors.CopyTo(array, index);
		}

		/// <summary>Получает число ошибок в коллекции.</summary>
		/// <returns>Общее число ошибок в коллекции.</returns>
		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x060018E5 RID: 6373 RVA: 0x00073FA0 File Offset: 0x000721A0
		public int Count
		{
			get
			{
				return this._errors.Count;
			}
		}

		/// <summary>Описание этого члена см. в разделе <see cref="P:System.Collections.ICollection.SyncRoot" />.</summary>
		/// <returns>Объект, который может использоваться для синхронизации доступа к <see cref="T:System.Collections.ICollection" />.</returns>
		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x060018E6 RID: 6374 RVA: 0x00005696 File Offset: 0x00003896
		object ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>Описание этого члена см. в разделе <see cref="P:System.Collections.ICollection.IsSynchronized" />.</summary>
		/// <returns>
		///   <see langword="true" />, если доступ к классу <see cref="T:System.Collections.ICollection" /> является синхронизированным (потокобезопасным); в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x060018E7 RID: 6375 RVA: 0x00006D64 File Offset: 0x00004F64
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает ошибку с указанным индексом.</summary>
		/// <param name="index">Начинающийся с нуля индекс извлекаемой ошибки.</param>
		/// <returns>
		///   <see cref="T:System.Data.SqlClient.SqlError" />, который содержит ошибку по указанному индексу.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Параметр индекса находится за границами массива.</exception>
		// Token: 0x1700047C RID: 1148
		public SqlError this[int index]
		{
			get
			{
				return (SqlError)this._errors[index];
			}
		}

		/// <summary>Возвращает перечислитель, осуществляющий перебор элементов списка <see cref="T:System.Data.SqlClient.SqlErrorCollection" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.IEnumerator" /> для <see cref="T:System.Data.SqlClient.SqlErrorCollection" />.</returns>
		// Token: 0x060018E9 RID: 6377 RVA: 0x00073FC0 File Offset: 0x000721C0
		public IEnumerator GetEnumerator()
		{
			return this._errors.GetEnumerator();
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x00073FD2 File Offset: 0x000721D2
		internal void Add(SqlError error)
		{
			this._errors.Add(error);
		}

		// Token: 0x04001036 RID: 4150
		private readonly List<object> _errors = new List<object>();
	}
}
