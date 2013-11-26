///  Problem 3 : Find the K'th element of a list. The first element in the list is number 1.
/// Example in F#: 
/// > elementAt [1; 2; 3] 2;;
/// val it : int = 2
/// > elementAt (List.ofSeq "fsharp") 5;;
/// val it : char = 'r'

open System


let elementAt xs n =
    List.nth xs (n-1)  


let arr1 = [1; 2; 3; 4]
let result = elementAt arr1 2
    
printfn "%i" result

let arr2 = List.ofSeq "fsharp"
let result' = elementAt arr2 5

printfn "%c" result'