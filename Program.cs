




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
        Console.WriteLine("1.Для перехода к папке введите: cd; затем её имя");
        Console.WriteLine("2.Для перехода к предыдущей папке введите: app ");
        Console.WriteLine("3.Для получение данных о файле введите: inf ");
        Console.WriteLine("4.Для удаления файла введите: del");
        Console.WriteLine("5.Для копирования файла введите: cp");
        Console.WriteLine("7.Для получение данных о каталоге введите: INF ");
        Console.WriteLine("8.Для удаления каталога введите: DEL");
        Console.WriteLine("9.Для перемещения каталога введите: CP");
        Console.WriteLine("end - Выход");
        Console.WriteLine(duplicate);
        Console.Write("Вы выбираете команду : ");
        var s = Console.ReadLine();
        if (s != "cd" && s != "app" && s != "inf" && s != "del" && s != "cp"
            && s != "INF" && s != "DEL" && s != "CP" && s != "end")
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
            case "inf":
                {
                    Str3();
                    break;
                }
            case "del":
                {
                    Str4();
                    break;
                }
            case "cp":
                {
                    Str5();
                    break;
                }
            case "INF":
                {
                    Str6();
                    break;
                }
            case "DEL":
                {
                    Str7();
                    break;
                }
            case "CP":
                {
                    Str8();
                    break;
                }
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


static void Str1() //cd
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
static void Str3()  //inf
{
    string dirName = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
    Console.WriteLine("Введите имя файла с его расширением");
    string to = @"\" + Console.ReadLine();
    string path = dirName + to;
    FileInfo fileInf = new (path);
    if (fileInf.Exists)
    {
        Console.WriteLine("Имя файла: {0}", fileInf.Name);
        Console.WriteLine("Время создания: {0}", fileInf.CreationTime);
        Console.WriteLine("Размер: {0} Байт", fileInf.Length);
    }
    else
    {
        Console.Write("Файла не существует! Для возврата нажмите любую кнопку... ");
        Console.ReadKey();
        MainMain();
    }
    Console.ReadKey();
    Console.Clear();
    MainMain();
}
static void Str4()  //del
{
    string dirName = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
    Console.WriteLine("Введите имя файла с его расширением");
    string to = @"\" + Console.ReadLine();
    string path = dirName + to;
    FileInfo fileInf = new(path);
    if (fileInf.Exists)
    {
        File.Delete(path);
    }
    else
    {
        Console.Write("Файла не существует! Для возврата нажмите любую кнопку... ");
        Console.ReadKey();
        Console.Clear();
        MainMain();
    }
    Console.ReadKey();
    Console.Clear();
    MainMain();
}
static void Str5()  //cp
{
    string dirName = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
    Console.WriteLine("Введите имя файла с его расширением");
    string to = @"\" + Console.ReadLine();
    string path = dirName + to;
    Console.WriteLine("Введите имя папки в которую вы хотите скопировать файл");
    string toto = dirName + @"\" + Console.ReadLine() + to;
    Console.WriteLine(path + " * " + toto);
    Console.ReadKey();
    FileInfo fileInf = new(path);
    if (fileInf.Exists)
    {
        File.Copy(path, toto, true);
    }
    else
    {
        Console.Write("Ошибка! Для возврата нажмите любую кнопку... ");
        Console.ReadKey();
        Console.Clear();
        MainMain();
    }
    Console.WriteLine($"Файл успешно скопирован в: {toto}");
    Console.ReadKey();
    Console.Clear();
    MainMain();
}
static void Str6()  //INF
{
    string dirName = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
    //Console.WriteLine("Введите имя каталога");
    DirectoryInfo dirInfo = new (dirName);
    Console.WriteLine($"Название каталога: {dirInfo.Name}");
    Console.WriteLine($"Полное название каталога: {dirInfo.FullName}");
    Console.WriteLine($"Время создания каталога: {dirInfo.CreationTime}");
    Console.ReadKey();
    Console.Clear();
    MainMain();
}
static void Str7()  //DEL
{
    string dirName = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
    Console.WriteLine("Введите имя каталога");
    string to = @"\" + Console.ReadLine();
    string path = dirName + to;
    Directory.Delete(path, true);
    Console.ReadKey();
    Console.Clear();
    MainMain();
}
static void Str8()  //CP
{
    string dirName = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
    Console.WriteLine("Введите имя папки");
    string to = @"\" + Console.ReadLine();
    string path = dirName + to;
    Console.WriteLine("Введите имя папки в которую вы хотите переместить:" + to);
    string toto = dirName + @"\" + Console.ReadLine() + to;
    DirectoryInfo dirInfo = new (dirName);
    if (dirInfo.Exists && Directory.Exists(toto) == false)
    {
        dirInfo.MoveTo(toto);
    }
    else
    {
        Console.Write("Ошибка! Для возврата нажмите любую кнопку... ");
        Console.ReadKey();
        Console.Clear();
        MainMain();
    }
    Console.WriteLine($"Файл успешно скопирован в: {toto}");
    Console.ReadKey();
    Console.Clear();
    MainMain();
}





