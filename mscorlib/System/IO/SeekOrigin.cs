using System;

namespace System.IO
{
	/// <summary>Задает позицию в потоке, используемую для поиска.</summary>
	// Token: 0x02000B10 RID: 2832
	public enum SeekOrigin
	{
		/// <summary>Задает начало потока.</summary>
		// Token: 0x04003B6A RID: 15210
		Begin,
		/// <summary>Задает текущее положение в потоке.</summary>
		// Token: 0x04003B6B RID: 15211
		Current,
		/// <summary>Задает конец потока.</summary>
		// Token: 0x04003B6C RID: 15212
		End
	}
}
