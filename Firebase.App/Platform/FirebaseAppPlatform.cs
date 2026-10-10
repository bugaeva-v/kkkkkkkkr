using System;

namespace Firebase.Platform
{
	// Token: 0x0200001E RID: 30
	internal class FirebaseAppPlatform : IFirebaseAppPlatform
	{
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000292 RID: 658 RVA: 0x000087E0 File Offset: 0x000069E0
		// (set) Token: 0x06000293 RID: 659 RVA: 0x000087E8 File Offset: 0x000069E8
		private WeakReference app { get; set; }

		// Token: 0x06000294 RID: 660 RVA: 0x000087F1 File Offset: 0x000069F1
		internal FirebaseAppPlatform(FirebaseApp wrappedApp)
		{
			this.app = new WeakReference(wrappedApp, false);
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000295 RID: 661 RVA: 0x0000880C File Offset: 0x00006A0C
		public object AppObject
		{
			get
			{
				object result;
				try
				{
					result = this.app.Target;
				}
				catch (InvalidOperationException)
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000296 RID: 662 RVA: 0x00008840 File Offset: 0x00006A40
		internal FirebaseApp App
		{
			get
			{
				return this.AppObject as FirebaseApp;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000297 RID: 663 RVA: 0x00008860 File Offset: 0x00006A60
		public string Name
		{
			get
			{
				FirebaseApp app = this.App;
				bool flag = app != null;
				string result;
				if (flag)
				{
					result = app.Name;
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000298 RID: 664 RVA: 0x00008890 File Offset: 0x00006A90
		public Uri DatabaseUrl
		{
			get
			{
				FirebaseApp app = this.App;
				bool flag = app != null;
				Uri result;
				if (flag)
				{
					result = app.Options.DatabaseUrl;
				}
				else
				{
					result = null;
				}
				return result;
			}
		}
	}
}
