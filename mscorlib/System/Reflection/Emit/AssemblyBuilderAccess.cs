using System;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>Определяет режимы доступа для динамической сборки.</summary>
	// Token: 0x02000914 RID: 2324
	[ComVisible(true)]
	[Flags]
	[Serializable]
	public enum AssemblyBuilderAccess
	{
		/// <summary>Динамическую сборку можно выполнять, но нельзя сохранять.</summary>
		// Token: 0x04003114 RID: 12564
		Run = 1,
		/// <summary>Динамическую сборку можно сохранять, но нельзя выполнять.</summary>
		// Token: 0x04003115 RID: 12565
		Save = 2,
		/// <summary>Динамическую сборку можно выполнять и сохранять.</summary>
		// Token: 0x04003116 RID: 12566
		RunAndSave = 3,
		/// <summary>Динамическая сборка загружается только в контекст отражения, и ее невозможно выполнить.</summary>
		// Token: 0x04003117 RID: 12567
		ReflectionOnly = 6,
		/// <summary>Динамическая сборка будет автоматически выгружена, и ее память освобождается, когда она больше недоступна.</summary>
		// Token: 0x04003118 RID: 12568
		RunAndCollect = 9
	}
}
