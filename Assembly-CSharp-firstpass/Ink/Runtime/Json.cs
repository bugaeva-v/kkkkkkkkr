using System;
using System.Collections.Generic;
using System.Linq;

namespace Ink.Runtime
{
	// Token: 0x0200002B RID: 43
	internal static class Json
	{
		// Token: 0x06000157 RID: 343 RVA: 0x0000A80C File Offset: 0x00008A0C
		public static List<object> ListToJArray<T>(List<T> serialisables) where T : Object
		{
			List<object> list = new List<object>();
			foreach (T t in serialisables)
			{
				list.Add(Json.RuntimeObjectToJToken(t));
			}
			return list;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000A86C File Offset: 0x00008A6C
		public static List<T> JArrayToRuntimeObjList<T>(List<object> jArray, bool skipLast = false) where T : Object
		{
			int num = jArray.Count;
			if (skipLast)
			{
				num--;
			}
			List<T> list = new List<T>(jArray.Count);
			for (int i = 0; i < num; i++)
			{
				T item = Json.JTokenToRuntimeObject(jArray[i]) as T;
				list.Add(item);
			}
			return list;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000A8BE File Offset: 0x00008ABE
		public static List<Object> JArrayToRuntimeObjList(List<object> jArray, bool skipLast = false)
		{
			return Json.JArrayToRuntimeObjList<Object>(jArray, skipLast);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000A8C8 File Offset: 0x00008AC8
		public static Dictionary<string, object> DictionaryRuntimeObjsToJObject(Dictionary<string, Object> dictionary)
		{
			Dictionary<string, object> dictionary2 = new Dictionary<string, object>();
			foreach (KeyValuePair<string, Object> keyValuePair in dictionary)
			{
				Object value = keyValuePair.Value;
				if (value != null)
				{
					dictionary2[keyValuePair.Key] = Json.RuntimeObjectToJToken(value);
				}
			}
			return dictionary2;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000A93C File Offset: 0x00008B3C
		public static Dictionary<string, Object> JObjectToDictionaryRuntimeObjs(Dictionary<string, object> jObject)
		{
			Dictionary<string, Object> dictionary = new Dictionary<string, Object>(jObject.Count);
			foreach (KeyValuePair<string, object> keyValuePair in jObject)
			{
				dictionary[keyValuePair.Key] = Json.JTokenToRuntimeObject(keyValuePair.Value);
			}
			return dictionary;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000A9AC File Offset: 0x00008BAC
		public static Dictionary<string, int> JObjectToIntDictionary(Dictionary<string, object> jObject)
		{
			Dictionary<string, int> dictionary = new Dictionary<string, int>(jObject.Count);
			foreach (KeyValuePair<string, object> keyValuePair in jObject)
			{
				dictionary[keyValuePair.Key] = (int)keyValuePair.Value;
			}
			return dictionary;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000AA1C File Offset: 0x00008C1C
		public static Dictionary<string, object> IntDictionaryToJObject(Dictionary<string, int> dict)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			foreach (KeyValuePair<string, int> keyValuePair in dict)
			{
				dictionary[keyValuePair.Key] = keyValuePair.Value;
			}
			return dictionary;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000AA84 File Offset: 0x00008C84
		public static Object JTokenToRuntimeObject(object token)
		{
			if (token is int || token is float)
			{
				return Value.Create(token);
			}
			if (token is string)
			{
				string text = (string)token;
				char c = text[0];
				if (c == '^')
				{
					return new StringValue(text.Substring(1));
				}
				if (c == '\n' && text.Length == 1)
				{
					return new StringValue("\n");
				}
				if (text == "<>")
				{
					return new Glue(GlueType.Bidirectional);
				}
				if (text == "G<")
				{
					return new Glue(GlueType.Left);
				}
				if (text == "G>")
				{
					return new Glue(GlueType.Right);
				}
				for (int i = 0; i < Json._controlCommandNames.Length; i++)
				{
					string b = Json._controlCommandNames[i];
					if (text == b)
					{
						return new ControlCommand((ControlCommand.CommandType)i);
					}
				}
				if (text == "L^")
				{
					text = "^";
				}
				if (NativeFunctionCall.CallExistsWithName(text))
				{
					return NativeFunctionCall.CallWithName(text);
				}
				if (text == "->->")
				{
					return ControlCommand.PopTunnel();
				}
				if (text == "~ret")
				{
					return ControlCommand.PopFunction();
				}
				if (text == "void")
				{
					return new Void();
				}
			}
			if (token is Dictionary<string, object>)
			{
				Dictionary<string, object> dictionary = (Dictionary<string, object>)token;
				object obj;
				if (dictionary.TryGetValue("^->", out obj))
				{
					return new DivertTargetValue(new Path((string)obj));
				}
				if (dictionary.TryGetValue("^var", out obj))
				{
					VariablePointerValue variablePointerValue = new VariablePointerValue((string)obj, -1);
					if (dictionary.TryGetValue("ci", out obj))
					{
						variablePointerValue.contextIndex = (int)obj;
					}
					return variablePointerValue;
				}
				bool flag = false;
				bool pushesToStack = false;
				PushPopType stackPushType = PushPopType.Function;
				bool flag2 = false;
				if (dictionary.TryGetValue("->", out obj))
				{
					flag = true;
				}
				else if (dictionary.TryGetValue("f()", out obj))
				{
					flag = true;
					pushesToStack = true;
					stackPushType = PushPopType.Function;
				}
				else if (dictionary.TryGetValue("->t->", out obj))
				{
					flag = true;
					pushesToStack = true;
					stackPushType = PushPopType.Tunnel;
				}
				else if (dictionary.TryGetValue("x()", out obj))
				{
					flag = true;
					flag2 = true;
					pushesToStack = false;
					stackPushType = PushPopType.Function;
				}
				if (flag)
				{
					Divert divert = new Divert();
					divert.pushesToStack = pushesToStack;
					divert.stackPushType = stackPushType;
					divert.isExternal = flag2;
					string text2 = obj.ToString();
					if (dictionary.TryGetValue("var", out obj))
					{
						divert.variableDivertName = text2;
					}
					else
					{
						divert.targetPathString = text2;
					}
					divert.isConditional = dictionary.TryGetValue("c", out obj);
					if (flag2 && dictionary.TryGetValue("exArgs", out obj))
					{
						divert.externalArgs = (int)obj;
					}
					return divert;
				}
				if (dictionary.TryGetValue("*", out obj))
				{
					ChoicePoint choicePoint = new ChoicePoint();
					choicePoint.pathStringOnChoice = obj.ToString();
					if (dictionary.TryGetValue("flg", out obj))
					{
						choicePoint.flags = (int)obj;
					}
					return choicePoint;
				}
				if (dictionary.TryGetValue("VAR?", out obj))
				{
					return new VariableReference(obj.ToString());
				}
				if (dictionary.TryGetValue("CNT?", out obj))
				{
					return new VariableReference
					{
						pathStringForCount = obj.ToString()
					};
				}
				bool flag3 = false;
				bool isGlobal = false;
				if (dictionary.TryGetValue("VAR=", out obj))
				{
					flag3 = true;
					isGlobal = true;
				}
				else if (dictionary.TryGetValue("temp=", out obj))
				{
					flag3 = true;
					isGlobal = false;
				}
				if (flag3)
				{
					string variableName = obj.ToString();
					bool isNewDeclaration = !dictionary.TryGetValue("re", out obj);
					return new VariableAssignment(variableName, isNewDeclaration)
					{
						isGlobal = isGlobal
					};
				}
				if (dictionary.TryGetValue("#", out obj))
				{
					return new Tag((string)obj);
				}
				if (dictionary.TryGetValue("list", out obj))
				{
					Dictionary<string, object> dictionary2 = (Dictionary<string, object>)obj;
					InkList inkList = new InkList();
					if (dictionary.TryGetValue("origins", out obj))
					{
						List<object> source = (List<object>)obj;
						inkList.SetInitialOriginNames(source.Cast<string>().ToList<string>());
					}
					foreach (KeyValuePair<string, object> keyValuePair in dictionary2)
					{
						InkListItem key = new InkListItem(keyValuePair.Key);
						int value = (int)keyValuePair.Value;
						inkList.Add(key, value);
					}
					return new ListValue(inkList);
				}
				if (dictionary["originalChoicePath"] != null)
				{
					return Json.JObjectToChoice(dictionary);
				}
			}
			if (token is List<object>)
			{
				return Json.JArrayToContainer((List<object>)token);
			}
			if (token == null)
			{
				return null;
			}
			throw new Exception("Failed to convert token to runtime object: " + ((token != null) ? token.ToString() : null));
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000AF2C File Offset: 0x0000912C
		public static object RuntimeObjectToJToken(Object obj)
		{
			Container container = obj as Container;
			if (container)
			{
				return Json.ContainerToJArray(container);
			}
			Divert divert = obj as Divert;
			if (divert)
			{
				string key = "->";
				if (divert.isExternal)
				{
					key = "x()";
				}
				else if (divert.pushesToStack)
				{
					if (divert.stackPushType == PushPopType.Function)
					{
						key = "f()";
					}
					else if (divert.stackPushType == PushPopType.Tunnel)
					{
						key = "->t->";
					}
				}
				string value;
				if (divert.hasVariableTarget)
				{
					value = divert.variableDivertName;
				}
				else
				{
					value = divert.targetPathString;
				}
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary[key] = value;
				if (divert.hasVariableTarget)
				{
					dictionary["var"] = true;
				}
				if (divert.isConditional)
				{
					dictionary["c"] = true;
				}
				if (divert.externalArgs > 0)
				{
					dictionary["exArgs"] = divert.externalArgs;
				}
				return dictionary;
			}
			ChoicePoint choicePoint = obj as ChoicePoint;
			if (choicePoint)
			{
				Dictionary<string, object> dictionary2 = new Dictionary<string, object>();
				dictionary2["*"] = choicePoint.pathStringOnChoice;
				dictionary2["flg"] = choicePoint.flags;
				return dictionary2;
			}
			IntValue intValue = obj as IntValue;
			if (intValue)
			{
				return intValue.value;
			}
			FloatValue floatValue = obj as FloatValue;
			if (floatValue)
			{
				return floatValue.value;
			}
			StringValue stringValue = obj as StringValue;
			if (stringValue)
			{
				if (stringValue.isNewline)
				{
					return "\n";
				}
				return "^" + stringValue.value;
			}
			else
			{
				ListValue listValue = obj as ListValue;
				if (listValue)
				{
					return Json.InkListToJObject(listValue);
				}
				DivertTargetValue divertTargetValue = obj as DivertTargetValue;
				if (divertTargetValue)
				{
					Dictionary<string, object> dictionary3 = new Dictionary<string, object>();
					dictionary3["^->"] = divertTargetValue.value.componentsString;
					return dictionary3;
				}
				VariablePointerValue variablePointerValue = obj as VariablePointerValue;
				if (variablePointerValue)
				{
					Dictionary<string, object> dictionary4 = new Dictionary<string, object>();
					dictionary4["^var"] = variablePointerValue.value;
					dictionary4["ci"] = variablePointerValue.contextIndex;
					return dictionary4;
				}
				Glue glue = obj as Glue;
				if (glue)
				{
					if (glue.isBi)
					{
						return "<>";
					}
					if (glue.isLeft)
					{
						return "G<";
					}
					return "G>";
				}
				else
				{
					ControlCommand controlCommand = obj as ControlCommand;
					if (controlCommand)
					{
						return Json._controlCommandNames[(int)controlCommand.commandType];
					}
					NativeFunctionCall nativeFunctionCall = obj as NativeFunctionCall;
					if (nativeFunctionCall)
					{
						string text = nativeFunctionCall.name;
						if (text == "^")
						{
							text = "L^";
						}
						return text;
					}
					VariableReference variableReference = obj as VariableReference;
					if (variableReference)
					{
						Dictionary<string, object> dictionary5 = new Dictionary<string, object>();
						string pathStringForCount = variableReference.pathStringForCount;
						if (pathStringForCount != null)
						{
							dictionary5["CNT?"] = pathStringForCount;
						}
						else
						{
							dictionary5["VAR?"] = variableReference.name;
						}
						return dictionary5;
					}
					VariableAssignment variableAssignment = obj as VariableAssignment;
					if (variableAssignment)
					{
						string key2 = variableAssignment.isGlobal ? "VAR=" : "temp=";
						Dictionary<string, object> dictionary6 = new Dictionary<string, object>();
						dictionary6[key2] = variableAssignment.variableName;
						if (!variableAssignment.isNewDeclaration)
						{
							dictionary6["re"] = true;
						}
						return dictionary6;
					}
					if (obj as Void)
					{
						return "void";
					}
					Tag tag = obj as Tag;
					if (tag)
					{
						Dictionary<string, object> dictionary7 = new Dictionary<string, object>();
						dictionary7["#"] = tag.text;
						return dictionary7;
					}
					Choice choice = obj as Choice;
					if (choice)
					{
						return Json.ChoiceToJObject(choice);
					}
					throw new Exception("Failed to convert runtime object to Json token: " + ((obj != null) ? obj.ToString() : null));
				}
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000B2F4 File Offset: 0x000094F4
		private static List<object> ContainerToJArray(Container container)
		{
			List<object> list = Json.ListToJArray<Object>(container.content);
			Dictionary<string, Object> namedOnlyContent = container.namedOnlyContent;
			int countFlags = container.countFlags;
			if ((namedOnlyContent != null && namedOnlyContent.Count > 0) || countFlags > 0 || container.name != null)
			{
				Dictionary<string, object> dictionary;
				if (namedOnlyContent != null)
				{
					dictionary = Json.DictionaryRuntimeObjsToJObject(namedOnlyContent);
					using (Dictionary<string, object>.Enumerator enumerator = dictionary.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							KeyValuePair<string, object> keyValuePair = enumerator.Current;
							List<object> list2 = keyValuePair.Value as List<object>;
							if (list2 != null)
							{
								Dictionary<string, object> dictionary2 = list2[list2.Count - 1] as Dictionary<string, object>;
								if (dictionary2 != null)
								{
									dictionary2.Remove("#n");
									if (dictionary2.Count == 0)
									{
										list2[list2.Count - 1] = null;
									}
								}
							}
						}
						goto IL_C8;
					}
				}
				dictionary = new Dictionary<string, object>();
				IL_C8:
				if (countFlags > 0)
				{
					dictionary["#f"] = countFlags;
				}
				if (container.name != null)
				{
					dictionary["#n"] = container.name;
				}
				list.Add(dictionary);
			}
			else
			{
				list.Add(null);
			}
			return list;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000B418 File Offset: 0x00009618
		private static Container JArrayToContainer(List<object> jArray)
		{
			Container container = new Container();
			container.content = Json.JArrayToRuntimeObjList(jArray, true);
			Dictionary<string, object> dictionary = jArray[jArray.Count - 1] as Dictionary<string, object>;
			if (dictionary != null)
			{
				Dictionary<string, Object> dictionary2 = new Dictionary<string, Object>(dictionary.Count);
				foreach (KeyValuePair<string, object> keyValuePair in dictionary)
				{
					if (keyValuePair.Key == "#f")
					{
						container.countFlags = (int)keyValuePair.Value;
					}
					else if (keyValuePair.Key == "#n")
					{
						container.name = keyValuePair.Value.ToString();
					}
					else
					{
						Object @object = Json.JTokenToRuntimeObject(keyValuePair.Value);
						Container container2 = @object as Container;
						if (container2)
						{
							container2.name = keyValuePair.Key;
						}
						dictionary2[keyValuePair.Key] = @object;
					}
				}
				container.namedOnlyContent = dictionary2;
			}
			return container;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000B534 File Offset: 0x00009734
		private static Choice JObjectToChoice(Dictionary<string, object> jObj)
		{
			return new Choice
			{
				text = jObj["text"].ToString(),
				index = (int)jObj["index"],
				originalChoicePath = jObj["originalChoicePath"].ToString(),
				originalThreadIndex = (int)jObj["originalThreadIndex"]
			};
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000B5A0 File Offset: 0x000097A0
		private static Dictionary<string, object> ChoiceToJObject(Choice choice)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary["text"] = choice.text;
			dictionary["index"] = choice.index;
			dictionary["originalChoicePath"] = choice.originalChoicePath;
			dictionary["originalThreadIndex"] = choice.originalThreadIndex;
			return dictionary;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000B600 File Offset: 0x00009800
		private static Dictionary<string, object> InkListToJObject(ListValue listVal)
		{
			InkList value = listVal.value;
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			Dictionary<string, object> dictionary2 = new Dictionary<string, object>();
			foreach (KeyValuePair<InkListItem, int> keyValuePair in value)
			{
				InkListItem key = keyValuePair.Key;
				int value2 = keyValuePair.Value;
				dictionary2[key.ToString()] = value2;
			}
			dictionary["list"] = dictionary2;
			if (value.Count == 0 && value.originNames != null && value.originNames.Count > 0)
			{
				dictionary["origins"] = value.originNames.Cast<object>().ToList<object>();
			}
			return dictionary;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000B6D0 File Offset: 0x000098D0
		public static Dictionary<string, object> ListDefinitionsToJToken(ListDefinitionsOrigin origin)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			foreach (ListDefinition listDefinition in origin.lists)
			{
				Dictionary<string, object> dictionary2 = new Dictionary<string, object>();
				foreach (KeyValuePair<InkListItem, int> keyValuePair in listDefinition.items)
				{
					InkListItem key = keyValuePair.Key;
					int value = keyValuePair.Value;
					dictionary2[key.itemName] = value;
				}
				dictionary[listDefinition.name] = dictionary2;
			}
			return dictionary;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0000B79C File Offset: 0x0000999C
		public static ListDefinitionsOrigin JTokenToListDefinitions(object obj)
		{
			Dictionary<string, object> dictionary = (Dictionary<string, object>)obj;
			List<ListDefinition> list = new List<ListDefinition>();
			foreach (KeyValuePair<string, object> keyValuePair in dictionary)
			{
				string key = keyValuePair.Key;
				Dictionary<string, object> dictionary2 = (Dictionary<string, object>)keyValuePair.Value;
				Dictionary<string, int> dictionary3 = new Dictionary<string, int>();
				foreach (KeyValuePair<string, object> keyValuePair2 in dictionary2)
				{
					dictionary3.Add(keyValuePair2.Key, (int)keyValuePair2.Value);
				}
				ListDefinition item = new ListDefinition(key, dictionary3);
				list.Add(item);
			}
			return new ListDefinitionsOrigin(list);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000B878 File Offset: 0x00009A78
		static Json()
		{
			Json._controlCommandNames[0] = "ev";
			Json._controlCommandNames[1] = "out";
			Json._controlCommandNames[2] = "/ev";
			Json._controlCommandNames[3] = "du";
			Json._controlCommandNames[4] = "pop";
			Json._controlCommandNames[5] = "~ret";
			Json._controlCommandNames[6] = "->->";
			Json._controlCommandNames[7] = "str";
			Json._controlCommandNames[8] = "/str";
			Json._controlCommandNames[9] = "nop";
			Json._controlCommandNames[10] = "choiceCnt";
			Json._controlCommandNames[11] = "turns";
			Json._controlCommandNames[12] = "readc";
			Json._controlCommandNames[13] = "rnd";
			Json._controlCommandNames[14] = "srnd";
			Json._controlCommandNames[15] = "visit";
			Json._controlCommandNames[16] = "seq";
			Json._controlCommandNames[17] = "thread";
			Json._controlCommandNames[18] = "done";
			Json._controlCommandNames[19] = "end";
			Json._controlCommandNames[20] = "listInt";
			Json._controlCommandNames[21] = "range";
			for (int i = 0; i < 22; i++)
			{
				if (Json._controlCommandNames[i] == null)
				{
					throw new Exception("Control command not accounted for in serialisation");
				}
			}
		}

		// Token: 0x04000133 RID: 307
		private static string[] _controlCommandNames = new string[22];
	}
}
