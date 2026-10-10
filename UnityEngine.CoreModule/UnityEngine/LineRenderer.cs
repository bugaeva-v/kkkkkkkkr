using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000146 RID: 326
	[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
	[NativeHeader("Runtime/Graphics/LineRenderer.h")]
	public sealed class LineRenderer : Renderer
	{
		// Token: 0x06000ABF RID: 2751 RVA: 0x0000F567 File Offset: 0x0000D767
		[Obsolete("Use startWidth, endWidth or widthCurve instead.", false)]
		public void SetWidth(float start, float end)
		{
			this.startWidth = start;
			this.endWidth = end;
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x0000F57A File Offset: 0x0000D77A
		[Obsolete("Use startColor, endColor or colorGradient instead.", false)]
		public void SetColors(Color start, Color end)
		{
			this.startColor = start;
			this.endColor = end;
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x0000F58D File Offset: 0x0000D78D
		[Obsolete("Use positionCount instead.", false)]
		public void SetVertexCount(int count)
		{
			this.positionCount = count;
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x0000F598 File Offset: 0x0000D798
		// (set) Token: 0x06000AC3 RID: 2755 RVA: 0x0000F58D File Offset: 0x0000D78D
		[Obsolete("Use positionCount instead (UnityUpgradable) -> positionCount", false)]
		public int numPositions
		{
			get
			{
				return this.positionCount;
			}
			set
			{
				this.positionCount = value;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000AC4 RID: 2756
		// (set) Token: 0x06000AC5 RID: 2757
		public extern float startWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000AC6 RID: 2758
		// (set) Token: 0x06000AC7 RID: 2759
		public extern float endWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000AC8 RID: 2760
		// (set) Token: 0x06000AC9 RID: 2761
		public extern float widthMultiplier { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000ACA RID: 2762
		// (set) Token: 0x06000ACB RID: 2763
		public extern int numCornerVertices { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000ACC RID: 2764
		// (set) Token: 0x06000ACD RID: 2765
		public extern int numCapVertices { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000ACE RID: 2766
		// (set) Token: 0x06000ACF RID: 2767
		public extern bool useWorldSpace { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000AD0 RID: 2768
		// (set) Token: 0x06000AD1 RID: 2769
		public extern bool loop { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x0000F5B0 File Offset: 0x0000D7B0
		// (set) Token: 0x06000AD3 RID: 2771 RVA: 0x0000F5C6 File Offset: 0x0000D7C6
		public Color startColor
		{
			get
			{
				Color result;
				this.get_startColor_Injected(out result);
				return result;
			}
			set
			{
				this.set_startColor_Injected(ref value);
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000AD4 RID: 2772 RVA: 0x0000F5D0 File Offset: 0x0000D7D0
		// (set) Token: 0x06000AD5 RID: 2773 RVA: 0x0000F5E6 File Offset: 0x0000D7E6
		public Color endColor
		{
			get
			{
				Color result;
				this.get_endColor_Injected(out result);
				return result;
			}
			set
			{
				this.set_endColor_Injected(ref value);
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000AD6 RID: 2774
		// (set) Token: 0x06000AD7 RID: 2775
		[NativeProperty("PositionsCount")]
		public extern int positionCount { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000AD8 RID: 2776 RVA: 0x0000F5F0 File Offset: 0x0000D7F0
		public void SetPosition(int index, Vector3 position)
		{
			this.SetPosition_Injected(index, ref position);
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x0000F5FC File Offset: 0x0000D7FC
		public Vector3 GetPosition(int index)
		{
			Vector3 result;
			this.GetPosition_Injected(index, out result);
			return result;
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000ADA RID: 2778
		// (set) Token: 0x06000ADB RID: 2779
		public extern float shadowBias { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000ADC RID: 2780
		// (set) Token: 0x06000ADD RID: 2781
		public extern bool generateLightingData { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000ADE RID: 2782
		// (set) Token: 0x06000ADF RID: 2783
		public extern LineTextureMode textureMode { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000AE0 RID: 2784
		// (set) Token: 0x06000AE1 RID: 2785
		public extern LineAlignment alignment { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000AE2 RID: 2786
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Simplify(float tolerance);

		// Token: 0x06000AE3 RID: 2787 RVA: 0x0000F613 File Offset: 0x0000D813
		public void BakeMesh(Mesh mesh, bool useTransform = false)
		{
			this.BakeMesh(mesh, Camera.main, useTransform);
		}

		// Token: 0x06000AE4 RID: 2788
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void BakeMesh([NotNull("ArgumentNullException")] Mesh mesh, [NotNull("ArgumentNullException")] Camera camera, bool useTransform = false);

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x0000F624 File Offset: 0x0000D824
		// (set) Token: 0x06000AE6 RID: 2790 RVA: 0x0000F63C File Offset: 0x0000D83C
		public AnimationCurve widthCurve
		{
			get
			{
				return this.GetWidthCurveCopy();
			}
			set
			{
				this.SetWidthCurve(value);
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x0000F648 File Offset: 0x0000D848
		// (set) Token: 0x06000AE8 RID: 2792 RVA: 0x0000F660 File Offset: 0x0000D860
		public Gradient colorGradient
		{
			get
			{
				return this.GetColorGradientCopy();
			}
			set
			{
				this.SetColorGradient(value);
			}
		}

		// Token: 0x06000AE9 RID: 2793
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern AnimationCurve GetWidthCurveCopy();

		// Token: 0x06000AEA RID: 2794
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetWidthCurve([NotNull("ArgumentNullException")] AnimationCurve curve);

		// Token: 0x06000AEB RID: 2795
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Gradient GetColorGradientCopy();

		// Token: 0x06000AEC RID: 2796
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetColorGradient([NotNull("ArgumentNullException")] Gradient curve);

		// Token: 0x06000AED RID: 2797
		[FreeFunction(Name = "LineRendererScripting::GetPositions", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int GetPositions([NotNull("ArgumentNullException")] [Out] Vector3[] positions);

		// Token: 0x06000AEE RID: 2798
		[FreeFunction(Name = "LineRendererScripting::SetPositions", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetPositions([NotNull("ArgumentNullException")] Vector3[] positions);

		// Token: 0x06000AEF RID: 2799 RVA: 0x0000F66B File Offset: 0x0000D86B
		public void SetPositions(NativeArray<Vector3> positions)
		{
			this.SetPositionsWithNativeContainer((IntPtr)positions.GetUnsafeReadOnlyPtr<Vector3>(), positions.Length);
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x0000F689 File Offset: 0x0000D889
		public void SetPositions(NativeSlice<Vector3> positions)
		{
			this.SetPositionsWithNativeContainer((IntPtr)positions.GetUnsafeReadOnlyPtr<Vector3>(), positions.Length);
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x0000F6A8 File Offset: 0x0000D8A8
		public int GetPositions([Out] NativeArray<Vector3> positions)
		{
			return this.GetPositionsWithNativeContainer((IntPtr)positions.GetUnsafePtr<Vector3>(), positions.Length);
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x0000F6D4 File Offset: 0x0000D8D4
		public int GetPositions([Out] NativeSlice<Vector3> positions)
		{
			return this.GetPositionsWithNativeContainer((IntPtr)positions.GetUnsafePtr<Vector3>(), positions.Length);
		}

		// Token: 0x06000AF3 RID: 2803
		[FreeFunction(Name = "LineRendererScripting::SetPositionsWithNativeContainer", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetPositionsWithNativeContainer(IntPtr positions, int count);

		// Token: 0x06000AF4 RID: 2804
		[FreeFunction(Name = "LineRendererScripting::GetPositionsWithNativeContainer", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern int GetPositionsWithNativeContainer(IntPtr positions, int length);

		// Token: 0x06000AF6 RID: 2806
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void get_startColor_Injected(out Color ret);

		// Token: 0x06000AF7 RID: 2807
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void set_startColor_Injected(ref Color value);

		// Token: 0x06000AF8 RID: 2808
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void get_endColor_Injected(out Color ret);

		// Token: 0x06000AF9 RID: 2809
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void set_endColor_Injected(ref Color value);

		// Token: 0x06000AFA RID: 2810
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetPosition_Injected(int index, ref Vector3 position);

		// Token: 0x06000AFB RID: 2811
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetPosition_Injected(int index, out Vector3 ret);
	}
}
