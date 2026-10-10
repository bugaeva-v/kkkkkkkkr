using System;
using System.Globalization;
using System.IO;

namespace Castle.Core.Resource
{
	// Token: 0x020000C6 RID: 198
	public class UncResource : AbstractStreamResource
	{
		// Token: 0x060004EA RID: 1258 RVA: 0x00010974 File Offset: 0x0000EB74
		public UncResource(CustomUri resource)
		{
			UncResource <>4__this = this;
			base.CreateStream = (() => <>4__this.CreateStreamFromUri(resource, AbstractResource.DefaultBasePath));
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x000109B0 File Offset: 0x0000EBB0
		public UncResource(CustomUri resource, string basePath)
		{
			UncResource <>4__this = this;
			base.CreateStream = (() => <>4__this.CreateStreamFromUri(resource, basePath));
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x000109F0 File Offset: 0x0000EBF0
		public UncResource(string resourceName) : this(new CustomUri(resourceName))
		{
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x000109FE File Offset: 0x0000EBFE
		public UncResource(string resourceName, string basePath) : this(new CustomUri(resourceName), basePath)
		{
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x00010A0D File Offset: 0x0000EC0D
		public override string FileBasePath
		{
			get
			{
				return this.basePath;
			}
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00010A15 File Offset: 0x0000EC15
		public override IResource CreateRelative(string relativePath)
		{
			return new UncResource(Path.Combine(this.basePath, relativePath));
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00010A28 File Offset: 0x0000EC28
		public override string ToString()
		{
			return string.Format(CultureInfo.CurrentCulture, "UncResource: [{0}] [{1}]", new object[]
			{
				this.filePath,
				this.basePath
			});
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00010A54 File Offset: 0x0000EC54
		private Stream CreateStreamFromUri(CustomUri resource, string rootPath)
		{
			if (resource == null)
			{
				throw new ArgumentNullException("resource");
			}
			if (!resource.IsUnc)
			{
				throw new ArgumentException("Resource must be an Unc", "resource");
			}
			if (!resource.IsFile)
			{
				throw new ArgumentException("The specified resource is not a file", "resource");
			}
			string text = resource.Path;
			if (!File.Exists(text) && rootPath != null)
			{
				text = Path.Combine(rootPath, text);
			}
			this.filePath = Path.GetFileName(text);
			this.basePath = Path.GetDirectoryName(text);
			UncResource.CheckFileExists(text);
			return File.OpenRead(text);
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00010ADD File Offset: 0x0000ECDD
		private static void CheckFileExists(string path)
		{
			if (!File.Exists(path))
			{
				throw new ResourceException(string.Format(CultureInfo.InvariantCulture, "File {0} could not be found", new object[]
				{
					path
				}));
			}
		}

		// Token: 0x04000159 RID: 345
		private string basePath;

		// Token: 0x0400015A RID: 346
		private string filePath;
	}
}
