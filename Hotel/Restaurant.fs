namespace Restaurant.Types 
    open System

    type ClientClassification =
        |Regular
        |Premium

    type Restaurant(name: string, classificationFn) =
        let name = name
        let classification = classificationFn
    
        member this.Name with get() = name
    
        member this.GetFee (date: DateTime) (client: ClientClassification) : int =
            classification(date, client)


