using System;

namespace UnityEngine.Timeline
{
	// Token: 0x0200003C RID: 60
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public class TrackClipTypeAttribute : Attribute
	{
		// Token: 0x060002AF RID: 687 RVA: 0x000099BB File Offset: 0x00007BBB
		public TrackClipTypeAttribute(Type clipClass)
		{
			this.inspectedType = clipClass;
			this.allowAutoCreate = true;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x000099D1 File Offset: 0x00007BD1
		public TrackClipTypeAttribute(Type clipClass, bool allowAutoCreate)
		{
			this.inspectedType = clipClass;
		}

		// Token: 0x040000E8 RID: 232
		public readonly Type inspectedType;

		// Token: 0x040000E9 RID: 233
		public readonly bool allowAutoCreate;
	}
}
