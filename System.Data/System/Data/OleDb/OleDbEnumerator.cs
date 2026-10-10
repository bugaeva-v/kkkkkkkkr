using System;
using System.Data.Common;

namespace System.Data.OleDb
{
	/// <summary>Предоставляет механизм для перечисления всех доступных поставщиков OLE DB в локальной сети.</summary>
	// Token: 0x02000163 RID: 355
	[MonoTODO("OleDb is not implemented.")]
	public sealed class OleDbEnumerator
	{
		/// <summary>Извлекает таблицу <see cref="T:System.Data.DataTable" />, в которой содержатся сведения о всех видимых поставщиках OLE DB.</summary>
		/// <returns>Таблица <see cref="T:System.Data.DataTable" />, в которой содержатся сведения о видимых поставщиках OLE DB.</returns>
		/// <exception cref="T:System.InvalidCastException">Поставщик не поддерживает ISourcesRowset.</exception>
		/// <exception cref="T:System.Data.OleDb.OleDbException">Исключение возникло у основного поставщика.</exception>
		// Token: 0x06001351 RID: 4945 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public DataTable GetElements()
		{
			throw ADP.OleDb();
		}

		/// <summary>Использует конкретный перечислитель OLE DB для возврата объекта <see cref="T:System.Data.OleDb.OleDbDataReader" />, содержащего сведения об установленных в текущий момент поставщиках OLE DB, без требования экземпляра класса <see cref="T:System.Data.OleDb.OleDbEnumerator" />.</summary>
		/// <param name="type">Объект <see cref="T:System.Type" />.</param>
		/// <returns>Объект <see cref="T:System.Data.OleDb.OleDbDataReader" />, содержащий сведения о запрошенных поставщиках OLE DB с помощью заданного перечислителя OLE DB.</returns>
		/// <exception cref="T:System.InvalidCastException">Поставщик не поддерживает ISourcesRowset.</exception>
		/// <exception cref="T:System.Data.OleDb.OleDbException">Исключение возникло у основного поставщика.</exception>
		// Token: 0x06001352 RID: 4946 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public static OleDbDataReader GetEnumerator(Type type)
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает объект <see cref="T:System.Data.OleDb.OleDbDataReader" />, содержащий сведения об установленных в текущий момент поставщиках OLE DB, без требования экземпляра класса <see cref="T:System.Data.OleDb.OleDbEnumerator" />.</summary>
		/// <returns>Объект <see cref="T:System.Data.OleDb.OleDbDataReader" />, в котором содержатся сведения о видимых поставщиках OLE DB.</returns>
		/// <exception cref="T:System.InvalidCastException">Поставщик не поддерживает ISourcesRowset.</exception>
		/// <exception cref="T:System.Data.OleDb.OleDbException">Исключение возникло у основного поставщика.</exception>
		// Token: 0x06001353 RID: 4947 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public static OleDbDataReader GetRootEnumerator()
		{
			throw ADP.OleDb();
		}
	}
}
