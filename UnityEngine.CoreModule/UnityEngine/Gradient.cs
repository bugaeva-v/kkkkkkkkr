using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001C4 RID: 452
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Export/Math/Gradient.bindings.h")]
	[StructLayout(LayoutKind.Sequential)]
	public class Gradient : IEquatable<Gradient>
	{
		// Token: 0x060013BF RID: 5055
		[FreeFunction(Name = "Gradient_Bindings::Init", IsThreadSafe = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr Init();

		// Token: 0x060013C0 RID: 5056
		[FreeFunction(Name = "Gradient_Bindings::Cleanup", IsThreadSafe = true, HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Cleanup();

		// Token: 0x060013C1 RID: 5057
		[FreeFunction("Gradient_Bindings::Internal_Equals", IsThreadSafe = true, HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool Internal_Equals(IntPtr other);

		// Token: 0x060013C2 RID: 5058 RVA: 0x0001C71F File Offset: 0x0001A91F
		[RequiredByNativeCode]
		public Gradient()
		{
			this.m_Ptr = Gradient.Init();
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x0001C734 File Offset: 0x0001A934
		~Gradient()
		{
			this.Cleanup();
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x0001C764 File Offset: 0x0001A964
		[FreeFunction(Name = "Gradient_Bindings::Evaluate", IsThreadSafe = true, HasExplicitThis = true)]
		public Color Evaluate(float time)
		{
			Color result;
			this.Evaluate_Injected(time, out result);
			return result;
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x060013C5 RID: 5061
		// (set) Token: 0x060013C6 RID: 5062
		public extern GradientColorKey[] colorKeys { [FreeFunction("Gradient_Bindings::GetColorKeys", IsThreadSafe = true, HasExplicitThis = true)] [MethodImpl(MethodImplOptions.InternalCall)] get; [FreeFunction("Gradient_Bindings::SetColorKeys", IsThreadSafe = true, HasExplicitThis = true)] [MethodImpl(MethodImplOptions.InternalCall)] [param: Unmarshalled] set; }

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x060013C7 RID: 5063
		// (set) Token: 0x060013C8 RID: 5064
		public extern GradientAlphaKey[] alphaKeys { [FreeFunction("Gradient_Bindings::GetAlphaKeys", IsThreadSafe = true, HasExplicitThis = true)] [MethodImpl(MethodImplOptions.InternalCall)] get; [FreeFunction("Gradient_Bindings::SetAlphaKeys", IsThreadSafe = true, HasExplicitThis = true)] [MethodImpl(MethodImplOptions.InternalCall)] [param: Unmarshalled] set; }

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x060013C9 RID: 5065
		// (set) Token: 0x060013CA RID: 5066
		[NativeProperty(IsThreadSafe = true)]
		public extern GradientMode mode { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060013CB RID: 5067
		[FreeFunction(Name = "Gradient_Bindings::SetKeys", IsThreadSafe = true, HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetKeys([Unmarshalled] GradientColorKey[] colorKeys, [Unmarshalled] GradientAlphaKey[] alphaKeys);

		// Token: 0x060013CC RID: 5068 RVA: 0x0001C77C File Offset: 0x0001A97C
		public override bool Equals(object o)
		{
			bool flag = o == null;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				bool flag2 = this == o;
				if (flag2)
				{
					result = true;
				}
				else
				{
					bool flag3 = o.GetType() != base.GetType();
					result = (!flag3 && this.Equals((Gradient)o));
				}
			}
			return result;
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x0001C7D0 File Offset: 0x0001A9D0
		public bool Equals(Gradient other)
		{
			bool flag = other == null;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				bool flag2 = this == other;
				if (flag2)
				{
					result = true;
				}
				else
				{
					bool flag3 = this.m_Ptr.Equals(other.m_Ptr);
					result = (flag3 || this.Internal_Equals(other.m_Ptr));
				}
			}
			return result;
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x0001C828 File Offset: 0x0001AA28
		public override int GetHashCode()
		{
			return this.m_Ptr.GetHashCode();
		}

		// Token: 0x060013CF RID: 5071
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Evaluate_Injected(float time, out Color ret);

		// Token: 0x0400074C RID: 1868
		internal IntPtr m_Ptr;
	}
}
