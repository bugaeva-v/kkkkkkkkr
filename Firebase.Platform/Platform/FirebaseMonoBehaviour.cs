using System;
using UnityEngine;
using UnityEngine.Scripting;

namespace Firebase.Platform
{
	// Token: 0x02000014 RID: 20
	[Preserve]
	internal sealed class FirebaseMonoBehaviour : MonoBehaviour
	{
		// Token: 0x06000078 RID: 120 RVA: 0x0000318C File Offset: 0x0000138C
		private FirebaseHandler GetFirebaseHandlerOrDestroyGameObject()
		{
			FirebaseHandler defaultInstance = FirebaseHandler.DefaultInstance;
			bool flag = defaultInstance == null;
			if (flag)
			{
				Object.Destroy(base.gameObject);
			}
			return defaultInstance;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000031B9 File Offset: 0x000013B9
		[Preserve]
		private void OnEnable()
		{
			this.GetFirebaseHandlerOrDestroyGameObject();
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000031C4 File Offset: 0x000013C4
		[Preserve]
		private void Update()
		{
			FirebaseHandler firebaseHandlerOrDestroyGameObject = this.GetFirebaseHandlerOrDestroyGameObject();
			bool flag = firebaseHandlerOrDestroyGameObject != null;
			if (flag)
			{
				PlatformInformation.RealtimeSinceStartupSafe = PlatformInformation.RealtimeSinceStartup;
				firebaseHandlerOrDestroyGameObject.Update();
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000031F8 File Offset: 0x000013F8
		[Preserve]
		private void OnApplicationFocus(bool hasFocus)
		{
			FirebaseHandler firebaseHandlerOrDestroyGameObject = this.GetFirebaseHandlerOrDestroyGameObject();
			bool flag = firebaseHandlerOrDestroyGameObject != null;
			if (flag)
			{
				firebaseHandlerOrDestroyGameObject.OnApplicationFocus(hasFocus);
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000321D File Offset: 0x0000141D
		private void OnDestroy()
		{
			FirebaseHandler.OnMonoBehaviourDestroyed(this);
		}
	}
}
