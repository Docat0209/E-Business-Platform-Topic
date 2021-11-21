<template>
  <div class="swiper mySwiper">
    <div class="swiper-wrapper">
      <div class="swiper-slide">
        <img src="https://fakeimg.pl/1000x350/?text=testBanner1" />
      </div>
      <div class="swiper-slide">
        <img src="https://fakeimg.pl/1000x350/?text=testBanner2" />
      </div>
      <div class="swiper-slide">
        <img src="https://fakeimg.pl/1000x350/?text=testBanner3" />
      </div>
      <div class="swiper-slide">
        <img src="https://fakeimg.pl/1000x350/?text=testBanner4" />
      </div>
    </div>
    <div class="swiper-pagination"></div>
    <div class="swiper-button-next swiperButton"></div>
    <div class="swiper-button-prev swiperButton"></div>
  </div>
</template>

<script>
//swiper-bundle.min.css
import Swiper from "swiper/swiper-bundle.min.js";
export default {
  name: "BannerSwiper",
  props: {},
  components: {},
  data() {
    return {};
  },
  mounted() {
    new Swiper(".mySwiper", {
      pagination: {
        el: ".swiper-pagination",
        clickable: true,
      },
      navigation: {
        nextEl: ".swiper-button-next",
        prevEl: ".swiper-button-prev",
      },
      autoplay: {
        //輪播秒數
        delay: 3000,
        disableOnInteraction: false,
      },
      keyboard: {
        //鍵盤切換
        enabled: true,
        onlyInViewport: false,
      },
      mousewheel: {
        //滾輪切換順序
        invert: true,
      },
    });
  },
};
</script>

<style scoped>
/* 引入swiper的css */
@import url("https://unpkg.com/swiper/swiper-bundle.min.css");
.mySwiper {
  width: 100%;
  height: 100%;
}
img {
  object-fit: cover;
}
.swiper-slide {
  text-align: center;
  font-size: 18px;
  background: #fff;
  display: -webkit-box;
  display: -ms-flexbox;
  display: -webkit-flex;
  display: flex;
  -webkit-box-pack: center;
  -ms-flex-pack: center;
  -webkit-justify-content: center;
  justify-content: center;
  -webkit-box-align: center;
  -ms-flex-align: center;
  -webkit-align-items: center;
  align-items: center;
}
.swiperButton{
  width: 50%;
  height: 100%;
  bottom:0;
  top: 0;
}
/* 隱藏箭頭 */
.swiperButton::after{
  content: '';
}
/* .swiper-slide img {
  display: block;
  width: 100%;
  height: 100%;
  object-fit: cover;
} */
</style>