using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x02000290 RID: 656
	public sealed class DictationRecognizer : IDisposable
	{
		// Token: 0x06001C59 RID: 7257
		[NativeHeader("PlatformDependent/Win/Bindings/SpeechBindings.h")]
		[NativeThrows]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr Create(object self, ConfidenceLevel minimumConfidence, DictationTopicConstraint topicConstraint);

		// Token: 0x06001C5A RID: 7258
		[NativeThrows]
		[NativeHeader("PlatformDependent/Win/Bindings/SpeechBindings.h")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Start(IntPtr self);

		// Token: 0x06001C5B RID: 7259
		[NativeHeader("PlatformDependent/Win/Bindings/SpeechBindings.h")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Stop(IntPtr self);

		// Token: 0x06001C5C RID: 7260
		[NativeHeader("PlatformDependent/Win/Bindings/SpeechBindings.h")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Destroy(IntPtr self);

		// Token: 0x06001C5D RID: 7261
		[ThreadSafe]
		[NativeHeader("PlatformDependent/Win/Bindings/SpeechBindings.h")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void DestroyThreaded(IntPtr self);

		// Token: 0x06001C5E RID: 7262
		[NativeHeader("PlatformDependent/Win/Bindings/SpeechBindings.h")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern SpeechSystemStatus GetStatus(IntPtr self);

		// Token: 0x06001C5F RID: 7263
		[NativeHeader("PlatformDependent/Win/Bindings/SpeechBindings.h")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float GetAutoSilenceTimeoutSeconds(IntPtr self);

		// Token: 0x06001C60 RID: 7264
		[NativeHeader("PlatformDependent/Win/Bindings/SpeechBindings.h")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetAutoSilenceTimeoutSeconds(IntPtr self, float value);

		// Token: 0x06001C61 RID: 7265
		[NativeHeader("PlatformDependent/Win/Bindings/SpeechBindings.h")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float GetInitialSilenceTimeoutSeconds(IntPtr self);

		// Token: 0x06001C62 RID: 7266
		[NativeHeader("PlatformDependent/Win/Bindings/SpeechBindings.h")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetInitialSilenceTimeoutSeconds(IntPtr self, float value);

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x06001C63 RID: 7267 RVA: 0x0002D7FC File Offset: 0x0002B9FC
		// (remove) Token: 0x06001C64 RID: 7268 RVA: 0x0002D834 File Offset: 0x0002BA34
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event DictationRecognizer.DictationHypothesisDelegate DictationHypothesis;

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x06001C65 RID: 7269 RVA: 0x0002D86C File Offset: 0x0002BA6C
		// (remove) Token: 0x06001C66 RID: 7270 RVA: 0x0002D8A4 File Offset: 0x0002BAA4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event DictationRecognizer.DictationResultDelegate DictationResult;

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x06001C67 RID: 7271 RVA: 0x0002D8DC File Offset: 0x0002BADC
		// (remove) Token: 0x06001C68 RID: 7272 RVA: 0x0002D914 File Offset: 0x0002BB14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event DictationRecognizer.DictationCompletedDelegate DictationComplete;

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x06001C69 RID: 7273 RVA: 0x0002D94C File Offset: 0x0002BB4C
		// (remove) Token: 0x06001C6A RID: 7274 RVA: 0x0002D984 File Offset: 0x0002BB84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event DictationRecognizer.DictationErrorHandler DictationError;

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06001C6B RID: 7275 RVA: 0x0002D9BC File Offset: 0x0002BBBC
		public SpeechSystemStatus Status
		{
			get
			{
				return (this.m_Recognizer != IntPtr.Zero) ? DictationRecognizer.GetStatus(this.m_Recognizer) : SpeechSystemStatus.Stopped;
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06001C6C RID: 7276 RVA: 0x0002D9F0 File Offset: 0x0002BBF0
		// (set) Token: 0x06001C6D RID: 7277 RVA: 0x0002DA2C File Offset: 0x0002BC2C
		public float AutoSilenceTimeoutSeconds
		{
			get
			{
				bool flag = this.m_Recognizer == IntPtr.Zero;
				float result;
				if (flag)
				{
					result = 0f;
				}
				else
				{
					result = DictationRecognizer.GetAutoSilenceTimeoutSeconds(this.m_Recognizer);
				}
				return result;
			}
			set
			{
				bool flag = this.m_Recognizer == IntPtr.Zero;
				if (!flag)
				{
					DictationRecognizer.SetAutoSilenceTimeoutSeconds(this.m_Recognizer, value);
				}
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06001C6E RID: 7278 RVA: 0x0002DA60 File Offset: 0x0002BC60
		// (set) Token: 0x06001C6F RID: 7279 RVA: 0x0002DA9C File Offset: 0x0002BC9C
		public float InitialSilenceTimeoutSeconds
		{
			get
			{
				bool flag = this.m_Recognizer == IntPtr.Zero;
				float result;
				if (flag)
				{
					result = 0f;
				}
				else
				{
					result = DictationRecognizer.GetInitialSilenceTimeoutSeconds(this.m_Recognizer);
				}
				return result;
			}
			set
			{
				bool flag = this.m_Recognizer == IntPtr.Zero;
				if (!flag)
				{
					DictationRecognizer.SetInitialSilenceTimeoutSeconds(this.m_Recognizer, value);
				}
			}
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x0002DACD File Offset: 0x0002BCCD
		public DictationRecognizer() : this(ConfidenceLevel.Medium, DictationTopicConstraint.Dictation)
		{
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x0002DAD9 File Offset: 0x0002BCD9
		public DictationRecognizer(ConfidenceLevel confidenceLevel) : this(confidenceLevel, DictationTopicConstraint.Dictation)
		{
		}

		// Token: 0x06001C72 RID: 7282 RVA: 0x0002DAE5 File Offset: 0x0002BCE5
		public DictationRecognizer(DictationTopicConstraint topic) : this(ConfidenceLevel.Medium, topic)
		{
		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x0002DAF1 File Offset: 0x0002BCF1
		public DictationRecognizer(ConfidenceLevel minimumConfidence, DictationTopicConstraint topic)
		{
			this.m_Recognizer = DictationRecognizer.Create(this, minimumConfidence, topic);
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x0002DB0C File Offset: 0x0002BD0C
		protected override void Finalize()
		{
			try
			{
				bool flag = this.m_Recognizer != IntPtr.Zero;
				if (flag)
				{
					DictationRecognizer.DestroyThreaded(this.m_Recognizer);
					this.m_Recognizer = IntPtr.Zero;
					GC.SuppressFinalize(this);
				}
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x0002DB6C File Offset: 0x0002BD6C
		public void Start()
		{
			bool flag = this.m_Recognizer == IntPtr.Zero;
			if (!flag)
			{
				DictationRecognizer.Start(this.m_Recognizer);
			}
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x0002DB9C File Offset: 0x0002BD9C
		public void Stop()
		{
			bool flag = this.m_Recognizer == IntPtr.Zero;
			if (!flag)
			{
				DictationRecognizer.Stop(this.m_Recognizer);
			}
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x0002DBCC File Offset: 0x0002BDCC
		public void Dispose()
		{
			bool flag = this.m_Recognizer != IntPtr.Zero;
			if (flag)
			{
				DictationRecognizer.Destroy(this.m_Recognizer);
				this.m_Recognizer = IntPtr.Zero;
			}
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x0002DC10 File Offset: 0x0002BE10
		[RequiredByNativeCode]
		private void DictationRecognizer_InvokeHypothesisGeneratedEvent(string keyword)
		{
			DictationRecognizer.DictationHypothesisDelegate dictationHypothesis = this.DictationHypothesis;
			bool flag = dictationHypothesis != null;
			if (flag)
			{
				dictationHypothesis(keyword);
			}
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x0002DC38 File Offset: 0x0002BE38
		[RequiredByNativeCode]
		private void DictationRecognizer_InvokeResultGeneratedEvent(string keyword, ConfidenceLevel minimumConfidence)
		{
			DictationRecognizer.DictationResultDelegate dictationResult = this.DictationResult;
			bool flag = dictationResult != null;
			if (flag)
			{
				dictationResult(keyword, minimumConfidence);
			}
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x0002DC60 File Offset: 0x0002BE60
		[RequiredByNativeCode]
		private void DictationRecognizer_InvokeCompletedEvent(DictationCompletionCause cause)
		{
			DictationRecognizer.DictationCompletedDelegate dictationComplete = this.DictationComplete;
			bool flag = dictationComplete != null;
			if (flag)
			{
				dictationComplete(cause);
			}
		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x0002DC88 File Offset: 0x0002BE88
		[RequiredByNativeCode]
		private void DictationRecognizer_InvokeErrorEvent(string error, int hresult)
		{
			DictationRecognizer.DictationErrorHandler dictationError = this.DictationError;
			bool flag = dictationError != null;
			if (flag)
			{
				dictationError(error, hresult);
			}
		}

		// Token: 0x0400092E RID: 2350
		private IntPtr m_Recognizer;

		// Token: 0x02000291 RID: 657
		// (Invoke) Token: 0x06001C7D RID: 7293
		public delegate void DictationHypothesisDelegate(string text);

		// Token: 0x02000292 RID: 658
		// (Invoke) Token: 0x06001C81 RID: 7297
		public delegate void DictationResultDelegate(string text, ConfidenceLevel confidence);

		// Token: 0x02000293 RID: 659
		// (Invoke) Token: 0x06001C85 RID: 7301
		public delegate void DictationCompletedDelegate(DictationCompletionCause cause);

		// Token: 0x02000294 RID: 660
		// (Invoke) Token: 0x06001C89 RID: 7305
		public delegate void DictationErrorHandler(string error, int hresult);
	}
}
