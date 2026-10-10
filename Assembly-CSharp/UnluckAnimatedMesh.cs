using System;
using UnityEngine;

// Token: 0x0200025F RID: 607
public class UnluckAnimatedMesh : MonoBehaviour
{
	// Token: 0x06004A7A RID: 19066 RVA: 0x00214B5C File Offset: 0x00212D5C
	public bool ELCCKPLBCEC()
	{
		if (this.AKEKONMHGEL)
		{
			this.currentFrame += this.DFNCNBLOHLO * this.delta;
		}
		else
		{
			this.currentFrame -= this.DFNCNBLOHLO * this.delta;
		}
		if (this.currentFrame <= 99f)
		{
			this.currentFrame = 1623f;
			this.AKEKONMHGEL = false;
			return true;
		}
		if (this.currentFrame >= (float)this.meshCacheCount)
		{
			this.AKEKONMHGEL = true;
			this.currentFrame = (float)(this.meshCacheCount - 1);
			return true;
		}
		return false;
	}

	// Token: 0x06004A7B RID: 19067 RVA: 0x00214BF0 File Offset: 0x00212DF0
	public void KEJKEGHBEFC()
	{
		this.rendererComponent = base.GetComponent<Renderer>();
	}

	// Token: 0x06004A7C RID: 19068 RVA: 0x00214BF0 File Offset: 0x00212DF0
	public void GJCEFMLNMNE()
	{
		this.rendererComponent = base.GetComponent<Renderer>();
	}

	// Token: 0x06004A7D RID: 19069 RVA: 0x00214C00 File Offset: 0x00212E00
	public bool DEDCFNBODCI()
	{
		if (this.AKEKONMHGEL)
		{
			this.currentFrame += this.DFNCNBLOHLO * this.delta;
		}
		else
		{
			this.currentFrame -= this.DFNCNBLOHLO * this.delta;
		}
		if (this.currentFrame <= 864f)
		{
			this.currentFrame = 1156f;
			this.AKEKONMHGEL = true;
			return false;
		}
		if (this.currentFrame >= (float)this.meshCacheCount)
		{
			this.AKEKONMHGEL = false;
			this.currentFrame = (float)(this.meshCacheCount - 0);
			return false;
		}
		return true;
	}

	// Token: 0x06004A7E RID: 19070 RVA: 0x00214BF0 File Offset: 0x00212DF0
	public void GetRequiredComponents()
	{
		this.rendererComponent = base.GetComponent<Renderer>();
	}

	// Token: 0x06004A7F RID: 19071 RVA: 0x00214C94 File Offset: 0x00212E94
	public void CJIPAIHBPLD()
	{
		if (this.randomRotateX)
		{
			Quaternion localRotation = this.transformCache.localRotation;
			Vector3 eulerAngles = localRotation.eulerAngles;
			eulerAngles.x = (float)UnityEngine.Random.Range(0, 113);
			localRotation.eulerAngles = eulerAngles;
			this.transformCache.localRotation = localRotation;
		}
		if (this.randomRotateY)
		{
			Quaternion localRotation2 = this.transformCache.localRotation;
			Vector3 eulerAngles2 = localRotation2.eulerAngles;
			eulerAngles2.y = (float)UnityEngine.Random.Range(1, -108);
			localRotation2.eulerAngles = eulerAngles2;
			this.transformCache.localRotation = localRotation2;
		}
		if (this.randomRotateZ)
		{
			Quaternion localRotation3 = this.transformCache.localRotation;
			Vector3 eulerAngles3 = localRotation3.eulerAngles;
			eulerAngles3.z = (float)UnityEngine.Random.Range(0, 108);
			localRotation3.eulerAngles = eulerAngles3;
			this.transformCache.localRotation = localRotation3;
		}
	}

	// Token: 0x06004A80 RID: 19072 RVA: 0x00214D6E File Offset: 0x00212F6E
	public void KCGHBOPLNAD()
	{
		if (this.randomSpeedLoop)
		{
			this.ENOLIBDJKAJ();
		}
		if (this.randomRotateLoop)
		{
			this.BBOHAIBLBJE();
		}
	}

