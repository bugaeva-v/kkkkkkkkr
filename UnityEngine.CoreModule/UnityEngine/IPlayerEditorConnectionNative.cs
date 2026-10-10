using System;

namespace UnityEngine
{
	// Token: 0x020001D0 RID: 464
	internal interface IPlayerEditorConnectionNative
	{
		// Token: 0x060015A8 RID: 5544
		void Initialize();

		// Token: 0x060015A9 RID: 5545
		void DisconnectAll();

		// Token: 0x060015AA RID: 5546
		void SendMessage(Guid messageId, byte[] data, int playerId);

		// Token: 0x060015AB RID: 5547
		bool TrySendMessage(Guid messageId, byte[] data, int playerId);

		// Token: 0x060015AC RID: 5548
		void Poll();

		// Token: 0x060015AD RID: 5549
		void RegisterInternal(Guid messageId);

		// Token: 0x060015AE RID: 5550
		void UnregisterInternal(Guid messageId);

		// Token: 0x060015AF RID: 5551
		bool IsConnected();
	}
}
