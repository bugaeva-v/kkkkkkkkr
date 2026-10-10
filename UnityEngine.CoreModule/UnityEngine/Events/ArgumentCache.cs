using System;
using UnityEngine.Serialization;

namespace UnityEngine.Events
{
	// Token: 0x020002B8 RID: 696
	[Serializable]
	internal class ArgumentCache : ISerializationCallbackReceiver
	{
		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06001D23 RID: 7459 RVA: 0x0002EAF0 File Offset: 0x0002CCF0
		// (set) Token: 0x06001D24 RID: 7460 RVA: 0x0002EB08 File Offset: 0x0002CD08
		public Object unityObjectArgument
		{
			get
			{
				return this.m_ObjectArgument;
			}
			set
			{
				this.m_ObjectArgument = value;
				this.m_ObjectArgumentAssemblyTypeName = ((value != null) ? value.GetType().AssemblyQualifiedName : string.Empty);
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001D25 RID: 7461 RVA: 0x0002EB34 File Offset: 0x0002CD34
		public string unityObjectArgumentAssemblyTypeName
		{
			get
			{
				return this.m_ObjectArgumentAssemblyTypeName;
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06001D26 RID: 7462 RVA: 0x0002EB4C File Offset: 0x0002CD4C
		// (set) Token: 0x06001D27 RID: 7463 RVA: 0x0002EB64 File Offset: 0x0002CD64
		public int intArgument
		{
			get
			{
				return this.m_IntArgument;
			}
			set
			{
				this.m_IntArgument = value;
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06001D28 RID: 7464 RVA: 0x0002EB70 File Offset: 0x0002CD70
		// (set) Token: 0x06001D29 RID: 7465 RVA: 0x0002EB88 File Offset: 0x0002CD88
		public float floatArgument
		{
			get
			{
				return this.m_FloatArgument;
			}
			set
			{
				this.m_FloatArgument = value;
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06001D2A RID: 7466 RVA: 0x0002EB94 File Offset: 0x0002CD94
		// (set) Token: 0x06001D2B RID: 7467 RVA: 0x0002EBAC File Offset: 0x0002CDAC
		public string stringArgument
		{
			get
			{
				return this.m_StringArgument;
			}
			set
			{
				this.m_StringArgument = value;
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06001D2C RID: 7468 RVA: 0x0002EBB8 File Offset: 0x0002CDB8
		// (set) Token: 0x06001D2D RID: 7469 RVA: 0x0002EBD0 File Offset: 0x0002CDD0
		public bool boolArgument
		{
			get
			{
				return this.m_BoolArgument;
			}
			set
			{
				this.m_BoolArgument = value;
			}
		}

		// Token: 0x06001D2E RID: 7470 RVA: 0x0002EBDA File Offset: 0x0002CDDA
		public void OnBeforeSerialize()
		{
			this.m_ObjectArgumentAssemblyTypeName = UnityEventTools.TidyAssemblyTypeName(this.m_ObjectArgumentAssemblyTypeName);
		}

		// Token: 0x06001D2F RID: 7471 RVA: 0x0002EBDA File Offset: 0x0002CDDA
		public void OnAfterDeserialize()
		{
			this.m_ObjectArgumentAssemblyTypeName = UnityEventTools.TidyAssemblyTypeName(this.m_ObjectArgumentAssemblyTypeName);
		}

		// Token: 0x04000993 RID: 2451
		[FormerlySerializedAs("objectArgument")]
		[SerializeField]
		private Object m_ObjectArgument;

		// Token: 0x04000994 RID: 2452
		[SerializeField]
		[FormerlySerializedAs("objectArgumentAssemblyTypeName")]
		private string m_ObjectArgumentAssemblyTypeName;

		// Token: 0x04000995 RID: 2453
		[SerializeField]
		[FormerlySerializedAs("intArgument")]
		private int m_IntArgument;

		// Token: 0x04000996 RID: 2454
		[FormerlySerializedAs("floatArgument")]
		[SerializeField]
		private float m_FloatArgument;

		// Token: 0x04000997 RID: 2455
		[FormerlySerializedAs("stringArgument")]
		[SerializeField]
		private string m_StringArgument;

		// Token: 0x04000998 RID: 2456
		[SerializeField]
		private bool m_BoolArgument;
	}
}
