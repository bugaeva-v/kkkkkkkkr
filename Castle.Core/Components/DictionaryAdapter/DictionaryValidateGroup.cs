using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000118 RID: 280
	public class DictionaryValidateGroup : IDictionaryValidate, IDataErrorInfo, INotifyPropertyChanged, IDisposable
	{
		// Token: 0x060007B5 RID: 1973 RVA: 0x00015C18 File Offset: 0x00013E18
		public DictionaryValidateGroup(object[] groups, IDictionaryAdapter adapter)
		{
			this.groups = groups;
			this.adapter = adapter;
			this.propertyNames = (from property in this.adapter.This.Properties.Values
			from groupings in property.Annotations.OfType<GroupAttribute>()
			where this.groups.Intersect(groupings.Group).Any<object>()
			select property.PropertyName).Distinct<string>().ToArray<string>();
			if (this.propertyNames.Length != 0 && adapter.CanNotify)
			{
				this.propertyChanged = (PropertyChangedEventHandler)Delegate.Combine(this.propertyChanged, new PropertyChangedEventHandler(delegate(object sender, PropertyChangedEventArgs args)
				{
					if (this.PropertyChanged != null)
					{
						this.PropertyChanged(this, args);
					}
				}));
				this.adapter.PropertyChanged += this.propertyChanged;
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060007B6 RID: 1974 RVA: 0x00015D1C File Offset: 0x00013F1C
		// (remove) Token: 0x060007B7 RID: 1975 RVA: 0x00015D54 File Offset: 0x00013F54
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060007B8 RID: 1976 RVA: 0x00015D89 File Offset: 0x00013F89
		// (set) Token: 0x060007B9 RID: 1977 RVA: 0x00015D96 File Offset: 0x00013F96
		public bool CanValidate
		{
			get
			{
				return this.adapter.CanValidate;
			}
			set
			{
				this.adapter.CanValidate = value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x00015DA4 File Offset: 0x00013FA4
		public bool IsValid
		{
			get
			{
				return string.IsNullOrEmpty(this.Error);
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060007BB RID: 1979 RVA: 0x00015DB4 File Offset: 0x00013FB4
		public string Error
		{
			get
			{
				return string.Join(Environment.NewLine, (from propertyName in this.propertyNames
				select this.adapter[propertyName] into errors
				where !string.IsNullOrEmpty(errors)
				select errors).ToArray<string>());
			}
		}

		// Token: 0x1700013C RID: 316
		public string this[string columnName]
		{
			get
			{
				if (Array.IndexOf<string>(this.propertyNames, columnName) >= 0)
				{
					return this.adapter[columnName];
				}
				return string.Empty;
			}
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00015E2E File Offset: 0x0001402E
		public DictionaryValidateGroup ValidateGroups(params object[] groups)
		{
			groups = this.groups.Union(groups).ToArray<object>();
			return new DictionaryValidateGroup(groups, this.adapter);
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x00015E4F File Offset: 0x0001404F
		public IEnumerable<IDictionaryValidator> Validators
		{
			get
			{
				return this.adapter.Validators;
			}
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x00015E5C File Offset: 0x0001405C
		public void AddValidator(IDictionaryValidator validator)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x00015E63 File Offset: 0x00014063
		public void Dispose()
		{
			this.adapter.PropertyChanged -= this.propertyChanged;
		}

		// Token: 0x040001D8 RID: 472
		private readonly object[] groups;

		// Token: 0x040001D9 RID: 473
		private readonly IDictionaryAdapter adapter;

		// Token: 0x040001DA RID: 474
		private readonly string[] propertyNames;

		// Token: 0x040001DB RID: 475
		private readonly PropertyChangedEventHandler propertyChanged;
	}
}
