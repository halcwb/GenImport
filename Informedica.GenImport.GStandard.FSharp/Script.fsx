// Learn more about F# at http://fsharp.net. See the 'F# Tutorial' project
// for more guidance on F# programming.
#I @"C:\Development\GenImport\packages\RavenDB.Client.2.0.2330\lib\net40\"
#r "Raven.Client.Lightweight.dll"
#I @"C:\Development\GenImport\packages\RavenDB.Client.2.0.2330\lib\net40\"
#r "Raven.Abstractions.dll"


#load "Library1.fs"
open Informedica.GenImport.GStandard.FSharp
open Raven.Client
open Raven.Client.Extensions

// Set up the document store
let store = 
    let store = new Raven.Client.Document.DocumentStore()
    store.Url <- @"http://localhost:8080"
    store.Initialize()

// Delete the database, note database map still has to be deleted on disk
let deleteDatabase (store: Raven.Client.IDocumentStore) (name: string) hard =
    let maxdatabases = 10
    let cmd = store.DatabaseCommands
    if (cmd.GetDatabaseNames(maxdatabases) |> Array.exists(fun n -> n = name)) then
        let url = "/admin/databases/" + name

        let client  = cmd.ForSystemDatabase() :?> Raven.Client.Connection.ServerClient
        let jsonReq = client.CreateRequest("DELETE", url)
        do jsonReq.ExecuteRequest()

let createDatabase(store: Raven.Client.IDocumentStore) name =
    let cmd = store.DatabaseCommands
    cmd.EnsureDatabaseExists(name)
    

// Define G-Standard files
let path = @"c:\tmp\062012\"
let productfile = "BST031T"
let genericfile = "BST031T"
let namefile = "BST020T"
let thesauriTotalFile = "BST902T"
let fieldsFile = "BST001T"
let groupFile = "BST500T"

// Define G-Standard structure
type Position = {Start: int; End: int}

type GFile = { Name: string; Path: string }

type GField = { Name: string; Position: Position; ForeignKey: GFile list option }

type GStruct = { File: GFile; FieldList: GField list}

// Read files
let getlines p f = System.IO.File.ReadAllLines(p + f)
let getlinesfromfile = getlines path


// Parse files
let getPosition (p:Position) (l: string) = 
    l.Substring(p.Start - 1, p.End - (p.Start - 1)) 

let splitLine (pl: Position list) (l: string) =
    pl |> List.map(fun pos -> l |> getPosition pos)

let splitFile (pl: Position list) (f: string list) =
    f |> List.filter(fun line -> line.Length > 11) |> List.map(fun line -> line |> splitLine pl)    

// Write to database
let write (database: string) (s: Raven.Client.IDocumentStore) data =
    use s = s.OpenSession(database)
    do s.Store(data)
    do s.SaveChanges()

let writelist (database: string) (s: Raven.Client.IDocumentStore) =
    write database s

let writeListToTest data = writelist "Test" store data

let storelist w l = 
    l |> List.iter(fun d -> d |> w)

// Create therapy group documents
//Bestandsbeschrijvingen: Bestand 500 Informatorium groepen
//
//Veld	    Omschrijving	    SR1	    Lengte2	    Type3	    Posities
//BSTNUM	Bestand-nummer		        4	        N	        001-004
//MUTKOD	Mutatiekode		            1	        N	        005-005
//GRPINP	Groepkode	        1O	    4	        N	        006-009
//          Leeg veld		            1	        A	        010-010
//GRPNAM	Groepnaam		            50	        A	        011-060
//XRPO1	    Groepvolgorde kode		    11	        N	        061-071
//          Leeg veld		            25	        A	        072-096

type TherapeuticGroup = { Id: string; GroupCode: string; Name: string; Text: string; HiearchyCode: string list; Groups: TherapeuticGroup list }    

let hiearchyCode (c: string) = [c.Substring(0,3);c.Substring(2,2);c.Substring(4,2);c.Substring(6,2);c.Substring(8,2)] |> List.filter(fun s -> s = "00" |> not)

