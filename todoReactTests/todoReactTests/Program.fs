open canopy
open runner
open TodoApp.TestOne

configuration.chromeDir <- "../../../../driver"

start chrome

"Open React Todo Application"  &&& fun _ -> 
    TodoApp.TestOne.openPage("http://todomvc.com/examples/react/#/")
    
run()

printfn "press [enter] to exit"
System.Console.ReadLine |> ignore

quit()