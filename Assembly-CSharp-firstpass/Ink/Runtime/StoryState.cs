using System;
using System.Collections.Generic;
using System.Text;

namespace Ink.Runtime
{
	// Token: 0x02000036 RID: 54
	public class StoryState
	{
		// Token: 0x06000221 RID: 545 RVA: 0x00010770 File Offset: 0x0000E970
		public string ToJson()
		{
			return InkJSON.DictionaryToText(this.jsonToken);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0001077D File Offset: 0x0000E97D
		public void LoadJson(string json)
		{
			this.jsonToken = InkJSON.TextToDictionary(json);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0001078C File Offset: 0x0000E98C
		public int VisitCountAtPathString(string pathString)
		{
			int result;
			if (this.visitCounts.TryGetValue(pathString, out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000224 RID: 548 RVA: 0x000107AC File Offset: 0x0000E9AC
		internal int callstackDepth
		{
			get
			{
				return this.callStack.depth;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000225 RID: 549 RVA: 0x000107B9 File Offset: 0x0000E9B9
		internal List<Object> outputStream
		{
			get
			{
				return this._outputStream;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000226 RID: 550 RVA: 0x000107C1 File Offset: 0x0000E9C1
		internal List<Choice> currentChoices
		{
			get
			{
				if (this.canContinue)
				{
					return new List<Choice>();
				}
				return this._currentChoices;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000227 RID: 551 RVA: 0x000107D7 File Offset: 0x0000E9D7
		internal List<Choice> generatedChoices
		{
			get
			{
				return this._currentChoices;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000228 RID: 552 RVA: 0x000107DF File Offset: 0x0000E9DF
		// (set) Token: 0x06000229 RID: 553 RVA: 0x000107E7 File Offset: 0x0000E9E7
		internal List<string> currentErrors { get; private set; }

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600022A RID: 554 RVA: 0x000107F0 File Offset: 0x0000E9F0
		// (set) Token: 0x0600022B RID: 555 RVA: 0x000107F8 File Offset: 0x0000E9F8
		internal VariablesState variablesState { get; private set; }

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00010801 File Offset: 0x0000EA01
		// (set) Token: 0x0600022D RID: 557 RVA: 0x00010809 File Offset: 0x0000EA09
		internal CallStack callStack { get; set; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600022E RID: 558 RVA: 0x00010812 File Offset: 0x0000EA12
		// (set) Token: 0x0600022F RID: 559 RVA: 0x0001081A File Offset: 0x0000EA1A
		internal List<Object> evaluationStack { get; private set; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000230 RID: 560 RVA: 0x00010823 File Offset: 0x0000EA23
		// (set) Token: 0x06000231 RID: 561 RVA: 0x0001082B File Offset: 0x0000EA2B
		internal Object divertedTargetObject { get; set; }

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000232 RID: 562 RVA: 0x00010834 File Offset: 0x0000EA34
		// (set) Token: 0x06000233 RID: 563 RVA: 0x0001083C File Offset: 0x0000EA3C
		internal Dictionary<string, int> visitCounts { get; private set; }

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000234 RID: 564 RVA: 0x00010845 File Offset: 0x0000EA45
		// (set) Token: 0x06000235 RID: 565 RVA: 0x0001084D File Offset: 0x0000EA4D
		internal Dictionary<string, int> turnIndices { get; private set; }

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000236 RID: 566 RVA: 0x00010856 File Offset: 0x0000EA56
		// (set) Token: 0x06000237 RID: 567 RVA: 0x0001085E File Offset: 0x0000EA5E
		internal int currentTurnIndex { get; private set; }

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00010867 File Offset: 0x0000EA67
		// (set) Token: 0x06000239 RID: 569 RVA: 0x0001086F File Offset: 0x0000EA6F
		internal int storySeed { get; set; }

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00010878 File Offset: 0x0000EA78
		// (set) Token: 0x0600023B RID: 571 RVA: 0x00010880 File Offset: 0x0000EA80
		internal int previousRandom { get; set; }

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600023C RID: 572 RVA: 0x00010889 File Offset: 0x0000EA89
		// (set) Token: 0x0600023D RID: 573 RVA: 0x00010891 File Offset: 0x0000EA91
		internal bool didSafeExit { get; set; }

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600023E RID: 574 RVA: 0x0001089A File Offset: 0x0000EA9A
		// (set) Token: 0x0600023F RID: 575 RVA: 0x000108A2 File Offset: 0x0000EAA2
		internal Story story { get; set; }

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000240 RID: 576 RVA: 0x000108AB File Offset: 0x0000EAAB
		// (set) Token: 0x06000241 RID: 577 RVA: 0x000108C8 File Offset: 0x0000EAC8
		internal Path currentPath
		{
			get
			{
				if (this.currentContentObject == null)
				{
					return null;
				}
				return this.currentContentObject.path;
			}
			set
			{
				if (value != null)
				{
					this.currentContentObject = this.story.ContentAtPath(value);
					return;
				}
				this.currentContentObject = null;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000242 RID: 578 RVA: 0x000108E7 File Offset: 0x0000EAE7
		// (set) Token: 0x06000243 RID: 579 RVA: 0x000108F9 File Offset: 0x0000EAF9
		internal Object currentContentObject
		{
			get
			{
				return this.callStack.currentElement.currentObject;
			}
			set
			{
				this.callStack.currentElement.currentObject = value;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000244 RID: 580 RVA: 0x0001090C File Offset: 0x0000EB0C
		internal Container currentContainer
		{
			get
			{
				return this.callStack.currentElement.currentContainer;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000245 RID: 581 RVA: 0x0001091E File Offset: 0x0000EB1E
		// (set) Token: 0x06000246 RID: 582 RVA: 0x00010930 File Offset: 0x0000EB30
		internal Object previousContentObject
		{
			get
			{
				return this.callStack.currentThread.previousContentObject;
			}
			set
			{
				this.callStack.currentThread.previousContentObject = value;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000247 RID: 583 RVA: 0x00010943 File Offset: 0x0000EB43
		internal bool canContinue
		{
			get
			{
				return this.currentContentObject != null && !this.hasError;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000248 RID: 584 RVA: 0x0001095E File Offset: 0x0000EB5E
		internal bool hasError
		{
			get
			{
				return this.currentErrors != null && this.currentErrors.Count > 0;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000249 RID: 585 RVA: 0x00010978 File Offset: 0x0000EB78
		internal string currentText
		{
			get
			{
				if (this._outputStreamTextDirty)
				{
					StringBuilder stringBuilder = new StringBuilder();
					foreach (Object @object in this._outputStream)
					{
						StringValue stringValue = @object as StringValue;
						if (stringValue != null)
						{
							stringBuilder.Append(stringValue.value);
						}
					}
					this._currentText = stringBuilder.ToString();
					this._outputStreamTextDirty = false;
				}
				return this._currentText;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600024A RID: 586 RVA: 0x00010A08 File Offset: 0x0000EC08
		internal List<string> currentTags
		{
			get
			{
				if (this._outputStreamTagsDirty)
				{
					this._currentTags = new List<string>();
					foreach (Object @object in this._outputStream)
					{
						Tag tag = @object as Tag;
						if (tag != null)
						{
							this._currentTags.Add(tag.text);
						}
					}
					this._outputStreamTagsDirty = false;
				}
				return this._currentTags;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00010A94 File Offset: 0x0000EC94
		// (set) Token: 0x0600024C RID: 588 RVA: 0x00010AA6 File Offset: 0x0000ECA6
		internal bool inExpressionEvaluation
		{
			get
			{
				return this.callStack.currentElement.inExpressionEvaluation;
			}
			set
			{
				this.callStack.currentElement.inExpressionEvaluation = value;
			}
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00010ABC File Offset: 0x0000ECBC
		internal StoryState(Story story)
		{
			this.story = story;
			this._outputStream = new List<Object>();
			this.OutputStreamDirty();
			this.evaluationStack = new List<Object>();
			this.callStack = new CallStack(story.rootContentContainer);
			this.variablesState = new VariablesState(this.callStack, story.listDefinitions);
			this.visitCounts = new Dictionary<string, int>();
			this.turnIndices = new Dictionary<string, int>();
			this.currentTurnIndex = -1;
			int millisecond = DateTime.Now.Millisecond;
			this.storySeed = new Random(millisecond).Next() % 100;
			this.previousRandom = 0;
			this._currentChoices = new List<Choice>();
			this.GoToStart();
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00010B7F File Offset: 0x0000ED7F
		internal void GoToStart()
		{
			this.callStack.currentElement.currentContainer = this.story.mainContentContainer;
			this.callStack.currentElement.currentContentIndex = 0;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00010BB0 File Offset: 0x0000EDB0
		internal StoryState Copy()
		{
			StoryState storyState = new StoryState(this.story);
			storyState.outputStream.AddRange(this._outputStream);
			this.OutputStreamDirty();
			storyState._currentChoices.AddRange(this._currentChoices);
			if (this.hasError)
			{
				storyState.currentErrors = new List<string>();
				storyState.currentErrors.AddRange(this.currentErrors);
			}
			storyState.callStack = new CallStack(this.callStack);
			if (this._originalCallstack != null)
			{
				storyState._originalCallstack = new CallStack(this._originalCallstack);
			}
			storyState.variablesState = new VariablesState(storyState.callStack, this.story.listDefinitions);
			storyState.variablesState.CopyFrom(this.variablesState);
			storyState.evaluationStack.AddRange(this.evaluationStack);
			storyState._originalEvaluationStackHeight = this._originalEvaluationStackHeight;
			if (this.divertedTargetObject != null)
			{
				storyState.divertedTargetObject = this.divertedTargetObject;
			}
			storyState.previousContentObject = this.previousContentObject;
			storyState.visitCounts = new Dictionary<string, int>(this.visitCounts);
			storyState.turnIndices = new Dictionary<string, int>(this.turnIndices);
			storyState.currentTurnIndex = this.currentTurnIndex;
			storyState.storySeed = this.storySeed;
			storyState.previousRandom = this.previousRandom;
			storyState.didSafeExit = this.didSafeExit;
			return storyState;
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000250 RID: 592 RVA: 0x00010D04 File Offset: 0x0000EF04
		// (set) Token: 0x06000251 RID: 593 RVA: 0x00010EF0 File Offset: 0x0000F0F0
		public Dictionary<string, object> jsonToken
		{
			get
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				Dictionary<string, object> dictionary2 = null;
				foreach (Choice choice in this._currentChoices)
				{
					choice.originalChoicePath = choice.choicePoint.path.componentsString;
					choice.originalThreadIndex = choice.threadAtGeneration.threadIndex;
					if (this.callStack.ThreadWithIndex(choice.originalThreadIndex) == null)
					{
						if (dictionary2 == null)
						{
							dictionary2 = new Dictionary<string, object>();
						}
						dictionary2[choice.originalThreadIndex.ToString()] = choice.threadAtGeneration.jsonToken;
					}
				}
				if (dictionary2 != null)
				{
					dictionary["choiceThreads"] = dictionary2;
				}
				dictionary["callstackThreads"] = this.callStack.GetJsonToken();
				dictionary["variablesState"] = this.variablesState.jsonToken;
				dictionary["evalStack"] = Json.ListToJArray<Object>(this.evaluationStack);
				dictionary["outputStream"] = Json.ListToJArray<Object>(this._outputStream);
				dictionary["currentChoices"] = Json.ListToJArray<Choice>(this._currentChoices);
				if (this.divertedTargetObject != null)
				{
					dictionary["currentDivertTarget"] = this.divertedTargetObject.path.componentsString;
				}
				dictionary["visitCounts"] = Json.IntDictionaryToJObject(this.visitCounts);
				dictionary["turnIndices"] = Json.IntDictionaryToJObject(this.turnIndices);
				dictionary["turnIdx"] = this.currentTurnIndex;
				dictionary["storySeed"] = this.storySeed;
				dictionary["previousRandom"] = this.previousRandom;
				dictionary["inkSaveVersion"] = 7;
				dictionary["inkFormatVersion"] = 17;
				return dictionary;
			}
			set
			{
				object obj = null;
				if (!value.TryGetValue("inkSaveVersion", out obj))
				{
					throw new StoryException("ink save format incorrect, can't load.");
				}
				if ((int)obj < 6)
				{
					throw new StoryException(string.Concat(new string[]
					{
						"Ink save format isn't compatible with the current version (saw '",
						(obj != null) ? obj.ToString() : null,
						"', but minimum is ",
						6.ToString(),
						"), so can't load."
					}));
				}
				this.callStack.SetJsonToken((Dictionary<string, object>)value["callstackThreads"], this.story);
				this.variablesState.jsonToken = (Dictionary<string, object>)value["variablesState"];
				this.evaluationStack = Json.JArrayToRuntimeObjList((List<object>)value["evalStack"], false);
				this._outputStream = Json.JArrayToRuntimeObjList((List<object>)value["outputStream"], false);
				this.OutputStreamDirty();
				this._currentChoices = Json.JArrayToRuntimeObjList<Choice>((List<object>)value["currentChoices"], false);
				object obj2;
				if (value.TryGetValue("currentDivertTarget", out obj2))
				{
					Path path = new Path(obj2.ToString());
					this.divertedTargetObject = this.story.ContentAtPath(path);
				}
				this.visitCounts = Json.JObjectToIntDictionary((Dictionary<string, object>)value["visitCounts"]);
				this.turnIndices = Json.JObjectToIntDictionary((Dictionary<string, object>)value["turnIndices"]);
				this.currentTurnIndex = (int)value["turnIdx"];
				this.storySeed = (int)value["storySeed"];
				this.previousRandom = (int)value["previousRandom"];
				object obj3 = null;
				value.TryGetValue("choiceThreads", out obj3);
				Dictionary<string, object> dictionary = (Dictionary<string, object>)obj3;
				foreach (Choice choice in this._currentChoices)
				{
					choice.choicePoint = (ChoicePoint)this.story.ContentAtPath(new Path(choice.originalChoicePath));
					CallStack.Thread thread = this.callStack.ThreadWithIndex(choice.originalThreadIndex);
					if (thread != null)
					{
						choice.threadAtGeneration = thread;
					}
					else
					{
						Dictionary<string, object> jThreadObj = (Dictionary<string, object>)dictionary[choice.originalThreadIndex.ToString()];
						choice.threadAtGeneration = new CallStack.Thread(jThreadObj, this.story);
					}
				}
			}
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00011178 File Offset: 0x0000F378
		internal void ResetErrors()
		{
			this.currentErrors = null;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00011181 File Offset: 0x0000F381
		internal void ResetOutput()
		{
			this._outputStream.Clear();
			this.OutputStreamDirty();
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00011194 File Offset: 0x0000F394
		internal void PushToOutputStream(Object obj)
		{
			StringValue stringValue = obj as StringValue;
			if (stringValue)
			{
				List<StringValue> list = this.TrySplittingHeadTailWhitespace(stringValue);
				if (list != null)
				{
					foreach (StringValue obj2 in list)
					{
						this.PushToOutputStreamIndividual(obj2);
					}
					return;
				}
			}
			this.PushToOutputStreamIndividual(obj);
			this.OutputStreamDirty();
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0001120C File Offset: 0x0000F40C
		private List<StringValue> TrySplittingHeadTailWhitespace(StringValue single)
		{
			string value = single.value;
			int num = -1;
			int num2 = -1;
			for (int i = 0; i < value.Length; i++)
			{
				char c = value[i];
				if (c == '\n')
				{
					if (num == -1)
					{
						num = i;
					}
					num2 = i;
				}
				else if (c != ' ' && c != '\t')
				{
					break;
				}
			}
			int num3 = -1;
			int num4 = -1;
			for (int j = 0; j < value.Length; j++)
			{
				char c2 = value[j];
				if (c2 == '\n')
				{
					if (num3 == -1)
					{
						num3 = j;
					}
					num4 = j;
				}
				else if (c2 != ' ' && c2 != '\t')
				{
					break;
				}
			}
			if (num == -1 && num3 == -1)
			{
				return null;
			}
			List<StringValue> list = new List<StringValue>();
			int num5 = 0;
			int num6 = value.Length;
			if (num != -1)
			{
				if (num > 0)
				{
					StringValue item = new StringValue(value.Substring(0, num));
					list.Add(item);
				}
				list.Add(new StringValue("\n"));
				num5 = num2 + 1;
			}
			if (num3 != -1)
			{
				num6 = num4;
			}
			if (num6 > num5)
			{
				string str = value.Substring(num5, num6 - num5);
				list.Add(new StringValue(str));
			}
			if (num3 != -1 && num4 > num2)
			{
				list.Add(new StringValue("\n"));
				if (num3 < value.Length - 1)
				{
					int length = value.Length - num3 - 1;
					StringValue item2 = new StringValue(value.Substring(num3 + 1, length));
					list.Add(item2);
				}
			}
			return list;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00011370 File Offset: 0x0000F570
		private void PushToOutputStreamIndividual(Object obj)
		{
			Glue glue = obj as Glue;
			StringValue stringValue = obj as StringValue;
			bool flag = true;
			if (glue)
			{
				Glue rightGlueToStopAt = null;
				if (glue.isLeft)
				{
					rightGlueToStopAt = this.MatchRightGlueForLeftGlue(glue);
				}
				if (glue.isLeft || glue.isBi)
				{
					this.TrimNewlinesFromOutputStream(rightGlueToStopAt);
				}
				flag = (glue.isBi || glue.isRight);
			}
			else if (stringValue)
			{
				if (this.currentGlueIndex != -1)
				{
					if (stringValue.isNewline)
					{
						this.TrimFromExistingGlue();
						flag = false;
					}
					else if (stringValue.isNonWhitespace)
					{
						this.RemoveExistingGlue();
					}
				}
				else if (stringValue.isNewline && (this.outputStreamEndsInNewline || !this.outputStreamContainsContent))
				{
					flag = false;
				}
			}
			if (flag)
			{
				this._outputStream.Add(obj);
			}
			this.OutputStreamDirty();
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00011434 File Offset: 0x0000F634
		private void TrimNewlinesFromOutputStream(Glue rightGlueToStopAt)
		{
			int num = -1;
			int num2 = -1;
			bool flag = false;
			for (int i = this._outputStream.Count - 1; i >= 0; i--)
			{
				Object @object = this._outputStream[i];
				ControlCommand obj = @object as ControlCommand;
				StringValue stringValue = @object as StringValue;
				Glue a = @object as Glue;
				if (obj || (stringValue && stringValue.isNonWhitespace))
				{
					flag = true;
					if (rightGlueToStopAt == null)
					{
						break;
					}
				}
				else
				{
					if (rightGlueToStopAt && a == rightGlueToStopAt)
					{
						num2 = i;
						break;
					}
					if (stringValue && stringValue.isNewline && !flag)
					{
						num = i;
					}
				}
			}
			if (num >= 0)
			{
				int i = num;
				while (i < this._outputStream.Count)
				{
					if (this._outputStream[i] as StringValue)
					{
						this._outputStream.RemoveAt(i);
					}
					else
					{
						i++;
					}
				}
			}
			if (rightGlueToStopAt && num2 > -1)
			{
				int i = num2;
				while (i < this._outputStream.Count)
				{
					if (this._outputStream[i] is Glue && ((Glue)this._outputStream[i]).isRight)
					{
						this._outputStream.RemoveAt(i);
					}
					else
					{
						i++;
					}
				}
			}
			this.OutputStreamDirty();
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00011578 File Offset: 0x0000F778
		private void TrimFromExistingGlue()
		{
			int i = this.currentGlueIndex;
			while (i < this._outputStream.Count)
			{
				StringValue stringValue = this._outputStream[i] as StringValue;
				if (stringValue && !stringValue.isNonWhitespace)
				{
					this._outputStream.RemoveAt(i);
				}
				else
				{
					i++;
				}
			}
			this.OutputStreamDirty();
		}

		// Token: 0x06000259 RID: 601 RVA: 0x000115D8 File Offset: 0x0000F7D8
		private void RemoveExistingGlue()
		{
			for (int i = this._outputStream.Count - 1; i >= 0; i--)
			{
				Object @object = this._outputStream[i];
				if (@object is Glue)
				{
					this._outputStream.RemoveAt(i);
				}
				else if (@object is ControlCommand)
				{
					break;
				}
			}
			this.OutputStreamDirty();
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600025A RID: 602 RVA: 0x00011630 File Offset: 0x0000F830
		private int currentGlueIndex
		{
			get
			{
				for (int i = this._outputStream.Count - 1; i >= 0; i--)
				{
					Object @object = this._outputStream[i];
					if (@object as Glue)
					{
						return i;
					}
					if (@object is ControlCommand)
					{
						break;
					}
				}
				return -1;
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0001167C File Offset: 0x0000F87C
		private Glue MatchRightGlueForLeftGlue(Glue leftGlue)
		{
			if (!leftGlue.isLeft)
			{
				return null;
			}
			for (int i = this._outputStream.Count - 1; i >= 0; i--)
			{
				Object @object = this._outputStream[i];
				Glue glue = @object as Glue;
				if (glue && glue.isRight && glue.parent == leftGlue.parent)
				{
					return glue;
				}
				if (@object is ControlCommand)
				{
					break;
				}
			}
			return null;
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600025C RID: 604 RVA: 0x000116F0 File Offset: 0x0000F8F0
		internal bool outputStreamEndsInNewline
		{
			get
			{
				if (this._outputStream.Count > 0)
				{
					int num = this._outputStream.Count - 1;
					while (num >= 0 && !(this._outputStream[num] is ControlCommand))
					{
						StringValue stringValue = this._outputStream[num] as StringValue;
						if (stringValue)
						{
							if (stringValue.isNewline)
							{
								return true;
							}
							if (stringValue.isNonWhitespace)
							{
								break;
							}
						}
						num--;
					}
				}
				return false;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600025D RID: 605 RVA: 0x00011764 File Offset: 0x0000F964
		internal bool outputStreamContainsContent
		{
			get
			{
				using (List<Object>.Enumerator enumerator = this._outputStream.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current is StringValue)
						{
							return true;
						}
					}
				}
				return false;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600025E RID: 606 RVA: 0x000117C0 File Offset: 0x0000F9C0
		internal bool inStringEvaluation
		{
			get
			{
				for (int i = this._outputStream.Count - 1; i >= 0; i--)
				{
					ControlCommand controlCommand = this._outputStream[i] as ControlCommand;
					if (controlCommand && controlCommand.commandType == ControlCommand.CommandType.BeginString)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0001180C File Offset: 0x0000FA0C
		internal void PushEvaluationStack(Object obj)
		{
			ListValue listValue = obj as ListValue;
			if (listValue)
			{
				InkList value = listValue.value;
				if (value.originNames != null)
				{
					if (value.origins == null)
					{
						value.origins = new List<ListDefinition>();
					}
					value.origins.Clear();
					foreach (string name in value.originNames)
					{
						ListDefinition item = null;
						this.story.listDefinitions.TryListGetDefinition(name, out item);
						if (!value.origins.Contains(item))
						{
							value.origins.Add(item);
						}
					}
				}
			}
			this.evaluationStack.Add(obj);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x000118DC File Offset: 0x0000FADC
		internal Object PopEvaluationStack()
		{
			Object result = this.evaluationStack[this.evaluationStack.Count - 1];
			this.evaluationStack.RemoveAt(this.evaluationStack.Count - 1);
			return result;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0001190E File Offset: 0x0000FB0E
		internal Object PeekEvaluationStack()
		{
			return this.evaluationStack[this.evaluationStack.Count - 1];
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00011928 File Offset: 0x0000FB28
		internal List<Object> PopEvaluationStack(int numberOfObjects)
		{
			if (numberOfObjects > this.evaluationStack.Count)
			{
				throw new Exception("trying to pop too many objects");
			}
			List<Object> range = this.evaluationStack.GetRange(this.evaluationStack.Count - numberOfObjects, numberOfObjects);
			this.evaluationStack.RemoveRange(this.evaluationStack.Count - numberOfObjects, numberOfObjects);
			return range;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00011980 File Offset: 0x0000FB80
		public void ForceEnd()
		{
			while (this.callStack.canPopThread)
			{
				this.callStack.PopThread();
			}
			while (this.callStack.canPop)
			{
				this.callStack.Pop(null);
			}
			this._currentChoices.Clear();
			this.currentContentObject = null;
			this.previousContentObject = null;
			this.didSafeExit = true;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x000119EC File Offset: 0x0000FBEC
		internal void SetChosenPath(Path path)
		{
			this._currentChoices.Clear();
			this.currentPath = path;
			int currentTurnIndex = this.currentTurnIndex;
			this.currentTurnIndex = currentTurnIndex + 1;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00011A1C File Offset: 0x0000FC1C
		internal void StartExternalFunctionEvaluation(Container funcContainer, params object[] arguments)
		{
			this._originalCallstack = this.callStack;
			this._originalEvaluationStackHeight = this.evaluationStack.Count;
			this.callStack = new CallStack(funcContainer);
			this.callStack.currentElement.type = PushPopType.Function;
			this.variablesState.callStack = this.callStack;
			this._isExternalFunctionEvaluation = true;
			this.PassArgumentsToEvaluationStack(arguments);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00011A84 File Offset: 0x0000FC84
		internal void PassArgumentsToEvaluationStack(params object[] arguments)
		{
			if (arguments != null)
			{
				for (int i = 0; i < arguments.Length; i++)
				{
					if (!(arguments[i] is int) && !(arguments[i] is float) && !(arguments[i] is string))
					{
						throw new ArgumentException("ink arguments when calling EvaluateFunction / ChoosePathStringWithParameters must be int, float or string");
					}
					this.PushEvaluationStack(Value.Create(arguments[i]));
				}
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00011ADC File Offset: 0x0000FCDC
		internal bool TryExitExternalFunctionEvaluation()
		{
			if (this._isExternalFunctionEvaluation && this.callStack.elements.Count == 1 && this.callStack.currentElement.type == PushPopType.Function)
			{
				this.currentContentObject = null;
				this.didSafeExit = true;
				return true;
			}
			return false;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00011B28 File Offset: 0x0000FD28
		internal object CompleteExternalFunctionEvaluation()
		{
			Object @object = null;
			while (this.evaluationStack.Count > this._originalEvaluationStackHeight)
			{
				Object object2 = this.PopEvaluationStack();
				if (@object == null)
				{
					@object = object2;
				}
			}
			this.callStack = this._originalCallstack;
			this._originalCallstack = null;
			this._originalEvaluationStackHeight = 0;
			this.variablesState.callStack = this.callStack;
			if (!@object)
			{
				return null;
			}
			if (@object is Void)
			{
				return null;
			}
			Value value = @object as Value;
			if (value.valueType == ValueType.DivertTarget)
			{
				return value.valueObject.ToString();
			}
			return value.valueObject;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00011BBF File Offset: 0x0000FDBF
		internal void AddError(string message)
		{
			if (this.currentErrors == null)
			{
				this.currentErrors = new List<string>();
			}
			this.currentErrors.Add(message);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00011BE0 File Offset: 0x0000FDE0
		private void OutputStreamDirty()
		{
			this._outputStreamTextDirty = true;
			this._outputStreamTagsDirty = true;
		}

		// Token: 0x04000186 RID: 390
		public const int kInkSaveStateVersion = 7;

		// Token: 0x04000187 RID: 391
		private const int kMinCompatibleLoadVersion = 6;

		// Token: 0x04000194 RID: 404
		private string _currentText;

		// Token: 0x04000195 RID: 405
		private List<string> _currentTags;

		// Token: 0x04000196 RID: 406
		private List<Object> _outputStream;

		// Token: 0x04000197 RID: 407
		private bool _outputStreamTextDirty = true;

		// Token: 0x04000198 RID: 408
		private bool _outputStreamTagsDirty = true;

		// Token: 0x04000199 RID: 409
		private List<Choice> _currentChoices;

		// Token: 0x0400019A RID: 410
		private bool _isExternalFunctionEvaluation;

		// Token: 0x0400019B RID: 411
		private CallStack _originalCallstack;

		// Token: 0x0400019C RID: 412
		private int _originalEvaluationStackHeight;
	}
}
