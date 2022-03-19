using System;

namespace ExampleProj
{
    class Program
    {
        // static signfifie que la methode peut être appellé sans objet
        // void signifie qu'elle n'attends pas de résultat/valeur
        // Main() est le nom de la fonction elle même. Attention c# fait attention aux minuscules et aux majuscules
        // les {} ou va ou le code à exectuter
        // par default la fonction sera "private" on peut l'écrire devant :
        // " private static void Main() "
        // pour la rendre public on fait l'inverse : 
        // " public static void Main() "
        // On peut indiquer quel type d'argument in va recevoir, par exemple ici, il va recevoir un String (je sais pas encore pourquoi ya un array au bout) et avec un argument (args)
        // on peut l'appeller cacahouette si ça nous chante
        // on peut écrire la fonction Main() de pleins de façons differents. (ya des asyncs etc)
        // t'as vu les hello world de ouf ? =)
        // System.Diagnostics.Debug.WriteLine("Hello World");
        // Console.WriteLine("Hello World");


        // conditions :
        // jusque la rien de novueau sauf qu'on écris les primitives en bool. Après je sais que dans c# on peut faire var complete = false par exemple
        /* bool complete = false;
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

        // Loooooooooooooooooooppps 
        // ya du for et du while comme dans Js, les copieurs t'as vu ? houla le mec va vite et donnes pas des exemples de ouf =//

        /* List<string> collection = new List<string>() { "a", "b", "c" };
        for (int i = 0; i < collection.Count; i++)
        {
            System.Diagnostics.Debug.WriteLine(collection[i] )

        } */

        // WHile 
        // faut dire que les boucles while et for ressemblent beaucoup au Js, comme s'ils avaient copié ? 
        /* int i = 3;
         while(i>0)
         {
             System.Diagnostics.Debug.WriteLine("Loading");

         }*/

        // FUNCTIONS && METHODS 
        // alors ça marche un peu pareil que dans le Js encore une fois, à quelques différences prés. Déjà l'écriture même de la fonction, il faut la faire précéder de void, de public, static etc. (je pense que ça viendra avec le temps assez facilement)

        /* PrintMessage("Hello World");

         // pour l'exemple j'avais écris ça en dehors de la Main() je ne sais pas encore si on peut écrire des fonction dans des fonctions. 
         // Jvais tester pour la science ici ?
         // spoiler alert : on peut, enfin je suppose que ça reste dans le scope de cette fonction en particulier ? (possiblement)
         static void PrintMessage(string message)
         {
             Console.WriteLine(message);
         } */

        // LES ERREURS, ya trois types d'erreurs différentes : 
        // Syntax Error: on a écris un truc pas comme il fallait (probablement une string à la place d'un char, un array à la place d'un array etc)
        // Logic Error : Le code fait pas ce qu'on lui dit de faire (lol dans le cul ? )
        // Runtime error : Une erreur apparaissant pendant que le code se lance

        // SYNAXE DU C#

        // case sensitive language : 
        // int example = 1;
        //  int EXAMPLE = 1; 
        // deux entités de example different. Faut TOUJOURS TOUJOURS finir par une ; ....

        // les {} montrent ou commencent et finissent les scope des fonctions
        // c# va dans une class  

        // il y a quatre modificateurs d'accès dans c# : 
        // PUBLIC : tout le monde peut y accéder, par les autres class par exemple
        // PROTECTED : seulement quelques autres class spécifiques peuvent accèder aux datas de ces trucs. On dirait genre ce qu'on écrirait dans un scope ? les class qui "extends" ladidte classe aura accès aux infos dans la private
        // PRIVATE : ne sera dispo QUE dans la class 
        // INTERNAL : seulement utilisable  "l'assembly?" (un truc qui regroupe le code, on va pas l'utiliser de suite mais un peu plus tard si j'ai bien compris)


        // C# a des attributs aux codes pour y ajouter des informations


        // on peut genre rendre un string private ? (ok) et l'appeller plus tard dans un truc public (ok ?)
        // donc dans Name on appelle la valeur de name en prennant sa valeur et on retourne la QUOI ? déjà ça devrait pas être l'inverse ? 
        // et après tout le monde détéste Js ? Fuck la planète

        // j'en étais au COURST 4 // Basic Syntac // Lesson 11
        /*  private string name = "robert";

         public string Name
         {
             get { return name; }
             set { name = value; }
         } */

