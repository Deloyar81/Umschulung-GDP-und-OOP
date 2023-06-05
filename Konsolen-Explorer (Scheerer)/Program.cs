using Konsolen_Explorer__Scheerer_;

Operations o = new Operations();
o.Path = @"c:\";

o.ListDirectory();

int input;

do
{
    input = int.Parse(Console.ReadLine());
    o.ChangeDirectory(input);
} while (input != -1);
