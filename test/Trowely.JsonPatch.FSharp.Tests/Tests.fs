module Tests

open Expecto

[<Tests>]
let tests = testList "Trowely Tests" [  
  testCase "A simple test" <| fun () ->
    let expected = 4
    Expect.equal expected (2+2) "2+2 = 4"
] 