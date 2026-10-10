using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine.SceneManagement
{
	// Token: 0x020002E2 RID: 738
	[NativeHeader("Runtime/Export/SceneManager/Scene.bindings.h")]
	[Serializable]
	public struct Scene
	{
		// Token: 0x06001E0F RID: 7695
		[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool IsValidInternal(int sceneHandle);

		// Token: 0x06001E10 RID: 7696
		[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string GetPathInternal(int sceneHandle);

		// Token: 0x06001E11 RID: 7697
		[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string GetNameInternal(int sceneHandle);

		// Token: 0x06001E12 RID: 7698
		[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
		[NativeThrows]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetNameInternal(int sceneHandle, string name);

		// Token: 0x06001E13 RID: 7699
		[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string GetGUIDInternal(int sceneHandle);

		// Token: 0x06001E14 RID: 7700
		[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool IsSubScene(int sceneHandle);

		// Token: 0x06001E15 RID: 7701
		[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetIsSubScene(int sceneHandle, bool value);

		// Token: 0x06001E16 RID: 7702
		[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool GetIsLoadedInternal(int sceneHandle);

		// Token: 0x06001E17 RID: 7703
		[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Scene.LoadingState GetLoadingStateInternal(int sceneHandle);

		// Token: 0x06001E18 RID: 7704
		[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool GetIsDirtyInternal(int sceneHandle);

		// Token: 0x06001E19 RID: 7705
		[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int GetDirtyID(int sceneHandle);

		// Token: 0x06001E1A RID: 7706
		[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int GetBuildIndexInternal(int sceneHandle);

		// Token: 0x06001E1B RID: 7707
		[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int GetRootCountInternal(int sceneHandle);

		// Token: 0x06001E1C RID: 7708
		[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetRootGameObjectsInternal(int sceneHandle, object resultRootList);

		// Token: 0x06001E1D RID: 7709 RVA: 0x00030E79 File Offset: 0x0002F079
		internal Scene(int handle)
		{
			this.m_Handle = handle;
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06001E1E RID: 7710 RVA: 0x00030E84 File Offset: 0x0002F084
		public int handle
		{
			get
			{
				return this.m_Handle;
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06001E1F RID: 7711 RVA: 0x00030E9C File Offset: 0x0002F09C
		internal Scene.LoadingState loadingState
		{
			get
			{
				return Scene.GetLoadingStateInternal(this.handle);
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06001E20 RID: 7712 RVA: 0x00030EBC File Offset: 0x0002F0BC
		internal string guid
		{
			get
			{
				return Scene.GetGUIDInternal(this.handle);
			}
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x00030EDC File Offset: 0x0002F0DC
		public bool IsValid()
		{
			return Scene.IsValidInternal(this.handle);
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06001E22 RID: 7714 RVA: 0x00030EFC File Offset: 0x0002F0FC
		public string path
		{
			get
			{
				return Scene.GetPathInternal(this.handle);
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06001E23 RID: 7715 RVA: 0x00030F1C File Offset: 0x0002F11C
		// (set) Token: 0x06001E24 RID: 7716 RVA: 0x00030F39 File Offset: 0x0002F139
		public string name
		{
			get
			{
				return Scene.GetNameInternal(this.handle);
			}
			set
			{
				Scene.SetNameInternal(this.handle, value);
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06001E25 RID: 7717 RVA: 0x00030F4C File Offset: 0x0002F14C
		public bool isLoaded
		{
			get
			{
				return Scene.GetIsLoadedInternal(this.handle);
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001E26 RID: 7718 RVA: 0x00030F6C File Offset: 0x0002F16C
		public int buildIndex
		{
			get
			{
				return Scene.GetBuildIndexInternal(this.handle);
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06001E27 RID: 7719 RVA: 0x00030F8C File Offset: 0x0002F18C
		public bool isDirty
		{
			get
			{
				return Scene.GetIsDirtyInternal(this.handle);
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06001E28 RID: 7720 RVA: 0x00030FAC File Offset: 0x0002F1AC
		internal int dirtyID
		{
			get
			{
				return Scene.GetDirtyID(this.handle);
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06001E29 RID: 7721 RVA: 0x00030FCC File Offset: 0x0002F1CC
		public int rootCount
		{
			get
			{
				return Scene.GetRootCountInternal(this.handle);
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06001E2A RID: 7722 RVA: 0x00030FEC File Offset: 0x0002F1EC
		// (set) Token: 0x06001E2B RID: 7723 RVA: 0x00031009 File Offset: 0x0002F209
		public bool isSubScene
		{
			get
			{
				return Scene.IsSubScene(this.handle);
			}
			set
			{
				Scene.SetIsSubScene(this.handle, value);
			}
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x0003101C File Offset: 0x0002F21C
		public GameObject[] GetRootGameObjects()
		{
			List<GameObject> list = new List<GameObject>(this.rootCount);
			this.GetRootGameObjects(list);
			return list.ToArray();
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x00031048 File Offset: 0x0002F248
		public void GetRootGameObjects(List<GameObject> rootGameObjects)
		{
			bool flag = rootGameObjects.Capacity < this.rootCount;
			if (flag)
			{
				rootGameObjects.Capacity = this.rootCount;
			}
			rootGameObjects.Clear();
			bool flag2 = !this.IsValid();
			if (flag2)
			{
				throw new ArgumentException("The scene is invalid.");
			}
			bool flag3 = !Application.isPlaying && !this.isLoaded;
			if (flag3)
			{
				throw new ArgumentException("The scene is not loaded.");
			}
			bool flag4 = this.rootCount == 0;
			if (!flag4)
			{
				Scene.GetRootGameObjectsInternal(this.handle, rootGameObjects);
			}
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x000310D4 File Offset: 0x0002F2D4
		public static bool operator ==(Scene lhs, Scene rhs)
		{
			return lhs.handle == rhs.handle;
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x000310F8 File Offset: 0x0002F2F8
		public static bool operator !=(Scene lhs, Scene rhs)
		{
			return lhs.handle != rhs.handle;
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x00031120 File Offset: 0x0002F320
		public override int GetHashCode()
		{
			return this.m_Handle;
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x00031138 File Offset: 0x0002F338
		public override bool Equals(object other)
		{
			bool flag = !(other is Scene);
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				Scene scene = (Scene)other;
				result = (this.handle == scene.handle);
			}
			return result;
		}

		// Token: 0x040009E0 RID: 2528
		[HideInInspector]
		[SerializeField]
		private int m_Handle;

		// Token: 0x020002E3 RID: 739
		internal enum LoadingState
		{
			// Token: 0x040009E2 RID: 2530
			NotLoaded,
			// Token: 0x040009E3 RID: 2531
			Loading,
			// Token: 0x040009E4 RID: 2532
			Loaded,
			// Token: 0x040009E5 RID: 2533
			Unloading
		}
	}
}
