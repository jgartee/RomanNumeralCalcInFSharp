namespace ConvertToArabic

module ToArabic =
    type RomanArabic = { Roman : string ; Arabic : int }

    let conversions = [ { Roman = "III" ; Arabic = 3 } ; 
                        { Roman = "II"  ; Arabic = 2 } ; 
                        { Roman = "IV"   ; Arabic = 4 } ;
                        { Roman = "I"   ; Arabic = 1 } ;
                      ]

    let result = [int32]
    
    let toArabic ( numeral : string ) : int =

        let rNumeral = numeral

        let rec convert (rNumeral : string, l : RomanArabic list ) : int list = 
            match l with 
                | []     -> [] 
                | x :: xs -> if numeral.StartsWith ( x.Roman.Substring(0, x.Roman.Length) ) then 
                                [x.Arabic] 
                             else
                                 [] @ convert (rNumeral, xs)

                              
        List.sum( convert ( numeral, conversions ))