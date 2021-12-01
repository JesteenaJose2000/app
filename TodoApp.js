import React, { Component } from 'react'
import "./TodoApp.css"
//different directory ../TodoApp

export default class TodoApp extends Component {
    state={
        input:"",
        items:[]
    };
    storeItems=(event)=>{
        event.preventDefault();
        const {input}=this.state;
        // const allItems=this.state.items;
        // allItems.push(input);

        this.setState({
            items:[...this.state.items,input],
            input:""
        });
    }
    deleteItem=(key)=>{
        const allItems = this.state.items;
        allItems.splice(key,1);
        this.setState({
            items:allItems
        })
    }
    handleChange=(event)=>{
        this.setState({
            input:event.target.value
        });
    }
    render() {
        // const {input,email,password}=this.state
        //this is destructuring
        const {input,items}= this.state;
        console.log(items);
        return (
            <div className="todo-container">
                <form className="input-section" onSubmit={this.storeItems}>
                    <h1>Todo app</h1>
                    <input type="text" value={input} onChange={this.handleChange} placeholder="Enter item..." />
                </form>
                <ul>
                    {items.map((data,index) => (
                        <li key={index}>{data} <i className="fas fa-trash-alt" onClick={()=> this.deleteItem(index)}></i></li>
                    ))}
                </ul>
            </div>
        )
    }
}
