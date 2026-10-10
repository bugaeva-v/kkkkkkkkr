using System;

namespace Unity.Services.Analytics.Data
{
	// Token: 0x02000022 RID: 34
	internal interface IDataGenerator
	{
		// Token: 0x060000D3 RID: 211
		void GameRunning(string callingMethodIdentifier);

		// Token: 0x060000D4 RID: 212
		void SdkStartup(string callingMethodIdentifier);

		// Token: 0x060000D5 RID: 213
		void NewPlayer(string callingMethodIdentifier);

		// Token: 0x060000D6 RID: 214
		void GameStarted(string callingMethodIdentifier);

		// Token: 0x060000D7 RID: 215
		void GameEnded(string callingMethodIdentifier, DataGenerator.SessionEndState quitState);

		// Token: 0x060000D8 RID: 216
		void ClientDevice(string callingMethodIdentifier);

		// Token: 0x060000D9 RID: 217
		void PushCommonParams(string callingMethodIdentifier);

		// Token: 0x060000DA RID: 218
		void PushEvent(string callingMethodIdentifier, Event e);

		// Token: 0x060000DB RID: 219
		void PushEmptyEvent(string name);
	}
}
