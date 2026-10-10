using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace NSubstitute.Routing.AutoValues
{
	// Token: 0x02000038 RID: 56
	public class AutoTaskProvider : IAutoValueProvider
	{
		// Token: 0x060000CA RID: 202 RVA: 0x00003E3D File Offset: 0x0000203D
		public AutoTaskProvider(Lazy<IReadOnlyCollection<IAutoValueProvider>> autoValueProviders)
		{
			this._autoValueProviders = autoValueProviders;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00003E4C File Offset: 0x0000204C
		public bool CanProvideValueFor(Type type)
		{
			return typeof(Task).IsAssignableFrom(type);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00003E60 File Offset: 0x00002060
		public object GetValue(Type type)
		{
			if (!this.CanProvideValueFor(type))
			{
				throw new InvalidOperationException();
			}
			if (type.GetTypeInfo().IsGenericType)
			{
				Type taskType = type.GetGenericArguments()[0];
				IAutoValueProvider autoValueProvider = this._autoValueProviders.Value.FirstOrDefault((IAutoValueProvider vp) => vp.CanProvideValueFor(taskType));
				object obj = (autoValueProvider == null) ? AutoTaskProvider.GetDefault(type) : autoValueProvider.GetValue(taskType);
				Type type2 = typeof(TaskCompletionSource<>).MakeGenericType(new Type[]
				{
					taskType
				});
				object obj2 = Activator.CreateInstance(type2);
				type2.GetMethod("SetResult").Invoke(obj2, new object[]
				{
					obj
				});
				return type2.GetProperty("Task").GetValue(obj2, null);
			}
			TaskCompletionSource<object> taskCompletionSource = new TaskCompletionSource<object>();
			taskCompletionSource.SetResult(null);
			return taskCompletionSource.Task;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00003F3E File Offset: 0x0000213E
		[return: Nullable(2)]
		private static object GetDefault(Type type)
		{
			if (!type.GetTypeInfo().IsValueType)
			{
				return null;
			}
			return Activator.CreateInstance(type);
		}

		// Token: 0x0400004A RID: 74
		private readonly Lazy<IReadOnlyCollection<IAutoValueProvider>> _autoValueProviders;
	}
}
