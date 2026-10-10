using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace System.Data
{
	/// <summary>Этот тип используется как базовый класс для создания объектов с типом <see cref="T:System.Data.DataTable" /> Visual Studio и инструмента .NET Framework XSD.exe; тип не предназначен для непосредственного использования из кода.</summary>
	/// <typeparam name="T">Тип объектов в исходной последовательности, представленной в таблице, обычно <see cref="T:System.Data.DataRow" />.</typeparam>
	// Token: 0x02000011 RID: 17
	[Serializable]
	public abstract class TypedTableBase<T> : DataTable, IEnumerable<T>, IEnumerable where T : DataRow
	{
		/// <summary>Инициализирует новый объект <see cref="T:System.Data.TypedTableBase`1" />. Этот метод поддерживает создание типизированного объекта <see cref="T:System.Data.DataTable" /> с помощью Visual Studio и средства .NET Framework XSD.exe. Этот тип не предназначен для непосредственного использования в коде.</summary>
		// Token: 0x06000058 RID: 88 RVA: 0x000031A2 File Offset: 0x000013A2
		protected TypedTableBase()
		{
		}

		/// <summary>Инициализирует новый объект <see cref="T:System.Data.TypedTableBase`1" />. Этот метод поддерживает создание типизированного объекта <see cref="T:System.Data.DataTable" /> с помощью Visual Studio и средства .NET Framework XSD.exe. Этот метод не предназначен для непосредственного использования в коде.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, содержащий данные для создания объекта.</param>
		/// <param name="context">Потоковый контекст для десериализуемого объекта.</param>
		// Token: 0x06000059 RID: 89 RVA: 0x000031AA File Offset: 0x000013AA
		protected TypedTableBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Возвращает перечислитель для типизированной строки <see cref="T:System.Data.DataRow" />. Этот метод поддерживает создание типизированного объекта <see cref="T:System.Data.DataTable" /> с помощью Visual Studio и средства .NET Framework XSD.exe. Этот метод не предназначен для непосредственного использования в коде.</summary>
		/// <returns>Объект, реализующий интерфейс <see cref="T:System.Collections.Generic.IEnumerator`1" />.</returns>
		// Token: 0x0600005A RID: 90 RVA: 0x000031B4 File Offset: 0x000013B4
		public IEnumerator<T> GetEnumerator()
		{
			return base.Rows.Cast<T>().GetEnumerator();
		}

		/// <summary>Возвращает перечислитель для типизированной строки <see cref="T:System.Data.DataRow" />. Этот метод поддерживает создание типизированного объекта <see cref="T:System.Data.DataTable" /> с помощью Visual Studio и средства .NET Framework XSD.exe. Этот метод не предназначен для непосредственного использования в коде.</summary>
		/// <returns>Объект, реализующий интерфейс <see cref="T:System.Collections.Generic.IEnumerator`1" />.</returns>
		// Token: 0x0600005B RID: 91 RVA: 0x000031C6 File Offset: 0x000013C6
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		/// <summary>Преобразует элементы <see cref="T:System.Data.TypedTableBase`1" /> в указанный тип. Этот метод поддерживает создание типизированного объекта <see cref="T:System.Data.DataTable" /> с помощью Visual Studio и средства .NET Framework XSD.exe. Этот метод не предназначен для непосредственного использования в коде.</summary>
		/// <typeparam name="TResult" />
		/// <returns>
		///   <see cref="T:System.Data.EnumerableRowCollection" /> — содержит все элементы исходной последовательности, преобразованные в указанный тип.</returns>
		// Token: 0x0600005C RID: 92 RVA: 0x000031CE File Offset: 0x000013CE
		public EnumerableRowCollection<TResult> Cast<TResult>()
		{
			return new EnumerableRowCollection<T>(this).Cast<TResult>();
		}
	}
}
