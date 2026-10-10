using System;
using System.Collections;
using System.Collections.Generic;

namespace Ink.Runtime
{
	// Token: 0x02000044 RID: 68
	public class VariablesState : IEnumerable<string>, IEnumerable
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060002BD RID: 701 RVA: 0x000123C4 File Offset: 0x000105C4
		// (remove) Token: 0x060002BE RID: 702 RVA: 0x000123FC File Offset: 0x000105FC
		internal event VariablesState.VariableChanged variableChangedEvent;

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060002BF RID: 703 RVA: 0x00012431 File Offset: 0x00010631
		// (set) Token: 0x060002C0 RID: 704 RVA: 0x0001243C File Offset: 0x0001063C
		internal bool batchObservingVariableChanges
		{
			get
			{
				return this._batchObservingVariableChanges;
			}
			set
			{
				this._batchObservingVariableChanges = value;
				if (value)
				{
					this._changedVariables = new HashSet<string>();
					return;
				}
				if (this._changedVariables != null)
				{
					foreach (string text in this._changedVariables)
					{
						Object newValue = this._globalVariables[text];
						this.variableChangedEvent(text, newValue);
					}
				}
				this._changedVariables = null;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x000124C8 File Offset: 0x000106C8
		// (set) Token: 0x060002C2 RID: 706 RVA: 0x000124D0 File Offset: 0x000106D0
		internal CallStack callStack
		{
			get
			{
				return this._callStack;
			}
			set
			{
				this._callStack = value;
			}
		}

		// Token: 0x170000A6 RID: 166
		public object this[string variableName]
		{
			get
			{
				Object @object;
				if (this._globalVariables.TryGetValue(variableName, out @object))
				{
					return (@object as Value).valueObject;
				}
				return null;
			}
			set
			{
				if (!this._globalVariables.ContainsKey(variableName))
				{
					Story.errorsLog.Add("Variable '" + variableName + "' doesn't exist, so can't be set.");
					return;
				}
				Value value2 = Value.Create(value);
				if (!(value2 == null))
				{
					this.SetGlobal(variableName, value2);
					return;
				}
				if (value == null)
				{
					Story.errorsLog.Add("Cannot pass null to VariableState");
					return;
				}
				Story.errorsLog.Add("Invalid value passed to VariableState: " + value.ToString());
			}
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00012584 File Offset: 0x00010784
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0001258C File Offset: 0x0001078C
		public IEnumerator<string> GetEnumerator()
		{
			return this._globalVariables.Keys.GetEnumerator();
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x000125A3 File Offset: 0x000107A3
		internal VariablesState(CallStack callStack, ListDefinitionsOrigin listDefsOrigin)
		{
			this._globalVariables = new Dictionary<string, Object>();
			this._callStack = callStack;
			this._listDefsOrigin = listDefsOrigin;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x000125C4 File Offset: 0x000107C4
		internal void CopyFrom(VariablesState toCopy)
		{
			this._globalVariables = new Dictionary<string, Object>(toCopy._globalVariables);
			this.variableChangedEvent = toCopy.variableChangedEvent;
			if (toCopy.batchObservingVariableChanges != this.batchObservingVariableChanges)
			{
				if (toCopy.batchObservingVariableChanges)
				{
					this._batchObservingVariableChanges = true;
					this._changedVariables = new HashSet<string>(toCopy._changedVariables);
					return;
				}
				this._batchObservingVariableChanges = false;
				this._changedVariables = null;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x0001262B File Offset: 0x0001082B
		// (set) Token: 0x060002CA RID: 714 RVA: 0x00012638 File Offset: 0x00010838
		internal Dictionary<string, object> jsonToken
		{
			get
			{
				return Json.DictionaryRuntimeObjsToJObject(this._globalVariables);
			}
			set
			{
				this._globalVariables = Json.JObjectToDictionaryRuntimeObjs(value);
			}
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00012646 File Offset: 0x00010846
		internal Object GetVariableWithName(string name)
		{
			return this.GetVariableWithName(name, -1);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00012650 File Offset: 0x00010850
		internal bool GlobalVariableExistsWithName(string name)
		{
			return this._globalVariables.ContainsKey(name);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00012660 File Offset: 0x00010860
		private Object GetVariableWithName(string name, int contextIndex)
		{
			Object @object = this.GetRawVariableWithName(name, contextIndex);
			VariablePointerValue variablePointerValue = @object as VariablePointerValue;
			if (variablePointerValue)
			{
				@object = this.ValueAtVariablePointer(variablePointerValue);
			}
			return @object;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00012690 File Offset: 0x00010890
		private Object GetRawVariableWithName(string name, int contextIndex)
		{
			Object @object = null;
			if (contextIndex == 0 || contextIndex == -1)
			{
				if (this._globalVariables.TryGetValue(name, out @object))
				{
					return @object;
				}
				ListValue listValue = this._listDefsOrigin.FindSingleItemListWithName(name);
				if (listValue)
				{
					return listValue;
				}
			}
			@object = this._callStack.GetTemporaryVariableWithName(name, contextIndex);
			if (@object == null)
			{
				Story.errorsLog.Add(string.Concat(new string[]
				{
					"(failing safe) RUNTIME ERROR: Variable '",
					name,
					"' could not be found in context '",
					contextIndex.ToString(),
					"'. This shouldn't be possible so is a bug in the ink engine. Please try to construct a minimal story that reproduces the problem and report to inkle, thank you!"
				}));
				@object = Value.Create(0);
			}
			return @object;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0001272E File Offset: 0x0001092E
		internal Object ValueAtVariablePointer(VariablePointerValue pointer)
		{
			return this.GetVariableWithName(pointer.variableName, pointer.contextIndex);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00012744 File Offset: 0x00010944
		internal void Assign(VariableAssignment varAss, Object value)
		{
			string variableName = varAss.variableName;
			int num = -1;
			bool flag;
			if (varAss.isNewDeclaration)
			{
				flag = varAss.isGlobal;
			}
			else
			{
				flag = this._globalVariables.ContainsKey(variableName);
			}
			if (varAss.isNewDeclaration)
			{
				VariablePointerValue variablePointerValue = value as VariablePointerValue;
				if (variablePointerValue)
				{
					value = this.ResolveVariablePointer(variablePointerValue);
				}
			}
			else
			{
				VariablePointerValue variablePointerValue2;
				do
				{
					variablePointerValue2 = (this.GetRawVariableWithName(variableName, num) as VariablePointerValue);
					if (variablePointerValue2)
					{
						variableName = variablePointerValue2.variableName;
						num = variablePointerValue2.contextIndex;
						flag = (num == 0);
					}
				}
				while (variablePointerValue2);
			}
			if (flag)
			{
				this.SetGlobal(variableName, value);
				return;
			}
			this._callStack.SetTemporaryVariable(variableName, value, varAss.isNewDeclaration, num);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x000127F8 File Offset: 0x000109F8
		private void RetainListOriginsForAssignment(Object oldValue, Object newValue)
		{
			ListValue listValue = oldValue as ListValue;
			ListValue listValue2 = newValue as ListValue;
			if (listValue && listValue2 && listValue2.value.Count == 0)
			{
				listValue2.value.SetInitialOriginNames(listValue.value.originNames);
			}
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00012848 File Offset: 0x00010A48
		private void SetGlobal(string variableName, Object value)
		{
			Object @object = null;
			this._globalVariables.TryGetValue(variableName, out @object);
			ListValue.RetainListOriginsForAssignment(@object, value);
			this._globalVariables[variableName] = value;
			if (this.variableChangedEvent != null && !value.Equals(@object))
			{
				if (this.batchObservingVariableChanges)
				{
					this._changedVariables.Add(variableName);
					return;
				}
				this.variableChangedEvent(variableName, value);
			}
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x000128B0 File Offset: 0x00010AB0
		private VariablePointerValue ResolveVariablePointer(VariablePointerValue varPointer)
		{
			int num = varPointer.contextIndex;
			if (num == -1)
			{
				num = this.GetContextIndexOfVariableNamed(varPointer.variableName);
			}
			VariablePointerValue variablePointerValue = this.GetRawVariableWithName(varPointer.variableName, num) as VariablePointerValue;
			if (variablePointerValue)
			{
				return variablePointerValue;
			}
			return new VariablePointerValue(varPointer.variableName, num);
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x000128FE File Offset: 0x00010AFE
		private int GetContextIndexOfVariableNamed(string varName)
		{
			if (this._globalVariables.ContainsKey(varName))
			{
				return 0;
			}
			return this._callStack.currentElementIndex;
		}

		// Token: 0x040001AF RID: 431
		private bool _batchObservingVariableChanges;

		// Token: 0x040001B0 RID: 432
		private Dictionary<string, Object> _globalVariables;

		// Token: 0x040001B1 RID: 433
		private CallStack _callStack;

		// Token: 0x040001B2 RID: 434
		private HashSet<string> _changedVariables;

		// Token: 0x040001B3 RID: 435
		private ListDefinitionsOrigin _listDefsOrigin;

		// Token: 0x0200007C RID: 124
		// (Invoke) Token: 0x0600037D RID: 893
		internal delegate void VariableChanged(string variableName, Object newValue);
	}
}
