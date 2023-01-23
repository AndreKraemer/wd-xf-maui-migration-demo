using Android.Content;
using MauiMigrationDemo;
using MauiMigrationDemo.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ShadowButton), typeof(ShadowButtonRenderer))]
namespace MauiMigrationDemo.Droid
{
    public class ShadowButtonRenderer : Xamarin.Forms.Platform.Android.AppCompat.ButtonRenderer
    {
        public ShadowButtonRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null)
            {
                // Cleanup
            }

            if (e.NewElement != null)
            {
                Control.SetShadowLayer(5, 3, 3, Color.Black.ToAndroid());
            }
        }
    }
}