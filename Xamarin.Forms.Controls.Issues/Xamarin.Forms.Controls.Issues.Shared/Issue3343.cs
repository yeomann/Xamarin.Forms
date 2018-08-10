using Xamarin.Forms.CustomAttributes;
using Xamarin.Forms.Internals;

namespace Xamarin.Forms.Controls.Issues
{
	[Preserve(AllMembers = true)]
	[Issue(IssueTracker.Github, 3343, "[Android] Cursor position in entry and selection length not working on 3.2.0-pre1", PlatformAffected.Android | PlatformAffected.iOS)]
	public class Issue3343 : TestContentPage
	{
		protected override void Init()
		{
			Entry entry = new Entry()
			{
				Text = "Initialized"
			};

			Entry entry2 = new Entry()
			{
				Text = "Click Button",

			};

			entry.CursorPosition = 4;
			entry.SelectionLength = entry.Text.Length;

			Content = new StackLayout()
			{
				Padding = 20,
				Children =
						{
						new Label{ Text = "The first Entry should have all text selected starting at character 4. Click the button to trigger the same selection in the second Entry." },
							entry,
							entry2,
							new Button()
							{
								Text = "Click Me",
								Command = new Command(() =>
								{
									entry2.CursorPosition = 4;
									entry2.SelectionLength = entry2.Text.Length;
								})
							},
							new Button()
							{
								Text = "Click Me After",
								Command = new Command(() =>
								{
									entry2.CursorPosition = 2;
								})
							}
						}
			};
		}
	}
}