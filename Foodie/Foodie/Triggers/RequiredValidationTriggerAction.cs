using Xamarin.Forms;

namespace Foodie.Triggers
{
    class RequiredValidationTriggerAction : TriggerAction<Entry>
    {
        protected override void Invoke(Entry entry)
        {
            entry.BackgroundColor = string.IsNullOrEmpty(entry.Text)
                ? Color.FromHex("#FFCDD2")
                : Color.Default;
        }
    }
}
