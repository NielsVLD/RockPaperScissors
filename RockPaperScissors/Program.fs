// Learn more about F# at http://fsharp.org

open System



let RPS() = 
    
    let combos = [|"Rock";"Paper";"Scissors"|]
    let x = System.Console.ReadLine()
    let rnd = System.Random().Next(0,2)
    //let isInt x = box (int x) :? int

    if(0 <= (int x) && (int x) <= 2) then
        let computer = combos.[rnd]
        let player = combos.[(int x)]

        if(player = computer) then
            printf "Its a tie!"
        if(player = "Rock" && computer = "Paper") then
            printf "Computer wins!"
        if(player = "Rock" && computer = "Scissors") then
            printf "You win!"
        if(player = "Paper" && computer = "Rock") then
            printf "You win!"
        if(player = "Paper" && computer = "Scissors") then
            printf "Computer wins!"
        if(player = "Scissors" && computer = "Rock") then
            printf "Computer wins!"
        if(player = "Scissors" && computer = "Paper") then
            printf "You win!"
        printfn "\nYou picked %s." player
        printfn "The computer picked %s." computer
    else
        printf "\nNumber is not between 0 and 2.\n"
       
    


[<EntryPoint>]
let main argv =
    printf "Lets Play, Rock Paper Scissors!\n\n"
    printf "Rules: press a number to pick Rock, Paper or Scissors and see if you can win!\n\n0 = Rock\n1 = Paper\n2 = Scissors\n"
    printf "Please enter a number (0, 2): "
    RPS()



    0 // return an integer exit code
