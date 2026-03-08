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
        "\t ⚠️ The username can't be empty. Try again.",
        "\t ⚠️ El nombre de usuario no puede estar vacío. Inténtalo de nuevo.",
        "\t ⚠️ El nom d'usuari no pot estar buit. Intenta-ho de nou."];

    public static string[] MsgSelectPet = [
        " 0. Cat\n 1. Dog\n 2. Chick\nSelect a pet: ",
        " 0. Gato\n 1. Perro\n 3. Pollo\nSelecciona una mascota: ",
        " 0. Gat\n 1. God\n 3. Pollet\nSelecciona una mascota"];
    public static string[] MsgSelectPetError = ["\t ⚠️ The pet must be a valid number (0-2)" +
                                           "\t ⚠️ La mascota tiene que ser un número válido (0-2)" +
                                           "\t ⚠️ La mascota ha de ser un número vàlid (0-2)"];

    public static string[] MsgPetNameSelection = ["Name your pet: ", "Ponle un nombre a tu mascota: ", "Posa-li un nom a la teva mascota: "];
    public static string[] MsgPetNameSelectionError = ["\t ⚠️ The name can't be empty. Try again.", "\t ⚠️ El nombre no puede estar vacío. Inténtalo de nuevo.", "\t ⚠️ El nom no pot estar buit. Intenta-ho de nou."];

    public static string[] MsgPressEnter = [
        "Press enter.",
        "Presiona enter.",
        "Pressiona enter."
        ];

    public static string[] MsgShowStats = [
        "    Energy: {0}     Hunger: {1}    Health: {2}    ",
        "    Energia: {0}    Hambre: {1}    Salud: {2}     ",
        "    Energia: {0}    Fam: {1}       Salut: {2}     "
        ];

    public static string[] MsgMenuOptions = [
        "\t0. Exit\n\t1. Eat\n\t2. Sleep\n\t3. Play\n\t4. Shop\n\t5. Injection\n\t6. Change language\nSelect an option: ",
        "\t0. Salir\n\t1. Comer\n\t2. Dormir\n\t3. Jugar\n\t4. Tienda\n\t5. Inyección\n\t6. Cambiar idioma\nSelecciona una opción: ",
        "\t0. Sortir\n\t1. Menjar\n\t2. Dormir\n\t3. Juagr\n\t4. Botiga\n\t5. Injecció\n\t6. Canviar idioma\nSelecciona una opció: "
        ];
    public static string[] MsgMenuOptionsError = [
        "\t ⚠️ You must input a number between 0 and {0}.",
        "\t ⚠️ Tienes que introducir un número entre 0 i {0}.",
        "\t ⚠️ Has d'introduir un número entre 0 i {0}."
        ];

    public static string[] MsgMenuEat = [
        "\t\t   Eating...   \nAvailable snacks: {0}\nAvailable meals: {1}\n0. Cancel\n1. Snack\n2. Meal\nSelect an option: ",
        "\t\t   Comiendo...   \nSnacks disponibles: {0}\nComidas disponibles: {1}\n0. Cancelar\n1. Snack\n2. Comida\nSelecciona una opción: ",
        "\t\t   Menjant...   \nSnacks disponibles: {0}\nMenjars disponibles: {0}\n0. Cancel·lar\n1. Snack\n2. Menjar\nSelecciona una opció: "
        ];
    public static string[] MsgSnackError = [
        "You don't have any snack left.",
        "No tienes ningun snack disponible.",
        "No tens cap snack disponible."
        ];
    public static string[] MsgMealError = [
        "You don't have any meal left.",
        "No tienes ninguna comida disponible.",
        "No tens cap menjar disponible."
        ];

    public static string[] MsgPlayErrorNoEnergyHunger = [
        "\t ⚠️ You can't play with {0}. Give them something to eat and let them sleep.",
        "\t ⚠️ No puedes jugar con {0}. Dale algo para comer y déjale dormir.",
        "\t ⚠️ No pots jugar amb {0}. Dona-li alguna cosa per menjar i deixa'l dormir."
        ];
    public static string[] MsgPlayErrorNoEnergy = [
        "\t ⚠️ You can't play with {0}. Let them sleep.",
        "\t ⚠️ No puedes jugar con {0}. Déjale dormir.",
        "\t ⚠️ No pots jugar amb {0}. Deixa'l dormir."
        ];
    public static string[] MsgPlayErrorNoHunger = [
        "\t ⚠️ You can't play with {0}. Give them something to eat.",
        "\t ⚠️ No puedes jugar con {0}. Dale algo para comer.",
        "\t ⚠️ pots jugar amb {0}. Dona-li alguna cosa per menjar."
        ];

    public static string[] MsgShopOptions = [
        "\t\t Shop \n 0. Exit\n 1. Buy a snack\n 2. Buy a meal\nEnter your option: ",
        "\t\t Tienda \n 0. Salir\n 1. Snack\n 2. Comida\nSelecciona tu opción: ",
        "\t\t Botiga \n 0. Sortir\n 1. Snack\n 2. MenjarnSelecciona la teva opció: "
        ];

    public static string[] MsgErrorNumber = ["\t ⚠️ You must input a valid number (0-{0})",
                                           "\t ⚠️ Tienes que introducir un número válido (0-{0})",
                                           "\t ⚠️ Has d'introduïr un número vàlid (0-{0})"];
    public static string[] MsgAngry = [
        "😠 Your pet is angry at you!",
        "😠 ¡Tu mascota está enfadada contigo!",
        "😠 La teva mascota està enfadada amb tu!"
        ];
}
