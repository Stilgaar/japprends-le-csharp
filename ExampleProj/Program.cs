using System;
using System.Text;
using System.Collections.Generic;

namespace ExampleProj
{
    class Program
    {
        /* 
         La fonction principale en c# est MAIN est est présentée comme ça :
        public static void Main(string[] args)
        {
            // do something
        }

        Notez qu'il y a plusieurs autres annotations. 
         
         */


        /*
         Si un jour vous tombez la dessus, notez que c'est mes premiers cours de c# que j'ai toppé sur UDEMY.
         Notez également que je fais beaocup de commentaires parce que ce REPO va également me servir d'anti-sèche quand j'en aurais besoin. :D
         Notez également, que de temps en temps, j'écris vraiment de la merde 
        
        Notez, encore une fois, qu'il y a beaucoup de trucs que ne note pas forcément, c'est parce que il y a beaucoup de similitudes entre le c# et le js. 
        Généralement je l'écris du coup qu'il y a une telle similitude. 

         */

        /********************************************************************************************************************/
        /*************************************** BASES *********************************************************************/
        /******************************************************************************************************************/

        /*
        static signfifie que la methode peut être appellé sans objet
         void signifie qu'elle n'attends pas de résultat/valeur
         Main() est le nom de la fonction elle même. Attention c# fait attention aux minuscules et aux majuscules
        les {} ou va ou le code à exectuter
        par default la fonction sera "private" on peut l'écrire devant :
        " private static void Main() "
         pour la rendre public on fait l'inverse : 
        " public static void Main() "
         On peut indiquer quel type d'argument in va recevoir, par exemple ici, il va recevoir un String (je sais pas encore pourquoi ya un array au bout) et avec un argument (args)
        on peut l'appeller cacahouette si ça nous chante
         on peut écrire la fonction Main() de pleins de façons differents. (ya des asyncs etc)
         t'as vu les hello world de ouf ? =)
         System.Diagnostics.Debug.WriteLine("Hello World");
        Console.WriteLine("Hello World");
        */

        /*****************************************************************************************************************/
        /*************************************** CONDITIONS *************************************************************/
        /***************************************************************************************************************/

        /* 
         
        jusque la rien de novueau sauf qu'on écris les primitives en bool. Après je sais que dans c# on peut faire var complete = false par exemple
        bool complete = false;
        bool started = true;
        int x;

        if (complete) {
            x = 5; 
        }
        else if (started)
        {
            x = 3;
        } else
        {
            x = 1;
        } */

        /**************************************************************************************************************/
        /* LOOOOOOOOOOOPSS****************************** loop  ************************************** LOOOOOOOOOOOPSS*/
        /************************************************************************************************************/

        /* 
         ya du for et du while comme dans Js, les copieurs t'as vu ? houla le mec va vite et donnes pas des exemples de ouf =//

        (oui c'est une liste de string, une collection, un array, un oiseau un avion ? non c'es superstring)
        List<string> collection = new List<string>() { "a", "b", "c" };
        for (int i = 0; i < collection.Count; i++)
        {
            System.Diagnostics.Debug.WriteLine(collection[i] )

        } 

         While
         faut dire que les boucles while et for ressemblent beaucoup au Js, comme s'ils avaient copié ? 
         int i = 3;
         while(i>0)
         {
             System.Diagnostics.Debug.WriteLine("Loading");

         }*/

        /*************************************************************************************************************/
        /*************************************** FUNCTIONS && METHODS  **********************************************/
        /***********************************************************************************************************/

        /* 
         alors ça marche un peu pareil que dans le Js encore une fois, à quelques différences prés. Déjà l'écriture même de la fonction, il faut la faire précéder de void, de public, static etc. (je pense que ça viendra avec le temps assez facilement)

        PrintMessage("Hello World");

          pour l'exemple j'avais écris ça en dehors de la Main() je ne sais pas encore si on peut écrire des fonction dans des fonctions. 
          Jvais tester pour la science ici ?
          spoiler alert : on peut, enfin je suppose que ça reste dans le scope de cette fonction en particulier ? (possiblement)
         static void PrintMessage(string message)
         {
             Console.WriteLine(message);
         } 
        */

        /****************************************************/
        /*************** ERRORS - ERREURS  ***************/
        /****************************************************/

        /*
         LES ERREURS, ya trois types d'erreurs différentes : 
         Syntax Error: on a écris un truc pas comme il fallait (probablement une string à la place d'un char, un array à la place d'un array etc)
         Logic Error : Le code fait pas ce qu'on lui dit de faire (lol dans le cul ? )
         Runtime error : Une erreur apparaissant pendant que le code se lance
        /*

        /**************************************************************************************************************/

        /***************************************************************************************************************/
        /*************************************** SYNTAXE DU C#  *******************************************************/
        /*************************************************************************************************************/

