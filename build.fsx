#load "packages/FSharp.Formatting/FSharp.Formatting.fsx"

open FSharp.Literate
open System.IO

let relative subdir = Path.Combine(__SOURCE_DIRECTORY__, subdir)

Literate.ProcessDirectory(relative "_code", outputDirectory = relative "_posts", format = OutputKind.Html, lineNumbers = false, generateAnchors = true)