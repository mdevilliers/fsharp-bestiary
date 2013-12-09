// Learn more about F# at http://fsharp.net. See the 'F# Tutorial' project
// for more guidance on F# programming.

#load "Library1.fs"
open TypeProviderTester

// Define your library scripting code here


// Your path may vary...

#r @"../../TypeProvider/TypeProvider/bin/Debug/TypeProvider.dll"
open TypeProvider

// Type `MyType.MyProperty` on next line down.
printfn "%s" MyType.MyProperty

let thing = MyType()
let thingInnerState = thing.InnerState
 
let thing2 = MyType("Some other text")
let thing2InnerState = thing2.InnerState