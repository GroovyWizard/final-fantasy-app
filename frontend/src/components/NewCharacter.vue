<template>
  <div class="container-bg">
    <div class="heading">
        Adicione um novo Personagem!
    </div>
    <img class="moogle"
    src="https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2Fimg4.wikia.nocookie.net%2F__cb20131211202525%2Ffinalfantasy%2Fimages%2F8%2F88%2FFFXIV_Delivery_Moogle.png&f=1&nofb=1">
  
    <div class="todo">
        <div class="colorline"/>
        <div class="todobg"/>
        <div class="todotext"> 
            Name:
            <input type="text" class="todoinput" @keydown.enter="addNewTodo" v-model="content"/>
        </div>
        <div class="controlButtons">
            <button class="controlButtonAdd" @click="addNewTodo">Add</button>
            <button class="controlButtonCancel" @click="clearNewTodo">Clear</button>
        </div>
    </div>

    </div>
</template>

<script>
import { ref } from '@vue/reactivity'
export default {
    emits: ['addtodo'],
    setup(props, { emit }){
        const content = ref('')
        function clearNewTodo(){
            content.value = ''
        }
        function addNewTodo(){
            if(content.value.length > 0){
                emit('addtodo', content.value)
                content.value = ''
            }
        }
        return {content, clearNewTodo, addNewTodo}
    }
}
</script>

<style scoped>
.container-bg{
  margin-top: 20px;
  border-radius: 10px;
  border-color: black;
}
.heading{
  text-align: center;
  margin: 20px;
  color: darkslategrey;
  font-size: 1.25em;
}
.todo{
  position: relative;
  height: 150px;
  width: 800px;
  margin: auto;
  text-align: center;
}
.todobg{
  position: absolute;
  top: 0;
  left: 1%;
  z-index: -1;
  margin: auto ;
  background: whitesmoke;
  border-radius: 20px;
  height: 100%;
  width: 99%;
}
.colorline{
  position: absolute;
  top: 8%;
  left: 0;
  margin: auto;
  z-index: -2;
  margin: auto ;
  background: coral;
  border-radius: 20px;
  height: 96%;
  width: 100%;
}
.todotext{
  margin-left: 5%;
  display: flex;
  justify-content: left;
  text-align: left;
  align-items: center;
  height: 100%;
  width: 70%;
}
.controlButtons{
  margin-right: 5%;
  position: absolute;
  top: 0;
  right: 0;
  width: 20%;
  height: 100%;
  display: flex;
  justify-content: space-evenly;
  align-items: center;
}
.controlButtonAdd,  .controlButtonCancel{
  font-size: 1.005em;
  color: black;
  cursor: pointer;
  padding: 0;
  margin: 0;
  border: none;
  text-align: center;
  background: whitesmoke;
  transition: all 0.2s ease;
}
.controlButtonAdd:hover,  .controlButtonCancel:hover{
  transition: all 0.2s ease;
  transform: scale(1.1);
}
.controlButtonAdd{
  color: green;
}
.controlButtonCancel{
  color: red;
}
.todoinput{
    color: rgb(60, 60, 60);
    width: 75%;
    margin-left: 4%;
    border-radius: 20px;
    border: 1px lightslategray solid;
    padding-top: 10px;
    padding-bottom: 10px;;
    padding-left: 10px;
    padding-right: 10px;
    transition: all 0.2s ease;
    background: whitesmoke;
}
.todoinput:focus{
    transition: all 0.2s ease;
    transform: scale(1.025);
    border: 2px lightslategray solid;
    outline: none;
}
.moogle{
  width: 5%;
  height: 5%;
}
</style>