
<template>
  <div class="todo">
    <div class="colorline" />
    <div class="todobg" />
    <div v-if="!editing">
      <div class="todotext">
        <img class="characterImage" v-bind:src="imgUrl">
        {{ content }}
      </div>
      <div class="controlButtons">
        <button class="controlButtonEdit material-icons" @click="nowEditing">Editar </button>
        <button class="controlButtonDone material-icons" :class="{ 'controlButtonDoneCompleted': !progress }"
          @click="toggleTodo">Terminar</button>
        <button class="controlButtonCancel material-icons" @click="rem">Deletar</button>
      </div>
    </div>
    <div v-else>
      <div class="todotext">
        <input class="todoinput" @keydown.enter="updateTodo" v-model="newContent" />
      </div>
      <div class="controlButtons">
        <button class="controlButtonAdd material-icons" @click="updateTodo">Update</button>
        <button class="controlButtonCancel material-icons" @click="cancelUpdateTodo">Deletar</button>
      </div>
    </div>
  </div>
</template>

<script>
import { ref } from 'vue'
import axios from 'axios'
export default {
  props: ['content', 'id', 'progress', 'imgUrl'],
  emits: ['changedProgress', 'remmed', 'updatedContent'],
  setup(props, { emit }) {
    const editing = ref(false)
    const newContent = ref('')
    function toggleTodo() {
      emit('changedProgress', props.id)
    }
    function rem() {
      console.log(props.id)
      axios.delete(`https://localhost:7022/Character/${props.id}`, 
       { data: { id: props.id}, headers: {}})
        .then(() => {
          alert("Personagem deletado com sucesso")
        })
        .catch(() => {
          alert("Um erro ocorreu")
        }).finally(() => {
        });
    }
    function nowEditing() {
      editing.value = true
      newContent.value = props.content
    }
    function updateTodo() {
      if (newContent.value.length > 0) {
        emit('updatedContent', props.id, newContent.value)
        newContent.value = ''
        editing.value = false
      }
    }
    function cancelUpdateTodo() {
      editing.value = false
    }
    return { toggleTodo, rem, editing, newContent, nowEditing, updateTodo, cancelUpdateTodo }
  }
}
</script>

<style scoped>
.todo {
  position: relative;
  height: 100px;
  width: 700px;
  margin: auto;
  text-align: center;
}

.todobg {
  position: absolute;
  top: 0;
  left: 1%;
  z-index: -1;
  margin: auto;
  background: white;
  border-radius: 20px;
  border-color: black;
  height: 100%;
  width: 99%;
}

.colorline {
  position: absolute;
  top: 2%;
  left: 0;
  margin: auto;
  z-index: -2;
  margin: auto;
  background: cyan;
  border-radius: 20px;
  height: 96%;
  width: 100%;
}

.todotext {
  position: absolute;
  margin-left: 8%;
  display: flex;
  justify-content: left;
  text-align: left;
  align-items: center;
  height: 100%;
  width: 67%;
}

.characterImage {
  height: 100px;
  width: 100px;
  margin-right: 50px;
}

.controlButtons {
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

.controlButtonDone,
.controlButtonCancel,
.controlButtonEdit,
.controlButtonAdd {
  color: black;
  cursor: pointer;
  padding: 0;
  margin: 0;
  border: none;
  text-align: center;
  background: whitesmoke;
  transition: all 0.2s ease;
}

.controlButtonDone:hover,
.controlButtonCancel:hover,
.controlButtonEdit:hover,
.controlButtonAdd:hover {
  transition: all 0.2s ease;
  transform: scale(1.2);
}

.controlButtonDoneCompleted,
.controlButtonAdd {
  color: green;
}

.controlButtonCancel {
  color: red;
}

.todoinput {
  color: rgb(60, 60, 60);
  width: 100%;
  border-radius: 20px;
  border: 1px lightslategray solid;
  padding-top: 10px;
  padding-bottom: 10px;
  ;
  padding-left: 10px;
  padding-right: 10px;
  transition: all 0.2s ease;
  background: whitesmoke;
}

.todoinput:focus {
  transition: all 0.2s ease;
  transform: scale(1.025);
  border: 2px lightslategray solid;
  outline: none;
}
</style>