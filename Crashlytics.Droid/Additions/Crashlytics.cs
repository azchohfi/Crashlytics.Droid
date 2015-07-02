using Java.Lang;

// ReSharper disable once CheckNamespace
namespace Com.Crashlytics.Android
{
    public partial class Crashlytics
    {
        public override int CompareTo(Object obj)
        {
            return CompareTo((IO.Fabric.Sdk.Android.Kit)obj);
        }
    }
}