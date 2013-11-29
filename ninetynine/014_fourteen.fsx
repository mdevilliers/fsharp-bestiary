/// Problem 14 : Duplicate the elements of a list.
/// Example in F#: 
/// 
/// > dupli [1; 2; 3]
/// [1;1;2;2;3;3]


let dupli ls =
    ls |> List.map (fun x -> [x;x;])
       |> List.concat

let result = dupli [1; 2; 3]
printfn "%A" result 

let dupli' ls =
    ls |> List.collect (fun x -> [x;x;])


let result' = dupli' [1; 2; 3]
printfn "%A" result'
