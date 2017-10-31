module Tests

open System
open Xunit
open ConvertToArabic.ToArabic


[<Fact>]
let ``toArabic V returns 5`` () =
    Assert.Equal(toArabic("V"), 5)