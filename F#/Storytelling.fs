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
    // !!! ТӨМЕНДЕГІ ӘДІСТЕР game.Run() БҰРЫН ШАҚЫРУ КЕРЕК
    // !!! СЛЕДУЮЩИЕ МЕТОДЫ ДОЛЖНЫ БЫТЬ ВЫЗОВАНЫ ПЕРЕД game.Run()
    setup()
    
    // Displays impersonal text without quotes. Can be used as the words of the author or thoughts of the hero
    // Жеке емес мәтінді тырнақшасыз көрсетеді. Автордың сөзі немесе кейіпкердің ойы ретінде қолдануға болады
    // Отображает обезличенный текст без кавычек. Могут быть использованы как слова автора, так и мысли героя.
    story.Write "This is the text of the author - will be shown without quotes."

    // Stops updating the dialog thread for the specified number of seconds
    // Диалогтың ағынының жаңартылуын көрсетілген секунд санына тоқтатады
    // Останавливает обновление диалогового потока на указанное количество секунд
    story.WaitFor 10u

    story.Write "You've waited for 10 seconds."

    // Loads an illustration into the scene from the specified file
    // Көрсетілген файлдан көрініске иллюстрацияны жүктейді
    // Загружает иллюстрацию в сцену из указанного файла
    story.LoadIllustration @"<image file path>"

    // Displays options on the screen. Variants are written on one line and separated by "|".
    // This is followed by the definitions of the lambda function, respectively, for each

    // Экранда опцияларды көрсетеді. Варианттар бір жолға жазылады және «|» арқылы бөлінеді.
    // Осыдан кейін әрқайсысы үшін сәйкесінше ламбда функциясының анықтамалары келеді

    // Отображает параметры на экране. Варианты пишутся в одну строку и разделяются знаком «|».
    // Далее следуют определения лямбда-функции соответственно для каждого
    story.ShowMenu("First|Second",
        fun() -> story.Write "You clicked on the first!"
        ,
        fun() -> story.Write "You clicked on the second!")

    game.Run()

    EndGame
