using System;
using System.IO;

namespace Castle.Core.Logging
{
	// Token: 0x020000C8 RID: 200
	public abstract class AbstractExtendedLoggerFactory : MarshalByRefObject, IExtendedLoggerFactory, ILoggerFactory
	{
		// Token: 0x060004F7 RID: 1271 RVA: 0x00010B27 File Offset: 0x0000ED27
		public virtual IExtendedLogger Create(Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			return this.Create(type.FullName);
		}

		// Token: 0x060004F8 RID: 1272
		public abstract IExtendedLogger Create(string name);

		// Token: 0x060004F9 RID: 1273 RVA: 0x00010B49 File Offset: 0x0000ED49
		public virtual IExtendedLogger Create(Type type, LoggerLevel level)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			return this.Create(type.FullName, level);
		}

		// Token: 0x060004FA RID: 1274
		public abstract IExtendedLogger Create(string name, LoggerLevel level);

		// Token: 0x060004FB RID: 1275 RVA: 0x00010B6C File Offset: 0x0000ED6C
		ILogger ILoggerFactory.Create(Type type)
		{
			return this.Create(type);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00010B75 File Offset: 0x0000ED75
		ILogger ILoggerFactory.Create(string name)
		{
			return this.Create(name);
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00010B7E File Offset: 0x0000ED7E
		ILogger ILoggerFactory.Create(Type type, LoggerLevel level)
		{
			return this.Create(type, level);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00010B88 File Offset: 0x0000ED88
		ILogger ILoggerFactory.Create(string name, LoggerLevel level)
		{
			return this.Create(name, level);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00010B94 File Offset: 0x0000ED94
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