        /*
         case sensitive language : 
         int example = 1;
          int EXAMPLE = 1; 
         deux entités de example different. Faut TOUJOURS TOUJOURS finir par une ; ....

         les {} montrent ou commencent et finissent les scope des fonctions
         c# va dans une class  

         il y a quatre modificateurs d'accès dans c# : 
         PUBLIC : tout le monde peut y accéder, par les autres class par exemple
         PROTECTED : seulement quelques autres class spécifiques peuvent accèder aux datas de ces trucs. On dirait genre ce qu'on écrirait dans un scope ? les class qui "extends" ladidte classe aura accès aux infos dans la private
         PRIVATE : ne sera dispo QUE dans la class 
         INTERNAL : seulement utilisable  "l'assembly?" (un truc qui regroupe le code, on va pas l'utiliser de suite mais un peu plus tard si j'ai bien compris)


         C# a des attributs aux codes pour y ajouter des informations
         on peut genre rendre un string private ? (ok) et l'appeller plus tard dans un truc public (ok ?)
         donc dans Name on appelle la valeur de name en prennant sa valeur et on retourne la QUOI ? déjà ça devrait pas être l'inverse ? 
         et après tout le monde détéste Js ? Fuck la planète

         j'en étais au COURST 4 // Basic Syntac // Lesson 11
          private string name = "robert";

         public string Name
         {
             get { return name; }
             set { name = value; }
         } 

         MODULOS : % vont donner le restant d'une fraction. Genre 5 % 4 = 1 mais 4 % 4 = 0. Je me demande si c'est pas utilisé pour voir si c'est pair un impaire en gros =)
         Console.WriteLine(124 % 2);

         INCREMENT ET DECREMENT operators
         ++ RAJOUTE 1
         -- ENLEVE 1
         rajoute en eleve 1 à une valeur
         int number = 4;
         number++;
         console.log(number) ===> 5 

         IS OPERATOR équivalent au typeof ? MAIS PAS TOUT A FAIT ....

         bool b = "abc" is string; <== oui c'est un vrai truc
         le console.writeline(b); va répondre true
         par contre bool b = "abc" is int <== encore un vrai truc ? oui oui
         le console.writeline(b); va répondre false. PARCE QUE C'EST FALSE \o/

         on va pousser un peu peu plus loin : créons Ex1 et Ex2, Ex2 extends Ex1 d'ailleurs
         
        */

        /*****************************************************/
        /**********  IS && AS *******************************/
        /***************************************************/

        /*
        OPERATEUR IS
         public class Ex1 { }
         public class Ex2 : Ex1 { }
         Ex2 ex2Object = new Ex2();
         bool b = ex2Object is Ex1;
         System.Diagnostics.Debug.WriteLine(b);
         va donner TRUE parce que Ex1 est une extention de Ex2. Forcmement vu que ex2Object à été crée à partir d'un Ex2 qui est Ex1 extend t'as pigé ? moi oui.
         tu remarquera que pour expand une class, contrairement à Js on lui mets ":" au lieu du mot clefs expands.

         operateur AS, marche un peu comme on pense qu'il devrait marcher. 
         string s1 = "abc"; 
         object obj1 = s1;
         string s2 = obj1 as string; 

        /*****************************************************/

        /*****************************************************/
        /********** TERNAIRES *******************************/
        /***************************************************/

        /*
         estceuqeutruc ? OUI : NON <--  
        les ternaires fonctionnent pareil que dans Js
         le "ternaire" "&&" fonctione avec des "??"
        */

        /*****************************************************/
        /**********  SISEOF -- TYPEOF ***********************/
        /***************************************************/

        /*
        siseof() donne nombre de bytes que la variable va prendre, retourne un int. 

         typeof() n'est pas vraiment beaucoup utilisé. C'est comme dans JS, ça nous donne le type. Par exemple in typeof(int) va nous donner un System.Int32 parce que c'est ce qui se passe réelement. Est ce qu'on a besoin de savoir tout réelement ? NON 
         surtout qu'au final tout est déjà typé
           */

        /****************************************************************************************************************************/
        /*************************************** OPERATOR OVERLOADING  *************************************************************/
        /**************************************************************************************************************************/

        /*
         c'est pour additionner deux trucs qui ne devraient apparement PAS être additionnables ? Ou lui indiquer COMMENT additioner ces deux items. Le mystère reste mysterieux.
         alors ça se complique un poil ^-^' 
         on va prendre cet exemple avec la class Box. On va lui donner trois mesures. Puis lui crée une fonction pour qu'il connaisse ces mesures. 
         ensuite on va crée trois fonction pour retourner les mesure. (putain ?)
         ENSUITE on va crée une fonction d'operator overload. 

            class Box
            {
                private int lenght;
                private int width;
                private int height; 

                public Box(int lenght, int width, int height)
                {
                  this.lenght = lenght;
                    this.width = width;
                   this.height = height; 
                }

               public int GetLenght()
               {
                    return lenght; 
                }

                public int GetWidht() 
                {
                    return width; 
                }  

                public int GetHeight()
                {
                    return height; 
                }

                public static Box operator +(Box box1, Box box2)
                {
                    return new Box(box1.GetLenght() + box2.GetLenght(),
                                    box1.GetWidht() + box2.GetWidht(),
                                    box1.GetHeight() + box2.GetHeight());
                }
            }
            public static void Main(string[] args)
            {
               Box box1 = new Box(2, 2, 2);
                Box box2 = new Box(2, 2, 2);
                Box box3 = box1 + box2;

                System.Diagnostics.Debug.WriteLine("Lenght: " + box3.GetLenght());
               System.Diagnostics.Debug.WriteLine("Widht: " + box3.GetWidht());
               System.Diagnostics.Debug.WriteLine("Height: " + box3.GetHeight());

           }
        }

         Comme dans tous les languages, C# dispose d'un paquet de noms reservés, ce sont les noms qui servent comme async await etc. 
         comme dans les autres languages, ce qui est bien, au top, c'est de ne pas les utiliser comme noms de variables t'as vu ? 
        */

        /*************************************************************************************************************************/
        /***************************************  BASIC DATA TYPES  *************************************************************/
        /***********************************************************************************************************************/

