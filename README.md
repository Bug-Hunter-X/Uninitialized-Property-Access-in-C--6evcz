# Uninitialized Property Access in C#.NET

This repository demonstrates a common error in C#: accessing a property before it has been explicitly assigned a value.  Uninitialized properties will have default values based on their type, but this can lead to unexpected behavior and bugs if not handled carefully.

## The Problem

The `bug.cs` file showcases the issue.  The `MyProperty` is declared but not initialized before it's read within `MyMethod`. This can lead to unexpected results depending on the property's type and how it's used.

## The Solution

The `bugSolution.cs` demonstrates a corrected version.  The property is either assigned a default value in the declaration or within the constructor, ensuring it has a defined value before being accessed.