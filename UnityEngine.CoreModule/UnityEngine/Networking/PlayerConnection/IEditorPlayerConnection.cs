using System;
using UnityEngine.Events;

namespace UnityEngine.Networking.PlayerConnection
{
	// Token: 0x0200038B RID: 907
	public interface IEditorPlayerConnection
	{
		// Token: 0x06001ECF RID: 7887
		void Register(Guid messageId, UnityAction<MessageEventArgs> callback);

		// Token: 0x06001ED0 RID: 7888
		void Unregister(Guid messageId, UnityAction<MessageEventArgs> callback);

		// Token: 0x06001ED1 RID: 7889
		void DisconnectAll();

		// Token: 0x06001ED2 RID: 7890
		void RegisterConnection(UnityAction<int> callback);

		// Token: 0x06001ED3 RID: 7891
		void RegisterDisconnection(UnityAction<int> callback);

		// Token: 0x06001ED4 RID: 7892
		void UnregisterConnection(UnityAction<int> callback);

		// Token: 0x06001ED5 RID: 7893
		void UnregisterDisconnection(UnityAction<int> callback);

		// Token: 0x06001ED6 RID: 7894
		void Send(Guid messageId, byte[] data);

		// Token: 0x06001ED7 RID: 7895
		bool TrySend(Guid messageId, byte[] data);
	}
}
