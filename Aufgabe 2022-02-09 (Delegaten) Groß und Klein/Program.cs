using Aufgabe_2022_02_09__Delegaten__Groß_und_Klein;

string kaffee = "Ich brauche Kaffee!";
string tee = "Ich brauche Tee!";

Character character = new Character();

CharacterDelegate characterDelegatelower, characterDelegateupper, characterDelegateul, cd4;

characterDelegatelower = new CharacterDelegate(character.LowerCase);

characterDelegatelower(kaffee);

characterDelegateupper = new CharacterDelegate(character.UpperCase);

characterDelegateupper(kaffee);

characterDelegateul = new CharacterDelegate(character.UpperLower);

characterDelegateul(kaffee);

cd4 = characterDelegatelower + characterDelegateupper + characterDelegateul;
cd4(tee);

Console.ReadLine();