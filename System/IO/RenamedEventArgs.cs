using System;

namespace System.IO
{
	/// <summary>Предоставляет данные для события <see cref="E:System.IO.FileSystemWatcher.Renamed" />.</summary>
	// Token: 0x020004F8 RID: 1272
	public class RenamedEventArgs : FileSystemEventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.RenamedEventArgs" />.</summary>
		/// <param name="changeType">Одно из значений <see cref="T:System.IO.WatcherChangeTypes" />.</param>
		/// <param name="directory">Имя файла или каталога, в которых произошло изменение.</param>
		/// <param name="name">Имя файла или каталога, в которых произошло изменение.</param>
		/// <param name="oldName">Старое имя измененного файла или каталога.</param>
		// Token: 0x060029A3 RID: 10659 RVA: 0x0008F1C0 File Offset: 0x0008D3C0
		public RenamedEventArgs(WatcherChangeTypes changeType, string directory, string name, string oldName) : base(changeType, directory, name)
		{
			this._oldName = oldName;
			this._oldFullPath = FileSystemEventArgs.Combine(directory, oldName);
		}

		/// <summary>Получает исходный полный путь измененного файла или каталога.</summary>
		/// <returns>Исходный полный путь измененного файла или каталога.</returns>
		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x060029A4 RID: 10660 RVA: 0x0008F1E1 File Offset: 0x0008D3E1
		public string OldFullPath
		{
			get
			{
				return this._oldFullPath;
			}
		}

		/// <summary>Получает старое имя измененного файла или каталога.</summary>
		/// <returns>Предыдущее имя измененного файла или каталога.</returns>
		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x060029A5 RID: 10661 RVA: 0x0008F1E9 File Offset: 0x0008D3E9
		public string OldName
		{
			get
			{
				return this._oldName;
			}
		}

		// Token: 0x040015F8 RID: 5624
		private readonly string _oldName;

		// Token: 0x040015F9 RID: 5625
		private readonly string _oldFullPath;
	}
}
