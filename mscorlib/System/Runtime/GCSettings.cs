using System;
using System.Runtime.ConstrainedExecution;

namespace System.Runtime
{
	/// <summary>Указывает параметры сборки мусора для текущего процесса.</summary>
	// Token: 0x02000552 RID: 1362
	public static class GCSettings
	{
		/// <summary>Возвращает значение, указывающее, включена ли сборка мусора на сервере.</summary>
		/// <returns>Значение <see langword="true" />, если сборка мусора сервера включена, в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x060035B3 RID: 13747 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		[MonoTODO("Always returns false")]
		public static bool IsServerGC
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает или задает текущий режим задержки для сборки мусора.</summary>
		/// <returns>Одно из значений из перечисления, задающее режим задержки.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Для свойства <see cref="P:System.Runtime.GCSettings.LatencyMode" /> задается недопустимое значение.  
		///
		/// или - 
		/// Свойству <see cref="P:System.Runtime.GCSettings.LatencyMode" /> невозможно присвоить значение <see cref="F:System.Runtime.GCLatencyMode.NoGCRegion" />.</exception>
		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x060035B4 RID: 13748 RVA: 0x000040F7 File Offset: 0x000022F7
		// (set) Token: 0x060035B5 RID: 13749 RVA: 0x00004BF9 File Offset: 0x00002DF9
		[MonoTODO("Always returns GCLatencyMode.Interactive and ignores set")]
		public static GCLatencyMode LatencyMode
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get
			{
				return GCLatencyMode.Interactive;
			}
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			set
			{
			}
		}

		/// <summary>Возвращает или задает значение, которое указывает, будет ли куча больших объектов (LOH) сжата во время полной блокирующей сборки мусора.</summary>
		/// <returns>Одно из значений перечисления, указывающее, сжимается ли LOH при полной блокирующей сборке мусора.</returns>
		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x060035B6 RID: 13750 RVA: 0x000C1FF9 File Offset: 0x000C01F9
		// (set) Token: 0x060035B7 RID: 13751 RVA: 0x000C2000 File Offset: 0x000C0200
		public static GCLargeObjectHeapCompactionMode LargeObjectHeapCompactionMode { [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)] get; [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)] set; }
	}
}
