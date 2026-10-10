using System;
using System.Collections.Generic;

namespace Ink.Runtime
{
	// Token: 0x0200002E RID: 46
	internal class NativeFunctionCall : Object
	{
		// Token: 0x06000175 RID: 373 RVA: 0x0000BD7F File Offset: 0x00009F7F
		public static NativeFunctionCall CallWithName(string functionName)
		{
			return new NativeFunctionCall(functionName);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0000BD87 File Offset: 0x00009F87
		public static bool CallExistsWithName(string functionName)
		{
			NativeFunctionCall.GenerateNativeFunctionsIfNecessary();
			return NativeFunctionCall._nativeFunctions.ContainsKey(functionName);
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000177 RID: 375 RVA: 0x0000BD99 File Offset: 0x00009F99
		// (set) Token: 0x06000178 RID: 376 RVA: 0x0000BDA1 File Offset: 0x00009FA1
		public string name
		{
			get
			{
				return this._name;
			}
			protected set
			{
				this._name = value;
				if (!this._isPrototype)
				{
					this._prototype = NativeFunctionCall._nativeFunctions[this._name];
				}
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000179 RID: 377 RVA: 0x0000BDC8 File Offset: 0x00009FC8
		// (set) Token: 0x0600017A RID: 378 RVA: 0x0000BDE9 File Offset: 0x00009FE9
		public int numberOfParameters
		{
			get
			{
				if (this._prototype)
				{
					return this._prototype.numberOfParameters;
				}
				return this._numberOfParameters;
			}
			protected set
			{
				this._numberOfParameters = value;
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0000BDF4 File Offset: 0x00009FF4
		public Object Call(List<Object> parameters)
		{
			if (this._prototype)
			{
				return this._prototype.Call(parameters);
			}
			if (this.numberOfParameters != parameters.Count)
			{
				throw new Exception("Unexpected number of parameters");
			}
			bool flag = false;
			foreach (Object @object in parameters)
			{
				if (@object is Void)
				{
					throw new StoryException("Attempting to perform operation on a void value. Did you forget to 'return' a value from a function you called here?");
				}
				if (@object is ListValue)
				{
					flag = true;
				}
			}
			if (parameters.Count == 2 && flag)
			{
				return this.CallBinaryListOperation(parameters);
			}
			List<Value> list = this.CoerceValuesToSingleType(parameters);
			ValueType valueType = list[0].valueType;
			if (valueType == ValueType.Int)
			{
				return this.Call<int>(list);
			}
			if (valueType == ValueType.Float)
			{
				return this.Call<float>(list);
			}
			if (valueType == ValueType.String)
			{
				return this.Call<string>(list);
			}
			if (valueType == ValueType.DivertTarget)
			{
				return this.Call<Path>(list);
			}
			if (valueType == ValueType.List)
			{
				return this.Call<InkList>(list);
			}
			return null;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0000BEF4 File Offset: 0x0000A0F4
		private Value Call<T>(List<Value> parametersOfSingleType)
		{
			Value value = parametersOfSingleType[0];
			ValueType valueType = value.valueType;
			Value<T> value2 = (Value<T>)value;
			int count = parametersOfSingleType.Count;
			if (count != 2 && count != 1)
			{
				throw new Exception("Unexpected number of parameters to NativeFunctionCall: " + parametersOfSingleType.Count.ToString());
			}
			object obj = null;
			if (!this._operationFuncs.TryGetValue(valueType, out obj))
			{
				throw new StoryException("Cannot perform operation '" + this.name + "' on " + valueType.ToString());
			}
			if (count == 2)
			{
				Value<T> value3 = (Value<T>)parametersOfSingleType[1];
				return Value.Create(((NativeFunctionCall.BinaryOp<T>)obj)(value2.value, value3.value));
			}
			return Value.Create(((NativeFunctionCall.UnaryOp<T>)obj)(value2.value));
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000BFC8 File Offset: 0x0000A1C8
		private Value CallBinaryListOperation(List<Object> parameters)
		{
			if ((this.name == "+" || this.name == "-") && parameters[0] is ListValue && parameters[1] is IntValue)
			{
				return this.CallListIncrementOperation(parameters);
			}
			Value value = parameters[0] as Value;
			Value value2 = parameters[1] as Value;
			if ((this.name == "&&" || this.name == "||") && (value.valueType != ValueType.List || value2.valueType != ValueType.List))
			{
				return new IntValue((int)(this._operationFuncs[ValueType.Int] as NativeFunctionCall.BinaryOp<int>)(value.isTruthy ? 1 : 0, value2.isTruthy ? 1 : 0));
			}
			if (value.valueType == ValueType.List && value2.valueType == ValueType.List)
			{
				return this.Call<InkList>(new List<Value>
				{
					value,
					value2
				});
			}
			throw new StoryException(string.Concat(new string[]
			{
				"Can not call use '",
				this.name,
				"' operation on ",
				value.valueType.ToString(),
				" and ",
				value2.valueType.ToString()
			}));
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0000C134 File Offset: 0x0000A334
		private Value CallListIncrementOperation(List<Object> listIntParams)
		{
			ListValue listValue = (ListValue)listIntParams[0];
			IntValue intValue = (IntValue)listIntParams[1];
			InkList inkList = new InkList();
			foreach (KeyValuePair<InkListItem, int> keyValuePair in listValue.value)
			{
				InkListItem key = keyValuePair.Key;
				int value = keyValuePair.Value;
				int num = (int)((NativeFunctionCall.BinaryOp<int>)this._operationFuncs[ValueType.Int])(value, intValue.value);
				ListDefinition listDefinition = null;
				foreach (ListDefinition listDefinition2 in listValue.value.origins)
				{
					if (listDefinition2.name == key.originName)
					{
						listDefinition = listDefinition2;
						break;
					}
				}
				InkListItem key2;
				if (listDefinition != null && listDefinition.TryGetItemWithValue(num, out key2))
				{
					inkList.Add(key2, num);
				}
			}
			return new ListValue(inkList);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000C260 File Offset: 0x0000A460
		private List<Value> CoerceValuesToSingleType(List<Object> parametersIn)
		{
			ValueType valueType = ValueType.Int;
			ListValue listValue = null;
			foreach (Object @object in parametersIn)
			{
				Value value = (Value)@object;
				if (value.valueType > valueType)
				{
					valueType = value.valueType;
				}
				if (value.valueType == ValueType.List)
				{
					listValue = (value as ListValue);
				}
			}
			List<Value> list = new List<Value>();
			if (valueType == ValueType.List)
			{
				using (List<Object>.Enumerator enumerator = parametersIn.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Object object2 = enumerator.Current;
						Value value2 = (Value)object2;
						if (value2.valueType == ValueType.List)
						{
							list.Add(value2);
						}
						else
						{
							if (value2.valueType != ValueType.Int)
							{
								throw new StoryException("Cannot mix Lists and " + value2.valueType.ToString() + " values in this operation");
							}
							int num = (int)value2.valueObject;
							ListDefinition originOfMaxItem = listValue.value.originOfMaxItem;
							InkListItem singleItem;
							if (!originOfMaxItem.TryGetItemWithValue(num, out singleItem))
							{
								throw new StoryException("Could not find List item with the value " + num.ToString() + " in " + originOfMaxItem.name);
							}
							ListValue item = new ListValue(singleItem, num);
							list.Add(item);
						}
					}
					return list;
				}
			}
			foreach (Object object3 in parametersIn)
			{
				Value item2 = ((Value)object3).Cast(valueType);
				list.Add(item2);
			}
			return list;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0000C41C File Offset: 0x0000A61C
		public NativeFunctionCall(string name)
		{
			NativeFunctionCall.GenerateNativeFunctionsIfNecessary();
			this.name = name;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0000C430 File Offset: 0x0000A630
		public NativeFunctionCall()
		{
			NativeFunctionCall.GenerateNativeFunctionsIfNecessary();
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000C43D File Offset: 0x0000A63D
		private NativeFunctionCall(string name, int numberOfParamters)
		{
			this._isPrototype = true;
			this.name = name;
			this.numberOfParameters = numberOfParamters;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000C45C File Offset: 0x0000A65C
		private static void GenerateNativeFunctionsIfNecessary()
		{
			if (NativeFunctionCall._nativeFunctions == null)
			{
				NativeFunctionCall._nativeFunctions = new Dictionary<string, NativeFunctionCall>();
				NativeFunctionCall.AddIntBinaryOp("+", (int x, int y) => x + y);
				NativeFunctionCall.AddIntBinaryOp("-", (int x, int y) => x - y);
				NativeFunctionCall.AddIntBinaryOp("*", (int x, int y) => x * y);
				NativeFunctionCall.AddIntBinaryOp("/", (int x, int y) => x / y);
				NativeFunctionCall.AddIntBinaryOp("%", (int x, int y) => x % y);
				NativeFunctionCall.AddIntUnaryOp("_", (int x) => -x);
				NativeFunctionCall.AddIntBinaryOp("==", (int x, int y) => (x == y) ? 1 : 0);
				NativeFunctionCall.AddIntBinaryOp(">", (int x, int y) => (x > y) ? 1 : 0);
				NativeFunctionCall.AddIntBinaryOp("<", (int x, int y) => (x < y) ? 1 : 0);
				NativeFunctionCall.AddIntBinaryOp(">=", (int x, int y) => (x >= y) ? 1 : 0);
				NativeFunctionCall.AddIntBinaryOp("<=", (int x, int y) => (x <= y) ? 1 : 0);
				NativeFunctionCall.AddIntBinaryOp("!=", (int x, int y) => (x != y) ? 1 : 0);
				NativeFunctionCall.AddIntUnaryOp("!", (int x) => (x == 0) ? 1 : 0);
				NativeFunctionCall.AddIntBinaryOp("&&", (int x, int y) => (x != 0 && y != 0) ? 1 : 0);
				NativeFunctionCall.AddIntBinaryOp("||", (int x, int y) => (x != 0 || y != 0) ? 1 : 0);
				NativeFunctionCall.AddIntBinaryOp("MAX", (int x, int y) => Math.Max(x, y));
				NativeFunctionCall.AddIntBinaryOp("MIN", (int x, int y) => Math.Min(x, y));
				NativeFunctionCall.AddFloatBinaryOp("+", (float x, float y) => x + y);
				NativeFunctionCall.AddFloatBinaryOp("-", (float x, float y) => x - y);
				NativeFunctionCall.AddFloatBinaryOp("*", (float x, float y) => x * y);
				NativeFunctionCall.AddFloatBinaryOp("/", (float x, float y) => x / y);
				NativeFunctionCall.AddFloatBinaryOp("%", (float x, float y) => x % y);
				NativeFunctionCall.AddFloatUnaryOp("_", (float x) => -x);
				NativeFunctionCall.AddFloatBinaryOp("==", (float x, float y) => (x == y) ? 1 : 0);
				NativeFunctionCall.AddFloatBinaryOp(">", (float x, float y) => (x > y) ? 1 : 0);
				NativeFunctionCall.AddFloatBinaryOp("<", (float x, float y) => (x < y) ? 1 : 0);
				NativeFunctionCall.AddFloatBinaryOp(">=", (float x, float y) => (x >= y) ? 1 : 0);
				NativeFunctionCall.AddFloatBinaryOp("<=", (float x, float y) => (x <= y) ? 1 : 0);
				NativeFunctionCall.AddFloatBinaryOp("!=", (float x, float y) => (x != y) ? 1 : 0);
				NativeFunctionCall.AddFloatUnaryOp("!", (float x) => (x == 0f) ? 1 : 0);
				NativeFunctionCall.AddFloatBinaryOp("&&", (float x, float y) => (x != 0f && y != 0f) ? 1 : 0);
				NativeFunctionCall.AddFloatBinaryOp("||", (float x, float y) => (x != 0f || y != 0f) ? 1 : 0);
				NativeFunctionCall.AddFloatBinaryOp("MAX", (float x, float y) => Math.Max(x, y));
				NativeFunctionCall.AddFloatBinaryOp("MIN", (float x, float y) => Math.Min(x, y));
				NativeFunctionCall.AddStringBinaryOp("+", (string x, string y) => x + y);
				NativeFunctionCall.AddStringBinaryOp("==", (string x, string y) => x.Equals(y) ? 1 : 0);
				NativeFunctionCall.AddStringBinaryOp("!=", (string x, string y) => (!x.Equals(y)) ? 1 : 0);
				NativeFunctionCall.AddStringBinaryOp("?", (string x, string y) => x.Contains(y) ? 1 : 0);
				NativeFunctionCall.AddListBinaryOp("+", (InkList x, InkList y) => x.Union(y));
				NativeFunctionCall.AddListBinaryOp("-", (InkList x, InkList y) => x.Without(y));
				NativeFunctionCall.AddListBinaryOp("?", (InkList x, InkList y) => x.Contains(y) ? 1 : 0);
				NativeFunctionCall.AddListBinaryOp("!?", (InkList x, InkList y) => x.Contains(y) ? 0 : 1);
				NativeFunctionCall.AddListBinaryOp("^", (InkList x, InkList y) => x.Intersect(y));
				NativeFunctionCall.AddListBinaryOp("==", (InkList x, InkList y) => x.Equals(y) ? 1 : 0);
				NativeFunctionCall.AddListBinaryOp(">", (InkList x, InkList y) => x.GreaterThan(y) ? 1 : 0);
				NativeFunctionCall.AddListBinaryOp("<", (InkList x, InkList y) => x.LessThan(y) ? 1 : 0);
				NativeFunctionCall.AddListBinaryOp(">=", (InkList x, InkList y) => x.GreaterThanOrEquals(y) ? 1 : 0);
				NativeFunctionCall.AddListBinaryOp("<=", (InkList x, InkList y) => x.LessThanOrEquals(y) ? 1 : 0);
				NativeFunctionCall.AddListBinaryOp("!=", (InkList x, InkList y) => (!x.Equals(y)) ? 1 : 0);
				NativeFunctionCall.AddListBinaryOp("&&", (InkList x, InkList y) => (x.Count > 0 && y.Count > 0) ? 1 : 0);
				NativeFunctionCall.AddListBinaryOp("||", (InkList x, InkList y) => (x.Count > 0 || y.Count > 0) ? 1 : 0);
				NativeFunctionCall.AddListUnaryOp("!", (InkList x) => (x.Count == 0) ? 1 : 0);
				NativeFunctionCall.AddListUnaryOp("LIST_INVERT", (InkList x) => x.inverse);
				NativeFunctionCall.AddListUnaryOp("LIST_ALL", (InkList x) => x.all);
				NativeFunctionCall.AddListUnaryOp("LIST_MIN", (InkList x) => x.MinAsList());
				NativeFunctionCall.AddListUnaryOp("LIST_MAX", (InkList x) => x.MaxAsList());
				NativeFunctionCall.AddListUnaryOp("LIST_COUNT", (InkList x) => x.Count);
				NativeFunctionCall.AddListUnaryOp("LIST_VALUE", (InkList x) => x.maxItem.Value);
				NativeFunctionCall.BinaryOp<Path> op = (Path d1, Path d2) => d1.Equals(d2) ? 1 : 0;
				NativeFunctionCall.AddOpToNativeFunc("==", 2, ValueType.DivertTarget, op);
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000CDF4 File Offset: 0x0000AFF4
		private void AddOpFuncForType(ValueType valType, object op)
		{
			if (this._operationFuncs == null)
			{
				this._operationFuncs = new Dictionary<ValueType, object>();
			}
			this._operationFuncs[valType] = op;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0000CE18 File Offset: 0x0000B018
		private static void AddOpToNativeFunc(string name, int args, ValueType valType, object op)
		{
			NativeFunctionCall nativeFunctionCall = null;
			if (!NativeFunctionCall._nativeFunctions.TryGetValue(name, out nativeFunctionCall))
			{
				nativeFunctionCall = new NativeFunctionCall(name, args);
				NativeFunctionCall._nativeFunctions[name] = nativeFunctionCall;
			}
			nativeFunctionCall.AddOpFuncForType(valType, op);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0000CE52 File Offset: 0x0000B052
		private static void AddIntBinaryOp(string name, NativeFunctionCall.BinaryOp<int> op)
		{
			NativeFunctionCall.AddOpToNativeFunc(name, 2, ValueType.Int, op);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0000CE5D File Offset: 0x0000B05D
		private static void AddIntUnaryOp(string name, NativeFunctionCall.UnaryOp<int> op)
		{
			NativeFunctionCall.AddOpToNativeFunc(name, 1, ValueType.Int, op);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000CE68 File Offset: 0x0000B068
		private static void AddFloatBinaryOp(string name, NativeFunctionCall.BinaryOp<float> op)
		{
			NativeFunctionCall.AddOpToNativeFunc(name, 2, ValueType.Float, op);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000CE73 File Offset: 0x0000B073
		private static void AddStringBinaryOp(string name, NativeFunctionCall.BinaryOp<string> op)
		{
			NativeFunctionCall.AddOpToNativeFunc(name, 2, ValueType.String, op);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0000CE7E File Offset: 0x0000B07E
		private static void AddListBinaryOp(string name, NativeFunctionCall.BinaryOp<InkList> op)
		{
			NativeFunctionCall.AddOpToNativeFunc(name, 2, ValueType.List, op);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0000CE89 File Offset: 0x0000B089
		private static void AddListUnaryOp(string name, NativeFunctionCall.UnaryOp<InkList> op)
		{
			NativeFunctionCall.AddOpToNativeFunc(name, 1, ValueType.List, op);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000CE94 File Offset: 0x0000B094
		private static void AddFloatUnaryOp(string name, NativeFunctionCall.UnaryOp<float> op)
		{
			NativeFunctionCall.AddOpToNativeFunc(name, 1, ValueType.Float, op);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0000CE9F File Offset: 0x0000B09F
		public override string ToString()
		{
			return "Native '" + this.name + "'";
		}

		// Token: 0x04000139 RID: 313
		public const string Add = "+";

		// Token: 0x0400013A RID: 314
		public const string Subtract = "-";

		// Token: 0x0400013B RID: 315
		public const string Divide = "/";

		// Token: 0x0400013C RID: 316
		public const string Multiply = "*";

		// Token: 0x0400013D RID: 317
		public const string Mod = "%";

		// Token: 0x0400013E RID: 318
		public const string Negate = "_";

		// Token: 0x0400013F RID: 319
		public const string Equal = "==";

		// Token: 0x04000140 RID: 320
		public const string Greater = ">";

		// Token: 0x04000141 RID: 321
		public const string Less = "<";

		// Token: 0x04000142 RID: 322
		public const string GreaterThanOrEquals = ">=";

		// Token: 0x04000143 RID: 323
		public const string LessThanOrEquals = "<=";

		// Token: 0x04000144 RID: 324
		public const string NotEquals = "!=";

		// Token: 0x04000145 RID: 325
		public const string Not = "!";

		// Token: 0x04000146 RID: 326
		public const string And = "&&";

		// Token: 0x04000147 RID: 327
		public const string Or = "||";

		// Token: 0x04000148 RID: 328
		public const string Min = "MIN";

		// Token: 0x04000149 RID: 329
		public const string Max = "MAX";

		// Token: 0x0400014A RID: 330
		public const string Has = "?";

		// Token: 0x0400014B RID: 331
		public const string Hasnt = "!?";

		// Token: 0x0400014C RID: 332
		public const string Intersect = "^";

		// Token: 0x0400014D RID: 333
		public const string ListMin = "LIST_MIN";

		// Token: 0x0400014E RID: 334
		public const string ListMax = "LIST_MAX";

		// Token: 0x0400014F RID: 335
		public const string All = "LIST_ALL";

		// Token: 0x04000150 RID: 336
		public const string Count = "LIST_COUNT";

		// Token: 0x04000151 RID: 337
		public const string ValueOfList = "LIST_VALUE";

		// Token: 0x04000152 RID: 338
		public const string Invert = "LIST_INVERT";

		// Token: 0x04000153 RID: 339
		private string _name;

		// Token: 0x04000154 RID: 340
		private int _numberOfParameters;

		// Token: 0x04000155 RID: 341
		private NativeFunctionCall _prototype;

		// Token: 0x04000156 RID: 342
		private bool _isPrototype;

		// Token: 0x04000157 RID: 343
		private Dictionary<ValueType, object> _operationFuncs;

		// Token: 0x04000158 RID: 344
		private static Dictionary<string, NativeFunctionCall> _nativeFunctions;

		// Token: 0x0200006A RID: 106
		// (Invoke) Token: 0x06000303 RID: 771
		private delegate object BinaryOp<T>(T left, T right);

		// Token: 0x0200006B RID: 107
		// (Invoke) Token: 0x06000307 RID: 775
		private delegate object UnaryOp<T>(T val);
	}
}
