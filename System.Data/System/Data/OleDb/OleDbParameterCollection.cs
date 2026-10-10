using System;
using System.Collections;
using System.ComponentModel;
using System.Data.Common;

namespace System.Data.OleDb
{
	/// <summary>Представляет коллекцию параметров, относящихся к <see cref="T:System.Data.OleDb.OleDbCommand" />, а также соответствующие им сопоставления со столбцами в <see cref="T:System.Data.DataSet" />.</summary>
	// Token: 0x0200016E RID: 366
	[MonoTODO("OleDb is not implemented.")]
	public class OleDbParameterCollection : DbParameterCollection
	{
		// Token: 0x0600139E RID: 5022 RVA: 0x0005AE10 File Offset: 0x00059010
		internal OleDbParameterCollection()
		{
		}

		/// <summary>Добавляет заданный объект <see cref="T:System.Data.OleDb.OleDbParameter" /> в <see cref="T:System.Data.OleDb.OleDbParameterCollection" />.</summary>
		/// <param name="value">Параметр <see cref="T:System.Data.OleDb.OleDbParameter" /> для добавления в коллекцию.</param>
		/// <returns>Индекс нового объекта <see cref="T:System.Data.OleDb.OleDbParameter" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <see cref="T:System.Data.OleDb.OleDbParameter" />, заданный в параметре <paramref name="value" />, уже добавлен в эту или другую коллекцию <see cref="T:System.Data.OleDb.OleDbParameterCollection" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="value" /> имеет значение null.</exception>
		// Token: 0x0600139F RID: 5023 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public OleDbParameter Add(OleDbParameter value)
		{
			throw ADP.OleDb();
		}

		/// <summary>Добавляет указанный объект <see cref="T:System.Data.OleDb.OleDbParameter" /> в коллекцию <see cref="T:System.Data.OleDb.OleDbParameterCollection" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />.</param>
		/// <returns>Индекс нового объекта <see cref="T:System.Data.OleDb.OleDbParameter" /> в коллекции.</returns>
		// Token: 0x060013A0 RID: 5024 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Add(object value)
		{
			throw ADP.OleDb();
		}

		/// <summary>Добавляет <see cref="T:System.Data.OleDb.OleDbParameter" /> с заданным именем параметра и типом данных в коллекцию <see cref="T:System.Data.OleDb.OleDbParameterCollection" />.</summary>
		/// <param name="parameterName">Имя параметра.</param>
		/// <param name="oleDbType">Одно из значений <see cref="T:System.Data.OleDb.OleDbType" />.</param>
		/// <returns>Индекс нового объекта <see cref="T:System.Data.OleDb.OleDbParameter" />.</returns>
		// Token: 0x060013A1 RID: 5025 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public OleDbParameter Add(string parameterName, OleDbType oleDbType)
		{
			throw ADP.OleDb();
		}

		/// <summary>Добавляет <see cref="T:System.Data.OleDb.OleDbParameter" /> с заданным именем, типом данных и длиной столбца в <see cref="T:System.Data.OleDb.OleDbParameterCollection" />.</summary>
		/// <param name="parameterName">Имя параметра.</param>
		/// <param name="oleDbType">Одно из значений <see cref="T:System.Data.OleDb.OleDbType" />.</param>
		/// <param name="size">Длина столбца.</param>
		/// <returns>Индекс нового объекта <see cref="T:System.Data.OleDb.OleDbParameter" />.</returns>
		// Token: 0x060013A2 RID: 5026 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public OleDbParameter Add(string parameterName, OleDbType oleDbType, int size)
		{
			throw ADP.OleDb();
		}

