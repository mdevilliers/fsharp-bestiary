/// Problem 1 : Find the last element of a list.
/// Example in F#: 
/// > myLast [1; 2; 3; 4];;
/// val it : int = 4
/// > myLast ['x';'y';'z'];;
/// val it : char = 'z'

open System

let rec myLast array = 
    match array with
    | hd :: [] -> hd
    | hd :: tl -> myLast tl
    | _ -> failwith "Empty list."


let result = myLast [1; 2; 3; 4]
    
printfn "%i" result

let result' = myLast ['x';'y';'z']

printfn "%c" result'
