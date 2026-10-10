using System;

// Token: 0x02000496 RID: 1174
[Serializable]
public class AssetCdnSubDepot
{
	// Token: 0x06008E3D RID: 36413 RVA: 0x003ED020 File Offset: 0x003EB220
	public AssetCdnSubDepot(LNDOOJOFFOM CNFJOAAOCLB, string DBHMNECMIAB)
	{
		this.assetBundleFolder = CNFJOAAOCLB;
		this.subDepotId = DBHMNECMIAB;
	}

	// Token: 0x04002792 RID: 10130
	public LNDOOJOFFOM assetBundleFolder;

	// Token: 0x04002793 RID: 10131
	public string subDepotId;
}
