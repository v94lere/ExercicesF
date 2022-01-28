/// Exercices réaliser sous F# 
open system

/// Exercices calcul
 
let five = 5
let seven = 7
let cube (x : int) = x * x * x
printfn "x: %i" (cube(five))
printfn "x: %i" (cube(seven))

///Exercice 1
let interestRate (balance: decimal): single =
  match balance with
  | solde when solde < 0m -> 3.213f
  | solde when 0m <= solde && solde <1000m -> 0.5f
  | solde when 1000m <= solde && solde < 5000m -> 1.621f
  | solde when solde > 5000m -> 2.475f
  | _ -> 0f

interestRate (200.75m) |> printfn "%f"

///Exercice Chaine de caractères

let interest (balance: decimal): decimal =
 System.Convert.ToDecimal (interestRate (200.75m)) * balance / 100m

interest (200.75m) |> printfn "%f"

///Exercice 3
let annualBalanceUpdate(balance: decimal): decimal =

 balance + interest(200.75m)


annualBalanceUpdate (200.75m)|> printfn "%f"

///Exercice 4
let amountToDonate(balance: decimal) (taxFreePercentage: float): int =
    int(balance / 100m * decimal(taxFreePercentage) * 2.0m);

let solde = 550.5m;
let taxe = 2.5;

amountToDonate solde taxe |> printfn "Don : %i"

///Exercice 2
///1
let message (txt: string): string =
    txt.Substring(txt.IndexOf(':') + 2)

message "[WARNING] : Disque presque plein" |> printfn ("%s")

///2
let logLevel (txt: string): string =
    txt.Substring(txt.IndexOf('[') + 1, txt.IndexOf(']') - 1).ToLower()

logLevel "[ERREUR] : Disque presque plein" |> printfn ("%s")

///3
let reformat (txt: string): string =
    message(txt) +  " (" + logLevel(txt) + ")"

reformat("[INFO] : Opération terminée") |> printfn("%s")

/// Manipuler les caractères
let talkToBob(message: string): string =
    match message with
    | i when (i.EndsWith("?")) -> "Bien sûr";
    | i when (i = i.ToUpper()) -> "Whoa, calme-toi !";
    | i when (i = i.ToUpper() && i.EndsWith("?")) -> "Calme-toi, je sais ce que je fais";
    | i when (i.Length = 0) -> "Très bien. Sois comme ça";
    | _ -> "Peu importe";
printfn "Bob: %s" (talkToBob("COMMENT ÇA VA ?")); // -> renvoi Bien sûr car le pattern est avant le isUpper


///Exercice Basket-ball
type entraîneurs = {
 nom: string
 ancienJoueur: bool
     };
 
type statistiques = {
     victoires: int
     defaites: int
 };
 
 type equipes = {
 nom: string
 entraineurs: entraîneurs
 stats: statistiques
 }

let creerEntraineur(nom: string, ancienJoueur: bool): entraîneurs=
       {nom = nom; ancienJoueur = ancienJoueur}

 
let creerStats(victoire: int, defaite: int): statistiques=
       {victoires = victoire; defaites = defaite}


let creerEquipe(nom: string, entraineur: entraîneurs, stat: statistiques): equipes=
       {nom = nom; entraineurs = entraineur; stats = stat}

let remplacerEntraineur(equipe: equipes, entraineur: entraîneurs): equipes=equipe

let memeEquipe(equipe1: equipes, equipe2: equipes): bool=
       equipe1 = equipe2

let entraineurPacer = creerEntraineur ("Larry Bird", true)
let statPacer = creerStats (58, 24)
let equipePacer = creerEquipe ("Indiana Pacers", entraineurPacer, statPacer)

let entraineurLakers = creerEntraineur  ("Del Harris", false)
let statLakers = creerStats (61, 21)
let equipeLakers = creerEquipe  ("LA Lakers", entraineurLakers, statLakers)

memeEquipe (equipePacer, equipeLakers) |> printfn "%b"
