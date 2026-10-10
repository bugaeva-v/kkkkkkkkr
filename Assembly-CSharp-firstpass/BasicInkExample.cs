using System;
using Ink.Runtime;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000002 RID: 2
public class BasicInkExample : MonoBehaviour
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	private void Awake()
	{
		this.StartStory();
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
	private void StartStory()
	{
		this.story = new Story(this.inkJSONAsset.text);
		this.RefreshView();
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002078 File Offset: 0x00000278
	private void RefreshView()
	{
		this.RemoveChildren();
		while (this.story.canContinue)
		{
			string text = this.story.Continue().Trim();
			this.CreateContentView(text);
		}
		if (this.story.currentChoices.Count > 0)
		{
			for (int i = 0; i < this.story.currentChoices.Count; i++)
			{
				Choice choice = this.story.currentChoices[i];
				this.CreateChoiceView(choice.text.Trim()).onClick.AddListener(delegate()
				{
					this.OnClickChoiceButton(choice);
				});
			}
			return;
		}
		this.CreateChoiceView("End of story.\nRestart?").onClick.AddListener(delegate()
		{
			this.StartStory();
		});
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002152 File Offset: 0x00000352
	private void OnClickChoiceButton(Choice choice)
	{
		this.story.ChooseChoiceIndex(choice.index);
		this.RefreshView();
	}

	// Token: 0x06000005 RID: 5 RVA: 0x0000216B File Offset: 0x0000036B
	private void CreateContentView(string text)
	{
		Text text2 = UnityEngine.Object.Instantiate<Text>(this.textPrefab);
		text2.text = text;
		text2.transform.SetParent(this.canvas.transform, false);
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002195 File Offset: 0x00000395
	private Button CreateChoiceView(string text)
	{
		Button button = UnityEngine.Object.Instantiate<Button>(this.buttonPrefab);
		button.transform.SetParent(this.canvas.transform, false);
		button.GetComponentInChildren<Text>().text = text;
		button.GetComponent<HorizontalLayoutGroup>().childForceExpandHeight = false;
		return button;
	}

	// Token: 0x06000007 RID: 7 RVA: 0x000021D4 File Offset: 0x000003D4
	private void RemoveChildren()
	{
		for (int i = this.canvas.transform.childCount - 1; i >= 0; i--)
		{
			UnityEngine.Object.Destroy(this.canvas.transform.GetChild(i).gameObject);
		}
	}

	// Token: 0x04000001 RID: 1
	[SerializeField]
	private TextAsset inkJSONAsset;

	// Token: 0x04000002 RID: 2
	private Story story;

	// Token: 0x04000003 RID: 3
	[SerializeField]
	private Canvas canvas;

	// Token: 0x04000004 RID: 4
	[SerializeField]
	private Text textPrefab;

	// Token: 0x04000005 RID: 5
	[SerializeField]
	private Button buttonPrefab;
}
