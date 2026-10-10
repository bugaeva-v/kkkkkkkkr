using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Uniject;
using UnityEngine.EventSystems;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000049 RID: 73
	internal class UIFakeStore : FakeStore
	{
		// Token: 0x060001B9 RID: 441 RVA: 0x000073E0 File Offset: 0x000055E0
		public UIFakeStore(ICartValidator cartValidator, ILogger logger) : base(cartValidator, logger)
		{
		}

		// Token: 0x060001BA RID: 442 RVA: 0x000073EA File Offset: 0x000055EA
		public UIFakeStore(ICartValidator cartValidator, IUtil util, ILogger logger) : base(cartValidator, logger)
		{
			this.m_Util = util;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000073FC File Offset: 0x000055FC
		protected override bool StartUI<T>(object model, FakeStore.DialogType dialogType, Action<bool, T> callback)
		{
			List<string> list = new List<string>
			{
				"Success"
			};
			foreach (object obj in Enum.GetValues(typeof(T)))
			{
				T t = (T)((object)obj);
				list.Add(t.ToString());
			}
			Action<bool, int> callback2 = delegate(bool result, int codeValue)
			{
				T arg = (T)((object)codeValue);
				callback(result, arg);
			};
			string queryText = null;
			string okayButtonText = null;
			if (dialogType == FakeStore.DialogType.Purchase)
			{
				queryText = this.CreatePurchaseQuestion((ProductDefinition)model);
				if (this.UIMode == FakeStoreUIMode.DeveloperUser)
				{
					okayButtonText = "OK";
				}
				else
				{
					okayButtonText = "Buy";
				}
			}
			else if (dialogType == FakeStore.DialogType.FetchProducts)
			{
				queryText = this.CreateFetchProductsQuestion((ReadOnlyCollection<ProductDefinition>)model);
				okayButtonText = "OK";
			}
			else
			{
				Debug.unityLogger.LogIAPError(string.Format("Unrecognized DialogType {0}", dialogType));
			}
			string cancelButtonText = "Cancel";
			return this.StartUI(queryText, okayButtonText, cancelButtonText, list, callback2);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00007518 File Offset: 0x00005718
		private bool StartUI(string queryText, string okayButtonText, string cancelButtonText, List<string> options, Action<bool, int> callback)
		{
			if (this.IsShowingDialog())
			{
				return false;
			}
			DialogRequest currentDialog = new DialogRequest
			{
				QueryText = queryText,
				OkayButtonText = okayButtonText,
				CancelButtonText = cancelButtonText,
				Options = options,
				Callback = callback
			};
			this.m_CurrentDialog = currentDialog;
			this.InstantiateDialog();
			return true;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00007568 File Offset: 0x00005768
		private void InstantiateDialog()
		{
			if (this.m_CurrentDialog != null)
			{
				UIFakeStoreWindow orCreateFakeStoreWindow = this.GetOrCreateFakeStoreWindow();
				this.AddLifeCycleNotifierAndSetDestroyCallback(orCreateFakeStoreWindow.gameObject);
				this.EnsureEventSystemCreated(orCreateFakeStoreWindow.transform);
				this.ConfigureDialogWindow(orCreateFakeStoreWindow);
				return;
			}
			Debug.unityLogger.LogIAPError(((this != null) ? this.ToString() : null) + " requires m_CurrentDialog. Not showing dialog.");
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000075C5 File Offset: 0x000057C5
		private UIFakeStoreWindow GetOrCreateFakeStoreWindow()
		{
			if (this.m_UIFakeStoreWindowObject == null)
			{
				this.m_UIFakeStoreWindowObject = new GameObject("UIFakeStoreWindow");
				this.m_UIFakeStoreWindowObject.AddComponent<UIFakeStoreWindow>();
			}
			return this.m_UIFakeStoreWindowObject.GetComponent<UIFakeStoreWindow>();
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000075FC File Offset: 0x000057FC
		private void AddLifeCycleNotifierAndSetDestroyCallback(GameObject gameObject)
		{
			gameObject.AddComponent<LifecycleNotifier>().OnDestroyCallback = delegate()
			{
				this.m_CurrentDialog = null;
			};
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00007615 File Offset: 0x00005815
		private void EnsureEventSystemCreated(Transform rootTransform)
		{
			if (Object.FindObjectOfType<EventSystem>() == null)
			{
				this.CreateEventSystem(rootTransform);
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000762C File Offset: 0x0000582C
		private void ConfigureDialogWindow(UIFakeStoreWindow dialogWindow)
		{
			bool assignCancelCallback = this.UIMode != FakeStoreUIMode.DeveloperUser;
			bool flag = this.UIMode != FakeStoreUIMode.StandardUser;
			dialogWindow.ConfigureMainDialogText(this.m_CurrentDialog.QueryText, this.m_CurrentDialog.OkayButtonText, this.m_CurrentDialog.CancelButtonText);
			if (flag)
			{
				dialogWindow.ConfigureDropdownOptions(this.m_CurrentDialog.Options);
			}
			this.ConfigureDialogWindowCallbacks(dialogWindow, assignCancelCallback, flag);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00007698 File Offset: 0x00005898
		private void ConfigureDialogWindowCallbacks(UIFakeStoreWindow dialogWindow, bool assignCancelCallback, bool assignDropDownCallback)
		{
			Action onCancel = null;
			Action<int> onDropdown = null;
			if (assignCancelCallback)
			{
				onCancel = new Action(this.CancelButtonClicked);
			}
			if (assignDropDownCallback)
			{
				onDropdown = new Action<int>(this.DropdownValueChanged);
			}
			dialogWindow.AssignCallbacks(new Action(this.OkayButtonClicked), onCancel, onDropdown);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000076E0 File Offset: 0x000058E0
		private void CreateEventSystem(Transform rootTransform)
		{
			this.m_EventSystem = new GameObject("EventSystem", new Type[]
			{
				typeof(EventSystem)
			});
			this.m_EventSystem.AddComponent<StandaloneInputModule>();
			this.m_EventSystem.transform.parent = rootTransform;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000772D File Offset: 0x0000592D
		private string CreatePurchaseQuestion(ProductDefinition definition)
		{
			return "Do you want to Purchase " + definition.id + "?\n\n[Environment: FakeStore]";
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00007744 File Offset: 0x00005944
		private string CreateFetchProductsQuestion(ReadOnlyCollection<ProductDefinition> definitions)
		{
			string str = "Do you want to initialize purchasing for products {";
			str += string.Join(", ", (from pid in definitions.Take(2)
			select pid.id).ToArray<string>());
			if (definitions.Count > 2)
			{
				str += ", ...";
			}
			return str + "}?\n\n[Environment: FakeStore]";
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000077BC File Offset: 0x000059BC
		private void OkayButtonClicked()
		{
			bool arg = false;
			if (this.m_LastSelectedDropdownIndex == 0 || this.UIMode != FakeStoreUIMode.DeveloperUser)
			{
				arg = true;
			}
			int arg2 = Math.Max(0, this.m_LastSelectedDropdownIndex - 1);
			this.m_CurrentDialog.Callback(arg, arg2);
			this.CloseDialog();
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00007805 File Offset: 0x00005A05
		private void CancelButtonClicked()
		{
			this.m_CurrentDialog.Callback(false, 4);
			this.CloseDialog();
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000781F File Offset: 0x00005A1F
		private void DropdownValueChanged(int selectedItem)
		{
			this.m_LastSelectedDropdownIndex = selectedItem;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00007828 File Offset: 0x00005A28
		private void CloseDialog()
		{
			this.m_CurrentDialog = null;
			if (this.m_UIFakeStoreWindowObject != null)
			{
				Object.Destroy(this.m_UIFakeStoreWindowObject);
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000784A File Offset: 0x00005A4A
		public bool IsShowingDialog()
		{
			return this.m_CurrentDialog != null;
		}

		// Token: 0x040000A9 RID: 169
		private const string EnvironmentDescriptionPostfix = "\n\n[Environment: FakeStore]";

		// Token: 0x040000AA RID: 170
		private const string SuccessString = "Success";

		// Token: 0x040000AB RID: 171
		private const int FetchProductsDescriptionCount = 2;

		// Token: 0x040000AC RID: 172
		private DialogRequest m_CurrentDialog;

		// Token: 0x040000AD RID: 173
		private int m_LastSelectedDropdownIndex;

		// Token: 0x040000AE RID: 174
		private GameObject m_UIFakeStoreWindowObject;

		// Token: 0x040000AF RID: 175
		private GameObject m_EventSystem;

		// Token: 0x040000B0 RID: 176
		private readonly IUtil m_Util;
	}
}
