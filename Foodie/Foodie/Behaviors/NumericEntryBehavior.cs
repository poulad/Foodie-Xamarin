using Xamarin.Forms;

namespace Foodie.Behaviors
{
    class NumericEntryBehavior : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.TextChanged += OnTextChanged;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.TextChanged -= OnTextChanged;
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(e.NewTextValue))
            {
                return;
            }

            if (!double.TryParse(e.NewTextValue, out double _))
            {
                var entry = (Entry)sender;
                entry.Text = e.OldTextValue;
            }
        }
    }
}