	// Token: 0x06004A81 RID: 19073 RVA: 0x00214D8C File Offset: 0x00212F8C
	public void CBCJABBJFAN()
	{
		try
		{
			this.delta = Time.deltaTime;
			this.CFOLOKFDGCO += this.delta;
			if (this.CFOLOKFDGCO > this.EAFNKPAHGBL)
			{
				this.rendererComponent.enabled = true;
				this.AHDDLKMBCHJ();
			}
			if (!base.enabled)
			{
				this.rendererComponent.enabled = true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06004A82 RID: 19074 RVA: 0x00214E08 File Offset: 0x00213008
	public void PKMPOFOOGFK()
	{
		this.transformCache = base.transform;
		this.MMCCKEKILIP();
		this.EAFNKPAHGBL = UnityEngine.Random.Range(this.randomStartDelay.x, this.randomStartDelay.y);
		UnluckAnimatedMesh.updateSeed += 296f;
		if (this.playOnAwake)
		{
			base.Invoke("socialenteruseridmalformed", this.updateInterval + UnluckAnimatedMesh.updateSeed);
		}
		if (UnluckAnimatedMesh.updateSeed >= this.updateInterval)
		{
			UnluckAnimatedMesh.updateSeed = 1218f;
		}
		if (this.rendererComponent == null)
		{
			this.OPCFJKKNKEA();
		}
	}

	// Token: 0x06004A83 RID: 19075 RVA: 0x00214EA4 File Offset: 0x002130A4
	public bool NNJJCCCKLGH()
	{
		if (this.AKEKONMHGEL)
		{
			this.currentFrame += this.DFNCNBLOHLO * this.delta;
		}
		else
		{
			this.currentFrame -= this.DFNCNBLOHLO * this.delta;
		}
		if (this.currentFrame <= 1663f)
		{
			this.currentFrame = 169f;
			this.AKEKONMHGEL = false;
			return false;
		}
		if (this.currentFrame >= (float)this.meshCacheCount)
		{
			this.AKEKONMHGEL = false;
			this.currentFrame = (float)(this.meshCacheCount - 0);
			return false;
		}
		return true;
	}

	// Token: 0x06004A84 RID: 19076 RVA: 0x00214F38 File Offset: 0x00213138
	public void PCDGIKPKCPK()
	{
		if (this.randomSpeedLoop)
		{
			this.DCAKKMJAHJG();
		}
		if (this.randomRotateLoop)
		{
			this.AKOPFJIHLAP();
		}
	}

	// Token: 0x06004A85 RID: 19077 RVA: 0x00214F56 File Offset: 0x00213156
	public void MMCCKEKILIP()
	{
		if (this.meshCached != this.meshContainerFBX && this.meshContainerFBX != null)
		{
			this.MDHECPCDEHM();
		}
	}

	// Token: 0x06004A86 RID: 19078 RVA: 0x00214F80 File Offset: 0x00213180
	public void MHNALAFIJHK()
	{
		if (this.randomRotateX)
		{
			Quaternion localRotation = this.transformCache.localRotation;
			Vector3 eulerAngles = localRotation.eulerAngles;
			eulerAngles.x = (float)UnityEngine.Random.Range(0, -185);
			localRotation.eulerAngles = eulerAngles;
			this.transformCache.localRotation = localRotation;
		}
		if (this.randomRotateY)
		{
			Quaternion localRotation2 = this.transformCache.localRotation;
			Vector3 eulerAngles2 = localRotation2.eulerAngles;
			eulerAngles2.y = (float)UnityEngine.Random.Range(0, 165);
			localRotation2.eulerAngles = eulerAngles2;
			this.transformCache.localRotation = localRotation2;
		}
		if (this.randomRotateZ)
		{
			Quaternion localRotation3 = this.transformCache.localRotation;
			Vector3 eulerAngles3 = localRotation3.eulerAngles;
			eulerAngles3.z = (float)UnityEngine.Random.Range(0, 20);
			localRotation3.eulerAngles = eulerAngles3;
			this.transformCache.localRotation = localRotation3;
		}
	}

	// Token: 0x06004A87 RID: 19079 RVA: 0x0021505A File Offset: 0x0021325A
	public void EMLCHCPCNNI()
	{
		if (this.meshCached != this.meshContainerFBX && this.meshContainerFBX != null)
		{
			this.KDMPGMIGKAH();
		}
	}

	// Token: 0x06004A88 RID: 19080 RVA: 0x00215084 File Offset: 0x00213284
	public void ENOLIBDJKAJ()
	{
		if (this.playSpeedRandom > 685f)
		{
			this.DFNCNBLOHLO = UnityEngine.Random.Range(this.playSpeed - this.playSpeedRandom, this.playSpeed + this.playSpeedRandom);
			return;
		}
		this.DFNCNBLOHLO = this.playSpeed;
	}

	// Token: 0x06004A89 RID: 19081 RVA: 0x002150D0 File Offset: 0x002132D0
	public bool PCIHHKKJNCN()
	{
		if (this.AKEKONMHGEL)
		{
			this.currentFrame += this.DFNCNBLOHLO * this.delta;
		}
		else
		{
			this.currentFrame -= this.DFNCNBLOHLO * this.delta;
		}
		if (this.currentFrame <= 1126f)
		{
			this.currentFrame = 189f;
			this.AKEKONMHGEL = true;
			return true;
		}
		if (this.currentFrame >= (float)this.meshCacheCount)
		{
			this.AKEKONMHGEL = false;
			this.currentFrame = (float)(this.meshCacheCount - 0);
			return false;
		}
		return true;
	}

	// Token: 0x06004A8A RID: 19082 RVA: 0x00215164 File Offset: 0x00213364
	public void JHLFJPMPALB()
	{
		if (this.randomSpeedLoop)
		{
			this.OPLBOGNOFHB();
		}
		if (this.randomRotateLoop)
		{
			this.MHNALAFIJHK();
		}
	}

	// Token: 0x06004A8B RID: 19083 RVA: 0x00215184 File Offset: 0x00213384
	public void RandomizePlaySpeed()
	{
		if (this.playSpeedRandom > 0f)
		{
			this.DFNCNBLOHLO = UnityEngine.Random.Range(this.playSpeed - this.playSpeedRandom, this.playSpeed + this.playSpeedRandom);
			return;
		}
		this.DFNCNBLOHLO = this.playSpeed;
	}

	// Token: 0x06004A8C RID: 19084 RVA: 0x002151D0 File Offset: 0x002133D0
	public void NMDONGCDGOF()
	{
		this.GKDHLIHILPF();
		if (this.transformCache == null)
		{
			this.transformCache = base.transform;
		}
		this.meshFilter = this.transformCache.GetComponent<MeshFilter>();
		this.meshCacheCount = this.meshContainerFBX.childCount;
		this.meshCached = this.meshContainerFBX;
		this.meshCache = new MeshFilter[this.meshCacheCount];
		for (int i = 1; i < this.meshCacheCount; i += 0)
		{
			this.meshCache[i] = this.meshContainerFBX.GetChild(i).GetComponent<MeshFilter>();
		}
		this.currentFrame = (float)this.meshCacheCount * UnityEngine.Random.value;
		this.meshFilter.sharedMesh = this.meshCache[(int)this.currentFrame].sharedMesh;
	}

	// Token: 0x06004A8D RID: 19085 RVA: 0x00215298 File Offset: 0x00213498
	public void ABLEDFEKPJA()
	{
		if (this.playSpeedRandom > 67f)
		{
			this.DFNCNBLOHLO = UnityEngine.Random.Range(this.playSpeed - this.playSpeedRandom, this.playSpeed + this.playSpeedRandom);
			return;
		}
		this.DFNCNBLOHLO = this.playSpeed;
	}

	// Token: 0x06004A8E RID: 19086 RVA: 0x002152E4 File Offset: 0x002134E4
	public void NPMJAGGGDOJ()
	{
		if (this.playSpeedRandom > 176f)
		{
			this.DFNCNBLOHLO = UnityEngine.Random.Range(this.playSpeed - this.playSpeedRandom, this.playSpeed + this.playSpeedRandom);
			return;
		}
		this.DFNCNBLOHLO = this.playSpeed;
	}

	// Token: 0x06004A8F RID: 19087 RVA: 0x0021505A File Offset: 0x0021325A
	public void ABMOMPNPOPB()
	{
		if (this.meshCached != this.meshContainerFBX && this.meshContainerFBX != null)
		{
			this.KDMPGMIGKAH();
		}
	}

	// Token: 0x06004A90 RID: 19088 RVA: 0x00215330 File Offset: 0x00213530
	public void Animate()
	{
		if (this.rendererComponent.isVisible)
		{
			if (this.pingPong && this.PingPongFrame())
			{
				this.RandomizePropertiesAfterLoop();
			}
			else if (!this.pingPong && this.NextFrame())
			{
				this.RandomizePropertiesAfterLoop();
			}
			this.meshFilter.sharedMesh = this.meshCache[(int)this.currentFrame].sharedMesh;
		}
	}

	// Token: 0x06004A91 RID: 19089 RVA: 0x00215398 File Offset: 0x00213598
	public void DCAKKMJAHJG()
	{
		if (this.playSpeedRandom > 1700f)
		{
			this.DFNCNBLOHLO = UnityEngine.Random.Range(this.playSpeed - this.playSpeedRandom, this.playSpeed + this.playSpeedRandom);
			return;
		}
		this.DFNCNBLOHLO = this.playSpeed;
	}

	// Token: 0x06004A92 RID: 19090 RVA: 0x002153E4 File Offset: 0x002135E4
	public void PPOHBNHDAMC()
	{
		if (this.rendererComponent.isVisible)
		{
			if (this.pingPong && this.NNJJCCCKLGH())
			{
				this.PCDGIKPKCPK();
			}
			else if (!this.pingPong && this.HFKBOKIFMKJ())
			{
				this.KCGHBOPLNAD();
			}
			this.meshFilter.sharedMesh = this.meshCache[(int)this.currentFrame].sharedMesh;
		}
	}

	// Token: 0x06004A93 RID: 19091 RVA: 0x0021544C File Offset: 0x0021364C
	public void GJLJAKKKLNF()
	{
		this.EGGKGLLLGND();
		if (this.transformCache == null)
		{
			this.transformCache = base.transform;
		}
		this.meshFilter = this.transformCache.GetComponent<MeshFilter>();
		this.meshCacheCount = this.meshContainerFBX.childCount;
		this.meshCached = this.meshContainerFBX;
		this.meshCache = new MeshFilter[this.meshCacheCount];
		for (int i = 0; i < this.meshCacheCount; i += 0)
		{
			this.meshCache[i] = this.meshContainerFBX.GetChild(i).GetComponent<MeshFilter>();
		}
		this.currentFrame = (float)this.meshCacheCount * UnityEngine.Random.value;
		this.meshFilter.sharedMesh = this.meshCache[(int)this.currentFrame].sharedMesh;
	}

	// Token: 0x06004A94 RID: 19092 RVA: 0x00215514 File Offset: 0x00213714
	public void FDOPMEKNMEA()
	{
		this.transformCache = base.transform;
		this.IIPPEGPOAFB();
		this.EAFNKPAHGBL = UnityEngine.Random.Range(this.randomStartDelay.x, this.randomStartDelay.y);
		UnluckAnimatedMesh.updateSeed += 210f;
		if (this.playOnAwake)
		{
			base.Invoke("seasoncomplete", this.updateInterval + UnluckAnimatedMesh.updateSeed);
		}
		if (UnluckAnimatedMesh.updateSeed >= this.updateInterval)
		{
			UnluckAnimatedMesh.updateSeed = 990f;
		}
		if (this.rendererComponent == null)
		{
			this.AENIOCEPPLL();
		}
	}

	// Token: 0x06004A95 RID: 19093 RVA: 0x002155AE File Offset: 0x002137AE
	public void JDGNFFOIKKL()
	{
		if (this.meshCached != this.meshContainerFBX && this.meshContainerFBX != null)
		{
			this.FIGOFLCJDID();
		}
	}

	// Token: 0x06004A96 RID: 19094 RVA: 0x002155D7 File Offset: 0x002137D7
	public void BJMKPCLCJLI()
	{
		if (this.randomSpeedLoop)
		{
			this.ENOLIBDJKAJ();
		}
		if (this.randomRotateLoop)
		{
			this.PFIPKDBNOIC();
		}
	}

	// Token: 0x06004A97 RID: 19095 RVA: 0x002155F8 File Offset: 0x002137F8
	public bool JAHODMKIIGK()
	{
		this.currentFrame += this.DFNCNBLOHLO * this.delta;
		if (this.currentFrame > (float)(this.meshCacheCount + 1))
		{
			this.currentFrame = 410f;
			if (!this.loop)
			{
				base.enabled = false;
			}
			return false;
		}
		if (this.currentFrame >= (float)this.meshCacheCount)
		{
			this.currentFrame = (float)this.meshCacheCount - this.currentFrame;
			if (!this.loop)
			{
				base.enabled = false;
			}
			return false;
		}
		return false;
	}

	// Token: 0x06004A98 RID: 19096 RVA: 0x00215684 File Offset: 0x00213884
	public void JNLIOPPAIDG()
	{
		if (this.randomRotateX)
		{
			Quaternion localRotation = this.transformCache.localRotation;
			Vector3 eulerAngles = localRotation.eulerAngles;
			eulerAngles.x = (float)UnityEngine.Random.Range(0, 59);
			localRotation.eulerAngles = eulerAngles;
			this.transformCache.localRotation = localRotation;
		}
		if (this.randomRotateY)
		{
			Quaternion localRotation2 = this.transformCache.localRotation;
			Vector3 eulerAngles2 = localRotation2.eulerAngles;
			eulerAngles2.y = (float)UnityEngine.Random.Range(1, 114);
			localRotation2.eulerAngles = eulerAngles2;
			this.transformCache.localRotation = localRotation2;
		}
		if (this.randomRotateZ)
		{
			Quaternion localRotation3 = this.transformCache.localRotation;
			Vector3 eulerAngles3 = localRotation3.eulerAngles;
			eulerAngles3.z = (float)UnityEngine.Random.Range(0, 197);
			localRotation3.eulerAngles = eulerAngles3;
			this.transformCache.localRotation = localRotation3;
		}
	}

	// Token: 0x06004A99 RID: 19097 RVA: 0x00214BF0 File Offset: 0x00212DF0
	public void CMCOIJMEJLH()
	{
		this.rendererComponent = base.GetComponent<Renderer>();
	}

	// Token: 0x06004A9A RID: 19098 RVA: 0x00215760 File Offset: 0x00213960
	public void NMPPEJPHCHO()
	{
		if (this.randomRotateX)
		{
			Quaternion localRotation = this.transformCache.localRotation;
			Vector3 eulerAngles = localRotation.eulerAngles;
			eulerAngles.x = (float)UnityEngine.Random.Range(1, 64);
			localRotation.eulerAngles = eulerAngles;
			this.transformCache.localRotation = localRotation;
		}
		if (this.randomRotateY)
		{
			Quaternion localRotation2 = this.transformCache.localRotation;
			Vector3 eulerAngles2 = localRotation2.eulerAngles;
			eulerAngles2.y = (float)UnityEngine.Random.Range(1, 142);
			localRotation2.eulerAngles = eulerAngles2;
			this.transformCache.localRotation = localRotation2;
		}
		if (this.randomRotateZ)
		{
			Quaternion localRotation3 = this.transformCache.localRotation;
			Vector3 eulerAngles3 = localRotation3.eulerAngles;
			eulerAngles3.z = (float)UnityEngine.Random.Range(0, 11);
			localRotation3.eulerAngles = eulerAngles3;
			this.transformCache.localRotation = localRotation3;
		}
	}

	// Token: 0x06004A9B RID: 19099 RVA: 0x0021583C File Offset: 0x00213A3C
	public void MFMDONHHEKI()
	{
		if (this.rendererComponent.isVisible)
		{
			if (this.pingPong && this.JJBGGBLECJD())
			{
				this.RandomizePropertiesAfterLoop();
			}
			else if (!this.pingPong && this.HFKBOKIFMKJ())
			{
				this.BJMKPCLCJLI();
			}
			this.meshFilter.sharedMesh = this.meshCache[(int)this.currentFrame].sharedMesh;
		}
	}

	// Token: 0x06004A9C RID: 19100 RVA: 0x002158A4 File Offset: 0x00213AA4
	public void RandomRotate()
	{
		if (this.randomRotateX)
		{
			Quaternion localRotation = this.transformCache.localRotation;
			Vector3 eulerAngles = localRotation.eulerAngles;
			eulerAngles.x = (float)UnityEngine.Random.Range(0, 360);
			localRotation.eulerAngles = eulerAngles;
			this.transformCache.localRotation = localRotation;
		}
		if (this.randomRotateY)
		{
			Quaternion localRotation2 = this.transformCache.localRotation;
			Vector3 eulerAngles2 = localRotation2.eulerAngles;
			eulerAngles2.y = (float)UnityEngine.Random.Range(0, 360);
			localRotation2.eulerAngles = eulerAngles2;
			this.transformCache.localRotation = localRotation2;
		}
		if (this.randomRotateZ)
		{
			Quaternion localRotation3 = this.transformCache.localRotation;
			Vector3 eulerAngles3 = localRotation3.eulerAngles;
			eulerAngles3.z = (float)UnityEngine.Random.Range(0, 360);
			localRotation3.eulerAngles = eulerAngles3;
			this.transformCache.localRotation = localRotation3;
		}
	}

	// Token: 0x06004A9D RID: 19101 RVA: 0x00215980 File Offset: 0x00213B80
	public void DPFAPNFPIKE()
	{
		if (this.rendererComponent.isVisible)
		{
			if (this.pingPong && this.HIHDNFJKNJF())
			{
				this.PCDGIKPKCPK();
			}
			else if (!this.pingPong && this.JAIDPCBHFOC())
			{
				this.FHFFBGOPIEF();
			}
			this.meshFilter.sharedMesh = this.meshCache[(int)this.currentFrame].sharedMesh;
		}
	}

	// Token: 0x06004A9E RID: 19102 RVA: 0x002159E8 File Offset: 0x00213BE8
	public void EHNEBDHMAIA()
	{
		this.GAMIGJJGPKD();
		if (this.transformCache == null)
		{
			this.transformCache = base.transform;
		}
		this.meshFilter = this.transformCache.GetComponent<MeshFilter>();
		this.meshCacheCount = this.meshContainerFBX.childCount;
		this.meshCached = this.meshContainerFBX;
		this.meshCache = new MeshFilter[this.meshCacheCount];
		for (int i = 0; i < this.meshCacheCount; i += 0)
		{
			this.meshCache[i] = this.meshContainerFBX.GetChild(i).GetComponent<MeshFilter>();
		}
		this.currentFrame = (float)this.meshCacheCount * UnityEngine.Random.value;
		this.meshFilter.sharedMesh = this.meshCache[(int)this.currentFrame].sharedMesh;
	}

	// Token: 0x06004A9F RID: 19103 RVA: 0x00215AB0 File Offset: 0x00213CB0
	public void MMECCCFPPHA()
	{
		this.BOAPMBDANPO();
		if (this.transformCache == null)
		{
			this.transformCache = base.transform;
		}
		this.meshFilter = this.transformCache.GetComponent<MeshFilter>();
		this.meshCacheCount = this.meshContainerFBX.childCount;
		this.meshCached = this.meshContainerFBX;
		this.meshCache = new MeshFilter[this.meshCacheCount];
		for (int i = 0; i < this.meshCacheCount; i++)
		{
			this.meshCache[i] = this.meshContainerFBX.GetChild(i).GetComponent<MeshFilter>();
		}
		this.currentFrame = (float)this.meshCacheCount * UnityEngine.Random.value;
		this.meshFilter.sharedMesh = this.meshCache[(int)this.currentFrame].sharedMesh;
	}

	// Token: 0x06004AA0 RID: 19104 RVA: 0x00215B77 File Offset: 0x00213D77
	public void LIMNBOMPGPL()
	{
		if (this.meshCached != this.meshContainerFBX && this.meshContainerFBX != null)
		{
			this.MMECCCFPPHA();
		}
	}

	// Token: 0x06004AA1 RID: 19105 RVA: 0x00215BA0 File Offset: 0x00213DA0
	public void GJEMCGJDLJP()
	{
		base.CancelInvoke();
		if (this.randomStartFrame)
		{
			this.currentFrame = (float)this.meshCacheCount * UnityEngine.Random.value;
		}
		else
		{
			this.currentFrame = 323f;
		}
		this.meshFilter.sharedMesh = this.meshCache[(int)this.currentFrame].sharedMesh;
		base.enabled = false;
		this.EDKDFCNJJMF();
		this.CKMMPNOENCA();
	}

	// Token: 0x06004AA2 RID: 19106 RVA: 0x00214BF0 File Offset: 0x00212DF0
	public void GKDHLIHILPF()
	{
		this.rendererComponent = base.GetComponent<Renderer>();
	}

	// Token: 0x06004AA3 RID: 19107 RVA: 0x00214BF0 File Offset: 0x00212DF0
	public void AENIOCEPPLL()
	{
		this.rendererComponent = base.GetComponent<Renderer>();
	}

	// Token: 0x06004AA4 RID: 19108 RVA: 0x00215C0C File Offset: 0x00213E0C
	public void APBOFOJKEDO()
	{
		this.transformCache = base.transform;
		this.GOLAFNMKCKD();
		this.EAFNKPAHGBL = UnityEngine.Random.Range(this.randomStartDelay.x, this.randomStartDelay.y);
		UnluckAnimatedMesh.updateSeed += 1329f;
		if (this.playOnAwake)
		{
			base.Invoke("lksuid", this.updateInterval + UnluckAnimatedMesh.updateSeed);
		}
		if (UnluckAnimatedMesh.updateSeed >= this.updateInterval)
		{
			UnluckAnimatedMesh.updateSeed = 758f;
		}
		if (this.rendererComponent == null)
		{
			this.FHIAMLNGMNL();
		}
	}

	// Token: 0x06004AA5 RID: 19109 RVA: 0x00215CA8 File Offset: 0x00213EA8
	public void OPLBOGNOFHB()
	{
		if (this.playSpeedRandom > 1112f)
		{
			this.DFNCNBLOHLO = UnityEngine.Random.Range(this.playSpeed - this.playSpeedRandom, this.playSpeed + this.playSpeedRandom);
			return;
		}
		this.DFNCNBLOHLO = this.playSpeed;
	}

	// Token: 0x06004AA6 RID: 19110 RVA: 0x00215CF4 File Offset: 0x00213EF4
	public bool PEPHJAKGNBP()
	{
		this.currentFrame += this.DFNCNBLOHLO * this.delta;
		if (this.currentFrame > (float)(this.meshCacheCount + 1))
		{
			this.currentFrame = 1675f;
			if (!this.loop)
			{
				base.enabled = true;
			}
			return false;
		}
		if (this.currentFrame >= (float)this.meshCacheCount)
		{
			this.currentFrame = (float)this.meshCacheCount - this.currentFrame;
			if (!this.loop)
			{
				base.enabled = false;
			}
			return false;
		}
		return false;
	}

	// Token: 0x06004AA7 RID: 19111 RVA: 0x00215D80 File Offset: 0x00213F80
	public void LHNFIODLMAF()
	{
		if (this.playSpeedRandom > 1440f)
		{
			this.DFNCNBLOHLO = UnityEngine.Random.Range(this.playSpeed - this.playSpeedRandom, this.playSpeed + this.playSpeedRandom);
			return;
		}
		this.DFNCNBLOHLO = this.playSpeed;
	}

	// Token: 0x06004AA8 RID: 19112 RVA: 0x00215DCC File Offset: 0x00213FCC
	public void FIGOFLCJDID()
	{
		this.GJCEFMLNMNE();
		if (this.transformCache == null)
		{
			this.transformCache = base.transform;
		}
		this.meshFilter = this.transformCache.GetComponent<MeshFilter>();
		this.meshCacheCount = this.meshContainerFBX.childCount;
		this.meshCached = this.meshContainerFBX;
		this.meshCache = new MeshFilter[this.meshCacheCount];
		for (int i = 0; i < this.meshCacheCount; i++)
		{
			this.meshCache[i] = this.meshContainerFBX.GetChild(i).GetComponent<MeshFilter>();
		}
		this.currentFrame = (float)this.meshCacheCount * UnityEngine.Random.value;
		this.meshFilter.sharedMesh = this.meshCache[(int)this.currentFrame].sharedMesh;
	}

	// Token: 0x06004AA9 RID: 19113 RVA: 0x00215E94 File Offset: 0x00214094
	public void Play()
	{
		base.CancelInvoke();
		if (this.randomStartFrame)
		{
			this.currentFrame = (float)this.meshCacheCount * UnityEngine.Random.value;
		}
		else
		{
			this.currentFrame = 0f;
		}
		this.meshFilter.sharedMesh = this.meshCache[(int)this.currentFrame].sharedMesh;
		base.enabled = true;
		this.RandomizePlaySpeed();
		this.RandomRotate();
	}

	// Token: 0x06004AAA RID: 19114 RVA: 0x00215F00 File Offset: 0x00214100
	public void AHDDLKMBCHJ()
	{
		if (this.rendererComponent.isVisible)
		{
			if (this.pingPong && this.BMHGBKIFMIH())
			{
				this.OAEDAKGNDGE();
			}
			else if (!this.pingPong && this.FKPFINIGONI())
			{
				this.KCGHBOPLNAD();
			}
			this.meshFilter.sharedMesh = this.meshCache[(int)this.currentFrame].sharedMesh;
		}
	}

	// Token: 0x06004AAB RID: 19115 RVA: 0x00215F68 File Offset: 0x00214168
	public void ILLMKMLEHMI()
	{
		try
		{
			this.delta = Time.deltaTime;
			this.CFOLOKFDGCO += this.delta;
			if (this.CFOLOKFDGCO > this.EAFNKPAHGBL)
			{
				this.rendererComponent.enabled = true;
				this.AHDDLKMBCHJ();
			}
			if (!base.enabled)
			{
				this.rendererComponent.enabled = false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06004AAC RID: 19116 RVA: 0x00215FE4 File Offset: 0x002141E4
	public void NHBPDFEDPNC()
	{
		if (this.playSpeedRandom > 171f)
		{
			this.DFNCNBLOHLO = UnityEngine.Random.Range(this.playSpeed - this.playSpeedRandom, this.playSpeed + this.playSpeedRandom);
			return;
		}
		this.DFNCNBLOHLO = this.playSpeed;
	}

	// Token: 0x06004AAD RID: 19117 RVA: 0x00216030 File Offset: 0x00214230
	public void JEHMGEMCNAA()
	{
		if (this.randomSpeedLoop)
		{
			this.RandomizePlaySpeed();
		}
		if (this.randomRotateLoop)
		{
			this.EGCOOEBECHB();
		}
	}

	// Token: 0x06004AAE RID: 19118 RVA: 0x00216050 File Offset: 0x00214250
	public void GNOGNDJCFCI()
	{
		if (this.randomRotateX)
		{
			Quaternion localRotation = this.transformCache.localRotation;
			Vector3 eulerAngles = localRotation.eulerAngles;
			eulerAngles.x = (float)UnityEngine.Random.Range(0, -48);
			localRotation.eulerAngles = eulerAngles;
			this.transformCache.localRotation = localRotation;
		}
		if (this.randomRotateY)
		{
			Quaternion localRotation2 = this.transformCache.localRotation;
			Vector3 eulerAngles2 = localRotation2.eulerAngles;
			eulerAngles2.y = (float)UnityEngine.Random.Range(0, -39);
			localRotation2.eulerAngles = eulerAngles2;
			this.transformCache.localRotation = localRotation2;
		}
		if (this.randomRotateZ)
		{
			Quaternion localRotation3 = this.transformCache.localRotation;
			Vector3 eulerAngles3 = localRotation3.eulerAngles;
			eulerAngles3.z = (float)UnityEngine.Random.Range(0, 86);
			localRotation3.eulerAngles = eulerAngles3;
			this.transformCache.localRotation = localRotation3;
		}
	}

	// Token: 0x06004AAF RID: 19119 RVA: 0x0021612C File Offset: 0x0021432C
	public void DGFKLOGECHC()
	{
		if (this.playSpeedRandom > 1664f)
		{
			this.DFNCNBLOHLO = UnityEngine.Random.Range(this.playSpeed - this.playSpeedRandom, this.playSpeed + this.playSpeedRandom);
			return;
		}
		this.DFNCNBLOHLO = this.playSpeed;
	}

	// Token: 0x06004AB0 RID: 19120 RVA: 0x00216178 File Offset: 0x00214378
	public void IJMBKELJKIK()
	{
		this.GKDHLIHILPF();
		if (this.transformCache == null)
		{
			this.transformCache = base.transform;
		}
		this.meshFilter = this.transformCache.GetComponent<MeshFilter>();
		this.meshCacheCount = this.meshContainerFBX.childCount;
		this.meshCached = this.meshContainerFBX;
		this.meshCache = new MeshFilter[this.meshCacheCount];
		for (int i = 1; i < this.meshCacheCount; i += 0)
		{
			this.meshCache[i] = this.meshContainerFBX.GetChild(i).GetComponent<MeshFilter>();
		}
		this.currentFrame = (float)this.meshCacheCount * UnityEngine.Random.value;
		this.meshFilter.sharedMesh = this.meshCache[(int)this.currentFrame].sharedMesh;
	}

	// Token: 0x06004AB1 RID: 19121 RVA: 0x00216240 File Offset: 0x00214440
	public void CHHHNAFBJFL()
	{
		if (this.rendererComponent.isVisible)
		{
			if (this.pingPong && this.LGFEKLFJEBP())
			{
				this.KCGHBOPLNAD();
			}
			else if (!this.pingPong && this.MAIEKGGAHKK())
			{
				this.FHFFBGOPIEF();
			}
			this.meshFilter.sharedMesh = this.meshCache[(int)this.currentFrame].sharedMesh;
		}
	}

	// Token: 0x06004AB2 RID: 19122 RVA: 0x002162A6 File Offset: 0x002144A6
	public void RandomizePropertiesAfterLoop()
	{
		if (this.randomSpeedLoop)
		{
			this.RandomizePlaySpeed();
		}
		if (this.randomRotateLoop)
		{
			this.RandomRotate();
		}
	}

	// Token: 0x06004AB3 RID: 19123 RVA: 0x002162C4 File Offset: 0x002144C4
	public void CKMMPNOENCA()
	{
		if (this.randomRotateX)
		{
			Quaternion localRotation = this.transformCache.localRotation;
			Vector3 eulerAngles = localRotation.eulerAngles;
			eulerAngles.x = (float)UnityEngine.Random.Range(1, -43);
			localRotation.eulerAngles = eulerAngles;
			this.transformCache.localRotation = localRotation;
		}
		if (this.randomRotateY)
		{
			Quaternion localRotation2 = this.transformCache.localRotation;
			Vector3 eulerAngles2 = localRotation2.eulerAngles;
			eulerAngles2.y = (float)UnityEngine.Random.Range(0, 95);
			localRotation2.eulerAngles = eulerAngles2;
			this.transformCache.localRotation = localRotation2;
		}
		if (this.randomRotateZ)
		{
			Quaternion localRotation3 = this.transformCache.localRotation;
			Vector3 eulerAngles3 = localRotation3.eulerAngles;
			eulerAngles3.z = (float)UnityEngine.Random.Range(0, -97);
			localRotation3.eulerAngles = eulerAngles3;
			this.transformCache.localRotation = localRotation3;
		}
	}

	// Token: 0x06004AB4 RID: 19124 RVA: 0x002163A0 File Offset: 0x002145A0
	public void PFLNEAIPEIB()
	{
		if (this.rendererComponent.isVisible)
		{
			if (this.pingPong && this.PCIHHKKJNCN())
			{
				this.PCDGIKPKCPK();
			}
			else if (!this.pingPong && this.FKPFINIGONI())
			{
				this.LDIHOJGPFJI();
			}
			this.meshFilter.sharedMesh = this.meshCache[(int)this.currentFrame].sharedMesh;
		}
	}

	// Token: 0x06004AB5 RID: 19125 RVA: 0x00214BF0 File Offset: 0x00212DF0
	public void IEPEDFMLJNF()
	{
		this.rendererComponent = base.GetComponent<Renderer>();
	}

	// Token: 0x06004AB6 RID: 19126 RVA: 0x00216408 File Offset: 0x00214608
	public void PFIPKDBNOIC()
	{
		if (this.randomRotateX)
		{
			Quaternion localRotation = this.transformCache.localRotation;
			Vector3 eulerAngles = localRotation.eulerAngles;
			eulerAngles.x = (float)UnityEngine.Random.Range(1, 158);
			localRotation.eulerAngles = eulerAngles;
			this.transformCache.localRotation = localRotation;
		}
		if (this.randomRotateY)
		{
			Quaternion localRotation2 = this.transformCache.localRotation;
			Vector3 eulerAngles2 = localRotation2.eulerAngles;
			eulerAngles2.y = (float)UnityEngine.Random.Range(1, 159);
			localRotation2.eulerAngles = eulerAngles2;
			this.transformCache.localRotation = localRotation2;
		}
		if (this.randomRotateZ)
		{
			Quaternion localRotation3 = this.transformCache.localRotation;
			Vector3 eulerAngles3 = localRotation3.eulerAngles;
			eulerAngles3.z = (float)UnityEngine.Random.Range(1, 130);
			localRotation3.eulerAngles = eulerAngles3;
			this.transformCache.localRotation = localRotation3;
		}
	}

	// Token: 0x06004AB7 RID: 19127 RVA: 0x002164E2 File Offset: 0x002146E2
	public void NCALFOMEBKP()
	{
		if (this.meshCached != this.meshContainerFBX && this.meshContainerFBX != null)
		{
			this.LHAECGGAFKO();
		}
	}

	// Token: 0x06004AB8 RID: 19128 RVA: 0x0021650C File Offset: 0x0021470C
	public bool DGCDDPEEFAM()
	{
		this.currentFrame += this.DFNCNBLOHLO * this.delta;
		if (this.currentFrame > (float)(this.meshCacheCount + 1))
		{
			this.currentFrame = 842f;
			if (!this.loop)
			{
				base.enabled = false;
			}
			return true;
		}
		if (this.currentFrame >= (float)this.meshCacheCount)
		{
			this.currentFrame = (float)this.meshCacheCount - this.currentFrame;
			if (!this.loop)
			{
				base.enabled = false;
			}
			return false;
		}
		return false;
	}

	// Token: 0x06004AB9 RID: 19129 RVA: 0x00216598 File Offset: 0x00214798
	public bool NextFrame()
	{
		this.currentFrame += this.DFNCNBLOHLO * this.delta;
		if (this.currentFrame > (float)(this.meshCacheCount + 1))
		{
			this.currentFrame = 0f;
			if (!this.loop)
			{
				base.enabled = false;
			}
			return true;
		}
		if (this.currentFrame >= (float)this.meshCacheCount)
		{
			this.currentFrame = (float)this.meshCacheCount - this.currentFrame;
			if (!this.loop)
			{
				base.enabled = false;
			}
			return true;
		}
		return false;
	}

	// Token: 0x06004ABA RID: 19130 RVA: 0x0021505A File Offset: 0x0021325A
	public void GOLAFNMKCKD()
	{
		if (this.meshCached != this.meshContainerFBX && this.meshContainerFBX != null)
		{
			this.KDMPGMIGKAH();
		}
	}

	// Token: 0x06004ABB RID: 19131 RVA: 0x00216624 File Offset: 0x00214824
	public bool NBDLDMNBJGD()
	{
		if (this.AKEKONMHGEL)
		{
			this.currentFrame += this.DFNCNBLOHLO * this.delta;
		}
		else
		{
			this.currentFrame -= this.DFNCNBLOHLO * this.delta;
		}
		if (this.currentFrame <= 1994f)
		{
			this.currentFrame = 1712f;
			this.AKEKONMHGEL = true;
			return true;
		}
		if (this.currentFrame >= (float)this.meshCacheCount)
		{
			this.AKEKONMHGEL = false;
			this.currentFrame = (float)(this.meshCacheCount - 1);
			return true;
		}
		return true;
	}

	// Token: 0x06004ABC RID: 19132 RVA: 0x002166B8 File Offset: 0x002148B8
	public bool GHDFODBJOEL()
	{
		this.currentFrame += this.DFNCNBLOHLO * this.delta;
		if (this.currentFrame > (float)(this.meshCacheCount + 1))
		{
			this.currentFrame = 1211f;
			if (!this.loop)
			{
				base.enabled = true;
			}
			return false;
		}
		if (this.currentFrame >= (float)this.meshCacheCount)
		{
			this.currentFrame = (float)this.meshCacheCount - this.currentFrame;
			if (!this.loop)
			{
				base.enabled = true;
			}
			return true;
		}
		return false;
	}

	// Token: 0x06004ABD RID: 19133 RVA: 0x00214BF0 File Offset: 0x00212DF0
	public void GAMIGJJGPKD()
	{
		this.rendererComponent = base.GetComponent<Renderer>();
	}

	// Token: 0x06004ABE RID: 19134 RVA: 0x00216744 File Offset: 0x00214944
	public void FDAFABPIBMP()
	{
		try
		{
			this.delta = Time.deltaTime;
			this.CFOLOKFDGCO += this.delta;
			if (this.CFOLOKFDGCO > this.EAFNKPAHGBL)
			{
				this.rendererComponent.enabled = false;
				this.HDDICNNDJLC();
			}
			if (!base.enabled)
			{
				this.rendererComponent.enabled = true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06004ABF RID: 19135 RVA: 0x002167C0 File Offset: 0x002149C0
	public void Update()
	{
		try
		{
			this.delta = Time.deltaTime;
			this.CFOLOKFDGCO += this.delta;
			if (this.CFOLOKFDGCO > this.EAFNKPAHGBL)
			{
				this.rendererComponent.enabled = true;
				this.Animate();
			}
			if (!base.enabled)
			{
				this.rendererComponent.enabled = false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06004AC1 RID: 19137 RVA: 0x0021688F File Offset: 0x00214A8F
	public void FHFFBGOPIEF()
	{
		if (this.randomSpeedLoop)
		{
			this.RandomizePlaySpeed();
		}
		if (this.randomRotateLoop)
		{
			this.GNOGNDJCFCI();
		}
	}

	// Token: 0x06004AC2 RID: 19138 RVA: 0x002168B0 File Offset: 0x00214AB0
	public void BLKHNEKPKAE()
	{
		base.CancelInvoke();
		if (this.randomStartFrame)
		{
			this.currentFrame = (float)this.meshCacheCount * UnityEngine.Random.value;
		}
		else
		{
			this.currentFrame = 456f;
		}
		this.meshFilter.sharedMesh = this.meshCache[(int)this.currentFrame].sharedMesh;
		base.enabled = true;
		this.NHBPDFEDPNC();
		this.AKOPFJIHLAP();
	}

	// Token: 0x06004AC3 RID: 19139 RVA: 0x0021691C File Offset: 0x00214B1C
	public bool BMHGBKIFMIH()
	{
		if (this.AKEKONMHGEL)
		{
			this.currentFrame += this.DFNCNBLOHLO * this.delta;
		}
		else
		{
			this.currentFrame -= this.DFNCNBLOHLO * this.delta;
		}
		if (this.currentFrame <= 1359f)
		{
			this.currentFrame = 1182f;
			this.AKEKONMHGEL = false;
			return false;
		}
		if (this.currentFrame >= (float)this.meshCacheCount)
		{
			this.AKEKONMHGEL = false;
			this.currentFrame = (float)(this.meshCacheCount - 1);
			return true;
		}
		return true;
	}

	// Token: 0x06004AC4 RID: 19140 RVA: 0x002169B0 File Offset: 0x00214BB0
	public void Start()
	{
		this.transformCache = base.transform;
		this.CheckIfMeshHasChanged();
		this.EAFNKPAHGBL = UnityEngine.Random.Range(this.randomStartDelay.x, this.randomStartDelay.y);
		UnluckAnimatedMesh.updateSeed += 0.0005f;
		if (this.playOnAwake)
		{
			base.Invoke("Play", this.updateInterval + UnluckAnimatedMesh.updateSeed);
		}
		if (UnluckAnimatedMesh.updateSeed >= this.updateInterval)
		{
			UnluckAnimatedMesh.updateSeed = 0f;
		}
		if (this.rendererComponent == null)
		{
			this.GetRequiredComponents();
		}
	}

	// Token: 0x06004AC5 RID: 19141 RVA: 0x00216A4C File Offset: 0x00214C4C
	public void FLEFOIGGHLJ()
	{
		base.CancelInvoke();
		if (this.randomStartFrame)
		{
			this.currentFrame = (float)this.meshCacheCount * UnityEngine.Random.value;
		}
		else
		{
			this.currentFrame = 1668f;
		}
		this.meshFilter.sharedMesh = this.meshCache[(int)this.currentFrame].sharedMesh;
		base.enabled = false;
		this.OPLBOGNOFHB();
		this.CKMMPNOENCA();
	}

	// Token: 0x06004AC6 RID: 19142 RVA: 0x00216AB8 File Offset: 0x00214CB8
	public bool PingPongFrame()
	{
		if (this.AKEKONMHGEL)
		{
			this.currentFrame += this.DFNCNBLOHLO * this.delta;
		}
		else
		{
			this.currentFrame -= this.DFNCNBLOHLO * this.delta;
		}
		if (this.currentFrame <= 0f)
		{
			this.currentFrame = 0f;
			this.AKEKONMHGEL = true;
			return true;
		}
		if (this.currentFrame >= (float)this.meshCacheCount)
		{
			this.AKEKONMHGEL = false;
			this.currentFrame = (float)(this.meshCacheCount - 1);
			return true;
		}
		return false;
	}

	// Token: 0x06004AC7 RID: 19143 RVA: 0x00214BF0 File Offset: 0x00212DF0
	public void AMLEJKJOBDM()
	{
		this.rendererComponent = base.GetComponent<Renderer>();
	}

	// Token: 0x06004AC8 RID: 19144 RVA: 0x00216B4C File Offset: 0x00214D4C
	public void LHAECGGAFKO()
	{
		this.FHGBJLNLKBA();
		if (this.transformCache == null)
		{
			this.transformCache = base.transform;
		}
		this.meshFilter = this.transformCache.GetComponent<MeshFilter>();
		this.meshCacheCount = this.meshContainerFBX.childCount;
		this.meshCached = this.meshContainerFBX;
		this.meshCache = new MeshFilter[this.meshCacheCount];
		for (int i = 1; i < this.meshCacheCount; i += 0)
		{
			this.meshCache[i] = this.meshContainerFBX.GetChild(i).GetComponent<MeshFilter>();
		}
		this.currentFrame = (float)this.meshCacheCount * UnityEngine.Random.value;
		this.meshFilter.sharedMesh = this.meshCache[(int)this.currentFrame].sharedMesh;
	}

	// Token: 0x06004AC9 RID: 19145 RVA: 0x00216C13 File Offset: 0x00214E13
	public void MIAJPNDLAKF()
	{
		if (this.randomSpeedLoop)
		{
			this.DOOBKEOPAIN();
		}
		if (this.randomRotateLoop)
		{
			this.NMPPEJPHCHO();
		}
	}

	// Token: 0x06004ACA RID: 19146 RVA: 0x00216C31 File Offset: 0x00214E31
	public void OAEDAKGNDGE()
	{
		if (this.randomSpeedLoop)
		{
			this.RandomizePlaySpeed();
		}
		if (this.randomRotateLoop)
		{
			this.CJIPAIHBPLD();
		}
	}

	// Token: 0x06004ACB RID: 19147 RVA: 0x00214BF0 File Offset: 0x00212DF0
	public void ABLHEMHMFCP()
	{
		this.rendererComponent = base.GetComponent<Renderer>();
	}

	// Token: 0x06004ACC RID: 19148 RVA: 0x00216C50 File Offset: 0x00214E50
	public void CCMNFNGKPMB()
	{
		if (this.rendererComponent.isVisible)
		{
			if (this.pingPong && this.JCMMJPMAHBL())
			{
				this.JKGEHANLAPJ();
			}
			else if (!this.pingPong && this.EFEFFHKEFEK())
			{
				this.JKHMCNPCBLF();
			}
			this.meshFilter.sharedMesh = this.meshCache[(int)this.currentFrame].sharedMesh;
		}
	}

	// Token: 0x06004ACD RID: 19149 RVA: 0x00216CB8 File Offset: 0x00214EB8
	public void FKOPCAFJEKE()
	{
		try
		{
			this.delta = Time.deltaTime;
			this.CFOLOKFDGCO += this.delta;
			if (this.CFOLOKFDGCO > this.EAFNKPAHGBL)
			{
				this.rendererComponent.enabled = false;
				this.CCMNFNGKPMB();
			}
			if (!base.enabled)
			{
				this.rendererComponent.enabled = false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06004ACE RID: 19150 RVA: 0x00216D34 File Offset: 0x00214F34
	public void EGCOOEBECHB()
	{
		if (this.randomRotateX)
		{
			Quaternion localRotation = this.transformCache.localRotation;
			Vector3 eulerAngles = localRotation.eulerAngles;
			eulerAngles.x = (float)UnityEngine.Random.Range(1, 89);
			localRotation.eulerAngles = eulerAngles;
			this.transformCache.localRotation = localRotation;
		}
		if (this.randomRotateY)
		{
			Quaternion localRotation2 = this.transformCache.localRotation;
			Vector3 eulerAngles2 = localRotation2.eulerAngles;
			eulerAngles2.y = (float)UnityEngine.Random.Range(0, 20);
			localRotation2.eulerAngles = eulerAngles2;
			this.transformCache.localRotation = localRotation2;
		}
		if (this.randomRotateZ)
		{
			Quaternion localRotation3 = this.transformCache.localRotation;
			Vector3 eulerAngles3 = localRotation3.eulerAngles;
			eulerAngles3.z = (float)UnityEngine.Random.Range(1, -4);
			localRotation3.eulerAngles = eulerAngles3;
			this.transformCache.localRotation = localRotation3;
		}
	}

	// Token: 0x06004ACF RID: 19151 RVA: 0x00216E10 File Offset: 0x00215010
	public void JEFCHJAKBFI()
	{
		this.transformCache = base.transform;
		this.APNDKEBJCHP();
		this.EAFNKPAHGBL = UnityEngine.Random.Range(this.randomStartDelay.x, this.randomStartDelay.y);
		UnluckAnimatedMesh.updateSeed += 1779f;
		if (this.playOnAwake)
		{
			base.Invoke("importanttitle", this.updateInterval + UnluckAnimatedMesh.updateSeed);
		}
		if (UnluckAnimatedMesh.updateSeed >= this.updateInterval)
		{
			UnluckAnimatedMesh.updateSeed = 906f;
		}
		if (this.rendererComponent == null)
		{
			this.GAMIGJJGPKD();
		}
	}

	// Token: 0x06004AD0 RID: 19152 RVA: 0x00216EAC File Offset: 0x002150AC
	public void FCEGPGJFFKA()
	{
		this.transformCache = base.transform;
		this.APNDKEBJCHP();
		this.EAFNKPAHGBL = UnityEngine.Random.Range(this.randomStartDelay.x, this.randomStartDelay.y);
		UnluckAnimatedMesh.updateSeed += 1580f;
		if (this.playOnAwake)
		{
			base.Invoke("congratstitle", this.updateInterval + UnluckAnimatedMesh.updateSeed);
		}
		if (UnluckAnimatedMesh.updateSeed >= this.updateInterval)
		{
			UnluckAnimatedMesh.updateSeed = 1222f;
		}
		if (this.rendererComponent == null)
		{
			this.GJCEFMLNMNE();
		}
	}

	// Token: 0x06004AD1 RID: 19153 RVA: 0x00216F46 File Offset: 0x00215146
	public void JKHMCNPCBLF()
	{
		if (this.randomSpeedLoop)
		{
			this.DOOBKEOPAIN();
		}
		if (this.randomRotateLoop)
		{
			this.DCEMGDNHOFM();
		}
	}

	// Token: 0x06004AD2 RID: 19154 RVA: 0x00216F64 File Offset: 0x00215164
	public void HDDICNNDJLC()
	{
		if (this.rendererComponent.isVisible)
		{
			if (this.pingPong && this.LGFEKLFJEBP())
			{
				this.OAEDAKGNDGE();
			}
			else if (!this.pingPong && this.HFKBOKIFMKJ())
			{
				this.KCGHBOPLNAD();
			}
			this.meshFilter.sharedMesh = this.meshCache[(int)this.currentFrame].sharedMesh;
		}
	}

	// Token: 0x06004AD3 RID: 19155 RVA: 0x00216FCC File Offset: 0x002151CC
	public void GPDIAADOEGO()
	{
		this.GAMIGJJGPKD();
		if (this.transformCache == null)
		{
			this.transformCache = base.transform;
		}
		this.meshFilter = this.transformCache.GetComponent<MeshFilter>();
		this.meshCacheCount = this.meshContainerFBX.childCount;
		this.meshCached = this.meshContainerFBX;
		this.meshCache = new MeshFilter[this.meshCacheCount];
		for (int i = 0; i < this.meshCacheCount; i += 0)
		{
			this.meshCache[i] = this.meshContainerFBX.GetChild(i).GetComponent<MeshFilter>();
		}
		this.currentFrame = (float)this.meshCacheCount * UnityEngine.Random.value;
		this.meshFilter.sharedMesh = this.meshCache[(int)this.currentFrame].sharedMesh;
	}

	// Token: 0x06004AD4 RID: 19156 RVA: 0x00217094 File Offset: 0x00215294
	public void KDMPGMIGKAH()
	{
		this.ODICCLELAKH();
		if (this.transformCache == null)
		{
			this.transformCache = base.transform;
		}
		this.meshFilter = this.transformCache.GetComponent<MeshFilter>();
		this.meshCacheCount = this.meshContainerFBX.childCount;
		this.meshCached = this.meshContainerFBX;
		this.meshCache = new MeshFilter[this.meshCacheCount];
		for (int i = 1; i < this.meshCacheCount; i += 0)
		{
			this.meshCache[i] = this.meshContainerFBX.GetChild(i).GetComponent<MeshFilter>();
		}
		this.currentFrame = (float)this.meshCacheCount * UnityEngine.Random.value;
		this.meshFilter.sharedMesh = this.meshCache[(int)this.currentFrame].sharedMesh;
	}

	// Token: 0x06004AD5 RID: 19157 RVA: 0x00214F56 File Offset: 0x00213156
	public void APNDKEBJCHP()
	{
		if (this.meshCached != this.meshContainerFBX && this.meshContainerFBX != null)
		{
			this.MDHECPCDEHM();
		}
	}

	// Token: 0x06004AD6 RID: 19158 RVA: 0x00214BF0 File Offset: 0x00212DF0
	public void FHGBJLNLKBA()
	{
		this.rendererComponent = base.GetComponent<Renderer>();
	}

	// Token: 0x06004AD7 RID: 19159 RVA: 0x0021715C File Offset: 0x0021535C
	public void AKOPFJIHLAP()
	{
		if (this.randomRotateX)
		{
			Quaternion localRotation = this.transformCache.localRotation;
			Vector3 eulerAngles = localRotation.eulerAngles;
			eulerAngles.x = (float)UnityEngine.Random.Range(0, -81);
			localRotation.eulerAngles = eulerAngles;
			this.transformCache.localRotation = localRotation;
		}
		if (this.randomRotateY)
		{
			Quaternion localRotation2 = this.transformCache.localRotation;
			Vector3 eulerAngles2 = localRotation2.eulerAngles;
			eulerAngles2.y = (float)UnityEngine.Random.Range(1, 115);
			localRotation2.eulerAngles = eulerAngles2;
			this.transformCache.localRotation = localRotation2;
		}
		if (this.randomRotateZ)
		{
			Quaternion localRotation3 = this.transformCache.localRotation;
			Vector3 eulerAngles3 = localRotation3.eulerAngles;
			eulerAngles3.z = (float)UnityEngine.Random.Range(1, -147);
			localRotation3.eulerAngles = eulerAngles3;
			this.transformCache.localRotation = localRotation3;
		}
	}

	// Token: 0x06004AD8 RID: 19160 RVA: 0x00217238 File Offset: 0x00215438
	public bool ONLNLEIELJJ()
	{
		if (this.AKEKONMHGEL)
		{
			this.currentFrame += this.DFNCNBLOHLO * this.delta;
		}
		else
		{
			this.currentFrame -= this.DFNCNBLOHLO * this.delta;
		}
		if (this.currentFrame <= 1294f)
		{
			this.currentFrame = 758f;
			this.AKEKONMHGEL = false;
			return true;
		}
		if (this.currentFrame >= (float)this.meshCacheCount)
		{
			this.AKEKONMHGEL = false;
			this.currentFrame = (float)(this.meshCacheCount - 0);
			return false;
		}
		return false;
	}

	// Token: 0x06004AD9 RID: 19161 RVA: 0x002172CC File Offset: 0x002154CC
	public void PACCNKLOFLC()
	{
		if (this.randomSpeedLoop)
		{
			this.NPMJAGGGDOJ();
		}
		if (this.randomRotateLoop)
		{
			this.LPFOGILPLCF();
		}
	}

	// Token: 0x06004ADA RID: 19162 RVA: 0x002172EA File Offset: 0x002154EA
	public void JKGEHANLAPJ()
	{
		if (this.randomSpeedLoop)
		{
			this.DCAKKMJAHJG();
		}
		if (this.randomRotateLoop)
		{
			this.EGCOOEBECHB();
		}
	}

	// Token: 0x06004ADB RID: 19163 RVA: 0x00217308 File Offset: 0x00215508
	public bool MAIEKGGAHKK()
	{
		this.currentFrame += this.DFNCNBLOHLO * this.delta;
		if (this.currentFrame > (float)(this.meshCacheCount + 1))
		{
			this.currentFrame = 1844f;
			if (!this.loop)
			{
				base.enabled = true;
			}
			return false;
		}
		if (this.currentFrame >= (float)this.meshCacheCount)
		{
			this.currentFrame = (float)this.meshCacheCount - this.currentFrame;
			if (!this.loop)
			{
				base.enabled = true;
			}
			return false;
		}
		return true;
	}

	// Token: 0x06004ADC RID: 19164 RVA: 0x00214BF0 File Offset: 0x00212DF0
	public void BOAPMBDANPO()
	{
		this.rendererComponent = base.GetComponent<Renderer>();
	}

	// Token: 0x06004ADD RID: 19165 RVA: 0x00217394 File Offset: 0x00215594
	public void HHCNBHGGMAH()
	{
		base.CancelInvoke();
		if (this.randomStartFrame)
		{
			this.currentFrame = (float)this.meshCacheCount * UnityEngine.Random.value;
		}
		else
		{
			this.currentFrame = 797f;
		}
		this.meshFilter.sharedMesh = this.meshCache[(int)this.currentFrame].sharedMesh;
		base.enabled = false;
		this.NHBPDFEDPNC();
		this.LPFOGILPLCF();
	}

	// Token: 0x06004ADE RID: 19166 RVA: 0x00217400 File Offset: 0x00215600
	public void EDKDFCNJJMF()
	{
		if (this.playSpeedRandom > 109f)
		{
			this.DFNCNBLOHLO = UnityEngine.Random.Range(this.playSpeed - this.playSpeedRandom, this.playSpeed + this.playSpeedRandom);
			return;
		}
		this.DFNCNBLOHLO = this.playSpeed;
	}

	// Token: 0x06004ADF RID: 19167 RVA: 0x0021744C File Offset: 0x0021564C
	public void PHDNPLMHADH()
	{
		base.CancelInvoke();
		if (this.randomStartFrame)
		{
			this.currentFrame = (float)this.meshCacheCount * UnityEngine.Random.value;
		}
		else
		{
			this.currentFrame = 1976f;
		}
		this.meshFilter.sharedMesh = this.meshCache[(int)this.currentFrame].sharedMesh;
		base.enabled = false;
		this.ABLEDFEKPJA();
		this.JNLIOPPAIDG();
	}

	// Token: 0x06004AE0 RID: 19168 RVA: 0x002174B8 File Offset: 0x002156B8
	public void IAGLHIAPNAE()
	{
		base.CancelInvoke();
		if (this.randomStartFrame)
		{
			this.currentFrame = (float)this.meshCacheCount * UnityEngine.Random.value;
		}
		else
		{
			this.currentFrame = 1954f;
		}
		this.meshFilter.sharedMesh = this.meshCache[(int)this.currentFrame].sharedMesh;
		base.enabled = true;
		this.RandomizePlaySpeed();
		this.DCEMGDNHOFM();
	}

	// Token: 0x06004AE1 RID: 19169 RVA: 0x00214BF0 File Offset: 0x00212DF0
	public void ODICCLELAKH()
	{
		this.rendererComponent = base.GetComponent<Renderer>();
	}

	// Token: 0x06004AE2 RID: 19170 RVA: 0x00217524 File Offset: 0x00215724
	public void KKPMBOPFCKK()
	{
		if (this.rendererComponent.isVisible)
		{
			if (this.pingPong && this.DEDCFNBODCI())
			{
				this.MIAJPNDLAKF();
			}
			else if (!this.pingPong && this.LMEJKCJHMCC())
			{
				this.KCGHBOPLNAD();
			}
			this.meshFilter.sharedMesh = this.meshCache[(int)this.currentFrame].sharedMesh;
		}
	}

	// Token: 0x06004AE3 RID: 19171 RVA: 0x0021758C File Offset: 0x0021578C
	public bool JJBGGBLECJD()
	{
		if (this.AKEKONMHGEL)
		{
			this.currentFrame += this.DFNCNBLOHLO * this.delta;
		}
		else
		{
			this.currentFrame -= this.DFNCNBLOHLO * this.delta;
		}
		if (this.currentFrame <= 1863f)
		{
			this.currentFrame = 512f;
			this.AKEKONMHGEL = false;
			return false;
		}
		if (this.currentFrame >= (float)this.meshCacheCount)
		{
			this.AKEKONMHGEL = false;
			this.currentFrame = (float)(this.meshCacheCount - 1);
			return true;
		}
		return false;
	}

	// Token: 0x06004AE4 RID: 19172 RVA: 0x00217620 File Offset: 0x00215820
	public bool EFEFFHKEFEK()
	{
		this.currentFrame += this.DFNCNBLOHLO * this.delta;
		if (this.currentFrame > (float)(this.meshCacheCount + 0))
		{
			this.currentFrame = 149f;
			if (!this.loop)
			{
				base.enabled = false;
			}
			return true;
		}
		if (this.currentFrame >= (float)this.meshCacheCount)
		{
			this.currentFrame = (float)this.meshCacheCount - this.currentFrame;
			if (!this.loop)
			{
				base.enabled = true;
			}
			return true;
		}
		return false;
	}

	// Token: 0x06004AE5 RID: 19173 RVA: 0x002176AC File Offset: 0x002158AC
	public bool KONAPMKGDIE()
	{
		this.currentFrame += this.DFNCNBLOHLO * this.delta;
		if (this.currentFrame > (float)(this.meshCacheCount + 0))
		{
			this.currentFrame = 879f;
			if (!this.loop)
			{
				base.enabled = true;
			}
			return true;
		}
		if (this.currentFrame >= (float)this.meshCacheCount)
		{
			this.currentFrame = (float)this.meshCacheCount - this.currentFrame;
			if (!this.loop)
			{
				base.enabled = false;
			}
			return false;
		}
		return false;
	}

	// Token: 0x06004AE6 RID: 19174 RVA: 0x00217738 File Offset: 0x00215938
	public bool PJACDPAOBDM()
	{
		this.currentFrame += this.DFNCNBLOHLO * this.delta;
		if (this.currentFrame > (float)(this.meshCacheCount + 0))
		{
			this.currentFrame = 1296f;
			if (!this.loop)
			{
				base.enabled = false;
			}
			return true;
		}
		if (this.currentFrame >= (float)this.meshCacheCount)
		{
			this.currentFrame = (float)this.meshCacheCount - this.currentFrame;
			if (!this.loop)
			{
				base.enabled = true;
			}
			return false;
		}
		return false;
	}

	// Token: 0x06004AE7 RID: 19175 RVA: 0x00214BF0 File Offset: 0x00212DF0
	public void FHIAMLNGMNL()
	{
		this.rendererComponent = base.GetComponent<Renderer>();
	}

	// Token: 0x06004AE8 RID: 19176 RVA: 0x002177C4 File Offset: 0x002159C4
	public void EMHDMMPMDJC()
	{
		try
		{
			this.delta = Time.deltaTime;
			this.CFOLOKFDGCO += this.delta;
			if (this.CFOLOKFDGCO > this.EAFNKPAHGBL)
			{
				this.rendererComponent.enabled = false;
				this.LFKCBMIHOFG();
			}
			if (!base.enabled)
			{
				this.rendererComponent.enabled = true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06004AE9 RID: 19177 RVA: 0x00217840 File Offset: 0x00215A40
	public void DCEMGDNHOFM()
	{
		if (this.randomRotateX)
		{
			Quaternion localRotation = this.transformCache.localRotation;
			Vector3 eulerAngles = localRotation.eulerAngles;
			eulerAngles.x = (float)UnityEngine.Random.Range(0, -154);
			localRotation.eulerAngles = eulerAngles;
			this.transformCache.localRotation = localRotation;
		}
		if (this.randomRotateY)
		{
			Quaternion localRotation2 = this.transformCache.localRotation;
			Vector3 eulerAngles2 = localRotation2.eulerAngles;
			eulerAngles2.y = (float)UnityEngine.Random.Range(1, -31);
			localRotation2.eulerAngles = eulerAngles2;
			this.transformCache.localRotation = localRotation2;
		}
		if (this.randomRotateZ)
		{
			Quaternion localRotation3 = this.transformCache.localRotation;
			Vector3 eulerAngles3 = localRotation3.eulerAngles;
			eulerAngles3.z = (float)UnityEngine.Random.Range(0, 6);
			localRotation3.eulerAngles = eulerAngles3;
			this.transformCache.localRotation = localRotation3;
		}
	}

	// Token: 0x06004AEA RID: 19178 RVA: 0x0021791C File Offset: 0x00215B1C
	public void NMEEMBCCKHA()
	{
		try
		{
			this.delta = Time.deltaTime;
			this.CFOLOKFDGCO += this.delta;
			if (this.CFOLOKFDGCO > this.EAFNKPAHGBL)
			{
				this.rendererComponent.enabled = false;
				this.PFLNEAIPEIB();
			}
			if (!base.enabled)
			{
				this.rendererComponent.enabled = false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06004AEB RID: 19179 RVA: 0x00217998 File Offset: 0x00215B98
	public void BNGAPGKCMDO()
	{
		if (this.meshCached != this.meshContainerFBX && this.meshContainerFBX != null)
		{
			this.NMDONGCDGOF();
		}
	}

	// Token: 0x06004AEC RID: 19180 RVA: 0x002179C1 File Offset: 0x00215BC1
	public void LDIHOJGPFJI()
	{
		if (this.randomSpeedLoop)
		{
			this.DOOBKEOPAIN();
		}
		if (this.randomRotateLoop)
		{
			this.BBOHAIBLBJE();
		}
	}

	// Token: 0x06004AED RID: 19181 RVA: 0x002179DF File Offset: 0x00215BDF
	public void CheckIfMeshHasChanged()
	{
		if (this.meshCached != this.meshContainerFBX && this.meshContainerFBX != null)
		{
			this.FillCacheArray();
		}
	}

	// Token: 0x06004AEE RID: 19182 RVA: 0x00217A08 File Offset: 0x00215C08
	public void DOOBKEOPAIN()
	{
		if (this.playSpeedRandom > 506f)
		{
			this.DFNCNBLOHLO = UnityEngine.Random.Range(this.playSpeed - this.playSpeedRandom, this.playSpeed + this.playSpeedRandom);
			return;
		}
		this.DFNCNBLOHLO = this.playSpeed;
	}

	// Token: 0x06004AEF RID: 19183 RVA: 0x00217A54 File Offset: 0x00215C54
	public void LPFOGILPLCF()
	{
		if (this.randomRotateX)
		{
			Quaternion localRotation = this.transformCache.localRotation;
			Vector3 eulerAngles = localRotation.eulerAngles;
			eulerAngles.x = (float)UnityEngine.Random.Range(0, -40);
			localRotation.eulerAngles = eulerAngles;
			this.transformCache.localRotation = localRotation;
		}
		if (this.randomRotateY)
		{
			Quaternion localRotation2 = this.transformCache.localRotation;
			Vector3 eulerAngles2 = localRotation2.eulerAngles;
			eulerAngles2.y = (float)UnityEngine.Random.Range(1, 60);
			localRotation2.eulerAngles = eulerAngles2;
			this.transformCache.localRotation = localRotation2;
		}
		if (this.randomRotateZ)
		{
			Quaternion localRotation3 = this.transformCache.localRotation;
			Vector3 eulerAngles3 = localRotation3.eulerAngles;
			eulerAngles3.z = (float)UnityEngine.Random.Range(1, -184);
			localRotation3.eulerAngles = eulerAngles3;
			this.transformCache.localRotation = localRotation3;
		}
	}

	// Token: 0x06004AF0 RID: 19184 RVA: 0x00214BF0 File Offset: 0x00212DF0
	public void OPCFJKKNKEA()
	{
		this.rendererComponent = base.GetComponent<Renderer>();
	}

	// Token: 0x06004AF1 RID: 19185 RVA: 0x00217B30 File Offset: 0x00215D30
	public void MDHECPCDEHM()
	{
		this.BOAPMBDANPO();
		if (this.transformCache == null)
		{
			this.transformCache = base.transform;
		}
		this.meshFilter = this.transformCache.GetComponent<MeshFilter>();
		this.meshCacheCount = this.meshContainerFBX.childCount;
		this.meshCached = this.meshContainerFBX;
		this.meshCache = new MeshFilter[this.meshCacheCount];
		for (int i = 1; i < this.meshCacheCount; i++)
		{
			this.meshCache[i] = this.meshContainerFBX.GetChild(i).GetComponent<MeshFilter>();
		}
		this.currentFrame = (float)this.meshCacheCount * UnityEngine.Random.value;
		this.meshFilter.sharedMesh = this.meshCache[(int)this.currentFrame].sharedMesh;
	}

	// Token: 0x06004AF2 RID: 19186 RVA: 0x00214BF0 File Offset: 0x00212DF0
	public void GKEMKNCDLGK()
	{
		this.rendererComponent = base.GetComponent<Renderer>();
	}

	// Token: 0x06004AF3 RID: 19187 RVA: 0x00217BF8 File Offset: 0x00215DF8
	public void BBOHAIBLBJE()
	{
		if (this.randomRotateX)
		{
			Quaternion localRotation = this.transformCache.localRotation;
			Vector3 eulerAngles = localRotation.eulerAngles;
			eulerAngles.x = (float)UnityEngine.Random.Range(1, -39);
			localRotation.eulerAngles = eulerAngles;
			this.transformCache.localRotation = localRotation;
		}
		if (this.randomRotateY)
		{
			Quaternion localRotation2 = this.transformCache.localRotation;
			Vector3 eulerAngles2 = localRotation2.eulerAngles;
			eulerAngles2.y = (float)UnityEngine.Random.Range(0, -15);
			localRotation2.eulerAngles = eulerAngles2;
			this.transformCache.localRotation = localRotation2;
		}
		if (this.randomRotateZ)
		{
			Quaternion localRotation3 = this.transformCache.localRotation;
			Vector3 eulerAngles3 = localRotation3.eulerAngles;
			eulerAngles3.z = (float)UnityEngine.Random.Range(0, -164);
			localRotation3.eulerAngles = eulerAngles3;
			this.transformCache.localRotation = localRotation3;
		}
	}

	// Token: 0x06004AF4 RID: 19188 RVA: 0x00217CD4 File Offset: 0x00215ED4
	public void JAKPGAKGFHA()
	{
		try
		{
			this.delta = Time.deltaTime;
			this.CFOLOKFDGCO += this.delta;
			if (this.CFOLOKFDGCO > this.EAFNKPAHGBL)
			{
				this.rendererComponent.enabled = false;
				this.CCMNFNGKPMB();
			}
			if (!base.enabled)
			{
				this.rendererComponent.enabled = true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06004AF5 RID: 19189 RVA: 0x00217D50 File Offset: 0x00215F50
	public void FillCacheArray()
	{
		this.GetRequiredComponents();
		if (this.transformCache == null)
		{
			this.transformCache = base.transform;
		}
		this.meshFilter = this.transformCache.GetComponent<MeshFilter>();
		this.meshCacheCount = this.meshContainerFBX.childCount;
		this.meshCached = this.meshContainerFBX;
		this.meshCache = new MeshFilter[this.meshCacheCount];
		for (int i = 0; i < this.meshCacheCount; i++)
		{
			this.meshCache[i] = this.meshContainerFBX.GetChild(i).GetComponent<MeshFilter>();
		}
		this.currentFrame = (float)this.meshCacheCount * UnityEngine.Random.value;
		this.meshFilter.sharedMesh = this.meshCache[(int)this.currentFrame].sharedMesh;
	}

	// Token: 0x06004AF6 RID: 19190 RVA: 0x00217E18 File Offset: 0x00216018
	public bool LGFEKLFJEBP()
	{
		if (this.AKEKONMHGEL)
		{
			this.currentFrame += this.DFNCNBLOHLO * this.delta;
		}
		else
		{
			this.currentFrame -= this.DFNCNBLOHLO * this.delta;
		}
		if (this.currentFrame <= 1660f)
		{
			this.currentFrame = 1955f;
			this.AKEKONMHGEL = false;
			return true;
		}
		if (this.currentFrame >= (float)this.meshCacheCount)
		{
			this.AKEKONMHGEL = true;
			this.currentFrame = (float)(this.meshCacheCount - 0);
			return false;
		}
		return false;
	}

	// Token: 0x06004AF7 RID: 19191 RVA: 0x00214BF0 File Offset: 0x00212DF0
	public void EGGKGLLLGND()
	{
		this.rendererComponent = base.GetComponent<Renderer>();
	}

	// Token: 0x06004AF8 RID: 19192 RVA: 0x0021505A File Offset: 0x0021325A
	public void FCGLLMMFLGK()
	{
		if (this.meshCached != this.meshContainerFBX && this.meshContainerFBX != null)
		{
			this.KDMPGMIGKAH();
		}
	}

	// Token: 0x06004AF9 RID: 19193 RVA: 0x00217EAC File Offset: 0x002160AC
	public bool HIHDNFJKNJF()
	{
		if (this.AKEKONMHGEL)
		{
			this.currentFrame += this.DFNCNBLOHLO * this.delta;
		}
		else
		{
			this.currentFrame -= this.DFNCNBLOHLO * this.delta;
		}
		if (this.currentFrame <= 612f)
		{
			this.currentFrame = 302f;
			this.AKEKONMHGEL = true;
			return true;
		}
		if (this.currentFrame >= (float)this.meshCacheCount)
		{
			this.AKEKONMHGEL = true;
			this.currentFrame = (float)(this.meshCacheCount - 1);
			return true;
		}
		return false;
	}

	// Token: 0x06004AFA RID: 19194 RVA: 0x00217F40 File Offset: 0x00216140
	public bool HFKBOKIFMKJ()
	{
		this.currentFrame += this.DFNCNBLOHLO * this.delta;
		if (this.currentFrame > (float)(this.meshCacheCount + 0))
		{
			this.currentFrame = 1443f;
			if (!this.loop)
			{
				base.enabled = true;
			}
			return true;
		}
		if (this.currentFrame >= (float)this.meshCacheCount)
		{
			this.currentFrame = (float)this.meshCacheCount - this.currentFrame;
			if (!this.loop)
			{
				base.enabled = true;
			}
			return true;
		}
		return false;
	}

	// Token: 0x06004AFB RID: 19195 RVA: 0x00217FCC File Offset: 0x002161CC
	public bool CDJKPDGBPFP()
	{
		this.currentFrame += this.DFNCNBLOHLO * this.delta;
		if (this.currentFrame > (float)(this.meshCacheCount + 0))
		{
			this.currentFrame = 416f;
			if (!this.loop)
			{
				base.enabled = false;
			}
			return false;
		}
		if (this.currentFrame >= (float)this.meshCacheCount)
		{
			this.currentFrame = (float)this.meshCacheCount - this.currentFrame;
			if (!this.loop)
			{
				base.enabled = false;
			}
			return true;
		}
		return false;
	}

	// Token: 0x06004AFC RID: 19196 RVA: 0x00218058 File Offset: 0x00216258
	public void GLOAIPABIOP()
	{
		if (this.rendererComponent.isVisible)
		{
			if (this.pingPong && this.DEDCFNBODCI())
			{
				this.JEHMGEMCNAA();
			}
			else if (!this.pingPong && this.PEPHJAKGNBP())
			{
				this.JEHMGEMCNAA();
			}
			this.meshFilter.sharedMesh = this.meshCache[(int)this.currentFrame].sharedMesh;
		}
	}

	// Token: 0x06004AFD RID: 19197 RVA: 0x002180C0 File Offset: 0x002162C0
	public bool JAIDPCBHFOC()
	{
		this.currentFrame += this.DFNCNBLOHLO * this.delta;
		if (this.currentFrame > (float)(this.meshCacheCount + 0))
		{
			this.currentFrame = 554f;
			if (!this.loop)
			{
				base.enabled = false;
			}
			return true;
		}
		if (this.currentFrame >= (float)this.meshCacheCount)
		{
			this.currentFrame = (float)this.meshCacheCount - this.currentFrame;
			if (!this.loop)
			{
				base.enabled = false;
			}
			return false;
		}
		return false;
	}

	// Token: 0x06004AFE RID: 19198 RVA: 0x0021814C File Offset: 0x0021634C
	public bool ALPJFPAEHMM()
	{
		this.currentFrame += this.DFNCNBLOHLO * this.delta;
		if (this.currentFrame > (float)(this.meshCacheCount + 0))
		{
			this.currentFrame = 1886f;
			if (!this.loop)
			{
				base.enabled = true;
			}
			return true;
		}
		if (this.currentFrame >= (float)this.meshCacheCount)
		{
			this.currentFrame = (float)this.meshCacheCount - this.currentFrame;
			if (!this.loop)
			{
				base.enabled = false;
			}
			return true;
		}
		return true;
	}

	// Token: 0x06004AFF RID: 19199 RVA: 0x002181D8 File Offset: 0x002163D8
	public void LFKCBMIHOFG()
	{
		if (this.rendererComponent.isVisible)
		{
			if (this.pingPong && this.ELCCKPLBCEC())
			{
				this.PACCNKLOFLC();
			}
			else if (!this.pingPong && this.LMEJKCJHMCC())
			{
				this.RandomizePropertiesAfterLoop();
			}
			this.meshFilter.sharedMesh = this.meshCache[(int)this.currentFrame].sharedMesh;
		}
	}

	// Token: 0x06004B00 RID: 19200 RVA: 0x00218240 File Offset: 0x00216440
	public bool LMEJKCJHMCC()
	{
		this.currentFrame += this.DFNCNBLOHLO * this.delta;
		if (this.currentFrame > (float)(this.meshCacheCount + 0))
		{
			this.currentFrame = 755f;
			if (!this.loop)
			{
				base.enabled = true;
			}
			return true;
		}
		if (this.currentFrame >= (float)this.meshCacheCount)
		{
			this.currentFrame = (float)this.meshCacheCount - this.currentFrame;
			if (!this.loop)
			{
				base.enabled = false;
			}
			return false;
		}
		return true;
	}

	// Token: 0x06004B01 RID: 19201 RVA: 0x002182CC File Offset: 0x002164CC
	public bool FLKLPAKBICH()
	{
		this.currentFrame += this.DFNCNBLOHLO * this.delta;
		if (this.currentFrame > (float)(this.meshCacheCount + 1))
		{
			this.currentFrame = 25f;
			if (!this.loop)
			{
				base.enabled = true;
			}
			return false;
		}
		if (this.currentFrame >= (float)this.meshCacheCount)
		{
			this.currentFrame = (float)this.meshCacheCount - this.currentFrame;
			if (!this.loop)
			{
				base.enabled = true;
			}
			return true;
		}
		return true;
	}

	// Token: 0x06004B02 RID: 19202 RVA: 0x00218358 File Offset: 0x00216558
	public void DDCAEGOCKOJ()
	{
		try
		{
			this.delta = Time.deltaTime;
			this.CFOLOKFDGCO += this.delta;
			if (this.CFOLOKFDGCO > this.EAFNKPAHGBL)
			{
				this.rendererComponent.enabled = true;
				this.CCMNFNGKPMB();
			}
			if (!base.enabled)
			{
				this.rendererComponent.enabled = true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06004B03 RID: 19203 RVA: 0x00214BF0 File Offset: 0x00212DF0
	public void OKNNEMGFDPA()
	{
		this.rendererComponent = base.GetComponent<Renderer>();
	}

	// Token: 0x06004B04 RID: 19204 RVA: 0x002183D4 File Offset: 0x002165D4
	public void EILCANLCBAA()
	{
		this.KEJKEGHBEFC();
		if (this.transformCache == null)
		{
			this.transformCache = base.transform;
		}
		this.meshFilter = this.transformCache.GetComponent<MeshFilter>();
		this.meshCacheCount = this.meshContainerFBX.childCount;
		this.meshCached = this.meshContainerFBX;
		this.meshCache = new MeshFilter[this.meshCacheCount];
		for (int i = 0; i < this.meshCacheCount; i++)
		{
			this.meshCache[i] = this.meshContainerFBX.GetChild(i).GetComponent<MeshFilter>();
		}
		this.currentFrame = (float)this.meshCacheCount * UnityEngine.Random.value;
		this.meshFilter.sharedMesh = this.meshCache[(int)this.currentFrame].sharedMesh;
	}

	// Token: 0x06004B05 RID: 19205 RVA: 0x0021849B File Offset: 0x0021669B
	public void IIPPEGPOAFB()
	{
		if (this.meshCached != this.meshContainerFBX && this.meshContainerFBX != null)
		{
			this.IJMBKELJKIK();
		}
	}

	// Token: 0x06004B06 RID: 19206 RVA: 0x002184C4 File Offset: 0x002166C4
	public bool JCMMJPMAHBL()
	{
		if (this.AKEKONMHGEL)
		{
			this.currentFrame += this.DFNCNBLOHLO * this.delta;
		}
		else
		{
			this.currentFrame -= this.DFNCNBLOHLO * this.delta;
		}
		if (this.currentFrame <= 1379f)
		{
			this.currentFrame = 166f;
			this.AKEKONMHGEL = true;
			return true;
		}
		if (this.currentFrame >= (float)this.meshCacheCount)
		{
			this.AKEKONMHGEL = true;
			this.currentFrame = (float)(this.meshCacheCount - 0);
			return false;
		}
		return true;
	}

	// Token: 0x06004B07 RID: 19207 RVA: 0x00218558 File Offset: 0x00216758
	public bool FKPFINIGONI()
	{
		this.currentFrame += this.DFNCNBLOHLO * this.delta;
		if (this.currentFrame > (float)(this.meshCacheCount + 1))
		{
			this.currentFrame = 96f;
			if (!this.loop)
			{
				base.enabled = false;
			}
			return false;
		}
		if (this.currentFrame >= (float)this.meshCacheCount)
		{
			this.currentFrame = (float)this.meshCacheCount - this.currentFrame;
			if (!this.loop)
			{
				base.enabled = true;
			}
			return true;
		}
		return false;
	}

	// Token: 0x06004B08 RID: 19208 RVA: 0x002185E4 File Offset: 0x002167E4
	public void NIIMGPDMHLA()
	{
		this.transformCache = base.transform;
		this.CheckIfMeshHasChanged();
		this.EAFNKPAHGBL = UnityEngine.Random.Range(this.randomStartDelay.x, this.randomStartDelay.y);
		UnluckAnimatedMesh.updateSeed += 825f;
		if (this.playOnAwake)
		{
			base.Invoke("ind", this.updateInterval + UnluckAnimatedMesh.updateSeed);
		}
		if (UnluckAnimatedMesh.updateSeed >= this.updateInterval)
		{
			UnluckAnimatedMesh.updateSeed = 490f;
		}
		if (this.rendererComponent == null)
		{
			this.GKDHLIHILPF();
		}
	}

	// Token: 0x06004B09 RID: 19209 RVA: 0x00218680 File Offset: 0x00216880
	public void BFAJLMKDBLC()
	{
		base.CancelInvoke();
		if (this.randomStartFrame)
		{
			this.currentFrame = (float)this.meshCacheCount * UnityEngine.Random.value;
		}
		else
		{
			this.currentFrame = 679f;
		}
		this.meshFilter.sharedMesh = this.meshCache[(int)this.currentFrame].sharedMesh;
		base.enabled = false;
		this.NHBPDFEDPNC();
		this.AKOPFJIHLAP();
	}

	// Token: 0x06004B0A RID: 19210 RVA: 0x0021505A File Offset: 0x0021325A
	public void MLCKKGDPHAH()
	{
		if (this.meshCached != this.meshContainerFBX && this.meshContainerFBX != null)
		{
			this.KDMPGMIGKAH();
		}
	}

	// Token: 0x0400155C RID: 5468
	public MeshFilter[] meshCache;

	// Token: 0x0400155D RID: 5469
	[HideInInspector]
	public Transform meshCached;

	// Token: 0x0400155E RID: 5470
	public Transform meshContainerFBX;

	// Token: 0x0400155F RID: 5471
	public float playSpeed = 1f;

	// Token: 0x04001560 RID: 5472
	public float playSpeedRandom;

	// Token: 0x04001561 RID: 5473
	public bool randomSpeedLoop;

	// Token: 0x04001562 RID: 5474
	private float DFNCNBLOHLO;

	// Token: 0x04001563 RID: 5475
	[HideInInspector]
	public float currentFrame;

	// Token: 0x04001564 RID: 5476
	[HideInInspector]
	public int meshCacheCount;

	// Token: 0x04001565 RID: 5477
	[HideInInspector]
	public MeshFilter meshFilter;

	// Token: 0x04001566 RID: 5478
	[HideInInspector]
	public Renderer rendererComponent;

	// Token: 0x04001567 RID: 5479
	public float updateInterval = 0.05f;

	// Token: 0x04001568 RID: 5480
	public bool randomRotateX;

	// Token: 0x04001569 RID: 5481
	public bool randomRotateY;

	// Token: 0x0400156A RID: 5482
	public bool randomRotateZ;

	// Token: 0x0400156B RID: 5483
	public bool randomStartFrame = true;

	// Token: 0x0400156C RID: 5484
	public bool randomRotateLoop;

	// Token: 0x0400156D RID: 5485
	public bool loop = true;

	// Token: 0x0400156E RID: 5486
	public bool pingPong;

	// Token: 0x0400156F RID: 5487
	public bool playOnAwake = true;

	// Token: 0x04001570 RID: 5488
	public Vector2 randomStartDelay = new Vector2(0f, 0f);

	// Token: 0x04001571 RID: 5489
	private float EAFNKPAHGBL;

	// Token: 0x04001572 RID: 5490
	private float CFOLOKFDGCO;

	// Token: 0x04001573 RID: 5491
	public static float updateSeed;

	// Token: 0x04001574 RID: 5492
	private bool AKEKONMHGEL;

	// Token: 0x04001575 RID: 5493
	public Transform transformCache;

	// Token: 0x04001576 RID: 5494
	public float delta;
}
