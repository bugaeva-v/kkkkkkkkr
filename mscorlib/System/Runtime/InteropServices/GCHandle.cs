using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Runtime.InteropServices
{
	/// <summary>Предоставляет способ доступа к управляемому объекту из неуправляемой памяти.</summary>
	// Token: 0x0200073F RID: 1855
	[ComVisible(true)]
	public struct GCHandle
	{
		// Token: 0x06004122 RID: 16674 RVA: 0x000E1DF3 File Offset: 0x000DFFF3
		private GCHandle(IntPtr h)
		{
			this.handle = h;
		}

		// Token: 0x06004123 RID: 16675 RVA: 0x000E1DFC File Offset: 0x000DFFFC
		private GCHandle(object obj)
		{
			this = new GCHandle(obj, GCHandleType.Normal);
		}

		// Token: 0x06004124 RID: 16676 RVA: 0x000E1E06 File Offset: 0x000E0006
		internal GCHandle(object value, GCHandleType type)
		{
			if (type < GCHandleType.Weak || type > GCHandleType.Pinned)
			{
				type = GCHandleType.Normal;
			}
			this.handle = GCHandle.GetTargetHandle(value, IntPtr.Zero, type);
		}

		/// <summary>Возвращает значение, показывающее, выделен ли дескриптор.</summary>
		/// <returns>Значение <see langword="true" />, если дескриптор выделен; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06004125 RID: 16677 RVA: 0x000E1E25 File Offset: 0x000E0025
		public bool IsAllocated
		{
			get
			{
				return this.handle != IntPtr.Zero;
			}
		}

		/// <summary>Возвращает или задает объект, предоставляемый дескриптором.</summary>
		/// <returns>Объект, представляемый дескриптором.</returns>
		/// <exception cref="T:System.InvalidOperationException">Дескриптор освобожден или не был инициализирован.</exception>
		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06004126 RID: 16678 RVA: 0x000E1E37 File Offset: 0x000E0037
		// (set) Token: 0x06004127 RID: 16679 RVA: 0x000E1E57 File Offset: 0x000E0057
		public object Target
		{
			get
			{
				if (!this.IsAllocated)
				{
					throw new InvalidOperationException("Handle is not allocated");
				}
				return GCHandle.GetTarget(this.handle);
			}
			set
			{
				this.handle = GCHandle.GetTargetHandle(value, this.handle, (GCHandleType)(-1));
			}
		}

		/// <summary>Возвращает адрес объекта в дескрипторе <see cref="F:System.Runtime.InteropServices.GCHandleType.Pinned" />.</summary>
		/// <returns>Адрес закрепленного объекта как указатель <see cref="T:System.IntPtr" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Типом дескриптора может быть любой тип, кроме <see cref="F:System.Runtime.InteropServices.GCHandleType.Pinned" />.</exception>
		// Token: 0x06004128 RID: 16680 RVA: 0x000E1E6C File Offset: 0x000E006C
		public IntPtr AddrOfPinnedObject()
		{
			IntPtr addrOfPinnedObject = GCHandle.GetAddrOfPinnedObject(this.handle);
			if (addrOfPinnedObject == (IntPtr)(-1))
			{
				throw new ArgumentException("Object contains non-primitive or non-blittable data.");
			}
			if (addrOfPinnedObject == (IntPtr)(-2))
			{
				throw new InvalidOperationException("Handle is not pinned.");
			}
			return addrOfPinnedObject;
		}

		/// <summary>Выделяет дескриптор <see cref="F:System.Runtime.InteropServices.GCHandleType.Normal" /> для указанного объекта.</summary>
		/// <param name="value">Объект, использующий дескриптор <see cref="T:System.Runtime.InteropServices.GCHandle" />.</param>
		/// <returns>Новый дескриптор <see cref="T:System.Runtime.InteropServices.GCHandle" />, защищающий объект от сборщика мусора. Этот дескриптор <see cref="T:System.Runtime.InteropServices.GCHandle" /> должен освобождаться с помощью метода <see cref="M:System.Runtime.InteropServices.GCHandle.Free" />, если в нем больше нет необходимости.</returns>
		/// <exception cref="T:System.ArgumentException">Экземпляр с членами, не являющимися примитивами (не требующими преобразования), не может быть закреплен.</exception>
		// Token: 0x06004129 RID: 16681 RVA: 0x000E1EAC File Offset: 0x000E00AC
		public static GCHandle Alloc(object value)
		{
			return new GCHandle(value);
		}

		/// <summary>Выделяет дескриптор указанного типа для указанного объекта.</summary>
		/// <param name="value">Объект, использующий дескриптор <see cref="T:System.Runtime.InteropServices.GCHandle" />.</param>
		/// <param name="type">Одно из значений <see cref="T:System.Runtime.InteropServices.GCHandleType" />, показывающее тип создаваемого дескриптора <see cref="T:System.Runtime.InteropServices.GCHandle" />.</param>
		/// <returns>Новый дескриптор <see cref="T:System.Runtime.InteropServices.GCHandle" /> указанного типа. Этот дескриптор <see cref="T:System.Runtime.InteropServices.GCHandle" /> должен освобождаться с помощью метода <see cref="M:System.Runtime.InteropServices.GCHandle.Free" />, если в нем больше нет необходимости.</returns>
		/// <exception cref="T:System.ArgumentException">Экземпляр с членами, не являющимися примитивами (не требующими преобразования), не может быть закреплен.</exception>
		// Token: 0x0600412A RID: 16682 RVA: 0x000E1EB4 File Offset: 0x000E00B4
		public static GCHandle Alloc(object value, GCHandleType type)
		{
			return new GCHandle(value, type);
		}

		/// <summary>Освобождает дескриптор <see cref="T:System.Runtime.InteropServices.GCHandle" />.</summary>
		/// <exception cref="T:System.InvalidOperationException">Дескриптор освобожден или не был инициализирован.</exception>
		// Token: 0x0600412B RID: 16683 RVA: 0x000E1EC0 File Offset: 0x000E00C0
		public void Free()
		{
			IntPtr intPtr = this.handle;
			if (intPtr != IntPtr.Zero && Interlocked.CompareExchange(ref this.handle, IntPtr.Zero, intPtr) == intPtr)
			{
				GCHandle.FreeHandle(intPtr);
				return;
			}
			throw new InvalidOperationException("Handle is not initialized.");
		}

		/// <summary>Дескриптор <see cref="T:System.Runtime.InteropServices.GCHandle" /> хранится в виде целого числа как внутреннего представления.</summary>
		/// <param name="value">Дескриптор <see cref="T:System.Runtime.InteropServices.GCHandle" />, для которого требуется целое число.</param>
		/// <returns>Целочисленное значение.</returns>
		// Token: 0x0600412C RID: 16684 RVA: 0x000E1F0B File Offset: 0x000E010B
		public static explicit operator IntPtr(GCHandle value)
		{
			return value.handle;
		}

		/// <summary>Дескриптор <see cref="T:System.Runtime.InteropServices.GCHandle" /> хранится в виде целого числа как внутреннего представления.</summary>
		/// <param name="value">Указатель <see cref="T:System.IntPtr" /> на дескриптор, для которого необходимо выполнить преобразование.</param>
		/// <returns>Сохраненный объект <see cref="T:System.Runtime.InteropServices.GCHandle" /> в виде целого числа как внутреннего представления.</returns>
		// Token: 0x0600412D RID: 16685 RVA: 0x000E1F13 File Offset: 0x000E0113
		public static explicit operator GCHandle(IntPtr value)
		{
			if (value == IntPtr.Zero)
			{
				throw new InvalidOperationException("GCHandle value cannot be zero");
			}
			if (!GCHandle.CheckCurrentDomain(value))
			{
				throw new ArgumentException("GCHandle value belongs to a different domain");
			}
			return new GCHandle(value);
		}

		// Token: 0x0600412E RID: 16686
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool CheckCurrentDomain(IntPtr handle);

		// Token: 0x0600412F RID: 16687
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern object GetTarget(IntPtr handle);

		// Token: 0x06004130 RID: 16688
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr GetTargetHandle(object obj, IntPtr handle, GCHandleType type);

		// Token: 0x06004131 RID: 16689
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void FreeHandle(IntPtr handle);

		// Token: 0x06004132 RID: 16690
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr GetAddrOfPinnedObject(IntPtr handle);

		/// <summary>Возвращает значение, показывающее, равны ли два объекта <see cref="T:System.Runtime.InteropServices.GCHandle" />.</summary>
		/// <param name="a">Объект <see cref="T:System.Runtime.InteropServices.GCHandle" />, сравниваемый с параметром <paramref name="b" />.</param>
		/// <param name="b">Объект <see cref="T:System.Runtime.InteropServices.GCHandle" />, сравниваемый с параметром <paramref name="a" />.</param>
		/// <returns>Значение <see langword="true" />, если параметры <paramref name="a" /> и <paramref name="b" /> равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004133 RID: 16691 RVA: 0x000E1F46 File Offset: 0x000E0146
		public static bool operator ==(GCHandle a, GCHandle b)
		{
			return a.handle == b.handle;
		}

		/// <summary>Возвращает значение, показывающее, являются ли два объекта <see cref="T:System.Runtime.InteropServices.GCHandle" /> неравными.</summary>
		/// <param name="a">Объект <see cref="T:System.Runtime.InteropServices.GCHandle" />, сравниваемый с параметром <paramref name="b" />.</param>
		/// <param name="b">Объект <see cref="T:System.Runtime.InteropServices.GCHandle" />, сравниваемый с параметром <paramref name="a" />.</param>
		/// <returns>Значение <see langword="true" />, если параметры <paramref name="a" /> и <paramref name="b" /> не равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004134 RID: 16692 RVA: 0x000E1F59 File Offset: 0x000E0159
		public static bool operator !=(GCHandle a, GCHandle b)
		{
			return !(a == b);
		}

		/// <summary>Определяет, равен ли заданный объект <see cref="T:System.Runtime.InteropServices.GCHandle" /> текущему объекту <see cref="T:System.Runtime.InteropServices.GCHandle" />.</summary>
		/// <param name="o">Объект <see cref="T:System.Runtime.InteropServices.GCHandle" />, сравниваемый с текущим объектом <see cref="T:System.Runtime.InteropServices.GCHandle" />.</param>
		/// <returns>Значение <see langword="true" />, если заданный объект <see cref="T:System.Runtime.InteropServices.GCHandle" /> равен текущему объекту <see cref="T:System.Runtime.InteropServices.GCHandle" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004135 RID: 16693 RVA: 0x000E1F65 File Offset: 0x000E0165
		public override bool Equals(object o)
		{
			return o is GCHandle && this == (GCHandle)o;
		}

		/// <summary>Возвращает идентификатор текущего объекта <see cref="T:System.Runtime.InteropServices.GCHandle" />.</summary>
		/// <returns>Идентификатор текущего объекта <see cref="T:System.Runtime.InteropServices.GCHandle" />.</returns>
		// Token: 0x06004136 RID: 16694 RVA: 0x000E1F82 File Offset: 0x000E0182
		public override int GetHashCode()
		{
			return this.handle.GetHashCode();
		}

		/// <summary>Возвращает новый объект <see cref="T:System.Runtime.InteropServices.GCHandle" />, созданный из дескриптора управляемого объекта.</summary>
		/// <param name="value">Дескриптор <see cref="T:System.IntPtr" /> управляемого объекта, для создания из него объекта <see cref="T:System.Runtime.InteropServices.GCHandle" />.</param>
		/// <returns>Новый объект <see cref="T:System.Runtime.InteropServices.GCHandle" />, соответствующий значению параметра.</returns>
		/// <exception cref="T:System.InvalidOperationException">параметр <paramref name="value" /> имеет значение <see cref="F:System.IntPtr.Zero" />;</exception>
		// Token: 0x06004137 RID: 16695 RVA: 0x000E1F8F File Offset: 0x000E018F
		public static GCHandle FromIntPtr(IntPtr value)
		{
			return (GCHandle)value;
		}

		/// <summary>Возвращает внутреннее целочисленное представление объекта <see cref="T:System.Runtime.InteropServices.GCHandle" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Runtime.InteropServices.GCHandle" /> для извлечения внутреннего целочисленного представления.</param>
		/// <returns>Объект <see cref="T:System.IntPtr" />, представляющий объект <see cref="T:System.Runtime.InteropServices.GCHandle" />.</returns>
		// Token: 0x06004138 RID: 16696 RVA: 0x000E1F97 File Offset: 0x000E0197
		public static IntPtr ToIntPtr(GCHandle value)
		{
			return (IntPtr)value;
		}

		// Token: 0x04002BC1 RID: 11201
		private IntPtr handle;
	}
}
