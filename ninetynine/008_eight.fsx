/// Problem 8 : Eliminate consecutive duplicates of list elements.
/// Example in F#: 
/// 
/// > compress ["a";"a";"a";"a";"b";"c";"c";"a";"a";"d";"e";"e";"e";"e"];;
/// val it : string list = ["a";"b";"c";"a";"d";"e"]

open System

let compress ls =
    let rec loop acc ls = 
        match ls with
        | hd :: hd2 :: tl when hd = hd2 -> loop acc (hd2::tl)
        | hd :: tl  -> loop (hd::acc) tl
        | _ -> acc |> List.rev
    loop [] ls

let result = compress ["a";"a";"a";"a";"b";"c";"c";"a";"a";"d";"e";"e";"e";"e"]
printfn "%A" result 
