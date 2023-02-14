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
    
    // Create a Button at coordinates: X - 840, Y - 700, with the text "Play", with mainColor and character size of 30
    let startButton = new Button(840f, 700f, "Play", mainColor, 30u)

    // Create a Label at coordinates: X - 650, Y - 600, with the text "Sample Text", with color(r:190, g:30, b:120) and character size of 35
    let label = new Label(650f, 600f, "Sample Text", new ColorUI(190uy, 30uy, 120uy), 35u)

    // Create a ImageBox at coordinates: X - 690, Y - 200, contains the image located at the specified path
    let image = new ImageBox(690f, 200f, @"<image file path>")

    // Create a CheckBox at coordinates: X - 800, Y - 800, with the text "Label", with mainColor and character size of 30
    let check = new CheckBox(800f, 800f, "Label", mainColor, 30u)

    // adding these elements to "Menu" scene
    game.AddElementsUI("Menu", startButton, label, image, check)

[<EntryPoint>]
let main args =
    setup()

    game.Run()

    EndGame