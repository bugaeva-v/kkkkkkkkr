using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace Microsoft.Win32.SafeHandles
{
	/// <summary>Предоставляет базовый класс для реализаций критического дескриптора Win32, в котором значение 0 или -1 обозначает недопустимый дескриптор.</summary>
	// Token: 0x020000BA RID: 186
	[SecurityCritical]
	[SecurityPermission(SecurityAction.InheritanceDemand, UnmanagedCode = true)]
	public abstract class CriticalHandleZeroOrMinusOneIsInvalid : CriticalHandle
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:Microsoft.Win32.SafeHandles.CriticalHandleZeroOrMinusOneIsInvalid" />.</summary>
		// Token: 0x06000499 RID: 1177 RVA: 0x00017694 File Offset: 0x00015894
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		protected CriticalHandleZeroOrMinusOneIsInvalid() : base(IntPtr.Zero)
		{
		}

		/// <summary>Получает значение, указывающее, является ли дескриптор недействительным.</summary>
		/// <returns>Значение <see langword="true" />, если дескриптор недействителен, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x000176A1 File Offset: 0x000158A1
		public override bool IsInvalid
		{
			[SecurityCritical]
			get
			{
				return this.handle.IsNull() || this.handle == new IntPtr(-1);
			}
		}
	}
}
