using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x0200010B RID: 267
	[NativeHeader("Runtime/Utilities/DiagnosticSwitch.h")]
	[NativeAsStruct]
	[NativeClass("DiagnosticSwitch", "struct DiagnosticSwitch;")]
	[StructLayout(LayoutKind.Sequential)]
	internal class DiagnosticSwitch
	{
		// Token: 0x0600066A RID: 1642 RVA: 0x00008CE3 File Offset: 0x00006EE3
		private DiagnosticSwitch()
		{
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600066B RID: 1643
		public extern string name { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600066C RID: 1644
		public extern string description { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600066D RID: 1645
		[NativeName("OwningModuleName")]
		public extern string owningModule { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600066E RID: 1646
		public extern DiagnosticSwitch.Flags flags { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x00008CED File Offset: 0x00006EED
		// (set) Token: 0x06000670 RID: 1648 RVA: 0x00008CF5 File Offset: 0x00006EF5
		public object value
		{
			get
			{
				return this.GetScriptingValue();
			}
			set
			{
				this.SetScriptingValue(value, false);
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000671 RID: 1649
		[NativeName("ScriptingDefaultValue")]
		public extern object defaultValue { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000672 RID: 1650
		[NativeName("ScriptingMinValue")]
		public extern object minValue { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000673 RID: 1651
		[NativeName("ScriptingMaxValue")]
		public extern object maxValue { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x00008D00 File Offset: 0x00006F00
		// (set) Token: 0x06000675 RID: 1653 RVA: 0x00008D08 File Offset: 0x00006F08
		public object persistentValue
		{
			get
			{
				return this.GetScriptingPersistentValue();
			}
			set
			{
				this.SetScriptingValue(value, true);
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000676 RID: 1654
		[NativeName("ScriptingEnumInfo")]
		public extern EnumInfo enumInfo { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000677 RID: 1655
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern object GetScriptingValue();

		// Token: 0x06000678 RID: 1656
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern object GetScriptingPersistentValue();

		// Token: 0x06000679 RID: 1657
		[NativeThrows]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetScriptingValue(object value, bool setPersistent);

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x00008D13 File Offset: 0x00006F13
		public bool isSetToDefault
		{
			get
			{
				return object.Equals(this.persistentValue, this.defaultValue);
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600067B RID: 1659 RVA: 0x00008D26 File Offset: 0x00006F26
		public bool needsRestart
		{
			get
			{
				return !object.Equals(this.value, this.persistentValue);
			}
		}

		// Token: 0x04000381 RID: 897
		private IntPtr m_Ptr;

		// Token: 0x0200010C RID: 268
		[Flags]
		internal enum Flags
		{
			// Token: 0x04000383 RID: 899
			None = 0,
			// Token: 0x04000384 RID: 900
			CanChangeAfterEngineStart = 1
		}
	}
}
