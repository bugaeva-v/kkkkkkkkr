using System;
using System.Data.Common;

namespace System.Data.SqlClient
{
	/// <summary>Определяет соответствие между столбцом в источнике данных экземпляра <see cref="T:System.Data.SqlClient.SqlBulkCopy" /> и столбцом в таблице назначения данного экземпляра.</summary>
	// Token: 0x020001A9 RID: 425
	public sealed class SqlBulkCopyColumnMapping
	{
		/// <summary>Имя сопоставляемого столбца в целевой таблице базы данных.</summary>
		/// <returns>Строковое значение свойства <see cref="P:System.Data.SqlClient.SqlBulkCopyColumnMapping.DestinationColumn" />.</returns>
		// Token: 0x17000393 RID: 915
		// (get) Token: 0x060014F6 RID: 5366 RVA: 0x0006036E File Offset: 0x0005E56E
		// (set) Token: 0x060014F7 RID: 5367 RVA: 0x00060384 File Offset: 0x0005E584
		public string DestinationColumn
		{
			get
			{
				if (this._destinationColumnName != null)
				{
					return this._destinationColumnName;
				}
				return string.Empty;
			}
			set
			{
				this._destinationColumnOrdinal = (this._internalDestinationColumnOrdinal = -1);
				this._destinationColumnName = value;
			}
		}

		/// <summary>Порядковый номер целевого столбца в таблице назначения.</summary>
		/// <returns>Целочисленное значение свойства <see cref="P:System.Data.SqlClient.SqlBulkCopyColumnMapping.DestinationOrdinal" /> или -1, если его значение не задано.</returns>
		// Token: 0x17000394 RID: 916
		// (get) Token: 0x060014F8 RID: 5368 RVA: 0x000603A8 File Offset: 0x0005E5A8
		// (set) Token: 0x060014F9 RID: 5369 RVA: 0x000603B0 File Offset: 0x0005E5B0
		public int DestinationOrdinal
		{
			get
			{
				return this._destinationColumnOrdinal;
			}
			set
			{
				if (value >= 0)
				{
					this._destinationColumnName = null;
					this._internalDestinationColumnOrdinal = value;
					this._destinationColumnOrdinal = value;
					return;
				}
				throw ADP.IndexOutOfRange(value);
			}
		}

		/// <summary>Имя сопоставляемого столбца в источнике данных.</summary>
		/// <returns>Строковое значение свойства <see cref="P:System.Data.SqlClient.SqlBulkCopyColumnMapping.SourceColumn" />.</returns>
		// Token: 0x17000395 RID: 917
		// (get) Token: 0x060014FA RID: 5370 RVA: 0x000603DF File Offset: 0x0005E5DF
		// (set) Token: 0x060014FB RID: 5371 RVA: 0x000603F8 File Offset: 0x0005E5F8
		public string SourceColumn
		{
			get
			{
				if (this._sourceColumnName != null)
				{
					return this._sourceColumnName;
				}
				return string.Empty;
			}
			set
			{
				this._sourceColumnOrdinal = (this._internalSourceColumnOrdinal = -1);
				this._sourceColumnName = value;
			}
		}

		/// <summary>Порядковый номер исходного столбца в источнике данных.</summary>
		/// <returns>Целочисленное значение свойства <see cref="P:System.Data.SqlClient.SqlBulkCopyColumnMapping.SourceOrdinal" />.</returns>
		// Token: 0x17000396 RID: 918
		// (get) Token: 0x060014FC RID: 5372 RVA: 0x0006041C File Offset: 0x0005E61C
		// (set) Token: 0x060014FD RID: 5373 RVA: 0x00060424 File Offset: 0x0005E624
		public int SourceOrdinal
		{
			get
			{
				return this._sourceColumnOrdinal;
			}
			set
			{
				if (value >= 0)
				{
					this._sourceColumnName = null;
					this._internalSourceColumnOrdinal = value;
					this._sourceColumnOrdinal = value;
					return;
				}
				throw ADP.IndexOutOfRange(value);
			}
		}

		/// <summary>Используемый по умолчанию конструктор, инициализирующий объект <see cref="T:System.Data.SqlClient.SqlBulkCopyColumnMapping" />.</summary>
		// Token: 0x060014FE RID: 5374 RVA: 0x00060453 File Offset: 0x0005E653
		public SqlBulkCopyColumnMapping()
		{
			this._internalSourceColumnOrdinal = -1;
		}

		/// <summary>Создает новое сопоставление столбцов, используя имена столбцов источника и назначения.</summary>
		/// <param name="sourceColumn">Имя исходного столбца в источнике данных.</param>
		/// <param name="destinationColumn">Имя целевого столбца в таблице назначения.</param>
		// Token: 0x060014FF RID: 5375 RVA: 0x00060462 File Offset: 0x0005E662
		public SqlBulkCopyColumnMapping(string sourceColumn, string destinationColumn)
		{
			this.SourceColumn = sourceColumn;
			this.DestinationColumn = destinationColumn;
		}

		/// <summary>Создает новое сопоставление столбцов, используя порядковый номер исходного столбца и имя столбца назначения.</summary>
		/// <param name="sourceColumnOrdinal">Порядковый номер исходного столбца в источнике данных.</param>
		/// <param name="destinationColumn">Имя целевого столбца в таблице назначения.</param>
		// Token: 0x06001500 RID: 5376 RVA: 0x00060478 File Offset: 0x0005E678
		public SqlBulkCopyColumnMapping(int sourceColumnOrdinal, string destinationColumn)
		{
			this.SourceOrdinal = sourceColumnOrdinal;
			this.DestinationColumn = destinationColumn;
		}

		/// <summary>Создает новое сопоставление столбцов, используя имя исходного столбца и порядковый номер столбца назначения.</summary>
		/// <param name="sourceColumn">Имя исходного столбца в источнике данных.</param>
		/// <param name="destinationOrdinal">Порядковый номер целевого столбца в таблице назначения.</param>
		// Token: 0x06001501 RID: 5377 RVA: 0x0006048E File Offset: 0x0005E68E
		public SqlBulkCopyColumnMapping(string sourceColumn, int destinationOrdinal)
		{
			this.SourceColumn = sourceColumn;
			this.DestinationOrdinal = destinationOrdinal;
		}

		/// <summary>Создает новое сопоставление столбцов, используя порядковые номера для ссылки на столбцы источника и назначения.</summary>
		/// <param name="sourceColumnOrdinal">Порядковый номер исходного столбца в источнике данных.</param>
		/// <param name="destinationOrdinal">Порядковый номер целевого столбца в таблице назначения.</param>
		// Token: 0x06001502 RID: 5378 RVA: 0x000604A4 File Offset: 0x0005E6A4
		public SqlBulkCopyColumnMapping(int sourceColumnOrdinal, int destinationOrdinal)
		{
			this.SourceOrdinal = sourceColumnOrdinal;
			this.DestinationOrdinal = destinationOrdinal;
		}

		// Token: 0x04000D57 RID: 3415
		internal string _destinationColumnName;

		// Token: 0x04000D58 RID: 3416
		internal int _destinationColumnOrdinal;

		// Token: 0x04000D59 RID: 3417
		internal string _sourceColumnName;

		// Token: 0x04000D5A RID: 3418
		internal int _sourceColumnOrdinal;

		// Token: 0x04000D5B RID: 3419
		internal int _internalDestinationColumnOrdinal;

		// Token: 0x04000D5C RID: 3420
		internal int _internalSourceColumnOrdinal;
	}
}
