using System;
using System.Collections;

namespace System.Data
{
	/// <summary>Представляет коллекцию объектов <see cref="T:System.Data.DataRow" />, возвращаемых из запроса LINQ to DataSet. Данный API поддерживает инфраструктуру .NET Framework и не предназначен для использования непосредственно из кода.</summary>
	// Token: 0x0200000A RID: 10
	public abstract class EnumerableRowCollection : IEnumerable
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600002E RID: 46
		internal abstract Type ElementType { get; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600002F RID: 47
		internal abstract DataTable Table { get; }

		// Token: 0x06000030 RID: 48 RVA: 0x000021DF File Offset: 0x000003DF
		internal EnumerableRowCollection()
		{
		}

		/// <summary>Возвращает перечислитель для коллекции объектов <see cref="T:System.Data.DataRow" />. Данный API поддерживает инфраструктуру .NET Framework и не предназначен для использования непосредственно из кода.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IEnumerator" />, который может использоваться для просмотра коллекции объектов <see cref="T:System.Data.DataRow" />.</returns>
		// Token: 0x06000031 RID: 49 RVA: 0x00002A0B File Offset: 0x00000C0B
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