        // MODULOS : % vont donner le restant d'une fraction. Genre 5 % 4 = 1 mais 4 % 4 = 0. Je me demande si c'est pas utilisé pour voir si c'est pair un impaire en gros =)
        // Console.WriteLine(124 % 2);

        // INCREMENT ET DECREMENT operators
        // ++ RAJOUTE 1
        // -- ENLEVE 1
        // rajoute en eleve 1 à une valeur
        // int number = 4;
        // number++;
        // console.log(number) ===> 5 

        // IS OPERATOR équivalent au typeof ? MAIS PAS TOUT A FAIT ....

        // bool b = "abc" is string; <== oui c'est un vrai truc
        // le console.writeline(b); va répondre true
        // par contre bool b = "abc" is int <== encore un vrai truc ? oui oui
        // le console.writeline(b); va répondre false. PARCE QUE C'EST FALSE \o/

        // on va pousser un peu peu plus loin : créons Ex1 et Ex2, Ex2 extends Ex1 d'ailleurs


        // OPERATEUR IS
        // public class Ex1 { }
        // public class Ex2 : Ex1 { }
        // Ex2 ex2Object = new Ex2();
        // bool b = ex2Object is Ex1;
        // System.Diagnostics.Debug.WriteLine(b);
        // va donner TRUE parce que Ex1 est une extention de Ex2. Forcmement vu que ex2Object à été crée à partir d'un Ex2 qui est Ex1 extend t'as pigé ? moi oui.
        // tu remarquera que pour expand une class, contrairement à Js on lui mets ":" au lieu du mot clefs expands.

        // operateur AS, marche un peu comme on pense qu'il devrait marcher. 
        // string s1 = "abc"; 
        // object obj1 = s1;
        // string s2 = obj1 as string; 

        // les ternaires fonctionnent pareil que dans Js
        // le "ternaire" "&&" fonctione avec des "??"

        // siseof() donne nombre de bytes que la variable va prendre, retourne un int. 

        // typeof() n'est pas vraiment beaucoup utilisé. C'est comme dans JS, ça nous donne le type. Par exemple in typeof(int) va nous donner un System.Int32 parce que c'est ce qui se passe réelement. Est ce qu'on a besoin de savoir tout réelement ? NON 
        // surtout qu'au final tout est déjà typé

        //Operator Overloading
        // c'est pour additionner deux trucs qui ne devraient apparement PAS être additionnables ? Ou lui indiquer COMMENT additioner ces deux items. Le mystère reste mysterieux.
        // alors ça se complique un poil ^-^' 
        // on va prendre cet exemple avec la class Box. On va lui donner trois mesures. Puis lui crée une fonction pour qu'il connaisse ces mesures. 
        // ensuite on va crée trois fonction pour retourner les mesure. (putain ?)
        // ENSUITE on va crée une fonction d'operator overload. 

        //    class Box
        //    {
        //        private int lenght;
        //        private int width;
        //        private int height; 

        //        public Box(int lenght, int width, int height)
        //        {
        //            this.lenght = lenght;
        //            this.width = width;
        //            this.height = height; 
        //        }

        //        public int GetLenght()
        //        {
        //            return lenght; 
        //        }

        //        public int GetWidht() 
        //        {
        //            return width; 
        //        }  

        //        public int GetHeight()
        //        {
        //            return height; 
        //        }

        //        public static Box operator +(Box box1, Box box2)
        //        {
        //            return new Box(box1.GetLenght() + box2.GetLenght(),
        //                            box1.GetWidht() + box2.GetWidht(),
        //                            box1.GetHeight() + box2.GetHeight());
        //        }
        //    }
        //    public static void Main(string[] args)
        //    {
        //        Box box1 = new Box(2, 2, 2);
        //        Box box2 = new Box(2, 2, 2);
        //        Box box3 = box1 + box2;

        //        System.Diagnostics.Debug.WriteLine("Lenght: " + box3.GetLenght());
        //        System.Diagnostics.Debug.WriteLine("Widht: " + box3.GetWidht());
        //        System.Diagnostics.Debug.WriteLine("Height: " + box3.GetHeight());

        //    }
        //}

        // Comme dans tous les languages, C# dispose d'un paquet de noms reservés, ce sont les noms qui servent comme async await etc. 
        // comme dans les autres languages, ce qui est bien, au top, c'est de ne pas les utiliser comme noms de variables t'as vu ? 

        public static void Main(string[] args)
        {
        }

    }
}
