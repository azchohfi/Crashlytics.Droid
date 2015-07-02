using Java.Lang;

// ReSharper disable once CheckNamespace
namespace Com.Crashlytics.Android.Core
{
    public partial class CrashlyticsCore
    {
        public override int CompareTo(Object obj)
        {
            return CompareTo((IO.Fabric.Sdk.Android.Kit)obj);
        }
    }
}