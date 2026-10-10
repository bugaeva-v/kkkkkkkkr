using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200033D RID: 829
[CreateAssetMenu(fileName = "assetAvatarExtensionPackX", menuName = "ROMANCE/Create assetAvatarExtensionPackX", order = 1)]
public class AssetAvatarExtensionPack : ScriptableObject
{
	// Token: 0x04001CA4 RID: 7332
	public AssetAvatarExtensionPackHeader header;

	// Token: 0x04001CA5 RID: 7333
	public List<AssetAvatarExtension> extensions;
}
