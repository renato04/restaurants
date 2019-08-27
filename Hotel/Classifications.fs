namespace Restaurant
    open System
    open Restaurant.Types

    module Classifications = 

        let classficationThree (date: DateTime, client: ClientClassification)  =
            match date.DayOfWeek with
            | DayOfWeek.Saturday | DayOfWeek.Sunday -> 
                match client with
                | Regular -> 90
                | Premium -> 80
            | _ -> 
                match client with
                | Regular -> 110
                | Premium -> 80

        let classficationFour (date: DateTime, client: ClientClassification)  =
            match date.DayOfWeek with
            | DayOfWeek.Saturday | DayOfWeek.Sunday -> 
                match client with
                | Regular -> 60
                | Premium -> 50
            | _ -> 
                match client with
                | Regular -> 160
                | Premium -> 110

        let classficationFive (date: DateTime, client: ClientClassification)  =
            match date.DayOfWeek with
            | DayOfWeek.Saturday | DayOfWeek.Sunday -> 
                match client with
                | Regular -> 150
                | Premium -> 40
            | _ -> 
                match client with
                | Regular -> 220
                | Premium -> 100

