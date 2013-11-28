/// Problem 9 : Pack consecutive duplicates of list elements into sublists.
/// Example in F#: 
/// 
/// > pack ['a'; 'a'; 'a'; 'a'; 'b'; 'c'; 'c'; 'a'; 
///         'a'; 'd'; 'e'; 'e'; 'e'; 'e']
/// val it : char list list =
///  [['a'; 'a'; 'a'; 'a']; ['b']; ['c'; 'c']; ['a'; 'a']; ['d'];
///   ['e'; 'e'; 'e'; 'e']]

open System

let pack ls =
    let collect x = function
        | (y::xs)::xss when x = y -> (x::y::xs)::xss
        | xss -> [x]::xss
    List.foldBack collect ls []

let result = pack ['a'; 'a'; 'a'; 'a'; 'b'; 'c'; 'c'; 'a'; 'a'; 'd'; 'e'; 'e'; 'e'; 'e']
printfn "%A" result 
