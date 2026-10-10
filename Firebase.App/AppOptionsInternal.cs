using System;
using System.Runtime.InteropServices;

namespace Firebase
{
	// Token: 0x02000013 RID: 19
	internal sealed class AppOptionsInternal : IDisposable
	{
		// Token: 0x060000EF RID: 239 RVA: 0x00005248 File Offset: 0x00003448
		internal AppOptionsInternal(IntPtr cPtr, bool cMemoryOwn)
		{
			this.swigCMemOwn = cMemoryOwn;
			this.swigCPtr = new HandleRef(this, cPtr);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00005268 File Offset: 0x00003468
		internal static HandleRef getCPtr(AppOptionsInternal obj)
		{
			return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00005290 File Offset: 0x00003490
		internal static HandleRef swigRelease(AppOptionsInternal obj)
		{
			bool flag = obj != null;
			HandleRef result;
			if (flag)
			{
				bool flag2 = !obj.swigCMemOwn;
				if (flag2)
				{
					throw new ApplicationException("Cannot release ownership as memory is not owned");
				}
				HandleRef handleRef = obj.swigCPtr;
				obj.swigCMemOwn = false;
				obj.Dispose();
				result = handleRef;
			}
			else
			{
				result = new HandleRef(null, IntPtr.Zero);
			}
			return result;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000052E8 File Offset: 0x000034E8
		~AppOptionsInternal()
		{
			this.Dispose(false);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000531C File Offset: 0x0000351C
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00005330 File Offset: 0x00003530
		public void Dispose(bool disposing)
		{
			object disposeLock = FirebaseApp.disposeLock;
			lock (disposeLock)
			{
				bool flag2 = this.swigCPtr.Handle != IntPtr.Zero;
				if (flag2)
				{
					bool flag3 = this.swigCMemOwn;
					if (flag3)
					{
						this.swigCMemOwn = false;
						AppUtilPINVOKE.delete_AppOptionsInternal(this.swigCPtr);
					}
					this.swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				GC.SuppressFinalize(this);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x000053C0 File Offset: 0x000035C0
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x000053DD File Offset: 0x000035DD
		public Uri DatabaseUrl
		{
			get
			{
				return FirebaseApp.UrlStringToUri(this.GetDatabaseUrlInternal());
			}
			set
			{
				this.SetDatabaseUrlInternal(FirebaseApp.UriToUrlString(value));
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000053F0 File Offset: 0x000035F0
		internal AppOptionsInternal() : this(AppUtilPINVOKE.new_AppOptionsInternal(), true)
		{
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000541C File Offset: 0x0000361C
		internal void SetDatabaseUrlInternal(string url)
		{
			AppUtilPINVOKE.AppOptionsInternal_SetDatabaseUrlInternal(this.swigCPtr, url);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00005448 File Offset: 0x00003648
		internal string GetDatabaseUrlInternal()
		{
			string result = AppUtilPINVOKE.AppOptionsInternal_GetDatabaseUrlInternal(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00005478 File Offset: 0x00003678
		internal static AppOptionsInternal LoadFromJsonConfig(string config, AppOptionsInternal options)
		{
			IntPtr intPtr = AppUtilPINVOKE.AppOptionsInternal_LoadFromJsonConfig__SWIG_0(config, AppOptionsInternal.getCPtr(options));
			AppOptionsInternal result = (intPtr == IntPtr.Zero) ? null : new AppOptionsInternal(intPtr, false);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000054C0 File Offset: 0x000036C0
		internal static AppOptionsInternal LoadFromJsonConfig(string config)
		{
			IntPtr intPtr = AppUtilPINVOKE.AppOptionsInternal_LoadFromJsonConfig__SWIG_1(config);
			AppOptionsInternal result = (intPtr == IntPtr.Zero) ? null : new AppOptionsInternal(intPtr, false);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00005530 File Offset: 0x00003730
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00005504 File Offset: 0x00003704
		public string AppId
		{
			get
			{
				string result = AppUtilPINVOKE.AppOptionsInternal_AppId_get(this.swigCPtr);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
			set
			{
				AppUtilPINVOKE.AppOptionsInternal_AppId_set(this.swigCPtr, value);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000FF RID: 255 RVA: 0x0000558C File Offset: 0x0000378C
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00005560 File Offset: 0x00003760
		public string ApiKey
		{
			get
			{
				string result = AppUtilPINVOKE.AppOptionsInternal_ApiKey_get(this.swigCPtr);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
			set
			{
				AppUtilPINVOKE.AppOptionsInternal_ApiKey_set(this.swigCPtr, value);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000101 RID: 257 RVA: 0x000055E8 File Offset: 0x000037E8
		// (set) Token: 0x06000100 RID: 256 RVA: 0x000055BC File Offset: 0x000037BC
		public string MessageSenderId
		{
			get
			{
				string result = AppUtilPINVOKE.AppOptionsInternal_MessageSenderId_get(this.swigCPtr);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
			set
			{
				AppUtilPINVOKE.AppOptionsInternal_MessageSenderId_set(this.swigCPtr, value);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00005644 File Offset: 0x00003844
		// (set) Token: 0x06000102 RID: 258 RVA: 0x00005618 File Offset: 0x00003818
		public string StorageBucket
		{
			get
			{
				string result = AppUtilPINVOKE.AppOptionsInternal_StorageBucket_get(this.swigCPtr);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
			set
			{
				AppUtilPINVOKE.AppOptionsInternal_StorageBucket_set(this.swigCPtr, value);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000105 RID: 261 RVA: 0x000056A0 File Offset: 0x000038A0
		// (set) Token: 0x06000104 RID: 260 RVA: 0x00005674 File Offset: 0x00003874
		public string ProjectId
		{
			get
			{
				string result = AppUtilPINVOKE.AppOptionsInternal_ProjectId_get(this.swigCPtr);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
			set
			{
				AppUtilPINVOKE.AppOptionsInternal_ProjectId_set(this.swigCPtr, value);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000107 RID: 263 RVA: 0x000056FC File Offset: 0x000038FC
		// (set) Token: 0x06000106 RID: 262 RVA: 0x000056D0 File Offset: 0x000038D0
		public string PackageName
		{
			get
			{
				string result = AppUtilPINVOKE.AppOptionsInternal_PackageName_get(this.swigCPtr);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
			set
			{
				AppUtilPINVOKE.AppOptionsInternal_PackageName_set(this.swigCPtr, value);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
			}
		}

		// Token: 0x0400003E RID: 62
		private HandleRef swigCPtr;

		// Token: 0x0400003F RID: 63
		private bool swigCMemOwn;
	}
}
