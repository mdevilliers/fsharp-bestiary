/// Problem 11 : Modified run-length encoding.
/// Modify the result of problem 10 in such a way that if an element has no duplicates it 
/// is simply copied into the result list. Only elements with duplicates are transferred as
/// (N E) lists. 
/// Example: 
/// * (encode-modified '(a a a a b c c a a d e e e e))
/// ((4 A) B (2 C) (2 A) D (4 E))
///  
/// Example in F#: 
/// 
/// > encodeModified <| List.ofSeq "aaaabccaadeeee"
/// val it : char Encoding list =
///   [Multiple (4,'a'); Single 'b'; Multiple (2,'c'); Multiple (2,'a');
///    Single 'd'; Multiple (4,'e')]

open System

type 'a Encoding = Multiple of int * 'a | Single of 'a

let pack ls =
    let collect x = function
        | (y::xs)::xss when x = y -> (x::y::xs)::xss
        | xss -> [x]::xss
    List.foldBack collect ls []

let encode xs =
    xs |> pack
       |> List.map (fun x -> List.length x, List.head x)

let encodeModified xs =
    xs |> encode
       |> List.map (fun (n, c) -> if n = 1 then Single c else Multiple (n,c) )     

let result = encodeModified <| List.ofSeq "aaaabccaadeeee"
printfn "%A" result 
