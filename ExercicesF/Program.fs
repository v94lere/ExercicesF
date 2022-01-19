
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

///Exercice 2

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

///Exercice 3
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

let entraineurPacer = creerEntraineur  nom: "Larry Bird" ancienJoueur: true
val statPacer = creerStats victoire: 58; defaite: 24
let equipePacer = creerEquipe nom: "Indiana Pacers";  entraineur: entraineurPacer stat: statPacer

let entraineurLakers = creerEntraineur  nom: "Del Harris";  ancienJoueur: false
let statLakers = creerStats victoire: 61; defaite: 21
let equipeLakers = creerEquipe  nom: "LA Lakers";  entraineur: entraineurLakeres; stat: statLakers

val memeEquipe equipePacer: equipes; equipeLakers |> printfn  memeEquipe
