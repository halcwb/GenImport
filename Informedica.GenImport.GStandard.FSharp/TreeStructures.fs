namespace TreeStructures

module TreeStructures =

    let buildGenericTree isParent partf addNodes nodes =
        let rec build nodes =
            match nodes |> partf with
            | roots, nodes when nodes |> List.length = 0 -> printfn "No more nodes"; roots
            | roots, nodes  -> roots |> List.map(fun g -> g |> addNodes ((nodes |> List.filter(fun n -> g |> isParent n) |> build)))

        build nodes
     

