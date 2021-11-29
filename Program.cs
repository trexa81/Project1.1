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
//Directory.CreateDirectory(Path.Combine(@"D:\", "ExampleDir"));// Создаем вложенную директорию по заданному пути

//string workDir = @"D:\ExampleDir";

//Console.WriteLine(Directory.Exists(workDir)); // Проверяет, существует ли заданная директория

//string notesDir = Path.Combine(workDir, "Notes23"); // "D:\ExampleDir\Notes"

//Directory.CreateDirectory(notesDir); // Создаем вложенную директорию

//string noteText = "Этот файл создан автоматически 23";

//string notePath = Path.Combine(notesDir, "Note 123.txt"); // "D:\ExampleDir\Notes\Note 1.txt"

//File.WriteAllText(notePath, noteText);

//string copyOfNotePath = Path.Combine(workDir, "Copy of Note 123.txt"); // "D:\ExampleDir\Copy of Note 1.txt"
//File.Copy(notePath, copyOfNotePath); // Копируем созданную заметку в "D:\ExampleDir\Copy of Note 1.txt"

//Console.WriteLine(File.Exists(copyOfNotePath)); // Проверяет, существует ли заданный файл

//File.Move(copyOfNotePath, Path.Combine(notesDir, "Note 223.txt"));
//// Перемещаем заметку в "D:\ExampleDir\Notes\Note 2.txt"

//// Создаем директорию "D:\ExampleDir\Documents" и перемещаем в нее директорию Notes
//Directory.CreateDirectory(Path.Combine(workDir, "Documents23"));
//Directory.Move(notesDir, Path.Combine(workDir, "Documents23", "Notes23"));

/*********************************/



//string fileName = "myfile.ext";
//string path1 = @"mydir";
//string path2 = @"\mydir";
//string fullPath;

//fullPath = Path.GetFullPath(path1);
//Console.WriteLine("GetFullPath('{0}') returns '{1}'",
//    path1, fullPath);

//fullPath = Path.GetFullPath(fileName);
//Console.WriteLine("GetFullPath('{0}') returns '{1}'",
//    fileName, fullPath);

//fullPath = Path.GetFullPath(path2);
//Console.WriteLine("GetFullPath('{0}') returns '{1}'",
//    path2, fullPath);



// Перечень всех файлов и папок, вложенных в каталог ( и все вложения /*, SearchOption.AllDirectories*/)
var dir = "\\ExampleDir";
string duplicate = new('=', 120);
string dirName = Environment.GetFolderPath(Environment.SpecialFolder.Personal)/* + dir */;
DirectoryInfo di = new(dirName + dir);
string app = di.Parent.FullName;
Console.WriteLine(app);
//Console.WriteLine(di.Parent.FullName);
Console.WriteLine();

//string to = Console.ReadLine() ;


string[] entries = Directory.GetFileSystemEntries(dirName + dir , "" /*, SearchOption.AllDirectories*/);

for (int i = 0; i < entries.Length; i++)
{
    Console.WriteLine(entries[i]);
}


//if (Directory.Exists(dirName))
//{
//    Console.WriteLine("Папки:");
//    string[] dirs = Directory.GetDirectories(dirName);
//    foreach (string s in dirs)
//    {
//        Console.WriteLine(s);
//    }
//    Console.WriteLine(duplicate);
//    Console.WriteLine("Файлы:");
//    string[] files = Directory.GetFiles(dirName);
//    foreach (string s in files)
//    {
//        Console.WriteLine(s);
//    }
//}

Console.WriteLine(duplicate);

Console.WriteLine("Для перехода к папке введите её имя");
Console.WriteLine("Для перехода к предыдущей папке введите: app ");
string to = Console.ReadLine();
if (to != "app")
{
    string[] entriesTo = Directory.GetFileSystemEntries(di + @"\" + to, "*" /*, SearchOption.AllDirectories*/);

    for (int i = 0; i < entriesTo.Length; i++)
    {
        Console.WriteLine(entriesTo[i]);
    }
}
else
{
    string[] entriesTo = Directory.GetFileSystemEntries(app, "*" /*, SearchOption.AllDirectories*/);

    for (int i = 0; i < entriesTo.Length; i++)
    {
        Console.WriteLine(entriesTo[i]);
    }
}





