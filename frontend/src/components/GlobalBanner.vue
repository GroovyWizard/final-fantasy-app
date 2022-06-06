<template>
  <div class="hello">
    <h1>{{ title }}</h1>
    <h3>{{ msg }}</h3>
  </div>
</template>

<script>
export default {
  name: 'GlobalBanner',
  props: {
    title: String,
    msg: String

  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
