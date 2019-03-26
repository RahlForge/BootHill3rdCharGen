module Dice

open System

let dice = System.Random()
let rollDice d = dice.Next(1, d+1)