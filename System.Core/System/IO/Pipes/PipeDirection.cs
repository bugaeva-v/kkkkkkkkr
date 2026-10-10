using System;

namespace System.IO.Pipes
{
	/// <summary>
	///         Задает направление канала.
	///       </summary>
	// Token: 0x0200034C RID: 844
	public enum PipeDirection
	{
		/// <summary>
		///         Указывает, что канал.
		///       </summary>
		// Token: 0x04000C48 RID: 3144
		In = 1,
		/// <summary>
		///         Указывает, что канал.
		///       </summary>
		// Token: 0x04000C49 RID: 3145
		Out,
		/// <summary>
		///         Указывает, что канал является двусторонней.
		///       </summary>
		// Token: 0x04000C4A RID: 3146
		InOut
	}
}
