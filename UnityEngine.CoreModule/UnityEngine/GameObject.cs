using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x0200020C RID: 524
	[ExcludeFromPreset]
	[NativeHeader("Runtime/Export/Scripting/GameObject.bindings.h")]
	[UsedByNativeCode]
	public sealed class GameObject : Object
	{
		// Token: 0x060016CF RID: 5839
		[FreeFunction("GameObjectBindings::CreatePrimitive")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern GameObject CreatePrimitive(PrimitiveType type);

		// Token: 0x060016D0 RID: 5840 RVA: 0x00024D24 File Offset: 0x00022F24
		[SecuritySafeCritical]
		public unsafe T GetComponent<T>()
		{
			CastHelper<T> castHelper = default(CastHelper<T>);
			this.GetComponentFastPath(typeof(T), new IntPtr((void*)(&castHelper.onePointerFurtherThanT)));
			return castHelper.t;
		}

		// Token: 0x060016D1 RID: 5841
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		[FreeFunction(Name = "GameObjectBindings::GetComponentFromType", HasExplicitThis = true, ThrowsException = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Component GetComponent(Type type);

		// Token: 0x060016D2 RID: 5842
		[FreeFunction(Name = "GameObjectBindings::GetComponentFastPath", HasExplicitThis = true, ThrowsException = true)]
		[NativeWritableSelf]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue);

		// Token: 0x060016D3 RID: 5843
		[FreeFunction(Name = "Scripting::GetScriptingWrapperOfComponentOfGameObject", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern Component GetComponentByName(string type);

		// Token: 0x060016D4 RID: 5844 RVA: 0x00024D64 File Offset: 0x00022F64
		public Component GetComponent(string type)
		{
			return this.GetComponentByName(type);
		}

		// Token: 0x060016D5 RID: 5845
		[FreeFunction(Name = "GameObjectBindings::GetComponentInChildren", HasExplicitThis = true, ThrowsException = true)]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Component GetComponentInChildren(Type type, bool includeInactive);

		// Token: 0x060016D6 RID: 5846 RVA: 0x00024D80 File Offset: 0x00022F80
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public Component GetComponentInChildren(Type type)
		{
			return this.GetComponentInChildren(type, false);
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x00024D9C File Offset: 0x00022F9C
		[ExcludeFromDocs]
		public T GetComponentInChildren<T>()
		{
			bool includeInactive = false;
			return this.GetComponentInChildren<T>(includeInactive);
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x00024DB8 File Offset: 0x00022FB8
		public T GetComponentInChildren<T>([DefaultValue("false")] bool includeInactive)
		{
			return (T)((object)this.GetComponentInChildren(typeof(T), includeInactive));
		}

		// Token: 0x060016D9 RID: 5849
		[FreeFunction(Name = "GameObjectBindings::GetComponentInParent", HasExplicitThis = true, ThrowsException = true)]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Component GetComponentInParent(Type type, bool includeInactive);

		// Token: 0x060016DA RID: 5850 RVA: 0x00024DE0 File Offset: 0x00022FE0
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public Component GetComponentInParent(Type type)
		{
			return this.GetComponentInParent(type, false);
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x00024DFC File Offset: 0x00022FFC
		[ExcludeFromDocs]
		public T GetComponentInParent<T>()
		{
			bool includeInactive = false;
			return this.GetComponentInParent<T>(includeInactive);
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x00024E18 File Offset: 0x00023018
		public T GetComponentInParent<T>([DefaultValue("false")] bool includeInactive)
		{
			return (T)((object)this.GetComponentInParent(typeof(T), includeInactive));
		}

		// Token: 0x060016DD RID: 5853
		[FreeFunction(Name = "GameObjectBindings::GetComponentsInternal", HasExplicitThis = true, ThrowsException = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Array GetComponentsInternal(Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList);

		// Token: 0x060016DE RID: 5854 RVA: 0x00024E40 File Offset: 0x00023040
		public Component[] GetComponents(Type type)
		{
			return (Component[])this.GetComponentsInternal(type, false, false, true, false, null);
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x00024E64 File Offset: 0x00023064
		public T[] GetComponents<T>()
		{
			return (T[])this.GetComponentsInternal(typeof(T), true, false, true, false, null);
		}

		// Token: 0x060016E0 RID: 5856 RVA: 0x00024E90 File Offset: 0x00023090
		public void GetComponents(Type type, List<Component> results)
		{
			this.GetComponentsInternal(type, false, false, true, false, results);
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x00024EA0 File Offset: 0x000230A0
		public void GetComponents<T>(List<T> results)
		{
			this.GetComponentsInternal(typeof(T), true, false, true, false, results);
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x00024EBC File Offset: 0x000230BC
		[ExcludeFromDocs]
		public Component[] GetComponentsInChildren(Type type)
		{
			bool includeInactive = false;
			return this.GetComponentsInChildren(type, includeInactive);
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x00024ED8 File Offset: 0x000230D8
		public Component[] GetComponentsInChildren(Type type, [DefaultValue("false")] bool includeInactive)
		{
			return (Component[])this.GetComponentsInternal(type, false, true, includeInactive, false, null);
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x00024EFC File Offset: 0x000230FC
		public T[] GetComponentsInChildren<T>(bool includeInactive)
		{
			return (T[])this.GetComponentsInternal(typeof(T), true, true, includeInactive, false, null);
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x00024F28 File Offset: 0x00023128
		public void GetComponentsInChildren<T>(bool includeInactive, List<T> results)
		{
			this.GetComponentsInternal(typeof(T), true, true, includeInactive, false, results);
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x00024F44 File Offset: 0x00023144
		public T[] GetComponentsInChildren<T>()
		{
			return this.GetComponentsInChildren<T>(false);
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x00024F5D File Offset: 0x0002315D
		public void GetComponentsInChildren<T>(List<T> results)
		{
			this.GetComponentsInChildren<T>(false, results);
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x00024F6C File Offset: 0x0002316C
		[ExcludeFromDocs]
		public Component[] GetComponentsInParent(Type type)
		{
			bool includeInactive = false;
			return this.GetComponentsInParent(type, includeInactive);
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x00024F88 File Offset: 0x00023188
		public Component[] GetComponentsInParent(Type type, [DefaultValue("false")] bool includeInactive)
		{
			return (Component[])this.GetComponentsInternal(type, false, true, includeInactive, true, null);
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x00024FAB File Offset: 0x000231AB
		public void GetComponentsInParent<T>(bool includeInactive, List<T> results)
		{
			this.GetComponentsInternal(typeof(T), true, true, includeInactive, true, results);
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x00024FC4 File Offset: 0x000231C4
		public T[] GetComponentsInParent<T>(bool includeInactive)
		{
			return (T[])this.GetComponentsInternal(typeof(T), true, true, includeInactive, true, null);
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x00024FF0 File Offset: 0x000231F0
		public T[] GetComponentsInParent<T>()
		{
			return this.GetComponentsInParent<T>(false);
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x0002500C File Offset: 0x0002320C
		[SecuritySafeCritical]
		public unsafe bool TryGetComponent<T>(out T component)
		{
			CastHelper<T> castHelper = default(CastHelper<T>);
			this.TryGetComponentFastPath(typeof(T), new IntPtr((void*)(&castHelper.onePointerFurtherThanT)));
			component = castHelper.t;
			return castHelper.t != null;
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x00025060 File Offset: 0x00023260
		public bool TryGetComponent(Type type, out Component component)
		{
			component = this.TryGetComponentInternal(type);
			return component != null;
		}

		// Token: 0x060016EF RID: 5871
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		[FreeFunction(Name = "GameObjectBindings::TryGetComponentFromType", HasExplicitThis = true, ThrowsException = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern Component TryGetComponentInternal(Type type);

		// Token: 0x060016F0 RID: 5872
		[FreeFunction(Name = "GameObjectBindings::TryGetComponentFastPath", HasExplicitThis = true, ThrowsException = true)]
		[NativeWritableSelf]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void TryGetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue);

		// Token: 0x060016F1 RID: 5873 RVA: 0x00025084 File Offset: 0x00023284
		public static GameObject FindWithTag(string tag)
		{
			return GameObject.FindGameObjectWithTag(tag);
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x0002509C File Offset: 0x0002329C
		public void SendMessageUpwards(string methodName, SendMessageOptions options)
		{
			this.SendMessageUpwards(methodName, null, options);
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x000250A9 File Offset: 0x000232A9
		public void SendMessage(string methodName, SendMessageOptions options)
		{
			this.SendMessage(methodName, null, options);
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x000250B6 File Offset: 0x000232B6
		public void BroadcastMessage(string methodName, SendMessageOptions options)
		{
			this.BroadcastMessage(methodName, null, options);
		}

		// Token: 0x060016F5 RID: 5877
		[FreeFunction(Name = "MonoAddComponent", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern Component AddComponentInternal(string className);

		// Token: 0x060016F6 RID: 5878
		[FreeFunction(Name = "MonoAddComponentWithType", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Component Internal_AddComponentWithType(Type componentType);

		// Token: 0x060016F7 RID: 5879 RVA: 0x000250C4 File Offset: 0x000232C4
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public Component AddComponent(Type componentType)
		{
			return this.Internal_AddComponentWithType(componentType);
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x000250E0 File Offset: 0x000232E0
		public T AddComponent<T>() where T : Component
		{
			return this.AddComponent(typeof(T)) as T;
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x060016F9 RID: 5881
		public extern Transform transform { [FreeFunction("GameObjectBindings::GetTransform", HasExplicitThis = true)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x060016FA RID: 5882
		// (set) Token: 0x060016FB RID: 5883
		public extern int layer { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x060016FC RID: 5884
		// (set) Token: 0x060016FD RID: 5885
		[Obsolete("GameObject.active is obsolete. Use GameObject.SetActive(), GameObject.activeSelf or GameObject.activeInHierarchy.")]
		public extern bool active { [NativeMethod(Name = "IsActive")] [MethodImpl(MethodImplOptions.InternalCall)] get; [NativeMethod(Name = "SetSelfActive")] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060016FE RID: 5886
		[NativeMethod(Name = "SetSelfActive")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetActive(bool value);

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x060016FF RID: 5887
		public extern bool activeSelf { [NativeMethod(Name = "IsSelfActive")] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06001700 RID: 5888
		public extern bool activeInHierarchy { [NativeMethod(Name = "IsActive")] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06001701 RID: 5889
		[NativeMethod(Name = "SetActiveRecursivelyDeprecated")]
		[Obsolete("gameObject.SetActiveRecursively() is obsolete. Use GameObject.SetActive(), which is now inherited by children.")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetActiveRecursively(bool state);

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06001702 RID: 5890
		// (set) Token: 0x06001703 RID: 5891
		public extern bool isStatic { [NativeMethod(Name = "GetIsStaticDeprecated")] [MethodImpl(MethodImplOptions.InternalCall)] get; [NativeMethod(Name = "SetIsStaticDeprecated")] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06001704 RID: 5892
		internal extern bool isStaticBatchable { [NativeMethod(Name = "IsStaticBatchable")] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06001705 RID: 5893
		// (set) Token: 0x06001706 RID: 5894
		public extern string tag { [FreeFunction("GameObjectBindings::GetTag", HasExplicitThis = true)] [MethodImpl(MethodImplOptions.InternalCall)] get; [FreeFunction("GameObjectBindings::SetTag", HasExplicitThis = true)] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06001707 RID: 5895
		[FreeFunction(Name = "GameObjectBindings::CompareTag", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool CompareTag(string tag);

		// Token: 0x06001708 RID: 5896
		[FreeFunction(Name = "GameObjectBindings::FindGameObjectWithTag", ThrowsException = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern GameObject FindGameObjectWithTag(string tag);

		// Token: 0x06001709 RID: 5897
		[FreeFunction(Name = "GameObjectBindings::FindGameObjectsWithTag", ThrowsException = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern GameObject[] FindGameObjectsWithTag(string tag);

		// Token: 0x0600170A RID: 5898
		[FreeFunction(Name = "Scripting::SendScriptingMessageUpwards", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SendMessageUpwards(string methodName, [DefaultValue("null")] object value, [DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options);

		// Token: 0x0600170B RID: 5899 RVA: 0x0002510C File Offset: 0x0002330C
		[ExcludeFromDocs]
		public void SendMessageUpwards(string methodName, object value)
		{
			SendMessageOptions options = SendMessageOptions.RequireReceiver;
			this.SendMessageUpwards(methodName, value, options);
		}

		// Token: 0x0600170C RID: 5900 RVA: 0x00025128 File Offset: 0x00023328
		[ExcludeFromDocs]
		public void SendMessageUpwards(string methodName)
		{
			SendMessageOptions options = SendMessageOptions.RequireReceiver;
			object value = null;
			this.SendMessageUpwards(methodName, value, options);
		}

		// Token: 0x0600170D RID: 5901
		[FreeFunction(Name = "Scripting::SendScriptingMessage", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SendMessage(string methodName, [DefaultValue("null")] object value, [DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options);

		// Token: 0x0600170E RID: 5902 RVA: 0x00025144 File Offset: 0x00023344
		[ExcludeFromDocs]
		public void SendMessage(string methodName, object value)
		{
			SendMessageOptions options = SendMessageOptions.RequireReceiver;
			this.SendMessage(methodName, value, options);
		}

		// Token: 0x0600170F RID: 5903 RVA: 0x00025160 File Offset: 0x00023360
		[ExcludeFromDocs]
		public void SendMessage(string methodName)
		{
			SendMessageOptions options = SendMessageOptions.RequireReceiver;
			object value = null;
			this.SendMessage(methodName, value, options);
		}

		// Token: 0x06001710 RID: 5904
		[FreeFunction(Name = "Scripting::BroadcastScriptingMessage", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void BroadcastMessage(string methodName, [DefaultValue("null")] object parameter, [DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options);

		// Token: 0x06001711 RID: 5905 RVA: 0x0002517C File Offset: 0x0002337C
		[ExcludeFromDocs]
		public void BroadcastMessage(string methodName, object parameter)
		{
			SendMessageOptions options = SendMessageOptions.RequireReceiver;
			this.BroadcastMessage(methodName, parameter, options);
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x00025198 File Offset: 0x00023398
		[ExcludeFromDocs]
		public void BroadcastMessage(string methodName)
		{
			SendMessageOptions options = SendMessageOptions.RequireReceiver;
			object parameter = null;
			this.BroadcastMessage(methodName, parameter, options);
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x000251B4 File Offset: 0x000233B4
		public GameObject(string name)
		{
			GameObject.Internal_CreateGameObject(this, name);
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x000251C6 File Offset: 0x000233C6
		public GameObject()
		{
			GameObject.Internal_CreateGameObject(this, null);
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x000251D8 File Offset: 0x000233D8
		public GameObject(string name, params Type[] components)
		{
			GameObject.Internal_CreateGameObject(this, name);
			foreach (Type componentType in components)
			{
				this.AddComponent(componentType);
			}
		}

		// Token: 0x06001716 RID: 5910
		[FreeFunction(Name = "GameObjectBindings::Internal_CreateGameObject")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CreateGameObject([Writable] GameObject self, string name);

		// Token: 0x06001717 RID: 5911
		[FreeFunction(Name = "GameObjectBindings::Find")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern GameObject Find(string name);

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06001718 RID: 5912 RVA: 0x00025214 File Offset: 0x00023414
		public Scene scene
		{
			[FreeFunction("GameObjectBindings::GetScene", HasExplicitThis = true)]
			get
			{
				Scene result;
				this.get_scene_Injected(out result);
				return result;
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06001719 RID: 5913
		public extern ulong sceneCullingMask { [FreeFunction(Name = "GameObjectBindings::GetSceneCullingMask", HasExplicitThis = true)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x0600171A RID: 5914 RVA: 0x0002522C File Offset: 0x0002342C
		public GameObject gameObject
		{
			get
			{
				return this;
			}
		}

		// Token: 0x0600171B RID: 5915
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void get_scene_Injected(out Scene ret);
	}
}
