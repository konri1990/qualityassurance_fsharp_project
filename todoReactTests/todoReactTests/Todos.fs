namespace TodoApp
module Todos = 
    open canopy
    open FSharp.Data

    let openPage(urlPage:string) = 
        url urlPage

    let addItem(title:string) = 
        describe("Adding " + title + " to todolist")            
        
        ".new-todo" << title

        press enter

    let checkIfExistsInTodos(title:string) = 
        let titleOnList = read (elementWithText ".todo-list li div label" title)    
        titleOnList === title

    let counterShouldBeEqual(numberOfItems:int) = 
        let number = read (element ".todo-count strong:first") |> int
        numberOfItems === number