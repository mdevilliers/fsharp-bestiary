/// Problem 2 : Find the last but one element of a list.
/// Example in F#: 
/// lastButOneRec [1; 2; 3; 4];;
/// val it : int = 3
/// > lastButOneRec ['a'..'z'];;
/// val it : char = 'y

open System

let lastButOneRec array = 
    let rec lbo arr last = 
        match arr with
        | [] -> last
        | hd :: [] -> last
        | hd :: tl -> lbo tl hd
        
    match array with
    | hd :: [] -> hd
    | hd :: tl -> lbo tl hd
    | _ -> failwith "Empty list."


let arr1 = [1; 2; 3; 4]
let result = lastButOneRec arr1
    
printfn "%i" result

let arr2 = ['a'..'z']
let result' = lastButOneRec arr2

printfn "%c" result'

let lastButOne array =
    array |> List.rev |> List.tail |> List.head 

let result'' = lastButOne arr1
printfn "%i" result''