using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000E4 RID: 228
	[NativeHeader("Runtime/Math/AnimationCurve.bindings.h")]
	[RequiredByNativeCode]
	[StructLayout(LayoutKind.Sequential)]
	public class AnimationCurve : IEquatable<AnimationCurve>
	{
		// Token: 0x0600039F RID: 927
		[FreeFunction("AnimationCurveBindings::Internal_Destroy", IsThreadSafe = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Destroy(IntPtr ptr);

		// Token: 0x060003A0 RID: 928
		[FreeFunction("AnimationCurveBindings::Internal_Create", IsThreadSafe = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr Internal_Create(Keyframe[] keys);

		// Token: 0x060003A1 RID: 929
		[FreeFunction("AnimationCurveBindings::Internal_Equals", HasExplicitThis = true, IsThreadSafe = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool Internal_Equals(IntPtr other);

		// Token: 0x060003A2 RID: 930 RVA: 0x0000615C File Offset: 0x0000435C
		~AnimationCurve()
		{
			AnimationCurve.Internal_Destroy(this.m_Ptr);
		}

		// Token: 0x060003A3 RID: 931
		[ThreadSafe]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern float Evaluate(float time);

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x00006194 File Offset: 0x00004394
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x000061AC File Offset: 0x000043AC
		public Keyframe[] keys
		{
			get
			{
				return this.GetKeys();
			}
			set
			{
				this.SetKeys(value);
			}
		}

		// Token: 0x060003A6 RID: 934
		[FreeFunction("AnimationCurveBindings::AddKeySmoothTangents", HasExplicitThis = true, IsThreadSafe = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int AddKey(float time, float value);

		// Token: 0x060003A7 RID: 935 RVA: 0x000061B8 File Offset: 0x000043B8
		public int AddKey(Keyframe key)
		{
			return this.AddKey_Internal(key);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x000061D1 File Offset: 0x000043D1
		[NativeMethod("AddKey", IsThreadSafe = true)]
		private int AddKey_Internal(Keyframe key)
		{
			return this.AddKey_Internal_Injected(ref key);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x000061DB File Offset: 0x000043DB
		[NativeThrows]
		[FreeFunction("AnimationCurveBindings::MoveKey", HasExplicitThis = true, IsThreadSafe = true)]
		public int MoveKey(int index, Keyframe key)
		{
			return this.MoveKey_Injected(index, ref key);
		}

		// Token: 0x060003AA RID: 938
		[FreeFunction("AnimationCurveBindings::RemoveKey", HasExplicitThis = true, IsThreadSafe = true)]
		[NativeThrows]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RemoveKey(int index);

		// Token: 0x170000A2 RID: 162
		public Keyframe this[int index]
		{
			get
			{
				return this.GetKey(index);
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060003AC RID: 940
		public extern int length { [NativeMethod("GetKeyCount", IsThreadSafe = true)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060003AD RID: 941
		[FreeFunction("AnimationCurveBindings::SetKeys", HasExplicitThis = true, IsThreadSafe = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetKeys(Keyframe[] keys);

		// Token: 0x060003AE RID: 942 RVA: 0x00006204 File Offset: 0x00004404
		[NativeThrows]
		[FreeFunction("AnimationCurveBindings::GetKey", HasExplicitThis = true, IsThreadSafe = true)]
		private Keyframe GetKey(int index)
		{
			Keyframe result;
			this.GetKey_Injected(index, out result);
			return result;
		}

		// Token: 0x060003AF RID: 943
		[FreeFunction("AnimationCurveBindings::GetKeys", HasExplicitThis = true, IsThreadSafe = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Keyframe[] GetKeys();

		// Token: 0x060003B0 RID: 944
		[FreeFunction("AnimationCurveBindings::SmoothTangents", HasExplicitThis = true, IsThreadSafe = true)]
		[NativeThrows]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SmoothTangents(int index, float weight);

		// Token: 0x060003B1 RID: 945 RVA: 0x0000621C File Offset: 0x0000441C
		public static AnimationCurve Constant(float timeStart, float timeEnd, float value)
		{
			return AnimationCurve.Linear(timeStart, value, timeEnd, value);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00006238 File Offset: 0x00004438
		public static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd)
		{
			bool flag = timeStart == timeEnd;
			AnimationCurve result;
			if (flag)
			{
				Keyframe keyframe = new Keyframe(timeStart, valueStart);
				result = new AnimationCurve(new Keyframe[]
				{
					keyframe
				});
			}
			else
			{
				float num = (valueEnd - valueStart) / (timeEnd - timeStart);
				Keyframe[] keys = new Keyframe[]
				{
					new Keyframe(timeStart, valueStart, 0f, num),
					new Keyframe(timeEnd, valueEnd, num, 0f)
				};
				result = new AnimationCurve(keys);
			}
			return result;
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x000062B4 File Offset: 0x000044B4
		public static AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd)
		{
			bool flag = timeStart == timeEnd;
			AnimationCurve result;
			if (flag)
			{
				Keyframe keyframe = new Keyframe(timeStart, valueStart);
				result = new AnimationCurve(new Keyframe[]
				{
					keyframe
				});
			}
			else
			{
				Keyframe[] keys = new Keyframe[]
				{
					new Keyframe(timeStart, valueStart, 0f, 0f),
					new Keyframe(timeEnd, valueEnd, 0f, 0f)
				};
				result = new AnimationCurve(keys);
			}
			return result;
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060003B4 RID: 948
		// (set) Token: 0x060003B5 RID: 949
		public extern WrapMode preWrapMode { [NativeMethod("GetPreInfinity", IsThreadSafe = true)] [MethodImpl(MethodImplOptions.InternalCall)] get; [NativeMethod("SetPreInfinity", IsThreadSafe = true)] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060003B6 RID: 950
		// (set) Token: 0x060003B7 RID: 951
		public extern WrapMode postWrapMode { [NativeMethod("GetPostInfinity", IsThreadSafe = true)] [MethodImpl(MethodImplOptions.InternalCall)] get; [NativeMethod("SetPostInfinity", IsThreadSafe = true)] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060003B8 RID: 952 RVA: 0x0000632B File Offset: 0x0000452B
		public AnimationCurve(params Keyframe[] keys)
		{
			this.m_Ptr = AnimationCurve.Internal_Create(keys);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00006341 File Offset: 0x00004541
		[RequiredByNativeCode]
		public AnimationCurve()
		{
			this.m_Ptr = AnimationCurve.Internal_Create(null);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00006358 File Offset: 0x00004558
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
					result = (!flag3 && this.Equals((AnimationCurve)o));
				}
			}
			return result;
		}

		// Token: 0x060003BB RID: 955 RVA: 0x000063AC File Offset: 0x000045AC
		public bool Equals(AnimationCurve other)
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

		// Token: 0x060003BC RID: 956 RVA: 0x00006404 File Offset: 0x00004604
		public override int GetHashCode()
		{
			return this.m_Ptr.GetHashCode();
		}

		// Token: 0x060003BD RID: 957
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern int AddKey_Internal_Injected(ref Keyframe key);

		// Token: 0x060003BE RID: 958
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern int MoveKey_Injected(int index, ref Keyframe key);

		// Token: 0x060003BF RID: 959
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetKey_Injected(int index, out Keyframe ret);

		// Token: 0x040002F7 RID: 759
		internal IntPtr m_Ptr;
	}
}
