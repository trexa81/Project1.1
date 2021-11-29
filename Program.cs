// See https://aka.ms/new-console-template for more information
// new repo
//Console.WriteLine("Hello, World!");
//var x = Console.ReadLine();
//Console.WriteLine("нажмите любую кнопку");
//Console.WriteLine(x);
//Console.ReadKey();
/*
Просмотр файловой структуры
Поддержка копирование файлов, каталогов
Поддержка удаление файлов, каталогов
Получение информации о размерах, системных атрибутов файла, каталога
Вывод файловой структуры должен быть постраничным

 */



//string dirName = @"D:\ExampleDir";
//Directory.Delete(dirName, true); //удаляем перед созданием ранее созданную папку (директорию)

//Directory.CreateDirectory(Path.Combine(@"D:\", "ExampleDir"));
//string workDir = @"D:\ExampleDir";

//Console.WriteLine(Directory.Exists(workDir)); // Проверяет, существует ли заданная директория

//string notesDir = Path.Combine(workDir, "Notes"); // "D:\ExampleDir\Notes"

//Directory.CreateDirectory(notesDir); // Создаем вложенную директорию

//string noteText = "Этот файл создан автоматически";

//string notePath = Path.Combine(notesDir, "Note 1.txt"); // "D:\ExampleDir\Notes\Note 1.txt"

//File.WriteAllText(notePath, noteText);

//string copyOfNotePath = Path.Combine(workDir, "Copy of Note 1.txt"); // "D:\ExampleDir\Copy of Note 1.txt"
//File.Copy(notePath, copyOfNotePath); // Копируем созданную заметку в "D:\ExampleDir\Copy of Note 1.txt"

//Console.WriteLine(File.Exists(copyOfNotePath)); // Проверяет, существует ли заданный файл

//File.Move(copyOfNotePath, Path.Combine(notesDir, "Note 2.txt"));
//// Перемещаем заметку в "D:\ExampleDir\Notes\Note 2.txt"

//// Создаем директорию "D:\ExampleDir\Documents" и перемещаем в нее директорию Notes
//Directory.CreateDirectory(Path.Combine(workDir, "Documents"));
//Directory.Move(notesDir, Path.Combine(workDir, "Documents", "Notes"));

// Перечень всех файлов и папок, вложенных в каталог ( и все вложения /*, SearchOption.AllDirectories*/)
string[] entries = Directory.GetFileSystemEntries(@"F:\", "" );

for (int i = 0; i < entries.Length; i++)
{
    Console.WriteLine(entries[i]);
}


//Console.ReadKey();
