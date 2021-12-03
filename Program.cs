


/*
Просмотр файловой структуры
Поддержка копирование файлов, каталогов
Поддержка удаление файлов, каталогов
Получение информации о размерах, системных атрибутов файла, каталога
Вывод файловой структуры должен быть постраничным

 */



/*************************************/



MainMain();




static void MainMain()
{
    string dirName = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
    string duplicate = new('=', 119);
    
    string[] entries = Directory.GetFileSystemEntries(dirName, "" /*, SearchOption.AllDirectories*/);

    for (int i = 0; i < entries.Length; i++)
    {
        Console.WriteLine(entries[i]);
    }

    Console.WriteLine(duplicate);

nn:
    
    try
    {
    n:
      
        Console.WriteLine("Выберите команду: ");
        Console.WriteLine("Для перехода к папке введите: cd; затем её имя");
        Console.WriteLine("Для перехода к предыдущей папке введите: app ");
        //Console.WriteLine("3 - Вывод содержимого файла и добавление информации.");
        //Console.WriteLine("4 - Получение данных о файле. ");
        //Console.WriteLine("5 - Атрибуты файла. ");
        Console.WriteLine("end - Выход");
        Console.Write("Вы выбираете команду : ");
        var s = Console.ReadLine();
        if (s != "cd" && s != "app" && s != "end")
        {
            Console.WriteLine("неверный ввод команды");
            goto nn;
        }
        switch (s)
        {
            case "cd":
                {
                    Str1();
                    goto n;
                }
            case "app":
                {
                    Str2();
                    break;
                }
            //case 3:
            //    {
            //        Str3();
            //        break;
            //    }
            //case 4:
            //    {
            //        Str4();
            //        break;
            //    }
            //case 5:
            //    {
            //        Str5();
            //        break;
            //    }
            case "end":
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Не вводите пробелы,буквы, пустые строки, или же числа через пробелы");
        Console.ReadKey();
        goto nn;
    }
}

static void Str1()
{
    
    
    string dirName = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
    Console.Write("Введите имя папки: ");
    string to = Console.ReadLine();
    string[] entries = Directory.GetFileSystemEntries(dirName + @"\" + to, "*");
    Console.Clear();
    for (int i = 0; i < entries.Length; i++)
    {
        Console.WriteLine(entries[i]);
    }
    Console.ReadKey();

    MainMain();

}
static void Str2()  //  "app"
{
    
    string dirName = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
    DirectoryInfo di = new(dirName);
    dirName = di.Parent.FullName;
    string[] entriesTo = Directory.GetFileSystemEntries(dirName, "*" /*, SearchOption.AllDirectories*/);
    Console.Clear();
    for (int i = 0; i < entriesTo.Length; i++)
    {
        Console.WriteLine(entriesTo[i]);
    }

    Console.ReadKey();
    MainMain();
}
static void Str3()
{
    if ((File.Exists(@"D:myfile.txt")) == false)
    {
        Console.Write("Файла не существует! Для возврата нажмите любую кнопку... ");
        Console.ReadKey();
        Console.Clear();
        MainMain();
    }
    else
    {
        string appendText = Environment.NewLine;
        File.AppendAllText(@"D:myfile.txt", appendText);
        string[] text = File.ReadAllLines(@"D:myfile.txt");
        foreach (string s in text)
        {
            Console.WriteLine(s);
        }
        Console.ReadKey();
    }
}
static void Str4()
{
    if ((File.Exists(@"D:myfile.txt")) == false)
    {
        Console.Write("Файла не существует! Для возврата нажмите любую кнопку... ");
        Console.ReadKey();
        Console.Clear();
        MainMain();
    }
    else
    {
        DateTime toto = File.GetCreationTime(@"D:myfile.txt");
        Console.WriteLine("Файл создан: " + toto);
        Console.ReadKey();
        Console.WriteLine("Для возврата нажмите любую кнопку. ");
        Console.ReadKey();
        MainMain();
    }
}
static void Str5()
{
    if (File.Exists("myfile.txt"))
    {
        Console.Write("Файл уже существует! Для возврата нажмите любую кнопку... ");
        Console.ReadKey();
        Console.Clear();
    }
    else if (!(File.Exists("myfile.txt")))
    {
        Console.WriteLine("Атрибуты файла:");
        FileAttributes attributes = File.GetAttributes(@"D:myfile.txt");
        if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
        {
            Console.WriteLine("Только для чтения - да");
        }
        else
        {
            Console.WriteLine("Только для чтения - нет");
        }
        if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
        {
            Console.WriteLine("Скрытый - да");
        }
        else
        {
            Console.WriteLine("Скрытый - нет");
        }
        if ((attributes & FileAttributes.System) == FileAttributes.System)
        {
            Console.WriteLine("Системный файл - да");
        }
        else
        {
            Console.WriteLine("Системный файл - нет");
        }
        Console.WriteLine("Для возврата в меню нажмите любую клавишу.");
        Console.ReadKey();
        Console.Clear();
        MainMain();
    }
}




