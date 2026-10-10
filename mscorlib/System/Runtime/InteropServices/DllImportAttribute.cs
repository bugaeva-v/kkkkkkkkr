using System;
using System.Reflection;
using System.Security;

namespace System.Runtime.InteropServices
{
	/// <summary>Указывает, что метод с атрибутом передается библиотекой динамической компонентов (DLL) как статическая точка входа.</summary>
	// Token: 0x02000706 RID: 1798
	[AttributeUsage(AttributeTargets.Method, Inherited = false)]
	[ComVisible(true)]
	public sealed class DllImportAttribute : Attribute
	{
		// Token: 0x0600409E RID: 16542 RVA: 0x000E1254 File Offset: 0x000DF454
		[SecurityCritical]
		internal static Attribute GetCustomAttribute(RuntimeMethodInfo method)
		{
			if ((method.Attributes & MethodAttributes.PinvokeImpl) == MethodAttributes.PrivateScope)
			{
				return null;
			}
			string dllName = null;
			int metadataToken = method.MetadataToken;
			PInvokeAttributes pinvokeAttributes = PInvokeAttributes.CharSetNotSpec;
			string entryPoint;
			method.GetPInvoke(out pinvokeAttributes, out entryPoint, out dllName);
			CharSet charSet = CharSet.None;
			switch (pinvokeAttributes & PInvokeAttributes.CharSetMask)
			{
			case PInvokeAttributes.CharSetNotSpec:
				charSet = CharSet.None;
				break;
			case PInvokeAttributes.CharSetAnsi:
				charSet = CharSet.Ansi;
				break;
			case PInvokeAttributes.CharSetUnicode:
				charSet = CharSet.Unicode;
				break;
			case PInvokeAttributes.CharSetMask:
				charSet = CharSet.Auto;
				break;
			}
			CallingConvention callingConvention = CallingConvention.Cdecl;
			PInvokeAttributes pinvokeAttributes2 = pinvokeAttributes & PInvokeAttributes.CallConvMask;
			if (pinvokeAttributes2 <= PInvokeAttributes.CallConvCdecl)
			{
				if (pinvokeAttributes2 != PInvokeAttributes.CallConvWinapi)
				{
					if (pinvokeAttributes2 == PInvokeAttributes.CallConvCdecl)
					{
						callingConvention = CallingConvention.Cdecl;
					}
				}
				else
				{
					callingConvention = CallingConvention.Winapi;
				}
			}
			else if (pinvokeAttributes2 != PInvokeAttributes.CallConvStdcall)
			{
				if (pinvokeAttributes2 != PInvokeAttributes.CallConvThiscall)
				{
					if (pinvokeAttributes2 == PInvokeAttributes.CallConvFastcall)
					{
						callingConvention = CallingConvention.FastCall;
					}
				}
				else
				{
					callingConvention = CallingConvention.ThisCall;
				}
			}
			else
			{
				callingConvention = CallingConvention.StdCall;
			}
			bool exactSpelling = (pinvokeAttributes & PInvokeAttributes.NoMangle) > PInvokeAttributes.CharSetNotSpec;
			bool setLastError = (pinvokeAttributes & PInvokeAttributes.SupportsLastError) > PInvokeAttributes.CharSetNotSpec;
			bool bestFitMapping = (pinvokeAttributes & PInvokeAttributes.BestFitMask) == PInvokeAttributes.BestFitEnabled;
			bool throwOnUnmappableChar = (pinvokeAttributes & PInvokeAttributes.ThrowOnUnmappableCharMask) == PInvokeAttributes.ThrowOnUnmappableCharEnabled;
			bool preserveSig = (method.GetMethodImplementationFlags() & MethodImplAttributes.PreserveSig) > MethodImplAttributes.IL;
			return new DllImportAttribute(dllName, entryPoint, charSet, exactSpelling, setLastError, preserveSig, callingConvention, bestFitMapping, throwOnUnmappableChar);
		}

