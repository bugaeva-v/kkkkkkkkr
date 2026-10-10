using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000331 RID: 817
[CreateAssetMenu(fileName = "assetAvatarPackX", menuName = "ROMANCE/Create assetAvatarPackX", order = 1)]
public class AssetAvatarPack : ScriptableObject
{
	// Token: 0x04001BFA RID: 7162
	public AssetAvatarPackHeader header;

	// Token: 0x04001BFB RID: 7163
	public List<AssetAvatarComponent> components;
}