        /*  
         (oui on fait les data types AVANT de faire tout le reste ... r/HMMMMMM 

         Les data types (lol) basiques sont : 
         - Ints :
         - Floats 
         - Strings
         - Characters
         - Booleans

         Si on fait par exemple, un :
         int example = 1; 
        il équivaut à 
        System.Int32 example = 1 ;

        Pour faire plus en profondeur : bool équivaut à System.Boolean 
        float équivaut à System.Single
        int équivaut à System.Int32
        string équivaut à System.String
        char équivaut à System.Char
        */

        /****************************************************/
        /**********  NUMBER VARIABLES && FLOATS ************/
        /**************************************************/

        /*
         pour l'incrémentation c'est les ++ et les --. Enfin on connait t'as vu ? =)
         le préfix et le suffix fonctionent à peu près pareil ?
         le c# à les mêmes operateurs classiques que JS ou que le monde entier en fait. + - / *
         on peut faire des nombres à virugle en rajoutant un f à la fin des numéros. Genre 0.5f <-- Comme on fait dans la vie réele.
         quand on additionne deux floats et qu'ils donnent un entier, ça va laisser tomber la virugle de suite. Genre 0.5 et 0.5 = 1 et pas 1.0 

        int i = 0;
        i = 5;
            System.Diagnostics.Debug.WriteLine(10 + 5 * 2 + 3);

         Floats && Int ==> 
         Si on fait un (int)5.5f => l'ordinateur va juste laisser tomber tout ce qui est derrière la virugule. pas arrondir hein, faire comme si ça n'existait pas 
         ici il va print un joli 5. C'est une perte de données. 
        */

        /****************************************************/
        /**********  MATH CLASS  ***************************/
        /**************************************************/

        /*
         La MATH class est tout droit sorti du system de c#. Faut du coup pas oulbier le "using System"
         La MATH fonctionne comme dans Js.
         genre Math.abs(-3) va donner la valeur absolue. ici donc 3
         Math.round(3.5) => 4, Math.round(3.2) => 2
         Math.Cieling(3.1) => toujours 4, toujours au dessus
         Math.Floor(3.9) => toujours 3, toujours en dessous
         Math.Truncate(5.9) => va faire pareil que Floor. Enfin ça tronque en gros, petit chançard. 
         Math.Min(3,5) => va donner 3 parce que 3 est plus petit que 5
         Math.Max(3,5) => va donner 5 parce que c'est le nombre le plus grand des deux. 
         Qu'est ce que je t'avais dit ? C'est grave pareil qu'en Js
         *****************  Inserez le Gif de Mr Bean en train de copier son collègue ICI ***************** 
        */

        /*********************************************************************************************************/
        /************************  STRINGS ( ͡° ͜ʖ ͡°)  ************************************************************/
        /*******************************************************************************************************/

        /*
         (oui je me suis vraiment fait chier à chercher cet émoji sur google)
         Un string est une chaine de caractères écrites entre deux doubles guillemets. Notez que c'est important parce que si c'est des simples guillemets ça devient un type char, pour character
         on peut aussi crée une string vide qu'on va remplir par la suite. genre string s2 = ""; On peut aussi l'écrire en string s3 = string.Empty;
         string s1 = "hi";
         une fois les strings assignés, même en les modifiants, au final, ça restera un string. (Le String de Guerre ?)

         la concatenation se fait pareil qu'en Js aussi avec les plus. Je ne pense qu'ils aient des tempalte strings. 
         Ah alors oui elle existe après verification, interesting. Bon vous savez en Js, ça s'écris comme ça `Text ${var} text` <- 
         en C# ce sera comme ça : $"text, {var} text" => en gros il faut mettre un $ avant de commencer sa longue string puis mettre les variables comme en jsx
        notez que les éspaces si besoin entre deux strings, quand on concatène, se fait également de la même manier : var1 + " " + var2
        */

        /********* DIFFERENCES ******** ENTRE ****************/
        /**********  STRINGS ( ͡° ͜ʖ ͡°)  ***** ET *************/
        /**************** CHAR *****************************/

        /*
         Alors ... A quoi ça sert vraiment me dépasse entièrement. 
         le CHAR corresponds à un seul et unique caractère. Il est écris uniquement entre guillemets simples ' ' <-- Il représente une BITE soit 8 BYTES. Ou c'est l'inverse. Je sais plus avec leurs histoires de bites. 
         char char1 = 'a';
         char char2 = '\n'; est le NEW LINE CHARACTER. Pourquoi ils n'écrivent pas juste \n ? PERSONNE NE SAIT
         va un truc vraiment complexe qui se fait quand on écris string s1 = "abc"; convertissant ça en décomposotion de char. Franchement, je ne sais pas si c'est important pour la suite.
         Franchement, j'espère pas.
        */

        /****************************************************/
        /**********  STRINGS ( ͡° ͜ʖ ͡°)  ** EQUALITY *********/
        /**************************************************/

        /*
         Prennons les exemples suivants : 
        string s1 = "abc"; 
        string s2 = "abc";
        la si on fait un joli s1 == s2; ça va donner true. 
        nottez qu'en c# ya pas de triple === pour la bonne et simple raison que c'est un language TYPé
        alors vu que c'est un language ou on aime bien rajouter des petits mots partout apparement le truc le plus utilisé c'est le string.Equals(s1,s2) qui va bien sur donner true aussi.
         */

