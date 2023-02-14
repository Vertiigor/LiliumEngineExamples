open LiliumEngine
open LiliumEngine.Basics
open LiliumEngine.UI
open LiliumEngine.UI.Elements
open LiliumEngine.Managment
open LiliumEngine.Audio

[<Literal>]
let EndGame = 0

// General:
let mainColor = new ColorUI(154uy, 8uy, 66uy)
let game = new Game("Title", @"<font file path>", mainColor)
let audio = new AudioPlayer(game)
let story = new StoryTelling(game)

// Characters:
let bob = new Character(game, "Bob")
let alice = new Character(game, "Alice")

let setup() =
    
    let startButton = new Button(840f, 700f, "Play", mainColor, 30u)
    startButton.Click.Add(fun evArgs -> SceneManager.LoadScene(game, "Main"))

    game.AddElementsUI("Menu", startButton)

[<EntryPoint>]
let main args =
    setup()
    
    // outputs a message in the format - characterName: "message"
    bob.Say "Nice to meet you, I'm Bob"

    alice.Say "Hello, I'm Alice"

    game.Run()

    EndGame