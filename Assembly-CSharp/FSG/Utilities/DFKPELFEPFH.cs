using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace FSG.Utilities
{
	// Token: 0x020003F6 RID: 1014
	public sealed class DFKPELFEPFH
	{
		// Token: 0x0600775A RID: 30554 RVA: 0x0035BA5C File Offset: 0x00359C5C
		public byte[] AONCHHGNAIB(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			bool flag = true;
			byte[] result;
			try
			{
				Monitor.Enter(dhpdehpmgco, ref flag);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.DBDHNIBBEEG(), CryptoStreamMode.Read))
					{
						cryptoStream.Write(GKIKEIKFNBC, 1, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(dhpdehpmgco);
				}
			}
			return result;
		}

		// Token: 0x0600775B RID: 30555 RVA: 0x0035BAF0 File Offset: 0x00359CF0
		public byte[] PIPHGJAIPPF(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.FABOFJPDALB(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(GKIKEIKFNBC, 0, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x0600775C RID: 30556 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform HGEEPAFIHKD()
		{
			if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
			{
				this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
			}
			return this.HGPFBFACIKE;
		}

		// Token: 0x0600775D RID: 30557 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform LKCHJHKNCKP()
		{
			if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
			{
				this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
			}
			return this.HGPFBFACIKE;
		}

		// Token: 0x0600775E RID: 30558 RVA: 0x0035BBB4 File Offset: 0x00359DB4
		public byte[] DJFCJDEBPJK(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.IEKLKAFLMGC(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(GKIKEIKFNBC, 1, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x0600775F RID: 30559 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform OKAPFCOKIIJ()
		{
			if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
			{
				this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
			}
			return this.HGPFBFACIKE;
		}

		// Token: 0x06007760 RID: 30560 RVA: 0x0035BC48 File Offset: 0x00359E48
		public byte[] JEIPKKFMPEG(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			bool flag = true;
			byte[] result;
			try
			{
				Monitor.Enter(dhpdehpmgco, ref flag);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.ONCJDPBPPAA(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(GKIKEIKFNBC, 0, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(dhpdehpmgco);
				}
			}
			return result;
		}

		// Token: 0x06007761 RID: 30561 RVA: 0x0035BCDC File Offset: 0x00359EDC
		public byte[] AOAGFGJEAPI(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			bool flag = true;
			byte[] result;
			try
			{
				Monitor.Enter(dhpdehpmgco, ref flag);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.OCIIGEDOFBB(), CryptoStreamMode.Read))
					{
						cryptoStream.Write(GKIKEIKFNBC, 0, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(dhpdehpmgco);
				}
			}
			return result;
		}

		// Token: 0x06007762 RID: 30562 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform JAOHHICDLGG()
		{
			if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
			{
				this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
			}
			return this.HGPFBFACIKE;
		}

		// Token: 0x06007763 RID: 30563 RVA: 0x0035BD70 File Offset: 0x00359F70
		private ICryptoTransform BJBNNBCHLON()
		{
			if (this.PKLPLAFNNJM == null || !this.PKLPLAFNNJM.CanReuseTransform)
			{
				this.PKLPLAFNNJM = this.JJJFKOPLNMN.CreateDecryptor();
			}
			return this.PKLPLAFNNJM;
		}

		// Token: 0x06007764 RID: 30564 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform FDDAOELELDJ()
		{
			if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
			{
				this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
			}
			return this.HGPFBFACIKE;
		}

		// Token: 0x06007765 RID: 30565 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform LMDGHDKLGAI()
		{
			if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
			{
				this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
			}
			return this.HGPFBFACIKE;
		}

		// Token: 0x06007766 RID: 30566 RVA: 0x0035BD70 File Offset: 0x00359F70
		private ICryptoTransform GLBAPPGBJKE()
		{
			if (this.PKLPLAFNNJM == null || !this.PKLPLAFNNJM.CanReuseTransform)
			{
				this.PKLPLAFNNJM = this.JJJFKOPLNMN.CreateDecryptor();
			}
			return this.PKLPLAFNNJM;
		}

		// Token: 0x06007767 RID: 30567 RVA: 0x0035BDA0 File Offset: 0x00359FA0
		public byte[] DHCKCHEKDCN(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			bool flag = true;
			byte[] result;
			try
			{
				Monitor.Enter(dhpdehpmgco, ref flag);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.BNBDOPBHEHE(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(GKIKEIKFNBC, 1, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(dhpdehpmgco);
				}
			}
			return result;
		}

		// Token: 0x06007768 RID: 30568 RVA: 0x0035BE34 File Offset: 0x0035A034
		public byte[] CNMGKEPMIBC(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.GLBAPPGBJKE(), CryptoStreamMode.Read))
					{
						cryptoStream.Write(GKIKEIKFNBC, 0, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x06007769 RID: 30569 RVA: 0x0035BEC8 File Offset: 0x0035A0C8
		public byte[] POFAMANNNJC(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.BJBNNBCHLON(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(GKIKEIKFNBC, 0, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x0600776A RID: 30570 RVA: 0x0035BF5C File Offset: 0x0035A15C
		public byte[] OPLNEAIBOGL(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			bool flag = true;
			byte[] result;
			try
			{
				Monitor.Enter(dhpdehpmgco, ref flag);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.JBEECGNOBHH(), CryptoStreamMode.Read))
					{
						cryptoStream.Write(GKIKEIKFNBC, 1, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(dhpdehpmgco);
				}
			}
			return result;
		}

		// Token: 0x0600776B RID: 30571 RVA: 0x0035BFF0 File Offset: 0x0035A1F0
		public byte[] MHIIBHHBDHA(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			bool flag = true;
			byte[] result;
			try
			{
				Monitor.Enter(dhpdehpmgco, ref flag);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.OCHJEBFCOGE(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(GKIKEIKFNBC, 0, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(dhpdehpmgco);
				}
			}
			return result;
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x0600776C RID: 30572 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform PIBAINAPMNO
		{
			get
			{
				if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
				{
					this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
				}
				return this.HGPFBFACIKE;
			}
		}

		// Token: 0x0600776D RID: 30573 RVA: 0x0035BD70 File Offset: 0x00359F70
		private ICryptoTransform LEEAEFDOGAD()
		{
			if (this.PKLPLAFNNJM == null || !this.PKLPLAFNNJM.CanReuseTransform)
			{
				this.PKLPLAFNNJM = this.JJJFKOPLNMN.CreateDecryptor();
			}
			return this.PKLPLAFNNJM;
		}

		// Token: 0x0600776E RID: 30574 RVA: 0x0035BD70 File Offset: 0x00359F70
		private ICryptoTransform PMANJJBPNKC()
		{
			if (this.PKLPLAFNNJM == null || !this.PKLPLAFNNJM.CanReuseTransform)
			{
				this.PKLPLAFNNJM = this.JJJFKOPLNMN.CreateDecryptor();
			}
			return this.PKLPLAFNNJM;
		}

		// Token: 0x0600776F RID: 30575 RVA: 0x0035C084 File Offset: 0x0035A284
		public byte[] KJAJLBHAOLI(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			bool flag = true;
			byte[] result;
			try
			{
				Monitor.Enter(dhpdehpmgco, ref flag);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.IEKLKAFLMGC(), CryptoStreamMode.Read))
					{
						cryptoStream.Write(GKIKEIKFNBC, 1, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(dhpdehpmgco);
				}
			}
			return result;
		}

		// Token: 0x06007770 RID: 30576 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform CIPDAGJMEJA()
		{
			if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
			{
				this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
			}
			return this.HGPFBFACIKE;
		}

		// Token: 0x06007771 RID: 30577 RVA: 0x0035C118 File Offset: 0x0035A318
		public DFKPELFEPFH(string LKFBMAKGOKA, string HOGMBJDIJGA)
		{
			if (HOGMBJDIJGA.Length != 20)
			{
				throw new Exception("Invalid salt length. Must be 20");
			}
			this.LKFBMAKGOKA = LKFBMAKGOKA;
			this.HOGMBJDIJGA = Encoding.ASCII.GetBytes(HOGMBJDIJGA);
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(this.LKFBMAKGOKA, this.HOGMBJDIJGA);
			this.JJJFKOPLNMN = new AesManaged();
			this.JJJFKOPLNMN.Key = rfc2898DeriveBytes.GetBytes(this.JJJFKOPLNMN.KeySize / 8);
			this.JJJFKOPLNMN.IV = rfc2898DeriveBytes.GetBytes(this.JJJFKOPLNMN.BlockSize / 8);
		}

		// Token: 0x06007772 RID: 30578 RVA: 0x0035BD70 File Offset: 0x00359F70
		private ICryptoTransform HOHMPCMPJGN()
		{
			if (this.PKLPLAFNNJM == null || !this.PKLPLAFNNJM.CanReuseTransform)
			{
				this.PKLPLAFNNJM = this.JJJFKOPLNMN.CreateDecryptor();
			}
			return this.PKLPLAFNNJM;
		}

		// Token: 0x06007773 RID: 30579 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform GFDOPMHGGJE()
		{
			if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
			{
				this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
			}
			return this.HGPFBFACIKE;
		}

		// Token: 0x06007774 RID: 30580 RVA: 0x0035BD70 File Offset: 0x00359F70
		private ICryptoTransform HPNEBCLPLHN()
		{
			if (this.PKLPLAFNNJM == null || !this.PKLPLAFNNJM.CanReuseTransform)
			{
				this.PKLPLAFNNJM = this.JJJFKOPLNMN.CreateDecryptor();
			}
			return this.PKLPLAFNNJM;
		}

		// Token: 0x06007775 RID: 30581 RVA: 0x0035C1BC File Offset: 0x0035A3BC
		public byte[] LODNMJHKHGC(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			bool flag = true;
			byte[] result;
			try
			{
				Monitor.Enter(dhpdehpmgco, ref flag);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.EMNKNAMHIKJ(), CryptoStreamMode.Read))
					{
						cryptoStream.Write(GKIKEIKFNBC, 0, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(dhpdehpmgco);
				}
			}
			return result;
		}

		// Token: 0x06007776 RID: 30582 RVA: 0x0035C250 File Offset: 0x0035A450
		public byte[] OHNJDBBEMIL(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.DBIDEFDDAII(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(GKIKEIKFNBC, 0, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x06007777 RID: 30583 RVA: 0x0035BD70 File Offset: 0x00359F70
		private ICryptoTransform HGANIOIGOHC()
		{
			if (this.PKLPLAFNNJM == null || !this.PKLPLAFNNJM.CanReuseTransform)
			{
				this.PKLPLAFNNJM = this.JJJFKOPLNMN.CreateDecryptor();
			}
			return this.PKLPLAFNNJM;
		}

		// Token: 0x06007778 RID: 30584 RVA: 0x0035C2E4 File Offset: 0x0035A4E4
		public byte[] DMIEILIMONJ(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.FDDAOELELDJ(), CryptoStreamMode.Read))
					{
						cryptoStream.Write(GKIKEIKFNBC, 1, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x06007779 RID: 30585 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform HMAACFMAOOM()
		{
			if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
			{
				this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
			}
			return this.HGPFBFACIKE;
		}

		// Token: 0x0600777A RID: 30586 RVA: 0x0035C378 File Offset: 0x0035A578
		public byte[] EDECLEPKBCD(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.FDDAOELELDJ(), CryptoStreamMode.Read))
					{
						cryptoStream.Write(GKIKEIKFNBC, 0, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x0600777B RID: 30587 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform EMNKNAMHIKJ()
		{
			if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
			{
				this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
			}
			return this.HGPFBFACIKE;
		}

		// Token: 0x0600777C RID: 30588 RVA: 0x0035C40C File Offset: 0x0035A60C
		public byte[] ECEMNLGEPBL(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.FABOFJPDALB(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(GKIKEIKFNBC, 0, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x0600777D RID: 30589 RVA: 0x0035C4A0 File Offset: 0x0035A6A0
		public byte[] MKFDOLBOCNA(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.NOHPLPPBDNE(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(GKIKEIKFNBC, 0, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x0600777E RID: 30590 RVA: 0x0035BD70 File Offset: 0x00359F70
		private ICryptoTransform PKOOFJAALKF()
		{
			if (this.PKLPLAFNNJM == null || !this.PKLPLAFNNJM.CanReuseTransform)
			{
				this.PKLPLAFNNJM = this.JJJFKOPLNMN.CreateDecryptor();
			}
			return this.PKLPLAFNNJM;
		}

		// Token: 0x0600777F RID: 30591 RVA: 0x0035C534 File Offset: 0x0035A734
		public byte[] DNJDDLPDJOD(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.PMANJJBPNKC(), CryptoStreamMode.Read))
					{
						cryptoStream.Write(GKIKEIKFNBC, 1, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x06007780 RID: 30592 RVA: 0x0035C5C8 File Offset: 0x0035A7C8
		public byte[] NIIAMAMFEJA(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.KADEOMJABFI(), CryptoStreamMode.Read))
					{
						cryptoStream.Write(GKIKEIKFNBC, 1, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x06007781 RID: 30593 RVA: 0x0035C65C File Offset: 0x0035A85C
		public byte[] IENOJLNDAAC(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			bool flag = true;
			byte[] result;
			try
			{
				Monitor.Enter(dhpdehpmgco, ref flag);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.OLFJDFPPNIL(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(GKIKEIKFNBC, 0, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(dhpdehpmgco);
				}
			}
			return result;
		}

		// Token: 0x06007782 RID: 30594 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform JLFIJEKILFK()
		{
			if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
			{
				this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
			}
			return this.HGPFBFACIKE;
		}

		// Token: 0x06007783 RID: 30595 RVA: 0x0035C6F0 File Offset: 0x0035A8F0
		public byte[] ACMNOOOJJBE(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.GFDOPMHGGJE(), CryptoStreamMode.Read))
					{
						cryptoStream.Write(GKIKEIKFNBC, 1, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x06007784 RID: 30596 RVA: 0x0035BD70 File Offset: 0x00359F70
		private ICryptoTransform OCHJEBFCOGE()
		{
			if (this.PKLPLAFNNJM == null || !this.PKLPLAFNNJM.CanReuseTransform)
			{
				this.PKLPLAFNNJM = this.JJJFKOPLNMN.CreateDecryptor();
			}
			return this.PKLPLAFNNJM;
		}

		// Token: 0x06007785 RID: 30597 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform BNKCFGFGODJ()
		{
			if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
			{
				this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
			}
			return this.HGPFBFACIKE;
		}

		// Token: 0x06007786 RID: 30598 RVA: 0x0035BD70 File Offset: 0x00359F70
		private ICryptoTransform KADEOMJABFI()
		{
			if (this.PKLPLAFNNJM == null || !this.PKLPLAFNNJM.CanReuseTransform)
			{
				this.PKLPLAFNNJM = this.JJJFKOPLNMN.CreateDecryptor();
			}
			return this.PKLPLAFNNJM;
		}

		// Token: 0x06007787 RID: 30599 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform PCGFIDJEEAA()
		{
			if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
			{
				this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
			}
			return this.HGPFBFACIKE;
		}

		// Token: 0x06007788 RID: 30600 RVA: 0x0035C784 File Offset: 0x0035A984
		public byte[] MFDOJOMCOIP(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			bool flag = true;
			byte[] result;
			try
			{
				Monitor.Enter(dhpdehpmgco, ref flag);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.EMNKNAMHIKJ(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(GKIKEIKFNBC, 0, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(dhpdehpmgco);
				}
			}
			return result;
		}

		// Token: 0x06007789 RID: 30601 RVA: 0x0035BD70 File Offset: 0x00359F70
		private ICryptoTransform IOFEAKPIACH()
		{
			if (this.PKLPLAFNNJM == null || !this.PKLPLAFNNJM.CanReuseTransform)
			{
				this.PKLPLAFNNJM = this.JJJFKOPLNMN.CreateDecryptor();
			}
			return this.PKLPLAFNNJM;
		}

		// Token: 0x0600778A RID: 30602 RVA: 0x0035C818 File Offset: 0x0035AA18
		public byte[] MDAKACLAJOM(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.CKEIJPAFMMF(), CryptoStreamMode.Read))
					{
						cryptoStream.Write(GKIKEIKFNBC, 1, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x0600778B RID: 30603 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform GNGPJDHJFKI()
		{
			if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
			{
				this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
			}
			return this.HGPFBFACIKE;
		}

		// Token: 0x0600778C RID: 30604 RVA: 0x0035C8AC File Offset: 0x0035AAAC
		public byte[] PBFKBDELAHG(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			bool flag = true;
			byte[] result;
			try
			{
				Monitor.Enter(dhpdehpmgco, ref flag);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.BFHOGJGJJAM(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(GKIKEIKFNBC, 0, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(dhpdehpmgco);
				}
			}
			return result;
		}

		// Token: 0x0600778D RID: 30605 RVA: 0x0035BD70 File Offset: 0x00359F70
		private ICryptoTransform NKIEIMMAOMA()
		{
			if (this.PKLPLAFNNJM == null || !this.PKLPLAFNNJM.CanReuseTransform)
			{
				this.PKLPLAFNNJM = this.JJJFKOPLNMN.CreateDecryptor();
			}
			return this.PKLPLAFNNJM;
		}

		// Token: 0x0600778E RID: 30606 RVA: 0x0035BD70 File Offset: 0x00359F70
		private ICryptoTransform JMCLJKPGIHK()
		{
			if (this.PKLPLAFNNJM == null || !this.PKLPLAFNNJM.CanReuseTransform)
			{
				this.PKLPLAFNNJM = this.JJJFKOPLNMN.CreateDecryptor();
			}
			return this.PKLPLAFNNJM;
		}

		// Token: 0x0600778F RID: 30607 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform PABLJBGCMBD()
		{
			if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
			{
				this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
			}
			return this.HGPFBFACIKE;
		}

		// Token: 0x06007790 RID: 30608 RVA: 0x0035BD70 File Offset: 0x00359F70
		private ICryptoTransform DBIDEFDDAII()
		{
			if (this.PKLPLAFNNJM == null || !this.PKLPLAFNNJM.CanReuseTransform)
			{
				this.PKLPLAFNNJM = this.JJJFKOPLNMN.CreateDecryptor();
			}
			return this.PKLPLAFNNJM;
		}

		// Token: 0x06007791 RID: 30609 RVA: 0x0035BD70 File Offset: 0x00359F70
		private ICryptoTransform NOEMMGLNFGD()
		{
			if (this.PKLPLAFNNJM == null || !this.PKLPLAFNNJM.CanReuseTransform)
			{
				this.PKLPLAFNNJM = this.JJJFKOPLNMN.CreateDecryptor();
			}
			return this.PKLPLAFNNJM;
		}

		// Token: 0x06007792 RID: 30610 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform GMFNPJCKEPN()
		{
			if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
			{
				this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
			}
			return this.HGPFBFACIKE;
		}

		// Token: 0x06007793 RID: 30611 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform ONCJDPBPPAA()
		{
			if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
			{
				this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
			}
			return this.HGPFBFACIKE;
		}

		// Token: 0x06007794 RID: 30612 RVA: 0x0035BD70 File Offset: 0x00359F70
		private ICryptoTransform KOADCGBANBM()
		{
			if (this.PKLPLAFNNJM == null || !this.PKLPLAFNNJM.CanReuseTransform)
			{
				this.PKLPLAFNNJM = this.JJJFKOPLNMN.CreateDecryptor();
			}
			return this.PKLPLAFNNJM;
		}

		// Token: 0x06007795 RID: 30613 RVA: 0x0035C940 File Offset: 0x0035AB40
		public byte[] GJAHCMHKGBJ(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.PMHACBBCAPJ(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(GKIKEIKFNBC, 0, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x06007796 RID: 30614 RVA: 0x0035C9D4 File Offset: 0x0035ABD4
		public byte[] LHCIBDGFJJH(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			bool flag = true;
			byte[] result;
			try
			{
				Monitor.Enter(dhpdehpmgco, ref flag);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.HGANIOIGOHC(), CryptoStreamMode.Read))
					{
						cryptoStream.Write(GKIKEIKFNBC, 1, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(dhpdehpmgco);
				}
			}
			return result;
		}

		// Token: 0x06007797 RID: 30615 RVA: 0x0035CA68 File Offset: 0x0035AC68
		public byte[] GMJCLCJOKKH(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.CKEIJPAFMMF(), CryptoStreamMode.Read))
					{
						cryptoStream.Write(GKIKEIKFNBC, 1, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x06007798 RID: 30616 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform DPDEABCDDIE()
		{
			if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
			{
				this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
			}
			return this.HGPFBFACIKE;
		}

		// Token: 0x06007799 RID: 30617 RVA: 0x0035CAFC File Offset: 0x0035ACFC
		public byte[] BDJBEELHILA(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.PMANJJBPNKC(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(GKIKEIKFNBC, 1, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x0600779A RID: 30618 RVA: 0x0035CB90 File Offset: 0x0035AD90
		public byte[] HILAAJFJCKK(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.FABOFJPDALB(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(GKIKEIKFNBC, 0, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x0600779B RID: 30619 RVA: 0x0035BD70 File Offset: 0x00359F70
		private ICryptoTransform FABOFJPDALB()
		{
			if (this.PKLPLAFNNJM == null || !this.PKLPLAFNNJM.CanReuseTransform)
			{
				this.PKLPLAFNNJM = this.JJJFKOPLNMN.CreateDecryptor();
			}
			return this.PKLPLAFNNJM;
		}

		// Token: 0x0600779C RID: 30620 RVA: 0x0035CC24 File Offset: 0x0035AE24
		public byte[] HDLJBMLGMKD(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			bool flag = true;
			byte[] result;
			try
			{
				Monitor.Enter(dhpdehpmgco, ref flag);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.NOFAHILPGFP(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(GKIKEIKFNBC, 1, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(dhpdehpmgco);
				}
			}
			return result;
		}

		// Token: 0x0600779D RID: 30621 RVA: 0x0035CCB8 File Offset: 0x0035AEB8
		public byte[] GJCEIPKJJFE(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.PNAJFMJBAML(), CryptoStreamMode.Read))
					{
						cryptoStream.Write(GKIKEIKFNBC, 1, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x0600779E RID: 30622 RVA: 0x0035CD4C File Offset: 0x0035AF4C
		public byte[] JCIIFBKIKDP(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.LPOPCAFOJBP, CryptoStreamMode.Write))
					{
						cryptoStream.Write(GKIKEIKFNBC, 0, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x0600779F RID: 30623 RVA: 0x0035CDE0 File Offset: 0x0035AFE0
		public byte[] GOCBFOGBNPL(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.PMANJJBPNKC(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(GKIKEIKFNBC, 0, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x060077A0 RID: 30624 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform EBEFFJOOGNM()
		{
			if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
			{
				this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
			}
			return this.HGPFBFACIKE;
		}

		// Token: 0x060077A1 RID: 30625 RVA: 0x0035CE74 File Offset: 0x0035B074
		public byte[] NLFFNPAGHGI(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			bool flag = true;
			byte[] result;
			try
			{
				Monitor.Enter(dhpdehpmgco, ref flag);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.LEEAEFDOGAD(), CryptoStreamMode.Read))
					{
						cryptoStream.Write(GKIKEIKFNBC, 1, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(dhpdehpmgco);
				}
			}
			return result;
		}

		// Token: 0x060077A2 RID: 30626 RVA: 0x0035CF08 File Offset: 0x0035B108
		public byte[] PBMLFKJKDCP(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.NOEMMGLNFGD(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(GKIKEIKFNBC, 0, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x060077A3 RID: 30627 RVA: 0x0035CF9C File Offset: 0x0035B19C
		public byte[] AIEDOFAMGHI(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			bool flag = true;
			byte[] result;
			try
			{
				Monitor.Enter(dhpdehpmgco, ref flag);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.CKEIJPAFMMF(), CryptoStreamMode.Read))
					{
						cryptoStream.Write(GKIKEIKFNBC, 0, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(dhpdehpmgco);
				}
			}
			return result;
		}

		// Token: 0x060077A4 RID: 30628 RVA: 0x0035D030 File Offset: 0x0035B230
		public byte[] EOOAPMPLHFF(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.JMCLJKPGIHK(), CryptoStreamMode.Read))
					{
						cryptoStream.Write(GKIKEIKFNBC, 0, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x060077A5 RID: 30629 RVA: 0x0035D0C4 File Offset: 0x0035B2C4
		public byte[] IKEODCKBBBJ(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			bool flag = true;
			byte[] result;
			try
			{
				Monitor.Enter(dhpdehpmgco, ref flag);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.LBLFMPLMKON(), CryptoStreamMode.Read))
					{
						cryptoStream.Write(GKIKEIKFNBC, 0, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(dhpdehpmgco);
				}
			}
			return result;
		}

		// Token: 0x060077A6 RID: 30630 RVA: 0x0035D158 File Offset: 0x0035B358
		public byte[] AIMFLBGFALA(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			bool flag = true;
			byte[] result;
			try
			{
				Monitor.Enter(dhpdehpmgco, ref flag);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.DPDEABCDDIE(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(GKIKEIKFNBC, 0, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(dhpdehpmgco);
				}
			}
			return result;
		}

		// Token: 0x060077A7 RID: 30631 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform JBEECGNOBHH()
		{
			if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
			{
				this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
			}
			return this.HGPFBFACIKE;
		}

		// Token: 0x060077A8 RID: 30632 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform NOHPLPPBDNE()
		{
			if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
			{
				this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
			}
			return this.HGPFBFACIKE;
		}

		// Token: 0x060077A9 RID: 30633 RVA: 0x0035D1EC File Offset: 0x0035B3EC
		public byte[] EECOEEDNKFI(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.LBLFMPLMKON(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(GKIKEIKFNBC, 1, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x060077AA RID: 30634 RVA: 0x0035BD70 File Offset: 0x00359F70
		private ICryptoTransform IEKLKAFLMGC()
		{
			if (this.PKLPLAFNNJM == null || !this.PKLPLAFNNJM.CanReuseTransform)
			{
				this.PKLPLAFNNJM = this.JJJFKOPLNMN.CreateDecryptor();
			}
			return this.PKLPLAFNNJM;
		}

		// Token: 0x060077AB RID: 30635 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform PNAJFMJBAML()
		{
			if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
			{
				this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
			}
			return this.HGPFBFACIKE;
		}

		// Token: 0x060077AC RID: 30636 RVA: 0x0035D280 File Offset: 0x0035B480
		public byte[] KFHNHFKDKAN(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			bool flag = true;
			byte[] result;
			try
			{
				Monitor.Enter(dhpdehpmgco, ref flag);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.NOEMMGLNFGD(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(GKIKEIKFNBC, 1, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(dhpdehpmgco);
				}
			}
			return result;
		}

		// Token: 0x060077AD RID: 30637 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform OLFJDFPPNIL()
		{
			if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
			{
				this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
			}
			return this.HGPFBFACIKE;
		}

		// Token: 0x060077AE RID: 30638 RVA: 0x0035D314 File Offset: 0x0035B514
		public byte[] FHMLCHGNINI(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			bool flag = true;
			byte[] result;
			try
			{
				Monitor.Enter(dhpdehpmgco, ref flag);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.JMCLJKPGIHK(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(GKIKEIKFNBC, 1, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(dhpdehpmgco);
				}
			}
			return result;
		}

		// Token: 0x060077AF RID: 30639 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform DNCFGLOEBON()
		{
			if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
			{
				this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
			}
			return this.HGPFBFACIKE;
		}

		// Token: 0x060077B0 RID: 30640 RVA: 0x0035BD70 File Offset: 0x00359F70
		private ICryptoTransform CKEIJPAFMMF()
		{
			if (this.PKLPLAFNNJM == null || !this.PKLPLAFNNJM.CanReuseTransform)
			{
				this.PKLPLAFNNJM = this.JJJFKOPLNMN.CreateDecryptor();
			}
			return this.PKLPLAFNNJM;
		}

		// Token: 0x060077B1 RID: 30641 RVA: 0x0035D3A8 File Offset: 0x0035B5A8
		public byte[] GFKIMHBOBLO(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			bool flag = true;
			byte[] result;
			try
			{
				Monitor.Enter(dhpdehpmgco, ref flag);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.PMANJJBPNKC(), CryptoStreamMode.Read))
					{
						cryptoStream.Write(GKIKEIKFNBC, 1, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(dhpdehpmgco);
				}
			}
			return result;
		}

		// Token: 0x060077B2 RID: 30642 RVA: 0x0035BD70 File Offset: 0x00359F70
		private ICryptoTransform GBEKMENAFLN()
		{
			if (this.PKLPLAFNNJM == null || !this.PKLPLAFNNJM.CanReuseTransform)
			{
				this.PKLPLAFNNJM = this.JJJFKOPLNMN.CreateDecryptor();
			}
			return this.PKLPLAFNNJM;
		}

		// Token: 0x060077B3 RID: 30643 RVA: 0x0035D43C File Offset: 0x0035B63C
		public byte[] KFJIKMMCDEN(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			bool flag = true;
			byte[] result;
			try
			{
				Monitor.Enter(dhpdehpmgco, ref flag);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.LEEAEFDOGAD(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(GKIKEIKFNBC, 0, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(dhpdehpmgco);
				}
			}
			return result;
		}

		// Token: 0x060077B4 RID: 30644 RVA: 0x0035D4D0 File Offset: 0x0035B6D0
		public byte[] MFFANPGBEHG(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.LEEAEFDOGAD(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(GKIKEIKFNBC, 0, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x060077B5 RID: 30645 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform CBJKBEOFBHG()
		{
			if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
			{
				this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
			}
			return this.HGPFBFACIKE;
		}

		// Token: 0x060077B6 RID: 30646 RVA: 0x0035D564 File Offset: 0x0035B764
		public byte[] ONHJOKACHGA(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.HCDKHMHHKBB(), CryptoStreamMode.Read))
					{
						cryptoStream.Write(GKIKEIKFNBC, 1, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x060077B7 RID: 30647 RVA: 0x0035BD70 File Offset: 0x00359F70
		private ICryptoTransform FEBMFIOJJCN()
		{
			if (this.PKLPLAFNNJM == null || !this.PKLPLAFNNJM.CanReuseTransform)
			{
				this.PKLPLAFNNJM = this.JJJFKOPLNMN.CreateDecryptor();
			}
			return this.PKLPLAFNNJM;
		}

		// Token: 0x060077B8 RID: 30648 RVA: 0x0035D5F8 File Offset: 0x0035B7F8
		public byte[] JFNNGDBLOKP(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.PNAJFMJBAML(), CryptoStreamMode.Read))
					{
						cryptoStream.Write(GKIKEIKFNBC, 1, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x060077B9 RID: 30649 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform NIAHLBLAOEP()
		{
			if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
			{
				this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
			}
			return this.HGPFBFACIKE;
		}

		// Token: 0x060077BA RID: 30650 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform NOFAHILPGFP()
		{
			if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
			{
				this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
			}
			return this.HGPFBFACIKE;
		}

		// Token: 0x060077BB RID: 30651 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform BCJHIFOAFND()
		{
			if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
			{
				this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
			}
			return this.HGPFBFACIKE;
		}

		// Token: 0x060077BC RID: 30652 RVA: 0x0035D68C File Offset: 0x0035B88C
		public byte[] JHEGJCILIOG(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.PLMJPBBJJHB(), CryptoStreamMode.Read))
					{
						cryptoStream.Write(GKIKEIKFNBC, 1, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x060077BD RID: 30653 RVA: 0x0035D720 File Offset: 0x0035B920
		public byte[] BKCJJMBBDMC(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			bool flag = true;
			byte[] result;
			try
			{
				Monitor.Enter(dhpdehpmgco, ref flag);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.JAOHHICDLGG(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(GKIKEIKFNBC, 0, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(dhpdehpmgco);
				}
			}
			return result;
		}

		// Token: 0x060077BE RID: 30654 RVA: 0x0035D7B4 File Offset: 0x0035B9B4
		public byte[] AJLBNFEPCBM(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.NOHPLPPBDNE(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(GKIKEIKFNBC, 1, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x060077BF RID: 30655 RVA: 0x0035D848 File Offset: 0x0035BA48
		public byte[] JNBMEPKFKPJ(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.JAOHHICDLGG(), CryptoStreamMode.Read))
					{
						cryptoStream.Write(GKIKEIKFNBC, 0, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x060077C0 RID: 30656 RVA: 0x0035BD70 File Offset: 0x00359F70
		private ICryptoTransform PLMJPBBJJHB()
		{
			if (this.PKLPLAFNNJM == null || !this.PKLPLAFNNJM.CanReuseTransform)
			{
				this.PKLPLAFNNJM = this.JJJFKOPLNMN.CreateDecryptor();
			}
			return this.PKLPLAFNNJM;
		}

		// Token: 0x060077C1 RID: 30657 RVA: 0x0035D8DC File Offset: 0x0035BADC
		public byte[] CLBBCAKDHEG(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.KOADCGBANBM(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(GKIKEIKFNBC, 1, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x060077C2 RID: 30658 RVA: 0x0035BD70 File Offset: 0x00359F70
		private ICryptoTransform NGMFEEGEBHK()
		{
			if (this.PKLPLAFNNJM == null || !this.PKLPLAFNNJM.CanReuseTransform)
			{
				this.PKLPLAFNNJM = this.JJJFKOPLNMN.CreateDecryptor();
			}
			return this.PKLPLAFNNJM;
		}

		// Token: 0x060077C3 RID: 30659 RVA: 0x0035D970 File Offset: 0x0035BB70
		public byte[] OFDOFMDCLBB(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.BNKCFGFGODJ(), CryptoStreamMode.Read))
					{
						cryptoStream.Write(GKIKEIKFNBC, 1, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x060077C4 RID: 30660 RVA: 0x0035BD70 File Offset: 0x00359F70
		private ICryptoTransform LBLFMPLMKON()
		{
			if (this.PKLPLAFNNJM == null || !this.PKLPLAFNNJM.CanReuseTransform)
			{
				this.PKLPLAFNNJM = this.JJJFKOPLNMN.CreateDecryptor();
			}
			return this.PKLPLAFNNJM;
		}

		// Token: 0x060077C5 RID: 30661 RVA: 0x0035DA04 File Offset: 0x0035BC04
		public byte[] PHJOPOBKKJN(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			bool flag = true;
			byte[] result;
			try
			{
				Monitor.Enter(dhpdehpmgco, ref flag);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.DNCFGLOEBON(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(GKIKEIKFNBC, 0, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(dhpdehpmgco);
				}
			}
			return result;
		}

		// Token: 0x060077C6 RID: 30662 RVA: 0x0035DA98 File Offset: 0x0035BC98
		public byte[] JHAODMNHGOI(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			bool flag = true;
			byte[] result;
			try
			{
				Monitor.Enter(dhpdehpmgco, ref flag);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.HOHMPCMPJGN(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(GKIKEIKFNBC, 0, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(dhpdehpmgco);
				}
			}
			return result;
		}

		// Token: 0x060077C7 RID: 30663 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform OCIIGEDOFBB()
		{
			if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
			{
				this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
			}
			return this.HGPFBFACIKE;
		}

		// Token: 0x060077C8 RID: 30664 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform BNBDOPBHEHE()
		{
			if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
			{
				this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
			}
			return this.HGPFBFACIKE;
		}

		// Token: 0x060077C9 RID: 30665 RVA: 0x0035DB2C File Offset: 0x0035BD2C
		public byte[] JNGJDHEGAHF(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.PLMJPBBJJHB(), CryptoStreamMode.Read))
					{
						cryptoStream.Write(GKIKEIKFNBC, 1, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x060077CA RID: 30666 RVA: 0x0035DBC0 File Offset: 0x0035BDC0
		public byte[] LNBEPKHILGM(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.PMANJJBPNKC(), CryptoStreamMode.Read))
					{
						cryptoStream.Write(GKIKEIKFNBC, 1, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x060077CB RID: 30667 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform INICAHNFKED()
		{
			if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
			{
				this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
			}
			return this.HGPFBFACIKE;
		}

		// Token: 0x060077CC RID: 30668 RVA: 0x0035BD70 File Offset: 0x00359F70
		private ICryptoTransform LJENKCPDPMC()
		{
			if (this.PKLPLAFNNJM == null || !this.PKLPLAFNNJM.CanReuseTransform)
			{
				this.PKLPLAFNNJM = this.JJJFKOPLNMN.CreateDecryptor();
			}
			return this.PKLPLAFNNJM;
		}

		// Token: 0x060077CD RID: 30669 RVA: 0x0035DC54 File Offset: 0x0035BE54
		public byte[] LKGCFBIMDNK(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.EMNKNAMHIKJ(), CryptoStreamMode.Read))
					{
						cryptoStream.Write(GKIKEIKFNBC, 1, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x060077CE RID: 30670 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform BBHPNPFNONA()
		{
			if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
			{
				this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
			}
			return this.HGPFBFACIKE;
		}

		// Token: 0x060077CF RID: 30671 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform BFHOGJGJJAM()
		{
			if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
			{
				this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
			}
			return this.HGPFBFACIKE;
		}

		// Token: 0x060077D0 RID: 30672 RVA: 0x0035DCE8 File Offset: 0x0035BEE8
		public byte[] KDBFPNJEECF(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.LKCHJHKNCKP(), CryptoStreamMode.Read))
					{
						cryptoStream.Write(GKIKEIKFNBC, 1, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x060077D1 RID: 30673 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform DBDHNIBBEEG()
		{
			if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
			{
				this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
			}
			return this.HGPFBFACIKE;
		}

		// Token: 0x060077D2 RID: 30674 RVA: 0x0035DD7C File Offset: 0x0035BF7C
		public byte[] CPOGEEANNJP(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.INICAHNFKED(), CryptoStreamMode.Read))
					{
						cryptoStream.Write(GKIKEIKFNBC, 1, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x060077D3 RID: 30675 RVA: 0x0035DE10 File Offset: 0x0035C010
		public byte[] DKLPOLPNCPB(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			bool flag = true;
			byte[] result;
			try
			{
				Monitor.Enter(dhpdehpmgco, ref flag);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.OLFJDFPPNIL(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(GKIKEIKFNBC, 0, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(dhpdehpmgco);
				}
			}
			return result;
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060077D4 RID: 30676 RVA: 0x0035BD70 File Offset: 0x00359F70
		private ICryptoTransform LPOPCAFOJBP
		{
			get
			{
				if (this.PKLPLAFNNJM == null || !this.PKLPLAFNNJM.CanReuseTransform)
				{
					this.PKLPLAFNNJM = this.JJJFKOPLNMN.CreateDecryptor();
				}
				return this.PKLPLAFNNJM;
			}
		}

		// Token: 0x060077D5 RID: 30677 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform GIPBGKDEFGF()
		{
			if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
			{
				this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
			}
			return this.HGPFBFACIKE;
		}

		// Token: 0x060077D6 RID: 30678 RVA: 0x0035BD70 File Offset: 0x00359F70
		private ICryptoTransform PMHACBBCAPJ()
		{
			if (this.PKLPLAFNNJM == null || !this.PKLPLAFNNJM.CanReuseTransform)
			{
				this.PKLPLAFNNJM = this.JJJFKOPLNMN.CreateDecryptor();
			}
			return this.PKLPLAFNNJM;
		}

		// Token: 0x060077D7 RID: 30679 RVA: 0x0035DEA4 File Offset: 0x0035C0A4
		public byte[] NHNOAKDJLAF(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			byte[] result;
			lock (dhpdehpmgco)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.PIBAINAPMNO, CryptoStreamMode.Write))
					{
						cryptoStream.Write(GKIKEIKFNBC, 0, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x060077D8 RID: 30680 RVA: 0x0035DF38 File Offset: 0x0035C138
		public byte[] BPMEFIGMCDK(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			bool flag = true;
			byte[] result;
			try
			{
				Monitor.Enter(dhpdehpmgco, ref flag);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.EBEFFJOOGNM(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(GKIKEIKFNBC, 1, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(dhpdehpmgco);
				}
			}
			return result;
		}

		// Token: 0x060077D9 RID: 30681 RVA: 0x0035DFCC File Offset: 0x0035C1CC
		public byte[] EMAPHIAJLEI(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			bool flag = true;
			byte[] result;
			try
			{
				Monitor.Enter(dhpdehpmgco, ref flag);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.PKOOFJAALKF(), CryptoStreamMode.Read))
					{
						cryptoStream.Write(GKIKEIKFNBC, 0, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(dhpdehpmgco);
				}
			}
			return result;
		}

		// Token: 0x060077DA RID: 30682 RVA: 0x0035BD70 File Offset: 0x00359F70
		private ICryptoTransform OKDIGNOIGPG()
		{
			if (this.PKLPLAFNNJM == null || !this.PKLPLAFNNJM.CanReuseTransform)
			{
				this.PKLPLAFNNJM = this.JJJFKOPLNMN.CreateDecryptor();
			}
			return this.PKLPLAFNNJM;
		}

		// Token: 0x060077DB RID: 30683 RVA: 0x0035BB84 File Offset: 0x00359D84
		private ICryptoTransform HCDKHMHHKBB()
		{
			if (this.HGPFBFACIKE == null || !this.HGPFBFACIKE.CanReuseTransform)
			{
				this.HGPFBFACIKE = this.JJJFKOPLNMN.CreateEncryptor();
			}
			return this.HGPFBFACIKE;
		}

		// Token: 0x060077DC RID: 30684 RVA: 0x0035E060 File Offset: 0x0035C260
		public byte[] CAKDALIOHEM(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			bool flag = true;
			byte[] result;
			try
			{
				Monitor.Enter(dhpdehpmgco, ref flag);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.LJENKCPDPMC(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(GKIKEIKFNBC, 0, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(dhpdehpmgco);
				}
			}
			return result;
		}

		// Token: 0x060077DD RID: 30685 RVA: 0x0035E0F4 File Offset: 0x0035C2F4
		public byte[] EBAKHFOIKLC(byte[] GKIKEIKFNBC)
		{
			object dhpdehpmgco = this.DHPDEHPMGCO;
			bool flag = true;
			byte[] result;
			try
			{
				Monitor.Enter(dhpdehpmgco, ref flag);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, this.HCDKHMHHKBB(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(GKIKEIKFNBC, 0, GKIKEIKFNBC.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(dhpdehpmgco);
				}
			}
			return result;
		}

		// Token: 0x04002310 RID: 8976
		private readonly object DHPDEHPMGCO = new object();

		// Token: 0x04002311 RID: 8977
		private readonly string LKFBMAKGOKA;

		// Token: 0x04002312 RID: 8978
		private readonly byte[] HOGMBJDIJGA;

		// Token: 0x04002313 RID: 8979
		private Aes JJJFKOPLNMN;

		// Token: 0x04002314 RID: 8980
		private ICryptoTransform HGPFBFACIKE;

		// Token: 0x04002315 RID: 8981
		private ICryptoTransform PKLPLAFNNJM;
	}
}