        /****************************************************/
        /**********  STRINGS ( ͡° ͜ʖ ͡°)  ** @ - $ ************/
        /**************************************************/

        /* 
         @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
         
        le @ s'appelle le verbatim identifier. Alors je ne sais pas si ça vient des marques de disquettes d'à l'époque (boom coup de ieuv) mais ça me ramène 15 ans en arrière
        donc on peut pas faire ça : string if = "hello world"; du coup on peut faire ça : string @if = "hello world"; 
        l'autre fonctionnalité de @ sert à ce qu'un string soit lue de façon littérale. Explication : 
        
        (j'en ai marre d'écrire System.Diagnostics.Debug.WriteLine(truc) à chaque fois, maintenant dans mes exemples jvais juste écrire console.(truc) ok ?
        si on fait un console.("a \n b") ça va écrire : 
        a
        b
        si on fait un console.(@"a \n b") ça va écrire : 
        a\nb

        C'était mon Ted Talk

         $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
        ah bha je cherche des trucs sur google pour rien. le $ pour le string est principalement utilisé pour faire un template litteral comme j'ai dit plus haut
        c'est toujours bon de réécrire les trucs alors au lieu de faire ça : 
        
        string s1 = "Ryu"; 
        console.("Salut " + s1 + " Comment tu vas ?")
        
        on peut écrire : 
        console.($"Salut {s1} Comment tu vas ?")
        ce qui est quand même plus classe non ? 
        ah ça a été introduit en c# v6, donc c'est relativement récent. (comme pour le template string en Js au final)
         */

        /****************************************************/
        /***** SLICING *****  STRINGS ( ͡° ͜ʖ ͡°)  ************/
        /**************** (SUBSTING) **********************/

        /*
        Slicing permet d'avoir un subsring d'un string. Quand on dit substring c'est ce qu'on peut obtenir à partir de la string de base. 
        par exemple : String S1 = "ABC"
        Les substrings qu'on peut en obtenir sont : 

        "A"
        "B"
        "C"
        "AB"
        "BC"
        "ABC" (obviously)

        Notez qu'on ne peut pas OBTENIR (direcement en tout cas) de substring "AC" parce que ce n'est plus un slice. 
         
        par exemple : (qu'on verra avec différentes méthodes je suppose ?) 
        string ex = "abc"; 
        console.(ex.Contains("bc")); va renvoyer true
        console.(ex.Contains("Ac")); va renvoyer false

        SubString va prendre en argument la valeur de l'index à laquelle on veut commencer à prendre le string. N'oubliez pas qu'un string reste un objet avec un index
        ici a = 0, b = 1 et c = 3. Du coup quand on écris : 
        console.(ex.SubString(1)); il va nour renvoyer son plus beau "bc"

        Dans SubString on peut aussi passer un second argument. Du coup le premier devient le point de départ. Et le second la longueur.
        En gros ex.SubString(0,2) va nous renvoyer son plus beau "ab"

         */

        /****************************************************/
        /**********  STRINGS ( ͡° ͜ʖ ͡°)  *********************/
        /*********** ESCAPE SEQUENCIES  *******************/

        /* 
        Encore une fois c'est comme en Js
        c'est pour faire un console.("Jeff à dit \"c'est comme dans Js\"") ib écris des \ devant les " pour qu'ils soient print et pas que le console.log se plante. 
        Ouais je sais pour rappel dans Js on fait comme ça ("Jeff à dit 'c'est comme dans Js'") mais on a des trucs qui servent à rien ou on les a pas (HEIN CHAR)
         
        Si on veut que le / soit vu comme un String il faut qu'on en écrive deux fois par exemple // 

        le \a va rien imprimer sur notre console mais va jouer un son. UN SON. 
        genre en gros Console.WriteLine("\a"); va jouer un son ok ? 

        le \r fait un return (un peu comme le \n ?)

        le \t rajoute une espace de tabulation. (putain c'est tellement un truc de fou HIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII!!!!!!!!!!!!!!!!!!!!)
        en plus !! EN PLUS on peut faire ça : console.("Hello \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t world") pour faire encore plus de tabulation !!
        HIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII!!!!!!!!!!!!!!!!!!!!²²²²²

         */

        /**************** FORMATTING ************************/
        /**********  STRINGS ( ͡° ͜ʖ ͡°)  *********************/
        /**************************************************/

        /* 
        Alors c'est une methode nommé format pour qu'on indique comment on veut que le string soit display.
        Houla houla houla. On est passé de "faut tout tapper" à "ya des truc qui se font tout seuls" en deux secondes ! Et moi qui pensait que ça allait être uppercase et ce genre de merdes.

        Alors : Grosso Modo : 
        On prends un INT : 
        int price = 100;
        System.Diagnostics.Debug.WriteLine(string.Format("L'item coute {0:C}", price}) et la vous vous dites WTF ? Moi aussi. 
        donc dans le {0:C} (c'est un placeholder) on a le : 
        0 premier arguement , price qui sera à l'index 0, le premier argumennt on l'écrirs après la virgule.
        : est pour lui dire que c'est le 0 qu'on veut transformer. Enfin jusque la c'est normal
        C : pour Currency, va nous transformer le code en monnaie. 

        en gros ça : 
        int price = 100;
        System.Diagnostics.Debug.WriteLine(string.Format("L'item coute {0:C}", price})
        Va nous print ça : 
        L'item coute 100,00€ (ou $) ===> L'item coute 100,00 €, ho l'autre, il sait qu'il faut mettre en euro t'as vu ?

        on peut donc aller plus loin dans l'exemple avec plusieurs int : 
        int price1 = 50;
        int price2 = 150;
        int price3 = 200;
        Jvais essayer de faire le truc seul !

        System.Diagnostics.Debug.WriteLine(string.Format("Les Items coutent respectivement {0:C}, {2:C} et {1:C}", price1, price2, price3));
        ah et effectivement, c'est comme ça que ça marche. Putain c'est chelou le C# quand même !!!
        --> Les Items coutent respectivement 50,00 €, 200,00 € et 150,00 €. Miracle. 
        
        un autre system de string formating est le P, pour Pourcents. 
        ça va marcher avec un float. 
        En gros si on fait un 
        float percent = 0.5f
        System.Diagnostics.Debug.WriteLine(string.Format("C'est terminé à {0:P} pourcents", percent));
        --> C'est terminé à 50,00 % pourcents. C'est trop la magie t'as vu ? 
         */

