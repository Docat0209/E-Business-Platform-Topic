<template>
  <div id="loading_wrapper">
    <div class="loading_box">
      <div class="lds-ring">
        <div></div>
        <div></div>
        <div></div>
        <div></div>
      </div>
      <span>Loading....</span>
    </div>
  </div>
</template>

<script>
export default {
  name: "Loading",
};
</script>

<style scoped>
/* :root{
  --delayTime : .8s;
} */
*{
  --loading-color : rgb(158, 255, 158);
}
#loading_wrapper {
  position: fixed;
  width: 100%;
  height: 100%;
  z-index: 99999;
  transition: all 0.8s ease-out;
}
span {
  color: var(--loading-color);
  font-size: 20px;
}
.loading_box {
  display: flex;
  justify-content: center;
  align-items: center;
  width: 100%;
  height: 100%;
  transition: all 0.8s ease-out;
  background-color: #0000008f;
}

.loading_box h3 {
  font-size: 5em;
  /* color: white; */
}

.lds-ring {
  display: inline-block;
  position: relative;
  width: 80px;
  height: 80px;
}
.lds-ring div {
  box-sizing: border-box;
  display: block;
  position: absolute;
  width: 54px;
  height: 54px;
  margin: 8px;
  border: 4px solid var(--loading-color);
  border-radius: 50%;
  animation: lds-ring 1.2s cubic-bezier(0.5, 0, 0.5, 1) infinite;
  border-color: var(--loading-color) transparent transparent transparent;
}
.lds-ring div:nth-child(1) {
  animation-delay: -0.45s;
}
.lds-ring div:nth-child(2) {
  animation-delay: -0.3s;
}
.lds-ring div:nth-child(3) {
  animation-delay: -0.15s;
}
@keyframes lds-ring {
  0% {
    transform: rotate(0deg);
  }
  100% {
    transform: rotate(360deg);
  }
}
</style>