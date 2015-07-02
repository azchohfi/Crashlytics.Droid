# Crashlytics.Droid

Crashlytics binding project for Android

Crashlytics does not support Xamarin.Android nor does it provides a binding project that we can use with our project.

I've developed this binding project trying to solve this problem.

Any help is appreciated!

PS:
The JAR files were taken from the public Crashlytics files from this URL:
https://twittersdk.artifactoryonline.com/twittersdk/public/

Actually there are no JAR files there, only ARR, but there is no aparent reason for this, so I extracted the JAR files from each of the ARR files and made the binding project.

---------HOW TO USE---------

Download the source, compile the binding project.
Add this to your manifest file (inside your application tag, inside your manifest tag):
´´´
<meta-data android:name="com.crashlytics.ApiKey" android:value="[YOUR-API-KEY]" />
´´´
Replace the [YOUR-API-KEY] with your api key. (You can get it here: https://fabric.io/settings/organizations, selection your organization, then clicking on the "API Key" button).

One other thing you need, since there is no equivalent to the crashlytics build tool for Xamarin, is a string resource named 'com.crashlytics.android.build_id', with your build_id, equivalent to your manifest's "android:versionName", or anything you want actually.

So add this to the file named Resources\values\String.xml:
´´´
<?xml version="1.0" encoding="utf-8"?>
<resources>
  <string name="com.crashlytics.android.build_id">[BUILD-ID]</string>
</resources>
´´´
Replace the [BUILD-ID] with your build id... something like 1.0.0, for example.

You also need to add permissions to access Internet, obviously.
´´´
	<uses-permission android:name="android.permission.INTERNET" />
´´´

It's pretty strait forward.

If you want, you can add a pre-build script to your project to get the manifest's "android:versionName" and set it right into the String.xml file, but that's up to you.