        /**************** STRINGBUILDER CLASS ***************/
        /**********  STRINGS ( ͡° ͜ʖ ͡°)  *********************/
        /**************************************************/

        /* 
        Rappels : Strings are IMMUTABLES
        Les modifications que nous avons fait jusqu'à présent résultent en création de nouvelles strings.  
        Si on fait mal les modifications, on va surchargre le heap et du coup aussi faire du mauvais code.
        
        La solution à ça c'est le StringBuilder Class
        une class Strigbuilder permet d'avoir un string avec ses séquences mutables. 
        C'est une class sellée et ne peut pas être subclassée. 
         
        Pour crée un nouveau StringBuilder faut évidement la déclarer : 
        Par contre il vaut invoquer le System.Text; dans les using tout la haut 
        ' using System.Text; 

        -> tout simplement ... 
        StringBuilder stringBuilder = new StringBuilder();
        
         public static void Main(string[] args)
            {
            StringBuilder stringBuilder = new StringBuilder(); // --> au aurait pu appeller stringBuilder cacahouette évidement
            stringBuilder.Append("Hello World");
            for(int i = 0; i <4; i++)
            {
                stringBuilder.Append(" Chuis content de te vois t'as vu ? ");
            }
            string str = stringBuilder.ToString();
            System.Diagnostics.Debug.WriteLine(str);
            stringBuilder.Clear(); // va vider le stringBuilder
            str = stringBuilder.ToString();  // on réassigne str à stringBuilder et on le convertis ToString();
            System.Diagnostics.Debug.WriteLine(str); // du coup ici on a un truc vide vu que c'est clear. FACILE
            // dans ce systeme on n'a pas crée de nouvelles string avec le type string, on a crée un StringBuidler qui garde la même instance. 
        }

         StringBuilder sb = new StringBuilder();
            sb.AppendLine("Hello World"); // --> appendLine rajoute un saut à la ligne du prochain objet
            sb.AppendLine("Hello World"); // -> s'il n'y a rien en dessous ça va faire une ligne vide. 
            System.Diagnostics.Debug.WriteLine(sb.ToString());


        StringBuilder sb1 = new StringBuilder("Hello Monde");
            sb1.Remove(6,5); // va topper l'index 6 et enlever 5 caractères, ici on enlève Monde
            System.Diagnostics.Debug.WriteLine(sb1.ToString());

            StringBuilder sb2 = new StringBuilder("C'est un string avec des espaces et des machins comme ça"); 
            sb2.Replace(" ", ""); // -> ah par contre pour virer les espace dans un texte c'est plus facile qu'en Js ? :o Au lieu d'avoir un vieux text.split(" ").join("")
            System.Diagnostics.Debug.WriteLine(sb2.ToString());


         StringBuilder sb2 = new StringBuilder("C'est un string avec des espaces et des machins comme ça");
            sb2.Replace(" ", ""); 
            System.Diagnostics.Debug.WriteLine(sb2.Length.ToString()); // -> lenght va donner la longueur du StringBuilder (truc de fou non ?)
         */

        /**************** TRAVAILLER AVEC LES ***************/
        /**********  STRINGS ( ͡° ͜ʖ ͡°)  *********************/
        /********** (Oui je laisse le smiley à vie) *******/

        /* 
         Il y a deux façons donc d'initilaliser un string :
        
        string s1 = "";
        ou 
        string s2 = string.Empty; 
         
        s1 = "abc";
        s1.Lenght nous donne la longueur de la String
        s1.IndexOf("b"); va nous donner 1
        s1.ToUpper(); => to uppercase
        s1.ToLower(); => to lowercase
        s1.Insert(3, "d") => insere dans la string, le premier argument est l'index ou on veut l'insérer et le second est ce que l'on veut insérer. 
        s1.Remove(3); => retire ce qu'on indique dans l'index. ici ou on en est c'est d.
        s1.Trim('a'); va retirer tous les a de la string. 
        s1.Replace("bc", "cd"); va virer bc et le rempalcer par la cd (comme dans stringbuilder)

        string s = "Le renard Rapide, saute au dessus du chien feignant, cette phrase n'a aucun putain de sens";
            string[] sArray = s.Split(' '); // alors c'est censé me foutre tous les mots séparés par un espace dans un array. Mais je peux pas console.log l'array après
            j'ai déception

         */

        /**************** VALIDATION **********************/
        /**********  STRINGS ( ͡° ͜ʖ ͡°)  *********************/
        /**************************************************/

