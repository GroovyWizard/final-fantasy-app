<template>
  <img alt="Vue logo" style="width: 300px; height:200px;"
    src="https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Forig00.deviantart.net%2Faa0e%2Ff%2F2011%2F218%2F2%2F9%2Ffinal_fantasy_ii_logo_by_eldi13-d45pon1.png&f=1&nofb=1">
  <GlobalBanner title="Final Fantasy APP" msg="C# Backend " />
  <router-view/>

</template>


<script>
import GlobalBanner from './components/GlobalBanner.vue'

export default {
  name: 'App',
  components: {
    GlobalBanner
  },
}


</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
