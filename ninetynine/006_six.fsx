/// Problem 6 : Find out whether a list is a palindrome.
/// Example in F#: 
/// A palindrome can be read forward or backward; e.g. (x a m a x).
/// 
/// Example in F#: 
/// > isPalindrome [1;2;3];;
/// val it : bool = false
/// > isPalindrome <| List.ofSeq "madamimadam";;
/// val it : bool = true
/// > isPalindrome [1;2;4;8;16;8;4;2;1];;
/// val it : bool = true

open System

let reverse xs =
    List.rev xs

let isPalindrome xs =
    xs = reverse xs

let result = isPalindrome [1;2;3]
printfn "%O" result 

let result' = isPalindrome <| List.ofSeq "madamimadam"
printfn "%O" result'

let result'' = isPalindrome <| List.ofSeq "madamimadam"
printfn "%O" result''

let result''' = isPalindrome [1;2;4;8;16;8;4;2;1]
printfn "%O" result'''