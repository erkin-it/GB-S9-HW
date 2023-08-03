// Дана строка, содержащая только следующие символы:'(', ')', '{', '}', '[', ']'. 
// Определите, является ли ваша строка допустимой.
// Исходная строка считается допустимой при условии:
// 1. Открытые скобки должны быть закрыты скобками того же типа.
// 2. Открытые скобки должны быть закрыты в правильном порядке.
// 4. Каждая закрывающия скобка имеет соответствующую открытыю скобку того же типа.


// Печать массива
void PrintArray(char[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"'{array[i]}' ");
    }
}

bool CheckSimbolClose(char simbol, char[] array, int index)
{
    for (int j=index; j<array.GetLength(0); j=j+2)
    {
       if (simbol==array[j]) return true;
    }
    
    return false;
}


bool CheckSimbols(char[] array)
{
    bool result = false;
    int CountChar = 0;

    for (int i = 0; i < array.GetLength(0) ; i++)
    {
        if (array[i]=='(' || array[i]=='{' || array[i]=='[' ) CountChar++ ;
        if (array[i]==')' || array[i]=='}' || array[i]==']' ) CountChar-- ;
    }

    if (CountChar != 0) return false ;

    for (int i = 0; i < array.GetLength(0) ; i++)
    {
        char OpenCharSimbol = array[i];

        if (OpenCharSimbol == '(') result = CheckSimbolClose(')', array, i+1);
        else if (OpenCharSimbol == '{') result = CheckSimbolClose('}', array, i+1);
        else if (OpenCharSimbol == '[') result = CheckSimbolClose(']', array, i+1);

        if (result !) break;      
    }

    return result;
}

/////////////////////////////////////////////////////////////////

string strValue = "({[]})";
char[] chars= strValue.ToCharArray ();
PrintArray(chars);
Console.Write(CheckSimbols(chars));