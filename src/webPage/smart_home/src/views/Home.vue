<template>
  <main class="home">
    <div id="tech_video_area" class="item_box">
      <div class="tech_video_area_title">
        <h1>最新消息</h1>
      </div>
      <div id="bannerSwiperArea">
        <BannerSwiper></BannerSwiper>
      </div>
    </div>
    <!-- 最近動作區塊 -->
    <div id="recent_area" class="item_box">
      <div class="recent_area_title">
        <h1>最近動作</h1>
      </div>
      <div class="recent_area_main"></div>
    </div>
    <!-- 近五天用電量折線圖條圖區塊 -->
    <div id="power_chart_area" class="item_box">
      <div class="power_chart_area_title">
        <h1>用電情形</h1>
      </div>
      <div id="powerChartArea">
        <PowerChart
          canvas-width="600px"
          canvas-height="600px"
          :canvas-data="[6, 2, 1, 11, 20]"
        ></PowerChart>
      </div>
    </div>
    <!-- 小訊息區塊 -->
    <div id="little_info_area_1" class="item_box info_area">
      <div class="little_info_area_1_title">
        <h1>家具數量</h1>
        <img class="info_svg" src="../assets/note-check.svg" alt="" />
      </div>
      <div class="little_info_area_1_main">
        <!-- <div class="little_info_area_main_left">
          <img class="info_svg" src="../assets/note-check.svg" alt="" />
        </div> -->

        <h3>
          3
          <span>台</span>
        </h3>
      </div>
    </div>
    <div id="little_info_area_2" class="item_box info_area">
      <div class="little_info_area_2_title">
        <h1>用電瓦數</h1>
        <img class="info_svg_2" src="../assets/flash.svg" alt="" />
      </div>
      <div class="little_info_area_2_main">
        <h3>
          6874
          <span>瓦</span>
        </h3>
      </div>
    </div>
  </main>
</template>
<script>
import PowerChart from "@/components/PowerChart.vue";
import BannerSwiper from "@/components/BannerSwiper.vue";
export default {
  name: "Home",
  components: {
    PowerChart,
    BannerSwiper,
  },
};
</script>
<style scoped>
* {
  --boxRadiusValue: 0px;
  --itemBoxShadowColor: rgba(90, 90, 90, 0.25);
  --littleInfoColor: #5aeea6;
  --infoFontSize: 35px;
}
.home {
  box-sizing: border-box;
  padding: 40px;
  display: grid;
  width: 81.3vw;
  height: 100vh;
  /* grid-template-rows: 400px 30px 1fr 20px 1fr; */
  /* grid-template-columns: 967px 30px 472px; */
  /* 42.69% */
  grid-template-rows: 48% 3.2% 1fr 2.1% 1fr;
  grid-template-columns: 65.3% 2% 31.8%;
}

.item_box {
  width: 100%;
  height: 100%;
  border-radius: var(--boxRadiusValue);
  background-color: white;

  box-shadow: 1px 2px 4px 1px var(--itemBoxShadowColor);
  transition: all 0.2s ease-in-out;
}

.item_box:hover:not(#tech_video_area):not(#power_chart_area) {
  transform: scale(1.01, 1.01);
}

/* 影片區域 or Banner */
#tech_video_area {
  grid-row: 1/2;
  grid-column: 1/2;
  transition: all 0.5s ease-in-out;
  animation-name: video_out;
  animation-duration: 1.6s;
  animation-timing-function: ease-in-out;
  /* padding: 15px; */
  /* box-sizing: border-box; */
}

@keyframes video_out {
  0% {
    opacity: 0;
  }
  100% {
    opacity: 100;
  }
}
#tech_video_area .tech_video_area_title {
  width: 100%;
  height: 15%;
  background-color: #b1f8f2;
  display: flex;
  align-items: center;
  justify-content: center;
}

#tech_video_area #bannerSwiperArea {
  width: 100%;
  height: 85%;
  /* padding: 15px; */
  /* box-sizing: border-box; */
}

/* 最近動作 */
#recent_area {
  grid-row: 1/2;
  grid-column: 3/4;
  animation-name: recent_area_in;
  animation-duration: 0.9s;
}
/* 最近動作區塊 標題 */
#recent_area .recent_area_title {
  width: 100%;
  height: 15%;
  display: flex;
  align-items: center;
  justify-content: center;
  background-color: #f97068;
}
/* 最近動作區塊 內容 */
#recent_area .recent_area_main {
  width: 100%;
  height: 85%;
}
@keyframes recent_area_in {
  0% {
    margin-left: 800px;
  }
  100% {
    margin-left: 0;
  }
}

/* 用電圖表 */
#power_chart_area {
  grid-row: 3/6;
  grid-column: 1/2;
  /* padding: 10px; */
  box-sizing: border-box;
  animation-name: power_chart_area_in;
  animation-duration: 2s;
}
#power_chart_area .power_chart_area_title {
  height: 15%;
  width: 100%;
  background-color: #ffe66d;
  display: flex;
  align-items: center;
  justify-content: center;
}
#power_chart_area .power_chart_area_title h1 {
  /* color: rgb(255, 255, 255); */
  /* -webkit-text-stroke: .1px rgb(36, 36, 36); */
  /* text-stroke */
}
#power_chart_area #powerChartArea {
  height: 85%;
  width: 100%;
  padding: 10px;
  box-sizing: border-box;
}
@keyframes power_chart_area_in {
  0% {
    opacity: 0;
  }
  100% {
    opacity: 100;
  }
}
#power_chart_area h1 {
  padding-left: 10px;
}

#little_info_area_1 {
  grid-row: 3/4;
  grid-column: 3/4;
  animation-name: little_info_area_1_in;
  animation-duration: 1s;
}
#little_info_area_1 .little_info_area_1_title {
  display: flex;
  justify-content: center;
  align-items: center;
  width: 100%;
  height: 31%;
  background-color: var(--littleInfoColor);
}
#little_info_area_1 .little_info_area_1_main {
  width: 100%;
  height: 69%;
  display: flex;
  align-items: center;
  justify-content: center;
  font-size: var(--infoFontSize);
}
@keyframes little_info_area_1_in {
  0% {
    margin-left: 800px;
  }
  100% {
    margin-left: 0;
  }
}

#little_info_area_2 {
  grid-row: 5/6;
  grid-column: 3/4;
  animation-name: little_info_area_2_in;
  animation-duration: 1.1s;
}
#little_info_area_2 .little_info_area_2_title {
  display: flex;
  justify-content: center;
  align-items: center;
  width: 100%;
  height: 31%;
  background-color: var(--littleInfoColor);
}
#little_info_area_2 .little_info_area_2_main {
  width: 100%;
  height: 69%;
  display: flex;
  align-items: center;
  justify-content: center;
  font-size: var(--infoFontSize);
}
@keyframes little_info_area_2_in {
  0% {
    margin-left: 800px;
  }
  100% {
    margin-left: 0;
  }
}
.little_info_area_main_left,
.little_info_area_main_right {
  width: 50%;
}
.info_svg_1 {
  /* font-size: 30px; */
  width: 50px;
  height: 50px;
}
.info_svg_2 {
  /* font-size: 30px; */
  width: 45px;
  height: 45px;
}
</style>
