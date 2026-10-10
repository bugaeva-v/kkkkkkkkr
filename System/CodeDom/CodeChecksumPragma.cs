using System;

namespace System.CodeDom
{
	/// <summary>Представляет сущность кода pragma для контрольной суммы кода.</summary>
	// Token: 0x020002FE RID: 766
	[Serializable]
	public class CodeChecksumPragma : CodeDirective
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeChecksumPragma" />.</summary>
		// Token: 0x0600187F RID: 6271 RVA: 0x0005F624 File Offset: 0x0005D824
		public CodeChecksumPragma()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeChecksumPragma" /> с использованием имени файла, GUID, представляющего алгоритм контрольной суммы и потока байтов, представляющего данные контрольной суммы.</summary>
		/// <param name="fileName">Путь к файлу контрольной суммы.</param>
		/// <param name="checksumAlgorithmId">Значение <see cref="T:System.Guid" />, идентифицирующее используемый алгоритм контрольной суммы.</param>
		/// <param name="checksumData">Массив байтов, содержащий данные контрольной суммы.</param>
		// Token: 0x06001880 RID: 6272 RVA: 0x0005F62C File Offset: 0x0005D82C
		public CodeChecksumPragma(string fileName, Guid checksumAlgorithmId, byte[] checksumData)
		{
			this._fileName = fileName;
			this.ChecksumAlgorithmId = checksumAlgorithmId;
			this.ChecksumData = checksumData;
		}

		/// <summary>Получает или задает путь к файлу контрольной суммы.</summary>
		/// <returns>Путь к файлу контрольной суммы.</returns>
		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06001881 RID: 6273 RVA: 0x0005F649 File Offset: 0x0005D849
		// (set) Token: 0x06001882 RID: 6274 RVA: 0x0005F65A File Offset: 0x0005D85A
		public string FileName
		{
			get
			{
				return this._fileName ?? string.Empty;
			}
			set
			{
				this._fileName = value;
			}
		}

		/// <summary>Получает или задает GUID, идентифицирующий используемый алгоритм контрольной суммы.</summary>
		/// <returns>Значение <see cref="T:System.Guid" />, идентифицирующее используемый алгоритм контрольной суммы.</returns>
		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06001883 RID: 6275 RVA: 0x0005F663 File Offset: 0x0005D863
		// (set) Token: 0x06001884 RID: 6276 RVA: 0x0005F66B File Offset: 0x0005D86B
		public Guid ChecksumAlgorithmId { get; set; }

		/// <summary>Получает или задает значение данных для расчета контрольной суммы.</summary>
		/// <returns>Массив байтов, содержащий данные для расчета контрольной суммы.</returns>
		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06001885 RID: 6277 RVA: 0x0005F674 File Offset: 0x0005D874
		// (set) Token: 0x06001886 RID: 6278 RVA: 0x0005F67C File Offset: 0x0005D87C
		public byte[] ChecksumData { get; set; }

		// Token: 0x04000D70 RID: 3440
		private string _fileName;
	}
}
