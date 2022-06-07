      
<template>
  <div>
    <h2> Cadastrar Novo Personagem </h2>
    <img class="moogle"
      src="https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2Fimg4.wikia.nocookie.net%2F__cb20131211202525%2Ffinalfantasy%2Fimages%2F8%2F88%2FFFXIV_Delivery_Moogle.png&f=1&nofb=1">
    <form v-on:submit.prevent="submitForm">
      <div class="form-group">
        <label for="name">Nome</label>
        <input type="text" class="form-control" id="name" placeholder="Cloud Strife" v-model="form.name">
      </div>
      <div class="form-group">
        <label for="game">Jogo</label>
        <input type="game" class="form-control" id="game" placeholder="Final Fantasy III" v-model="form.game">
      </div>
      <div class="form-group">
        <label for="game">Imagem</label>
        <input type="imgUrl" class="form-control" id="imgUrl" placeholder="url" v-model="form.imgUrl">
      </div>
      <div class="form-group">
        <button class="btn btn-primary">Enviar</button>
      </div>
    </form>
  </div>
</template>
  
<script>
import axios from 'axios';

export default {
  name: 'PostFormAxios',
  data() {
    return {
      form: {
        name: '',
        game: '',
        imgUrl: ''
      }
    }
  },
  methods: {
    submitForm() {
      axios.post('https://localhost:7022/character', this.form)
        .then(() => {
          alert("Personagem gravado com sucesso")
        })
        .catch((error) => {
          console.log(error)
        }).finally(() => {
        });
    }
  }
}
</script>

<style scoped>
.container-bg {
  margin-top: 20px;
  border-radius: 10px;
  border-color: black;
}

.heading {
  text-align: center;
  margin: 20px;
  color: darkslategrey;
  font-size: 1.25em;
}

.todo {
  position: relative;
  height: 150px;
  width: 800px;
  margin: auto;
  text-align: center;
}

.todobg {
  position: absolute;
  top: 0;
  left: 1%;
  z-index: -1;
  margin: auto;
  background: whitesmoke;
  border-radius: 20px;
  height: 100%;
  width: 99%;
}

.colorline {
  position: absolute;
  top: 8%;
  left: 0;
  margin: auto;
  z-index: -2;
  margin: auto;
  background: coral;
  border-radius: 20px;
  height: 96%;
  width: 100%;
}

.todotext {
  margin-left: 5%;
  display: flex;
  justify-content: left;
  text-align: left;
  align-items: center;
  height: 100%;
  width: 70%;
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

.controlButtonAdd,
.controlButtonCancel {
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

.controlButtonAdd:hover,
.controlButtonCancel:hover {
  transition: all 0.2s ease;
  transform: scale(1.1);
}

.controlButtonAdd {
  color: green;
}

.controlButtonCancel {
  color: red;
}

.todoinput {
  color: rgb(60, 60, 60);
  width: 75%;
  margin-left: 4%;
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

.moogle {
  width: 5%;
  height: 5%;
}
</style>