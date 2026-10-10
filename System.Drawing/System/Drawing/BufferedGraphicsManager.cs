using System;

namespace System.Drawing
{
	/// <summary>Предоставляет доступ к объекту основного контекста буферизованной графики для домена приложения.</summary>
	// Token: 0x02000051 RID: 81
	public sealed class BufferedGraphicsManager
	{
		// Token: 0x060003B2 RID: 946 RVA: 0x00002050 File Offset: 0x00000250
		private BufferedGraphicsManager()
		{
		}

		/// <summary>Возвращает контекст <see cref="T:System.Drawing.BufferedGraphicsContext" /> для текущего домена приложения.</summary>
		/// <returns>Контекст <see cref="T:System.Drawing.BufferedGraphicsContext" /> для текущего домена приложения.</returns>
		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x00009BF9 File Offset: 0x00007DF9
		public static BufferedGraphicsContext Current
		{
			get
			{
				return BufferedGraphicsManager.graphics_context;
			}
		}

		// Token: 0x04000433 RID: 1075
		private static BufferedGraphicsContext graphics_context = new BufferedGraphicsContext();
	}
}
