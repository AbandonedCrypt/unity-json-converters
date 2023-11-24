# Unity Json.NET Converters

A drop-in solution for custom converters for Unity types, no configuration required.


## The issue

Newtonsoft Json, which has been officially supported as a Unity package as  `com.unity.nuget.newtonsoft-json`, has trouble serializing most native Unity types such as `Color`, 

`Vector2` ,   `Vector3` and many more.


## The solution

This package adds custom converters for these Unity types into your project and automatically adds them to the default configuration of Newtonsoft Json in both editor and runtime. No configuration required - plug and play.


## Installation

1. In your package manager (`Window/Package Manager`) choose the +.
2. Select "Add from git URL"
3. Enter ``
4. You are done and ready to de-/serialize

## Supported Unity types

Currently only the following are supported, but with time, all will be added.

- Color
