using System;
using System.Collections.Generic;

namespace Ink.Runtime
{
	// Token: 0x0200002F RID: 47
	public class Object
	{
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600018E RID: 398 RVA: 0x0000CEB6 File Offset: 0x0000B0B6
		// (set) Token: 0x0600018F RID: 399 RVA: 0x0000CEBE File Offset: 0x0000B0BE
		public Object parent { get; set; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000190 RID: 400 RVA: 0x0000CEC7 File Offset: 0x0000B0C7
		// (set) Token: 0x06000191 RID: 401 RVA: 0x0000CEF0 File Offset: 0x0000B0F0
		internal DebugMetadata debugMetadata
		{
			get
			{
				if (this._debugMetadata == null && this.parent)
				{
					return this.parent.debugMetadata;
				}
				return this._debugMetadata;
			}
			set
			{
				this._debugMetadata = value;
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000CEFC File Offset: 0x0000B0FC
		internal int? DebugLineNumberOfPath(Path path)
		{
			if (path == null)
			{
				return null;
			}
			Container rootContentContainer = this.rootContentContainer;
			if (rootContentContainer)
			{
				Object @object = null;
				try
				{
					@object = rootContentContainer.ContentAtPath(path, -1);
				}
				catch
				{
				}
				if (@object)
				{
					DebugMetadata debugMetadata = @object.debugMetadata;
					if (debugMetadata != null)
					{
						return new int?(debugMetadata.startLineNumber);
					}
				}
			}
			return null;
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000193 RID: 403 RVA: 0x0000CF6C File Offset: 0x0000B16C
		internal Path path
		{
			get
			{
				if (this._path == null)
				{
					if (this.parent == null)
					{
						this._path = new Path();
					}
					else
					{
						Stack<Path.Component> stack = new Stack<Path.Component>();
						Object @object = this;
						Container container = @object.parent as Container;
						while (container)
						{
							INamedContent namedContent = @object as INamedContent;
							if (namedContent != null && namedContent.hasValidName)
							{
								stack.Push(new Path.Component(namedContent.name));
							}
							else
							{
								stack.Push(new Path.Component(container.content.IndexOf(@object)));
							}
							@object = container;
							container = (container.parent as Container);
						}
						this._path = new Path(stack, false);
					}
				}
				return this._path;
			}
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000D01C File Offset: 0x0000B21C
		internal Object ResolvePath(Path path)
		{
			if (path.isRelative)
			{
				Container container = this as Container;
				if (!container)
				{
					container = (this.parent as Container);
					path = path.tail;
				}
				return container.ContentAtPath(path, -1);
			}
			return this.rootContentContainer.ContentAtPath(path, -1);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000D06C File Offset: 0x0000B26C
		internal Path ConvertPathToRelative(Path globalPath)
		{
			Path path = this.path;
			int num = Math.Min(globalPath.componentCount, path.componentCount);
			int num2 = -1;
			for (int i = 0; i < num; i++)
			{
				Path.Component component = path.GetComponent(i);
				Path.Component component2 = globalPath.GetComponent(i);
				if (!component.Equals(component2))
				{
					break;
				}
				num2 = i;
			}
			if (num2 == -1)
			{
				return globalPath;
			}
			int num3 = path.componentCount - 1 - num2;
			List<Path.Component> list = new List<Path.Component>();
			for (int j = 0; j < num3; j++)
			{
				list.Add(Path.Component.ToParent());
			}
			for (int k = num2 + 1; k < globalPath.componentCount; k++)
			{
				list.Add(globalPath.GetComponent(k));
			}
			return new Path(list, true);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000D124 File Offset: 0x0000B324
		internal string CompactPathString(Path otherPath)
		{
			string componentsString;
			string componentsString2;
			if (otherPath.isRelative)
			{
				componentsString = otherPath.componentsString;
				componentsString2 = this.path.PathByAppendingPath(otherPath).componentsString;
			}
			else
			{
				componentsString = this.ConvertPathToRelative(otherPath).componentsString;
				componentsString2 = otherPath.componentsString;
			}
			if (componentsString.Length < componentsString2.Length)
			{
				return componentsString;
			}
			return componentsString2;
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000197 RID: 407 RVA: 0x0000D180 File Offset: 0x0000B380
		internal Container rootContentContainer
		{
			get
			{
				Object @object = this;
				while (@object.parent)
				{
					@object = @object.parent;
				}
				return @object as Container;
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000D1AB File Offset: 0x0000B3AB
		internal Object()
		{
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000D1B3 File Offset: 0x0000B3B3
		internal virtual Object Copy()
		{
			throw new NotImplementedException(base.GetType().Name + " doesn't support copying");
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000D1D0 File Offset: 0x0000B3D0
		internal void SetChild<T>(ref T obj, T value) where T : Object
		{
			if (obj)
			{
				obj.parent = null;
			}
			obj = value;
			if (obj)
			{
				obj.parent = this;
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000D222 File Offset: 0x0000B422
		public static implicit operator bool(Object obj)
		{
			return obj != null;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000D22B File Offset: 0x0000B42B
		public static bool operator ==(Object a, Object b)
		{
			return a == b;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000D231 File Offset: 0x0000B431
		public static bool operator !=(Object a, Object b)
		{
			return !(a == b);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000D23D File Offset: 0x0000B43D
		public override bool Equals(object obj)
		{
			return obj == this;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0000D243 File Offset: 0x0000B443
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x0400015A RID: 346
		private DebugMetadata _debugMetadata;

		// Token: 0x0400015B RID: 347
		private Path _path;
	}
}
