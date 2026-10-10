using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Задает направление потока данных в параметре <paramref name="dwDirection" /> метода <see cref="M:System.Runtime.InteropServices.ComTypes.IDataObject.EnumFormatEtc(System.Runtime.InteropServices.ComTypes.DATADIR)" />. Определяет, какие форматы сможет перечислить итоговый перечислитель.</summary>
	// Token: 0x02000188 RID: 392
	public enum DATADIR
	{
		/// <summary>Требует, чтобы <see cref="M:System.Runtime.InteropServices.ComTypes.IDataObject.EnumFormatEtc(System.Runtime.InteropServices.ComTypes.DATADIR)" /> предоставлял перечислитель для форматов, которые могут быть заданы в <see cref="M:System.Runtime.InteropServices.ComTypes.IDataObject.GetData(System.Runtime.InteropServices.ComTypes.FORMATETC@,System.Runtime.InteropServices.ComTypes.STGMEDIUM@)" />.</summary>
		// Token: 0x040006F9 RID: 1785
		DATADIR_GET = 1,
		/// <summary>Требует, чтобы <see cref="M:System.Runtime.InteropServices.ComTypes.IDataObject.EnumFormatEtc(System.Runtime.InteropServices.ComTypes.DATADIR)" /> предоставлял перечислитель для форматов, которые могут быть заданы в <see cref="M:System.Runtime.InteropServices.ComTypes.IDataObject.SetData(System.Runtime.InteropServices.ComTypes.FORMATETC@,System.Runtime.InteropServices.ComTypes.STGMEDIUM@,System.Boolean)" />.</summary>
		// Token: 0x040006FA RID: 1786
		DATADIR_SET
	}
}
