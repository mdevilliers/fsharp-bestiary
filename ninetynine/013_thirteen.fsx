/// Problem 13 : Run-length encoding of a list (direct solution).
/// Implement the so-called run-length encoding data compression method directly. I.e. 
/// don't explicitly create the sublists containing the duplicates, as in problem 9, 
/// but only count them. As in problem P11, simplify the result list by replacing the 
/// singleton lists (1 X) by X.
///  
/// Example: 
/// * (encode-direct '(a a a a b c c a a d e e e e))
/// ((4 A) B (2 C) (2 A) D (4 E))
///  
/// Example in F#: 
/// 
/// > encodeDirect <| List.ofSeq "aaaabccaadeeee"
/// val it : char Encoding list =
///   [Multiple (4,'a'); Single 'b'; Multiple (2,'c'); Multiple (2,'a');
///    Single 'd'; Multiple (4,'e')]

type 'a Encoding = Multiple of int * 'a | Single of 'a

let encodeDirect ls =
    let collect x = function
        | [] -> [Single x]
        | Single y::xs when x = y -> 
            //printfn "Single y::xs -> x : %O y : %O " x y
            Multiple (2, x)::xs
        | Single _::_ as xs -> Single x::xs
        | Multiple(n,y)::xs when x = y ->  
            //printfn "Multiple(n,y)::xs -> x : %O y : %O " x y
            Multiple (n+1, x)::xs
        | xs -> Single x::xs
    List.foldBack collect ls []

let result = encodeDirect <| List.ofSeq "aaaabccaadeeee"
printfn "%A" result 
