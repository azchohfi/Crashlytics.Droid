# Crashlytics.Droid

Crashlytics binding project for Android

## Description

Crashlytics does not support Xamarin.Android nor does it provides a binding project that we can use with our project.

I've developed this binding project trying to solve this problem.

Any help is appreciated!

PS:
The JAR files(extracted form the AAR files) are downloaded from the official Fabric's Maven (https://maven.fabric.io/public), using a little PowerShell script (Crashlytics.Droid\Jars\get-dependencies.ps1)

## Download

NuGet: [![NuGet Badge](https://chohfi.visualstudio.com/_apis/public/build/definitions/642271bf-04a0-4044-8524-834575f246e0/10/badge)](https://www.nuget.org/packages/Crashlytics.Droid.Binding/)

MyGet: [https://www.myget.org/F/azchohfi/api/v3/index.json](https://www.myget.org/F/azchohfi/api/v3/index.json)

## How to use

Download the source, compile the binding project.
Add this to your manifest file (inside your application tag, inside your manifest tag):

	<meta-data android:name="io.fabric.ApiKey" android:value="[YOUR-API-KEY]" />


Replace the [YOUR-API-KEY] with your api key. (You can get it here: https://fabric.io/settings/organizations, select your organization, then click on the "API Key" button).

One other thing you need, since there is nothing equivalent to the crashlytics build tool for Xamarin, is a string resource named 'com.crashlytics.android.build_id', with your build_id, equivalent to your manifest's "android:versionName", or anything you want actually.

So add this to the file named Resources\values\String.xml:

	<?xml version="1.0" encoding="utf-8"?>
	<resources>
	  <string name="com.crashlytics.android.build_id">[BUILD-ID]</string>
	</resources>


Replace the [BUILD-ID] with your build id... something like 1.0.0, for example.

You also need to add permissions to access Internet, obviously.

	<uses-permission android:name="android.permission.INTERNET" />


At last, but not least, you need to add this to your activity's OnCreate method:

	IO.Fabric.Sdk.Android.Fabric.With(this, new Com.Crashlytics.Android.Crashlytics());


It's pretty strait forward.

If you want, you can add a pre-build script to your project to get the manifest's "android:versionName" and set it right into the String.xml file, but that's up to you.

## Note

This WORKS, but it won't create the project at Fabric's site, so you need to download Android Studio, download Fabric's Plugin, and follow the whole proccess of creating a Fabric's app inside Android Studio. ->Remember to use the exact same package name so the crashes sent to crashlytics actually report back to you.<-

It's a PITA, but it's the only way I've found to create the project at Fabric's site.
