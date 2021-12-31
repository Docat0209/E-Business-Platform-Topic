<template>
  <aside>
    <nav id="sidebar">
      <div class="logo_area">
        <router-link :to="HomePath" class="logo_title_link">
          <img src="../assets/cloud.svg" alt="" class="logo" />
        </router-link>
        <router-link :to="HomePath" class="logo_title_link">
          <h3 class="logo_title">智慧居家</h3>
        </router-link>
      </div>
      <div class="user_info">
        <!-- API -> 將使用者頭像路徑放在src -->
        <img src="../assets/nene.jpg" class="user_thumbnail" />
        <hr class="user_hr" />
        <!-- API -> 將使用者名稱放在這 -->
        <span class="user_name">NeNe Wang</span>
      </div>
      <ul>
        <li class="link_list">
          <router-link :to="manageProductPath" class="link_text"
            ><img src="../assets/plus.svg" class="link_icon" /> 管理產品
          </router-link>
        </li>
        <li class="link_list">
          <router-link :to="listProductPath" class="link_text"
            ><img src="../assets/list-square.svg" class="link_icon" /> 產品控制
          </router-link>
        </li>
        <li class="link_list">
          <router-link :to="manageAccountPath" class="link_text"
            ><img src="../assets/edit-user-2.svg" class="link_icon" /> 帳號相關
          </router-link>
        </li>
      </ul>
    </nav>
  </aside>
</template>

<script>
export default {
  name: "Sidebar",
  data() {
    return {
      //首頁路徑
      HomePath: "/",
      // 管理產品路徑
      manageProductPath: "/manage/product",
      // 產品列表路徑
      listProductPath: "/list/product",
      // 帳號相關路徑
      manageAccountPath: "/manage/account",
    };
  },
};
</script>

<style scoped>
* {
  /* Hover顏色 */
  --hoverColor: #acfffc;
  /* 連結區塊高度 */
  --navLinkHeight: 72px;
  /* 滑入動畫圓角 */
  --hoverRadius: 0 50px 50px 0;
  /* 滑入動畫長度 */
  --hoverLinkBeforeElementWidth: 95%;
}
#sidebar {
  box-sizing: border-box;
  /* width: 360px; */
  width: 18.7vw;
  height: 100%;
  position: fixed;
  left: 0;
  text-align: center;
  background-color: white;
  box-shadow: 2px 0 4px 1px rgba(90, 90, 90, 0.25);
}

/*Logo*/

.logo_area {
  margin-top: 60px;
  margin-bottom: 10px;
}

.logo {
  position: relative;
  top: 5px;
  object-fit: cover;
  width: 50px;
  height: 50px;
}

.logo_area {
  display: flex;
  align-items: center;
  justify-content: center;
}

.logo_title {
  font-size: 40px;
  color: black;
  letter-spacing: 3px;
  margin-left: 15px;
}

/*User*/
.user_info {
  text-align: center;
}

.user_thumbnail {
  margin-top: 15px;
  width: 125px;
  height: 125px;
  border: 1px solid gray;
  border-radius: 50%;
  object-fit: cover;
  margin-bottom: 12px;
}

.user_hr {
  /*margin-top: 5px;*/
  width: 35%;
  margin: auto auto 10px;
  /*background-color: black;*/
  border-color: #2f2f2f;
}

.user_name {
  letter-spacing: 2px;
  color: #7c7c7c;
  font-size: 24px;
}

/**/
ul {
  display: flex;
  flex-direction: column;
  justify-content: space-around;
  height: 30%;
}

.link_list {
  height: var(--navLinkHeight);
  display: flex;
  width: 100%;
  justify-content: center;
  align-items: center;
  margin: auto 0;
}

.link_list::before {
  content: "";
  width: var(--hoverLinkBeforeElementWidth);
  height: var(--navLinkHeight);
  position: absolute;
  background-color: var(--hoverColor);
  left: -360px;
  z-index: -100;
  transition: all 0.35s ease-in-out;
  border-radius: var(--hoverRadius);
}

.link_list:hover.link_list::before {
  left: 0;
}
.link_list > a.router-link-active {
  position: relative;
  width: 100%;
  margin: 0;
}
.link_list > a.router-link-active::before {
  content: "";
  width: var(--hoverLinkBeforeElementWidth);
  height: var(--navLinkHeight);
  position: absolute;
  left: 0;
  top: -10px;
  z-index: -100;
  transition: all 0.35s ease-in-out;
  background-color: var(--hoverColor);
  border-radius: var(--hoverRadius);
}

.link_text {
  font-size: 36px;
  letter-spacing: 3px;
  margin-left: 4px;
  color: black;
  font-weight: 600;
}

.link_icon {
  position: relative;
  top: 6px;
  width: 43px;
  height: 43px;
}

a {
  text-decoration: none;
}
</style>