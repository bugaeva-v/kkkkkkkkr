using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x0200014F RID: 335
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Interface, AllowMultiple = true)]
	public class XPathAttribute : Attribute
	{
		// Token: 0x06000977 RID: 2423 RVA: 0x00017B28 File Offset: 0x00015D28
		public XPathAttribute(string path)
		{
			if (path == null)
			{
				throw Error.ArgumentNull("path");
			}
			this.getPath = XPathCompiler.Compile(path);
			this.setPath = this.getPath;
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00017B56 File Offset: 0x00015D56
		public XPathAttribute(string get, string set)
		{
			if (get == null)
			{
				throw Error.ArgumentNull("get");
			}
			if (set == null)
			{
				throw Error.ArgumentNull("set");
			}
			this.getPath = XPathCompiler.Compile(get);
			this.setPath = XPathCompiler.Compile(set);
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000979 RID: 2425 RVA: 0x00017B92 File Offset: 0x00015D92
		public CompiledXPath GetPath
		{
			get
			{
				return this.getPath;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x00017B9A File Offset: 0x00015D9A
		public CompiledXPath SetPath
		{
			get
			{
				return this.setPath;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600097B RID: 2427 RVA: 0x00017BA2 File Offset: 0x00015DA2
		// (set) Token: 0x0600097C RID: 2428 RVA: 0x00017BAA File Offset: 0x00015DAA
		public bool Nullable { get; set; }

		// Token: 0x0400020D RID: 525
		private readonly CompiledXPath getPath;

		// Token: 0x0400020E RID: 526
		private readonly CompiledXPath setPath;
	}
}
