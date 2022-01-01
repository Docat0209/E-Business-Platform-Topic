<template>
  <main class="account">
    <!-- <h1>帳號相關</h1> -->
    <div id="accountBox">
      <div id="accountTitleDiv">
        <h1 id="accountTitle">
          個人資料
          <font-awesome-icon :icon="['far', 'address-card']" />
        </h1>
      </div>
      <AccountMainDiv></AccountMainDiv>
      <div id="accountFooterDiv">
        <!-- 上方Input有變動顯示下方按鈕 -->
        <button id="confirmModify">確認修改</button>
      </div>
      <!-- 帳號 更改密碼 名稱 電子信箱  頭像 -->
    </div>
  </main>
</template>

<script>
import AccountMainDiv from "../components/AccountMainDiv.vue";
export default {
  name: "ManageAccount",
  components: {
    AccountMainDiv,
    
  },

  data() {
    return {
      accountData: null,
    };
  },
  mounted() {
    // 先從API取資料，再進行渲染
  },
};
</script>

<style scoped>
.account {
  width: 81.3vw;
  height: 100vh;
  box-sizing: border-box;
  padding: 40px;
}
/* 帳號大箱子 */
#accountBox {
  width: 100%;
  height: 100%;
  background-color: #fff;
  box-shadow: 0px 2px 3px 1px rgba(90, 90, 90, 0.25);
  box-sizing: border-box;
  padding: 20px;
}
/* 個人資料標題區塊 */
#accountTitleDiv {
  display: flex;
  padding-left: 20px;
  align-items: center;
  height: 10%;
}
/* 個人資料標題區塊 h1 */
#accountTitleDiv #accountTitle {
  font-size: 40px;
}
/* 個人資料主要區塊 */
#accountMainDiv {
  height: 80%;
  width: 100%;
}
/* 個人資料底部區塊 */
#accountFooterDiv {
  width: 100%;
  height: 10%;
  display: flex;
  align-items: center;
  padding: 0 10px;
}
/* 個人資料底部區塊 確認修改按鈕 */
#accountFooterDiv #confirmModify {
  border: none;
  border: 1px solid rgba(0, 0, 0, 0.253);
  background-color: #19d858;
  /* padding: 10px 20px 10px 20px; */
  color: white;
  font-size: 20px;
  font-weight: bold;
  letter-spacing: 3px;
  padding: 20px 50px 20px 50px;
  box-sizing: border-box;
  transition-duration: 0.4s;
}
#accountFooterDiv #confirmModify:hover {
  background-color: #11a743;
}
</style>