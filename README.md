scriptcs-adder
============

# Adder Script Pack

## What is it?
A script pack that allows you to perform additions.

## Usage
This is just useful for the acceptance tests.

```csharp
var adder = Require<Adder>();

var value = adder.Add(3, 4);

Debug.Assert(value == 7);
```