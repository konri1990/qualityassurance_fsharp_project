open canopy
open runner
open TodoApp.Todos

configuration.chromeDir <- "../../../../driver"

start chrome

pin FullScreen

"Open React Todo Application" &&& fun _ -> 
    TodoApp.Todos.openPage("http://todomvc.com/examples/react/#/")
    
"Add One Todo Item" &&& fun _ ->
    let itemTitle = "Write main test page"
    TodoApp.Todos.addItem(itemTitle)
    TodoApp.Todos.checkIfExistsInTodos(itemTitle)

"Add items and check if counter is correct" &&& fun _ ->
    let oneItem = "Adding one item"
    let secondItem = "Adding second item"
    let thirdItem = "Adding third item"
    TodoApp.Todos.addItem(oneItem)
    TodoApp.Todos.addItem(secondItem)
    TodoApp.Todos.addItem(thirdItem)
    TodoApp.Todos.checkIfExistsInTodos(oneItem)
    TodoApp.Todos.checkIfExistsInTodos(secondItem)
    TodoApp.Todos.checkIfExistsInTodos(thirdItem)
    
    TodoApp.Todos.counterShouldBeEqual(3)

run()

printfn "press [enter] to exit"
sleep 10
System.Console.ReadLine |> ignore

quit()