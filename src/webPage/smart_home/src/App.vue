<template>
  <div>
    <!-- Loading元件 -->
    <!-- <Loading></Loading> -->
    <!-- 側邊欄元件 -->
    <Sidebar :userData="userData"></Sidebar>
    <!-- 頁面內容view -->
    <router-view
      v-if="RouterAlive"
      @AccountHasModify="AccountHasModifyMethod()"
    />
  </div>
</template>
<script>
import Sidebar from "./components/Sidebar.vue";
// import Loading from "./components/Loading.vue";

export default {
  name: "App",
  data() {
    return {
      userData: "",
      RouterAlive: true,
    };
  },
  components: {
    Sidebar,
    // Loading,
  },
  created() {
    this.GetAccountInfo(1);
  },
  mounted() {
    let loadingWrapper = document.getElementById("loading_wrapper");
    setTimeout(function () {
      loadingWrapper.style.opacity = "0";
      document.getElementsByClassName("loading_box")[0].style.opacity = "0";
      setTimeout(function () {
        loadingWrapper.style.display = "none";
      }, 800);
    }, 1000);
  },
  methods: {
    reloadRouteView() {
      this.RouterAlive = false;
      this.$nextTick(() => {
        this.RouterAlive = true;
      });
    },
    GetAccountInfo(id) {
      const __this = this;
      // http://localhost/smartHomeApi/public/api/v1/
      let url = window.location.origin + "/smartHomeApi/public/api/v1/user/"+ id;
      console.log(url);
      fetch(url, {})
        .then((response) => {
          return response.json();
        })
        .then((jsonData) => {
          __this.userData = jsonData.data;
        })
        .catch((err) => {
          console.log("錯誤", err);
        });
    },
    AccountHasModifyMethod() {
      this.GetAccountInfo(1);
      setTimeout(() => {
        this.reloadRouteView();
      }, 200);
    },
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
