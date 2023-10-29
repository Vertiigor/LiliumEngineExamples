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

let mainColor = new ColorUI(0uy, 0uy, 0uy)

// main variable, which is responsible for initializing and starting the game. Constructor includes(game's name, font file, UI's default color)
// ойынды инициализациялауға және бастауға жауап беретін негізгі айнымалы. Конструктор кіреді (ойынның аты, қаріп файлы, UI әдепкі түсі)
// основная переменная, отвечающая за инициализацию и запуск игры. Конструктор включает в себя (название игры, файл шрифта, цвет пользовательского интерфейса по умолчанию)
let game = new Game("Title", @"<font file path>", mainColor)

// variable responsible for interaction with the audio system
// аудио жүйемен өзара әрекеттесу үшін жауапты айнымалы
// переменная, отвечающая за взаимодействие с аудиосистемой
let audio = new AudioPlayer(game)

// variable responsible for controlling the plot and design
// сюжетті және дизайнды басқаруға жауапты айнымалы
// переменная, отвечающая за управление сюжетом и дизайном
let story = new StoryTelling(game)

let setup() =
    0

[<EntryPoint>]
let main args =
    setup()

    game.Run()

    EndGame
