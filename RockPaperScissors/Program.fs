// Rock Paper Scissors!
open System


let RPS3() = 
    
    let moves = [|"Rock";"Paper";"Scissor"|]

    printf "Lets Play, Rock Paper Scissors!\n\n"
    printf "Select how many games you want to play : 1, 2 or 3?\n" 
    let x = System.Console.ReadLine()
    let num = System.Int32.Parse(x)

    let rec Game(n : int) =
        
        let random = new System.Random()
        let computer = moves.[random.Next(moves.Length)]
        
        printf "Enter: Rock, Paper or Scissor: \n"
        let player = System.Console.ReadLine()
        match (player, computer) with
        | ("Rock", "Paper")
        | ("Paper", "Scissor")
        | ("Scissor", "Rock") -> printfn "Computer Wins!"
        | ("Rock", "Scissor")
        | ("Paper", "Rock")
        | ("Scissor", "Paper") -> printfn "Player Wins!"
        | (player, computer) -> printfn "Its a tie!"
        
        printfn "The computer picked %s\n" computer

        match n with
        | 1 -> "The game has ended. Thanks for playing\n"
        | n -> Game(n - 1)

    printfn "%s" (Game num)


[<EntryPoint>]
let main argv =

    RPS3()


    0 // return an integer exit code
