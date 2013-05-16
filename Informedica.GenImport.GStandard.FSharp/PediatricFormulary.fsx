// Learn more about F# at http://fsharp.net. See the 'F# Tutorial' project
// for more guidance on F# programming.
#I @"C:\Development\GenImport\packages\RavenDB.Client.2.0.2330\lib\net40\"
#r "Raven.Client.Lightweight.dll"
#I @"C:\Development\GenImport\packages\RavenDB.Client.2.0.2330\lib\net40\"
#r "Raven.Abstractions.dll"


#load "Library1.fs"
#load "TreeStructures.fs"
open System.Collections.Generic
open System
open System.IO
open System.Net
open System.Text.RegularExpressions

open Informedica.GenImport.GStandard.FSharp
open Raven.Client
open Raven.Client.Extensions
open TreeStructures

let pediatricFormUrl = "http://www.kinderformularium.nl/search/stof.php?id="

type PediatricFormularyText =
    { Id: string; ATC: string; Html: string }

// Set up the document store
let store = 
    let store = new Raven.Client.Document.DocumentStore()
    store.Url <- @"http://localhost:8080"
    store.Initialize()


// Write to database
let write (database: string) (s: Raven.Client.IDocumentStore) data =
    use s = s.OpenSession(database)
    do s.Store(data)
    do s.SaveChanges()

let writelist (database: string) (s: Raven.Client.IDocumentStore) =
    write database s

let writeToPediatricFormulary data = writelist "PediatricFormulary" store data

let storelist w l = 
    l |> List.iter(fun d -> d |> w)

// Fetches a Web page.
let fetch (url : string) =
    try
        let req = WebRequest.Create(url) :?> HttpWebRequest
        req.UserAgent <- "Mozilla/5.0 (Windows; U; MSIE 9.0; Windows NT 9.0; en-US)"
        req.Timeout <- 5000
        use resp = req.GetResponse()
        let content = resp.ContentType
        let isHtml = Regex("html").IsMatch(content)
        match isHtml with
        | true -> use stream = resp.GetResponseStream()
                  use reader = new StreamReader(stream)
                  let html = reader.ReadToEnd()
                  Some html
        | false -> None
    with
    | _ -> None

let fetchPediatricForm id = 
    let url = pediatricFormUrl + id
    fetch url

let getATC html =
    let atcM = @"ATC code: [ABCDGHJLMNPRSV]\d\d[A-Z][A-Z]\d\d";
    Regex.Match(html, atcM).Value.Replace("ATC code: ", "")


let parsePediatricForm ids =
    let ids = ids |> List.map(fun i -> i.ToString())
    seq { for id in ids do
            let html = fetchPediatricForm id
            match html with
            |Some s -> match s |> getATC with
                       | atc when atc.Length > 0 -> printfn "found: %s %s" id atc; yield { Id = id; ATC = atc; Html = html.Value }
                       | _ -> id |> ignore
            | _ -> id |> ignore }  


[0..1..1000] |> parsePediatricForm |> Seq.toList |> storelist writeToPediatricFormulary    
