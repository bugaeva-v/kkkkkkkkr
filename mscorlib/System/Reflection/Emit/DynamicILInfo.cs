using System;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>Обеспечивает поддержку альтернативных методов создания MSIL и метаданных для динамического метода, включая методы создания токенов и вставки кода, обработки исключений и больших двоичных объектов подписи локальных переменных.</summary>
	// Token: 0x0200091C RID: 2332
	[ComVisible(true)]
	public class DynamicILInfo
	{
		// Token: 0x06004F63 RID: 20323 RVA: 0x0000259F File Offset: 0x0000079F
		internal DynamicILInfo()
		{
		}

		// Token: 0x06004F64 RID: 20324 RVA: 0x000F9A72 File Offset: 0x000F7C72
		internal DynamicILInfo(DynamicMethod method)
		{
			this.method = method;
		}

		/// <summary>Возвращает динамический метод, основной текст которого создан текущим экземпляром.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.Emit.DynamicMethod" />, представляющий динамический метод, для которого текущий объект <see cref="T:System.Reflection.Emit.DynamicILInfo" /> создает код.</returns>
		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x06004F65 RID: 20325 RVA: 0x000F9A81 File Offset: 0x000F7C81
		public DynamicMethod DynamicMethod
		{
			get
			{
				return this.method;
			}
		}

		/// <summary>Возвращает токен, допустимый в области текущего <see cref="T:System.Reflection.Emit.DynamicILInfo" />, представляющего подпись для связанного динамического метода.</summary>
		/// <param name="signature">Массив, содержащий сигнатуру.</param>
		/// <returns>токен, который может быть внедрен в метаданные и поток MSIL для связанного динамического метода.</returns>
		// Token: 0x06004F66 RID: 20326 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public int GetTokenFor(byte[] signature)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает токен, допустимый в области текущего <see cref="T:System.Reflection.Emit.DynamicILInfo" />, представляющего динамический метод, который должен быть вызван из связанного метода.</summary>
		/// <param name="method">Вызываемый динамический метод.</param>
		/// <returns>токен, который может быть встроен в поток MSIL для связанного динамического метода в качестве назначения инструкции MSIL.</returns>
		// Token: 0x06004F67 RID: 20327 RVA: 0x000F9A89 File Offset: 0x000F7C89
		public int GetTokenFor(DynamicMethod method)
		{
			return this.method.GetILGenerator().TokenGenerator.GetToken(method, false);
		}

		/// <summary>Возвращает токен, допустимый в области текущего <see cref="T:System.Reflection.Emit.DynamicILInfo" />, представляющего поле, к которому должен быть предоставлен доступ из связанного динамического метода.</summary>
		/// <param name="field">Поле для доступа.</param>
		/// <returns>токен, который может быть использован в качестве операнда инструкции MSIL, получающей доступ к полям, в области действия текущего объекта <see cref="T:System.Reflection.Emit.DynamicILInfo" />.</returns>
		// Token: 0x06004F68 RID: 20328 RVA: 0x000F9AA2 File Offset: 0x000F7CA2
		public int GetTokenFor(RuntimeFieldHandle field)
		{
			return this.method.GetILGenerator().TokenGenerator.GetToken(FieldInfo.GetFieldFromHandle(field), false);
		}

		/// <summary>Возвращает токен, допустимый в области текущего <see cref="T:System.Reflection.Emit.DynamicILInfo" />, представляющего метод, к которому должен быть предоставлен доступ из связанного динамического метода.</summary>
		/// <param name="method">Метод для доступа.</param>
		/// <returns>токен, который может быть использован в качестве операнда инструкции MSIL, получающей доступ к методам, таким как <see cref="F:System.Reflection.Emit.OpCodes.Call" /> или <see cref="F:System.Reflection.Emit.OpCodes.Ldtoken" /> в области действия текущего объекта <see cref="T:System.Reflection.Emit.DynamicILInfo" />.</returns>
		// Token: 0x06004F69 RID: 20329 RVA: 0x000F9AC0 File Offset: 0x000F7CC0
		public int GetTokenFor(RuntimeMethodHandle method)
		{
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle(method);
			return this.method.GetILGenerator().TokenGenerator.GetToken(methodFromHandle, false);
		}

		/// <summary>Возвращает токен, допустимый в области текущего <see cref="T:System.Reflection.Emit.DynamicILInfo" />, представляющего тип, который будет использоваться в связанном динамическом методе.</summary>
		/// <param name="type">Используемый тип.</param>
		/// <returns>токен, который может быть использован в качестве операнда инструкции MSIL, нуждающейся в типе, в области действия текущего объекта <see cref="T:System.Reflection.Emit.DynamicILInfo" />.</returns>
		// Token: 0x06004F6A RID: 20330 RVA: 0x000F9AEC File Offset: 0x000F7CEC
		public int GetTokenFor(RuntimeTypeHandle type)
		{
			Type typeFromHandle = Type.GetTypeFromHandle(type);
			return this.method.GetILGenerator().TokenGenerator.GetToken(typeFromHandle, false);
		}

		/// <summary>Возвращает токен, допустимый в области текущего <see cref="T:System.Reflection.Emit.DynamicILInfo" />, представляющего строковый литерал, который будет использоваться в связанном динамическом методе.</summary>
		/// <param name="literal">Используемая строка.</param>
		/// <returns>токен, который может быть использован в качестве операнда инструкции MSIL, нуждающейся в строке, в области действия текущего объекта <see cref="T:System.Reflection.Emit.DynamicILInfo" />.</returns>
		// Token: 0x06004F6B RID: 20331 RVA: 0x000F9B17 File Offset: 0x000F7D17
		public int GetTokenFor(string literal)
		{
			return this.method.GetILGenerator().TokenGenerator.GetToken(literal);
		}

		/// <summary>Возвращает токен, допустимый в области действия текущего <see cref="T:System.Reflection.Emit.DynamicILInfo" />, представляющего метод в универсальном типе.</summary>
		/// <param name="method">Метод.</param>
		/// <param name="contextType">Универсальный тип, к которому принадлежит метод.</param>
		/// <returns>токен, который может быть использован в качестве операнда инструкции MSIL, получающей доступ к методам, таким как <see cref="F:System.Reflection.Emit.OpCodes.Call" /> или <see cref="F:System.Reflection.Emit.OpCodes.Ldtoken" /> в области действия текущего объекта <see cref="T:System.Reflection.Emit.DynamicILInfo" />.</returns>
		// Token: 0x06004F6C RID: 20332 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public int GetTokenFor(RuntimeMethodHandle method, RuntimeTypeHandle contextType)
		{
			throw new NotImplementedException();
		}

		/// <summary>Получает токен, допустимый в области текущего объекта <see cref="T:System.Reflection.Emit.DynamicILInfo" />, представляющего поле, к которому должен быть предоставлен доступ из связанного динамического метода; поле относится к указанному универсальному типу.</summary>
		/// <param name="field">Поле для доступа.</param>
		/// <param name="contextType">Универсальный тип, к которому относится поле.</param>
		/// <returns>Токен, который может быть использован в качестве операнда инструкции MSIL, получающей доступ к полям в области действия текущего объекта <see cref="T:System.Reflection.Emit.DynamicILInfo" />.</returns>
		// Token: 0x06004F6D RID: 20333 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public int GetTokenFor(RuntimeFieldHandle field, RuntimeTypeHandle contextType)
		{
			throw new NotImplementedException();
		}

		/// <summary>Задает основной текст кода связанного динамического метода.</summary>
		/// <param name="code">Массив, который содержит поток MSIL.</param>
		/// <param name="maxStackSize">Максимальное количество элементов в стеке операторов при выполнении метода.</param>
		// Token: 0x06004F6E RID: 20334 RVA: 0x000F9B2F File Offset: 0x000F7D2F
		public void SetCode(byte[] code, int maxStackSize)
		{
			if (code == null)
			{
				throw new ArgumentNullException("code");
			}
			this.method.GetILGenerator().SetCode(code, maxStackSize);
		}

		/// <summary>Задает основной текст кода связанного динамического метода.</summary>
		/// <param name="code">Указатель на массив байтов, в котором содержится поток MSIL.</param>
		/// <param name="codeSize">Возвращает число байтов потока MSIL.</param>
		/// <param name="maxStackSize">Максимальное количество элементов в стеке операторов при выполнении метода.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="code" /> равно <see langword="null" />, а <paramref name="codeSize" /> больше 0.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="codeSize" /> меньше 0.</exception>
		// Token: 0x06004F6F RID: 20335 RVA: 0x000F9B51 File Offset: 0x000F7D51
		[CLSCompliant(false)]
		public unsafe void SetCode(byte* code, int codeSize, int maxStackSize)
		{
			if (code == null)
			{
				throw new ArgumentNullException("code");
			}
			this.method.GetILGenerator().SetCode(code, codeSize, maxStackSize);
		}

		/// <summary>Задает метаданные исключения для связанного динамического метода.</summary>
		/// <param name="exceptions">Массив, в котором содержатся метаданные исключения.</param>
		// Token: 0x06004F70 RID: 20336 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public void SetExceptions(byte[] exceptions)
		{
			throw new NotImplementedException();
		}

		/// <summary>Задает метаданные исключения для связанного динамического метода.</summary>
		/// <param name="exceptions">Указатель на массив байтов, содержащий метаданные исключения.</param>
		/// <param name="exceptionsSize">Количество байтов в метаданных исключения.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="exceptions" /> равно <see langword="null" />, а <paramref name="exceptionSize" /> больше 0.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="exceptionSize" /> меньше 0.</exception>
		// Token: 0x06004F71 RID: 20337 RVA: 0x000479F8 File Offset: 0x00045BF8
		[CLSCompliant(false)]
		[MonoTODO]
		public unsafe void SetExceptions(byte* exceptions, int exceptionsSize)
		{
			throw new NotImplementedException();
		}

		/// <summary>Задает подпись локальной переменной, которая описывает структуру локальных переменных для связанного динамического метода.</summary>
		/// <param name="localSignature">Массив, содержащий структуру локальных переменных для связанного метода <see cref="T:System.Reflection.Emit.DynamicMethod" />.</param>
		// Token: 0x06004F72 RID: 20338 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public void SetLocalSignature(byte[] localSignature)
		{
			throw new NotImplementedException();
		}

		/// <summary>Задает подпись локальной переменной, которая описывает структуру локальных переменных для связанного динамического метода.</summary>
		/// <param name="localSignature">Массив, содержащий структуру локальных переменных для связанного метода <see cref="T:System.Reflection.Emit.DynamicMethod" />.</param>
		/// <param name="signatureSize">Число байтов в подписи.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="localSignature" /> равно <see langword="null" />, а <paramref name="signatureSize" /> больше 0.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="signatureSize" /> меньше 0.</exception>
		// Token: 0x06004F73 RID: 20339 RVA: 0x000F9B78 File Offset: 0x000F7D78
		[CLSCompliant(false)]
		public unsafe void SetLocalSignature(byte* localSignature, int signatureSize)
		{
			byte[] array = new byte[signatureSize];
			for (int i = 0; i < signatureSize; i++)
			{
				array[i] = localSignature[i];
			}
		}

		// Token: 0x04003135 RID: 12597
		private DynamicMethod method;
	}
}
