// Learn more about F# at http://fsharp.net. See the 'F# Tutorial' project
// for more guidance on F# programming.
#I @"C:\Development\GenImport\packages\RavenDB.Client.2.0.2330\lib\net40\"
#r "Raven.Client.Lightweight.dll"


#load "Library1.fs"
open Informedica.GenImport.GStandard.FSharp

// Define your library scripting code here
let path = @"c:\tmp\062012\"
let productfile = "BST031T"
let genericfile = "BST031T"
let namefile = "BST020T"
let thesauriTotalFile = "BST902T"
let fieldsFile = "BST001T"
let groupFile = "BST500T"

let getlines p f = System.IO.File.ReadAllLines(p + f)
let getlinesfromfile = getlines path

type Position = {Start: int; End: int}

let getPosition (p:Position) (l: string) = 
    l.Substring(p.Start - 1, p.End - p.Start) 

let splitLine (pl: Position list) (l: string) =
    pl |> List.map(fun pos -> l |> getPosition pos)

let splitFile (pl: Position list) (f: string list) =
    f |> List.filter(fun line -> line.Length > 11) |> List.map(fun line -> line |> splitLine pl)    

type TherapeuticGroup = { Id: string; Name: string; Text: string }

let grouplist (l: string list list) = 
    l |> List.map(fun g -> { Id = null; Name = g.[0]; Text = "" })

let store = 
    let store = new Raven.Client.Document.DocumentStore()
    store.Url <- @"http://localhost:8080"
    store.Initialize()

let write (database: string) (s: Raven.Client.IDocumentStore) data =
    use s = s.OpenSession(database)
    do s.Store(data)
    do s.SaveChanges()

let writelist (database: string) (s: Raven.Client.IDocumentStore) =
    write database s

let writeListToTest data = writelist "Test" store data

let storelist w l = 
    l |> List.iter(fun d -> d |> w)
