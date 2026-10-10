using System;

namespace System.Drawing.Imaging
{
	/// <summary>Определяет характер записей, размещенных в файле EMF (расширенный метафайл). Перечисление, используемое несколькими конструкторами в классе <see cref="T:System.Drawing.Imaging.Metafile" />.</summary>
	// Token: 0x02000100 RID: 256
	public enum EmfType
	{
		/// <summary>Указывает, что все записи в метафайле являются записями EMF, которые могут отображаться GDI или GDI+.</summary>
		// Token: 0x04000971 RID: 2417
		EmfOnly = 3,
		/// <summary>Указывает, что все записи в метафайле являются записями EMF+, которые могут отображаться в GDI+, но не в GDI.</summary>
		// Token: 0x04000972 RID: 2418
		EmfPlusOnly,
		/// <summary>Указывает, что все записи EMF+ в метафайле связаны с альтернативной записью EMF. Метафайлы с типом <see cref="F:System.Drawing.Imaging.EmfType.EmfPlusDual" /> могут отображаться в GDI или GDI+.</summary>
		// Token: 0x04000973 RID: 2419
		EmfPlusDual
	}
}
