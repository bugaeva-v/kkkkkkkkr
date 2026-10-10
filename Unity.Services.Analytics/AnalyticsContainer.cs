using System;
using Unity.Services.Analytics.Internal;
using UnityEngine;

namespace Unity.Services.Analytics
{
	// Token: 0x0200001A RID: 26
	internal class AnalyticsContainer : MonoBehaviour, IAnalyticsContainer, IContainerDebug
	{
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00003B27 File Offset: 0x00001D27
		private float AutoFlushPeriod
		{
			get
			{
				return 60f * (float)this.m_Service.AutoflushPeriodMultiplier;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00003B3B File Offset: 0x00001D3B
		internal static IContainerDebug ContainerDebug
		{
			get
			{
				return AnalyticsContainer.m_Instance;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00003B42 File Offset: 0x00001D42
		public float TimeUntilNextHeartbeat
		{
			get
			{
				return this.AutoFlushPeriod - this.m_AutoFlushTime;
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00003B54 File Offset: 0x00001D54
		internal static AnalyticsContainer CreateContainer()
		{
			if (!AnalyticsContainer.s_Created)
			{
				AnalyticsContainer.s_Container = new GameObject("AnalyticsContainer");
				AnalyticsContainer.m_Instance = AnalyticsContainer.s_Container.AddComponent<AnalyticsContainer>();
				AnalyticsContainer.s_Container.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild);
				AnalyticsContainer.s_Container.hideFlags |= HideFlags.HideInInspector;
				UnityEngine.Object.DontDestroyOnLoad(AnalyticsContainer.s_Container);
				AnalyticsContainer.s_Created = true;
				Application.quitting += AnalyticsContainer.m_Instance.CleanUp;
			}
			return AnalyticsContainer.m_Instance;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00003BCE File Offset: 0x00001DCE
		public void Initialize(AnalyticsServiceInstance service)
		{
			this.m_Service = service;
			base.enabled = false;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00003BDE File Offset: 0x00001DDE
		public void Enable()
		{
			base.enabled = true;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00003BE7 File Offset: 0x00001DE7
		public void Disable()
		{
			base.enabled = false;
			this.m_AutoFlushTime = 0f;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00003BFC File Offset: 0x00001DFC
		private void Update()
		{
			this.m_GameRunningTime += Time.unscaledDeltaTime;
			if (this.m_GameRunningTime >= 60f)
			{
				this.m_Service.RecordGameRunningIfNecessary();
				this.m_GameRunningTime = 0f;
			}
			this.m_AutoFlushTime += Time.unscaledDeltaTime;
			if (this.m_AutoFlushTime >= this.AutoFlushPeriod)
			{
				this.m_Service.Flush();
				this.m_AutoFlushTime = 0f;
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00003C74 File Offset: 0x00001E74
		private void OnApplicationPause(bool paused)
		{
			this.m_Service.ApplicationPaused(paused);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00003C82 File Offset: 0x00001E82
		private void CleanUp()
		{
			Application.quitting -= AnalyticsContainer.m_Instance.CleanUp;
			this.m_Service.ApplicationQuit();
			AnalyticsContainer.s_Container = null;
			AnalyticsContainer.s_Created = false;
		}

		// Token: 0x04000060 RID: 96
		private const float k_AutoFlushPeriod = 60f;

		// Token: 0x04000061 RID: 97
		private const float k_GameRunningPeriod = 60f;

		// Token: 0x04000062 RID: 98
		private static bool s_Created;

		// Token: 0x04000063 RID: 99
		private static GameObject s_Container;

		// Token: 0x04000064 RID: 100
		private static AnalyticsContainer m_Instance;

		// Token: 0x04000065 RID: 101
		private float m_AutoFlushTime;

		// Token: 0x04000066 RID: 102
		private float m_GameRunningTime;

		// Token: 0x04000067 RID: 103
		private AnalyticsServiceInstance m_Service;
	}
}
