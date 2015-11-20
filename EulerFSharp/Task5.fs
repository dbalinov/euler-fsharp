﻿module Task5

(*
 * Smallest multiple
 *
 * 2520 is the smallest number that can be divided by each of the
 * numbers from 1 to 10 without any remainder.
 *
 * What is the smallest positive number that is evenly divisible by all
 * of the numbers from 1 to 20?
 *)

let run = 
    let commonDivider = 5 * 7 *11 * 13 * 17 * 19* 9 * 16 |> bigint

    Sequence.naturalNumbers
    |> Seq.find (fun n -> n % commonDivider = 0I)
    |> printfn "%O"