<template>
  <div class="canvasArea">
    <canvas id="myChart" :width="canvasWidth" :height="canvasHeight"></canvas>
  </div>
</template>

<script>
import Chart from "chart.js/auto";
export default {
  name: "PowerChart",
  props: {
    canvasWidth: {
      // defualt:
      type: String,
      default: "100px",
    },
    canvasHeight: {
      // defualt:
      type: String,
      default: "100px",
    },
    canvasData: {
      type: Array,
      default: function () {
        return [0, 0, 0, 0, 0];
      },
    },
    canvasDate: {
      type: Array,
      default: function () {
        let dateArray = [];
        let currentDate = new Date();
        for (let i = 1; i < 6; i++) {
          dateArray.push(
            currentDate.getMonth() + 1 + "/" + (currentDate.getDate() - i)
          );
        }
        return dateArray.reverse();
      },
    },
  },
  mounted() {
    var ctx = document.getElementById("myChart").getContext("2d");
    var __this = this;
    new Chart(ctx, {
      type: "line",
      data: {
        labels: __this.canvasDate,
        datasets: [
          {
            data: __this.canvasData,
            backgroundColor: [
              // "rgba(255, 99, 132, 0.2)",
              // "rgba(54, 162, 235, 0.2)",
              // "rgba(255, 206, 86, 0.2)",
              // "rgba(75, 192, 192, 0.2)",
              // "rgba(153, 102, 255, 0.2)",
              // "rgba(255, 159, 64, 0.2)",
            ],
            borderColor: [
              // "yellow"
              // "rgba(255, 99, 132, 1)",
              // "rgba(54, 162, 235, 1)",
              "rgba(255, 206, 86, 1)",
              // "rgba(75, 192, 192, 1)",
              // "rgba(153, 102, 255, 1)",
              // "rgba(255, 159, 64, 1)",
            ],
            borderWidth: 5,
          },
        ],
      },
      options: {
        plugins: {
          legend: {
            display: false,
          },
        },
        layout: {
          padding: {
            // top: 20,
            // bottom: 40,
          },
        },
        scales: {
          y: {
            title: {
              display: true,
              text: "瓦數(W)",
            },
            beginAtZero: true,
          },
          x: {
            title: {
              display: true,
              text: "近五日",
            },
          },
        },
      },
    });
  },
};
</script>

<style scoped>
.canvasArea {
  width: 100%;
  height: 100%;
}
/* #myChart {
  width: 90%;
  height: 90%;
} */
</style>