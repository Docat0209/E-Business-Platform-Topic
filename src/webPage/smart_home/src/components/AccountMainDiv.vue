<template>
  <div id="accountMainDiv">
    <div class="accountColumn">
      <div>
        <!-- API接頭像src -->
        <img
          class="accountColumnAvatar"
          src="http://localhost:8080/img/nene.aba9e214.jpg"
        />
        <!-- 更改頭像 -->
        <input
          accept=".bmp, .jpg, .jpeg, .png, .gif"
          type="file"
          id="accountColumnAvatarInput"
        />
      </div>
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
</template>

<script>
export default {
  name: "AccountMainDiv",
};
</script>

<style scoped>
* {
  --ColumnTitleFontSize: 32px;
}
/* 個人資料主要區塊 欄位 */
#accountMainDiv .accountColumn {
  box-sizing: border-box;
  width: 100%;
  display: flex;
  padding: 15px 10px 15px 20px;
}
/* 個人資料主要區塊 頭像樣式 */
.accountColumnAvatar {
  width: 125px;
  height: 125px;
  border: 1px solid gray;
  border-radius: 50%;
  -o-object-fit: cover;
  object-fit: cover;
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