using System;
using System.Globalization;
using System.IO;

namespace Castle.Core.Resource
{
	// Token: 0x020000C0 RID: 192
	public class FileResource : AbstractStreamResource
	{
		// Token: 0x060004CD RID: 1229 RVA: 0x000106CC File Offset: 0x0000E8CC
		public FileResource(CustomUri resource)
		{
			FileResource <>4__this = this;
			base.CreateStream = (() => <>4__this.CreateStreamFromUri(resource, AbstractResource.DefaultBasePath));
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00010708 File Offset: 0x0000E908
		public FileResource(CustomUri resource, string basePath)
		{
			FileResource <>4__this = this;
			base.CreateStream = (() => <>4__this.CreateStreamFromUri(resource, basePath));
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00010748 File Offset: 0x0000E948
		public FileResource(string resourceName)
		{
			FileResource <>4__this = this;
			base.CreateStream = (() => <>4__this.CreateStreamFromPath(resourceName, AbstractResource.DefaultBasePath));
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00010784 File Offset: 0x0000E984
		public FileResource(string resourceName, string basePath)
		{
			FileResource <>4__this = this;
			base.CreateStream = (() => <>4__this.CreateStreamFromPath(resourceName, basePath));
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x000107C4 File Offset: 0x0000E9C4
		public override string ToString()
		{
			return string.Format(CultureInfo.CurrentCulture, "FileResource: [{0}] [{1}]", new object[]
			{
				this.filePath,
				this.basePath
			});
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x000107ED File Offset: 0x0000E9ED
		public override string FileBasePath
		{
			get
			{
				return this.basePath;
			}
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x000107F5 File Offset: 0x0000E9F5
		public override IResource CreateRelative(string relativePath)
		{
			return new FileResource(relativePath, this.basePath);
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00010804 File Offset: 0x0000EA04
		private Stream CreateStreamFromUri(CustomUri resource, string rootPath)
		{
			if (resource == null)
			{
				throw new ArgumentNullException("resource");
			}
			if (rootPath == null)
			{
				throw new ArgumentNullException("rootPath");
			}
			if (!resource.IsFile)
			{
				throw new ArgumentException("The specified resource is not a file", "resource");
			}
			return this.CreateStreamFromPath(resource.Path, rootPath);
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00010854 File Offset: 0x0000EA54
		private Stream CreateStreamFromPath(string resourcePath, string rootPath)
		{
			if (resourcePath == null)
			{
				throw new ArgumentNullException("resourcePath");
			}
			if (rootPath == null)
			{
				throw new ArgumentNullException("rootPath");
			}
			if (!Path.IsPathRooted(resourcePath) || !File.Exists(resourcePath))
			{
				resourcePath = Path.Combine(rootPath, resourcePath);
			}
			FileResource.CheckFileExists(resourcePath);
			this.filePath = Path.GetFileName(resourcePath);
			this.basePath = Path.GetDirectoryName(resourcePath);
			return File.OpenRead(resourcePath);
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x000108BA File Offset: 0x0000EABA
		private static void CheckFileExists(string path)
		{
			if (!File.Exists(path))
			{
				throw new ResourceException(string.Format(CultureInfo.InvariantCulture, "File {0} could not be found", new object[]
				{
					new FileInfo(path).FullName
				}));
			}
		}

		// Token: 0x04000156 RID: 342
		private string filePath;

		// Token: 0x04000157 RID: 343
		private string basePath;
	}
}
