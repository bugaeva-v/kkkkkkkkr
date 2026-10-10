using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Firebase
{
	// Token: 0x02000018 RID: 24
	internal class VariantList : IDisposable, IEnumerable, IEnumerable<Variant>
	{
		// Token: 0x06000164 RID: 356 RVA: 0x000073A6 File Offset: 0x000055A6
		internal VariantList(IntPtr cPtr, bool cMemoryOwn)
		{
			this.swigCMemOwn = cMemoryOwn;
			this.swigCPtr = new HandleRef(this, cPtr);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x000073C4 File Offset: 0x000055C4
		internal static HandleRef getCPtr(VariantList obj)
		{
			return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000073EC File Offset: 0x000055EC
		internal static HandleRef swigRelease(VariantList obj)
		{
			bool flag = obj != null;
			HandleRef result;
			if (flag)
			{
				bool flag2 = !obj.swigCMemOwn;
				if (flag2)
				{
					throw new ApplicationException("Cannot release ownership as memory is not owned");
				}
				HandleRef handleRef = obj.swigCPtr;
				obj.swigCMemOwn = false;
				obj.Dispose();
				result = handleRef;
			}
			else
			{
				result = new HandleRef(null, IntPtr.Zero);
			}
			return result;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00007444 File Offset: 0x00005644
		~VariantList()
		{
			this.Dispose(false);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00007478 File Offset: 0x00005678
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000748C File Offset: 0x0000568C
		public virtual void Dispose(bool disposing)
		{
			object disposeLock = FirebaseApp.disposeLock;
			lock (disposeLock)
			{
				bool flag2 = this.swigCPtr.Handle != IntPtr.Zero;
				if (flag2)
				{
					bool flag3 = this.swigCMemOwn;
					if (flag3)
					{
						this.swigCMemOwn = false;
						AppUtilPINVOKE.delete_VariantList(this.swigCPtr);
					}
					this.swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				GC.SuppressFinalize(this);
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000751C File Offset: 0x0000571C
		public VariantList(IEnumerable c) : this()
		{
			bool flag = c == null;
			if (flag)
			{
				throw new ArgumentNullException("c");
			}
			foreach (object obj in c)
			{
				Variant x = (Variant)obj;
				this.Add(x);
			}
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00007590 File Offset: 0x00005790
		public VariantList(IEnumerable<Variant> c) : this()
		{
			bool flag = c == null;
			if (flag)
			{
				throw new ArgumentNullException("c");
			}
			foreach (Variant x in c)
			{
				this.Add(x);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600016C RID: 364 RVA: 0x000075F8 File Offset: 0x000057F8
		public bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600016D RID: 365 RVA: 0x0000760C File Offset: 0x0000580C
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000038 RID: 56
		public Variant this[int index]
		{
			get
			{
				return this.getitem(index);
			}
			set
			{
				this.setitem(index, value);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000170 RID: 368 RVA: 0x00007648 File Offset: 0x00005848
		// (set) Token: 0x06000171 RID: 369 RVA: 0x00007660 File Offset: 0x00005860
		public int Capacity
		{
			get
			{
				return (int)this.capacity();
			}
			set
			{
				bool flag = value < 0 || value < (int)this.size();
				if (flag)
				{
					throw new ArgumentOutOfRangeException("Capacity");
				}
				this.reserve((uint)value);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00007698 File Offset: 0x00005898
		public bool IsEmpty
		{
			get
			{
				return this.empty();
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000173 RID: 371 RVA: 0x000076B0 File Offset: 0x000058B0
		public int Count
		{
			get
			{
				return (int)this.size();
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000174 RID: 372 RVA: 0x000076C8 File Offset: 0x000058C8
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x000076DB File Offset: 0x000058DB
		public void CopyTo(Variant[] array)
		{
			this.CopyTo(0, array, 0, this.Count);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x000076EE File Offset: 0x000058EE
		public void CopyTo(Variant[] array, int arrayIndex)
		{
			this.CopyTo(0, array, arrayIndex, this.Count);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00007704 File Offset: 0x00005904
		public void CopyTo(int index, Variant[] array, int arrayIndex, int count)
		{
			bool flag = array == null;
			if (flag)
			{
				throw new ArgumentNullException("array");
			}
			bool flag2 = index < 0;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("index", "Value is less than zero");
			}
			bool flag3 = arrayIndex < 0;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
			}
			bool flag4 = count < 0;
			if (flag4)
			{
				throw new ArgumentOutOfRangeException("count", "Value is less than zero");
			}
			bool flag5 = array.Rank > 1;
			if (flag5)
			{
				throw new ArgumentException("Multi dimensional array.", "array");
			}
			bool flag6 = index + count > this.Count || arrayIndex + count > array.Length;
			if (flag6)
			{
				throw new ArgumentException("Number of elements to copy is too large.");
			}
			for (int i = 0; i < count; i++)
			{
				array.SetValue(this.getitemcopy(index + i), arrayIndex + i);
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x000077E4 File Offset: 0x000059E4
		public Variant[] ToArray()
		{
			Variant[] array = new Variant[this.Count];
			this.CopyTo(array);
			return array;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000780C File Offset: 0x00005A0C
		IEnumerator<Variant> IEnumerable<Variant>.GetEnumerator()
		{
			return new VariantList.VariantListEnumerator(this);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00007824 File Offset: 0x00005A24
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new VariantList.VariantListEnumerator(this);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0000783C File Offset: 0x00005A3C
		public VariantList.VariantListEnumerator GetEnumerator()
		{
			return new VariantList.VariantListEnumerator(this);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00007854 File Offset: 0x00005A54
		public VariantList() : this(AppUtilPINVOKE.new_VariantList__SWIG_0(), true)
		{
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00007880 File Offset: 0x00005A80
		public VariantList(VariantList other) : this(AppUtilPINVOKE.new_VariantList__SWIG_1(VariantList.getCPtr(other)), true)
		{
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000078B0 File Offset: 0x00005AB0
		public void Clear()
		{
			AppUtilPINVOKE.VariantList_Clear(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000078DC File Offset: 0x00005ADC
		public void Add(Variant x)
		{
			AppUtilPINVOKE.VariantList_Add(this.swigCPtr, Variant.getCPtr(x));
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0000790C File Offset: 0x00005B0C
		private uint size()
		{
			uint result = AppUtilPINVOKE.VariantList_size(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0000793C File Offset: 0x00005B3C
		private bool empty()
		{
			bool result = AppUtilPINVOKE.VariantList_empty(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000796C File Offset: 0x00005B6C
		private uint capacity()
		{
			uint result = AppUtilPINVOKE.VariantList_capacity(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000799C File Offset: 0x00005B9C
		private void reserve(uint n)
		{
			AppUtilPINVOKE.VariantList_reserve(this.swigCPtr, n);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000079C8 File Offset: 0x00005BC8
		public VariantList(int capacity) : this(AppUtilPINVOKE.new_VariantList__SWIG_2(capacity), true)
		{
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x06000185 RID: 389 RVA: 0x000079F4 File Offset: 0x00005BF4
		private Variant getitemcopy(int index)
		{
			Variant result = new Variant(AppUtilPINVOKE.VariantList_getitemcopy(this.swigCPtr, index), true);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00007A2C File Offset: 0x00005C2C
		private Variant getitem(int index)
		{
			Variant result = new Variant(AppUtilPINVOKE.VariantList_getitem(this.swigCPtr, index), false);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00007A64 File Offset: 0x00005C64
		private void setitem(int index, Variant val)
		{
			AppUtilPINVOKE.VariantList_setitem(this.swigCPtr, index, Variant.getCPtr(val));
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00007A94 File Offset: 0x00005C94
		public void AddRange(VariantList values)
		{
			AppUtilPINVOKE.VariantList_AddRange(this.swigCPtr, VariantList.getCPtr(values));
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00007AC4 File Offset: 0x00005CC4
		public VariantList GetRange(int index, int count)
		{
			IntPtr intPtr = AppUtilPINVOKE.VariantList_GetRange(this.swigCPtr, index, count);
			VariantList result = (intPtr == IntPtr.Zero) ? null : new VariantList(intPtr, true);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00007B0C File Offset: 0x00005D0C
		public void Insert(int index, Variant x)
		{
			AppUtilPINVOKE.VariantList_Insert(this.swigCPtr, index, Variant.getCPtr(x));
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00007B3C File Offset: 0x00005D3C
		public void InsertRange(int index, VariantList values)
		{
			AppUtilPINVOKE.VariantList_InsertRange(this.swigCPtr, index, VariantList.getCPtr(values));
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00007B6C File Offset: 0x00005D6C
		public void RemoveAt(int index)
		{
			AppUtilPINVOKE.VariantList_RemoveAt(this.swigCPtr, index);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00007B98 File Offset: 0x00005D98
		public void RemoveRange(int index, int count)
		{
			AppUtilPINVOKE.VariantList_RemoveRange(this.swigCPtr, index, count);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00007BC4 File Offset: 0x00005DC4
		public static VariantList Repeat(Variant value, int count)
		{
			IntPtr intPtr = AppUtilPINVOKE.VariantList_Repeat(Variant.getCPtr(value), count);
			VariantList result = (intPtr == IntPtr.Zero) ? null : new VariantList(intPtr, true);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00007C0C File Offset: 0x00005E0C
		public void Reverse()
		{
			AppUtilPINVOKE.VariantList_Reverse__SWIG_0(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00007C38 File Offset: 0x00005E38
		public void Reverse(int index, int count)
		{
			AppUtilPINVOKE.VariantList_Reverse__SWIG_1(this.swigCPtr, index, count);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00007C64 File Offset: 0x00005E64
		public void SetRange(int index, VariantList values)
		{
			AppUtilPINVOKE.VariantList_SetRange(this.swigCPtr, index, VariantList.getCPtr(values));
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x04000063 RID: 99
		private HandleRef swigCPtr;

		// Token: 0x04000064 RID: 100
		protected bool swigCMemOwn;

		// Token: 0x02000036 RID: 54
		public sealed class VariantListEnumerator : IEnumerator, IEnumerator<Variant>, IDisposable
		{
			// Token: 0x060002F0 RID: 752 RVA: 0x00009373 File Offset: 0x00007573
			public VariantListEnumerator(VariantList collection)
			{
				this.collectionRef = collection;
				this.currentIndex = -1;
				this.currentObject = null;
				this.currentSize = this.collectionRef.Count;
			}

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x060002F1 RID: 753 RVA: 0x000093A4 File Offset: 0x000075A4
			public Variant Current
			{
				get
				{
					bool flag = this.currentIndex == -1;
					if (flag)
					{
						throw new InvalidOperationException("Enumeration not started.");
					}
					bool flag2 = this.currentIndex > this.currentSize - 1;
					if (flag2)
					{
						throw new InvalidOperationException("Enumeration finished.");
					}
					bool flag3 = this.currentObject == null;
					if (flag3)
					{
						throw new InvalidOperationException("Collection modified.");
					}
					return (Variant)this.currentObject;
				}
			}

			// Token: 0x17000051 RID: 81
			// (get) Token: 0x060002F2 RID: 754 RVA: 0x00009410 File Offset: 0x00007610
			object IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x060002F3 RID: 755 RVA: 0x00009428 File Offset: 0x00007628
			public bool MoveNext()
			{
				int count = this.collectionRef.Count;
				bool flag = this.currentIndex + 1 < count && count == this.currentSize;
				bool flag2 = flag;
				if (flag2)
				{
					this.currentIndex++;
					this.currentObject = this.collectionRef[this.currentIndex];
				}
				else
				{
					this.currentObject = null;
				}
				return flag;
			}

			// Token: 0x060002F4 RID: 756 RVA: 0x00009498 File Offset: 0x00007698
			public void Reset()
			{
				this.currentIndex = -1;
				this.currentObject = null;
				bool flag = this.collectionRef.Count != this.currentSize;
				if (flag)
				{
					throw new InvalidOperationException("Collection modified.");
				}
			}

			// Token: 0x060002F5 RID: 757 RVA: 0x000094DA File Offset: 0x000076DA
			public void Dispose()
			{
				this.currentIndex = -1;
				this.currentObject = null;
			}

			// Token: 0x04000095 RID: 149
			private VariantList collectionRef;

			// Token: 0x04000096 RID: 150
			private int currentIndex;

			// Token: 0x04000097 RID: 151
			private object currentObject;

			// Token: 0x04000098 RID: 152
			private int currentSize;
		}
	}
}