		/// <summary>Добавляет объект <see cref="T:System.Data.OleDb.OleDbParameter" /> с заданным именем параметра, типом данных, длиной столбца и именем столбца источника в <see cref="T:System.Data.OleDb.OleDbParameterCollection" />.</summary>
		/// <param name="parameterName">Имя параметра.</param>
		/// <param name="oleDbType">Одно из значений <see cref="T:System.Data.OleDb.OleDbType" />.</param>
		/// <param name="size">Длина столбца.</param>
		/// <param name="sourceColumn">Имя исходного столбца.</param>
		/// <returns>Индекс нового объекта <see cref="T:System.Data.OleDb.OleDbParameter" />.</returns>
		// Token: 0x060013A3 RID: 5027 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public OleDbParameter Add(string parameterName, OleDbType oleDbType, int size, string sourceColumn)
		{
			throw ADP.OleDb();
		}

		/// <summary>Добавляет объект <see cref="T:System.Data.OleDb.OleDbParameter" /> с заданным именем параметра и значением в <see cref="T:System.Data.OleDb.OleDbParameterCollection" />.</summary>
		/// <param name="parameterName">Имя параметра.</param>
		/// <param name="value">
		///   <see cref="P:System.Data.OleDb.OleDbParameter.Value" /> из <see cref="T:System.Data.OleDb.OleDbParameter" /> для добавления в коллекцию.</param>
		/// <returns>Индекс нового объекта <see cref="T:System.Data.OleDb.OleDbParameter" />.</returns>
		/// <exception cref="T:System.InvalidCastException">Параметр <paramref name="value" /> не является <see cref="T:System.Data.OleDb.OleDbParameter" />.</exception>
		// Token: 0x060013A4 RID: 5028 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public OleDbParameter Add(string parameterName, object value)
		{
			throw ADP.OleDb();
		}

		/// <summary>Добавляет массив значений в конец коллекции <see cref="T:System.Data.OleDb.OleDbParameterCollection" />.</summary>
		/// <param name="values">Добавляемые значения <see cref="T:System.Array" />.</param>
		// Token: 0x060013A5 RID: 5029 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override void AddRange(Array values)
		{
			throw ADP.OleDb();
		}

		/// <summary>Добавляет массив значений <see cref="T:System.Data.OleDb.OleDbParameter" /> в конец коллекции <see cref="T:System.Data.OleDb.OleDbParameterCollection" />.</summary>
		/// <param name="values">Добавляемые значения <see cref="T:System.Data.OleDb.OleDbParameter" />.</param>
		// Token: 0x060013A6 RID: 5030 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public void AddRange(OleDbParameter[] values)
		{
			throw ADP.OleDb();
		}

		/// <summary>Добавляет значение в конец коллекции <see cref="T:System.Data.OleDb.OleDbParameterCollection" />.</summary>
		/// <param name="parameterName">Имя параметра.</param>
		/// <param name="value">Добавляемое значение.</param>
		/// <returns>Объект <see cref="T:System.Data.OleDb.OleDbParameter" />.</returns>
		// Token: 0x060013A7 RID: 5031 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public OleDbParameter AddWithValue(string parameterName, object value)
		{
			throw ADP.OleDb();
		}

		/// <summary>Удаляет все объекты <see cref="T:System.Data.OleDb.OleDbParameter" /> из коллекции <see cref="T:System.Data.OleDb.OleDbParameterCollection" />.</summary>
		// Token: 0x060013A8 RID: 5032 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override void Clear()
		{
			throw ADP.OleDb();
		}

		/// <summary>Определяет, находится ли заданный объект <see cref="T:System.Data.OleDb.OleDbParameter" /> в этой коллекции <see cref="T:System.Data.OleDb.OleDbParameterCollection" />.</summary>
		/// <param name="value">Значение <see cref="T:System.Data.OleDb.OleDbParameter" />.</param>
		/// <returns>Значение <see langword="true" />, если элемент <see cref="T:System.Data.OleDb.OleDbParameter" /> присутствует в коллекции, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060013A9 RID: 5033 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public bool Contains(OleDbParameter value)
		{
			throw ADP.OleDb();
		}

