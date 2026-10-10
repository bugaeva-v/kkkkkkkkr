using System;
using System.Diagnostics;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020006B9 RID: 1721
	internal sealed class SerStack
	{
		// Token: 0x06003FA9 RID: 16297 RVA: 0x000DF3A6 File Offset: 0x000DD5A6
		internal SerStack()
		{
			this.stackId = "System";
		}

		// Token: 0x06003FAA RID: 16298 RVA: 0x000DF3CC File Offset: 0x000DD5CC
		internal SerStack(string stackId)
		{
			this.stackId = stackId;
		}

		// Token: 0x06003FAB RID: 16299 RVA: 0x000DF3F0 File Offset: 0x000DD5F0
		internal void Push(object obj)
		{
			if (this.top == this.objects.Length - 1)
			{
				this.IncreaseCapacity();
			}
			object[] array = this.objects;
			int num = this.top + 1;
			this.top = num;
			array[num] = obj;
		}

		// Token: 0x06003FAC RID: 16300 RVA: 0x000DF430 File Offset: 0x000DD630
		internal object Pop()
		{
			if (this.top < 0)
			{
				return null;
			}
			object result = this.objects[this.top];
			object[] array = this.objects;
			int num = this.top;
			this.top = num - 1;
			array[num] = null;
			return result;
		}

		// Token: 0x06003FAD RID: 16301 RVA: 0x000DF470 File Offset: 0x000DD670
		internal void IncreaseCapacity()
		{
			object[] destinationArray = new object[this.objects.Length * 2];
			Array.Copy(this.objects, 0, destinationArray, 0, this.objects.Length);
			this.objects = destinationArray;
		}

		// Token: 0x06003FAE RID: 16302 RVA: 0x000DF4AA File Offset: 0x000DD6AA
		internal object Peek()
		{
			if (this.top < 0)
			{
				return null;
			}
			return this.objects[this.top];
		}

		// Token: 0x06003FAF RID: 16303 RVA: 0x000DF4C4 File Offset: 0x000DD6C4
		internal object PeekPeek()
		{
			if (this.top < 1)
			{
				return null;
			}
			return this.objects[this.top - 1];
		}

		// Token: 0x06003FB0 RID: 16304 RVA: 0x000DF4E0 File Offset: 0x000DD6E0
		internal int Count()
		{
			return this.top + 1;
		}

		// Token: 0x06003FB1 RID: 16305 RVA: 0x000DF4EA File Offset: 0x000DD6EA
		internal bool IsEmpty()
		{
			return this.top <= 0;
		}

		// Token: 0x06003FB2 RID: 16306 RVA: 0x000DF4F8 File Offset: 0x000DD6F8
		[Conditional("SER_LOGGING")]
		internal void Dump()
		{
			for (int i = 0; i < this.Count(); i++)
			{
			}
		}

		// Token: 0x040029A9 RID: 10665
		internal object[] objects = new object[5];

		// Token: 0x040029AA RID: 10666
		internal string stackId;

		// Token: 0x040029AB RID: 10667
		internal int top = -1;

		// Token: 0x040029AC RID: 10668
		internal int next;
	}
}
