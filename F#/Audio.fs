open LiliumEngine
open LiliumEngine.Basics
open LiliumEngine.UI
open LiliumEngine.UI.Elements
open LiliumEngine.Managment
open LiliumEngine.Audio

[<Literal>]
let EndGame = 0

// General:
// Жалпы:
// Общий:
let mainColor = new ColorUI(154uy, 8uy, 66uy)
let game = new Game("Title", @"<font file path>", mainColor)
let audio = new AudioPlayer(game)
let story = new StoryTelling(game)

let setup() =
    
    let startButton = new Button(840f, 700f, "Play", mainColor, 30u)
    startButton.Click.Add(fun evArgs -> SceneManager.LoadScene(game, "Main"))

    game.AddElementsUI("Menu", startButton)

[<EntryPoint>]
let main args =

    // !!! THE FOLLOWING METHODS SHOULD BE CALLED BEFORE game.Run()
    // !!! ТӨМЕНДЕГІ ӘДІСТЕР Game.Run() БҰРЫН ШАҚЫРУ КЕРЕК
    // !!! СЛЕДУЮЩИЕ МЕТОДЫ ДОЛЖНЫ БЫТЬ ВЫЗОВАНЫ ПЕРЕД игрой.Run()
    setup()
    
    story.Write "And suddenly the music started playing..."

    // Launch music on the specified file. The volume is set from 0 to 100.
    // As well as the looping flag (whether the song will be played again after the end), by default False.

    // Көрсетілген файлда музыканы іске қосыңыз. Дыбыс деңгейі 0-ден 100-ге дейін орнатылған.
     // Сонымен қатар циклдік жалауша (ән аяқталғаннан кейін қайта ойнатылады ма), әдепкі бойынша False.

     // Запускаем музыку из указанного файла. Громкость устанавливается от 0 до 100.
     // А также флаг зацикливания (будет ли песня воспроизводиться снова после окончания), по умолчанию False.
    audio.PlayMusic(@"music file path", 100, true)

    game.Run()

    EndGame
