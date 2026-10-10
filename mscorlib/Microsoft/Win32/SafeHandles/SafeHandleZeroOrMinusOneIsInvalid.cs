using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace Microsoft.Win32.SafeHandles
{
	/// <summary>Предоставляет базовый класс для реализаций безопасного дескриптора Win32, в котором значение 0 или -1 обозначает недопустимый дескриптор.</summary>
	// Token: 0x020000B8 RID: 184
	[SecurityCritical]
	[SecurityPermission(SecurityAction.InheritanceDemand, UnmanagedCode = true)]
	public abstract class SafeHandleZeroOrMinusOneIsInvalid : SafeHandle
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid" />, указывающий, нужно ли освобождать дескриптор наверняка.</summary>
		/// <param name="ownsHandle">Значение <see langword="true" />, чтобы надежно освободить маркер на стадии завершения; значение <see langword="false" />, чтобы предотвратить надежное освобождение (не рекомендуется).</param>
		// Token: 0x06000495 RID: 1173 RVA: 0x00017642 File Offset: 0x00015842
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		protected SafeHandleZeroOrMinusOneIsInvalid(bool ownsHandle) : base(IntPtr.Zero, ownsHandle)
		{
		}

		/// <summary>Получает значение, указывающее, является ли дескриптор недействительным.</summary>
		/// <returns>Значение <see langword="true" />, если дескриптор недействителен, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x00017650 File Offset: 0x00015850
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
