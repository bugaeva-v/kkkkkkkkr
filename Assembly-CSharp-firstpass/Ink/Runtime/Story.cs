using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ink.Runtime
{
	// Token: 0x02000034 RID: 52
	public class Story : Object
	{
		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x0000DE04 File Offset: 0x0000C004
		public List<Choice> currentChoices
		{
			get
			{
				List<Choice> list = new List<Choice>();
				foreach (Choice choice in this._state.currentChoices)
				{
					if (!choice.choicePoint.isInvisibleDefault)
					{
						choice.index = list.Count;
						list.Add(choice);
					}
				}
				return list;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x0000DE7C File Offset: 0x0000C07C
		public string currentText
		{
			get
			{
				return this.state.currentText;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x0000DE89 File Offset: 0x0000C089
		public List<string> currentTags
		{
			get
			{
				return this.state.currentTags;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x0000DE96 File Offset: 0x0000C096
		public List<string> currentErrors
		{
			get
			{
				return this.state.currentErrors;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x0000DEA3 File Offset: 0x0000C0A3
		public bool hasError
		{
			get
			{
				return this.state.hasError;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x0000DEB0 File Offset: 0x0000C0B0
		public VariablesState variablesState
		{
			get
			{
				return this.state.variablesState;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x0000DEBD File Offset: 0x0000C0BD
		internal ListDefinitionsOrigin listDefinitions
		{
			get
			{
				return this._listDefinitions;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x0000DEC5 File Offset: 0x0000C0C5
		public StoryState state
		{
			get
			{
				return this._state;
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0000DECD File Offset: 0x0000C0CD
		public Profiler StartProfiling()
		{
			this._profiler = new Profiler();
			return this._profiler;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000DEE0 File Offset: 0x0000C0E0
		public void EndProfiling()
		{
			this._profiler = null;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000DEE9 File Offset: 0x0000C0E9
		internal Story(Container contentContainer, List<ListDefinition> lists = null)
		{
			this._mainContentContainer = contentContainer;
			if (lists != null)
			{
				this._listDefinitions = new ListDefinitionsOrigin(lists);
			}
			this._externals = new Dictionary<string, Story.ExternalFunction>();
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000DF14 File Offset: 0x0000C114
		public Story(string jsonString) : this(null, null)
		{
			Dictionary<string, object> dictionary = InkJSON.TextToDictionary(jsonString);
			object obj = dictionary["inkVersion"];
			if (obj == null)
			{
				throw new Exception("ink version number not found. Are you sure it's a valid .ink.json file?");
			}
			int num = (int)obj;
			if (num > 17)
			{
				throw new Exception("Version of ink used to build story was newer than the current verison of the engine");
			}
			if (num < 16)
			{
				throw new Exception("Version of ink used to build story is too old to be loaded by this verison of the engine");
			}
			object obj2 = dictionary["root"];
			if (obj2 == null)
			{
				throw new Exception("Root node for ink not found. Are you sure it's a valid .ink.json file?");
			}
			object obj3;
			if (dictionary.TryGetValue("listDefs", out obj3))
			{
				this._listDefinitions = Json.JTokenToListDefinitions(obj3);
			}
			this._mainContentContainer = (Json.JTokenToRuntimeObject(obj2) as Container);
			this.ResetState();
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000DFC0 File Offset: 0x0000C1C0
		public string ToJsonString()
		{
			List<object> value = (List<object>)Json.RuntimeObjectToJToken(this._mainContentContainer);
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary["inkVersion"] = 17;
			dictionary["root"] = value;
			if (this._listDefinitions != null)
			{
				dictionary["listDefs"] = Json.ListDefinitionsToJToken(this._listDefinitions);
			}
			return InkJSON.DictionaryToText(dictionary);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000E026 File Offset: 0x0000C226
		public void ResetState()
		{
			this._state = new StoryState(this);
			this._state.variablesState.variableChangedEvent += this.VariableStateDidChangeEvent;
			this.ResetGlobals();
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000E056 File Offset: 0x0000C256
		public void ResetErrors()
		{
			this._state.ResetErrors();
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000E063 File Offset: 0x0000C263
		public void ResetCallstack()
		{
			this._state.ForceEnd();
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000E070 File Offset: 0x0000C270
		private void ResetGlobals()
		{
			if (this._mainContentContainer.namedContent.ContainsKey("global decl"))
			{
				Path currentPath = this.state.currentPath;
				this.ChoosePathString("global decl", Array.Empty<object>());
				this.ContinueInternal();
				this.state.currentPath = currentPath;
			}
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000E0C3 File Offset: 0x0000C2C3
		public string Continue()
		{
			if (!this._hasValidatedExternals)
			{
				this.ValidateExternalBindings();
			}
			return this.ContinueInternal();
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000E0DC File Offset: 0x0000C2DC
		private string ContinueInternal()
		{
			if (!this.canContinue)
			{
				throw new StoryException("Can't continue - should check canContinue before calling Continue");
			}
			if (this._profiler != null)
			{
				this._profiler.PreContinue();
			}
			this._state.ResetOutput();
			this._state.didSafeExit = false;
			this._state.variablesState.batchObservingVariableChanges = true;
			try
			{
				StoryState storyState = null;
				for (;;)
				{
					if (this._profiler != null)
					{
						this._profiler.PreStep();
					}
					this.Step();
					if (this._profiler != null)
					{
						this._profiler.PostStep();
					}
					bool canContinue = this.canContinue;
					if (!canContinue)
					{
						this.TryFollowDefaultInvisibleChoice();
						canContinue = this.canContinue;
					}
					if (this._profiler != null)
					{
						this._profiler.PreSnapshot();
					}
					if (!this.state.inStringEvaluation)
					{
						if (storyState != null)
						{
							string currentText = this.currentText;
							int length = storyState.currentText.Length;
							int count = storyState.currentTags.Count;
							if (!currentText.Equals(storyState.currentText) || count != this.currentTags.Count)
							{
								if (currentText.Length >= length && currentText[length - 1] == '\n')
								{
									break;
								}
								storyState = null;
							}
						}
						if (this.state.outputStreamEndsInNewline)
						{
							if (canContinue)
							{
								if (storyState == null)
								{
									storyState = this.StateSnapshot();
								}
							}
							else
							{
								storyState = null;
							}
						}
					}
					if (this._profiler != null)
					{
						this._profiler.PostSnapshot();
					}
					if (!canContinue)
					{
						goto IL_14E;
					}
				}
				this.RestoreStateSnapshot(storyState);
				IL_14E:
				if (storyState != null)
				{
					if (this._profiler != null)
					{
						this._profiler.PreRestore();
					}
					this.RestoreStateSnapshot(storyState);
					if (this._profiler != null)
					{
						this._profiler.PostRestore();
					}
				}
				if (!this.canContinue)
				{
					if (this.state.callStack.canPopThread)
					{
						this.Error("Thread available to pop, threads should always be flat by the end of evaluation?", false);
					}
					if (this.state.generatedChoices.Count == 0 && !this.state.didSafeExit && this._temporaryEvaluationContainer == null)
					{
						if (this.state.callStack.CanPop(new PushPopType?(PushPopType.Tunnel)))
						{
							this.Error("unexpectedly reached end of content. Do you need a '->->' to return from a tunnel?", false);
						}
						else if (this.state.callStack.CanPop(new PushPopType?(PushPopType.Function)))
						{
							this.Error("unexpectedly reached end of content. Do you need a '~ return'?", false);
						}
						else if (!this.state.callStack.canPop)
						{
							this.Error("ran out of content. Do you need a '-> DONE' or '-> END'?", false);
						}
						else
						{
							this.Error("unexpectedly reached end of content for unknown reason. Please debug compiler!", false);
						}
					}
				}
			}
			catch (StoryException ex)
			{
				this.AddError(ex.Message, ex.useEndLineNumber);
			}
			finally
			{
				this.state.didSafeExit = false;
				this._state.variablesState.batchObservingVariableChanges = false;
			}
			if (this._profiler != null)
			{
				this._profiler.PostContinue();
			}
			return this.currentText;
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x0000E3C0 File Offset: 0x0000C5C0
		public bool canContinue
		{
			get
			{
				return this.state.canContinue;
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000E3D0 File Offset: 0x0000C5D0
		public string ContinueMaximally()
		{
			StringBuilder stringBuilder = new StringBuilder();
			while (this.canContinue)
			{
				stringBuilder.Append(this.Continue());
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000E400 File Offset: 0x0000C600
		internal Object ContentAtPath(Path path)
		{
			return this.mainContentContainer.ContentAtPath(path, -1);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000E40F File Offset: 0x0000C60F
		private StoryState StateSnapshot()
		{
			return this.state.Copy();
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000E41C File Offset: 0x0000C61C
		private void RestoreStateSnapshot(StoryState state)
		{
			this._state = state;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000E428 File Offset: 0x0000C628
		private void Step()
		{
			bool flag = true;
			Object @object = this.state.currentContentObject;
			if (@object == null)
			{
				return;
			}
			Container container = @object as Container;
			while (container)
			{
				this.VisitContainer(container, true);
				if (container.content.Count == 0)
				{
					break;
				}
				@object = container.content[0];
				this.state.callStack.currentElement.currentContentIndex = 0;
				this.state.callStack.currentElement.currentContainer = container;
				container = (@object as Container);
			}
			container = this.state.callStack.currentElement.currentContainer;
			if (this._profiler != null)
			{
				this._profiler.Step(this.state.callStack);
			}
			bool flag2 = this.PerformLogicAndFlowControl(@object);
			if (this.state.currentContentObject == null)
			{
				return;
			}
			if (flag2)
			{
				flag = false;
			}
			ChoicePoint choicePoint = @object as ChoicePoint;
			if (choicePoint)
			{
				Choice choice = this.ProcessChoice(choicePoint);
				if (choice)
				{
					this.state.generatedChoices.Add(choice);
				}
				@object = null;
				flag = false;
			}
			if (@object is Container)
			{
				flag = false;
			}
			if (flag)
			{
				VariablePointerValue variablePointerValue = @object as VariablePointerValue;
				if (variablePointerValue && variablePointerValue.contextIndex == -1)
				{
					int contextIndex = this.state.callStack.ContextForVariableNamed(variablePointerValue.variableName);
					@object = new VariablePointerValue(variablePointerValue.variableName, contextIndex);
				}
				if (this.state.inExpressionEvaluation)
				{
					this.state.PushEvaluationStack(@object);
				}
				else
				{
					this.state.PushToOutputStream(@object);
				}
			}
			this.NextContent();
			ControlCommand controlCommand = @object as ControlCommand;
			if (controlCommand && controlCommand.commandType == ControlCommand.CommandType.StartThread)
			{
				this.state.callStack.PushThread();
			}
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000E5EB File Offset: 0x0000C7EB
		private void VisitContainer(Container container, bool atStart)
		{
			if (!container.countingAtStartOnly || atStart)
			{
				if (container.visitsShouldBeCounted)
				{
					this.IncrementVisitCountForContainer(container);
				}
				if (container.turnIndexShouldBeCounted)
				{
					this.RecordTurnIndexVisitToContainer(container);
				}
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000E618 File Offset: 0x0000C818
		private void VisitChangedContainersDueToDivert()
		{
			Object previousContentObject = this.state.previousContentObject;
			Object currentContentObject = this.state.currentContentObject;
			if (!currentContentObject)
			{
				return;
			}
			if (this._prevContainerSet == null)
			{
				this._prevContainerSet = new HashSet<Container>();
			}
			this._prevContainerSet.Clear();
			if (previousContentObject)
			{
				Container container = (previousContentObject as Container) ?? (previousContentObject.parent as Container);
				while (container)
				{
					this._prevContainerSet.Add(container);
					container = (container.parent as Container);
				}
			}
			Object @object = currentContentObject;
			Container container2 = @object.parent as Container;
			while (container2 && !this._prevContainerSet.Contains(container2))
			{
				bool atStart = container2.content.Count > 0 && @object == container2.content[0];
				this.VisitContainer(container2, atStart);
				@object = container2;
				container2 = (container2.parent as Container);
			}
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000E70C File Offset: 0x0000C90C
		private Choice ProcessChoice(ChoicePoint choicePoint)
		{
			bool flag = true;
			if (choicePoint.hasCondition)
			{
				Object obj = this.state.PopEvaluationStack();
				if (!this.IsTruthy(obj))
				{
					flag = false;
				}
			}
			string str = "";
			string str2 = "";
			if (choicePoint.hasChoiceOnlyContent)
			{
				str2 = (this.state.PopEvaluationStack() as StringValue).value;
			}
			if (choicePoint.hasStartContent)
			{
				str = (this.state.PopEvaluationStack() as StringValue).value;
			}
			if (choicePoint.onceOnly && this.VisitCountForContainer(choicePoint.choiceTarget) > 0)
			{
				flag = false;
			}
			Choice choice = new Choice(choicePoint);
			choice.threadAtGeneration = this.state.callStack.currentThread.Copy();
			if (!flag)
			{
				return null;
			}
			choice.text = str + str2;
			return choice;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000E7D4 File Offset: 0x0000C9D4
		private bool IsTruthy(Object obj)
		{
			bool result = false;
			if (!(obj is Value))
			{
				return result;
			}
			Value value = (Value)obj;
			if (value is DivertTargetValue)
			{
				DivertTargetValue divertTargetValue = (DivertTargetValue)value;
				string str = "Shouldn't use a divert target (to ";
				Path targetPath = divertTargetValue.targetPath;
				this.Error(str + ((targetPath != null) ? targetPath.ToString() : null) + ") as a conditional value. Did you intend a function call 'likeThis()' or a read count check 'likeThis'? (no arrows)", false);
				return false;
			}
			return value.isTruthy;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000E834 File Offset: 0x0000CA34
		private bool PerformLogicAndFlowControl(Object contentObj)
		{
			if (contentObj == null)
			{
				return false;
			}
			if (contentObj is Divert)
			{
				Divert divert = (Divert)contentObj;
				if (divert.isConditional)
				{
					Object obj4 = this.state.PopEvaluationStack();
					if (!this.IsTruthy(obj4))
					{
						return true;
					}
				}
				if (divert.hasVariableTarget)
				{
					string variableDivertName = divert.variableDivertName;
					Object variableWithName = this.state.variablesState.GetVariableWithName(variableDivertName);
					if (!(variableWithName is DivertTargetValue))
					{
						IntValue intValue = variableWithName as IntValue;
						string text = "Tried to divert to a target from a variable, but the variable (" + variableDivertName + ") didn't contain a divert target, it ";
						if (intValue && intValue.value == 0)
						{
							text += "was empty/null (the value 0).";
						}
						else
						{
							string str = text;
							string str2 = "contained '";
							Object @object = variableWithName;
							text = str + str2 + ((@object != null) ? @object.ToString() : null) + "'.";
						}
						this.Error(text, false);
					}
					DivertTargetValue divertTargetValue = (DivertTargetValue)variableWithName;
					this.state.divertedTargetObject = this.ContentAtPath(divertTargetValue.targetPath);
				}
				else
				{
					if (divert.isExternal)
					{
						this.CallExternalFunction(divert.targetPathString, divert.externalArgs);
						return true;
					}
					this.state.divertedTargetObject = divert.targetContent;
				}
				if (divert.pushesToStack)
				{
					this.state.callStack.Push(divert.stackPushType);
				}
				if (this.state.divertedTargetObject == null && !divert.isExternal)
				{
					if (divert && divert.debugMetadata.sourceName != null)
					{
						this.Error("Divert target doesn't exist: " + divert.debugMetadata.sourceName, false);
					}
					else
					{
						string str3 = "Divert resolution failed: ";
						Divert divert2 = divert;
						this.Error(str3 + ((divert2 != null) ? divert2.ToString() : null), false);
					}
				}
				return true;
			}
			if (contentObj is ControlCommand)
			{
				ControlCommand controlCommand = (ControlCommand)contentObj;
				switch (controlCommand.commandType)
				{
				case ControlCommand.CommandType.EvalStart:
					this.Assert(!this.state.inExpressionEvaluation, "Already in expression evaluation?", Array.Empty<object>());
					this.state.inExpressionEvaluation = true;
					break;
				case ControlCommand.CommandType.EvalOutput:
					if (this.state.evaluationStack.Count > 0)
					{
						Object object2 = this.state.PopEvaluationStack();
						if (!(object2 is Void))
						{
							StringValue obj2 = new StringValue(object2.ToString());
							this.state.PushToOutputStream(obj2);
						}
					}
					break;
				case ControlCommand.CommandType.EvalEnd:
					this.Assert(this.state.inExpressionEvaluation, "Not in expression evaluation mode", Array.Empty<object>());
					this.state.inExpressionEvaluation = false;
					break;
				case ControlCommand.CommandType.Duplicate:
					this.state.PushEvaluationStack(this.state.PeekEvaluationStack());
					break;
				case ControlCommand.CommandType.PopEvaluatedValue:
					this.state.PopEvaluationStack();
					break;
				case ControlCommand.CommandType.PopFunction:
				case ControlCommand.CommandType.PopTunnel:
				{
					PushPopType pushPopType = (controlCommand.commandType == ControlCommand.CommandType.PopFunction) ? PushPopType.Function : PushPopType.Tunnel;
					DivertTargetValue divertTargetValue2 = null;
					if (pushPopType == PushPopType.Tunnel)
					{
						Object object3 = this.state.PopEvaluationStack();
						divertTargetValue2 = (object3 as DivertTargetValue);
						if (divertTargetValue2 == null)
						{
							this.Assert(object3 is Void, "Expected void if ->-> doesn't override target", Array.Empty<object>());
						}
					}
					if (!this.state.TryExitExternalFunctionEvaluation())
					{
						if (this.state.callStack.currentElement.type != pushPopType || !this.state.callStack.canPop)
						{
							Dictionary<PushPopType, string> dictionary = new Dictionary<PushPopType, string>();
							dictionary[PushPopType.Function] = "function return statement (~ return)";
							dictionary[PushPopType.Tunnel] = "tunnel onwards statement (->->)";
							string arg = dictionary[this.state.callStack.currentElement.type];
							if (!this.state.callStack.canPop)
							{
								arg = "end of flow (-> END or choice)";
							}
							string message = string.Format("Found {0}, when expected {1}", dictionary[pushPopType], arg);
							this.Error(message, false);
						}
						else
						{
							this.state.callStack.Pop(null);
							if (divertTargetValue2)
							{
								this.state.divertedTargetObject = this.ContentAtPath(divertTargetValue2.targetPath);
							}
						}
					}
					break;
				}
				case ControlCommand.CommandType.BeginString:
					this.state.PushToOutputStream(controlCommand);
					this.Assert(this.state.inExpressionEvaluation, "Expected to be in an expression when evaluating a string", Array.Empty<object>());
					this.state.inExpressionEvaluation = false;
					break;
				case ControlCommand.CommandType.EndString:
				{
					Stack<Object> stack = new Stack<Object>();
					int num = 0;
					for (int i = this.state.outputStream.Count - 1; i >= 0; i--)
					{
						Object object4 = this.state.outputStream[i];
						num++;
						ControlCommand controlCommand2 = object4 as ControlCommand;
						if (controlCommand2 != null && controlCommand2.commandType == ControlCommand.CommandType.BeginString)
						{
							break;
						}
						if (object4 is StringValue)
						{
							stack.Push(object4);
						}
					}
					this.state.outputStream.RemoveRange(this.state.outputStream.Count - num, num);
					StringBuilder stringBuilder = new StringBuilder();
					foreach (Object object5 in stack)
					{
						stringBuilder.Append(object5.ToString());
					}
					this.state.inExpressionEvaluation = true;
					this.state.PushEvaluationStack(new StringValue(stringBuilder.ToString()));
					break;
				}
				case ControlCommand.CommandType.NoOp:
				case ControlCommand.CommandType.StartThread:
					break;
				case ControlCommand.CommandType.ChoiceCount:
				{
					int count = this.state.generatedChoices.Count;
					this.state.PushEvaluationStack(new IntValue(count));
					break;
				}
				case ControlCommand.CommandType.TurnsSince:
				case ControlCommand.CommandType.ReadCount:
				{
					Object object6 = this.state.PopEvaluationStack();
					if (!(object6 is DivertTargetValue))
					{
						string str4 = "";
						if (object6 is IntValue)
						{
							str4 = ". Did you accidentally pass a read count ('knot_name') instead of a target ('-> knot_name')?";
						}
						string str5 = "TURNS_SINCE expected a divert target (knot, stitch, label name), but saw ";
						Object object7 = object6;
						this.Error(str5 + ((object7 != null) ? object7.ToString() : null) + str4, false);
					}
					else
					{
						DivertTargetValue divertTargetValue3 = object6 as DivertTargetValue;
						Container container = this.ContentAtPath(divertTargetValue3.targetPath) as Container;
						int intVal;
						if (controlCommand.commandType == ControlCommand.CommandType.TurnsSince)
						{
							intVal = this.TurnsSinceForContainer(container);
						}
						else
						{
							intVal = this.VisitCountForContainer(container);
						}
						this.state.PushEvaluationStack(new IntValue(intVal));
					}
					break;
				}
				case ControlCommand.CommandType.Random:
				{
					IntValue intValue2 = this.state.PopEvaluationStack() as IntValue;
					IntValue intValue3 = this.state.PopEvaluationStack() as IntValue;
					if (intValue3 == null)
					{
						this.Error("Invalid value for minimum parameter of RANDOM(min, max)", false);
					}
					if (intValue2 == null)
					{
						this.Error("Invalid value for maximum parameter of RANDOM(min, max)", false);
					}
					int num2 = intValue2.value - intValue3.value + 1;
					if (num2 <= 0)
					{
						this.Error(string.Concat(new string[]
						{
							"RANDOM was called with minimum as ",
							intValue3.value.ToString(),
							" and maximum as ",
							intValue2.value.ToString(),
							". The maximum must be larger"
						}), false);
					}
					int num3 = new Random(this.state.storySeed + this.state.previousRandom).Next();
					int intVal2 = num3 % num2 + intValue3.value;
					this.state.PushEvaluationStack(new IntValue(intVal2));
					this.state.previousRandom = num3;
					break;
				}
				case ControlCommand.CommandType.SeedRandom:
				{
					IntValue intValue4 = this.state.PopEvaluationStack() as IntValue;
					if (intValue4 == null)
					{
						this.Error("Invalid value passed to SEED_RANDOM", false);
					}
					this.state.storySeed = intValue4.value;
					this.state.previousRandom = 0;
					this.state.PushEvaluationStack(new Void());
					break;
				}
				case ControlCommand.CommandType.VisitIndex:
				{
					int intVal3 = this.VisitCountForContainer(this.state.currentContainer) - 1;
					this.state.PushEvaluationStack(new IntValue(intVal3));
					break;
				}
				case ControlCommand.CommandType.SequenceShuffleIndex:
				{
					int intVal4 = this.NextSequenceShuffleIndex();
					this.state.PushEvaluationStack(new IntValue(intVal4));
					break;
				}
				case ControlCommand.CommandType.Done:
					if (this.state.callStack.canPopThread)
					{
						this.state.callStack.PopThread();
					}
					else
					{
						this.state.didSafeExit = true;
						this.state.currentContentObject = null;
					}
					break;
				case ControlCommand.CommandType.End:
					this.state.ForceEnd();
					break;
				case ControlCommand.CommandType.ListFromInt:
				{
					IntValue intValue5 = this.state.PopEvaluationStack() as IntValue;
					StringValue stringValue = this.state.PopEvaluationStack() as StringValue;
					if (intValue5 == null)
					{
						throw new StoryException("Passed non-integer when creating a list element from a numerical value.");
					}
					ListValue listValue = null;
					ListDefinition listDefinition;
					if (!this.listDefinitions.TryListGetDefinition(stringValue.value, out listDefinition))
					{
						throw new StoryException("Failed to find LIST called " + stringValue.value);
					}
					InkListItem singleItem;
					if (listDefinition.TryGetItemWithValue(intValue5.value, out singleItem))
					{
						listValue = new ListValue(singleItem, intValue5.value);
					}
					if (listValue == null)
					{
						listValue = new ListValue();
					}
					this.state.PushEvaluationStack(listValue);
					break;
				}
				case ControlCommand.CommandType.ListRange:
				{
					Object object8 = this.state.PopEvaluationStack();
					Object object9 = this.state.PopEvaluationStack();
					ListValue listValue2 = this.state.PopEvaluationStack() as ListValue;
					if (listValue2 == null || object9 == null || object8 == null)
					{
						throw new StoryException("Expected list, minimum and maximum for LIST_RANGE");
					}
					Func<Object, int> func = delegate(Object obj)
					{
						ListValue listValue4 = obj as ListValue;
						if (listValue4)
						{
							return listValue4.value.maxItem.Value;
						}
						IntValue intValue6 = obj as IntValue;
						if (intValue6)
						{
							return intValue6.value;
						}
						return -1;
					};
					int num4 = func(object9);
					int num5 = func(object8);
					if (num4 == -1)
					{
						string str6 = "Invalid min range bound passed to LIST_VALUE(): ";
						Object object10 = object9;
						throw new StoryException(str6 + ((object10 != null) ? object10.ToString() : null));
					}
					if (num5 == -1)
					{
						string str7 = "Invalid max range bound passed to LIST_VALUE(): ";
						Object object11 = object8;
						throw new StoryException(str7 + ((object11 != null) ? object11.ToString() : null));
					}
					ListValue listValue3 = new ListValue();
					List<ListDefinition> origins = listValue2.value.origins;
					if (origins != null)
					{
						foreach (ListDefinition listDefinition2 in origins)
						{
							foreach (KeyValuePair<InkListItem, int> keyValuePair in listDefinition2.ListRange(num4, num5).value)
							{
								listValue3.value[keyValuePair.Key] = keyValuePair.Value;
							}
						}
					}
					this.state.PushEvaluationStack(listValue3);
					break;
				}
				default:
				{
					string str8 = "unhandled ControlCommand: ";
					ControlCommand controlCommand3 = controlCommand;
					this.Error(str8 + ((controlCommand3 != null) ? controlCommand3.ToString() : null), false);
					break;
				}
				}
				return true;
			}
			if (contentObj is VariableAssignment)
			{
				VariableAssignment varAss = (VariableAssignment)contentObj;
				Object value = this.state.PopEvaluationStack();
				this.state.variablesState.Assign(varAss, value);
				return true;
			}
			if (contentObj is VariableReference)
			{
				VariableReference variableReference = (VariableReference)contentObj;
				Object object12;
				if (variableReference.pathForCount != null)
				{
					Container containerForCount = variableReference.containerForCount;
					object12 = new IntValue(this.VisitCountForContainer(containerForCount));
				}
				else
				{
					object12 = this.state.variablesState.GetVariableWithName(variableReference.name);
					if (object12 == null)
					{
						this.Error("Uninitialised variable: " + variableReference.name, false);
						object12 = new IntValue(0);
					}
				}
				this.state.PushEvaluationStack(object12);
				return true;
			}
			if (contentObj is NativeFunctionCall)
			{
				NativeFunctionCall nativeFunctionCall = (NativeFunctionCall)contentObj;
				List<Object> parameters = this.state.PopEvaluationStack(nativeFunctionCall.numberOfParameters);
				Object obj3 = nativeFunctionCall.Call(parameters);
				this.state.PushEvaluationStack(obj3);
				return true;
			}
			return false;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0000F408 File Offset: 0x0000D608
		public void ChoosePathString(string path, params object[] arguments)
		{
			this.state.PassArgumentsToEvaluationStack(arguments);
			this.ChoosePath(new Path(path));
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000F422 File Offset: 0x0000D622
		internal void ChoosePath(Path p)
		{
			this.state.SetChosenPath(p);
			this.VisitChangedContainersDueToDivert();
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000F438 File Offset: 0x0000D638
		public void ChooseChoiceIndex(int choiceIdx)
		{
			List<Choice> currentChoices = this.currentChoices;
			this.Assert(choiceIdx >= 0 && choiceIdx < currentChoices.Count, "choice out of range", Array.Empty<object>());
			Choice choice = currentChoices[choiceIdx];
			this.state.callStack.currentThread = choice.threadAtGeneration;
			this.ChoosePath(choice.choicePoint.choiceTarget.path);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0000F4A0 File Offset: 0x0000D6A0
		public bool HasFunction(string functionName)
		{
			bool result;
			try
			{
				result = (this.ContentAtPath(new Path(functionName)) is Container);
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000F4DC File Offset: 0x0000D6DC
		public object EvaluateFunction(string functionName, params object[] arguments)
		{
			string text;
			return this.EvaluateFunction(functionName, out text, arguments);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000F4F4 File Offset: 0x0000D6F4
		public object EvaluateFunction(string functionName, out string textOutput, params object[] arguments)
		{
			if (functionName == null)
			{
				throw new Exception("Function is null");
			}
			if (functionName == string.Empty || functionName.Trim() == string.Empty)
			{
				throw new Exception("Function is empty or white space.");
			}
			Container funcContainer = null;
			try
			{
				funcContainer = (this.ContentAtPath(new Path(functionName)) as Container);
			}
			catch (StoryException ex)
			{
				if (ex.Message.Contains("not found"))
				{
					throw new Exception("Function doesn't exist: '" + functionName + "'");
				}
				throw ex;
			}
			this.state.StartExternalFunctionEvaluation(funcContainer, arguments);
			StringBuilder stringBuilder = new StringBuilder();
			while (this.canContinue)
			{
				stringBuilder.Append(this.Continue());
			}
			textOutput = stringBuilder.ToString();
			return this.state.CompleteExternalFunctionEvaluation();
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000F5C8 File Offset: 0x0000D7C8
		internal Object EvaluateExpression(Container exprContainer)
		{
			int count = this.state.callStack.elements.Count;
			this.state.callStack.Push(PushPopType.Tunnel);
			this._temporaryEvaluationContainer = exprContainer;
			this.state.GoToStart();
			int count2 = this.state.evaluationStack.Count;
			this.Continue();
			this._temporaryEvaluationContainer = null;
			if (this.state.callStack.elements.Count > count)
			{
				this.state.callStack.Pop(null);
			}
			if (this.state.evaluationStack.Count > count2)
			{
				return this.state.PopEvaluationStack();
			}
			return null;
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x0000F67E File Offset: 0x0000D87E
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x0000F686 File Offset: 0x0000D886
		public bool allowExternalFunctionFallbacks { get; set; }

		// Token: 0x060001F8 RID: 504 RVA: 0x0000F690 File Offset: 0x0000D890
		internal void CallExternalFunction(string funcName, int numberOfArguments)
		{
			Story.ExternalFunction externalFunction = null;
			if (!this._externals.TryGetValue(funcName, out externalFunction))
			{
				if (this.allowExternalFunctionFallbacks)
				{
					Container container = this.ContentAtPath(new Path(funcName)) as Container;
					this.Assert(container != null, "Trying to call EXTERNAL function '" + funcName + "' which has not been bound, and fallback ink function could not be found.", Array.Empty<object>());
					this.state.callStack.Push(PushPopType.Function);
					this.state.divertedTargetObject = container;
					return;
				}
				this.Assert(false, "Trying to call EXTERNAL function '" + funcName + "' which has not been bound (and ink fallbacks disabled).", Array.Empty<object>());
			}
			List<object> list = new List<object>();
			for (int i = 0; i < numberOfArguments; i++)
			{
				object valueObject = (this.state.PopEvaluationStack() as Value).valueObject;
				list.Add(valueObject);
			}
			list.Reverse();
			object obj = externalFunction(list.ToArray());
			Object @object;
			if (obj != null)
			{
				@object = Value.Create(obj);
				bool condition = @object != null;
				string str = "Could not create ink value from returned object of type ";
				Type type = obj.GetType();
				this.Assert(condition, str + ((type != null) ? type.ToString() : null), Array.Empty<object>());
			}
			else
			{
				@object = new Void();
			}
			this.state.PushEvaluationStack(@object);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000F7C2 File Offset: 0x0000D9C2
		public void BindExternalFunctionGeneral(string funcName, Story.ExternalFunction func)
		{
			this.Assert(!this._externals.ContainsKey(funcName), "Function '" + funcName + "' has already been bound.", Array.Empty<object>());
			this._externals[funcName] = func;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000F7FC File Offset: 0x0000D9FC
		private object TryCoerce<T>(object value)
		{
			if (value == null)
			{
				return null;
			}
			if (value is T)
			{
				return (T)((object)value);
			}
			if (value is float && typeof(T) == typeof(int))
			{
				return (int)Math.Round((double)((float)value));
			}
			if (value is int && typeof(T) == typeof(float))
			{
				return (float)((int)value);
			}
			if (value is int && typeof(T) == typeof(bool))
			{
				return (int)value != 0;
			}
			if (typeof(T) == typeof(string))
			{
				return value.ToString();
			}
			this.Assert(false, "Failed to cast " + value.GetType().Name + " to " + typeof(T).Name, Array.Empty<object>());
			return null;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000F918 File Offset: 0x0000DB18
		public void BindExternalFunction(string funcName, Func<object> func)
		{
			this.Assert(func != null, "Can't bind a null function", Array.Empty<object>());
			this.BindExternalFunctionGeneral(funcName, delegate(object[] args)
			{
				this.Assert(args.Length == 0, "External function expected no arguments", Array.Empty<object>());
				return func();
			});
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000F968 File Offset: 0x0000DB68
		public void BindExternalFunction(string funcName, Action act)
		{
			this.Assert(act != null, "Can't bind a null function", Array.Empty<object>());
			this.BindExternalFunctionGeneral(funcName, delegate(object[] args)
			{
				this.Assert(args.Length == 0, "External function expected no arguments", Array.Empty<object>());
				act();
				return null;
			});
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000F9B8 File Offset: 0x0000DBB8
		public void BindExternalFunction<T>(string funcName, Func<T, object> func)
		{
			this.Assert(func != null, "Can't bind a null function", Array.Empty<object>());
			this.BindExternalFunctionGeneral(funcName, delegate(object[] args)
			{
				this.Assert(args.Length == 1, "External function expected one argument", Array.Empty<object>());
				return func((T)((object)this.TryCoerce<T>(args[0])));
			});
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000FA08 File Offset: 0x0000DC08
		public void BindExternalFunction<T>(string funcName, Action<T> act)
		{
			this.Assert(act != null, "Can't bind a null function", Array.Empty<object>());
			this.BindExternalFunctionGeneral(funcName, delegate(object[] args)
			{
				this.Assert(args.Length == 1, "External function expected one argument", Array.Empty<object>());
				act((T)((object)this.TryCoerce<T>(args[0])));
				return null;
			});
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000FA58 File Offset: 0x0000DC58
		public void BindExternalFunction<T1, T2>(string funcName, Func<T1, T2, object> func)
		{
			this.Assert(func != null, "Can't bind a null function", Array.Empty<object>());
			this.BindExternalFunctionGeneral(funcName, delegate(object[] args)
			{
				this.Assert(args.Length == 2, "External function expected two arguments", Array.Empty<object>());
				return func((T1)((object)this.TryCoerce<T1>(args[0])), (T2)((object)this.TryCoerce<T2>(args[1])));
			});
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000FAA8 File Offset: 0x0000DCA8
		public void BindExternalFunction<T1, T2>(string funcName, Action<T1, T2> act)
		{
			this.Assert(act != null, "Can't bind a null function", Array.Empty<object>());
			this.BindExternalFunctionGeneral(funcName, delegate(object[] args)
			{
				this.Assert(args.Length == 2, "External function expected two arguments", Array.Empty<object>());
				act((T1)((object)this.TryCoerce<T1>(args[0])), (T2)((object)this.TryCoerce<T2>(args[1])));
				return null;
			});
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000FAF8 File Offset: 0x0000DCF8
		public void BindExternalFunction<T1, T2, T3>(string funcName, Func<T1, T2, T3, object> func)
		{
			this.Assert(func != null, "Can't bind a null function", Array.Empty<object>());
			this.BindExternalFunctionGeneral(funcName, delegate(object[] args)
			{
				this.Assert(args.Length == 3, "External function expected two arguments", Array.Empty<object>());
				return func((T1)((object)this.TryCoerce<T1>(args[0])), (T2)((object)this.TryCoerce<T2>(args[1])), (T3)((object)this.TryCoerce<T3>(args[2])));
			});
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0000FB48 File Offset: 0x0000DD48
		public void BindExternalFunction<T1, T2, T3>(string funcName, Action<T1, T2, T3> act)
		{
			this.Assert(act != null, "Can't bind a null function", Array.Empty<object>());
			this.BindExternalFunctionGeneral(funcName, delegate(object[] args)
			{
				this.Assert(args.Length == 3, "External function expected two arguments", Array.Empty<object>());
				act((T1)((object)this.TryCoerce<T1>(args[0])), (T2)((object)this.TryCoerce<T2>(args[1])), (T3)((object)this.TryCoerce<T3>(args[2])));
				return null;
			});
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000FB95 File Offset: 0x0000DD95
		public void UnbindExternalFunction(string funcName)
		{
			this.Assert(this._externals.ContainsKey(funcName), "Function '" + funcName + "' has not been bound.", Array.Empty<object>());
			this._externals.Remove(funcName);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000FBCC File Offset: 0x0000DDCC
		public void ValidateExternalBindings()
		{
			HashSet<string> hashSet = new HashSet<string>();
			this.ValidateExternalBindings(this._mainContentContainer, hashSet);
			this._hasValidatedExternals = true;
			if (hashSet.Count == 0)
			{
				this._hasValidatedExternals = true;
				return;
			}
			string message = string.Format("ERROR: Missing function binding for external{0}: '{1}' {2}", (hashSet.Count > 1) ? "s" : string.Empty, string.Join("', '", hashSet.ToArray<string>()), this.allowExternalFunctionFallbacks ? ", and no fallback ink function found." : " (ink fallbacks disabled)");
			this.Error(message, false);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000FC50 File Offset: 0x0000DE50
		private void ValidateExternalBindings(Container c, HashSet<string> missingExternals)
		{
			foreach (Object @object in c.content)
			{
				Container container = @object as Container;
				if (container == null || !container.hasValidName)
				{
					this.ValidateExternalBindings(@object, missingExternals);
				}
			}
			foreach (KeyValuePair<string, INamedContent> keyValuePair in c.namedContent)
			{
				this.ValidateExternalBindings(keyValuePair.Value as Object, missingExternals);
			}
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000FD0C File Offset: 0x0000DF0C
		private void ValidateExternalBindings(Object o, HashSet<string> missingExternals)
		{
			Container container = o as Container;
			if (container)
			{
				this.ValidateExternalBindings(container, missingExternals);
				return;
			}
			Divert divert = o as Divert;
			if (divert && divert.isExternal)
			{
				string targetPathString = divert.targetPathString;
				if (!this._externals.ContainsKey(targetPathString))
				{
					if (this.allowExternalFunctionFallbacks)
					{
						if (!this.mainContentContainer.namedContent.ContainsKey(targetPathString))
						{
							missingExternals.Add(targetPathString);
							return;
						}
					}
					else
					{
						missingExternals.Add(targetPathString);
					}
				}
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000FD8C File Offset: 0x0000DF8C
		public void ObserveVariable(string variableName, Story.VariableObserver observer)
		{
			if (this._variableObservers == null)
			{
				this._variableObservers = new Dictionary<string, Story.VariableObserver>();
			}
			if (!this.state.variablesState.GlobalVariableExistsWithName(variableName))
			{
				throw new StoryException("Cannot observe variable '" + variableName + "' because it wasn't declared in the ink story.");
			}
			if (this._variableObservers.ContainsKey(variableName))
			{
				Dictionary<string, Story.VariableObserver> variableObservers = this._variableObservers;
				variableObservers[variableName] = (Story.VariableObserver)Delegate.Combine(variableObservers[variableName], observer);
				return;
			}
			this._variableObservers[variableName] = observer;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000FE14 File Offset: 0x0000E014
		public void ObserveVariables(IList<string> variableNames, Story.VariableObserver observer)
		{
			foreach (string variableName in variableNames)
			{
				this.ObserveVariable(variableName, observer);
			}
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000FE60 File Offset: 0x0000E060
		public void RemoveVariableObserver(Story.VariableObserver observer, string specificVariableName = null)
		{
			if (this._variableObservers == null)
			{
				return;
			}
			if (specificVariableName != null)
			{
				if (this._variableObservers.ContainsKey(specificVariableName))
				{
					Dictionary<string, Story.VariableObserver> variableObservers = this._variableObservers;
					variableObservers[specificVariableName] = (Story.VariableObserver)Delegate.Remove(variableObservers[specificVariableName], observer);
					return;
				}
			}
			else
			{
				foreach (KeyValuePair<string, Story.VariableObserver> keyValuePair in this._variableObservers)
				{
					string key = keyValuePair.Key;
					Dictionary<string, Story.VariableObserver> variableObservers = this._variableObservers;
					string key2 = key;
					variableObservers[key2] = (Story.VariableObserver)Delegate.Remove(variableObservers[key2], observer);
				}
			}
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000FF14 File Offset: 0x0000E114
		private void VariableStateDidChangeEvent(string variableName, Object newValueObj)
		{
			if (this._variableObservers == null)
			{
				return;
			}
			Story.VariableObserver variableObserver = null;
			if (this._variableObservers.TryGetValue(variableName, out variableObserver))
			{
				if (!(newValueObj is Value))
				{
					throw new Exception("Tried to get the value of a variable that isn't a standard type");
				}
				Value value = newValueObj as Value;
				variableObserver(variableName, value.valueObject);
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600020B RID: 523 RVA: 0x0000FF63 File Offset: 0x0000E163
		public List<string> globalTags
		{
			get
			{
				return this.TagsAtStartOfFlowContainerWithPathString("");
			}
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000FF70 File Offset: 0x0000E170
		public List<string> TagsForContentAtPath(string path)
		{
			return this.TagsAtStartOfFlowContainerWithPathString(path);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000FF7C File Offset: 0x0000E17C
		private List<string> TagsAtStartOfFlowContainerWithPathString(string pathString)
		{
			Path path = new Path(pathString);
			Container container = this.ContentAtPath(path) as Container;
			for (;;)
			{
				Object @object = container.content[0];
				if (!(@object is Container))
				{
					break;
				}
				container = (Container)@object;
			}
			List<string> list = null;
			foreach (Object object2 in container.content)
			{
				Tag tag = object2 as Tag;
				if (!tag)
				{
					break;
				}
				if (list == null)
				{
					list = new List<string>();
				}
				list.Add(tag.text);
			}
			return list;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00010024 File Offset: 0x0000E224
		public virtual string BuildStringOfHierarchy()
		{
			StringBuilder stringBuilder = new StringBuilder();
			this.mainContentContainer.BuildStringOfHierarchy(stringBuilder, 0, this.state.currentContentObject);
			return stringBuilder.ToString();
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00010058 File Offset: 0x0000E258
		private string BuildStringOfContainer(Container container)
		{
			StringBuilder stringBuilder = new StringBuilder();
			container.BuildStringOfHierarchy(stringBuilder, 0, this.state.currentContentObject);
			return stringBuilder.ToString();
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00010084 File Offset: 0x0000E284
		private void NextContent()
		{
			this.state.previousContentObject = this.state.currentContentObject;
			if (this.state.divertedTargetObject != null)
			{
				this.state.currentContentObject = this.state.divertedTargetObject;
				this.state.divertedTargetObject = null;
				this.VisitChangedContainersDueToDivert();
				if (this.state.currentContentObject != null)
				{
					return;
				}
			}
			if (!this.IncrementContentPointer())
			{
				bool flag = false;
				if (this.state.callStack.CanPop(new PushPopType?(PushPopType.Function)))
				{
					this.state.callStack.Pop(new PushPopType?(PushPopType.Function));
					if (this.state.inExpressionEvaluation)
					{
						this.state.PushEvaluationStack(new Void());
					}
					flag = true;
				}
				else if (this.state.callStack.canPopThread)
				{
					this.state.callStack.PopThread();
					flag = true;
				}
				else
				{
					this.state.TryExitExternalFunctionEvaluation();
				}
				if (flag && this.state.currentContentObject != null)
				{
					this.NextContent();
				}
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000101A0 File Offset: 0x0000E3A0
		private bool IncrementContentPointer()
		{
			bool flag = true;
			CallStack.Element currentElement = this.state.callStack.currentElement;
			currentElement.currentContentIndex++;
			while (currentElement.currentContentIndex >= currentElement.currentContainer.content.Count)
			{
				flag = false;
				Container container = currentElement.currentContainer.parent as Container;
				if (!container)
				{
					break;
				}
				int num = container.content.IndexOf(currentElement.currentContainer);
				if (num == -1)
				{
					break;
				}
				currentElement.currentContainer = container;
				currentElement.currentContentIndex = num + 1;
				flag = true;
			}
			if (!flag)
			{
				currentElement.currentContainer = null;
			}
			return flag;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00010238 File Offset: 0x0000E438
		private bool TryFollowDefaultInvisibleChoice()
		{
			List<Choice> currentChoices = this._state.currentChoices;
			List<Choice> list = (from c in currentChoices
			where c.choicePoint.isInvisibleDefault
			select c).ToList<Choice>();
			if (list.Count == 0 || currentChoices.Count > list.Count)
			{
				return false;
			}
			Choice choice = list[0];
			this.ChoosePath(choice.choicePoint.choiceTarget.path);
			return true;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x000102B4 File Offset: 0x0000E4B4
		private int VisitCountForContainer(Container container)
		{
			if (!container.visitsShouldBeCounted)
			{
				string[] array = new string[5];
				array[0] = "Read count for target (";
				array[1] = container.name;
				array[2] = " - on ";
				int num = 3;
				DebugMetadata debugMetadata = container.debugMetadata;
				array[num] = ((debugMetadata != null) ? debugMetadata.ToString() : null);
				array[4] = ") unknown. The story may need to be compiled with countAllVisits flag (-c).";
				this.Error(string.Concat(array), false);
				return 0;
			}
			int result = 0;
			string key = container.path.ToString();
			this.state.visitCounts.TryGetValue(key, out result);
			return result;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00010338 File Offset: 0x0000E538
		private void IncrementVisitCountForContainer(Container container)
		{
			int num = 0;
			string key = container.path.ToString();
			this.state.visitCounts.TryGetValue(key, out num);
			num++;
			this.state.visitCounts[key] = num;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00010380 File Offset: 0x0000E580
		private void RecordTurnIndexVisitToContainer(Container container)
		{
			string key = container.path.ToString();
			this.state.turnIndices[key] = this.state.currentTurnIndex;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x000103B8 File Offset: 0x0000E5B8
		private int TurnsSinceForContainer(Container container)
		{
			if (!container.turnIndexShouldBeCounted)
			{
				string[] array = new string[5];
				array[0] = "TURNS_SINCE() for target (";
				array[1] = container.name;
				array[2] = " - on ";
				int num = 3;
				DebugMetadata debugMetadata = container.debugMetadata;
				array[num] = ((debugMetadata != null) ? debugMetadata.ToString() : null);
				array[4] = ") unknown. The story may need to be compiled with countAllVisits flag (-c).";
				this.Error(string.Concat(array), false);
			}
			int num2 = 0;
			string key = container.path.ToString();
			if (this.state.turnIndices.TryGetValue(key, out num2))
			{
				return this.state.currentTurnIndex - num2;
			}
			return -1;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00010448 File Offset: 0x0000E648
		private int NextSequenceShuffleIndex()
		{
			IntValue intValue = this.state.PopEvaluationStack() as IntValue;
			if (intValue == null)
			{
				this.Error("expected number of elements in sequence for shuffle index", false);
				return 0;
			}
			Object currentContainer = this.state.currentContainer;
			int value = intValue.value;
			int value2 = (this.state.PopEvaluationStack() as IntValue).value;
			int num = value2 / value;
			int num2 = value2 % value;
			string text = currentContainer.path.ToString();
			int num3 = 0;
			foreach (char c in text)
			{
				num3 += (int)c;
			}
			Random random = new Random(num3 + num + this.state.storySeed);
			List<int> list = new List<int>();
			for (int j = 0; j < value; j++)
			{
				list.Add(j);
			}
			for (int k = 0; k <= num2; k++)
			{
				int index = random.Next() % list.Count;
				int result = list[index];
				list.RemoveAt(index);
				if (k == num2)
				{
					return result;
				}
			}
			throw new Exception("Should never reach here");
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00010560 File Offset: 0x0000E760
		private void Error(string message, bool useEndLineNumber = false)
		{
			throw new StoryException(message)
			{
				useEndLineNumber = useEndLineNumber
			};
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00010570 File Offset: 0x0000E770
		private void AddError(string message, bool useEndLineNumber)
		{
			DebugMetadata currentDebugMetadata = this.currentDebugMetadata;
			if (currentDebugMetadata != null)
			{
				int num = useEndLineNumber ? currentDebugMetadata.endLineNumber : currentDebugMetadata.startLineNumber;
				message = string.Format("RUNTIME ERROR: '{0}' line {1}: {2}", currentDebugMetadata.fileName, num, message);
			}
			else if (this.state.currentPath != null)
			{
				message = string.Format("RUNTIME ERROR: ({0}): {1}", this.state.currentPath, message);
			}
			else
			{
				message = "RUNTIME ERROR: " + message;
			}
			this.state.AddError(message);
			this.state.ForceEnd();
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00010600 File Offset: 0x0000E800
		private void Assert(bool condition, string message = null, params object[] formatParams)
		{
			if (!condition)
			{
				if (message == null)
				{
					message = "Story assert";
				}
				if (formatParams != null && formatParams.Count<object>() > 0)
				{
					message = string.Format(message, formatParams);
				}
				string str = message;
				string str2 = " ";
				DebugMetadata currentDebugMetadata = this.currentDebugMetadata;
				throw new Exception(str + str2 + ((currentDebugMetadata != null) ? currentDebugMetadata.ToString() : null));
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00010654 File Offset: 0x0000E854
		private DebugMetadata currentDebugMetadata
		{
			get
			{
				Object currentContentObject = this.state.currentContentObject;
				if (currentContentObject)
				{
					DebugMetadata debugMetadata = currentContentObject.debugMetadata;
					if (debugMetadata != null)
					{
						return debugMetadata;
					}
				}
				for (int i = this.state.callStack.elements.Count - 1; i >= 0; i--)
				{
					Object currentObject = this.state.callStack.elements[i].currentObject;
					if (currentObject && currentObject.debugMetadata != null)
					{
						return currentObject.debugMetadata;
					}
				}
				for (int j = this.state.outputStream.Count - 1; j >= 0; j--)
				{
					DebugMetadata debugMetadata = this.state.outputStream[j].debugMetadata;
					if (debugMetadata != null)
					{
						return debugMetadata;
					}
				}
				return null;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00010718 File Offset: 0x0000E918
		private int currentLineNumber
		{
			get
			{
				DebugMetadata currentDebugMetadata = this.currentDebugMetadata;
				if (currentDebugMetadata != null)
				{
					return currentDebugMetadata.startLineNumber;
				}
				return 0;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600021D RID: 541 RVA: 0x00010737 File Offset: 0x0000E937
		internal Container mainContentContainer
		{
			get
			{
				if (this._temporaryEvaluationContainer)
				{
					return this._temporaryEvaluationContainer;
				}
				return this._mainContentContainer;
			}
		}

		// Token: 0x04000178 RID: 376
		public static List<string> errorsLog = new List<string>();

		// Token: 0x04000179 RID: 377
		public const int inkVersionCurrent = 17;

		// Token: 0x0400017A RID: 378
		private const int inkVersionMinimumCompatible = 16;

		// Token: 0x0400017B RID: 379
		private HashSet<Container> _prevContainerSet;

		// Token: 0x0400017D RID: 381
		private Container _mainContentContainer;

		// Token: 0x0400017E RID: 382
		private ListDefinitionsOrigin _listDefinitions;

		// Token: 0x0400017F RID: 383
		private Dictionary<string, Story.ExternalFunction> _externals;

		// Token: 0x04000180 RID: 384
		private Dictionary<string, Story.VariableObserver> _variableObservers;

		// Token: 0x04000181 RID: 385
		private bool _hasValidatedExternals;

		// Token: 0x04000182 RID: 386
		private Container _temporaryEvaluationContainer;

		// Token: 0x04000183 RID: 387
		private StoryState _state;

		// Token: 0x04000184 RID: 388
		private Profiler _profiler;

		// Token: 0x02000071 RID: 113
		// (Invoke) Token: 0x06000361 RID: 865
		public delegate object ExternalFunction(object[] args);

		// Token: 0x02000072 RID: 114
		// (Invoke) Token: 0x06000365 RID: 869
		public delegate void VariableObserver(string variableName, object newValue);
	}
}
