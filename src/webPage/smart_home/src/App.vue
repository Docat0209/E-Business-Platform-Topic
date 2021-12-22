<template>
  <div>
    <!-- Loading元件 -->
    <!-- <Loading></Loading> -->
    <!-- 側邊欄元件 -->
    <Sidebar></Sidebar>
    <!-- 頁面內容view -->
    <router-view />
  </div>
</template>
<script>
import Sidebar from "./components/Sidebar.vue";
// import Loading from "./components/Loading.vue";

export default {
  name: "App",
  components: {
    Sidebar,
    // Loading,
  },
  mounted() {
    // 監聽重新整理
    // window.onunload = function () {
    // document.location.href = window.location.pathname + "/";
    // alert((document.location.href = window.location.pathname + "/"));
    // return (document.location.href = window.location.pathname + "/");
    // };
    // console.log(window.location.pathname);
    let loadingWrapper = document.getElementById("loading_wrapper");
    setTimeout(function () {
      loadingWrapper.style.opacity = "0";
      document.getElementsByClassName("loading_box")[0].style.opacity = "0";
      setTimeout(function () {
        loadingWrapper.style.display = "none";
      }, 800);
    }, 1000);
  },
};
</script>
<style>
@import url("https://fonts.googleapis.com/css2?family=Roboto:ital@0;1&display=swap");

* {
  margin: 0;
  padding: 0;
}

body {
  background-color: #f6f8f8;
}

#app {
  /*font-family: Avenir, Helvetica, Arial, sans-serif;*/
  font-family: "Roboto", sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
}

.product,
.home,
.account,
.manageProduct {
  position: fixed;
  /* left: 360px; */
  left: 18.7vw;
  width: 81.3vw;
  /* width: 80%; */
}
</style>
