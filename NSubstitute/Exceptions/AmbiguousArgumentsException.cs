using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using NSubstitute.Core;
using NSubstitute.Core.Arguments;

namespace NSubstitute.Exceptions
{
	// Token: 0x0200004A RID: 74
	public class AmbiguousArgumentsException : SubstituteException
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000109 RID: 265 RVA: 0x0000485E File Offset: 0x00002A5E
		internal bool ContainsDefaultMessage { get; }

		// Token: 0x0600010A RID: 266 RVA: 0x00004866 File Offset: 0x00002A66
		public AmbiguousArgumentsException() : base("Cannot determine argument specifications to use. Please use specifications for all arguments of the same type.")
		{
			this.ContainsDefaultMessage = 1;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000487A File Offset: 0x00002A7A
		public AmbiguousArgumentsException(string message) : base(message)
		{
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00004883 File Offset: 0x00002A83
		public AmbiguousArgumentsException(MethodInfo method, [Nullable(new byte[]
		{
			0,
			2
		})] IEnumerable<object> invocationArguments, IEnumerable<IArgumentSpecification> matchedSpecifications, IEnumerable<IArgumentSpecification> allSpecifications) : this(AmbiguousArgumentsException.BuildExceptionMessage(method, invocationArguments, matchedSpecifications, allSpecifications))
		{
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00004898 File Offset: 0x00002A98
		private static string BuildExceptionMessage(MethodInfo method, [Nullable(new byte[]
		{
			0,
			2
		})] IEnumerable<object> invocationArguments, IEnumerable<IArgumentSpecification> matchedSpecifications, IEnumerable<IArgumentSpecification> allSpecifications)
		{
			string text = null;
			string text2 = null;
			string text3 = null;
			if (CallFormatter.Default.CanFormat(method))
			{
				object[] array = invocationArguments.ToArray<object>();
				if (method.GetParameters().Last<ParameterInfo>().IsParams())
				{
					IEnumerable enumerable = array.Last<object>() as IEnumerable;
					if (enumerable != null)
					{
						array = array.Take(array.Length - 1).Concat(enumerable.Cast<object>()).ToArray<object>();
					}
				}
				text = CallFormatter.Default.Format(method, AmbiguousArgumentsException.FormatMethodParameterTypes(method.GetParameters()));
				text2 = CallFormatter.Default.Format(method, AmbiguousArgumentsException.FormatMethodArguments(array));
				text3 = CallFormatter.Default.Format(method, AmbiguousArgumentsException.PadNonMatchedSpecifications(matchedSpecifications, array));
			}
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("Cannot determine argument specifications to use. Please use specifications for all arguments of the same type.");
			if (text != null)
			{
				stringBuilder.AppendLine("Method signature:");
				stringBuilder.Append("    ");
				stringBuilder.AppendLine(text);
			}
			if (text2 != null)
			{
				stringBuilder.AppendLine("Method arguments (possible arg matchers are indicated with '*'):");
				stringBuilder.Append("    ");
				stringBuilder.AppendLine(text2);
			}
			stringBuilder.AppendLine("All queued specifications:");
			stringBuilder.AppendLine(AmbiguousArgumentsException.FormatSpecifications(allSpecifications));
			if (text3 != null)
			{
				stringBuilder.AppendLine("Matched argument specifications:");
				stringBuilder.Append("    ");
				stringBuilder.AppendLine(text3);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000049DF File Offset: 0x00002BDF
		private static IEnumerable<string> FormatMethodParameterTypes(IEnumerable<ParameterInfo> parameters)
		{
			return parameters.Select(delegate(ParameterInfo p)
			{
				Type parameterType = p.ParameterType;
				if (p.IsOut)
				{
					return "out " + parameterType.GetElementType().GetNonMangledTypeName();
				}
				if (parameterType.IsByRef)
				{
					return "ref " + parameterType.GetElementType().GetNonMangledTypeName();
				}
				if (p.IsParams())
				{
					return "params " + parameterType.GetNonMangledTypeName();
				}
				return parameterType.GetNonMangledTypeName();
			});
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00004A08 File Offset: 0x00002C08
		private static IEnumerable<string> FormatMethodArguments([Nullable(new byte[]
		{
			0,
			2
		})] IEnumerable<object> arguments)
		{
			DefaultChecker defaultChecker = new DefaultChecker(new DefaultForType());
			return arguments.Select(delegate(object arg)
			{
				bool highlight = arg == null || defaultChecker.IsDefault(arg, arg.GetType());
				return ArgumentFormatter.Default.Format(arg, highlight);
			});
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00004A40 File Offset: 0x00002C40
		private static IEnumerable<string> PadNonMatchedSpecifications(IEnumerable<IArgumentSpecification> matchedSpecifications, [Nullable(new byte[]
		{
			0,
			2
		})] IEnumerable<object> allArguments)
		{
			string[] array = (from x in matchedSpecifications
			select x.ToString() ?? string.Empty).ToArray<string>();
			int count = allArguments.Count<object>() - array.Length;
			IEnumerable<string> second = Enumerable.Repeat<string>("???", count);
			return array.Concat(second);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00004A96 File Offset: 0x00002C96
		private static string FormatSpecifications(IEnumerable<IArgumentSpecification> specifications)
		{
			return string.Join(Environment.NewLine, from spec in specifications
			select "    " + spec.ToString());
		}

		// Token: 0x0400005A RID: 90
		internal const string NonReportedResolvedSpecificationsKey = "NON_REPORTED_RESOLVED_SPECIFICATIONS";

		// Token: 0x0400005B RID: 91
		private const string DefaultErrorMessage = "Cannot determine argument specifications to use. Please use specifications for all arguments of the same type.";

		// Token: 0x0400005C RID: 92
		private const string TabPadding = "    ";
	}
}
