using System;
using System.Reflection;

namespace Firebase.Platform
{
	// Token: 0x02000015 RID: 21
	internal sealed class FirebaseEditorDispatcher
	{
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00003230 File Offset: 0x00001430
		private static Type EditorApplicationType
		{
			get
			{
				return Type.GetType("UnityEditor.EditorApplication, UnityEditor");
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00003250 File Offset: 0x00001450
		public static bool EditorIsPlaying
		{
			get
			{
				Type editorApplicationType = FirebaseEditorDispatcher.EditorApplicationType;
				bool flag = editorApplicationType != null;
				if (flag)
				{
					PropertyInfo property = editorApplicationType.GetProperty("isPlaying");
					bool flag2 = property != null;
					if (flag2)
					{
						return (bool)property.GetValue(null, null);
					}
				}
				return true;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000080 RID: 128 RVA: 0x000032A4 File Offset: 0x000014A4
		public static bool EditorIsPlayingOrWillChangePlaymode
		{
			get
			{
				Type editorApplicationType = FirebaseEditorDispatcher.EditorApplicationType;
				bool flag = editorApplicationType != null;
				if (flag)
				{
					PropertyInfo property = editorApplicationType.GetProperty("isPlayingOrWillChangePlaymode");
					bool flag2 = property != null;
					if (flag2)
					{
						return (bool)property.GetValue(null, null);
					}
				}
				return true;
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000032F8 File Offset: 0x000014F8
		public static void StartEditorUpdate()
		{
			Type editorApplicationType = FirebaseEditorDispatcher.EditorApplicationType;
			bool flag = editorApplicationType != null;
			if (flag)
			{
				FirebaseEditorDispatcher.AddRemoveCallbackToField(editorApplicationType.GetField("update"), new Action(FirebaseEditorDispatcher.Update), null, true, "Firebase failed to register for editor update calls. Most Firebase features will fail, as callbacks will notwork properly. This is caused by being unable to resolvethe necessary fields from the UnityEditor.dll.");
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00003340 File Offset: 0x00001540
		public static void StopEditorUpdate()
		{
			Type editorApplicationType = FirebaseEditorDispatcher.EditorApplicationType;
			bool flag = editorApplicationType != null;
			if (flag)
			{
				FirebaseEditorDispatcher.AddRemoveCallbackToField(editorApplicationType.GetField("update"), new Action(FirebaseEditorDispatcher.Update), null, false, null);
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00003381 File Offset: 0x00001581
		public static void Update()
		{
			FirebaseHandler.DefaultInstance.Update();
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00003390 File Offset: 0x00001590
		public static void ListenToPlayState(bool start = true)
		{
			Type editorApplicationType = FirebaseEditorDispatcher.EditorApplicationType;
			bool flag = editorApplicationType != null;
			if (flag)
			{
				EventInfo @event = editorApplicationType.GetEvent("playModeStateChanged");
				bool flag2 = @event != null;
				if (flag2)
				{
					Type type = Type.GetType("UnityEditor.PlayModeStateChange, UnityEditor");
					bool flag3 = type != null;
					if (flag3)
					{
						MethodInfo methodInfo = typeof(FirebaseEditorDispatcher).GetMethod("PlayModeStateChangedWithArg", BindingFlags.Static | BindingFlags.NonPublic);
						methodInfo = methodInfo.MakeGenericMethod(new Type[]
						{
							type
						});
						Delegate handler = Delegate.CreateDelegate(@event.EventHandlerType, null, methodInfo);
						if (start)
						{
							@event.AddEventHandler(null, handler);
						}
						else
						{
							@event.RemoveEventHandler(null, handler);
						}
						return;
					}
				}
				FirebaseEditorDispatcher.AddRemoveCallbackToField(editorApplicationType.GetField("playmodeStateChanged"), new Action(FirebaseEditorDispatcher.PlayModeStateChanged), null, start, null);
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00003468 File Offset: 0x00001668
		private static void PlayModeStateChanged()
		{
			bool flag = !FirebaseHandler.DefaultInstance.IsPlayMode && FirebaseEditorDispatcher.EditorIsPlaying;
			if (flag)
			{
				FirebaseEditorDispatcher.StopEditorUpdate();
				FirebaseHandler.DefaultInstance.StartMonoBehaviour();
				FirebaseHandler.DefaultInstance.IsPlayMode = true;
			}
			else
			{
				bool flag2 = FirebaseHandler.DefaultInstance.IsPlayMode && !FirebaseEditorDispatcher.EditorIsPlayingOrWillChangePlaymode;
				if (flag2)
				{
					FirebaseHandler.DefaultInstance.StopMonoBehaviour();
					FirebaseEditorDispatcher.StartEditorUpdate();
					FirebaseHandler.DefaultInstance.IsPlayMode = false;
				}
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000034E9 File Offset: 0x000016E9
		private static void PlayModeStateChangedWithArg<T>(T t)
		{
			FirebaseEditorDispatcher.PlayModeStateChanged();
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000034F4 File Offset: 0x000016F4
		private static void AddRemoveCallbackToField(FieldInfo eventField, Action callback, object target = null, bool add = true, string errorMessage = null)
		{
			bool flag = eventField != null;
			if (flag)
			{
				Delegate @delegate = eventField.GetValue(null) as Delegate;
				if (add)
				{
					Delegate delegate2 = Delegate.CreateDelegate(eventField.FieldType, target, callback.Method);
					bool flag2 = @delegate != null;
					if (flag2)
					{
						eventField.SetValue(null, Delegate.Combine(@delegate, delegate2));
					}
					else
					{
						eventField.SetValue(null, delegate2);
					}
					return;
				}
				bool flag3 = @delegate != null;
				if (flag3)
				{
					Delegate value = Delegate.CreateDelegate(eventField.FieldType, target, callback.Method);
					eventField.SetValue(null, Delegate.Remove(@delegate, value));
					return;
				}
			}
			bool flag4 = !string.IsNullOrEmpty(errorMessage);
			if (flag4)
			{
				FirebaseLogger.LogMessage(PlatformLogLevel.Error, errorMessage);
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000035B0 File Offset: 0x000017B0
		public static void Terminate(bool isPlayMode)
		{
			FirebaseEditorDispatcher.ListenToPlayState(false);
			bool flag = !isPlayMode;
			if (flag)
			{
				FirebaseEditorDispatcher.StopEditorUpdate();
			}
		}
	}
}
