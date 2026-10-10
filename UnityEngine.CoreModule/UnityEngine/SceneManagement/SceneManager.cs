using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Events;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine.SceneManagement
{
	// Token: 0x020002E6 RID: 742
	[NativeHeader("Runtime/Export/SceneManager/SceneManager.bindings.h")]
	[RequiredByNativeCode]
	public class SceneManager
	{
		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06001E42 RID: 7746
		public static extern int sceneCount { [StaticAccessor("GetSceneManager()", StaticAccessorType.Dot)] [NativeHeader("Runtime/SceneManager/SceneManager.h")] [NativeMethod("GetSceneCount")] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001E43 RID: 7747 RVA: 0x000311F0 File Offset: 0x0002F3F0
		public static int sceneCountInBuildSettings
		{
			get
			{
				return SceneManagerAPI.ActiveAPI.GetNumScenesInBuildSettings();
			}
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x0003120C File Offset: 0x0002F40C
		[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
		public static Scene GetActiveScene()
		{
			Scene result;
			SceneManager.GetActiveScene_Injected(out result);
			return result;
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x00031221 File Offset: 0x0002F421
		[NativeThrows]
		[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
		public static bool SetActiveScene(Scene scene)
		{
			return SceneManager.SetActiveScene_Injected(ref scene);
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x0003122C File Offset: 0x0002F42C
		[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
		public static Scene GetSceneByPath(string scenePath)
		{
			Scene result;
			SceneManager.GetSceneByPath_Injected(scenePath, out result);
			return result;
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x00031244 File Offset: 0x0002F444
		[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
		public static Scene GetSceneByName(string name)
		{
			Scene result;
			SceneManager.GetSceneByName_Injected(name, out result);
			return result;
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x0003125C File Offset: 0x0002F45C
		public static Scene GetSceneByBuildIndex(int buildIndex)
		{
			return SceneManagerAPI.ActiveAPI.GetSceneByBuildIndex(buildIndex);
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x0003127C File Offset: 0x0002F47C
		[NativeThrows]
		[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
		public static Scene GetSceneAt(int index)
		{
			Scene result;
			SceneManager.GetSceneAt_Injected(index, out result);
			return result;
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x00031294 File Offset: 0x0002F494
		[NativeThrows]
		[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
		public static Scene CreateScene([NotNull("ArgumentNullException")] string sceneName, CreateSceneParameters parameters)
		{
			Scene result;
			SceneManager.CreateScene_Injected(sceneName, ref parameters, out result);
			return result;
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x000312AC File Offset: 0x0002F4AC
		[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
		[NativeThrows]
		private static bool UnloadSceneInternal(Scene scene, UnloadSceneOptions options)
		{
			return SceneManager.UnloadSceneInternal_Injected(ref scene, options);
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x000312B6 File Offset: 0x0002F4B6
		[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
		[NativeThrows]
		private static AsyncOperation UnloadSceneAsyncInternal(Scene scene, UnloadSceneOptions options)
		{
			return SceneManager.UnloadSceneAsyncInternal_Injected(ref scene, options);
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x000312C0 File Offset: 0x0002F4C0
		private static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame)
		{
			bool flag = !SceneManager.s_AllowLoadScene;
			AsyncOperation result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = SceneManagerAPI.ActiveAPI.LoadSceneAsyncByNameOrIndex(sceneName, sceneBuildIndex, parameters, mustCompleteNextFrame);
			}
			return result;
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x000312F0 File Offset: 0x0002F4F0
		private static AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess)
		{
			bool flag = !SceneManager.s_AllowLoadScene;
			AsyncOperation result;
			if (flag)
			{
				outSuccess = false;
				result = null;
			}
			else
			{
				result = SceneManagerAPI.ActiveAPI.UnloadSceneAsyncByNameOrIndex(sceneName, sceneBuildIndex, immediately, options, out outSuccess);
			}
			return result;
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x00031327 File Offset: 0x0002F527
		[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
		[NativeThrows]
		public static void MergeScenes(Scene sourceScene, Scene destinationScene)
		{
			SceneManager.MergeScenes_Injected(ref sourceScene, ref destinationScene);
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x00031332 File Offset: 0x0002F532
		[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
		[NativeThrows]
		public static void MoveGameObjectToScene([NotNull("ArgumentNullException")] GameObject go, Scene scene)
		{
			SceneManager.MoveGameObjectToScene_Injected(go, ref scene);
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x0003133C File Offset: 0x0002F53C
		[RequiredByNativeCode]
		internal static AsyncOperation LoadFirstScene_Internal(bool async)
		{
			return SceneManagerAPI.ActiveAPI.LoadFirstScene(async);
		}

		// Token: 0x14000028 RID: 40
		// (add) Token: 0x06001E52 RID: 7762 RVA: 0x0003135C File Offset: 0x0002F55C
		// (remove) Token: 0x06001E53 RID: 7763 RVA: 0x00031390 File Offset: 0x0002F590
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event UnityAction<Scene, LoadSceneMode> sceneLoaded;

		// Token: 0x14000029 RID: 41
		// (add) Token: 0x06001E54 RID: 7764 RVA: 0x000313C4 File Offset: 0x0002F5C4
		// (remove) Token: 0x06001E55 RID: 7765 RVA: 0x000313F8 File Offset: 0x0002F5F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event UnityAction<Scene> sceneUnloaded;

		// Token: 0x1400002A RID: 42
		// (add) Token: 0x06001E56 RID: 7766 RVA: 0x0003142C File Offset: 0x0002F62C
		// (remove) Token: 0x06001E57 RID: 7767 RVA: 0x00031460 File Offset: 0x0002F660
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event UnityAction<Scene, Scene> activeSceneChanged;

		// Token: 0x06001E58 RID: 7768 RVA: 0x00031494 File Offset: 0x0002F694
		[Obsolete("Use SceneManager.sceneCount and SceneManager.GetSceneAt(int index) to loop the all scenes instead.")]
		public static Scene[] GetAllScenes()
		{
			Scene[] array = new Scene[SceneManager.sceneCount];
			for (int i = 0; i < SceneManager.sceneCount; i++)
			{
				array[i] = SceneManager.GetSceneAt(i);
			}
			return array;
		}

		// Token: 0x06001E59 RID: 7769 RVA: 0x000314D8 File Offset: 0x0002F6D8
		public static Scene CreateScene(string sceneName)
		{
			CreateSceneParameters parameters = new CreateSceneParameters(LocalPhysicsMode.None);
			return SceneManager.CreateScene(sceneName, parameters);
		}

		// Token: 0x06001E5A RID: 7770 RVA: 0x000314FC File Offset: 0x0002F6FC
		public static void LoadScene(string sceneName, [DefaultValue("LoadSceneMode.Single")] LoadSceneMode mode)
		{
			LoadSceneParameters parameters = new LoadSceneParameters(mode);
			SceneManager.LoadScene(sceneName, parameters);
		}

		// Token: 0x06001E5B RID: 7771 RVA: 0x0003151C File Offset: 0x0002F71C
		[ExcludeFromDocs]
		public static void LoadScene(string sceneName)
		{
			LoadSceneParameters parameters = new LoadSceneParameters(LoadSceneMode.Single);
			SceneManager.LoadScene(sceneName, parameters);
		}

		// Token: 0x06001E5C RID: 7772 RVA: 0x0003153C File Offset: 0x0002F73C
		public static Scene LoadScene(string sceneName, LoadSceneParameters parameters)
		{
			SceneManager.LoadSceneAsyncNameIndexInternal(sceneName, -1, parameters, true);
			return SceneManager.GetSceneAt(SceneManager.sceneCount - 1);
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x00031564 File Offset: 0x0002F764
		public static void LoadScene(int sceneBuildIndex, [DefaultValue("LoadSceneMode.Single")] LoadSceneMode mode)
		{
			LoadSceneParameters parameters = new LoadSceneParameters(mode);
			SceneManager.LoadScene(sceneBuildIndex, parameters);
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x00031584 File Offset: 0x0002F784
		[ExcludeFromDocs]
		public static void LoadScene(int sceneBuildIndex)
		{
			LoadSceneParameters parameters = new LoadSceneParameters(LoadSceneMode.Single);
			SceneManager.LoadScene(sceneBuildIndex, parameters);
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x000315A4 File Offset: 0x0002F7A4
		public static Scene LoadScene(int sceneBuildIndex, LoadSceneParameters parameters)
		{
			SceneManager.LoadSceneAsyncNameIndexInternal(null, sceneBuildIndex, parameters, true);
			return SceneManager.GetSceneAt(SceneManager.sceneCount - 1);
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x000315CC File Offset: 0x0002F7CC
		public static AsyncOperation LoadSceneAsync(int sceneBuildIndex, [DefaultValue("LoadSceneMode.Single")] LoadSceneMode mode)
		{
			LoadSceneParameters parameters = new LoadSceneParameters(mode);
			return SceneManager.LoadSceneAsync(sceneBuildIndex, parameters);
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x000315F0 File Offset: 0x0002F7F0
		[ExcludeFromDocs]
		public static AsyncOperation LoadSceneAsync(int sceneBuildIndex)
		{
			LoadSceneParameters parameters = new LoadSceneParameters(LoadSceneMode.Single);
			return SceneManager.LoadSceneAsync(sceneBuildIndex, parameters);
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x00031614 File Offset: 0x0002F814
		public static AsyncOperation LoadSceneAsync(int sceneBuildIndex, LoadSceneParameters parameters)
		{
			return SceneManager.LoadSceneAsyncNameIndexInternal(null, sceneBuildIndex, parameters, false);
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x00031630 File Offset: 0x0002F830
		public static AsyncOperation LoadSceneAsync(string sceneName, [DefaultValue("LoadSceneMode.Single")] LoadSceneMode mode)
		{
			LoadSceneParameters parameters = new LoadSceneParameters(mode);
			return SceneManager.LoadSceneAsync(sceneName, parameters);
		}

		// Token: 0x06001E64 RID: 7780 RVA: 0x00031654 File Offset: 0x0002F854
		[ExcludeFromDocs]
		public static AsyncOperation LoadSceneAsync(string sceneName)
		{
			LoadSceneParameters parameters = new LoadSceneParameters(LoadSceneMode.Single);
			return SceneManager.LoadSceneAsync(sceneName, parameters);
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x00031678 File Offset: 0x0002F878
		public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters)
		{
			return SceneManager.LoadSceneAsyncNameIndexInternal(sceneName, -1, parameters, false);
		}

		// Token: 0x06001E66 RID: 7782 RVA: 0x00031694 File Offset: 0x0002F894
		[Obsolete("Use SceneManager.UnloadSceneAsync. This function is not safe to use during triggers and under other circumstances. See Scripting reference for more details.")]
		public static bool UnloadScene(Scene scene)
		{
			return SceneManager.UnloadSceneInternal(scene, UnloadSceneOptions.None);
		}

		// Token: 0x06001E67 RID: 7783 RVA: 0x000316B0 File Offset: 0x0002F8B0
		[Obsolete("Use SceneManager.UnloadSceneAsync. This function is not safe to use during triggers and under other circumstances. See Scripting reference for more details.")]
		public static bool UnloadScene(int sceneBuildIndex)
		{
			bool result;
			SceneManager.UnloadSceneNameIndexInternal("", sceneBuildIndex, true, UnloadSceneOptions.None, out result);
			return result;
		}

		// Token: 0x06001E68 RID: 7784 RVA: 0x000316D4 File Offset: 0x0002F8D4
		[Obsolete("Use SceneManager.UnloadSceneAsync. This function is not safe to use during triggers and under other circumstances. See Scripting reference for more details.")]
		public static bool UnloadScene(string sceneName)
		{
			bool result;
			SceneManager.UnloadSceneNameIndexInternal(sceneName, -1, true, UnloadSceneOptions.None, out result);
			return result;
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x000316F4 File Offset: 0x0002F8F4
		public static AsyncOperation UnloadSceneAsync(int sceneBuildIndex)
		{
			bool flag;
			return SceneManager.UnloadSceneNameIndexInternal("", sceneBuildIndex, false, UnloadSceneOptions.None, out flag);
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x00031718 File Offset: 0x0002F918
		public static AsyncOperation UnloadSceneAsync(string sceneName)
		{
			bool flag;
			return SceneManager.UnloadSceneNameIndexInternal(sceneName, -1, false, UnloadSceneOptions.None, out flag);
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x00031738 File Offset: 0x0002F938
		public static AsyncOperation UnloadSceneAsync(Scene scene)
		{
			return SceneManager.UnloadSceneAsyncInternal(scene, UnloadSceneOptions.None);
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x00031754 File Offset: 0x0002F954
		public static AsyncOperation UnloadSceneAsync(int sceneBuildIndex, UnloadSceneOptions options)
		{
			bool flag;
			return SceneManager.UnloadSceneNameIndexInternal("", sceneBuildIndex, false, options, out flag);
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x00031778 File Offset: 0x0002F978
		public static AsyncOperation UnloadSceneAsync(string sceneName, UnloadSceneOptions options)
		{
			bool flag;
			return SceneManager.UnloadSceneNameIndexInternal(sceneName, -1, false, options, out flag);
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x00031798 File Offset: 0x0002F998
		public static AsyncOperation UnloadSceneAsync(Scene scene, UnloadSceneOptions options)
		{
			return SceneManager.UnloadSceneAsyncInternal(scene, options);
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x000317B4 File Offset: 0x0002F9B4
		[RequiredByNativeCode]
		private static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode)
		{
			bool flag = SceneManager.sceneLoaded != null;
			if (flag)
			{
				SceneManager.sceneLoaded(scene, mode);
			}
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x000317E0 File Offset: 0x0002F9E0
		[RequiredByNativeCode]
		private static void Internal_SceneUnloaded(Scene scene)
		{
			bool flag = SceneManager.sceneUnloaded != null;
			if (flag)
			{
				SceneManager.sceneUnloaded(scene);
			}
		}

		// Token: 0x06001E71 RID: 7793 RVA: 0x00031808 File Offset: 0x0002FA08
		[RequiredByNativeCode]
		private static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene)
		{
			bool flag = SceneManager.activeSceneChanged != null;
			if (flag)
			{
				SceneManager.activeSceneChanged(previousActiveScene, newActiveScene);
			}
		}

		// Token: 0x06001E74 RID: 7796
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetActiveScene_Injected(out Scene ret);

		// Token: 0x06001E75 RID: 7797
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool SetActiveScene_Injected(ref Scene scene);

		// Token: 0x06001E76 RID: 7798
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetSceneByPath_Injected(string scenePath, out Scene ret);

		// Token: 0x06001E77 RID: 7799
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetSceneByName_Injected(string name, out Scene ret);

		// Token: 0x06001E78 RID: 7800
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetSceneAt_Injected(int index, out Scene ret);

		// Token: 0x06001E79 RID: 7801
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void CreateScene_Injected(string sceneName, ref CreateSceneParameters parameters, out Scene ret);

		// Token: 0x06001E7A RID: 7802
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool UnloadSceneInternal_Injected(ref Scene scene, UnloadSceneOptions options);

		// Token: 0x06001E7B RID: 7803
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern AsyncOperation UnloadSceneAsyncInternal_Injected(ref Scene scene, UnloadSceneOptions options);

		// Token: 0x06001E7C RID: 7804
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void MergeScenes_Injected(ref Scene sourceScene, ref Scene destinationScene);

		// Token: 0x06001E7D RID: 7805
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void MoveGameObjectToScene_Injected(GameObject go, ref Scene scene);

		// Token: 0x040009E8 RID: 2536
		internal static bool s_AllowLoadScene = true;
	}
}
