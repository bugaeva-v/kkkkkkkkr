using System;
using System.Reflection;
using System.Threading;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Абстрактный класс, который является базовым классом для <see cref="T:System.Xml.Serialization.XmlSerializationReader" /> и <see cref="T:System.Xml.Serialization.XmlSerializationWriter" /> которая содержит методы, общие для обоих типов.
	///       </summary>
	// Token: 0x020002E8 RID: 744
	public abstract class XmlSerializationGeneratedCode
	{
		// Token: 0x06001D4B RID: 7499 RVA: 0x000AB2B4 File Offset: 0x000A94B4
		internal void Init(TempAssembly tempAssembly)
		{
			this.tempAssembly = tempAssembly;
			if (tempAssembly != null && tempAssembly.NeedAssembyResolve)
			{
				this.threadCode = Thread.CurrentThread.GetHashCode();
				this.assemblyResolver = new ResolveEventHandler(this.OnAssemblyResolve);
				AppDomain.CurrentDomain.AssemblyResolve += this.assemblyResolver;
			}
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x000AB305 File Offset: 0x000A9505
		internal void Dispose()
		{
			if (this.assemblyResolver != null)
			{
				AppDomain.CurrentDomain.AssemblyResolve -= this.assemblyResolver;
			}
			this.assemblyResolver = null;
		}

		// Token: 0x06001D4D RID: 7501 RVA: 0x000AB326 File Offset: 0x000A9526
		internal Assembly OnAssemblyResolve(object sender, ResolveEventArgs args)
		{
			if (this.tempAssembly != null && Thread.CurrentThread.GetHashCode() == this.threadCode)
			{
				return this.tempAssembly.GetReferencedAssembly(args.Name);
			}
			return null;
		}

		// Token: 0x04001A45 RID: 6725
		private TempAssembly tempAssembly;

		// Token: 0x04001A46 RID: 6726
		private int threadCode;

		// Token: 0x04001A47 RID: 6727
		private ResolveEventHandler assemblyResolver;
	}
}