        /* 
        
        différentre entre string emtpy et null ? 
        alors OUI évidement
        notez que 
        string s = string.Empty; à en fait une valeur. Puisqu'au final, ""; c'est une valeur. T'as gépi ? 
        alors que 
        string s = null; n'en a pas

        Alors du coup il y a une methode super sympa en c# qui s'appelle .IsNullOrEmpty() qui permet de check ces deux paramètres en même temps.
        Ce qui au fond est carrèment trop sympa =) Surtout pour la validation de formulaires par exemple.
         
        */


        /*********************************************************************************************************/
        /************************  BOOLEANS *********************************************************************/
        /*******************************************************************************************************/

        /*  
        alors heu c'est oui ou non, vrai ou faux, True or False
        HOOULA alors on peut EVENTUELLEMENT, enfin, genre. C'est FAISABLE d'assigner NULL à un BOOLEAN en c# (nique toi ?)

        bool? example = null; 
        example pourra avoir la valeur de null, true or false. OK ....
         
         */

        /************** LOGICAL OPERATORS ******************/
        /**********  BOOLEANS *****************************/
        /*************************************************/

        /* 
        le ! check si c'est pas la condition. Genre 
        bool completed = false; 
        on peut faire un if(!completed) { do something }

        Pour les && du js on a un simple & dans le c#
        Faut que les deux trucs soient true pour qu'ils soit true. 
        if(true & true) => true
        if(true & false) => false
        
        Pour le double || de notre Js adoré il est remplacé par un | tout moche et tout simple, parce que les gens, dans le c# ils sont tristes.
        Faut que l'un seul des deux soit true pour qu'il soit true.
        if(true | true) => true
        if(true | false) => true

        Ah ya quand même les doubles && et les doubles ||. Mais les gens dans le c# doivent quand même être triste.
        En gros il va checker si le premier est vrai, enfin si le premier à le resulat attendu, si oui, il passe à l'autre pour checker, sinon il laises tomber.
         
         */

        /************** FLAG TECHNIQUE *********************/
        /**********  BOOLEANS *****************************/
        /*************************************************/

        /* 
        On crée un bool :
        bool flag = false; 
        On crée une liste d'INT. Alors pour qu'il check la class list il faut : 
        using System.Collections.Generic; tout la haut
        List<int> intList = new List<int>() {1,2,3};
         
          bool flag = false;
            List<int> intList = new List<int>() { 1, 2, 3 };

            foreach(int i in intList)
            {
                if(i == 3)
                {
                    flag = true;
                }

                if(flag)
                {
                    System.Diagnostics.Debug.WriteLine("On a trouvé le 3, entre nous, dans le code, je l'avais déjà vu en vrai");
                }
            }

         */

        /*********************************************************************************************************/
        /**** NULL *** NULL ********  NULL ******* NULL *** NULL ***** NULL *********NULL****** NULL ***** NULL */
        /*******************************************************************************************************/

        /* 
         Null signifique que le truc n'a pas de valeur. Généralement c'est pas super bon signe en c#. Notez que c'est généralement une erreure très commune de :
        "NULL REFERENCE EXEPTION". Ce qui arrive quand on lance une fonction avec une variable qui n'a pas de valeur. 
         On peut assigner NULL a pas mal de trucs 
         object o = null; 
        comme pour le boolean on peut aussi assigner du nul à d'autres types de temps en temps. 
        bool? example = null; 
        int? exint = null; 
        char? exchar = null; 
        etc etc
         
         */

        /*********************************************************************************************************/
        /************************  CONVERSION DE VARIABLES ******************************************************/
        /*********** BOXING ****************************** UNBOXING ********************************************/

        /* 
        Alors RE quelques bases : 
        - C# est un language TRES TYPé
        - Chaque Variable à une type qui lui est associé
        - C'est pas tous les languages qui sont strongly typed (genre dynamique) tiens on parle de Js ou de Python ? 
         
        * UN TYPE, peut contenir plus d'informations qu'on ne le pense. 
        - Elle peut renseigner l'espace disque dont un type à besoin
        - Les valeurs max et min qu'elle peut prendre
        - ses Membres
        - Quels types héritent de ses proprietés
        - L'emplacement de la mémoire d'ou les variables vont venir
        - Le type (lol) d'operations qu'on a l'autorisation de faire. 
          
        Tout les types que C# peut utiliser : 
        BOOL // BYTE // SBYTE // CHAR // DECIMAL // DOUBLE // FLOAT // INT // UINT // LONG // ULONG // OBJECT // SHORT // USHORT // STRING

        Notez que vous avez également des type custom : 
        STRUCS // CLASSES // INTERFACE // ENUMS
      
        (rappel que dans Js, les primitives sont : BOOL // STING // NUMBER // UNDIFINED // NULL // SYMBOL (et BigInt depuis 2020)) 

        N'oubliez pas que 
        1/ L'héritages entre les variables est importante. 

        2/ il y a deux types de types. Les VALUES TYPES qui contiennent déjà leurs valeurs. Comme Bool qui con tient déjà True et False et les
        REFERENCE TYPES qui sont null de bases (quand on les appelle pas, ouais c'est compliqué non ?) et auquels ont peut assigner une valeur. (genre les autres en gros)

        Alors on en reviens à nos moutons : au niveau de la conversion il y a plusieurs versions : 
        1/ Conversion Implicites :
         int num = 3;
         float f = num; 
        On a transformé l'int en float, donc le 3 devient un 3.0 tout simplement, aucun problème en gros. 

        2/ Conversions Explicites :
        float f = 1.5f;
        int example = (int)f;
        On dit clairement : transforme ce f en int

        3/ Conversions définies par l'utilisateur :
        On les verra plus tard ...
        4/ Conversion avec la Helper Class :
        On les verra plus tard ...

        */

