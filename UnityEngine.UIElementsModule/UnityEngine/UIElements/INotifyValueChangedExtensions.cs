using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200014C RID: 332
	public static class INotifyValueChangedExtensions
	{
		// Token: 0x06000AC5 RID: 2757 RVA: 0x0002B688 File Offset: 0x00029888
		public static bool RegisterValueChangedCallback<T>(this INotifyValueChanged<T> control, EventCallback<ChangeEvent<T>> callback)
		{
			CallbackEventHandler callbackEventHandler = control as CallbackEventHandler;
			bool flag = callbackEventHandler != null;
			bool result;
			if (flag)
			{
				callbackEventHandler.RegisterCallback<ChangeEvent<T>>(callback, TrickleDown.NoTrickleDown);
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x0002B6B8 File Offset: 0x000298B8
		public static bool UnregisterValueChangedCallback<T>(this INotifyValueChanged<T> control, EventCallback<ChangeEvent<T>> callback)
		{
			CallbackEventHandler callbackEventHandler = control as CallbackEventHandler;
			bool flag = callbackEventHandler != null;
			bool result;
			if (flag)
			{
				callbackEventHandler.UnregisterCallback<ChangeEvent<T>>(callback, TrickleDown.NoTrickleDown);
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}
	}
}
