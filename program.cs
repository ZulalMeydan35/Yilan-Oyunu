using SnakeGame.ConsoleApp;
using System.Drawing;


Console.CursorVisible = false;

int borderWidth = 50, borderHeigth = 20;
int borderX = 20, borderY = 5;

var message = "Oyuna Başlamak İçin Herhangi Bir Tuşa Basın :)";

Console.SetCursorPosition((Console.WindowWidth - message.Length) / 2, Console.CursorTop + 5);
Console.WriteLine(message);

Console.ReadKey();
Console.Clear();

Snake snake = new(snakeChar: 'O',
                  snakePoint: new Point(5, 5),
                  snakeInitialLength: 2,
                  new Rectangle(borderX, borderY, borderWidth, borderHeigth));

snake.SetSnakeChar('■');
snake.SetInitialSnakeLength(5);
snake.SetFoodChar('■');

await snake.Run();
