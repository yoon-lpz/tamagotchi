using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi.Core.UI;

public class Messages
{
    public const string MsgLanguageOptions = "\n   0. ENG\n   1. ESP\n   2. CA\n";
    public const string MsgLanguageSelection = "Language/idioma: ";
    public const string MsgLanguageError = "\t ⚠️ Language must be a valid number         \n" +
                                           "\t ⚠️ El idioma tiene que ser un número válido\n" +
                                           "\t ⚠️ L'idioma ha de ser un número vàlid      ";

    public const string CatProfileASCII =
        "     ,_         _,\n" +
        "     |\\\\.-\"\"\"-.//|\n" +
        "     \\`         `/\n" +
        "    /    _   _    \\\n" +
        "    |    a _ a    |\n" +
        "    '.=    Y    =.'\n" +
        "      >._  ^  _.<\n" +
        "     /   `````   \\\n" +
        "     )           (\n" +
        "    ,(           ),\n" +
        "   / )   /   \\   ( \\\n" +
        "   ) (   )   (   ) (\n" +
        "   ( )   (   )   ( )\n" +
        "   )_(   )   (   )_(-.._\n" +
        "  (  )_  (._.)  _(  )_, `\\\n" +
        "   ``(   )   (   )`` .' .'\n" +
        "      ```     ```   ( (`\n" +
        "                     '-'\n";

    public const string DogProfileASCII = "                          _\r\n                       ,:'/   _..._\r\n                      // ( `\"\"-.._.'\r\n                      \\| /    6\\___\r\n                      |     6      4\r\n                      |            /\r\n                      \\_       .--'\r\n                      (_'---'`)\r\n                      / `'---`()\r\n                    ,'        |\r\n    ,            .'`          |\r\n    )\\       _.-'             ;\r\n   / |    .'`   _            /\r\n /` /   .'       '.        , |\r\n/  /   /           \\   ;   | |\r\n|  \\  |            |  .|   | |\r\n \\  `\"|           /.-' |   | |\r\n  '-..-\\       _.;.._  |   |.;-.\r\n        \\    <`.._  )) |  .;-. ))\r\n        (__.  `  ))-'  \\_    ))'\r\n            `'--\"`       `\"\"\"`\r\n";
    public const string ChickProfileASCII = "                .---.\r\n         .---. '     \\ _\r\n       /`     `    o  |<\r\n  , _.' _.---.       / `\r\n  `\\  `\\         ;.-'\r\n    \\   '._.'    /\r\n     '.        .'\r\n       \\_/--;`\r\n        |   _\\_\r\n      --;--.  \\`--\r\n         '.    `\r\n";

    public static string[] MsgUserNameSelection = ["Input your name: ", "Introduce tu nombre: ", "Introdueix el teu nom: "];
    public static string[] MsgUserNameSelectionError = [
        "\t The username must contain at least 3 characters. Try again.",
        "\t El nombre de usuario debe tener al menos 3 caracteres. Inténtalo de nuevo.",
        "\t El nom d'usuari ha de tenir al menys 3 caracters. Intenta-ho de nou."];

    public static string[] MsgSelectPet = [
        "Select a pet",
        "Selecciona una mascota",
        "Selecciona una mascota"];
    public static string[] MsgSelectPetError = ["\t ⚠️ The pet must be a valid number (0-2)" +
                                           "\t ⚠️ La mascota tiene que ser un número válido (0-2)" +
                                           "\t ⚠️ La mascota ha de ser un número vàlid (0-2)"];
}
