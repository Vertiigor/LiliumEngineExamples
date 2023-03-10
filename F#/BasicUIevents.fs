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

let setup() =
    
    let startButton = new Button(840f, 700f, "Play", mainColor, 30u)
    // set an event to the button, when clicked, the scene switches to "Main"
    startButton.Click.Add(fun evArgs -> SceneManager.LoadScene(game, "Main"))

    let check = new CheckBox(800f, 800f, "Label", mainColor, 30u)
    // set an event to the checkbox, if after clicking the value is true, then a message will be displayed in the console
    check.Click.Add(fun evArgs -> if check.Value = true then printf "I was checked!")

    let quitButton = new Button(840f, 900f, "Quit", mainColor, 30u)
    // set an event to the button, when clicked, the game will end
    quitButton.Click.Add(fun evArgs -> game.Close(game, evArgs))

    // adding these elements to "Menu" scene
    game.AddElementsUI("Menu", startButton, check, quitButton)

[<EntryPoint>]
let main args =
    setup()
    
    game.Run()

    EndGame