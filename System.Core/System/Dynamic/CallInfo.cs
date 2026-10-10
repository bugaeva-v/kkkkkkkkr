using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;
using System.Linq.Expressions;

namespace System.Dynamic
{
	/// <summary>
	///         Описывает аргументы в процессе динамической привязки.
	///       </summary>
	// Token: 0x020002F8 RID: 760
	public sealed class CallInfo
	{
		/// <summary>
		///         Создает новый экземпляр PositionalArgumentInfo.
		///       </summary>
		/// <param name="argCount">
		///           Число аргументов.
		///         </param>
		/// <param name="argNames">
		///           Имена аргументов.
		///         </param>
		// Token: 0x060016E6 RID: 5862 RVA: 0x0004CEB2 File Offset: 0x0004B0B2
		public CallInfo(int argCount, params string[] argNames) : this(argCount, argNames)
		{
		}

		/// <summary>
		///         Создает новый объект CallInfo, представляющий аргументы в процессе динамической привязки.
		///       </summary>
		/// <param name="argCount">
		///           Число аргументов.
		///         </param>
		/// <param name="argNames">
		///           Имена аргументов.
		///         </param>
		// Token: 0x060016E7 RID: 5863 RVA: 0x0004CEBC File Offset: 0x0004B0BC
		public CallInfo(int argCount, IEnumerable<string> argNames)
		{
			ContractUtils.RequiresNotNull(argNames, "argNames");
			ReadOnlyCollection<string> readOnlyCollection = argNames.ToReadOnly<string>();
			if (argCount < readOnlyCollection.Count)
			{
				throw Error.ArgCntMustBeGreaterThanNameCnt();
			}
			ContractUtils.RequiresNotNullItems<string>(readOnlyCollection, "argNames");
			this.ArgumentCount = argCount;
			this.ArgumentNames = readOnlyCollection;
		}

		/// <summary>
		///         Число аргументов.
		///       </summary>
		/// <returns>
		///         Число аргументов.
		///       </returns>
		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x060016E8 RID: 5864 RVA: 0x0004CF09 File Offset: 0x0004B109
		public int ArgumentCount { get; }

		/// <summary>
		///         Имена аргументов.
		///       </summary>
		/// <returns>
		///         Только для чтения коллекция имен аргументов.
		///       </returns>
		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x060016E9 RID: 5865 RVA: 0x0004CF11 File Offset: 0x0004B111
		public ReadOnlyCollection<string> ArgumentNames { get; }

		/// <summary>
		///         Служит хэш-функцией текущего <see cref="T:System.Dynamic.CallInfo" />.
		///       </summary>
		/// <returns>
		///         Хэш-код для текущего объекта <see cref="T:System.Dynamic.CallInfo" />.
		///       </returns>
		// Token: 0x060016EA RID: 5866 RVA: 0x0004CF19 File Offset: 0x0004B119
		public override int GetHashCode()
		{
			return this.ArgumentCount ^ this.ArgumentNames.ListHashCode<string>();
		}

		/// <summary>
		///         Определяет, считается ли указанный экземпляр CallInfo текущему объекту.
		///       </summary>
		/// <param name="obj">
		///           Экземпляр <see cref="T:System.Dynamic.CallInfo" /> для сравнения с текущим экземпляром.
		///         </param>
		/// <returns>
		///         значение true, если указанный экземпляр равен имеющийся в противном случае — значение false.
		///       </returns>
		// Token: 0x060016EB RID: 5867 RVA: 0x0004CF30 File Offset: 0x0004B130
		public override bool Equals(object obj)
		{
			CallInfo callInfo = obj as CallInfo;
			return callInfo != null && this.ArgumentCount == callInfo.ArgumentCount && this.ArgumentNames.ListEquals(callInfo.ArgumentNames);
		}
	}
}
