<template>
  <div id="app">
    <img src="./assets/logounri.png" height="75" >
    <web-toolbar></web-toolbar>
    <web-home><web-login></web-login></web-home>
    <router-view/>
    <web-footer></web-footer>
  </div>
  </template>

  <script>
    import WebFooter from './components/WebFooter'
    import WebHome from './components/WebHome'
    import WebLogin from './components/WebLogin'
    import WebToolbar from './components/WebToolbar'

    export default {
    name : 'app',
    components: {WebFooter,WebHome,WebLogin,WebToolbar}
  }
  </script>

  <style>
    #app {
      font-family: 'Avenir', Arial, Helvetica, sans-serif;
      -webkit-font-smoothing: antialiased ;
      -moz-osx-font-smoothing: grayscale;
      text-align: left;
      color: #2c3e50;
    }
    #text {
      text-align: left;
      position: relative;
    }
  </style>





