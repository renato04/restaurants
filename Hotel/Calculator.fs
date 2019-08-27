namespace Restaurant
open System
open Restaurant.Types

module Calculator =
    type CheapestRestaurant =
        {Name: string
         Rate: int}

    let getCheapest (day:DateTime) (client: ClientClassification) (restaurants: Restaurant list) =
        restaurants
        |> List.map (fun h -> {Name = h.Name; Rate = h.GetFee day client})
        |> List.minBy (fun i -> i.Rate)

    let CalculateCheapestRestaurantRoomRate (client: ClientClassification) (restaurants: Restaurant list) (days: DateTime list) =
        let cheapest =   days
                            |> List.map (fun day ->  (getCheapest day client restaurants))
                            |> List.minBy (fun i -> i.Rate)
        cheapest.Name




