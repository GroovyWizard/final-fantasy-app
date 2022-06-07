<template>
  <div class="navv">
    <span :class="{'navsPlus' : !addit, 'navs-activePlus' : addit}" @click="selectNav(4)">+</span>
  </div>

    <div class="content" v-for="todo in todos" :key="todo.id">
      <Todo :content="todo.name" :imgUrl="todo.imgUrl" :id="todo.id" :progress=false @changedProgress="toggleOngoing" @remmed="removeTodo" @updatedContent="changeContent"/>
    </div>
    <NewTodo @addtodo="updateTodos"/>
</template>

<script>
import Todo from "../components/CharacterModel.vue"
import NewTodo from "../components/NewCharacter.vue"
export default {
  name: 'HomePage',
  components: {
    Todo, NewTodo
  },

  data() {
    return {
      todos: [],
    };
  },
   methods: {
    async getData() {
      try {
        let response = await fetch("https://localhost:7022/character");
        this.todos = await response.json();
      } catch (error) {
        console.log(error);
      }
    },
  },
   created() { 
         this.getData();
  },
  
}
</script>

<style scoped>
.navv{
  margin-top: 10px;
  text-align: center;
}
.navs{
  display: inline-block;
  margin: 25px;
  font-size: 0.85em;
  color: gray;
  transition: all 0.2s ease;
}
.navs-active{
  display: inline-block;
  margin: 25px;
  font-size: 0.9em;
  color: rgb(40, 40, 40);
  transition: all 0.2s ease;
}
.navs:hover, .navs-active:hover, .navsPlus:hover, .navs-activePlus:hover{
  cursor: pointer;
}
.content{
  text-align: center;
  margin: 20px auto;
}
.navsPlus{
  transform: translateY(10%);
  margin: 25px;
  display: inline-block;
  font-size: 1.5em;
  color: gray;
  transition: all 0.2s ease;
}
.navs-activePlus{
  transform: translateY(10%);
  display: inline-block;
  margin-left: 22.5px;
  margin-right: 22.5px;
  margin-top: 17.5px;
  margin-bottom: 17.5px;
  font-size: 2em;
  color: rgb(40, 40, 40);
  transition: all 0.2s ease;
}
</style>