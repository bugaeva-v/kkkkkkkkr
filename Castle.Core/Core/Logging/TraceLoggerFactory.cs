using System;
using System.Security;

namespace Castle.Core.Logging
{
	// Token: 0x020000DD RID: 221
	public class TraceLoggerFactory : AbstractLoggerFactory
	{
		// Token: 0x060005F3 RID: 1523 RVA: 0x00011A5C File Offset: 0x0000FC5C
		public TraceLoggerFactory()
		{
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00011A64 File Offset: 0x0000FC64
		public TraceLoggerFactory(LoggerLevel level)
		{
			this.level = new LoggerLevel?(level);
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00011A78 File Offset: 0x0000FC78
		[SecuritySafeCritical]
		public override ILogger Create(string name)
		{
			if (this.level != null)
			{
				return this.Create(name, this.level.Value);
			}
			return this.InternalCreate(name);
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00011AB2 File Offset: 0x0000FCB2
		[SecurityCritical]
		private ILogger InternalCreate(string name)
		{
			return new TraceLogger(name);
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00011ABA File Offset: 0x0000FCBA
		[SecuritySafeCritical]
		public override ILogger Create(string name, LoggerLevel level)
		{
			return this.InternalCreate(name, level);
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00011AC4 File Offset: 0x0000FCC4
		[SecurityCritical]
		private ILogger InternalCreate(string name, LoggerLevel level)
		{
			return new TraceLogger(name, level);
		}

		// Token: 0x0400016C RID: 364
		private readonly LoggerLevel? level;
	}
}
