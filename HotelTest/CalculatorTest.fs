namespace Tests

open NUnit.Framework
open System
open Restaurant.Calculator
open Restaurant.Types
open Restaurant.Classifications

type CalculatorTest () =

    let restaurants = [
        Restaurant("Wasaki", classficationThree)
        Restaurant("Burned", classficationFour)
        Restaurant("Deux", classficationFive)
    ]

    [<SetUp>]
    member this.Setup () =
        ()

    [<Test(Description= "It should be Wasaki")>]
    member this.ItShouldBeWasaki () =
        let days = [
            DateTime(2009, 03, 16)
            DateTime(2009, 03, 17)
            DateTime(2009, 03, 18)
        ]

        let expected = "Wasaki"

        let actual = CalculateCheapestRestaurantRoomRate Regular restaurants days

        Assert.AreEqual(expected, actual)

    [<Test(Description= "It should be Burned")>]
    member this.ItShouldBeBurned () =
        let days = [
            DateTime(2009, 03, 20)
            DateTime(2009, 03, 21)
            DateTime(2009, 03, 22)
        ]

        let expected = "Burned"

        let actual = CalculateCheapestRestaurantRoomRate Regular restaurants days

        Assert.AreEqual(expected, actual)

    [<Test(Description= "It should be Deux")>]
    member this.ItShouldBeDeux () =
        let days = [
            DateTime(2009, 03, 26)
            DateTime(2009, 03, 27)
            DateTime(2009, 03, 28)
        ]

        let expected = "Deux"

        let actual = CalculateCheapestRestaurantRoomRate Premium restaurants days

        Assert.AreEqual(expected, actual)
