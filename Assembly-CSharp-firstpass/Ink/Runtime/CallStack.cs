using System;
using System.Collections.Generic;
using System.Text;

namespace Ink.Runtime
{
	// Token: 0x0200001E RID: 30
	internal class CallStack
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x000086D5 File Offset: 0x000068D5
		public List<CallStack.Element> elements
		{
			get
			{
				return this.callStack;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x000086DD File Offset: 0x000068DD
		public int depth
		{
			get
			{
				return this.elements.Count;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x000086EA File Offset: 0x000068EA
		public CallStack.Element currentElement
		{
			get
			{
				return this.callStack[this.callStack.Count - 1];
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00008704 File Offset: 0x00006904
		public int currentElementIndex
		{
			get
			{
				return this.callStack.Count - 1;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00008713 File Offset: 0x00006913
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x0000872D File Offset: 0x0000692D
		public CallStack.Thread currentThread
		{
			get
			{
				return this._threads[this._threads.Count - 1];
			}
			set
			{
				this._threads.Clear();
				this._threads.Add(value);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00008746 File Offset: 0x00006946
		public bool canPop
		{
			get
			{
				return this.callStack.Count > 1;
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00008758 File Offset: 0x00006958
		public CallStack(Container rootContentContainer)
		{
			this._threads = new List<CallStack.Thread>();
			this._threads.Add(new CallStack.Thread());
			this._threads[0].callstack.Add(new CallStack.Element(PushPopType.Tunnel, rootContentContainer, 0, false));
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000087A8 File Offset: 0x000069A8
		public CallStack(CallStack toCopy)
		{
			this._threads = new List<CallStack.Thread>();
			foreach (CallStack.Thread thread in toCopy._threads)
			{
				this._threads.Add(thread.Copy());
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00008818 File Offset: 0x00006A18
		public void SetJsonToken(Dictionary<string, object> jObject, Story storyContext)
		{
			this._threads.Clear();
			foreach (object obj in ((List<object>)jObject["threads"]))
			{
				CallStack.Thread item = new CallStack.Thread((Dictionary<string, object>)obj, storyContext);
				this._threads.Add(item);
			}
			this._threadCounter = (int)jObject["threadCounter"];
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000088A8 File Offset: 0x00006AA8
		public Dictionary<string, object> GetJsonToken()
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			List<object> list = new List<object>();
			foreach (CallStack.Thread thread in this._threads)
			{
				list.Add(thread.jsonToken);
			}
			dictionary["threads"] = list;
			dictionary["threadCounter"] = this._threadCounter;
			return dictionary;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00008930 File Offset: 0x00006B30
		public void PushThread()
		{
			CallStack.Thread thread = this.currentThread.Copy();
			this._threadCounter++;
			thread.threadIndex = this._threadCounter;
			this._threads.Add(thread);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000896F File Offset: 0x00006B6F
		public void PopThread()
		{
			if (this.canPopThread)
			{
				this._threads.Remove(this.currentThread);
				return;
			}
			throw new Exception("Can't pop thread");
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00008996 File Offset: 0x00006B96
		public bool canPopThread
		{
			get
			{
				return this._threads.Count > 1;
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000089A6 File Offset: 0x00006BA6
		public void Push(PushPopType type)
		{
			this.callStack.Add(new CallStack.Element(type, this.currentElement.currentContainer, this.currentElement.currentContentIndex, false));
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000089D0 File Offset: 0x00006BD0
		public bool CanPop(PushPopType? type = null)
		{
			if (!this.canPop)
			{
				return false;
			}
			if (type == null)
			{
				return true;
			}
			PushPopType type2 = this.currentElement.type;
			PushPopType? pushPopType = type;
			return type2 == pushPopType.GetValueOrDefault() & pushPopType != null;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00008A10 File Offset: 0x00006C10
		public void Pop(PushPopType? type = null)
		{
			if (this.CanPop(type))
			{
				this.callStack.RemoveAt(this.callStack.Count - 1);
				return;
			}
			throw new Exception("Mismatched push/pop in Callstack");
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00008A40 File Offset: 0x00006C40
		public Object GetTemporaryVariableWithName(string name, int contextIndex = -1)
		{
			if (contextIndex == -1)
			{
				contextIndex = this.currentElementIndex + 1;
			}
			Object result = null;
			if (this.callStack[contextIndex - 1].temporaryVariables.TryGetValue(name, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00008A80 File Offset: 0x00006C80
		public void SetTemporaryVariable(string name, Object value, bool declareNew, int contextIndex = -1)
		{
			if (contextIndex == -1)
			{
				contextIndex = this.currentElementIndex + 1;
			}
			CallStack.Element element = this.callStack[contextIndex - 1];
			if (!declareNew && !element.temporaryVariables.ContainsKey(name))
			{
				Story.errorsLog.Add("(failing safe) RUNTIME ERROR: Could not find temporary variable to set: " + name);
				return;
			}
			Object oldValue;
			if (element.temporaryVariables.TryGetValue(name, out oldValue))
			{
				ListValue.RetainListOriginsForAssignment(oldValue, value);
			}
			element.temporaryVariables[name] = value;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00008AF7 File Offset: 0x00006CF7
		public int ContextForVariableNamed(string name)
		{
			if (this.currentElement.temporaryVariables.ContainsKey(name))
			{
				return this.currentElementIndex + 1;
			}
			return 0;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00008B18 File Offset: 0x00006D18
		public CallStack.Thread ThreadWithIndex(int index)
		{
			return this._threads.Find((CallStack.Thread t) => t.threadIndex == index);
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00008B49 File Offset: 0x00006D49
		private List<CallStack.Element> callStack
		{
			get
			{
				return this.currentThread.callstack;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00008B58 File Offset: 0x00006D58
		internal string callStackTrace
		{
			get
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < this._threads.Count; i++)
				{
					CallStack.Thread thread = this._threads[i];
					bool flag = i == this._threads.Count - 1;
					stringBuilder.AppendFormat("=== THREAD {0}/{1} {2}===\n", i + 1, this._threads.Count, flag ? "(current) " : "");
					for (int j = 0; j < thread.callstack.Count; j++)
					{
						if (thread.callstack[j].type == PushPopType.Function)
						{
							stringBuilder.Append("  [FUNCTION] ");
						}
						else
						{
							stringBuilder.Append("  [TUNNEL] ");
						}
						Object currentObject = thread.callstack[j].currentObject;
						if (currentObject == null)
						{
							if (thread.callstack[j].currentContainer != null)
							{
								stringBuilder.Append("<SOMEWHERE IN ");
								stringBuilder.Append(thread.callstack[j].currentContainer.path.ToString());
								stringBuilder.AppendLine(">");
							}
							else
							{
								stringBuilder.AppendLine("<UNKNOWN STACK ELEMENT>");
							}
						}
						else
						{
							string value = currentObject.path.ToString();
							stringBuilder.AppendLine(value);
						}
					}
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x04000108 RID: 264
		private List<CallStack.Thread> _threads;

		// Token: 0x04000109 RID: 265
		private int _threadCounter;

		// Token: 0x02000061 RID: 97
		internal class Element
		{
			// Token: 0x170000A8 RID: 168
			// (get) Token: 0x060002E2 RID: 738 RVA: 0x0001299C File Offset: 0x00010B9C
			// (set) Token: 0x060002E3 RID: 739 RVA: 0x000129DC File Offset: 0x00010BDC
			public Object currentObject
			{
				get
				{
					if (this.currentContainer && this.currentContentIndex < this.currentContainer.content.Count)
					{
						return this.currentContainer.content[this.currentContentIndex];
					}
					return null;
				}
				set
				{
					if (value == null)
					{
						this.currentContainer = null;
						this.currentContentIndex = 0;
						return;
					}
					this.currentContainer = (value.parent as Container);
					if (this.currentContainer != null)
					{
						this.currentContentIndex = this.currentContainer.content.IndexOf(value);
					}
					if (this.currentContainer == null || this.currentContentIndex == -1)
					{
						this.currentContainer = (value as Container);
						this.currentContentIndex = 0;
					}
				}
			}

			// Token: 0x060002E4 RID: 740 RVA: 0x00012A63 File Offset: 0x00010C63
			public Element(PushPopType type, Container container, int contentIndex, bool inExpressionEvaluation = false)
			{
				this.currentContainer = container;
				this.currentContentIndex = contentIndex;
				this.inExpressionEvaluation = inExpressionEvaluation;
				this.temporaryVariables = new Dictionary<string, Object>();
				this.type = type;
			}

			// Token: 0x060002E5 RID: 741 RVA: 0x00012A93 File Offset: 0x00010C93
			public CallStack.Element Copy()
			{
				return new CallStack.Element(this.type, this.currentContainer, this.currentContentIndex, this.inExpressionEvaluation)
				{
					temporaryVariables = new Dictionary<string, Object>(this.temporaryVariables)
				};
			}

			// Token: 0x04000200 RID: 512
			public Container currentContainer;

			// Token: 0x04000201 RID: 513
			public int currentContentIndex;

			// Token: 0x04000202 RID: 514
			public bool inExpressionEvaluation;

			// Token: 0x04000203 RID: 515
			public Dictionary<string, Object> temporaryVariables;

			// Token: 0x04000204 RID: 516
			public PushPopType type;
		}

		// Token: 0x02000062 RID: 98
		internal class Thread
		{
			// Token: 0x060002E6 RID: 742 RVA: 0x00012AC3 File Offset: 0x00010CC3
			public Thread()
			{
				this.callstack = new List<CallStack.Element>();
			}

			// Token: 0x060002E7 RID: 743 RVA: 0x00012AD8 File Offset: 0x00010CD8
			public Thread(Dictionary<string, object> jThreadObj, Story storyContext) : this()
			{
				this.threadIndex = (int)jThreadObj["threadIndex"];
				foreach (object obj in ((List<object>)jThreadObj["callstack"]))
				{
					Dictionary<string, object> dictionary = (Dictionary<string, object>)obj;
					PushPopType type = (PushPopType)((int)dictionary["type"]);
					Container container = null;
					int contentIndex = 0;
					object obj2;
					if (dictionary.TryGetValue("cPath", out obj2))
					{
						string componentsString = obj2.ToString();
						container = (storyContext.ContentAtPath(new Path(componentsString)) as Container);
						contentIndex = (int)dictionary["idx"];
					}
					bool inExpressionEvaluation = (bool)dictionary["exp"];
					CallStack.Element element = new CallStack.Element(type, container, contentIndex, inExpressionEvaluation);
					Dictionary<string, object> jObject = (Dictionary<string, object>)dictionary["temp"];
					element.temporaryVariables = Json.JObjectToDictionaryRuntimeObjs(jObject);
					this.callstack.Add(element);
				}
				object obj3;
				if (jThreadObj.TryGetValue("previousContentObject", out obj3))
				{
					Path path = new Path((string)obj3);
					this.previousContentObject = storyContext.ContentAtPath(path);
				}
			}

			// Token: 0x060002E8 RID: 744 RVA: 0x00012C20 File Offset: 0x00010E20
			public CallStack.Thread Copy()
			{
				CallStack.Thread thread = new CallStack.Thread();
				thread.threadIndex = this.threadIndex;
				foreach (CallStack.Element element in this.callstack)
				{
					thread.callstack.Add(element.Copy());
				}
				thread.previousContentObject = this.previousContentObject;
				return thread;
			}

			// Token: 0x170000A9 RID: 169
			// (get) Token: 0x060002E9 RID: 745 RVA: 0x00012C9C File Offset: 0x00010E9C
			public Dictionary<string, object> jsonToken
			{
				get
				{
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					List<object> list = new List<object>();
					foreach (CallStack.Element element in this.callstack)
					{
						Dictionary<string, object> dictionary2 = new Dictionary<string, object>();
						if (element.currentContainer)
						{
							dictionary2["cPath"] = element.currentContainer.path.componentsString;
							dictionary2["idx"] = element.currentContentIndex;
						}
						dictionary2["exp"] = element.inExpressionEvaluation;
						dictionary2["type"] = (int)element.type;
						dictionary2["temp"] = Json.DictionaryRuntimeObjsToJObject(element.temporaryVariables);
						list.Add(dictionary2);
					}
					dictionary["callstack"] = list;
					dictionary["threadIndex"] = this.threadIndex;
					if (this.previousContentObject != null)
					{
						dictionary["previousContentObject"] = this.previousContentObject.path.ToString();
					}
					return dictionary;
				}
			}

			// Token: 0x04000205 RID: 517
			public List<CallStack.Element> callstack;

			// Token: 0x04000206 RID: 518
			public int threadIndex;

			// Token: 0x04000207 RID: 519
			public Object previousContentObject;
		}
	}
}
