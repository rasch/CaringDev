module AnApplicationOfStructuralTyping

    open System

    open FSharp.Data

    type XmlMessage = XmlProvider<"messageSamples.xml", SampleIsList=true, Global=true>

    type DbMessage = {
        Available : string
        Missing : string
        MissingNil : Nullable<int>
        Nil : Nullable<decimal>
    }

    let map (xmlMessage : XmlMessage.Message) =
        let missingNil =
            xmlMessage.MissingNil
            |> Option.bind (fun n -> match n.Nil with Some true -> None | _ -> Some n.Value)
            |> Option.toNullable
        let nil =
            match xmlMessage.Nil.Nil with Some true -> None | _ -> Some xmlMessage.Nil.Value
            |> Option.toNullable
        {
            Available = xmlMessage.Available
            Missing = xmlMessage.Missing |> Option.toObj
            MissingNil = missingNil
            Nil = nil
        }

    type Option<'T> with
        static member inline ofNillable n =
            match (^N : (member Nil : bool option) n) with
            | Some true -> None
            | _ -> Some (^N : (member Value : 'T) n)

    type Nillable =
        static member inline toNullable n =
            Option.ofNillable n |> Option.toNullable
        static member inline toNullable n =
            Option.bind Option.ofNillable n |> Option.toNullable


    let map' (xmlMessage : XmlMessage.Message) =
        {
            Available = xmlMessage.Available
            Missing = xmlMessage.Missing |> Option.toObj
            MissingNil = xmlMessage.MissingNil |> Nillable.toNullable
            Nil = xmlMessage.Nil |> Nillable.toNullable
        }