namespace ConvertToArabic

module ToArabic =
    type RomanArabic = { Roman : string ; Arabic : int }

    let conversions = [ { Roman = "III" ; Arabic = 3 } ; 
                        { Roman = "II"  ; Arabic = 2 } ; 
                        { Roman = "IV"  ; Arabic = 4 } ;
                        { Roman = "V"   ; Arabic = 5 } ;
                        { Roman = "I"   ; Arabic = 1 } ;
                      ]
    
    let toArabic ( numeral : string ) : int =

        let rec convert (numeral : string, l : RomanArabic list ) : int list = 
            match l with 
                | []     -> [0] 
                | x :: xs -> if numeral.StartsWith ( x.Roman.Substring(0, x.Roman.Length) ) then 
                                [x.Arabic] 
                             else
                                 [0] @ convert (numeral, xs)

                              
        let rval = List.sum( convert ( numeral, conversions ))

        if rval = 0 then 0 
        else rval