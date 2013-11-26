/// Problem 5 : Reverse a list.
/// Example in F#: 
/// reverse <| List.ofSeq ("A man, a plan, a canal, panama!")
/// val it : char list =
///  ['!'; 'a'; 'm'; 'a'; 'n'; 'a'; 'p'; ' '; ','; 'l'; 'a'; 'n'; 'a'; 'c'; ' ';
///   'a'; ' '; ','; 'n'; 'a'; 'l'; 'p'; ' '; 'a'; ' '; ','; 'n'; 'a'; 'm'; ' ';
///   'A']
/// > reverse [1,2,3,4];;
/// val it : int list = [4; 3; 2; 1]

open System

let reverse xs =
    List.rev xs

let arr1 = List.ofSeq ("A man, a plan, a canal, panama!")
let result = reverse arr1
    
printfn "%O" result 

let arr2 = [1;2;3;4;]
let result' = reverse arr2

printfn "%O" result'

let reverseAcc xs =
    List.fold (fun acc x -> x::acc ) [] xs

let result'' = reverseAcc arr2
printfn "%O" result''