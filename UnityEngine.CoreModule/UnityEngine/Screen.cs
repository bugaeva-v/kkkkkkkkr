using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	// Token: 0x0200012B RID: 299
	[NativeHeader("Runtime/Graphics/ScreenManager.h")]
	[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
	[NativeHeader("Runtime/Graphics/WindowLayout.h")]
	[StaticAccessor("GetScreenManager()", StaticAccessorType.Dot)]
	public sealed class Screen
	{
		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000836 RID: 2102
		public static extern int width { [NativeMethod(Name = "GetWidth", IsThreadSafe = true)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000837 RID: 2103
		public static extern int height { [NativeMethod(Name = "GetHeight", IsThreadSafe = true)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000838 RID: 2104
		public static extern float dpi { [NativeName("GetDPI")] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000839 RID: 2105
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void RequestOrientation(ScreenOrientation orient);

		// Token: 0x0600083A RID: 2106
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ScreenOrientation GetScreenOrientation();

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x0000C5B4 File Offset: 0x0000A7B4
		// (set) Token: 0x0600083C RID: 2108 RVA: 0x0000C5CC File Offset: 0x0000A7CC
		public static ScreenOrientation orientation
		{
			get
			{
				return Screen.GetScreenOrientation();
			}
			set
			{
				bool flag = value == ScreenOrientation.Unknown;
				if (flag)
				{
					Debug.Log("ScreenOrientation.Unknown is deprecated. Please use ScreenOrientation.AutoRotation");
					value = ScreenOrientation.AutoRotation;
				}
				Screen.RequestOrientation(value);
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600083D RID: 2109
		// (set) Token: 0x0600083E RID: 2110
		[NativeProperty("ScreenTimeout")]
		public static extern int sleepTimeout { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x0600083F RID: 2111
		[NativeName("GetIsOrientationEnabled")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool IsOrientationEnabled(EnabledOrientation orient);

		// Token: 0x06000840 RID: 2112
		[NativeName("SetIsOrientationEnabled")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetOrientationEnabled(EnabledOrientation orient, bool enabled);

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x0000C5FC File Offset: 0x0000A7FC
		// (set) Token: 0x06000842 RID: 2114 RVA: 0x0000C614 File Offset: 0x0000A814
		public static bool autorotateToPortrait
		{
			get
			{
				return Screen.IsOrientationEnabled(EnabledOrientation.kAutorotateToPortrait);
			}
			set
			{
				Screen.SetOrientationEnabled(EnabledOrientation.kAutorotateToPortrait, value);
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x0000C620 File Offset: 0x0000A820
		// (set) Token: 0x06000844 RID: 2116 RVA: 0x0000C638 File Offset: 0x0000A838
		public static bool autorotateToPortraitUpsideDown
		{
			get
			{
				return Screen.IsOrientationEnabled(EnabledOrientation.kAutorotateToPortraitUpsideDown);
			}
			set
			{
				Screen.SetOrientationEnabled(EnabledOrientation.kAutorotateToPortraitUpsideDown, value);
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x0000C644 File Offset: 0x0000A844
		// (set) Token: 0x06000846 RID: 2118 RVA: 0x0000C65C File Offset: 0x0000A85C
		public static bool autorotateToLandscapeLeft
		{
			get
			{
				return Screen.IsOrientationEnabled(EnabledOrientation.kAutorotateToLandscapeLeft);
			}
			set
			{
				Screen.SetOrientationEnabled(EnabledOrientation.kAutorotateToLandscapeLeft, value);
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x0000C668 File Offset: 0x0000A868
		// (set) Token: 0x06000848 RID: 2120 RVA: 0x0000C680 File Offset: 0x0000A880
		public static bool autorotateToLandscapeRight
		{
			get
			{
				return Screen.IsOrientationEnabled(EnabledOrientation.kAutorotateToLandscapeRight);
			}
			set
			{
				Screen.SetOrientationEnabled(EnabledOrientation.kAutorotateToLandscapeRight, value);
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x0000C68C File Offset: 0x0000A88C
		public static Resolution currentResolution
		{
			get
			{
				Resolution result;
				Screen.get_currentResolution_Injected(out result);
				return result;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x0600084A RID: 2122
		// (set) Token: 0x0600084B RID: 2123
		public static extern bool fullScreen { [NativeName("IsFullscreen")] [MethodImpl(MethodImplOptions.InternalCall)] get; [NativeName("RequestSetFullscreenFromScript")] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x0600084C RID: 2124
		// (set) Token: 0x0600084D RID: 2125
		public static extern FullScreenMode fullScreenMode { [NativeName("GetFullscreenMode")] [MethodImpl(MethodImplOptions.InternalCall)] get; [NativeName("RequestSetFullscreenModeFromScript")] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x0000C6A4 File Offset: 0x0000A8A4
		public static Rect safeArea
		{
			get
			{
				Rect result;
				Screen.get_safeArea_Injected(out result);
				return result;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x0600084F RID: 2127
		public static extern Rect[] cutouts { [FreeFunction("ScreenScripting::GetCutouts")] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000850 RID: 2128
		[NativeName("RequestResolution")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetResolution(int width, int height, FullScreenMode fullscreenMode, [UnityEngine.Internal.DefaultValue("0")] int preferredRefreshRate);

		// Token: 0x06000851 RID: 2129 RVA: 0x0000C6B9 File Offset: 0x0000A8B9
		public static void SetResolution(int width, int height, FullScreenMode fullscreenMode)
		{
			Screen.SetResolution(width, height, fullscreenMode, 0);
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x0000C6C6 File Offset: 0x0000A8C6
		public static void SetResolution(int width, int height, bool fullscreen, [UnityEngine.Internal.DefaultValue("0")] int preferredRefreshRate)
		{
			Screen.SetResolution(width, height, fullscreen ? FullScreenMode.FullScreenWindow : FullScreenMode.Windowed, preferredRefreshRate);
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x0000C6D9 File Offset: 0x0000A8D9
		public static void SetResolution(int width, int height, bool fullscreen)
		{
			Screen.SetResolution(width, height, fullscreen, 0);
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000854 RID: 2132 RVA: 0x0000C6E8 File Offset: 0x0000A8E8
		public static Vector2Int mainWindowPosition
		{
			get
			{
				return Screen.GetMainWindowPosition();
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x0000C700 File Offset: 0x0000A900
		public static DisplayInfo mainWindowDisplayInfo
		{
			get
			{
				return Screen.GetMainWindowDisplayInfo();
			}
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x0000C718 File Offset: 0x0000A918
		public static void GetDisplayLayout(List<DisplayInfo> displayLayout)
		{
			bool flag = displayLayout == null;
			if (flag)
			{
				throw new ArgumentNullException();
			}
			Screen.GetDisplayLayoutImpl(displayLayout);
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x0000C73C File Offset: 0x0000A93C
		public static AsyncOperation MoveMainWindowTo(in DisplayInfo display, Vector2Int position)
		{
			return Screen.MoveMainWindowImpl(display, position);
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x0000C758 File Offset: 0x0000A958
		[FreeFunction("GetMainWindowPosition")]
		private static Vector2Int GetMainWindowPosition()
		{
			Vector2Int result;
			Screen.GetMainWindowPosition_Injected(out result);
			return result;
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x0000C770 File Offset: 0x0000A970
		[FreeFunction("GetMainWindowDisplayInfo")]
		private static DisplayInfo GetMainWindowDisplayInfo()
		{
			DisplayInfo result;
			Screen.GetMainWindowDisplayInfo_Injected(out result);
			return result;
		}

		// Token: 0x0600085A RID: 2138
		[FreeFunction("GetDisplayLayout")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetDisplayLayoutImpl(List<DisplayInfo> displayLayout);

		// Token: 0x0600085B RID: 2139 RVA: 0x0000C785 File Offset: 0x0000A985
		[FreeFunction("MoveMainWindow")]
		private static AsyncOperation MoveMainWindowImpl(in DisplayInfo display, Vector2Int position)
		{
			return Screen.MoveMainWindowImpl_Injected(display, ref position);
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x0600085C RID: 2140
		public static extern Resolution[] resolutions { [FreeFunction("ScreenScripting::GetResolutions")] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x0600085D RID: 2141
		// (set) Token: 0x0600085E RID: 2142
		public static extern float brightness { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x0000C790 File Offset: 0x0000A990
		// (set) Token: 0x06000860 RID: 2144 RVA: 0x0000C7AC File Offset: 0x0000A9AC
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Cursor.lockState and Cursor.visible instead.", false)]
		public static bool lockCursor
		{
			get
			{
				return CursorLockMode.Locked == Cursor.lockState;
			}
			set
			{
				if (value)
				{
					Cursor.visible = false;
					Cursor.lockState = CursorLockMode.Locked;
				}
				else
				{
					Cursor.lockState = CursorLockMode.None;
					Cursor.visible = true;
				}
			}
		}

		// Token: 0x06000862 RID: 2146
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void get_currentResolution_Injected(out Resolution ret);

		// Token: 0x06000863 RID: 2147
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void get_safeArea_Injected(out Rect ret);

		// Token: 0x06000864 RID: 2148
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetMainWindowPosition_Injected(out Vector2Int ret);

		// Token: 0x06000865 RID: 2149
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetMainWindowDisplayInfo_Injected(out DisplayInfo ret);

		// Token: 0x06000866 RID: 2150
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern AsyncOperation MoveMainWindowImpl_Injected(in DisplayInfo display, ref Vector2Int position);
	}
}
