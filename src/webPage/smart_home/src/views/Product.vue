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
      <!-- 家具箱子 -->
      <div class="furnitureBox">
        <div class="furnitureBoxHeader">
          <div class="furnitureName">
            <!-- 電腦 -->
          </div>
          <div class="furnitureLocation">
            <!-- 公司-辦公桌 -->
            <div>
              <!-- 公司 -->
            </div>
            <div>
              <!-- 辦公桌 -->
            </div>
          </div>
          <!-- 家具電源開關 -->
          <div class="furniturePowerButton"></div>
        </div>
        <div class="furnitureBoxBody"></div>
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
}
/* 家具箱子 */
.furnitureBox {
  width: 100%;
  /* height: 100%; */
}
/* 家具箱子 標題頭部 */
.furnitureBox .furnitureBoxHeader {
}
/* 家具箱子 內容 */
.furnitureBox .furnitureBoxBody {
}
</style>