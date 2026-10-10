using System;
using System.Dynamic.Utils;
using Unity;

namespace System.Linq.Expressions
{
	/// <summary>
	///         Хранит информацию, позволяющую пропустить отладку сведений о символах исходного файла, в частности имени файла и уникального идентификатора языка.
	///       </summary>
	// Token: 0x0200029E RID: 670
	public class SymbolDocumentInfo
	{
		// Token: 0x060013E6 RID: 5094 RVA: 0x0003D244 File Offset: 0x0003B444
		internal SymbolDocumentInfo(string fileName)
		{
			ContractUtils.RequiresNotNull(fileName, "fileName");
			this.FileName = fileName;
		}

		/// <summary>
		///         Имя исходного файла.
		///       </summary>
		/// <returns>
		///         Строка, представляющая имя исходного файла.
		///       </returns>
		// Token: 0x17000395 RID: 917
		// (get) Token: 0x060013E7 RID: 5095 RVA: 0x0003D25E File Offset: 0x0003B45E
		public string FileName { get; }

		/// <summary>
		///         Возвращает уникальный идентификатор языка, если таковые имеются.
		///       </summary>
		/// <returns>
		///         Уникальный идентификатор языка
		///       </returns>
		// Token: 0x17000396 RID: 918
		// (get) Token: 0x060013E8 RID: 5096 RVA: 0x0003D266 File Offset: 0x0003B466
		public virtual Guid Language
		{
			get
			{
				return Guid.Empty;
			}
		}

		/// <summary>
		///         Возвращает уникальный идентификатор поставщика языка, если таковые имеются.
		///       </summary>
		/// <returns>
		///         Уникальный идентификатор поставщика языка.
		///       </returns>
		// Token: 0x17000397 RID: 919
		// (get) Token: 0x060013E9 RID: 5097 RVA: 0x0003D266 File Offset: 0x0003B466
		public virtual Guid LanguageVendor
		{
			get
			{
				return Guid.Empty;
			}
		}

		/// <summary>
		///         Возвращает уникальный идентификатор типа документа, если таковые имеются.
		///          По умолчанию идентификатор GUID для текстового файла.
		///       </summary>
		/// <returns>
		///         Уникальный идентификатор типа документа.
		///       </returns>
		// Token: 0x17000398 RID: 920
		// (get) Token: 0x060013EA RID: 5098 RVA: 0x0003D26D File Offset: 0x0003B46D
		public virtual Guid DocumentType
		{
			get
			{
				return SymbolDocumentInfo.DocumentType_Text;
			}
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x0000235B File Offset: 0x0000055B
		internal SymbolDocumentInfo()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04000A5E RID: 2654
		internal static readonly Guid DocumentType_Text = new Guid(1518771467, 26129, 4563, 189, 42, 0, 0, 248, 8, 73, 189);
	}
}
