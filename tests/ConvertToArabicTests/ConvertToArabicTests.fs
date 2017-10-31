module Tests

open System
open Xunit
open ConvertToArabic.ToArabic

[<Fact>]
let ``toArabic I returns 1`` () =
    Assert.Equal(toArabic("I"),1)

[<Fact>]
let ``toArabic II returns 2`` () =
    Assert.Equal(toArabic("II"),2)

[<Fact>]
let ``toArabic III returns 3`` () = 
    Assert.Equal(toArabic("III"),3)


[<Fact>]
let ``toArabic IV returns 4`` () = 
    Assert.Equal(toArabic("IV"),4)
