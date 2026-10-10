using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000195 RID: 405
	[NativeHeader("Runtime/Graphics/Mesh/SkinnedMeshRenderer.h")]
	[RequiredByNativeCode]
	public class SkinnedMeshRenderer : Renderer
	{
		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000ED1 RID: 3793
		// (set) Token: 0x06000ED2 RID: 3794
		public extern SkinQuality quality { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000ED3 RID: 3795
		// (set) Token: 0x06000ED4 RID: 3796
		public extern bool updateWhenOffscreen { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000ED5 RID: 3797
		// (set) Token: 0x06000ED6 RID: 3798
		public extern bool forceMatrixRecalculationPerRender { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000ED7 RID: 3799
		// (set) Token: 0x06000ED8 RID: 3800
		public extern Transform rootBone { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000ED9 RID: 3801
		// (set) Token: 0x06000EDA RID: 3802
		public extern Transform[] bones { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000EDB RID: 3803
		// (set) Token: 0x06000EDC RID: 3804
		[NativeProperty("Mesh")]
		public extern Mesh sharedMesh { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000EDD RID: 3805
		// (set) Token: 0x06000EDE RID: 3806
		[NativeProperty("SkinnedMeshMotionVectors")]
		public extern bool skinnedMotionVectors { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000EDF RID: 3807
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern float GetBlendShapeWeight(int index);

		// Token: 0x06000EE0 RID: 3808
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetBlendShapeWeight(int index, float value);

		// Token: 0x06000EE1 RID: 3809 RVA: 0x00012D87 File Offset: 0x00010F87
		public void BakeMesh(Mesh mesh)
		{
			this.BakeMesh(mesh, false);
		}

		// Token: 0x06000EE2 RID: 3810
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void BakeMesh([NotNull("NullExceptionObject")] Mesh mesh, bool useScale);

		// Token: 0x06000EE3 RID: 3811 RVA: 0x00012D94 File Offset: 0x00010F94
		public GraphicsBuffer GetVertexBuffer()
		{
			bool flag = this == null;
			if (flag)
			{
				throw new NullReferenceException();
			}
			return this.GetVertexBufferImpl();
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x00012DC0 File Offset: 0x00010FC0
		public GraphicsBuffer GetPreviousVertexBuffer()
		{
			bool flag = this == null;
			if (flag)
			{
				throw new NullReferenceException();
			}
			return this.GetPreviousVertexBufferImpl();
		}

		// Token: 0x06000EE5 RID: 3813
		[FreeFunction(Name = "SkinnedMeshRendererScripting::GetVertexBufferPtr", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern GraphicsBuffer GetVertexBufferImpl();

		// Token: 0x06000EE6 RID: 3814
		[FreeFunction(Name = "SkinnedMeshRendererScripting::GetPreviousVertexBufferPtr", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern GraphicsBuffer GetPreviousVertexBufferImpl();

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000EE7 RID: 3815
		// (set) Token: 0x06000EE8 RID: 3816
		public extern GraphicsBuffer.Target vertexBufferTarget { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
