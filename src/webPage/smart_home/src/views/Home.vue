<template>
  <main class="home">
    <div id="tech_video_area" class="item_box">
      <h1>最新消息</h1>
      <div id="bannerSwiperArea">
        <BannerSwiper></BannerSwiper>
      </div>
    </div>
    <!-- 最近動作區塊 -->
    <div id="recent_area" class="item_box"></div>
    <!-- 近五天用電量折線圖條圖區塊 -->
    <div id="power_chart_area" class="item_box">
      <h1>用電情形</h1>
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
      <div class="info_main_text">
        <img
          style="width: 65px; height: 65px"
          src="../assets/note-check.svg"
          class="info_icon"
        />
        <h1 class="info_main_text_title">家具數量</h1>
        <!--    接API取得Value    -->
        <span class="info_sub_text_title">3</span>
      </div>
      <hr />
      <div class="info_sub_text">
        <!--  連結-->
        <span class="three_line"></span>
        <span>詳細資料</span>
      </div>
    </div>
    <div id="little_info_area_2" class="item_box info_area">
      <div class="info_main_text">
        <img
          style="width: 59px; height: 59px"
          src="../assets/flash.png"
          class="info_icon"
        />
        <h1 class="info_main_text_title">使用瓦數</h1>
        <!--    接API取得Value    -->
        <span class="info_sub_text_title">3</span>
      </div>
      <hr />
      <div class="info_sub_text">
        <span>每仟瓦3.52元</span>
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
  box-shadow: 1px 2px 4px 1px rgba(0, 0, 0, 0.25);
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
  padding: 15px;
  box-sizing: border-box;
}

@keyframes video_out {
  0% {
    opacity: 0;
  }
  100% {
    opacity: 100;
  }
}
#tech_video_area #bannerSwiperArea {
  width: 100%;
  height: 87%;
}
#tech_video_area h1 {
  width: 100%;
  height: 13%;
}
/* 最近動作 */
#recent_area {
  grid-row: 1/2;
  grid-column: 3/4;
  animation-name: recent_area_in;
  animation-duration: 0.9s;
}
@keyframes recent_area_in {
  0% {
    margin-left: 800px;
  }
  100% {
    margin-left: 0;
  }
}

#power_chart_area {
  grid-row: 3/6;
  grid-column: 1/2;
  padding: 10px;
  box-sizing: border-box;
  animation-name: power_chart_area_in;
  animation-duration: 2s;
}
#power_chart_area h1 {
  height: 15%;
  width: 100%;
}
#power_chart_area #powerChartArea {
  height: 85%;
  width: 100%;
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
  /* margin-left: 800px; */
  /* animation: recent_area_in 0.8s ease-out 1 1s; */
  animation-name: little_info_area_1_in;
  animation-duration: 1s;
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

@keyframes little_info_area_2_in {
  0% {
    margin-left: 800px;
  }
  100% {
    margin-left: 0;
  }
}

.info_area {
  box-sizing: border-box;
  padding: 10px;
  display: flex;
  flex-direction: column;
}

.info_main_text {
  margin-top: 30px;
  padding-left: 10px;
  padding-right: 30px;
  display: grid;
  grid-template-rows: 0.5fr 0.1fr;
  grid-template-columns: 0.5fr 0.5fr;
  box-sizing: border-box;
}

.info_main_text_title {
  padding-top: 5px;
  margin-left: auto;
}

.info_sub_text_title {
  margin-left: auto;
  padding-bottom: 5px;
  font-size: 40px;
}

.info_icon {
  margin-top: auto;
  margin-bottom: auto;
  grid-column: 1/2;
  grid-row: 1/3;
}

.info_sub_text {
  margin-top: 10px;
  font-size: 30px;
  margin-left: 25px;
}

.info_area hr {
  width: 87.7%;
  /*置中*/
  margin-left: auto;
  margin-right: auto;
}
</style>
