body{
    margin:0;
    background-color: rgb(10, 102, 177);
    font-family:sans-serif ;
}

.todo-container{
    width:350px;
    position:absolute;
    left:50%;
    top:50%;
    transform:translate(-50%,-50%);
    text-align: center;

}

.input-section{
    background-color:rgb(97, 137, 247);
    padding:18px;
    border-radius: 10px;
    box-shadow: 0 4px 6px rgb(119, 112, 112);
}

.input-section input{
    border-radius: 5px;
    border: 1px solid rgb(61, 72, 223);
    width: 100%;
    padding: 10px;
    box-sizing: border-box;
    background-color: rgb(111, 193, 240);
    outline:none;
    color:rgb(8, 95, 95);

}

input::placeholder{
    color: rgb(34, 88, 238);
}

h1{
    margin: 0%;
    margin-bottom: 15px;
    color:rgb(77, 97, 214);
}
ul{
    text-align: left;
    padding: 0%;
}

ul li{
    display:flex;
    list-style:none ;
    background-color:rgb(14, 41, 161);
    padding: 15px;
    border-radius: 5px;
    margin-bottom: 2px;
    color:rgb(2, 9, 48);
    box-shadow: 0 4px 6px black;
}

ul li i{
    text-align:right;
    flex:1;
    cursor: pointer;
    width: 9;
}