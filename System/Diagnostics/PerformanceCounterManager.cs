using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Diagnostics
{
	/// <summary>Подготавливает данные о производительности для библиотеки performance.dll, которая загружается системой при работе со счетчиками производительности.</summary>
	// Token: 0x02000275 RID: 629
	[Obsolete("use PerformanceCounter")]
	[MonoTODO("not implemented")]
	[Guid("82840be1-d273-11d2-b94a-00600893b17a")]
	[ComVisible(true)]
	[PermissionSet(SecurityAction.LinkDemand, Unrestricted = true)]
	public sealed class PerformanceCounterManager : ICollectData
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.PerformanceCounterManager" />.</summary>
		// Token: 0x06001414 RID: 5140 RVA: 0x0000219B File Offset: 0x0000039B
		[Obsolete("use PerformanceCounter")]
		public PerformanceCounterManager()
		{
		}

		/// <summary>Вызывается функцией закрытия данных о производительности библиотеки производительности DLL.</summary>
		// Token: 0x06001415 RID: 5141 RVA: 0x0000829A File Offset: 0x0000649A
		void ICollectData.CloseData()
		{
			throw new NotImplementedException();
		}

		/// <summary>Процедура сбора данных о производительности. Вызывается библиотекой производительности PerfCount.</summary>
		/// <param name="callIdx">Индекс вызова.</param>
		/// <param name="valueNamePtr">Указатель на список строк в формате Юникод с запрашиваемыми идентификаторами объектов.</param>
		/// <param name="dataPtr">Указатель на буфер данных.</param>
		/// <param name="totalBytes">Указатель на число байтов.</param>
		/// <param name="res">Возвращаемые этим методом данные содержат структуру <see cref="T:System.IntPtr" /> со значением -1.</param>
		// Token: 0x06001416 RID: 5142 RVA: 0x0000829A File Offset: 0x0000649A
		void ICollectData.CollectData(int callIdx, IntPtr valueNamePtr, IntPtr dataPtr, int totalBytes, out IntPtr res)
		{
			throw new NotImplementedException();
		}
	}
}
