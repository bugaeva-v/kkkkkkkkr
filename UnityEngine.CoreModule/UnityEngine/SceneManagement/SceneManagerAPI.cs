using System;

namespace UnityEngine.SceneManagement
{
	// Token: 0x020002E5 RID: 741
	public class SceneManagerAPI
	{
		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06001E38 RID: 7736 RVA: 0x00031196 File Offset: 0x0002F396
		internal static SceneManagerAPI ActiveAPI
		{
			get
			{
				return SceneManagerAPI.overrideAPI ?? SceneManagerAPI.s_DefaultAPI;
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06001E39 RID: 7737 RVA: 0x000311A6 File Offset: 0x0002F3A6
		// (set) Token: 0x06001E3A RID: 7738 RVA: 0x000311AD File Offset: 0x0002F3AD
		public static SceneManagerAPI overrideAPI { get; set; }

		// Token: 0x06001E3B RID: 7739 RVA: 0x00008CE3 File Offset: 0x00006EE3
		protected internal SceneManagerAPI()
		{
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x000311B5 File Offset: 0x0002F3B5
		protected internal virtual int GetNumScenesInBuildSettings()
		{
			return SceneManagerAPIInternal.GetNumScenesInBuildSettings();
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x000311BC File Offset: 0x0002F3BC
		protected internal virtual Scene GetSceneByBuildIndex(int buildIndex)
		{
			return SceneManagerAPIInternal.GetSceneByBuildIndex(buildIndex);
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x000311C4 File Offset: 0x0002F3C4
		protected internal virtual AsyncOperation LoadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame)
		{
			return SceneManagerAPIInternal.LoadSceneAsyncNameIndexInternal(sceneName, sceneBuildIndex, parameters, mustCompleteNextFrame);
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x000311D0 File Offset: 0x0002F3D0
		protected internal virtual AsyncOperation UnloadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess)
		{
			return SceneManagerAPIInternal.UnloadSceneNameIndexInternal(sceneName, sceneBuildIndex, immediately, options, out outSuccess);
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x000311DE File Offset: 0x0002F3DE
		protected internal virtual AsyncOperation LoadFirstScene(bool mustLoadAsync)
		{
			return null;
		}

		// Token: 0x040009E6 RID: 2534
		private static SceneManagerAPI s_DefaultAPI = new SceneManagerAPI();
	}
}