        /***************************************************/
        /**********  BOXING && UNBOXING *******************/
        /*************************************************/

        /*
        
        Ici on se crée un int avec la valeur de 1 (facile)
        int example = 1;
        object o = example; -> on va le (boxer) on l'emboiter dans un objet. ici o. 
        int example2 = (int)o; --> ici on va l'unboxer (le déballer) en lui assignant une nouvelle valeur example2. En lui indiquant qu'on veut cast un (int) de o.
        C'est le genre de truc memory consuming (je parle comme JCVD t'as vu ?) donc à pas utilliser à tord et a travers.
        Bon l'exemple doit pas être cirant de veritié sur ce qu'il y a a faire ou pas faire. Mais sur des gros trucs ça doit pouvoir devenir catastrophique.

         */

        /***************************************************/
        /**********  ANNONYMOUS TYPE **********************/
        /************* DYNAMIC TYPE **********************/

        /* 
        Ah la on sait me parler !
        C'est quand on blance son plus beau var. 
        ANNONYMOUS (we are legion)
        var example1 = 1;
         
        DYNAMIC TYPE : 
        (c'est pour bascule en mode JavaScript)
        dynamic example2 = 1;
        
         */

        /***************************************************/
        /**********  VALUE && REFERENCE TYPE **************/
        /**************************************************/

        /* 
        Ok on deepdive dans un truc qu'on a déjà vu tout à lheure. N'oubliez pas que l'apprentissage vient de la répétition. 
        
        Tous les types en c# ont soit un type valeur soit un type référence. 
        - un type valeur contient sa propre valeur en mémoire (comme bool)
        - elle dérive de System.ValueType

             public static void Main(string[] args)
        {
            // do something
            int i = 200;
            System.Diagnostics.Debug.WriteLine("1 " + i);
            ChangeValue(i);
            System.Diagnostics.Debug.WriteLine("2 " + i);
        }

        static void ChangeValue(int num)
        {
            num = 500;
            System.Diagnostics.Debug.WriteLine("3 " + num);
        }

        --> REPONSE : 
        1 200
        3 500
        2 200
        }
        Je trouve cet exemple complètement con. Enfin je me doutait de la réponse vu qu'on définis num dans le ChangeValue ... BREF
        n'est stupide que la stupidité après tout. 

         public static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "Old Person";
            System.Diagnostics.Debug.WriteLine("1 " + p.Name); --> va sortir un "Old Person"
            ChangeReferenceType(p);
            System.Diagnostics.Debug.WriteLine("2 " + p.Name); --> va sortir le "New Name"
        }

        public class Person
        {
            public string Name; 
        }

        static void ChangeReferenceType(Person person)
        {
            person.Name = "New Name";
        }

         */

        /*********************************************************************************************************/
        /************************ DATETIME  ********** TIMESPAN *************************************************/
        /*******************************************************************************************************/

        /* 
         Pour checker le DateTime Class
        Pour check le TimeSpan Class
        Formatter des dates et des heures
        Check l'UTC time.
        Notez que ça a l'air de moins puer le sapin que sur Js, enfin sur Js c'est le plus gros caca qu'ils aient pondu.
        mais ça vient surtout du fait que c'est un truc qui est la depuis 1995 
        
        System.Diagnostics.Debug.WriteLine(DateTime.Now); => va donner un vrai truc genre 19/03/2022 15:05:15

        Sinon on fait un peu comme d'habitude pour ce genre de trucs : 
        DateTime date = new DateTime();
        
        DateTime date = new DateTime(2020, 1, 19);
        System.Diagnostics.Debug.WriteLine(date);
        va donner :  19/01/2020 00:00:00
        (l'heure est comme ça, vu qu'on a pas demandé l'heure en vrai)


        TimeSpan va donner la durée depuis x temps. On peut lui appliquer différentes méthodes pour qu'il nous donne les heures, minutes etc. 
        Maintneant je pense qu'on peut le combiner avec des DateTime pour nous donner un écart entre deux dates etc. Enfin je pense NON ? Si
        Probablement. Qu'est ce que je dois dire ?

          TimeSpan timespan = new TimeSpan(1,2,0);
            System.Diagnostics.Debug.WriteLine(timespan.Hours); // va donner 1
            System.Diagnostics.Debug.WriteLine(timespan.Minutes); // va donner 2
            System.Diagnostics.Debug.WriteLine(timespan.Seconds); // va donner 0

         */

        /***************************************************/
        /**********  FORMATTING TIME IN C# ****************/
        /**************************************************/

        /* 
        On peut joliement formater les dates et les heures avec le DateTime.Now.ToString("ecrirre comment on veut la date")

       J'avoue leurs trucs est quand même utilisable. N'oubliez pas qu'en Js, on a un chiffre en milisecodnes, entre maintenant et 1970. FUCK THAT SHIT

       System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("MM/dd/yyyy")); // --> 03 / 19 / 2022
       System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("dddd, dd, MMMM yyyy")); // --> samedi, 19, mars 2022
       System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("dddd, dd, MMMM yyyy HH:mm:ss")); // -> samedi, 19, mars 2022 15:16:41 TROP CLASSE
       System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("MM/dd/yy hh:mm tt")); // 03/19/22 03:18 en AM/PM par contre pour des raisons il me l'écris pas (je pense c'est parceque je suis en Rance)
         
         */

