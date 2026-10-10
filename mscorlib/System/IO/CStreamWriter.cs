using System;
using System.Text;

namespace System.IO
{
	// Token: 0x02000B6D RID: 2925
	internal class CStreamWriter : StreamWriter
	{
		// Token: 0x06006A6D RID: 27245 RVA: 0x0016C5CC File Offset: 0x0016A7CC
		public CStreamWriter(Stream stream, Encoding encoding, bool leaveOpen) : base(stream, encoding, 1024, leaveOpen)
		{
			this.driver = (TermInfoDriver)ConsoleDriver.driver;
		}

		// Token: 0x06006A6E RID: 27246 RVA: 0x0016C5EC File Offset: 0x0016A7EC
		public override void Write(char[] buffer, int index, int count)
		{
			if (count <= 0)
			{
				return;
			}
			if (!this.driver.Initialized)
			{
				try
				{
					base.Write(buffer, index, count);
				}
				catch (IOException)
				{
				}
				return;
			}
			lock (this)
			{
				int num = index + count;
				int num2 = index;
				int num3 = 0;
				do
				{
					char c = buffer[num2++];
					if (this.driver.IsSpecialKey(c))
					{
						if (num3 > 0)
						{
							try
							{
								base.Write(buffer, index, num3);
							}
							catch (IOException)
							{
							}
							num3 = 0;
						}
						this.driver.WriteSpecialKey(c);
						index = num2;
					}
					else
					{
						num3++;
					}
				}
				while (num2 < num);
				if (num3 > 0)
				{
					try
					{
						base.Write(buffer, index, num3);
					}
					catch (IOException)
					{
					}
				}
			}
		}

		// Token: 0x06006A6F RID: 27247 RVA: 0x0016C6D0 File Offset: 0x0016A8D0
		public override void Write(char val)
		{
			lock (this)
			{
				try
				{
					if (this.driver.IsSpecialKey(val))
					{
						this.driver.WriteSpecialKey(val);
					}
					else
					{
						this.InternalWriteChar(val);
					}
				}
				catch (IOException)
				{
				}
			}
		}

		// Token: 0x06006A70 RID: 27248 RVA: 0x0016C738 File Offset: 0x0016A938
		public void InternalWriteString(string val)
		{
			try
			{
				base.Write(val);
			}
			catch (IOException)
			{
			}
		}

		// Token: 0x06006A71 RID: 27249 RVA: 0x0016C764 File Offset: 0x0016A964
		public void InternalWriteChar(char val)
		{
			try
			{
				base.Write(val);
			}
			catch (IOException)
			{
			}
		}

		// Token: 0x06006A72 RID: 27250 RVA: 0x0016C790 File Offset: 0x0016A990
		public void InternalWriteChars(char[] buffer, int n)
		{
			try
			{
				base.Write(buffer, 0, n);
			}
			catch (IOException)
			{
			}
		}

		// Token: 0x06006A73 RID: 27251 RVA: 0x0016C7BC File Offset: 0x0016A9BC
		public override void Write(char[] val)
		{
			this.Write(val, 0, val.Length);
		}

		// Token: 0x06006A74 RID: 27252 RVA: 0x0016C7CC File Offset: 0x0016A9CC
		public override void Write(string val)
		{
			if (val == null)
			{
				return;
			}
			if (this.driver.Initialized)
			{
				this.Write(val.ToCharArray());
				return;
			}
			try
			{
				base.Write(val);
			}
			catch (IOException)
			{
			}
		}

		// Token: 0x06006A75 RID: 27253 RVA: 0x0016C814 File Offset: 0x0016AA14
		public override void WriteLine(string val)
		{
			this.Write(val);
			this.Write(this.NewLine);
		}

		// Token: 0x04003D8C RID: 15756
		private TermInfoDriver driver;
	}
}
