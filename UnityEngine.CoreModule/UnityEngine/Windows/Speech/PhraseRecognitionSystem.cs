using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x0200028B RID: 651
	public static class PhraseRecognitionSystem
	{
		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06001C32 RID: 7218
		public static extern bool isSupported { [ThreadSafe] [NativeHeader("PlatformDependent/Win/Bindings/SpeechBindings.h")] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001C33 RID: 7219
		public static extern SpeechSystemStatus Status { [NativeHeader("PlatformDependent/Win/Bindings/SpeechBindings.h")] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06001C34 RID: 7220
		[NativeHeader("PlatformDependent/Win/Bindings/SpeechBindings.h")]
		[NativeThrows]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Restart();

		// Token: 0x06001C35 RID: 7221
		[NativeHeader("PlatformDependent/Win/Bindings/SpeechBindings.h")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Shutdown();

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x06001C36 RID: 7222 RVA: 0x0002D43C File Offset: 0x0002B63C
		// (remove) Token: 0x06001C37 RID: 7223 RVA: 0x0002D470 File Offset: 0x0002B670
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event PhraseRecognitionSystem.ErrorDelegate OnError;

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x06001C38 RID: 7224 RVA: 0x0002D4A4 File Offset: 0x0002B6A4
		// (remove) Token: 0x06001C39 RID: 7225 RVA: 0x0002D4D8 File Offset: 0x0002B6D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event PhraseRecognitionSystem.StatusDelegate OnStatusChanged;

		// Token: 0x06001C3A RID: 7226 RVA: 0x0002D50C File Offset: 0x0002B70C
		[RequiredByNativeCode]
		private static void PhraseRecognitionSystem_InvokeErrorEvent(SpeechError errorCode)
		{
			PhraseRecognitionSystem.ErrorDelegate onError = PhraseRecognitionSystem.OnError;
			bool flag = onError != null;
			if (flag)
			{
				onError(errorCode);
			}
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x0002D530 File Offset: 0x0002B730
		[RequiredByNativeCode]
		private static void PhraseRecognitionSystem_InvokeStatusChangedEvent(SpeechSystemStatus status)
		{
			PhraseRecognitionSystem.StatusDelegate onStatusChanged = PhraseRecognitionSystem.OnStatusChanged;
			bool flag = onStatusChanged != null;
			if (flag)
			{
				onStatusChanged(status);
			}
		}

		// Token: 0x0200028C RID: 652
		// (Invoke) Token: 0x06001C3D RID: 7229
		public delegate void ErrorDelegate(SpeechError errorCode);

		// Token: 0x0200028D RID: 653
		// (Invoke) Token: 0x06001C41 RID: 7233
		public delegate void StatusDelegate(SpeechSystemStatus status);
	}
}
