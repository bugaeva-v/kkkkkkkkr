using System;

namespace System.Drawing.Imaging
{
	/// <summary>Данный делегат не используется. Пример перечисления записей метафайла см. в <see cref="M:System.Drawing.Graphics.EnumerateMetafile(System.Drawing.Imaging.Metafile,System.Drawing.Point,System.Drawing.Graphics.EnumerateMetafileProc)" />.</summary>
	/// <param name="recordType">Не используется.</param>
	/// <param name="flags">Не используется.</param>
	/// <param name="dataSize">Не используется.</param>
	/// <param name="recordData">Не используется.</param>
	// Token: 0x02000113 RID: 275
	// (Invoke) Token: 0x06000CCB RID: 3275
	public delegate void PlayRecordCallback(EmfPlusRecordType recordType, int flags, int dataSize, IntPtr recordData);
}
