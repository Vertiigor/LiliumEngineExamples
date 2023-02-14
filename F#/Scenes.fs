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

// Scenes:
// adding a scene with the name "Options" and an empty array of UI elements to the general list of game scenes
let optionsScene = new Scene(game, "Options", Array.empty)

let setup() =
    
    let startButton = new Button(840f, 700f, "Play", mainColor, 30u)
    // set an event to the button, when clicked, the scene switches to "Main"
    startButton.Click.Add(fun evArgs -> SceneManager.LoadScene(game, "Main"))

    let check = new CheckBox(800f, 800f, "Label", mainColor, 30u)
    // set an event to the checkbox, if after clicking the value is true, then a message will be displayed in the console
    check.Click.Add(fun evArgs -> if check.Value = true then printf "I was checked!")

    let optionsButton = new Button(1140f, 700f, "Options", mainColor, 30u)
    // set an event to the button, when clicked, the scene switches to "Options"
    optionsButton.Click.Add(fun evArgs -> SceneManager.LoadScene(game, "Options"))

    // adding these elements to "Menu" scene
    game.AddElementsUI("Menu", startButton, optionsButton)

    // adding CheckBox to "Options" scene
    game.AddElementsUI("Options", check)

[<EntryPoint>]
let main args =
    setup()
    
    game.Run()

    EndGame
