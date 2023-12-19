# Unity Json.NET Converters

A drop-in solution providing custom converters for Unity types to AbandonedCrypt Projects, *no configuration required*.

### The problem

Newtonsoft Json, which has been officially supported as a Unity package as  `com.unity.nuget.newtonsoft-json`, has trouble serializing most native Unity types such as `Color`, `Vector2` ,   `Vector3` and many more. This is due to self-references in the struct types Unity uses, which runs Json.NET into an infinite serialization loop.

### The solution

This package adds custom converters for these Unity types and specific converters for AbandonedCrypt projects into a project and automatically adds them to the default configuration of Newtonsoft Json in both editor and runtime. *No configuration required - plug and play.*

## Installation

1. In your package manager (`Window > Package Manager`) choose the `+`.
2. Select *"Add from git URL"*
3. Enter `https://github.com/AbandonedCrypt/unity-json-converters.git` and go.
4. You are done and ready to de-/serialize

### Supported Unity types

Currently only the following are supported, but with time, all will be added.

- Color
- Vector2
- Vector3
- Vector4

### Who is this for?

AbandonedCrypt projects. If you need custom converters for unity types you can fork this and remove all additions of non-standard custom converters.
