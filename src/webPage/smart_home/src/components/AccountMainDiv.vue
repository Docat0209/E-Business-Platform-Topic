<template>
  <div id="accountMainDiv">
    <div class="accountColumn">
      <div>
        <!-- API接頭像src -->
        <!-- src="http://localhost:8080/img/nene.aba9e214.jpg" -->
        <img
          class="accountColumnAvatar"
          
          :src="'/public'+userInfo.thumbnail_path"
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
        <font-awesome-icon :icon="['far', 'user']" />
        名稱
      </span>
      <div class="accountColumnInputDiv">
        <input
          class="accountInput"
          required
          type="text"
          :value="userInfo.name"
          @keyup="CheckIfmodify($event)"
          @change="CheckIfmodify($event)"
          data-type="name"
        />
      </div>
    </div>
    <div class="accountColumn">
      <span class="accountColumnTitle">
        <font-awesome-icon :icon="['far', 'user-circle']" />
        帳號
      </span>
      <div class="accountColumnInputDiv">
        <input
          class="accountInput"
          required
          type="text"
          :value="userInfo.account"
          @keyup="CheckIfmodify($event)"
          @change="CheckIfmodify($event)"
          data-type="account"
        />
      </div>
    </div>
    <!-- <div class="accountColumn">
      <span class="accountColumnTitle">
        <font-awesome-icon
          style="
            box-sizing: border-box;
            padding: 1px;
            margin-left: 1px;
            margin-right: 2px;
          "
          :icon="['fas', 'lock']"
        />
        密碼
      </span>
      <div class="accountColumnInputDiv">
        <input
          class="accountInput"
          :type="userInfo.password == '載入中' ? 'text' : 'password'"
          required
          :value="userInfo.password"
          @keyup="CheckIfmodify($event)"
          @change="CheckIfmodify($event)"
          data-type="password"
        />
      </div>
    </div> -->
    <div class="accountColumn">
      <span class="accountColumnTitle">
        <font-awesome-icon :icon="['fas', 'globe-asia']" />
        國家
      </span>
      <div class="accountColumnInputDiv">
        <input
          class="accountInput"
          type="text"
          :value="userInfo.country == null ? '未設定' : userInfo.country"
          @keyup="CheckIfmodify($event)"
          @change="CheckIfmodify($event)"
          data-type="country"
        />
      </div>
    </div>
    <div class="accountColumn">
      <span class="accountColumnTitle"
        ><font-awesome-icon
          style="padding-right: 5px; box-sizing: border-box"
          :icon="['fas', 'language']"
        />語言
      </span>
      <div class="accountColumnInputDiv">
        <input
          class="accountInput"
          type="text"
          :value="userInfo.language == null ? '未設定' : userInfo.language"
          @keyup="CheckIfmodify($event)"
          @change="CheckIfmodify($event)"
          data-type="language"
        />
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "AccountMainDiv",

  data() {
    return {
      // 初始化使用者資料
      userInfo: {
        name: "載入中",
        account: "載入中",
        password: "載入中",
        status: "載入中",
        country: "載入中",
        language: "載入中",
        thumbnail_path:"/storage/thumbnail/defaultAvatar.jpg",
      },
      afterUserInfo: null,
    };
  },
  created() {
    const __this = this;
    // API取使用者資料
    setTimeout(() => {
      fetch("/api/user/1", {})
        .then((response) => {
          return response.json();
        })
        .then((jsonData) => {
          __this.userInfo = jsonData.data;
          // 拷貝物件，CallByValue
          console.log(__this.userInfo);
          __this.afterUserInfo = { ...__this.userInfo };
        })
        .catch((err) => {
          console.log("錯誤", err);
        });
    }, 300);
  },
  methods: {
    // 檢查是否有變動資料->顯示確定按鈕進行更新
    CheckIfmodify: function (event) {
      const __this = this;
      let TargetDom = event.currentTarget;
      let TargetType = TargetDom.dataset.type;
      let TargetValue = TargetDom.value;
      __this.afterUserInfo[TargetType] = TargetValue;
      __this.$emit("update", [__this.userInfo, __this.afterUserInfo]);
    },
  },
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