let createGroup (sl: string list) = { Id = ""; GroupCode = sl.[0] ; Name = sl.[1].Trim(); Text = ""; HiearchyCode = (sl.[2] |> hiearchyCode); Groups = [] }

let addGroup (g1: TherapeuticGroup) (g2: TherapeuticGroup) =
    { g1 with Groups = match g1.Groups with |[] -> [g2] | _ -> g2::g1.Groups  } 

let addGroups gl group = { group with Groups = gl } 

let isParentOf g1 g2 = g1.HiearchyCode |> Seq.take (g1.HiearchyCode.Length - 1) |> Seq.toList = g2.HiearchyCode

let findParent l c = l |> List.tryFind(fun p -> p |> isParentOf c)

let hasParent l c = c |> findParent l = None

let isRoot gl g =
    gl |> List.exists(fun p -> p |> isParentOf g && not (p = g)) |> not   

let hasChildren gl p = gl |> List.exists(fun c -> p |> isParentOf c)

let isChild gl c = not (c |> hasChildren gl) && not (c |> isRoot gl)

let addChildren gl g = 
    printfn "Adding children for %A " g.Name   
    let rec add g ch =
        match ch with 
        | [] -> g
        | head::tail -> tail |> add (head |> addGroup g)

    gl |> List.filter(fun c -> g |> isParentOf c) |> add g


let groupList (l: string list list) = 
    l |> List.map(fun g -> g |> createGroup)

let groups = 
    let positions = [{Start = 6; End = 9};{Start = 11; End = 60};{Start = 61; End = 71}]
    groupFile |> getlinesfromfile |> Array.toList |> splitFile positions |> groupList 

let partNodes l = l |> List.partition(fun g -> g |> isRoot l)

let buildTree groups =
    let rec build nodes =
        match nodes |> partNodes with
        | roots, nodes when nodes |> List.length = 0 -> printfn "No more nodes"; roots
        | roots, nodes  -> printfn "roots: %A, nodes %A" roots.Length nodes.Length
                           roots |> List.map(fun g -> g |> addGroups ((nodes |> List.filter(fun n -> g |> isParentOf n) |> build)))

    build groups
     
// Some test groups
let overige    = groups |> List.find(fun g -> g.Name = "OVERIGE DIURETICA")
let diuretica  = groups |> List.find(fun g -> g.Name = "DIURETICA")
let protozoica = groups |> List.find(fun g -> g.Name = "ANTIPROTOZOICA")

groups |> buildTree |> storelist writeListToTest

// Delete a collection of documents in the test database
let deleteByIndex (store: IDocumentStore) index =
    let query = new Raven.Abstractions.Data.IndexQuery()
    query.Query <- ("Tag: " + index)
    let session = store.OpenSession()
    session.Advanced.DocumentStore.DatabaseCommands.ForDatabase("Test").DeleteByIndex("Raven/DocumentsByEntityName", query, true)
    do session.SaveChanges()

//MSNAAM	Merkstamnaam		50	A	037-086
    
//GRP001	FTK 1		4	N	201-204
//GRP002	FTK 2		4	N	205-208
//GRP003	FTK 3		4	N	209-212
//GRP004	FTK 4		4	N	213-216
//GRP005	FTK 5		4	N	217-220


type Product = { Name: string; FTK: TherapeuticGroup list } 

let productGroups groups (ftk: string) = 
    let sl = [0..4..15] |> List.map(fun i -> ftk.Substring(i, 4))
    groups |> List.filter(fun g -> sl |> List.exists(fun fk -> fk = g.GroupCode))

let createProduct (sl: string list) = { Name = sl.[0].Trim(); FTK = sl.[1] |> productGroups groups } 
 
let productList (l: string list list) = 
    l |> List.filter(fun sl -> sl.[0].Trim() = "" |> not) |> List.map(fun g -> g |> createProduct)

let products =
    let positions = [{Start = 37; End = 86};{Start = 201; End = 220}]
    productfile |> getlinesfromfile |> Array.toList |> splitFile positions |> productList 

products |> storelist writeListToTest
