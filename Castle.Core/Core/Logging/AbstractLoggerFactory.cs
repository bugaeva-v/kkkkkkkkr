using System;
using System.IO;

namespace Castle.Core.Logging
{
	// Token: 0x020000C9 RID: 201
	[Serializable]
	public abstract class AbstractLoggerFactory : MarshalByRefObject, ILoggerFactory
	{
		// Token: 0x06000501 RID: 1281 RVA: 0x00010BD1 File Offset: 0x0000EDD1
		public virtual ILogger Create(Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			return this.Create(type.FullName);
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00010BF3 File Offset: 0x0000EDF3
		public virtual ILogger Create(Type type, LoggerLevel level)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			return this.Create(type.FullName, level);
		}

		// Token: 0x06000503 RID: 1283
		public abstract ILogger Create(string name);

		// Token: 0x06000504 RID: 1284
		public abstract ILogger Create(string name, LoggerLevel level);

		// Token: 0x06000505 RID: 1285 RVA: 0x00010C18 File Offset: 0x0000EE18
		protected static FileInfo GetConfigFile(string fileName)
		{
			FileInfo result;
			if (Path.IsPathRooted(fileName))
			{
				result = new FileInfo(fileName);
			}
			else
			{
				result = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName));
			}
			return result;
		}
	}
}
