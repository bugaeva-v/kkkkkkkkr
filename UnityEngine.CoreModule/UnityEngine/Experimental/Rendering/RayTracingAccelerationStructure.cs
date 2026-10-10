using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000480 RID: 1152
	public sealed class RayTracingAccelerationStructure : IDisposable
	{
		// Token: 0x0600288B RID: 10379 RVA: 0x00043318 File Offset: 0x00041518
		~RayTracingAccelerationStructure()
		{
			this.Dispose(false);
		}

		// Token: 0x0600288C RID: 10380 RVA: 0x0004334C File Offset: 0x0004154C
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600288D RID: 10381 RVA: 0x00043360 File Offset: 0x00041560
		private void Dispose(bool disposing)
		{
			if (disposing)
			{
				RayTracingAccelerationStructure.Destroy(this);
			}
			this.m_Ptr = IntPtr.Zero;
		}

		// Token: 0x0600288E RID: 10382 RVA: 0x00043387 File Offset: 0x00041587
		public RayTracingAccelerationStructure(RayTracingAccelerationStructure.RASSettings settings)
		{
			this.m_Ptr = RayTracingAccelerationStructure.Create(settings);
		}

		// Token: 0x0600288F RID: 10383 RVA: 0x000433A0 File Offset: 0x000415A0
		public RayTracingAccelerationStructure()
		{
			this.m_Ptr = RayTracingAccelerationStructure.Create(new RayTracingAccelerationStructure.RASSettings
			{
				rayTracingModeMask = RayTracingAccelerationStructure.RayTracingModeMask.Everything,
				managementMode = RayTracingAccelerationStructure.ManagementMode.Manual,
				layerMask = -1
			});
		}

		// Token: 0x06002890 RID: 10384 RVA: 0x000433E2 File Offset: 0x000415E2
		[FreeFunction("RayTracingAccelerationStructure_Bindings::Create")]
		private static IntPtr Create(RayTracingAccelerationStructure.RASSettings desc)
		{
			return RayTracingAccelerationStructure.Create_Injected(ref desc);
		}

		// Token: 0x06002891 RID: 10385
		[FreeFunction("RayTracingAccelerationStructure_Bindings::Destroy")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Destroy(RayTracingAccelerationStructure accelStruct);

		// Token: 0x06002892 RID: 10386 RVA: 0x000433EB File Offset: 0x000415EB
		public void Release()
		{
			this.Dispose();
		}

		// Token: 0x06002893 RID: 10387 RVA: 0x000433F5 File Offset: 0x000415F5
		public void Build()
		{
			this.Build(Vector3.zero);
		}

		// Token: 0x06002894 RID: 10388 RVA: 0x000433F5 File Offset: 0x000415F5
		[Obsolete("Method Update has been deprecated. Use Build instead (UnityUpgradable) -> Build()", true)]
		public void Update()
		{
			this.Build(Vector3.zero);
		}

		// Token: 0x06002895 RID: 10389 RVA: 0x00043404 File Offset: 0x00041604
		[FreeFunction(Name = "RayTracingAccelerationStructure_Bindings::Build", HasExplicitThis = true)]
		public void Build(Vector3 relativeOrigin)
		{
			this.Build_Injected(ref relativeOrigin);
		}

		// Token: 0x06002896 RID: 10390 RVA: 0x0004340E File Offset: 0x0004160E
		[Obsolete("Method Update has been deprecated. Use Build instead (UnityUpgradable) -> Build(*)", true)]
		[FreeFunction(Name = "RayTracingAccelerationStructure_Bindings::Update", HasExplicitThis = true)]
		public void Update(Vector3 relativeOrigin)
		{
			this.Update_Injected(ref relativeOrigin);
		}

		// Token: 0x06002897 RID: 10391
		[FreeFunction(Name = "RayTracingAccelerationStructure_Bindings::AddInstanceDeprecated", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void AddInstance([NotNull("ArgumentNullException")] Renderer targetRenderer, bool[] subMeshMask = null, bool[] subMeshTransparencyFlags = null, bool enableTriangleCulling = true, bool frontTriangleCounterClockwise = false, uint mask = 255U, uint id = 4294967295U);

		// Token: 0x06002898 RID: 10392 RVA: 0x00043418 File Offset: 0x00041618
		public void AddInstance(Renderer targetRenderer, RayTracingSubMeshFlags[] subMeshFlags, bool enableTriangleCulling = true, bool frontTriangleCounterClockwise = false, uint mask = 255U, uint id = 4294967295U)
		{
			this.AddInstanceSubMeshFlagsArray(targetRenderer, subMeshFlags, enableTriangleCulling, frontTriangleCounterClockwise, mask, id);
		}

		// Token: 0x06002899 RID: 10393
		[FreeFunction(Name = "RayTracingAccelerationStructure_Bindings::RemoveInstance", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RemoveInstance([NotNull("ArgumentNullException")] Renderer targetRenderer);

		// Token: 0x0600289A RID: 10394 RVA: 0x0004342C File Offset: 0x0004162C
		public void AddInstance(GraphicsBuffer aabbBuffer, uint numElements, Material material, bool isCutOff, bool enableTriangleCulling = true, bool frontTriangleCounterClockwise = false, uint mask = 255U, bool reuseBounds = false, uint id = 4294967295U)
		{
			this.AddInstance_Procedural(aabbBuffer, numElements, material, Matrix4x4.identity, isCutOff, enableTriangleCulling, frontTriangleCounterClockwise, mask, reuseBounds, id);
		}

		// Token: 0x0600289B RID: 10395 RVA: 0x00043458 File Offset: 0x00041658
		public void AddInstance(GraphicsBuffer aabbBuffer, uint numElements, Material material, Matrix4x4 instanceTransform, bool isCutOff, bool enableTriangleCulling = true, bool frontTriangleCounterClockwise = false, uint mask = 255U, bool reuseBounds = false, uint id = 4294967295U)
		{
			this.AddInstance_Procedural(aabbBuffer, numElements, material, instanceTransform, isCutOff, enableTriangleCulling, frontTriangleCounterClockwise, mask, reuseBounds, id);
		}

		// Token: 0x0600289C RID: 10396 RVA: 0x00043480 File Offset: 0x00041680
		[FreeFunction(Name = "RayTracingAccelerationStructure_Bindings::AddInstance", HasExplicitThis = true)]
		private void AddInstance_Procedural([NotNull("ArgumentNullException")] GraphicsBuffer aabbBuffer, uint numElements, [NotNull("ArgumentNullException")] Material material, Matrix4x4 instanceTransform, bool isCutOff, bool enableTriangleCulling = true, bool frontTriangleCounterClockwise = false, uint mask = 255U, bool reuseBounds = false, uint id = 4294967295U)
		{
			this.AddInstance_Procedural_Injected(aabbBuffer, numElements, material, ref instanceTransform, isCutOff, enableTriangleCulling, frontTriangleCounterClockwise, mask, reuseBounds, id);
		}

		// Token: 0x0600289D RID: 10397
		[FreeFunction(Name = "RayTracingAccelerationStructure_Bindings::UpdateInstanceTransform", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void UpdateInstanceTransform([NotNull("ArgumentNullException")] Renderer renderer);

		// Token: 0x0600289E RID: 10398
		[FreeFunction(Name = "RayTracingAccelerationStructure_Bindings::UpdateInstanceMask", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void UpdateInstanceMask([NotNull("ArgumentNullException")] Renderer renderer, uint mask);

		// Token: 0x0600289F RID: 10399
		[FreeFunction(Name = "RayTracingAccelerationStructure_Bindings::UpdateInstanceID", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void UpdateInstanceID([NotNull("ArgumentNullException")] Renderer renderer, uint instanceID);

		// Token: 0x060028A0 RID: 10400
		[FreeFunction(Name = "RayTracingAccelerationStructure_Bindings::GetSize", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern ulong GetSize();

		// Token: 0x060028A1 RID: 10401
		[FreeFunction(Name = "RayTracingAccelerationStructure_Bindings::GetInstanceCount", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern uint GetInstanceCount();

		// Token: 0x060028A2 RID: 10402
		[FreeFunction(Name = "RayTracingAccelerationStructure_Bindings::AddInstanceSubMeshFlagsArray", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void AddInstanceSubMeshFlagsArray([NotNull("ArgumentNullException")] Renderer targetRenderer, RayTracingSubMeshFlags[] subMeshFlags, bool enableTriangleCulling = true, bool frontTriangleCounterClockwise = false, uint mask = 255U, uint id = 4294967295U);

		// Token: 0x060028A3 RID: 10403
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr Create_Injected(ref RayTracingAccelerationStructure.RASSettings desc);

		// Token: 0x060028A4 RID: 10404
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Build_Injected(ref Vector3 relativeOrigin);

		// Token: 0x060028A5 RID: 10405
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Update_Injected(ref Vector3 relativeOrigin);

		// Token: 0x060028A6 RID: 10406
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void AddInstance_Procedural_Injected(GraphicsBuffer aabbBuffer, uint numElements, Material material, ref Matrix4x4 instanceTransform, bool isCutOff, bool enableTriangleCulling = true, bool frontTriangleCounterClockwise = false, uint mask = 255U, bool reuseBounds = false, uint id = 4294967295U);

		// Token: 0x04000F8E RID: 3982
		internal IntPtr m_Ptr;

		// Token: 0x02000481 RID: 1153
		[Flags]
		public enum RayTracingModeMask
		{
			// Token: 0x04000F90 RID: 3984
			Nothing = 0,
			// Token: 0x04000F91 RID: 3985
			Static = 2,
			// Token: 0x04000F92 RID: 3986
			DynamicTransform = 4,
			// Token: 0x04000F93 RID: 3987
			DynamicGeometry = 8,
			// Token: 0x04000F94 RID: 3988
			Everything = 14
		}

		// Token: 0x02000482 RID: 1154
		public enum ManagementMode
		{
			// Token: 0x04000F96 RID: 3990
			Manual,
			// Token: 0x04000F97 RID: 3991
			Automatic
		}

		// Token: 0x02000483 RID: 1155
		public struct RASSettings
		{
			// Token: 0x060028A7 RID: 10407 RVA: 0x000434A4 File Offset: 0x000416A4
			public RASSettings(RayTracingAccelerationStructure.ManagementMode sceneManagementMode, RayTracingAccelerationStructure.RayTracingModeMask rayTracingModeMask, int layerMask)
			{
				this.managementMode = sceneManagementMode;
				this.rayTracingModeMask = rayTracingModeMask;
				this.layerMask = layerMask;
			}

			// Token: 0x04000F98 RID: 3992
			public RayTracingAccelerationStructure.ManagementMode managementMode;

			// Token: 0x04000F99 RID: 3993
			public RayTracingAccelerationStructure.RayTracingModeMask rayTracingModeMask;

			// Token: 0x04000F9A RID: 3994
			public int layerMask;
		}
	}
}
