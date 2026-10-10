using System;
using System.Security.Permissions;
using Unity;

namespace System.Diagnostics.Eventing.Reader
{
	/// <summary>
	///         Позволяет получить доступ к свойствам времени выполнения активных журналов событий и журналов событий.
	///          Эти свойства включают количество событий в журнале, размер журнала, значение, определяющее ли журнал полон, и время последнего журнала были записаны или получить доступ к.
	///       </summary>
	// Token: 0x0200039E RID: 926
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public sealed class EventLogInformation
	{
		// Token: 0x06001BA8 RID: 7080 RVA: 0x0000235B File Offset: 0x0000055B
		internal EventLogInformation()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Получает атрибуты файла журнала, связанного с этим журналом.
		///       </summary>
		/// <returns>
		///         Возвращает целочисленное значение.
		///          Это значение может быть null.
		///       </returns>
		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06001BA9 RID: 7081 RVA: 0x0005A6E0 File Offset: 0x000588E0
		public int? Attributes
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Получает время создания файла журнала, связанных с журналом событий.
		///       </summary>
		/// <returns>
		///         Возвращает объект <see cref="T:System.DateTime" />.
		///          Это значение может быть null.
		///       </returns>
		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06001BAA RID: 7082 RVA: 0x0005A6FC File Offset: 0x000588FC
		public DateTime? CreationTime
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает размер файла в байтах, связанных с журналом событий.
		///       </summary>
		/// <returns>
		///         Возвращает значение типа long.
		///       </returns>
		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001BAB RID: 7083 RVA: 0x0005A718 File Offset: 0x00058918
		public long? FileSize
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает логическое значение, определяющее, ли файл журнала достигла максимального размера (журнал заполнен).
		///       </summary>
		/// <returns>
		///         Возвращает <see langword="true" /> если журнал заполнен и возвращает <see langword="false" /> Если журнал не заполнен.
		///       </returns>
		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06001BAC RID: 7084 RVA: 0x0005A734 File Offset: 0x00058934
		public bool? IsLogFull
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Получает данные времени последнего файла журнала, связанных с журналом событий получен.
		///       </summary>
		/// <returns>
		///         Возвращает объект <see cref="T:System.DateTime" />.
		///          Это значение может быть null.
		///       </returns>
		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06001BAD RID: 7085 RVA: 0x0005A750 File Offset: 0x00058950
		public DateTime? LastAccessTime
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Получает время последней записи данных в файл журнала, связанных с журналом событий.
		///       </summary>
		/// <returns>
		///         Возвращает объект <see cref="T:System.DateTime" />.
		///          Это значение может быть null.
		///       </returns>
		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06001BAE RID: 7086 RVA: 0x0005A76C File Offset: 0x0005896C
		public DateTime? LastWriteTime
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Получает число наиболее старых записей в журнале событий.
		///       </summary>
		/// <returns>
		///         Возвращает значение типа long, представляющее количество наиболее старых записей в журнале событий.
		///          Это значение может быть null.
		///       </returns>
		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06001BAF RID: 7087 RVA: 0x0005A788 File Offset: 0x00058988
		public long? OldestRecordNumber
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает количество записей событий в журнале событий.
		///       </summary>
		/// <returns>
		///         Возвращает значение типа long, представляющее количество записей событий в журнале событий.
		///          Это значение может быть null.
		///       </returns>
		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06001BB0 RID: 7088 RVA: 0x0005A7A4 File Offset: 0x000589A4
		public long? RecordCount
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}
	}
}
