using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace Microsoft.Win32.SafeHandles
{
	/// <summary>Предоставляет базовый класс для реализаций критического дескриптора Win32, в котором значение -1 обозначает недопустимый дескриптор.</summary>
	// Token: 0x020000BB RID: 187
	[SecurityCritical]
	[SecurityPermission(SecurityAction.InheritanceDemand, UnmanagedCode = true)]
	public abstract class CriticalHandleMinusOneIsInvalid : CriticalHandle
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:Microsoft.Win32.SafeHandles.CriticalHandleMinusOneIsInvalid" />.</summary>
		// Token: 0x0600049B RID: 1179 RVA: 0x000176C3 File Offset: 0x000158C3
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		protected CriticalHandleMinusOneIsInvalid() : base(new IntPtr(-1))
		{
		}

		/// <summary>Получает значение, указывающее, является ли дескриптор недействительным.</summary>
		/// <returns>Значение <see langword="true" />, если дескриптор недействителен, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x000176D1 File Offset: 0x000158D1
		public override bool IsInvalid
		{
			[SecurityCritical]
			get
			{
				return this.handle == new IntPtr(-1);
			}
		}
	}
}
