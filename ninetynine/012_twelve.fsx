/// Problem 12 : Decode a run-length encoded list.
/// Given a run-length code list generated as specified in problem 11. Construct its 
/// uncompressed version.
///  
/// Example in F#: 
/// 
/// > decodeModified 
///     [Multiple (4,'a');Single 'b';Multiple (2,'c');
///      Multiple (2,'a');Single 'd';Multiple (4,'e')];;
/// val it : char list =
///   ['a'; 'a'; 'a'; 'a'; 'b'; 'c'; 'c'; 'a'; 'a'; 'd'; 'e'; 'e'; 'e'; 'e']

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

let decodeModified xs =
    let expand  = function
        | Multiple (x,c) -> List.replicate x c
        | Single (c)-> [c]
    xs |> List.collect expand

let result = decodeModified  [ Multiple (4,'a'); Single 'b'; Multiple (2,'c'); Multiple (2,'a'); Single 'd'; Multiple (4,'e')]
printfn "%A" result 
