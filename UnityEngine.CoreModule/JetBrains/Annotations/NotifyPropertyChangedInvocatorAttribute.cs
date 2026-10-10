using System;

namespace JetBrains.Annotations
{
	// Token: 0x020000BC RID: 188
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class NotifyPropertyChangedInvocatorAttribute : Attribute
	{
		// Token: 0x06000346 RID: 838 RVA: 0x00002059 File Offset: 0x00000259
		public NotifyPropertyChangedInvocatorAttribute()
		{
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00005CC8 File Offset: 0x00003EC8
		public NotifyPropertyChangedInvocatorAttribute([NotNull] string parameterName)
		{
			this.ParameterName = parameterName;
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000348 RID: 840 RVA: 0x00005CD9 File Offset: 0x00003ED9
		[CanBeNull]
		public string ParameterName { get; }
	}
}
