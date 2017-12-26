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

    let removeFirstItemFromList() = 
        hover ".todo-list li:first"
        click ".destroy"

    let markAsActive(which:int) = 
        click (nth which ".toggle")

    let clickActive() =
        let activeLink = read (elementWithText ".filters li a" "Active")    
        click activeLink

    let clickAll() =
        let allLink = read (elementWithText ".filters li a" "All")    
        click allLink

    let clickCompleted() =
        let allLink = read (elementWithText ".filters li a" "Completed")    
        click allLink
    
    let clickClearCompleted() =
        let allLink = read (element ".filters li button")    
        click allLink