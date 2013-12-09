/// Problem 15 : Replicate the elements of a list a given number of times.
/// Example in F#: 
/// 
/// > repli (List.ofSeq "abc") 3
/// val it : char list = ['a'; 'a'; 'a'; 'b'; 'b'; 'b'; 'c'; 'c'; 'c']

let repli ls n =
    ls |> List.collect ( List.replicate n)
       
let result = repli (List.ofSeq "abc") 3
printfn "%A" result 
