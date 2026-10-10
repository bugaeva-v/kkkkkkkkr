using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Unity.Services.Core.Environments;
using Unity.Services.Core.Internal;
using UnityEngine;
using UnityEngine.Events;

namespace Unity.Services.Core.Components
{
	// Token: 0x02000003 RID: 3
	[AddComponentMenu("Services/Services Initialization")]
	public class ServicesInitialization : ServicesBehaviour
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000A RID: 10 RVA: 0x0000214B File Offset: 0x0000034B
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00002153 File Offset: 0x00000353
		internal bool IsSetupDone { get; private set; }

		// Token: 0x0600000C RID: 12 RVA: 0x0000215C File Offset: 0x0000035C
		internal ServicesInitialization()
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000217C File Offset: 0x0000037C
		protected override void OnServicesReady()
		{
			ServicesInitialization.<OnServicesReady>d__9 <OnServicesReady>d__;
			<OnServicesReady>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnServicesReady>d__.<>4__this = this;
			<OnServicesReady>d__.<>1__state = -1;
			<OnServicesReady>d__.<>t__builder.Start<ServicesInitialization.<OnServicesReady>d__9>(ref <OnServicesReady>d__);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000021B3 File Offset: 0x000003B3
		protected override void OnServicesInitialized()
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000021B5 File Offset: 0x000003B5
		protected override void Cleanup()
		{
			if (base.Services != null)
			{
				base.Services.Initialized -= this.OnInitialized;
				base.Services.InitializeFailed -= this.OnInitializeFailed;
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000021F0 File Offset: 0x000003F0
		internal Task SetupAsync()
		{
			ServicesInitialization.<SetupAsync>d__12 <SetupAsync>d__;
			<SetupAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<SetupAsync>d__.<>4__this = this;
			<SetupAsync>d__.<>1__state = -1;
			<SetupAsync>d__.<>t__builder.Start<ServicesInitialization.<SetupAsync>d__12>(ref <SetupAsync>d__);
			return <SetupAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002234 File Offset: 0x00000434
		internal Task InitializeOnStartAsync()
		{
			ServicesInitialization.<InitializeOnStartAsync>d__13 <InitializeOnStartAsync>d__;
			<InitializeOnStartAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<InitializeOnStartAsync>d__.<>4__this = this;
			<InitializeOnStartAsync>d__.<>1__state = -1;
			<InitializeOnStartAsync>d__.<>t__builder.Start<ServicesInitialization.<InitializeOnStartAsync>d__13>(ref <InitializeOnStartAsync>d__);
			return <InitializeOnStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002278 File Offset: 0x00000478
		internal InitializationOptions BuildInitializationOptions()
		{
			InitializationOptions initializationOptions = new InitializationOptions();
			if (this.UseCustomEnvironment)
			{
				initializationOptions.SetEnvironmentName(this.EnvironmentName);
			}
			return initializationOptions;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000022A1 File Offset: 0x000004A1
		private void OnInitialized()
		{
			ServicesInitializationEvents events = this.Events;
			if (events == null)
			{
				return;
			}
			UnityEvent initialized = events.Initialized;
			if (initialized == null)
			{
				return;
			}
			initialized.Invoke();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000022BD File Offset: 0x000004BD
		private void OnInitializeFailed(Exception e)
		{
			ServicesInitializationEvents events = this.Events;
			if (events == null)
			{
				return;
			}
			UnityEvent<Exception> initializeFailed = events.InitializeFailed;
			if (initializeFailed == null)
			{
				return;
			}
			initializeFailed.Invoke(e);
		}

		// Token: 0x04000005 RID: 5
		[Header("Automation")]
		[Tooltip("This will attempt to initialize the services in Start().")]
		[SerializeField]
		public bool InitializeOnStart;

		// Token: 0x04000006 RID: 6
		[SerializeField]
		[Tooltip("Use this to set a custom environment in the initialization options. Defaults to the environment defined in the project settings or production.")]
		[Visibility("InitializeOnStart", true)]
		public bool UseCustomEnvironment;

		// Token: 0x04000007 RID: 7
		[SerializeField]
		[Tooltip("Choose the environment name to pass in the initialization options. You can configure environments in the unity dashboard.")]
		[Visibility("UseCustomEnvironment", true)]
		public string EnvironmentName = "production";

		// Token: 0x04000008 RID: 8
		[Header("Events")]
		[SerializeField]
		public ServicesInitializationEvents Events = new ServicesInitializationEvents();
	}
}
