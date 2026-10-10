using System;
using System.Runtime.InteropServices;

namespace Steamworks
{
	// Token: 0x0200009C RID: 156
	[Serializable]
	public struct SteamInputActionEvent_t
	{
		// Token: 0x040003CE RID: 974
		public InputHandle_t controllerHandle;

		// Token: 0x040003CF RID: 975
		public PMKDOODINCP eEventType;

		// Token: 0x040003D0 RID: 976
		public SteamInputActionEvent_t.OptionValue m_val;

		// Token: 0x0200009D RID: 157
		[Serializable]
		public struct AnalogAction_t
		{
			// Token: 0x040003D1 RID: 977
			public InputAnalogActionHandle_t actionHandle;

			// Token: 0x040003D2 RID: 978
			public DBHPFDFKFHC analogActionData;
		}

		// Token: 0x0200009E RID: 158
		[Serializable]
		public struct DigitalAction_t
		{
			// Token: 0x040003D3 RID: 979
			public InputDigitalActionHandle_t actionHandle;

			// Token: 0x040003D4 RID: 980
			public AFIFGIEEBFC digitalActionData;
		}

		// Token: 0x0200009F RID: 159
		[Serializable]
		[StructLayout(LayoutKind.Explicit)]
		public struct OptionValue
		{
			// Token: 0x040003D5 RID: 981
			[FieldOffset(0)]
			public SteamInputActionEvent_t.AnalogAction_t analogAction;

			// Token: 0x040003D6 RID: 982
			[FieldOffset(0)]
			public SteamInputActionEvent_t.DigitalAction_t digitalAction;
		}
	}
}