        /***************************************************/
        /**********  UTC TIME *****************************/
        /*************************************************/

        /* 
        L'UTC sert pour l'UNIVERSAL COORDONATED TIME. C'est pour qu'on puisse pas gruger au niveau des heures, par exemple au niveau des applications. 
         
        System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("dddd, dd, MMMM yyyy HH:mm:ss"))
        System.Diagnostics.Debug.WriteLine(DateTime.UtcNow.ToString("dddd, dd, MMMM yyyy HH:mm:ss"))
        NOW dimanche, 20, mars 2022 17:52:25
        UTCNOW dimanche, 20, mars 2022 16:52:25

        On peut aussi les écrire de cette manière : 
        System.Diagnostics.Debug.WriteLine(DateTime.Now.ToUniversalTime().ToString("dddd, dd, MMMM yyyy HH:mm:ss"));

        Ou encore dans l'autre sens : 
        System.Diagnostics.Debug.WriteLine(DateTime.UtcNow.ToLocalTime("dddd, dd, MMMM yyyy HH:mm:ss"));

        Si on veut savoir la valeur de la Date (si elle est en local ou en UTC) Il y aussi une méthode pour ça : 
        Alors la de suite je comprends pas trop à quoi elle sert parce qu'au fond ... Bha c'est écris juste avant ? =)
        System.Diagnostics.Debug.WriteLine(DateTime.Now.Kind);
        System.Diagnostics.Debug.WriteLine(DateTime.UtcNow.Kind);

         */

        /*********************************************************************************************************/
        /************************ CONTROL FLOW STATEMENT AND LOOPS **********************************************/
        /*******************************************************************************************************/


        /***************************************************/
        /**********  IF SELS IF ELSE **********************/
        /*************************************************/

        /* 
        Bon j'en mets pas ma main à couper, des fois qu'il y aie un null qui traine pour rien ? Bref sinon ça marche comme dans dans Js 
         
        Ouais donc ouais globablement c'est bha pareil
        Bon pour le if, yen a toujours qu'un par colone (par contre ça je ne fais pas en Js me semble, enfin Js s'en cogne)

        Après ya autant de "else if" qu'on veut

        if(5 > 3) { console.("yes papa") }
        else if ( 4 < 2 ) { console.("non") }

        ah si on fait un truc avec deux vrais et que le premier est un if et que le second est un else if, il va s'arrêter que si le if est skip
        spour ça que tu peux mettre deux if de suite stu veux. Mais c'est des codes blocks differents. T'as vu, trop la classe. 

        le dernier de la lignée sera toujorus un petit else qui va bien. 

        Ce sont les trucs qui générent le code le flow du code. Par contre s'il y en a beaucoup, ça ajoute du code spaghetti (à ralonge) pour rien.

        */

        /***************************************************/
        /**********  SWITCH STATEMENTS ********************/
        /*************************************************/

        /* 
         Bon alors encore une fois, c'est un truc qui marche de la même façon qu'en Js, du coup, bha du coup. 
        En gros alors, oui oui c'est ça, le default etc, la même chose. 

        J'adore le fait qu'il ai pris comme un exemple un truc genre "ah ça fait sale en else if et mets un truc vraiment dégeulasse en switch case aussi :D

         int value = 2;

            switch (value)
            {
             case 1:
                     System.Diagnostics.Debug.WriteLine("1");
                     break;
             case 2:
                      System.Diagnostics.Debug.WriteLine("2");
                     break;
            case 3:
                     System.Diagnostics.Debug.WriteLine("3");
                    break;
            case 5:
                     System.Diagnostics.Debug.WriteLine("5"); 
                     break;
            default:
                    System.Diagnostics.Debug.WriteLine("Autre");
                    break; 
            }
        
         */

        /***************************************************/
        /**********  FOR LOOPS ****************************/
        /*************************************************/

        /* 
        Bon alors, il me semble que c'est pareil que dans js ? :D
        ah et le Lenght ici prends une majuscule, parce que pourquoi copier coller tout mais changer UN POIL pour que ce soit pareil ? Ah et le i il faut le typer aussi évidement. 

        for(int i = 0; i < 5; i++){
         System.Diagnostics.Debug.WriteLine("HELLO FUCKING WEULRD");
        }


        string example = "AbCdeEF";

        for(int i = 0; i < example.Lenght; i++) { 
        System.Diagnostics.Debug.WriteLine(example[i])
        }
         
        On peut inverser les for loop en inversant l'odre des statements dans le for
        for(int = example.Lenght - 1; i >= 0; i--) { 
        System.Diagnostics.Debug.WriteLine(example[i])
        }


        ya une autre 'façon' d'écrire une boucle for() comme ça. Enfin j'ai plus l'impression que c'est genre comment ça fonctionne under the hood. 
        int i = 0;
        for(; ;)
        { 
        if(i < 4) { 
        System.Diagnostics.Debug.WriteLine(i.ToString());
        }
        }

        On peut bien évidement écrire un for loop dans un autre for loop : 

        for(int i = 0; i < 5; i ++) {

            for(int j = 0; j < 5; j++) {
        
        }

        Bon la, le i tourne cinq fois, et le j tourne 25 fois (cinq fois par i au final, ouais je sais compter)

        }

         */


        /* JE ME SUIS ARRÊTER LESSON 7 EPISODE 4*/ 


        public static void Main(string[] args)
        {
            // do something 






           
        }
    } 
}



