using System;
using Android.Graphics;
using Neudesic.AgileDefender.Droid.Renderers;
using Neudesic.AgileDefender.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(LabelWithCustomFont), typeof(LabelWithCustomFontRenderer))]
namespace Neudesic.AgileDefender.Droid.Renderers
{
    public class LabelWithCustomFontRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            try
            {
                var labelWithCustomFont = e.NewElement;
                if (labelWithCustomFont != null)
                {
                    var fontPath = labelWithCustomFont.FontFamily;
                    var label = Control;
                    var font = Typeface.CreateFromAsset(Forms.Context.Assets, fontPath);
                    label.Typeface = font;
                }
            }
            catch (Exception)
            {
                // Ignore any errors (like font file was not found, etc.) and let XF render using default
            }
        }
    }
}