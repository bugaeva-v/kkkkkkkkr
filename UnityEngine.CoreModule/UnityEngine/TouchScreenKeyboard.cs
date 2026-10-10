using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	// Token: 0x02000253 RID: 595
	[NativeHeader("Runtime/Input/KeyboardOnScreen.h")]
	[NativeConditional("ENABLE_ONSCREEN_KEYBOARD")]
	[NativeHeader("Runtime/Export/TouchScreenKeyboard/TouchScreenKeyboard.bindings.h")]
	public class TouchScreenKeyboard
	{
		// Token: 0x060019C0 RID: 6592
		[FreeFunction("TouchScreenKeyboard_Destroy", IsThreadSafe = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Destroy(IntPtr ptr);

		// Token: 0x060019C1 RID: 6593 RVA: 0x000299E8 File Offset: 0x00027BE8
		private void Destroy()
		{
			bool flag = this.m_Ptr != IntPtr.Zero;
			if (flag)
			{
				TouchScreenKeyboard.Internal_Destroy(this.m_Ptr);
				this.m_Ptr = IntPtr.Zero;
			}
			GC.SuppressFinalize(this);
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x00029A2C File Offset: 0x00027C2C
		~TouchScreenKeyboard()
		{
			this.Destroy();
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x00029A5C File Offset: 0x00027C5C
		public TouchScreenKeyboard(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit)
		{
			TouchScreenKeyboard_InternalConstructorHelperArguments touchScreenKeyboard_InternalConstructorHelperArguments = default(TouchScreenKeyboard_InternalConstructorHelperArguments);
			touchScreenKeyboard_InternalConstructorHelperArguments.keyboardType = Convert.ToUInt32(keyboardType);
			touchScreenKeyboard_InternalConstructorHelperArguments.autocorrection = Convert.ToUInt32(autocorrection);
			touchScreenKeyboard_InternalConstructorHelperArguments.multiline = Convert.ToUInt32(multiline);
			touchScreenKeyboard_InternalConstructorHelperArguments.secure = Convert.ToUInt32(secure);
			touchScreenKeyboard_InternalConstructorHelperArguments.alert = Convert.ToUInt32(alert);
			touchScreenKeyboard_InternalConstructorHelperArguments.characterLimit = characterLimit;
			this.m_Ptr = TouchScreenKeyboard.TouchScreenKeyboard_InternalConstructorHelper(ref touchScreenKeyboard_InternalConstructorHelperArguments, text, textPlaceholder);
		}

		// Token: 0x060019C4 RID: 6596
		[FreeFunction("TouchScreenKeyboard_InternalConstructorHelper")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr TouchScreenKeyboard_InternalConstructorHelper(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder);

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x060019C5 RID: 6597 RVA: 0x00029ADC File Offset: 0x00027CDC
		public static bool isSupported
		{
			get
			{
				RuntimePlatform platform = Application.platform;
				RuntimePlatform runtimePlatform = platform;
				RuntimePlatform runtimePlatform2 = runtimePlatform;
				if (runtimePlatform2 <= RuntimePlatform.Android)
				{
					if (runtimePlatform2 != RuntimePlatform.IPhonePlayer && runtimePlatform2 != RuntimePlatform.Android)
					{
						goto IL_5C;
					}
				}
				else if (runtimePlatform2 - RuntimePlatform.MetroPlayerX86 > 2 && runtimePlatform2 != RuntimePlatform.PS4)
				{
					switch (runtimePlatform2)
					{
					case RuntimePlatform.tvOS:
					case RuntimePlatform.Switch:
					case RuntimePlatform.Stadia:
					case RuntimePlatform.GameCoreXboxSeries:
					case RuntimePlatform.GameCoreXboxOne:
					case RuntimePlatform.PS5:
						break;
					case RuntimePlatform.Lumin:
					case RuntimePlatform.CloudRendering:
						goto IL_5C;
					default:
						goto IL_5C;
					}
				}
				return true;
				IL_5C:
				return false;
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x060019C6 RID: 6598 RVA: 0x00029B4A File Offset: 0x00027D4A
		// (set) Token: 0x060019C7 RID: 6599 RVA: 0x00029B51 File Offset: 0x00027D51
		internal static bool disableInPlaceEditing { get; set; }

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x060019C8 RID: 6600 RVA: 0x00029B5C File Offset: 0x00027D5C
		public static bool isInPlaceEditingAllowed
		{
			get
			{
				bool disableInPlaceEditing = TouchScreenKeyboard.disableInPlaceEditing;
				return disableInPlaceEditing && false;
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x060019C9 RID: 6601 RVA: 0x00029B7C File Offset: 0x00027D7C
		internal static bool isRequiredToForceOpen
		{
			get
			{
				return TouchScreenKeyboard.IsRequiredToForceOpen();
			}
		}

		// Token: 0x060019CA RID: 6602
		[FreeFunction("TouchScreenKeyboard_IsRequiredToForceOpen")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool IsRequiredToForceOpen();

		// Token: 0x060019CB RID: 6603 RVA: 0x00029B94 File Offset: 0x00027D94
		public static TouchScreenKeyboard Open(string text, [DefaultValue("TouchScreenKeyboardType.Default")] TouchScreenKeyboardType keyboardType, [DefaultValue("true")] bool autocorrection, [DefaultValue("false")] bool multiline, [DefaultValue("false")] bool secure, [DefaultValue("false")] bool alert, [DefaultValue("\"\"")] string textPlaceholder, [DefaultValue("0")] int characterLimit)
		{
			return new TouchScreenKeyboard(text, keyboardType, autocorrection, multiline, secure, alert, textPlaceholder, characterLimit);
		}

		// Token: 0x060019CC RID: 6604 RVA: 0x00029BB8 File Offset: 0x00027DB8
		[ExcludeFromDocs]
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder)
		{
			int characterLimit = 0;
			return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert, textPlaceholder, characterLimit);
		}

		// Token: 0x060019CD RID: 6605 RVA: 0x00029BDC File Offset: 0x00027DDC
		[ExcludeFromDocs]
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert)
		{
			int characterLimit = 0;
			string textPlaceholder = "";
			return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert, textPlaceholder, characterLimit);
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x00029C08 File Offset: 0x00027E08
		[ExcludeFromDocs]
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure)
		{
			int characterLimit = 0;
			string textPlaceholder = "";
			bool alert = false;
			return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert, textPlaceholder, characterLimit);
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x00029C34 File Offset: 0x00027E34
		[ExcludeFromDocs]
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline)
		{
			int characterLimit = 0;
			string textPlaceholder = "";
			bool alert = false;
			bool secure = false;
			return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert, textPlaceholder, characterLimit);
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x00029C64 File Offset: 0x00027E64
		[ExcludeFromDocs]
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection)
		{
			int characterLimit = 0;
			string textPlaceholder = "";
			bool alert = false;
			bool secure = false;
			bool multiline = false;
			return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert, textPlaceholder, characterLimit);
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x00029C98 File Offset: 0x00027E98
		[ExcludeFromDocs]
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType)
		{
			int characterLimit = 0;
			string textPlaceholder = "";
			bool alert = false;
			bool secure = false;
			bool multiline = false;
			bool autocorrection = true;
			return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert, textPlaceholder, characterLimit);
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x00029CD0 File Offset: 0x00027ED0
		[ExcludeFromDocs]
		public static TouchScreenKeyboard Open(string text)
		{
			int characterLimit = 0;
			string textPlaceholder = "";
			bool alert = false;
			bool secure = false;
			bool multiline = false;
			bool autocorrection = true;
			TouchScreenKeyboardType keyboardType = TouchScreenKeyboardType.Default;
			return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert, textPlaceholder, characterLimit);
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x060019D3 RID: 6611
		// (set) Token: 0x060019D4 RID: 6612
		public extern string text { [NativeName("GetText")] [MethodImpl(MethodImplOptions.InternalCall)] get; [NativeName("SetText")] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x060019D5 RID: 6613
		// (set) Token: 0x060019D6 RID: 6614
		public static extern bool hideInput { [NativeName("IsInputHidden")] [MethodImpl(MethodImplOptions.InternalCall)] get; [NativeName("SetInputHidden")] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x060019D7 RID: 6615
		// (set) Token: 0x060019D8 RID: 6616
		public extern bool active { [NativeName("IsActive")] [MethodImpl(MethodImplOptions.InternalCall)] get; [NativeName("SetActive")] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060019D9 RID: 6617
		[FreeFunction("TouchScreenKeyboard_GetDone")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool GetDone(IntPtr ptr);

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x060019DA RID: 6618 RVA: 0x00029D0C File Offset: 0x00027F0C
		[Obsolete("Property done is deprecated, use status instead")]
		public bool done
		{
			get
			{
				return TouchScreenKeyboard.GetDone(this.m_Ptr);
			}
		}

		// Token: 0x060019DB RID: 6619
		[FreeFunction("TouchScreenKeyboard_GetWasCanceled")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool GetWasCanceled(IntPtr ptr);

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x060019DC RID: 6620 RVA: 0x00029D2C File Offset: 0x00027F2C
		[Obsolete("Property wasCanceled is deprecated, use status instead.")]
		public bool wasCanceled
		{
			get
			{
				return TouchScreenKeyboard.GetWasCanceled(this.m_Ptr);
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x060019DD RID: 6621
		public extern TouchScreenKeyboard.Status status { [NativeName("GetKeyboardStatus")] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x060019DE RID: 6622
		// (set) Token: 0x060019DF RID: 6623
		public extern int characterLimit { [NativeName("GetCharacterLimit")] [MethodImpl(MethodImplOptions.InternalCall)] get; [NativeName("SetCharacterLimit")] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x060019E0 RID: 6624
		public extern bool canGetSelection { [NativeName("CanGetSelection")] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x060019E1 RID: 6625
		public extern bool canSetSelection { [NativeName("CanSetSelection")] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x060019E2 RID: 6626 RVA: 0x00029D4C File Offset: 0x00027F4C
		// (set) Token: 0x060019E3 RID: 6627 RVA: 0x00029D74 File Offset: 0x00027F74
		public RangeInt selection
		{
			get
			{
				RangeInt result;
				TouchScreenKeyboard.GetSelection(out result.start, out result.length);
				return result;
			}
			set
			{
				bool flag = value.start < 0 || value.length < 0 || value.start + value.length > this.text.Length;
				if (flag)
				{
					throw new ArgumentOutOfRangeException("selection", "Selection is out of range.");
				}
				TouchScreenKeyboard.SetSelection(value.start, value.length);
			}
		}

		// Token: 0x060019E4 RID: 6628
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetSelection(out int start, out int length);

		// Token: 0x060019E5 RID: 6629
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetSelection(int start, int length);

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x060019E6 RID: 6630
		public extern TouchScreenKeyboardType type { [NativeName("GetKeyboardType")] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x060019E7 RID: 6631 RVA: 0x00029DD8 File Offset: 0x00027FD8
		// (set) Token: 0x060019E8 RID: 6632 RVA: 0x00004563 File Offset: 0x00002763
		public int targetDisplay
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x060019E9 RID: 6633 RVA: 0x00029DEC File Offset: 0x00027FEC
		[NativeConditional("ENABLE_ONSCREEN_KEYBOARD", "RectT<float>()")]
		public static Rect area
		{
			[NativeName("GetRect")]
			get
			{
				Rect result;
				TouchScreenKeyboard.get_area_Injected(out result);
				return result;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x060019EA RID: 6634
		public static extern bool visible { [NativeName("IsVisible")] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060019EB RID: 6635
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void get_area_Injected(out Rect ret);

		// Token: 0x0400087F RID: 2175
		[NonSerialized]
		internal IntPtr m_Ptr;

		// Token: 0x02000254 RID: 596
		public enum Status
		{
			// Token: 0x04000882 RID: 2178
			Visible,
			// Token: 0x04000883 RID: 2179
			Done,
			// Token: 0x04000884 RID: 2180
			Canceled,
			// Token: 0x04000885 RID: 2181
			LostFocus
		}

		// Token: 0x02000255 RID: 597
		public class Android
		{
			// Token: 0x17000533 RID: 1331
			// (get) Token: 0x060019EC RID: 6636 RVA: 0x00029E04 File Offset: 0x00028004
			// (set) Token: 0x060019ED RID: 6637 RVA: 0x00029E1B File Offset: 0x0002801B
			[Obsolete("TouchScreenKeyboard.Android.closeKeyboardOnOutsideTap is obsolete. Use TouchScreenKeyboard.Android.consumesOutsideTouches instead (UnityUpgradable) -> UnityEngine.TouchScreenKeyboard/Android.consumesOutsideTouches")]
			public static bool closeKeyboardOnOutsideTap
			{
				get
				{
					return TouchScreenKeyboard.Android.consumesOutsideTouches;
				}
				set
				{
					TouchScreenKeyboard.Android.consumesOutsideTouches = value;
				}
			}

			// Token: 0x17000534 RID: 1332
			// (get) Token: 0x060019EF RID: 6639 RVA: 0x00029E30 File Offset: 0x00028030
			// (set) Token: 0x060019EE RID: 6638 RVA: 0x00029E25 File Offset: 0x00028025
			public static bool consumesOutsideTouches
			{
				get
				{
					return TouchScreenKeyboard.Android.TouchScreenKeyboard_GetAndroidKeyboardConsumesOutsideTouches();
				}
				set
				{
					TouchScreenKeyboard.Android.TouchScreenKeyboard_SetAndroidKeyboardConsumesOutsideTouches(value);
				}
			}

			// Token: 0x060019F0 RID: 6640
			[NativeConditional("PLATFORM_ANDROID")]
			[FreeFunction("TouchScreenKeyboard_SetAndroidKeyboardConsumesOutsideTouches")]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void TouchScreenKeyboard_SetAndroidKeyboardConsumesOutsideTouches(bool enable);

			// Token: 0x060019F1 RID: 6641
			[NativeConditional("PLATFORM_ANDROID")]
			[FreeFunction("TouchScreenKeyboard_GetAndroidKeyboardConsumesOutsideTouches")]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern bool TouchScreenKeyboard_GetAndroidKeyboardConsumesOutsideTouches();
		}
	}
}
