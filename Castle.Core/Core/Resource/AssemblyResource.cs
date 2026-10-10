using System;
using System.Globalization;
using System.IO;
using System.Reflection;

namespace Castle.Core.Resource
{
	// Token: 0x020000BB RID: 187
	public class AssemblyResource : AbstractStreamResource
	{
		// Token: 0x060004A9 RID: 1193 RVA: 0x000100BC File Offset: 0x0000E2BC
		public AssemblyResource(CustomUri resource)
		{
			AssemblyResource <>4__this = this;
			base.CreateStream = (() => <>4__this.CreateResourceFromUri(resource, null));
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x000100F8 File Offset: 0x0000E2F8
		public AssemblyResource(CustomUri resource, string basePath)
		{
			AssemblyResource <>4__this = this;
			base.CreateStream = (() => <>4__this.CreateResourceFromUri(resource, basePath));
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00010138 File Offset: 0x0000E338
		public AssemblyResource(string resource)
		{
			AssemblyResource <>4__this = this;
			base.CreateStream = (() => <>4__this.CreateResourceFromPath(resource, <>4__this.basePath));
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00010171 File Offset: 0x0000E371
		public override IResource CreateRelative(string relativePath)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00010178 File Offset: 0x0000E378
		public override string ToString()
		{
			return string.Format(CultureInfo.CurrentCulture, "AssemblyResource: [{0}] [{1}]", new object[]
			{
				this.assemblyName,
				this.resourcePath
			});
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x000101A1 File Offset: 0x0000E3A1
		private Stream CreateResourceFromPath(string resource, string path)
		{
			if (!resource.StartsWith("assembly" + CustomUri.SchemeDelimiter, StringComparison.CurrentCulture))
			{
				resource = "assembly" + CustomUri.SchemeDelimiter + resource;
			}
			return this.CreateResourceFromUri(new CustomUri(resource), path);
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x000101DC File Offset: 0x0000E3DC
		private Stream CreateResourceFromUri(CustomUri resourcex, string path)
		{
			if (resourcex == null)
			{
				throw new ArgumentNullException("resourcex");
			}
			this.assemblyName = resourcex.Host;
			this.resourcePath = this.ConvertToResourceName(this.assemblyName, resourcex.Path);
			Assembly assembly = AssemblyResource.ObtainAssembly(this.assemblyName);
			string[] manifestResourceNames = assembly.GetManifestResourceNames();
			string nameFound = this.GetNameFound(manifestResourceNames);
			if (nameFound == null)
			{
				this.resourcePath = resourcex.Path.Replace('/', '.').Substring(1);
				nameFound = this.GetNameFound(manifestResourceNames);
			}
			if (nameFound == null)
			{
				throw new ResourceException(string.Format(CultureInfo.InvariantCulture, "The assembly resource {0} could not be located", new object[]
				{
					this.resourcePath
				}));
			}
			this.basePath = this.ConvertToPath(this.resourcePath);
			return assembly.GetManifestResourceStream(nameFound);
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0001029C File Offset: 0x0000E49C
		private string GetNameFound(string[] names)
		{
			string result = null;
			foreach (string text in names)
			{
				if (string.Compare(this.resourcePath, text, StringComparison.OrdinalIgnoreCase) == 0)
				{
					result = text;
					break;
				}
			}
			return result;
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x000102D3 File Offset: 0x0000E4D3
		private string ConvertToResourceName(string assembly, string resource)
		{
			assembly = this.GetSimpleName(assembly);
			return string.Format(CultureInfo.CurrentCulture, "{0}{1}", new object[]
			{
				assembly,
				resource.Replace('/', '.')
			});
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00010304 File Offset: 0x0000E504
		private string GetSimpleName(string assembly)
		{
			int num = assembly.IndexOf(',');
			if (num < 0)
			{
				return assembly;
			}
			return assembly.Substring(0, num);
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00010328 File Offset: 0x0000E528
		private string ConvertToPath(string resource)
		{
			string text = resource.Replace('.', '/');
			if (text[0] != '/')
			{
				text = string.Format(CultureInfo.CurrentCulture, "/{0}", new object[]
				{
					text
				});
			}
			return text;
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00010368 File Offset: 0x0000E568
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

		// Token: 0x04000148 RID: 328
		private string assemblyName;

		// Token: 0x04000149 RID: 329
		private string resourcePath;

		// Token: 0x0400014A RID: 330
		private string basePath;
	}
}
