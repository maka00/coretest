module Tests

open System
open Xunit
open applib

[<Fact>]
let ``My test`` () =
    Assert.Equal(Say.hello "x", "Hello x")
