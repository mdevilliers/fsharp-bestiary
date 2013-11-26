/// Problem 4 : Find the number of elements of a list.
/// Example in F#: 
/// > myLength [123; 456; 789];;
/// val it : int = 3
/// > myLength <| List.ofSeq "Hello, world!"
/// val it : int = 13 

open System

let myLength xs =
    List.length xs

let arr1 = [123; 456; 789]
let result = myLength arr1
    
printfn "%i" result

let arr2 = List.ofSeq "Hello, world!"
let result' = myLength arr2

printfn "%i" result'