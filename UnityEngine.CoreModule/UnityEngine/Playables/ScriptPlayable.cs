using System;

namespace UnityEngine.Playables
{
	// Token: 0x0200044C RID: 1100
	public struct ScriptPlayable<T> : IPlayable, IEquatable<ScriptPlayable<T>> where T : class, IPlayableBehaviour, new()
	{
		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x060026DE RID: 9950 RVA: 0x00040D1C File Offset: 0x0003EF1C
		public static ScriptPlayable<T> Null
		{
			get
			{
				return ScriptPlayable<T>.m_NullPlayable;
			}
		}

		// Token: 0x060026DF RID: 9951 RVA: 0x00040D34 File Offset: 0x0003EF34
		public static ScriptPlayable<T> Create(PlayableGraph graph, int inputCount = 0)
		{
			PlayableHandle handle = ScriptPlayable<T>.CreateHandle(graph, default(T), inputCount);
			return new ScriptPlayable<T>(handle);
		}

		// Token: 0x060026E0 RID: 9952 RVA: 0x00040D60 File Offset: 0x0003EF60
		public static ScriptPlayable<T> Create(PlayableGraph graph, T template, int inputCount = 0)
		{
			PlayableHandle handle = ScriptPlayable<T>.CreateHandle(graph, template, inputCount);
			return new ScriptPlayable<T>(handle);
		}

		// Token: 0x060026E1 RID: 9953 RVA: 0x00040D84 File Offset: 0x0003EF84
		private static PlayableHandle CreateHandle(PlayableGraph graph, T template, int inputCount)
		{
			bool flag = template == null;
			object obj;
			if (flag)
			{
				obj = ScriptPlayable<T>.CreateScriptInstance();
			}
			else
			{
				obj = ScriptPlayable<T>.CloneScriptInstance(template);
			}
			bool flag2 = obj == null;
			PlayableHandle result;
			if (flag2)
			{
				string str = "Could not create a ScriptPlayable of Type ";
				Type typeFromHandle = typeof(T);
				Debug.LogError(str + ((typeFromHandle != null) ? typeFromHandle.ToString() : null));
				result = PlayableHandle.Null;
			}
			else
			{
				PlayableHandle playableHandle = graph.CreatePlayableHandle();
				bool flag3 = !playableHandle.IsValid();
				if (flag3)
				{
					result = PlayableHandle.Null;
				}
				else
				{
					playableHandle.SetInputCount(inputCount);
					playableHandle.SetScriptInstance(obj);
					result = playableHandle;
				}
			}
			return result;
		}

		// Token: 0x060026E2 RID: 9954 RVA: 0x00040E2C File Offset: 0x0003F02C
		private static object CreateScriptInstance()
		{
			bool flag = typeof(ScriptableObject).IsAssignableFrom(typeof(T));
			IPlayableBehaviour result;
			if (flag)
			{
				result = (ScriptableObject.CreateInstance(typeof(T)) as T);
			}
			else
			{
				result = Activator.CreateInstance<T>();
			}
			return result;
		}

		// Token: 0x060026E3 RID: 9955 RVA: 0x00040E8C File Offset: 0x0003F08C
		private static object CloneScriptInstance(IPlayableBehaviour source)
		{
			Object @object = source as Object;
			bool flag = @object != null;
			object result;
			if (flag)
			{
				result = ScriptPlayable<T>.CloneScriptInstanceFromEngineObject(@object);
			}
			else
			{
				ICloneable cloneable = source as ICloneable;
				bool flag2 = cloneable != null;
				if (flag2)
				{
					result = ScriptPlayable<T>.CloneScriptInstanceFromIClonable(cloneable);
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x060026E4 RID: 9956 RVA: 0x00040ED4 File Offset: 0x0003F0D4
		private static object CloneScriptInstanceFromEngineObject(Object source)
		{
			Object @object = Object.Instantiate(source);
			bool flag = @object != null;
			if (flag)
			{
				@object.hideFlags |= HideFlags.DontSave;
			}
			return @object;
		}

		// Token: 0x060026E5 RID: 9957 RVA: 0x00040F0C File Offset: 0x0003F10C
		private static object CloneScriptInstanceFromIClonable(ICloneable source)
		{
			return source.Clone();
		}

		// Token: 0x060026E6 RID: 9958 RVA: 0x00040F24 File Offset: 0x0003F124
		internal ScriptPlayable(PlayableHandle handle)
		{
			bool flag = handle.IsValid();
			if (flag)
			{
				bool flag2 = !typeof(T).IsAssignableFrom(handle.GetPlayableType());
				if (flag2)
				{
					throw new InvalidCastException(string.Format("Incompatible handle: Trying to assign a playable data of type `{0}` that is not compatible with the PlayableBehaviour of type `{1}`.", handle.GetPlayableType(), typeof(T)));
				}
			}
			this.m_Handle = handle;
		}

		// Token: 0x060026E7 RID: 9959 RVA: 0x00040F84 File Offset: 0x0003F184
		public PlayableHandle GetHandle()
		{
			return this.m_Handle;
		}

		// Token: 0x060026E8 RID: 9960 RVA: 0x00040F9C File Offset: 0x0003F19C
		public T GetBehaviour()
		{
			return this.m_Handle.GetObject<T>();
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x00040FBC File Offset: 0x0003F1BC
		public static implicit operator Playable(ScriptPlayable<T> playable)
		{
			return new Playable(playable.GetHandle());
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x00040FDC File Offset: 0x0003F1DC
		public static explicit operator ScriptPlayable<T>(Playable playable)
		{
			return new ScriptPlayable<T>(playable.GetHandle());
		}

		// Token: 0x060026EB RID: 9963 RVA: 0x00040FFC File Offset: 0x0003F1FC
		public bool Equals(ScriptPlayable<T> other)
		{
			return this.GetHandle() == other.GetHandle();
		}

		// Token: 0x04000E34 RID: 3636
		private PlayableHandle m_Handle;

		// Token: 0x04000E35 RID: 3637
		private static readonly ScriptPlayable<T> m_NullPlayable = new ScriptPlayable<T>(PlayableHandle.Null);
	}
}
