using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using NSubstitute.Exceptions;

namespace NSubstitute.Core
{
	// Token: 0x02000069 RID: 105
	public class CallInfo
	{
		// Token: 0x06000176 RID: 374 RVA: 0x00005655 File Offset: 0x00003855
		public CallInfo(Argument[] callArguments)
		{
			this._callArguments = callArguments;
		}

		// Token: 0x17000018 RID: 24
		public object this[int index]
		{
			get
			{
				return this._callArguments[index].Value;
			}
			set
			{
				Argument argument = this._callArguments[index];
				this.EnsureArgIsSettable(argument, index, value);
				argument.Value = value;
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000569A File Offset: 0x0000389A
		private void EnsureArgIsSettable(Argument argument, int index, object value)
		{
			if (!argument.IsByRef)
			{
				throw new ArgumentIsNotOutOrRefException(index, argument.DeclaredType);
			}
			if (value != null && !argument.CanSetValueWithInstanceOf(value.GetType()))
			{
				throw new ArgumentSetWithIncompatibleValueException(index, argument.DeclaredType, value.GetType());
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x000056D5 File Offset: 0x000038D5
		public object[] Args()
		{
			return (from x in this._callArguments
			select x.Value).ToArray<object>();
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00005706 File Offset: 0x00003906
		public Type[] ArgTypes()
		{
			return (from x in this._callArguments
			select x.DeclaredType).ToArray<Type>();
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00005738 File Offset: 0x00003938
		public T Arg<T>()
		{
			T result;
			if (this.TryGetArg<T>((Argument x) => x.IsDeclaredTypeEqualToOrByRefVersionOf(typeof(T)), out result))
			{
				return result;
			}
			if (this.TryGetArg<T>((Argument x) => x.IsValueAssignableTo(typeof(T)), out result))
			{
				return result;
			}
			throw new ArgumentNotFoundException("Can not find an argument of type " + typeof(T).FullName + " to this call.");
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000057C0 File Offset: 0x000039C0
		private bool TryGetArg<T>(Func<Argument, bool> condition, [System.Diagnostics.CodeAnalysis.MaybeNullWhen(false)] out T value)
		{
			value = default(T);
			IEnumerable<Argument> enumerable = this._callArguments.Where(condition);
			if (!enumerable.Any<Argument>())
			{
				return false;
			}
			this.ThrowIfMoreThanOne<T>(enumerable);
			value = (T)((object)enumerable.First<Argument>().Value);
			return true;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0000580C File Offset: 0x00003A0C
		private void ThrowIfMoreThanOne<T>(IEnumerable<Argument> arguments)
		{
			if (arguments.Skip(1).Any<Argument>())
			{
				string[] array = new string[7];
				array[0] = "There is more than one argument of type ";
				array[1] = typeof(T).FullName;
				array[2] = " to this call.\nThe call signature is (";
				array[3] = CallInfo.DisplayTypes(this.ArgTypes());
				array[4] = ")\n  and was called with (";
				array[5] = CallInfo.DisplayTypes(from x in this._callArguments
				select x.ActualType);
				array[6] = ")";
				throw new AmbiguousArgumentsException(string.Concat(array));
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000058B0 File Offset: 0x00003AB0
		public T ArgAt<T>(int position)
		{
			if (position >= this._callArguments.Length)
			{
				throw new ArgumentOutOfRangeException("position", string.Format("There is no argument at position {0}", position));
			}
			T result;
			try
			{
				result = (T)((object)this._callArguments[position].Value);
			}
			catch (InvalidCastException)
			{
				throw new InvalidCastException(string.Format("Couldn't convert parameter at position {0} to type {1}", position, typeof(T).FullName));
			}
			return result;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00005930 File Offset: 0x00003B30
		private static string DisplayTypes(IEnumerable<Type> types)
		{
			return string.Join(", ", (from x in types
			select x.Name).ToArray<string>());
		}

		// Token: 0x04000080 RID: 128
		private readonly Argument[] _callArguments;
	}
}
