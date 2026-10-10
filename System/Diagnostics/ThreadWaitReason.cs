using System;

namespace System.Diagnostics
{
	/// <summary>Указывает причину, по которой поток находится в состоянии ожидания.</summary>
	// Token: 0x02000283 RID: 643
	public enum ThreadWaitReason
	{
		/// <summary>Поток ожидает старшую составляющую пары события.</summary>
		// Token: 0x04000B79 RID: 2937
		EventPairHigh = 7,
		/// <summary>Поток ожидает младшую составляющую пары события.</summary>
		// Token: 0x04000B7A RID: 2938
		EventPairLow,
		/// <summary>Выполнение потока отложено.</summary>
		// Token: 0x04000B7B RID: 2939
		ExecutionDelay = 4,
		/// <summary>Поток ожидает планировщик.</summary>
		// Token: 0x04000B7C RID: 2940
		Executive = 0,
		/// <summary>Поток ожидает свободную страницу виртуальной памяти.</summary>
		// Token: 0x04000B7D RID: 2941
		FreePage,
		/// <summary>Поток ожидает поступления вызова локальной процедуры.</summary>
		// Token: 0x04000B7E RID: 2942
		LpcReceive = 9,
		/// <summary>Поток ожидает поступления ответа на вызов локальной процедуры.</summary>
		// Token: 0x04000B7F RID: 2943
		LpcReply,
		/// <summary>Поток ожидает поступления страницы виртуальной памяти в память.</summary>
		// Token: 0x04000B80 RID: 2944
		PageIn = 2,
		/// <summary>Поток ожидает записи страницы виртуальной памяти на диск.</summary>
		// Token: 0x04000B81 RID: 2945
		PageOut = 12,
		/// <summary>Выполнение потока приостановлено.</summary>
		// Token: 0x04000B82 RID: 2946
		Suspended = 5,
		/// <summary>Поток ожидает системных ресурсов.</summary>
		// Token: 0x04000B83 RID: 2947
		SystemAllocation = 3,
		/// <summary>Причина ожидания потока неизвестна.</summary>
		// Token: 0x04000B84 RID: 2948
		Unknown = 13,
		/// <summary>Поток ожидает запроса пользователя.</summary>
		// Token: 0x04000B85 RID: 2949
		UserRequest = 6,
		/// <summary>Поток ожидает выделения системой виртуальной памяти.</summary>
		// Token: 0x04000B86 RID: 2950
		VirtualMemory = 11
	}
}
