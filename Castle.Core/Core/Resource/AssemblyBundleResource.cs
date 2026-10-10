using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Text;

namespace Castle.Core.Resource
{
	// Token: 0x020000BA RID: 186
	public class AssemblyBundleResource : AbstractResource
	{
		// Token: 0x060004A4 RID: 1188 RVA: 0x0000FFDE File Offset: 0x0000E1DE
		public AssemblyBundleResource(CustomUri resource)
		{
			this.resource = resource;
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0000FFF0 File Offset: 0x0000E1F0
		public override TextReader GetStreamReader()
		{
			Assembly assembly = AssemblyBundleResource.ObtainAssembly(this.resource.Host);
			string[] array = this.resource.Path.Split(new char[]
			{
				'/'
			}, StringSplitOptions.RemoveEmptyEntries);
			if (array.Length != 2)
			{
				throw new ResourceException("AssemblyBundleResource does not support paths with more than 2 levels in depth. See " + this.resource.Path);
			}
			return new StringReader(new ResourceManager(array[0], assembly).GetString(array[1]));
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00010062 File Offset: 0x0000E262
		public override TextReader GetStreamReader(Encoding encoding)
		{
			return this.GetStreamReader();
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x0001006A File Offset: 0x0000E26A
		public override IResource CreateRelative(string relativePath)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00010074 File Offset: 0x0000E274
		private static Assembly ObtainAssembly(string assemblyName)
		{
			Assembly result;
			try
			{
				result = Assembly.Load(assemblyName);
			}
			catch (Exception innerException)
			{
				throw new ResourceException(string.Format(CultureInfo.InvariantCulture, "The assembly {0} could not be loaded", new object[]
				{
					assemblyName
				}), innerException);
			}
			return result;
		}

		// Token: 0x04000147 RID: 327
		private readonly CustomUri resource;
	}
}
