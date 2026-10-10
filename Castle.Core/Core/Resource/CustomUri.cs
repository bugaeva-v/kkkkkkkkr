using System;
using System.Text;

namespace Castle.Core.Resource
{
	// Token: 0x020000BF RID: 191
	[Serializable]
	public sealed class CustomUri
	{
		// Token: 0x060004C4 RID: 1220 RVA: 0x000104C4 File Offset: 0x0000E6C4
		public CustomUri(string resourceIdentifier)
		{
			if (resourceIdentifier == null)
			{
				throw new ArgumentNullException("resourceIdentifier");
			}
			if (resourceIdentifier == string.Empty)
			{
				throw new ArgumentException("Empty resource identifier is not allowed", "resourceIdentifier");
			}
			this.ParseIdentifier(resourceIdentifier);
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x000104FE File Offset: 0x0000E6FE
		public bool IsUnc
		{
			get
			{
				return this.isUnc;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x00010506 File Offset: 0x0000E706
		public bool IsFile
		{
			get
			{
				return this.isFile;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x0001050E File Offset: 0x0000E70E
		public bool IsAssembly
		{
			get
			{
				return this.isAssembly;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x00010516 File Offset: 0x0000E716
		public string Scheme
		{
			get
			{
				return this.scheme;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x0001051E File Offset: 0x0000E71E
		public string Host
		{
			get
			{
				return this.host;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x00010526 File Offset: 0x0000E726
		public string Path
		{
			get
			{
				return this.path;
			}
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00010530 File Offset: 0x0000E730
		private void ParseIdentifier(string identifier)
		{
			int num = identifier.IndexOf(':');
			if (num == -1 && (identifier[0] != '\\' || identifier[1] != '\\') && identifier[0] != '/')
			{
				throw new ArgumentException("Invalid Uri: no scheme delimiter found on " + identifier);
			}
			bool flag = true;
			if (identifier[0] == '\\' && identifier[1] == '\\')
			{
				this.isUnc = true;
				this.isFile = true;
				this.scheme = CustomUri.UriSchemeFile;
				flag = false;
			}
			else if (identifier[num + 1] == '/' && identifier[num + 2] == '/')
			{
				this.scheme = identifier.Substring(0, num);
				this.isFile = (this.scheme == CustomUri.UriSchemeFile);
				this.isAssembly = (this.scheme == CustomUri.UriSchemeAssembly);
				identifier = identifier.Substring(num + CustomUri.SchemeDelimiter.Length);
			}
			else
			{
				this.isFile = true;
				this.scheme = CustomUri.UriSchemeFile;
			}
			StringBuilder stringBuilder = new StringBuilder();
			foreach (char c in identifier.ToCharArray())
			{
				if (flag && (c == '\\' || c == '/'))
				{
					if (this.host == null && !this.IsFile)
					{
						this.host = stringBuilder.ToString();
						stringBuilder.Length = 0;
					}
					stringBuilder.Append('/');
				}
				else
				{
					stringBuilder.Append(c);
				}
			}
			this.path = Environment.ExpandEnvironmentVariables(stringBuilder.ToString());
		}

		// Token: 0x0400014D RID: 333
		public static readonly string SchemeDelimiter = "://";

		// Token: 0x0400014E RID: 334
		public static readonly string UriSchemeFile = "file";

		// Token: 0x0400014F RID: 335
		public static readonly string UriSchemeAssembly = "assembly";

		// Token: 0x04000150 RID: 336
		private string scheme;

		// Token: 0x04000151 RID: 337
		private string host;

		// Token: 0x04000152 RID: 338
		private string path;

		// Token: 0x04000153 RID: 339
		private bool isUnc;

		// Token: 0x04000154 RID: 340
		private bool isFile;

		// Token: 0x04000155 RID: 341
		private bool isAssembly;
	}
}
