/// Problem 7 : Flatten a nested list structure.
/// Example in F#: 
/// A palindrome can be read forward or backward; e.g. (x a m a x).
/// 
/// Example in F#: 
/// Example in F#: 
/// 
type 'a NestedList = List of 'a NestedList list | Elem of 'a
///
/// > flatten (Elem 5);;
/// val it : int list = [5]
/// > flatten (List [Elem 1; List [Elem 2; List [Elem 3; Elem 4]; Elem 5]]);;
/// val it : int list = [1;2;3;4;5]
/// > flatten (List [] : int NestedList);;
/// val it : int list = []

open System

let flatten ls =
   let rec flt acc = function
        | Elem x -> x::acc
        | List xs -> List.foldBack (fun x acc -> flt acc x ) xs acc
   flt [] ls 

let result = flatten (Elem 5)
printfn "%O" result 

let result' = flatten (List [Elem 1; List [Elem 2; List [Elem 3; Elem 4]; Elem 5]])
printfn "%O" result'

let result'' = flatten (List [] : int NestedList)
printfn "%O" result''