		/// <summary>Определяет, находится ли заданный объект <see cref="T:System.Object" /> в этой коллекции <see cref="T:System.Data.OleDb.OleDbParameterCollection" />.</summary>
		/// <param name="value">Значение <see cref="T:System.Object" />.</param>
		/// <returns>Значение <see langword="true" />, если коллекция <see cref="T:System.Data.OleDb.OleDbParameterCollection" /> содержит параметр <paramref name="value" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060013AA RID: 5034 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override bool Contains(object value)
		{
			throw ADP.OleDb();
		}

		/// <summary>Определяет, находится ли заданный объект <see cref="T:System.String" /> в этой коллекции <see cref="T:System.Data.OleDb.OleDbParameterCollection" />.</summary>
		/// <param name="value">Значение <see cref="T:System.String" />.</param>
		/// <returns>
		///   <see langword="true" />, если коллекция <see cref="T:System.Data.OleDb.OleDbParameterCollection" /> содержит значение; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060013AB RID: 5035 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override bool Contains(string value)
		{
			throw ADP.OleDb();
		}

		/// <summary>Копирует все элементы текущей коллекции <see cref="T:System.Data.OleDb.OleDbParameterCollection" /> в указанный одномерный массив <see cref="T:System.Array" />, начиная с указанного индекса в массиве <see cref="T:System.Array" />.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" /> — назначение для элементов, копируемых из текущей коллекции <see cref="T:System.Data.OleDb.OleDbParameterCollection" />.</param>
		/// <param name="index">32-разрядное целое число, представляющее индекс в коллекции <see cref="T:System.Array" />, с которого начинается копирование.</param>
		// Token: 0x060013AC RID: 5036 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override void CopyTo(Array array, int index)
		{
			throw ADP.OleDb();
		}

