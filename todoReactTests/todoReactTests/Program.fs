open canopy
open runner
open TodoApp.Todos

configuration.chromeDir <- "../../../../driver"

start chrome

pin FullScreen

"Open react todo application" &&& fun _ -> 
    TodoApp.Todos.openPage("http://todomvc.com/examples/react/#/")
    
"Add one todo item" &&& fun _ ->
    let itemTitle = "Write main test page"
    TodoApp.Todos.addItem(itemTitle)
    TodoApp.Todos.checkIfExistsInTodos(itemTitle)

"Remove first item from list" &&& fun _ ->
    TodoApp.Todos.removeFirstItemFromList();

"Add items and check if total items is displayed correctly" &&& fun _ ->
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

"Mark 2 items as active" &&& fun _ ->
    TodoApp.Todos.markAsActive(1);
    TodoApp.Todos.markAsActive(2);

"Display only active items" &&& fun _ ->
    TodoApp.Todos.clickActive();
    TodoApp.Todos.counterShouldBeEqual(1);

"Display all items" &&& fun _ ->
    TodoApp.Todos.clickAll();
    //todo count number of li elements for validation

"Display active items" &&& fun _ ->
    TodoApp.Todos.clickAll();
    //todo count number of li elements for validation

"Display completed items" &&& fun _ ->
    TodoApp.Todos.clickAll();
    //todo count number of li elements for validation

"Click clear completed" &&& fun _ ->
    TodoApp.Todos.clickClearCompleted();
    //todo count number of li elements for validation

run()

printfn "press [enter] to exit"
sleep 10
System.Console.ReadLine |> ignore

quit()