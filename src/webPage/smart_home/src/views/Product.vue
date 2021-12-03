<template>
  <main class="product">
    <!-- 控制產品的頁面 -->
    <header id="AreaFilterBox">
      <nav>
        <div>
          <label>
            <span>位置</span>
            <select id="LocationSelector" class="selectMenu">
              <option value="">公司</option>
            </select>
          </label>
        </div>
        <div>
          <label>
            <span>區域</span>
            <select id="DistrictSelector" class="selectMenu">
              <option value="">辦公桌</option>
            </select>
          </label>
        </div>
      </nav>
    </header>
    <div id="furnitureList">
      <div class="furnitureListBox" v-for="test in 2" :key="test">
        <!-- 家具箱子 -->
        <div class="furnitureBox">
          <div class="furnitureBoxHeader PowerOff">
            <div class="furnitureLocation">
              <!-- 公司-辦公桌 -->
              公司-辦公桌
            </div>
            <div class="furnitureName">電腦</div>

            <!-- 家具電源開關 -->
            <div class="furniturePowerButton">
              <label>
                <input
                  @change="PowerStateHasChanged"
                  class="PowerButtonCheckbox"
                  type="checkbox"
                />
                <span class="PowerButton"></span>
              </label>
            </div>
          </div>
          <div class="furnitureBoxBody"></div>
        </div>
      </div>
    </div>
  </main>
</template>

<script>
export default {
  name: "Product",
  data() {
    return {};
  },
  mounted() {
    // 先取資料 才能渲染
  },
};
</script>

<style scoped>
* {
  --PowerOn: #9cec5b;
  --PowerOff: #ff5964;
  /* fb6376 */
  /* FF5964 */
  /* 家具名稱字體大小 */
  --furnitureNameFontSize: 30px;
  /* 家具位置及區域字體大小 */
  --furnitureLocationFontSize: 16px;
  --PowerButtonHeight: 30px;
  --PowerButtonWidth: 70px;
  --PowerButtonInsideCircleWidth: 28px;
  --PowerButtonInsideCircleHeight: 28px;
}
.product {
  width: 81.3vw;
  height: 100vh;
  box-sizing: border-box;
  padding: 40px;
}
/* 篩選地區箱子 Header */
#AreaFilterBox {
  width: 100%;
  height: 10%;
  background-color: #fff;
  box-shadow: 0px 2px 3px 1px rgba(90, 90, 90, 0.25);
}
#AreaFilterBox nav {
  box-sizing: border-box;
  padding: 10px;
  height: 100%;
  width: 100%;
  display: flex;
  align-items: center;
}
#AreaFilterBox nav > div {
  padding: 0px 10px;
}
#AreaFilterBox nav label {
  display: flex;
  align-items: center;
}
/* 篩選地區箱子 Header 文字 */
#AreaFilterBox nav label span {
  font-size: 30px;
}
/* 篩選地區箱子 篩選選單 */
#AreaFilterBox .selectMenu {
  padding: 0px 10px;
  outline: none;
  width: 250px;
  height: 45px;
  font-size: 20px;
  border-radius: 0;
  margin-left: 10px;
}
/* 家具列表 */
#furnitureList {
  width: 100%;
  height: 90%;
  display: flex;
  flex-wrap: wrap;
}
/* 家具列表箱子 */
.furnitureListBox {
  width: 50%;
  height: 50%;
  box-sizing: border-box;
  padding: 40px 20px 10px 20px;
}
/* 家具箱子 */
.furnitureBox {
  width: 100%;
  height: 100%;
  background-color: #fff;
  box-shadow: 1px 2px 4px 1px rgba(90, 90, 90, 0.25);
}
/* 家具箱子 標題頭部 */
.furnitureBox .furnitureBoxHeader {
  width: 100%;
  height: 22%;
  transition: all 0.5s ease-in-out;
  padding: 5px 10px 5px 10px;
  box-sizing: border-box;
  display: flex;
  align-items: center;
  justify-content: space-between;
}
/* 家具箱子 標題頭部 家具名稱 */
.furnitureBoxHeader .furnitureName {
  font-weight: bold;
  font-size: var(--furnitureNameFontSize);
}

/* 家具箱子 標題頭部 家具位置及區域 */
.furnitureBoxHeader .furnitureLocation {
  font-weight: bold;
  font-size: var(--furnitureLocationFontSize);
}

/* 家具箱子 內容 */
.furnitureBox .furnitureBoxBody {
  width: 100%;
  height: 78%;
}
/* 電源開關 */
.PowerButton {
  display: inline-block;
  position: relative;
  width: var(--PowerButtonWidth);
  height: var(--PowerButtonHeight);
  border: 4px solid white;
  background-color: #e9e9ea;
  border-radius: var(--PowerButtonHeight);
  transition: all 0.3s ease-in-out;
}
.PowerButton::after {
  content: "";
  display: inline-block;
  width: var(--PowerButtonInsideCircleWidth);
  height: var(--PowerButtonInsideCircleHeight);
  background-color: white;
  position: absolute;
  border-radius: 50%;
  top: 3.4%;
  left: 4%;
  transition: all 0.3s ease-in-out;
}
.PowerButtonCheckbox {
  display: none;
}
.PowerButtonCheckbox:checked + span {
  background-color: #36e461;
}
.PowerButtonCheckbox:checked + span::after {
  transform: translateX(calc(var(--PowerButtonInsideCircleWidth) * 1.3));
}
.PowerOn {
  background-color: var(--PowerOn);
}
.PowerOff {
  background-color: var(--PowerOff);
}
</style>