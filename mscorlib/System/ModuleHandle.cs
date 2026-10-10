using System;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Представляет для модуля дескриптор среды выполнения.</summary>
	// Token: 0x0200023C RID: 572
	[ComVisible(true)]
	public struct ModuleHandle
	{
		// Token: 0x06001A1E RID: 6686 RVA: 0x0005FF8C File Offset: 0x0005E18C
		internal ModuleHandle(IntPtr v)
		{
			this.value = v;
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06001A1F RID: 6687 RVA: 0x0005FF95 File Offset: 0x0005E195
		internal IntPtr Value
		{
			get
			{
				return this.value;
			}
		}

		/// <summary>Возвращает версию потока метаданных.</summary>
		/// <returns>32-разрядное целое число, представляющее версию потока метаданных. Два байта старшего разряда представляют основной номер версии, а два байта младшего разряда — дополнительный.</returns>
		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06001A20 RID: 6688 RVA: 0x0005FF9D File Offset: 0x0005E19D
		public int MDStreamVersion
		{
			get
			{
				if (this.value == IntPtr.Zero)
				{
					throw new ArgumentNullException(string.Empty, "Invalid handle");
				}
				return RuntimeModule.GetMDStreamVersion(this.value);
			}
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x0005FFCC File Offset: 0x0005E1CC
		internal void GetPEKind(out PortableExecutableKinds peKind, out ImageFileMachine machine)
		{
			if (this.value == IntPtr.Zero)
			{
				throw new ArgumentNullException(string.Empty, "Invalid handle");
			}
			RuntimeModule.GetPEKind(this.value, out peKind, out machine);
		}

		/// <summary>Возвращает дескриптор среды выполнения для поля, которое определяется заданным токеном метаданных.</summary>
		/// <param name="fieldToken">токен метаданных, определяющий поле в модуле.</param>
		/// <returns>Структура <see cref="T:System.RuntimeFieldHandle" /> для поля, определяемого параметром <paramref name="fieldToken" />.</returns>
		/// <exception cref="T:System.BadImageFormatException">Параметр <paramref name="metadataToken" /> не является допустимым маркером для поля в области текущего модуля.  
		///
		/// или - 
		/// Параметр <paramref name="metadataToken" /> не является маркером для поля в области текущего модуля.  
		///
		/// или - 
		/// Параметр <paramref name="metadataToken" /> определяет поле, родительская спецификация <see langword="TypeSpec" /> которого имеет подпись, содержащую переменную типа элемента <see langword="var" /> или <see langword="mvar" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод вызывается для дескриптора пустого поля.</exception>
		// Token: 0x06001A22 RID: 6690 RVA: 0x0005FFFD File Offset: 0x0005E1FD
		public RuntimeFieldHandle ResolveFieldHandle(int fieldToken)
		{
			return this.ResolveFieldHandle(fieldToken, null, null);
		}

		/// <summary>Возвращает дескриптор метода среды выполнения для метода или конструктора, который определяется заданным токеном метаданных.</summary>
		/// <param name="methodToken">маркер метаданных, определяющий метод или конструктор в модуле.</param>
		/// <returns>Структура <see cref="T:System.RuntimeMethodHandle" /> для метода или конструктора, определяемого токеном <paramref name="methodToken" />.</returns>
		/// <exception cref="T:System.BadImageFormatException">Параметр <paramref name="methodToken" /> не является допустимым маркером метаданных для метода в текущем модуле.  
		///
		/// или - 
		/// Параметр <paramref name="metadataToken" /> не является маркером для метода или конструктора в области текущего модуля.  
		///
		/// или - 
		/// Параметр <paramref name="metadataToken" /> является спецификацией <see langword="MethodSpec" />, в подписи которой, содержится переменная типа элемента <see langword="var" /> или <see langword="mvar" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод вызывается для дескриптора пустого метода.</exception>
		// Token: 0x06001A23 RID: 6691 RVA: 0x00060008 File Offset: 0x0005E208
		public RuntimeMethodHandle ResolveMethodHandle(int methodToken)
		{
			return this.ResolveMethodHandle(methodToken, null, null);
		}

		/// <summary>Возвращает дескриптор типа среды выполнения для типа, которое определяется заданным токеном метаданных.</summary>
		/// <param name="typeToken">Маркер метаданных, который определяет тип в модуле.</param>
		/// <returns>Структура <see cref="T:System.RuntimeTypeHandle" /> для типа, определяемого токеном <paramref name="typeToken" />.</returns>
		/// <exception cref="T:System.BadImageFormatException">Параметр <paramref name="typeToken" /> не является допустимым маркером метаданных для типа в текущем модуле.  
		///
		/// или - 
		/// Параметр <paramref name="metadataToken" /> не является маркером для типа в области текущего модуля.  
		///
		/// или - 
		/// Параметр <paramref name="metadataToken" /> является спецификацией <see langword="TypeSpec" />, в подписи которой, содержится переменная типа элемента <see langword="var" /> или <see langword="mvar" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод вызывается для дескриптора пустого типа.</exception>
		// Token: 0x06001A24 RID: 6692 RVA: 0x00060013 File Offset: 0x0005E213
		public RuntimeTypeHandle ResolveTypeHandle(int typeToken)
		{
			return this.ResolveTypeHandle(typeToken, null, null);
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x00060020 File Offset: 0x0005E220
		private IntPtr[] ptrs_from_handles(RuntimeTypeHandle[] handles)
		{
			if (handles == null)
			{
				return null;
			}
			IntPtr[] array = new IntPtr[handles.Length];
			for (int i = 0; i < handles.Length; i++)
			{
				array[i] = handles[i].Value;
			}
			return array;
		}

		/// <summary>Возвращает дескриптор типа среды выполнения для типа, определенного указанным токеном метаданных, задающим аргументы универсального типа и метод, в котором токен остается в пределах области.</summary>
		/// <param name="typeToken">Маркер метаданных, который определяет тип в модуле.</param>
		/// <param name="typeInstantiationContext">Массив структур <see cref="T:System.RuntimeTypeHandle" />, представляющих аргументы универсального типа для типа, в котором токен остается в пределах области, либо значение <see langword="null" />, если этот тип не является универсальным.</param>
		/// <param name="methodInstantiationContext">Массив объектов структур <see cref="T:System.RuntimeTypeHandle" />, представляющих аргументы универсального типа для метода, в котором токен остается в пределах в области, либо значение <see langword="null" />, если этот метод не является универсальным.</param>
		/// <returns>Структура <see cref="T:System.RuntimeTypeHandle" /> для типа, определяемого токеном <paramref name="typeToken" />.</returns>
		/// <exception cref="T:System.BadImageFormatException">Параметр <paramref name="typeToken" /> не является допустимым маркером метаданных для типа в текущем модуле.  
		///
		/// или - 
		/// Параметр <paramref name="metadataToken" /> не является маркером для типа в области текущего модуля.  
		///
		/// или - 
		/// Параметр <paramref name="metadataToken" /> является спецификацией <see langword="TypeSpec" />, в подписи которой, содержится переменная типа элемента <see langword="var" /> или <see langword="mvar" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод вызывается для дескриптора пустого типа.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="typeToken" /> не является допустимым токеном.</exception>
		// Token: 0x06001A26 RID: 6694 RVA: 0x0006005C File Offset: 0x0005E25C
		public RuntimeTypeHandle ResolveTypeHandle(int typeToken, RuntimeTypeHandle[] typeInstantiationContext, RuntimeTypeHandle[] methodInstantiationContext)
		{
			if (this.value == IntPtr.Zero)
			{
				throw new ArgumentNullException(string.Empty, "Invalid handle");
			}
			ResolveTokenError resolveTokenError;
			IntPtr intPtr = RuntimeModule.ResolveTypeToken(this.value, typeToken, this.ptrs_from_handles(typeInstantiationContext), this.ptrs_from_handles(methodInstantiationContext), out resolveTokenError);
			if (intPtr == IntPtr.Zero)
			{
				throw new TypeLoadException(string.Format("Could not load type '0x{0:x}' from assembly '0x{1:x}'", typeToken, this.value.ToInt64()));
			}
			return new RuntimeTypeHandle(intPtr);
		}

		/// <summary>Возвращает дескриптор метода среды выполнения для метода или конструктора, определенного указанным токеном метаданных, задающим аргументы универсального типа и метода, в котором токен остается в пределах области.</summary>
		/// <param name="methodToken">маркер метаданных, определяющий метод или конструктор в модуле.</param>
		/// <param name="typeInstantiationContext">Массив структур <see cref="T:System.RuntimeTypeHandle" />, представляющих аргументы универсального типа для типа, в котором токен остается в пределах области, либо значение <see langword="null" />, если этот тип не является универсальным.</param>
		/// <param name="methodInstantiationContext">Массив структур <see cref="T:System.RuntimeTypeHandle" />, представляющих аргументы универсального типа для метода, в котором токен остается в пределах в области, либо значение <see langword="null" />, если этот метод не является универсальным.</param>
		/// <returns>Структура <see cref="T:System.RuntimeMethodHandle" /> для метода или конструктора, определяемого токеном <paramref name="methodToken" />.</returns>
		/// <exception cref="T:System.BadImageFormatException">Параметр <paramref name="methodToken" /> не является допустимым маркером метаданных для метода в текущем модуле.  
		///
		/// или - 
		/// Параметр <paramref name="metadataToken" /> не является маркером для метода или конструктора в области текущего модуля.  
		///
		/// или - 
		/// Параметр <paramref name="metadataToken" /> является спецификацией <see langword="MethodSpec" />, в подписи которой, содержится переменная типа элемента <see langword="var" /> или <see langword="mvar" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод вызывается для дескриптора пустого метода.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="methodToken" /> не является допустимым токеном.</exception>
		// Token: 0x06001A27 RID: 6695 RVA: 0x000600E4 File Offset: 0x0005E2E4
		public RuntimeMethodHandle ResolveMethodHandle(int methodToken, RuntimeTypeHandle[] typeInstantiationContext, RuntimeTypeHandle[] methodInstantiationContext)
		{
			if (this.value == IntPtr.Zero)
			{
				throw new ArgumentNullException(string.Empty, "Invalid handle");
			}
			ResolveTokenError resolveTokenError;
			IntPtr intPtr = RuntimeModule.ResolveMethodToken(this.value, methodToken, this.ptrs_from_handles(typeInstantiationContext), this.ptrs_from_handles(methodInstantiationContext), out resolveTokenError);
			if (intPtr == IntPtr.Zero)
			{
				throw new Exception(string.Format("Could not load method '0x{0:x}' from assembly '0x{1:x}'", methodToken, this.value.ToInt64()));
			}
			return new RuntimeMethodHandle(intPtr);
		}

		/// <summary>Возвращает дескриптор поля среды выполнения для поля, определенного указанным токеном метаданных, задающим аргументы универсального типа и метод, в котором токен остается в пределах области.</summary>
		/// <param name="fieldToken">токен метаданных, определяющий поле в модуле.</param>
		/// <param name="typeInstantiationContext">Массив структур <see cref="T:System.RuntimeTypeHandle" />, представляющих аргументы универсального типа для типа, в котором токен остается в пределах области, либо значение <see langword="null" />, если этот тип не является универсальным.</param>
		/// <param name="methodInstantiationContext">Массив структур <see cref="T:System.RuntimeTypeHandle" />, представляющих аргументы универсального типа для метода, в котором токен остается в пределах в области, либо значение <see langword="null" />, если этот метод не является универсальным.</param>
		/// <returns>Структура <see cref="T:System.RuntimeFieldHandle" /> для поля, определяемого параметром <paramref name="fieldToken" />.</returns>
		/// <exception cref="T:System.BadImageFormatException">Параметр <paramref name="metadataToken" /> не является допустимым маркером для поля в области текущего модуля.  
		///
		/// или - 
		/// Параметр <paramref name="metadataToken" /> не является маркером для поля в области текущего модуля.  
		///
		/// или - 
		/// Параметр <paramref name="metadataToken" /> определяет поле, родительская спецификация <see langword="TypeSpec" /> которого имеет подпись, содержащую переменную типа элемента <see langword="var" /> или <see langword="mvar" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод вызывается для дескриптора пустого поля.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="fieldToken" /> не является допустимым токеном.</exception>
		// Token: 0x06001A28 RID: 6696 RVA: 0x0006016C File Offset: 0x0005E36C
		public RuntimeFieldHandle ResolveFieldHandle(int fieldToken, RuntimeTypeHandle[] typeInstantiationContext, RuntimeTypeHandle[] methodInstantiationContext)
		{
			if (this.value == IntPtr.Zero)
			{
				throw new ArgumentNullException(string.Empty, "Invalid handle");
			}
			ResolveTokenError resolveTokenError;
			IntPtr intPtr = RuntimeModule.ResolveFieldToken(this.value, fieldToken, this.ptrs_from_handles(typeInstantiationContext), this.ptrs_from_handles(methodInstantiationContext), out resolveTokenError);
			if (intPtr == IntPtr.Zero)
			{
				throw new Exception(string.Format("Could not load field '0x{0:x}' from assembly '0x{1:x}'", fieldToken, this.value.ToInt64()));
			}
			return new RuntimeFieldHandle(intPtr);
		}

		/// <summary>Возвращает дескриптор среды выполнения для поля, которое определяется заданным токеном метаданных.</summary>
		/// <param name="fieldToken">токен метаданных, определяющий поле в модуле.</param>
		/// <returns>Структура <see cref="T:System.RuntimeFieldHandle" /> для поля, определяемого параметром <paramref name="fieldToken" />.</returns>
		// Token: 0x06001A29 RID: 6697 RVA: 0x000601F1 File Offset: 0x0005E3F1
		public RuntimeFieldHandle GetRuntimeFieldHandleFromMetadataToken(int fieldToken)
		{
			return this.ResolveFieldHandle(fieldToken);
		}

		/// <summary>Возвращает дескриптор метода среды выполнения для метода или конструктора, который определяется заданным токеном метаданных.</summary>
		/// <param name="methodToken">маркер метаданных, определяющий метод или конструктор в модуле.</param>
		/// <returns>Структура <see cref="T:System.RuntimeMethodHandle" /> для метода или конструктора, определяемого токеном <paramref name="methodToken" />.</returns>
		// Token: 0x06001A2A RID: 6698 RVA: 0x000601FA File Offset: 0x0005E3FA
		public RuntimeMethodHandle GetRuntimeMethodHandleFromMetadataToken(int methodToken)
		{
			return this.ResolveMethodHandle(methodToken);
		}

		/// <summary>Возвращает дескриптор типа среды выполнения для типа, которое определяется заданным токеном метаданных.</summary>
		/// <param name="typeToken">Маркер метаданных, который определяет тип в модуле.</param>
		/// <returns>Структура <see cref="T:System.RuntimeTypeHandle" /> для типа, определяемого токеном <paramref name="typeToken" />.</returns>
		// Token: 0x06001A2B RID: 6699 RVA: 0x00060203 File Offset: 0x0005E403
		public RuntimeTypeHandle GetRuntimeTypeHandleFromMetadataToken(int typeToken)
		{
			return this.ResolveTypeHandle(typeToken);
		}

		/// <summary>Возвращает значение <see cref="T:System.Boolean" />, позволяющее определить, является ли указанный объект структурой <see cref="T:System.ModuleHandle" /> и эквивалентна ли эта структура текущей структуре <see cref="T:System.ModuleHandle" />.</summary>
		/// <param name="obj">Объект, который необходимо сравнить с текущей структурой <see cref="T:System.ModuleHandle" />.</param>
		/// <returns>Значение <see langword="true" />, если объект <paramref name="obj" /> является структурой <see cref="T:System.ModuleHandle" /> и эквивалентен текущей структуре <see cref="T:System.ModuleHandle" /> в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001A2C RID: 6700 RVA: 0x0006020C File Offset: 0x0005E40C
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public override bool Equals(object obj)
		{
			return obj != null && !(base.GetType() != obj.GetType()) && this.value == ((ModuleHandle)obj).Value;
		}

		/// <summary>Возвращает значение <see cref="T:System.Boolean" />, позволяющее определить, эквивалентна ли заданная структура <see cref="T:System.ModuleHandle" /> текущей структуре <see cref="T:System.ModuleHandle" />.</summary>
		/// <param name="handle">Структура <see cref="T:System.ModuleHandle" />, которую необходимо сравнить с текущей структурой <see cref="T:System.ModuleHandle" />.</param>
		/// <returns>Значение <see langword="true" />, если объект <paramref name="handle" /> эквивалентен текущей структуре <see cref="T:System.ModuleHandle" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001A2D RID: 6701 RVA: 0x00060254 File Offset: 0x0005E454
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public bool Equals(ModuleHandle handle)
		{
			return this.value == handle.Value;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>32-разрядное целое число со знаком, являющееся хэш-кодом для данного экземпляра.</returns>
		// Token: 0x06001A2E RID: 6702 RVA: 0x00060268 File Offset: 0x0005E468
		public override int GetHashCode()
		{
			return this.value.GetHashCode();
		}

		/// <summary>Проверяет равенство двух структур <see cref="T:System.ModuleHandle" /> .</summary>
		/// <param name="left">Структура <see cref="T:System.ModuleHandle" />, которая находится слева от оператора равенства.</param>
		/// <param name="right">Структура <see cref="T:System.ModuleHandle" />, которая находится справа от оператора равенства.</param>
		/// <returns>Значение <see langword="true" />, если две структуры <see cref="T:System.ModuleHandle" /> эквивалентны, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001A2F RID: 6703 RVA: 0x00060275 File Offset: 0x0005E475
		public static bool operator ==(ModuleHandle left, ModuleHandle right)
		{
			return object.Equals(left, right);
		}

		/// <summary>Проверяет, действительно ли две структуры <see cref="T:System.ModuleHandle" /> неэквивалентны.</summary>
		/// <param name="left">Структура <see cref="T:System.ModuleHandle" />, которая находится слева от оператора неравенства.</param>
		/// <param name="right">Структура <see cref="T:System.ModuleHandle" />, которая находится справа от оператора неравенства.</param>
		/// <returns>Значение <see langword="true" />, если две структуры <see cref="T:System.ModuleHandle" /> неэквивалентны, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001A30 RID: 6704 RVA: 0x00060288 File Offset: 0x0005E488
		public static bool operator !=(ModuleHandle left, ModuleHandle right)
		{
			return !object.Equals(left, right);
		}

		// Token: 0x0400171F RID: 5919
		private IntPtr value;

		/// <summary>Представляет дескриптор пустого модуля.</summary>
		// Token: 0x04001720 RID: 5920
		public static readonly ModuleHandle EmptyHandle = new ModuleHandle(IntPtr.Zero);
	}
}