		// Token: 0x0600409F RID: 16543 RVA: 0x000E136F File Offset: 0x000DF56F
		internal static bool IsDefined(RuntimeMethodInfo method)
		{
			return (method.Attributes & MethodAttributes.PinvokeImpl) > MethodAttributes.PrivateScope;
		}

		// Token: 0x060040A0 RID: 16544 RVA: 0x000E1380 File Offset: 0x000DF580
		internal DllImportAttribute(string dllName, string entryPoint, CharSet charSet, bool exactSpelling, bool setLastError, bool preserveSig, CallingConvention callingConvention, bool bestFitMapping, bool throwOnUnmappableChar)
		{
			this._val = dllName;
			this.EntryPoint = entryPoint;
			this.CharSet = charSet;
			this.ExactSpelling = exactSpelling;
			this.SetLastError = setLastError;
			this.PreserveSig = preserveSig;
			this.CallingConvention = callingConvention;
			this.BestFitMapping = bestFitMapping;
			this.ThrowOnUnmappableChar = throwOnUnmappableChar;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.DllImportAttribute" /> с именем динамической библиотеки (DLL), содержащей импортируемый метод.</summary>
		/// <param name="dllName">Имя динамической библиотеки (DLL), содержащей неуправляемый метод. Если DLL включена в сборку, это имя может включать отображаемое имя сборки.</param>
		// Token: 0x060040A1 RID: 16545 RVA: 0x000E13D8 File Offset: 0x000DF5D8
		public DllImportAttribute(string dllName)
		{
			this._val = dllName;
		}

		/// <summary>Возвращает имя динамической библиотеки (DLL), содержащей точку входа.</summary>
		/// <returns>Имя файла динамической библиотеки (DLL), содержащей точку входа.</returns>
		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x060040A2 RID: 16546 RVA: 0x000E13E7 File Offset: 0x000DF5E7
		public string Value
		{
			get
			{
				return this._val;
			}
		}

		// Token: 0x04002AD1 RID: 10961
		internal string _val;

		/// <summary>Показывает имя или порядковый номер точки входа вызываемой динамической библиотеки (DLL).</summary>
		// Token: 0x04002AD2 RID: 10962
		public string EntryPoint;

		/// <summary>Показывает способ маршалинга параметров строки для метода, а также управляет искажением имени.</summary>
		// Token: 0x04002AD3 RID: 10963
		public CharSet CharSet;

		/// <summary>Показывает, вызывает ли вызываемый объект функцию <see langword="SetLastError" /> интерфейса Win32 API перед возвращением из метода, использующего атрибуты.</summary>
		// Token: 0x04002AD4 RID: 10964
		public bool SetLastError;

		/// <summary>Контролирует запуск поиска имен точек входа помимо заданной точки в неуправляемой динамической библиотеке (DLL), выполняемого средой CLR, полем <see cref="F:System.Runtime.InteropServices.DllImportAttribute.CharSet" />.</summary>
		// Token: 0x04002AD5 RID: 10965
		public bool ExactSpelling;

		/// <summary>Показывают, выполняется ли для методов с возвращаемыми значениями <see langword="HRESULT" /> или <see langword="retval" /> непосредственное преобразование, либо возвращаемые значения <see langword="HRESULT" /> или <see langword="retval" /> автоматически преобразуются в исключения.</summary>
		// Token: 0x04002AD6 RID: 10966
		public bool PreserveSig;

		/// <summary>Показывает соглашение о вызове для точки входа.</summary>
		// Token: 0x04002AD7 RID: 10967
		public CallingConvention CallingConvention;

		/// <summary>Включает или отключает поведение наилучшего сопоставления при преобразовании знаков Юникода в знаки ANSI.</summary>
		// Token: 0x04002AD8 RID: 10968
		public bool BestFitMapping;

		/// <summary>Включает и отключает возникновение исключений для неотображаемых символов Юникода, преобразующихся в знаки вопроса ("?") ANSI.</summary>
		// Token: 0x04002AD9 RID: 10969
		public bool ThrowOnUnmappableChar;
	}
}
