using System;
using System.Collections.Generic;

namespace Ink.Runtime
{
	// Token: 0x02000041 RID: 65
	internal class ListValue : Value<InkList>
	{
		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x000120DF File Offset: 0x000102DF
		public override ValueType valueType
		{
			get
			{
				return ValueType.List;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x000120E4 File Offset: 0x000102E4
		public override bool isTruthy
		{
			get
			{
				foreach (KeyValuePair<InkListItem, int> keyValuePair in base.value)
				{
					if (keyValuePair.Value != 0)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00012140 File Offset: 0x00010340
		public override Value Cast(ValueType newType)
		{
			if (newType == ValueType.Int)
			{
				KeyValuePair<InkListItem, int> maxItem = base.value.maxItem;
				if (maxItem.Key.isNull)
				{
					return new IntValue(0);
				}
				return new IntValue(maxItem.Value);
			}
			else if (newType == ValueType.Float)
			{
				KeyValuePair<InkListItem, int> maxItem2 = base.value.maxItem;
				if (maxItem2.Key.isNull)
				{
					return new FloatValue(0f);
				}
				return new FloatValue((float)maxItem2.Value);
			}
			else if (newType == ValueType.String)
			{
				KeyValuePair<InkListItem, int> maxItem3 = base.value.maxItem;
				if (maxItem3.Key.isNull)
				{
					return new StringValue("");
				}
				return new StringValue(maxItem3.Key.ToString());
			}
			else
			{
				if (newType == this.valueType)
				{
					return this;
				}
				throw new Exception("Unexpected type cast of Value to new ValueType");
			}
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00012217 File Offset: 0x00010417
		public ListValue() : base(null)
		{
			base.value = new InkList();
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0001222B File Offset: 0x0001042B
		public ListValue(InkList list) : base(null)
		{
			base.value = new InkList(list);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00012240 File Offset: 0x00010440
		public ListValue(InkListItem singleItem, int singleValue) : base(null)
		{
			base.value = new InkList
			{
				{
					singleItem,
					singleValue
				}
			};
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0001225C File Offset: 0x0001045C
		public static void RetainListOriginsForAssignment(Object oldValue, Object newValue)
		{
			ListValue listValue = oldValue as ListValue;
			ListValue listValue2 = newValue as ListValue;
			if (listValue && listValue2 && listValue2.value.Count == 0)
			{
				listValue2.value.SetInitialOriginNames(listValue.value.originNames);
			}
		}
	}
}
