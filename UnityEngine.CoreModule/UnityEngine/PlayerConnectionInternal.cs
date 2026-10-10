using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x020001D1 RID: 465
	[NativeHeader("Runtime/Export/PlayerConnection/PlayerConnectionInternal.bindings.h")]
	internal class PlayerConnectionInternal : IPlayerEditorConnectionNative
	{
		// Token: 0x060015B0 RID: 5552 RVA: 0x00022FB8 File Offset: 0x000211B8
		void IPlayerEditorConnectionNative.SendMessage(Guid messageId, byte[] data, int playerId)
		{
			bool flag = messageId == Guid.Empty;
			if (flag)
			{
				throw new ArgumentException("messageId must not be empty");
			}
			PlayerConnectionInternal.SendMessage(messageId.ToString("N"), data, playerId);
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x00022FF8 File Offset: 0x000211F8
		bool IPlayerEditorConnectionNative.TrySendMessage(Guid messageId, byte[] data, int playerId)
		{
			bool flag = messageId == Guid.Empty;
			if (flag)
			{
				throw new ArgumentException("messageId must not be empty");
			}
			return PlayerConnectionInternal.TrySendMessage(messageId.ToString("N"), data, playerId);
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x00023038 File Offset: 0x00021238
		void IPlayerEditorConnectionNative.Poll()
		{
			PlayerConnectionInternal.PollInternal();
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x00023041 File Offset: 0x00021241
		void IPlayerEditorConnectionNative.RegisterInternal(Guid messageId)
		{
			PlayerConnectionInternal.RegisterInternal(messageId.ToString("N"));
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x00023056 File Offset: 0x00021256
		void IPlayerEditorConnectionNative.UnregisterInternal(Guid messageId)
		{
			PlayerConnectionInternal.UnregisterInternal(messageId.ToString("N"));
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x0002306B File Offset: 0x0002126B
		void IPlayerEditorConnectionNative.Initialize()
		{
			PlayerConnectionInternal.Initialize();
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x00023074 File Offset: 0x00021274
		bool IPlayerEditorConnectionNative.IsConnected()
		{
			return PlayerConnectionInternal.IsConnected();
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x0002308B File Offset: 0x0002128B
		void IPlayerEditorConnectionNative.DisconnectAll()
		{
			PlayerConnectionInternal.DisconnectAll();
		}

		// Token: 0x060015B8 RID: 5560
		[FreeFunction("PlayerConnection_Bindings::IsConnected")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool IsConnected();

		// Token: 0x060015B9 RID: 5561
		[FreeFunction("PlayerConnection_Bindings::Initialize")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Initialize();

		// Token: 0x060015BA RID: 5562
		[FreeFunction("PlayerConnection_Bindings::RegisterInternal")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void RegisterInternal(string messageId);

		// Token: 0x060015BB RID: 5563
		[FreeFunction("PlayerConnection_Bindings::UnregisterInternal")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void UnregisterInternal(string messageId);

		// Token: 0x060015BC RID: 5564
		[FreeFunction("PlayerConnection_Bindings::SendMessage")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SendMessage(string messageId, [Unmarshalled] byte[] data, int playerId);

		// Token: 0x060015BD RID: 5565
		[FreeFunction("PlayerConnection_Bindings::TrySendMessage")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool TrySendMessage(string messageId, [Unmarshalled] byte[] data, int playerId);

		// Token: 0x060015BE RID: 5566
		[FreeFunction("PlayerConnection_Bindings::PollInternal")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void PollInternal();

		// Token: 0x060015BF RID: 5567
		[FreeFunction("PlayerConnection_Bindings::DisconnectAll")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void DisconnectAll();

		// Token: 0x020001D2 RID: 466
		[Flags]
		public enum MulticastFlags
		{
			// Token: 0x040007AB RID: 1963
			kRequestImmediateConnect = 1,
			// Token: 0x040007AC RID: 1964
			kSupportsProfile = 2,
			// Token: 0x040007AD RID: 1965
			kCustomMessage = 4,
			// Token: 0x040007AE RID: 1966
			kUseAlternateIP = 8
		}
	}
}
