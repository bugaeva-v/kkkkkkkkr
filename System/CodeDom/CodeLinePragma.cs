using System;

namespace System.CodeDom
{
	/// <summary>Представляет конкретное место внутри конкретного файла.</summary>
	// Token: 0x02000315 RID: 789
	[Serializable]
	public class CodeLinePragma
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeLinePragma" />.</summary>
		// Token: 0x0600190F RID: 6415 RVA: 0x0000219B File Offset: 0x0000039B
		public CodeLinePragma()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeLinePragma" />.</summary>
		/// <param name="fileName">Имя связанного файла.</param>
		/// <param name="lineNumber">Номер строки для сохранения ссылки.</param>
		// Token: 0x06001910 RID: 6416 RVA: 0x0005FE10 File Offset: 0x0005E010
		public CodeLinePragma(string fileName, int lineNumber)
		{
			this.FileName = fileName;
			this.LineNumber = lineNumber;
		}

		/// <summary>Получает или задает имя связанного файла.</summary>
		/// <returns>Имя связанного файла.</returns>
		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06001911 RID: 6417 RVA: 0x0005FE26 File Offset: 0x0005E026
		// (set) Token: 0x06001912 RID: 6418 RVA: 0x0005FE37 File Offset: 0x0005E037
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

		/// <summary>Получает или задает номер строки связанной ссылки.</summary>
		/// <returns>Номер строки.</returns>
		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06001913 RID: 6419 RVA: 0x0005FE40 File Offset: 0x0005E040
		// (set) Token: 0x06001914 RID: 6420 RVA: 0x0005FE48 File Offset: 0x0005E048
		public int LineNumber { get; set; }

		// Token: 0x04000D96 RID: 3478
		private string _fileName;
	}
}
