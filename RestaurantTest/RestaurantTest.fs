namespace Tests

open NUnit.Framework
open System
open Restaurant.Classifications
open Restaurant .Types

type RestaurantTest () =

    [<Test(Description= "When classification three and weekday and regular should be 110 ")>]
    member this.WhenClassificationThreeWeekdayRegularShouldBe110 () =
        let day = DateTime(2019, 08, 26 )
        let client = Regular
        let expected = 110

        let actual = classficationThree(day, client)

        Assert.AreEqual(expected, actual)
        
    [<Test(Description= "When classification three and weekend and regular should be 90 ")>]
    member this.WhenClassificationThreeWeekdayRegularShouldBe90 () =
        let day = DateTime(2019, 08, 25 )
        let client = Regular
        let expected = 90

        let actual = classficationThree(day, client)

        Assert.AreEqual(expected, actual)

    [<Test(Description= "When classification three and weekend and reward should be 80")>]
    member this.WhenClassificationThreeWeekdayRewardShouldBe90 () =
        let day = DateTime(2019, 08, 26 )
        let client = Premium
        let expected = 80

        let actual = classficationThree(day, client)

        Assert.AreEqual(expected, actual)

    [<Test(Description= "When classification three and weekday and reward should be 80 ")>]
    member this.WhenClassificationThreeWeekendRewardShouldBe80 () =
        let day = DateTime(2019, 08, 25 )
        let client = Premium
        let expected = 80

        let actual = classficationThree(day, client)

        Assert.AreEqual(expected, actual)

    [<Test(Description= "When classification four and weekday and regular should be 160")>]
    member this.WhenClassificationFourWeekdayRegularShouldBe160 () =
        let day = DateTime(2019, 08, 26 )
        let client = Regular
        let expected = 160

        let actual = classficationFour(day, client)

        Assert.AreEqual(expected, actual)

    [<Test(Description= "When classification four and weekend and regular should be 60 ")>]
    member this.WhenClassificationFourWeekendRegularShouldBe60 () =
        let day = DateTime(2019, 08, 25 )
        let client = Regular
        let expected = 60

        let actual = classficationFour(day, client)

        Assert.AreEqual(expected, actual)

    [<Test(Description= "When classification four and weekday and reward should be 110")>]
    member this.WhenClassificationFourWeekdayRewardShouldBe160 () =
        let day = DateTime(2019, 08, 26 )
        let client = Premium
        let expected = 110

        let actual = classficationFour(day, client)

        Assert.AreEqual(expected, actual)

    [<Test(Description= "When classification four and weekend and reward should be 50 ")>]
    member this.WhenClassificationFourWeekendRewardShouldBe50 () =
        let day = DateTime(2019, 08, 25 )
        let client = Premium
        let expected = 50

        let actual = classficationFour(day, client)

        Assert.AreEqual(expected, actual)

    [<Test(Description= "When classification five and weekday and regular should be 220")>]
    member this.WhenClassificationFiveWeekdayRegularShouldBe220 () =
        let day = DateTime(2019, 08, 26 )
        let client = Regular
        let expected = 220

        let actual = classficationFive(day, client)

        Assert.AreEqual(expected, actual)

    [<Test(Description= "When classification five and weekend and regular should be 150 ")>]
    member this.WhenClassificationFiveWeekendRegularShouldBe150 () =
        let day = DateTime(2019, 08, 25 )
        let client = Regular
        let expected = 150

        let actual = classficationFive(day, client)

        Assert.AreEqual(expected, actual)

    [<Test(Description= "When classification five and weekday and reward should be 100")>]
    member this.WhenClassificationFiveWeekdayRewardShouldBe100 () =
        let day = DateTime(2019, 08, 26 )
        let client = Premium
        let expected = 100

        let actual = classficationFive(day, client)

        Assert.AreEqual(expected, actual)

    [<Test(Description= "When classification five and weekend and regular should be 40 ")>]
    member this.WhenClassificationFiveWeekendRewardShouldBe40 () =
        let day = DateTime(2019, 08, 25 )
        let client = Premium
        let expected = 40

        let actual = classficationFive(day, client)

        Assert.AreEqual(expected, actual)



