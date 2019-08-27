namespace Restaurant
    open System
    open System.Globalization
    open Restaurant.Types
    open Restaurant.Data
    open Restaurant.Calculator

    module View = 

        type Input =
            {Content: string}

        type Request =
            {ClientClassification: ClientClassification
             Days: DateTime list} 

        let parseDays (input: string) =
            input.Split(",")
            |>Array.map (fun d -> DateTime.ParseExact(d.Trim(), "ddMMMyyyy(ddd)", CultureInfo.InvariantCulture))
            |>Array.toList

        let validateInput input =
            match input.Content with
            | null -> Error "Invalid input"
            | "" -> Error "Invalid input"
            | _ -> Ok input

        let validateInputContent input =
            match input.Content.Split(":") with
            | s when s.Length = 2  -> Ok input
            | s when s.[0] = "Regular" || s.[0] = "Reward" -> Ok input
            | _ -> Error "Invalid"

        let getRequest classification days =
            {ClientClassification = classification; Days = parseDays days}
        
        let getRewardClassification = getRequest Premium
        let getRegularClassification = getRequest Regular

        let parseInput input = 
            try
                let parts = input.Content.Split(":")
                match parts.[0] with
                | "Regular" -> Ok (getRegularClassification parts.[1])
                | "Reward" -> Ok (getRewardClassification parts.[1])
                | _ -> Error "Fail to parse input: Client Type does not exist"

            with
            | :? System.FormatException as ex -> Error (sprintf "%s %s" "Fail to parse input! " ex.Message)
            | _ -> Error "Fail to parse input"

        let runRequest request =
            match request with
            | Ok request -> Ok((CalculateCheapestRestaurantRoomRate request.ClientClassification Restaurants request.Days))
            | Error e -> Error e

        let displayResult lastResult =
            match lastResult with
            | Ok result -> printfn "%s" result
            | Error e -> printfn "%s" e

        let run =
            while true do
                let input = System.Console.ReadLine()
                {Content = input}
                |> validateInput
                |> Result.bind validateInputContent
                |> Result.bind parseInput
                |> runRequest
                |> displayResult
                |> ignore
              
            

