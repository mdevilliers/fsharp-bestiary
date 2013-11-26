/// Problem 2 : Find the last but one element of a list.
/// Example in F#: 
/// lastButOneRec [1; 2; 3; 4];;
/// val it : int = 3
/// > lastButOneRec ['a'..'z'];;
/// val it : char = 'y

open System

let rec lastButOneRec array last = 
    match array with
    | hd :: [] -> last
    | hd :: tl -> lastButOneRec tl hd
    | _ -> failwith "Empty list."

let arr1 = [1; 2; 3; 4]
let result = lastButOneRec arr1.Tail arr1.Head
    
printfn "%i" result

let arr2 = ['a'..'z']
let result' = lastButOneRec arr2.Tail arr2.Head

printfn "%c" result'

let lastButOne array =
    array |> List.rev |> List.tail |> List.head 

let result'' = lastButOne arr1
printfn "%i" result''