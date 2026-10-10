using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;

namespace System.Runtime.CompilerServices
{
	/// <summary>
	///         Создает отладочную информацию для лямбда-выражений в дереве выражения.
	///       </summary>
	// Token: 0x020002E3 RID: 739
	public abstract class DebugInfoGenerator
	{
		/// <summary>
		///         Создает генератор символов базы данных (PDB) программы.
		///       </summary>
		/// <returns>
		///         Генератор символов PDB.
		///       </returns>
		// Token: 0x0600166E RID: 5742 RVA: 0x00003A06 File Offset: 0x00001C06
		public static DebugInfoGenerator CreatePdbGenerator()
		{
			throw new PlatformNotSupportedException();
		}

		/// <summary>
		///         Задает точку следования в код на промежуточном языке (MSIL).
		///       </summary>
		/// <param name="method">
		///           Лямбда-выражение, которое создается.
		///         </param>
		/// <param name="ilOffset">
		///           Смещение внутри кода MSIL, на котором для обозначения точки последовательности.
		///         </param>
		/// <param name="sequencePoint">
		///           Отладочную информацию, который соответствует точке последовательности.
		///         </param>
		// Token: 0x0600166F RID: 5743
		public abstract void MarkSequencePoint(LambdaExpression method, int ilOffset, DebugInfoExpression sequencePoint);

		// Token: 0x06001670 RID: 5744 RVA: 0x0004BD6D File Offset: 0x00049F6D
		internal virtual void MarkSequencePoint(LambdaExpression method, MethodBase methodBase, ILGenerator ilg, DebugInfoExpression sequencePoint)
		{
			this.MarkSequencePoint(method, ilg.ILOffset, sequencePoint);
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x00003A59 File Offset: 0x00001C59
		internal virtual void SetLocalName(LocalBuilder localBuilder, string name)
		{
		}
	}
}