		/// <summary>Копирует все элементы текущей коллекции <see cref="T:System.Data.OleDb.OleDbParameterCollection" /> в указанную коллекцию <see cref="T:System.Data.OleDb.OleDbParameterCollection" />, начиная с указанного индекса в коллекции назначения.</summary>
		/// <param name="array">Коллекция <see cref="T:System.Data.OleDb.OleDbParameterCollection" /> — назначение для элементов, копируемых из текущей коллекции <see cref="T:System.Data.OleDb.OleDbParameterCollection" />.</param>
		/// <param name="index">32-разрядное целое число, представляющее индекс в коллекции <see cref="T:System.Data.OleDb.OleDbParameterCollection" />, с которого начинается копирование.</param>
		// Token: 0x060013AD RID: 5037 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public void CopyTo(OleDbParameter[] array, int index)
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает перечислитель, осуществляющий перебор элементов списка <see cref="T:System.Data.OleDb.OleDbParameterCollection" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.IEnumerator" /> для <see cref="T:System.Data.OleDb.OleDbParameterCollection" />.</returns>
		// Token: 0x060013AE RID: 5038 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override IEnumerator GetEnumerator()
		{
			throw ADP.OleDb();
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		protected override DbParameter GetParameter(int index)
		{
			throw ADP.OleDb();
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		protected override DbParameter GetParameter(string parameterName)
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает положение указанного объекта <see cref="T:System.Data.OleDb.OleDbParameter" /> в коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.Data.OleDb.OleDbParameter" /> в коллекции, который требуется найти.</param>
		/// <returns>Отсчитываемое от нуля расположение указанного объекта <see cref="T:System.Data.OleDb.OleDbParameter" />, который является объектом <see cref="T:System.Data.OleDb.OleDbParameter" /> в коллекции.</returns>
		// Token: 0x060013B1 RID: 5041 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public int IndexOf(OleDbParameter value)
		{
			throw ADP.OleDb();
		}

		/// <summary>Местоположение указанного объекта <see cref="T:System.Object" /> в коллекции.</summary>
		/// <param name="value">Искомый объект <see cref="T:System.Object" />.</param>
		/// <returns>Отсчитываемое от нуля расположение указанного объекта <see cref="T:System.Object" />, который является объектом <see cref="T:System.Data.OleDb.OleDbParameterCollection" /> в коллекции.</returns>
		// Token: 0x060013B2 RID: 5042 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override int IndexOf(object value)
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает положение заданного объекта <see cref="T:System.Data.OleDb.OleDbParameter" /> с указанным именем.</summary>
		/// <param name="parameterName">Имя искомого объекта <see cref="T:System.Data.OleDb.OleDbParameter" /> с учетом регистра.</param>
		/// <returns>Положение (отсчет с нуля) указанного объекта <see cref="T:System.Data.OleDb.OleDbParameter" /> с заданным именем с учетом регистра.</returns>
		// Token: 0x060013B3 RID: 5043 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override int IndexOf(string parameterName)
		{
			throw ADP.OleDb();
		}

		/// <summary>Вставляет объект <see cref="T:System.Data.OleDb.OleDbParameter" /> в коллекцию <see cref="T:System.Data.OleDb.OleDbParameterCollection" /> по указанному индексу.</summary>
		/// <param name="index">Индекс (отсчет с нуля), по которому необходимо вставить значение.</param>
		/// <param name="value">Объект <see cref="T:System.Data.OleDb.OleDbParameter" />, который необходимо вставить в коллекцию <see cref="T:System.Data.OleDb.OleDbParameterCollection" />.</param>
		// Token: 0x060013B4 RID: 5044 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public void Insert(int index, OleDbParameter value)
		{
			throw ADP.OleDb();
		}

		/// <summary>Вставляет <see cref="T:System.Object" /> в <see cref="T:System.Data.OleDb.OleDbParameterCollection" /> по указанному индексу.</summary>
		/// <param name="index">Индекс (отсчет с нуля), по которому необходимо вставить значение.</param>
		/// <param name="value">Объект <see cref="T:System.Object" />, который необходимо вставить в <see cref="T:System.Data.OleDb.OleDbParameterCollection" />.</param>
		// Token: 0x060013B5 RID: 5045 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override void Insert(int index, object value)
		{
			throw ADP.OleDb();
		}

		/// <summary>Удаляет объект <see cref="T:System.Data.OleDb.OleDbParameter" /> из коллекции <see cref="T:System.Data.OleDb.OleDbParameterCollection" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Data.OleDb.OleDbParameter" />, удаляемый из коллекции.</param>
		/// <exception cref="T:System.InvalidCastException">Параметр не является объектом <see cref="T:System.Data.OleDb.OleDbParameter" />.</exception>
		/// <exception cref="T:System.SystemException">Параметр отсутствует в коллекции.</exception>
		// Token: 0x060013B6 RID: 5046 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public void Remove(OleDbParameter value)
		{
			throw ADP.OleDb();
		}

		/// <summary>Удаляет объект <see cref="T:System.Object" /> из коллекции <see cref="T:System.Data.OleDb.OleDbParameterCollection" />.</summary>
		/// <param name="value">Объект<see cref="T:System.Object" />, удаляемый из коллекции <see cref="T:System.Data.OleDb.OleDbParameterCollection" />.</param>
		// Token: 0x060013B7 RID: 5047 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override void Remove(object value)
		{
			throw ADP.OleDb();
		}

		/// <summary>Удаляет объект <see cref="T:System.Data.OleDb.OleDbParameter" /> с указанным индексом из коллекции <see cref="T:System.Data.OleDb.OleDbParameterCollection" />.</summary>
		/// <param name="index">Индекс (отсчет с нуля) удаляемого объекта <see cref="T:System.Data.OleDb.OleDbParameter" />.</param>
		// Token: 0x060013B8 RID: 5048 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override void RemoveAt(int index)
		{
			throw ADP.OleDb();
		}

		/// <summary>Удаляет объект <see cref="T:System.Data.OleDb.OleDbParameter" /> с указанным именем из коллекции <see cref="T:System.Data.OleDb.OleDbParameterCollection" />.</summary>
		/// <param name="parameterName">Имя удаляемого объекта <see cref="T:System.Data.OleDb.OleDbParameter" />.</param>
		// Token: 0x060013B9 RID: 5049 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override void RemoveAt(string parameterName)
		{
			throw ADP.OleDb();
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		protected override void SetParameter(int index, DbParameter value)
		{
			throw ADP.OleDb();
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		protected override void SetParameter(string parameterName, DbParameter value)
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает целое число, которое содержит количество элементов в <see cref="T:System.Data.OleDb.OleDbParameterCollection" />. Только для чтения.</summary>
		/// <returns>Количество элементов в <see cref="T:System.Data.OleDb.OleDbParameterCollection" />, представленное в виде целого числа.</returns>
		// Token: 0x1700034E RID: 846
		// (get) Token: 0x060013BC RID: 5052 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override int Count
		{
			get
			{
				throw ADP.OleDb();
			}
		}

		/// <summary>Возвращает значение, показывающее, имеет ли объект <see cref="T:System.Data.OleDb.OleDbParameterCollection" /> фиксированный размер. Только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если список <see cref="T:System.Data.OleDb.OleDbParameterCollection" /> имеет фиксированный размер. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700034F RID: 847
		// (get) Token: 0x060013BD RID: 5053 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override bool IsFixedSize
		{
			get
			{
				throw ADP.OleDb();
			}
		}

		/// <summary>Возвращает значение, которое определяет, является ли коллекция <see cref="T:System.Data.OleDb.OleDbParameterCollection" /> доступной только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если коллекция <see cref="T:System.Data.OleDb.OleDbParameterCollection" /> доступна только для чтения, в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000350 RID: 848
		// (get) Token: 0x060013BE RID: 5054 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override bool IsReadOnly
		{
			get
			{
				throw ADP.OleDb();
			}
		}

		/// <summary>Возвращает значение, которое определяет, является ли коллекция <see cref="T:System.Data.OleDb.OleDbParameterCollection" /> синхронизированной. Только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если коллекция <see cref="T:System.Data.OleDb.OleDbParameterCollection" /> синхронизирована; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000351 RID: 849
		// (get) Token: 0x060013BF RID: 5055 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override bool IsSynchronized
		{
			get
			{
				throw ADP.OleDb();
			}
		}

		/// <summary>Возвращает или задает объект <see cref="T:System.Data.OleDb.OleDbParameter" /> с заданным индексом.</summary>
		/// <param name="index">Индекс получаемого параметра (отсчет с нуля).</param>
		/// <returns>Параметр <see cref="T:System.Data.OleDb.OleDbParameter" /> по указанному индексу.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Указанный индекс не существует.</exception>
		// Token: 0x17000352 RID: 850
		public OleDbParameter this[int index]
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Возвращает или задает объект <see cref="T:System.Data.OleDb.OleDbParameter" /> с заданным именем.</summary>
		/// <param name="parameterName">Имя получаемого параметра.</param>
		/// <returns>Параметр <see cref="T:System.Data.OleDb.OleDbParameter" /> с указанным именем.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Указанного имени не существует.</exception>
		// Token: 0x17000353 RID: 851
		public OleDbParameter this[string parameterName]
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Получает объект, с помощью которого можно синхронизировать доступ к коллекции <see cref="T:System.Data.OleDb.OleDbParameterCollection" />. Только для чтения.</summary>
		/// <returns>Объект, который может использоваться для синхронизации доступа к <see cref="T:System.Data.OleDb.OleDbParameterCollection" />.</returns>
		// Token: 0x17000354 RID: 852
		// (get) Token: 0x060013C4 RID: 5060 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override object SyncRoot
		{
			get
			{
				throw ADP.OleDb();
			}
		}
	}
}
