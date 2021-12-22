<template>
  <main class="account">
    <!-- <h1>帳號相關</h1> -->
    <!--  -->
    <div id="accountBox">
      <div id="accountTitleDiv">
        <h1 id="accountTitle">
          個人資料
          <font-awesome-icon :icon="['far', 'address-card']" />
        </h1>
      </div>
      <div>
        <div class="accountColumn">
          <div>
            <img class="accountColumnAvatar" src="../assets/nene.jpg" />
          </div>
          <!-- <span class="accountColumnTitle"> -->
          <!-- <font-awesome-icon :icon="['far', 'user-circle']" /> -->
          <!-- 頭像 -->
          <!-- </span> -->
          <!-- <div class="accountColumnInputDiv"> -->
          <!-- <input class="accountInput" type="text" value="NeNeWangTest" /> -->
          <!-- </div> -->
        </div>
        <div class="accountColumn">
          <span class="accountColumnTitle">
            <font-awesome-icon :icon="['far', 'user-circle']" />
            帳號
          </span>
          <div class="accountColumnInputDiv">
            <input class="accountInput" type="text" value="NeNeWangTest" />
          </div>
        </div>
        <div class="accountColumn">
          <span class="accountColumnTitle">
            <font-awesome-icon :icon="['far', 'user']" />
            名稱
          </span>
          <div class="accountColumnInputDiv">
            <input class="accountInput" type="text" value="NeNe Wang" />
          </div>
        </div>
        <div class="accountColumn">
          <span class="accountColumnTitle">
            <font-awesome-icon :icon="['far', 'envelope']" />
            電子信箱
          </span>
          <div class="accountColumnInputDiv">
            <input
              class="accountInput"
              type="text"
              value="NeNeWangTest@gmail.com"
            />
          </div>
        </div>
        <!-- <div>
          <span>頭像</span>
          <input class="accountInput" type="file" />
        </div> -->
      </div>
      <!-- 帳號 更改密碼 名稱 電子信箱  頭像 -->
    </div>
  </main>
</template>

<script>
export default {
  name: "ManageAccount",
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
* {
  --ColumnTitleFontSize: 32px;
}
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
.accountColumn {
  box-sizing: border-box;
  width: 100%;
  display: flex;
  height: 100%;
  /* align-items: ; */
  padding: 0px 10px 0px 20px;
  margin: 20px 0px;
  /* justify-content: center; */
}
.accountColumnAvatar {
  /* margin-top: 15px; */
  width: 125px;
  height: 125px;
  border: 1px solid gray;
  border-radius: 50%;
  -o-object-fit: cover;
  object-fit: cover;
  /* margin-bottom: 12px; */
}
/* 欄位名稱樣式 */
.accountColumnTitle {
  font-size: var(--ColumnTitleFontSize);
  width: 13%;
}
/* 欄位輸入區塊 */
.accountColumnInputDiv {
  width: 40%;
}
/* 欄位輸入樣式 Input */
.accountColumnInputDiv .accountInput {
  width: 100%;
  border: none;
  font-size: 28px;
  border-bottom: 1px solid rgb(204, 204, 204);
  outline: none;
  padding-top: 5px;
}
</style>